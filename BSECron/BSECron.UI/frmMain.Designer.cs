namespace BSECron.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnDownloadBSEData = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.lblNotify = new System.Windows.Forms.Label();
            this.grdBseData = new System.Windows.Forms.DataGridView();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.cmbBoxGainers = new System.Windows.Forms.ComboBox();
            this.cmbBoxLosers = new System.Windows.Forms.ComboBox();
            this.grpBoxTopFilters = new System.Windows.Forms.GroupBox();
            this.btnAnalyzeLogic = new System.Windows.Forms.Button();
            this.lblLosers = new System.Windows.Forms.Label();
            this.lblTopGainers = new System.Windows.Forms.Label();
            this.grpBoxOperations = new System.Windows.Forms.GroupBox();
            this.grpDateSelectors = new System.Windows.Forms.GroupBox();
            this.grpSortOrder = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.ddlSortColumns = new System.Windows.Forms.ComboBox();
            this.btnResetData = new System.Windows.Forms.Button();
            this.chrtBseData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trckGraphDuration = new System.Windows.Forms.TrackBar();
            this.btnMarginStocks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBseData)).BeginInit();
            this.grpBoxTopFilters.SuspendLayout();
            this.grpBoxOperations.SuspendLayout();
            this.grpDateSelectors.SuspendLayout();
            this.grpSortOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtBseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckGraphDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // dateToPicker
            // 
            this.dateToPicker.Location = new System.Drawing.Point(156, 102);
            this.dateToPicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(396, 31);
            this.dateToPicker.TabIndex = 6;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(8, 108);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(88, 25);
            this.lblToDate.TabIndex = 7;
            this.lblToDate.Text = "To Date";
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Location = new System.Drawing.Point(156, 36);
            this.dateFromPicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(396, 31);
            this.dateFromPicker.TabIndex = 5;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(8, 42);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(112, 25);
            this.lblFromDate.TabIndex = 8;
            this.lblFromDate.Text = "From Date";
            // 
            // btnDownloadBSEData
            // 
            this.btnDownloadBSEData.Location = new System.Drawing.Point(12, 36);
            this.btnDownloadBSEData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDownloadBSEData.Name = "btnDownloadBSEData";
            this.btnDownloadBSEData.Size = new System.Drawing.Size(232, 103);
            this.btnDownloadBSEData.TabIndex = 10;
            this.btnDownloadBSEData.Text = "Download BSE Data";
            this.btnDownloadBSEData.UseVisualStyleBackColor = true;
            this.btnDownloadBSEData.Click += new System.EventHandler(this.btnDownloadBSEData_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Location = new System.Drawing.Point(256, 36);
            this.btnSaveToDB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(232, 103);
            this.btnSaveToDB.TabIndex = 11;
            this.btnSaveToDB.Text = "Save To DB";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.Location = new System.Drawing.Point(18, 1350);
            this.lblNotify.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(179, 36);
            this.lblNotify.TabIndex = 12;
            this.lblNotify.Text = "Notifications";
            // 
            // grdBseData
            // 
            this.grdBseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBseData.Location = new System.Drawing.Point(24, 227);
            this.grdBseData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdBseData.Name = "grdBseData";
            this.grdBseData.RowHeadersWidth = 62;
            this.grdBseData.Size = new System.Drawing.Size(3022, 575);
            this.grdBseData.TabIndex = 13;
            this.grdBseData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBseData_CellClick);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(500, 36);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(232, 103);
            this.btnExportToExcel.TabIndex = 14;
            this.btnExportToExcel.Text = "Export To Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // cmbBoxGainers
            // 
            this.cmbBoxGainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGainers.FormattingEnabled = true;
            this.cmbBoxGainers.Items.AddRange(new object[] {
            "0",
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
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255",
            "256",
            "257",
            "258",
            "259",
            "260",
            "261",
            "262",
            "263",
            "264",
            "265",
            "266",
            "267",
            "268",
            "269",
            "270",
            "271",
            "272",
            "273",
            "274",
            "275",
            "276",
            "277",
            "278",
            "279",
            "280",
            "281",
            "282",
            "283",
            "284",
            "285",
            "286",
            "287",
            "288",
            "289",
            "290",
            "291",
            "292",
            "293",
            "294",
            "295",
            "296",
            "297",
            "298",
            "299",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "311",
            "312",
            "313",
            "314",
            "315",
            "316",
            "317",
            "318",
            "319",
            "320",
            "321",
            "322",
            "323",
            "324",
            "325",
            "326",
            "327",
            "328",
            "329",
            "330",
            "331",
            "332",
            "333",
            "334",
            "335",
            "336",
            "337",
            "338",
            "339",
            "340",
            "341",
            "342",
            "343",
            "344",
            "345",
            "346",
            "347",
            "348",
            "349",
            "350",
            "351",
            "352",
            "353",
            "354",
            "355",
            "356",
            "357",
            "358",
            "359",
            "360",
            "361",
            "362",
            "363",
            "364",
            "365"});
            this.cmbBoxGainers.Location = new System.Drawing.Point(110, 42);
            this.cmbBoxGainers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbBoxGainers.Name = "cmbBoxGainers";
            this.cmbBoxGainers.Size = new System.Drawing.Size(232, 33);
            this.cmbBoxGainers.TabIndex = 16;
            this.cmbBoxGainers.SelectedIndexChanged += new System.EventHandler(this.cmbBoxGainers_SelectedIndexChanged);
            // 
            // cmbBoxLosers
            // 
            this.cmbBoxLosers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLosers.FormattingEnabled = true;
            this.cmbBoxLosers.Items.AddRange(new object[] {
            "0",
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
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255",
            "256",
            "257",
            "258",
            "259",
            "260",
            "261",
            "262",
            "263",
            "264",
            "265",
            "266",
            "267",
            "268",
            "269",
            "270",
            "271",
            "272",
            "273",
            "274",
            "275",
            "276",
            "277",
            "278",
            "279",
            "280",
            "281",
            "282",
            "283",
            "284",
            "285",
            "286",
            "287",
            "288",
            "289",
            "290",
            "291",
            "292",
            "293",
            "294",
            "295",
            "296",
            "297",
            "298",
            "299",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "311",
            "312",
            "313",
            "314",
            "315",
            "316",
            "317",
            "318",
            "319",
            "320",
            "321",
            "322",
            "323",
            "324",
            "325",
            "326",
            "327",
            "328",
            "329",
            "330",
            "331",
            "332",
            "333",
            "334",
            "335",
            "336",
            "337",
            "338",
            "339",
            "340",
            "341",
            "342",
            "343",
            "344",
            "345",
            "346",
            "347",
            "348",
            "349",
            "350",
            "351",
            "352",
            "353",
            "354",
            "355",
            "356",
            "357",
            "358",
            "359",
            "360",
            "361",
            "362",
            "363",
            "364",
            "365"});
            this.cmbBoxLosers.Location = new System.Drawing.Point(110, 108);
            this.cmbBoxLosers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbBoxLosers.Name = "cmbBoxLosers";
            this.cmbBoxLosers.Size = new System.Drawing.Size(232, 33);
            this.cmbBoxLosers.TabIndex = 17;
            this.cmbBoxLosers.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLosers_SelectedIndexChanged);
            // 
            // grpBoxTopFilters
            // 
            this.grpBoxTopFilters.Controls.Add(this.btnAnalyzeLogic);
            this.grpBoxTopFilters.Controls.Add(this.lblLosers);
            this.grpBoxTopFilters.Controls.Add(this.lblTopGainers);
            this.grpBoxTopFilters.Controls.Add(this.cmbBoxGainers);
            this.grpBoxTopFilters.Controls.Add(this.cmbBoxLosers);
            this.grpBoxTopFilters.Location = new System.Drawing.Point(1370, 23);
            this.grpBoxTopFilters.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpBoxTopFilters.Name = "grpBoxTopFilters";
            this.grpBoxTopFilters.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpBoxTopFilters.Size = new System.Drawing.Size(524, 192);
            this.grpBoxTopFilters.TabIndex = 18;
            this.grpBoxTopFilters.TabStop = false;
            this.grpBoxTopFilters.Text = "TOP CONSISTENT";
            // 
            // btnAnalyzeLogic
            // 
            this.btnAnalyzeLogic.Location = new System.Drawing.Point(376, 36);
            this.btnAnalyzeLogic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAnalyzeLogic.Name = "btnAnalyzeLogic";
            this.btnAnalyzeLogic.Size = new System.Drawing.Size(126, 111);
            this.btnAnalyzeLogic.TabIndex = 20;
            this.btnAnalyzeLogic.Text = "Analyze";
            this.btnAnalyzeLogic.UseVisualStyleBackColor = true;
            this.btnAnalyzeLogic.Click += new System.EventHandler(this.btnAnalyzeLogic_Click);
            // 
            // lblLosers
            // 
            this.lblLosers.AutoSize = true;
            this.lblLosers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosers.Location = new System.Drawing.Point(12, 114);
            this.lblLosers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLosers.Name = "lblLosers";
            this.lblLosers.Size = new System.Drawing.Size(77, 26);
            this.lblLosers.TabIndex = 19;
            this.lblLosers.Text = "Losers";
            // 
            // lblTopGainers
            // 
            this.lblTopGainers.AutoSize = true;
            this.lblTopGainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopGainers.Location = new System.Drawing.Point(12, 48);
            this.lblTopGainers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTopGainers.Name = "lblTopGainers";
            this.lblTopGainers.Size = new System.Drawing.Size(88, 26);
            this.lblTopGainers.TabIndex = 18;
            this.lblTopGainers.Text = "Gainers";
            // 
            // grpBoxOperations
            // 
            this.grpBoxOperations.Controls.Add(this.btnDownloadBSEData);
            this.grpBoxOperations.Controls.Add(this.btnSaveToDB);
            this.grpBoxOperations.Controls.Add(this.btnExportToExcel);
            this.grpBoxOperations.Location = new System.Drawing.Point(608, 23);
            this.grpBoxOperations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpBoxOperations.Name = "grpBoxOperations";
            this.grpBoxOperations.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpBoxOperations.Size = new System.Drawing.Size(750, 192);
            this.grpBoxOperations.TabIndex = 19;
            this.grpBoxOperations.TabStop = false;
            this.grpBoxOperations.Text = "OPERATIONS";
            // 
            // grpDateSelectors
            // 
            this.grpDateSelectors.Controls.Add(this.dateFromPicker);
            this.grpDateSelectors.Controls.Add(this.lblFromDate);
            this.grpDateSelectors.Controls.Add(this.lblToDate);
            this.grpDateSelectors.Controls.Add(this.dateToPicker);
            this.grpDateSelectors.Location = new System.Drawing.Point(22, 23);
            this.grpDateSelectors.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpDateSelectors.Name = "grpDateSelectors";
            this.grpDateSelectors.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpDateSelectors.Size = new System.Drawing.Size(574, 192);
            this.grpDateSelectors.TabIndex = 20;
            this.grpDateSelectors.TabStop = false;
            this.grpDateSelectors.Text = "CHOOSE DATE";
            // 
            // grpSortOrder
            // 
            this.grpSortOrder.Controls.Add(this.btnFilter);
            this.grpSortOrder.Controls.Add(this.txtFilter);
            this.grpSortOrder.Controls.Add(this.ddlSortColumns);
            this.grpSortOrder.Location = new System.Drawing.Point(1926, 23);
            this.grpSortOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpSortOrder.Name = "grpSortOrder";
            this.grpSortOrder.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpSortOrder.Size = new System.Drawing.Size(400, 192);
            this.grpSortOrder.TabIndex = 21;
            this.grpSortOrder.TabStop = false;
            this.grpSortOrder.Text = "FILTER";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(12, 136);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(376, 44);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "OK";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 91);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(372, 31);
            this.txtFilter.TabIndex = 2;
            // 
            // ddlSortColumns
            // 
            this.ddlSortColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSortColumns.FormattingEnabled = true;
            this.ddlSortColumns.Location = new System.Drawing.Point(12, 36);
            this.ddlSortColumns.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ddlSortColumns.Name = "ddlSortColumns";
            this.ddlSortColumns.Size = new System.Drawing.Size(372, 33);
            this.ddlSortColumns.TabIndex = 0;
            this.ddlSortColumns.SelectedIndexChanged += new System.EventHandler(this.ddlSortColumns_SelectedIndexChanged);
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(2896, 1341);
            this.btnResetData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(150, 44);
            this.btnResetData.TabIndex = 4;
            this.btnResetData.Text = "RESET";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // chrtBseData
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtBseData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtBseData.Legends.Add(legend1);
            this.chrtBseData.Location = new System.Drawing.Point(22, 916);
            this.chrtBseData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chrtBseData.Name = "chrtBseData";
            this.chrtBseData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValuesPerPoint = 6;
            this.chrtBseData.Series.Add(series1);
            this.chrtBseData.Size = new System.Drawing.Size(3024, 419);
            this.chrtBseData.TabIndex = 22;
            this.chrtBseData.Text = "chart1";
            // 
            // trckGraphDuration
            // 
            this.trckGraphDuration.Location = new System.Drawing.Point(24, 817);
            this.trckGraphDuration.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trckGraphDuration.Name = "trckGraphDuration";
            this.trckGraphDuration.Size = new System.Drawing.Size(3022, 90);
            this.trckGraphDuration.TabIndex = 23;
            this.trckGraphDuration.Tag = "";
            this.trckGraphDuration.Scroll += new System.EventHandler(this.trckGraphDuration_Scroll);
            // 
            // btnMarginStocks
            // 
            this.btnMarginStocks.Location = new System.Drawing.Point(2358, 47);
            this.btnMarginStocks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMarginStocks.Name = "btnMarginStocks";
            this.btnMarginStocks.Size = new System.Drawing.Size(150, 44);
            this.btnMarginStocks.TabIndex = 24;
            this.btnMarginStocks.Text = "Margin Stocks";
            this.btnMarginStocks.UseVisualStyleBackColor = true;
            this.btnMarginStocks.Click += new System.EventHandler(this.btnMarginStocks_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2826, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 84);
            this.button1.TabIndex = 25;
            this.button1.Text = "Indicators";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2636, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 56);
            this.button2.TabIndex = 26;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3058, 1402);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMarginStocks);
            this.Controls.Add(this.trckGraphDuration);
            this.Controls.Add(this.chrtBseData);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.grpSortOrder);
            this.Controls.Add(this.grpDateSelectors);
            this.Controls.Add(this.grpBoxOperations);
            this.Controls.Add(this.grpBoxTopFilters);
            this.Controls.Add(this.grdBseData);
            this.Controls.Add(this.lblNotify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMain";
            this.Text = "BSECron";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBseData)).EndInit();
            this.grpBoxTopFilters.ResumeLayout(false);
            this.grpBoxTopFilters.PerformLayout();
            this.grpBoxOperations.ResumeLayout(false);
            this.grpDateSelectors.ResumeLayout(false);
            this.grpDateSelectors.PerformLayout();
            this.grpSortOrder.ResumeLayout(false);
            this.grpSortOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtBseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckGraphDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnDownloadBSEData;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.DataGridView grdBseData;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ComboBox cmbBoxGainers;
        private System.Windows.Forms.ComboBox cmbBoxLosers;
        private System.Windows.Forms.GroupBox grpBoxTopFilters;
        private System.Windows.Forms.Label lblLosers;
        private System.Windows.Forms.Label lblTopGainers;
        private System.Windows.Forms.GroupBox grpBoxOperations;
        private System.Windows.Forms.GroupBox grpDateSelectors;
        private System.Windows.Forms.Button btnAnalyzeLogic;
        private System.Windows.Forms.GroupBox grpSortOrder;
        private System.Windows.Forms.ComboBox ddlSortColumns;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtBseData;
        private System.Windows.Forms.TrackBar trckGraphDuration;
        private System.Windows.Forms.Button btnMarginStocks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

