using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlliaTeliuk_PZPI212_CourseWortk_InterpolBase
{
    public class Data
    {
        public bool mode = true;
        public string based;
        public string archived;
        public void Search(DataGridView table, TextBox box)
        {
            int pickedPosition = table.CurrentCell.RowIndex;
            for (int i = 0; i < table.RowCount; i++)
            {
                if (pickedPosition < table.RowCount - 1) pickedPosition++; else pickedPosition = 0;
                for (int j = 0; j < 13; j++)
                {
                    if (table[j, pickedPosition].FormattedValue.ToString().Contains(box.Text.Trim()))
                    {
                        table.CurrentCell = table[0, pickedPosition];
                        box.Clear();
                        return;
                    }
                }
            }
            MessageBox.Show("На жаль, нічого не знайдено");
        }
        //алгоритм пошуку, поки не зовсім коректно працює через регістр
        public void ChangeInfo(DataGridView table, TextBox box, List <Gangstar> list)
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
    }
}
