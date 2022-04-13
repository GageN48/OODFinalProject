namespace OOD_Final_Project
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
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.radHitters = new System.Windows.Forms.RadioButton();
            this.gbLeague = new System.Windows.Forms.GroupBox();
            this.radWNBA = new System.Windows.Forms.RadioButton();
            this.radNBA = new System.Windows.Forms.RadioButton();
            this.radPitchers = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbNLorAL = new System.Windows.Forms.GroupBox();
            this.radNL = new System.Windows.Forms.RadioButton();
            this.radAL = new System.Windows.Forms.RadioButton();
            this.radMLB = new System.Windows.Forms.RadioButton();
            this.gbHittersBasic = new System.Windows.Forms.GroupBox();
            this.cbOPS = new System.Windows.Forms.CheckBox();
            this.cbSLG = new System.Windows.Forms.CheckBox();
            this.cbOBP = new System.Windows.Forms.CheckBox();
            this.cbAVG = new System.Windows.Forms.CheckBox();
            this.cbSO = new System.Windows.Forms.CheckBox();
            this.cbBB = new System.Windows.Forms.CheckBox();
            this.cbCS = new System.Windows.Forms.CheckBox();
            this.cbSB = new System.Windows.Forms.CheckBox();
            this.cbRBI = new System.Windows.Forms.CheckBox();
            this.cbHR = new System.Windows.Forms.CheckBox();
            this.cb3B = new System.Windows.Forms.CheckBox();
            this.cb2B = new System.Windows.Forms.CheckBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.cbR = new System.Windows.Forms.CheckBox();
            this.cbAB = new System.Windows.Forms.CheckBox();
            this.cbPA = new System.Windows.Forms.CheckBox();
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.cbIBB = new System.Windows.Forms.CheckBox();
            this.cbHBP = new System.Windows.Forms.CheckBox();
            this.cbTB = new System.Windows.Forms.CheckBox();
            this.cbwRCPlus = new System.Windows.Forms.CheckBox();
            this.cbwOBA = new System.Windows.Forms.CheckBox();
            this.cbwRAA = new System.Windows.Forms.CheckBox();
            this.cbRC = new System.Windows.Forms.CheckBox();
            this.cbPASO = new System.Windows.Forms.CheckBox();
            this.cbOPSPlus = new System.Windows.Forms.CheckBox();
            this.cbISO = new System.Windows.Forms.CheckBox();
            this.cbBABIP = new System.Windows.Forms.CheckBox();
            this.lbMLBTeams = new System.Windows.Forms.ListBox();
            this.lbHitterPosition = new System.Windows.Forms.ListBox();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.gbDivisions = new System.Windows.Forms.GroupBox();
            this.radAllDivisions = new System.Windows.Forms.RadioButton();
            this.radWest = new System.Windows.Forms.RadioButton();
            this.radCentral = new System.Windows.Forms.RadioButton();
            this.radEast = new System.Windows.Forms.RadioButton();
            this.rtbLabels = new System.Windows.Forms.RichTextBox();
            this.gbLeague.SuspendLayout();
            this.gbNLorAL.SuspendLayout();
            this.gbHittersBasic.SuspendLayout();
            this.gbAdvanced.SuspendLayout();
            this.gbDivisions.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbOut
            // 
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbOut.Font = new System.Drawing.Font("Courier New", 12F);
            this.rtbOut.Location = new System.Drawing.Point(0, 310);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(1384, 420);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
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
            this.radHitters.CheckedChanged += new System.EventHandler(this.radHitters_CheckedChanged);
            // 
            // gbLeague
            // 
            this.gbLeague.Controls.Add(this.radWNBA);
            this.gbLeague.Controls.Add(this.radNBA);
            this.gbLeague.Controls.Add(this.radPitchers);
            this.gbLeague.Controls.Add(this.radHitters);
            this.gbLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbLeague.Location = new System.Drawing.Point(13, 13);
            this.gbLeague.Name = "gbLeague";
            this.gbLeague.Size = new System.Drawing.Size(191, 171);
            this.gbLeague.TabIndex = 2;
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
            this.radPitchers.CheckedChanged += new System.EventHandler(this.radPitchers_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(12, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(811, 30);
            this.textBox1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(937, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(829, 247);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbNLorAL
            // 
            this.gbNLorAL.Controls.Add(this.radNL);
            this.gbNLorAL.Controls.Add(this.radAL);
            this.gbNLorAL.Controls.Add(this.radMLB);
            this.gbNLorAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbNLorAL.Location = new System.Drawing.Point(209, 13);
            this.gbNLorAL.Name = "gbNLorAL";
            this.gbNLorAL.Size = new System.Drawing.Size(209, 80);
            this.gbNLorAL.TabIndex = 7;
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
            // gbHittersBasic
            // 
            this.gbHittersBasic.Controls.Add(this.cbOPS);
            this.gbHittersBasic.Controls.Add(this.cbSLG);
            this.gbHittersBasic.Controls.Add(this.cbOBP);
            this.gbHittersBasic.Controls.Add(this.cbAVG);
            this.gbHittersBasic.Controls.Add(this.cbSO);
            this.gbHittersBasic.Controls.Add(this.cbBB);
            this.gbHittersBasic.Controls.Add(this.cbCS);
            this.gbHittersBasic.Controls.Add(this.cbSB);
            this.gbHittersBasic.Controls.Add(this.cbRBI);
            this.gbHittersBasic.Controls.Add(this.cbHR);
            this.gbHittersBasic.Controls.Add(this.cb3B);
            this.gbHittersBasic.Controls.Add(this.cb2B);
            this.gbHittersBasic.Controls.Add(this.cbH);
            this.gbHittersBasic.Controls.Add(this.cbR);
            this.gbHittersBasic.Controls.Add(this.cbAB);
            this.gbHittersBasic.Controls.Add(this.cbPA);
            this.gbHittersBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbHittersBasic.Location = new System.Drawing.Point(426, 13);
            this.gbHittersBasic.Name = "gbHittersBasic";
            this.gbHittersBasic.Size = new System.Drawing.Size(292, 171);
            this.gbHittersBasic.TabIndex = 8;
            this.gbHittersBasic.TabStop = false;
            this.gbHittersBasic.Text = "Basic Statistics";
            this.gbHittersBasic.Visible = false;
            // 
            // cbOPS
            // 
            this.cbOPS.AutoSize = true;
            this.cbOPS.Checked = true;
            this.cbOPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOPS.Location = new System.Drawing.Point(210, 134);
            this.cbOPS.Name = "cbOPS";
            this.cbOPS.Size = new System.Drawing.Size(77, 29);
            this.cbOPS.TabIndex = 15;
            this.cbOPS.Text = "OPS";
            this.cbOPS.UseVisualStyleBackColor = true;
            // 
            // cbSLG
            // 
            this.cbSLG.AutoSize = true;
            this.cbSLG.Location = new System.Drawing.Point(210, 100);
            this.cbSLG.Name = "cbSLG";
            this.cbSLG.Size = new System.Drawing.Size(74, 29);
            this.cbSLG.TabIndex = 14;
            this.cbSLG.Text = "SLG";
            this.cbSLG.UseVisualStyleBackColor = true;
            // 
            // cbOBP
            // 
            this.cbOBP.AutoSize = true;
            this.cbOBP.Checked = true;
            this.cbOBP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOBP.Location = new System.Drawing.Point(210, 64);
            this.cbOBP.Name = "cbOBP";
            this.cbOBP.Size = new System.Drawing.Size(76, 29);
            this.cbOBP.TabIndex = 13;
            this.cbOBP.Text = "OBP";
            this.cbOBP.UseVisualStyleBackColor = true;
            // 
            // cbAVG
            // 
            this.cbAVG.AutoSize = true;
            this.cbAVG.Checked = true;
            this.cbAVG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAVG.Location = new System.Drawing.Point(210, 30);
            this.cbAVG.Name = "cbAVG";
            this.cbAVG.Size = new System.Drawing.Size(77, 29);
            this.cbAVG.TabIndex = 12;
            this.cbAVG.Text = "AVG";
            this.cbAVG.UseVisualStyleBackColor = true;
            // 
            // cbSO
            // 
            this.cbSO.AutoSize = true;
            this.cbSO.Checked = true;
            this.cbSO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSO.Location = new System.Drawing.Point(142, 134);
            this.cbSO.Name = "cbSO";
            this.cbSO.Size = new System.Drawing.Size(64, 29);
            this.cbSO.TabIndex = 11;
            this.cbSO.Text = "SO";
            this.cbSO.UseVisualStyleBackColor = true;
            // 
            // cbBB
            // 
            this.cbBB.AutoSize = true;
            this.cbBB.Checked = true;
            this.cbBB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBB.Location = new System.Drawing.Point(142, 100);
            this.cbBB.Name = "cbBB";
            this.cbBB.Size = new System.Drawing.Size(60, 29);
            this.cbBB.TabIndex = 10;
            this.cbBB.Text = "BB";
            this.cbBB.UseVisualStyleBackColor = true;
            // 
            // cbCS
            // 
            this.cbCS.AutoSize = true;
            this.cbCS.Checked = true;
            this.cbCS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCS.Location = new System.Drawing.Point(142, 64);
            this.cbCS.Name = "cbCS";
            this.cbCS.Size = new System.Drawing.Size(63, 29);
            this.cbCS.TabIndex = 9;
            this.cbCS.Text = "CS";
            this.cbCS.UseVisualStyleBackColor = true;
            // 
            // cbSB
            // 
            this.cbSB.AutoSize = true;
            this.cbSB.Checked = true;
            this.cbSB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSB.Location = new System.Drawing.Point(142, 30);
            this.cbSB.Name = "cbSB";
            this.cbSB.Size = new System.Drawing.Size(61, 29);
            this.cbSB.TabIndex = 8;
            this.cbSB.Text = "SB";
            this.cbSB.UseVisualStyleBackColor = true;
            // 
            // cbRBI
            // 
            this.cbRBI.AutoSize = true;
            this.cbRBI.Checked = true;
            this.cbRBI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRBI.Location = new System.Drawing.Point(74, 134);
            this.cbRBI.Name = "cbRBI";
            this.cbRBI.Size = new System.Drawing.Size(65, 29);
            this.cbRBI.TabIndex = 7;
            this.cbRBI.Text = "RBI";
            this.cbRBI.UseVisualStyleBackColor = true;
            // 
            // cbHR
            // 
            this.cbHR.AutoSize = true;
            this.cbHR.Checked = true;
            this.cbHR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHR.Location = new System.Drawing.Point(74, 99);
            this.cbHR.Name = "cbHR";
            this.cbHR.Size = new System.Drawing.Size(61, 29);
            this.cbHR.TabIndex = 6;
            this.cbHR.Text = "HR";
            this.cbHR.UseVisualStyleBackColor = true;
            // 
            // cb3B
            // 
            this.cb3B.AutoSize = true;
            this.cb3B.Checked = true;
            this.cb3B.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3B.Location = new System.Drawing.Point(74, 64);
            this.cb3B.Name = "cb3B";
            this.cb3B.Size = new System.Drawing.Size(58, 29);
            this.cb3B.TabIndex = 5;
            this.cb3B.Text = "3B";
            this.cb3B.UseVisualStyleBackColor = true;
            // 
            // cb2B
            // 
            this.cb2B.AutoSize = true;
            this.cb2B.Checked = true;
            this.cb2B.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb2B.Location = new System.Drawing.Point(74, 29);
            this.cb2B.Name = "cb2B";
            this.cb2B.Size = new System.Drawing.Size(58, 29);
            this.cb2B.TabIndex = 4;
            this.cb2B.Text = "2B";
            this.cb2B.UseVisualStyleBackColor = true;
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Checked = true;
            this.cbH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbH.Location = new System.Drawing.Point(7, 135);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(48, 29);
            this.cbH.TabIndex = 3;
            this.cbH.Text = "H";
            this.cbH.UseVisualStyleBackColor = true;
            // 
            // cbR
            // 
            this.cbR.AutoSize = true;
            this.cbR.Checked = true;
            this.cbR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbR.Location = new System.Drawing.Point(7, 100);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(47, 29);
            this.cbR.TabIndex = 2;
            this.cbR.Text = "R";
            this.cbR.UseVisualStyleBackColor = true;
            // 
            // cbAB
            // 
            this.cbAB.AutoSize = true;
            this.cbAB.Checked = true;
            this.cbAB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAB.Location = new System.Drawing.Point(7, 64);
            this.cbAB.Name = "cbAB";
            this.cbAB.Size = new System.Drawing.Size(61, 29);
            this.cbAB.TabIndex = 1;
            this.cbAB.Text = "AB";
            this.cbAB.UseVisualStyleBackColor = true;
            // 
            // cbPA
            // 
            this.cbPA.AutoSize = true;
            this.cbPA.Checked = true;
            this.cbPA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPA.Location = new System.Drawing.Point(7, 30);
            this.cbPA.Name = "cbPA";
            this.cbPA.Size = new System.Drawing.Size(61, 29);
            this.cbPA.TabIndex = 0;
            this.cbPA.Text = "PA";
            this.cbPA.UseVisualStyleBackColor = true;
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Controls.Add(this.cbIBB);
            this.gbAdvanced.Controls.Add(this.cbHBP);
            this.gbAdvanced.Controls.Add(this.cbTB);
            this.gbAdvanced.Controls.Add(this.cbwRCPlus);
            this.gbAdvanced.Controls.Add(this.cbwOBA);
            this.gbAdvanced.Controls.Add(this.cbwRAA);
            this.gbAdvanced.Controls.Add(this.cbRC);
            this.gbAdvanced.Controls.Add(this.cbPASO);
            this.gbAdvanced.Controls.Add(this.cbOPSPlus);
            this.gbAdvanced.Controls.Add(this.cbISO);
            this.gbAdvanced.Controls.Add(this.cbBABIP);
            this.gbAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbAdvanced.Location = new System.Drawing.Point(724, 13);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(313, 171);
            this.gbAdvanced.TabIndex = 9;
            this.gbAdvanced.TabStop = false;
            this.gbAdvanced.Text = "Advanced Statistics";
            this.gbAdvanced.Visible = false;
            // 
            // cbIBB
            // 
            this.cbIBB.AutoSize = true;
            this.cbIBB.Location = new System.Drawing.Point(217, 99);
            this.cbIBB.Name = "cbIBB";
            this.cbIBB.Size = new System.Drawing.Size(65, 29);
            this.cbIBB.TabIndex = 11;
            this.cbIBB.Text = "IBB";
            this.cbIBB.UseVisualStyleBackColor = true;
            // 
            // cbHBP
            // 
            this.cbHBP.AutoSize = true;
            this.cbHBP.Location = new System.Drawing.Point(217, 65);
            this.cbHBP.Name = "cbHBP";
            this.cbHBP.Size = new System.Drawing.Size(74, 29);
            this.cbHBP.TabIndex = 10;
            this.cbHBP.Text = "HBP";
            this.cbHBP.UseVisualStyleBackColor = true;
            // 
            // cbTB
            // 
            this.cbTB.AutoSize = true;
            this.cbTB.Location = new System.Drawing.Point(217, 30);
            this.cbTB.Name = "cbTB";
            this.cbTB.Size = new System.Drawing.Size(60, 29);
            this.cbTB.TabIndex = 9;
            this.cbTB.Text = "TB";
            this.cbTB.UseVisualStyleBackColor = true;
            // 
            // cbwRCPlus
            // 
            this.cbwRCPlus.AutoSize = true;
            this.cbwRCPlus.Location = new System.Drawing.Point(119, 134);
            this.cbwRCPlus.Name = "cbwRCPlus";
            this.cbwRCPlus.Size = new System.Drawing.Size(88, 29);
            this.cbwRCPlus.TabIndex = 7;
            this.cbwRCPlus.Text = "wRC+";
            this.cbwRCPlus.UseVisualStyleBackColor = true;
            // 
            // cbwOBA
            // 
            this.cbwOBA.AutoSize = true;
            this.cbwOBA.Location = new System.Drawing.Point(119, 99);
            this.cbwOBA.Name = "cbwOBA";
            this.cbwOBA.Size = new System.Drawing.Size(91, 29);
            this.cbwOBA.TabIndex = 6;
            this.cbwOBA.Text = "wOBA";
            this.cbwOBA.UseVisualStyleBackColor = true;
            // 
            // cbwRAA
            // 
            this.cbwRAA.AutoSize = true;
            this.cbwRAA.Location = new System.Drawing.Point(119, 64);
            this.cbwRAA.Name = "cbwRAA";
            this.cbwRAA.Size = new System.Drawing.Size(89, 29);
            this.cbwRAA.TabIndex = 5;
            this.cbwRAA.Text = "wRAA";
            this.cbwRAA.UseVisualStyleBackColor = true;
            // 
            // cbRC
            // 
            this.cbRC.AutoSize = true;
            this.cbRC.Location = new System.Drawing.Point(119, 29);
            this.cbRC.Name = "cbRC";
            this.cbRC.Size = new System.Drawing.Size(62, 29);
            this.cbRC.TabIndex = 4;
            this.cbRC.Text = "RC";
            this.cbRC.UseVisualStyleBackColor = true;
            // 
            // cbPASO
            // 
            this.cbPASO.AutoSize = true;
            this.cbPASO.Location = new System.Drawing.Point(7, 134);
            this.cbPASO.Name = "cbPASO";
            this.cbPASO.Size = new System.Drawing.Size(97, 29);
            this.cbPASO.TabIndex = 3;
            this.cbPASO.Text = "PA/SO";
            this.cbPASO.UseVisualStyleBackColor = true;
            // 
            // cbOPSPlus
            // 
            this.cbOPSPlus.AutoSize = true;
            this.cbOPSPlus.Location = new System.Drawing.Point(7, 99);
            this.cbOPSPlus.Name = "cbOPSPlus";
            this.cbOPSPlus.Size = new System.Drawing.Size(89, 29);
            this.cbOPSPlus.TabIndex = 2;
            this.cbOPSPlus.Text = "OPS+";
            this.cbOPSPlus.UseVisualStyleBackColor = true;
            // 
            // cbISO
            // 
            this.cbISO.AutoSize = true;
            this.cbISO.Location = new System.Drawing.Point(7, 64);
            this.cbISO.Name = "cbISO";
            this.cbISO.Size = new System.Drawing.Size(69, 29);
            this.cbISO.TabIndex = 1;
            this.cbISO.Text = "ISO";
            this.cbISO.UseVisualStyleBackColor = true;
            // 
            // cbBABIP
            // 
            this.cbBABIP.AutoSize = true;
            this.cbBABIP.Location = new System.Drawing.Point(7, 30);
            this.cbBABIP.Name = "cbBABIP";
            this.cbBABIP.Size = new System.Drawing.Size(92, 29);
            this.cbBABIP.TabIndex = 0;
            this.cbBABIP.Text = "BABIP";
            this.cbBABIP.UseVisualStyleBackColor = true;
            // 
            // lbMLBTeams
            // 
            this.lbMLBTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMLBTeams.FormattingEnabled = true;
            this.lbMLBTeams.ItemHeight = 25;
            this.lbMLBTeams.Items.AddRange(new object[] {
            "All Teams",
            "Arizona Diamondbacks",
            "Atlanta Braves",
            "Baltimore Orioles",
            "Boston Red Sox",
            "Chicago Cubs",
            "Chicago White Sox",
            "Cincinnati Reds",
            "Cleveland Guardians",
            "Colorado Rockies",
            "Detroit Tigers",
            "Houston Astros",
            "Kansas City Royals",
            "Los Angeles Angels",
            "Los Angeles Dodgers",
            "Miami Marlins",
            "Milwaukee Brewers",
            "Minnesota Twins",
            "New York Mets",
            "New York Yankees",
            "Oakland Athletics",
            "Philidelphia Phillies",
            "Pittsburgh Pirates",
            "San Francisco Giants",
            "San Diego Padres",
            "Seattle Mariners",
            "St. Louis Cardinals",
            "Tampa Bay Rays",
            "Texas Rangers",
            "Toronto Blue Jays",
            "Washington Nationals"});
            this.lbMLBTeams.Location = new System.Drawing.Point(423, 190);
            this.lbMLBTeams.Name = "lbMLBTeams";
            this.lbMLBTeams.Size = new System.Drawing.Size(294, 54);
            this.lbMLBTeams.TabIndex = 10;
            this.lbMLBTeams.Visible = false;
            // 
            // lbHitterPosition
            // 
            this.lbHitterPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHitterPosition.FormattingEnabled = true;
            this.lbHitterPosition.ItemHeight = 25;
            this.lbHitterPosition.Items.AddRange(new object[] {
            "All Positions",
            "Catcher",
            "1st Base",
            "2nd Base",
            "Short Stop",
            "3rd Base",
            "Left Field",
            "Center Field",
            "Right Field",
            "Designated Hitter"});
            this.lbHitterPosition.Location = new System.Drawing.Point(724, 190);
            this.lbHitterPosition.Name = "lbHitterPosition";
            this.lbHitterPosition.Size = new System.Drawing.Size(313, 54);
            this.lbHitterPosition.TabIndex = 11;
            this.lbHitterPosition.Visible = false;
            // 
            // btnDictionary
            // 
            this.btnDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDictionary.Location = new System.Drawing.Point(13, 190);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(190, 52);
            this.btnDictionary.TabIndex = 12;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // gbDivisions
            // 
            this.gbDivisions.Controls.Add(this.radAllDivisions);
            this.gbDivisions.Controls.Add(this.radWest);
            this.gbDivisions.Controls.Add(this.radCentral);
            this.gbDivisions.Controls.Add(this.radEast);
            this.gbDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbDivisions.Location = new System.Drawing.Point(210, 98);
            this.gbDivisions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDivisions.Name = "gbDivisions";
            this.gbDivisions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDivisions.Size = new System.Drawing.Size(208, 122);
            this.gbDivisions.TabIndex = 14;
            this.gbDivisions.TabStop = false;
            this.gbDivisions.Text = "Divisions";
            this.gbDivisions.Visible = false;
            // 
            // radAllDivisions
            // 
            this.radAllDivisions.AutoSize = true;
            this.radAllDivisions.Checked = true;
            this.radAllDivisions.Location = new System.Drawing.Point(5, 25);
            this.radAllDivisions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radAllDivisions.Name = "radAllDivisions";
            this.radAllDivisions.Size = new System.Drawing.Size(138, 29);
            this.radAllDivisions.TabIndex = 3;
            this.radAllDivisions.TabStop = true;
            this.radAllDivisions.Text = "All Divisions";
            this.radAllDivisions.UseVisualStyleBackColor = true;
            // 
            // radWest
            // 
            this.radWest.AutoSize = true;
            this.radWest.Location = new System.Drawing.Point(86, 53);
            this.radWest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radWest.Name = "radWest";
            this.radWest.Size = new System.Drawing.Size(79, 29);
            this.radWest.TabIndex = 2;
            this.radWest.Text = "West";
            this.radWest.UseVisualStyleBackColor = true;
            // 
            // radCentral
            // 
            this.radCentral.AutoSize = true;
            this.radCentral.Location = new System.Drawing.Point(5, 81);
            this.radCentral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radCentral.Name = "radCentral";
            this.radCentral.Size = new System.Drawing.Size(96, 29);
            this.radCentral.TabIndex = 1;
            this.radCentral.Text = "Central";
            this.radCentral.UseVisualStyleBackColor = true;
            // 
            // radEast
            // 
            this.radEast.AutoSize = true;
            this.radEast.Location = new System.Drawing.Point(5, 53);
            this.radEast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radEast.Name = "radEast";
            this.radEast.Size = new System.Drawing.Size(72, 29);
            this.radEast.TabIndex = 0;
            this.radEast.Text = "East";
            this.radEast.UseVisualStyleBackColor = true;
            // 
            // rtbLabels
            // 
            this.rtbLabels.Font = new System.Drawing.Font("Courier New", 12F);
            this.rtbLabels.Location = new System.Drawing.Point(0, 284);
            this.rtbLabels.Name = "rtbLabels";
            this.rtbLabels.Size = new System.Drawing.Size(1384, 30);
            this.rtbLabels.TabIndex = 15;
            this.rtbLabels.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 730);
            this.Controls.Add(this.rtbLabels);
            this.Controls.Add(this.gbDivisions);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.lbHitterPosition);
            this.Controls.Add(this.lbMLBTeams);
            this.Controls.Add(this.gbAdvanced);
            this.Controls.Add(this.gbHittersBasic);
            this.Controls.Add(this.gbNLorAL);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbLeague);
            this.Controls.Add(this.rtbOut);
            this.Name = "Form1";
            this.Text = "OOD Final Project";
            this.gbLeague.ResumeLayout(false);
            this.gbLeague.PerformLayout();
            this.gbNLorAL.ResumeLayout(false);
            this.gbNLorAL.PerformLayout();
            this.gbHittersBasic.ResumeLayout(false);
            this.gbHittersBasic.PerformLayout();
            this.gbAdvanced.ResumeLayout(false);
            this.gbAdvanced.PerformLayout();
            this.gbDivisions.ResumeLayout(false);
            this.gbDivisions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.RadioButton radHitters;
        private System.Windows.Forms.GroupBox gbLeague;
        private System.Windows.Forms.RadioButton radWNBA;
        private System.Windows.Forms.RadioButton radNBA;
        private System.Windows.Forms.RadioButton radPitchers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbNLorAL;
        private System.Windows.Forms.GroupBox gbHittersBasic;
        private System.Windows.Forms.CheckBox cbOPS;
        private System.Windows.Forms.CheckBox cbSLG;
        private System.Windows.Forms.CheckBox cbOBP;
        private System.Windows.Forms.CheckBox cbAVG;
        private System.Windows.Forms.CheckBox cbSO;
        private System.Windows.Forms.CheckBox cbBB;
        private System.Windows.Forms.CheckBox cbCS;
        private System.Windows.Forms.CheckBox cbSB;
        private System.Windows.Forms.CheckBox cbRBI;
        private System.Windows.Forms.CheckBox cbHR;
        private System.Windows.Forms.CheckBox cb3B;
        private System.Windows.Forms.CheckBox cb2B;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.CheckBox cbR;
        private System.Windows.Forms.CheckBox cbAB;
        private System.Windows.Forms.CheckBox cbPA;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private System.Windows.Forms.ListBox lbMLBTeams;
        private System.Windows.Forms.CheckBox cbIBB;
        private System.Windows.Forms.CheckBox cbHBP;
        private System.Windows.Forms.CheckBox cbTB;
        private System.Windows.Forms.CheckBox cbwRCPlus;
        private System.Windows.Forms.CheckBox cbwOBA;
        private System.Windows.Forms.CheckBox cbwRAA;
        private System.Windows.Forms.CheckBox cbRC;
        private System.Windows.Forms.CheckBox cbPASO;
        private System.Windows.Forms.CheckBox cbOPSPlus;
        private System.Windows.Forms.CheckBox cbISO;
        private System.Windows.Forms.CheckBox cbBABIP;
        private System.Windows.Forms.ListBox lbHitterPosition;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.RadioButton radNL;
        private System.Windows.Forms.RadioButton radAL;
        private System.Windows.Forms.RadioButton radMLB;
        private System.Windows.Forms.GroupBox gbDivisions;
        private System.Windows.Forms.RadioButton radWest;
        private System.Windows.Forms.RadioButton radCentral;
        private System.Windows.Forms.RadioButton radEast;
        private System.Windows.Forms.RadioButton radAllDivisions;
        private System.Windows.Forms.RichTextBox rtbLabels;
    }
}

