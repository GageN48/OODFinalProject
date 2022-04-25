
namespace ProjectV2
{
    partial class Form1
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
            this.gbLeague = new System.Windows.Forms.GroupBox();
            this.radWNBA = new System.Windows.Forms.RadioButton();
            this.radNBA = new System.Windows.Forms.RadioButton();
            this.radPitchers = new System.Windows.Forms.RadioButton();
            this.radHitters = new System.Windows.Forms.RadioButton();
            this.gbNLorAL = new System.Windows.Forms.GroupBox();
            this.radNL = new System.Windows.Forms.RadioButton();
            this.radAL = new System.Windows.Forms.RadioButton();
            this.radMLB = new System.Windows.Forms.RadioButton();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rtbLabels = new System.Windows.Forms.RichTextBox();
            this.gbDivisionsNBA = new System.Windows.Forms.GroupBox();
            this.radSouthwest = new System.Windows.Forms.RadioButton();
            this.radPacific = new System.Windows.Forms.RadioButton();
            this.radNorthwest = new System.Windows.Forms.RadioButton();
            this.radAllDivisionsNBA = new System.Windows.Forms.RadioButton();
            this.radCentralNBA = new System.Windows.Forms.RadioButton();
            this.radSoutheast = new System.Windows.Forms.RadioButton();
            this.radAtlantic = new System.Windows.Forms.RadioButton();
            this.gbNBAbasic = new System.Windows.Forms.GroupBox();
            this.cbPoints = new System.Windows.Forms.CheckBox();
            this.cbFTA = new System.Windows.Forms.CheckBox();
            this.cbTO = new System.Windows.Forms.CheckBox();
            this.cbFTM = new System.Windows.Forms.CheckBox();
            this.cbSteals = new System.Windows.Forms.CheckBox();
            this.cb3PM = new System.Windows.Forms.CheckBox();
            this.cbBlocks = new System.Windows.Forms.CheckBox();
            this.cbFGattempts = new System.Windows.Forms.CheckBox();
            this.cbAssists = new System.Windows.Forms.CheckBox();
            this.cb3PA = new System.Windows.Forms.CheckBox();
            this.cbDB = new System.Windows.Forms.CheckBox();
            this.cbFGmakes = new System.Windows.Forms.CheckBox();
            this.cbOB = new System.Windows.Forms.CheckBox();
            this.cbMinutes = new System.Windows.Forms.CheckBox();
            this.cbGamesPlayed = new System.Windows.Forms.CheckBox();
            this.gbNBAadvanced = new System.Windows.Forms.GroupBox();
            this.lbNBATeams = new System.Windows.Forms.ListBox();
            this.lbNBApositions = new System.Windows.Forms.ListBox();
            this.gbConferences = new System.Windows.Forms.GroupBox();
            this.radEastNBA = new System.Windows.Forms.RadioButton();
            this.radWestNBA = new System.Windows.Forms.RadioButton();
            this.radConferences = new System.Windows.Forms.RadioButton();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbMPG = new System.Windows.Forms.CheckBox();
            this.cbFGP = new System.Windows.Forms.CheckBox();
            this.cb3PP = new System.Windows.Forms.CheckBox();
            this.cbFTP = new System.Windows.Forms.CheckBox();
            this.cbTS = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.cbREBPG = new System.Windows.Forms.CheckBox();
            this.cbASTSPG = new System.Windows.Forms.CheckBox();
            this.cbBLKPG = new System.Windows.Forms.CheckBox();
            this.cbSTLPG = new System.Windows.Forms.CheckBox();
            this.cbSHEFF = new System.Windows.Forms.CheckBox();
            this.cbSCEFF = new System.Windows.Forms.CheckBox();
            this.cbPIE = new System.Windows.Forms.CheckBox();
            this.cbTOPG = new System.Windows.Forms.CheckBox();
            this.gbLeague.SuspendLayout();
            this.gbNLorAL.SuspendLayout();
            this.gbDivisionsNBA.SuspendLayout();
            this.gbNBAbasic.SuspendLayout();
            this.gbNBAadvanced.SuspendLayout();
            this.gbConferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLeague
            // 
            this.gbLeague.Controls.Add(this.radWNBA);
            this.gbLeague.Controls.Add(this.radNBA);
            this.gbLeague.Controls.Add(this.radPitchers);
            this.gbLeague.Controls.Add(this.radHitters);
            this.gbLeague.Controls.Add(this.gbNLorAL);
            this.gbLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbLeague.Location = new System.Drawing.Point(12, 21);
            this.gbLeague.Name = "gbLeague";
            this.gbLeague.Size = new System.Drawing.Size(191, 171);
            this.gbLeague.TabIndex = 3;
            this.gbLeague.TabStop = false;
            this.gbLeague.Text = "League";
            // 
            // radWNBA
            // 
            this.radWNBA.AutoSize = true;
            this.radWNBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radWNBA.Location = new System.Drawing.Point(6, 134);
            this.radWNBA.Name = "radWNBA";
            this.radWNBA.Size = new System.Drawing.Size(94, 29);
            this.radWNBA.TabIndex = 4;
            this.radWNBA.Text = "WNBA";
            this.radWNBA.UseVisualStyleBackColor = true;
            // 
            // radNBA
            // 
            this.radNBA.AutoSize = true;
            this.radNBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radNBA.Location = new System.Drawing.Point(6, 99);
            this.radNBA.Name = "radNBA";
            this.radNBA.Size = new System.Drawing.Size(74, 29);
            this.radNBA.TabIndex = 3;
            this.radNBA.Text = "NBA";
            this.radNBA.UseVisualStyleBackColor = true;
            this.radNBA.CheckedChanged += new System.EventHandler(this.radNBA_CheckedChanged);
            // 
            // radPitchers
            // 
            this.radPitchers.AutoSize = true;
            this.radPitchers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radPitchers.Location = new System.Drawing.Point(6, 64);
            this.radPitchers.Name = "radPitchers";
            this.radPitchers.Size = new System.Drawing.Size(163, 29);
            this.radPitchers.TabIndex = 2;
            this.radPitchers.Text = "Pitchers (MLB)";
            this.radPitchers.UseVisualStyleBackColor = true;
            // 
            // radHitters
            // 
            this.radHitters.AutoSize = true;
            this.radHitters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radHitters.Location = new System.Drawing.Point(6, 29);
            this.radHitters.Name = "radHitters";
            this.radHitters.Size = new System.Drawing.Size(148, 29);
            this.radHitters.TabIndex = 1;
            this.radHitters.Text = "Hitters (MLB)";
            this.radHitters.UseVisualStyleBackColor = true;
            // 
            // gbNLorAL
            // 
            this.gbNLorAL.Controls.Add(this.radNL);
            this.gbNLorAL.Controls.Add(this.radAL);
            this.gbNLorAL.Controls.Add(this.radMLB);
            this.gbNLorAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbNLorAL.Location = new System.Drawing.Point(187, 0);
            this.gbNLorAL.Name = "gbNLorAL";
            this.gbNLorAL.Size = new System.Drawing.Size(209, 80);
            this.gbNLorAL.TabIndex = 17;
            this.gbNLorAL.TabStop = false;
            this.gbNLorAL.Text = "Leagues";
            this.gbNLorAL.Visible = false;
            // 
            // radNL
            // 
            this.radNL.AutoSize = true;
            this.radNL.Location = new System.Drawing.Point(63, 51);
            this.radNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNL.Name = "radNL";
            this.radNL.Size = new System.Drawing.Size(58, 29);
            this.radNL.TabIndex = 2;
            this.radNL.TabStop = true;
            this.radNL.Text = "NL";
            this.radNL.UseVisualStyleBackColor = true;
            // 
            // radAL
            // 
            this.radAL.AutoSize = true;
            this.radAL.Location = new System.Drawing.Point(6, 52);
            this.radAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radAL.Name = "radAL";
            this.radAL.Size = new System.Drawing.Size(58, 29);
            this.radAL.TabIndex = 1;
            this.radAL.TabStop = true;
            this.radAL.Text = "AL";
            this.radAL.UseVisualStyleBackColor = true;
            // 
            // radMLB
            // 
            this.radMLB.AutoSize = true;
            this.radMLB.Checked = true;
            this.radMLB.Location = new System.Drawing.Point(6, 24);
            this.radMLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMLB.Name = "radMLB";
            this.radMLB.Size = new System.Drawing.Size(136, 29);
            this.radMLB.TabIndex = 0;
            this.radMLB.TabStop = true;
            this.radMLB.Text = "All Leagues";
            this.radMLB.UseVisualStyleBackColor = true;
            // 
            // btnDictionary
            // 
            this.btnDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDictionary.Location = new System.Drawing.Point(12, 198);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(190, 39);
            this.btnDictionary.TabIndex = 13;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(12, 243);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1129, 30);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rtbLabels
            // 
            this.rtbLabels.AcceptsTab = true;
            this.rtbLabels.Font = new System.Drawing.Font("Courier New", 12F);
            this.rtbLabels.Location = new System.Drawing.Point(0, 279);
            this.rtbLabels.Name = "rtbLabels";
            this.rtbLabels.ReadOnly = true;
            this.rtbLabels.Size = new System.Drawing.Size(1412, 30);
            this.rtbLabels.TabIndex = 16;
            this.rtbLabels.Text = "";
            // 
            // gbDivisionsNBA
            // 
            this.gbDivisionsNBA.Controls.Add(this.radSouthwest);
            this.gbDivisionsNBA.Controls.Add(this.radPacific);
            this.gbDivisionsNBA.Controls.Add(this.radNorthwest);
            this.gbDivisionsNBA.Controls.Add(this.radAllDivisionsNBA);
            this.gbDivisionsNBA.Controls.Add(this.radCentralNBA);
            this.gbDivisionsNBA.Controls.Add(this.radSoutheast);
            this.gbDivisionsNBA.Controls.Add(this.radAtlantic);
            this.gbDivisionsNBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbDivisionsNBA.Location = new System.Drawing.Point(209, 99);
            this.gbDivisionsNBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDivisionsNBA.Name = "gbDivisionsNBA";
            this.gbDivisionsNBA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDivisionsNBA.Size = new System.Drawing.Size(321, 136);
            this.gbDivisionsNBA.TabIndex = 18;
            this.gbDivisionsNBA.TabStop = false;
            this.gbDivisionsNBA.Text = "Divisions";
            this.gbDivisionsNBA.Visible = false;
            // 
            // radSouthwest
            // 
            this.radSouthwest.AutoSize = true;
            this.radSouthwest.Location = new System.Drawing.Point(122, 109);
            this.radSouthwest.Name = "radSouthwest";
            this.radSouthwest.Size = new System.Drawing.Size(125, 29);
            this.radSouthwest.TabIndex = 6;
            this.radSouthwest.TabStop = true;
            this.radSouthwest.Text = "Southwest";
            this.radSouthwest.UseVisualStyleBackColor = true;
            // 
            // radPacific
            // 
            this.radPacific.AutoSize = true;
            this.radPacific.Location = new System.Drawing.Point(5, 107);
            this.radPacific.Name = "radPacific";
            this.radPacific.Size = new System.Drawing.Size(90, 29);
            this.radPacific.TabIndex = 5;
            this.radPacific.TabStop = true;
            this.radPacific.Text = "Pacific";
            this.radPacific.UseVisualStyleBackColor = true;
            // 
            // radNorthwest
            // 
            this.radNorthwest.AutoSize = true;
            this.radNorthwest.Location = new System.Drawing.Point(123, 82);
            this.radNorthwest.Name = "radNorthwest";
            this.radNorthwest.Size = new System.Drawing.Size(120, 29);
            this.radNorthwest.TabIndex = 4;
            this.radNorthwest.TabStop = true;
            this.radNorthwest.Text = "Northwest";
            this.radNorthwest.UseVisualStyleBackColor = true;
            // 
            // radAllDivisionsNBA
            // 
            this.radAllDivisionsNBA.AutoSize = true;
            this.radAllDivisionsNBA.Checked = true;
            this.radAllDivisionsNBA.Location = new System.Drawing.Point(5, 25);
            this.radAllDivisionsNBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radAllDivisionsNBA.Name = "radAllDivisionsNBA";
            this.radAllDivisionsNBA.Size = new System.Drawing.Size(138, 29);
            this.radAllDivisionsNBA.TabIndex = 3;
            this.radAllDivisionsNBA.TabStop = true;
            this.radAllDivisionsNBA.Text = "All Divisions";
            this.radAllDivisionsNBA.UseVisualStyleBackColor = true;
            // 
            // radCentralNBA
            // 
            this.radCentralNBA.AutoSize = true;
            this.radCentralNBA.Location = new System.Drawing.Point(122, 53);
            this.radCentralNBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCentralNBA.Name = "radCentralNBA";
            this.radCentralNBA.Size = new System.Drawing.Size(96, 29);
            this.radCentralNBA.TabIndex = 2;
            this.radCentralNBA.Text = "Central";
            this.radCentralNBA.UseVisualStyleBackColor = true;
            // 
            // radSoutheast
            // 
            this.radSoutheast.AutoSize = true;
            this.radSoutheast.Location = new System.Drawing.Point(5, 81);
            this.radSoutheast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSoutheast.Name = "radSoutheast";
            this.radSoutheast.Size = new System.Drawing.Size(122, 29);
            this.radSoutheast.TabIndex = 1;
            this.radSoutheast.Text = "Southeast";
            this.radSoutheast.UseVisualStyleBackColor = true;
            // 
            // radAtlantic
            // 
            this.radAtlantic.AutoSize = true;
            this.radAtlantic.Location = new System.Drawing.Point(5, 53);
            this.radAtlantic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radAtlantic.Name = "radAtlantic";
            this.radAtlantic.Size = new System.Drawing.Size(97, 29);
            this.radAtlantic.TabIndex = 0;
            this.radAtlantic.Text = "Atlantic";
            this.radAtlantic.UseVisualStyleBackColor = true;
            // 
            // gbNBAbasic
            // 
            this.gbNBAbasic.Controls.Add(this.cbPoints);
            this.gbNBAbasic.Controls.Add(this.cbFTA);
            this.gbNBAbasic.Controls.Add(this.cbTO);
            this.gbNBAbasic.Controls.Add(this.cbFTM);
            this.gbNBAbasic.Controls.Add(this.cbSteals);
            this.gbNBAbasic.Controls.Add(this.cb3PM);
            this.gbNBAbasic.Controls.Add(this.cbBlocks);
            this.gbNBAbasic.Controls.Add(this.cbFGattempts);
            this.gbNBAbasic.Controls.Add(this.cbAssists);
            this.gbNBAbasic.Controls.Add(this.cb3PA);
            this.gbNBAbasic.Controls.Add(this.cbDB);
            this.gbNBAbasic.Controls.Add(this.cbFGmakes);
            this.gbNBAbasic.Controls.Add(this.cbOB);
            this.gbNBAbasic.Controls.Add(this.cbMinutes);
            this.gbNBAbasic.Controls.Add(this.cbGamesPlayed);
            this.gbNBAbasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbNBAbasic.Location = new System.Drawing.Point(536, 21);
            this.gbNBAbasic.Name = "gbNBAbasic";
            this.gbNBAbasic.Size = new System.Drawing.Size(289, 216);
            this.gbNBAbasic.TabIndex = 19;
            this.gbNBAbasic.TabStop = false;
            this.gbNBAbasic.Text = "Basic Statistics";
            this.gbNBAbasic.Visible = false;
            // 
            // cbPoints
            // 
            this.cbPoints.AutoSize = true;
            this.cbPoints.Location = new System.Drawing.Point(165, 131);
            this.cbPoints.Name = "cbPoints";
            this.cbPoints.Size = new System.Drawing.Size(74, 29);
            this.cbPoints.TabIndex = 33;
            this.cbPoints.Text = "PTS";
            this.cbPoints.UseVisualStyleBackColor = true;
            // 
            // cbFTA
            // 
            this.cbFTA.AutoSize = true;
            this.cbFTA.Location = new System.Drawing.Point(84, 75);
            this.cbFTA.Name = "cbFTA";
            this.cbFTA.Size = new System.Drawing.Size(73, 29);
            this.cbFTA.TabIndex = 30;
            this.cbFTA.Text = "FTA";
            this.cbFTA.UseVisualStyleBackColor = true;
            // 
            // cbTO
            // 
            this.cbTO.AutoSize = true;
            this.cbTO.Location = new System.Drawing.Point(84, 131);
            this.cbTO.Name = "cbTO";
            this.cbTO.Size = new System.Drawing.Size(63, 29);
            this.cbTO.TabIndex = 32;
            this.cbTO.Text = "TO";
            this.cbTO.UseVisualStyleBackColor = true;
            // 
            // cbFTM
            // 
            this.cbFTM.AutoSize = true;
            this.cbFTM.Location = new System.Drawing.Point(3, 78);
            this.cbFTM.Name = "cbFTM";
            this.cbFTM.Size = new System.Drawing.Size(76, 29);
            this.cbFTM.TabIndex = 29;
            this.cbFTM.Text = "FTM";
            this.cbFTM.UseVisualStyleBackColor = true;
            // 
            // cbSteals
            // 
            this.cbSteals.AutoSize = true;
            this.cbSteals.Location = new System.Drawing.Point(3, 131);
            this.cbSteals.Name = "cbSteals";
            this.cbSteals.Size = new System.Drawing.Size(72, 29);
            this.cbSteals.TabIndex = 31;
            this.cbSteals.Text = "STL";
            this.cbSteals.UseVisualStyleBackColor = true;
            // 
            // cb3PM
            // 
            this.cb3PM.AutoSize = true;
            this.cb3PM.Location = new System.Drawing.Point(84, 51);
            this.cb3PM.Name = "cb3PM";
            this.cb3PM.Size = new System.Drawing.Size(75, 29);
            this.cb3PM.TabIndex = 28;
            this.cb3PM.Text = "3PM";
            this.cb3PM.UseVisualStyleBackColor = true;
            // 
            // cbBlocks
            // 
            this.cbBlocks.AutoSize = true;
            this.cbBlocks.Location = new System.Drawing.Point(165, 103);
            this.cbBlocks.Name = "cbBlocks";
            this.cbBlocks.Size = new System.Drawing.Size(72, 29);
            this.cbBlocks.TabIndex = 30;
            this.cbBlocks.Text = "BLK";
            this.cbBlocks.UseVisualStyleBackColor = true;
            // 
            // cbFGattempts
            // 
            this.cbFGattempts.AutoSize = true;
            this.cbFGattempts.Location = new System.Drawing.Point(3, 54);
            this.cbFGattempts.Name = "cbFGattempts";
            this.cbFGattempts.Size = new System.Drawing.Size(75, 29);
            this.cbFGattempts.TabIndex = 27;
            this.cbFGattempts.Text = "FGA";
            this.cbFGattempts.UseVisualStyleBackColor = true;
            // 
            // cbAssists
            // 
            this.cbAssists.AutoSize = true;
            this.cbAssists.Location = new System.Drawing.Point(84, 103);
            this.cbAssists.Name = "cbAssists";
            this.cbAssists.Size = new System.Drawing.Size(75, 29);
            this.cbAssists.TabIndex = 29;
            this.cbAssists.Text = "AST";
            this.cbAssists.UseVisualStyleBackColor = true;
            // 
            // cb3PA
            // 
            this.cb3PA.AutoSize = true;
            this.cb3PA.Location = new System.Drawing.Point(165, 51);
            this.cb3PA.Name = "cb3PA";
            this.cb3PA.Size = new System.Drawing.Size(72, 29);
            this.cb3PA.TabIndex = 27;
            this.cb3PA.Text = "3PA";
            this.cb3PA.UseVisualStyleBackColor = true;
            // 
            // cbDB
            // 
            this.cbDB.AutoSize = true;
            this.cbDB.Location = new System.Drawing.Point(3, 104);
            this.cbDB.Name = "cbDB";
            this.cbDB.Size = new System.Drawing.Size(61, 29);
            this.cbDB.TabIndex = 28;
            this.cbDB.Text = "DR";
            this.cbDB.UseVisualStyleBackColor = true;
            // 
            // cbFGmakes
            // 
            this.cbFGmakes.AutoSize = true;
            this.cbFGmakes.Location = new System.Drawing.Point(165, 24);
            this.cbFGmakes.Name = "cbFGmakes";
            this.cbFGmakes.Size = new System.Drawing.Size(78, 29);
            this.cbFGmakes.TabIndex = 2;
            this.cbFGmakes.Text = "FGM";
            this.cbFGmakes.UseVisualStyleBackColor = true;
            // 
            // cbOB
            // 
            this.cbOB.AutoSize = true;
            this.cbOB.Location = new System.Drawing.Point(165, 78);
            this.cbOB.Name = "cbOB";
            this.cbOB.Size = new System.Drawing.Size(63, 29);
            this.cbOB.TabIndex = 27;
            this.cbOB.Text = "OR";
            this.cbOB.UseVisualStyleBackColor = true;
            // 
            // cbMinutes
            // 
            this.cbMinutes.AutoSize = true;
            this.cbMinutes.Location = new System.Drawing.Point(84, 26);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(70, 29);
            this.cbMinutes.TabIndex = 1;
            this.cbMinutes.Text = "MIN";
            this.cbMinutes.UseVisualStyleBackColor = true;
            // 
            // cbGamesPlayed
            // 
            this.cbGamesPlayed.AutoSize = true;
            this.cbGamesPlayed.Location = new System.Drawing.Point(3, 30);
            this.cbGamesPlayed.Name = "cbGamesPlayed";
            this.cbGamesPlayed.Size = new System.Drawing.Size(62, 29);
            this.cbGamesPlayed.TabIndex = 0;
            this.cbGamesPlayed.Text = "GP";
            this.cbGamesPlayed.UseVisualStyleBackColor = true;
            // 
            // gbNBAadvanced
            // 
            this.gbNBAadvanced.Controls.Add(this.cbSHEFF);
            this.gbNBAadvanced.Controls.Add(this.cbSCEFF);
            this.gbNBAadvanced.Controls.Add(this.cbPIE);
            this.gbNBAadvanced.Controls.Add(this.cbTOPG);
            this.gbNBAadvanced.Controls.Add(this.cbSTLPG);
            this.gbNBAadvanced.Controls.Add(this.cbMPG);
            this.gbNBAadvanced.Controls.Add(this.cbBLKPG);
            this.gbNBAadvanced.Controls.Add(this.cbFGP);
            this.gbNBAadvanced.Controls.Add(this.cbASTSPG);
            this.gbNBAadvanced.Controls.Add(this.cb3PP);
            this.gbNBAadvanced.Controls.Add(this.cbREBPG);
            this.gbNBAadvanced.Controls.Add(this.cbFTP);
            this.gbNBAadvanced.Controls.Add(this.checkBox6);
            this.gbNBAadvanced.Controls.Add(this.cbTS);
            this.gbNBAadvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbNBAadvanced.Location = new System.Drawing.Point(831, 21);
            this.gbNBAadvanced.Name = "gbNBAadvanced";
            this.gbNBAadvanced.Size = new System.Drawing.Size(246, 216);
            this.gbNBAadvanced.TabIndex = 20;
            this.gbNBAadvanced.TabStop = false;
            this.gbNBAadvanced.Text = "Advanced Statistics";
            this.gbNBAadvanced.Visible = false;
            // 
            // lbNBATeams
            // 
            this.lbNBATeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNBATeams.FormattingEnabled = true;
            this.lbNBATeams.ItemHeight = 25;
            this.lbNBATeams.Items.AddRange(new object[] {
            "All Teams",
            "Atlanta Hawks",
            "Boston Celtics",
            "Brooklyn Nets",
            "Charlotte Hornets",
            "Chicago Bulls",
            "Cleveland Cavaliers",
            "Dallas Mavericks",
            "Denver Nuggets",
            "Detroit Pistons",
            "Golden State Warriors",
            "Houston Rockets",
            "Indiana Pacers",
            "Los Angeles Clippers",
            "Los Angeles Lakers",
            "Memphis Grizzlies",
            "Miami Heat",
            "Milwaukee Bucks",
            "Minnesota Timberwolves",
            "New Orleans Pelicans",
            "New York Knicks",
            "Oklahoma City Thunder",
            "Orlando Magic",
            "Philadelphia 76ers",
            "Phoenix Suns",
            "Portland Trail Blazers",
            "Sacramento Kings",
            "San Antonio Spurs",
            "Toronto Raptors",
            "Utah Jazz",
            "Washington Wizards"});
            this.lbNBATeams.Location = new System.Drawing.Point(1083, 129);
            this.lbNBATeams.Name = "lbNBATeams";
            this.lbNBATeams.Size = new System.Drawing.Size(313, 104);
            this.lbNBATeams.TabIndex = 21;
            this.lbNBATeams.Visible = false;
            // 
            // lbNBApositions
            // 
            this.lbNBApositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNBApositions.FormattingEnabled = true;
            this.lbNBApositions.ItemHeight = 25;
            this.lbNBApositions.Items.AddRange(new object[] {
            "All Positions",
            "Point Guard",
            "Shooting Guard",
            "Small Forward",
            "Power Forward",
            "Center"});
            this.lbNBApositions.Location = new System.Drawing.Point(1083, 21);
            this.lbNBApositions.Name = "lbNBApositions";
            this.lbNBApositions.Size = new System.Drawing.Size(313, 104);
            this.lbNBApositions.TabIndex = 22;
            this.lbNBApositions.Visible = false;
            // 
            // gbConferences
            // 
            this.gbConferences.Controls.Add(this.radEastNBA);
            this.gbConferences.Controls.Add(this.radWestNBA);
            this.gbConferences.Controls.Add(this.radConferences);
            this.gbConferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbConferences.Location = new System.Drawing.Point(209, 22);
            this.gbConferences.Name = "gbConferences";
            this.gbConferences.Size = new System.Drawing.Size(321, 80);
            this.gbConferences.TabIndex = 23;
            this.gbConferences.TabStop = false;
            this.gbConferences.Text = "Conferences";
            this.gbConferences.Visible = false;
            // 
            // radEastNBA
            // 
            this.radEastNBA.AutoSize = true;
            this.radEastNBA.Location = new System.Drawing.Point(86, 52);
            this.radEastNBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEastNBA.Name = "radEastNBA";
            this.radEastNBA.Size = new System.Drawing.Size(72, 29);
            this.radEastNBA.TabIndex = 2;
            this.radEastNBA.TabStop = true;
            this.radEastNBA.Text = "East";
            this.radEastNBA.UseVisualStyleBackColor = true;
            // 
            // radWestNBA
            // 
            this.radWestNBA.AutoSize = true;
            this.radWestNBA.Location = new System.Drawing.Point(6, 52);
            this.radWestNBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radWestNBA.Name = "radWestNBA";
            this.radWestNBA.Size = new System.Drawing.Size(79, 29);
            this.radWestNBA.TabIndex = 1;
            this.radWestNBA.TabStop = true;
            this.radWestNBA.Text = "West";
            this.radWestNBA.UseVisualStyleBackColor = true;
            // 
            // radConferences
            // 
            this.radConferences.AutoSize = true;
            this.radConferences.Checked = true;
            this.radConferences.Location = new System.Drawing.Point(6, 24);
            this.radConferences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radConferences.Name = "radConferences";
            this.radConferences.Size = new System.Drawing.Size(172, 29);
            this.radConferences.TabIndex = 0;
            this.radConferences.TabStop = true;
            this.radConferences.Text = "All Conferences";
            this.radConferences.UseVisualStyleBackColor = true;
            // 
            // rtbOut
            // 
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 12F);
            this.rtbOut.Location = new System.Drawing.Point(0, 323);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.ReadOnly = true;
            this.rtbOut.Size = new System.Drawing.Size(1412, 374);
            this.rtbOut.TabIndex = 24;
            this.rtbOut.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGo.Location = new System.Drawing.Point(1171, 243);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(105, 31);
            this.btnGo.TabIndex = 25;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(1298, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 31);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbMPG
            // 
            this.cbMPG.AutoSize = true;
            this.cbMPG.Location = new System.Drawing.Point(6, 24);
            this.cbMPG.Name = "cbMPG";
            this.cbMPG.Size = new System.Drawing.Size(66, 29);
            this.cbMPG.TabIndex = 27;
            this.cbMPG.Text = "MG";
            this.cbMPG.UseVisualStyleBackColor = true;
            // 
            // cbFGP
            // 
            this.cbFGP.AutoSize = true;
            this.cbFGP.Location = new System.Drawing.Point(89, 24);
            this.cbFGP.Name = "cbFGP";
            this.cbFGP.Size = new System.Drawing.Size(79, 29);
            this.cbFGP.TabIndex = 28;
            this.cbFGP.Text = "FG%";
            this.cbFGP.UseVisualStyleBackColor = true;
            // 
            // cb3PP
            // 
            this.cb3PP.AutoSize = true;
            this.cb3PP.Location = new System.Drawing.Point(176, 24);
            this.cb3PP.Name = "cb3PP";
            this.cb3PP.Size = new System.Drawing.Size(76, 29);
            this.cb3PP.TabIndex = 29;
            this.cb3PP.Text = "3P%";
            this.cb3PP.UseVisualStyleBackColor = true;
            // 
            // cbFTP
            // 
            this.cbFTP.AutoSize = true;
            this.cbFTP.Location = new System.Drawing.Point(6, 51);
            this.cbFTP.Name = "cbFTP";
            this.cbFTP.Size = new System.Drawing.Size(77, 29);
            this.cbFTP.TabIndex = 30;
            this.cbFTP.Text = "FT%";
            this.cbFTP.UseVisualStyleBackColor = true;
            // 
            // cbTS
            // 
            this.cbTS.AutoSize = true;
            this.cbTS.Location = new System.Drawing.Point(89, 51);
            this.cbTS.Name = "cbTS";
            this.cbTS.Size = new System.Drawing.Size(79, 29);
            this.cbTS.TabIndex = 31;
            this.cbTS.Text = "TS%";
            this.cbTS.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 177);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(110, 29);
            this.checkBox6.TabIndex = 32;
            this.checkBox6.Text = "AST/TO";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // cbREBPG
            // 
            this.cbREBPG.AutoSize = true;
            this.cbREBPG.Location = new System.Drawing.Point(122, 177);
            this.cbREBPG.Name = "cbREBPG";
            this.cbREBPG.Size = new System.Drawing.Size(107, 29);
            this.cbREBPG.TabIndex = 33;
            this.cbREBPG.Text = "REB/PG";
            this.cbREBPG.UseVisualStyleBackColor = true;
            // 
            // cbASTSPG
            // 
            this.cbASTSPG.AutoSize = true;
            this.cbASTSPG.Location = new System.Drawing.Point(6, 142);
            this.cbASTSPG.Name = "cbASTSPG";
            this.cbASTSPG.Size = new System.Drawing.Size(109, 29);
            this.cbASTSPG.TabIndex = 34;
            this.cbASTSPG.Text = "AST/PG";
            this.cbASTSPG.UseVisualStyleBackColor = true;
            // 
            // cbBLKPG
            // 
            this.cbBLKPG.AutoSize = true;
            this.cbBLKPG.Location = new System.Drawing.Point(121, 142);
            this.cbBLKPG.Name = "cbBLKPG";
            this.cbBLKPG.Size = new System.Drawing.Size(106, 29);
            this.cbBLKPG.TabIndex = 35;
            this.cbBLKPG.Text = "BLK/PG";
            this.cbBLKPG.UseVisualStyleBackColor = true;
            // 
            // cbSTLPG
            // 
            this.cbSTLPG.AutoSize = true;
            this.cbSTLPG.Location = new System.Drawing.Point(6, 108);
            this.cbSTLPG.Name = "cbSTLPG";
            this.cbSTLPG.Size = new System.Drawing.Size(106, 29);
            this.cbSTLPG.TabIndex = 36;
            this.cbSTLPG.Text = "STL/PG";
            this.cbSTLPG.UseVisualStyleBackColor = true;
            // 
            // cbSHEFF
            // 
            this.cbSHEFF.AutoSize = true;
            this.cbSHEFF.Location = new System.Drawing.Point(122, 78);
            this.cbSHEFF.Name = "cbSHEFF";
            this.cbSHEFF.Size = new System.Drawing.Size(106, 29);
            this.cbSHEFF.TabIndex = 27;
            this.cbSHEFF.Text = "SH-EFF";
            this.cbSHEFF.UseVisualStyleBackColor = true;
            // 
            // cbSCEFF
            // 
            this.cbSCEFF.AutoSize = true;
            this.cbSCEFF.Location = new System.Drawing.Point(6, 78);
            this.cbSCEFF.Name = "cbSCEFF";
            this.cbSCEFF.Size = new System.Drawing.Size(107, 29);
            this.cbSCEFF.TabIndex = 28;
            this.cbSCEFF.Text = "SC-EFF";
            this.cbSCEFF.UseVisualStyleBackColor = true;
            // 
            // cbPIE
            // 
            this.cbPIE.AutoSize = true;
            this.cbPIE.Location = new System.Drawing.Point(176, 51);
            this.cbPIE.Name = "cbPIE";
            this.cbPIE.Size = new System.Drawing.Size(65, 29);
            this.cbPIE.TabIndex = 29;
            this.cbPIE.Text = "PIE";
            this.cbPIE.UseVisualStyleBackColor = true;
            // 
            // cbTOPG
            // 
            this.cbTOPG.AutoSize = true;
            this.cbTOPG.Location = new System.Drawing.Point(121, 107);
            this.cbTOPG.Name = "cbTOPG";
            this.cbTOPG.Size = new System.Drawing.Size(97, 29);
            this.cbTOPG.TabIndex = 30;
            this.cbTOPG.Text = "TO/PG";
            this.cbTOPG.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 697);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.gbConferences);
            this.Controls.Add(this.lbNBApositions);
            this.Controls.Add(this.lbNBATeams);
            this.Controls.Add(this.gbNBAadvanced);
            this.Controls.Add(this.gbNBAbasic);
            this.Controls.Add(this.gbDivisionsNBA);
            this.Controls.Add(this.rtbLabels);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.gbLeague);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLeague.ResumeLayout(false);
            this.gbLeague.PerformLayout();
            this.gbNLorAL.ResumeLayout(false);
            this.gbNLorAL.PerformLayout();
            this.gbDivisionsNBA.ResumeLayout(false);
            this.gbDivisionsNBA.PerformLayout();
            this.gbNBAbasic.ResumeLayout(false);
            this.gbNBAbasic.PerformLayout();
            this.gbNBAadvanced.ResumeLayout(false);
            this.gbNBAadvanced.PerformLayout();
            this.gbConferences.ResumeLayout(false);
            this.gbConferences.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLeague;
        private System.Windows.Forms.RadioButton radWNBA;
        private System.Windows.Forms.RadioButton radNBA;
        private System.Windows.Forms.RadioButton radPitchers;
        private System.Windows.Forms.RadioButton radHitters;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RichTextBox rtbLabels;
        private System.Windows.Forms.GroupBox gbNLorAL;
        private System.Windows.Forms.RadioButton radNL;
        private System.Windows.Forms.RadioButton radAL;
        private System.Windows.Forms.RadioButton radMLB;
        private System.Windows.Forms.GroupBox gbDivisionsNBA;
        private System.Windows.Forms.RadioButton radAllDivisionsNBA;
        private System.Windows.Forms.RadioButton radCentralNBA;
        private System.Windows.Forms.RadioButton radSoutheast;
        private System.Windows.Forms.RadioButton radAtlantic;
        private System.Windows.Forms.GroupBox gbNBAbasic;
        private System.Windows.Forms.GroupBox gbNBAadvanced;
        private System.Windows.Forms.ListBox lbNBATeams;
        private System.Windows.Forms.ListBox lbNBApositions;
        private System.Windows.Forms.GroupBox gbConferences;
        private System.Windows.Forms.RadioButton radEastNBA;
        private System.Windows.Forms.RadioButton radWestNBA;
        private System.Windows.Forms.RadioButton radConferences;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radSouthwest;
        private System.Windows.Forms.RadioButton radPacific;
        private System.Windows.Forms.RadioButton radNorthwest;
        private System.Windows.Forms.CheckBox cbGamesPlayed;
        private System.Windows.Forms.CheckBox cbMinutes;
        private System.Windows.Forms.CheckBox cbFGmakes;
        private System.Windows.Forms.CheckBox cbFGattempts;
        private System.Windows.Forms.CheckBox cb3PM;
        private System.Windows.Forms.CheckBox cbFTA;
        private System.Windows.Forms.CheckBox cbFTM;
        private System.Windows.Forms.CheckBox cb3PA;
        private System.Windows.Forms.CheckBox cbPoints;
        private System.Windows.Forms.CheckBox cbTO;
        private System.Windows.Forms.CheckBox cbSteals;
        private System.Windows.Forms.CheckBox cbBlocks;
        private System.Windows.Forms.CheckBox cbAssists;
        private System.Windows.Forms.CheckBox cbDB;
        private System.Windows.Forms.CheckBox cbOB;
        private System.Windows.Forms.CheckBox cbSHEFF;
        private System.Windows.Forms.CheckBox cbSCEFF;
        private System.Windows.Forms.CheckBox cbPIE;
        private System.Windows.Forms.CheckBox cbTOPG;
        private System.Windows.Forms.CheckBox cbSTLPG;
        private System.Windows.Forms.CheckBox cbMPG;
        private System.Windows.Forms.CheckBox cbBLKPG;
        private System.Windows.Forms.CheckBox cbFGP;
        private System.Windows.Forms.CheckBox cbASTSPG;
        private System.Windows.Forms.CheckBox cb3PP;
        private System.Windows.Forms.CheckBox cbREBPG;
        private System.Windows.Forms.CheckBox cbFTP;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox cbTS;
    }
}

