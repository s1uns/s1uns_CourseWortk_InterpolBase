namespace IlliaTeliuk_PZPI212_CourseWortk_InterpolBase
{
    partial class InterpolBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterpolBase));
            this.BaseButton = new System.Windows.Forms.Button();
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.BaseOrArchiveTable = new System.Windows.Forms.DataGridView();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Growth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HairColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EyesColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialSigns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GangRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FatherNameLabel = new System.Windows.Forms.Label();
            this.FatherNameTextBox = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.NickNameTextBox = new System.Windows.Forms.TextBox();
            this.GrowthLabel = new System.Windows.Forms.Label();
            this.GrowthTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.HairColorLabel = new System.Windows.Forms.Label();
            this.HairColorTextBox = new System.Windows.Forms.TextBox();
            this.EyesColorLabel = new System.Windows.Forms.Label();
            this.EyesColorTextBox = new System.Windows.Forms.TextBox();
            this.SpecialSignsLabel = new System.Windows.Forms.Label();
            this.SpecialSignsTextBox = new System.Windows.Forms.TextBox();
            this.NationalityLabel = new System.Windows.Forms.Label();
            this.NationalityTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.GangLabel = new System.Windows.Forms.Label();
            this.GangTextBox = new System.Windows.Forms.TextBox();
            this.BirthDayDay = new System.Windows.Forms.ComboBox();
            this.BirthDayMonth = new System.Windows.Forms.ComboBox();
            this.BirthDayYear = new System.Windows.Forms.ComboBox();
            this.GangRoleLabel = new System.Windows.Forms.Label();
            this.GangRoleTextBox = new System.Windows.Forms.TextBox();
            this.CrimeLabel = new System.Windows.Forms.Label();
            this.CrimeTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.ChangedButton = new System.Windows.Forms.Button();
            this.NewCrimeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DiedButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaseOrArchiveTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseButton
            // 
            this.BaseButton.BackColor = System.Drawing.Color.Green;
            this.BaseButton.Image = ((System.Drawing.Image)(resources.GetObject("BaseButton.Image")));
            this.BaseButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BaseButton.Location = new System.Drawing.Point(1, 1);
            this.BaseButton.Name = "BaseButton";
            this.BaseButton.Size = new System.Drawing.Size(714, 153);
            this.BaseButton.TabIndex = 0;
            this.BaseButton.Text = "ЗАГАЛЬНА БАЗА";
            this.BaseButton.UseVisualStyleBackColor = false;
            this.BaseButton.Click += new System.EventHandler(this.BaseButton_Click);
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.BackColor = System.Drawing.Color.Red;
            this.ArchiveButton.Image = ((System.Drawing.Image)(resources.GetObject("ArchiveButton.Image")));
            this.ArchiveButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ArchiveButton.Location = new System.Drawing.Point(710, 1);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(782, 153);
            this.ArchiveButton.TabIndex = 1;
            this.ArchiveButton.Text = "АРХІВ";
            this.ArchiveButton.UseVisualStyleBackColor = false;
            this.ArchiveButton.Click += new System.EventHandler(this.ArchiveButton_Click);
            // 
            // BaseOrArchiveTable
            // 
            this.BaseOrArchiveTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BaseOrArchiveTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecondName,
            this.ColumnName,
            this.FatherName,
            this.NickName,
            this.Growth,
            this.HairColor,
            this.EyesColor,
            this.SpecialSigns,
            this.Nationality,
            this.DayOfBirth,
            this.Gang,
            this.GangRole,
            this.Crime});
            this.BaseOrArchiveTable.Location = new System.Drawing.Point(1, 151);
            this.BaseOrArchiveTable.Name = "BaseOrArchiveTable";
            this.BaseOrArchiveTable.RowTemplate.Height = 25;
            this.BaseOrArchiveTable.Size = new System.Drawing.Size(1491, 302);
            this.BaseOrArchiveTable.TabIndex = 2;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Прізвище";
            this.SecondName.Name = "SecondName";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Ім\'я";
            this.ColumnName.Name = "ColumnName";
            // 
            // FatherName
            // 
            this.FatherName.HeaderText = "По-батькові";
            this.FatherName.Name = "FatherName";
            // 
            // NickName
            // 
            this.NickName.HeaderText = "Прізвисько";
            this.NickName.Name = "NickName";
            // 
            // Growth
            // 
            this.Growth.HeaderText = "Зріст(см)";
            this.Growth.Name = "Growth";
            this.Growth.Width = 50;
            // 
            // HairColor
            // 
            this.HairColor.HeaderText = "Колір волосся";
            this.HairColor.Name = "HairColor";
            // 
            // EyesColor
            // 
            this.EyesColor.HeaderText = "Колір очей";
            this.EyesColor.Name = "EyesColor";
            // 
            // SpecialSigns
            // 
            this.SpecialSigns.HeaderText = "Особливі прикмети";
            this.SpecialSigns.Name = "SpecialSigns";
            this.SpecialSigns.Width = 200;
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "Громадянство";
            this.Nationality.Name = "Nationality";
            // 
            // DayOfBirth
            // 
            this.DayOfBirth.HeaderText = "Дата народження";
            this.DayOfBirth.Name = "DayOfBirth";
            // 
            // Gang
            // 
            this.Gang.HeaderText = "Угрупування";
            this.Gang.Name = "Gang";
            // 
            // GangRole
            // 
            this.GangRole.HeaderText = "Роль у банді";
            this.GangRole.Name = "GangRole";
            this.GangRole.Width = 200;
            // 
            // Crime
            // 
            this.Crime.HeaderText = "Злочин";
            this.Crime.Name = "Crime";
            this.Crime.Width = 200;
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(36, 469);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(56, 13);
            this.SecondNameLabel.TabIndex = 3;
            this.SecondNameLabel.Text = "Прізвище";
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(93, 466);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondNameTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(64, 492);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(26, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Ім\'я";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(93, 491);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // FatherNameLabel
            // 
            this.FatherNameLabel.AutoSize = true;
            this.FatherNameLabel.Location = new System.Drawing.Point(25, 519);
            this.FatherNameLabel.Name = "FatherNameLabel";
            this.FatherNameLabel.Size = new System.Drawing.Size(67, 13);
            this.FatherNameLabel.TabIndex = 7;
            this.FatherNameLabel.Text = "По-батькові";
            // 
            // FatherNameTextBox
            // 
            this.FatherNameTextBox.Location = new System.Drawing.Point(93, 516);
            this.FatherNameTextBox.Name = "FatherNameTextBox";
            this.FatherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FatherNameTextBox.TabIndex = 8;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Location = new System.Drawing.Point(27, 542);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(65, 13);
            this.NickNameLabel.TabIndex = 9;
            this.NickNameLabel.Text = "Прізвисько";
            // 
            // NickNameTextBox
            // 
            this.NickNameTextBox.Location = new System.Drawing.Point(93, 542);
            this.NickNameTextBox.Name = "NickNameTextBox";
            this.NickNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NickNameTextBox.TabIndex = 10;
            // 
            // GrowthLabel
            // 
            this.GrowthLabel.AutoSize = true;
            this.GrowthLabel.Location = new System.Drawing.Point(36, 571);
            this.GrowthLabel.Name = "GrowthLabel";
            this.GrowthLabel.Size = new System.Drawing.Size(53, 13);
            this.GrowthLabel.TabIndex = 11;
            this.GrowthLabel.Text = "Зріст(см)";
            // 
            // GrowthTextBox
            // 
            this.GrowthTextBox.Location = new System.Drawing.Point(93, 568);
            this.GrowthTextBox.Name = "GrowthTextBox";
            this.GrowthTextBox.Size = new System.Drawing.Size(100, 20);
            this.GrowthTextBox.TabIndex = 12;
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(12, 689);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(147, 56);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HairColorLabel
            // 
            this.HairColorLabel.AutoSize = true;
            this.HairColorLabel.Location = new System.Drawing.Point(8, 601);
            this.HairColorLabel.Name = "HairColorLabel";
            this.HairColorLabel.Size = new System.Drawing.Size(79, 13);
            this.HairColorLabel.TabIndex = 14;
            this.HairColorLabel.Text = "Колір волосся";
            // 
            // HairColorTextBox
            // 
            this.HairColorTextBox.Location = new System.Drawing.Point(93, 598);
            this.HairColorTextBox.Name = "HairColorTextBox";
            this.HairColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.HairColorTextBox.TabIndex = 15;
            // 
            // EyesColorLabel
            // 
            this.EyesColorLabel.AutoSize = true;
            this.EyesColorLabel.Location = new System.Drawing.Point(25, 625);
            this.EyesColorLabel.Name = "EyesColorLabel";
            this.EyesColorLabel.Size = new System.Drawing.Size(60, 13);
            this.EyesColorLabel.TabIndex = 16;
            this.EyesColorLabel.Text = "Колір очей";
            // 
            // EyesColorTextBox
            // 
            this.EyesColorTextBox.Location = new System.Drawing.Point(93, 625);
            this.EyesColorTextBox.Name = "EyesColorTextBox";
            this.EyesColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.EyesColorTextBox.TabIndex = 17;
            // 
            // SpecialSignsLabel
            // 
            this.SpecialSignsLabel.AutoSize = true;
            this.SpecialSignsLabel.Location = new System.Drawing.Point(199, 469);
            this.SpecialSignsLabel.Name = "SpecialSignsLabel";
            this.SpecialSignsLabel.Size = new System.Drawing.Size(105, 13);
            this.SpecialSignsLabel.TabIndex = 18;
            this.SpecialSignsLabel.Text = "Особливі прикмети";
            // 
            // SpecialSignsTextBox
            // 
            this.SpecialSignsTextBox.Location = new System.Drawing.Point(310, 466);
            this.SpecialSignsTextBox.Name = "SpecialSignsTextBox";
            this.SpecialSignsTextBox.Size = new System.Drawing.Size(162, 20);
            this.SpecialSignsTextBox.TabIndex = 19;
            // 
            // NationalityLabel
            // 
            this.NationalityLabel.AutoSize = true;
            this.NationalityLabel.Location = new System.Drawing.Point(224, 494);
            this.NationalityLabel.Name = "NationalityLabel";
            this.NationalityLabel.Size = new System.Drawing.Size(80, 13);
            this.NationalityLabel.TabIndex = 20;
            this.NationalityLabel.Text = "Громадянство";
            // 
            // NationalityTextBox
            // 
            this.NationalityTextBox.Location = new System.Drawing.Point(310, 492);
            this.NationalityTextBox.Name = "NationalityTextBox";
            this.NationalityTextBox.Size = new System.Drawing.Size(100, 20);
            this.NationalityTextBox.TabIndex = 21;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(206, 522);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(98, 13);
            this.DateOfBirthLabel.TabIndex = 22;
            this.DateOfBirthLabel.Text = "Дата народження";
            // 
            // GangLabel
            // 
            this.GangLabel.AutoSize = true;
            this.GangLabel.Location = new System.Drawing.Point(223, 545);
            this.GangLabel.Name = "GangLabel";
            this.GangLabel.Size = new System.Drawing.Size(72, 13);
            this.GangLabel.TabIndex = 24;
            this.GangLabel.Text = "Угрупування";
            // 
            // GangTextBox
            // 
            this.GangTextBox.Location = new System.Drawing.Point(310, 542);
            this.GangTextBox.Name = "GangTextBox";
            this.GangTextBox.Size = new System.Drawing.Size(100, 20);
            this.GangTextBox.TabIndex = 25;
            // 
            // BirthDayDay
            // 
            this.BirthDayDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BirthDayDay.FormattingEnabled = true;
            this.BirthDayDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.BirthDayDay.Location = new System.Drawing.Point(310, 518);
            this.BirthDayDay.Name = "BirthDayDay";
            this.BirthDayDay.Size = new System.Drawing.Size(37, 21);
            this.BirthDayDay.TabIndex = 26;
            // 
            // BirthDayMonth
            // 
            this.BirthDayMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BirthDayMonth.FormattingEnabled = true;
            this.BirthDayMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.BirthDayMonth.Location = new System.Drawing.Point(353, 518);
            this.BirthDayMonth.Name = "BirthDayMonth";
            this.BirthDayMonth.Size = new System.Drawing.Size(35, 21);
            this.BirthDayMonth.TabIndex = 27;
            // 
            // BirthDayYear
            // 
            this.BirthDayYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BirthDayYear.FormattingEnabled = true;
            this.BirthDayYear.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900"});
            this.BirthDayYear.Location = new System.Drawing.Point(394, 519);
            this.BirthDayYear.Name = "BirthDayYear";
            this.BirthDayYear.Size = new System.Drawing.Size(49, 21);
            this.BirthDayYear.TabIndex = 28;
            // 
            // GangRoleLabel
            // 
            this.GangRoleLabel.AutoSize = true;
            this.GangRoleLabel.Location = new System.Drawing.Point(202, 571);
            this.GangRoleLabel.Name = "GangRoleLabel";
            this.GangRoleLabel.Size = new System.Drawing.Size(102, 13);
            this.GangRoleLabel.TabIndex = 29;
            this.GangRoleLabel.Text = "Роль в угрупуванні";
            // 
            // GangRoleTextBox
            // 
            this.GangRoleTextBox.Location = new System.Drawing.Point(310, 568);
            this.GangRoleTextBox.Name = "GangRoleTextBox";
            this.GangRoleTextBox.Size = new System.Drawing.Size(100, 20);
            this.GangRoleTextBox.TabIndex = 30;
            // 
            // CrimeLabel
            // 
            this.CrimeLabel.AutoSize = true;
            this.CrimeLabel.Location = new System.Drawing.Point(252, 598);
            this.CrimeLabel.Name = "CrimeLabel";
            this.CrimeLabel.Size = new System.Drawing.Size(43, 13);
            this.CrimeLabel.TabIndex = 31;
            this.CrimeLabel.Text = "Злочин";
            // 
            // CrimeTextBox
            // 
            this.CrimeTextBox.Location = new System.Drawing.Point(310, 594);
            this.CrimeTextBox.Name = "CrimeTextBox";
            this.CrimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CrimeTextBox.TabIndex = 32;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SearchButton.Location = new System.Drawing.Point(832, 491);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(154, 65);
            this.SearchButton.TabIndex = 33;
            this.SearchButton.Text = "ПОШУК";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(832, 465);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(154, 20);
            this.SearchTextBox.TabIndex = 34;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangeButton.Image")));
            this.ChangeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChangeButton.Location = new System.Drawing.Point(661, 491);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(156, 66);
            this.ChangeButton.TabIndex = 35;
            this.ChangeButton.Text = "ЗАМІНА";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Location = new System.Drawing.Point(661, 467);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.Size = new System.Drawing.Size(156, 20);
            this.ChangeTextBox.TabIndex = 36;
            // 
            // ChangedButton
            // 
            this.ChangedButton.BackColor = System.Drawing.Color.Lime;
            this.ChangedButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangedButton.Image")));
            this.ChangedButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChangedButton.Location = new System.Drawing.Point(661, 572);
            this.ChangedButton.Name = "ChangedButton";
            this.ChangedButton.Size = new System.Drawing.Size(156, 86);
            this.ChangedButton.TabIndex = 37;
            this.ChangedButton.Text = "ВИПРАВИВСЯ";
            this.ChangedButton.UseVisualStyleBackColor = false;
            this.ChangedButton.Click += new System.EventHandler(this.MoveToArchiveButton_Click);
            // 
            // NewCrimeButton
            // 
            this.NewCrimeButton.BackColor = System.Drawing.Color.Brown;
            this.NewCrimeButton.Image = ((System.Drawing.Image)(resources.GetObject("NewCrimeButton.Image")));
            this.NewCrimeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NewCrimeButton.Location = new System.Drawing.Point(823, 572);
            this.NewCrimeButton.Name = "NewCrimeButton";
            this.NewCrimeButton.Size = new System.Drawing.Size(163, 86);
            this.NewCrimeButton.TabIndex = 38;
            this.NewCrimeButton.Text = "ПОВЕРНУВСЯ\r\n           У            \r\nКРИМІНАЛЬНИЙ СВІТ";
            this.NewCrimeButton.UseVisualStyleBackColor = false;
            this.NewCrimeButton.Click += new System.EventHandler(this.MoveToBaseButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Green;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddButton.Location = new System.Drawing.Point(276, 625);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(188, 83);
            this.AddButton.TabIndex = 39;
            this.AddButton.Text = "ДОДАТИ";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DiedButton
            // 
            this.DiedButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DiedButton.Image = ((System.Drawing.Image)(resources.GetObject("DiedButton.Image")));
            this.DiedButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DiedButton.Location = new System.Drawing.Point(1193, 653);
            this.DiedButton.Name = "DiedButton";
            this.DiedButton.Size = new System.Drawing.Size(231, 92);
            this.DiedButton.TabIndex = 40;
            this.DiedButton.Text = "ПОМЕР";
            this.DiedButton.UseVisualStyleBackColor = false;
            this.DiedButton.Click += new System.EventHandler(this.DiedButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1193, 466);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 175);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 675);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 70);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // InterpolBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 757);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DiedButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NewCrimeButton);
            this.Controls.Add(this.ChangedButton);
            this.Controls.Add(this.ChangeTextBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CrimeTextBox);
            this.Controls.Add(this.CrimeLabel);
            this.Controls.Add(this.GangRoleTextBox);
            this.Controls.Add(this.GangRoleLabel);
            this.Controls.Add(this.BirthDayYear);
            this.Controls.Add(this.BirthDayMonth);
            this.Controls.Add(this.BirthDayDay);
            this.Controls.Add(this.GangTextBox);
            this.Controls.Add(this.GangLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.NationalityTextBox);
            this.Controls.Add(this.NationalityLabel);
            this.Controls.Add(this.SpecialSignsTextBox);
            this.Controls.Add(this.SpecialSignsLabel);
            this.Controls.Add(this.EyesColorTextBox);
            this.Controls.Add(this.EyesColorLabel);
            this.Controls.Add(this.HairColorTextBox);
            this.Controls.Add(this.HairColorLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GrowthTextBox);
            this.Controls.Add(this.GrowthLabel);
            this.Controls.Add(this.NickNameTextBox);
            this.Controls.Add(this.NickNameLabel);
            this.Controls.Add(this.FatherNameTextBox);
            this.Controls.Add(this.FatherNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.BaseOrArchiveTable);
            this.Controls.Add(this.ArchiveButton);
            this.Controls.Add(this.BaseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterpolBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довідник Інтерполу by Телюк ПЗПІ-21-2";
            ((System.ComponentModel.ISupportInitialize)(this.BaseOrArchiveTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BaseButton;
        private Button ArchiveButton;
        private DataGridView BaseOrArchiveTable;
        private Label SecondNameLabel;
        private TextBox SecondNameTextBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label FatherNameLabel;
        private TextBox FatherNameTextBox;
        private Label NickNameLabel;
        private TextBox NickNameTextBox;
        private Label GrowthLabel;
        private TextBox GrowthTextBox;
        private Button SaveButton;
        private Label HairColorLabel;
        private TextBox HairColorTextBox;
        private Label EyesColorLabel;
        private TextBox EyesColorTextBox;
        private Label SpecialSignsLabel;
        private TextBox SpecialSignsTextBox;
        private Label NationalityLabel;
        private TextBox NationalityTextBox;
        private Label DateOfBirthLabel;
        private Label GangLabel;
        private TextBox GangTextBox;
        private ComboBox BirthDayDay;
        private ComboBox BirthDayMonth;
        private ComboBox BirthDayYear;
        private Label GangRoleLabel;
        private TextBox GangRoleTextBox;
        private Label CrimeLabel;
        private TextBox CrimeTextBox;
        private Button SearchButton;
        private TextBox SearchTextBox;
        private Button ChangeButton;
        private TextBox ChangeTextBox;
        private Button ChangedButton;
        private Button NewCrimeButton;
        private Button AddButton;
        private Button DiedButton;
        private DataGridViewTextBoxColumn SecondName;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn FatherName;
        private DataGridViewTextBoxColumn NickName;
        private DataGridViewTextBoxColumn Growth;
        private DataGridViewTextBoxColumn HairColor;
        private DataGridViewTextBoxColumn EyesColor;
        private DataGridViewTextBoxColumn SpecialSigns;
        private DataGridViewTextBoxColumn Nationality;
        private DataGridViewTextBoxColumn DayOfBirth;
        private DataGridViewTextBoxColumn Gang;
        private DataGridViewTextBoxColumn GangRole;
        private DataGridViewTextBoxColumn Crime;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}