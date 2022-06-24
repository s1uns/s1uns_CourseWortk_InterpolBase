using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlliaTeliuk_PZPI212_CourseWortk_InterpolBase
{
    public class Data
    {
        public bool mode = true;
        //Перемикач між основною базою та архівом
        public string? based;
        public string? archived;
        //Рядки для запису у форматі json
        public string filenamebased = $@"saves/json/mainbasejson.json";
        public string filenamearchive = $@"saves/json/archivejson.json";
        //Рядки для визначення розташування файлів .json
        public List<Gangstar> MainBase = new List<Gangstar>();
        public List<Gangstar> Archive = new List<Gangstar>();
        //Листи для серіалізації з файлів json та взаємодії із кнопкою банд
        public bool isValide = true;
        //Показник валідності введених даних
        public List<Gangstar> Gang = new List<Gangstar>();
        //Лист для показу усіх членів угрупування
        public void Search(DataGridView table, TextBox box, bool mode)
        {
            if (box.Text.Length == 0) MessageBox.Show("Неможливо здійснити пошук, адже Ви не заповнили поле!");
            else
            {
                int pickedPosition = table.CurrentCell.RowIndex;
                for (int i = 0; i < table.RowCount; i++)
                {
                    if (pickedPosition < table.RowCount - 1) pickedPosition++; else pickedPosition = 0;
                    for (int j = 0; j < 13; j++)
                    {
                        if (table[j, pickedPosition].FormattedValue.ToString().ToUpper().Contains(box.Text.ToUpper()))
                        {
                            table.CurrentCell = table[0, pickedPosition];
                            return;
                        }
                    }
                }
                if (mode) MessageBox.Show("На жаль, в основній базі такої людини не знайдено, перевірте архів");
                else MessageBox.Show("На жаль, в архіві такої людини не знайдено, перевірте основну базу");
            }


        }
        //алгоритм пошуку, поки не зовсім коректно працює через регістр
        public void ChangeInfo(DataGridView table, TextBox box, List<Gangstar> list)
        {
            int row = table.CurrentCell.RowIndex;
            int col = table.CurrentCell.ColumnIndex;
            switch (col)
            {
                case 0: list[row].secondName = box.Text; break;
                case 1: list[row].name = box.Text; break;
                case 2: list[row].fatherName = box.Text; break;
                case 3: list[row].nickname = box.Text; break;
                case 4: list[row].growth = box.Text; break;
                case 5: list[row].hairColor = box.Text; break;
                case 6: list[row].eyesColor = box.Text; break;
                case 7: list[row].specialSigns = box.Text; break;
                case 8: list[row].nationality = box.Text; break;
                case 9: list[row].dateBirth = box.Text; break;
                case 10: list[row].gang = box.Text; break;
                case 11: list[row].roleInGang = box.Text; break;
                case 12: list[row].crime = box.Text; break;
            }
        }
        //алгоритм заміни даних в таблиці
        public int Died(DataGridView table)
        {
            int index = table.CurrentCell.RowIndex;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                table.Rows.RemoveAt(row.Index);

            }
            return index;

        }
        //смерть злочинця
        public void ChangeToBase()
        {
            mode = true;
        }                                                   //перемикач режиму таблиці
        public void ChangeToArchive()
        {
            mode = false;
        }

        public void MoveData(List<Gangstar> list1, List<Gangstar> list2, int i)
        {
            list2.Add(list1[i]);
            list1.RemoveAt(i);
        }

        public void Validation(string a, ref bool isValide, string type)
        {
            switch (type)
            {
                case "neutral":
                    if (string.IsNullOrEmpty(a)) { isValide = false; return; }
                    break;
                case "string":
                    if (a.Length < 2) { isValide = false; return; }
                    else
                    {
                        foreach (char b in a)
                        {
                            if (Char.IsDigit(b)) { isValide = false; return; }
                        }

                    }
                    break;
                case "number":
                    if (string.IsNullOrEmpty(a)) { isValide = false; return; }
                    else if (Convert.ToInt32(a) > 260 || Convert.ToInt32(a) < 50) { isValide = false; return; }
                    else
                    {
                        foreach (char b in a)
                        {
                            if (!Char.IsDigit(b)) { isValide = false; return; }
                        }

                    }
                    break;
                case "date":
                    if (a.Length < 9) { isValide = false; return; }
                    break;
            }
        }
        public string Capitalize(string? a)
        {
            return (char.ToUpper(a[0]) + a.Substring(1));
        }
        public void SelectLastRow(DataGridView table)
        {
            table.ClearSelection();//If you want
            int nRowIndex = table.Rows.Count - 2;
            int nColumnIndex = 12;
            table.Rows[nRowIndex].Selected = true;
            table.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;
            table.CurrentCell = table.Rows[nRowIndex].Cells[0];
            table.FirstDisplayedScrollingRowIndex = nRowIndex;
        }

        public void GangsShow(bool mode, DataGridView table, List<Gangstar> basedlist, List<Gangstar> archivedlist, List<Gangstar> gangslist)
        {
            gangslist.Clear();
            int index = table.CurrentCell.RowIndex;
            string a;
            if (mode) { a = basedlist[index].gang; }
            else { a = archivedlist[index].gang; }
            foreach (Gangstar gangsta in basedlist)
            {
                if (gangsta.gang == a)
                {
                    Gangstar gangstar = new Gangstar(gangsta);
                    gangstar.gang += "(Основна база)";
                    gangslist.Add(gangstar);
                }
            }
            foreach (Gangstar gangsta in archivedlist)
            {
                if (gangsta.gang == a)
                {
                    Gangstar gangstar = new Gangstar(gangsta);
                    gangstar.gang += "(Архів)";
                    gangslist.Add(gangstar);
                }
            }


        }

        //РОБОТА ІЗ JSON

        //Запис рядка у форматі .json
        public void SaveJSonToFile(string filename1, string filename2, string jsonstring1, string jsonstring2)
        {

            Directory.CreateDirectory($@"saves/json");
            File.WriteAllText(filename1, jsonstring1);
            File.WriteAllText(filename2, jsonstring2);

        }
        //Запис рядка у форматі json до файлу у форматі .json
        public void ConvertToList(out List<Gangstar> basedlist, out List<Gangstar> archivedlist, string? filename1, string? filename2)
        {
            basedlist = JsonConvert.DeserializeObject<List<Gangstar>>(File.ReadAllText(filename1));
            archivedlist = JsonConvert.DeserializeObject<List<Gangstar>>(File.ReadAllText(filename2));


        }
        public void ConvertToJSon(out string? jsonstring1, out string? jsonstring2, List<Gangstar> basedlist, List<Gangstar> archivedlist)
        {
            jsonstring1 = JsonConvert.SerializeObject(basedlist);
            jsonstring2 = JsonConvert.SerializeObject(archivedlist);

        }
        public void SaveData(string filename1, string filename2, string? jsonstring1, string? jsonstring2, List<Gangstar> basedlist, List<Gangstar> archivedlist)
        {
            ConvertToJSon(out jsonstring1, out jsonstring2, basedlist, archivedlist);
            SaveJSonToFile(filename1, filename2, jsonstring1, jsonstring2);
        }
    }
}

