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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tchk_InvisShipBird = new System.Windows.Forms.CheckBox();
            this.tchk_BigSoHRoL = new System.Windows.Forms.CheckBox();
            this.tchk_SoHRoLEff = new System.Windows.Forms.CheckBox();
            this.tchk_HUAStone = new System.Windows.Forms.CheckBox();
            this.tchk_SagesStone = new System.Windows.Forms.CheckBox();
            this.tchk_InvisNPC = new System.Windows.Forms.CheckBox();
            this.tchk_FourJobFiesta = new System.Windows.Forms.CheckBox();
            this.tchk_PartyItems = new System.Windows.Forms.CheckBox();
            this.tchk_NoOrb = new System.Windows.Forms.CheckBox();
            this.tchk_DoubleAttack = new System.Windows.Forms.CheckBox();
            this.tchk_NonMPJobs = new System.Windows.Forms.CheckBox();
            this.tchk_RandSpellStr = new System.Windows.Forms.CheckBox();
            this.tchk_RandSpellLearn = new System.Windows.Forms.CheckBox();
            this.tchk_DispEqPower = new System.Windows.Forms.CheckBox();
            this.tchk_Cod = new System.Windows.Forms.CheckBox();
            this.tchk_RandStartGold = new System.Windows.Forms.CheckBox();
            this.tchk_RmManips = new System.Windows.Forms.CheckBox();
            this.tchk_SpeedUpMenus = new System.Windows.Forms.CheckBox();
            this.tchk_SpeedUpText = new System.Windows.Forms.CheckBox();
            this.tchk_IncBatSpeed = new System.Windows.Forms.CheckBox();
            this.grp_RandStats = new System.Windows.Forms.GroupBox();
            this.rad_RandStatsRand = new System.Windows.Forms.RadioButton();
            this.rad_RandStatsLud = new System.Windows.Forms.RadioButton();
            this.rad_RandStatsRid = new System.Windows.Forms.RadioButton();
            this.rad_RandStatsSilly = new System.Windows.Forms.RadioButton();
            this.rad_RandStatsOff = new System.Windows.Forms.RadioButton();
            this.grp_EncRate = new System.Windows.Forms.GroupBox();
            this.rad_EncRateRand = new System.Windows.Forms.RadioButton();
            this.rad_EncRate400 = new System.Windows.Forms.RadioButton();
            this.rad_EncRate300 = new System.Windows.Forms.RadioButton();
            this.rad_EncRate200 = new System.Windows.Forms.RadioButton();
            this.rad_EncRate150 = new System.Windows.Forms.RadioButton();
            this.rad_EncRate100 = new System.Windows.Forms.RadioButton();
            this.rad_EncRate75 = new System.Windows.Forms.RadioButton();
            this.rad_EncRate50 = new System.Windows.Forms.RadioButton();
            this.rad_EncRate25 = new System.Windows.Forms.RadioButton();
            this.rad_EncRate0 = new System.Windows.Forms.RadioButton();
            this.grp_GoldGain = new System.Windows.Forms.GroupBox();
            this.rad_GoldGain150 = new System.Windows.Forms.RadioButton();
            this.rad_GoldGainRand = new System.Windows.Forms.RadioButton();
            this.rad_GoldGain200 = new System.Windows.Forms.RadioButton();
            this.rad_GoldGain100 = new System.Windows.Forms.RadioButton();
            this.rad_GoldGain50 = new System.Windows.Forms.RadioButton();
            this.rad_GoldGain1 = new System.Windows.Forms.RadioButton();
            this.grp_ExpGain = new System.Windows.Forms.GroupBox();
            this.rad_ExpGainRand = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain1000 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain750 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain500 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain400 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain300 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain200 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain150 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain100 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain50 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain25 = new System.Windows.Forms.RadioButton();
            this.rad_ExpGain0 = new System.Windows.Forms.RadioButton();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tchk_RmNoEncounter = new System.Windows.Forms.CheckBox();
            this.tchk_NoNewTown = new System.Windows.Forms.CheckBox();
            this.tchk_RmMoatCharlock = new System.Windows.Forms.CheckBox();
            this.tchk_RmMountDQC = new System.Windows.Forms.CheckBox();
            this.tchk_RmMountBaramos = new System.Windows.Forms.CheckBox();
            this.tchk_RmMountNecro = new System.Windows.Forms.CheckBox();
            this.tchk_RmMountLancel = new System.Windows.Forms.CheckBox();
            this.tchk_RandShrines = new System.Windows.Forms.CheckBox();
            this.tchk_RandCaveTower = new System.Windows.Forms.CheckBox();
            this.tchk_RandTowns = new System.Windows.Forms.CheckBox();
            this.tchk_RandMonstZones = new System.Windows.Forms.CheckBox();
            this.tchk_SmallMaps = new System.Windows.Forms.CheckBox();
            this.tchk_RandMaps = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tchk_RmMetalRun = new System.Windows.Forms.CheckBox();
            this.tchk_RandEnAttPat = new System.Windows.Forms.CheckBox();
            this.tchk_RmDupItemPool = new System.Windows.Forms.CheckBox();
            this.tchk_RandDrops = new System.Windows.Forms.CheckBox();
            this.tchk_RandGold = new System.Windows.Forms.CheckBox();
            this.tchk_RandExp = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tchk_RandItemEff = new System.Windows.Forms.CheckBox();
            this.tchk_RmRedKey = new System.Windows.Forms.CheckBox();
            this.tchk_GreenSilvOrb = new System.Windows.Forms.CheckBox();
            this.tchk_AddGoldClaw = new System.Windows.Forms.CheckBox();
            this.tchk_RandTreasures = new System.Windows.Forms.CheckBox();
            this.tchk_AdjEqPrices = new System.Windows.Forms.CheckBox();
            this.tchk_RandEqClass = new System.Windows.Forms.CheckBox();
            this.tchk_RmFigherPen = new System.Windows.Forms.CheckBox();
            this.tchk_RemStartCap = new System.Windows.Forms.CheckBox();
            this.tchk_VanEqVals = new System.Windows.Forms.CheckBox();
            this.tchk_RandEqPower = new System.Windows.Forms.CheckBox();
            this.tchk_AddRemakeEq = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tchk_AnimalSuit = new System.Windows.Forms.CheckBox();
            this.tchk_SellKeyItems = new System.Windows.Forms.CheckBox();
            this.tchk_RandInnPrice = new System.Windows.Forms.CheckBox();
            this.tchk_RandWeapShop = new System.Windows.Forms.CheckBox();
            this.tchk_RandItemShop = new System.Windows.Forms.CheckBox();
            this.grp_AddToItemShop = new System.Windows.Forms.GroupBox();
            this.tchk_PoisonMothPowder = new System.Windows.Forms.CheckBox();
            this.tchk_LeafOfTheWorldTree = new System.Windows.Forms.CheckBox();
            this.tchk_StoneOfLife = new System.Windows.Forms.CheckBox();
            this.tchk_WizardsRing = new System.Windows.Forms.CheckBox();
            this.tchk_BookOfSatori = new System.Windows.Forms.CheckBox();
            this.tchk_RingOfLife = new System.Windows.Forms.CheckBox();
            this.tchk_ShoesOfHappiness = new System.Windows.Forms.CheckBox();
            this.tchk_MeteoriteArmband = new System.Windows.Forms.CheckBox();
            this.tchk_LampOfDarkness = new System.Windows.Forms.CheckBox();
            this.tchk_SilverHarp = new System.Windows.Forms.CheckBox();
            this.tchk_EchoingFlute = new System.Windows.Forms.CheckBox();
            this.tchk_LuckSeed = new System.Windows.Forms.CheckBox();
            this.tchk_VitSeed = new System.Windows.Forms.CheckBox();
            this.tchk_IntSeed = new System.Windows.Forms.CheckBox();
            this.tchk_AgiSeed = new System.Windows.Forms.CheckBox();
            this.tchk_StrSeed = new System.Windows.Forms.CheckBox();
            this.tchk_AcornsOfLife = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grp_Class = new System.Windows.Forms.GroupBox();
            this.grp_ClassInclude = new System.Windows.Forms.GroupBox();
            this.chk_RandSoldier = new System.Windows.Forms.CheckBox();
            this.chk_RandPilgrim = new System.Windows.Forms.CheckBox();
            this.chk_RandWizard = new System.Windows.Forms.CheckBox();
            this.chk_RandFighter = new System.Windows.Forms.CheckBox();
            this.chk_RandMerchant = new System.Windows.Forms.CheckBox();
            this.chk_RandGoofOff = new System.Windows.Forms.CheckBox();
            this.chk_RandHero = new System.Windows.Forms.CheckBox();
            this.chk_RandSage = new System.Windows.Forms.CheckBox();
            this.grp_Class3 = new System.Windows.Forms.GroupBox();
            this.rad_Class3Rand = new System.Windows.Forms.RadioButton();
            this.rad_Class3Manual = new System.Windows.Forms.RadioButton();
            this.rad_Class3Off = new System.Windows.Forms.RadioButton();
            this.cbo_Class3 = new System.Windows.Forms.ComboBox();
            this.grp_Class2 = new System.Windows.Forms.GroupBox();
            this.rad_Class2Rand = new System.Windows.Forms.RadioButton();
            this.rad_Class2Manual = new System.Windows.Forms.RadioButton();
            this.rad_Class2Off = new System.Windows.Forms.RadioButton();
            this.cbo_Class2 = new System.Windows.Forms.ComboBox();
            this.grp_Class1 = new System.Windows.Forms.GroupBox();
            this.rad_Class1Rand = new System.Windows.Forms.RadioButton();
            this.rad_Class1Manual = new System.Windows.Forms.RadioButton();
            this.rad_Class1Off = new System.Windows.Forms.RadioButton();
            this.cbo_Class1 = new System.Windows.Forms.ComboBox();
            this.grp_Gender = new System.Windows.Forms.GroupBox();
            this.grp_Gender3 = new System.Windows.Forms.GroupBox();
            this.rad_Gender3Rand = new System.Windows.Forms.RadioButton();
            this.rad_Gender3Manual = new System.Windows.Forms.RadioButton();
            this.rad_Gender3Off = new System.Windows.Forms.RadioButton();
            this.cbo_Gender3 = new System.Windows.Forms.ComboBox();
            this.grp_Gender2 = new System.Windows.Forms.GroupBox();
            this.rad_Gender2Rand = new System.Windows.Forms.RadioButton();
            this.rad_Gender2Manual = new System.Windows.Forms.RadioButton();
            this.rad_Gender2Off = new System.Windows.Forms.RadioButton();
            this.cbo_Gender2 = new System.Windows.Forms.ComboBox();
            this.grp_Gender1 = new System.Windows.Forms.GroupBox();
            this.rad_Gender1Rand = new System.Windows.Forms.RadioButton();
            this.rad_Gender1Manual = new System.Windows.Forms.RadioButton();
            this.rad_Gender1Off = new System.Windows.Forms.RadioButton();
            this.cbo_Gender1 = new System.Windows.Forms.ComboBox();
            this.grp_ChName = new System.Windows.Forms.GroupBox();
            this.grp_ChName3 = new System.Windows.Forms.GroupBox();
            this.rad_ChName3Rand = new System.Windows.Forms.RadioButton();
            this.rad_ChName3Manual = new System.Windows.Forms.RadioButton();
            this.rad_ChName3Off = new System.Windows.Forms.RadioButton();
            this.txt_ChName3 = new System.Windows.Forms.TextBox();
            this.grp_ChName2 = new System.Windows.Forms.GroupBox();
            this.rad_ChName2Rand = new System.Windows.Forms.RadioButton();
            this.rad_ChName2Manual = new System.Windows.Forms.RadioButton();
            this.rad_ChName2Off = new System.Windows.Forms.RadioButton();
            this.txt_ChName2 = new System.Windows.Forms.TextBox();
            this.grp_ChName1 = new System.Windows.Forms.GroupBox();
            this.rad_ChName1Rand = new System.Windows.Forms.RadioButton();
            this.rad_ChName1Manual = new System.Windows.Forms.RadioButton();
            this.rad_ChName1Off = new System.Windows.Forms.RadioButton();
            this.txt_ChName1 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.grp_FixHeroSpell = new System.Windows.Forms.GroupBox();
            this.rad_FixHeroSpellRand = new System.Windows.Forms.RadioButton();
            this.rad_FixHeroSpellOn = new System.Windows.Forms.RadioButton();
            this.rad_FixHeroSpellOff = new System.Windows.Forms.RadioButton();
            this.grp_RmParryBug = new System.Windows.Forms.GroupBox();
            this.rad_RmParryBugRand = new System.Windows.Forms.RadioButton();
            this.rad_RmParryBugOn = new System.Windows.Forms.RadioButton();
            this.rad_RmParryBugOff = new System.Windows.Forms.RadioButton();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.grp_EveryCat = new System.Windows.Forms.GroupBox();
            this.rad_EveryCatRand = new System.Windows.Forms.RadioButton();
            this.rad_EveryCatOn = new System.Windows.Forms.RadioButton();
            this.rad_EveryCatOff = new System.Windows.Forms.RadioButton();
            this.grp_FFightSprite = new System.Windows.Forms.GroupBox();
            this.rad_FFightSpriteRand = new System.Windows.Forms.RadioButton();
            this.rad_FFightSpriteOn = new System.Windows.Forms.RadioButton();
            this.rad_FFightSpriteOff = new System.Windows.Forms.RadioButton();
            this.grp_ChCats = new System.Windows.Forms.GroupBox();
            this.rad_ChCatsRand = new System.Windows.Forms.RadioButton();
            this.rad_ChCatsOn = new System.Windows.Forms.RadioButton();
            this.rad_ChCatsOff = new System.Windows.Forms.RadioButton();
            this.grp_RandNPC = new System.Windows.Forms.GroupBox();
            this.rad_RandNPCRand = new System.Windows.Forms.RadioButton();
            this.rad_RandNPCOn = new System.Windows.Forms.RadioButton();
            this.rad_RandNPCOff = new System.Windows.Forms.RadioButton();
            this.grp_RandSpriteCol = new System.Windows.Forms.GroupBox();
            this.rad_RandSpriteColRand = new System.Windows.Forms.RadioButton();
            this.rad_RandSpriteColOn = new System.Windows.Forms.RadioButton();
            this.rad_RandSpriteColOff = new System.Windows.Forms.RadioButton();
            this.grp_FHero = new System.Windows.Forms.GroupBox();
            this.rad_FHeroRand = new System.Windows.Forms.RadioButton();
            this.rad_FHeroOn = new System.Windows.Forms.RadioButton();
            this.rad_FHeroOff = new System.Windows.Forms.RadioButton();
            this.grp_SlimeSnail = new System.Windows.Forms.GroupBox();
            this.rad_SlimeSnailRand = new System.Windows.Forms.RadioButton();
            this.rad_SlimeSnailOn = new System.Windows.Forms.RadioButton();
            this.rad_SlimeSnailOff = new System.Windows.Forms.RadioButton();
            this.grp_StdCase = new System.Windows.Forms.GroupBox();
            this.rad_StdCaseRand = new System.Windows.Forms.RadioButton();
            this.rad_StdCaseOn = new System.Windows.Forms.RadioButton();
            this.rad_StdCaseOff = new System.Windows.Forms.RadioButton();
            this.grp_GhostToCasket = new System.Windows.Forms.GroupBox();
            this.rad_GhostToCasketRand = new System.Windows.Forms.RadioButton();
            this.rad_GhostToCasketOn = new System.Windows.Forms.RadioButton();
            this.rad_GhostToCasketOff = new System.Windows.Forms.RadioButton();
            this.grp_RandHeroAge = new System.Windows.Forms.GroupBox();
            this.rad_RandHeroAgeRand = new System.Windows.Forms.RadioButton();
            this.rad_RandHeroAgeOn = new System.Windows.Forms.RadioButton();
            this.rad_RandHeroAgeOff = new System.Windows.Forms.RadioButton();
            this.grp_LevelUpTxt = new System.Windows.Forms.GroupBox();
            this.rad_LevelUpTxtRand = new System.Windows.Forms.RadioButton();
            this.rad_LevelUpTxtOn = new System.Windows.Forms.RadioButton();
            this.rad_LevelUpTxtOff = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.adjustments = new System.Windows.Forms.ToolTip(this.components);
            this.chk_GenCompareFile = new System.Windows.Forms.CheckBox();
            this.chk_GenIslandsMonstersZones = new System.Windows.Forms.CheckBox();
            this.lblNewChecksum = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpFlags = new System.Windows.Forms.GroupBox();
            this.rad_EverythingRand = new System.Windows.Forms.RadioButton();
            this.rad_FastVanilla = new System.Windows.Forms.RadioButton();
            this.optSotWFlags = new System.Windows.Forms.RadioButton();
            this.opt_JustForFun = new System.Windows.Forms.RadioButton();
            this.optTradSotWFlags = new System.Windows.Forms.RadioButton();
            this.optManualFlags = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btn_chksumHash = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grp_RandStats.SuspendLayout();
            this.grp_EncRate.SuspendLayout();
            this.grp_GoldGain.SuspendLayout();
            this.grp_ExpGain.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.grp_AddToItemShop.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grp_Class.SuspendLayout();
            this.grp_ClassInclude.SuspendLayout();
            this.grp_Class3.SuspendLayout();
            this.grp_Class2.SuspendLayout();
            this.grp_Class1.SuspendLayout();
            this.grp_Gender.SuspendLayout();
            this.grp_Gender3.SuspendLayout();
            this.grp_Gender2.SuspendLayout();
            this.grp_Gender1.SuspendLayout();
            this.grp_ChName.SuspendLayout();
            this.grp_ChName3.SuspendLayout();
            this.grp_ChName2.SuspendLayout();
            this.grp_ChName1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.grp_FixHeroSpell.SuspendLayout();
            this.grp_RmParryBug.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.grp_EveryCat.SuspendLayout();
            this.grp_FFightSprite.SuspendLayout();
            this.grp_ChCats.SuspendLayout();
            this.grp_RandNPC.SuspendLayout();
            this.grp_RandSpriteCol.SuspendLayout();
            this.grp_FHero.SuspendLayout();
            this.grp_SlimeSnail.SuspendLayout();
            this.grp_StdCase.SuspendLayout();
            this.grp_GhostToCasket.SuspendLayout();
            this.grp_RandHeroAge.SuspendLayout();
            this.grp_LevelUpTxt.SuspendLayout();
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
            this.btnBrowse.Location = new System.Drawing.Point(608, 9);
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
            this.btnRandomize.Location = new System.Drawing.Point(608, 628);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(77, 23);
            this.btnRandomize.TabIndex = 262;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(608, 55);
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
            this.label3.Location = new System.Drawing.Point(359, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Seed";
            // 
            // btnCompareBrowse
            // 
            this.btnCompareBrowse.Location = new System.Drawing.Point(608, 32);
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
            this.btnNewSeed.Location = new System.Drawing.Point(608, 192);
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
            this.tabControl1.Location = new System.Drawing.Point(7, 220);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 404);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tchk_InvisShipBird);
            this.tabPage1.Controls.Add(this.tchk_BigSoHRoL);
            this.tabPage1.Controls.Add(this.tchk_SoHRoLEff);
            this.tabPage1.Controls.Add(this.tchk_HUAStone);
            this.tabPage1.Controls.Add(this.tchk_SagesStone);
            this.tabPage1.Controls.Add(this.tchk_InvisNPC);
            this.tabPage1.Controls.Add(this.tchk_FourJobFiesta);
            this.tabPage1.Controls.Add(this.tchk_PartyItems);
            this.tabPage1.Controls.Add(this.tchk_NoOrb);
            this.tabPage1.Controls.Add(this.tchk_DoubleAttack);
            this.tabPage1.Controls.Add(this.tchk_NonMPJobs);
            this.tabPage1.Controls.Add(this.tchk_RandSpellStr);
            this.tabPage1.Controls.Add(this.tchk_RandSpellLearn);
            this.tabPage1.Controls.Add(this.tchk_DispEqPower);
            this.tabPage1.Controls.Add(this.tchk_Cod);
            this.tabPage1.Controls.Add(this.tchk_RandStartGold);
            this.tabPage1.Controls.Add(this.tchk_RmManips);
            this.tabPage1.Controls.Add(this.tchk_SpeedUpMenus);
            this.tabPage1.Controls.Add(this.tchk_SpeedUpText);
            this.tabPage1.Controls.Add(this.tchk_IncBatSpeed);
            this.tabPage1.Controls.Add(this.grp_RandStats);
            this.tabPage1.Controls.Add(this.grp_EncRate);
            this.tabPage1.Controls.Add(this.grp_GoldGain);
            this.tabPage1.Controls.Add(this.grp_ExpGain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(678, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adjustments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tchk_InvisShipBird
            // 
            this.tchk_InvisShipBird.AutoSize = true;
            this.tchk_InvisShipBird.Location = new System.Drawing.Point(352, 103);
            this.tchk_InvisShipBird.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_InvisShipBird.Name = "tchk_InvisShipBird";
            this.tchk_InvisShipBird.Size = new System.Drawing.Size(135, 17);
            this.tchk_InvisShipBird.TabIndex = 620;
            this.tchk_InvisShipBird.Text = "Invisible Ships and Bird";
            this.tchk_InvisShipBird.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_InvisShipBird, "Ships and Bird are invisible on world map.");
            this.tchk_InvisShipBird.UseVisualStyleBackColor = true;
            this.tchk_InvisShipBird.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_BigSoHRoL
            // 
            this.tchk_BigSoHRoL.AutoSize = true;
            this.tchk_BigSoHRoL.Location = new System.Drawing.Point(527, 55);
            this.tchk_BigSoHRoL.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_BigSoHRoL.Name = "tchk_BigSoHRoL";
            this.tchk_BigSoHRoL.Size = new System.Drawing.Size(140, 17);
            this.tchk_BigSoHRoL.TabIndex = 619;
            this.tchk_BigSoHRoL.Text = "Big SoH and RoL Effect";
            this.tchk_BigSoHRoL.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_BigSoHRoL, "Randomizes Shoes of Happiness and Ring of Life Effect between 11 and 256 per step" +
        "");
            this.tchk_BigSoHRoL.UseVisualStyleBackColor = true;
            this.tchk_BigSoHRoL.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_SoHRoLEff
            // 
            this.tchk_SoHRoLEff.AutoSize = true;
            this.tchk_SoHRoLEff.Location = new System.Drawing.Point(352, 55);
            this.tchk_SoHRoLEff.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_SoHRoLEff.Name = "tchk_SoHRoLEff";
            this.tchk_SoHRoLEff.Size = new System.Drawing.Size(165, 17);
            this.tchk_SoHRoLEff.TabIndex = 618;
            this.tchk_SoHRoLEff.Text = "Random SoH and RoL Effect";
            this.tchk_SoHRoLEff.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_SoHRoLEff, "Randomizes Shoes of Happiness and Ring of Life Effect between 1 and 10 per step");
            this.tchk_SoHRoLEff.UseVisualStyleBackColor = true;
            this.tchk_SoHRoLEff.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_HUAStone
            // 
            this.tchk_HUAStone.AutoSize = true;
            this.tchk_HUAStone.Location = new System.Drawing.Point(509, 31);
            this.tchk_HUAStone.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_HUAStone.Name = "tchk_HUAStone";
            this.tchk_HUAStone.Size = new System.Drawing.Size(162, 17);
            this.tchk_HUAStone.TabIndex = 617;
            this.tchk_HUAStone.Text = "Guaranteed HealUsAll Stone";
            this.tchk_HUAStone.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_HUAStone, "Guarantees the Sage\'s Stone will cast HealUsAll");
            this.tchk_HUAStone.UseVisualStyleBackColor = true;
            this.tchk_HUAStone.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_SagesStone
            // 
            this.tchk_SagesStone.AutoSize = true;
            this.tchk_SagesStone.Location = new System.Drawing.Point(352, 31);
            this.tchk_SagesStone.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_SagesStone.Name = "tchk_SagesStone";
            this.tchk_SagesStone.Size = new System.Drawing.Size(145, 17);
            this.tchk_SagesStone.TabIndex = 616;
            this.tchk_SagesStone.Text = "Randomize Sage\'s Stone";
            this.tchk_SagesStone.ThreeState = true;
            this.tchk_SagesStone.UseVisualStyleBackColor = true;
            this.tchk_SagesStone.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_InvisNPC
            // 
            this.tchk_InvisNPC.AutoSize = true;
            this.tchk_InvisNPC.Location = new System.Drawing.Point(352, 79);
            this.tchk_InvisNPC.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_InvisNPC.Name = "tchk_InvisNPC";
            this.tchk_InvisNPC.Size = new System.Drawing.Size(94, 17);
            this.tchk_InvisNPC.TabIndex = 615;
            this.tchk_InvisNPC.Text = "Invisible NPCs";
            this.tchk_InvisNPC.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_InvisNPC, "Makes NPCs invisible (but you can still interact with them)");
            this.tchk_InvisNPC.UseVisualStyleBackColor = true;
            this.tchk_InvisNPC.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_FourJobFiesta
            // 
            this.tchk_FourJobFiesta.AutoSize = true;
            this.tchk_FourJobFiesta.Location = new System.Drawing.Point(352, 7);
            this.tchk_FourJobFiesta.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_FourJobFiesta.Name = "tchk_FourJobFiesta";
            this.tchk_FourJobFiesta.Size = new System.Drawing.Size(98, 17);
            this.tchk_FourJobFiesta.TabIndex = 614;
            this.tchk_FourJobFiesta.Text = "Four Job Fiesta";
            this.tchk_FourJobFiesta.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_FourJobFiesta, "Allows the hero to be removed from the party, the hero to change classes, and any" +
        " hero to become a sage.");
            this.tchk_FourJobFiesta.UseVisualStyleBackColor = true;
            this.tchk_FourJobFiesta.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_PartyItems
            // 
            this.tchk_PartyItems.AutoSize = true;
            this.tchk_PartyItems.Location = new System.Drawing.Point(173, 127);
            this.tchk_PartyItems.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_PartyItems.Name = "tchk_PartyItems";
            this.tchk_PartyItems.Size = new System.Drawing.Size(130, 17);
            this.tchk_PartyItems.TabIndex = 613;
            this.tchk_PartyItems.Text = "Party Starts with Items";
            this.tchk_PartyItems.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_PartyItems, "Party starts with a random consumable item.");
            this.tchk_PartyItems.UseVisualStyleBackColor = true;
            this.tchk_PartyItems.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_NoOrb
            // 
            this.tchk_NoOrb.AutoSize = true;
            this.tchk_NoOrb.Location = new System.Drawing.Point(173, 103);
            this.tchk_NoOrb.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_NoOrb.Name = "tchk_NoOrb";
            this.tchk_NoOrb.Size = new System.Drawing.Size(151, 17);
            this.tchk_NoOrb.TabIndex = 612;
            this.tchk_NoOrb.Text = "Require No Orbs for Lamia";
            this.tchk_NoOrb.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_NoOrb, "Do not need orbs to hatch Lamia.");
            this.tchk_NoOrb.UseVisualStyleBackColor = true;
            this.tchk_NoOrb.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_DoubleAttack
            // 
            this.tchk_DoubleAttack.AutoSize = true;
            this.tchk_DoubleAttack.Location = new System.Drawing.Point(173, 79);
            this.tchk_DoubleAttack.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_DoubleAttack.Name = "tchk_DoubleAttack";
            this.tchk_DoubleAttack.Size = new System.Drawing.Size(146, 17);
            this.tchk_DoubleAttack.TabIndex = 611;
            this.tchk_DoubleAttack.Text = "Normal Attacks Hit Twice";
            this.tchk_DoubleAttack.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_DoubleAttack, "Party physical attacks hit twice (is not influenced by Falcon Sword).");
            this.tchk_DoubleAttack.UseVisualStyleBackColor = true;
            this.tchk_DoubleAttack.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_NonMPJobs
            // 
            this.tchk_NonMPJobs.AutoSize = true;
            this.tchk_NonMPJobs.Location = new System.Drawing.Point(173, 55);
            this.tchk_NonMPJobs.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_NonMPJobs.Name = "tchk_NonMPJobs";
            this.tchk_NonMPJobs.Size = new System.Drawing.Size(173, 17);
            this.tchk_NonMPJobs.TabIndex = 610;
            this.tchk_NonMPJobs.Text = "Non-MP Gaining Jobs Gain MP";
            this.tchk_NonMPJobs.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_NonMPJobs, "Non-MP gaining jobs gain MP at level up based on intelligence.");
            this.tchk_NonMPJobs.UseVisualStyleBackColor = true;
            this.tchk_NonMPJobs.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandSpellStr
            // 
            this.tchk_RandSpellStr.AutoSize = true;
            this.tchk_RandSpellStr.Location = new System.Drawing.Point(173, 31);
            this.tchk_RandSpellStr.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_RandSpellStr.Name = "tchk_RandSpellStr";
            this.tchk_RandSpellStr.Size = new System.Drawing.Size(153, 17);
            this.tchk_RandSpellStr.TabIndex = 609;
            this.tchk_RandSpellStr.Text = "Randomize Spell Strengths";
            this.tchk_RandSpellStr.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandSpellStr, "Randomizes the strength of spells.");
            this.tchk_RandSpellStr.UseVisualStyleBackColor = true;
            this.tchk_RandSpellStr.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandSpellLearn
            // 
            this.tchk_RandSpellLearn.AutoSize = true;
            this.tchk_RandSpellLearn.Location = new System.Drawing.Point(173, 7);
            this.tchk_RandSpellLearn.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_RandSpellLearn.Name = "tchk_RandSpellLearn";
            this.tchk_RandSpellLearn.Size = new System.Drawing.Size(149, 17);
            this.tchk_RandSpellLearn.TabIndex = 608;
            this.tchk_RandSpellLearn.Text = "Randomize Spell Learning";
            this.tchk_RandSpellLearn.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandSpellLearn, "Randomizes the class and level spells are learned. Field and battle spells are le" +
        "arned separately.");
            this.tchk_RandSpellLearn.UseVisualStyleBackColor = true;
            this.tchk_RandSpellLearn.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_DispEqPower
            // 
            this.tchk_DispEqPower.AutoSize = true;
            this.tchk_DispEqPower.Location = new System.Drawing.Point(7, 151);
            this.tchk_DispEqPower.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_DispEqPower.Name = "tchk_DispEqPower";
            this.tchk_DispEqPower.Size = new System.Drawing.Size(146, 17);
            this.tchk_DispEqPower.TabIndex = 607;
            this.tchk_DispEqPower.Text = "Display Equipment Power";
            this.tchk_DispEqPower.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_DispEqPower, "Display equipment power as part of equipment name.");
            this.tchk_DispEqPower.UseVisualStyleBackColor = true;
            this.tchk_DispEqPower.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_Cod
            // 
            this.tchk_Cod.AutoSize = true;
            this.tchk_Cod.Location = new System.Drawing.Point(7, 127);
            this.tchk_Cod.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_Cod.Name = "tchk_Cod";
            this.tchk_Cod.Size = new System.Drawing.Size(147, 17);
            this.tchk_Cod.TabIndex = 606;
            this.tchk_Cod.Text = "Cold as a Cod Adjustment";
            this.tchk_Cod.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_Cod, "All party members are brought back to life when party is wiped.");
            this.tchk_Cod.UseVisualStyleBackColor = true;
            this.tchk_Cod.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandStartGold
            // 
            this.tchk_RandStartGold.AutoSize = true;
            this.tchk_RandStartGold.Location = new System.Drawing.Point(7, 103);
            this.tchk_RandStartGold.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_RandStartGold.Name = "tchk_RandStartGold";
            this.tchk_RandStartGold.Size = new System.Drawing.Size(143, 17);
            this.tchk_RandStartGold.TabIndex = 605;
            this.tchk_RandStartGold.Text = "Randomize Starting Gold";
            this.tchk_RandStartGold.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandStartGold, "Randomizes gold given by king between 1 and 256.");
            this.tchk_RandStartGold.UseVisualStyleBackColor = true;
            this.tchk_RandStartGold.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmManips
            // 
            this.tchk_RmManips.AutoSize = true;
            this.tchk_RmManips.Location = new System.Drawing.Point(7, 79);
            this.tchk_RmManips.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_RmManips.Name = "tchk_RmManips";
            this.tchk_RmManips.Size = new System.Drawing.Size(134, 17);
            this.tchk_RmManips.TabIndex = 604;
            this.tchk_RmManips.Text = "Remove Manipulations";
            this.tchk_RmManips.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmManips, "Changes game\'s random number generation to remove known manipulations.");
            this.tchk_RmManips.UseVisualStyleBackColor = true;
            this.tchk_RmManips.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_SpeedUpMenus
            // 
            this.tchk_SpeedUpMenus.AutoSize = true;
            this.tchk_SpeedUpMenus.Location = new System.Drawing.Point(7, 55);
            this.tchk_SpeedUpMenus.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_SpeedUpMenus.Name = "tchk_SpeedUpMenus";
            this.tchk_SpeedUpMenus.Size = new System.Drawing.Size(109, 17);
            this.tchk_SpeedUpMenus.TabIndex = 603;
            this.tchk_SpeedUpMenus.Text = "Speed Up Menus";
            this.tchk_SpeedUpMenus.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_SpeedUpMenus, "Speeds up how quickly menus change.");
            this.tchk_SpeedUpMenus.UseVisualStyleBackColor = true;
            this.tchk_SpeedUpMenus.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_SpeedUpText
            // 
            this.tchk_SpeedUpText.AutoSize = true;
            this.tchk_SpeedUpText.Location = new System.Drawing.Point(7, 31);
            this.tchk_SpeedUpText.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_SpeedUpText.Name = "tchk_SpeedUpText";
            this.tchk_SpeedUpText.Size = new System.Drawing.Size(98, 17);
            this.tchk_SpeedUpText.TabIndex = 602;
            this.tchk_SpeedUpText.Text = "Speed Up Text";
            this.tchk_SpeedUpText.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_SpeedUpText, "Speeds up how quickly text is displayed.");
            this.tchk_SpeedUpText.UseVisualStyleBackColor = true;
            this.tchk_SpeedUpText.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_IncBatSpeed
            // 
            this.tchk_IncBatSpeed.AutoSize = true;
            this.tchk_IncBatSpeed.Location = new System.Drawing.Point(7, 7);
            this.tchk_IncBatSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_IncBatSpeed.Name = "tchk_IncBatSpeed";
            this.tchk_IncBatSpeed.Size = new System.Drawing.Size(137, 17);
            this.tchk_IncBatSpeed.TabIndex = 601;
            this.tchk_IncBatSpeed.Text = "Increased Battle Speed";
            this.tchk_IncBatSpeed.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_IncBatSpeed, "Removes frames of animation to speed up battles.");
            this.tchk_IncBatSpeed.UseVisualStyleBackColor = true;
            this.tchk_IncBatSpeed.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandStats
            // 
            this.grp_RandStats.Controls.Add(this.rad_RandStatsRand);
            this.grp_RandStats.Controls.Add(this.rad_RandStatsLud);
            this.grp_RandStats.Controls.Add(this.rad_RandStatsRid);
            this.grp_RandStats.Controls.Add(this.rad_RandStatsSilly);
            this.grp_RandStats.Controls.Add(this.rad_RandStatsOff);
            this.grp_RandStats.Location = new System.Drawing.Point(5, 320);
            this.grp_RandStats.Name = "grp_RandStats";
            this.grp_RandStats.Size = new System.Drawing.Size(332, 41);
            this.grp_RandStats.TabIndex = 73;
            this.grp_RandStats.TabStop = false;
            this.grp_RandStats.Text = "Randomize Party Stats and Growth";
            this.adjustments.SetToolTip(this.grp_RandStats, "Randomizes which stats grow faster for classes and the rate that they grow.");
            // 
            // rad_RandStatsRand
            // 
            this.rad_RandStatsRand.AutoSize = true;
            this.rad_RandStatsRand.Location = new System.Drawing.Point(257, 19);
            this.rad_RandStatsRand.Name = "rad_RandStatsRand";
            this.rad_RandStatsRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandStatsRand.TabIndex = 4;
            this.rad_RandStatsRand.Text = "Random";
            this.rad_RandStatsRand.UseVisualStyleBackColor = true;
            this.rad_RandStatsRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandStatsLud
            // 
            this.rad_RandStatsLud.AutoSize = true;
            this.rad_RandStatsLud.Location = new System.Drawing.Point(180, 19);
            this.rad_RandStatsLud.Name = "rad_RandStatsLud";
            this.rad_RandStatsLud.Size = new System.Drawing.Size(71, 17);
            this.rad_RandStatsLud.TabIndex = 3;
            this.rad_RandStatsLud.Text = "Ludicrous";
            this.rad_RandStatsLud.UseVisualStyleBackColor = true;
            this.rad_RandStatsLud.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandStatsRid
            // 
            this.rad_RandStatsRid.AutoSize = true;
            this.rad_RandStatsRid.Location = new System.Drawing.Point(100, 19);
            this.rad_RandStatsRid.Name = "rad_RandStatsRid";
            this.rad_RandStatsRid.Size = new System.Drawing.Size(74, 17);
            this.rad_RandStatsRid.TabIndex = 2;
            this.rad_RandStatsRid.Text = "Ridiculous";
            this.rad_RandStatsRid.UseVisualStyleBackColor = true;
            this.rad_RandStatsRid.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandStatsSilly
            // 
            this.rad_RandStatsSilly.AutoSize = true;
            this.rad_RandStatsSilly.Location = new System.Drawing.Point(51, 19);
            this.rad_RandStatsSilly.Name = "rad_RandStatsSilly";
            this.rad_RandStatsSilly.Size = new System.Drawing.Size(43, 17);
            this.rad_RandStatsSilly.TabIndex = 1;
            this.rad_RandStatsSilly.Text = "Silly";
            this.rad_RandStatsSilly.UseVisualStyleBackColor = true;
            this.rad_RandStatsSilly.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandStatsOff
            // 
            this.rad_RandStatsOff.AutoSize = true;
            this.rad_RandStatsOff.Checked = true;
            this.rad_RandStatsOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandStatsOff.Name = "rad_RandStatsOff";
            this.rad_RandStatsOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandStatsOff.TabIndex = 0;
            this.rad_RandStatsOff.TabStop = true;
            this.rad_RandStatsOff.Text = "Off";
            this.rad_RandStatsOff.UseVisualStyleBackColor = true;
            this.rad_RandStatsOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_EncRate
            // 
            this.grp_EncRate.Controls.Add(this.rad_EncRateRand);
            this.grp_EncRate.Controls.Add(this.rad_EncRate400);
            this.grp_EncRate.Controls.Add(this.rad_EncRate300);
            this.grp_EncRate.Controls.Add(this.rad_EncRate200);
            this.grp_EncRate.Controls.Add(this.rad_EncRate150);
            this.grp_EncRate.Controls.Add(this.rad_EncRate100);
            this.grp_EncRate.Controls.Add(this.rad_EncRate75);
            this.grp_EncRate.Controls.Add(this.rad_EncRate50);
            this.grp_EncRate.Controls.Add(this.rad_EncRate25);
            this.grp_EncRate.Controls.Add(this.rad_EncRate0);
            this.grp_EncRate.Location = new System.Drawing.Point(5, 175);
            this.grp_EncRate.Margin = new System.Windows.Forms.Padding(2);
            this.grp_EncRate.Name = "grp_EncRate";
            this.grp_EncRate.Padding = new System.Windows.Forms.Padding(2);
            this.grp_EncRate.Size = new System.Drawing.Size(670, 41);
            this.grp_EncRate.TabIndex = 52;
            this.grp_EncRate.TabStop = false;
            this.grp_EncRate.Text = "Encounter Rate";
            this.adjustments.SetToolTip(this.grp_EncRate, "Changes the encounter rate for random battles");
            // 
            // rad_EncRateRand
            // 
            this.rad_EncRateRand.AutoSize = true;
            this.rad_EncRateRand.Location = new System.Drawing.Point(471, 19);
            this.rad_EncRateRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRateRand.Name = "rad_EncRateRand";
            this.rad_EncRateRand.Size = new System.Drawing.Size(65, 17);
            this.rad_EncRateRand.TabIndex = 9;
            this.rad_EncRateRand.Text = "Random";
            this.rad_EncRateRand.UseVisualStyleBackColor = true;
            this.rad_EncRateRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate400
            // 
            this.rad_EncRate400.AutoSize = true;
            this.rad_EncRate400.Location = new System.Drawing.Point(416, 19);
            this.rad_EncRate400.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate400.Name = "rad_EncRate400";
            this.rad_EncRate400.Size = new System.Drawing.Size(51, 17);
            this.rad_EncRate400.TabIndex = 8;
            this.rad_EncRate400.Text = "400%";
            this.rad_EncRate400.UseVisualStyleBackColor = true;
            this.rad_EncRate400.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate300
            // 
            this.rad_EncRate300.AutoSize = true;
            this.rad_EncRate300.Location = new System.Drawing.Point(361, 19);
            this.rad_EncRate300.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate300.Name = "rad_EncRate300";
            this.rad_EncRate300.Size = new System.Drawing.Size(51, 17);
            this.rad_EncRate300.TabIndex = 7;
            this.rad_EncRate300.Text = "300%";
            this.rad_EncRate300.UseVisualStyleBackColor = true;
            this.rad_EncRate300.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate200
            // 
            this.rad_EncRate200.AutoSize = true;
            this.rad_EncRate200.Location = new System.Drawing.Point(306, 19);
            this.rad_EncRate200.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate200.Name = "rad_EncRate200";
            this.rad_EncRate200.Size = new System.Drawing.Size(51, 17);
            this.rad_EncRate200.TabIndex = 6;
            this.rad_EncRate200.Text = "200%";
            this.rad_EncRate200.UseVisualStyleBackColor = true;
            this.rad_EncRate200.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate150
            // 
            this.rad_EncRate150.AutoSize = true;
            this.rad_EncRate150.Location = new System.Drawing.Point(251, 19);
            this.rad_EncRate150.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate150.Name = "rad_EncRate150";
            this.rad_EncRate150.Size = new System.Drawing.Size(51, 17);
            this.rad_EncRate150.TabIndex = 5;
            this.rad_EncRate150.Text = "150%";
            this.rad_EncRate150.UseVisualStyleBackColor = true;
            this.rad_EncRate150.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate100
            // 
            this.rad_EncRate100.AutoSize = true;
            this.rad_EncRate100.Checked = true;
            this.rad_EncRate100.Location = new System.Drawing.Point(196, 19);
            this.rad_EncRate100.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate100.Name = "rad_EncRate100";
            this.rad_EncRate100.Size = new System.Drawing.Size(51, 17);
            this.rad_EncRate100.TabIndex = 4;
            this.rad_EncRate100.TabStop = true;
            this.rad_EncRate100.Text = "100%";
            this.rad_EncRate100.UseVisualStyleBackColor = true;
            this.rad_EncRate100.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate75
            // 
            this.rad_EncRate75.AutoSize = true;
            this.rad_EncRate75.Location = new System.Drawing.Point(147, 19);
            this.rad_EncRate75.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate75.Name = "rad_EncRate75";
            this.rad_EncRate75.Size = new System.Drawing.Size(45, 17);
            this.rad_EncRate75.TabIndex = 3;
            this.rad_EncRate75.Text = "75%";
            this.rad_EncRate75.UseVisualStyleBackColor = true;
            this.rad_EncRate75.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate50
            // 
            this.rad_EncRate50.AutoSize = true;
            this.rad_EncRate50.Location = new System.Drawing.Point(98, 19);
            this.rad_EncRate50.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate50.Name = "rad_EncRate50";
            this.rad_EncRate50.Size = new System.Drawing.Size(45, 17);
            this.rad_EncRate50.TabIndex = 2;
            this.rad_EncRate50.Text = "50%";
            this.rad_EncRate50.UseVisualStyleBackColor = true;
            this.rad_EncRate50.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate25
            // 
            this.rad_EncRate25.AutoSize = true;
            this.rad_EncRate25.Location = new System.Drawing.Point(49, 19);
            this.rad_EncRate25.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate25.Name = "rad_EncRate25";
            this.rad_EncRate25.Size = new System.Drawing.Size(45, 17);
            this.rad_EncRate25.TabIndex = 1;
            this.rad_EncRate25.Text = "25%";
            this.rad_EncRate25.UseVisualStyleBackColor = true;
            this.rad_EncRate25.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate0
            // 
            this.rad_EncRate0.AutoSize = true;
            this.rad_EncRate0.Location = new System.Drawing.Point(6, 19);
            this.rad_EncRate0.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EncRate0.Name = "rad_EncRate0";
            this.rad_EncRate0.Size = new System.Drawing.Size(39, 17);
            this.rad_EncRate0.TabIndex = 0;
            this.rad_EncRate0.Text = "0%";
            this.rad_EncRate0.UseVisualStyleBackColor = true;
            this.rad_EncRate0.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_GoldGain
            // 
            this.grp_GoldGain.Controls.Add(this.rad_GoldGain150);
            this.grp_GoldGain.Controls.Add(this.rad_GoldGainRand);
            this.grp_GoldGain.Controls.Add(this.rad_GoldGain200);
            this.grp_GoldGain.Controls.Add(this.rad_GoldGain100);
            this.grp_GoldGain.Controls.Add(this.rad_GoldGain50);
            this.grp_GoldGain.Controls.Add(this.rad_GoldGain1);
            this.grp_GoldGain.Location = new System.Drawing.Point(5, 271);
            this.grp_GoldGain.Margin = new System.Windows.Forms.Padding(2);
            this.grp_GoldGain.Name = "grp_GoldGain";
            this.grp_GoldGain.Padding = new System.Windows.Forms.Padding(2);
            this.grp_GoldGain.Size = new System.Drawing.Size(670, 41);
            this.grp_GoldGain.TabIndex = 51;
            this.grp_GoldGain.TabStop = false;
            this.grp_GoldGain.Text = "Gold Gains";
            this.adjustments.SetToolTip(this.grp_GoldGain, "Changes the amount of gold earned when defeating monsters");
            // 
            // rad_GoldGain150
            // 
            this.rad_GoldGain150.AutoSize = true;
            this.rad_GoldGain150.Location = new System.Drawing.Point(254, 19);
            this.rad_GoldGain150.Margin = new System.Windows.Forms.Padding(2);
            this.rad_GoldGain150.Name = "rad_GoldGain150";
            this.rad_GoldGain150.Size = new System.Drawing.Size(51, 17);
            this.rad_GoldGain150.TabIndex = 3;
            this.rad_GoldGain150.TabStop = true;
            this.rad_GoldGain150.Text = "150%";
            this.rad_GoldGain150.UseVisualStyleBackColor = true;
            this.rad_GoldGain150.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGainRand
            // 
            this.rad_GoldGainRand.AutoSize = true;
            this.rad_GoldGainRand.Location = new System.Drawing.Point(364, 19);
            this.rad_GoldGainRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_GoldGainRand.Name = "rad_GoldGainRand";
            this.rad_GoldGainRand.Size = new System.Drawing.Size(65, 17);
            this.rad_GoldGainRand.TabIndex = 5;
            this.rad_GoldGainRand.Text = "Random";
            this.rad_GoldGainRand.UseVisualStyleBackColor = true;
            this.rad_GoldGainRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGain200
            // 
            this.rad_GoldGain200.AutoSize = true;
            this.rad_GoldGain200.Location = new System.Drawing.Point(309, 19);
            this.rad_GoldGain200.Margin = new System.Windows.Forms.Padding(2);
            this.rad_GoldGain200.Name = "rad_GoldGain200";
            this.rad_GoldGain200.Size = new System.Drawing.Size(51, 17);
            this.rad_GoldGain200.TabIndex = 4;
            this.rad_GoldGain200.Text = "200%";
            this.rad_GoldGain200.UseVisualStyleBackColor = true;
            this.rad_GoldGain200.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGain100
            // 
            this.rad_GoldGain100.AutoSize = true;
            this.rad_GoldGain100.Checked = true;
            this.rad_GoldGain100.Location = new System.Drawing.Point(199, 19);
            this.rad_GoldGain100.Margin = new System.Windows.Forms.Padding(2);
            this.rad_GoldGain100.Name = "rad_GoldGain100";
            this.rad_GoldGain100.Size = new System.Drawing.Size(51, 17);
            this.rad_GoldGain100.TabIndex = 2;
            this.rad_GoldGain100.TabStop = true;
            this.rad_GoldGain100.Text = "100%";
            this.rad_GoldGain100.UseVisualStyleBackColor = true;
            this.rad_GoldGain100.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGain50
            // 
            this.rad_GoldGain50.AutoSize = true;
            this.rad_GoldGain50.Location = new System.Drawing.Point(150, 19);
            this.rad_GoldGain50.Margin = new System.Windows.Forms.Padding(2);
            this.rad_GoldGain50.Name = "rad_GoldGain50";
            this.rad_GoldGain50.Size = new System.Drawing.Size(45, 17);
            this.rad_GoldGain50.TabIndex = 1;
            this.rad_GoldGain50.Text = "50%";
            this.rad_GoldGain50.UseVisualStyleBackColor = true;
            this.rad_GoldGain50.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGain1
            // 
            this.rad_GoldGain1.AutoSize = true;
            this.rad_GoldGain1.Location = new System.Drawing.Point(6, 19);
            this.rad_GoldGain1.Margin = new System.Windows.Forms.Padding(2);
            this.rad_GoldGain1.Name = "rad_GoldGain1";
            this.rad_GoldGain1.Size = new System.Drawing.Size(140, 17);
            this.rad_GoldGain1.TabIndex = 0;
            this.rad_GoldGain1.Text = "1 G per Monster + Battle";
            this.rad_GoldGain1.UseVisualStyleBackColor = true;
            this.rad_GoldGain1.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_ExpGain
            // 
            this.grp_ExpGain.Controls.Add(this.rad_ExpGainRand);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain1000);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain750);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain500);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain400);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain300);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain200);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain150);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain100);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain50);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain25);
            this.grp_ExpGain.Controls.Add(this.rad_ExpGain0);
            this.grp_ExpGain.Location = new System.Drawing.Point(5, 223);
            this.grp_ExpGain.Margin = new System.Windows.Forms.Padding(2);
            this.grp_ExpGain.Name = "grp_ExpGain";
            this.grp_ExpGain.Padding = new System.Windows.Forms.Padding(2);
            this.grp_ExpGain.Size = new System.Drawing.Size(670, 41);
            this.grp_ExpGain.TabIndex = 50;
            this.grp_ExpGain.TabStop = false;
            this.grp_ExpGain.Text = "Experience Gains";
            this.adjustments.SetToolTip(this.grp_ExpGain, "Changes the amount of experience earned when defeating monsters");
            // 
            // rad_ExpGainRand
            // 
            this.rad_ExpGainRand.AutoSize = true;
            this.rad_ExpGainRand.Location = new System.Drawing.Point(593, 19);
            this.rad_ExpGainRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGainRand.Name = "rad_ExpGainRand";
            this.rad_ExpGainRand.Size = new System.Drawing.Size(65, 17);
            this.rad_ExpGainRand.TabIndex = 11;
            this.rad_ExpGainRand.Text = "Random";
            this.rad_ExpGainRand.UseVisualStyleBackColor = true;
            this.rad_ExpGainRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain1000
            // 
            this.rad_ExpGain1000.AutoSize = true;
            this.rad_ExpGain1000.Location = new System.Drawing.Point(532, 19);
            this.rad_ExpGain1000.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain1000.Name = "rad_ExpGain1000";
            this.rad_ExpGain1000.Size = new System.Drawing.Size(57, 17);
            this.rad_ExpGain1000.TabIndex = 10;
            this.rad_ExpGain1000.Text = "1000%";
            this.rad_ExpGain1000.UseVisualStyleBackColor = true;
            this.rad_ExpGain1000.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain750
            // 
            this.rad_ExpGain750.AutoSize = true;
            this.rad_ExpGain750.Location = new System.Drawing.Point(477, 19);
            this.rad_ExpGain750.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain750.Name = "rad_ExpGain750";
            this.rad_ExpGain750.Size = new System.Drawing.Size(51, 17);
            this.rad_ExpGain750.TabIndex = 9;
            this.rad_ExpGain750.Text = "750%";
            this.rad_ExpGain750.UseVisualStyleBackColor = true;
            this.rad_ExpGain750.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain500
            // 
            this.rad_ExpGain500.AutoSize = true;
            this.rad_ExpGain500.Location = new System.Drawing.Point(422, 19);
            this.rad_ExpGain500.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain500.Name = "rad_ExpGain500";
            this.rad_ExpGain500.Size = new System.Drawing.Size(51, 17);
            this.rad_ExpGain500.TabIndex = 8;
            this.rad_ExpGain500.Text = "500%";
            this.rad_ExpGain500.UseVisualStyleBackColor = true;
            this.rad_ExpGain500.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain400
            // 
            this.rad_ExpGain400.AutoSize = true;
            this.rad_ExpGain400.Location = new System.Drawing.Point(367, 19);
            this.rad_ExpGain400.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain400.Name = "rad_ExpGain400";
            this.rad_ExpGain400.Size = new System.Drawing.Size(51, 17);
            this.rad_ExpGain400.TabIndex = 7;
            this.rad_ExpGain400.Text = "400%";
            this.rad_ExpGain400.UseVisualStyleBackColor = true;
            this.rad_ExpGain400.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain300
            // 
            this.rad_ExpGain300.AutoSize = true;
            this.rad_ExpGain300.Location = new System.Drawing.Point(312, 19);
            this.rad_ExpGain300.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain300.Name = "rad_ExpGain300";
            this.rad_ExpGain300.Size = new System.Drawing.Size(51, 17);
            this.rad_ExpGain300.TabIndex = 6;
            this.rad_ExpGain300.Text = "300%";
            this.rad_ExpGain300.UseVisualStyleBackColor = true;
            this.rad_ExpGain300.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain200
            // 
            this.rad_ExpGain200.AutoSize = true;
            this.rad_ExpGain200.Location = new System.Drawing.Point(257, 19);
            this.rad_ExpGain200.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain200.Name = "rad_ExpGain200";
            this.rad_ExpGain200.Size = new System.Drawing.Size(51, 17);
            this.rad_ExpGain200.TabIndex = 5;
            this.rad_ExpGain200.Text = "200%";
            this.rad_ExpGain200.UseVisualStyleBackColor = true;
            this.rad_ExpGain200.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain150
            // 
            this.rad_ExpGain150.AutoSize = true;
            this.rad_ExpGain150.Location = new System.Drawing.Point(202, 19);
            this.rad_ExpGain150.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain150.Name = "rad_ExpGain150";
            this.rad_ExpGain150.Size = new System.Drawing.Size(51, 17);
            this.rad_ExpGain150.TabIndex = 4;
            this.rad_ExpGain150.Text = "150%";
            this.rad_ExpGain150.UseVisualStyleBackColor = true;
            this.rad_ExpGain150.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain100
            // 
            this.rad_ExpGain100.AutoSize = true;
            this.rad_ExpGain100.Checked = true;
            this.rad_ExpGain100.Location = new System.Drawing.Point(147, 19);
            this.rad_ExpGain100.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain100.Name = "rad_ExpGain100";
            this.rad_ExpGain100.Size = new System.Drawing.Size(51, 17);
            this.rad_ExpGain100.TabIndex = 3;
            this.rad_ExpGain100.TabStop = true;
            this.rad_ExpGain100.Text = "100%";
            this.rad_ExpGain100.UseVisualStyleBackColor = true;
            this.rad_ExpGain100.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain50
            // 
            this.rad_ExpGain50.AutoSize = true;
            this.rad_ExpGain50.Location = new System.Drawing.Point(98, 19);
            this.rad_ExpGain50.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain50.Name = "rad_ExpGain50";
            this.rad_ExpGain50.Size = new System.Drawing.Size(45, 17);
            this.rad_ExpGain50.TabIndex = 2;
            this.rad_ExpGain50.Text = "50%";
            this.rad_ExpGain50.UseVisualStyleBackColor = true;
            this.rad_ExpGain50.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain25
            // 
            this.rad_ExpGain25.AutoSize = true;
            this.rad_ExpGain25.Location = new System.Drawing.Point(49, 19);
            this.rad_ExpGain25.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain25.Name = "rad_ExpGain25";
            this.rad_ExpGain25.Size = new System.Drawing.Size(45, 17);
            this.rad_ExpGain25.TabIndex = 1;
            this.rad_ExpGain25.Text = "25%";
            this.rad_ExpGain25.UseVisualStyleBackColor = true;
            this.rad_ExpGain25.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain0
            // 
            this.rad_ExpGain0.AutoSize = true;
            this.rad_ExpGain0.Location = new System.Drawing.Point(6, 19);
            this.rad_ExpGain0.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ExpGain0.Name = "rad_ExpGain0";
            this.rad_ExpGain0.Size = new System.Drawing.Size(39, 17);
            this.rad_ExpGain0.TabIndex = 0;
            this.rad_ExpGain0.Text = "0%";
            this.rad_ExpGain0.UseVisualStyleBackColor = true;
            this.rad_ExpGain0.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tchk_RmNoEncounter);
            this.tabPage8.Controls.Add(this.tchk_NoNewTown);
            this.tabPage8.Controls.Add(this.tchk_RmMoatCharlock);
            this.tabPage8.Controls.Add(this.tchk_RmMountDQC);
            this.tabPage8.Controls.Add(this.tchk_RmMountBaramos);
            this.tabPage8.Controls.Add(this.tchk_RmMountNecro);
            this.tabPage8.Controls.Add(this.tchk_RmMountLancel);
            this.tabPage8.Controls.Add(this.tchk_RandShrines);
            this.tabPage8.Controls.Add(this.tchk_RandCaveTower);
            this.tabPage8.Controls.Add(this.tchk_RandTowns);
            this.tabPage8.Controls.Add(this.tchk_RandMonstZones);
            this.tabPage8.Controls.Add(this.tchk_SmallMaps);
            this.tabPage8.Controls.Add(this.tchk_RandMaps);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(678, 422);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Map";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tchk_RmNoEncounter
            // 
            this.tchk_RmNoEncounter.AutoSize = true;
            this.tchk_RmNoEncounter.Location = new System.Drawing.Point(461, 7);
            this.tchk_RmNoEncounter.Name = "tchk_RmNoEncounter";
            this.tchk_RmNoEncounter.Size = new System.Drawing.Size(158, 17);
            this.tchk_RmNoEncounter.TabIndex = 107;
            this.tchk_RmNoEncounter.Text = "Disable No Encounter State";
            this.tchk_RmNoEncounter.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmNoEncounter, "Separates Baramos Castle and Pit to disable no encounter glitch");
            this.tchk_RmNoEncounter.UseVisualStyleBackColor = true;
            this.tchk_RmNoEncounter.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_NoNewTown
            // 
            this.tchk_NoNewTown.AutoSize = true;
            this.tchk_NoNewTown.Location = new System.Drawing.Point(189, 127);
            this.tchk_NoNewTown.Name = "tchk_NoNewTown";
            this.tchk_NoNewTown.Size = new System.Drawing.Size(162, 17);
            this.tchk_NoNewTown.TabIndex = 106;
            this.tchk_NoNewTown.Text = "Do Not Generate New Town";
            this.tchk_NoNewTown.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_NoNewTown, "Removes New Town from being generated on the overworld map");
            this.tchk_NoNewTown.UseVisualStyleBackColor = true;
            this.tchk_NoNewTown.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmMoatCharlock
            // 
            this.tchk_RmMoatCharlock.AutoSize = true;
            this.tchk_RmMoatCharlock.Location = new System.Drawing.Point(189, 103);
            this.tchk_RmMoatCharlock.Name = "tchk_RmMoatCharlock";
            this.tchk_RmMoatCharlock.Size = new System.Drawing.Size(189, 17);
            this.tchk_RmMoatCharlock.TabIndex = 105;
            this.tchk_RmMoatCharlock.Text = "Fill Moat in around Charlock Castle";
            this.tchk_RmMoatCharlock.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmMoatCharlock, "Fills in water around Charlock Castle with land");
            this.tchk_RmMoatCharlock.UseVisualStyleBackColor = true;
            this.tchk_RmMoatCharlock.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmMountDQC
            // 
            this.tchk_RmMountDQC.AutoSize = true;
            this.tchk_RmMountDQC.Location = new System.Drawing.Point(189, 79);
            this.tchk_RmMountDQC.Name = "tchk_RmMountDQC";
            this.tchk_RmMountDQC.Size = new System.Drawing.Size(259, 17);
            this.tchk_RmMountDQC.TabIndex = 104;
            this.tchk_RmMountDQC.Text = "Remove Mountains around Dragon Queen Castle";
            this.tchk_RmMountDQC.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmMountDQC, "Removes mountains around Dragon Queen\'s Castle");
            this.tchk_RmMountDQC.UseVisualStyleBackColor = true;
            this.tchk_RmMountDQC.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmMountBaramos
            // 
            this.tchk_RmMountBaramos.AutoSize = true;
            this.tchk_RmMountBaramos.Location = new System.Drawing.Point(189, 55);
            this.tchk_RmMountBaramos.Name = "tchk_RmMountBaramos";
            this.tchk_RmMountBaramos.Size = new System.Drawing.Size(232, 17);
            this.tchk_RmMountBaramos.TabIndex = 103;
            this.tchk_RmMountBaramos.Text = "Remove Mountains around Baramos\' Castle";
            this.tchk_RmMountBaramos.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmMountBaramos, "Removes mountains around Baramos\' Castle");
            this.tchk_RmMountBaramos.UseVisualStyleBackColor = true;
            this.tchk_RmMountBaramos.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmMountNecro
            // 
            this.tchk_RmMountNecro.AutoSize = true;
            this.tchk_RmMountNecro.Location = new System.Drawing.Point(189, 31);
            this.tchk_RmMountNecro.Name = "tchk_RmMountNecro";
            this.tchk_RmMountNecro.Size = new System.Drawing.Size(250, 17);
            this.tchk_RmMountNecro.TabIndex = 102;
            this.tchk_RmMountNecro.Text = "Remove Mountains around Cave of Necrogond";
            this.tchk_RmMountNecro.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmMountNecro, "Removes mountains around Cave of Necrogond");
            this.tchk_RmMountNecro.UseVisualStyleBackColor = true;
            this.tchk_RmMountNecro.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmMountLancel
            // 
            this.tchk_RmMountLancel.AutoSize = true;
            this.tchk_RmMountLancel.Location = new System.Drawing.Point(189, 7);
            this.tchk_RmMountLancel.Name = "tchk_RmMountLancel";
            this.tchk_RmMountLancel.Size = new System.Drawing.Size(217, 17);
            this.tchk_RmMountLancel.TabIndex = 101;
            this.tchk_RmMountLancel.Text = "Remove Mountains around Lancel Cave";
            this.tchk_RmMountLancel.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmMountLancel, "Removes mountains around Lancel Cave");
            this.tchk_RmMountLancel.UseVisualStyleBackColor = true;
            this.tchk_RmMountLancel.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandShrines
            // 
            this.tchk_RandShrines.AutoSize = true;
            this.tchk_RandShrines.Location = new System.Drawing.Point(7, 127);
            this.tchk_RandShrines.Name = "tchk_RandShrines";
            this.tchk_RandShrines.Size = new System.Drawing.Size(117, 17);
            this.tchk_RandShrines.TabIndex = 100;
            this.tchk_RandShrines.Text = "Randomize Shrines";
            this.tchk_RandShrines.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandShrines, "Randomizes continents that shrines are found on");
            this.tchk_RandShrines.UseVisualStyleBackColor = true;
            this.tchk_RandShrines.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandCaveTower
            // 
            this.tchk_RandCaveTower.AutoSize = true;
            this.tchk_RandCaveTower.Location = new System.Drawing.Point(7, 103);
            this.tchk_RandCaveTower.Name = "tchk_RandCaveTower";
            this.tchk_RandCaveTower.Size = new System.Drawing.Size(171, 17);
            this.tchk_RandCaveTower.TabIndex = 99;
            this.tchk_RandCaveTower.Text = "Randomize Caves and Towers";
            this.tchk_RandCaveTower.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandCaveTower, "Randomizes continents that caves and towers are found on");
            this.tchk_RandCaveTower.UseVisualStyleBackColor = true;
            this.tchk_RandCaveTower.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandTowns
            // 
            this.tchk_RandTowns.AutoSize = true;
            this.tchk_RandTowns.Location = new System.Drawing.Point(7, 79);
            this.tchk_RandTowns.Name = "tchk_RandTowns";
            this.tchk_RandTowns.Size = new System.Drawing.Size(114, 17);
            this.tchk_RandTowns.TabIndex = 98;
            this.tchk_RandTowns.Text = "Randomize Towns";
            this.tchk_RandTowns.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandTowns, "Randomizes continents that towns are found on");
            this.tchk_RandTowns.UseVisualStyleBackColor = true;
            this.tchk_RandTowns.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandMonstZones
            // 
            this.tchk_RandMonstZones.AutoSize = true;
            this.tchk_RandMonstZones.Location = new System.Drawing.Point(7, 55);
            this.tchk_RandMonstZones.Name = "tchk_RandMonstZones";
            this.tchk_RandMonstZones.Size = new System.Drawing.Size(153, 17);
            this.tchk_RandMonstZones.TabIndex = 97;
            this.tchk_RandMonstZones.Text = "Randomize Monster Zones";
            this.tchk_RandMonstZones.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandMonstZones, "Randomizes zones that monsters are found in");
            this.tchk_RandMonstZones.UseVisualStyleBackColor = true;
            this.tchk_RandMonstZones.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_SmallMaps
            // 
            this.tchk_SmallMaps.AutoSize = true;
            this.tchk_SmallMaps.Location = new System.Drawing.Point(7, 31);
            this.tchk_SmallMaps.Name = "tchk_SmallMaps";
            this.tchk_SmallMaps.Size = new System.Drawing.Size(80, 17);
            this.tchk_SmallMaps.TabIndex = 96;
            this.tchk_SmallMaps.Text = "Small Maps";
            this.tchk_SmallMaps.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_SmallMaps, "Reduces the size of the light and dark world maps.");
            this.tchk_SmallMaps.UseVisualStyleBackColor = true;
            this.tchk_SmallMaps.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandMaps
            // 
            this.tchk_RandMaps.AutoSize = true;
            this.tchk_RandMaps.Location = new System.Drawing.Point(7, 7);
            this.tchk_RandMaps.Name = "tchk_RandMaps";
            this.tchk_RandMaps.Size = new System.Drawing.Size(108, 17);
            this.tchk_RandMaps.TabIndex = 95;
            this.tchk_RandMaps.Text = "Randomize Maps";
            this.tchk_RandMaps.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandMaps, "Randomize light and dark world maps");
            this.tchk_RandMaps.UseVisualStyleBackColor = true;
            this.tchk_RandMaps.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tchk_RmMetalRun);
            this.tabPage2.Controls.Add(this.tchk_RandEnAttPat);
            this.tabPage2.Controls.Add(this.tchk_RmDupItemPool);
            this.tabPage2.Controls.Add(this.tchk_RandDrops);
            this.tabPage2.Controls.Add(this.tchk_RandGold);
            this.tabPage2.Controls.Add(this.tchk_RandExp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(678, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monsters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tchk_RmMetalRun
            // 
            this.tchk_RmMetalRun.AutoSize = true;
            this.tchk_RmMetalRun.Location = new System.Drawing.Point(232, 31);
            this.tchk_RmMetalRun.Name = "tchk_RmMetalRun";
            this.tchk_RmMetalRun.Size = new System.Drawing.Size(210, 17);
            this.tchk_RmMetalRun.TabIndex = 121;
            this.tchk_RmMetalRun.Text = "Remove Metal Monster High Run Rate";
            this.tchk_RmMetalRun.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmMetalRun, "Removes high run rate from metal monsters");
            this.tchk_RmMetalRun.UseVisualStyleBackColor = true;
            this.tchk_RmMetalRun.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandEnAttPat
            // 
            this.tchk_RandEnAttPat.AutoSize = true;
            this.tchk_RandEnAttPat.Location = new System.Drawing.Point(232, 7);
            this.tchk_RandEnAttPat.Name = "tchk_RandEnAttPat";
            this.tchk_RandEnAttPat.Size = new System.Drawing.Size(190, 17);
            this.tchk_RandEnAttPat.TabIndex = 120;
            this.tchk_RandEnAttPat.Text = "Randomize Enemy Attack Patterns";
            this.tchk_RandEnAttPat.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandEnAttPat, "Randomizes the attacks and patterns that enemy monsters can use");
            this.tchk_RandEnAttPat.UseVisualStyleBackColor = true;
            this.tchk_RandEnAttPat.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmDupItemPool
            // 
            this.tchk_RmDupItemPool.AutoSize = true;
            this.tchk_RmDupItemPool.Location = new System.Drawing.Point(7, 79);
            this.tchk_RmDupItemPool.Name = "tchk_RmDupItemPool";
            this.tchk_RmDupItemPool.Size = new System.Drawing.Size(215, 17);
            this.tchk_RmDupItemPool.TabIndex = 119;
            this.tchk_RmDupItemPool.Text = "Remove Duplicate Items from Drop Pool";
            this.tchk_RmDupItemPool.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmDupItemPool, "Removes duplicate consumable items from drop table");
            this.tchk_RmDupItemPool.UseVisualStyleBackColor = true;
            this.tchk_RmDupItemPool.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandDrops
            // 
            this.tchk_RandDrops.AutoSize = true;
            this.tchk_RandDrops.Location = new System.Drawing.Point(7, 55);
            this.tchk_RandDrops.Name = "tchk_RandDrops";
            this.tchk_RandDrops.Size = new System.Drawing.Size(110, 17);
            this.tchk_RandDrops.TabIndex = 118;
            this.tchk_RandDrops.Text = "Randomize Drops";
            this.tchk_RandDrops.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandDrops, "Randomizes drops from monsters");
            this.tchk_RandDrops.UseVisualStyleBackColor = true;
            this.tchk_RandDrops.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandGold
            // 
            this.tchk_RandGold.AutoSize = true;
            this.tchk_RandGold.Location = new System.Drawing.Point(7, 31);
            this.tchk_RandGold.Name = "tchk_RandGold";
            this.tchk_RandGold.Size = new System.Drawing.Size(104, 17);
            this.tchk_RandGold.TabIndex = 117;
            this.tchk_RandGold.Text = "Randomize Gold";
            this.tchk_RandGold.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandGold, "Randomizes gold granted by monsters by + or - 25%");
            this.tchk_RandGold.UseVisualStyleBackColor = true;
            this.tchk_RandGold.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandExp
            // 
            this.tchk_RandExp.AutoSize = true;
            this.tchk_RandExp.Location = new System.Drawing.Point(7, 7);
            this.tchk_RandExp.Name = "tchk_RandExp";
            this.tchk_RandExp.Size = new System.Drawing.Size(135, 17);
            this.tchk_RandExp.TabIndex = 116;
            this.tchk_RandExp.Text = "Randomize Experience";
            this.tchk_RandExp.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandExp, "Randomizes experience granted by monsters by + or - 25%");
            this.tchk_RandExp.UseVisualStyleBackColor = true;
            this.tchk_RandExp.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tchk_RandItemEff);
            this.tabPage4.Controls.Add(this.tchk_RmRedKey);
            this.tabPage4.Controls.Add(this.tchk_GreenSilvOrb);
            this.tabPage4.Controls.Add(this.tchk_AddGoldClaw);
            this.tabPage4.Controls.Add(this.tchk_RandTreasures);
            this.tabPage4.Controls.Add(this.tchk_AdjEqPrices);
            this.tabPage4.Controls.Add(this.tchk_RandEqClass);
            this.tabPage4.Controls.Add(this.tchk_RmFigherPen);
            this.tabPage4.Controls.Add(this.tchk_RemStartCap);
            this.tabPage4.Controls.Add(this.tchk_VanEqVals);
            this.tabPage4.Controls.Add(this.tchk_RandEqPower);
            this.tabPage4.Controls.Add(this.tchk_AddRemakeEq);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(678, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Treasures & Equipment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tchk_RandItemEff
            // 
            this.tchk_RandItemEff.AutoSize = true;
            this.tchk_RandItemEff.Enabled = false;
            this.tchk_RandItemEff.Location = new System.Drawing.Point(490, 7);
            this.tchk_RandItemEff.Name = "tchk_RandItemEff";
            this.tchk_RandItemEff.Size = new System.Drawing.Size(138, 17);
            this.tchk_RandItemEff.TabIndex = 153;
            this.tchk_RandItemEff.Text = "Randomize Item Effects";
            this.tchk_RandItemEff.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandItemEff, "Randomizes the effect of items.");
            this.tchk_RandItemEff.UseVisualStyleBackColor = true;
            this.tchk_RandItemEff.Visible = false;
            this.tchk_RandItemEff.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmRedKey
            // 
            this.tchk_RmRedKey.AutoSize = true;
            this.tchk_RmRedKey.Location = new System.Drawing.Point(225, 78);
            this.tchk_RmRedKey.Name = "tchk_RmRedKey";
            this.tchk_RmRedKey.Size = new System.Drawing.Size(240, 17);
            this.tchk_RmRedKey.TabIndex = 152;
            this.tchk_RmRedKey.Text = "Remove Redundant Keys from Treasure Pool";
            this.tchk_RmRedKey.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmRedKey, "Removes lower tier keys from areas if a higher tier one is found there.");
            this.tchk_RmRedKey.UseVisualStyleBackColor = true;
            this.tchk_RmRedKey.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_GreenSilvOrb
            // 
            this.tchk_GreenSilvOrb.AutoSize = true;
            this.tchk_GreenSilvOrb.Location = new System.Drawing.Point(225, 54);
            this.tchk_GreenSilvOrb.Name = "tchk_GreenSilvOrb";
            this.tchk_GreenSilvOrb.Size = new System.Drawing.Size(247, 17);
            this.tchk_GreenSilvOrb.TabIndex = 151;
            this.tchk_GreenSilvOrb.Text = "Green and Silver Orb Locations can have Orbs";
            this.tchk_GreenSilvOrb.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_GreenSilvOrb, "Allows Green and Silver Orbs to be found in their default locations.");
            this.tchk_GreenSilvOrb.UseVisualStyleBackColor = true;
            this.tchk_GreenSilvOrb.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_AddGoldClaw
            // 
            this.tchk_AddGoldClaw.AutoSize = true;
            this.tchk_AddGoldClaw.Location = new System.Drawing.Point(225, 31);
            this.tchk_AddGoldClaw.Name = "tchk_AddGoldClaw";
            this.tchk_AddGoldClaw.Size = new System.Drawing.Size(189, 17);
            this.tchk_AddGoldClaw.TabIndex = 150;
            this.tchk_AddGoldClaw.Text = "Add Golden Claw to Treasure Pool";
            this.tchk_AddGoldClaw.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_AddGoldClaw, "Add the Golden Claw to the Treasure Pool (1 will be put in a random chest).");
            this.tchk_AddGoldClaw.UseVisualStyleBackColor = true;
            this.tchk_AddGoldClaw.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandTreasures
            // 
            this.tchk_RandTreasures.AutoSize = true;
            this.tchk_RandTreasures.Location = new System.Drawing.Point(225, 7);
            this.tchk_RandTreasures.Name = "tchk_RandTreasures";
            this.tchk_RandTreasures.Size = new System.Drawing.Size(129, 17);
            this.tchk_RandTreasures.TabIndex = 149;
            this.tchk_RandTreasures.Text = "Randomize Treasures";
            this.tchk_RandTreasures.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandTreasures, "Randomizes treasures found in chests and on the ground.");
            this.tchk_RandTreasures.UseVisualStyleBackColor = true;
            this.tchk_RandTreasures.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_AdjEqPrices
            // 
            this.tchk_AdjEqPrices.AutoSize = true;
            this.tchk_AdjEqPrices.Location = new System.Drawing.Point(7, 150);
            this.tchk_AdjEqPrices.Name = "tchk_AdjEqPrices";
            this.tchk_AdjEqPrices.Size = new System.Drawing.Size(140, 17);
            this.tchk_AdjEqPrices.TabIndex = 148;
            this.tchk_AdjEqPrices.Text = "Adjust Equipment Prices";
            this.tchk_AdjEqPrices.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_AdjEqPrices, "Adjusts equipment prices based on power.");
            this.tchk_AdjEqPrices.UseVisualStyleBackColor = true;
            this.tchk_AdjEqPrices.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandEqClass
            // 
            this.tchk_RandEqClass.AutoSize = true;
            this.tchk_RandEqClass.Location = new System.Drawing.Point(7, 126);
            this.tchk_RandEqClass.Name = "tchk_RandEqClass";
            this.tchk_RandEqClass.Size = new System.Drawing.Size(168, 17);
            this.tchk_RandEqClass.TabIndex = 147;
            this.tchk_RandEqClass.Text = "Randomize Equipping Classes";
            this.tchk_RandEqClass.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandEqClass, "Randomizes which classes can equip equipment.");
            this.tchk_RandEqClass.UseVisualStyleBackColor = true;
            this.tchk_RandEqClass.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RmFigherPen
            // 
            this.tchk_RmFigherPen.AutoSize = true;
            this.tchk_RmFigherPen.Location = new System.Drawing.Point(7, 102);
            this.tchk_RmFigherPen.Name = "tchk_RmFigherPen";
            this.tchk_RmFigherPen.Size = new System.Drawing.Size(189, 17);
            this.tchk_RmFigherPen.TabIndex = 146;
            this.tchk_RmFigherPen.Text = "Remove Fighter Equipping Penalty";
            this.tchk_RmFigherPen.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RmFigherPen, "Removes the penalty some equipment has for fighters.");
            this.tchk_RmFigherPen.UseVisualStyleBackColor = true;
            this.tchk_RmFigherPen.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RemStartCap
            // 
            this.tchk_RemStartCap.AutoSize = true;
            this.tchk_RemStartCap.Location = new System.Drawing.Point(7, 78);
            this.tchk_RemStartCap.Name = "tchk_RemStartCap";
            this.tchk_RemStartCap.Size = new System.Drawing.Size(208, 17);
            this.tchk_RemStartCap.TabIndex = 145;
            this.tchk_RemStartCap.Text = "Remove Caps from Starting Equipment";
            this.tchk_RemStartCap.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RemStartCap, "Starting equipment is not limited in power when randomized.");
            this.tchk_RemStartCap.UseVisualStyleBackColor = true;
            this.tchk_RemStartCap.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_VanEqVals
            // 
            this.tchk_VanEqVals.AutoSize = true;
            this.tchk_VanEqVals.Location = new System.Drawing.Point(7, 54);
            this.tchk_VanEqVals.Name = "tchk_VanEqVals";
            this.tchk_VanEqVals.Size = new System.Drawing.Size(167, 17);
            this.tchk_VanEqVals.TabIndex = 144;
            this.tchk_VanEqVals.Text = "Use Vanilla Equipment Values";
            this.tchk_VanEqVals.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_VanEqVals, "Uses values of actual equipment instead of a random number when randomizing power" +
        ".");
            this.tchk_VanEqVals.UseVisualStyleBackColor = true;
            this.tchk_VanEqVals.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandEqPower
            // 
            this.tchk_RandEqPower.AutoSize = true;
            this.tchk_RandEqPower.Location = new System.Drawing.Point(7, 31);
            this.tchk_RandEqPower.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_RandEqPower.Name = "tchk_RandEqPower";
            this.tchk_RandEqPower.Size = new System.Drawing.Size(165, 17);
            this.tchk_RandEqPower.TabIndex = 143;
            this.tchk_RandEqPower.Text = "Randomize Equipment Power";
            this.tchk_RandEqPower.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandEqPower, "Randomizes the power of weapons, armor, helmets, and shields.");
            this.tchk_RandEqPower.UseVisualStyleBackColor = true;
            this.tchk_RandEqPower.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_AddRemakeEq
            // 
            this.tchk_AddRemakeEq.AutoSize = true;
            this.tchk_AddRemakeEq.Location = new System.Drawing.Point(7, 7);
            this.tchk_AddRemakeEq.Margin = new System.Windows.Forms.Padding(2);
            this.tchk_AddRemakeEq.Name = "tchk_AddRemakeEq";
            this.tchk_AddRemakeEq.Size = new System.Drawing.Size(141, 17);
            this.tchk_AddRemakeEq.TabIndex = 142;
            this.tchk_AddRemakeEq.Text = "Add Remake Equipment";
            this.tchk_AddRemakeEq.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_AddRemakeEq, "Replaces some equipment to add equipment from remakes for Pilgrim, Merchant, and " +
        "Fighter.");
            this.tchk_AddRemakeEq.UseVisualStyleBackColor = true;
            this.tchk_AddRemakeEq.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tchk_AnimalSuit);
            this.tabPage6.Controls.Add(this.tchk_SellKeyItems);
            this.tabPage6.Controls.Add(this.tchk_RandInnPrice);
            this.tabPage6.Controls.Add(this.tchk_RandWeapShop);
            this.tabPage6.Controls.Add(this.tchk_RandItemShop);
            this.tabPage6.Controls.Add(this.grp_AddToItemShop);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(678, 422);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Item & Weapon Shops & Inns";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tchk_AnimalSuit
            // 
            this.tchk_AnimalSuit.AutoSize = true;
            this.tchk_AnimalSuit.Location = new System.Drawing.Point(7, 103);
            this.tchk_AnimalSuit.Name = "tchk_AnimalSuit";
            this.tchk_AnimalSuit.Size = new System.Drawing.Size(214, 17);
            this.tchk_AnimalSuit.TabIndex = 170;
            this.tchk_AnimalSuit.Text = "Guarantee Animal Suit in Weapon Shop";
            this.tchk_AnimalSuit.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_AnimalSuit, "Ensures that the Animal Suit will be found in at least 1 Weapon Shop.");
            this.tchk_AnimalSuit.UseVisualStyleBackColor = true;
            this.tchk_AnimalSuit.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_SellKeyItems
            // 
            this.tchk_SellKeyItems.AutoSize = true;
            this.tchk_SellKeyItems.Location = new System.Drawing.Point(7, 79);
            this.tchk_SellKeyItems.Name = "tchk_SellKeyItems";
            this.tchk_SellKeyItems.Size = new System.Drawing.Size(118, 17);
            this.tchk_SellKeyItems.TabIndex = 169;
            this.tchk_SellKeyItems.Text = "Sell Most Key Items";
            this.tchk_SellKeyItems.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_SellKeyItems, "Sell many key items. Selling before use can lead to progression blocks.");
            this.tchk_SellKeyItems.UseVisualStyleBackColor = true;
            this.tchk_SellKeyItems.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandInnPrice
            // 
            this.tchk_RandInnPrice.AutoSize = true;
            this.tchk_RandInnPrice.Location = new System.Drawing.Point(7, 55);
            this.tchk_RandInnPrice.Name = "tchk_RandInnPrice";
            this.tchk_RandInnPrice.Size = new System.Drawing.Size(129, 17);
            this.tchk_RandInnPrice.TabIndex = 168;
            this.tchk_RandInnPrice.Text = "Randomize Inn Prices";
            this.tchk_RandInnPrice.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandInnPrice, "Randomizes inn prices.");
            this.tchk_RandInnPrice.UseVisualStyleBackColor = true;
            this.tchk_RandInnPrice.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandWeapShop
            // 
            this.tchk_RandWeapShop.AutoSize = true;
            this.tchk_RandWeapShop.Location = new System.Drawing.Point(7, 31);
            this.tchk_RandWeapShop.Name = "tchk_RandWeapShop";
            this.tchk_RandWeapShop.Size = new System.Drawing.Size(156, 17);
            this.tchk_RandWeapShop.TabIndex = 167;
            this.tchk_RandWeapShop.Text = "Randomize Weapon Shops";
            this.tchk_RandWeapShop.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandWeapShop, "Randomizes weapons and armor found in Weapon Shops.");
            this.tchk_RandWeapShop.UseVisualStyleBackColor = true;
            this.tchk_RandWeapShop.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RandItemShop
            // 
            this.tchk_RandItemShop.AutoSize = true;
            this.tchk_RandItemShop.Location = new System.Drawing.Point(7, 7);
            this.tchk_RandItemShop.Name = "tchk_RandItemShop";
            this.tchk_RandItemShop.Size = new System.Drawing.Size(135, 17);
            this.tchk_RandItemShop.TabIndex = 166;
            this.tchk_RandItemShop.Text = "Randomize Item Shops";
            this.tchk_RandItemShop.ThreeState = true;
            this.adjustments.SetToolTip(this.tchk_RandItemShop, "Randomizes items for sale in Item Shops.");
            this.tchk_RandItemShop.UseVisualStyleBackColor = true;
            this.tchk_RandItemShop.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_AddToItemShop
            // 
            this.grp_AddToItemShop.Controls.Add(this.tchk_PoisonMothPowder);
            this.grp_AddToItemShop.Controls.Add(this.tchk_LeafOfTheWorldTree);
            this.grp_AddToItemShop.Controls.Add(this.tchk_StoneOfLife);
            this.grp_AddToItemShop.Controls.Add(this.tchk_WizardsRing);
            this.grp_AddToItemShop.Controls.Add(this.tchk_BookOfSatori);
            this.grp_AddToItemShop.Controls.Add(this.tchk_RingOfLife);
            this.grp_AddToItemShop.Controls.Add(this.tchk_ShoesOfHappiness);
            this.grp_AddToItemShop.Controls.Add(this.tchk_MeteoriteArmband);
            this.grp_AddToItemShop.Controls.Add(this.tchk_LampOfDarkness);
            this.grp_AddToItemShop.Controls.Add(this.tchk_SilverHarp);
            this.grp_AddToItemShop.Controls.Add(this.tchk_EchoingFlute);
            this.grp_AddToItemShop.Controls.Add(this.tchk_LuckSeed);
            this.grp_AddToItemShop.Controls.Add(this.tchk_VitSeed);
            this.grp_AddToItemShop.Controls.Add(this.tchk_IntSeed);
            this.grp_AddToItemShop.Controls.Add(this.tchk_AgiSeed);
            this.grp_AddToItemShop.Controls.Add(this.tchk_StrSeed);
            this.grp_AddToItemShop.Controls.Add(this.tchk_AcornsOfLife);
            this.grp_AddToItemShop.Location = new System.Drawing.Point(241, 7);
            this.grp_AddToItemShop.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AddToItemShop.Name = "grp_AddToItemShop";
            this.grp_AddToItemShop.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AddToItemShop.Size = new System.Drawing.Size(434, 169);
            this.grp_AddToItemShop.TabIndex = 165;
            this.grp_AddToItemShop.TabStop = false;
            this.grp_AddToItemShop.Text = "Add to Item Shops Pool";
            this.adjustments.SetToolTip(this.grp_AddToItemShop, "Add specific items to Item Shop pool.");
            // 
            // tchk_PoisonMothPowder
            // 
            this.tchk_PoisonMothPowder.AutoSize = true;
            this.tchk_PoisonMothPowder.Location = new System.Drawing.Point(269, 120);
            this.tchk_PoisonMothPowder.Name = "tchk_PoisonMothPowder";
            this.tchk_PoisonMothPowder.Size = new System.Drawing.Size(124, 17);
            this.tchk_PoisonMothPowder.TabIndex = 197;
            this.tchk_PoisonMothPowder.Text = "Poison Moth Powder";
            this.tchk_PoisonMothPowder.ThreeState = true;
            this.tchk_PoisonMothPowder.UseVisualStyleBackColor = true;
            this.tchk_PoisonMothPowder.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_LeafOfTheWorldTree
            // 
            this.tchk_LeafOfTheWorldTree.AutoSize = true;
            this.tchk_LeafOfTheWorldTree.Location = new System.Drawing.Point(269, 96);
            this.tchk_LeafOfTheWorldTree.Name = "tchk_LeafOfTheWorldTree";
            this.tchk_LeafOfTheWorldTree.Size = new System.Drawing.Size(133, 17);
            this.tchk_LeafOfTheWorldTree.TabIndex = 196;
            this.tchk_LeafOfTheWorldTree.Text = "Leaf of the World Tree";
            this.tchk_LeafOfTheWorldTree.ThreeState = true;
            this.tchk_LeafOfTheWorldTree.UseVisualStyleBackColor = true;
            this.tchk_LeafOfTheWorldTree.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_StoneOfLife
            // 
            this.tchk_StoneOfLife.AutoSize = true;
            this.tchk_StoneOfLife.Location = new System.Drawing.Point(269, 72);
            this.tchk_StoneOfLife.Name = "tchk_StoneOfLife";
            this.tchk_StoneOfLife.Size = new System.Drawing.Size(86, 17);
            this.tchk_StoneOfLife.TabIndex = 195;
            this.tchk_StoneOfLife.Text = "Stone of Life";
            this.tchk_StoneOfLife.ThreeState = true;
            this.tchk_StoneOfLife.UseVisualStyleBackColor = true;
            this.tchk_StoneOfLife.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_WizardsRing
            // 
            this.tchk_WizardsRing.AutoSize = true;
            this.tchk_WizardsRing.Location = new System.Drawing.Point(269, 48);
            this.tchk_WizardsRing.Name = "tchk_WizardsRing";
            this.tchk_WizardsRing.Size = new System.Drawing.Size(91, 17);
            this.tchk_WizardsRing.TabIndex = 194;
            this.tchk_WizardsRing.Text = "Wizard\'s Ring";
            this.tchk_WizardsRing.ThreeState = true;
            this.tchk_WizardsRing.UseVisualStyleBackColor = true;
            this.tchk_WizardsRing.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_BookOfSatori
            // 
            this.tchk_BookOfSatori.AutoSize = true;
            this.tchk_BookOfSatori.Location = new System.Drawing.Point(269, 24);
            this.tchk_BookOfSatori.Name = "tchk_BookOfSatori";
            this.tchk_BookOfSatori.Size = new System.Drawing.Size(93, 17);
            this.tchk_BookOfSatori.TabIndex = 193;
            this.tchk_BookOfSatori.Text = "Book of Satori";
            this.tchk_BookOfSatori.ThreeState = true;
            this.tchk_BookOfSatori.UseVisualStyleBackColor = true;
            this.tchk_BookOfSatori.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_RingOfLife
            // 
            this.tchk_RingOfLife.AutoSize = true;
            this.tchk_RingOfLife.Location = new System.Drawing.Point(135, 144);
            this.tchk_RingOfLife.Name = "tchk_RingOfLife";
            this.tchk_RingOfLife.Size = new System.Drawing.Size(80, 17);
            this.tchk_RingOfLife.TabIndex = 192;
            this.tchk_RingOfLife.Text = "Ring of Life";
            this.tchk_RingOfLife.ThreeState = true;
            this.tchk_RingOfLife.UseVisualStyleBackColor = true;
            this.tchk_RingOfLife.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_ShoesOfHappiness
            // 
            this.tchk_ShoesOfHappiness.AutoSize = true;
            this.tchk_ShoesOfHappiness.Location = new System.Drawing.Point(135, 120);
            this.tchk_ShoesOfHappiness.Name = "tchk_ShoesOfHappiness";
            this.tchk_ShoesOfHappiness.Size = new System.Drawing.Size(121, 17);
            this.tchk_ShoesOfHappiness.TabIndex = 191;
            this.tchk_ShoesOfHappiness.Text = "Shoes of Happiness";
            this.tchk_ShoesOfHappiness.ThreeState = true;
            this.tchk_ShoesOfHappiness.UseVisualStyleBackColor = true;
            this.tchk_ShoesOfHappiness.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_MeteoriteArmband
            // 
            this.tchk_MeteoriteArmband.AutoSize = true;
            this.tchk_MeteoriteArmband.Location = new System.Drawing.Point(135, 96);
            this.tchk_MeteoriteArmband.Name = "tchk_MeteoriteArmband";
            this.tchk_MeteoriteArmband.Size = new System.Drawing.Size(115, 17);
            this.tchk_MeteoriteArmband.TabIndex = 190;
            this.tchk_MeteoriteArmband.Text = "Meteorite Armband";
            this.tchk_MeteoriteArmband.ThreeState = true;
            this.tchk_MeteoriteArmband.UseVisualStyleBackColor = true;
            this.tchk_MeteoriteArmband.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_LampOfDarkness
            // 
            this.tchk_LampOfDarkness.AutoSize = true;
            this.tchk_LampOfDarkness.Location = new System.Drawing.Point(135, 72);
            this.tchk_LampOfDarkness.Name = "tchk_LampOfDarkness";
            this.tchk_LampOfDarkness.Size = new System.Drawing.Size(112, 17);
            this.tchk_LampOfDarkness.TabIndex = 189;
            this.tchk_LampOfDarkness.Text = "Lamp of Darkness";
            this.tchk_LampOfDarkness.ThreeState = true;
            this.tchk_LampOfDarkness.UseVisualStyleBackColor = true;
            this.tchk_LampOfDarkness.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_SilverHarp
            // 
            this.tchk_SilverHarp.AutoSize = true;
            this.tchk_SilverHarp.Location = new System.Drawing.Point(135, 48);
            this.tchk_SilverHarp.Name = "tchk_SilverHarp";
            this.tchk_SilverHarp.Size = new System.Drawing.Size(78, 17);
            this.tchk_SilverHarp.TabIndex = 3;
            this.tchk_SilverHarp.Text = "Silver Harp";
            this.tchk_SilverHarp.ThreeState = true;
            this.tchk_SilverHarp.UseVisualStyleBackColor = true;
            this.tchk_SilverHarp.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_EchoingFlute
            // 
            this.tchk_EchoingFlute.AutoSize = true;
            this.tchk_EchoingFlute.Location = new System.Drawing.Point(135, 24);
            this.tchk_EchoingFlute.Name = "tchk_EchoingFlute";
            this.tchk_EchoingFlute.Size = new System.Drawing.Size(91, 17);
            this.tchk_EchoingFlute.TabIndex = 188;
            this.tchk_EchoingFlute.Text = "Echoing Flute";
            this.tchk_EchoingFlute.ThreeState = true;
            this.tchk_EchoingFlute.UseVisualStyleBackColor = true;
            this.tchk_EchoingFlute.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_LuckSeed
            // 
            this.tchk_LuckSeed.AutoSize = true;
            this.tchk_LuckSeed.Location = new System.Drawing.Point(7, 144);
            this.tchk_LuckSeed.Name = "tchk_LuckSeed";
            this.tchk_LuckSeed.Size = new System.Drawing.Size(78, 17);
            this.tchk_LuckSeed.TabIndex = 187;
            this.tchk_LuckSeed.Text = "Luck Seed";
            this.tchk_LuckSeed.ThreeState = true;
            this.tchk_LuckSeed.UseVisualStyleBackColor = true;
            this.tchk_LuckSeed.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_VitSeed
            // 
            this.tchk_VitSeed.AutoSize = true;
            this.tchk_VitSeed.Location = new System.Drawing.Point(7, 120);
            this.tchk_VitSeed.Name = "tchk_VitSeed";
            this.tchk_VitSeed.Size = new System.Drawing.Size(84, 17);
            this.tchk_VitSeed.TabIndex = 186;
            this.tchk_VitSeed.Text = "Vitality Seed";
            this.tchk_VitSeed.ThreeState = true;
            this.tchk_VitSeed.UseVisualStyleBackColor = true;
            this.tchk_VitSeed.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_IntSeed
            // 
            this.tchk_IntSeed.AutoSize = true;
            this.tchk_IntSeed.Location = new System.Drawing.Point(7, 96);
            this.tchk_IntSeed.Name = "tchk_IntSeed";
            this.tchk_IntSeed.Size = new System.Drawing.Size(108, 17);
            this.tchk_IntSeed.TabIndex = 185;
            this.tchk_IntSeed.Text = "Intelligence Seed";
            this.tchk_IntSeed.ThreeState = true;
            this.tchk_IntSeed.UseVisualStyleBackColor = true;
            this.tchk_IntSeed.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_AgiSeed
            // 
            this.tchk_AgiSeed.AutoSize = true;
            this.tchk_AgiSeed.Location = new System.Drawing.Point(7, 72);
            this.tchk_AgiSeed.Name = "tchk_AgiSeed";
            this.tchk_AgiSeed.Size = new System.Drawing.Size(81, 17);
            this.tchk_AgiSeed.TabIndex = 184;
            this.tchk_AgiSeed.Text = "Agility Seed";
            this.tchk_AgiSeed.ThreeState = true;
            this.tchk_AgiSeed.UseVisualStyleBackColor = true;
            this.tchk_AgiSeed.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_StrSeed
            // 
            this.tchk_StrSeed.AutoSize = true;
            this.tchk_StrSeed.Location = new System.Drawing.Point(7, 48);
            this.tchk_StrSeed.Name = "tchk_StrSeed";
            this.tchk_StrSeed.Size = new System.Drawing.Size(94, 17);
            this.tchk_StrSeed.TabIndex = 183;
            this.tchk_StrSeed.Text = "Strength Seed";
            this.tchk_StrSeed.ThreeState = true;
            this.tchk_StrSeed.UseVisualStyleBackColor = true;
            this.tchk_StrSeed.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tchk_AcornsOfLife
            // 
            this.tchk_AcornsOfLife.AutoSize = true;
            this.tchk_AcornsOfLife.Location = new System.Drawing.Point(7, 24);
            this.tchk_AcornsOfLife.Name = "tchk_AcornsOfLife";
            this.tchk_AcornsOfLife.Size = new System.Drawing.Size(91, 17);
            this.tchk_AcornsOfLife.TabIndex = 182;
            this.tchk_AcornsOfLife.Text = "Acorns of Life";
            this.tchk_AcornsOfLife.ThreeState = true;
            this.tchk_AcornsOfLife.UseVisualStyleBackColor = true;
            this.tchk_AcornsOfLife.CheckStateChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grp_Class);
            this.tabPage3.Controls.Add(this.grp_Gender);
            this.tabPage3.Controls.Add(this.grp_ChName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(678, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tavern Members";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grp_Class
            // 
            this.grp_Class.Controls.Add(this.grp_ClassInclude);
            this.grp_Class.Controls.Add(this.grp_Class3);
            this.grp_Class.Controls.Add(this.grp_Class2);
            this.grp_Class.Controls.Add(this.grp_Class1);
            this.grp_Class.Location = new System.Drawing.Point(5, 215);
            this.grp_Class.Name = "grp_Class";
            this.grp_Class.Size = new System.Drawing.Size(668, 157);
            this.grp_Class.TabIndex = 186;
            this.grp_Class.TabStop = false;
            this.grp_Class.Text = "Class";
            this.adjustments.SetToolTip(this.grp_Class, "Allows for changing of classes found in tavern or randomizing (Sage and Hero will" +
        " change flags).");
            // 
            // grp_ClassInclude
            // 
            this.grp_ClassInclude.Controls.Add(this.chk_RandSoldier);
            this.grp_ClassInclude.Controls.Add(this.chk_RandPilgrim);
            this.grp_ClassInclude.Controls.Add(this.chk_RandWizard);
            this.grp_ClassInclude.Controls.Add(this.chk_RandFighter);
            this.grp_ClassInclude.Controls.Add(this.chk_RandMerchant);
            this.grp_ClassInclude.Controls.Add(this.chk_RandGoofOff);
            this.grp_ClassInclude.Controls.Add(this.chk_RandHero);
            this.grp_ClassInclude.Controls.Add(this.chk_RandSage);
            this.grp_ClassInclude.Location = new System.Drawing.Point(6, 20);
            this.grp_ClassInclude.Name = "grp_ClassInclude";
            this.grp_ClassInclude.Size = new System.Drawing.Size(612, 51);
            this.grp_ClassInclude.TabIndex = 4;
            this.grp_ClassInclude.TabStop = false;
            this.grp_ClassInclude.Text = "Classes to include in Randomization";
            // 
            // chk_RandSoldier
            // 
            this.chk_RandSoldier.AutoSize = true;
            this.chk_RandSoldier.Checked = true;
            this.chk_RandSoldier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandSoldier.Location = new System.Drawing.Point(6, 19);
            this.chk_RandSoldier.Name = "chk_RandSoldier";
            this.chk_RandSoldier.Size = new System.Drawing.Size(58, 17);
            this.chk_RandSoldier.TabIndex = 208;
            this.chk_RandSoldier.Text = "Soldier";
            this.chk_RandSoldier.UseVisualStyleBackColor = true;
            this.chk_RandSoldier.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandPilgrim
            // 
            this.chk_RandPilgrim.AutoSize = true;
            this.chk_RandPilgrim.Checked = true;
            this.chk_RandPilgrim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandPilgrim.Location = new System.Drawing.Point(70, 19);
            this.chk_RandPilgrim.Name = "chk_RandPilgrim";
            this.chk_RandPilgrim.Size = new System.Drawing.Size(56, 17);
            this.chk_RandPilgrim.TabIndex = 209;
            this.chk_RandPilgrim.Text = "Pilgrim";
            this.chk_RandPilgrim.UseVisualStyleBackColor = true;
            this.chk_RandPilgrim.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandWizard
            // 
            this.chk_RandWizard.AutoSize = true;
            this.chk_RandWizard.Checked = true;
            this.chk_RandWizard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_RandWizard.Location = new System.Drawing.Point(132, 19);
            this.chk_RandWizard.Name = "chk_RandWizard";
            this.chk_RandWizard.Size = new System.Drawing.Size(59, 17);
            this.chk_RandWizard.TabIndex = 210;
            this.chk_RandWizard.Text = "Wizard";
            this.chk_RandWizard.UseVisualStyleBackColor = true;
            this.chk_RandWizard.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandFighter
            // 
            this.chk_RandFighter.AutoSize = true;
            this.chk_RandFighter.Location = new System.Drawing.Point(193, 19);
            this.chk_RandFighter.Name = "chk_RandFighter";
            this.chk_RandFighter.Size = new System.Drawing.Size(58, 17);
            this.chk_RandFighter.TabIndex = 211;
            this.chk_RandFighter.Text = "Fighter";
            this.chk_RandFighter.UseVisualStyleBackColor = true;
            this.chk_RandFighter.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandMerchant
            // 
            this.chk_RandMerchant.AutoSize = true;
            this.chk_RandMerchant.Location = new System.Drawing.Point(255, 19);
            this.chk_RandMerchant.Name = "chk_RandMerchant";
            this.chk_RandMerchant.Size = new System.Drawing.Size(71, 17);
            this.chk_RandMerchant.TabIndex = 212;
            this.chk_RandMerchant.Text = "Merchant";
            this.chk_RandMerchant.UseVisualStyleBackColor = true;
            this.chk_RandMerchant.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandGoofOff
            // 
            this.chk_RandGoofOff.AutoSize = true;
            this.chk_RandGoofOff.Location = new System.Drawing.Point(329, 19);
            this.chk_RandGoofOff.Name = "chk_RandGoofOff";
            this.chk_RandGoofOff.Size = new System.Drawing.Size(66, 17);
            this.chk_RandGoofOff.TabIndex = 213;
            this.chk_RandGoofOff.Text = "Goof-Off";
            this.chk_RandGoofOff.UseVisualStyleBackColor = true;
            this.chk_RandGoofOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandHero
            // 
            this.chk_RandHero.AutoSize = true;
            this.chk_RandHero.Location = new System.Drawing.Point(453, 19);
            this.chk_RandHero.Name = "chk_RandHero";
            this.chk_RandHero.Size = new System.Drawing.Size(49, 17);
            this.chk_RandHero.TabIndex = 215;
            this.chk_RandHero.Text = "Hero";
            this.chk_RandHero.UseVisualStyleBackColor = true;
            this.chk_RandHero.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSage
            // 
            this.chk_RandSage.AutoSize = true;
            this.chk_RandSage.Location = new System.Drawing.Point(399, 19);
            this.chk_RandSage.Name = "chk_RandSage";
            this.chk_RandSage.Size = new System.Drawing.Size(51, 17);
            this.chk_RandSage.TabIndex = 214;
            this.chk_RandSage.Text = "Sage";
            this.chk_RandSage.UseVisualStyleBackColor = true;
            this.chk_RandSage.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_Class3
            // 
            this.grp_Class3.Controls.Add(this.rad_Class3Rand);
            this.grp_Class3.Controls.Add(this.rad_Class3Manual);
            this.grp_Class3.Controls.Add(this.rad_Class3Off);
            this.grp_Class3.Controls.Add(this.cbo_Class3);
            this.grp_Class3.Location = new System.Drawing.Point(418, 77);
            this.grp_Class3.Name = "grp_Class3";
            this.grp_Class3.Size = new System.Drawing.Size(200, 76);
            this.grp_Class3.TabIndex = 222;
            this.grp_Class3.TabStop = false;
            this.grp_Class3.Text = "Member 3";
            // 
            // rad_Class3Rand
            // 
            this.rad_Class3Rand.AutoSize = true;
            this.rad_Class3Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_Class3Rand.Name = "rad_Class3Rand";
            this.rad_Class3Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_Class3Rand.TabIndex = 2;
            this.rad_Class3Rand.Text = "Random";
            this.rad_Class3Rand.UseVisualStyleBackColor = true;
            this.rad_Class3Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Class3Manual
            // 
            this.rad_Class3Manual.AutoSize = true;
            this.rad_Class3Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_Class3Manual.Name = "rad_Class3Manual";
            this.rad_Class3Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_Class3Manual.TabIndex = 1;
            this.rad_Class3Manual.Text = "Manual";
            this.rad_Class3Manual.UseVisualStyleBackColor = true;
            this.rad_Class3Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Class3Off
            // 
            this.rad_Class3Off.AutoSize = true;
            this.rad_Class3Off.Checked = true;
            this.rad_Class3Off.Location = new System.Drawing.Point(6, 19);
            this.rad_Class3Off.Name = "rad_Class3Off";
            this.rad_Class3Off.Size = new System.Drawing.Size(39, 17);
            this.rad_Class3Off.TabIndex = 223;
            this.rad_Class3Off.TabStop = true;
            this.rad_Class3Off.Text = "Off";
            this.rad_Class3Off.UseVisualStyleBackColor = true;
            this.rad_Class3Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // cbo_Class3
            // 
            this.cbo_Class3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Class3.FormattingEnabled = true;
            this.cbo_Class3.Items.AddRange(new object[] {
            "Soldier",
            "Pilgrim",
            "Wizard",
            "Fighter",
            "Merchant",
            "Goof-off",
            "Sage",
            "Hero"});
            this.cbo_Class3.Location = new System.Drawing.Point(6, 43);
            this.cbo_Class3.Name = "cbo_Class3";
            this.cbo_Class3.Size = new System.Drawing.Size(138, 21);
            this.cbo_Class3.TabIndex = 224;
            // 
            // grp_Class2
            // 
            this.grp_Class2.Controls.Add(this.rad_Class2Rand);
            this.grp_Class2.Controls.Add(this.rad_Class2Manual);
            this.grp_Class2.Controls.Add(this.rad_Class2Off);
            this.grp_Class2.Controls.Add(this.cbo_Class2);
            this.grp_Class2.Location = new System.Drawing.Point(212, 77);
            this.grp_Class2.Name = "grp_Class2";
            this.grp_Class2.Size = new System.Drawing.Size(200, 76);
            this.grp_Class2.TabIndex = 219;
            this.grp_Class2.TabStop = false;
            this.grp_Class2.Text = "Member 2";
            // 
            // rad_Class2Rand
            // 
            this.rad_Class2Rand.AutoSize = true;
            this.rad_Class2Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_Class2Rand.Name = "rad_Class2Rand";
            this.rad_Class2Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_Class2Rand.TabIndex = 2;
            this.rad_Class2Rand.Text = "Random";
            this.rad_Class2Rand.UseVisualStyleBackColor = true;
            this.rad_Class2Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Class2Manual
            // 
            this.rad_Class2Manual.AutoSize = true;
            this.rad_Class2Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_Class2Manual.Name = "rad_Class2Manual";
            this.rad_Class2Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_Class2Manual.TabIndex = 1;
            this.rad_Class2Manual.Text = "Manual";
            this.rad_Class2Manual.UseVisualStyleBackColor = true;
            this.rad_Class2Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Class2Off
            // 
            this.rad_Class2Off.AutoSize = true;
            this.rad_Class2Off.Checked = true;
            this.rad_Class2Off.Location = new System.Drawing.Point(6, 19);
            this.rad_Class2Off.Name = "rad_Class2Off";
            this.rad_Class2Off.Size = new System.Drawing.Size(39, 17);
            this.rad_Class2Off.TabIndex = 220;
            this.rad_Class2Off.TabStop = true;
            this.rad_Class2Off.Text = "Off";
            this.rad_Class2Off.UseVisualStyleBackColor = true;
            this.rad_Class2Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // cbo_Class2
            // 
            this.cbo_Class2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Class2.FormattingEnabled = true;
            this.cbo_Class2.Items.AddRange(new object[] {
            "Soldier",
            "Pilgrim",
            "Wizard",
            "Fighter",
            "Merchant",
            "Goof-off",
            "Sage",
            "Hero"});
            this.cbo_Class2.Location = new System.Drawing.Point(7, 43);
            this.cbo_Class2.Name = "cbo_Class2";
            this.cbo_Class2.Size = new System.Drawing.Size(138, 21);
            this.cbo_Class2.TabIndex = 221;
            // 
            // grp_Class1
            // 
            this.grp_Class1.Controls.Add(this.rad_Class1Rand);
            this.grp_Class1.Controls.Add(this.rad_Class1Manual);
            this.grp_Class1.Controls.Add(this.rad_Class1Off);
            this.grp_Class1.Controls.Add(this.cbo_Class1);
            this.grp_Class1.Location = new System.Drawing.Point(6, 77);
            this.grp_Class1.Name = "grp_Class1";
            this.grp_Class1.Size = new System.Drawing.Size(200, 76);
            this.grp_Class1.TabIndex = 216;
            this.grp_Class1.TabStop = false;
            this.grp_Class1.Text = "Member 1";
            // 
            // rad_Class1Rand
            // 
            this.rad_Class1Rand.AutoSize = true;
            this.rad_Class1Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_Class1Rand.Name = "rad_Class1Rand";
            this.rad_Class1Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_Class1Rand.TabIndex = 2;
            this.rad_Class1Rand.Text = "Random";
            this.rad_Class1Rand.UseVisualStyleBackColor = true;
            this.rad_Class1Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Class1Manual
            // 
            this.rad_Class1Manual.AutoSize = true;
            this.rad_Class1Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_Class1Manual.Name = "rad_Class1Manual";
            this.rad_Class1Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_Class1Manual.TabIndex = 1;
            this.rad_Class1Manual.Text = "Manual";
            this.rad_Class1Manual.UseVisualStyleBackColor = true;
            this.rad_Class1Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Class1Off
            // 
            this.rad_Class1Off.AutoSize = true;
            this.rad_Class1Off.Checked = true;
            this.rad_Class1Off.Location = new System.Drawing.Point(6, 19);
            this.rad_Class1Off.Name = "rad_Class1Off";
            this.rad_Class1Off.Size = new System.Drawing.Size(39, 17);
            this.rad_Class1Off.TabIndex = 217;
            this.rad_Class1Off.TabStop = true;
            this.rad_Class1Off.Text = "Off";
            this.rad_Class1Off.UseVisualStyleBackColor = true;
            this.rad_Class1Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // cbo_Class1
            // 
            this.cbo_Class1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Class1.FormattingEnabled = true;
            this.cbo_Class1.Items.AddRange(new object[] {
            "Soldier",
            "Pilgrim",
            "Wizard",
            "Fighter",
            "Merchant",
            "Goof-off",
            "Sage",
            "Hero"});
            this.cbo_Class1.Location = new System.Drawing.Point(7, 43);
            this.cbo_Class1.Name = "cbo_Class1";
            this.cbo_Class1.Size = new System.Drawing.Size(138, 21);
            this.cbo_Class1.TabIndex = 218;
            // 
            // grp_Gender
            // 
            this.grp_Gender.Controls.Add(this.grp_Gender3);
            this.grp_Gender.Controls.Add(this.grp_Gender2);
            this.grp_Gender.Controls.Add(this.grp_Gender1);
            this.grp_Gender.Location = new System.Drawing.Point(5, 109);
            this.grp_Gender.Name = "grp_Gender";
            this.grp_Gender.Size = new System.Drawing.Size(668, 100);
            this.grp_Gender.TabIndex = 185;
            this.grp_Gender.TabStop = false;
            this.grp_Gender.Text = "Gender";
            this.adjustments.SetToolTip(this.grp_Gender, "Allows for changing the gender of tavern members or randomizing.");
            // 
            // grp_Gender3
            // 
            this.grp_Gender3.Controls.Add(this.rad_Gender3Rand);
            this.grp_Gender3.Controls.Add(this.rad_Gender3Manual);
            this.grp_Gender3.Controls.Add(this.rad_Gender3Off);
            this.grp_Gender3.Controls.Add(this.cbo_Gender3);
            this.grp_Gender3.Location = new System.Drawing.Point(418, 19);
            this.grp_Gender3.Name = "grp_Gender3";
            this.grp_Gender3.Size = new System.Drawing.Size(200, 76);
            this.grp_Gender3.TabIndex = 205;
            this.grp_Gender3.TabStop = false;
            this.grp_Gender3.Text = "Member 3";
            // 
            // rad_Gender3Rand
            // 
            this.rad_Gender3Rand.AutoSize = true;
            this.rad_Gender3Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_Gender3Rand.Name = "rad_Gender3Rand";
            this.rad_Gender3Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_Gender3Rand.TabIndex = 2;
            this.rad_Gender3Rand.Text = "Random";
            this.rad_Gender3Rand.UseVisualStyleBackColor = true;
            this.rad_Gender3Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Gender3Manual
            // 
            this.rad_Gender3Manual.AutoSize = true;
            this.rad_Gender3Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_Gender3Manual.Name = "rad_Gender3Manual";
            this.rad_Gender3Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_Gender3Manual.TabIndex = 1;
            this.rad_Gender3Manual.Text = "Manual";
            this.rad_Gender3Manual.UseVisualStyleBackColor = true;
            this.rad_Gender3Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Gender3Off
            // 
            this.rad_Gender3Off.AutoSize = true;
            this.rad_Gender3Off.Checked = true;
            this.rad_Gender3Off.Location = new System.Drawing.Point(6, 19);
            this.rad_Gender3Off.Name = "rad_Gender3Off";
            this.rad_Gender3Off.Size = new System.Drawing.Size(39, 17);
            this.rad_Gender3Off.TabIndex = 206;
            this.rad_Gender3Off.TabStop = true;
            this.rad_Gender3Off.Text = "Off";
            this.rad_Gender3Off.UseVisualStyleBackColor = true;
            this.rad_Gender3Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // cbo_Gender3
            // 
            this.cbo_Gender3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Gender3.FormattingEnabled = true;
            this.cbo_Gender3.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbo_Gender3.Location = new System.Drawing.Point(6, 43);
            this.cbo_Gender3.Name = "cbo_Gender3";
            this.cbo_Gender3.Size = new System.Drawing.Size(150, 21);
            this.cbo_Gender3.TabIndex = 107;
            // 
            // grp_Gender2
            // 
            this.grp_Gender2.Controls.Add(this.rad_Gender2Rand);
            this.grp_Gender2.Controls.Add(this.rad_Gender2Manual);
            this.grp_Gender2.Controls.Add(this.rad_Gender2Off);
            this.grp_Gender2.Controls.Add(this.cbo_Gender2);
            this.grp_Gender2.Location = new System.Drawing.Point(212, 19);
            this.grp_Gender2.Name = "grp_Gender2";
            this.grp_Gender2.Size = new System.Drawing.Size(200, 76);
            this.grp_Gender2.TabIndex = 202;
            this.grp_Gender2.TabStop = false;
            this.grp_Gender2.Text = "Member 2";
            // 
            // rad_Gender2Rand
            // 
            this.rad_Gender2Rand.AutoSize = true;
            this.rad_Gender2Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_Gender2Rand.Name = "rad_Gender2Rand";
            this.rad_Gender2Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_Gender2Rand.TabIndex = 2;
            this.rad_Gender2Rand.Text = "Random";
            this.rad_Gender2Rand.UseVisualStyleBackColor = true;
            this.rad_Gender2Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Gender2Manual
            // 
            this.rad_Gender2Manual.AutoSize = true;
            this.rad_Gender2Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_Gender2Manual.Name = "rad_Gender2Manual";
            this.rad_Gender2Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_Gender2Manual.TabIndex = 1;
            this.rad_Gender2Manual.Text = "Manual";
            this.rad_Gender2Manual.UseVisualStyleBackColor = true;
            this.rad_Gender2Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Gender2Off
            // 
            this.rad_Gender2Off.AutoSize = true;
            this.rad_Gender2Off.Checked = true;
            this.rad_Gender2Off.Location = new System.Drawing.Point(6, 19);
            this.rad_Gender2Off.Name = "rad_Gender2Off";
            this.rad_Gender2Off.Size = new System.Drawing.Size(39, 17);
            this.rad_Gender2Off.TabIndex = 203;
            this.rad_Gender2Off.TabStop = true;
            this.rad_Gender2Off.Text = "Off";
            this.rad_Gender2Off.UseVisualStyleBackColor = true;
            this.rad_Gender2Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // cbo_Gender2
            // 
            this.cbo_Gender2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Gender2.FormattingEnabled = true;
            this.cbo_Gender2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbo_Gender2.Location = new System.Drawing.Point(6, 43);
            this.cbo_Gender2.Name = "cbo_Gender2";
            this.cbo_Gender2.Size = new System.Drawing.Size(150, 21);
            this.cbo_Gender2.TabIndex = 204;
            // 
            // grp_Gender1
            // 
            this.grp_Gender1.Controls.Add(this.rad_Gender1Rand);
            this.grp_Gender1.Controls.Add(this.rad_Gender1Manual);
            this.grp_Gender1.Controls.Add(this.rad_Gender1Off);
            this.grp_Gender1.Controls.Add(this.cbo_Gender1);
            this.grp_Gender1.Location = new System.Drawing.Point(6, 19);
            this.grp_Gender1.Name = "grp_Gender1";
            this.grp_Gender1.Size = new System.Drawing.Size(200, 76);
            this.grp_Gender1.TabIndex = 199;
            this.grp_Gender1.TabStop = false;
            this.grp_Gender1.Text = "Member 1";
            // 
            // rad_Gender1Rand
            // 
            this.rad_Gender1Rand.AutoSize = true;
            this.rad_Gender1Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_Gender1Rand.Name = "rad_Gender1Rand";
            this.rad_Gender1Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_Gender1Rand.TabIndex = 2;
            this.rad_Gender1Rand.Text = "Random";
            this.rad_Gender1Rand.UseVisualStyleBackColor = true;
            this.rad_Gender1Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Gender1Manual
            // 
            this.rad_Gender1Manual.AutoSize = true;
            this.rad_Gender1Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_Gender1Manual.Name = "rad_Gender1Manual";
            this.rad_Gender1Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_Gender1Manual.TabIndex = 1;
            this.rad_Gender1Manual.Text = "Manual";
            this.rad_Gender1Manual.UseVisualStyleBackColor = true;
            this.rad_Gender1Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_Gender1Off
            // 
            this.rad_Gender1Off.AutoSize = true;
            this.rad_Gender1Off.Checked = true;
            this.rad_Gender1Off.Location = new System.Drawing.Point(6, 19);
            this.rad_Gender1Off.Name = "rad_Gender1Off";
            this.rad_Gender1Off.Size = new System.Drawing.Size(39, 17);
            this.rad_Gender1Off.TabIndex = 200;
            this.rad_Gender1Off.TabStop = true;
            this.rad_Gender1Off.Text = "Off";
            this.rad_Gender1Off.UseVisualStyleBackColor = true;
            this.rad_Gender1Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // cbo_Gender1
            // 
            this.cbo_Gender1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Gender1.FormattingEnabled = true;
            this.cbo_Gender1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbo_Gender1.Location = new System.Drawing.Point(7, 43);
            this.cbo_Gender1.Name = "cbo_Gender1";
            this.cbo_Gender1.Size = new System.Drawing.Size(150, 21);
            this.cbo_Gender1.TabIndex = 201;
            // 
            // grp_ChName
            // 
            this.grp_ChName.Controls.Add(this.grp_ChName3);
            this.grp_ChName.Controls.Add(this.grp_ChName2);
            this.grp_ChName.Controls.Add(this.grp_ChName1);
            this.grp_ChName.Location = new System.Drawing.Point(5, 3);
            this.grp_ChName.Name = "grp_ChName";
            this.grp_ChName.Size = new System.Drawing.Size(668, 100);
            this.grp_ChName.TabIndex = 184;
            this.grp_ChName.TabStop = false;
            this.grp_ChName.Text = "Change Names";
            this.adjustments.SetToolTip(this.grp_ChName, "Allows for manual setting of Tavern Members names or random name from the Dragon " +
        "Quest series.");
            // 
            // grp_ChName3
            // 
            this.grp_ChName3.Controls.Add(this.rad_ChName3Rand);
            this.grp_ChName3.Controls.Add(this.rad_ChName3Manual);
            this.grp_ChName3.Controls.Add(this.rad_ChName3Off);
            this.grp_ChName3.Controls.Add(this.txt_ChName3);
            this.grp_ChName3.Location = new System.Drawing.Point(418, 19);
            this.grp_ChName3.Name = "grp_ChName3";
            this.grp_ChName3.Size = new System.Drawing.Size(200, 76);
            this.grp_ChName3.TabIndex = 196;
            this.grp_ChName3.TabStop = false;
            this.grp_ChName3.Text = "Member 3";
            // 
            // rad_ChName3Rand
            // 
            this.rad_ChName3Rand.AutoSize = true;
            this.rad_ChName3Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_ChName3Rand.Name = "rad_ChName3Rand";
            this.rad_ChName3Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_ChName3Rand.TabIndex = 2;
            this.rad_ChName3Rand.Text = "Random";
            this.rad_ChName3Rand.UseVisualStyleBackColor = true;
            this.rad_ChName3Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ChName3Manual
            // 
            this.rad_ChName3Manual.AutoSize = true;
            this.rad_ChName3Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_ChName3Manual.Name = "rad_ChName3Manual";
            this.rad_ChName3Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_ChName3Manual.TabIndex = 1;
            this.rad_ChName3Manual.Text = "Manual";
            this.rad_ChName3Manual.UseVisualStyleBackColor = true;
            this.rad_ChName3Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ChName3Off
            // 
            this.rad_ChName3Off.AutoSize = true;
            this.rad_ChName3Off.Checked = true;
            this.rad_ChName3Off.Location = new System.Drawing.Point(6, 19);
            this.rad_ChName3Off.Name = "rad_ChName3Off";
            this.rad_ChName3Off.Size = new System.Drawing.Size(39, 17);
            this.rad_ChName3Off.TabIndex = 197;
            this.rad_ChName3Off.TabStop = true;
            this.rad_ChName3Off.Text = "Off";
            this.rad_ChName3Off.UseVisualStyleBackColor = true;
            this.rad_ChName3Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // txt_ChName3
            // 
            this.txt_ChName3.Location = new System.Drawing.Point(6, 43);
            this.txt_ChName3.MaxLength = 8;
            this.txt_ChName3.Name = "txt_ChName3";
            this.txt_ChName3.Size = new System.Drawing.Size(143, 20);
            this.txt_ChName3.TabIndex = 198;
            // 
            // grp_ChName2
            // 
            this.grp_ChName2.Controls.Add(this.rad_ChName2Rand);
            this.grp_ChName2.Controls.Add(this.rad_ChName2Manual);
            this.grp_ChName2.Controls.Add(this.rad_ChName2Off);
            this.grp_ChName2.Controls.Add(this.txt_ChName2);
            this.grp_ChName2.Location = new System.Drawing.Point(212, 19);
            this.grp_ChName2.Name = "grp_ChName2";
            this.grp_ChName2.Size = new System.Drawing.Size(200, 75);
            this.grp_ChName2.TabIndex = 193;
            this.grp_ChName2.TabStop = false;
            this.grp_ChName2.Text = "Member 2";
            // 
            // rad_ChName2Rand
            // 
            this.rad_ChName2Rand.AutoSize = true;
            this.rad_ChName2Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_ChName2Rand.Name = "rad_ChName2Rand";
            this.rad_ChName2Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_ChName2Rand.TabIndex = 2;
            this.rad_ChName2Rand.Text = "Random";
            this.rad_ChName2Rand.UseVisualStyleBackColor = true;
            this.rad_ChName2Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ChName2Manual
            // 
            this.rad_ChName2Manual.AutoSize = true;
            this.rad_ChName2Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_ChName2Manual.Name = "rad_ChName2Manual";
            this.rad_ChName2Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_ChName2Manual.TabIndex = 1;
            this.rad_ChName2Manual.Text = "Manual";
            this.rad_ChName2Manual.UseVisualStyleBackColor = true;
            this.rad_ChName2Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ChName2Off
            // 
            this.rad_ChName2Off.AutoSize = true;
            this.rad_ChName2Off.Checked = true;
            this.rad_ChName2Off.Location = new System.Drawing.Point(6, 19);
            this.rad_ChName2Off.Name = "rad_ChName2Off";
            this.rad_ChName2Off.Size = new System.Drawing.Size(39, 17);
            this.rad_ChName2Off.TabIndex = 194;
            this.rad_ChName2Off.TabStop = true;
            this.rad_ChName2Off.Text = "Off";
            this.rad_ChName2Off.UseVisualStyleBackColor = true;
            this.rad_ChName2Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // txt_ChName2
            // 
            this.txt_ChName2.Location = new System.Drawing.Point(6, 43);
            this.txt_ChName2.MaxLength = 8;
            this.txt_ChName2.Name = "txt_ChName2";
            this.txt_ChName2.Size = new System.Drawing.Size(143, 20);
            this.txt_ChName2.TabIndex = 195;
            // 
            // grp_ChName1
            // 
            this.grp_ChName1.Controls.Add(this.rad_ChName1Rand);
            this.grp_ChName1.Controls.Add(this.rad_ChName1Manual);
            this.grp_ChName1.Controls.Add(this.rad_ChName1Off);
            this.grp_ChName1.Controls.Add(this.txt_ChName1);
            this.grp_ChName1.Location = new System.Drawing.Point(6, 19);
            this.grp_ChName1.Name = "grp_ChName1";
            this.grp_ChName1.Size = new System.Drawing.Size(200, 76);
            this.grp_ChName1.TabIndex = 190;
            this.grp_ChName1.TabStop = false;
            this.grp_ChName1.Text = "Member 1";
            // 
            // rad_ChName1Rand
            // 
            this.rad_ChName1Rand.AutoSize = true;
            this.rad_ChName1Rand.Location = new System.Drawing.Point(117, 19);
            this.rad_ChName1Rand.Name = "rad_ChName1Rand";
            this.rad_ChName1Rand.Size = new System.Drawing.Size(65, 17);
            this.rad_ChName1Rand.TabIndex = 2;
            this.rad_ChName1Rand.Text = "Random";
            this.rad_ChName1Rand.UseVisualStyleBackColor = true;
            this.rad_ChName1Rand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ChName1Manual
            // 
            this.rad_ChName1Manual.AutoSize = true;
            this.rad_ChName1Manual.Location = new System.Drawing.Point(51, 19);
            this.rad_ChName1Manual.Name = "rad_ChName1Manual";
            this.rad_ChName1Manual.Size = new System.Drawing.Size(60, 17);
            this.rad_ChName1Manual.TabIndex = 1;
            this.rad_ChName1Manual.Text = "Manual";
            this.rad_ChName1Manual.UseVisualStyleBackColor = true;
            this.rad_ChName1Manual.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ChName1Off
            // 
            this.rad_ChName1Off.AutoSize = true;
            this.rad_ChName1Off.Checked = true;
            this.rad_ChName1Off.Location = new System.Drawing.Point(6, 19);
            this.rad_ChName1Off.Name = "rad_ChName1Off";
            this.rad_ChName1Off.Size = new System.Drawing.Size(39, 17);
            this.rad_ChName1Off.TabIndex = 191;
            this.rad_ChName1Off.TabStop = true;
            this.rad_ChName1Off.Text = "Off";
            this.rad_ChName1Off.UseVisualStyleBackColor = true;
            this.rad_ChName1Off.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // txt_ChName1
            // 
            this.txt_ChName1.Location = new System.Drawing.Point(6, 43);
            this.txt_ChName1.MaxLength = 8;
            this.txt_ChName1.Name = "txt_ChName1";
            this.txt_ChName1.Size = new System.Drawing.Size(143, 20);
            this.txt_ChName1.TabIndex = 192;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.grp_FixHeroSpell);
            this.tabPage5.Controls.Add(this.grp_RmParryBug);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(678, 422);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fixes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // grp_FixHeroSpell
            // 
            this.grp_FixHeroSpell.Controls.Add(this.rad_FixHeroSpellRand);
            this.grp_FixHeroSpell.Controls.Add(this.rad_FixHeroSpellOn);
            this.grp_FixHeroSpell.Controls.Add(this.rad_FixHeroSpellOff);
            this.grp_FixHeroSpell.Location = new System.Drawing.Point(173, 4);
            this.grp_FixHeroSpell.Margin = new System.Windows.Forms.Padding(2);
            this.grp_FixHeroSpell.Name = "grp_FixHeroSpell";
            this.grp_FixHeroSpell.Padding = new System.Windows.Forms.Padding(2);
            this.grp_FixHeroSpell.Size = new System.Drawing.Size(163, 41);
            this.grp_FixHeroSpell.TabIndex = 231;
            this.grp_FixHeroSpell.TabStop = false;
            this.grp_FixHeroSpell.Text = "Fix Hero Spell Glitch";
            this.adjustments.SetToolTip(this.grp_FixHeroSpell, "Fixes Hero spell overflow glitch when creating too many party members");
            // 
            // rad_FixHeroSpellRand
            // 
            this.rad_FixHeroSpellRand.AutoSize = true;
            this.rad_FixHeroSpellRand.Location = new System.Drawing.Point(92, 19);
            this.rad_FixHeroSpellRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_FixHeroSpellRand.Name = "rad_FixHeroSpellRand";
            this.rad_FixHeroSpellRand.Size = new System.Drawing.Size(65, 17);
            this.rad_FixHeroSpellRand.TabIndex = 2;
            this.rad_FixHeroSpellRand.Text = "Random";
            this.rad_FixHeroSpellRand.UseVisualStyleBackColor = true;
            this.rad_FixHeroSpellRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_FixHeroSpellOn
            // 
            this.rad_FixHeroSpellOn.AutoSize = true;
            this.rad_FixHeroSpellOn.Location = new System.Drawing.Point(49, 19);
            this.rad_FixHeroSpellOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_FixHeroSpellOn.Name = "rad_FixHeroSpellOn";
            this.rad_FixHeroSpellOn.Size = new System.Drawing.Size(39, 17);
            this.rad_FixHeroSpellOn.TabIndex = 1;
            this.rad_FixHeroSpellOn.Text = "On";
            this.rad_FixHeroSpellOn.UseVisualStyleBackColor = true;
            this.rad_FixHeroSpellOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_FixHeroSpellOff
            // 
            this.rad_FixHeroSpellOff.AutoSize = true;
            this.rad_FixHeroSpellOff.Checked = true;
            this.rad_FixHeroSpellOff.Location = new System.Drawing.Point(6, 19);
            this.rad_FixHeroSpellOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_FixHeroSpellOff.Name = "rad_FixHeroSpellOff";
            this.rad_FixHeroSpellOff.Size = new System.Drawing.Size(39, 17);
            this.rad_FixHeroSpellOff.TabIndex = 0;
            this.rad_FixHeroSpellOff.TabStop = true;
            this.rad_FixHeroSpellOff.Text = "Off";
            this.rad_FixHeroSpellOff.UseVisualStyleBackColor = true;
            this.rad_FixHeroSpellOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RmParryBug
            // 
            this.grp_RmParryBug.Controls.Add(this.rad_RmParryBugRand);
            this.grp_RmParryBug.Controls.Add(this.rad_RmParryBugOn);
            this.grp_RmParryBug.Controls.Add(this.rad_RmParryBugOff);
            this.grp_RmParryBug.Location = new System.Drawing.Point(4, 4);
            this.grp_RmParryBug.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RmParryBug.Name = "grp_RmParryBug";
            this.grp_RmParryBug.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RmParryBug.Size = new System.Drawing.Size(163, 41);
            this.grp_RmParryBug.TabIndex = 230;
            this.grp_RmParryBug.TabStop = false;
            this.grp_RmParryBug.Text = "Remove Parry/Fight Bug";
            this.adjustments.SetToolTip(this.grp_RmParryBug, "Removes stacking of Parry with Fight command");
            // 
            // rad_RmParryBugRand
            // 
            this.rad_RmParryBugRand.AutoSize = true;
            this.rad_RmParryBugRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RmParryBugRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmParryBugRand.Name = "rad_RmParryBugRand";
            this.rad_RmParryBugRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RmParryBugRand.TabIndex = 2;
            this.rad_RmParryBugRand.Text = "Random";
            this.rad_RmParryBugRand.UseVisualStyleBackColor = true;
            this.rad_RmParryBugRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmParryBugOn
            // 
            this.rad_RmParryBugOn.AutoSize = true;
            this.rad_RmParryBugOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RmParryBugOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmParryBugOn.Name = "rad_RmParryBugOn";
            this.rad_RmParryBugOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RmParryBugOn.TabIndex = 1;
            this.rad_RmParryBugOn.Text = "On";
            this.rad_RmParryBugOn.UseVisualStyleBackColor = true;
            this.rad_RmParryBugOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmParryBugOff
            // 
            this.rad_RmParryBugOff.AutoSize = true;
            this.rad_RmParryBugOff.Checked = true;
            this.rad_RmParryBugOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RmParryBugOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmParryBugOff.Name = "rad_RmParryBugOff";
            this.rad_RmParryBugOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RmParryBugOff.TabIndex = 0;
            this.rad_RmParryBugOff.TabStop = true;
            this.rad_RmParryBugOff.Text = "Off";
            this.rad_RmParryBugOff.UseVisualStyleBackColor = true;
            this.rad_RmParryBugOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.grp_EveryCat);
            this.tabPage7.Controls.Add(this.grp_FFightSprite);
            this.tabPage7.Controls.Add(this.grp_ChCats);
            this.tabPage7.Controls.Add(this.grp_RandNPC);
            this.tabPage7.Controls.Add(this.grp_RandSpriteCol);
            this.tabPage7.Controls.Add(this.grp_FHero);
            this.tabPage7.Controls.Add(this.grp_SlimeSnail);
            this.tabPage7.Controls.Add(this.grp_StdCase);
            this.tabPage7.Controls.Add(this.grp_GhostToCasket);
            this.tabPage7.Controls.Add(this.grp_RandHeroAge);
            this.tabPage7.Controls.Add(this.grp_LevelUpTxt);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(678, 422);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Cosmetic";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // grp_EveryCat
            // 
            this.grp_EveryCat.Controls.Add(this.rad_EveryCatRand);
            this.grp_EveryCat.Controls.Add(this.rad_EveryCatOn);
            this.grp_EveryCat.Controls.Add(this.rad_EveryCatOff);
            this.grp_EveryCat.Location = new System.Drawing.Point(173, 147);
            this.grp_EveryCat.Name = "grp_EveryCat";
            this.grp_EveryCat.Size = new System.Drawing.Size(163, 41);
            this.grp_EveryCat.TabIndex = 250;
            this.grp_EveryCat.TabStop = false;
            this.grp_EveryCat.Text = "Everyone is a Cat!";
            this.adjustments.SetToolTip(this.grp_EveryCat, "Changes all characters into cats.");
            this.grp_EveryCat.Visible = false;
            // 
            // rad_EveryCatRand
            // 
            this.rad_EveryCatRand.AutoSize = true;
            this.rad_EveryCatRand.Location = new System.Drawing.Point(96, 19);
            this.rad_EveryCatRand.Name = "rad_EveryCatRand";
            this.rad_EveryCatRand.Size = new System.Drawing.Size(65, 17);
            this.rad_EveryCatRand.TabIndex = 2;
            this.rad_EveryCatRand.Text = "Random";
            this.rad_EveryCatRand.UseVisualStyleBackColor = true;
            // 
            // rad_EveryCatOn
            // 
            this.rad_EveryCatOn.AutoSize = true;
            this.rad_EveryCatOn.Location = new System.Drawing.Point(51, 19);
            this.rad_EveryCatOn.Name = "rad_EveryCatOn";
            this.rad_EveryCatOn.Size = new System.Drawing.Size(39, 17);
            this.rad_EveryCatOn.TabIndex = 1;
            this.rad_EveryCatOn.Text = "On";
            this.rad_EveryCatOn.UseVisualStyleBackColor = true;
            // 
            // rad_EveryCatOff
            // 
            this.rad_EveryCatOff.AutoSize = true;
            this.rad_EveryCatOff.Checked = true;
            this.rad_EveryCatOff.Location = new System.Drawing.Point(6, 19);
            this.rad_EveryCatOff.Name = "rad_EveryCatOff";
            this.rad_EveryCatOff.Size = new System.Drawing.Size(39, 17);
            this.rad_EveryCatOff.TabIndex = 0;
            this.rad_EveryCatOff.TabStop = true;
            this.rad_EveryCatOff.Text = "Off";
            this.rad_EveryCatOff.UseVisualStyleBackColor = true;
            // 
            // grp_FFightSprite
            // 
            this.grp_FFightSprite.Controls.Add(this.rad_FFightSpriteRand);
            this.grp_FFightSprite.Controls.Add(this.rad_FFightSpriteOn);
            this.grp_FFightSprite.Controls.Add(this.rad_FFightSpriteOff);
            this.grp_FFightSprite.Location = new System.Drawing.Point(4, 147);
            this.grp_FFightSprite.Name = "grp_FFightSprite";
            this.grp_FFightSprite.Size = new System.Drawing.Size(163, 41);
            this.grp_FFightSprite.TabIndex = 249;
            this.grp_FFightSprite.TabStop = false;
            this.grp_FFightSprite.Text = "Female Fighter Sprite Fix";
            this.adjustments.SetToolTip(this.grp_FFightSprite, "Fixes Female Fighter right facing sprite.");
            // 
            // rad_FFightSpriteRand
            // 
            this.rad_FFightSpriteRand.AutoSize = true;
            this.rad_FFightSpriteRand.Location = new System.Drawing.Point(96, 19);
            this.rad_FFightSpriteRand.Name = "rad_FFightSpriteRand";
            this.rad_FFightSpriteRand.Size = new System.Drawing.Size(65, 17);
            this.rad_FFightSpriteRand.TabIndex = 2;
            this.rad_FFightSpriteRand.Text = "Random";
            this.rad_FFightSpriteRand.UseVisualStyleBackColor = true;
            // 
            // rad_FFightSpriteOn
            // 
            this.rad_FFightSpriteOn.AutoSize = true;
            this.rad_FFightSpriteOn.Location = new System.Drawing.Point(51, 19);
            this.rad_FFightSpriteOn.Name = "rad_FFightSpriteOn";
            this.rad_FFightSpriteOn.Size = new System.Drawing.Size(39, 17);
            this.rad_FFightSpriteOn.TabIndex = 1;
            this.rad_FFightSpriteOn.Text = "On";
            this.rad_FFightSpriteOn.UseVisualStyleBackColor = true;
            // 
            // rad_FFightSpriteOff
            // 
            this.rad_FFightSpriteOff.AutoSize = true;
            this.rad_FFightSpriteOff.Checked = true;
            this.rad_FFightSpriteOff.Location = new System.Drawing.Point(6, 19);
            this.rad_FFightSpriteOff.Name = "rad_FFightSpriteOff";
            this.rad_FFightSpriteOff.Size = new System.Drawing.Size(39, 17);
            this.rad_FFightSpriteOff.TabIndex = 0;
            this.rad_FFightSpriteOff.TabStop = true;
            this.rad_FFightSpriteOff.Text = "Off";
            this.rad_FFightSpriteOff.UseVisualStyleBackColor = true;
            // 
            // grp_ChCats
            // 
            this.grp_ChCats.Controls.Add(this.rad_ChCatsRand);
            this.grp_ChCats.Controls.Add(this.rad_ChCatsOn);
            this.grp_ChCats.Controls.Add(this.rad_ChCatsOff);
            this.grp_ChCats.Location = new System.Drawing.Point(508, 100);
            this.grp_ChCats.Name = "grp_ChCats";
            this.grp_ChCats.Size = new System.Drawing.Size(163, 41);
            this.grp_ChCats.TabIndex = 248;
            this.grp_ChCats.TabStop = false;
            this.grp_ChCats.Text = "Change Cats";
            this.adjustments.SetToolTip(this.grp_ChCats, "Changes cats into different animals.");
            // 
            // rad_ChCatsRand
            // 
            this.rad_ChCatsRand.AutoSize = true;
            this.rad_ChCatsRand.Location = new System.Drawing.Point(96, 19);
            this.rad_ChCatsRand.Name = "rad_ChCatsRand";
            this.rad_ChCatsRand.Size = new System.Drawing.Size(65, 17);
            this.rad_ChCatsRand.TabIndex = 2;
            this.rad_ChCatsRand.Text = "Random";
            this.rad_ChCatsRand.UseVisualStyleBackColor = true;
            // 
            // rad_ChCatsOn
            // 
            this.rad_ChCatsOn.AutoSize = true;
            this.rad_ChCatsOn.Location = new System.Drawing.Point(51, 19);
            this.rad_ChCatsOn.Name = "rad_ChCatsOn";
            this.rad_ChCatsOn.Size = new System.Drawing.Size(39, 17);
            this.rad_ChCatsOn.TabIndex = 1;
            this.rad_ChCatsOn.Text = "On";
            this.rad_ChCatsOn.UseVisualStyleBackColor = true;
            // 
            // rad_ChCatsOff
            // 
            this.rad_ChCatsOff.AutoSize = true;
            this.rad_ChCatsOff.Checked = true;
            this.rad_ChCatsOff.Location = new System.Drawing.Point(6, 19);
            this.rad_ChCatsOff.Name = "rad_ChCatsOff";
            this.rad_ChCatsOff.Size = new System.Drawing.Size(39, 17);
            this.rad_ChCatsOff.TabIndex = 0;
            this.rad_ChCatsOff.TabStop = true;
            this.rad_ChCatsOff.Text = "Off";
            this.rad_ChCatsOff.UseVisualStyleBackColor = true;
            // 
            // grp_RandNPC
            // 
            this.grp_RandNPC.Controls.Add(this.rad_RandNPCRand);
            this.grp_RandNPC.Controls.Add(this.rad_RandNPCOn);
            this.grp_RandNPC.Controls.Add(this.rad_RandNPCOff);
            this.grp_RandNPC.Location = new System.Drawing.Point(341, 100);
            this.grp_RandNPC.Name = "grp_RandNPC";
            this.grp_RandNPC.Size = new System.Drawing.Size(163, 41);
            this.grp_RandNPC.TabIndex = 247;
            this.grp_RandNPC.TabStop = false;
            this.grp_RandNPC.Text = "Randomize NPC Sprite";
            this.adjustments.SetToolTip(this.grp_RandNPC, "Randomizes NPC sprites into similar sprites from other Dragon Warrior games.");
            // 
            // rad_RandNPCRand
            // 
            this.rad_RandNPCRand.AutoSize = true;
            this.rad_RandNPCRand.Location = new System.Drawing.Point(96, 19);
            this.rad_RandNPCRand.Name = "rad_RandNPCRand";
            this.rad_RandNPCRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandNPCRand.TabIndex = 2;
            this.rad_RandNPCRand.Text = "Random";
            this.rad_RandNPCRand.UseVisualStyleBackColor = true;
            // 
            // rad_RandNPCOn
            // 
            this.rad_RandNPCOn.AutoSize = true;
            this.rad_RandNPCOn.Location = new System.Drawing.Point(51, 19);
            this.rad_RandNPCOn.Name = "rad_RandNPCOn";
            this.rad_RandNPCOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandNPCOn.TabIndex = 1;
            this.rad_RandNPCOn.Text = "On";
            this.rad_RandNPCOn.UseVisualStyleBackColor = true;
            // 
            // rad_RandNPCOff
            // 
            this.rad_RandNPCOff.AutoSize = true;
            this.rad_RandNPCOff.Checked = true;
            this.rad_RandNPCOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandNPCOff.Name = "rad_RandNPCOff";
            this.rad_RandNPCOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandNPCOff.TabIndex = 0;
            this.rad_RandNPCOff.TabStop = true;
            this.rad_RandNPCOff.Text = "Off";
            this.rad_RandNPCOff.UseVisualStyleBackColor = true;
            // 
            // grp_RandSpriteCol
            // 
            this.grp_RandSpriteCol.Controls.Add(this.rad_RandSpriteColRand);
            this.grp_RandSpriteCol.Controls.Add(this.rad_RandSpriteColOn);
            this.grp_RandSpriteCol.Controls.Add(this.rad_RandSpriteColOff);
            this.grp_RandSpriteCol.Location = new System.Drawing.Point(173, 100);
            this.grp_RandSpriteCol.Name = "grp_RandSpriteCol";
            this.grp_RandSpriteCol.Size = new System.Drawing.Size(163, 41);
            this.grp_RandSpriteCol.TabIndex = 246;
            this.grp_RandSpriteCol.TabStop = false;
            this.grp_RandSpriteCol.Text = "Randomize Sprite Colors";
            this.adjustments.SetToolTip(this.grp_RandSpriteCol, "Randomizes the color pallets of sprites.");
            // 
            // rad_RandSpriteColRand
            // 
            this.rad_RandSpriteColRand.AutoSize = true;
            this.rad_RandSpriteColRand.Location = new System.Drawing.Point(96, 19);
            this.rad_RandSpriteColRand.Name = "rad_RandSpriteColRand";
            this.rad_RandSpriteColRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandSpriteColRand.TabIndex = 2;
            this.rad_RandSpriteColRand.Text = "Random";
            this.rad_RandSpriteColRand.UseVisualStyleBackColor = true;
            // 
            // rad_RandSpriteColOn
            // 
            this.rad_RandSpriteColOn.AutoSize = true;
            this.rad_RandSpriteColOn.Location = new System.Drawing.Point(51, 19);
            this.rad_RandSpriteColOn.Name = "rad_RandSpriteColOn";
            this.rad_RandSpriteColOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandSpriteColOn.TabIndex = 1;
            this.rad_RandSpriteColOn.Text = "On";
            this.rad_RandSpriteColOn.UseVisualStyleBackColor = true;
            // 
            // rad_RandSpriteColOff
            // 
            this.rad_RandSpriteColOff.AutoSize = true;
            this.rad_RandSpriteColOff.Checked = true;
            this.rad_RandSpriteColOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandSpriteColOff.Name = "rad_RandSpriteColOff";
            this.rad_RandSpriteColOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandSpriteColOff.TabIndex = 0;
            this.rad_RandSpriteColOff.TabStop = true;
            this.rad_RandSpriteColOff.Text = "Off";
            this.rad_RandSpriteColOff.UseVisualStyleBackColor = true;
            // 
            // grp_FHero
            // 
            this.grp_FHero.Controls.Add(this.rad_FHeroRand);
            this.grp_FHero.Controls.Add(this.rad_FHeroOn);
            this.grp_FHero.Controls.Add(this.rad_FHeroOff);
            this.grp_FHero.Location = new System.Drawing.Point(4, 100);
            this.grp_FHero.Name = "grp_FHero";
            this.grp_FHero.Size = new System.Drawing.Size(163, 41);
            this.grp_FHero.TabIndex = 245;
            this.grp_FHero.TabStop = false;
            this.grp_FHero.Text = "Female Hero Sprite";
            this.adjustments.SetToolTip(this.grp_FHero, "Changes the Hero\'s sprite into female sprites from other Dragon Warrior games.");
            // 
            // rad_FHeroRand
            // 
            this.rad_FHeroRand.AutoSize = true;
            this.rad_FHeroRand.Location = new System.Drawing.Point(96, 19);
            this.rad_FHeroRand.Name = "rad_FHeroRand";
            this.rad_FHeroRand.Size = new System.Drawing.Size(65, 17);
            this.rad_FHeroRand.TabIndex = 2;
            this.rad_FHeroRand.Text = "Random";
            this.rad_FHeroRand.UseVisualStyleBackColor = true;
            // 
            // rad_FHeroOn
            // 
            this.rad_FHeroOn.AutoSize = true;
            this.rad_FHeroOn.Location = new System.Drawing.Point(51, 19);
            this.rad_FHeroOn.Name = "rad_FHeroOn";
            this.rad_FHeroOn.Size = new System.Drawing.Size(39, 17);
            this.rad_FHeroOn.TabIndex = 1;
            this.rad_FHeroOn.Text = "On";
            this.rad_FHeroOn.UseVisualStyleBackColor = true;
            // 
            // rad_FHeroOff
            // 
            this.rad_FHeroOff.AutoSize = true;
            this.rad_FHeroOff.Checked = true;
            this.rad_FHeroOff.Location = new System.Drawing.Point(6, 19);
            this.rad_FHeroOff.Name = "rad_FHeroOff";
            this.rad_FHeroOff.Size = new System.Drawing.Size(39, 17);
            this.rad_FHeroOff.TabIndex = 0;
            this.rad_FHeroOff.TabStop = true;
            this.rad_FHeroOff.Text = "Off";
            this.rad_FHeroOff.UseVisualStyleBackColor = true;
            // 
            // grp_SlimeSnail
            // 
            this.grp_SlimeSnail.Controls.Add(this.rad_SlimeSnailRand);
            this.grp_SlimeSnail.Controls.Add(this.rad_SlimeSnailOn);
            this.grp_SlimeSnail.Controls.Add(this.rad_SlimeSnailOff);
            this.grp_SlimeSnail.Location = new System.Drawing.Point(173, 51);
            this.grp_SlimeSnail.Name = "grp_SlimeSnail";
            this.grp_SlimeSnail.Size = new System.Drawing.Size(163, 41);
            this.grp_SlimeSnail.TabIndex = 244;
            this.grp_SlimeSnail.TabStop = false;
            this.grp_SlimeSnail.Text = "Fix Slime Snail";
            this.adjustments.SetToolTip(this.grp_SlimeSnail, "Fixes Slime Snaii to Slime Snail.");
            // 
            // rad_SlimeSnailRand
            // 
            this.rad_SlimeSnailRand.AutoSize = true;
            this.rad_SlimeSnailRand.Location = new System.Drawing.Point(96, 19);
            this.rad_SlimeSnailRand.Name = "rad_SlimeSnailRand";
            this.rad_SlimeSnailRand.Size = new System.Drawing.Size(65, 17);
            this.rad_SlimeSnailRand.TabIndex = 2;
            this.rad_SlimeSnailRand.Text = "Random";
            this.rad_SlimeSnailRand.UseVisualStyleBackColor = true;
            // 
            // rad_SlimeSnailOn
            // 
            this.rad_SlimeSnailOn.AutoSize = true;
            this.rad_SlimeSnailOn.Location = new System.Drawing.Point(51, 19);
            this.rad_SlimeSnailOn.Name = "rad_SlimeSnailOn";
            this.rad_SlimeSnailOn.Size = new System.Drawing.Size(39, 17);
            this.rad_SlimeSnailOn.TabIndex = 1;
            this.rad_SlimeSnailOn.Text = "On";
            this.rad_SlimeSnailOn.UseVisualStyleBackColor = true;
            // 
            // rad_SlimeSnailOff
            // 
            this.rad_SlimeSnailOff.AutoSize = true;
            this.rad_SlimeSnailOff.Checked = true;
            this.rad_SlimeSnailOff.Location = new System.Drawing.Point(6, 19);
            this.rad_SlimeSnailOff.Name = "rad_SlimeSnailOff";
            this.rad_SlimeSnailOff.Size = new System.Drawing.Size(39, 17);
            this.rad_SlimeSnailOff.TabIndex = 0;
            this.rad_SlimeSnailOff.TabStop = true;
            this.rad_SlimeSnailOff.Text = "Off";
            this.rad_SlimeSnailOff.UseVisualStyleBackColor = true;
            // 
            // grp_StdCase
            // 
            this.grp_StdCase.Controls.Add(this.rad_StdCaseRand);
            this.grp_StdCase.Controls.Add(this.rad_StdCaseOn);
            this.grp_StdCase.Controls.Add(this.rad_StdCaseOff);
            this.grp_StdCase.Location = new System.Drawing.Point(4, 51);
            this.grp_StdCase.Name = "grp_StdCase";
            this.grp_StdCase.Size = new System.Drawing.Size(163, 41);
            this.grp_StdCase.TabIndex = 243;
            this.grp_StdCase.TabStop = false;
            this.grp_StdCase.Text = "Standard Case Menus";
            this.adjustments.SetToolTip(this.grp_StdCase, "Changes all caps menus and text to standard casing.");
            // 
            // rad_StdCaseRand
            // 
            this.rad_StdCaseRand.AutoSize = true;
            this.rad_StdCaseRand.Location = new System.Drawing.Point(96, 19);
            this.rad_StdCaseRand.Name = "rad_StdCaseRand";
            this.rad_StdCaseRand.Size = new System.Drawing.Size(65, 17);
            this.rad_StdCaseRand.TabIndex = 2;
            this.rad_StdCaseRand.Text = "Random";
            this.rad_StdCaseRand.UseVisualStyleBackColor = true;
            // 
            // rad_StdCaseOn
            // 
            this.rad_StdCaseOn.AutoSize = true;
            this.rad_StdCaseOn.Location = new System.Drawing.Point(51, 19);
            this.rad_StdCaseOn.Name = "rad_StdCaseOn";
            this.rad_StdCaseOn.Size = new System.Drawing.Size(39, 17);
            this.rad_StdCaseOn.TabIndex = 1;
            this.rad_StdCaseOn.Text = "On";
            this.rad_StdCaseOn.UseVisualStyleBackColor = true;
            // 
            // rad_StdCaseOff
            // 
            this.rad_StdCaseOff.AutoSize = true;
            this.rad_StdCaseOff.Checked = true;
            this.rad_StdCaseOff.Location = new System.Drawing.Point(6, 19);
            this.rad_StdCaseOff.Name = "rad_StdCaseOff";
            this.rad_StdCaseOff.Size = new System.Drawing.Size(39, 17);
            this.rad_StdCaseOff.TabIndex = 0;
            this.rad_StdCaseOff.TabStop = true;
            this.rad_StdCaseOff.Text = "Off";
            this.rad_StdCaseOff.UseVisualStyleBackColor = true;
            // 
            // grp_GhostToCasket
            // 
            this.grp_GhostToCasket.Controls.Add(this.rad_GhostToCasketRand);
            this.grp_GhostToCasket.Controls.Add(this.rad_GhostToCasketOn);
            this.grp_GhostToCasket.Controls.Add(this.rad_GhostToCasketOff);
            this.grp_GhostToCasket.Location = new System.Drawing.Point(341, 4);
            this.grp_GhostToCasket.Name = "grp_GhostToCasket";
            this.grp_GhostToCasket.Size = new System.Drawing.Size(163, 41);
            this.grp_GhostToCasket.TabIndex = 242;
            this.grp_GhostToCasket.TabStop = false;
            this.grp_GhostToCasket.Text = "Change Ghosts to Caskets";
            this.adjustments.SetToolTip(this.grp_GhostToCasket, "Changes dead party members into caskets instead of ghosts.");
            // 
            // rad_GhostToCasketRand
            // 
            this.rad_GhostToCasketRand.AutoSize = true;
            this.rad_GhostToCasketRand.Location = new System.Drawing.Point(96, 19);
            this.rad_GhostToCasketRand.Name = "rad_GhostToCasketRand";
            this.rad_GhostToCasketRand.Size = new System.Drawing.Size(65, 17);
            this.rad_GhostToCasketRand.TabIndex = 2;
            this.rad_GhostToCasketRand.Text = "Random";
            this.rad_GhostToCasketRand.UseVisualStyleBackColor = true;
            this.rad_GhostToCasketRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GhostToCasketOn
            // 
            this.rad_GhostToCasketOn.AutoSize = true;
            this.rad_GhostToCasketOn.Location = new System.Drawing.Point(51, 19);
            this.rad_GhostToCasketOn.Name = "rad_GhostToCasketOn";
            this.rad_GhostToCasketOn.Size = new System.Drawing.Size(39, 17);
            this.rad_GhostToCasketOn.TabIndex = 1;
            this.rad_GhostToCasketOn.Text = "On";
            this.rad_GhostToCasketOn.UseVisualStyleBackColor = true;
            this.rad_GhostToCasketOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GhostToCasketOff
            // 
            this.rad_GhostToCasketOff.AutoSize = true;
            this.rad_GhostToCasketOff.Checked = true;
            this.rad_GhostToCasketOff.Location = new System.Drawing.Point(6, 19);
            this.rad_GhostToCasketOff.Name = "rad_GhostToCasketOff";
            this.rad_GhostToCasketOff.Size = new System.Drawing.Size(39, 17);
            this.rad_GhostToCasketOff.TabIndex = 0;
            this.rad_GhostToCasketOff.TabStop = true;
            this.rad_GhostToCasketOff.Text = "Off";
            this.rad_GhostToCasketOff.UseVisualStyleBackColor = true;
            this.rad_GhostToCasketOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandHeroAge
            // 
            this.grp_RandHeroAge.Controls.Add(this.rad_RandHeroAgeRand);
            this.grp_RandHeroAge.Controls.Add(this.rad_RandHeroAgeOn);
            this.grp_RandHeroAge.Controls.Add(this.rad_RandHeroAgeOff);
            this.grp_RandHeroAge.Location = new System.Drawing.Point(173, 4);
            this.grp_RandHeroAge.Name = "grp_RandHeroAge";
            this.grp_RandHeroAge.Size = new System.Drawing.Size(163, 41);
            this.grp_RandHeroAge.TabIndex = 241;
            this.grp_RandHeroAge.TabStop = false;
            this.grp_RandHeroAge.Text = "Randomize Hero\'s Age";
            this.adjustments.SetToolTip(this.grp_RandHeroAge, "Randomizes Hero\'s age and changes sprite accordingly.");
            // 
            // rad_RandHeroAgeRand
            // 
            this.rad_RandHeroAgeRand.AutoSize = true;
            this.rad_RandHeroAgeRand.Location = new System.Drawing.Point(96, 19);
            this.rad_RandHeroAgeRand.Name = "rad_RandHeroAgeRand";
            this.rad_RandHeroAgeRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandHeroAgeRand.TabIndex = 2;
            this.rad_RandHeroAgeRand.Text = "Random";
            this.rad_RandHeroAgeRand.UseVisualStyleBackColor = true;
            this.rad_RandHeroAgeRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandHeroAgeOn
            // 
            this.rad_RandHeroAgeOn.AutoSize = true;
            this.rad_RandHeroAgeOn.Location = new System.Drawing.Point(51, 19);
            this.rad_RandHeroAgeOn.Name = "rad_RandHeroAgeOn";
            this.rad_RandHeroAgeOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandHeroAgeOn.TabIndex = 1;
            this.rad_RandHeroAgeOn.Text = "On";
            this.rad_RandHeroAgeOn.UseVisualStyleBackColor = true;
            this.rad_RandHeroAgeOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandHeroAgeOff
            // 
            this.rad_RandHeroAgeOff.AutoSize = true;
            this.rad_RandHeroAgeOff.Checked = true;
            this.rad_RandHeroAgeOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandHeroAgeOff.Name = "rad_RandHeroAgeOff";
            this.rad_RandHeroAgeOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandHeroAgeOff.TabIndex = 0;
            this.rad_RandHeroAgeOff.TabStop = true;
            this.rad_RandHeroAgeOff.Text = "Off";
            this.rad_RandHeroAgeOff.UseVisualStyleBackColor = true;
            this.rad_RandHeroAgeOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_LevelUpTxt
            // 
            this.grp_LevelUpTxt.Controls.Add(this.rad_LevelUpTxtRand);
            this.grp_LevelUpTxt.Controls.Add(this.rad_LevelUpTxtOn);
            this.grp_LevelUpTxt.Controls.Add(this.rad_LevelUpTxtOff);
            this.grp_LevelUpTxt.Location = new System.Drawing.Point(4, 4);
            this.grp_LevelUpTxt.Name = "grp_LevelUpTxt";
            this.grp_LevelUpTxt.Size = new System.Drawing.Size(163, 41);
            this.grp_LevelUpTxt.TabIndex = 240;
            this.grp_LevelUpTxt.TabStop = false;
            this.grp_LevelUpTxt.Text = "Change Level Up Text";
            this.adjustments.SetToolTip(this.grp_LevelUpTxt, "Changes Level Up text to include character name.");
            // 
            // rad_LevelUpTxtRand
            // 
            this.rad_LevelUpTxtRand.AutoSize = true;
            this.rad_LevelUpTxtRand.Location = new System.Drawing.Point(96, 19);
            this.rad_LevelUpTxtRand.Name = "rad_LevelUpTxtRand";
            this.rad_LevelUpTxtRand.Size = new System.Drawing.Size(65, 17);
            this.rad_LevelUpTxtRand.TabIndex = 2;
            this.rad_LevelUpTxtRand.Text = "Random";
            this.rad_LevelUpTxtRand.UseVisualStyleBackColor = true;
            this.rad_LevelUpTxtRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LevelUpTxtOn
            // 
            this.rad_LevelUpTxtOn.AutoSize = true;
            this.rad_LevelUpTxtOn.Location = new System.Drawing.Point(51, 19);
            this.rad_LevelUpTxtOn.Name = "rad_LevelUpTxtOn";
            this.rad_LevelUpTxtOn.Size = new System.Drawing.Size(39, 17);
            this.rad_LevelUpTxtOn.TabIndex = 1;
            this.rad_LevelUpTxtOn.Text = "On";
            this.rad_LevelUpTxtOn.UseVisualStyleBackColor = true;
            this.rad_LevelUpTxtOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LevelUpTxtOff
            // 
            this.rad_LevelUpTxtOff.AutoSize = true;
            this.rad_LevelUpTxtOff.Checked = true;
            this.rad_LevelUpTxtOff.Location = new System.Drawing.Point(6, 19);
            this.rad_LevelUpTxtOff.Name = "rad_LevelUpTxtOff";
            this.rad_LevelUpTxtOff.Size = new System.Drawing.Size(39, 17);
            this.rad_LevelUpTxtOff.TabIndex = 0;
            this.rad_LevelUpTxtOff.TabStop = true;
            this.rad_LevelUpTxtOff.Text = "Off";
            this.rad_LevelUpTxtOff.UseVisualStyleBackColor = true;
            this.rad_LevelUpTxtOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Flags";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(43, 195);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(312, 20);
            this.txtFlags.TabIndex = 31;
            this.txtFlags.Leave += new System.EventHandler(this.determineChecks);
            // 
            // chk_GenCompareFile
            // 
            this.chk_GenCompareFile.AutoSize = true;
            this.chk_GenCompareFile.Location = new System.Drawing.Point(220, 632);
            this.chk_GenCompareFile.Name = "chk_GenCompareFile";
            this.chk_GenCompareFile.Size = new System.Drawing.Size(134, 17);
            this.chk_GenCompareFile.TabIndex = 260;
            this.chk_GenCompareFile.Text = "Generate Compare File";
            this.adjustments.SetToolTip(this.chk_GenCompareFile, "Generates compare file on build. This will adjust randomization to avoid spoilers" +
        " (item locations, monster stats/spells.)");
            this.chk_GenCompareFile.UseVisualStyleBackColor = true;
            this.chk_GenCompareFile.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_GenIslandsMonstersZones
            // 
            this.chk_GenIslandsMonstersZones.AutoSize = true;
            this.chk_GenIslandsMonstersZones.Location = new System.Drawing.Point(372, 632);
            this.chk_GenIslandsMonstersZones.Name = "chk_GenIslandsMonstersZones";
            this.chk_GenIslandsMonstersZones.Size = new System.Drawing.Size(229, 17);
            this.chk_GenIslandsMonstersZones.TabIndex = 261;
            this.chk_GenIslandsMonstersZones.Text = "Generate islands, monsters, and zones files";
            this.adjustments.SetToolTip(this.chk_GenIslandsMonstersZones, "Speeds up how quickly text is displayed. Does not affect pauses in text.");
            this.chk_GenIslandsMonstersZones.UseVisualStyleBackColor = true;
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
            this.grpFlags.Controls.Add(this.rad_EverythingRand);
            this.grpFlags.Controls.Add(this.rad_FastVanilla);
            this.grpFlags.Controls.Add(this.optSotWFlags);
            this.grpFlags.Controls.Add(this.opt_JustForFun);
            this.grpFlags.Controls.Add(this.optTradSotWFlags);
            this.grpFlags.Controls.Add(this.optManualFlags);
            this.grpFlags.Location = new System.Drawing.Point(7, 144);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Size = new System.Drawing.Size(683, 41);
            this.grpFlags.TabIndex = 20;
            this.grpFlags.TabStop = false;
            this.grpFlags.Text = "Preset Flags";
            // 
            // rad_EverythingRand
            // 
            this.rad_EverythingRand.AutoSize = true;
            this.rad_EverythingRand.Location = new System.Drawing.Point(482, 19);
            this.rad_EverythingRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EverythingRand.Name = "rad_EverythingRand";
            this.rad_EverythingRand.Size = new System.Drawing.Size(125, 17);
            this.rad_EverythingRand.TabIndex = 0;
            this.rad_EverythingRand.Text = "Everything\'s Random";
            this.rad_EverythingRand.UseVisualStyleBackColor = true;
            this.rad_EverythingRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_FastVanilla
            // 
            this.rad_FastVanilla.AutoSize = true;
            this.rad_FastVanilla.Location = new System.Drawing.Point(97, 19);
            this.rad_FastVanilla.Margin = new System.Windows.Forms.Padding(2);
            this.rad_FastVanilla.Name = "rad_FastVanilla";
            this.rad_FastVanilla.Size = new System.Drawing.Size(79, 17);
            this.rad_FastVanilla.TabIndex = 0;
            this.rad_FastVanilla.Text = "Fast Vanilla";
            this.rad_FastVanilla.UseVisualStyleBackColor = true;
            this.rad_FastVanilla.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optSotWFlags
            // 
            this.optSotWFlags.AutoSize = true;
            this.optSotWFlags.Location = new System.Drawing.Point(179, 19);
            this.optSotWFlags.Margin = new System.Windows.Forms.Padding(2);
            this.optSotWFlags.Name = "optSotWFlags";
            this.optSotWFlags.Size = new System.Drawing.Size(80, 17);
            this.optSotWFlags.TabIndex = 0;
            this.optSotWFlags.Text = "SotW Flags";
            this.optSotWFlags.UseVisualStyleBackColor = true;
            this.optSotWFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // opt_JustForFun
            // 
            this.opt_JustForFun.AutoSize = true;
            this.opt_JustForFun.Location = new System.Drawing.Point(395, 19);
            this.opt_JustForFun.Margin = new System.Windows.Forms.Padding(2);
            this.opt_JustForFun.Name = "opt_JustForFun";
            this.opt_JustForFun.Size = new System.Drawing.Size(83, 17);
            this.opt_JustForFun.TabIndex = 0;
            this.opt_JustForFun.Text = "Just For Fun";
            this.opt_JustForFun.UseVisualStyleBackColor = true;
            this.opt_JustForFun.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optTradSotWFlags
            // 
            this.optTradSotWFlags.AutoSize = true;
            this.optTradSotWFlags.Location = new System.Drawing.Point(261, 19);
            this.optTradSotWFlags.Name = "optTradSotWFlags";
            this.optTradSotWFlags.Size = new System.Drawing.Size(132, 17);
            this.optTradSotWFlags.TabIndex = 0;
            this.optTradSotWFlags.Text = "Traditional SotW Flags";
            this.optTradSotWFlags.UseVisualStyleBackColor = true;
            this.optTradSotWFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optManualFlags
            // 
            this.optManualFlags.AutoSize = true;
            this.optManualFlags.Checked = true;
            this.optManualFlags.Location = new System.Drawing.Point(6, 19);
            this.optManualFlags.Name = "optManualFlags";
            this.optManualFlags.Size = new System.Drawing.Size(88, 17);
            this.optManualFlags.TabIndex = 0;
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
            this.txtSeed.Location = new System.Drawing.Point(396, 195);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(185, 20);
            this.txtSeed.TabIndex = 33;
            // 
            // btn_chksumHash
            // 
            this.btn_chksumHash.Location = new System.Drawing.Point(563, 113);
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
            this.ClientSize = new System.Drawing.Size(698, 659);
            this.Controls.Add(this.btn_chksumHash);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grpFlags);
            this.Controls.Add(this.chk_GenIslandsMonstersZones);
            this.Controls.Add(this.chk_GenCompareFile);
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
            this.grp_RandStats.ResumeLayout(false);
            this.grp_RandStats.PerformLayout();
            this.grp_EncRate.ResumeLayout(false);
            this.grp_EncRate.PerformLayout();
            this.grp_GoldGain.ResumeLayout(false);
            this.grp_GoldGain.PerformLayout();
            this.grp_ExpGain.ResumeLayout(false);
            this.grp_ExpGain.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.grp_AddToItemShop.ResumeLayout(false);
            this.grp_AddToItemShop.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grp_Class.ResumeLayout(false);
            this.grp_ClassInclude.ResumeLayout(false);
            this.grp_ClassInclude.PerformLayout();
            this.grp_Class3.ResumeLayout(false);
            this.grp_Class3.PerformLayout();
            this.grp_Class2.ResumeLayout(false);
            this.grp_Class2.PerformLayout();
            this.grp_Class1.ResumeLayout(false);
            this.grp_Class1.PerformLayout();
            this.grp_Gender.ResumeLayout(false);
            this.grp_Gender3.ResumeLayout(false);
            this.grp_Gender3.PerformLayout();
            this.grp_Gender2.ResumeLayout(false);
            this.grp_Gender2.PerformLayout();
            this.grp_Gender1.ResumeLayout(false);
            this.grp_Gender1.PerformLayout();
            this.grp_ChName.ResumeLayout(false);
            this.grp_ChName3.ResumeLayout(false);
            this.grp_ChName3.PerformLayout();
            this.grp_ChName2.ResumeLayout(false);
            this.grp_ChName2.PerformLayout();
            this.grp_ChName1.ResumeLayout(false);
            this.grp_ChName1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.grp_FixHeroSpell.ResumeLayout(false);
            this.grp_FixHeroSpell.PerformLayout();
            this.grp_RmParryBug.ResumeLayout(false);
            this.grp_RmParryBug.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.grp_EveryCat.ResumeLayout(false);
            this.grp_EveryCat.PerformLayout();
            this.grp_FFightSprite.ResumeLayout(false);
            this.grp_FFightSprite.PerformLayout();
            this.grp_ChCats.ResumeLayout(false);
            this.grp_ChCats.PerformLayout();
            this.grp_RandNPC.ResumeLayout(false);
            this.grp_RandNPC.PerformLayout();
            this.grp_RandSpriteCol.ResumeLayout(false);
            this.grp_RandSpriteCol.PerformLayout();
            this.grp_FHero.ResumeLayout(false);
            this.grp_FHero.PerformLayout();
            this.grp_SlimeSnail.ResumeLayout(false);
            this.grp_SlimeSnail.PerformLayout();
            this.grp_StdCase.ResumeLayout(false);
            this.grp_StdCase.PerformLayout();
            this.grp_GhostToCasket.ResumeLayout(false);
            this.grp_GhostToCasket.PerformLayout();
            this.grp_RandHeroAge.ResumeLayout(false);
            this.grp_RandHeroAge.PerformLayout();
            this.grp_LevelUpTxt.ResumeLayout(false);
            this.grp_LevelUpTxt.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_ChName2;
        private System.Windows.Forms.TextBox txt_ChName3;
        private System.Windows.Forms.TextBox txt_ChName1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.ToolTip adjustments;
		private System.Windows.Forms.Label lblNewChecksum;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbo_Class3;
		private System.Windows.Forms.ComboBox cbo_Class2;
		private System.Windows.Forms.ComboBox cbo_Class1;
		private System.Windows.Forms.ComboBox cbo_Gender3;
		private System.Windows.Forms.ComboBox cbo_Gender2;
		private System.Windows.Forms.ComboBox cbo_Gender1;
        private System.Windows.Forms.CheckBox chk_RandMerchant;
        private System.Windows.Forms.CheckBox chk_RandFighter;
        private System.Windows.Forms.CheckBox chk_RandWizard;
        private System.Windows.Forms.CheckBox chk_RandPilgrim;
        private System.Windows.Forms.CheckBox chk_RandSoldier;
        private System.Windows.Forms.CheckBox chk_RandHero;
        private System.Windows.Forms.CheckBox chk_RandSage;
        private System.Windows.Forms.CheckBox chk_RandGoofOff;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox chk_GenCompareFile;
        private System.Windows.Forms.CheckBox chk_GenIslandsMonstersZones;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox grpFlags;
        private System.Windows.Forms.RadioButton optTradSotWFlags;
        private System.Windows.Forms.RadioButton optManualFlags;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.RadioButton opt_JustForFun;
        private System.Windows.Forms.Button btn_chksumHash;
        private System.Windows.Forms.RadioButton optSotWFlags;
        private System.Windows.Forms.GroupBox grp_ExpGain;
        private System.Windows.Forms.GroupBox grp_GoldGain;
        private System.Windows.Forms.RadioButton rad_ExpGain500;
        private System.Windows.Forms.RadioButton rad_ExpGain400;
        private System.Windows.Forms.RadioButton rad_ExpGain300;
        private System.Windows.Forms.RadioButton rad_ExpGain200;
        private System.Windows.Forms.RadioButton rad_ExpGain150;
        private System.Windows.Forms.RadioButton rad_ExpGain100;
        private System.Windows.Forms.RadioButton rad_ExpGain50;
        private System.Windows.Forms.RadioButton rad_ExpGain25;
        private System.Windows.Forms.RadioButton rad_ExpGain0;
        private System.Windows.Forms.RadioButton rad_ExpGainRand;
        private System.Windows.Forms.RadioButton rad_ExpGain1000;
        private System.Windows.Forms.RadioButton rad_ExpGain750;
        private System.Windows.Forms.RadioButton rad_GoldGain1;
        private System.Windows.Forms.GroupBox grp_EncRate;
        private System.Windows.Forms.RadioButton rad_EncRate75;
        private System.Windows.Forms.RadioButton rad_EncRate50;
        private System.Windows.Forms.RadioButton rad_EncRate25;
        private System.Windows.Forms.RadioButton rad_EncRate0;
        private System.Windows.Forms.RadioButton rad_GoldGainRand;
        private System.Windows.Forms.RadioButton rad_GoldGain200;
        private System.Windows.Forms.RadioButton rad_GoldGain100;
        private System.Windows.Forms.RadioButton rad_GoldGain50;
        private System.Windows.Forms.RadioButton rad_EncRateRand;
        private System.Windows.Forms.RadioButton rad_EncRate400;
        private System.Windows.Forms.RadioButton rad_EncRate300;
        private System.Windows.Forms.RadioButton rad_EncRate200;
        private System.Windows.Forms.RadioButton rad_EncRate150;
        private System.Windows.Forms.RadioButton rad_EncRate100;
        private System.Windows.Forms.RadioButton rad_GoldGain150;
        private System.Windows.Forms.GroupBox grp_FixHeroSpell;
        private System.Windows.Forms.RadioButton rad_FixHeroSpellRand;
        private System.Windows.Forms.RadioButton rad_FixHeroSpellOn;
        private System.Windows.Forms.RadioButton rad_FixHeroSpellOff;
        private System.Windows.Forms.GroupBox grp_RmParryBug;
        private System.Windows.Forms.RadioButton rad_RmParryBugRand;
        private System.Windows.Forms.RadioButton rad_RmParryBugOn;
        private System.Windows.Forms.RadioButton rad_RmParryBugOff;
        private System.Windows.Forms.GroupBox grp_AddToItemShop;
        private System.Windows.Forms.GroupBox grp_ChName;
        private System.Windows.Forms.GroupBox grp_ChName3;
        private System.Windows.Forms.RadioButton rad_ChName3Rand;
        private System.Windows.Forms.RadioButton rad_ChName3Manual;
        private System.Windows.Forms.RadioButton rad_ChName3Off;
        private System.Windows.Forms.GroupBox grp_ChName2;
        private System.Windows.Forms.RadioButton rad_ChName2Rand;
        private System.Windows.Forms.RadioButton rad_ChName2Manual;
        private System.Windows.Forms.RadioButton rad_ChName2Off;
        private System.Windows.Forms.GroupBox grp_ChName1;
        private System.Windows.Forms.RadioButton rad_ChName1Rand;
        private System.Windows.Forms.RadioButton rad_ChName1Manual;
        private System.Windows.Forms.RadioButton rad_ChName1Off;
        private System.Windows.Forms.GroupBox grp_Class;
        private System.Windows.Forms.GroupBox grp_Class3;
        private System.Windows.Forms.RadioButton rad_Class3Rand;
        private System.Windows.Forms.RadioButton rad_Class3Manual;
        private System.Windows.Forms.RadioButton rad_Class3Off;
        private System.Windows.Forms.GroupBox grp_Class2;
        private System.Windows.Forms.RadioButton rad_Class2Rand;
        private System.Windows.Forms.RadioButton rad_Class2Manual;
        private System.Windows.Forms.RadioButton rad_Class2Off;
        private System.Windows.Forms.GroupBox grp_Class1;
        private System.Windows.Forms.RadioButton rad_Class1Rand;
        private System.Windows.Forms.RadioButton rad_Class1Manual;
        private System.Windows.Forms.RadioButton rad_Class1Off;
        private System.Windows.Forms.GroupBox grp_Gender;
        private System.Windows.Forms.GroupBox grp_Gender3;
        private System.Windows.Forms.RadioButton rad_Gender3Rand;
        private System.Windows.Forms.RadioButton rad_Gender3Manual;
        private System.Windows.Forms.RadioButton rad_Gender3Off;
        private System.Windows.Forms.GroupBox grp_Gender2;
        private System.Windows.Forms.RadioButton rad_Gender2Rand;
        private System.Windows.Forms.RadioButton rad_Gender2Manual;
        private System.Windows.Forms.RadioButton rad_Gender2Off;
        private System.Windows.Forms.GroupBox grp_Gender1;
        private System.Windows.Forms.RadioButton rad_Gender1Rand;
        private System.Windows.Forms.RadioButton rad_Gender1Manual;
        private System.Windows.Forms.RadioButton rad_Gender1Off;
        private System.Windows.Forms.GroupBox grp_ClassInclude;
        private System.Windows.Forms.GroupBox grp_RandStats;
        private System.Windows.Forms.RadioButton rad_RandStatsRand;
        private System.Windows.Forms.RadioButton rad_RandStatsLud;
        private System.Windows.Forms.RadioButton rad_RandStatsRid;
        private System.Windows.Forms.RadioButton rad_RandStatsSilly;
        private System.Windows.Forms.RadioButton rad_RandStatsOff;
        private System.Windows.Forms.GroupBox grp_LevelUpTxt;
        private System.Windows.Forms.RadioButton rad_LevelUpTxtRand;
        private System.Windows.Forms.RadioButton rad_LevelUpTxtOn;
        private System.Windows.Forms.RadioButton rad_LevelUpTxtOff;
        private System.Windows.Forms.GroupBox grp_GhostToCasket;
        private System.Windows.Forms.RadioButton rad_GhostToCasketRand;
        private System.Windows.Forms.RadioButton rad_GhostToCasketOn;
        private System.Windows.Forms.RadioButton rad_GhostToCasketOff;
        private System.Windows.Forms.GroupBox grp_RandHeroAge;
        private System.Windows.Forms.RadioButton rad_RandHeroAgeRand;
        private System.Windows.Forms.RadioButton rad_RandHeroAgeOn;
        private System.Windows.Forms.RadioButton rad_RandHeroAgeOff;
        private System.Windows.Forms.GroupBox grp_ChCats;
        private System.Windows.Forms.RadioButton rad_ChCatsRand;
        private System.Windows.Forms.RadioButton rad_ChCatsOn;
        private System.Windows.Forms.RadioButton rad_ChCatsOff;
        private System.Windows.Forms.GroupBox grp_RandNPC;
        private System.Windows.Forms.RadioButton rad_RandNPCRand;
        private System.Windows.Forms.RadioButton rad_RandNPCOn;
        private System.Windows.Forms.RadioButton rad_RandNPCOff;
        private System.Windows.Forms.GroupBox grp_RandSpriteCol;
        private System.Windows.Forms.RadioButton rad_RandSpriteColRand;
        private System.Windows.Forms.RadioButton rad_RandSpriteColOn;
        private System.Windows.Forms.RadioButton rad_RandSpriteColOff;
        private System.Windows.Forms.GroupBox grp_FHero;
        private System.Windows.Forms.RadioButton rad_FHeroRand;
        private System.Windows.Forms.RadioButton rad_FHeroOn;
        private System.Windows.Forms.RadioButton rad_FHeroOff;
        private System.Windows.Forms.GroupBox grp_SlimeSnail;
        private System.Windows.Forms.RadioButton rad_SlimeSnailRand;
        private System.Windows.Forms.RadioButton rad_SlimeSnailOn;
        private System.Windows.Forms.RadioButton rad_SlimeSnailOff;
        private System.Windows.Forms.GroupBox grp_StdCase;
        private System.Windows.Forms.RadioButton rad_StdCaseRand;
        private System.Windows.Forms.RadioButton rad_StdCaseOn;
        private System.Windows.Forms.RadioButton rad_StdCaseOff;
        private System.Windows.Forms.GroupBox grp_EveryCat;
        private System.Windows.Forms.RadioButton rad_EveryCatRand;
        private System.Windows.Forms.RadioButton rad_EveryCatOn;
        private System.Windows.Forms.RadioButton rad_EveryCatOff;
        private System.Windows.Forms.GroupBox grp_FFightSprite;
        private System.Windows.Forms.RadioButton rad_FFightSpriteRand;
        private System.Windows.Forms.RadioButton rad_FFightSpriteOn;
        private System.Windows.Forms.RadioButton rad_FFightSpriteOff;
        private System.Windows.Forms.RadioButton rad_FastVanilla;
        private System.Windows.Forms.RadioButton rad_EverythingRand;
        private System.Windows.Forms.CheckBox tchk_IncBatSpeed;
        private System.Windows.Forms.CheckBox tchk_SpeedUpText;
        private System.Windows.Forms.CheckBox tchk_SpeedUpMenus;
        private System.Windows.Forms.CheckBox tchk_RmManips;
        private System.Windows.Forms.CheckBox tchk_RandStartGold;
        private System.Windows.Forms.CheckBox tchk_Cod;
        private System.Windows.Forms.CheckBox tchk_DispEqPower;
        private System.Windows.Forms.CheckBox tchk_RandSpellLearn;
        private System.Windows.Forms.CheckBox tchk_RandSpellStr;
        private System.Windows.Forms.CheckBox tchk_NonMPJobs;
        private System.Windows.Forms.CheckBox tchk_DoubleAttack;
        private System.Windows.Forms.CheckBox tchk_NoOrb;
        private System.Windows.Forms.CheckBox tchk_PartyItems;
        private System.Windows.Forms.CheckBox tchk_FourJobFiesta;
        private System.Windows.Forms.CheckBox tchk_InvisNPC;
        private System.Windows.Forms.CheckBox tchk_SagesStone;
        private System.Windows.Forms.CheckBox tchk_HUAStone;
        private System.Windows.Forms.CheckBox tchk_SoHRoLEff;
        private System.Windows.Forms.CheckBox tchk_BigSoHRoL;
        private System.Windows.Forms.CheckBox tchk_InvisShipBird;
        private System.Windows.Forms.CheckBox tchk_RandMaps;
        private System.Windows.Forms.CheckBox tchk_SmallMaps;
        private System.Windows.Forms.CheckBox tchk_RandMonstZones;
        private System.Windows.Forms.CheckBox tchk_RandTowns;
        private System.Windows.Forms.CheckBox tchk_RandCaveTower;
        private System.Windows.Forms.CheckBox tchk_RandShrines;
        private System.Windows.Forms.CheckBox tchk_RmMountLancel;
        private System.Windows.Forms.CheckBox tchk_RmMountNecro;
        private System.Windows.Forms.CheckBox tchk_RmMountBaramos;
        private System.Windows.Forms.CheckBox tchk_RmMountDQC;
        private System.Windows.Forms.CheckBox tchk_RmMoatCharlock;
        private System.Windows.Forms.CheckBox tchk_NoNewTown;
        private System.Windows.Forms.CheckBox tchk_RmNoEncounter;
        private System.Windows.Forms.CheckBox tchk_RandExp;
        private System.Windows.Forms.CheckBox tchk_RandGold;
        private System.Windows.Forms.CheckBox tchk_RandDrops;
        private System.Windows.Forms.CheckBox tchk_RmDupItemPool;
        private System.Windows.Forms.CheckBox tchk_RandEnAttPat;
        private System.Windows.Forms.CheckBox tchk_RmMetalRun;
        private System.Windows.Forms.CheckBox tchk_AddRemakeEq;
        private System.Windows.Forms.CheckBox tchk_RandEqPower;
        private System.Windows.Forms.CheckBox tchk_VanEqVals;
        private System.Windows.Forms.CheckBox tchk_RemStartCap;
        private System.Windows.Forms.CheckBox tchk_RmFigherPen;
        private System.Windows.Forms.CheckBox tchk_RandEqClass;
        private System.Windows.Forms.CheckBox tchk_AdjEqPrices;
        private System.Windows.Forms.CheckBox tchk_RandTreasures;
        private System.Windows.Forms.CheckBox tchk_AddGoldClaw;
        private System.Windows.Forms.CheckBox tchk_GreenSilvOrb;
        private System.Windows.Forms.CheckBox tchk_RmRedKey;
        private System.Windows.Forms.CheckBox tchk_RandItemEff;
        private System.Windows.Forms.CheckBox tchk_RandItemShop;
        private System.Windows.Forms.CheckBox tchk_RandWeapShop;
        private System.Windows.Forms.CheckBox tchk_RandInnPrice;
        private System.Windows.Forms.CheckBox tchk_SellKeyItems;
        private System.Windows.Forms.CheckBox tchk_AnimalSuit;
        private System.Windows.Forms.CheckBox tchk_AcornsOfLife;
        private System.Windows.Forms.CheckBox tchk_StrSeed;
        private System.Windows.Forms.CheckBox tchk_AgiSeed;
        private System.Windows.Forms.CheckBox tchk_IntSeed;
        private System.Windows.Forms.CheckBox tchk_LuckSeed;
        private System.Windows.Forms.CheckBox tchk_VitSeed;
        private System.Windows.Forms.CheckBox tchk_SilverHarp;
        private System.Windows.Forms.CheckBox tchk_EchoingFlute;
        private System.Windows.Forms.CheckBox tchk_LampOfDarkness;
        private System.Windows.Forms.CheckBox tchk_RingOfLife;
        private System.Windows.Forms.CheckBox tchk_ShoesOfHappiness;
        private System.Windows.Forms.CheckBox tchk_MeteoriteArmband;
        private System.Windows.Forms.CheckBox tchk_PoisonMothPowder;
        private System.Windows.Forms.CheckBox tchk_LeafOfTheWorldTree;
        private System.Windows.Forms.CheckBox tchk_StoneOfLife;
        private System.Windows.Forms.CheckBox tchk_WizardsRing;
        private System.Windows.Forms.CheckBox tchk_BookOfSatori;
    }
}

