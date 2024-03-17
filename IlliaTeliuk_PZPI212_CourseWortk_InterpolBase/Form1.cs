using System.Collections.Generic;
namespace IlliaTeliuk_PZPI212_CourseWortk_InterpolBase
{
    public partial class InterpolBase : Form
    {
        public string saves = Environment.CurrentDirectory;
        
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
             
             gangsta.secondName = SecondNameTextBox.Text;
             data.Validation(gangsta.secondName, ref data.isValide, "string");
             
             gangsta.fatherName = FatherNameTextBox.Text;
             data.Validation(gangsta.fatherName, ref data.isValide, "string");
             
             gangsta.nickname = NickNameTextBox.Text;
             data.Validation(gangsta.nickname, ref data.isValide, "neutral");
             
             gangsta.growth = GrowthTextBox.Text;
             data.Validation(gangsta.growth, ref data.isValide, "number");
             
             gangsta.hairColor = HairColorTextBox.Text;
             data.Validation(gangsta.hairColor, ref data.isValide, "string");
            
             gangsta.eyesColor = EyesColorTextBox.Text;
             data.Validation(gangsta.eyesColor, ref data.isValide, "string");
             
             gangsta.specialSigns = SpecialSignsTextBox.Text;
             data.Validation(gangsta.specialSigns, ref data.isValide, "neutral");
             
             gangsta.nationality = NationalityTextBox.Text;
             data.Validation(gangsta.nationality, ref data.isValide, "string");
             
             gangsta.dateBirth = BirthDayDay.Text + "/" + BirthDayMonth.Text + "/" + BirthDayYear.Text;
             data.Validation(gangsta.dateBirth, ref data.isValide, "date");

             gangsta.gang = GangTextBox.Text;
             data.Validation(gangsta.gang, ref data.isValide, "neutral");
             
             gangsta.roleInGang = GangRoleTextBox.Text;
             data.Validation(gangsta.roleInGang, ref data.isValide, "neutral");
            
             gangsta.crime = CrimeTextBox.Text;
             data.Validation(gangsta.crime, ref data.isValide, "neutral");
             
            if (data.isValide) { 
                data.MainBase.Add(gangsta);
                ClearTable();
                LoadTable(data.MainBase);
                data.mode = 0;
                NameTextBox.Clear();
                SecondNameTextBox.Clear();
                FatherNameTextBox.Clear();
                NickNameTextBox.Clear();
                GrowthTextBox.Clear();
                HairColorTextBox.Clear();
                EyesColorTextBox.Clear();
                SpecialSignsTextBox.Clear();
                BirthDayDay.SelectedIndex = -1;
                BirthDayMonth.SelectedIndex = -1;
                BirthDayYear.SelectedIndex = -1;
                NationalityTextBox.Clear();
                GangTextBox.Clear();
                GangRoleTextBox.Clear();
                CrimeTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Певні дані введено некоректно! Спробуйте ще раз!");
                data.isValide = true;
            }
        }
        //Додавання злочинця до ОСНОВНОЇ БАЗИ
         private void BaseButton_Click(object sender, EventArgs e)
         {
             data.mode = 0;
             ChangeButtonColor();
             data.ChangeToBase();
             ClearTable();
             data.Gang.Clear();
             LoadTable(data.MainBase);

         }
        //Перемикання на ОСНОВНУ БАЗУ
        private void ArchiveButton_Click(object sender, EventArgs e)
         {
             data.mode = 1;
             ChangeButtonColor();
             data.ChangeToArchive();
             ClearTable();
             data.Gang.Clear();
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

                 BaseOrArchiveTable.Rows.Add(data.Capitalize(gangstar.secondName), data.Capitalize(gangstar.name), data.Capitalize(gangstar.fatherName), data.Capitalize(gangstar.nickname), gangstar.growth, gangstar.hairColor, gangstar.eyesColor, gangstar.specialSigns, data.Capitalize(gangstar.nationality), gangstar.dateBirth, gangstar.gang, gangstar.roleInGang, gangstar.crime);

             }
          }
        }
        //Додатковий метод для завантаження списку злочинців у таблицю
        private void SearchButton_Click(object sender, EventArgs e)
         {
             data.Search(BaseOrArchiveTable, SearchTextBox, data.mode);
         }
        //Натискання на кнопку пошуку
        private void DiedButton_Click(object sender, EventArgs e)
         {
            try
            {
                if (data.mode == 0) data.MainBase.RemoveAt(data.Died(BaseOrArchiveTable));
                else if (data.mode == 1) data.Archive.RemoveAt(data.Died(BaseOrArchiveTable));
                else MessageBox.Show("У режимі перегляду членів угрупування неможливо редагувати дані таблиці!");
              
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
                if (data.mode == 0)
                {
                    int index = BaseOrArchiveTable.CurrentCell.RowIndex;
                    data.mode = 1;
                    ChangeButtonColor();
                    data.MoveData(data.MainBase, data.Archive, index);
                    ClearTable();
                    LoadTable(data.Archive);
                    data.SelectLastRow(BaseOrArchiveTable);
                    
                }
                else if (data.mode == 1)
                {
                    MessageBox.Show("Злочинець вже знаходиться в архіві!");
                }
                else MessageBox.Show("У режимі перегляду членів угрупування неможливо редагувати дані таблиці!");
                

                
            }
            catch
            {
                ClearTable();
                MessageBox.Show($"Виникла помилка при перенесені злочинця до архіву ! Спробуйте ще раз!");
                data.mode = 1;
                LoadTable(data.Archive);
            }
            
         }
        //Перенесення злочинся до АРХІВУ
        private void MoveToBaseButton_Click(object sender, EventArgs e)
         {

            try
            {
                if (data.mode == 1)
                {
                    int index = BaseOrArchiveTable.CurrentCell.RowIndex;
                    data.mode = 0;
                    ChangeButtonColor();
                    data.MoveData(data.Archive, data.MainBase, index);
                    ClearTable();
                    LoadTable(data.MainBase);
                    data.SelectLastRow(BaseOrArchiveTable);
                }
                else if(data.mode == 0)
                {
                    MessageBox.Show("Злочинець вже знаходиться в основній базі!");
                }
                else MessageBox.Show("У режимі перегляду членів угрупування неможливо редагувати дані таблиці!");
            }
            catch
            {
                ClearTable();
                MessageBox.Show($"Виникла помилка при перенесені злочинця до основної бази! Спробуйте ще раз!");
                data.mode = 0;
                LoadTable(data.MainBase);
            }
        }
        //Перенесення злочинця до ОСНОВНОЇ БАЗИ
        
        public void ChangeButtonColor()
        {
            if (data.mode == 0)
            {
                ArchiveButton.BackColor = Color.Red;
                BaseButton.BackColor = Color.Green;
                ChangedButton.BackColor = Color.Lime;
                NewCrimeButton.BackColor = Color.Gray;
                SearchButton.BackColor = SystemColors.ActiveCaption;
                ChangeButton.BackColor = SystemColors.ActiveCaption;
                DiedButton.BackColor = SystemColors.ButtonShadow;
                GangButton.BackColor = Color.Cyan;
            }
            else if(data.mode == 1)
            {
                ArchiveButton.BackColor = Color.Green;
                BaseButton.BackColor = Color.Blue;
                ChangedButton.BackColor = Color.Gray;
                NewCrimeButton.BackColor = Color.Brown;
                SearchButton.BackColor = SystemColors.ActiveCaption;
                ChangeButton.BackColor = SystemColors.ActiveCaption;
                DiedButton.BackColor = SystemColors.ButtonShadow;
                GangButton.BackColor = Color.Cyan;
            }
            else
            {
                BaseButton.BackColor = Color.Blue;
                ArchiveButton.BackColor = Color.Red;
                ChangedButton.BackColor = Color.Gray;
                NewCrimeButton.BackColor = Color.Gray;
                ChangeButton.BackColor = Color.Gray;
                DiedButton.BackColor = Color.Gray;
                GangButton.BackColor = Color.Green;
            }
        }
        //Зміна кольору кнопки
        
         public void ChangeButton_Click(object sender, EventArgs e)
        {
            try { 
             if (data.mode == 0)
             {
                 ChangeButtonColor();
                 data.ChangeInfo(BaseOrArchiveTable, ChangeTextBox, data.MainBase);
                 ClearTable();
                 LoadTable(data.MainBase);
                 ChangeTextBox.Clear();
            }
             else if(data.mode == 1)
             {
                 ChangeButtonColor();
                 data.ChangeInfo(BaseOrArchiveTable, ChangeTextBox, data.Archive);
                 ClearTable();
                 LoadTable(data.Archive);
                 ChangeTextBox.Clear();
             }
            else MessageBox.Show("У режимі перегляду членів угрупування неможливо редагувати дані таблиці!");
            }
            catch
            {
                MessageBox.Show("Виникла помилка при спробі відредагувати дані таблиці. Перевірте правильність обраних даних!");
            }
        }
        //Кнопка ЗАМІНИТИ
        private void GangButton_Click(object sender, EventArgs e)
        {
            int gangmode = data.mode;
            data.mode = 2;
            ChangeButtonColor();
            data.GangsShow(gangmode, BaseOrArchiveTable, data.MainBase, data.Archive,data.Gang);
            ClearTable();
            LoadTable(data.Gang);
            

        }
         private void SaveButton_Click(object sender, EventArgs e)
         {
            data.SaveData(data.filenamebased, data.filenamearchive, data.based, data.archived, data.MainBase, data.Archive);
            MessageBox.Show("Виконані зміни успішно збережено!");

         }
        //Кнопка ЗБЕРЕГТИ
    }
}