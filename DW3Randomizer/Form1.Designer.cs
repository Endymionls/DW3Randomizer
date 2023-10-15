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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompareBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompare = new System.Windows.Forms.TextBox();
            this.btnNewSeed = new System.Windows.Forms.Button();
            this.lblIntensityDesc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grp_InvisShipBird = new System.Windows.Forms.GroupBox();
            this.rad_InvisShipBirdRand = new System.Windows.Forms.RadioButton();
            this.rad_InvisShipBirdOn = new System.Windows.Forms.RadioButton();
            this.rad_InvisShipBirdOff = new System.Windows.Forms.RadioButton();
            this.grp_PartyItems = new System.Windows.Forms.GroupBox();
            this.rad_PartyItemsRand = new System.Windows.Forms.RadioButton();
            this.rad_PartyItemsOn = new System.Windows.Forms.RadioButton();
            this.rad_PartyItemsOff = new System.Windows.Forms.RadioButton();
            this.grp_doubleAtt = new System.Windows.Forms.GroupBox();
            this.rad_DoubleAttRand = new System.Windows.Forms.RadioButton();
            this.rad_DoubleAttOn = new System.Windows.Forms.RadioButton();
            this.rad_DoubleAttOff = new System.Windows.Forms.RadioButton();
            this.grp_DispEqPower = new System.Windows.Forms.GroupBox();
            this.rad_DispEqPowerRand = new System.Windows.Forms.RadioButton();
            this.rad_DispEqPowerOn = new System.Windows.Forms.RadioButton();
            this.rad_DispEqPowerOff = new System.Windows.Forms.RadioButton();
            this.grp_Lamia = new System.Windows.Forms.GroupBox();
            this.rad_LamiaRand = new System.Windows.Forms.RadioButton();
            this.rad_LamiaOn = new System.Windows.Forms.RadioButton();
            this.rad_LamiaOff = new System.Windows.Forms.RadioButton();
            this.grp_cod = new System.Windows.Forms.GroupBox();
            this.rad_codRand = new System.Windows.Forms.RadioButton();
            this.rad_codOn = new System.Windows.Forms.RadioButton();
            this.rad_codOff = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_StartGoldRand = new System.Windows.Forms.RadioButton();
            this.rad_StartGoldOff = new System.Windows.Forms.RadioButton();
            this.rad_StartGoldOn = new System.Windows.Forms.RadioButton();
            this.grp_RmManips = new System.Windows.Forms.GroupBox();
            this.rad_RmManipRand = new System.Windows.Forms.RadioButton();
            this.rad_RmManipOn = new System.Windows.Forms.RadioButton();
            this.rad_RmManipOff = new System.Windows.Forms.RadioButton();
            this.grp_SpeedUpMenus = new System.Windows.Forms.GroupBox();
            this.rad_SpeedUpMenuRand = new System.Windows.Forms.RadioButton();
            this.rad_SpeedUpMenusOn = new System.Windows.Forms.RadioButton();
            this.rad_SpeedUpMenuOff = new System.Windows.Forms.RadioButton();
            this.grp_SpeedUpText = new System.Windows.Forms.GroupBox();
            this.rad_SpeedTextRand = new System.Windows.Forms.RadioButton();
            this.rad_SpeedTextOn = new System.Windows.Forms.RadioButton();
            this.rad_SpeedTextOff = new System.Windows.Forms.RadioButton();
            this.grp_IncBatSpeed = new System.Windows.Forms.GroupBox();
            this.rad_IncBattSpeedRand = new System.Windows.Forms.RadioButton();
            this.rad_IncBattSpeedOn = new System.Windows.Forms.RadioButton();
            this.rad_IncBattSpeedOff = new System.Windows.Forms.RadioButton();
            this.chk_HealUsAllStone = new System.Windows.Forms.CheckBox();
            this.chk_randsagestone = new System.Windows.Forms.CheckBox();
            this.chk_BigShoes = new System.Windows.Forms.CheckBox();
            this.chk_RandShoesEffect = new System.Windows.Forms.CheckBox();
            this.chk_InvisibleNPCs = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEncounterRate = new System.Windows.Forms.ComboBox();
            this.cboGoldReq = new System.Windows.Forms.ComboBox();
            this.cboExpGains = new System.Windows.Forms.ComboBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chk_RandoTowns = new System.Windows.Forms.CheckBox();
            this.chk_RandoCaves = new System.Windows.Forms.CheckBox();
            this.chk_ShrineRando = new System.Windows.Forms.CheckBox();
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
            this.chk_RemDupPool = new System.Windows.Forms.CheckBox();
            this.chk_RandDrop = new System.Windows.Forms.CheckBox();
            this.chkRandomizeGP = new System.Windows.Forms.CheckBox();
            this.chkRandomizeXP = new System.Windows.Forms.CheckBox();
            this.chk_RemMetalMonRun = new System.Windows.Forms.CheckBox();
            this.chkRandEnemyPatterns = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chk_AddRemakeEq = new System.Windows.Forms.CheckBox();
            this.chk_RmRedundKey = new System.Windows.Forms.CheckBox();
            this.chk_AdjustEqpPrices = new System.Windows.Forms.CheckBox();
            this.chk_GreenSilverOrb = new System.Windows.Forms.CheckBox();
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
            this.chk_sellUnsellItems = new System.Windows.Forms.CheckBox();
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
            this.chk_nonMagicMP = new System.Windows.Forms.CheckBox();
            this.grpMonsterStat = new System.Windows.Forms.GroupBox();
            this.optStatSilly = new System.Windows.Forms.RadioButton();
            this.optStatHeavy = new System.Windows.Forms.RadioButton();
            this.optStatMedium = new System.Windows.Forms.RadioButton();
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
            this.chk_FixHeroSpell = new System.Windows.Forms.CheckBox();
            this.chkRemoveParryFight = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chk_levelUpText = new System.Windows.Forms.CheckBox();
            this.chk_FemaleHero = new System.Windows.Forms.CheckBox();
            this.chk_RandNPCSprites = new System.Windows.Forms.CheckBox();
            this.chk_FFigherSprite = new System.Windows.Forms.CheckBox();
            this.chk_EveryoneCat = new System.Windows.Forms.CheckBox();
            this.chk_changeCats = new System.Windows.Forms.CheckBox();
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
            this.optSotWFlags = new System.Windows.Forms.RadioButton();
            this.opt_JustForFun = new System.Windows.Forms.RadioButton();
            this.optTradSotWFlags = new System.Windows.Forms.RadioButton();
            this.optManualFlags = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btn_CopyHash = new System.Windows.Forms.Button();
            this.btn_chksumHash = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grp_InvisShipBird.SuspendLayout();
            this.grp_PartyItems.SuspendLayout();
            this.grp_doubleAtt.SuspendLayout();
            this.grp_DispEqPower.SuspendLayout();
            this.grp_Lamia.SuspendLayout();
            this.grp_cod.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_RmManips.SuspendLayout();
            this.grp_SpeedUpMenus.SuspendLayout();
            this.grp_SpeedUpText.SuspendLayout();
            this.grp_IncBatSpeed.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpMonsterStat.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.grpFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(117, 10);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(451, 20);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.Leave += new System.EventHandler(this.txtFileName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DW3 ROM File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(573, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(77, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "DW3 ROM Checksum";
            // 
            // lblSHAChecksum
            // 
            this.lblSHAChecksum.AutoSize = true;
            this.lblSHAChecksum.Location = new System.Drawing.Point(117, 78);
            this.lblSHAChecksum.Name = "lblSHAChecksum";
            this.lblSHAChecksum.Size = new System.Drawing.Size(247, 13);
            this.lblSHAChecksum.TabIndex = 11;
            this.lblSHAChecksum.Text = "????????????????????????????????????????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Required Checksum";
            // 
            // lblReqChecksum
            // 
            this.lblReqChecksum.AutoSize = true;
            this.lblReqChecksum.Location = new System.Drawing.Point(117, 55);
            this.lblReqChecksum.Name = "lblReqChecksum";
            this.lblReqChecksum.Size = new System.Drawing.Size(244, 13);
            this.lblReqChecksum.TabIndex = 8;
            this.lblReqChecksum.Text = "a867549bad1cba4cd6f6dd51743e78596b982bd8";
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(573, 520);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(77, 23);
            this.btnRandomize.TabIndex = 250;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(573, 55);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(77, 23);
            this.btnCompare.TabIndex = 9;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Visible = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Seed";
            // 
            // btnCompareBrowse
            // 
            this.btnCompareBrowse.Location = new System.Drawing.Point(573, 32);
            this.btnCompareBrowse.Name = "btnCompareBrowse";
            this.btnCompareBrowse.Size = new System.Drawing.Size(77, 23);
            this.btnCompareBrowse.TabIndex = 6;
            this.btnCompareBrowse.Text = "Browse";
            this.btnCompareBrowse.UseVisualStyleBackColor = true;
            this.btnCompareBrowse.Click += new System.EventHandler(this.btnCompareBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Output ROM File";
            this.adjustments.SetToolTip(this.label5, "This can be used to compare an existing ROM file as well.");
            // 
            // txtCompare
            // 
            this.txtCompare.Location = new System.Drawing.Point(117, 32);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(451, 20);
            this.txtCompare.TabIndex = 5;
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.Location = new System.Drawing.Point(573, 205);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(77, 23);
            this.btnNewSeed.TabIndex = 34;
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
            this.label9.Location = new System.Drawing.Point(103, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Monster Random Level";
            this.label9.Visible = false;
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
            this.tabControl1.Location = new System.Drawing.Point(7, 231);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 284);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grp_InvisShipBird);
            this.tabPage1.Controls.Add(this.grp_PartyItems);
            this.tabPage1.Controls.Add(this.grp_doubleAtt);
            this.tabPage1.Controls.Add(this.grp_DispEqPower);
            this.tabPage1.Controls.Add(this.grp_Lamia);
            this.tabPage1.Controls.Add(this.grp_cod);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grp_RmManips);
            this.tabPage1.Controls.Add(this.grp_SpeedUpMenus);
            this.tabPage1.Controls.Add(this.grp_SpeedUpText);
            this.tabPage1.Controls.Add(this.grp_IncBatSpeed);
            this.tabPage1.Controls.Add(this.chk_HealUsAllStone);
            this.tabPage1.Controls.Add(this.chk_randsagestone);
            this.tabPage1.Controls.Add(this.chk_BigShoes);
            this.tabPage1.Controls.Add(this.chk_RandShoesEffect);
            this.tabPage1.Controls.Add(this.chk_InvisibleNPCs);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cboEncounterRate);
            this.tabPage1.Controls.Add(this.cboGoldReq);
            this.tabPage1.Controls.Add(this.cboExpGains);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(697, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adjustments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grp_InvisShipBird
            // 
            this.grp_InvisShipBird.Controls.Add(this.rad_InvisShipBirdRand);
            this.grp_InvisShipBird.Controls.Add(this.rad_InvisShipBirdOn);
            this.grp_InvisShipBird.Controls.Add(this.rad_InvisShipBirdOff);
            this.grp_InvisShipBird.Location = new System.Drawing.Point(348, 130);
            this.grp_InvisShipBird.Name = "grp_InvisShipBird";
            this.grp_InvisShipBird.Size = new System.Drawing.Size(163, 41);
            this.grp_InvisShipBird.TabIndex = 83;
            this.grp_InvisShipBird.TabStop = false;
            this.grp_InvisShipBird.Text = "Invisible Ships and Bird";
            this.adjustments.SetToolTip(this.grp_InvisShipBird, "Ships and Bird are invisible on world map.");
            // 
            // rad_InvisShipBirdRand
            // 
            this.rad_InvisShipBirdRand.AutoSize = true;
            this.rad_InvisShipBirdRand.Location = new System.Drawing.Point(96, 17);
            this.rad_InvisShipBirdRand.Name = "rad_InvisShipBirdRand";
            this.rad_InvisShipBirdRand.Size = new System.Drawing.Size(65, 17);
            this.rad_InvisShipBirdRand.TabIndex = 2;
            this.rad_InvisShipBirdRand.TabStop = true;
            this.rad_InvisShipBirdRand.Text = "Random";
            this.rad_InvisShipBirdRand.UseVisualStyleBackColor = true;
            this.rad_InvisShipBirdRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_InvisShipBirdOn
            // 
            this.rad_InvisShipBirdOn.AutoSize = true;
            this.rad_InvisShipBirdOn.Location = new System.Drawing.Point(51, 17);
            this.rad_InvisShipBirdOn.Name = "rad_InvisShipBirdOn";
            this.rad_InvisShipBirdOn.Size = new System.Drawing.Size(39, 17);
            this.rad_InvisShipBirdOn.TabIndex = 1;
            this.rad_InvisShipBirdOn.TabStop = true;
            this.rad_InvisShipBirdOn.Text = "On";
            this.rad_InvisShipBirdOn.UseVisualStyleBackColor = true;
            this.rad_InvisShipBirdOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_InvisShipBirdOff
            // 
            this.rad_InvisShipBirdOff.AutoSize = true;
            this.rad_InvisShipBirdOff.Location = new System.Drawing.Point(6, 17);
            this.rad_InvisShipBirdOff.Name = "rad_InvisShipBirdOff";
            this.rad_InvisShipBirdOff.Size = new System.Drawing.Size(39, 17);
            this.rad_InvisShipBirdOff.TabIndex = 0;
            this.rad_InvisShipBirdOff.TabStop = true;
            this.rad_InvisShipBirdOff.Text = "Off";
            this.rad_InvisShipBirdOff.UseVisualStyleBackColor = true;
            this.rad_InvisShipBirdOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_PartyItems
            // 
            this.grp_PartyItems.Controls.Add(this.rad_PartyItemsRand);
            this.grp_PartyItems.Controls.Add(this.rad_PartyItemsOn);
            this.grp_PartyItems.Controls.Add(this.rad_PartyItemsOff);
            this.grp_PartyItems.Location = new System.Drawing.Point(348, 83);
            this.grp_PartyItems.Name = "grp_PartyItems";
            this.grp_PartyItems.Size = new System.Drawing.Size(163, 41);
            this.grp_PartyItems.TabIndex = 82;
            this.grp_PartyItems.TabStop = false;
            this.grp_PartyItems.Text = "Party Starts with Items";
            this.adjustments.SetToolTip(this.grp_PartyItems, "Party starts with consumable items.");
            // 
            // rad_PartyItemsRand
            // 
            this.rad_PartyItemsRand.AutoSize = true;
            this.rad_PartyItemsRand.Location = new System.Drawing.Point(96, 19);
            this.rad_PartyItemsRand.Name = "rad_PartyItemsRand";
            this.rad_PartyItemsRand.Size = new System.Drawing.Size(65, 17);
            this.rad_PartyItemsRand.TabIndex = 2;
            this.rad_PartyItemsRand.TabStop = true;
            this.rad_PartyItemsRand.Text = "Random";
            this.rad_PartyItemsRand.UseVisualStyleBackColor = true;
            this.rad_PartyItemsRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_PartyItemsOn
            // 
            this.rad_PartyItemsOn.AutoSize = true;
            this.rad_PartyItemsOn.Location = new System.Drawing.Point(51, 19);
            this.rad_PartyItemsOn.Name = "rad_PartyItemsOn";
            this.rad_PartyItemsOn.Size = new System.Drawing.Size(39, 17);
            this.rad_PartyItemsOn.TabIndex = 1;
            this.rad_PartyItemsOn.TabStop = true;
            this.rad_PartyItemsOn.Text = "On";
            this.rad_PartyItemsOn.UseVisualStyleBackColor = true;
            this.rad_PartyItemsOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_PartyItemsOff
            // 
            this.rad_PartyItemsOff.AutoSize = true;
            this.rad_PartyItemsOff.Location = new System.Drawing.Point(6, 19);
            this.rad_PartyItemsOff.Name = "rad_PartyItemsOff";
            this.rad_PartyItemsOff.Size = new System.Drawing.Size(39, 17);
            this.rad_PartyItemsOff.TabIndex = 0;
            this.rad_PartyItemsOff.TabStop = true;
            this.rad_PartyItemsOff.Text = "Off";
            this.rad_PartyItemsOff.UseVisualStyleBackColor = true;
            this.rad_PartyItemsOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_doubleAtt
            // 
            this.grp_doubleAtt.Controls.Add(this.rad_DoubleAttRand);
            this.grp_doubleAtt.Controls.Add(this.rad_DoubleAttOn);
            this.grp_doubleAtt.Controls.Add(this.rad_DoubleAttOff);
            this.grp_doubleAtt.Location = new System.Drawing.Point(348, 36);
            this.grp_doubleAtt.Name = "grp_doubleAtt";
            this.grp_doubleAtt.Size = new System.Drawing.Size(163, 41);
            this.grp_doubleAtt.TabIndex = 81;
            this.grp_doubleAtt.TabStop = false;
            this.grp_doubleAtt.Text = "Normal Attacks Hit Twice";
            this.adjustments.SetToolTip(this.grp_doubleAtt, "Party physical attacks hit twice (is not influenced by Falcon Sword).");
            // 
            // rad_DoubleAttRand
            // 
            this.rad_DoubleAttRand.AutoSize = true;
            this.rad_DoubleAttRand.Location = new System.Drawing.Point(96, 19);
            this.rad_DoubleAttRand.Name = "rad_DoubleAttRand";
            this.rad_DoubleAttRand.Size = new System.Drawing.Size(65, 17);
            this.rad_DoubleAttRand.TabIndex = 2;
            this.rad_DoubleAttRand.TabStop = true;
            this.rad_DoubleAttRand.Text = "Random";
            this.rad_DoubleAttRand.UseVisualStyleBackColor = true;
            this.rad_DoubleAttRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DoubleAttOn
            // 
            this.rad_DoubleAttOn.AutoSize = true;
            this.rad_DoubleAttOn.Location = new System.Drawing.Point(51, 19);
            this.rad_DoubleAttOn.Name = "rad_DoubleAttOn";
            this.rad_DoubleAttOn.Size = new System.Drawing.Size(39, 17);
            this.rad_DoubleAttOn.TabIndex = 1;
            this.rad_DoubleAttOn.TabStop = true;
            this.rad_DoubleAttOn.Text = "On";
            this.rad_DoubleAttOn.UseVisualStyleBackColor = true;
            this.rad_DoubleAttOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DoubleAttOff
            // 
            this.rad_DoubleAttOff.AutoSize = true;
            this.rad_DoubleAttOff.Location = new System.Drawing.Point(6, 19);
            this.rad_DoubleAttOff.Name = "rad_DoubleAttOff";
            this.rad_DoubleAttOff.Size = new System.Drawing.Size(39, 17);
            this.rad_DoubleAttOff.TabIndex = 0;
            this.rad_DoubleAttOff.TabStop = true;
            this.rad_DoubleAttOff.Text = "Off";
            this.rad_DoubleAttOff.UseVisualStyleBackColor = true;
            this.rad_DoubleAttOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_DispEqPower
            // 
            this.grp_DispEqPower.Controls.Add(this.rad_DispEqPowerRand);
            this.grp_DispEqPower.Controls.Add(this.rad_DispEqPowerOn);
            this.grp_DispEqPower.Controls.Add(this.rad_DispEqPowerOff);
            this.grp_DispEqPower.Location = new System.Drawing.Point(179, 177);
            this.grp_DispEqPower.Name = "grp_DispEqPower";
            this.grp_DispEqPower.Size = new System.Drawing.Size(163, 41);
            this.grp_DispEqPower.TabIndex = 80;
            this.grp_DispEqPower.TabStop = false;
            this.grp_DispEqPower.Text = "Display Equipment Power";
            this.adjustments.SetToolTip(this.grp_DispEqPower, "Display equipment power as part of equipment name.");
            // 
            // rad_DispEqPowerRand
            // 
            this.rad_DispEqPowerRand.AutoSize = true;
            this.rad_DispEqPowerRand.Location = new System.Drawing.Point(96, 19);
            this.rad_DispEqPowerRand.Name = "rad_DispEqPowerRand";
            this.rad_DispEqPowerRand.Size = new System.Drawing.Size(65, 17);
            this.rad_DispEqPowerRand.TabIndex = 2;
            this.rad_DispEqPowerRand.Text = "Random";
            this.rad_DispEqPowerRand.UseVisualStyleBackColor = true;
            this.rad_DispEqPowerRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DispEqPowerOn
            // 
            this.rad_DispEqPowerOn.AutoSize = true;
            this.rad_DispEqPowerOn.Location = new System.Drawing.Point(51, 19);
            this.rad_DispEqPowerOn.Name = "rad_DispEqPowerOn";
            this.rad_DispEqPowerOn.Size = new System.Drawing.Size(39, 17);
            this.rad_DispEqPowerOn.TabIndex = 1;
            this.rad_DispEqPowerOn.Text = "On";
            this.rad_DispEqPowerOn.UseVisualStyleBackColor = true;
            this.rad_DispEqPowerOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DispEqPowerOff
            // 
            this.rad_DispEqPowerOff.AutoSize = true;
            this.rad_DispEqPowerOff.Checked = true;
            this.rad_DispEqPowerOff.Location = new System.Drawing.Point(6, 19);
            this.rad_DispEqPowerOff.Name = "rad_DispEqPowerOff";
            this.rad_DispEqPowerOff.Size = new System.Drawing.Size(39, 17);
            this.rad_DispEqPowerOff.TabIndex = 0;
            this.rad_DispEqPowerOff.TabStop = true;
            this.rad_DispEqPowerOff.Text = "Off";
            this.rad_DispEqPowerOff.UseVisualStyleBackColor = true;
            this.rad_DispEqPowerOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_Lamia
            // 
            this.grp_Lamia.Controls.Add(this.rad_LamiaRand);
            this.grp_Lamia.Controls.Add(this.rad_LamiaOn);
            this.grp_Lamia.Controls.Add(this.rad_LamiaOff);
            this.grp_Lamia.Location = new System.Drawing.Point(179, 130);
            this.grp_Lamia.Name = "grp_Lamia";
            this.grp_Lamia.Size = new System.Drawing.Size(163, 41);
            this.grp_Lamia.TabIndex = 79;
            this.grp_Lamia.TabStop = false;
            this.grp_Lamia.Text = "Require No Orbs for Lamia";
            // 
            // rad_LamiaRand
            // 
            this.rad_LamiaRand.AutoSize = true;
            this.rad_LamiaRand.Location = new System.Drawing.Point(96, 17);
            this.rad_LamiaRand.Name = "rad_LamiaRand";
            this.rad_LamiaRand.Size = new System.Drawing.Size(65, 17);
            this.rad_LamiaRand.TabIndex = 2;
            this.rad_LamiaRand.Text = "Random";
            this.rad_LamiaRand.UseVisualStyleBackColor = true;
            this.rad_LamiaRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LamiaOn
            // 
            this.rad_LamiaOn.AutoSize = true;
            this.rad_LamiaOn.Location = new System.Drawing.Point(51, 17);
            this.rad_LamiaOn.Name = "rad_LamiaOn";
            this.rad_LamiaOn.Size = new System.Drawing.Size(39, 17);
            this.rad_LamiaOn.TabIndex = 1;
            this.rad_LamiaOn.Text = "On";
            this.rad_LamiaOn.UseVisualStyleBackColor = true;
            this.rad_LamiaOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LamiaOff
            // 
            this.rad_LamiaOff.AutoSize = true;
            this.rad_LamiaOff.Checked = true;
            this.rad_LamiaOff.Location = new System.Drawing.Point(6, 17);
            this.rad_LamiaOff.Name = "rad_LamiaOff";
            this.rad_LamiaOff.Size = new System.Drawing.Size(39, 17);
            this.rad_LamiaOff.TabIndex = 0;
            this.rad_LamiaOff.TabStop = true;
            this.rad_LamiaOff.Text = "Off";
            this.rad_LamiaOff.UseVisualStyleBackColor = true;
            this.rad_LamiaOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_cod
            // 
            this.grp_cod.Controls.Add(this.rad_codRand);
            this.grp_cod.Controls.Add(this.rad_codOn);
            this.grp_cod.Controls.Add(this.rad_codOff);
            this.grp_cod.Location = new System.Drawing.Point(179, 83);
            this.grp_cod.Name = "grp_cod";
            this.grp_cod.Size = new System.Drawing.Size(163, 41);
            this.grp_cod.TabIndex = 78;
            this.grp_cod.TabStop = false;
            this.grp_cod.Text = "Cold as a Cod Adjustment";
            // 
            // rad_codRand
            // 
            this.rad_codRand.AutoSize = true;
            this.rad_codRand.Location = new System.Drawing.Point(96, 19);
            this.rad_codRand.Name = "rad_codRand";
            this.rad_codRand.Size = new System.Drawing.Size(65, 17);
            this.rad_codRand.TabIndex = 2;
            this.rad_codRand.Text = "Random";
            this.rad_codRand.UseVisualStyleBackColor = true;
            this.rad_codRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_codOn
            // 
            this.rad_codOn.AutoSize = true;
            this.rad_codOn.Location = new System.Drawing.Point(51, 20);
            this.rad_codOn.Name = "rad_codOn";
            this.rad_codOn.Size = new System.Drawing.Size(39, 17);
            this.rad_codOn.TabIndex = 1;
            this.rad_codOn.Text = "On";
            this.rad_codOn.UseVisualStyleBackColor = true;
            this.rad_codOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_codOff
            // 
            this.rad_codOff.AutoSize = true;
            this.rad_codOff.Checked = true;
            this.rad_codOff.Location = new System.Drawing.Point(6, 20);
            this.rad_codOff.Name = "rad_codOff";
            this.rad_codOff.Size = new System.Drawing.Size(39, 17);
            this.rad_codOff.TabIndex = 0;
            this.rad_codOff.TabStop = true;
            this.rad_codOff.Text = "Off";
            this.rad_codOff.UseVisualStyleBackColor = true;
            this.rad_codOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_StartGoldRand);
            this.groupBox1.Controls.Add(this.rad_StartGoldOff);
            this.groupBox1.Controls.Add(this.rad_StartGoldOn);
            this.groupBox1.Location = new System.Drawing.Point(179, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 41);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randomize Starting Gold";
            // 
            // rad_StartGoldRand
            // 
            this.rad_StartGoldRand.AutoSize = true;
            this.rad_StartGoldRand.Location = new System.Drawing.Point(96, 19);
            this.rad_StartGoldRand.Name = "rad_StartGoldRand";
            this.rad_StartGoldRand.Size = new System.Drawing.Size(65, 17);
            this.rad_StartGoldRand.TabIndex = 80;
            this.rad_StartGoldRand.Text = "Random";
            this.rad_StartGoldRand.UseVisualStyleBackColor = true;
            this.rad_StartGoldRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_StartGoldOff
            // 
            this.rad_StartGoldOff.AutoSize = true;
            this.rad_StartGoldOff.Checked = true;
            this.rad_StartGoldOff.Location = new System.Drawing.Point(6, 19);
            this.rad_StartGoldOff.Name = "rad_StartGoldOff";
            this.rad_StartGoldOff.Size = new System.Drawing.Size(39, 17);
            this.rad_StartGoldOff.TabIndex = 78;
            this.rad_StartGoldOff.TabStop = true;
            this.rad_StartGoldOff.Text = "Off";
            this.rad_StartGoldOff.UseVisualStyleBackColor = true;
            this.rad_StartGoldOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_StartGoldOn
            // 
            this.rad_StartGoldOn.AutoSize = true;
            this.rad_StartGoldOn.Location = new System.Drawing.Point(51, 19);
            this.rad_StartGoldOn.Name = "rad_StartGoldOn";
            this.rad_StartGoldOn.Size = new System.Drawing.Size(39, 17);
            this.rad_StartGoldOn.TabIndex = 79;
            this.rad_StartGoldOn.Text = "On";
            this.rad_StartGoldOn.UseVisualStyleBackColor = true;
            this.rad_StartGoldOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RmManips
            // 
            this.grp_RmManips.Controls.Add(this.rad_RmManipRand);
            this.grp_RmManips.Controls.Add(this.rad_RmManipOn);
            this.grp_RmManips.Controls.Add(this.rad_RmManipOff);
            this.grp_RmManips.Location = new System.Drawing.Point(10, 177);
            this.grp_RmManips.Name = "grp_RmManips";
            this.grp_RmManips.Size = new System.Drawing.Size(163, 41);
            this.grp_RmManips.TabIndex = 76;
            this.grp_RmManips.TabStop = false;
            this.grp_RmManips.Text = "Remove Manipulations";
            // 
            // rad_RmManipRand
            // 
            this.rad_RmManipRand.AutoSize = true;
            this.rad_RmManipRand.Location = new System.Drawing.Point(95, 19);
            this.rad_RmManipRand.Name = "rad_RmManipRand";
            this.rad_RmManipRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RmManipRand.TabIndex = 2;
            this.rad_RmManipRand.Text = "Random";
            this.rad_RmManipRand.UseVisualStyleBackColor = true;
            this.rad_RmManipRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmManipOn
            // 
            this.rad_RmManipOn.AutoSize = true;
            this.rad_RmManipOn.Location = new System.Drawing.Point(51, 19);
            this.rad_RmManipOn.Name = "rad_RmManipOn";
            this.rad_RmManipOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RmManipOn.TabIndex = 1;
            this.rad_RmManipOn.Text = "On";
            this.rad_RmManipOn.UseVisualStyleBackColor = true;
            this.rad_RmManipOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmManipOff
            // 
            this.rad_RmManipOff.AutoSize = true;
            this.rad_RmManipOff.Checked = true;
            this.rad_RmManipOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RmManipOff.Name = "rad_RmManipOff";
            this.rad_RmManipOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RmManipOff.TabIndex = 0;
            this.rad_RmManipOff.TabStop = true;
            this.rad_RmManipOff.Text = "Off";
            this.rad_RmManipOff.UseVisualStyleBackColor = true;
            this.rad_RmManipOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_SpeedUpMenus
            // 
            this.grp_SpeedUpMenus.Controls.Add(this.rad_SpeedUpMenuRand);
            this.grp_SpeedUpMenus.Controls.Add(this.rad_SpeedUpMenusOn);
            this.grp_SpeedUpMenus.Controls.Add(this.rad_SpeedUpMenuOff);
            this.grp_SpeedUpMenus.Location = new System.Drawing.Point(10, 130);
            this.grp_SpeedUpMenus.Name = "grp_SpeedUpMenus";
            this.grp_SpeedUpMenus.Size = new System.Drawing.Size(163, 41);
            this.grp_SpeedUpMenus.TabIndex = 75;
            this.grp_SpeedUpMenus.TabStop = false;
            this.grp_SpeedUpMenus.Text = "Speed Up Menus";
            // 
            // rad_SpeedUpMenuRand
            // 
            this.rad_SpeedUpMenuRand.AutoSize = true;
            this.rad_SpeedUpMenuRand.Location = new System.Drawing.Point(95, 17);
            this.rad_SpeedUpMenuRand.Name = "rad_SpeedUpMenuRand";
            this.rad_SpeedUpMenuRand.Size = new System.Drawing.Size(65, 17);
            this.rad_SpeedUpMenuRand.TabIndex = 2;
            this.rad_SpeedUpMenuRand.Text = "Random";
            this.rad_SpeedUpMenuRand.UseVisualStyleBackColor = true;
            this.rad_SpeedUpMenuRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SpeedUpMenusOn
            // 
            this.rad_SpeedUpMenusOn.AutoSize = true;
            this.rad_SpeedUpMenusOn.Location = new System.Drawing.Point(51, 17);
            this.rad_SpeedUpMenusOn.Name = "rad_SpeedUpMenusOn";
            this.rad_SpeedUpMenusOn.Size = new System.Drawing.Size(39, 17);
            this.rad_SpeedUpMenusOn.TabIndex = 1;
            this.rad_SpeedUpMenusOn.Text = "On";
            this.rad_SpeedUpMenusOn.UseVisualStyleBackColor = true;
            this.rad_SpeedUpMenusOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SpeedUpMenuOff
            // 
            this.rad_SpeedUpMenuOff.AutoSize = true;
            this.rad_SpeedUpMenuOff.Checked = true;
            this.rad_SpeedUpMenuOff.Location = new System.Drawing.Point(6, 17);
            this.rad_SpeedUpMenuOff.Name = "rad_SpeedUpMenuOff";
            this.rad_SpeedUpMenuOff.Size = new System.Drawing.Size(39, 17);
            this.rad_SpeedUpMenuOff.TabIndex = 0;
            this.rad_SpeedUpMenuOff.TabStop = true;
            this.rad_SpeedUpMenuOff.Text = "Off";
            this.rad_SpeedUpMenuOff.UseVisualStyleBackColor = true;
            this.rad_SpeedUpMenuOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_SpeedUpText
            // 
            this.grp_SpeedUpText.Controls.Add(this.rad_SpeedTextRand);
            this.grp_SpeedUpText.Controls.Add(this.rad_SpeedTextOn);
            this.grp_SpeedUpText.Controls.Add(this.rad_SpeedTextOff);
            this.grp_SpeedUpText.Location = new System.Drawing.Point(10, 83);
            this.grp_SpeedUpText.Name = "grp_SpeedUpText";
            this.grp_SpeedUpText.Size = new System.Drawing.Size(163, 41);
            this.grp_SpeedUpText.TabIndex = 74;
            this.grp_SpeedUpText.TabStop = false;
            this.grp_SpeedUpText.Text = "Speed Up Text";
            // 
            // rad_SpeedTextRand
            // 
            this.rad_SpeedTextRand.AutoSize = true;
            this.rad_SpeedTextRand.Location = new System.Drawing.Point(95, 18);
            this.rad_SpeedTextRand.Name = "rad_SpeedTextRand";
            this.rad_SpeedTextRand.Size = new System.Drawing.Size(65, 17);
            this.rad_SpeedTextRand.TabIndex = 2;
            this.rad_SpeedTextRand.Text = "Random";
            this.rad_SpeedTextRand.UseVisualStyleBackColor = true;
            this.rad_SpeedTextRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SpeedTextOn
            // 
            this.rad_SpeedTextOn.AutoSize = true;
            this.rad_SpeedTextOn.Location = new System.Drawing.Point(51, 18);
            this.rad_SpeedTextOn.Name = "rad_SpeedTextOn";
            this.rad_SpeedTextOn.Size = new System.Drawing.Size(39, 17);
            this.rad_SpeedTextOn.TabIndex = 1;
            this.rad_SpeedTextOn.Text = "On";
            this.rad_SpeedTextOn.UseVisualStyleBackColor = true;
            this.rad_SpeedTextOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SpeedTextOff
            // 
            this.rad_SpeedTextOff.AutoSize = true;
            this.rad_SpeedTextOff.Checked = true;
            this.rad_SpeedTextOff.Location = new System.Drawing.Point(6, 19);
            this.rad_SpeedTextOff.Name = "rad_SpeedTextOff";
            this.rad_SpeedTextOff.Size = new System.Drawing.Size(39, 17);
            this.rad_SpeedTextOff.TabIndex = 0;
            this.rad_SpeedTextOff.TabStop = true;
            this.rad_SpeedTextOff.Text = "Off";
            this.rad_SpeedTextOff.UseVisualStyleBackColor = true;
            this.rad_SpeedTextOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_IncBatSpeed
            // 
            this.grp_IncBatSpeed.Controls.Add(this.rad_IncBattSpeedRand);
            this.grp_IncBatSpeed.Controls.Add(this.rad_IncBattSpeedOn);
            this.grp_IncBatSpeed.Controls.Add(this.rad_IncBattSpeedOff);
            this.grp_IncBatSpeed.Location = new System.Drawing.Point(10, 36);
            this.grp_IncBatSpeed.Name = "grp_IncBatSpeed";
            this.grp_IncBatSpeed.Size = new System.Drawing.Size(163, 41);
            this.grp_IncBatSpeed.TabIndex = 73;
            this.grp_IncBatSpeed.TabStop = false;
            this.grp_IncBatSpeed.Text = "Increased Battle Speed";
            // 
            // rad_IncBattSpeedRand
            // 
            this.rad_IncBattSpeedRand.AutoSize = true;
            this.rad_IncBattSpeedRand.Location = new System.Drawing.Point(96, 19);
            this.rad_IncBattSpeedRand.Name = "rad_IncBattSpeedRand";
            this.rad_IncBattSpeedRand.Size = new System.Drawing.Size(65, 17);
            this.rad_IncBattSpeedRand.TabIndex = 74;
            this.rad_IncBattSpeedRand.Text = "Random";
            this.rad_IncBattSpeedRand.UseVisualStyleBackColor = true;
            this.rad_IncBattSpeedRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_IncBattSpeedOn
            // 
            this.rad_IncBattSpeedOn.AutoSize = true;
            this.rad_IncBattSpeedOn.Location = new System.Drawing.Point(51, 19);
            this.rad_IncBattSpeedOn.Name = "rad_IncBattSpeedOn";
            this.rad_IncBattSpeedOn.Size = new System.Drawing.Size(39, 17);
            this.rad_IncBattSpeedOn.TabIndex = 73;
            this.rad_IncBattSpeedOn.Text = "On";
            this.rad_IncBattSpeedOn.UseVisualStyleBackColor = true;
            this.rad_IncBattSpeedOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_IncBattSpeedOff
            // 
            this.rad_IncBattSpeedOff.AutoSize = true;
            this.rad_IncBattSpeedOff.Checked = true;
            this.rad_IncBattSpeedOff.Location = new System.Drawing.Point(6, 19);
            this.rad_IncBattSpeedOff.Name = "rad_IncBattSpeedOff";
            this.rad_IncBattSpeedOff.Size = new System.Drawing.Size(39, 17);
            this.rad_IncBattSpeedOff.TabIndex = 72;
            this.rad_IncBattSpeedOff.TabStop = true;
            this.rad_IncBattSpeedOff.Text = "Off";
            this.rad_IncBattSpeedOff.UseVisualStyleBackColor = true;
            this.rad_IncBattSpeedOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_HealUsAllStone
            // 
            this.chk_HealUsAllStone.AutoSize = true;
            this.chk_HealUsAllStone.Location = new System.Drawing.Point(533, 83);
            this.chk_HealUsAllStone.Margin = new System.Windows.Forms.Padding(2);
            this.chk_HealUsAllStone.Name = "chk_HealUsAllStone";
            this.chk_HealUsAllStone.Size = new System.Drawing.Size(162, 17);
            this.chk_HealUsAllStone.TabIndex = 69;
            this.chk_HealUsAllStone.Text = "Guaranteed HealUsAll Stone";
            this.adjustments.SetToolTip(this.chk_HealUsAllStone, "Guarantees HealUsAll for Sage\'s Stone");
            this.chk_HealUsAllStone.UseVisualStyleBackColor = true;
            this.chk_HealUsAllStone.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_randsagestone
            // 
            this.chk_randsagestone.AutoSize = true;
            this.chk_randsagestone.Location = new System.Drawing.Point(537, 36);
            this.chk_randsagestone.Margin = new System.Windows.Forms.Padding(2);
            this.chk_randsagestone.Name = "chk_randsagestone";
            this.chk_randsagestone.Size = new System.Drawing.Size(145, 17);
            this.chk_randsagestone.TabIndex = 68;
            this.chk_randsagestone.Text = "Randomize Sage\'s Stone";
            this.adjustments.SetToolTip(this.chk_randsagestone, "1 in 4 chance Sage\'s Stone will cast HealUsAll");
            this.chk_randsagestone.UseVisualStyleBackColor = true;
            this.chk_randsagestone.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_BigShoes
            // 
            this.chk_BigShoes.AutoSize = true;
            this.chk_BigShoes.Location = new System.Drawing.Point(542, 187);
            this.chk_BigShoes.Margin = new System.Windows.Forms.Padding(2);
            this.chk_BigShoes.Name = "chk_BigShoes";
            this.chk_BigShoes.Size = new System.Drawing.Size(151, 17);
            this.chk_BigShoes.TabIndex = 71;
            this.chk_BigShoes.Text = "Big Shoes and Ring Effect";
            this.adjustments.SetToolTip(this.chk_BigShoes, "Increases random range for Shoes of Happiness to 1 - 255");
            this.chk_BigShoes.UseVisualStyleBackColor = true;
            this.chk_BigShoes.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandShoesEffect
            // 
            this.chk_RandShoesEffect.AutoSize = true;
            this.chk_RandShoesEffect.Location = new System.Drawing.Point(533, 123);
            this.chk_RandShoesEffect.Margin = new System.Windows.Forms.Padding(2);
            this.chk_RandShoesEffect.Name = "chk_RandShoesEffect";
            this.chk_RandShoesEffect.Size = new System.Drawing.Size(177, 30);
            this.chk_RandShoesEffect.TabIndex = 70;
            this.chk_RandShoesEffect.Text = "Randomize Shoes of Happiness\r\nand Ring of Life Effect";
            this.adjustments.SetToolTip(this.chk_RandShoesEffect, "Randomize XP earned from Shoes of Happiness between 1 - 5 per step");
            this.chk_RandShoesEffect.UseVisualStyleBackColor = true;
            this.chk_RandShoesEffect.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_InvisibleNPCs
            // 
            this.chk_InvisibleNPCs.AutoSize = true;
            this.chk_InvisibleNPCs.Location = new System.Drawing.Point(354, 187);
            this.chk_InvisibleNPCs.Name = "chk_InvisibleNPCs";
            this.chk_InvisibleNPCs.Size = new System.Drawing.Size(94, 17);
            this.chk_InvisibleNPCs.TabIndex = 66;
            this.chk_InvisibleNPCs.Text = "Invisible NPCs";
            this.adjustments.SetToolTip(this.chk_InvisibleNPCs, "Makes NPCs invisible. Will also cause party to be invisible with Animal Suits.");
            this.chk_InvisibleNPCs.UseVisualStyleBackColor = true;
            this.chk_InvisibleNPCs.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Encounter Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Gold Gains";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Experience Gains";
            // 
            // cboEncounterRate
            // 
            this.cboEncounterRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncounterRate.FormattingEnabled = true;
            this.cboEncounterRate.Items.AddRange(new object[] {
            "Random",
            "400%",
            "300%",
            "200%",
            "150%",
            "100%",
            "75%",
            "50%",
            "25%",
            "0%"});
            this.cboEncounterRate.Location = new System.Drawing.Point(500, 10);
            this.cboEncounterRate.Margin = new System.Windows.Forms.Padding(2);
            this.cboEncounterRate.Name = "cboEncounterRate";
            this.cboEncounterRate.Size = new System.Drawing.Size(101, 21);
            this.cboEncounterRate.TabIndex = 55;
            this.cboEncounterRate.SelectedIndexChanged += new System.EventHandler(this.determineFlags);
            // 
            // cboGoldReq
            // 
            this.cboGoldReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoldReq.FormattingEnabled = true;
            this.cboGoldReq.Items.AddRange(new object[] {
            "Random",
            "200%",
            "150%",
            "100%",
            "50%",
            "1 G per monster + battle"});
            this.cboGoldReq.Location = new System.Drawing.Point(238, 10);
            this.cboGoldReq.Margin = new System.Windows.Forms.Padding(2);
            this.cboGoldReq.Name = "cboGoldReq";
            this.cboGoldReq.Size = new System.Drawing.Size(173, 21);
            this.cboGoldReq.TabIndex = 53;
            this.cboGoldReq.SelectedIndexChanged += new System.EventHandler(this.determineFlags);
            // 
            // cboExpGains
            // 
            this.cboExpGains.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboExpGains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpGains.FormattingEnabled = true;
            this.cboExpGains.Items.AddRange(new object[] {
            "Random",
            "1000%",
            "750%",
            "500%",
            "400%",
            "300%",
            "200%",
            "150%",
            "100%",
            "50%",
            "25%",
            "0%"});
            this.cboExpGains.Location = new System.Drawing.Point(107, 10);
            this.cboExpGains.Margin = new System.Windows.Forms.Padding(2);
            this.cboExpGains.Name = "cboExpGains";
            this.cboExpGains.Size = new System.Drawing.Size(64, 21);
            this.cboExpGains.TabIndex = 51;
            this.cboExpGains.SelectedIndexChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chk_RandoTowns);
            this.tabPage8.Controls.Add(this.chk_RandoCaves);
            this.tabPage8.Controls.Add(this.chk_ShrineRando);
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
            this.tabPage8.Size = new System.Drawing.Size(697, 258);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Map";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // chk_RandoTowns
            // 
            this.chk_RandoTowns.AutoSize = true;
            this.chk_RandoTowns.Location = new System.Drawing.Point(7, 88);
            this.chk_RandoTowns.Margin = new System.Windows.Forms.Padding(2);
            this.chk_RandoTowns.Name = "chk_RandoTowns";
            this.chk_RandoTowns.Size = new System.Drawing.Size(114, 17);
            this.chk_RandoTowns.TabIndex = 84;
            this.chk_RandoTowns.Text = "Randomize Towns";
            this.adjustments.SetToolTip(this.chk_RandoTowns, "Randomizes continents that some towns and castles are found on");
            this.chk_RandoTowns.UseVisualStyleBackColor = true;
            this.chk_RandoTowns.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandoCaves
            // 
            this.chk_RandoCaves.AutoSize = true;
            this.chk_RandoCaves.Location = new System.Drawing.Point(7, 68);
            this.chk_RandoCaves.Margin = new System.Windows.Forms.Padding(2);
            this.chk_RandoCaves.Name = "chk_RandoCaves";
            this.chk_RandoCaves.Size = new System.Drawing.Size(171, 17);
            this.chk_RandoCaves.TabIndex = 83;
            this.chk_RandoCaves.Text = "Randomize Caves and Towers";
            this.adjustments.SetToolTip(this.chk_RandoCaves, "Randomizes continents that some caves, towers, and pyramid are found on");
            this.chk_RandoCaves.UseVisualStyleBackColor = true;
            this.chk_RandoCaves.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_ShrineRando
            // 
            this.chk_ShrineRando.AutoSize = true;
            this.chk_ShrineRando.Location = new System.Drawing.Point(7, 49);
            this.chk_ShrineRando.Margin = new System.Windows.Forms.Padding(2);
            this.chk_ShrineRando.Name = "chk_ShrineRando";
            this.chk_ShrineRando.Size = new System.Drawing.Size(117, 17);
            this.chk_ShrineRando.TabIndex = 82;
            this.chk_ShrineRando.Text = "Randomize Shrines";
            this.adjustments.SetToolTip(this.chk_ShrineRando, "Randomizes continents that some shrines are found on");
            this.chk_ShrineRando.UseVisualStyleBackColor = true;
            this.chk_ShrineRando.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RmNewTown
            // 
            this.chk_RmNewTown.AutoSize = true;
            this.chk_RmNewTown.Location = new System.Drawing.Point(187, 146);
            this.chk_RmNewTown.Name = "chk_RmNewTown";
            this.chk_RmNewTown.Size = new System.Drawing.Size(161, 17);
            this.chk_RmNewTown.TabIndex = 93;
            this.chk_RmNewTown.Text = "Do not generate New Town.";
            this.chk_RmNewTown.UseVisualStyleBackColor = true;
            this.chk_RmNewTown.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RemoveMtnDrgQueen
            // 
            this.chk_RemoveMtnDrgQueen.AutoSize = true;
            this.chk_RemoveMtnDrgQueen.Location = new System.Drawing.Point(187, 29);
            this.chk_RemoveMtnDrgQueen.Name = "chk_RemoveMtnDrgQueen";
            this.chk_RemoveMtnDrgQueen.Size = new System.Drawing.Size(259, 17);
            this.chk_RemoveMtnDrgQueen.TabIndex = 87;
            this.chk_RemoveMtnDrgQueen.Text = "Remove Mountains around Dragon Queen Castle";
            this.chk_RemoveMtnDrgQueen.UseVisualStyleBackColor = true;
            this.chk_RemoveMtnDrgQueen.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RmMtnNecrogond
            // 
            this.chk_RmMtnNecrogond.AutoSize = true;
            this.chk_RmMtnNecrogond.Location = new System.Drawing.Point(187, 88);
            this.chk_RmMtnNecrogond.Name = "chk_RmMtnNecrogond";
            this.chk_RmMtnNecrogond.Size = new System.Drawing.Size(249, 17);
            this.chk_RmMtnNecrogond.TabIndex = 90;
            this.chk_RmMtnNecrogond.Text = "Remove mountains around Cave of Necrogond";
            this.adjustments.SetToolTip(this.chk_RmMtnNecrogond, "Remove mountains around Cave of Necrogond and shrine.");
            this.chk_RmMtnNecrogond.UseVisualStyleBackColor = true;
            this.chk_RmMtnNecrogond.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_lbtoCharlock
            // 
            this.chk_lbtoCharlock.AutoSize = true;
            this.chk_lbtoCharlock.Location = new System.Drawing.Point(187, 127);
            this.chk_lbtoCharlock.Name = "chk_lbtoCharlock";
            this.chk_lbtoCharlock.Size = new System.Drawing.Size(171, 17);
            this.chk_lbtoCharlock.TabIndex = 92;
            this.chk_lbtoCharlock.Text = "Land bridge to Charlock Castle";
            this.adjustments.SetToolTip(this.chk_lbtoCharlock, "Removes water and mountains around Charlock Castle");
            this.chk_lbtoCharlock.UseVisualStyleBackColor = true;
            this.chk_lbtoCharlock.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RemLancelMountains
            // 
            this.chk_RemLancelMountains.AutoSize = true;
            this.chk_RemLancelMountains.Location = new System.Drawing.Point(187, 68);
            this.chk_RemLancelMountains.Name = "chk_RemLancelMountains";
            this.chk_RemLancelMountains.Size = new System.Drawing.Size(216, 17);
            this.chk_RemLancelMountains.TabIndex = 89;
            this.chk_RemLancelMountains.Text = "Remove mountains around Lancel Cave";
            this.adjustments.SetToolTip(this.chk_RemLancelMountains, "Removes mountains around Lancel Cave to allow party in and not require Final Key");
            this.chk_RemLancelMountains.UseVisualStyleBackColor = true;
            this.chk_RemLancelMountains.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RemoveBirdRequirement
            // 
            this.chk_RemoveBirdRequirement.AutoSize = true;
            this.chk_RemoveBirdRequirement.Location = new System.Drawing.Point(187, 107);
            this.chk_RemoveBirdRequirement.Name = "chk_RemoveBirdRequirement";
            this.chk_RemoveBirdRequirement.Size = new System.Drawing.Size(235, 17);
            this.chk_RemoveBirdRequirement.TabIndex = 91;
            this.chk_RemoveBirdRequirement.Text = "Remove bird requirement for Baramos Castle";
            this.chk_RemoveBirdRequirement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.adjustments.SetToolTip(this.chk_RemoveBirdRequirement, "Removes mountains around Baramos Castle");
            this.chk_RemoveBirdRequirement.UseVisualStyleBackColor = true;
            this.chk_RemoveBirdRequirement.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Map";
            // 
            // chk_SepBarGaia
            // 
            this.chk_SepBarGaia.AutoSize = true;
            this.chk_SepBarGaia.Location = new System.Drawing.Point(187, 49);
            this.chk_SepBarGaia.Name = "chk_SepBarGaia";
            this.chk_SepBarGaia.Size = new System.Drawing.Size(213, 17);
            this.chk_SepBarGaia.TabIndex = 88;
            this.chk_SepBarGaia.Text = "Separate Baramos Castle and Gaia\'s Pit";
            this.adjustments.SetToolTip(this.chk_SepBarGaia, "Separates Baramos Castle and Gaia\'s Pit. 3 Wing of Wyverns will be in Baramos Cas" +
        "tle. Prepare yourself so you don\'t softlock.");
            this.chk_SepBarGaia.UseVisualStyleBackColor = true;
            this.chk_SepBarGaia.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandomizeMap
            // 
            this.chkRandomizeMap.AutoSize = true;
            this.chkRandomizeMap.Location = new System.Drawing.Point(7, 29);
            this.chkRandomizeMap.Name = "chkRandomizeMap";
            this.chkRandomizeMap.Size = new System.Drawing.Size(102, 17);
            this.chkRandomizeMap.TabIndex = 81;
            this.chkRandomizeMap.Text = "Randomize map";
            this.adjustments.SetToolTip(this.chkRandomizeMap, "Randomizes overworld and Alefgard maps.");
            this.chkRandomizeMap.UseVisualStyleBackColor = true;
            this.chkRandomizeMap.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkSmallMap
            // 
            this.chkSmallMap.AutoSize = true;
            this.chkSmallMap.Location = new System.Drawing.Point(7, 127);
            this.chkSmallMap.Name = "chkSmallMap";
            this.chkSmallMap.Size = new System.Drawing.Size(75, 17);
            this.chkSmallMap.TabIndex = 86;
            this.chkSmallMap.Text = "Small Map";
            this.adjustments.SetToolTip(this.chkSmallMap, "Generates a map that is 128x128 (standard is 256x256)");
            this.chkSmallMap.UseVisualStyleBackColor = true;
            this.chkSmallMap.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandMonsterZones
            // 
            this.chkRandMonsterZones.AutoSize = true;
            this.chkRandMonsterZones.Location = new System.Drawing.Point(7, 107);
            this.chkRandMonsterZones.Name = "chkRandMonsterZones";
            this.chkRandMonsterZones.Size = new System.Drawing.Size(150, 17);
            this.chkRandMonsterZones.TabIndex = 85;
            this.chkRandMonsterZones.Text = "Randomize monster zones";
            this.adjustments.SetToolTip(this.chkRandMonsterZones, "Randomizes where monster zones are located on the map.");
            this.chkRandMonsterZones.UseVisualStyleBackColor = true;
            this.chkRandMonsterZones.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chk_RemDupPool);
            this.tabPage2.Controls.Add(this.chk_RandDrop);
            this.tabPage2.Controls.Add(this.chkRandomizeGP);
            this.tabPage2.Controls.Add(this.chkRandomizeXP);
            this.tabPage2.Controls.Add(this.chk_RemMetalMonRun);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.chkRandEnemyPatterns);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(697, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monsters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chk_RemDupPool
            // 
            this.chk_RemDupPool.AutoSize = true;
            this.chk_RemDupPool.Location = new System.Drawing.Point(7, 88);
            this.chk_RemDupPool.Margin = new System.Windows.Forms.Padding(2);
            this.chk_RemDupPool.Name = "chk_RemDupPool";
            this.chk_RemDupPool.Size = new System.Drawing.Size(166, 17);
            this.chk_RemDupPool.TabIndex = 104;
            this.chk_RemDupPool.Text = "Remove Duplicates from Pool";
            this.adjustments.SetToolTip(this.chk_RemDupPool, "Removes duplicate herbs & misc items from pool, to increase odds of getting bette" +
        "r items");
            this.chk_RemDupPool.UseVisualStyleBackColor = true;
            this.chk_RemDupPool.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandDrop
            // 
            this.chk_RandDrop.AutoSize = true;
            this.chk_RandDrop.Location = new System.Drawing.Point(7, 68);
            this.chk_RandDrop.Margin = new System.Windows.Forms.Padding(2);
            this.chk_RandDrop.Name = "chk_RandDrop";
            this.chk_RandDrop.Size = new System.Drawing.Size(151, 17);
            this.chk_RandDrop.TabIndex = 103;
            this.chk_RandDrop.Text = "Randomize Dropped Items";
            this.adjustments.SetToolTip(this.chk_RandDrop, "Randomize Monster Drops");
            this.chk_RandDrop.UseVisualStyleBackColor = true;
            this.chk_RandDrop.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandomizeGP
            // 
            this.chkRandomizeGP.AutoSize = true;
            this.chkRandomizeGP.Location = new System.Drawing.Point(7, 49);
            this.chkRandomizeGP.Name = "chkRandomizeGP";
            this.chkRandomizeGP.Size = new System.Drawing.Size(102, 17);
            this.chkRandomizeGP.TabIndex = 102;
            this.chkRandomizeGP.Text = "Randomize gold";
            this.adjustments.SetToolTip(this.chkRandomizeGP, "Randomizes gold dropped by monsters.");
            this.chkRandomizeGP.UseVisualStyleBackColor = true;
            this.chkRandomizeGP.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandomizeXP
            // 
            this.chkRandomizeXP.AutoSize = true;
            this.chkRandomizeXP.Location = new System.Drawing.Point(7, 29);
            this.chkRandomizeXP.Name = "chkRandomizeXP";
            this.chkRandomizeXP.Size = new System.Drawing.Size(134, 17);
            this.chkRandomizeXP.TabIndex = 101;
            this.chkRandomizeXP.Text = "Randomize experience";
            this.adjustments.SetToolTip(this.chkRandomizeXP, "Randomizes experience given my monsters.");
            this.chkRandomizeXP.UseVisualStyleBackColor = true;
            this.chkRandomizeXP.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RemMetalMonRun
            // 
            this.chk_RemMetalMonRun.AutoSize = true;
            this.chk_RemMetalMonRun.Location = new System.Drawing.Point(183, 49);
            this.chk_RemMetalMonRun.Name = "chk_RemMetalMonRun";
            this.chk_RemMetalMonRun.Size = new System.Drawing.Size(145, 17);
            this.chk_RemMetalMonRun.TabIndex = 106;
            this.chk_RemMetalMonRun.Text = "Remove Metal Mon. Run";
            this.adjustments.SetToolTip(this.chk_RemMetalMonRun, "Metal Slimes and Metal Babble are less likely to have running in their logic");
            this.chk_RemMetalMonRun.UseVisualStyleBackColor = true;
            this.chk_RemMetalMonRun.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandEnemyPatterns
            // 
            this.chkRandEnemyPatterns.AutoSize = true;
            this.chkRandEnemyPatterns.Location = new System.Drawing.Point(183, 29);
            this.chkRandEnemyPatterns.Name = "chkRandEnemyPatterns";
            this.chkRandEnemyPatterns.Size = new System.Drawing.Size(154, 17);
            this.chkRandEnemyPatterns.TabIndex = 105;
            this.chkRandEnemyPatterns.Text = "Randomize enemy patterns";
            this.adjustments.SetToolTip(this.chkRandEnemyPatterns, "Randomizes enemy attack patterns.");
            this.chkRandEnemyPatterns.UseVisualStyleBackColor = true;
            this.chkRandEnemyPatterns.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chk_AddRemakeEq);
            this.tabPage4.Controls.Add(this.chk_RmRedundKey);
            this.tabPage4.Controls.Add(this.chk_AdjustEqpPrices);
            this.tabPage4.Controls.Add(this.chk_GreenSilverOrb);
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
            this.tabPage4.Size = new System.Drawing.Size(697, 258);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Treasures & Equipment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chk_AddRemakeEq
            // 
            this.chk_AddRemakeEq.AutoSize = true;
            this.chk_AddRemakeEq.Location = new System.Drawing.Point(200, 127);
            this.chk_AddRemakeEq.Margin = new System.Windows.Forms.Padding(2);
            this.chk_AddRemakeEq.Name = "chk_AddRemakeEq";
            this.chk_AddRemakeEq.Size = new System.Drawing.Size(141, 17);
            this.chk_AddRemakeEq.TabIndex = 122;
            this.chk_AddRemakeEq.Text = "Add Remake Equipment";
            this.adjustments.SetToolTip(this.chk_AddRemakeEq, "Replaces some equipment with equipment from the remakes. Makes Fighter and Mercha" +
        "nt more viable jobs.");
            this.chk_AddRemakeEq.UseVisualStyleBackColor = true;
            this.chk_AddRemakeEq.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RmRedundKey
            // 
            this.chk_RmRedundKey.AutoSize = true;
            this.chk_RmRedundKey.Location = new System.Drawing.Point(7, 49);
            this.chk_RmRedundKey.Name = "chk_RmRedundKey";
            this.chk_RmRedundKey.Size = new System.Drawing.Size(148, 17);
            this.chk_RmRedundKey.TabIndex = 112;
            this.chk_RmRedundKey.Text = "Remove Redundant Keys";
            this.adjustments.SetToolTip(this.chk_RmRedundKey, "Removes lower tier keys treasure pool if a higher tier key is found where the low" +
        "er one would be found.");
            this.chk_RmRedundKey.UseVisualStyleBackColor = true;
            this.chk_RmRedundKey.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_AdjustEqpPrices
            // 
            this.chk_AdjustEqpPrices.AutoSize = true;
            this.chk_AdjustEqpPrices.Location = new System.Drawing.Point(200, 49);
            this.chk_AdjustEqpPrices.Name = "chk_AdjustEqpPrices";
            this.chk_AdjustEqpPrices.Size = new System.Drawing.Size(217, 17);
            this.chk_AdjustEqpPrices.TabIndex = 118;
            this.chk_AdjustEqpPrices.Text = "Adjust equipment prices based on power";
            this.adjustments.SetToolTip(this.chk_AdjustEqpPrices, "Adjusts equipment prices based on power of equipment.");
            this.chk_AdjustEqpPrices.UseVisualStyleBackColor = true;
            this.chk_AdjustEqpPrices.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_GreenSilverOrb
            // 
            this.chk_GreenSilverOrb.AutoSize = true;
            this.chk_GreenSilverOrb.Location = new System.Drawing.Point(7, 146);
            this.chk_GreenSilverOrb.Name = "chk_GreenSilverOrb";
            this.chk_GreenSilverOrb.Size = new System.Drawing.Size(129, 17);
            this.chk_GreenSilverOrb.TabIndex = 115;
            this.chk_GreenSilverOrb.Text = "Orb Default Locations";
            this.adjustments.SetToolTip(this.chk_GreenSilverOrb, "Green and Silver Orbs have a chance of being randomized to their default location" +
        "s.");
            this.chk_GreenSilverOrb.UseVisualStyleBackColor = true;
            this.chk_GreenSilverOrb.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_UseVanEquipValues
            // 
            this.chk_UseVanEquipValues.AutoSize = true;
            this.chk_UseVanEquipValues.Location = new System.Drawing.Point(200, 68);
            this.chk_UseVanEquipValues.Name = "chk_UseVanEquipValues";
            this.chk_UseVanEquipValues.Size = new System.Drawing.Size(204, 17);
            this.chk_UseVanEquipValues.TabIndex = 119;
            this.chk_UseVanEquipValues.Text = "Use vanilla values for equipment stats";
            this.adjustments.SetToolTip(this.chk_UseVanEquipValues, "Randomizes equipment stats based on Vanilla game values");
            this.chk_UseVanEquipValues.UseVisualStyleBackColor = true;
            this.chk_UseVanEquipValues.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RmFighterPenalty
            // 
            this.chk_RmFighterPenalty.AutoSize = true;
            this.chk_RmFighterPenalty.Location = new System.Drawing.Point(200, 107);
            this.chk_RmFighterPenalty.Name = "chk_RmFighterPenalty";
            this.chk_RmFighterPenalty.Size = new System.Drawing.Size(183, 17);
            this.chk_RmFighterPenalty.TabIndex = 121;
            this.chk_RmFighterPenalty.Text = "Remove Fighter Weapon Penalty";
            this.adjustments.SetToolTip(this.chk_RmFighterPenalty, "Removes attack power penalty from some equipment the Fighter can equip.");
            this.chk_RmFighterPenalty.UseVisualStyleBackColor = true;
            this.chk_RmFighterPenalty.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // lbl_TreasurePool
            // 
            this.lbl_TreasurePool.AutoSize = true;
            this.lbl_TreasurePool.Location = new System.Drawing.Point(36, 107);
            this.lbl_TreasurePool.Name = "lbl_TreasurePool";
            this.lbl_TreasurePool.Size = new System.Drawing.Size(107, 13);
            this.lbl_TreasurePool.TabIndex = 113;
            this.lbl_TreasurePool.Text = "Add to Treasure Pool";
            // 
            // chk_RemoveStartEqRestrictions
            // 
            this.chk_RemoveStartEqRestrictions.AutoSize = true;
            this.chk_RemoveStartEqRestrictions.Location = new System.Drawing.Point(200, 88);
            this.chk_RemoveStartEqRestrictions.Name = "chk_RemoveStartEqRestrictions";
            this.chk_RemoveStartEqRestrictions.Size = new System.Drawing.Size(216, 17);
            this.chk_RemoveStartEqRestrictions.TabIndex = 120;
            this.chk_RemoveStartEqRestrictions.Text = "Remove Starting Equipment Restrictions";
            this.adjustments.SetToolTip(this.chk_RemoveStartEqRestrictions, "Removes low equipment stats for starting equipment (randomizer default is to keep" +
        " these low).");
            this.chk_RemoveStartEqRestrictions.UseVisualStyleBackColor = true;
            this.chk_RemoveStartEqRestrictions.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_GoldenClaw
            // 
            this.chk_GoldenClaw.AutoSize = true;
            this.chk_GoldenClaw.Location = new System.Drawing.Point(7, 127);
            this.chk_GoldenClaw.Name = "chk_GoldenClaw";
            this.chk_GoldenClaw.Size = new System.Drawing.Size(86, 17);
            this.chk_GoldenClaw.TabIndex = 114;
            this.chk_GoldenClaw.Text = "Golden Claw";
            this.adjustments.SetToolTip(this.chk_GoldenClaw, "Adds the Golden Claw to 1 random treasure chest");
            this.chk_GoldenClaw.UseVisualStyleBackColor = true;
            this.chk_GoldenClaw.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandEquip
            // 
            this.chkRandEquip.AutoSize = true;
            this.chkRandEquip.Location = new System.Drawing.Point(200, 29);
            this.chkRandEquip.Name = "chkRandEquip";
            this.chkRandEquip.Size = new System.Drawing.Size(163, 17);
            this.chkRandEquip.TabIndex = 117;
            this.chkRandEquip.Text = "Randomize equipment power";
            this.adjustments.SetToolTip(this.chkRandEquip, "Randomizes weapon and armor power.");
            this.chkRandEquip.UseVisualStyleBackColor = true;
            this.chkRandEquip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandWhoCanEquip
            // 
            this.chkRandWhoCanEquip.AutoSize = true;
            this.chkRandWhoCanEquip.Location = new System.Drawing.Point(200, 10);
            this.chkRandWhoCanEquip.Name = "chkRandWhoCanEquip";
            this.chkRandWhoCanEquip.Size = new System.Drawing.Size(152, 17);
            this.chkRandWhoCanEquip.TabIndex = 116;
            this.chkRandWhoCanEquip.Text = "Randomize who can equip";
            this.adjustments.SetToolTip(this.chkRandWhoCanEquip, "Randomizes which classes can equip equipment.");
            this.chkRandWhoCanEquip.UseVisualStyleBackColor = true;
            this.chkRandWhoCanEquip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandItemEffects
            // 
            this.chkRandItemEffects.AutoSize = true;
            this.chkRandItemEffects.Location = new System.Drawing.Point(7, 10);
            this.chkRandItemEffects.Name = "chkRandItemEffects";
            this.chkRandItemEffects.Size = new System.Drawing.Size(136, 17);
            this.chkRandItemEffects.TabIndex = 110;
            this.chkRandItemEffects.Text = "Randomize item effects";
            this.adjustments.SetToolTip(this.chkRandItemEffects, "Randomizes effects of items.");
            this.chkRandItemEffects.UseVisualStyleBackColor = true;
            this.chkRandItemEffects.Visible = false;
            this.chkRandItemEffects.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandTreasures
            // 
            this.chkRandTreasures.AutoSize = true;
            this.chkRandTreasures.Location = new System.Drawing.Point(7, 29);
            this.chkRandTreasures.Name = "chkRandTreasures";
            this.chkRandTreasures.Size = new System.Drawing.Size(125, 17);
            this.chkRandTreasures.TabIndex = 111;
            this.chkRandTreasures.Text = "Randomize treasures";
            this.adjustments.SetToolTip(this.chkRandTreasures, "Randomizes treasures found in chests and given by NPCs.");
            this.chkRandTreasures.UseVisualStyleBackColor = true;
            this.chkRandTreasures.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chk_sellUnsellItems);
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
            this.tabPage6.Size = new System.Drawing.Size(697, 258);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Item & Weapon Shops & Inns";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chk_sellUnsellItems
            // 
            this.chk_sellUnsellItems.AutoSize = true;
            this.chk_sellUnsellItems.Location = new System.Drawing.Point(7, 88);
            this.chk_sellUnsellItems.Name = "chk_sellUnsellItems";
            this.chk_sellUnsellItems.Size = new System.Drawing.Size(123, 17);
            this.chk_sellUnsellItems.TabIndex = 133;
            this.chk_sellUnsellItems.Text = "Sell Unsellable Items";
            this.adjustments.SetToolTip(this.chk_sellUnsellItems, "Sell unsellable items at item shops. Important key items cannot be sold.");
            this.chk_sellUnsellItems.UseVisualStyleBackColor = true;
            this.chk_sellUnsellItems.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_LeafoftheWorldTree
            // 
            this.chk_LeafoftheWorldTree.AutoSize = true;
            this.chk_LeafoftheWorldTree.Location = new System.Drawing.Point(315, 29);
            this.chk_LeafoftheWorldTree.Name = "chk_LeafoftheWorldTree";
            this.chk_LeafoftheWorldTree.Size = new System.Drawing.Size(133, 17);
            this.chk_LeafoftheWorldTree.TabIndex = 142;
            this.chk_LeafoftheWorldTree.Text = "Leaf of the World Tree";
            this.chk_LeafoftheWorldTree.UseVisualStyleBackColor = true;
            this.chk_LeafoftheWorldTree.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomizeWeaponShops
            // 
            this.chk_RandomizeWeaponShops.AutoSize = true;
            this.chk_RandomizeWeaponShops.Location = new System.Drawing.Point(7, 68);
            this.chk_RandomizeWeaponShops.Name = "chk_RandomizeWeaponShops";
            this.chk_RandomizeWeaponShops.Size = new System.Drawing.Size(156, 17);
            this.chk_RandomizeWeaponShops.TabIndex = 132;
            this.chk_RandomizeWeaponShops.Text = "Randomize Weapon Shops";
            this.chk_RandomizeWeaponShops.UseVisualStyleBackColor = true;
            this.chk_RandomizeWeaponShops.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_LampofDarkness
            // 
            this.chk_LampofDarkness.AutoSize = true;
            this.chk_LampofDarkness.Location = new System.Drawing.Point(315, 107);
            this.chk_LampofDarkness.Name = "chk_LampofDarkness";
            this.chk_LampofDarkness.Size = new System.Drawing.Size(112, 17);
            this.chk_LampofDarkness.TabIndex = 146;
            this.chk_LampofDarkness.Text = "Lamp of Darkness";
            this.chk_LampofDarkness.UseVisualStyleBackColor = true;
            this.chk_LampofDarkness.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_WizardsRing
            // 
            this.chk_WizardsRing.AutoSize = true;
            this.chk_WizardsRing.Location = new System.Drawing.Point(315, 88);
            this.chk_WizardsRing.Name = "chk_WizardsRing";
            this.chk_WizardsRing.Size = new System.Drawing.Size(91, 17);
            this.chk_WizardsRing.TabIndex = 145;
            this.chk_WizardsRing.Text = "Wizard\'s Ring";
            this.chk_WizardsRing.UseVisualStyleBackColor = true;
            this.chk_WizardsRing.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_MeteoriteArmband
            // 
            this.chk_MeteoriteArmband.AutoSize = true;
            this.chk_MeteoriteArmband.Location = new System.Drawing.Point(315, 68);
            this.chk_MeteoriteArmband.Name = "chk_MeteoriteArmband";
            this.chk_MeteoriteArmband.Size = new System.Drawing.Size(115, 17);
            this.chk_MeteoriteArmband.TabIndex = 144;
            this.chk_MeteoriteArmband.Text = "Meteorite Armband";
            this.chk_MeteoriteArmband.UseVisualStyleBackColor = true;
            this.chk_MeteoriteArmband.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_ShoesofHappiness
            // 
            this.chk_ShoesofHappiness.AutoSize = true;
            this.chk_ShoesofHappiness.Location = new System.Drawing.Point(315, 49);
            this.chk_ShoesofHappiness.Name = "chk_ShoesofHappiness";
            this.chk_ShoesofHappiness.Size = new System.Drawing.Size(121, 17);
            this.chk_ShoesofHappiness.TabIndex = 143;
            this.chk_ShoesofHappiness.Text = "Shoes of Happiness";
            this.chk_ShoesofHappiness.UseVisualStyleBackColor = true;
            this.chk_ShoesofHappiness.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // lbl_ItemShops
            // 
            this.lbl_ItemShops.AutoSize = true;
            this.lbl_ItemShops.Location = new System.Drawing.Point(268, 10);
            this.lbl_ItemShops.Name = "lbl_ItemShops";
            this.lbl_ItemShops.Size = new System.Drawing.Size(94, 13);
            this.lbl_ItemShops.TabIndex = 135;
            this.lbl_ItemShops.Text = "Add to Item Shops";
            // 
            // chk_SilverHarp
            // 
            this.chk_SilverHarp.AutoSize = true;
            this.chk_SilverHarp.Location = new System.Drawing.Point(205, 127);
            this.chk_SilverHarp.Name = "chk_SilverHarp";
            this.chk_SilverHarp.Size = new System.Drawing.Size(78, 17);
            this.chk_SilverHarp.TabIndex = 141;
            this.chk_SilverHarp.Text = "Silver Harp";
            this.chk_SilverHarp.UseVisualStyleBackColor = true;
            this.chk_SilverHarp.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_EchoingFlute
            // 
            this.chk_EchoingFlute.AutoSize = true;
            this.chk_EchoingFlute.Location = new System.Drawing.Point(205, 107);
            this.chk_EchoingFlute.Name = "chk_EchoingFlute";
            this.chk_EchoingFlute.Size = new System.Drawing.Size(91, 17);
            this.chk_EchoingFlute.TabIndex = 140;
            this.chk_EchoingFlute.Text = "Echoing Flute";
            this.chk_EchoingFlute.UseVisualStyleBackColor = true;
            this.chk_EchoingFlute.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RingofLife
            // 
            this.chk_RingofLife.AutoSize = true;
            this.chk_RingofLife.Location = new System.Drawing.Point(205, 88);
            this.chk_RingofLife.Name = "chk_RingofLife";
            this.chk_RingofLife.Size = new System.Drawing.Size(80, 17);
            this.chk_RingofLife.TabIndex = 139;
            this.chk_RingofLife.Text = "Ring of Life";
            this.chk_RingofLife.UseVisualStyleBackColor = true;
            this.chk_RingofLife.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_BookofSatori
            // 
            this.chk_BookofSatori.AutoSize = true;
            this.chk_BookofSatori.Location = new System.Drawing.Point(205, 68);
            this.chk_BookofSatori.Name = "chk_BookofSatori";
            this.chk_BookofSatori.Size = new System.Drawing.Size(93, 17);
            this.chk_BookofSatori.TabIndex = 138;
            this.chk_BookofSatori.Text = "Book of Satori";
            this.chk_BookofSatori.UseVisualStyleBackColor = true;
            this.chk_BookofSatori.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_Seeds
            // 
            this.chk_Seeds.AutoSize = true;
            this.chk_Seeds.Location = new System.Drawing.Point(205, 49);
            this.chk_Seeds.Name = "chk_Seeds";
            this.chk_Seeds.Size = new System.Drawing.Size(56, 17);
            this.chk_Seeds.TabIndex = 137;
            this.chk_Seeds.Text = "Seeds";
            this.chk_Seeds.UseVisualStyleBackColor = true;
            this.chk_Seeds.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_StoneofLife
            // 
            this.chk_StoneofLife.AutoSize = true;
            this.chk_StoneofLife.Location = new System.Drawing.Point(205, 29);
            this.chk_StoneofLife.Name = "chk_StoneofLife";
            this.chk_StoneofLife.Size = new System.Drawing.Size(86, 17);
            this.chk_StoneofLife.TabIndex = 136;
            this.chk_StoneofLife.Text = "Stone of Life";
            this.chk_StoneofLife.UseVisualStyleBackColor = true;
            this.chk_StoneofLife.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandItemStores
            // 
            this.chkRandItemStores.AutoSize = true;
            this.chkRandItemStores.Location = new System.Drawing.Point(7, 49);
            this.chkRandItemStores.Name = "chkRandItemStores";
            this.chkRandItemStores.Size = new System.Drawing.Size(135, 17);
            this.chkRandItemStores.TabIndex = 131;
            this.chkRandItemStores.Text = "Randomize Item Shops";
            this.chkRandItemStores.UseVisualStyleBackColor = true;
            this.chkRandItemStores.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_Caturday
            // 
            this.chk_Caturday.AutoSize = true;
            this.chk_Caturday.Location = new System.Drawing.Point(7, 107);
            this.chk_Caturday.Name = "chk_Caturday";
            this.chk_Caturday.Size = new System.Drawing.Size(68, 17);
            this.chk_Caturday.TabIndex = 134;
            this.chk_Caturday.Text = "Caturday";
            this.adjustments.SetToolTip(this.chk_Caturday, "Ensures that Animal Suits will be found in at least 1 weapon shop. Will replace t" +
        "he first Item in the shop list");
            this.chk_Caturday.UseVisualStyleBackColor = true;
            this.chk_Caturday.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_PoisonMothPowder
            // 
            this.chk_PoisonMothPowder.AutoSize = true;
            this.chk_PoisonMothPowder.Location = new System.Drawing.Point(315, 127);
            this.chk_PoisonMothPowder.Name = "chk_PoisonMothPowder";
            this.chk_PoisonMothPowder.Size = new System.Drawing.Size(124, 17);
            this.chk_PoisonMothPowder.TabIndex = 147;
            this.chk_PoisonMothPowder.Text = "Poison Moth Powder";
            this.chk_PoisonMothPowder.UseVisualStyleBackColor = true;
            this.chk_PoisonMothPowder.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomizeInnPrices
            // 
            this.chk_RandomizeInnPrices.AutoSize = true;
            this.chk_RandomizeInnPrices.Location = new System.Drawing.Point(7, 29);
            this.chk_RandomizeInnPrices.Name = "chk_RandomizeInnPrices";
            this.chk_RandomizeInnPrices.Size = new System.Drawing.Size(129, 17);
            this.chk_RandomizeInnPrices.TabIndex = 130;
            this.chk_RandomizeInnPrices.Text = "Randomize Inn Prices";
            this.adjustments.SetToolTip(this.chk_RandomizeInnPrices, "Randomizes the inn price from 1-100 GP per party member. Each inn is a different " +
        "value.");
            this.chk_RandomizeInnPrices.UseVisualStyleBackColor = true;
            this.chk_RandomizeInnPrices.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chk_nonMagicMP);
            this.tabPage3.Controls.Add(this.grpMonsterStat);
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
            this.tabPage3.Size = new System.Drawing.Size(697, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Characters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chk_nonMagicMP
            // 
            this.chk_nonMagicMP.AutoSize = true;
            this.chk_nonMagicMP.Location = new System.Drawing.Point(361, 117);
            this.chk_nonMagicMP.Margin = new System.Windows.Forms.Padding(2);
            this.chk_nonMagicMP.Name = "chk_nonMagicMP";
            this.chk_nonMagicMP.Size = new System.Drawing.Size(147, 17);
            this.chk_nonMagicMP.TabIndex = 177;
            this.chk_nonMagicMP.Text = "Non-Magic Jobs Gain MP";
            this.adjustments.SetToolTip(this.chk_nonMagicMP, "Non-spellcasting jobs gain MP at level up.");
            this.chk_nonMagicMP.UseVisualStyleBackColor = true;
            this.chk_nonMagicMP.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grpMonsterStat
            // 
            this.grpMonsterStat.Controls.Add(this.optStatSilly);
            this.grpMonsterStat.Controls.Add(this.optStatHeavy);
            this.grpMonsterStat.Controls.Add(this.optStatMedium);
            this.grpMonsterStat.Location = new System.Drawing.Point(147, 107);
            this.grpMonsterStat.Name = "grpMonsterStat";
            this.grpMonsterStat.Size = new System.Drawing.Size(203, 28);
            this.grpMonsterStat.TabIndex = 27;
            this.grpMonsterStat.TabStop = false;
            // 
            // optStatSilly
            // 
            this.optStatSilly.AutoSize = true;
            this.optStatSilly.Checked = true;
            this.optStatSilly.Location = new System.Drawing.Point(5, 8);
            this.optStatSilly.Name = "optStatSilly";
            this.optStatSilly.Size = new System.Drawing.Size(43, 17);
            this.optStatSilly.TabIndex = 174;
            this.optStatSilly.TabStop = true;
            this.optStatSilly.Text = "Silly";
            this.optStatSilly.UseVisualStyleBackColor = true;
            this.optStatSilly.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optStatHeavy
            // 
            this.optStatHeavy.AutoSize = true;
            this.optStatHeavy.Location = new System.Drawing.Point(130, 8);
            this.optStatHeavy.Name = "optStatHeavy";
            this.optStatHeavy.Size = new System.Drawing.Size(71, 17);
            this.optStatHeavy.TabIndex = 176;
            this.optStatHeavy.Text = "Ludicrous";
            this.optStatHeavy.UseVisualStyleBackColor = true;
            this.optStatHeavy.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optStatMedium
            // 
            this.optStatMedium.AutoSize = true;
            this.optStatMedium.Location = new System.Drawing.Point(53, 8);
            this.optStatMedium.Name = "optStatMedium";
            this.optStatMedium.Size = new System.Drawing.Size(74, 17);
            this.optStatMedium.TabIndex = 175;
            this.optStatMedium.Text = "Ridiculous";
            this.optStatMedium.UseVisualStyleBackColor = true;
            this.optStatMedium.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_ChangeDefaultParty
            // 
            this.chk_ChangeDefaultParty.AutoSize = true;
            this.chk_ChangeDefaultParty.Location = new System.Drawing.Point(7, 10);
            this.chk_ChangeDefaultParty.Name = "chk_ChangeDefaultParty";
            this.chk_ChangeDefaultParty.Size = new System.Drawing.Size(173, 17);
            this.chk_ChangeDefaultParty.TabIndex = 150;
            this.chk_ChangeDefaultParty.Text = "Change Default Party Members";
            this.adjustments.SetToolTip(this.chk_ChangeDefaultParty, "When unchecked, standard party members in Luisa\'s Place are unchanged. When check" +
        "ed, shows options for changing party members.");
            this.chk_ChangeDefaultParty.UseVisualStyleBackColor = true;
            this.chk_ChangeDefaultParty.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkFourJobFiesta
            // 
            this.chkFourJobFiesta.AutoSize = true;
            this.chkFourJobFiesta.Location = new System.Drawing.Point(307, 140);
            this.chkFourJobFiesta.Name = "chkFourJobFiesta";
            this.chkFourJobFiesta.Size = new System.Drawing.Size(157, 17);
            this.chkFourJobFiesta.TabIndex = 180;
            this.chkFourJobFiesta.Text = "Four Job Fiesta adjustments";
            this.adjustments.SetToolTip(this.chkFourJobFiesta, "Allows the hero to be removed from the party, the hero to change classes, and any" +
        " hero to become a sage.");
            this.chkFourJobFiesta.UseVisualStyleBackColor = true;
            this.chkFourJobFiesta.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandStatGains
            // 
            this.chkRandStatGains.AutoSize = true;
            this.chkRandStatGains.Location = new System.Drawing.Point(7, 117);
            this.chkRandStatGains.Name = "chkRandStatGains";
            this.chkRandStatGains.Size = new System.Drawing.Size(127, 17);
            this.chkRandStatGains.TabIndex = 173;
            this.chkRandStatGains.Text = "Randomize stat gains";
            this.adjustments.SetToolTip(this.chkRandStatGains, "Randomizes stats gained by classes at level up.");
            this.chkRandStatGains.UseVisualStyleBackColor = true;
            this.chkRandStatGains.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandSpellStrength
            // 
            this.chkRandSpellStrength.AutoSize = true;
            this.chkRandSpellStrength.Location = new System.Drawing.Point(153, 140);
            this.chkRandSpellStrength.Name = "chkRandSpellStrength";
            this.chkRandSpellStrength.Size = new System.Drawing.Size(149, 17);
            this.chkRandSpellStrength.TabIndex = 179;
            this.chkRandSpellStrength.Text = "Randomize spell strengths";
            this.adjustments.SetToolTip(this.chkRandSpellStrength, "Randomizes the strength of spells.");
            this.chkRandSpellStrength.UseVisualStyleBackColor = true;
            this.chkRandSpellStrength.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandSpellLearning
            // 
            this.chkRandSpellLearning.AutoSize = true;
            this.chkRandSpellLearning.Location = new System.Drawing.Point(7, 140);
            this.chkRandSpellLearning.Name = "chkRandSpellLearning";
            this.chkRandSpellLearning.Size = new System.Drawing.Size(143, 17);
            this.chkRandSpellLearning.TabIndex = 178;
            this.chkRandSpellLearning.Text = "Randomize spell learning";
            this.adjustments.SetToolTip(this.chkRandSpellLearning, "Randomizes the class and level spells are learned. Field and battle spells are le" +
        "arned separately.");
            this.chkRandSpellLearning.UseVisualStyleBackColor = true;
            this.chkRandSpellLearning.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandHero
            // 
            this.chk_RandHero.AutoSize = true;
            this.chk_RandHero.Location = new System.Drawing.Point(539, 88);
            this.chk_RandHero.Name = "chk_RandHero";
            this.chk_RandHero.Size = new System.Drawing.Size(49, 17);
            this.chk_RandHero.TabIndex = 171;
            this.chk_RandHero.Text = "Hero";
            this.chk_RandHero.UseVisualStyleBackColor = true;
            this.chk_RandHero.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSage
            // 
            this.chk_RandSage.AutoSize = true;
            this.chk_RandSage.Location = new System.Drawing.Point(539, 68);
            this.chk_RandSage.Name = "chk_RandSage";
            this.chk_RandSage.Size = new System.Drawing.Size(51, 17);
            this.chk_RandSage.TabIndex = 170;
            this.chk_RandSage.Text = "Sage";
            this.chk_RandSage.UseVisualStyleBackColor = true;
            this.chk_RandSage.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandGoofOff
            // 
            this.chk_RandGoofOff.AutoSize = true;
            this.chk_RandGoofOff.Location = new System.Drawing.Point(539, 49);
            this.chk_RandGoofOff.Name = "chk_RandGoofOff";
            this.chk_RandGoofOff.Size = new System.Drawing.Size(66, 17);
            this.chk_RandGoofOff.TabIndex = 169;
            this.chk_RandGoofOff.Text = "Goof-Off";
            this.chk_RandGoofOff.UseVisualStyleBackColor = true;
            this.chk_RandGoofOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandMerchant
            // 
            this.chk_RandMerchant.AutoSize = true;
            this.chk_RandMerchant.Location = new System.Drawing.Point(539, 29);
            this.chk_RandMerchant.Name = "chk_RandMerchant";
            this.chk_RandMerchant.Size = new System.Drawing.Size(71, 17);
            this.chk_RandMerchant.TabIndex = 168;
            this.chk_RandMerchant.Text = "Merchant";
            this.chk_RandMerchant.UseVisualStyleBackColor = true;
            this.chk_RandMerchant.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandFighter
            // 
            this.chk_RandFighter.AutoSize = true;
            this.chk_RandFighter.Location = new System.Drawing.Point(465, 88);
            this.chk_RandFighter.Name = "chk_RandFighter";
            this.chk_RandFighter.Size = new System.Drawing.Size(58, 17);
            this.chk_RandFighter.TabIndex = 167;
            this.chk_RandFighter.Text = "Fighter";
            this.chk_RandFighter.UseVisualStyleBackColor = true;
            this.chk_RandFighter.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandWizard
            // 
            this.chk_RandWizard.Location = new System.Drawing.Point(465, 68);
            this.chk_RandWizard.Name = "chk_RandWizard";
            this.chk_RandWizard.Size = new System.Drawing.Size(68, 17);
            this.chk_RandWizard.TabIndex = 166;
            this.chk_RandWizard.Text = "Wizard";
            this.chk_RandWizard.UseVisualStyleBackColor = true;
            this.chk_RandWizard.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandPilgrim
            // 
            this.chk_RandPilgrim.AutoSize = true;
            this.chk_RandPilgrim.Location = new System.Drawing.Point(465, 49);
            this.chk_RandPilgrim.Name = "chk_RandPilgrim";
            this.chk_RandPilgrim.Size = new System.Drawing.Size(56, 17);
            this.chk_RandPilgrim.TabIndex = 165;
            this.chk_RandPilgrim.Text = "Pilgrim";
            this.chk_RandPilgrim.UseVisualStyleBackColor = true;
            this.chk_RandPilgrim.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSoldier
            // 
            this.chk_RandSoldier.AutoSize = true;
            this.chk_RandSoldier.Location = new System.Drawing.Point(465, 29);
            this.chk_RandSoldier.Name = "chk_RandSoldier";
            this.chk_RandSoldier.Size = new System.Drawing.Size(58, 17);
            this.chk_RandSoldier.TabIndex = 164;
            this.chk_RandSoldier.Text = "Soldier";
            this.chk_RandSoldier.UseVisualStyleBackColor = true;
            this.chk_RandSoldier.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomGender
            // 
            this.chk_RandomGender.AutoSize = true;
            this.chk_RandomGender.Location = new System.Drawing.Point(156, 29);
            this.chk_RandomGender.Name = "chk_RandomGender";
            this.chk_RandomGender.Size = new System.Drawing.Size(117, 17);
            this.chk_RandomGender.TabIndex = 152;
            this.chk_RandomGender.Text = "Randomize Gender";
            this.adjustments.SetToolTip(this.chk_RandomGender, "Randomizes gender of party members.");
            this.chk_RandomGender.UseVisualStyleBackColor = true;
            this.chk_RandomGender.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomClass
            // 
            this.chk_RandomClass.AutoSize = true;
            this.chk_RandomClass.Location = new System.Drawing.Point(312, 29);
            this.chk_RandomClass.Name = "chk_RandomClass";
            this.chk_RandomClass.Size = new System.Drawing.Size(107, 17);
            this.chk_RandomClass.TabIndex = 153;
            this.chk_RandomClass.Text = "Randomize Class";
            this.adjustments.SetToolTip(this.chk_RandomClass, "Randomizes the class of party members.");
            this.chk_RandomClass.UseVisualStyleBackColor = true;
            this.chk_RandomClass.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomName
            // 
            this.chk_RandomName.AutoSize = true;
            this.chk_RandomName.Location = new System.Drawing.Point(7, 29);
            this.chk_RandomName.Name = "chk_RandomName";
            this.chk_RandomName.Size = new System.Drawing.Size(115, 17);
            this.chk_RandomName.TabIndex = 151;
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
            this.cboGender3.Location = new System.Drawing.Point(156, 88);
            this.cboGender3.Name = "cboGender3";
            this.cboGender3.Size = new System.Drawing.Size(150, 21);
            this.cboGender3.TabIndex = 160;
            // 
            // cboGender2
            // 
            this.cboGender2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender2.FormattingEnabled = true;
            this.cboGender2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender2.Location = new System.Drawing.Point(156, 68);
            this.cboGender2.Name = "cboGender2";
            this.cboGender2.Size = new System.Drawing.Size(150, 21);
            this.cboGender2.TabIndex = 159;
            // 
            // cboGender1
            // 
            this.cboGender1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender1.FormattingEnabled = true;
            this.cboGender1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender1.Location = new System.Drawing.Point(156, 49);
            this.cboGender1.Name = "cboGender1";
            this.cboGender1.Size = new System.Drawing.Size(150, 21);
            this.cboGender1.TabIndex = 158;
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
            this.cboClass3.Location = new System.Drawing.Point(312, 88);
            this.cboClass3.Name = "cboClass3";
            this.cboClass3.Size = new System.Drawing.Size(138, 21);
            this.cboClass3.TabIndex = 163;
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
            this.cboClass2.Location = new System.Drawing.Point(312, 68);
            this.cboClass2.Name = "cboClass2";
            this.cboClass2.Size = new System.Drawing.Size(138, 21);
            this.cboClass2.TabIndex = 162;
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
            this.cboClass1.Location = new System.Drawing.Point(312, 49);
            this.cboClass1.Name = "cboClass1";
            this.cboClass1.Size = new System.Drawing.Size(138, 21);
            this.cboClass1.TabIndex = 161;
            this.cboClass1.SelectedIndexChanged += new System.EventHandler(this.cboClass1_SelectedIndexChanged);
            // 
            // txtCharName2
            // 
            this.txtCharName2.Location = new System.Drawing.Point(7, 68);
            this.txtCharName2.MaxLength = 8;
            this.txtCharName2.Name = "txtCharName2";
            this.txtCharName2.Size = new System.Drawing.Size(143, 20);
            this.txtCharName2.TabIndex = 155;
            // 
            // txtCharName3
            // 
            this.txtCharName3.Location = new System.Drawing.Point(7, 88);
            this.txtCharName3.MaxLength = 8;
            this.txtCharName3.Name = "txtCharName3";
            this.txtCharName3.Size = new System.Drawing.Size(143, 20);
            this.txtCharName3.TabIndex = 156;
            // 
            // txtCharName1
            // 
            this.txtCharName1.Location = new System.Drawing.Point(7, 49);
            this.txtCharName1.MaxLength = 8;
            this.txtCharName1.Name = "txtCharName1";
            this.txtCharName1.Size = new System.Drawing.Size(143, 20);
            this.txtCharName1.TabIndex = 154;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chk_FixHeroSpell);
            this.tabPage5.Controls.Add(this.chkRemoveParryFight);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(697, 258);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fixes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chk_FixHeroSpell
            // 
            this.chk_FixHeroSpell.AutoSize = true;
            this.chk_FixHeroSpell.Location = new System.Drawing.Point(7, 29);
            this.chk_FixHeroSpell.Margin = new System.Windows.Forms.Padding(2);
            this.chk_FixHeroSpell.Name = "chk_FixHeroSpell";
            this.chk_FixHeroSpell.Size = new System.Drawing.Size(121, 17);
            this.chk_FixHeroSpell.TabIndex = 191;
            this.chk_FixHeroSpell.Text = "Fix Hero Spell Glitch";
            this.adjustments.SetToolTip(this.chk_FixHeroSpell, "Removes Hero 8 Spell glitch when creating characters.");
            this.chk_FixHeroSpell.UseVisualStyleBackColor = true;
            this.chk_FixHeroSpell.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRemoveParryFight
            // 
            this.chkRemoveParryFight.AutoSize = true;
            this.chkRemoveParryFight.Location = new System.Drawing.Point(7, 10);
            this.chkRemoveParryFight.Name = "chkRemoveParryFight";
            this.chkRemoveParryFight.Size = new System.Drawing.Size(143, 17);
            this.chkRemoveParryFight.TabIndex = 190;
            this.chkRemoveParryFight.Text = "Remove Parry/Fight Bug";
            this.adjustments.SetToolTip(this.chkRemoveParryFight, "Removes Parry/Fight bug found in original DWIII");
            this.chkRemoveParryFight.UseVisualStyleBackColor = true;
            this.chkRemoveParryFight.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label17);
            this.tabPage7.Controls.Add(this.label16);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.chk_levelUpText);
            this.tabPage7.Controls.Add(this.chk_FemaleHero);
            this.tabPage7.Controls.Add(this.chk_RandNPCSprites);
            this.tabPage7.Controls.Add(this.chk_FFigherSprite);
            this.tabPage7.Controls.Add(this.chk_EveryoneCat);
            this.tabPage7.Controls.Add(this.chk_changeCats);
            this.tabPage7.Controls.Add(this.chk_GhostToCasket);
            this.tabPage7.Controls.Add(this.chk_RandSpriteColor);
            this.tabPage7.Controls.Add(this.chk_ChangeHeroAge);
            this.tabPage7.Controls.Add(this.chk_LowerCaseMenus);
            this.tabPage7.Controls.Add(this.chk_FixSlimeSnail);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(697, 258);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Cosmetic";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(477, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 13);
            this.label17.TabIndex = 230;
            this.label17.Text = "Sprite Change - Flag Change";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 10);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 220;
            this.label16.Text = "Sprite Change";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(166, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 13);
            this.label15.TabIndex = 210;
            this.label15.Text = "Text Adjust - Flag Change";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 201;
            this.label13.Text = "Text Adjust";
            // 
            // chk_levelUpText
            // 
            this.chk_levelUpText.AutoSize = true;
            this.chk_levelUpText.Location = new System.Drawing.Point(166, 29);
            this.chk_levelUpText.Margin = new System.Windows.Forms.Padding(2);
            this.chk_levelUpText.Name = "chk_levelUpText";
            this.chk_levelUpText.Size = new System.Drawing.Size(133, 17);
            this.chk_levelUpText.TabIndex = 211;
            this.chk_levelUpText.Text = "Change Level Up Text";
            this.chk_levelUpText.UseVisualStyleBackColor = true;
            // 
            // chk_FemaleHero
            // 
            this.chk_FemaleHero.AutoSize = true;
            this.chk_FemaleHero.Location = new System.Drawing.Point(320, 29);
            this.chk_FemaleHero.Margin = new System.Windows.Forms.Padding(2);
            this.chk_FemaleHero.Name = "chk_FemaleHero";
            this.chk_FemaleHero.Size = new System.Drawing.Size(121, 17);
            this.chk_FemaleHero.TabIndex = 221;
            this.chk_FemaleHero.Text = "Female Hero Sprites";
            this.adjustments.SetToolTip(this.chk_FemaleHero, "Selects female sprites for the Hero Sprite. (Does not affect gameplay. Choose Fem" +
        "ale as sex at start to add equipment benefits.)");
            this.chk_FemaleHero.UseVisualStyleBackColor = true;
            // 
            // chk_RandNPCSprites
            // 
            this.chk_RandNPCSprites.AutoSize = true;
            this.chk_RandNPCSprites.Location = new System.Drawing.Point(320, 88);
            this.chk_RandNPCSprites.Margin = new System.Windows.Forms.Padding(2);
            this.chk_RandNPCSprites.Name = "chk_RandNPCSprites";
            this.chk_RandNPCSprites.Size = new System.Drawing.Size(139, 17);
            this.chk_RandNPCSprites.TabIndex = 224;
            this.chk_RandNPCSprites.Text = "Randomize NPC Sprites";
            this.chk_RandNPCSprites.UseVisualStyleBackColor = true;
            // 
            // chk_FFigherSprite
            // 
            this.chk_FFigherSprite.AutoSize = true;
            this.chk_FFigherSprite.Location = new System.Drawing.Point(320, 68);
            this.chk_FFigherSprite.Margin = new System.Windows.Forms.Padding(2);
            this.chk_FFigherSprite.Name = "chk_FFigherSprite";
            this.chk_FFigherSprite.Size = new System.Drawing.Size(141, 17);
            this.chk_FFigherSprite.TabIndex = 223;
            this.chk_FFigherSprite.Text = "Female Fighter Sprite Fix";
            this.chk_FFigherSprite.UseVisualStyleBackColor = true;
            // 
            // chk_EveryoneCat
            // 
            this.chk_EveryoneCat.AutoSize = true;
            this.chk_EveryoneCat.Location = new System.Drawing.Point(320, 129);
            this.chk_EveryoneCat.Margin = new System.Windows.Forms.Padding(2);
            this.chk_EveryoneCat.Name = "chk_EveryoneCat";
            this.chk_EveryoneCat.Size = new System.Drawing.Size(108, 17);
            this.chk_EveryoneCat.TabIndex = 226;
            this.chk_EveryoneCat.Text = "Everyone is a cat";
            this.chk_EveryoneCat.UseVisualStyleBackColor = true;
            this.chk_EveryoneCat.Visible = false;
            // 
            // chk_changeCats
            // 
            this.chk_changeCats.AutoSize = true;
            this.chk_changeCats.Location = new System.Drawing.Point(320, 109);
            this.chk_changeCats.Name = "chk_changeCats";
            this.chk_changeCats.Size = new System.Drawing.Size(163, 17);
            this.chk_changeCats.TabIndex = 225;
            this.chk_changeCats.Text = "Change cats to other animals";
            this.adjustments.SetToolTip(this.chk_changeCats, "Changes cat sprites to other animals from other Dragon Warrior games.");
            this.chk_changeCats.UseVisualStyleBackColor = true;
            // 
            // chk_GhostToCasket
            // 
            this.chk_GhostToCasket.AutoSize = true;
            this.chk_GhostToCasket.Location = new System.Drawing.Point(477, 49);
            this.chk_GhostToCasket.Name = "chk_GhostToCasket";
            this.chk_GhostToCasket.Size = new System.Drawing.Size(152, 17);
            this.chk_GhostToCasket.TabIndex = 232;
            this.chk_GhostToCasket.Text = "Change Ghosts to Caskets";
            this.adjustments.SetToolTip(this.chk_GhostToCasket, "This will change dead party members from ghosts into caskets (palls) and adjusts " +
        "relevant text.");
            this.chk_GhostToCasket.UseVisualStyleBackColor = true;
            // 
            // chk_RandSpriteColor
            // 
            this.chk_RandSpriteColor.AutoSize = true;
            this.chk_RandSpriteColor.Location = new System.Drawing.Point(320, 49);
            this.chk_RandSpriteColor.Name = "chk_RandSpriteColor";
            this.chk_RandSpriteColor.Size = new System.Drawing.Size(141, 17);
            this.chk_RandSpriteColor.TabIndex = 222;
            this.chk_RandSpriteColor.Text = "Randomize Sprite Colors";
            this.adjustments.SetToolTip(this.chk_RandSpriteColor, "Randomizes the colors of overworld sprites. There may be some interesting combina" +
        "tions.");
            this.chk_RandSpriteColor.UseVisualStyleBackColor = true;
            // 
            // chk_ChangeHeroAge
            // 
            this.chk_ChangeHeroAge.AutoSize = true;
            this.chk_ChangeHeroAge.Location = new System.Drawing.Point(477, 29);
            this.chk_ChangeHeroAge.Name = "chk_ChangeHeroAge";
            this.chk_ChangeHeroAge.Size = new System.Drawing.Size(118, 17);
            this.chk_ChangeHeroAge.TabIndex = 231;
            this.chk_ChangeHeroAge.Text = "Change Hero\'s Age";
            this.adjustments.SetToolTip(this.chk_ChangeHeroAge, "Changes the hero\'s age in opening to a random number and potentially the sprite b" +
        "ased on age.");
            this.chk_ChangeHeroAge.UseVisualStyleBackColor = true;
            // 
            // chk_LowerCaseMenus
            // 
            this.chk_LowerCaseMenus.AutoSize = true;
            this.chk_LowerCaseMenus.Location = new System.Drawing.Point(7, 29);
            this.chk_LowerCaseMenus.Name = "chk_LowerCaseMenus";
            this.chk_LowerCaseMenus.Size = new System.Drawing.Size(131, 17);
            this.chk_LowerCaseMenus.TabIndex = 202;
            this.chk_LowerCaseMenus.Text = "Standard Case Menus";
            this.adjustments.SetToolTip(this.chk_LowerCaseMenus, "Changes casing of all caps menu items to standard caps and lower case.");
            this.chk_LowerCaseMenus.UseVisualStyleBackColor = true;
            // 
            // chk_FixSlimeSnail
            // 
            this.chk_FixSlimeSnail.AutoSize = true;
            this.chk_FixSlimeSnail.Location = new System.Drawing.Point(7, 49);
            this.chk_FixSlimeSnail.Name = "chk_FixSlimeSnail";
            this.chk_FixSlimeSnail.Size = new System.Drawing.Size(93, 17);
            this.chk_FixSlimeSnail.TabIndex = 203;
            this.chk_FixSlimeSnail.Text = "Fix Slime Snail";
            this.adjustments.SetToolTip(this.chk_FixSlimeSnail, "Fixes Slime Snaii name to Slime Snail");
            this.chk_FixSlimeSnail.UseVisualStyleBackColor = true;
            this.chk_FixSlimeSnail.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Flags";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(117, 185);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(439, 20);
            this.txtFlags.TabIndex = 31;
            this.txtFlags.Leave += new System.EventHandler(this.determineChecks);
            // 
            // chk_GenCompareFile
            // 
            this.chk_GenCompareFile.AutoSize = true;
            this.chk_GenCompareFile.Location = new System.Drawing.Point(187, 520);
            this.chk_GenCompareFile.Name = "chk_GenCompareFile";
            this.chk_GenCompareFile.Size = new System.Drawing.Size(134, 17);
            this.chk_GenCompareFile.TabIndex = 230;
            this.chk_GenCompareFile.Text = "Generate Compare File";
            this.adjustments.SetToolTip(this.chk_GenCompareFile, "Generates compare file on build. This will adjust randomization to avoid spoilers" +
        " (item locations, monster stats/spells.)");
            this.chk_GenCompareFile.UseVisualStyleBackColor = true;
            this.chk_GenCompareFile.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_GenIslandsMonstersZones
            // 
            this.chk_GenIslandsMonstersZones.AutoSize = true;
            this.chk_GenIslandsMonstersZones.Location = new System.Drawing.Point(337, 520);
            this.chk_GenIslandsMonstersZones.Name = "chk_GenIslandsMonstersZones";
            this.chk_GenIslandsMonstersZones.Size = new System.Drawing.Size(229, 17);
            this.chk_GenIslandsMonstersZones.TabIndex = 231;
            this.chk_GenIslandsMonstersZones.Text = "Generate islands, monsters, and zones files";
            this.adjustments.SetToolTip(this.chk_GenIslandsMonstersZones, "Generates debug files for islands, monsters, and zones.");
            this.chk_GenIslandsMonstersZones.UseVisualStyleBackColor = true;
            // 
            // btnCopyChecksum
            // 
            this.btnCopyChecksum.Location = new System.Drawing.Point(527, 101);
            this.btnCopyChecksum.Name = "btnCopyChecksum";
            this.btnCopyChecksum.Size = new System.Drawing.Size(123, 23);
            this.btnCopyChecksum.TabIndex = 15;
            this.btnCopyChecksum.Text = "Copy New Checksum";
            this.btnCopyChecksum.UseVisualStyleBackColor = true;
            this.btnCopyChecksum.Click += new System.EventHandler(this.btnCopyChecksum_Click);
            // 
            // lblNewChecksum
            // 
            this.lblNewChecksum.AutoSize = true;
            this.lblNewChecksum.Location = new System.Drawing.Point(117, 101);
            this.lblNewChecksum.Name = "lblNewChecksum";
            this.lblNewChecksum.Size = new System.Drawing.Size(247, 13);
            this.lblNewChecksum.TabIndex = 14;
            this.lblNewChecksum.Text = "????????????????????????????????????????";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "New Checksum";
            // 
            // grpFlags
            // 
            this.grpFlags.Controls.Add(this.optSotWFlags);
            this.grpFlags.Controls.Add(this.opt_JustForFun);
            this.grpFlags.Controls.Add(this.optTradSotWFlags);
            this.grpFlags.Controls.Add(this.optManualFlags);
            this.grpFlags.Location = new System.Drawing.Point(116, 144);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Size = new System.Drawing.Size(405, 32);
            this.grpFlags.TabIndex = 20;
            this.grpFlags.TabStop = false;
            // 
            // optSotWFlags
            // 
            this.optSotWFlags.AutoSize = true;
            this.optSotWFlags.Location = new System.Drawing.Point(97, 10);
            this.optSotWFlags.Margin = new System.Windows.Forms.Padding(2);
            this.optSotWFlags.Name = "optSotWFlags";
            this.optSotWFlags.Size = new System.Drawing.Size(80, 17);
            this.optSotWFlags.TabIndex = 22;
            this.optSotWFlags.TabStop = true;
            this.optSotWFlags.Text = "SotW Flags";
            this.optSotWFlags.UseVisualStyleBackColor = true;
            this.optSotWFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // opt_JustForFun
            // 
            this.opt_JustForFun.AutoSize = true;
            this.opt_JustForFun.Location = new System.Drawing.Point(314, 10);
            this.opt_JustForFun.Margin = new System.Windows.Forms.Padding(2);
            this.opt_JustForFun.Name = "opt_JustForFun";
            this.opt_JustForFun.Size = new System.Drawing.Size(83, 17);
            this.opt_JustForFun.TabIndex = 24;
            this.opt_JustForFun.TabStop = true;
            this.opt_JustForFun.Text = "Just For Fun";
            this.opt_JustForFun.UseVisualStyleBackColor = true;
            this.opt_JustForFun.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optTradSotWFlags
            // 
            this.optTradSotWFlags.AutoSize = true;
            this.optTradSotWFlags.Location = new System.Drawing.Point(180, 10);
            this.optTradSotWFlags.Name = "optTradSotWFlags";
            this.optTradSotWFlags.Size = new System.Drawing.Size(132, 17);
            this.optTradSotWFlags.TabIndex = 23;
            this.optTradSotWFlags.Text = "Traditional SotW Flags";
            this.optTradSotWFlags.UseVisualStyleBackColor = true;
            this.optTradSotWFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optManualFlags
            // 
            this.optManualFlags.AutoSize = true;
            this.optManualFlags.Checked = true;
            this.optManualFlags.Location = new System.Drawing.Point(7, 10);
            this.optManualFlags.Name = "optManualFlags";
            this.optManualFlags.Size = new System.Drawing.Size(88, 17);
            this.optManualFlags.TabIndex = 21;
            this.optManualFlags.TabStop = true;
            this.optManualFlags.Text = "Manual Flags";
            this.optManualFlags.UseVisualStyleBackColor = true;
            this.optManualFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Hash";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(117, 123);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(247, 13);
            this.lblHash.TabIndex = 17;
            this.lblHash.Text = "????????????????????????????????????????";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(117, 208);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(439, 20);
            this.txtSeed.TabIndex = 33;
            // 
            // btn_CopyHash
            // 
            this.btn_CopyHash.Location = new System.Drawing.Point(527, 123);
            this.btn_CopyHash.Name = "btn_CopyHash";
            this.btn_CopyHash.Size = new System.Drawing.Size(123, 23);
            this.btn_CopyHash.TabIndex = 18;
            this.btn_CopyHash.Text = "Copy Hash";
            this.btn_CopyHash.UseVisualStyleBackColor = true;
            this.btn_CopyHash.Click += new System.EventHandler(this.btn_CopyHash_Click);
            // 
            // btn_chksumHash
            // 
            this.btn_chksumHash.Location = new System.Drawing.Point(527, 78);
            this.btn_chksumHash.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chksumHash.Name = "btn_chksumHash";
            this.btn_chksumHash.Size = new System.Drawing.Size(123, 23);
            this.btn_chksumHash.TabIndex = 12;
            this.btn_chksumHash.Text = "Copy Checksum/Hash";
            this.btn_chksumHash.UseVisualStyleBackColor = true;
            this.btn_chksumHash.Click += new System.EventHandler(this.btn_chksumHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 555);
            this.Controls.Add(this.btn_chksumHash);
            this.Controls.Add(this.btn_CopyHash);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.label12);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grp_InvisShipBird.ResumeLayout(false);
            this.grp_InvisShipBird.PerformLayout();
            this.grp_PartyItems.ResumeLayout(false);
            this.grp_PartyItems.PerformLayout();
            this.grp_doubleAtt.ResumeLayout(false);
            this.grp_doubleAtt.PerformLayout();
            this.grp_DispEqPower.ResumeLayout(false);
            this.grp_DispEqPower.PerformLayout();
            this.grp_Lamia.ResumeLayout(false);
            this.grp_Lamia.PerformLayout();
            this.grp_cod.ResumeLayout(false);
            this.grp_cod.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_RmManips.ResumeLayout(false);
            this.grp_RmManips.PerformLayout();
            this.grp_SpeedUpMenus.ResumeLayout(false);
            this.grp_SpeedUpMenus.PerformLayout();
            this.grp_SpeedUpText.ResumeLayout(false);
            this.grp_SpeedUpText.PerformLayout();
            this.grp_IncBatSpeed.ResumeLayout(false);
            this.grp_IncBatSpeed.PerformLayout();
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
            this.grpMonsterStat.ResumeLayout(false);
            this.grpMonsterStat.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.grpFlags.ResumeLayout(false);
            this.grpFlags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSHAChecksum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReqChecksum;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewSeed;
        private System.Windows.Forms.TextBox txtCompare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompareBrowse;
        private System.Windows.Forms.Label lblIntensityDesc;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.CheckBox chk_RemoveStartEqRestrictions;
        private System.Windows.Forms.CheckBox chk_RemMetalMonRun;
        private System.Windows.Forms.Label lbl_TreasurePool;
        private System.Windows.Forms.CheckBox chk_RmFighterPenalty;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.CheckBox chk_UseVanEquipValues;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox chk_LowerCaseMenus;
        private System.Windows.Forms.CheckBox chk_ChangeDefaultParty;
        private System.Windows.Forms.CheckBox chk_GenCompareFile;
        private System.Windows.Forms.CheckBox chk_ChangeHeroAge;
        private System.Windows.Forms.CheckBox chk_GenIslandsMonstersZones;
        private System.Windows.Forms.CheckBox chk_RandSpriteColor;
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
        private System.Windows.Forms.RadioButton optTradSotWFlags;
        private System.Windows.Forms.RadioButton optManualFlags;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.CheckBox chk_GreenSilverOrb;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.CheckBox chk_AdjustEqpPrices;
        private System.Windows.Forms.CheckBox chk_InvisibleNPCs;
        private System.Windows.Forms.CheckBox chk_changeCats;
        private System.Windows.Forms.CheckBox chk_sellUnsellItems;
        private System.Windows.Forms.CheckBox chk_RmRedundKey;
        private System.Windows.Forms.Button btn_CopyHash;
        private System.Windows.Forms.CheckBox chk_AddRemakeEq;
        private System.Windows.Forms.CheckBox chk_FixHeroSpell;
        private System.Windows.Forms.RadioButton opt_JustForFun;
        private System.Windows.Forms.CheckBox chk_RandDrop;
        private System.Windows.Forms.CheckBox chk_RemDupPool;
        private System.Windows.Forms.GroupBox grpMonsterStat;
        private System.Windows.Forms.RadioButton optStatSilly;
        private System.Windows.Forms.RadioButton optStatHeavy;
        private System.Windows.Forms.RadioButton optStatMedium;
        private System.Windows.Forms.Button btn_chksumHash;
        private System.Windows.Forms.CheckBox chk_EveryoneCat;
        private System.Windows.Forms.CheckBox chk_HealUsAllStone;
        private System.Windows.Forms.CheckBox chk_randsagestone;
        private System.Windows.Forms.CheckBox chk_BigShoes;
        private System.Windows.Forms.CheckBox chk_RandShoesEffect;
        private System.Windows.Forms.CheckBox chk_FFigherSprite;
        private System.Windows.Forms.CheckBox chk_RandNPCSprites;
        private System.Windows.Forms.CheckBox chk_FemaleHero;
        private System.Windows.Forms.CheckBox chk_ShrineRando;
        private System.Windows.Forms.CheckBox chk_RandoCaves;
        private System.Windows.Forms.CheckBox chk_RandoTowns;
        private System.Windows.Forms.RadioButton optSotWFlags;
        private System.Windows.Forms.CheckBox chk_nonMagicMP;
        private System.Windows.Forms.CheckBox chk_levelUpText;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grp_IncBatSpeed;
        private System.Windows.Forms.RadioButton rad_IncBattSpeedRand;
        private System.Windows.Forms.RadioButton rad_IncBattSpeedOn;
        private System.Windows.Forms.RadioButton rad_IncBattSpeedOff;
        private System.Windows.Forms.GroupBox grp_SpeedUpText;
        private System.Windows.Forms.RadioButton rad_SpeedTextRand;
        private System.Windows.Forms.RadioButton rad_SpeedTextOn;
        private System.Windows.Forms.RadioButton rad_SpeedTextOff;
        private System.Windows.Forms.GroupBox grp_SpeedUpMenus;
        private System.Windows.Forms.RadioButton rad_SpeedUpMenuRand;
        private System.Windows.Forms.RadioButton rad_SpeedUpMenusOn;
        private System.Windows.Forms.RadioButton rad_SpeedUpMenuOff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grp_RmManips;
        private System.Windows.Forms.RadioButton rad_RmManipRand;
        private System.Windows.Forms.RadioButton rad_RmManipOn;
        private System.Windows.Forms.RadioButton rad_RmManipOff;
        private System.Windows.Forms.RadioButton rad_StartGoldRand;
        private System.Windows.Forms.RadioButton rad_StartGoldOff;
        private System.Windows.Forms.RadioButton rad_StartGoldOn;
        private System.Windows.Forms.GroupBox grp_cod;
        private System.Windows.Forms.RadioButton rad_codRand;
        private System.Windows.Forms.RadioButton rad_codOn;
        private System.Windows.Forms.RadioButton rad_codOff;
        private System.Windows.Forms.GroupBox grp_Lamia;
        private System.Windows.Forms.RadioButton rad_LamiaRand;
        private System.Windows.Forms.RadioButton rad_LamiaOn;
        private System.Windows.Forms.RadioButton rad_LamiaOff;
        private System.Windows.Forms.GroupBox grp_DispEqPower;
        private System.Windows.Forms.RadioButton rad_DispEqPowerRand;
        private System.Windows.Forms.RadioButton rad_DispEqPowerOn;
        private System.Windows.Forms.RadioButton rad_DispEqPowerOff;
        private System.Windows.Forms.GroupBox grp_doubleAtt;
        private System.Windows.Forms.RadioButton rad_DoubleAttRand;
        private System.Windows.Forms.RadioButton rad_DoubleAttOn;
        private System.Windows.Forms.RadioButton rad_DoubleAttOff;
        private System.Windows.Forms.GroupBox grp_PartyItems;
        private System.Windows.Forms.RadioButton rad_PartyItemsRand;
        private System.Windows.Forms.RadioButton rad_PartyItemsOn;
        private System.Windows.Forms.RadioButton rad_PartyItemsOff;
        private System.Windows.Forms.GroupBox grp_InvisShipBird;
        private System.Windows.Forms.RadioButton rad_InvisShipBirdRand;
        private System.Windows.Forms.RadioButton rad_InvisShipBirdOn;
        private System.Windows.Forms.RadioButton rad_InvisShipBirdOff;
    }
}

