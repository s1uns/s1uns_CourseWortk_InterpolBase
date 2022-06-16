
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
            LoadTable(data.MainBase);
            }




        }




         private void AddButton_Click(object sender, EventArgs e)
         {
             Gangstar gangsta = new Gangstar();
             gangsta.name = NameTextBox.Text;
             NameTextBox.Clear();
             gangsta.secondName = SecondNameTextBox.Text;
             SecondNameTextBox.Clear();
             gangsta.fatherName = FatherNameTextBox.Text;
             FatherNameTextBox.Clear();
             gangsta.nickname = NickNameTextBox.Text;
             NickNameTextBox.Clear();
             gangsta.growth = GrowthTextBox.Text;
             GrowthTextBox.Clear();
             gangsta.hairColor = HairColorTextBox.Text;
             HairColorTextBox.Clear();
             gangsta.eyesColor = EyesColorTextBox.Text;
             EyesColorTextBox.Clear();
             gangsta.specialSigns = SpecialSignsTextBox.Text;
             SpecialSignsTextBox.Clear();
             gangsta.nationality = NationalityTextBox.Text;
             NationalityTextBox.Clear();
             gangsta.dateBirth = BirthDayDay.Text + "/" + BirthDayMonth.Text + "/" + BirthDayYear.Text;
             BirthDayDay.SelectedIndex = -1;
             BirthDayMonth.SelectedIndex = -1;
             BirthDayYear.SelectedIndex = -1;
             gangsta.gang = GangTextBox.Text;
             GangTextBox.Clear();
             gangsta.roleInGang = GangRoleTextBox.Text;
             GangRoleTextBox.Clear();
             gangsta.crime = CrimeTextBox.Text;
             CrimeTextBox.Clear();
             data.MainBase.Add(gangsta);
             ClearTable();
             LoadTable(data.MainBase);
             ArchiveButton.BackColor = Color.Red;
             BaseButton.BackColor = Color.Green;
         }
        //Додавання злочинця до ОСНОВНОЇ БАЗИ
         private void BaseButton_Click(object sender, EventArgs e)
         {
             ArchiveButton.BackColor = Color.Red;
             BaseButton.BackColor = Color.Green;
             data.ChangeToBase();
             ClearTable();
             LoadTable(data.MainBase);

         }
        //Перемикання на ОСНОВНУ БАЗУ
        private void ArchiveButton_Click(object sender, EventArgs e)
         {
             BaseButton.BackColor = Color.Blue;
             ArchiveButton.BackColor = Color.Green;
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

             if (data.mode) data.MainBase.RemoveAt(data.Died(BaseOrArchiveTable));
             else data.Archive.RemoveAt(data.Died(BaseOrArchiveTable));
         }
        //Натискання на кнопку смерті
        private void MoveToArchiveButton_Click(object sender, EventArgs e)
         {
             int index = BaseOrArchiveTable.CurrentCell.RowIndex;
             BaseButton.BackColor = Color.Blue;
             ArchiveButton.BackColor = Color.Green;
             data.Archive.Add(data.MainBase[index]);
             data.MainBase.RemoveAt(index);
             ClearTable();
             LoadTable(data.Archive);
         }
        //Перенесення злочинся до АРХІВУ
        private void MoveToBaseButton_Click(object sender, EventArgs e)
         {
             int index = BaseOrArchiveTable.CurrentCell.RowIndex;
             BaseButton.BackColor = Color.Green;
             ArchiveButton.BackColor = Color.Red;
             data.MainBase.Add(data.Archive[index]);
             data.Archive.RemoveAt(index);
             ClearTable();
             LoadTable(data.MainBase);
         }
        //Перенесення злочинця до ОСНОВНОЇ БАЗИ
        
        
         public void ChangeButton_Click(object sender, EventArgs e)
         {
             if (data.mode)
             {
                 ArchiveButton.BackColor = Color.Red;
                 BaseButton.BackColor = Color.Green;
                 data.ChangeInfo(BaseOrArchiveTable, ChangeTextBox, data.MainBase);
                 ClearTable();
                 LoadTable(data.MainBase);
                 ChangeTextBox.Clear();
             }
             else
             {
                 BaseButton.BackColor = Color.Blue;
                 ArchiveButton.BackColor = Color.Green;
                 data.ChangeInfo(BaseOrArchiveTable, ChangeTextBox, data.Archive);
                 ClearTable();
                 LoadTable(data.Archive);
                 ChangeTextBox.Clear();
             }
         }
        //Кнопка ЗАМІНИТИ
         private void SaveButton_Click(object sender, EventArgs e)
         {
             data.ConvertToJSon(out data.based, out data.archived, data.MainBase, data.Archive);
             data.SaveJSonToFile(data.filenamebased, data.filenamearchive, data.based, data.archived);

         }
        //Кнопка ЗБЕРЕГТИ
    }
}