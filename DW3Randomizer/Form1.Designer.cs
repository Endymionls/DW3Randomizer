using System;

namespace DW3Randomizer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSHAChecksum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReqChecksum = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompareBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompare = new System.Windows.Forms.TextBox();
            this.btnNewSeed = new System.Windows.Forms.Button();
            this.lblIntensityDesc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpMonsterStat = new System.Windows.Forms.GroupBox();
            this.optMonsterSilly = new System.Windows.Forms.RadioButton();
            this.optMonsterHeavy = new System.Windows.Forms.RadioButton();
            this.optMonsterMedium = new System.Windows.Forms.RadioButton();
            this.optMonsterLight = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chk_Caturday = new System.Windows.Forms.CheckBox();
            this.chkNoLamiaOrbs = new System.Windows.Forms.CheckBox();
            this.chkRemoveParryFight = new System.Windows.Forms.CheckBox();
            this.chkFourJobFiesta = new System.Windows.Forms.CheckBox();
            this.chkRandomizeGP = new System.Windows.Forms.CheckBox();
            this.chkRandomizeXP = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEncounterRate = new System.Windows.Forms.ComboBox();
            this.cboGoldReq = new System.Windows.Forms.ComboBox();
            this.cboExpGains = new System.Windows.Forms.ComboBox();
            this.chkSpeedText = new System.Windows.Forms.CheckBox();
            this.chkFasterBattles = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkRandomizeMap = new System.Windows.Forms.CheckBox();
            this.chkRandWhoCanEquip = new System.Windows.Forms.CheckBox();
            this.chkRandItemEffects = new System.Windows.Forms.CheckBox();
            this.chkSmallMap = new System.Windows.Forms.CheckBox();
            this.chkRandStatGains = new System.Windows.Forms.CheckBox();
            this.chkRandTreasures = new System.Windows.Forms.CheckBox();
            this.chkRandSpellStrength = new System.Windows.Forms.CheckBox();
            this.chkRandSpellLearning = new System.Windows.Forms.CheckBox();
            this.chkRandEquip = new System.Windows.Forms.CheckBox();
            this.chkRandMonsterZones = new System.Windows.Forms.CheckBox();
            this.chkRandEnemyPatterns = new System.Windows.Forms.CheckBox();
            this.chkRandStores = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chk_RandHero = new System.Windows.Forms.CheckBox();
            this.chk_RandSage = new System.Windows.Forms.CheckBox();
            this.chk_RandGoofOff = new System.Windows.Forms.CheckBox();
            this.chk_RandMerchant = new System.Windows.Forms.CheckBox();
            this.chk_RandFighter = new System.Windows.Forms.CheckBox();
            this.chk_RandWizard = new System.Windows.Forms.CheckBox();
            this.chk_RandPilgrim = new System.Windows.Forms.CheckBox();
            this.chk_RandSoldier = new System.Windows.Forms.CheckBox();
            this.chk_RandomGender = new System.Windows.Forms.CheckBox();
            this.chk_RandomClass = new System.Windows.Forms.CheckBox();
            this.chk_RandomName = new System.Windows.Forms.CheckBox();
            this.cboGender3 = new System.Windows.Forms.ComboBox();
            this.cboGender2 = new System.Windows.Forms.ComboBox();
            this.cboGender1 = new System.Windows.Forms.ComboBox();
            this.cboClass3 = new System.Windows.Forms.ComboBox();
            this.cboClass2 = new System.Windows.Forms.ComboBox();
            this.cboClass1 = new System.Windows.Forms.ComboBox();
            this.txtCharName2 = new System.Windows.Forms.TextBox();
            this.txtCharName3 = new System.Windows.Forms.TextBox();
            this.txtCharName1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.adjustments = new System.Windows.Forms.ToolTip(this.components);
            this.btnCopyChecksum = new System.Windows.Forms.Button();
            this.lblNewChecksum = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpMonsterStat.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(119, 23);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(320, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Leave += new System.EventHandler(this.txtFileName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DW3 ROM Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(448, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SHA1 Checksum";
            // 
            // lblSHAChecksum
            // 
            this.lblSHAChecksum.AutoSize = true;
            this.lblSHAChecksum.Location = new System.Drawing.Point(119, 78);
            this.lblSHAChecksum.Name = "lblSHAChecksum";
            this.lblSHAChecksum.Size = new System.Drawing.Size(247, 13);
            this.lblSHAChecksum.TabIndex = 4;
            this.lblSHAChecksum.Text = "????????????????????????????????????????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Required";
            // 
            // lblReqChecksum
            // 
            this.lblReqChecksum.AutoSize = true;
            this.lblReqChecksum.Location = new System.Drawing.Point(119, 102);
            this.lblReqChecksum.Name = "lblReqChecksum";
            this.lblReqChecksum.Size = new System.Drawing.Size(244, 13);
            this.lblReqChecksum.TabIndex = 6;
            this.lblReqChecksum.Text = "a867549bad1cba4cd6f6dd51743e78596b982bd8";
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(449, 399);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 26;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(448, 76);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(119, 185);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(100, 20);
            this.txtSeed.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seed";
            // 
            // btnCompareBrowse
            // 
            this.btnCompareBrowse.Location = new System.Drawing.Point(448, 47);
            this.btnCompareBrowse.Name = "btnCompareBrowse";
            this.btnCompareBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnCompareBrowse.TabIndex = 3;
            this.btnCompareBrowse.Text = "Browse";
            this.btnCompareBrowse.UseVisualStyleBackColor = true;
            this.btnCompareBrowse.Click += new System.EventHandler(this.btnCompareBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Comparison Image";
            // 
            // txtCompare
            // 
            this.txtCompare.Location = new System.Drawing.Point(119, 49);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(320, 20);
            this.txtCompare.TabIndex = 2;
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.Location = new System.Drawing.Point(231, 183);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(75, 23);
            this.btnNewSeed.TabIndex = 8;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = true;
            this.btnNewSeed.Click += new System.EventHandler(this.btnNewSeed_Click);
            // 
            // lblIntensityDesc
            // 
            this.lblIntensityDesc.Location = new System.Drawing.Point(13, 376);
            this.lblIntensityDesc.Name = "lblIntensityDesc";
            this.lblIntensityDesc.Size = new System.Drawing.Size(400, 18);
            this.lblIntensityDesc.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Random Level";
            // 
            // grpMonsterStat
            // 
            this.grpMonsterStat.Controls.Add(this.optMonsterSilly);
            this.grpMonsterStat.Controls.Add(this.optMonsterHeavy);
            this.grpMonsterStat.Controls.Add(this.optMonsterMedium);
            this.grpMonsterStat.Controls.Add(this.optMonsterLight);
            this.grpMonsterStat.Location = new System.Drawing.Point(119, 144);
            this.grpMonsterStat.Name = "grpMonsterStat";
            this.grpMonsterStat.Size = new System.Drawing.Size(271, 30);
            this.grpMonsterStat.TabIndex = 38;
            this.grpMonsterStat.TabStop = false;
            // 
            // optMonsterSilly
            // 
            this.optMonsterSilly.AutoSize = true;
            this.optMonsterSilly.Location = new System.Drawing.Point(63, 8);
            this.optMonsterSilly.Name = "optMonsterSilly";
            this.optMonsterSilly.Size = new System.Drawing.Size(43, 17);
            this.optMonsterSilly.TabIndex = 20;
            this.optMonsterSilly.Text = "Silly";
            this.optMonsterSilly.UseVisualStyleBackColor = true;
            this.optMonsterSilly.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optMonsterHeavy
            // 
            this.optMonsterHeavy.AutoSize = true;
            this.optMonsterHeavy.Location = new System.Drawing.Point(192, 8);
            this.optMonsterHeavy.Name = "optMonsterHeavy";
            this.optMonsterHeavy.Size = new System.Drawing.Size(71, 17);
            this.optMonsterHeavy.TabIndex = 19;
            this.optMonsterHeavy.Text = "Ludicrous";
            this.optMonsterHeavy.UseVisualStyleBackColor = true;
            this.optMonsterHeavy.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optMonsterMedium
            // 
            this.optMonsterMedium.AutoSize = true;
            this.optMonsterMedium.Location = new System.Drawing.Point(112, 8);
            this.optMonsterMedium.Name = "optMonsterMedium";
            this.optMonsterMedium.Size = new System.Drawing.Size(74, 17);
            this.optMonsterMedium.TabIndex = 18;
            this.optMonsterMedium.Text = "Ridiculous";
            this.optMonsterMedium.UseVisualStyleBackColor = true;
            this.optMonsterMedium.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optMonsterLight
            // 
            this.optMonsterLight.AutoSize = true;
            this.optMonsterLight.Checked = true;
            this.optMonsterLight.Location = new System.Drawing.Point(9, 8);
            this.optMonsterLight.Name = "optMonsterLight";
            this.optMonsterLight.Size = new System.Drawing.Size(48, 17);
            this.optMonsterLight.TabIndex = 17;
            this.optMonsterLight.TabStop = true;
            this.optMonsterLight.Text = "Light";
            this.optMonsterLight.UseVisualStyleBackColor = true;
            this.optMonsterLight.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 211);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 164);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_Caturday);
            this.tabPage1.Controls.Add(this.chkNoLamiaOrbs);
            this.tabPage1.Controls.Add(this.chkRemoveParryFight);
            this.tabPage1.Controls.Add(this.chkFourJobFiesta);
            this.tabPage1.Controls.Add(this.chkRandomizeGP);
            this.tabPage1.Controls.Add(this.chkRandomizeXP);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cboEncounterRate);
            this.tabPage1.Controls.Add(this.cboGoldReq);
            this.tabPage1.Controls.Add(this.cboExpGains);
            this.tabPage1.Controls.Add(this.chkSpeedText);
            this.tabPage1.Controls.Add(this.chkFasterBattles);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(533, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adjustments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chk_Caturday
            // 
            this.chk_Caturday.AutoSize = true;
            this.chk_Caturday.Location = new System.Drawing.Point(370, 105);
            this.chk_Caturday.Name = "chk_Caturday";
            this.chk_Caturday.Size = new System.Drawing.Size(68, 17);
            this.chk_Caturday.TabIndex = 22;
            this.chk_Caturday.Text = "Caturday";
            this.adjustments.SetToolTip(this.chk_Caturday, "Ensures that Animal Suits will be found in at least 1 weapon shop.");
            this.chk_Caturday.UseVisualStyleBackColor = true;
            this.chk_Caturday.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkNoLamiaOrbs
            // 
            this.chkNoLamiaOrbs.AutoSize = true;
            this.chkNoLamiaOrbs.Location = new System.Drawing.Point(370, 86);
            this.chkNoLamiaOrbs.Name = "chkNoLamiaOrbs";
            this.chkNoLamiaOrbs.Size = new System.Drawing.Size(151, 17);
            this.chkNoLamiaOrbs.TabIndex = 21;
            this.chkNoLamiaOrbs.Text = "Require No Orbs for Lamia";
            this.adjustments.SetToolTip(this.chkNoLamiaOrbs, "Able to hatch Lamia without any orbs.");
            this.chkNoLamiaOrbs.UseVisualStyleBackColor = true;
            this.chkNoLamiaOrbs.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRemoveParryFight
            // 
            this.chkRemoveParryFight.AutoSize = true;
            this.chkRemoveParryFight.Location = new System.Drawing.Point(370, 66);
            this.chkRemoveParryFight.Name = "chkRemoveParryFight";
            this.chkRemoveParryFight.Size = new System.Drawing.Size(143, 17);
            this.chkRemoveParryFight.TabIndex = 20;
            this.chkRemoveParryFight.Text = "Remove Parry/Fight Bug";
            this.adjustments.SetToolTip(this.chkRemoveParryFight, "Removes Parry/Fight bug found in standard DWIII");
            this.chkRemoveParryFight.UseVisualStyleBackColor = true;
            this.chkRemoveParryFight.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkFourJobFiesta
            // 
            this.chkFourJobFiesta.AutoSize = true;
            this.chkFourJobFiesta.Location = new System.Drawing.Point(370, 46);
            this.chkFourJobFiesta.Name = "chkFourJobFiesta";
            this.chkFourJobFiesta.Size = new System.Drawing.Size(157, 17);
            this.chkFourJobFiesta.TabIndex = 19;
            this.chkFourJobFiesta.Text = "Four Job Fiesta adjustments";
            this.adjustments.SetToolTip(this.chkFourJobFiesta, "Allows the hero to be removed from the party, the hero to change classes, and any" +
        " hero to become a sage.");
            this.chkFourJobFiesta.UseVisualStyleBackColor = true;
            this.chkFourJobFiesta.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandomizeGP
            // 
            this.chkRandomizeGP.AutoSize = true;
            this.chkRandomizeGP.Checked = true;
            this.chkRandomizeGP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeGP.Location = new System.Drawing.Point(211, 29);
            this.chkRandomizeGP.Name = "chkRandomizeGP";
            this.chkRandomizeGP.Size = new System.Drawing.Size(97, 17);
            this.chkRandomizeGP.TabIndex = 18;
            this.chkRandomizeGP.Text = "Randomize GP";
            this.chkRandomizeGP.UseVisualStyleBackColor = true;
            this.chkRandomizeGP.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandomizeXP
            // 
            this.chkRandomizeXP.AutoSize = true;
            this.chkRandomizeXP.Checked = true;
            this.chkRandomizeXP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeXP.Location = new System.Drawing.Point(211, 6);
            this.chkRandomizeXP.Name = "chkRandomizeXP";
            this.chkRandomizeXP.Size = new System.Drawing.Size(96, 17);
            this.chkRandomizeXP.TabIndex = 17;
            this.chkRandomizeXP.Text = "Randomize XP";
            this.chkRandomizeXP.UseVisualStyleBackColor = true;
            this.chkRandomizeXP.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Encounter Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gold Gains";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Experience Gains";
            // 
            // cboEncounterRate
            // 
            this.cboEncounterRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncounterRate.FormattingEnabled = true;
            this.cboEncounterRate.Items.AddRange(new object[] {
            "400%",
            "300%",
            "200%",
            "150%",
            "100%",
            "75%",
            "50%",
            "25%"});
            this.cboEncounterRate.Location = new System.Drawing.Point(109, 55);
            this.cboEncounterRate.Margin = new System.Windows.Forms.Padding(2);
            this.cboEncounterRate.Name = "cboEncounterRate";
            this.cboEncounterRate.Size = new System.Drawing.Size(82, 21);
            this.cboEncounterRate.TabIndex = 13;
            this.cboEncounterRate.SelectedIndexChanged += new System.EventHandler(this.determineFlags);
            // 
            // cboGoldReq
            // 
            this.cboGoldReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoldReq.FormattingEnabled = true;
            this.cboGoldReq.Items.AddRange(new object[] {
            "200%",
            "150%",
            "100%",
            "50%"});
            this.cboGoldReq.Location = new System.Drawing.Point(109, 30);
            this.cboGoldReq.Margin = new System.Windows.Forms.Padding(2);
            this.cboGoldReq.Name = "cboGoldReq";
            this.cboGoldReq.Size = new System.Drawing.Size(82, 21);
            this.cboGoldReq.TabIndex = 12;
            this.cboGoldReq.SelectedIndexChanged += new System.EventHandler(this.determineFlags);
            // 
            // cboExpGains
            // 
            this.cboExpGains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpGains.FormattingEnabled = true;
            this.cboExpGains.Items.AddRange(new object[] {
            "500%",
            "400%",
            "300%",
            "200%",
            "150%",
            "100%",
            "50%",
            "25%"});
            this.cboExpGains.Location = new System.Drawing.Point(109, 5);
            this.cboExpGains.Margin = new System.Windows.Forms.Padding(2);
            this.cboExpGains.Name = "cboExpGains";
            this.cboExpGains.Size = new System.Drawing.Size(82, 21);
            this.cboExpGains.TabIndex = 11;
            this.cboExpGains.SelectedIndexChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkSpeedText
            // 
            this.chkSpeedText.AutoSize = true;
            this.chkSpeedText.Checked = true;
            this.chkSpeedText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpeedText.Location = new System.Drawing.Point(370, 26);
            this.chkSpeedText.Name = "chkSpeedText";
            this.chkSpeedText.Size = new System.Drawing.Size(115, 17);
            this.chkSpeedText.TabIndex = 10;
            this.chkSpeedText.Text = "Speedy Text Hack";
            this.chkSpeedText.UseVisualStyleBackColor = true;
            this.chkSpeedText.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkFasterBattles
            // 
            this.chkFasterBattles.AutoSize = true;
            this.chkFasterBattles.Checked = true;
            this.chkFasterBattles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFasterBattles.Location = new System.Drawing.Point(370, 6);
            this.chkFasterBattles.Name = "chkFasterBattles";
            this.chkFasterBattles.Size = new System.Drawing.Size(137, 17);
            this.chkFasterBattles.TabIndex = 9;
            this.chkFasterBattles.Text = "Increased Battle Speed";
            this.chkFasterBattles.UseVisualStyleBackColor = true;
            this.chkFasterBattles.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkRandomizeMap);
            this.tabPage2.Controls.Add(this.chkRandWhoCanEquip);
            this.tabPage2.Controls.Add(this.chkRandItemEffects);
            this.tabPage2.Controls.Add(this.chkSmallMap);
            this.tabPage2.Controls.Add(this.chkRandStatGains);
            this.tabPage2.Controls.Add(this.chkRandTreasures);
            this.tabPage2.Controls.Add(this.chkRandSpellStrength);
            this.tabPage2.Controls.Add(this.chkRandSpellLearning);
            this.tabPage2.Controls.Add(this.chkRandEquip);
            this.tabPage2.Controls.Add(this.chkRandMonsterZones);
            this.tabPage2.Controls.Add(this.chkRandEnemyPatterns);
            this.tabPage2.Controls.Add(this.chkRandStores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(533, 138);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Randomization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeMap
            // 
            this.chkRandomizeMap.AutoSize = true;
            this.chkRandomizeMap.Location = new System.Drawing.Point(179, 5);
            this.chkRandomizeMap.Name = "chkRandomizeMap";
            this.chkRandomizeMap.Size = new System.Drawing.Size(102, 17);
            this.chkRandomizeMap.TabIndex = 52;
            this.chkRandomizeMap.Text = "Randomize map";
            this.chkRandomizeMap.UseVisualStyleBackColor = true;
            this.chkRandomizeMap.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandWhoCanEquip
            // 
            this.chkRandWhoCanEquip.AutoSize = true;
            this.chkRandWhoCanEquip.Checked = true;
            this.chkRandWhoCanEquip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandWhoCanEquip.Location = new System.Drawing.Point(179, 120);
            this.chkRandWhoCanEquip.Name = "chkRandWhoCanEquip";
            this.chkRandWhoCanEquip.Size = new System.Drawing.Size(152, 17);
            this.chkRandWhoCanEquip.TabIndex = 51;
            this.chkRandWhoCanEquip.Text = "Randomize who can equip";
            this.chkRandWhoCanEquip.UseVisualStyleBackColor = true;
            this.chkRandWhoCanEquip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandItemEffects
            // 
            this.chkRandItemEffects.AutoSize = true;
            this.chkRandItemEffects.Checked = true;
            this.chkRandItemEffects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandItemEffects.Location = new System.Drawing.Point(5, 120);
            this.chkRandItemEffects.Name = "chkRandItemEffects";
            this.chkRandItemEffects.Size = new System.Drawing.Size(136, 17);
            this.chkRandItemEffects.TabIndex = 50;
            this.chkRandItemEffects.Text = "Randomize item effects";
            this.chkRandItemEffects.UseVisualStyleBackColor = true;
            this.chkRandItemEffects.Visible = false;
            this.chkRandItemEffects.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkSmallMap
            // 
            this.chkSmallMap.AutoSize = true;
            this.chkSmallMap.Location = new System.Drawing.Point(179, 28);
            this.chkSmallMap.Name = "chkSmallMap";
            this.chkSmallMap.Size = new System.Drawing.Size(125, 17);
            this.chkSmallMap.TabIndex = 49;
            this.chkSmallMap.Text = "Small Map (128x128)";
            this.chkSmallMap.UseVisualStyleBackColor = true;
            this.chkSmallMap.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandStatGains
            // 
            this.chkRandStatGains.AutoSize = true;
            this.chkRandStatGains.Checked = true;
            this.chkRandStatGains.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandStatGains.Location = new System.Drawing.Point(5, 97);
            this.chkRandStatGains.Name = "chkRandStatGains";
            this.chkRandStatGains.Size = new System.Drawing.Size(127, 17);
            this.chkRandStatGains.TabIndex = 48;
            this.chkRandStatGains.Text = "Randomize stat gains";
            this.chkRandStatGains.UseVisualStyleBackColor = true;
            this.chkRandStatGains.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandTreasures
            // 
            this.chkRandTreasures.AutoSize = true;
            this.chkRandTreasures.Checked = true;
            this.chkRandTreasures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandTreasures.Location = new System.Drawing.Point(179, 74);
            this.chkRandTreasures.Name = "chkRandTreasures";
            this.chkRandTreasures.Size = new System.Drawing.Size(125, 17);
            this.chkRandTreasures.TabIndex = 47;
            this.chkRandTreasures.Text = "Randomize treasures";
            this.chkRandTreasures.UseVisualStyleBackColor = true;
            this.chkRandTreasures.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandSpellStrength
            // 
            this.chkRandSpellStrength.AutoSize = true;
            this.chkRandSpellStrength.Checked = true;
            this.chkRandSpellStrength.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandSpellStrength.Location = new System.Drawing.Point(5, 74);
            this.chkRandSpellStrength.Name = "chkRandSpellStrength";
            this.chkRandSpellStrength.Size = new System.Drawing.Size(149, 17);
            this.chkRandSpellStrength.TabIndex = 46;
            this.chkRandSpellStrength.Text = "Randomize spell strengths";
            this.chkRandSpellStrength.UseVisualStyleBackColor = true;
            this.chkRandSpellStrength.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandSpellLearning
            // 
            this.chkRandSpellLearning.AutoSize = true;
            this.chkRandSpellLearning.Checked = true;
            this.chkRandSpellLearning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandSpellLearning.Location = new System.Drawing.Point(5, 51);
            this.chkRandSpellLearning.Name = "chkRandSpellLearning";
            this.chkRandSpellLearning.Size = new System.Drawing.Size(143, 17);
            this.chkRandSpellLearning.TabIndex = 45;
            this.chkRandSpellLearning.Text = "Randomize spell learning";
            this.chkRandSpellLearning.UseVisualStyleBackColor = true;
            this.chkRandSpellLearning.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandEquip
            // 
            this.chkRandEquip.AutoSize = true;
            this.chkRandEquip.Checked = true;
            this.chkRandEquip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandEquip.Location = new System.Drawing.Point(179, 97);
            this.chkRandEquip.Name = "chkRandEquip";
            this.chkRandEquip.Size = new System.Drawing.Size(163, 17);
            this.chkRandEquip.TabIndex = 44;
            this.chkRandEquip.Text = "Randomize equipment power";
            this.chkRandEquip.UseVisualStyleBackColor = true;
            this.chkRandEquip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandMonsterZones
            // 
            this.chkRandMonsterZones.AutoSize = true;
            this.chkRandMonsterZones.Checked = true;
            this.chkRandMonsterZones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandMonsterZones.Location = new System.Drawing.Point(5, 28);
            this.chkRandMonsterZones.Name = "chkRandMonsterZones";
            this.chkRandMonsterZones.Size = new System.Drawing.Size(150, 17);
            this.chkRandMonsterZones.TabIndex = 43;
            this.chkRandMonsterZones.Text = "Randomize monster zones";
            this.chkRandMonsterZones.UseVisualStyleBackColor = true;
            this.chkRandMonsterZones.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandEnemyPatterns
            // 
            this.chkRandEnemyPatterns.AutoSize = true;
            this.chkRandEnemyPatterns.Checked = true;
            this.chkRandEnemyPatterns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandEnemyPatterns.Location = new System.Drawing.Point(5, 5);
            this.chkRandEnemyPatterns.Name = "chkRandEnemyPatterns";
            this.chkRandEnemyPatterns.Size = new System.Drawing.Size(154, 17);
            this.chkRandEnemyPatterns.TabIndex = 42;
            this.chkRandEnemyPatterns.Text = "Randomize enemy patterns";
            this.chkRandEnemyPatterns.UseVisualStyleBackColor = true;
            this.chkRandEnemyPatterns.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandStores
            // 
            this.chkRandStores.AutoSize = true;
            this.chkRandStores.Checked = true;
            this.chkRandStores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandStores.Location = new System.Drawing.Point(179, 51);
            this.chkRandStores.Name = "chkRandStores";
            this.chkRandStores.Size = new System.Drawing.Size(123, 17);
            this.chkRandStores.TabIndex = 41;
            this.chkRandStores.Text = "Randomize all stores";
            this.chkRandStores.UseVisualStyleBackColor = true;
            this.chkRandStores.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chk_RandHero);
            this.tabPage3.Controls.Add(this.chk_RandSage);
            this.tabPage3.Controls.Add(this.chk_RandGoofOff);
            this.tabPage3.Controls.Add(this.chk_RandMerchant);
            this.tabPage3.Controls.Add(this.chk_RandFighter);
            this.tabPage3.Controls.Add(this.chk_RandWizard);
            this.tabPage3.Controls.Add(this.chk_RandPilgrim);
            this.tabPage3.Controls.Add(this.chk_RandSoldier);
            this.tabPage3.Controls.Add(this.chk_RandomGender);
            this.tabPage3.Controls.Add(this.chk_RandomClass);
            this.tabPage3.Controls.Add(this.chk_RandomName);
            this.tabPage3.Controls.Add(this.cboGender3);
            this.tabPage3.Controls.Add(this.cboGender2);
            this.tabPage3.Controls.Add(this.cboGender1);
            this.tabPage3.Controls.Add(this.cboClass3);
            this.tabPage3.Controls.Add(this.cboClass2);
            this.tabPage3.Controls.Add(this.cboClass1);
            this.tabPage3.Controls.Add(this.txtCharName2);
            this.tabPage3.Controls.Add(this.txtCharName3);
            this.tabPage3.Controls.Add(this.txtCharName1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(533, 138);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Characters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chk_RandHero
            // 
            this.chk_RandHero.AutoSize = true;
            this.chk_RandHero.Location = new System.Drawing.Point(394, 122);
            this.chk_RandHero.Name = "chk_RandHero";
            this.chk_RandHero.Size = new System.Drawing.Size(49, 17);
            this.chk_RandHero.TabIndex = 56;
            this.chk_RandHero.Text = "Hero";
            this.chk_RandHero.UseVisualStyleBackColor = true;
            this.chk_RandHero.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSage
            // 
            this.chk_RandSage.AutoSize = true;
            this.chk_RandSage.Location = new System.Drawing.Point(394, 105);
            this.chk_RandSage.Name = "chk_RandSage";
            this.chk_RandSage.Size = new System.Drawing.Size(51, 17);
            this.chk_RandSage.TabIndex = 55;
            this.chk_RandSage.Text = "Sage";
            this.chk_RandSage.UseVisualStyleBackColor = true;
            this.chk_RandSage.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandGoofOff
            // 
            this.chk_RandGoofOff.AutoSize = true;
            this.chk_RandGoofOff.Checked = true;
            this.chk_RandGoofOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandGoofOff.Location = new System.Drawing.Point(394, 88);
            this.chk_RandGoofOff.Name = "chk_RandGoofOff";
            this.chk_RandGoofOff.Size = new System.Drawing.Size(66, 17);
            this.chk_RandGoofOff.TabIndex = 54;
            this.chk_RandGoofOff.Text = "Goof-Off";
            this.chk_RandGoofOff.UseVisualStyleBackColor = true;
            this.chk_RandGoofOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandMerchant
            // 
            this.chk_RandMerchant.AutoSize = true;
            this.chk_RandMerchant.Checked = true;
            this.chk_RandMerchant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandMerchant.Location = new System.Drawing.Point(394, 71);
            this.chk_RandMerchant.Name = "chk_RandMerchant";
            this.chk_RandMerchant.Size = new System.Drawing.Size(71, 17);
            this.chk_RandMerchant.TabIndex = 53;
            this.chk_RandMerchant.Text = "Merchant";
            this.chk_RandMerchant.UseVisualStyleBackColor = true;
            this.chk_RandMerchant.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandFighter
            // 
            this.chk_RandFighter.AutoSize = true;
            this.chk_RandFighter.Checked = true;
            this.chk_RandFighter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandFighter.Location = new System.Drawing.Point(394, 54);
            this.chk_RandFighter.Name = "chk_RandFighter";
            this.chk_RandFighter.Size = new System.Drawing.Size(58, 17);
            this.chk_RandFighter.TabIndex = 52;
            this.chk_RandFighter.Text = "Fighter";
            this.chk_RandFighter.UseVisualStyleBackColor = true;
            this.chk_RandFighter.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandWizard
            // 
            this.chk_RandWizard.Checked = true;
            this.chk_RandWizard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandWizard.Location = new System.Drawing.Point(394, 37);
            this.chk_RandWizard.Name = "chk_RandWizard";
            this.chk_RandWizard.Size = new System.Drawing.Size(80, 17);
            this.chk_RandWizard.TabIndex = 0;
            this.chk_RandWizard.Text = "Wizard";
            this.chk_RandWizard.UseVisualStyleBackColor = true;
            this.chk_RandWizard.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandPilgrim
            // 
            this.chk_RandPilgrim.AutoSize = true;
            this.chk_RandPilgrim.Checked = true;
            this.chk_RandPilgrim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandPilgrim.Location = new System.Drawing.Point(394, 19);
            this.chk_RandPilgrim.Name = "chk_RandPilgrim";
            this.chk_RandPilgrim.Size = new System.Drawing.Size(56, 17);
            this.chk_RandPilgrim.TabIndex = 51;
            this.chk_RandPilgrim.Text = "Pilgrim";
            this.chk_RandPilgrim.UseVisualStyleBackColor = true;
            this.chk_RandPilgrim.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSoldier
            // 
            this.chk_RandSoldier.AutoSize = true;
            this.chk_RandSoldier.Checked = true;
            this.chk_RandSoldier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandSoldier.Location = new System.Drawing.Point(394, 2);
            this.chk_RandSoldier.Name = "chk_RandSoldier";
            this.chk_RandSoldier.Size = new System.Drawing.Size(58, 17);
            this.chk_RandSoldier.TabIndex = 50;
            this.chk_RandSoldier.Text = "Soldier";
            this.chk_RandSoldier.UseVisualStyleBackColor = true;
            this.chk_RandSoldier.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomGender
            // 
            this.chk_RandomGender.AutoSize = true;
            this.chk_RandomGender.Location = new System.Drawing.Point(128, 7);
            this.chk_RandomGender.Name = "chk_RandomGender";
            this.chk_RandomGender.Size = new System.Drawing.Size(117, 17);
            this.chk_RandomGender.TabIndex = 49;
            this.chk_RandomGender.Text = "Randomize Gender";
            this.chk_RandomGender.UseVisualStyleBackColor = true;
            this.chk_RandomGender.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomClass
            // 
            this.chk_RandomClass.AutoSize = true;
            this.chk_RandomClass.Location = new System.Drawing.Point(251, 7);
            this.chk_RandomClass.Name = "chk_RandomClass";
            this.chk_RandomClass.Size = new System.Drawing.Size(107, 17);
            this.chk_RandomClass.TabIndex = 48;
            this.chk_RandomClass.Text = "Randomize Class";
            this.chk_RandomClass.UseVisualStyleBackColor = true;
            this.chk_RandomClass.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomName
            // 
            this.chk_RandomName.AutoSize = true;
            this.chk_RandomName.Location = new System.Drawing.Point(7, 8);
            this.chk_RandomName.Name = "chk_RandomName";
            this.chk_RandomName.Size = new System.Drawing.Size(115, 17);
            this.chk_RandomName.TabIndex = 47;
            this.chk_RandomName.Text = "Randomize Names";
            this.chk_RandomName.UseVisualStyleBackColor = true;
            this.chk_RandomName.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // cboGender3
            // 
            this.cboGender3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender3.FormattingEnabled = true;
            this.cboGender3.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender3.Location = new System.Drawing.Point(128, 84);
            this.cboGender3.Name = "cboGender3";
            this.cboGender3.Size = new System.Drawing.Size(117, 21);
            this.cboGender3.TabIndex = 46;
            // 
            // cboGender2
            // 
            this.cboGender2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender2.FormattingEnabled = true;
            this.cboGender2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender2.Location = new System.Drawing.Point(128, 57);
            this.cboGender2.Name = "cboGender2";
            this.cboGender2.Size = new System.Drawing.Size(117, 21);
            this.cboGender2.TabIndex = 45;
            // 
            // cboGender1
            // 
            this.cboGender1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender1.FormattingEnabled = true;
            this.cboGender1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender1.Location = new System.Drawing.Point(128, 30);
            this.cboGender1.Name = "cboGender1";
            this.cboGender1.Size = new System.Drawing.Size(117, 21);
            this.cboGender1.TabIndex = 44;
            // 
            // cboClass3
            // 
            this.cboClass3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass3.FormattingEnabled = true;
            this.cboClass3.Items.AddRange(new object[] {
            "Soldier",
            "Pilgrim",
            "Wizard",
            "Fighter",
            "Merchant",
            "Goof-off",
            "Sage",
            "Hero"});
            this.cboClass3.Location = new System.Drawing.Point(251, 84);
            this.cboClass3.Name = "cboClass3";
            this.cboClass3.Size = new System.Drawing.Size(138, 21);
            this.cboClass3.TabIndex = 43;
            // 
            // cboClass2
            // 
            this.cboClass2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass2.FormattingEnabled = true;
            this.cboClass2.Items.AddRange(new object[] {
            "Soldier",
            "Pilgrim",
            "Wizard",
            "Fighter",
            "Merchant",
            "Goof-off",
            "Sage",
            "Hero"});
            this.cboClass2.Location = new System.Drawing.Point(251, 57);
            this.cboClass2.Name = "cboClass2";
            this.cboClass2.Size = new System.Drawing.Size(138, 21);
            this.cboClass2.TabIndex = 42;
            // 
            // cboClass1
            // 
            this.cboClass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass1.FormattingEnabled = true;
            this.cboClass1.Items.AddRange(new object[] {
            "Soldier",
            "Pilgrim",
            "Wizard",
            "Fighter",
            "Merchant",
            "Goof-off",
            "Sage",
            "Hero"});
            this.cboClass1.Location = new System.Drawing.Point(251, 30);
            this.cboClass1.Name = "cboClass1";
            this.cboClass1.Size = new System.Drawing.Size(138, 21);
            this.cboClass1.TabIndex = 41;
            // 
            // txtCharName2
            // 
            this.txtCharName2.Location = new System.Drawing.Point(7, 57);
            this.txtCharName2.MaxLength = 8;
            this.txtCharName2.Name = "txtCharName2";
            this.txtCharName2.Size = new System.Drawing.Size(115, 20);
            this.txtCharName2.TabIndex = 39;
            // 
            // txtCharName3
            // 
            this.txtCharName3.Location = new System.Drawing.Point(7, 84);
            this.txtCharName3.MaxLength = 8;
            this.txtCharName3.Name = "txtCharName3";
            this.txtCharName3.Size = new System.Drawing.Size(115, 20);
            this.txtCharName3.TabIndex = 40;
            // 
            // txtCharName1
            // 
            this.txtCharName1.Location = new System.Drawing.Point(7, 31);
            this.txtCharName1.MaxLength = 8;
            this.txtCharName1.Name = "txtCharName1";
            this.txtCharName1.Size = new System.Drawing.Size(115, 20);
            this.txtCharName1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Flags";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(401, 187);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(155, 20);
            this.txtFlags.TabIndex = 42;
            this.txtFlags.Leave += new System.EventHandler(this.determineChecks);
            // 
            // btnCopyChecksum
            // 
            this.btnCopyChecksum.Location = new System.Drawing.Point(401, 122);
            this.btnCopyChecksum.Name = "btnCopyChecksum";
            this.btnCopyChecksum.Size = new System.Drawing.Size(121, 23);
            this.btnCopyChecksum.TabIndex = 46;
            this.btnCopyChecksum.Text = "Copy New Checksum";
            this.btnCopyChecksum.UseVisualStyleBackColor = true;
            this.btnCopyChecksum.Click += new System.EventHandler(this.btnCopyChecksum_Click);
            // 
            // lblNewChecksum
            // 
            this.lblNewChecksum.AutoSize = true;
            this.lblNewChecksum.Location = new System.Drawing.Point(119, 127);
            this.lblNewChecksum.Name = "lblNewChecksum";
            this.lblNewChecksum.Size = new System.Drawing.Size(247, 13);
            this.lblNewChecksum.TabIndex = 45;
            this.lblNewChecksum.Text = "????????????????????????????????????????";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "New Checksum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 457);
            this.Controls.Add(this.btnCopyChecksum);
            this.Controls.Add(this.lblNewChecksum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFlags);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpMonsterStat);
            this.Controls.Add(this.lblIntensityDesc);
            this.Controls.Add(this.btnNewSeed);
            this.Controls.Add(this.btnCompareBrowse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCompare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.lblReqChecksum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSHAChecksum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee" +
    "eee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMonsterStat.ResumeLayout(false);
            this.grpMonsterStat.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSHAChecksum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReqChecksum;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewSeed;
        private System.Windows.Forms.TextBox txtCompare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompareBrowse;
        private System.Windows.Forms.Label lblIntensityDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpMonsterStat;
        private System.Windows.Forms.RadioButton optMonsterSilly;
        private System.Windows.Forms.RadioButton optMonsterHeavy;
        private System.Windows.Forms.RadioButton optMonsterMedium;
        private System.Windows.Forms.RadioButton optMonsterLight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkSmallMap;
        private System.Windows.Forms.CheckBox chkRandStatGains;
        private System.Windows.Forms.CheckBox chkRandTreasures;
        private System.Windows.Forms.CheckBox chkRandSpellStrength;
        private System.Windows.Forms.CheckBox chkRandSpellLearning;
        private System.Windows.Forms.CheckBox chkRandEquip;
        private System.Windows.Forms.CheckBox chkRandMonsterZones;
        private System.Windows.Forms.CheckBox chkRandEnemyPatterns;
        private System.Windows.Forms.CheckBox chkRandStores;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtCharName2;
        private System.Windows.Forms.TextBox txtCharName3;
        private System.Windows.Forms.TextBox txtCharName1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.CheckBox chkSpeedText;
        private System.Windows.Forms.CheckBox chkFasterBattles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEncounterRate;
        private System.Windows.Forms.ComboBox cboGoldReq;
        private System.Windows.Forms.ComboBox cboExpGains;
        private System.Windows.Forms.CheckBox chkRandomizeGP;
        private System.Windows.Forms.CheckBox chkRandomizeXP;
        private System.Windows.Forms.CheckBox chkRandWhoCanEquip;
        private System.Windows.Forms.CheckBox chkRandItemEffects;
        private System.Windows.Forms.CheckBox chkRandomizeMap;
        private System.Windows.Forms.CheckBox chkFourJobFiesta;
        private System.Windows.Forms.ToolTip adjustments;
        private System.Windows.Forms.CheckBox chkRemoveParryFight;
		private System.Windows.Forms.CheckBox chkNoLamiaOrbs;
		private System.Windows.Forms.Button btnCopyChecksum;
		private System.Windows.Forms.Label lblNewChecksum;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cboClass3;
		private System.Windows.Forms.ComboBox cboClass2;
		private System.Windows.Forms.ComboBox cboClass1;
		private System.Windows.Forms.ComboBox cboGender3;
		private System.Windows.Forms.ComboBox cboGender2;
		private System.Windows.Forms.ComboBox cboGender1;
        private System.Windows.Forms.CheckBox chk_RandomGender;
        private System.Windows.Forms.CheckBox chk_RandomClass;
        private System.Windows.Forms.CheckBox chk_RandomName;
        private System.Windows.Forms.CheckBox chk_RandMerchant;
        private System.Windows.Forms.CheckBox chk_RandFighter;
        private System.Windows.Forms.CheckBox chk_RandWizard;
        private System.Windows.Forms.CheckBox chk_RandPilgrim;
        private System.Windows.Forms.CheckBox chk_RandSoldier;
        private System.Windows.Forms.CheckBox chk_RandHero;
        private System.Windows.Forms.CheckBox chk_RandSage;
        private System.Windows.Forms.CheckBox chk_RandGoofOff;
        private System.Windows.Forms.CheckBox chk_Caturday;
    }
}

