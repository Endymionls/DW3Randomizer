using System;
using System.ComponentModel;

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
            this.chk_RandomStartGold = new System.Windows.Forms.CheckBox();
            this.chk_RmManip = new System.Windows.Forms.CheckBox();
            this.chk_WeapArmPower = new System.Windows.Forms.CheckBox();
            this.chk_Cod = new System.Windows.Forms.CheckBox();
            this.chk_SpeedUpMenus = new System.Windows.Forms.CheckBox();
            this.chkNoLamiaOrbs = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEncounterRate = new System.Windows.Forms.ComboBox();
            this.cboGoldReq = new System.Windows.Forms.ComboBox();
            this.cboExpGains = new System.Windows.Forms.ComboBox();
            this.chkSpeedText = new System.Windows.Forms.CheckBox();
            this.chkFasterBattles = new System.Windows.Forms.CheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chk_RmNewTown = new System.Windows.Forms.CheckBox();
            this.chk_RemoveMtnDrgQueen = new System.Windows.Forms.CheckBox();
            this.chk_RmMtnNecrogond = new System.Windows.Forms.CheckBox();
            this.chk_lbtoCharlock = new System.Windows.Forms.CheckBox();
            this.chk_RemLancelMountains = new System.Windows.Forms.CheckBox();
            this.chk_RemoveBirdRequirement = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chk_SepBarGaia = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMap = new System.Windows.Forms.CheckBox();
            this.chkSmallMap = new System.Windows.Forms.CheckBox();
            this.chkRandMonsterZones = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkRandomizeGP = new System.Windows.Forms.CheckBox();
            this.chkRandomizeXP = new System.Windows.Forms.CheckBox();
            this.chk_RemMetalMonRun = new System.Windows.Forms.CheckBox();
            this.chkRandEnemyPatterns = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chk_UseVanEquipValues = new System.Windows.Forms.CheckBox();
            this.chk_RmFighterPenalty = new System.Windows.Forms.CheckBox();
            this.lbl_TreasurePool = new System.Windows.Forms.Label();
            this.chk_RemoveStartEqRestrictions = new System.Windows.Forms.CheckBox();
            this.chk_GoldenClaw = new System.Windows.Forms.CheckBox();
            this.chkRandEquip = new System.Windows.Forms.CheckBox();
            this.chkRandWhoCanEquip = new System.Windows.Forms.CheckBox();
            this.chkRandItemEffects = new System.Windows.Forms.CheckBox();
            this.chkRandTreasures = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chk_LeafoftheWorldTree = new System.Windows.Forms.CheckBox();
            this.chk_RandomizeWeaponShops = new System.Windows.Forms.CheckBox();
            this.chk_LampofDarkness = new System.Windows.Forms.CheckBox();
            this.chk_WizardsRing = new System.Windows.Forms.CheckBox();
            this.chk_MeteoriteArmband = new System.Windows.Forms.CheckBox();
            this.chk_ShoesofHappiness = new System.Windows.Forms.CheckBox();
            this.lbl_ItemShops = new System.Windows.Forms.Label();
            this.chk_SilverHarp = new System.Windows.Forms.CheckBox();
            this.chk_EchoingFlute = new System.Windows.Forms.CheckBox();
            this.chk_RingofLife = new System.Windows.Forms.CheckBox();
            this.chk_BookofSatori = new System.Windows.Forms.CheckBox();
            this.chk_Seeds = new System.Windows.Forms.CheckBox();
            this.chk_StoneofLife = new System.Windows.Forms.CheckBox();
            this.chkRandItemStores = new System.Windows.Forms.CheckBox();
            this.chk_Caturday = new System.Windows.Forms.CheckBox();
            this.chk_PoisonMothPowder = new System.Windows.Forms.CheckBox();
            this.chk_RandomizeInnPrices = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chk_ChangeDefaultParty = new System.Windows.Forms.CheckBox();
            this.chkFourJobFiesta = new System.Windows.Forms.CheckBox();
            this.chkRandStatGains = new System.Windows.Forms.CheckBox();
            this.chkRandSpellStrength = new System.Windows.Forms.CheckBox();
            this.chkRandSpellLearning = new System.Windows.Forms.CheckBox();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chkRemoveParryFight = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.chk_GhostToCasket = new System.Windows.Forms.CheckBox();
            this.chk_RandSpriteColor = new System.Windows.Forms.CheckBox();
            this.chk_ChangeHeroAge = new System.Windows.Forms.CheckBox();
            this.chk_LowerCaseMenus = new System.Windows.Forms.CheckBox();
            this.chk_FixSlimeSnail = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.adjustments = new System.Windows.Forms.ToolTip(this.components);
            this.chk_GenCompareFile = new System.Windows.Forms.CheckBox();
            this.chk_GenIslandsMonstersZones = new System.Windows.Forms.CheckBox();
            this.btnCopyChecksum = new System.Windows.Forms.Button();
            this.lblNewChecksum = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpFlags = new System.Windows.Forms.GroupBox();
            this.optEndysFlags = new System.Windows.Forms.RadioButton();
            this.optSotWFlags = new System.Windows.Forms.RadioButton();
            this.optManualFlags = new System.Windows.Forms.RadioButton();
            this.grpMonsterStat.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.grpFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(119, 21);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(451, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Leave += new System.EventHandler(this.txtFileName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DW3 ROM Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(576, 18);
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
            this.btnRandomize.Location = new System.Drawing.Point(572, 476);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 200;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(576, 78);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Visible = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(55, 229);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(512, 20);
            this.txtSeed.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seed";
            // 
            // btnCompareBrowse
            // 
            this.btnCompareBrowse.Location = new System.Drawing.Point(576, 47);
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
            this.label5.Location = new System.Drawing.Point(17, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Output ROM File";
            this.adjustments.SetToolTip(this.label5, "This can be used to compare an existing ROM file as well.");
            // 
            // txtCompare
            // 
            this.txtCompare.Location = new System.Drawing.Point(119, 49);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(451, 20);
            this.txtCompare.TabIndex = 2;
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.Location = new System.Drawing.Point(576, 227);
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
            this.label9.Location = new System.Drawing.Point(103, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Monster Random Level";
            // 
            // grpMonsterStat
            // 
            this.grpMonsterStat.Controls.Add(this.optMonsterSilly);
            this.grpMonsterStat.Controls.Add(this.optMonsterHeavy);
            this.grpMonsterStat.Controls.Add(this.optMonsterMedium);
            this.grpMonsterStat.Controls.Add(this.optMonsterLight);
            this.grpMonsterStat.Location = new System.Drawing.Point(28, 29);
            this.grpMonsterStat.Name = "grpMonsterStat";
            this.grpMonsterStat.Size = new System.Drawing.Size(271, 30);
            this.grpMonsterStat.TabIndex = 6;
            this.grpMonsterStat.TabStop = false;
            this.grpMonsterStat.Enter += new System.EventHandler(this.grpMonsterStat_Enter);
            // 
            // optMonsterSilly
            // 
            this.optMonsterSilly.AutoSize = true;
            this.optMonsterSilly.Location = new System.Drawing.Point(63, 8);
            this.optMonsterSilly.Name = "optMonsterSilly";
            this.optMonsterSilly.Size = new System.Drawing.Size(43, 17);
            this.optMonsterSilly.TabIndex = 41;
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
            this.optMonsterHeavy.TabIndex = 43;
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
            this.optMonsterMedium.TabIndex = 42;
            this.optMonsterMedium.Text = "Ridiculous";
            this.optMonsterMedium.UseVisualStyleBackColor = true;
            this.optMonsterMedium.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optMonsterLight
            // 
            this.optMonsterLight.AutoSize = true;
            this.optMonsterLight.Checked = true;
            this.optMonsterLight.Location = new System.Drawing.Point(6, 8);
            this.optMonsterLight.Name = "optMonsterLight";
            this.optMonsterLight.Size = new System.Drawing.Size(48, 17);
            this.optMonsterLight.TabIndex = 40;
            this.optMonsterLight.TabStop = true;
            this.optMonsterLight.Text = "Light";
            this.optMonsterLight.UseVisualStyleBackColor = true;
            this.optMonsterLight.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 255);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 216);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_RandomStartGold);
            this.tabPage1.Controls.Add(this.chk_RmManip);
            this.tabPage1.Controls.Add(this.chk_WeapArmPower);
            this.tabPage1.Controls.Add(this.chk_Cod);
            this.tabPage1.Controls.Add(this.chk_SpeedUpMenus);
            this.tabPage1.Controls.Add(this.chkNoLamiaOrbs);
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
            this.tabPage1.Size = new System.Drawing.Size(631, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adjustments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chk_RandomStartGold
            // 
            this.chk_RandomStartGold.AutoSize = true;
            this.chk_RandomStartGold.Location = new System.Drawing.Point(408, 55);
            this.chk_RandomStartGold.Name = "chk_RandomStartGold";
            this.chk_RandomStartGold.Size = new System.Drawing.Size(143, 17);
            this.chk_RandomStartGold.TabIndex = 30;
            this.chk_RandomStartGold.Text = "Randomize Starting Gold";
            this.adjustments.SetToolTip(this.chk_RandomStartGold, "Removes Parry/Fight bug found in original DWIII");
            this.chk_RandomStartGold.UseVisualStyleBackColor = true;
            this.chk_RandomStartGold.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RmManip
            // 
            this.chk_RmManip.AutoSize = true;
            this.chk_RmManip.Checked = true;
            this.chk_RmManip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RmManip.Location = new System.Drawing.Point(261, 102);
            this.chk_RmManip.Name = "chk_RmManip";
            this.chk_RmManip.Size = new System.Drawing.Size(133, 17);
            this.chk_RmManip.TabIndex = 29;
            this.chk_RmManip.Text = "Remove manipulations";
            this.adjustments.SetToolTip(this.chk_RmManip, "Implement DWIV RNG so any currently known manipulations won\'t work. Default Rando" +
        "mizer behavior.");
            this.chk_RmManip.UseVisualStyleBackColor = true;
            this.chk_RmManip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_WeapArmPower
            // 
            this.chk_WeapArmPower.AutoSize = true;
            this.chk_WeapArmPower.Location = new System.Drawing.Point(408, 9);
            this.chk_WeapArmPower.Name = "chk_WeapArmPower";
            this.chk_WeapArmPower.Size = new System.Drawing.Size(146, 17);
            this.chk_WeapArmPower.TabIndex = 27;
            this.chk_WeapArmPower.Text = "Display Equipment Power";
            this.adjustments.SetToolTip(this.chk_WeapArmPower, "Displays attack and defense power of equipment in Item menu. Item names are trunc" +
        "ated to allow this.");
            this.chk_WeapArmPower.UseVisualStyleBackColor = true;
            this.chk_WeapArmPower.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_Cod
            // 
            this.chk_Cod.AutoSize = true;
            this.chk_Cod.Checked = true;
            this.chk_Cod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Cod.Location = new System.Drawing.Point(261, 79);
            this.chk_Cod.Name = "chk_Cod";
            this.chk_Cod.Size = new System.Drawing.Size(147, 17);
            this.chk_Cod.TabIndex = 26;
            this.chk_Cod.Text = "Cold as a Cod Adjustment";
            this.adjustments.SetToolTip(this.chk_Cod, "Entire party is revived when wiped. Causes temporary graphical errors.");
            this.chk_Cod.UseVisualStyleBackColor = true;
            this.chk_Cod.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_SpeedUpMenus
            // 
            this.chk_SpeedUpMenus.AutoSize = true;
            this.chk_SpeedUpMenus.Checked = true;
            this.chk_SpeedUpMenus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SpeedUpMenus.Location = new System.Drawing.Point(261, 56);
            this.chk_SpeedUpMenus.Name = "chk_SpeedUpMenus";
            this.chk_SpeedUpMenus.Size = new System.Drawing.Size(107, 17);
            this.chk_SpeedUpMenus.TabIndex = 25;
            this.chk_SpeedUpMenus.Text = "Speed up Menus";
            this.adjustments.SetToolTip(this.chk_SpeedUpMenus, "Speeds up menus.");
            this.chk_SpeedUpMenus.UseVisualStyleBackColor = true;
            this.chk_SpeedUpMenus.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkNoLamiaOrbs
            // 
            this.chkNoLamiaOrbs.AutoSize = true;
            this.chkNoLamiaOrbs.Location = new System.Drawing.Point(408, 32);
            this.chkNoLamiaOrbs.Name = "chkNoLamiaOrbs";
            this.chkNoLamiaOrbs.Size = new System.Drawing.Size(151, 17);
            this.chkNoLamiaOrbs.TabIndex = 28;
            this.chkNoLamiaOrbs.Text = "Require No Orbs for Lamia";
            this.adjustments.SetToolTip(this.chkNoLamiaOrbs, "Able to hatch Lamia without any orbs.");
            this.chkNoLamiaOrbs.UseVisualStyleBackColor = true;
            this.chkNoLamiaOrbs.CheckedChanged += new System.EventHandler(this.determineFlags);
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
            this.cboEncounterRate.Size = new System.Drawing.Size(101, 21);
            this.cboEncounterRate.TabIndex = 22;
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
            this.cboGoldReq.Size = new System.Drawing.Size(101, 21);
            this.cboGoldReq.TabIndex = 21;
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
            this.cboExpGains.Size = new System.Drawing.Size(101, 21);
            this.cboExpGains.TabIndex = 20;
            this.cboExpGains.SelectedIndexChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkSpeedText
            // 
            this.chkSpeedText.AutoSize = true;
            this.chkSpeedText.Checked = true;
            this.chkSpeedText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpeedText.Location = new System.Drawing.Point(261, 33);
            this.chkSpeedText.Name = "chkSpeedText";
            this.chkSpeedText.Size = new System.Drawing.Size(115, 17);
            this.chkSpeedText.TabIndex = 24;
            this.chkSpeedText.Text = "Speedy Text Hack";
            this.adjustments.SetToolTip(this.chkSpeedText, "Speeds up text.");
            this.chkSpeedText.UseVisualStyleBackColor = true;
            this.chkSpeedText.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkFasterBattles
            // 
            this.chkFasterBattles.AutoSize = true;
            this.chkFasterBattles.Checked = true;
            this.chkFasterBattles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFasterBattles.Location = new System.Drawing.Point(261, 10);
            this.chkFasterBattles.Name = "chkFasterBattles";
            this.chkFasterBattles.Size = new System.Drawing.Size(137, 17);
            this.chkFasterBattles.TabIndex = 23;
            this.chkFasterBattles.Text = "Increased Battle Speed";
            this.adjustments.SetToolTip(this.chkFasterBattles, "Speeds up menus and text in battle.");
            this.chkFasterBattles.UseVisualStyleBackColor = true;
            this.chkFasterBattles.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chk_RmNewTown);
            this.tabPage8.Controls.Add(this.chk_RemoveMtnDrgQueen);
            this.tabPage8.Controls.Add(this.chk_RmMtnNecrogond);
            this.tabPage8.Controls.Add(this.chk_lbtoCharlock);
            this.tabPage8.Controls.Add(this.chk_RemLancelMountains);
            this.tabPage8.Controls.Add(this.chk_RemoveBirdRequirement);
            this.tabPage8.Controls.Add(this.label11);
            this.tabPage8.Controls.Add(this.chk_SepBarGaia);
            this.tabPage8.Controls.Add(this.chkRandomizeMap);
            this.tabPage8.Controls.Add(this.chkSmallMap);
            this.tabPage8.Controls.Add(this.chkRandMonsterZones);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(631, 190);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Map";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // chk_RmNewTown
            // 
            this.chk_RmNewTown.AutoSize = true;
            this.chk_RmNewTown.Location = new System.Drawing.Point(179, 157);
            this.chk_RmNewTown.Name = "chk_RmNewTown";
            this.chk_RmNewTown.Size = new System.Drawing.Size(161, 17);
            this.chk_RmNewTown.TabIndex = 68;
            this.chk_RmNewTown.Text = "Do not generate New Town.";
            this.chk_RmNewTown.UseVisualStyleBackColor = true;
            this.chk_RmNewTown.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RemoveMtnDrgQueen
            // 
            this.chk_RemoveMtnDrgQueen.AutoSize = true;
            this.chk_RemoveMtnDrgQueen.Location = new System.Drawing.Point(179, 19);
            this.chk_RemoveMtnDrgQueen.Name = "chk_RemoveMtnDrgQueen";
            this.chk_RemoveMtnDrgQueen.Size = new System.Drawing.Size(259, 17);
            this.chk_RemoveMtnDrgQueen.TabIndex = 67;
            this.chk_RemoveMtnDrgQueen.Text = "Remove Mountains around Dragon Queen Castle";
            this.chk_RemoveMtnDrgQueen.UseVisualStyleBackColor = true;
            this.chk_RemoveMtnDrgQueen.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RmMtnNecrogond
            // 
            this.chk_RmMtnNecrogond.AutoSize = true;
            this.chk_RmMtnNecrogond.Location = new System.Drawing.Point(179, 88);
            this.chk_RmMtnNecrogond.Name = "chk_RmMtnNecrogond";
            this.chk_RmMtnNecrogond.Size = new System.Drawing.Size(249, 17);
            this.chk_RmMtnNecrogond.TabIndex = 66;
            this.chk_RmMtnNecrogond.Text = "Remove mountains around Cave of Necrogond";
            this.adjustments.SetToolTip(this.chk_RmMtnNecrogond, "Remove mountains around Cave of Necrogond and shrine.");
            this.chk_RmMtnNecrogond.UseVisualStyleBackColor = true;
            this.chk_RmMtnNecrogond.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_lbtoCharlock
            // 
            this.chk_lbtoCharlock.AutoSize = true;
            this.chk_lbtoCharlock.Location = new System.Drawing.Point(179, 134);
            this.chk_lbtoCharlock.Name = "chk_lbtoCharlock";
            this.chk_lbtoCharlock.Size = new System.Drawing.Size(171, 17);
            this.chk_lbtoCharlock.TabIndex = 65;
            this.chk_lbtoCharlock.Text = "Land bridge to Charlock Castle";
            this.adjustments.SetToolTip(this.chk_lbtoCharlock, "Removes water and mountains around Charlock Castle");
            this.chk_lbtoCharlock.UseVisualStyleBackColor = true;
            this.chk_lbtoCharlock.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RemLancelMountains
            // 
            this.chk_RemLancelMountains.AutoSize = true;
            this.chk_RemLancelMountains.Location = new System.Drawing.Point(179, 65);
            this.chk_RemLancelMountains.Name = "chk_RemLancelMountains";
            this.chk_RemLancelMountains.Size = new System.Drawing.Size(216, 17);
            this.chk_RemLancelMountains.TabIndex = 64;
            this.chk_RemLancelMountains.Text = "Remove mountains around Lancel Cave";
            this.adjustments.SetToolTip(this.chk_RemLancelMountains, "Removes mountains around Lancel Cave to allow party in and not require Final Key");
            this.chk_RemLancelMountains.UseVisualStyleBackColor = true;
            this.chk_RemLancelMountains.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RemoveBirdRequirement
            // 
            this.chk_RemoveBirdRequirement.AutoSize = true;
            this.chk_RemoveBirdRequirement.Location = new System.Drawing.Point(179, 111);
            this.chk_RemoveBirdRequirement.Name = "chk_RemoveBirdRequirement";
            this.chk_RemoveBirdRequirement.Size = new System.Drawing.Size(235, 17);
            this.chk_RemoveBirdRequirement.TabIndex = 63;
            this.chk_RemoveBirdRequirement.Text = "Remove bird requirement for Baramos Castle";
            this.chk_RemoveBirdRequirement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.adjustments.SetToolTip(this.chk_RemoveBirdRequirement, "Removes mountains around Baramos Castle");
            this.chk_RemoveBirdRequirement.UseVisualStyleBackColor = true;
            this.chk_RemoveBirdRequirement.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Map";
            // 
            // chk_SepBarGaia
            // 
            this.chk_SepBarGaia.AutoSize = true;
            this.chk_SepBarGaia.Location = new System.Drawing.Point(179, 42);
            this.chk_SepBarGaia.Name = "chk_SepBarGaia";
            this.chk_SepBarGaia.Size = new System.Drawing.Size(213, 17);
            this.chk_SepBarGaia.TabIndex = 62;
            this.chk_SepBarGaia.Text = "Separate Baramos Castle and Gaia\'s Pit";
            this.adjustments.SetToolTip(this.chk_SepBarGaia, "Separates Baramos Castle and Gaia\'s Pit. 3 Wing of Wyverns will be in Baramos Cas" +
        "tle. Prepare yourself so you don\'t softlock.");
            this.chk_SepBarGaia.UseVisualStyleBackColor = true;
            this.chk_SepBarGaia.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandomizeMap
            // 
            this.chkRandomizeMap.AutoSize = true;
            this.chkRandomizeMap.Checked = true;
            this.chkRandomizeMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeMap.Location = new System.Drawing.Point(6, 19);
            this.chkRandomizeMap.Name = "chkRandomizeMap";
            this.chkRandomizeMap.Size = new System.Drawing.Size(102, 17);
            this.chkRandomizeMap.TabIndex = 59;
            this.chkRandomizeMap.Text = "Randomize map";
            this.adjustments.SetToolTip(this.chkRandomizeMap, "Randomizes overworld and Alefgard maps.");
            this.chkRandomizeMap.UseVisualStyleBackColor = true;
            this.chkRandomizeMap.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkSmallMap
            // 
            this.chkSmallMap.AutoSize = true;
            this.chkSmallMap.Checked = true;
            this.chkSmallMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSmallMap.Location = new System.Drawing.Point(6, 65);
            this.chkSmallMap.Name = "chkSmallMap";
            this.chkSmallMap.Size = new System.Drawing.Size(75, 17);
            this.chkSmallMap.TabIndex = 61;
            this.chkSmallMap.Text = "Small Map";
            this.adjustments.SetToolTip(this.chkSmallMap, "Generates a map that is 128x128 (standard is 256x256)");
            this.chkSmallMap.UseVisualStyleBackColor = true;
            this.chkSmallMap.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandMonsterZones
            // 
            this.chkRandMonsterZones.AutoSize = true;
            this.chkRandMonsterZones.Checked = true;
            this.chkRandMonsterZones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandMonsterZones.Location = new System.Drawing.Point(6, 42);
            this.chkRandMonsterZones.Name = "chkRandMonsterZones";
            this.chkRandMonsterZones.Size = new System.Drawing.Size(150, 17);
            this.chkRandMonsterZones.TabIndex = 58;
            this.chkRandMonsterZones.Text = "Randomize monster zones";
            this.adjustments.SetToolTip(this.chkRandMonsterZones, "Randomizes where monster zones are located on the map.");
            this.chkRandMonsterZones.UseVisualStyleBackColor = true;
            this.chkRandMonsterZones.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkRandomizeGP);
            this.tabPage2.Controls.Add(this.chkRandomizeXP);
            this.tabPage2.Controls.Add(this.chk_RemMetalMonRun);
            this.tabPage2.Controls.Add(this.grpMonsterStat);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.chkRandEnemyPatterns);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(631, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monsters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeGP
            // 
            this.chkRandomizeGP.AutoSize = true;
            this.chkRandomizeGP.Checked = true;
            this.chkRandomizeGP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeGP.Location = new System.Drawing.Point(8, 98);
            this.chkRandomizeGP.Name = "chkRandomizeGP";
            this.chkRandomizeGP.Size = new System.Drawing.Size(102, 17);
            this.chkRandomizeGP.TabIndex = 48;
            this.chkRandomizeGP.Text = "Randomize gold";
            this.adjustments.SetToolTip(this.chkRandomizeGP, "Randomizes gold dropped by monsters.");
            this.chkRandomizeGP.UseVisualStyleBackColor = true;
            this.chkRandomizeGP.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandomizeXP
            // 
            this.chkRandomizeXP.AutoSize = true;
            this.chkRandomizeXP.Checked = true;
            this.chkRandomizeXP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeXP.Location = new System.Drawing.Point(8, 75);
            this.chkRandomizeXP.Name = "chkRandomizeXP";
            this.chkRandomizeXP.Size = new System.Drawing.Size(134, 17);
            this.chkRandomizeXP.TabIndex = 47;
            this.chkRandomizeXP.Text = "Randomize experience";
            this.adjustments.SetToolTip(this.chkRandomizeXP, "Randomizes experience given my monsters.");
            this.chkRandomizeXP.UseVisualStyleBackColor = true;
            this.chkRandomizeXP.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RemMetalMonRun
            // 
            this.chk_RemMetalMonRun.AutoSize = true;
            this.chk_RemMetalMonRun.Location = new System.Drawing.Point(169, 98);
            this.chk_RemMetalMonRun.Name = "chk_RemMetalMonRun";
            this.chk_RemMetalMonRun.Size = new System.Drawing.Size(145, 17);
            this.chk_RemMetalMonRun.TabIndex = 46;
            this.chk_RemMetalMonRun.Text = "Remove Metal Mon. Run";
            this.adjustments.SetToolTip(this.chk_RemMetalMonRun, "Metal Slimes and Metal Babble are less likely to have running in their logic");
            this.chk_RemMetalMonRun.UseVisualStyleBackColor = true;
            this.chk_RemMetalMonRun.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandEnemyPatterns
            // 
            this.chkRandEnemyPatterns.AutoSize = true;
            this.chkRandEnemyPatterns.Checked = true;
            this.chkRandEnemyPatterns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandEnemyPatterns.Location = new System.Drawing.Point(169, 75);
            this.chkRandEnemyPatterns.Name = "chkRandEnemyPatterns";
            this.chkRandEnemyPatterns.Size = new System.Drawing.Size(154, 17);
            this.chkRandEnemyPatterns.TabIndex = 44;
            this.chkRandEnemyPatterns.Text = "Randomize enemy patterns";
            this.adjustments.SetToolTip(this.chkRandEnemyPatterns, "Randomizes enemy attack patterns.");
            this.chkRandEnemyPatterns.UseVisualStyleBackColor = true;
            this.chkRandEnemyPatterns.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chk_UseVanEquipValues);
            this.tabPage4.Controls.Add(this.chk_RmFighterPenalty);
            this.tabPage4.Controls.Add(this.lbl_TreasurePool);
            this.tabPage4.Controls.Add(this.chk_RemoveStartEqRestrictions);
            this.tabPage4.Controls.Add(this.chk_GoldenClaw);
            this.tabPage4.Controls.Add(this.chkRandEquip);
            this.tabPage4.Controls.Add(this.chkRandWhoCanEquip);
            this.tabPage4.Controls.Add(this.chkRandItemEffects);
            this.tabPage4.Controls.Add(this.chkRandTreasures);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(631, 190);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Treasures & Equipment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chk_UseVanEquipValues
            // 
            this.chk_UseVanEquipValues.AutoSize = true;
            this.chk_UseVanEquipValues.Location = new System.Drawing.Point(245, 53);
            this.chk_UseVanEquipValues.Name = "chk_UseVanEquipValues";
            this.chk_UseVanEquipValues.Size = new System.Drawing.Size(204, 17);
            this.chk_UseVanEquipValues.TabIndex = 66;
            this.chk_UseVanEquipValues.Text = "Use vanilla values for equipment stats";
            this.adjustments.SetToolTip(this.chk_UseVanEquipValues, "Randomizes equipment stats based on Vanilla game values");
            this.chk_UseVanEquipValues.UseVisualStyleBackColor = true;
            this.chk_UseVanEquipValues.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RmFighterPenalty
            // 
            this.chk_RmFighterPenalty.AutoSize = true;
            this.chk_RmFighterPenalty.Location = new System.Drawing.Point(245, 99);
            this.chk_RmFighterPenalty.Name = "chk_RmFighterPenalty";
            this.chk_RmFighterPenalty.Size = new System.Drawing.Size(183, 17);
            this.chk_RmFighterPenalty.TabIndex = 68;
            this.chk_RmFighterPenalty.Text = "Remove Fighter Weapon Penalty";
            this.adjustments.SetToolTip(this.chk_RmFighterPenalty, "Removes attack power penalty from some equipment the Fighter can equip.");
            this.chk_RmFighterPenalty.UseVisualStyleBackColor = true;
            this.chk_RmFighterPenalty.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // lbl_TreasurePool
            // 
            this.lbl_TreasurePool.AutoSize = true;
            this.lbl_TreasurePool.Location = new System.Drawing.Point(46, 54);
            this.lbl_TreasurePool.Name = "lbl_TreasurePool";
            this.lbl_TreasurePool.Size = new System.Drawing.Size(107, 13);
            this.lbl_TreasurePool.TabIndex = 75;
            this.lbl_TreasurePool.Text = "Add to Treasure Pool";
            // 
            // chk_RemoveStartEqRestrictions
            // 
            this.chk_RemoveStartEqRestrictions.AutoSize = true;
            this.chk_RemoveStartEqRestrictions.Location = new System.Drawing.Point(245, 76);
            this.chk_RemoveStartEqRestrictions.Name = "chk_RemoveStartEqRestrictions";
            this.chk_RemoveStartEqRestrictions.Size = new System.Drawing.Size(216, 17);
            this.chk_RemoveStartEqRestrictions.TabIndex = 67;
            this.chk_RemoveStartEqRestrictions.Text = "Remove Starting Equipment Restrictions";
            this.adjustments.SetToolTip(this.chk_RemoveStartEqRestrictions, "Removes low equipment stats for starting equipment (randomizer default is to keep" +
        " these low).");
            this.chk_RemoveStartEqRestrictions.UseVisualStyleBackColor = true;
            this.chk_RemoveStartEqRestrictions.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_GoldenClaw
            // 
            this.chk_GoldenClaw.AutoSize = true;
            this.chk_GoldenClaw.Location = new System.Drawing.Point(6, 76);
            this.chk_GoldenClaw.Name = "chk_GoldenClaw";
            this.chk_GoldenClaw.Size = new System.Drawing.Size(86, 17);
            this.chk_GoldenClaw.TabIndex = 62;
            this.chk_GoldenClaw.Text = "Golden Claw";
            this.adjustments.SetToolTip(this.chk_GoldenClaw, "Adds the Golden Claw to 1 random treasure chest");
            this.chk_GoldenClaw.UseVisualStyleBackColor = true;
            this.chk_GoldenClaw.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandEquip
            // 
            this.chkRandEquip.AutoSize = true;
            this.chkRandEquip.Checked = true;
            this.chkRandEquip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandEquip.Location = new System.Drawing.Point(245, 30);
            this.chkRandEquip.Name = "chkRandEquip";
            this.chkRandEquip.Size = new System.Drawing.Size(163, 17);
            this.chkRandEquip.TabIndex = 65;
            this.chkRandEquip.Text = "Randomize equipment power";
            this.adjustments.SetToolTip(this.chkRandEquip, "Randomizes weapon and armor power.");
            this.chkRandEquip.UseVisualStyleBackColor = true;
            this.chkRandEquip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandWhoCanEquip
            // 
            this.chkRandWhoCanEquip.AutoSize = true;
            this.chkRandWhoCanEquip.Location = new System.Drawing.Point(245, 7);
            this.chkRandWhoCanEquip.Name = "chkRandWhoCanEquip";
            this.chkRandWhoCanEquip.Size = new System.Drawing.Size(152, 17);
            this.chkRandWhoCanEquip.TabIndex = 64;
            this.chkRandWhoCanEquip.Text = "Randomize who can equip";
            this.adjustments.SetToolTip(this.chkRandWhoCanEquip, "Randomizes which classes can equip equipment.");
            this.chkRandWhoCanEquip.UseVisualStyleBackColor = true;
            this.chkRandWhoCanEquip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandItemEffects
            // 
            this.chkRandItemEffects.AutoSize = true;
            this.chkRandItemEffects.Location = new System.Drawing.Point(6, 7);
            this.chkRandItemEffects.Name = "chkRandItemEffects";
            this.chkRandItemEffects.Size = new System.Drawing.Size(136, 17);
            this.chkRandItemEffects.TabIndex = 60;
            this.chkRandItemEffects.Text = "Randomize item effects";
            this.adjustments.SetToolTip(this.chkRandItemEffects, "Randomizes effects of items.");
            this.chkRandItemEffects.UseVisualStyleBackColor = true;
            this.chkRandItemEffects.Visible = false;
            this.chkRandItemEffects.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandTreasures
            // 
            this.chkRandTreasures.AutoSize = true;
            this.chkRandTreasures.Checked = true;
            this.chkRandTreasures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandTreasures.Location = new System.Drawing.Point(6, 30);
            this.chkRandTreasures.Name = "chkRandTreasures";
            this.chkRandTreasures.Size = new System.Drawing.Size(125, 17);
            this.chkRandTreasures.TabIndex = 61;
            this.chkRandTreasures.Text = "Randomize treasures";
            this.adjustments.SetToolTip(this.chkRandTreasures, "Randomizes treasures found in chests and given by NPCs.");
            this.chkRandTreasures.UseVisualStyleBackColor = true;
            this.chkRandTreasures.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chk_LeafoftheWorldTree);
            this.tabPage6.Controls.Add(this.chk_RandomizeWeaponShops);
            this.tabPage6.Controls.Add(this.chk_LampofDarkness);
            this.tabPage6.Controls.Add(this.chk_WizardsRing);
            this.tabPage6.Controls.Add(this.chk_MeteoriteArmband);
            this.tabPage6.Controls.Add(this.chk_ShoesofHappiness);
            this.tabPage6.Controls.Add(this.lbl_ItemShops);
            this.tabPage6.Controls.Add(this.chk_SilverHarp);
            this.tabPage6.Controls.Add(this.chk_EchoingFlute);
            this.tabPage6.Controls.Add(this.chk_RingofLife);
            this.tabPage6.Controls.Add(this.chk_BookofSatori);
            this.tabPage6.Controls.Add(this.chk_Seeds);
            this.tabPage6.Controls.Add(this.chk_StoneofLife);
            this.tabPage6.Controls.Add(this.chkRandItemStores);
            this.tabPage6.Controls.Add(this.chk_Caturday);
            this.tabPage6.Controls.Add(this.chk_PoisonMothPowder);
            this.tabPage6.Controls.Add(this.chk_RandomizeInnPrices);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(631, 190);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Item & Weapon Shops & Inns";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chk_LeafoftheWorldTree
            // 
            this.chk_LeafoftheWorldTree.AutoSize = true;
            this.chk_LeafoftheWorldTree.Checked = true;
            this.chk_LeafoftheWorldTree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_LeafoftheWorldTree.Location = new System.Drawing.Point(315, 29);
            this.chk_LeafoftheWorldTree.Name = "chk_LeafoftheWorldTree";
            this.chk_LeafoftheWorldTree.Size = new System.Drawing.Size(133, 17);
            this.chk_LeafoftheWorldTree.TabIndex = 90;
            this.chk_LeafoftheWorldTree.Text = "Leaf of the World Tree";
            this.chk_LeafoftheWorldTree.UseVisualStyleBackColor = true;
            this.chk_LeafoftheWorldTree.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomizeWeaponShops
            // 
            this.chk_RandomizeWeaponShops.AutoSize = true;
            this.chk_RandomizeWeaponShops.Checked = true;
            this.chk_RandomizeWeaponShops.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandomizeWeaponShops.Location = new System.Drawing.Point(6, 52);
            this.chk_RandomizeWeaponShops.Name = "chk_RandomizeWeaponShops";
            this.chk_RandomizeWeaponShops.Size = new System.Drawing.Size(156, 17);
            this.chk_RandomizeWeaponShops.TabIndex = 81;
            this.chk_RandomizeWeaponShops.Text = "Randomize Weapon Shops";
            this.chk_RandomizeWeaponShops.UseVisualStyleBackColor = true;
            this.chk_RandomizeWeaponShops.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_LampofDarkness
            // 
            this.chk_LampofDarkness.AutoSize = true;
            this.chk_LampofDarkness.Checked = true;
            this.chk_LampofDarkness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_LampofDarkness.Location = new System.Drawing.Point(315, 121);
            this.chk_LampofDarkness.Name = "chk_LampofDarkness";
            this.chk_LampofDarkness.Size = new System.Drawing.Size(112, 17);
            this.chk_LampofDarkness.TabIndex = 94;
            this.chk_LampofDarkness.Text = "Lamp of Darkness";
            this.chk_LampofDarkness.UseVisualStyleBackColor = true;
            this.chk_LampofDarkness.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_WizardsRing
            // 
            this.chk_WizardsRing.AutoSize = true;
            this.chk_WizardsRing.Checked = true;
            this.chk_WizardsRing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_WizardsRing.Location = new System.Drawing.Point(315, 98);
            this.chk_WizardsRing.Name = "chk_WizardsRing";
            this.chk_WizardsRing.Size = new System.Drawing.Size(91, 17);
            this.chk_WizardsRing.TabIndex = 93;
            this.chk_WizardsRing.Text = "Wizard\'s Ring";
            this.chk_WizardsRing.UseVisualStyleBackColor = true;
            this.chk_WizardsRing.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_MeteoriteArmband
            // 
            this.chk_MeteoriteArmband.AutoSize = true;
            this.chk_MeteoriteArmband.Checked = true;
            this.chk_MeteoriteArmband.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_MeteoriteArmband.Location = new System.Drawing.Point(315, 75);
            this.chk_MeteoriteArmband.Name = "chk_MeteoriteArmband";
            this.chk_MeteoriteArmband.Size = new System.Drawing.Size(115, 17);
            this.chk_MeteoriteArmband.TabIndex = 92;
            this.chk_MeteoriteArmband.Text = "Meteorite Armband";
            this.chk_MeteoriteArmband.UseVisualStyleBackColor = true;
            this.chk_MeteoriteArmband.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_ShoesofHappiness
            // 
            this.chk_ShoesofHappiness.AutoSize = true;
            this.chk_ShoesofHappiness.Checked = true;
            this.chk_ShoesofHappiness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ShoesofHappiness.Location = new System.Drawing.Point(315, 52);
            this.chk_ShoesofHappiness.Name = "chk_ShoesofHappiness";
            this.chk_ShoesofHappiness.Size = new System.Drawing.Size(121, 17);
            this.chk_ShoesofHappiness.TabIndex = 91;
            this.chk_ShoesofHappiness.Text = "Shoes of Happiness";
            this.chk_ShoesofHappiness.UseVisualStyleBackColor = true;
            this.chk_ShoesofHappiness.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // lbl_ItemShops
            // 
            this.lbl_ItemShops.AutoSize = true;
            this.lbl_ItemShops.Location = new System.Drawing.Point(268, 7);
            this.lbl_ItemShops.Name = "lbl_ItemShops";
            this.lbl_ItemShops.Size = new System.Drawing.Size(94, 13);
            this.lbl_ItemShops.TabIndex = 58;
            this.lbl_ItemShops.Text = "Add to Item Shops";
            // 
            // chk_SilverHarp
            // 
            this.chk_SilverHarp.AutoSize = true;
            this.chk_SilverHarp.Checked = true;
            this.chk_SilverHarp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SilverHarp.Location = new System.Drawing.Point(205, 145);
            this.chk_SilverHarp.Name = "chk_SilverHarp";
            this.chk_SilverHarp.Size = new System.Drawing.Size(78, 17);
            this.chk_SilverHarp.TabIndex = 89;
            this.chk_SilverHarp.Text = "Silver Harp";
            this.chk_SilverHarp.UseVisualStyleBackColor = true;
            this.chk_SilverHarp.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_EchoingFlute
            // 
            this.chk_EchoingFlute.AutoSize = true;
            this.chk_EchoingFlute.Checked = true;
            this.chk_EchoingFlute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_EchoingFlute.Location = new System.Drawing.Point(205, 121);
            this.chk_EchoingFlute.Name = "chk_EchoingFlute";
            this.chk_EchoingFlute.Size = new System.Drawing.Size(91, 17);
            this.chk_EchoingFlute.TabIndex = 88;
            this.chk_EchoingFlute.Text = "Echoing Flute";
            this.chk_EchoingFlute.UseVisualStyleBackColor = true;
            this.chk_EchoingFlute.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RingofLife
            // 
            this.chk_RingofLife.AutoSize = true;
            this.chk_RingofLife.Checked = true;
            this.chk_RingofLife.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RingofLife.Location = new System.Drawing.Point(205, 98);
            this.chk_RingofLife.Name = "chk_RingofLife";
            this.chk_RingofLife.Size = new System.Drawing.Size(80, 17);
            this.chk_RingofLife.TabIndex = 87;
            this.chk_RingofLife.Text = "Ring of Life";
            this.chk_RingofLife.UseVisualStyleBackColor = true;
            this.chk_RingofLife.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_BookofSatori
            // 
            this.chk_BookofSatori.AutoSize = true;
            this.chk_BookofSatori.Checked = true;
            this.chk_BookofSatori.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_BookofSatori.Location = new System.Drawing.Point(205, 75);
            this.chk_BookofSatori.Name = "chk_BookofSatori";
            this.chk_BookofSatori.Size = new System.Drawing.Size(93, 17);
            this.chk_BookofSatori.TabIndex = 86;
            this.chk_BookofSatori.Text = "Book of Satori";
            this.chk_BookofSatori.UseVisualStyleBackColor = true;
            this.chk_BookofSatori.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_Seeds
            // 
            this.chk_Seeds.AutoSize = true;
            this.chk_Seeds.Checked = true;
            this.chk_Seeds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Seeds.Location = new System.Drawing.Point(205, 52);
            this.chk_Seeds.Name = "chk_Seeds";
            this.chk_Seeds.Size = new System.Drawing.Size(56, 17);
            this.chk_Seeds.TabIndex = 85;
            this.chk_Seeds.Text = "Seeds";
            this.chk_Seeds.UseVisualStyleBackColor = true;
            this.chk_Seeds.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_StoneofLife
            // 
            this.chk_StoneofLife.AutoSize = true;
            this.chk_StoneofLife.Checked = true;
            this.chk_StoneofLife.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_StoneofLife.Location = new System.Drawing.Point(205, 29);
            this.chk_StoneofLife.Name = "chk_StoneofLife";
            this.chk_StoneofLife.Size = new System.Drawing.Size(86, 17);
            this.chk_StoneofLife.TabIndex = 84;
            this.chk_StoneofLife.Text = "Stone of Life";
            this.chk_StoneofLife.UseVisualStyleBackColor = true;
            this.chk_StoneofLife.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandItemStores
            // 
            this.chkRandItemStores.AutoSize = true;
            this.chkRandItemStores.Checked = true;
            this.chkRandItemStores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandItemStores.Location = new System.Drawing.Point(6, 29);
            this.chkRandItemStores.Name = "chkRandItemStores";
            this.chkRandItemStores.Size = new System.Drawing.Size(135, 17);
            this.chkRandItemStores.TabIndex = 80;
            this.chkRandItemStores.Text = "Randomize Item Shops";
            this.chkRandItemStores.UseVisualStyleBackColor = true;
            this.chkRandItemStores.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_Caturday
            // 
            this.chk_Caturday.AutoSize = true;
            this.chk_Caturday.Location = new System.Drawing.Point(6, 75);
            this.chk_Caturday.Name = "chk_Caturday";
            this.chk_Caturday.Size = new System.Drawing.Size(68, 17);
            this.chk_Caturday.TabIndex = 82;
            this.chk_Caturday.Text = "Caturday";
            this.adjustments.SetToolTip(this.chk_Caturday, "Ensures that Animal Suits will be found in at least 1 weapon shop. Will replace t" +
        "he first Item in the shop list");
            this.chk_Caturday.UseVisualStyleBackColor = true;
            this.chk_Caturday.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_PoisonMothPowder
            // 
            this.chk_PoisonMothPowder.AutoSize = true;
            this.chk_PoisonMothPowder.Checked = true;
            this.chk_PoisonMothPowder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_PoisonMothPowder.Location = new System.Drawing.Point(315, 145);
            this.chk_PoisonMothPowder.Name = "chk_PoisonMothPowder";
            this.chk_PoisonMothPowder.Size = new System.Drawing.Size(124, 17);
            this.chk_PoisonMothPowder.TabIndex = 95;
            this.chk_PoisonMothPowder.Text = "Poison Moth Powder";
            this.chk_PoisonMothPowder.UseVisualStyleBackColor = true;
            this.chk_PoisonMothPowder.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomizeInnPrices
            // 
            this.chk_RandomizeInnPrices.AutoSize = true;
            this.chk_RandomizeInnPrices.Checked = true;
            this.chk_RandomizeInnPrices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandomizeInnPrices.Location = new System.Drawing.Point(6, 145);
            this.chk_RandomizeInnPrices.Name = "chk_RandomizeInnPrices";
            this.chk_RandomizeInnPrices.Size = new System.Drawing.Size(129, 17);
            this.chk_RandomizeInnPrices.TabIndex = 83;
            this.chk_RandomizeInnPrices.Text = "Randomize Inn Prices";
            this.adjustments.SetToolTip(this.chk_RandomizeInnPrices, "Randomizes the inn price from 1-100 GP per party member. Each inn is a different " +
        "value.");
            this.chk_RandomizeInnPrices.UseVisualStyleBackColor = true;
            this.chk_RandomizeInnPrices.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chk_ChangeDefaultParty);
            this.tabPage3.Controls.Add(this.chkFourJobFiesta);
            this.tabPage3.Controls.Add(this.chkRandStatGains);
            this.tabPage3.Controls.Add(this.chkRandSpellStrength);
            this.tabPage3.Controls.Add(this.chkRandSpellLearning);
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
            this.tabPage3.Size = new System.Drawing.Size(631, 190);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Characters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chk_ChangeDefaultParty
            // 
            this.chk_ChangeDefaultParty.AutoSize = true;
            this.chk_ChangeDefaultParty.Location = new System.Drawing.Point(7, 8);
            this.chk_ChangeDefaultParty.Name = "chk_ChangeDefaultParty";
            this.chk_ChangeDefaultParty.Size = new System.Drawing.Size(173, 17);
            this.chk_ChangeDefaultParty.TabIndex = 134;
            this.chk_ChangeDefaultParty.Text = "Change Default Party Members";
            this.adjustments.SetToolTip(this.chk_ChangeDefaultParty, "When unchecked, standard party members in Luisa\'s Place are unchanged. When check" +
        "ed, shows options for changing party members.");
            this.chk_ChangeDefaultParty.UseVisualStyleBackColor = true;
            this.chk_ChangeDefaultParty.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkFourJobFiesta
            // 
            this.chkFourJobFiesta.AutoSize = true;
            this.chkFourJobFiesta.Location = new System.Drawing.Point(465, 142);
            this.chkFourJobFiesta.Name = "chkFourJobFiesta";
            this.chkFourJobFiesta.Size = new System.Drawing.Size(157, 17);
            this.chkFourJobFiesta.TabIndex = 133;
            this.chkFourJobFiesta.Text = "Four Job Fiesta adjustments";
            this.adjustments.SetToolTip(this.chkFourJobFiesta, "Allows the hero to be removed from the party, the hero to change classes, and any" +
        " hero to become a sage.");
            this.chkFourJobFiesta.UseVisualStyleBackColor = true;
            this.chkFourJobFiesta.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandStatGains
            // 
            this.chkRandStatGains.AutoSize = true;
            this.chkRandStatGains.Checked = true;
            this.chkRandStatGains.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandStatGains.Location = new System.Drawing.Point(7, 141);
            this.chkRandStatGains.Name = "chkRandStatGains";
            this.chkRandStatGains.Size = new System.Drawing.Size(127, 17);
            this.chkRandStatGains.TabIndex = 130;
            this.chkRandStatGains.Text = "Randomize stat gains";
            this.adjustments.SetToolTip(this.chkRandStatGains, "Randomizes stats gained by classes at level up.");
            this.chkRandStatGains.UseVisualStyleBackColor = true;
            this.chkRandStatGains.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandSpellStrength
            // 
            this.chkRandSpellStrength.AutoSize = true;
            this.chkRandSpellStrength.Checked = true;
            this.chkRandSpellStrength.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandSpellStrength.Location = new System.Drawing.Point(312, 142);
            this.chkRandSpellStrength.Name = "chkRandSpellStrength";
            this.chkRandSpellStrength.Size = new System.Drawing.Size(149, 17);
            this.chkRandSpellStrength.TabIndex = 132;
            this.chkRandSpellStrength.Text = "Randomize spell strengths";
            this.adjustments.SetToolTip(this.chkRandSpellStrength, "Randomizes the strength of spells.");
            this.chkRandSpellStrength.UseVisualStyleBackColor = true;
            this.chkRandSpellStrength.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandSpellLearning
            // 
            this.chkRandSpellLearning.AutoSize = true;
            this.chkRandSpellLearning.Checked = true;
            this.chkRandSpellLearning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandSpellLearning.Location = new System.Drawing.Point(156, 142);
            this.chkRandSpellLearning.Name = "chkRandSpellLearning";
            this.chkRandSpellLearning.Size = new System.Drawing.Size(143, 17);
            this.chkRandSpellLearning.TabIndex = 131;
            this.chkRandSpellLearning.Text = "Randomize spell learning";
            this.adjustments.SetToolTip(this.chkRandSpellLearning, "Randomizes the class and level spells are learned. Field and battle spells are le" +
        "arned separately.");
            this.chkRandSpellLearning.UseVisualStyleBackColor = true;
            this.chkRandSpellLearning.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandHero
            // 
            this.chk_RandHero.AutoSize = true;
            this.chk_RandHero.Location = new System.Drawing.Point(539, 112);
            this.chk_RandHero.Name = "chk_RandHero";
            this.chk_RandHero.Size = new System.Drawing.Size(49, 17);
            this.chk_RandHero.TabIndex = 129;
            this.chk_RandHero.Text = "Hero";
            this.chk_RandHero.UseVisualStyleBackColor = true;
            this.chk_RandHero.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSage
            // 
            this.chk_RandSage.AutoSize = true;
            this.chk_RandSage.Location = new System.Drawing.Point(539, 89);
            this.chk_RandSage.Name = "chk_RandSage";
            this.chk_RandSage.Size = new System.Drawing.Size(51, 17);
            this.chk_RandSage.TabIndex = 128;
            this.chk_RandSage.Text = "Sage";
            this.chk_RandSage.UseVisualStyleBackColor = true;
            this.chk_RandSage.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandGoofOff
            // 
            this.chk_RandGoofOff.AutoSize = true;
            this.chk_RandGoofOff.Checked = true;
            this.chk_RandGoofOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandGoofOff.Location = new System.Drawing.Point(539, 66);
            this.chk_RandGoofOff.Name = "chk_RandGoofOff";
            this.chk_RandGoofOff.Size = new System.Drawing.Size(66, 17);
            this.chk_RandGoofOff.TabIndex = 127;
            this.chk_RandGoofOff.Text = "Goof-Off";
            this.chk_RandGoofOff.UseVisualStyleBackColor = true;
            this.chk_RandGoofOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandMerchant
            // 
            this.chk_RandMerchant.AutoSize = true;
            this.chk_RandMerchant.Checked = true;
            this.chk_RandMerchant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandMerchant.Location = new System.Drawing.Point(539, 43);
            this.chk_RandMerchant.Name = "chk_RandMerchant";
            this.chk_RandMerchant.Size = new System.Drawing.Size(71, 17);
            this.chk_RandMerchant.TabIndex = 126;
            this.chk_RandMerchant.Text = "Merchant";
            this.chk_RandMerchant.UseVisualStyleBackColor = true;
            this.chk_RandMerchant.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandFighter
            // 
            this.chk_RandFighter.AutoSize = true;
            this.chk_RandFighter.Checked = true;
            this.chk_RandFighter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandFighter.Location = new System.Drawing.Point(465, 112);
            this.chk_RandFighter.Name = "chk_RandFighter";
            this.chk_RandFighter.Size = new System.Drawing.Size(58, 17);
            this.chk_RandFighter.TabIndex = 125;
            this.chk_RandFighter.Text = "Fighter";
            this.chk_RandFighter.UseVisualStyleBackColor = true;
            this.chk_RandFighter.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandWizard
            // 
            this.chk_RandWizard.Checked = true;
            this.chk_RandWizard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandWizard.Location = new System.Drawing.Point(465, 89);
            this.chk_RandWizard.Name = "chk_RandWizard";
            this.chk_RandWizard.Size = new System.Drawing.Size(68, 17);
            this.chk_RandWizard.TabIndex = 124;
            this.chk_RandWizard.Text = "Wizard";
            this.chk_RandWizard.UseVisualStyleBackColor = true;
            this.chk_RandWizard.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandPilgrim
            // 
            this.chk_RandPilgrim.AutoSize = true;
            this.chk_RandPilgrim.Checked = true;
            this.chk_RandPilgrim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandPilgrim.Location = new System.Drawing.Point(465, 66);
            this.chk_RandPilgrim.Name = "chk_RandPilgrim";
            this.chk_RandPilgrim.Size = new System.Drawing.Size(56, 17);
            this.chk_RandPilgrim.TabIndex = 123;
            this.chk_RandPilgrim.Text = "Pilgrim";
            this.chk_RandPilgrim.UseVisualStyleBackColor = true;
            this.chk_RandPilgrim.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSoldier
            // 
            this.chk_RandSoldier.AutoSize = true;
            this.chk_RandSoldier.Checked = true;
            this.chk_RandSoldier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandSoldier.Location = new System.Drawing.Point(465, 43);
            this.chk_RandSoldier.Name = "chk_RandSoldier";
            this.chk_RandSoldier.Size = new System.Drawing.Size(58, 17);
            this.chk_RandSoldier.TabIndex = 122;
            this.chk_RandSoldier.Text = "Soldier";
            this.chk_RandSoldier.UseVisualStyleBackColor = true;
            this.chk_RandSoldier.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomGender
            // 
            this.chk_RandomGender.AutoSize = true;
            this.chk_RandomGender.Location = new System.Drawing.Point(156, 31);
            this.chk_RandomGender.Name = "chk_RandomGender";
            this.chk_RandomGender.Size = new System.Drawing.Size(117, 17);
            this.chk_RandomGender.TabIndex = 111;
            this.chk_RandomGender.Text = "Randomize Gender";
            this.adjustments.SetToolTip(this.chk_RandomGender, "Randomizes gender of party members.");
            this.chk_RandomGender.UseVisualStyleBackColor = true;
            this.chk_RandomGender.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomClass
            // 
            this.chk_RandomClass.AutoSize = true;
            this.chk_RandomClass.Location = new System.Drawing.Point(312, 31);
            this.chk_RandomClass.Name = "chk_RandomClass";
            this.chk_RandomClass.Size = new System.Drawing.Size(107, 17);
            this.chk_RandomClass.TabIndex = 112;
            this.chk_RandomClass.Text = "Randomize Class";
            this.adjustments.SetToolTip(this.chk_RandomClass, "Randomizes the class of party members.");
            this.chk_RandomClass.UseVisualStyleBackColor = true;
            this.chk_RandomClass.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomName
            // 
            this.chk_RandomName.AutoSize = true;
            this.chk_RandomName.Location = new System.Drawing.Point(7, 31);
            this.chk_RandomName.Name = "chk_RandomName";
            this.chk_RandomName.Size = new System.Drawing.Size(115, 17);
            this.chk_RandomName.TabIndex = 110;
            this.chk_RandomName.Text = "Randomize Names";
            this.adjustments.SetToolTip(this.chk_RandomName, "Randomizes the name of party members. Names are from other DW/DQ games.");
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
            this.cboGender3.Location = new System.Drawing.Point(156, 108);
            this.cboGender3.Name = "cboGender3";
            this.cboGender3.Size = new System.Drawing.Size(150, 21);
            this.cboGender3.TabIndex = 118;
            // 
            // cboGender2
            // 
            this.cboGender2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender2.FormattingEnabled = true;
            this.cboGender2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender2.Location = new System.Drawing.Point(156, 81);
            this.cboGender2.Name = "cboGender2";
            this.cboGender2.Size = new System.Drawing.Size(150, 21);
            this.cboGender2.TabIndex = 117;
            // 
            // cboGender1
            // 
            this.cboGender1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender1.FormattingEnabled = true;
            this.cboGender1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender1.Location = new System.Drawing.Point(156, 54);
            this.cboGender1.Name = "cboGender1";
            this.cboGender1.Size = new System.Drawing.Size(150, 21);
            this.cboGender1.TabIndex = 116;
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
            this.cboClass3.Location = new System.Drawing.Point(312, 108);
            this.cboClass3.Name = "cboClass3";
            this.cboClass3.Size = new System.Drawing.Size(138, 21);
            this.cboClass3.TabIndex = 121;
            this.cboClass3.SelectedIndexChanged += new System.EventHandler(this.cboClass3_SelectedIndexChanged);
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
            this.cboClass2.Location = new System.Drawing.Point(312, 81);
            this.cboClass2.Name = "cboClass2";
            this.cboClass2.Size = new System.Drawing.Size(138, 21);
            this.cboClass2.TabIndex = 120;
            this.cboClass2.SelectedIndexChanged += new System.EventHandler(this.cboClass2_SelectedIndexChanged);
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
            this.cboClass1.Location = new System.Drawing.Point(312, 54);
            this.cboClass1.Name = "cboClass1";
            this.cboClass1.Size = new System.Drawing.Size(138, 21);
            this.cboClass1.TabIndex = 119;
            this.cboClass1.SelectedIndexChanged += new System.EventHandler(this.cboClass1_SelectedIndexChanged);
            // 
            // txtCharName2
            // 
            this.txtCharName2.Location = new System.Drawing.Point(7, 80);
            this.txtCharName2.MaxLength = 8;
            this.txtCharName2.Name = "txtCharName2";
            this.txtCharName2.Size = new System.Drawing.Size(143, 20);
            this.txtCharName2.TabIndex = 114;
            // 
            // txtCharName3
            // 
            this.txtCharName3.Location = new System.Drawing.Point(7, 107);
            this.txtCharName3.MaxLength = 8;
            this.txtCharName3.Name = "txtCharName3";
            this.txtCharName3.Size = new System.Drawing.Size(143, 20);
            this.txtCharName3.TabIndex = 115;
            // 
            // txtCharName1
            // 
            this.txtCharName1.Location = new System.Drawing.Point(7, 54);
            this.txtCharName1.MaxLength = 8;
            this.txtCharName1.Name = "txtCharName1";
            this.txtCharName1.Size = new System.Drawing.Size(143, 20);
            this.txtCharName1.TabIndex = 113;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chkRemoveParryFight);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(631, 190);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fixes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chkRemoveParryFight
            // 
            this.chkRemoveParryFight.AutoSize = true;
            this.chkRemoveParryFight.Checked = true;
            this.chkRemoveParryFight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveParryFight.Location = new System.Drawing.Point(6, 6);
            this.chkRemoveParryFight.Name = "chkRemoveParryFight";
            this.chkRemoveParryFight.Size = new System.Drawing.Size(143, 17);
            this.chkRemoveParryFight.TabIndex = 140;
            this.chkRemoveParryFight.Text = "Remove Parry/Fight Bug";
            this.adjustments.SetToolTip(this.chkRemoveParryFight, "Removes Parry/Fight bug found in original DWIII");
            this.chkRemoveParryFight.UseVisualStyleBackColor = true;
            this.chkRemoveParryFight.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.chk_GhostToCasket);
            this.tabPage7.Controls.Add(this.chk_RandSpriteColor);
            this.tabPage7.Controls.Add(this.chk_ChangeHeroAge);
            this.tabPage7.Controls.Add(this.chk_LowerCaseMenus);
            this.tabPage7.Controls.Add(this.chk_FixSlimeSnail);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(631, 190);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Cosmetic";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // chk_GhostToCasket
            // 
            this.chk_GhostToCasket.AutoSize = true;
            this.chk_GhostToCasket.Location = new System.Drawing.Point(7, 100);
            this.chk_GhostToCasket.Name = "chk_GhostToCasket";
            this.chk_GhostToCasket.Size = new System.Drawing.Size(152, 17);
            this.chk_GhostToCasket.TabIndex = 144;
            this.chk_GhostToCasket.Text = "Change Ghosts to Caskets";
            this.adjustments.SetToolTip(this.chk_GhostToCasket, "This will change dead party members from ghosts into caskets (palls) and adjusts " +
        "relevant text.");
            this.chk_GhostToCasket.UseVisualStyleBackColor = true;
            // 
            // chk_RandSpriteColor
            // 
            this.chk_RandSpriteColor.AutoSize = true;
            this.chk_RandSpriteColor.Location = new System.Drawing.Point(6, 76);
            this.chk_RandSpriteColor.Name = "chk_RandSpriteColor";
            this.chk_RandSpriteColor.Size = new System.Drawing.Size(141, 17);
            this.chk_RandSpriteColor.TabIndex = 143;
            this.chk_RandSpriteColor.Text = "Randomize Sprite Colors";
            this.adjustments.SetToolTip(this.chk_RandSpriteColor, "Randomizes the colors of overworld sprites. There may be some interesting combina" +
        "tions.");
            this.chk_RandSpriteColor.UseVisualStyleBackColor = true;
            // 
            // chk_ChangeHeroAge
            // 
            this.chk_ChangeHeroAge.AutoSize = true;
            this.chk_ChangeHeroAge.Location = new System.Drawing.Point(6, 53);
            this.chk_ChangeHeroAge.Name = "chk_ChangeHeroAge";
            this.chk_ChangeHeroAge.Size = new System.Drawing.Size(118, 17);
            this.chk_ChangeHeroAge.TabIndex = 142;
            this.chk_ChangeHeroAge.Text = "Change Hero\'s Age";
            this.adjustments.SetToolTip(this.chk_ChangeHeroAge, "Changes the hero\'s age in opening to a random number.");
            this.chk_ChangeHeroAge.UseVisualStyleBackColor = true;
            // 
            // chk_LowerCaseMenus
            // 
            this.chk_LowerCaseMenus.AutoSize = true;
            this.chk_LowerCaseMenus.Location = new System.Drawing.Point(6, 6);
            this.chk_LowerCaseMenus.Name = "chk_LowerCaseMenus";
            this.chk_LowerCaseMenus.Size = new System.Drawing.Size(131, 17);
            this.chk_LowerCaseMenus.TabIndex = 0;
            this.chk_LowerCaseMenus.Text = "Standard Case Menus";
            this.adjustments.SetToolTip(this.chk_LowerCaseMenus, "Changes casing of all caps menu items to standard caps and lower case.");
            this.chk_LowerCaseMenus.UseVisualStyleBackColor = true;
            // 
            // chk_FixSlimeSnail
            // 
            this.chk_FixSlimeSnail.AutoSize = true;
            this.chk_FixSlimeSnail.Location = new System.Drawing.Point(6, 29);
            this.chk_FixSlimeSnail.Name = "chk_FixSlimeSnail";
            this.chk_FixSlimeSnail.Size = new System.Drawing.Size(93, 17);
            this.chk_FixSlimeSnail.TabIndex = 141;
            this.chk_FixSlimeSnail.Text = "Fix Slime Snail";
            this.adjustments.SetToolTip(this.chk_FixSlimeSnail, "Fixes Slime Snaii name to Slime Snail");
            this.chk_FixSlimeSnail.UseVisualStyleBackColor = true;
            this.chk_FixSlimeSnail.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Flags";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(55, 198);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(511, 20);
            this.txtFlags.TabIndex = 6;
            this.txtFlags.Leave += new System.EventHandler(this.determineChecks);
            // 
            // chk_GenCompareFile
            // 
            this.chk_GenCompareFile.AutoSize = true;
            this.chk_GenCompareFile.Location = new System.Drawing.Point(185, 480);
            this.chk_GenCompareFile.Name = "chk_GenCompareFile";
            this.chk_GenCompareFile.Size = new System.Drawing.Size(134, 17);
            this.chk_GenCompareFile.TabIndex = 201;
            this.chk_GenCompareFile.Text = "Generate Compare File";
            this.adjustments.SetToolTip(this.chk_GenCompareFile, "Generates compare file on build. This will adjust randomization to avoid spoilers" +
        " (item locations, monster stats/spells.)");
            this.chk_GenCompareFile.UseVisualStyleBackColor = true;
            this.chk_GenCompareFile.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_GenIslandsMonstersZones
            // 
            this.chk_GenIslandsMonstersZones.AutoSize = true;
            this.chk_GenIslandsMonstersZones.Location = new System.Drawing.Point(337, 480);
            this.chk_GenIslandsMonstersZones.Name = "chk_GenIslandsMonstersZones";
            this.chk_GenIslandsMonstersZones.Size = new System.Drawing.Size(229, 17);
            this.chk_GenIslandsMonstersZones.TabIndex = 202;
            this.chk_GenIslandsMonstersZones.Text = "Generate islands, monsters, and zones files";
            this.adjustments.SetToolTip(this.chk_GenIslandsMonstersZones, "Generates debug files for islands, monsters, and zones.");
            this.chk_GenIslandsMonstersZones.UseVisualStyleBackColor = true;
            // 
            // btnCopyChecksum
            // 
            this.btnCopyChecksum.Location = new System.Drawing.Point(530, 122);
            this.btnCopyChecksum.Name = "btnCopyChecksum";
            this.btnCopyChecksum.Size = new System.Drawing.Size(121, 23);
            this.btnCopyChecksum.TabIndex = 5;
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
            // grpFlags
            // 
            this.grpFlags.Controls.Add(this.optEndysFlags);
            this.grpFlags.Controls.Add(this.optSotWFlags);
            this.grpFlags.Controls.Add(this.optManualFlags);
            this.grpFlags.Location = new System.Drawing.Point(20, 158);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Size = new System.Drawing.Size(338, 34);
            this.grpFlags.TabIndex = 203;
            this.grpFlags.TabStop = false;
            // 
            // optEndysFlags
            // 
            this.optEndysFlags.AutoSize = true;
            this.optEndysFlags.Location = new System.Drawing.Point(190, 11);
            this.optEndysFlags.Name = "optEndysFlags";
            this.optEndysFlags.Size = new System.Drawing.Size(130, 17);
            this.optEndysFlags.TabIndex = 2;
            this.optEndysFlags.Text = "Endy\'s Standard Flags";
            this.optEndysFlags.UseVisualStyleBackColor = true;
            this.optEndysFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optSotWFlags
            // 
            this.optSotWFlags.AutoSize = true;
            this.optSotWFlags.Location = new System.Drawing.Point(98, 11);
            this.optSotWFlags.Name = "optSotWFlags";
            this.optSotWFlags.Size = new System.Drawing.Size(80, 17);
            this.optSotWFlags.TabIndex = 1;
            this.optSotWFlags.Text = "SotW Flags";
            this.optSotWFlags.UseVisualStyleBackColor = true;
            this.optSotWFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optManualFlags
            // 
            this.optManualFlags.AutoSize = true;
            this.optManualFlags.Checked = true;
            this.optManualFlags.Location = new System.Drawing.Point(6, 11);
            this.optManualFlags.Name = "optManualFlags";
            this.optManualFlags.Size = new System.Drawing.Size(88, 17);
            this.optManualFlags.TabIndex = 0;
            this.optManualFlags.TabStop = true;
            this.optManualFlags.Text = "Manual Flags";
            this.optManualFlags.UseVisualStyleBackColor = true;
            this.optManualFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 511);
            this.Controls.Add(this.grpFlags);
            this.Controls.Add(this.chk_GenIslandsMonstersZones);
            this.Controls.Add(this.chk_GenCompareFile);
            this.Controls.Add(this.btnCopyChecksum);
            this.Controls.Add(this.lblNewChecksum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFlags);
            this.Controls.Add(this.tabControl1);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMonsterStat.ResumeLayout(false);
            this.grpMonsterStat.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.grpFlags.ResumeLayout(false);
            this.grpFlags.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkRandStatGains;
        private System.Windows.Forms.CheckBox chkRandTreasures;
        private System.Windows.Forms.CheckBox chkRandSpellStrength;
        private System.Windows.Forms.CheckBox chkRandSpellLearning;
        private System.Windows.Forms.CheckBox chkRandEquip;
        private System.Windows.Forms.CheckBox chkRandEnemyPatterns;
        private System.Windows.Forms.CheckBox chkRandItemStores;
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox chk_StoneofLife;
        private System.Windows.Forms.CheckBox chk_Seeds;
        private System.Windows.Forms.CheckBox chk_BookofSatori;
        private System.Windows.Forms.CheckBox chk_RingofLife;
        private System.Windows.Forms.CheckBox chk_EchoingFlute;
        private System.Windows.Forms.CheckBox chk_SilverHarp;
        private System.Windows.Forms.Label lbl_ItemShops;
        private System.Windows.Forms.CheckBox chk_GoldenClaw;
        private System.Windows.Forms.CheckBox chk_ShoesofHappiness;
        private System.Windows.Forms.CheckBox chk_MeteoriteArmband;
        private System.Windows.Forms.CheckBox chk_WizardsRing;
        private System.Windows.Forms.CheckBox chk_LampofDarkness;
        private System.Windows.Forms.CheckBox chk_RandomizeWeaponShops;
        private System.Windows.Forms.CheckBox chk_RandomizeInnPrices;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox chk_FixSlimeSnail;
        private System.Windows.Forms.CheckBox chk_PoisonMothPowder;
        private System.Windows.Forms.CheckBox chk_LeafoftheWorldTree;
        private System.Windows.Forms.CheckBox chk_Cod;
        private System.Windows.Forms.CheckBox chk_SpeedUpMenus;
        private System.Windows.Forms.CheckBox chk_RemoveStartEqRestrictions;
        private System.Windows.Forms.CheckBox chk_RemMetalMonRun;
        private System.Windows.Forms.Label lbl_TreasurePool;
        private System.Windows.Forms.CheckBox chk_RmFighterPenalty;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.CheckBox chk_UseVanEquipValues;
        private System.Windows.Forms.CheckBox chk_WeapArmPower;
        private System.Windows.Forms.CheckBox chk_RmManip;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox chk_LowerCaseMenus;
        private System.Windows.Forms.CheckBox chk_ChangeDefaultParty;
        private System.Windows.Forms.CheckBox chk_GenCompareFile;
        private System.Windows.Forms.CheckBox chk_ChangeHeroAge;
        private System.Windows.Forms.CheckBox chk_GenIslandsMonstersZones;
        private System.Windows.Forms.CheckBox chk_RandSpriteColor;
        private System.Windows.Forms.CheckBox chk_RandomStartGold;
        private System.Windows.Forms.CheckBox chk_GhostToCasket;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.CheckBox chk_RmNewTown;
        private System.Windows.Forms.CheckBox chk_RemoveMtnDrgQueen;
        private System.Windows.Forms.CheckBox chk_RmMtnNecrogond;
        private System.Windows.Forms.CheckBox chk_lbtoCharlock;
        private System.Windows.Forms.CheckBox chk_RemLancelMountains;
        private System.Windows.Forms.CheckBox chk_RemoveBirdRequirement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chk_SepBarGaia;
        private System.Windows.Forms.CheckBox chkRandomizeMap;
        private System.Windows.Forms.CheckBox chkSmallMap;
        private System.Windows.Forms.CheckBox chkRandMonsterZones;
        private System.Windows.Forms.GroupBox grpFlags;
        private System.Windows.Forms.RadioButton optEndysFlags;
        private System.Windows.Forms.RadioButton optSotWFlags;
        private System.Windows.Forms.RadioButton optManualFlags;
    }
}

