using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
namespace IlliaTeliuk_PZPI212_CourseWortk_InterpolBase
{
    public partial class InterpolBase : Form
    {
        public string CurDir = Environment.CurrentDirectory;
        List<Gangstar> MainBase = new List<Gangstar>();
        List<Gangstar> Archive = new List<Gangstar>();
        Data data = new Data();
        public string filenamebased = $@"CurDir/json/mainbasejson.json";
        public string filenamearchive = $@"CurDir/json/archivejson.json";
        public InterpolBase()
        {
            InitializeComponent();


            ConvertToList();
            LoadTable(MainBase);




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
             MainBase.Add(gangsta);
             ClearTable();
             LoadTable(MainBase);
             ArchiveButton.BackColor = Color.Red;
             BaseButton.BackColor = Color.Green;
         }

         private void BaseButton_Click(object sender, EventArgs e)
         {
             ArchiveButton.BackColor = Color.Red;
             BaseButton.BackColor = Color.Green;
             data.ChangeToBase();
             ClearTable();
             LoadTable(MainBase);

         }
         private void ArchiveButton_Click(object sender, EventArgs e)
         {
             BaseButton.BackColor = Color.Blue;
             ArchiveButton.BackColor = Color.Green;
             data.ChangeToArchive();
             ClearTable();
             LoadTable(Archive);
         }
         private void ClearTable()
         {
             BaseOrArchiveTable.Rows.Clear();
             BaseOrArchiveTable.Refresh();
         }
         private void LoadTable(List<Gangstar> list)
         {
             foreach (Gangstar gangstar in list)
             {

                 BaseOrArchiveTable.Rows.Add(gangstar.secondName, gangstar.name, gangstar.fatherName, gangstar.nickname, gangstar.growth, gangstar.hairColor, gangstar.eyesColor, gangstar.specialSigns, gangstar.nationality, gangstar.dateBirth, gangstar.gang, gangstar.roleInGang, gangstar.crime);

             }
         }
         private void SearchButton_Click(object sender, EventArgs e)
         {
             data.Search(BaseOrArchiveTable, SearchTextBox);
         }
         private void DiedButton_Click(object sender, EventArgs e)
         {

             if (data.mode) MainBase.RemoveAt(data.Died(BaseOrArchiveTable));
             else Archive.RemoveAt(data.Died(BaseOrArchiveTable));
         }
         private void MoveToArchiveButton_Click(object sender, EventArgs e)
         {
             int index = BaseOrArchiveTable.CurrentCell.RowIndex;
             BaseButton.BackColor = Color.Blue;
             ArchiveButton.BackColor = Color.Green;
             Archive.Add(MainBase[index]);
             MainBase.RemoveAt(index);
             ClearTable();
             LoadTable(Archive);
         }
         private void MoveToBaseButton_Click(object sender, EventArgs e)
         {
             int index = BaseOrArchiveTable.CurrentCell.RowIndex;
             BaseButton.BackColor = Color.Green;
             ArchiveButton.BackColor = Color.Red;
             MainBase.Add(Archive[index]);
             Archive.RemoveAt(index);
             ClearTable();
             LoadTable(MainBase);
         }
         private void ConvertToJSon()
         {
             data.based = JsonConvert.SerializeObject(MainBase);
             data.archived = JsonConvert.SerializeObject(Archive);
         }
         private void SaveJSonToFile()
         {

             Directory.CreateDirectory($@"CurDir/json");
             File.WriteAllText(filenamebased, data.based);
             File.WriteAllText(filenamearchive, data.archived);
         }
         private void ConvertToList()
         {
             MainBase = JsonConvert.DeserializeObject<List<Gangstar>>(File.ReadAllText(filenamebased));
             Archive = JsonConvert.DeserializeObject<List<Gangstar>>(File.ReadAllText(filenamearchive));


         }
         public void ChangeButton_Click(object sender, EventArgs e)
         {
             if (data.mode)
             {
                 ArchiveButton.BackColor = Color.Red;
                 BaseButton.BackColor = Color.Green;
                 data.ChangeInfo(BaseOrArchiveTable, ChangeTextBox, MainBase);
                 ClearTable();
                 LoadTable(MainBase);
                 ChangeTextBox.Clear();
             }
             else
             {
                 BaseButton.BackColor = Color.Blue;
                 ArchiveButton.BackColor = Color.Green;
                 data.ChangeInfo(BaseOrArchiveTable, ChangeTextBox, Archive);
                 ClearTable();
                 LoadTable(Archive);
                 ChangeTextBox.Clear();
             }
         }
         private void SaveButton_Click(object sender, EventArgs e)
         {
             ConvertToJSon();
             SaveJSonToFile();

         }

         private void Form1_Load(object sender, EventArgs e)
         {

         }
    }
}