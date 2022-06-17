
using System.Collections.Generic;
namespace IlliaTeliuk_PZPI212_CourseWortk_InterpolBase
{
    public partial class InterpolBase : Form
    {
        public string CurDir = Environment.CurrentDirectory;
        
        Data data = new Data();
        public InterpolBase()
        {
            InitializeComponent();

            if(File.Exists(data.filenamearchive) && File.Exists(data.filenamebased)) { 
            data.ConvertToList(out data.MainBase, out data.Archive, data.filenamebased, data.filenamearchive);
            ChangeButtonColor();
            LoadTable(data.MainBase);
            }
             else
             {
            data.SaveData(data.filenamebased, data.filenamearchive, data.based, data.archived, data.MainBase, data.Archive);

             }



        }




        private void AddButton_Click(object sender, EventArgs e)
         {
             Gangstar gangsta = new Gangstar();
             gangsta.name = NameTextBox.Text;
             data.Validation(gangsta.name, ref data.isValide, "string");
             NameTextBox.Clear();
             gangsta.secondName = SecondNameTextBox.Text;
             data.Validation(gangsta.secondName, ref data.isValide, "string");
             SecondNameTextBox.Clear();
             gangsta.fatherName = FatherNameTextBox.Text;
             data.Validation(gangsta.fatherName, ref data.isValide, "string");
             FatherNameTextBox.Clear();
             gangsta.nickname = NickNameTextBox.Text;
             data.Validation(gangsta.nickname, ref data.isValide, "string");
             NickNameTextBox.Clear();
             gangsta.growth = GrowthTextBox.Text;
             data.Validation(gangsta.growth, ref data.isValide, "number");
             GrowthTextBox.Clear();
             gangsta.hairColor = HairColorTextBox.Text;
             data.Validation(gangsta.hairColor, ref data.isValide, "string");
             HairColorTextBox.Clear();
             gangsta.eyesColor = EyesColorTextBox.Text;
             data.Validation(gangsta.eyesColor, ref data.isValide, "string");
             EyesColorTextBox.Clear();
             gangsta.specialSigns = SpecialSignsTextBox.Text;
             data.Validation(gangsta.specialSigns, ref data.isValide, "string");
             SpecialSignsTextBox.Clear();
             gangsta.nationality = NationalityTextBox.Text;
             data.Validation(gangsta.nationality, ref data.isValide, "string");
             NationalityTextBox.Clear();
             gangsta.dateBirth = BirthDayDay.Text + "/" + BirthDayMonth.Text + "/" + BirthDayYear.Text;
             BirthDayDay.SelectedIndex = -1;
             BirthDayMonth.SelectedIndex = -1;
             BirthDayYear.SelectedIndex = -1;
             gangsta.gang = GangTextBox.Text;
             GangTextBox.Clear();
             gangsta.roleInGang = GangRoleTextBox.Text;
             data.Validation(gangsta.roleInGang, ref data.isValide, "string");
             GangRoleTextBox.Clear();
             gangsta.crime = CrimeTextBox.Text;
             data.Validation(gangsta.crime, ref data.isValide, "string");
             CrimeTextBox.Clear();
            if (data.isValide) { 
             data.MainBase.Add(gangsta);
             ClearTable();
             LoadTable(data.MainBase);
             data.mode = true;
            }
            else
            {
                MessageBox.Show("Певні дані введено некоректно! Спробуйте ще раз!");
            }
        }
        //Додавання злочинця до ОСНОВНОЇ БАЗИ
         private void BaseButton_Click(object sender, EventArgs e)
         {
             data.mode = true;
             ChangeButtonColor();
             data.ChangeToBase();
             ClearTable();
             LoadTable(data.MainBase);

         }
        //Перемикання на ОСНОВНУ БАЗУ
        private void ArchiveButton_Click(object sender, EventArgs e)
         {
             data.mode = false;
             ChangeButtonColor();
             data.ChangeToArchive();
             ClearTable();
             LoadTable(data.Archive);
         }
        //Перемикання на АРХІВ
        private void ClearTable()
         {
             BaseOrArchiveTable.Rows.Clear();
             BaseOrArchiveTable.Refresh();
         }
        //Додатковий метод для очистки сторінки
        private void LoadTable(List<Gangstar> list)
         {    if(list.Count > 0) { 
             foreach (Gangstar gangstar in list)
             {

                 BaseOrArchiveTable.Rows.Add(gangstar.secondName, gangstar.name, gangstar.fatherName, gangstar.nickname, gangstar.growth, gangstar.hairColor, gangstar.eyesColor, gangstar.specialSigns, gangstar.nationality, gangstar.dateBirth, gangstar.gang, gangstar.roleInGang, gangstar.crime);

             }
          }
        }
        //Додатковий метод для завантаження списку злочинців у таблицю
        private void SearchButton_Click(object sender, EventArgs e)
         {
             data.Search(BaseOrArchiveTable, SearchTextBox);
         }
        //Натискання на кнопку пошуку
        private void DiedButton_Click(object sender, EventArgs e)
         {
            try
            {
                if (data.mode) data.MainBase.RemoveAt(data.Died(BaseOrArchiveTable));
                else data.Archive.RemoveAt(data.Died(BaseOrArchiveTable));
            }
            catch {
                MessageBox.Show("Вибачте, трапилась помилка. Перевірте правильність вибору злочинця");
            }
             
         }
        //Натискання на кнопку смерті
        private void MoveToArchiveButton_Click(object sender, EventArgs e)
         {
            try
            {
                if (data.mode) { 
                int index = BaseOrArchiveTable.CurrentCell.RowIndex;
                data.mode = false;
                ChangeButtonColor();
                data.MoveData(data.MainBase, data.Archive, index);
                ClearTable();
                LoadTable(data.Archive);
                }
                else
                {
                    MessageBox.Show("Злочинець вже знаходиться в архіві!");
                }
            }
            catch
            {
                MessageBox.Show("Злочинець вже знаходиться в архіві!");
            }
            
         }
        //Перенесення злочинся до АРХІВУ
        private void MoveToBaseButton_Click(object sender, EventArgs e)
         {

            try
            {
                if (!data.mode)
                {
                    int index = BaseOrArchiveTable.CurrentCell.RowIndex;
                    data.mode = true;
                    ChangeButtonColor();
                    data.MoveData(data.Archive, data.MainBase, index);
                    ClearTable();
                    LoadTable(data.MainBase);
                }
                else
                {
                    MessageBox.Show("Злочинець вже знаходиться в основній базі!");
                }
            }
            catch
            {
                MessageBox.Show("Злочинець вже знаходиться в основній базі!");
            }
        }
        //Перенесення злочинця до ОСНОВНОЇ БАЗИ
        
        public void ChangeButtonColor()
        {
            if (data.mode)
            {
                ArchiveButton.BackColor = Color.Red;
                BaseButton.BackColor = Color.Green;
                ChangedButton.BackColor = Color.Lime;
                NewCrimeButton.BackColor = Color.Gray;
            }
            else
            {
                ArchiveButton.BackColor = Color.Green;
                BaseButton.BackColor = Color.Blue;
                ChangedButton.BackColor = Color.Gray;
                NewCrimeButton.BackColor = Color.Brown;
            }
        }
        
         public void ChangeButton_Click(object sender, EventArgs e)
         {
             if (data.mode)
             {
                 ChangeButtonColor();
                 data.ChangeInfo(BaseOrArchiveTable, ChangeTextBox, data.MainBase);
                 ClearTable();
                 LoadTable(data.MainBase);
                 ChangeTextBox.Clear();
             }
             else
             {
                 ChangeButtonColor();
                 data.ChangeInfo(BaseOrArchiveTable, ChangeTextBox, data.Archive);
                 ClearTable();
                 LoadTable(data.Archive);
                 ChangeTextBox.Clear();
             }
         }
        //Кнопка ЗАМІНИТИ
         private void SaveButton_Click(object sender, EventArgs e)
         {
            data.SaveData(data.filenamebased, data.filenamearchive, data.based, data.archived, data.MainBase, data.Archive);

         }
        //Кнопка ЗБЕРЕГТИ
    }
}