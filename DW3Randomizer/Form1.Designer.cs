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
            this.grp_Big = new System.Windows.Forms.GroupBox();
            this.rad_BigRand = new System.Windows.Forms.RadioButton();
            this.rad_BigOn = new System.Windows.Forms.RadioButton();
            this.rad_BigOff = new System.Windows.Forms.RadioButton();
            this.grp_SoHRoLEff = new System.Windows.Forms.GroupBox();
            this.rad_SoHRoLEffRand = new System.Windows.Forms.RadioButton();
            this.rad_SoHRoLEffOn = new System.Windows.Forms.RadioButton();
            this.rad_SoHRoLEffOff = new System.Windows.Forms.RadioButton();
            this.grp_HUAStone = new System.Windows.Forms.GroupBox();
            this.rad_HUAStoneRand = new System.Windows.Forms.RadioButton();
            this.rad_HUAStoneOn = new System.Windows.Forms.RadioButton();
            this.rad_HUAStoneOff = new System.Windows.Forms.RadioButton();
            this.grp_RandSageStone = new System.Windows.Forms.GroupBox();
            this.rad_RandSageStoneRand = new System.Windows.Forms.RadioButton();
            this.rad_RandSageStoneOn = new System.Windows.Forms.RadioButton();
            this.rad_RandSageStoneOff = new System.Windows.Forms.RadioButton();
            this.grp_InvisNPC = new System.Windows.Forms.GroupBox();
            this.rad_InvisNPCRand = new System.Windows.Forms.RadioButton();
            this.rad_InvisNPCOn = new System.Windows.Forms.RadioButton();
            this.rad_InvisNPCOff = new System.Windows.Forms.RadioButton();
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
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.grp_Continents = new System.Windows.Forms.GroupBox();
            this.grp_RandTown = new System.Windows.Forms.GroupBox();
            this.rad_RandTownsRand = new System.Windows.Forms.RadioButton();
            this.rad_RandTownsOn = new System.Windows.Forms.RadioButton();
            this.rad_RandTownsOff = new System.Windows.Forms.RadioButton();
            this.grp_RandCaves = new System.Windows.Forms.GroupBox();
            this.rad_RandCavesRand = new System.Windows.Forms.RadioButton();
            this.rad_RandCavesOn = new System.Windows.Forms.RadioButton();
            this.rad_RandCavesOff = new System.Windows.Forms.RadioButton();
            this.grp_RandShrine = new System.Windows.Forms.GroupBox();
            this.rad_RandShrinesRand = new System.Windows.Forms.RadioButton();
            this.rad_RandShrinesOn = new System.Windows.Forms.RadioButton();
            this.rad_RandShrinesOff = new System.Windows.Forms.RadioButton();
            this.grp_RmMountains = new System.Windows.Forms.GroupBox();
            this.grp_LancelCave = new System.Windows.Forms.GroupBox();
            this.rad_LancelCaveRand = new System.Windows.Forms.RadioButton();
            this.rad_LancelCaveOn = new System.Windows.Forms.RadioButton();
            this.rad_LancelCaveOff = new System.Windows.Forms.RadioButton();
            this.grp_CaveOfNecro = new System.Windows.Forms.GroupBox();
            this.rad_CaveOfNecroRand = new System.Windows.Forms.RadioButton();
            this.rad_CaveOfNecroOn = new System.Windows.Forms.RadioButton();
            this.rad_CaveOfNecroOff = new System.Windows.Forms.RadioButton();
            this.grp_BaramosCast = new System.Windows.Forms.GroupBox();
            this.rad_BaramosCastRand = new System.Windows.Forms.RadioButton();
            this.rad_BaramosCastOn = new System.Windows.Forms.RadioButton();
            this.rad_BaramosCastOff = new System.Windows.Forms.RadioButton();
            this.grp_DrgQnCast = new System.Windows.Forms.GroupBox();
            this.rad_DrgQnCastRand = new System.Windows.Forms.RadioButton();
            this.rad_DrgQnCastOn = new System.Windows.Forms.RadioButton();
            this.rad_DrgQnCastOff = new System.Windows.Forms.RadioButton();
            this.grp_NoNewTown = new System.Windows.Forms.GroupBox();
            this.rad_NoNewTownRand = new System.Windows.Forms.RadioButton();
            this.rad_NoNewTownOn = new System.Windows.Forms.RadioButton();
            this.rad_NoNewTownOff = new System.Windows.Forms.RadioButton();
            this.grp_Charlock = new System.Windows.Forms.GroupBox();
            this.rad_CharlockRand = new System.Windows.Forms.RadioButton();
            this.rad_CharlockOn = new System.Windows.Forms.RadioButton();
            this.rad_CharlockOff = new System.Windows.Forms.RadioButton();
            this.grp_DisAlefGlitch = new System.Windows.Forms.GroupBox();
            this.rad_DisAlefGlitchRand = new System.Windows.Forms.RadioButton();
            this.rad_DisAlefGlitchOn = new System.Windows.Forms.RadioButton();
            this.rad_DisAlefGlitchOff = new System.Windows.Forms.RadioButton();
            this.grp_RandMonstZone = new System.Windows.Forms.GroupBox();
            this.rad_RandMonstZoneRand = new System.Windows.Forms.RadioButton();
            this.rad_RandMonstZoneOn = new System.Windows.Forms.RadioButton();
            this.rad_RandMonstZoneOff = new System.Windows.Forms.RadioButton();
            this.grp_SmallMap = new System.Windows.Forms.GroupBox();
            this.rad_SmallMapRand = new System.Windows.Forms.RadioButton();
            this.rad_SmallMapOn = new System.Windows.Forms.RadioButton();
            this.rad_SmallMapOff = new System.Windows.Forms.RadioButton();
            this.grp_RandMap = new System.Windows.Forms.GroupBox();
            this.rad_RandMapsRand = new System.Windows.Forms.RadioButton();
            this.rad_RandMapsOn = new System.Windows.Forms.RadioButton();
            this.rad_RandMapsOff = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grp_RmMetalRun = new System.Windows.Forms.GroupBox();
            this.rad_RmMetalRunRand = new System.Windows.Forms.RadioButton();
            this.rad_RmMetalRunOn = new System.Windows.Forms.RadioButton();
            this.rad_RmMetalRunOff = new System.Windows.Forms.RadioButton();
            this.grp_RandEnePat = new System.Windows.Forms.GroupBox();
            this.rad_RandEnePatRand = new System.Windows.Forms.RadioButton();
            this.rad_RandEnePatOn = new System.Windows.Forms.RadioButton();
            this.rad_RandEnePatOff = new System.Windows.Forms.RadioButton();
            this.grp_RmDupDrop = new System.Windows.Forms.GroupBox();
            this.rad_RmDupDropRand = new System.Windows.Forms.RadioButton();
            this.rad_RmDupDropOn = new System.Windows.Forms.RadioButton();
            this.rad_RmDupDropOff = new System.Windows.Forms.RadioButton();
            this.grp_RandGold = new System.Windows.Forms.GroupBox();
            this.rad_RandGoldRand = new System.Windows.Forms.RadioButton();
            this.rad_RandGoldOn = new System.Windows.Forms.RadioButton();
            this.rad_RandGoldOff = new System.Windows.Forms.RadioButton();
            this.grp_RandDrop = new System.Windows.Forms.GroupBox();
            this.rad_RandDropRand = new System.Windows.Forms.RadioButton();
            this.rad_RandDropOn = new System.Windows.Forms.RadioButton();
            this.rad_RandDropOff = new System.Windows.Forms.RadioButton();
            this.grp_RandExp = new System.Windows.Forms.GroupBox();
            this.rad_RandExpRand = new System.Windows.Forms.RadioButton();
            this.rad_RandExpOn = new System.Windows.Forms.RadioButton();
            this.rad_RandExpOff = new System.Windows.Forms.RadioButton();
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
            this.grp_FixHeroSpell = new System.Windows.Forms.GroupBox();
            this.rad_FixHeroSpellRand = new System.Windows.Forms.RadioButton();
            this.rad_FixHeroSpellOn = new System.Windows.Forms.RadioButton();
            this.rad_FixHeroSpellOff = new System.Windows.Forms.RadioButton();
            this.grp_RmParryBug = new System.Windows.Forms.GroupBox();
            this.rad_RmParryBugRand = new System.Windows.Forms.RadioButton();
            this.rad_RmParryBugOn = new System.Windows.Forms.RadioButton();
            this.rad_RmParryBugOff = new System.Windows.Forms.RadioButton();
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
            this.grp_EncRate.SuspendLayout();
            this.grp_GoldGain.SuspendLayout();
            this.grp_ExpGain.SuspendLayout();
            this.grp_Big.SuspendLayout();
            this.grp_SoHRoLEff.SuspendLayout();
            this.grp_HUAStone.SuspendLayout();
            this.grp_RandSageStone.SuspendLayout();
            this.grp_InvisNPC.SuspendLayout();
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
            this.grp_Continents.SuspendLayout();
            this.grp_RandTown.SuspendLayout();
            this.grp_RandCaves.SuspendLayout();
            this.grp_RandShrine.SuspendLayout();
            this.grp_RmMountains.SuspendLayout();
            this.grp_LancelCave.SuspendLayout();
            this.grp_CaveOfNecro.SuspendLayout();
            this.grp_BaramosCast.SuspendLayout();
            this.grp_DrgQnCast.SuspendLayout();
            this.grp_NoNewTown.SuspendLayout();
            this.grp_Charlock.SuspendLayout();
            this.grp_DisAlefGlitch.SuspendLayout();
            this.grp_RandMonstZone.SuspendLayout();
            this.grp_SmallMap.SuspendLayout();
            this.grp_RandMap.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grp_RmMetalRun.SuspendLayout();
            this.grp_RandEnePat.SuspendLayout();
            this.grp_RmDupDrop.SuspendLayout();
            this.grp_RandGold.SuspendLayout();
            this.grp_RandDrop.SuspendLayout();
            this.grp_RandExp.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpMonsterStat.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.grp_FixHeroSpell.SuspendLayout();
            this.grp_RmParryBug.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.grpFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(176, 15);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(674, 26);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.Leave += new System.EventHandler(this.txtFileName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DW3 ROM File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(860, 15);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 35);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "DW3 ROM Checksum";
            // 
            // lblSHAChecksum
            // 
            this.lblSHAChecksum.AutoSize = true;
            this.lblSHAChecksum.Location = new System.Drawing.Point(176, 120);
            this.lblSHAChecksum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSHAChecksum.Name = "lblSHAChecksum";
            this.lblSHAChecksum.Size = new System.Drawing.Size(369, 20);
            this.lblSHAChecksum.TabIndex = 11;
            this.lblSHAChecksum.Text = "????????????????????????????????????????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Required Checksum";
            // 
            // lblReqChecksum
            // 
            this.lblReqChecksum.AutoSize = true;
            this.lblReqChecksum.Location = new System.Drawing.Point(176, 85);
            this.lblReqChecksum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReqChecksum.Name = "lblReqChecksum";
            this.lblReqChecksum.Size = new System.Drawing.Size(363, 20);
            this.lblReqChecksum.TabIndex = 8;
            this.lblReqChecksum.Text = "a867549bad1cba4cd6f6dd51743e78596b982bd8";
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(907, 898);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(116, 35);
            this.btnRandomize.TabIndex = 250;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(860, 85);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(116, 35);
            this.btnCompare.TabIndex = 9;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Visible = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Seed";
            // 
            // btnCompareBrowse
            // 
            this.btnCompareBrowse.Location = new System.Drawing.Point(860, 49);
            this.btnCompareBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompareBrowse.Name = "btnCompareBrowse";
            this.btnCompareBrowse.Size = new System.Drawing.Size(116, 35);
            this.btnCompareBrowse.TabIndex = 6;
            this.btnCompareBrowse.Text = "Browse";
            this.btnCompareBrowse.UseVisualStyleBackColor = true;
            this.btnCompareBrowse.Click += new System.EventHandler(this.btnCompareBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Output ROM File";
            this.adjustments.SetToolTip(this.label5, "This can be used to compare an existing ROM file as well.");
            // 
            // txtCompare
            // 
            this.txtCompare.Location = new System.Drawing.Point(176, 49);
            this.txtCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompare.Name = "txtCompare";
            this.txtCompare.Size = new System.Drawing.Size(674, 26);
            this.txtCompare.TabIndex = 5;
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.Location = new System.Drawing.Point(860, 315);
            this.btnNewSeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(116, 35);
            this.btnNewSeed.TabIndex = 34;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = true;
            this.btnNewSeed.Click += new System.EventHandler(this.btnNewSeed_Click);
            // 
            // lblIntensityDesc
            // 
            this.lblIntensityDesc.Location = new System.Drawing.Point(20, 578);
            this.lblIntensityDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntensityDesc.Name = "lblIntensityDesc";
            this.lblIntensityDesc.Size = new System.Drawing.Size(600, 28);
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
            this.tabControl1.Location = new System.Drawing.Point(10, 355);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 539);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grp_EncRate);
            this.tabPage1.Controls.Add(this.grp_GoldGain);
            this.tabPage1.Controls.Add(this.grp_ExpGain);
            this.tabPage1.Controls.Add(this.grp_Big);
            this.tabPage1.Controls.Add(this.grp_SoHRoLEff);
            this.tabPage1.Controls.Add(this.grp_HUAStone);
            this.tabPage1.Controls.Add(this.grp_RandSageStone);
            this.tabPage1.Controls.Add(this.grp_InvisNPC);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adjustments";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.grp_EncRate.Location = new System.Drawing.Point(6, 144);
            this.grp_EncRate.Name = "grp_EncRate";
            this.grp_EncRate.Size = new System.Drawing.Size(1005, 63);
            this.grp_EncRate.TabIndex = 91;
            this.grp_EncRate.TabStop = false;
            this.grp_EncRate.Text = "Encounter Rate";
            this.adjustments.SetToolTip(this.grp_EncRate, "Changes the encounter rate for random battles");
            // 
            // rad_EncRateRand
            // 
            this.rad_EncRateRand.AutoSize = true;
            this.rad_EncRateRand.Location = new System.Drawing.Point(691, 32);
            this.rad_EncRateRand.Name = "rad_EncRateRand";
            this.rad_EncRateRand.Size = new System.Drawing.Size(95, 24);
            this.rad_EncRateRand.TabIndex = 9;
            this.rad_EncRateRand.Text = "Random";
            this.rad_EncRateRand.UseVisualStyleBackColor = true;
            this.rad_EncRateRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate400
            // 
            this.rad_EncRate400.AutoSize = true;
            this.rad_EncRate400.Location = new System.Drawing.Point(610, 32);
            this.rad_EncRate400.Name = "rad_EncRate400";
            this.rad_EncRate400.Size = new System.Drawing.Size(75, 24);
            this.rad_EncRate400.TabIndex = 8;
            this.rad_EncRate400.Text = "400%";
            this.rad_EncRate400.UseVisualStyleBackColor = true;
            this.rad_EncRate400.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate300
            // 
            this.rad_EncRate300.AutoSize = true;
            this.rad_EncRate300.Location = new System.Drawing.Point(529, 32);
            this.rad_EncRate300.Name = "rad_EncRate300";
            this.rad_EncRate300.Size = new System.Drawing.Size(75, 24);
            this.rad_EncRate300.TabIndex = 7;
            this.rad_EncRate300.Text = "300%";
            this.rad_EncRate300.UseVisualStyleBackColor = true;
            this.rad_EncRate300.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate200
            // 
            this.rad_EncRate200.AutoSize = true;
            this.rad_EncRate200.Location = new System.Drawing.Point(448, 32);
            this.rad_EncRate200.Name = "rad_EncRate200";
            this.rad_EncRate200.Size = new System.Drawing.Size(75, 24);
            this.rad_EncRate200.TabIndex = 6;
            this.rad_EncRate200.Text = "200%";
            this.rad_EncRate200.UseVisualStyleBackColor = true;
            this.rad_EncRate200.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate150
            // 
            this.rad_EncRate150.AutoSize = true;
            this.rad_EncRate150.Location = new System.Drawing.Point(367, 32);
            this.rad_EncRate150.Name = "rad_EncRate150";
            this.rad_EncRate150.Size = new System.Drawing.Size(75, 24);
            this.rad_EncRate150.TabIndex = 5;
            this.rad_EncRate150.Text = "150%";
            this.rad_EncRate150.UseVisualStyleBackColor = true;
            this.rad_EncRate150.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate100
            // 
            this.rad_EncRate100.AutoSize = true;
            this.rad_EncRate100.Checked = true;
            this.rad_EncRate100.Location = new System.Drawing.Point(286, 32);
            this.rad_EncRate100.Name = "rad_EncRate100";
            this.rad_EncRate100.Size = new System.Drawing.Size(75, 24);
            this.rad_EncRate100.TabIndex = 4;
            this.rad_EncRate100.TabStop = true;
            this.rad_EncRate100.Text = "100%";
            this.rad_EncRate100.UseVisualStyleBackColor = true;
            this.rad_EncRate100.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate75
            // 
            this.rad_EncRate75.AutoSize = true;
            this.rad_EncRate75.Location = new System.Drawing.Point(214, 32);
            this.rad_EncRate75.Name = "rad_EncRate75";
            this.rad_EncRate75.Size = new System.Drawing.Size(66, 24);
            this.rad_EncRate75.TabIndex = 3;
            this.rad_EncRate75.Text = "75%";
            this.rad_EncRate75.UseVisualStyleBackColor = true;
            this.rad_EncRate75.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate50
            // 
            this.rad_EncRate50.AutoSize = true;
            this.rad_EncRate50.Location = new System.Drawing.Point(144, 32);
            this.rad_EncRate50.Name = "rad_EncRate50";
            this.rad_EncRate50.Size = new System.Drawing.Size(66, 24);
            this.rad_EncRate50.TabIndex = 2;
            this.rad_EncRate50.Text = "50%";
            this.rad_EncRate50.UseVisualStyleBackColor = true;
            this.rad_EncRate50.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate25
            // 
            this.rad_EncRate25.AutoSize = true;
            this.rad_EncRate25.Location = new System.Drawing.Point(72, 32);
            this.rad_EncRate25.Name = "rad_EncRate25";
            this.rad_EncRate25.Size = new System.Drawing.Size(66, 24);
            this.rad_EncRate25.TabIndex = 1;
            this.rad_EncRate25.Text = "25%";
            this.rad_EncRate25.UseVisualStyleBackColor = true;
            this.rad_EncRate25.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EncRate0
            // 
            this.rad_EncRate0.AutoSize = true;
            this.rad_EncRate0.Location = new System.Drawing.Point(9, 32);
            this.rad_EncRate0.Name = "rad_EncRate0";
            this.rad_EncRate0.Size = new System.Drawing.Size(57, 24);
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
            this.grp_GoldGain.Location = new System.Drawing.Point(6, 75);
            this.grp_GoldGain.Name = "grp_GoldGain";
            this.grp_GoldGain.Size = new System.Drawing.Size(1005, 63);
            this.grp_GoldGain.TabIndex = 90;
            this.grp_GoldGain.TabStop = false;
            this.grp_GoldGain.Text = "Gold Gains";
            this.adjustments.SetToolTip(this.grp_GoldGain, "Changes the amount of gold earned when defeating monsters");
            // 
            // rad_GoldGain150
            // 
            this.rad_GoldGain150.AutoSize = true;
            this.rad_GoldGain150.Location = new System.Drawing.Point(377, 25);
            this.rad_GoldGain150.Name = "rad_GoldGain150";
            this.rad_GoldGain150.Size = new System.Drawing.Size(75, 24);
            this.rad_GoldGain150.TabIndex = 3;
            this.rad_GoldGain150.TabStop = true;
            this.rad_GoldGain150.Text = "150%";
            this.rad_GoldGain150.UseVisualStyleBackColor = true;
            this.rad_GoldGain150.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGainRand
            // 
            this.rad_GoldGainRand.AutoSize = true;
            this.rad_GoldGainRand.Location = new System.Drawing.Point(539, 25);
            this.rad_GoldGainRand.Name = "rad_GoldGainRand";
            this.rad_GoldGainRand.Size = new System.Drawing.Size(95, 24);
            this.rad_GoldGainRand.TabIndex = 5;
            this.rad_GoldGainRand.Text = "Random";
            this.rad_GoldGainRand.UseVisualStyleBackColor = true;
            this.rad_GoldGainRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGain200
            // 
            this.rad_GoldGain200.AutoSize = true;
            this.rad_GoldGain200.Location = new System.Drawing.Point(458, 25);
            this.rad_GoldGain200.Name = "rad_GoldGain200";
            this.rad_GoldGain200.Size = new System.Drawing.Size(75, 24);
            this.rad_GoldGain200.TabIndex = 4;
            this.rad_GoldGain200.Text = "200%";
            this.rad_GoldGain200.UseVisualStyleBackColor = true;
            this.rad_GoldGain200.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGain100
            // 
            this.rad_GoldGain100.AutoSize = true;
            this.rad_GoldGain100.Checked = true;
            this.rad_GoldGain100.Location = new System.Drawing.Point(296, 25);
            this.rad_GoldGain100.Name = "rad_GoldGain100";
            this.rad_GoldGain100.Size = new System.Drawing.Size(75, 24);
            this.rad_GoldGain100.TabIndex = 2;
            this.rad_GoldGain100.TabStop = true;
            this.rad_GoldGain100.Text = "100%";
            this.rad_GoldGain100.UseVisualStyleBackColor = true;
            this.rad_GoldGain100.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGain50
            // 
            this.rad_GoldGain50.AutoSize = true;
            this.rad_GoldGain50.Location = new System.Drawing.Point(224, 25);
            this.rad_GoldGain50.Name = "rad_GoldGain50";
            this.rad_GoldGain50.Size = new System.Drawing.Size(66, 24);
            this.rad_GoldGain50.TabIndex = 1;
            this.rad_GoldGain50.Text = "50%";
            this.rad_GoldGain50.UseVisualStyleBackColor = true;
            this.rad_GoldGain50.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_GoldGain1
            // 
            this.rad_GoldGain1.AutoSize = true;
            this.rad_GoldGain1.Location = new System.Drawing.Point(9, 25);
            this.rad_GoldGain1.Name = "rad_GoldGain1";
            this.rad_GoldGain1.Size = new System.Drawing.Size(208, 24);
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
            this.grp_ExpGain.Location = new System.Drawing.Point(6, 6);
            this.grp_ExpGain.Name = "grp_ExpGain";
            this.grp_ExpGain.Size = new System.Drawing.Size(1005, 63);
            this.grp_ExpGain.TabIndex = 89;
            this.grp_ExpGain.TabStop = false;
            this.grp_ExpGain.Text = "Experience Gains";
            this.adjustments.SetToolTip(this.grp_ExpGain, "Changes the amount of experience earned when defeating monsters");
            // 
            // rad_ExpGainRand
            // 
            this.rad_ExpGainRand.AutoSize = true;
            this.rad_ExpGainRand.Location = new System.Drawing.Point(871, 25);
            this.rad_ExpGainRand.Name = "rad_ExpGainRand";
            this.rad_ExpGainRand.Size = new System.Drawing.Size(95, 24);
            this.rad_ExpGainRand.TabIndex = 11;
            this.rad_ExpGainRand.Text = "Random";
            this.rad_ExpGainRand.UseVisualStyleBackColor = true;
            this.rad_ExpGainRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain1000
            // 
            this.rad_ExpGain1000.AutoSize = true;
            this.rad_ExpGain1000.Location = new System.Drawing.Point(781, 25);
            this.rad_ExpGain1000.Name = "rad_ExpGain1000";
            this.rad_ExpGain1000.Size = new System.Drawing.Size(84, 24);
            this.rad_ExpGain1000.TabIndex = 10;
            this.rad_ExpGain1000.Text = "1000%";
            this.rad_ExpGain1000.UseVisualStyleBackColor = true;
            this.rad_ExpGain1000.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain750
            // 
            this.rad_ExpGain750.AutoSize = true;
            this.rad_ExpGain750.Location = new System.Drawing.Point(700, 25);
            this.rad_ExpGain750.Name = "rad_ExpGain750";
            this.rad_ExpGain750.Size = new System.Drawing.Size(75, 24);
            this.rad_ExpGain750.TabIndex = 9;
            this.rad_ExpGain750.Text = "750%";
            this.rad_ExpGain750.UseVisualStyleBackColor = true;
            this.rad_ExpGain750.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain500
            // 
            this.rad_ExpGain500.AutoSize = true;
            this.rad_ExpGain500.Location = new System.Drawing.Point(619, 25);
            this.rad_ExpGain500.Name = "rad_ExpGain500";
            this.rad_ExpGain500.Size = new System.Drawing.Size(75, 24);
            this.rad_ExpGain500.TabIndex = 8;
            this.rad_ExpGain500.Text = "500%";
            this.rad_ExpGain500.UseVisualStyleBackColor = true;
            this.rad_ExpGain500.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain400
            // 
            this.rad_ExpGain400.AutoSize = true;
            this.rad_ExpGain400.Location = new System.Drawing.Point(538, 25);
            this.rad_ExpGain400.Name = "rad_ExpGain400";
            this.rad_ExpGain400.Size = new System.Drawing.Size(75, 24);
            this.rad_ExpGain400.TabIndex = 7;
            this.rad_ExpGain400.Text = "400%";
            this.rad_ExpGain400.UseVisualStyleBackColor = true;
            this.rad_ExpGain400.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain300
            // 
            this.rad_ExpGain300.AutoSize = true;
            this.rad_ExpGain300.Location = new System.Drawing.Point(457, 25);
            this.rad_ExpGain300.Name = "rad_ExpGain300";
            this.rad_ExpGain300.Size = new System.Drawing.Size(75, 24);
            this.rad_ExpGain300.TabIndex = 6;
            this.rad_ExpGain300.Text = "300%";
            this.rad_ExpGain300.UseVisualStyleBackColor = true;
            this.rad_ExpGain300.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain200
            // 
            this.rad_ExpGain200.AutoSize = true;
            this.rad_ExpGain200.Location = new System.Drawing.Point(376, 25);
            this.rad_ExpGain200.Name = "rad_ExpGain200";
            this.rad_ExpGain200.Size = new System.Drawing.Size(75, 24);
            this.rad_ExpGain200.TabIndex = 5;
            this.rad_ExpGain200.Text = "200%";
            this.rad_ExpGain200.UseVisualStyleBackColor = true;
            this.rad_ExpGain200.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain150
            // 
            this.rad_ExpGain150.AutoSize = true;
            this.rad_ExpGain150.Location = new System.Drawing.Point(295, 25);
            this.rad_ExpGain150.Name = "rad_ExpGain150";
            this.rad_ExpGain150.Size = new System.Drawing.Size(75, 24);
            this.rad_ExpGain150.TabIndex = 4;
            this.rad_ExpGain150.Text = "150%";
            this.rad_ExpGain150.UseVisualStyleBackColor = true;
            this.rad_ExpGain150.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain100
            // 
            this.rad_ExpGain100.AutoSize = true;
            this.rad_ExpGain100.Checked = true;
            this.rad_ExpGain100.Location = new System.Drawing.Point(214, 25);
            this.rad_ExpGain100.Name = "rad_ExpGain100";
            this.rad_ExpGain100.Size = new System.Drawing.Size(75, 24);
            this.rad_ExpGain100.TabIndex = 3;
            this.rad_ExpGain100.TabStop = true;
            this.rad_ExpGain100.Text = "100%";
            this.rad_ExpGain100.UseVisualStyleBackColor = true;
            this.rad_ExpGain100.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain50
            // 
            this.rad_ExpGain50.AutoSize = true;
            this.rad_ExpGain50.Location = new System.Drawing.Point(142, 25);
            this.rad_ExpGain50.Name = "rad_ExpGain50";
            this.rad_ExpGain50.Size = new System.Drawing.Size(66, 24);
            this.rad_ExpGain50.TabIndex = 2;
            this.rad_ExpGain50.Text = "50%";
            this.rad_ExpGain50.UseVisualStyleBackColor = true;
            this.rad_ExpGain50.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain25
            // 
            this.rad_ExpGain25.AutoSize = true;
            this.rad_ExpGain25.Location = new System.Drawing.Point(72, 25);
            this.rad_ExpGain25.Name = "rad_ExpGain25";
            this.rad_ExpGain25.Size = new System.Drawing.Size(66, 24);
            this.rad_ExpGain25.TabIndex = 1;
            this.rad_ExpGain25.Text = "25%";
            this.rad_ExpGain25.UseVisualStyleBackColor = true;
            this.rad_ExpGain25.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ExpGain0
            // 
            this.rad_ExpGain0.AutoSize = true;
            this.rad_ExpGain0.Location = new System.Drawing.Point(9, 25);
            this.rad_ExpGain0.Name = "rad_ExpGain0";
            this.rad_ExpGain0.Size = new System.Drawing.Size(57, 24);
            this.rad_ExpGain0.TabIndex = 0;
            this.rad_ExpGain0.Text = "0%";
            this.rad_ExpGain0.UseVisualStyleBackColor = true;
            this.rad_ExpGain0.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_Big
            // 
            this.grp_Big.Controls.Add(this.rad_BigRand);
            this.grp_Big.Controls.Add(this.rad_BigOn);
            this.grp_Big.Controls.Add(this.rad_BigOff);
            this.grp_Big.Location = new System.Drawing.Point(765, 432);
            this.grp_Big.Name = "grp_Big";
            this.grp_Big.Size = new System.Drawing.Size(244, 63);
            this.grp_Big.TabIndex = 88;
            this.grp_Big.TabStop = false;
            this.grp_Big.Text = "Big SoH and RoL Effect";
            this.adjustments.SetToolTip(this.grp_Big, "Randomizes Shoes of Happiness and Ring of Life Effect between 11 and 256 per step" +
        "");
            // 
            // rad_BigRand
            // 
            this.rad_BigRand.AutoSize = true;
            this.rad_BigRand.Location = new System.Drawing.Point(129, 29);
            this.rad_BigRand.Name = "rad_BigRand";
            this.rad_BigRand.Size = new System.Drawing.Size(95, 24);
            this.rad_BigRand.TabIndex = 2;
            this.rad_BigRand.Text = "Random";
            this.rad_BigRand.UseVisualStyleBackColor = true;
            this.rad_BigRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_BigOn
            // 
            this.rad_BigOn.AutoSize = true;
            this.rad_BigOn.Location = new System.Drawing.Point(68, 29);
            this.rad_BigOn.Name = "rad_BigOn";
            this.rad_BigOn.Size = new System.Drawing.Size(55, 24);
            this.rad_BigOn.TabIndex = 1;
            this.rad_BigOn.Text = "On";
            this.rad_BigOn.UseVisualStyleBackColor = true;
            this.rad_BigOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_BigOff
            // 
            this.rad_BigOff.AutoSize = true;
            this.rad_BigOff.Checked = true;
            this.rad_BigOff.Location = new System.Drawing.Point(6, 29);
            this.rad_BigOff.Name = "rad_BigOff";
            this.rad_BigOff.Size = new System.Drawing.Size(56, 24);
            this.rad_BigOff.TabIndex = 0;
            this.rad_BigOff.TabStop = true;
            this.rad_BigOff.Text = "Off";
            this.rad_BigOff.UseVisualStyleBackColor = true;
            this.rad_BigOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_SoHRoLEff
            // 
            this.grp_SoHRoLEff.Controls.Add(this.rad_SoHRoLEffRand);
            this.grp_SoHRoLEff.Controls.Add(this.rad_SoHRoLEffOn);
            this.grp_SoHRoLEff.Controls.Add(this.rad_SoHRoLEffOff);
            this.grp_SoHRoLEff.Location = new System.Drawing.Point(765, 360);
            this.grp_SoHRoLEff.Name = "grp_SoHRoLEff";
            this.grp_SoHRoLEff.Size = new System.Drawing.Size(244, 63);
            this.grp_SoHRoLEff.TabIndex = 87;
            this.grp_SoHRoLEff.TabStop = false;
            this.grp_SoHRoLEff.Text = "Random SoH and RoL Effect";
            this.adjustments.SetToolTip(this.grp_SoHRoLEff, "Randomizes Shoes of Happiness and Ring of Life Effect between 1 and 10 per step");
            // 
            // rad_SoHRoLEffRand
            // 
            this.rad_SoHRoLEffRand.AutoSize = true;
            this.rad_SoHRoLEffRand.Location = new System.Drawing.Point(129, 26);
            this.rad_SoHRoLEffRand.Name = "rad_SoHRoLEffRand";
            this.rad_SoHRoLEffRand.Size = new System.Drawing.Size(95, 24);
            this.rad_SoHRoLEffRand.TabIndex = 2;
            this.rad_SoHRoLEffRand.Text = "Random";
            this.rad_SoHRoLEffRand.UseVisualStyleBackColor = true;
            this.rad_SoHRoLEffRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SoHRoLEffOn
            // 
            this.rad_SoHRoLEffOn.AutoSize = true;
            this.rad_SoHRoLEffOn.Location = new System.Drawing.Point(68, 26);
            this.rad_SoHRoLEffOn.Name = "rad_SoHRoLEffOn";
            this.rad_SoHRoLEffOn.Size = new System.Drawing.Size(55, 24);
            this.rad_SoHRoLEffOn.TabIndex = 1;
            this.rad_SoHRoLEffOn.Text = "On";
            this.rad_SoHRoLEffOn.UseVisualStyleBackColor = true;
            this.rad_SoHRoLEffOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SoHRoLEffOff
            // 
            this.rad_SoHRoLEffOff.AutoSize = true;
            this.rad_SoHRoLEffOff.Checked = true;
            this.rad_SoHRoLEffOff.Location = new System.Drawing.Point(6, 26);
            this.rad_SoHRoLEffOff.Name = "rad_SoHRoLEffOff";
            this.rad_SoHRoLEffOff.Size = new System.Drawing.Size(56, 24);
            this.rad_SoHRoLEffOff.TabIndex = 0;
            this.rad_SoHRoLEffOff.TabStop = true;
            this.rad_SoHRoLEffOff.Text = "Off";
            this.rad_SoHRoLEffOff.UseVisualStyleBackColor = true;
            this.rad_SoHRoLEffOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_HUAStone
            // 
            this.grp_HUAStone.Controls.Add(this.rad_HUAStoneRand);
            this.grp_HUAStone.Controls.Add(this.rad_HUAStoneOn);
            this.grp_HUAStone.Controls.Add(this.rad_HUAStoneOff);
            this.grp_HUAStone.Location = new System.Drawing.Point(765, 288);
            this.grp_HUAStone.Name = "grp_HUAStone";
            this.grp_HUAStone.Size = new System.Drawing.Size(244, 63);
            this.grp_HUAStone.TabIndex = 86;
            this.grp_HUAStone.TabStop = false;
            this.grp_HUAStone.Text = "Guaranteed HealUsAll Stone";
            this.adjustments.SetToolTip(this.grp_HUAStone, "Guarantees the Sage\'s Stone will cast HealUsAll");
            // 
            // rad_HUAStoneRand
            // 
            this.rad_HUAStoneRand.AutoSize = true;
            this.rad_HUAStoneRand.Location = new System.Drawing.Point(129, 29);
            this.rad_HUAStoneRand.Name = "rad_HUAStoneRand";
            this.rad_HUAStoneRand.Size = new System.Drawing.Size(95, 24);
            this.rad_HUAStoneRand.TabIndex = 2;
            this.rad_HUAStoneRand.Text = "Random";
            this.rad_HUAStoneRand.UseVisualStyleBackColor = true;
            this.rad_HUAStoneRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_HUAStoneOn
            // 
            this.rad_HUAStoneOn.AutoSize = true;
            this.rad_HUAStoneOn.Location = new System.Drawing.Point(68, 29);
            this.rad_HUAStoneOn.Name = "rad_HUAStoneOn";
            this.rad_HUAStoneOn.Size = new System.Drawing.Size(55, 24);
            this.rad_HUAStoneOn.TabIndex = 1;
            this.rad_HUAStoneOn.Text = "On";
            this.rad_HUAStoneOn.UseVisualStyleBackColor = true;
            this.rad_HUAStoneOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_HUAStoneOff
            // 
            this.rad_HUAStoneOff.AutoSize = true;
            this.rad_HUAStoneOff.Checked = true;
            this.rad_HUAStoneOff.Location = new System.Drawing.Point(6, 29);
            this.rad_HUAStoneOff.Name = "rad_HUAStoneOff";
            this.rad_HUAStoneOff.Size = new System.Drawing.Size(56, 24);
            this.rad_HUAStoneOff.TabIndex = 0;
            this.rad_HUAStoneOff.TabStop = true;
            this.rad_HUAStoneOff.Text = "Off";
            this.rad_HUAStoneOff.UseVisualStyleBackColor = true;
            this.rad_HUAStoneOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandSageStone
            // 
            this.grp_RandSageStone.Controls.Add(this.rad_RandSageStoneRand);
            this.grp_RandSageStone.Controls.Add(this.rad_RandSageStoneOn);
            this.grp_RandSageStone.Controls.Add(this.rad_RandSageStoneOff);
            this.grp_RandSageStone.Location = new System.Drawing.Point(765, 215);
            this.grp_RandSageStone.Name = "grp_RandSageStone";
            this.grp_RandSageStone.Size = new System.Drawing.Size(244, 63);
            this.grp_RandSageStone.TabIndex = 85;
            this.grp_RandSageStone.TabStop = false;
            this.grp_RandSageStone.Text = "Randomize Sage\'s Stone";
            // 
            // rad_RandSageStoneRand
            // 
            this.rad_RandSageStoneRand.AutoSize = true;
            this.rad_RandSageStoneRand.Location = new System.Drawing.Point(129, 29);
            this.rad_RandSageStoneRand.Name = "rad_RandSageStoneRand";
            this.rad_RandSageStoneRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandSageStoneRand.TabIndex = 2;
            this.rad_RandSageStoneRand.Text = "Random";
            this.rad_RandSageStoneRand.UseVisualStyleBackColor = true;
            this.rad_RandSageStoneRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandSageStoneOn
            // 
            this.rad_RandSageStoneOn.AutoSize = true;
            this.rad_RandSageStoneOn.Location = new System.Drawing.Point(68, 29);
            this.rad_RandSageStoneOn.Name = "rad_RandSageStoneOn";
            this.rad_RandSageStoneOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandSageStoneOn.TabIndex = 1;
            this.rad_RandSageStoneOn.Text = "On";
            this.rad_RandSageStoneOn.UseVisualStyleBackColor = true;
            this.rad_RandSageStoneOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandSageStoneOff
            // 
            this.rad_RandSageStoneOff.AutoSize = true;
            this.rad_RandSageStoneOff.Checked = true;
            this.rad_RandSageStoneOff.Location = new System.Drawing.Point(6, 29);
            this.rad_RandSageStoneOff.Name = "rad_RandSageStoneOff";
            this.rad_RandSageStoneOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandSageStoneOff.TabIndex = 0;
            this.rad_RandSageStoneOff.TabStop = true;
            this.rad_RandSageStoneOff.Text = "Off";
            this.rad_RandSageStoneOff.UseVisualStyleBackColor = true;
            this.rad_RandSageStoneOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_InvisNPC
            // 
            this.grp_InvisNPC.Controls.Add(this.rad_InvisNPCRand);
            this.grp_InvisNPC.Controls.Add(this.rad_InvisNPCOn);
            this.grp_InvisNPC.Controls.Add(this.rad_InvisNPCOff);
            this.grp_InvisNPC.Location = new System.Drawing.Point(511, 432);
            this.grp_InvisNPC.Name = "grp_InvisNPC";
            this.grp_InvisNPC.Size = new System.Drawing.Size(244, 63);
            this.grp_InvisNPC.TabIndex = 84;
            this.grp_InvisNPC.TabStop = false;
            this.grp_InvisNPC.Text = "Invisible NPCs";
            this.adjustments.SetToolTip(this.grp_InvisNPC, "Makes NPCs invisible (but you can still interact with them)");
            // 
            // rad_InvisNPCRand
            // 
            this.rad_InvisNPCRand.AutoSize = true;
            this.rad_InvisNPCRand.Location = new System.Drawing.Point(144, 29);
            this.rad_InvisNPCRand.Name = "rad_InvisNPCRand";
            this.rad_InvisNPCRand.Size = new System.Drawing.Size(95, 24);
            this.rad_InvisNPCRand.TabIndex = 2;
            this.rad_InvisNPCRand.Text = "Random";
            this.rad_InvisNPCRand.UseVisualStyleBackColor = true;
            this.rad_InvisNPCRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_InvisNPCOn
            // 
            this.rad_InvisNPCOn.AutoSize = true;
            this.rad_InvisNPCOn.Location = new System.Drawing.Point(76, 29);
            this.rad_InvisNPCOn.Name = "rad_InvisNPCOn";
            this.rad_InvisNPCOn.Size = new System.Drawing.Size(55, 24);
            this.rad_InvisNPCOn.TabIndex = 1;
            this.rad_InvisNPCOn.Text = "On";
            this.rad_InvisNPCOn.UseVisualStyleBackColor = true;
            this.rad_InvisNPCOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_InvisNPCOff
            // 
            this.rad_InvisNPCOff.AutoSize = true;
            this.rad_InvisNPCOff.Checked = true;
            this.rad_InvisNPCOff.Location = new System.Drawing.Point(9, 29);
            this.rad_InvisNPCOff.Name = "rad_InvisNPCOff";
            this.rad_InvisNPCOff.Size = new System.Drawing.Size(56, 24);
            this.rad_InvisNPCOff.TabIndex = 0;
            this.rad_InvisNPCOff.TabStop = true;
            this.rad_InvisNPCOff.Text = "Off";
            this.rad_InvisNPCOff.UseVisualStyleBackColor = true;
            this.rad_InvisNPCOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_InvisShipBird
            // 
            this.grp_InvisShipBird.Controls.Add(this.rad_InvisShipBirdRand);
            this.grp_InvisShipBird.Controls.Add(this.rad_InvisShipBirdOn);
            this.grp_InvisShipBird.Controls.Add(this.rad_InvisShipBirdOff);
            this.grp_InvisShipBird.Location = new System.Drawing.Point(511, 360);
            this.grp_InvisShipBird.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_InvisShipBird.Name = "grp_InvisShipBird";
            this.grp_InvisShipBird.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_InvisShipBird.Size = new System.Drawing.Size(244, 63);
            this.grp_InvisShipBird.TabIndex = 83;
            this.grp_InvisShipBird.TabStop = false;
            this.grp_InvisShipBird.Text = "Invisible Ships and Bird";
            this.adjustments.SetToolTip(this.grp_InvisShipBird, "Ships and Bird are invisible on world map.");
            // 
            // rad_InvisShipBirdRand
            // 
            this.rad_InvisShipBirdRand.AutoSize = true;
            this.rad_InvisShipBirdRand.Location = new System.Drawing.Point(144, 26);
            this.rad_InvisShipBirdRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_InvisShipBirdRand.Name = "rad_InvisShipBirdRand";
            this.rad_InvisShipBirdRand.Size = new System.Drawing.Size(95, 24);
            this.rad_InvisShipBirdRand.TabIndex = 2;
            this.rad_InvisShipBirdRand.Text = "Random";
            this.rad_InvisShipBirdRand.UseVisualStyleBackColor = true;
            this.rad_InvisShipBirdRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_InvisShipBirdOn
            // 
            this.rad_InvisShipBirdOn.AutoSize = true;
            this.rad_InvisShipBirdOn.Location = new System.Drawing.Point(76, 26);
            this.rad_InvisShipBirdOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_InvisShipBirdOn.Name = "rad_InvisShipBirdOn";
            this.rad_InvisShipBirdOn.Size = new System.Drawing.Size(55, 24);
            this.rad_InvisShipBirdOn.TabIndex = 1;
            this.rad_InvisShipBirdOn.Text = "On";
            this.rad_InvisShipBirdOn.UseVisualStyleBackColor = true;
            this.rad_InvisShipBirdOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_InvisShipBirdOff
            // 
            this.rad_InvisShipBirdOff.AutoSize = true;
            this.rad_InvisShipBirdOff.Checked = true;
            this.rad_InvisShipBirdOff.Location = new System.Drawing.Point(9, 26);
            this.rad_InvisShipBirdOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_InvisShipBirdOff.Name = "rad_InvisShipBirdOff";
            this.rad_InvisShipBirdOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_PartyItems.Location = new System.Drawing.Point(511, 288);
            this.grp_PartyItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_PartyItems.Name = "grp_PartyItems";
            this.grp_PartyItems.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_PartyItems.Size = new System.Drawing.Size(244, 63);
            this.grp_PartyItems.TabIndex = 82;
            this.grp_PartyItems.TabStop = false;
            this.grp_PartyItems.Text = "Party Starts with Items";
            this.adjustments.SetToolTip(this.grp_PartyItems, "Party starts with consumable items.");
            // 
            // rad_PartyItemsRand
            // 
            this.rad_PartyItemsRand.AutoSize = true;
            this.rad_PartyItemsRand.Location = new System.Drawing.Point(144, 29);
            this.rad_PartyItemsRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_PartyItemsRand.Name = "rad_PartyItemsRand";
            this.rad_PartyItemsRand.Size = new System.Drawing.Size(95, 24);
            this.rad_PartyItemsRand.TabIndex = 2;
            this.rad_PartyItemsRand.Text = "Random";
            this.rad_PartyItemsRand.UseVisualStyleBackColor = true;
            this.rad_PartyItemsRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_PartyItemsOn
            // 
            this.rad_PartyItemsOn.AutoSize = true;
            this.rad_PartyItemsOn.Location = new System.Drawing.Point(76, 29);
            this.rad_PartyItemsOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_PartyItemsOn.Name = "rad_PartyItemsOn";
            this.rad_PartyItemsOn.Size = new System.Drawing.Size(55, 24);
            this.rad_PartyItemsOn.TabIndex = 1;
            this.rad_PartyItemsOn.Text = "On";
            this.rad_PartyItemsOn.UseVisualStyleBackColor = true;
            this.rad_PartyItemsOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_PartyItemsOff
            // 
            this.rad_PartyItemsOff.AutoSize = true;
            this.rad_PartyItemsOff.Checked = true;
            this.rad_PartyItemsOff.Location = new System.Drawing.Point(9, 29);
            this.rad_PartyItemsOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_PartyItemsOff.Name = "rad_PartyItemsOff";
            this.rad_PartyItemsOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_doubleAtt.Location = new System.Drawing.Point(511, 215);
            this.grp_doubleAtt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_doubleAtt.Name = "grp_doubleAtt";
            this.grp_doubleAtt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_doubleAtt.Size = new System.Drawing.Size(244, 63);
            this.grp_doubleAtt.TabIndex = 81;
            this.grp_doubleAtt.TabStop = false;
            this.grp_doubleAtt.Text = "Normal Attacks Hit Twice";
            this.adjustments.SetToolTip(this.grp_doubleAtt, "Party physical attacks hit twice (is not influenced by Falcon Sword).");
            // 
            // rad_DoubleAttRand
            // 
            this.rad_DoubleAttRand.AutoSize = true;
            this.rad_DoubleAttRand.Location = new System.Drawing.Point(144, 29);
            this.rad_DoubleAttRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_DoubleAttRand.Name = "rad_DoubleAttRand";
            this.rad_DoubleAttRand.Size = new System.Drawing.Size(95, 24);
            this.rad_DoubleAttRand.TabIndex = 2;
            this.rad_DoubleAttRand.Text = "Random";
            this.rad_DoubleAttRand.UseVisualStyleBackColor = true;
            this.rad_DoubleAttRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DoubleAttOn
            // 
            this.rad_DoubleAttOn.AutoSize = true;
            this.rad_DoubleAttOn.Location = new System.Drawing.Point(76, 29);
            this.rad_DoubleAttOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_DoubleAttOn.Name = "rad_DoubleAttOn";
            this.rad_DoubleAttOn.Size = new System.Drawing.Size(55, 24);
            this.rad_DoubleAttOn.TabIndex = 1;
            this.rad_DoubleAttOn.Text = "On";
            this.rad_DoubleAttOn.UseVisualStyleBackColor = true;
            this.rad_DoubleAttOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DoubleAttOff
            // 
            this.rad_DoubleAttOff.AutoSize = true;
            this.rad_DoubleAttOff.Checked = true;
            this.rad_DoubleAttOff.Location = new System.Drawing.Point(9, 29);
            this.rad_DoubleAttOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_DoubleAttOff.Name = "rad_DoubleAttOff";
            this.rad_DoubleAttOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_DispEqPower.Location = new System.Drawing.Point(259, 432);
            this.grp_DispEqPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_DispEqPower.Name = "grp_DispEqPower";
            this.grp_DispEqPower.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_DispEqPower.Size = new System.Drawing.Size(244, 63);
            this.grp_DispEqPower.TabIndex = 80;
            this.grp_DispEqPower.TabStop = false;
            this.grp_DispEqPower.Text = "Display Equipment Power";
            this.adjustments.SetToolTip(this.grp_DispEqPower, "Display equipment power as part of equipment name.");
            // 
            // rad_DispEqPowerRand
            // 
            this.rad_DispEqPowerRand.AutoSize = true;
            this.rad_DispEqPowerRand.Location = new System.Drawing.Point(144, 29);
            this.rad_DispEqPowerRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_DispEqPowerRand.Name = "rad_DispEqPowerRand";
            this.rad_DispEqPowerRand.Size = new System.Drawing.Size(95, 24);
            this.rad_DispEqPowerRand.TabIndex = 2;
            this.rad_DispEqPowerRand.Text = "Random";
            this.rad_DispEqPowerRand.UseVisualStyleBackColor = true;
            this.rad_DispEqPowerRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DispEqPowerOn
            // 
            this.rad_DispEqPowerOn.AutoSize = true;
            this.rad_DispEqPowerOn.Location = new System.Drawing.Point(76, 29);
            this.rad_DispEqPowerOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_DispEqPowerOn.Name = "rad_DispEqPowerOn";
            this.rad_DispEqPowerOn.Size = new System.Drawing.Size(55, 24);
            this.rad_DispEqPowerOn.TabIndex = 1;
            this.rad_DispEqPowerOn.Text = "On";
            this.rad_DispEqPowerOn.UseVisualStyleBackColor = true;
            this.rad_DispEqPowerOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DispEqPowerOff
            // 
            this.rad_DispEqPowerOff.AutoSize = true;
            this.rad_DispEqPowerOff.Checked = true;
            this.rad_DispEqPowerOff.Location = new System.Drawing.Point(9, 29);
            this.rad_DispEqPowerOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_DispEqPowerOff.Name = "rad_DispEqPowerOff";
            this.rad_DispEqPowerOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_Lamia.Location = new System.Drawing.Point(259, 360);
            this.grp_Lamia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Lamia.Name = "grp_Lamia";
            this.grp_Lamia.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Lamia.Size = new System.Drawing.Size(244, 63);
            this.grp_Lamia.TabIndex = 79;
            this.grp_Lamia.TabStop = false;
            this.grp_Lamia.Text = "Require No Orbs for Lamia";
            // 
            // rad_LamiaRand
            // 
            this.rad_LamiaRand.AutoSize = true;
            this.rad_LamiaRand.Location = new System.Drawing.Point(144, 26);
            this.rad_LamiaRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_LamiaRand.Name = "rad_LamiaRand";
            this.rad_LamiaRand.Size = new System.Drawing.Size(95, 24);
            this.rad_LamiaRand.TabIndex = 2;
            this.rad_LamiaRand.Text = "Random";
            this.rad_LamiaRand.UseVisualStyleBackColor = true;
            this.rad_LamiaRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LamiaOn
            // 
            this.rad_LamiaOn.AutoSize = true;
            this.rad_LamiaOn.Location = new System.Drawing.Point(76, 26);
            this.rad_LamiaOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_LamiaOn.Name = "rad_LamiaOn";
            this.rad_LamiaOn.Size = new System.Drawing.Size(55, 24);
            this.rad_LamiaOn.TabIndex = 1;
            this.rad_LamiaOn.Text = "On";
            this.rad_LamiaOn.UseVisualStyleBackColor = true;
            this.rad_LamiaOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LamiaOff
            // 
            this.rad_LamiaOff.AutoSize = true;
            this.rad_LamiaOff.Checked = true;
            this.rad_LamiaOff.Location = new System.Drawing.Point(9, 26);
            this.rad_LamiaOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_LamiaOff.Name = "rad_LamiaOff";
            this.rad_LamiaOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_cod.Location = new System.Drawing.Point(259, 288);
            this.grp_cod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_cod.Name = "grp_cod";
            this.grp_cod.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_cod.Size = new System.Drawing.Size(244, 63);
            this.grp_cod.TabIndex = 78;
            this.grp_cod.TabStop = false;
            this.grp_cod.Text = "Cold as a Cod Adjustment";
            // 
            // rad_codRand
            // 
            this.rad_codRand.AutoSize = true;
            this.rad_codRand.Location = new System.Drawing.Point(144, 29);
            this.rad_codRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_codRand.Name = "rad_codRand";
            this.rad_codRand.Size = new System.Drawing.Size(95, 24);
            this.rad_codRand.TabIndex = 2;
            this.rad_codRand.Text = "Random";
            this.rad_codRand.UseVisualStyleBackColor = true;
            this.rad_codRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_codOn
            // 
            this.rad_codOn.AutoSize = true;
            this.rad_codOn.Location = new System.Drawing.Point(76, 31);
            this.rad_codOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_codOn.Name = "rad_codOn";
            this.rad_codOn.Size = new System.Drawing.Size(55, 24);
            this.rad_codOn.TabIndex = 1;
            this.rad_codOn.Text = "On";
            this.rad_codOn.UseVisualStyleBackColor = true;
            this.rad_codOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_codOff
            // 
            this.rad_codOff.AutoSize = true;
            this.rad_codOff.Checked = true;
            this.rad_codOff.Location = new System.Drawing.Point(9, 31);
            this.rad_codOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_codOff.Name = "rad_codOff";
            this.rad_codOff.Size = new System.Drawing.Size(56, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(259, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(244, 63);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randomize Starting Gold";
            // 
            // rad_StartGoldRand
            // 
            this.rad_StartGoldRand.AutoSize = true;
            this.rad_StartGoldRand.Location = new System.Drawing.Point(144, 29);
            this.rad_StartGoldRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_StartGoldRand.Name = "rad_StartGoldRand";
            this.rad_StartGoldRand.Size = new System.Drawing.Size(95, 24);
            this.rad_StartGoldRand.TabIndex = 80;
            this.rad_StartGoldRand.Text = "Random";
            this.rad_StartGoldRand.UseVisualStyleBackColor = true;
            this.rad_StartGoldRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_StartGoldOff
            // 
            this.rad_StartGoldOff.AutoSize = true;
            this.rad_StartGoldOff.Checked = true;
            this.rad_StartGoldOff.Location = new System.Drawing.Point(9, 29);
            this.rad_StartGoldOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_StartGoldOff.Name = "rad_StartGoldOff";
            this.rad_StartGoldOff.Size = new System.Drawing.Size(56, 24);
            this.rad_StartGoldOff.TabIndex = 78;
            this.rad_StartGoldOff.TabStop = true;
            this.rad_StartGoldOff.Text = "Off";
            this.rad_StartGoldOff.UseVisualStyleBackColor = true;
            this.rad_StartGoldOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_StartGoldOn
            // 
            this.rad_StartGoldOn.AutoSize = true;
            this.rad_StartGoldOn.Location = new System.Drawing.Point(76, 29);
            this.rad_StartGoldOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_StartGoldOn.Name = "rad_StartGoldOn";
            this.rad_StartGoldOn.Size = new System.Drawing.Size(55, 24);
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
            this.grp_RmManips.Location = new System.Drawing.Point(6, 432);
            this.grp_RmManips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_RmManips.Name = "grp_RmManips";
            this.grp_RmManips.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_RmManips.Size = new System.Drawing.Size(244, 63);
            this.grp_RmManips.TabIndex = 76;
            this.grp_RmManips.TabStop = false;
            this.grp_RmManips.Text = "Remove Manipulations";
            // 
            // rad_RmManipRand
            // 
            this.rad_RmManipRand.AutoSize = true;
            this.rad_RmManipRand.Location = new System.Drawing.Point(142, 29);
            this.rad_RmManipRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_RmManipRand.Name = "rad_RmManipRand";
            this.rad_RmManipRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RmManipRand.TabIndex = 2;
            this.rad_RmManipRand.Text = "Random";
            this.rad_RmManipRand.UseVisualStyleBackColor = true;
            this.rad_RmManipRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmManipOn
            // 
            this.rad_RmManipOn.AutoSize = true;
            this.rad_RmManipOn.Location = new System.Drawing.Point(76, 29);
            this.rad_RmManipOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_RmManipOn.Name = "rad_RmManipOn";
            this.rad_RmManipOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RmManipOn.TabIndex = 1;
            this.rad_RmManipOn.Text = "On";
            this.rad_RmManipOn.UseVisualStyleBackColor = true;
            this.rad_RmManipOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmManipOff
            // 
            this.rad_RmManipOff.AutoSize = true;
            this.rad_RmManipOff.Checked = true;
            this.rad_RmManipOff.Location = new System.Drawing.Point(9, 29);
            this.rad_RmManipOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_RmManipOff.Name = "rad_RmManipOff";
            this.rad_RmManipOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_SpeedUpMenus.Location = new System.Drawing.Point(6, 360);
            this.grp_SpeedUpMenus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_SpeedUpMenus.Name = "grp_SpeedUpMenus";
            this.grp_SpeedUpMenus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_SpeedUpMenus.Size = new System.Drawing.Size(244, 63);
            this.grp_SpeedUpMenus.TabIndex = 75;
            this.grp_SpeedUpMenus.TabStop = false;
            this.grp_SpeedUpMenus.Text = "Speed Up Menus";
            // 
            // rad_SpeedUpMenuRand
            // 
            this.rad_SpeedUpMenuRand.AutoSize = true;
            this.rad_SpeedUpMenuRand.Location = new System.Drawing.Point(142, 26);
            this.rad_SpeedUpMenuRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_SpeedUpMenuRand.Name = "rad_SpeedUpMenuRand";
            this.rad_SpeedUpMenuRand.Size = new System.Drawing.Size(95, 24);
            this.rad_SpeedUpMenuRand.TabIndex = 2;
            this.rad_SpeedUpMenuRand.Text = "Random";
            this.rad_SpeedUpMenuRand.UseVisualStyleBackColor = true;
            this.rad_SpeedUpMenuRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SpeedUpMenusOn
            // 
            this.rad_SpeedUpMenusOn.AutoSize = true;
            this.rad_SpeedUpMenusOn.Location = new System.Drawing.Point(76, 26);
            this.rad_SpeedUpMenusOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_SpeedUpMenusOn.Name = "rad_SpeedUpMenusOn";
            this.rad_SpeedUpMenusOn.Size = new System.Drawing.Size(55, 24);
            this.rad_SpeedUpMenusOn.TabIndex = 1;
            this.rad_SpeedUpMenusOn.Text = "On";
            this.rad_SpeedUpMenusOn.UseVisualStyleBackColor = true;
            this.rad_SpeedUpMenusOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SpeedUpMenuOff
            // 
            this.rad_SpeedUpMenuOff.AutoSize = true;
            this.rad_SpeedUpMenuOff.Checked = true;
            this.rad_SpeedUpMenuOff.Location = new System.Drawing.Point(9, 26);
            this.rad_SpeedUpMenuOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_SpeedUpMenuOff.Name = "rad_SpeedUpMenuOff";
            this.rad_SpeedUpMenuOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_SpeedUpText.Location = new System.Drawing.Point(6, 288);
            this.grp_SpeedUpText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_SpeedUpText.Name = "grp_SpeedUpText";
            this.grp_SpeedUpText.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_SpeedUpText.Size = new System.Drawing.Size(244, 63);
            this.grp_SpeedUpText.TabIndex = 74;
            this.grp_SpeedUpText.TabStop = false;
            this.grp_SpeedUpText.Text = "Speed Up Text";
            // 
            // rad_SpeedTextRand
            // 
            this.rad_SpeedTextRand.AutoSize = true;
            this.rad_SpeedTextRand.Location = new System.Drawing.Point(142, 28);
            this.rad_SpeedTextRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_SpeedTextRand.Name = "rad_SpeedTextRand";
            this.rad_SpeedTextRand.Size = new System.Drawing.Size(95, 24);
            this.rad_SpeedTextRand.TabIndex = 2;
            this.rad_SpeedTextRand.Text = "Random";
            this.rad_SpeedTextRand.UseVisualStyleBackColor = true;
            this.rad_SpeedTextRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SpeedTextOn
            // 
            this.rad_SpeedTextOn.AutoSize = true;
            this.rad_SpeedTextOn.Location = new System.Drawing.Point(76, 28);
            this.rad_SpeedTextOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_SpeedTextOn.Name = "rad_SpeedTextOn";
            this.rad_SpeedTextOn.Size = new System.Drawing.Size(55, 24);
            this.rad_SpeedTextOn.TabIndex = 1;
            this.rad_SpeedTextOn.Text = "On";
            this.rad_SpeedTextOn.UseVisualStyleBackColor = true;
            this.rad_SpeedTextOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SpeedTextOff
            // 
            this.rad_SpeedTextOff.AutoSize = true;
            this.rad_SpeedTextOff.Checked = true;
            this.rad_SpeedTextOff.Location = new System.Drawing.Point(9, 29);
            this.rad_SpeedTextOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_SpeedTextOff.Name = "rad_SpeedTextOff";
            this.rad_SpeedTextOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_IncBatSpeed.Location = new System.Drawing.Point(7, 215);
            this.grp_IncBatSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_IncBatSpeed.Name = "grp_IncBatSpeed";
            this.grp_IncBatSpeed.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_IncBatSpeed.Size = new System.Drawing.Size(244, 63);
            this.grp_IncBatSpeed.TabIndex = 73;
            this.grp_IncBatSpeed.TabStop = false;
            this.grp_IncBatSpeed.Text = "Increased Battle Speed";
            // 
            // rad_IncBattSpeedRand
            // 
            this.rad_IncBattSpeedRand.AutoSize = true;
            this.rad_IncBattSpeedRand.Location = new System.Drawing.Point(144, 29);
            this.rad_IncBattSpeedRand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_IncBattSpeedRand.Name = "rad_IncBattSpeedRand";
            this.rad_IncBattSpeedRand.Size = new System.Drawing.Size(95, 24);
            this.rad_IncBattSpeedRand.TabIndex = 74;
            this.rad_IncBattSpeedRand.Text = "Random";
            this.rad_IncBattSpeedRand.UseVisualStyleBackColor = true;
            this.rad_IncBattSpeedRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_IncBattSpeedOn
            // 
            this.rad_IncBattSpeedOn.AutoSize = true;
            this.rad_IncBattSpeedOn.Location = new System.Drawing.Point(76, 29);
            this.rad_IncBattSpeedOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_IncBattSpeedOn.Name = "rad_IncBattSpeedOn";
            this.rad_IncBattSpeedOn.Size = new System.Drawing.Size(55, 24);
            this.rad_IncBattSpeedOn.TabIndex = 73;
            this.rad_IncBattSpeedOn.Text = "On";
            this.rad_IncBattSpeedOn.UseVisualStyleBackColor = true;
            this.rad_IncBattSpeedOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_IncBattSpeedOff
            // 
            this.rad_IncBattSpeedOff.AutoSize = true;
            this.rad_IncBattSpeedOff.Checked = true;
            this.rad_IncBattSpeedOff.Location = new System.Drawing.Point(9, 29);
            this.rad_IncBattSpeedOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_IncBattSpeedOff.Name = "rad_IncBattSpeedOff";
            this.rad_IncBattSpeedOff.Size = new System.Drawing.Size(56, 24);
            this.rad_IncBattSpeedOff.TabIndex = 72;
            this.rad_IncBattSpeedOff.TabStop = true;
            this.rad_IncBattSpeedOff.Text = "Off";
            this.rad_IncBattSpeedOff.UseVisualStyleBackColor = true;
            this.rad_IncBattSpeedOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.grp_Continents);
            this.tabPage8.Controls.Add(this.grp_RmMountains);
            this.tabPage8.Controls.Add(this.grp_NoNewTown);
            this.tabPage8.Controls.Add(this.grp_Charlock);
            this.tabPage8.Controls.Add(this.grp_DisAlefGlitch);
            this.tabPage8.Controls.Add(this.grp_RandMonstZone);
            this.tabPage8.Controls.Add(this.grp_SmallMap);
            this.tabPage8.Controls.Add(this.grp_RandMap);
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage8.Size = new System.Drawing.Size(1017, 506);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Map";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // grp_Continents
            // 
            this.grp_Continents.Controls.Add(this.grp_RandTown);
            this.grp_Continents.Controls.Add(this.grp_RandCaves);
            this.grp_Continents.Controls.Add(this.grp_RandShrine);
            this.grp_Continents.Location = new System.Drawing.Point(261, 75);
            this.grp_Continents.Name = "grp_Continents";
            this.grp_Continents.Size = new System.Drawing.Size(244, 234);
            this.grp_Continents.TabIndex = 99;
            this.grp_Continents.TabStop = false;
            this.grp_Continents.Text = "Randomize Continents";
            // 
            // grp_RandTown
            // 
            this.grp_RandTown.Controls.Add(this.rad_RandTownsRand);
            this.grp_RandTown.Controls.Add(this.rad_RandTownsOn);
            this.grp_RandTown.Controls.Add(this.rad_RandTownsOff);
            this.grp_RandTown.Location = new System.Drawing.Point(6, 25);
            this.grp_RandTown.Name = "grp_RandTown";
            this.grp_RandTown.Size = new System.Drawing.Size(233, 63);
            this.grp_RandTown.TabIndex = 97;
            this.grp_RandTown.TabStop = false;
            this.grp_RandTown.Text = "Towns";
            this.adjustments.SetToolTip(this.grp_RandTown, "Randomizes continents that towns are found on");
            // 
            // rad_RandTownsRand
            // 
            this.rad_RandTownsRand.AutoSize = true;
            this.rad_RandTownsRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RandTownsRand.Name = "rad_RandTownsRand";
            this.rad_RandTownsRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandTownsRand.TabIndex = 2;
            this.rad_RandTownsRand.Text = "Random";
            this.rad_RandTownsRand.UseVisualStyleBackColor = true;
            this.rad_RandTownsRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandTownsOn
            // 
            this.rad_RandTownsOn.AutoSize = true;
            this.rad_RandTownsOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RandTownsOn.Name = "rad_RandTownsOn";
            this.rad_RandTownsOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandTownsOn.TabIndex = 1;
            this.rad_RandTownsOn.Text = "On";
            this.rad_RandTownsOn.UseVisualStyleBackColor = true;
            this.rad_RandTownsOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandTownsOff
            // 
            this.rad_RandTownsOff.AutoSize = true;
            this.rad_RandTownsOff.Checked = true;
            this.rad_RandTownsOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RandTownsOff.Name = "rad_RandTownsOff";
            this.rad_RandTownsOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandTownsOff.TabIndex = 0;
            this.rad_RandTownsOff.TabStop = true;
            this.rad_RandTownsOff.Text = "Off";
            this.rad_RandTownsOff.UseVisualStyleBackColor = true;
            this.rad_RandTownsOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandCaves
            // 
            this.grp_RandCaves.Controls.Add(this.rad_RandCavesRand);
            this.grp_RandCaves.Controls.Add(this.rad_RandCavesOn);
            this.grp_RandCaves.Controls.Add(this.rad_RandCavesOff);
            this.grp_RandCaves.Location = new System.Drawing.Point(6, 94);
            this.grp_RandCaves.Name = "grp_RandCaves";
            this.grp_RandCaves.Size = new System.Drawing.Size(233, 63);
            this.grp_RandCaves.TabIndex = 97;
            this.grp_RandCaves.TabStop = false;
            this.grp_RandCaves.Text = "Caves and Towers";
            this.adjustments.SetToolTip(this.grp_RandCaves, "Randomizes continents that caves and towers are found on");
            // 
            // rad_RandCavesRand
            // 
            this.rad_RandCavesRand.AutoSize = true;
            this.rad_RandCavesRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RandCavesRand.Name = "rad_RandCavesRand";
            this.rad_RandCavesRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandCavesRand.TabIndex = 2;
            this.rad_RandCavesRand.Text = "Random";
            this.rad_RandCavesRand.UseVisualStyleBackColor = true;
            this.rad_RandCavesRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandCavesOn
            // 
            this.rad_RandCavesOn.AutoSize = true;
            this.rad_RandCavesOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RandCavesOn.Name = "rad_RandCavesOn";
            this.rad_RandCavesOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandCavesOn.TabIndex = 1;
            this.rad_RandCavesOn.Text = "On";
            this.rad_RandCavesOn.UseVisualStyleBackColor = true;
            this.rad_RandCavesOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandCavesOff
            // 
            this.rad_RandCavesOff.AutoSize = true;
            this.rad_RandCavesOff.Checked = true;
            this.rad_RandCavesOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RandCavesOff.Name = "rad_RandCavesOff";
            this.rad_RandCavesOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandCavesOff.TabIndex = 0;
            this.rad_RandCavesOff.TabStop = true;
            this.rad_RandCavesOff.Text = "Off";
            this.rad_RandCavesOff.UseVisualStyleBackColor = true;
            this.rad_RandCavesOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandShrine
            // 
            this.grp_RandShrine.Controls.Add(this.rad_RandShrinesRand);
            this.grp_RandShrine.Controls.Add(this.rad_RandShrinesOn);
            this.grp_RandShrine.Controls.Add(this.rad_RandShrinesOff);
            this.grp_RandShrine.Location = new System.Drawing.Point(6, 163);
            this.grp_RandShrine.Name = "grp_RandShrine";
            this.grp_RandShrine.Size = new System.Drawing.Size(233, 63);
            this.grp_RandShrine.TabIndex = 97;
            this.grp_RandShrine.TabStop = false;
            this.grp_RandShrine.Text = "Shrines";
            this.adjustments.SetToolTip(this.grp_RandShrine, "Randomizes continents that shrines are found on");
            // 
            // rad_RandShrinesRand
            // 
            this.rad_RandShrinesRand.AutoSize = true;
            this.rad_RandShrinesRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RandShrinesRand.Name = "rad_RandShrinesRand";
            this.rad_RandShrinesRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandShrinesRand.TabIndex = 2;
            this.rad_RandShrinesRand.Text = "Random";
            this.rad_RandShrinesRand.UseVisualStyleBackColor = true;
            this.rad_RandShrinesRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandShrinesOn
            // 
            this.rad_RandShrinesOn.AutoSize = true;
            this.rad_RandShrinesOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RandShrinesOn.Name = "rad_RandShrinesOn";
            this.rad_RandShrinesOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandShrinesOn.TabIndex = 1;
            this.rad_RandShrinesOn.Text = "On";
            this.rad_RandShrinesOn.UseVisualStyleBackColor = true;
            this.rad_RandShrinesOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandShrinesOff
            // 
            this.rad_RandShrinesOff.AutoSize = true;
            this.rad_RandShrinesOff.Checked = true;
            this.rad_RandShrinesOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RandShrinesOff.Name = "rad_RandShrinesOff";
            this.rad_RandShrinesOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandShrinesOff.TabIndex = 0;
            this.rad_RandShrinesOff.TabStop = true;
            this.rad_RandShrinesOff.Text = "Off";
            this.rad_RandShrinesOff.UseVisualStyleBackColor = true;
            this.rad_RandShrinesOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RmMountains
            // 
            this.grp_RmMountains.Controls.Add(this.grp_LancelCave);
            this.grp_RmMountains.Controls.Add(this.grp_CaveOfNecro);
            this.grp_RmMountains.Controls.Add(this.grp_BaramosCast);
            this.grp_RmMountains.Controls.Add(this.grp_DrgQnCast);
            this.grp_RmMountains.Location = new System.Drawing.Point(511, 6);
            this.grp_RmMountains.Name = "grp_RmMountains";
            this.grp_RmMountains.Size = new System.Drawing.Size(244, 303);
            this.grp_RmMountains.TabIndex = 98;
            this.grp_RmMountains.TabStop = false;
            this.grp_RmMountains.Text = "Remove Mountains";
            // 
            // grp_LancelCave
            // 
            this.grp_LancelCave.Controls.Add(this.rad_LancelCaveRand);
            this.grp_LancelCave.Controls.Add(this.rad_LancelCaveOn);
            this.grp_LancelCave.Controls.Add(this.rad_LancelCaveOff);
            this.grp_LancelCave.Location = new System.Drawing.Point(6, 25);
            this.grp_LancelCave.Name = "grp_LancelCave";
            this.grp_LancelCave.Size = new System.Drawing.Size(232, 63);
            this.grp_LancelCave.TabIndex = 97;
            this.grp_LancelCave.TabStop = false;
            this.grp_LancelCave.Text = "Lancel Cave";
            this.adjustments.SetToolTip(this.grp_LancelCave, "Removes mountains around Lancel Cave");
            // 
            // rad_LancelCaveRand
            // 
            this.rad_LancelCaveRand.AutoSize = true;
            this.rad_LancelCaveRand.Location = new System.Drawing.Point(129, 25);
            this.rad_LancelCaveRand.Name = "rad_LancelCaveRand";
            this.rad_LancelCaveRand.Size = new System.Drawing.Size(95, 24);
            this.rad_LancelCaveRand.TabIndex = 2;
            this.rad_LancelCaveRand.Text = "Random";
            this.rad_LancelCaveRand.UseVisualStyleBackColor = true;
            this.rad_LancelCaveRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LancelCaveOn
            // 
            this.rad_LancelCaveOn.AutoSize = true;
            this.rad_LancelCaveOn.Location = new System.Drawing.Point(68, 25);
            this.rad_LancelCaveOn.Name = "rad_LancelCaveOn";
            this.rad_LancelCaveOn.Size = new System.Drawing.Size(55, 24);
            this.rad_LancelCaveOn.TabIndex = 1;
            this.rad_LancelCaveOn.Text = "On";
            this.rad_LancelCaveOn.UseVisualStyleBackColor = true;
            this.rad_LancelCaveOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LancelCaveOff
            // 
            this.rad_LancelCaveOff.AutoSize = true;
            this.rad_LancelCaveOff.Checked = true;
            this.rad_LancelCaveOff.Location = new System.Drawing.Point(6, 25);
            this.rad_LancelCaveOff.Name = "rad_LancelCaveOff";
            this.rad_LancelCaveOff.Size = new System.Drawing.Size(56, 24);
            this.rad_LancelCaveOff.TabIndex = 0;
            this.rad_LancelCaveOff.TabStop = true;
            this.rad_LancelCaveOff.Text = "Off";
            this.rad_LancelCaveOff.UseVisualStyleBackColor = true;
            this.rad_LancelCaveOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_CaveOfNecro
            // 
            this.grp_CaveOfNecro.Controls.Add(this.rad_CaveOfNecroRand);
            this.grp_CaveOfNecro.Controls.Add(this.rad_CaveOfNecroOn);
            this.grp_CaveOfNecro.Controls.Add(this.rad_CaveOfNecroOff);
            this.grp_CaveOfNecro.Location = new System.Drawing.Point(6, 94);
            this.grp_CaveOfNecro.Name = "grp_CaveOfNecro";
            this.grp_CaveOfNecro.Size = new System.Drawing.Size(233, 63);
            this.grp_CaveOfNecro.TabIndex = 97;
            this.grp_CaveOfNecro.TabStop = false;
            this.grp_CaveOfNecro.Text = "Cave of Necrogond";
            this.adjustments.SetToolTip(this.grp_CaveOfNecro, "Removes mountains around Cave of Necrogond");
            // 
            // rad_CaveOfNecroRand
            // 
            this.rad_CaveOfNecroRand.AutoSize = true;
            this.rad_CaveOfNecroRand.Location = new System.Drawing.Point(129, 25);
            this.rad_CaveOfNecroRand.Name = "rad_CaveOfNecroRand";
            this.rad_CaveOfNecroRand.Size = new System.Drawing.Size(95, 24);
            this.rad_CaveOfNecroRand.TabIndex = 2;
            this.rad_CaveOfNecroRand.Text = "Random";
            this.rad_CaveOfNecroRand.UseVisualStyleBackColor = true;
            this.rad_CaveOfNecroRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_CaveOfNecroOn
            // 
            this.rad_CaveOfNecroOn.AutoSize = true;
            this.rad_CaveOfNecroOn.Location = new System.Drawing.Point(68, 25);
            this.rad_CaveOfNecroOn.Name = "rad_CaveOfNecroOn";
            this.rad_CaveOfNecroOn.Size = new System.Drawing.Size(55, 24);
            this.rad_CaveOfNecroOn.TabIndex = 1;
            this.rad_CaveOfNecroOn.Text = "On";
            this.rad_CaveOfNecroOn.UseVisualStyleBackColor = true;
            this.rad_CaveOfNecroOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_CaveOfNecroOff
            // 
            this.rad_CaveOfNecroOff.AutoSize = true;
            this.rad_CaveOfNecroOff.Checked = true;
            this.rad_CaveOfNecroOff.Location = new System.Drawing.Point(6, 25);
            this.rad_CaveOfNecroOff.Name = "rad_CaveOfNecroOff";
            this.rad_CaveOfNecroOff.Size = new System.Drawing.Size(56, 24);
            this.rad_CaveOfNecroOff.TabIndex = 0;
            this.rad_CaveOfNecroOff.TabStop = true;
            this.rad_CaveOfNecroOff.Text = "Off";
            this.rad_CaveOfNecroOff.UseVisualStyleBackColor = true;
            this.rad_CaveOfNecroOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_BaramosCast
            // 
            this.grp_BaramosCast.Controls.Add(this.rad_BaramosCastRand);
            this.grp_BaramosCast.Controls.Add(this.rad_BaramosCastOn);
            this.grp_BaramosCast.Controls.Add(this.rad_BaramosCastOff);
            this.grp_BaramosCast.Location = new System.Drawing.Point(6, 163);
            this.grp_BaramosCast.Name = "grp_BaramosCast";
            this.grp_BaramosCast.Size = new System.Drawing.Size(232, 63);
            this.grp_BaramosCast.TabIndex = 97;
            this.grp_BaramosCast.TabStop = false;
            this.grp_BaramosCast.Text = "Baramos\' Castle";
            this.adjustments.SetToolTip(this.grp_BaramosCast, "Removes mountains around Baramos\' Castle");
            // 
            // rad_BaramosCastRand
            // 
            this.rad_BaramosCastRand.AutoSize = true;
            this.rad_BaramosCastRand.Location = new System.Drawing.Point(129, 25);
            this.rad_BaramosCastRand.Name = "rad_BaramosCastRand";
            this.rad_BaramosCastRand.Size = new System.Drawing.Size(95, 24);
            this.rad_BaramosCastRand.TabIndex = 2;
            this.rad_BaramosCastRand.Text = "Random";
            this.rad_BaramosCastRand.UseVisualStyleBackColor = true;
            this.rad_BaramosCastRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_BaramosCastOn
            // 
            this.rad_BaramosCastOn.AutoSize = true;
            this.rad_BaramosCastOn.Location = new System.Drawing.Point(68, 25);
            this.rad_BaramosCastOn.Name = "rad_BaramosCastOn";
            this.rad_BaramosCastOn.Size = new System.Drawing.Size(55, 24);
            this.rad_BaramosCastOn.TabIndex = 1;
            this.rad_BaramosCastOn.Text = "On";
            this.rad_BaramosCastOn.UseVisualStyleBackColor = true;
            this.rad_BaramosCastOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_BaramosCastOff
            // 
            this.rad_BaramosCastOff.AutoSize = true;
            this.rad_BaramosCastOff.Checked = true;
            this.rad_BaramosCastOff.Location = new System.Drawing.Point(6, 25);
            this.rad_BaramosCastOff.Name = "rad_BaramosCastOff";
            this.rad_BaramosCastOff.Size = new System.Drawing.Size(56, 24);
            this.rad_BaramosCastOff.TabIndex = 0;
            this.rad_BaramosCastOff.TabStop = true;
            this.rad_BaramosCastOff.Text = "Off";
            this.rad_BaramosCastOff.UseVisualStyleBackColor = true;
            this.rad_BaramosCastOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_DrgQnCast
            // 
            this.grp_DrgQnCast.Controls.Add(this.rad_DrgQnCastRand);
            this.grp_DrgQnCast.Controls.Add(this.rad_DrgQnCastOn);
            this.grp_DrgQnCast.Controls.Add(this.rad_DrgQnCastOff);
            this.grp_DrgQnCast.Location = new System.Drawing.Point(6, 232);
            this.grp_DrgQnCast.Name = "grp_DrgQnCast";
            this.grp_DrgQnCast.Size = new System.Drawing.Size(232, 63);
            this.grp_DrgQnCast.TabIndex = 97;
            this.grp_DrgQnCast.TabStop = false;
            this.grp_DrgQnCast.Text = "Dragon Queen Castle";
            this.adjustments.SetToolTip(this.grp_DrgQnCast, "Removes mountains around Dragon Queen\'s Castle");
            // 
            // rad_DrgQnCastRand
            // 
            this.rad_DrgQnCastRand.AutoSize = true;
            this.rad_DrgQnCastRand.Location = new System.Drawing.Point(129, 25);
            this.rad_DrgQnCastRand.Name = "rad_DrgQnCastRand";
            this.rad_DrgQnCastRand.Size = new System.Drawing.Size(95, 24);
            this.rad_DrgQnCastRand.TabIndex = 2;
            this.rad_DrgQnCastRand.Text = "Random";
            this.rad_DrgQnCastRand.UseVisualStyleBackColor = true;
            this.rad_DrgQnCastRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DrgQnCastOn
            // 
            this.rad_DrgQnCastOn.AutoSize = true;
            this.rad_DrgQnCastOn.Location = new System.Drawing.Point(68, 25);
            this.rad_DrgQnCastOn.Name = "rad_DrgQnCastOn";
            this.rad_DrgQnCastOn.Size = new System.Drawing.Size(55, 24);
            this.rad_DrgQnCastOn.TabIndex = 1;
            this.rad_DrgQnCastOn.Text = "On";
            this.rad_DrgQnCastOn.UseVisualStyleBackColor = true;
            this.rad_DrgQnCastOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DrgQnCastOff
            // 
            this.rad_DrgQnCastOff.AutoSize = true;
            this.rad_DrgQnCastOff.Checked = true;
            this.rad_DrgQnCastOff.Location = new System.Drawing.Point(6, 25);
            this.rad_DrgQnCastOff.Name = "rad_DrgQnCastOff";
            this.rad_DrgQnCastOff.Size = new System.Drawing.Size(56, 24);
            this.rad_DrgQnCastOff.TabIndex = 0;
            this.rad_DrgQnCastOff.TabStop = true;
            this.rad_DrgQnCastOff.Text = "Off";
            this.rad_DrgQnCastOff.UseVisualStyleBackColor = true;
            this.rad_DrgQnCastOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_NoNewTown
            // 
            this.grp_NoNewTown.Controls.Add(this.rad_NoNewTownRand);
            this.grp_NoNewTown.Controls.Add(this.rad_NoNewTownOn);
            this.grp_NoNewTown.Controls.Add(this.rad_NoNewTownOff);
            this.grp_NoNewTown.Location = new System.Drawing.Point(765, 144);
            this.grp_NoNewTown.Name = "grp_NoNewTown";
            this.grp_NoNewTown.Size = new System.Drawing.Size(244, 63);
            this.grp_NoNewTown.TabIndex = 97;
            this.grp_NoNewTown.TabStop = false;
            this.grp_NoNewTown.Text = "No New Town";
            this.adjustments.SetToolTip(this.grp_NoNewTown, "Removes New Town from being generated on the overworld map");
            // 
            // rad_NoNewTownRand
            // 
            this.rad_NoNewTownRand.AutoSize = true;
            this.rad_NoNewTownRand.Location = new System.Drawing.Point(129, 25);
            this.rad_NoNewTownRand.Name = "rad_NoNewTownRand";
            this.rad_NoNewTownRand.Size = new System.Drawing.Size(95, 24);
            this.rad_NoNewTownRand.TabIndex = 2;
            this.rad_NoNewTownRand.Text = "Random";
            this.rad_NoNewTownRand.UseVisualStyleBackColor = true;
            this.rad_NoNewTownRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_NoNewTownOn
            // 
            this.rad_NoNewTownOn.AutoSize = true;
            this.rad_NoNewTownOn.Location = new System.Drawing.Point(68, 25);
            this.rad_NoNewTownOn.Name = "rad_NoNewTownOn";
            this.rad_NoNewTownOn.Size = new System.Drawing.Size(55, 24);
            this.rad_NoNewTownOn.TabIndex = 1;
            this.rad_NoNewTownOn.Text = "On";
            this.rad_NoNewTownOn.UseVisualStyleBackColor = true;
            this.rad_NoNewTownOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_NoNewTownOff
            // 
            this.rad_NoNewTownOff.AutoSize = true;
            this.rad_NoNewTownOff.Checked = true;
            this.rad_NoNewTownOff.Location = new System.Drawing.Point(6, 25);
            this.rad_NoNewTownOff.Name = "rad_NoNewTownOff";
            this.rad_NoNewTownOff.Size = new System.Drawing.Size(56, 24);
            this.rad_NoNewTownOff.TabIndex = 0;
            this.rad_NoNewTownOff.TabStop = true;
            this.rad_NoNewTownOff.Text = "Off";
            this.rad_NoNewTownOff.UseVisualStyleBackColor = true;
            this.rad_NoNewTownOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_Charlock
            // 
            this.grp_Charlock.Controls.Add(this.rad_CharlockRand);
            this.grp_Charlock.Controls.Add(this.rad_CharlockOn);
            this.grp_Charlock.Controls.Add(this.rad_CharlockOff);
            this.grp_Charlock.Location = new System.Drawing.Point(765, 75);
            this.grp_Charlock.Name = "grp_Charlock";
            this.grp_Charlock.Size = new System.Drawing.Size(244, 63);
            this.grp_Charlock.TabIndex = 97;
            this.grp_Charlock.TabStop = false;
            this.grp_Charlock.Text = "Charlock Land Bridge";
            this.adjustments.SetToolTip(this.grp_Charlock, "Fills in water around Charlock Castle with land");
            // 
            // rad_CharlockRand
            // 
            this.rad_CharlockRand.AutoSize = true;
            this.rad_CharlockRand.Location = new System.Drawing.Point(129, 25);
            this.rad_CharlockRand.Name = "rad_CharlockRand";
            this.rad_CharlockRand.Size = new System.Drawing.Size(95, 24);
            this.rad_CharlockRand.TabIndex = 2;
            this.rad_CharlockRand.Text = "Random";
            this.rad_CharlockRand.UseVisualStyleBackColor = true;
            this.rad_CharlockRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_CharlockOn
            // 
            this.rad_CharlockOn.AutoSize = true;
            this.rad_CharlockOn.Location = new System.Drawing.Point(68, 25);
            this.rad_CharlockOn.Name = "rad_CharlockOn";
            this.rad_CharlockOn.Size = new System.Drawing.Size(55, 24);
            this.rad_CharlockOn.TabIndex = 1;
            this.rad_CharlockOn.Text = "On";
            this.rad_CharlockOn.UseVisualStyleBackColor = true;
            this.rad_CharlockOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_CharlockOff
            // 
            this.rad_CharlockOff.AutoSize = true;
            this.rad_CharlockOff.Checked = true;
            this.rad_CharlockOff.Location = new System.Drawing.Point(6, 25);
            this.rad_CharlockOff.Name = "rad_CharlockOff";
            this.rad_CharlockOff.Size = new System.Drawing.Size(56, 24);
            this.rad_CharlockOff.TabIndex = 0;
            this.rad_CharlockOff.TabStop = true;
            this.rad_CharlockOff.Text = "Off";
            this.rad_CharlockOff.UseVisualStyleBackColor = true;
            this.rad_CharlockOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_DisAlefGlitch
            // 
            this.grp_DisAlefGlitch.Controls.Add(this.rad_DisAlefGlitchRand);
            this.grp_DisAlefGlitch.Controls.Add(this.rad_DisAlefGlitchOn);
            this.grp_DisAlefGlitch.Controls.Add(this.rad_DisAlefGlitchOff);
            this.grp_DisAlefGlitch.Location = new System.Drawing.Point(765, 6);
            this.grp_DisAlefGlitch.Name = "grp_DisAlefGlitch";
            this.grp_DisAlefGlitch.Size = new System.Drawing.Size(244, 63);
            this.grp_DisAlefGlitch.TabIndex = 97;
            this.grp_DisAlefGlitch.TabStop = false;
            this.grp_DisAlefGlitch.Text = "Disable Alefgard Glitch";
            this.adjustments.SetToolTip(this.grp_DisAlefGlitch, "Separates Baramos Castle and Pit to disable no encounter glitch");
            // 
            // rad_DisAlefGlitchRand
            // 
            this.rad_DisAlefGlitchRand.AutoSize = true;
            this.rad_DisAlefGlitchRand.Location = new System.Drawing.Point(129, 25);
            this.rad_DisAlefGlitchRand.Name = "rad_DisAlefGlitchRand";
            this.rad_DisAlefGlitchRand.Size = new System.Drawing.Size(95, 24);
            this.rad_DisAlefGlitchRand.TabIndex = 2;
            this.rad_DisAlefGlitchRand.Text = "Random";
            this.rad_DisAlefGlitchRand.UseVisualStyleBackColor = true;
            this.rad_DisAlefGlitchRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DisAlefGlitchOn
            // 
            this.rad_DisAlefGlitchOn.AutoSize = true;
            this.rad_DisAlefGlitchOn.Location = new System.Drawing.Point(68, 25);
            this.rad_DisAlefGlitchOn.Name = "rad_DisAlefGlitchOn";
            this.rad_DisAlefGlitchOn.Size = new System.Drawing.Size(55, 24);
            this.rad_DisAlefGlitchOn.TabIndex = 1;
            this.rad_DisAlefGlitchOn.Text = "On";
            this.rad_DisAlefGlitchOn.UseVisualStyleBackColor = true;
            this.rad_DisAlefGlitchOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_DisAlefGlitchOff
            // 
            this.rad_DisAlefGlitchOff.AutoSize = true;
            this.rad_DisAlefGlitchOff.Checked = true;
            this.rad_DisAlefGlitchOff.Location = new System.Drawing.Point(6, 25);
            this.rad_DisAlefGlitchOff.Name = "rad_DisAlefGlitchOff";
            this.rad_DisAlefGlitchOff.Size = new System.Drawing.Size(56, 24);
            this.rad_DisAlefGlitchOff.TabIndex = 0;
            this.rad_DisAlefGlitchOff.TabStop = true;
            this.rad_DisAlefGlitchOff.Text = "Off";
            this.rad_DisAlefGlitchOff.UseVisualStyleBackColor = true;
            this.rad_DisAlefGlitchOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandMonstZone
            // 
            this.grp_RandMonstZone.Controls.Add(this.rad_RandMonstZoneRand);
            this.grp_RandMonstZone.Controls.Add(this.rad_RandMonstZoneOn);
            this.grp_RandMonstZone.Controls.Add(this.rad_RandMonstZoneOff);
            this.grp_RandMonstZone.Location = new System.Drawing.Point(259, 6);
            this.grp_RandMonstZone.Name = "grp_RandMonstZone";
            this.grp_RandMonstZone.Size = new System.Drawing.Size(244, 63);
            this.grp_RandMonstZone.TabIndex = 96;
            this.grp_RandMonstZone.TabStop = false;
            this.grp_RandMonstZone.Text = "Randomize Monster Zones";
            this.adjustments.SetToolTip(this.grp_RandMonstZone, "Randomizes zones that monsters are found in");
            // 
            // rad_RandMonstZoneRand
            // 
            this.rad_RandMonstZoneRand.AutoSize = true;
            this.rad_RandMonstZoneRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RandMonstZoneRand.Name = "rad_RandMonstZoneRand";
            this.rad_RandMonstZoneRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandMonstZoneRand.TabIndex = 2;
            this.rad_RandMonstZoneRand.Text = "Random";
            this.rad_RandMonstZoneRand.UseVisualStyleBackColor = true;
            this.rad_RandMonstZoneRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandMonstZoneOn
            // 
            this.rad_RandMonstZoneOn.AutoSize = true;
            this.rad_RandMonstZoneOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RandMonstZoneOn.Name = "rad_RandMonstZoneOn";
            this.rad_RandMonstZoneOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandMonstZoneOn.TabIndex = 1;
            this.rad_RandMonstZoneOn.Text = "On";
            this.rad_RandMonstZoneOn.UseVisualStyleBackColor = true;
            this.rad_RandMonstZoneOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandMonstZoneOff
            // 
            this.rad_RandMonstZoneOff.AutoSize = true;
            this.rad_RandMonstZoneOff.Checked = true;
            this.rad_RandMonstZoneOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RandMonstZoneOff.Name = "rad_RandMonstZoneOff";
            this.rad_RandMonstZoneOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandMonstZoneOff.TabIndex = 0;
            this.rad_RandMonstZoneOff.TabStop = true;
            this.rad_RandMonstZoneOff.Text = "Off";
            this.rad_RandMonstZoneOff.UseVisualStyleBackColor = true;
            this.rad_RandMonstZoneOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_SmallMap
            // 
            this.grp_SmallMap.Controls.Add(this.rad_SmallMapRand);
            this.grp_SmallMap.Controls.Add(this.rad_SmallMapOn);
            this.grp_SmallMap.Controls.Add(this.rad_SmallMapOff);
            this.grp_SmallMap.Location = new System.Drawing.Point(6, 75);
            this.grp_SmallMap.Name = "grp_SmallMap";
            this.grp_SmallMap.Size = new System.Drawing.Size(244, 63);
            this.grp_SmallMap.TabIndex = 95;
            this.grp_SmallMap.TabStop = false;
            this.grp_SmallMap.Text = "Small Maps";
            this.adjustments.SetToolTip(this.grp_SmallMap, "Randomize light and dark world maps");
            // 
            // rad_SmallMapRand
            // 
            this.rad_SmallMapRand.AutoSize = true;
            this.rad_SmallMapRand.Location = new System.Drawing.Point(130, 25);
            this.rad_SmallMapRand.Name = "rad_SmallMapRand";
            this.rad_SmallMapRand.Size = new System.Drawing.Size(95, 24);
            this.rad_SmallMapRand.TabIndex = 2;
            this.rad_SmallMapRand.Text = "Random";
            this.rad_SmallMapRand.UseVisualStyleBackColor = true;
            this.rad_SmallMapRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SmallMapOn
            // 
            this.rad_SmallMapOn.AutoSize = true;
            this.rad_SmallMapOn.Location = new System.Drawing.Point(69, 25);
            this.rad_SmallMapOn.Name = "rad_SmallMapOn";
            this.rad_SmallMapOn.Size = new System.Drawing.Size(55, 24);
            this.rad_SmallMapOn.TabIndex = 1;
            this.rad_SmallMapOn.Text = "On";
            this.rad_SmallMapOn.UseVisualStyleBackColor = true;
            this.rad_SmallMapOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SmallMapOff
            // 
            this.rad_SmallMapOff.AutoSize = true;
            this.rad_SmallMapOff.Checked = true;
            this.rad_SmallMapOff.Location = new System.Drawing.Point(7, 25);
            this.rad_SmallMapOff.Name = "rad_SmallMapOff";
            this.rad_SmallMapOff.Size = new System.Drawing.Size(56, 24);
            this.rad_SmallMapOff.TabIndex = 0;
            this.rad_SmallMapOff.TabStop = true;
            this.rad_SmallMapOff.Text = "Off";
            this.rad_SmallMapOff.UseVisualStyleBackColor = true;
            this.rad_SmallMapOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandMap
            // 
            this.grp_RandMap.Controls.Add(this.rad_RandMapsRand);
            this.grp_RandMap.Controls.Add(this.rad_RandMapsOn);
            this.grp_RandMap.Controls.Add(this.rad_RandMapsOff);
            this.grp_RandMap.Location = new System.Drawing.Point(6, 6);
            this.grp_RandMap.Name = "grp_RandMap";
            this.grp_RandMap.Size = new System.Drawing.Size(244, 63);
            this.grp_RandMap.TabIndex = 94;
            this.grp_RandMap.TabStop = false;
            this.grp_RandMap.Text = "Randomize Maps";
            this.adjustments.SetToolTip(this.grp_RandMap, "Randomize light and dark world maps");
            // 
            // rad_RandMapsRand
            // 
            this.rad_RandMapsRand.AutoSize = true;
            this.rad_RandMapsRand.Location = new System.Drawing.Point(130, 26);
            this.rad_RandMapsRand.Name = "rad_RandMapsRand";
            this.rad_RandMapsRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandMapsRand.TabIndex = 2;
            this.rad_RandMapsRand.Text = "Random";
            this.rad_RandMapsRand.UseVisualStyleBackColor = true;
            this.rad_RandMapsRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandMapsOn
            // 
            this.rad_RandMapsOn.AutoSize = true;
            this.rad_RandMapsOn.Location = new System.Drawing.Point(69, 26);
            this.rad_RandMapsOn.Name = "rad_RandMapsOn";
            this.rad_RandMapsOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandMapsOn.TabIndex = 1;
            this.rad_RandMapsOn.Text = "On";
            this.rad_RandMapsOn.UseVisualStyleBackColor = true;
            this.rad_RandMapsOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandMapsOff
            // 
            this.rad_RandMapsOff.AutoSize = true;
            this.rad_RandMapsOff.Checked = true;
            this.rad_RandMapsOff.Location = new System.Drawing.Point(7, 26);
            this.rad_RandMapsOff.Name = "rad_RandMapsOff";
            this.rad_RandMapsOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandMapsOff.TabIndex = 0;
            this.rad_RandMapsOff.TabStop = true;
            this.rad_RandMapsOff.Text = "Off";
            this.rad_RandMapsOff.UseVisualStyleBackColor = true;
            this.rad_RandMapsOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grp_RmMetalRun);
            this.tabPage2.Controls.Add(this.grp_RandEnePat);
            this.tabPage2.Controls.Add(this.grp_RmDupDrop);
            this.tabPage2.Controls.Add(this.grp_RandGold);
            this.tabPage2.Controls.Add(this.grp_RandDrop);
            this.tabPage2.Controls.Add(this.grp_RandExp);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monsters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grp_RmMetalRun
            // 
            this.grp_RmMetalRun.Controls.Add(this.rad_RmMetalRunRand);
            this.grp_RmMetalRun.Controls.Add(this.rad_RmMetalRunOn);
            this.grp_RmMetalRun.Controls.Add(this.rad_RmMetalRunOff);
            this.grp_RmMetalRun.Location = new System.Drawing.Point(765, 6);
            this.grp_RmMetalRun.Name = "grp_RmMetalRun";
            this.grp_RmMetalRun.Size = new System.Drawing.Size(244, 63);
            this.grp_RmMetalRun.TabIndex = 108;
            this.grp_RmMetalRun.TabStop = false;
            this.grp_RmMetalRun.Text = "Remove Metal Run";
            this.adjustments.SetToolTip(this.grp_RmMetalRun, "Removes high run rate from metal monsters");
            // 
            // rad_RmMetalRunRand
            // 
            this.rad_RmMetalRunRand.AutoSize = true;
            this.rad_RmMetalRunRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RmMetalRunRand.Name = "rad_RmMetalRunRand";
            this.rad_RmMetalRunRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RmMetalRunRand.TabIndex = 2;
            this.rad_RmMetalRunRand.Text = "Random";
            this.rad_RmMetalRunRand.UseVisualStyleBackColor = true;
            this.rad_RmMetalRunRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmMetalRunOn
            // 
            this.rad_RmMetalRunOn.AutoSize = true;
            this.rad_RmMetalRunOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RmMetalRunOn.Name = "rad_RmMetalRunOn";
            this.rad_RmMetalRunOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RmMetalRunOn.TabIndex = 1;
            this.rad_RmMetalRunOn.Text = "On";
            this.rad_RmMetalRunOn.UseVisualStyleBackColor = true;
            this.rad_RmMetalRunOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmMetalRunOff
            // 
            this.rad_RmMetalRunOff.AutoSize = true;
            this.rad_RmMetalRunOff.Checked = true;
            this.rad_RmMetalRunOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RmMetalRunOff.Name = "rad_RmMetalRunOff";
            this.rad_RmMetalRunOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RmMetalRunOff.TabIndex = 0;
            this.rad_RmMetalRunOff.TabStop = true;
            this.rad_RmMetalRunOff.Text = "Off";
            this.rad_RmMetalRunOff.UseVisualStyleBackColor = true;
            this.rad_RmMetalRunOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandEnePat
            // 
            this.grp_RandEnePat.Controls.Add(this.rad_RandEnePatRand);
            this.grp_RandEnePat.Controls.Add(this.rad_RandEnePatOn);
            this.grp_RandEnePat.Controls.Add(this.rad_RandEnePatOff);
            this.grp_RandEnePat.Location = new System.Drawing.Point(511, 6);
            this.grp_RandEnePat.Name = "grp_RandEnePat";
            this.grp_RandEnePat.Size = new System.Drawing.Size(244, 63);
            this.grp_RandEnePat.TabIndex = 108;
            this.grp_RandEnePat.TabStop = false;
            this.grp_RandEnePat.Text = "Randomize Enemy Patterns";
            this.adjustments.SetToolTip(this.grp_RandEnePat, "Randomizes the attacks that monsters can use");
            // 
            // rad_RandEnePatRand
            // 
            this.rad_RandEnePatRand.AutoSize = true;
            this.rad_RandEnePatRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RandEnePatRand.Name = "rad_RandEnePatRand";
            this.rad_RandEnePatRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandEnePatRand.TabIndex = 2;
            this.rad_RandEnePatRand.Text = "Random";
            this.rad_RandEnePatRand.UseVisualStyleBackColor = true;
            this.rad_RandEnePatRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandEnePatOn
            // 
            this.rad_RandEnePatOn.AutoSize = true;
            this.rad_RandEnePatOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RandEnePatOn.Name = "rad_RandEnePatOn";
            this.rad_RandEnePatOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandEnePatOn.TabIndex = 1;
            this.rad_RandEnePatOn.Text = "On";
            this.rad_RandEnePatOn.UseVisualStyleBackColor = true;
            this.rad_RandEnePatOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandEnePatOff
            // 
            this.rad_RandEnePatOff.AutoSize = true;
            this.rad_RandEnePatOff.Checked = true;
            this.rad_RandEnePatOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RandEnePatOff.Name = "rad_RandEnePatOff";
            this.rad_RandEnePatOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandEnePatOff.TabIndex = 0;
            this.rad_RandEnePatOff.TabStop = true;
            this.rad_RandEnePatOff.Text = "Off";
            this.rad_RandEnePatOff.UseVisualStyleBackColor = true;
            this.rad_RandEnePatOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RmDupDrop
            // 
            this.grp_RmDupDrop.Controls.Add(this.rad_RmDupDropRand);
            this.grp_RmDupDrop.Controls.Add(this.rad_RmDupDropOn);
            this.grp_RmDupDrop.Controls.Add(this.rad_RmDupDropOff);
            this.grp_RmDupDrop.Location = new System.Drawing.Point(259, 75);
            this.grp_RmDupDrop.Name = "grp_RmDupDrop";
            this.grp_RmDupDrop.Size = new System.Drawing.Size(244, 63);
            this.grp_RmDupDrop.TabIndex = 108;
            this.grp_RmDupDrop.TabStop = false;
            this.grp_RmDupDrop.Text = "Remove Duplicates";
            this.adjustments.SetToolTip(this.grp_RmDupDrop, "Removes duplicate consumable items from drop table");
            // 
            // rad_RmDupDropRand
            // 
            this.rad_RmDupDropRand.AutoSize = true;
            this.rad_RmDupDropRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RmDupDropRand.Name = "rad_RmDupDropRand";
            this.rad_RmDupDropRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RmDupDropRand.TabIndex = 2;
            this.rad_RmDupDropRand.Text = "Random";
            this.rad_RmDupDropRand.UseVisualStyleBackColor = true;
            this.rad_RmDupDropRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmDupDropOn
            // 
            this.rad_RmDupDropOn.AutoSize = true;
            this.rad_RmDupDropOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RmDupDropOn.Name = "rad_RmDupDropOn";
            this.rad_RmDupDropOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RmDupDropOn.TabIndex = 1;
            this.rad_RmDupDropOn.Text = "On";
            this.rad_RmDupDropOn.UseVisualStyleBackColor = true;
            this.rad_RmDupDropOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmDupDropOff
            // 
            this.rad_RmDupDropOff.AutoSize = true;
            this.rad_RmDupDropOff.Checked = true;
            this.rad_RmDupDropOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RmDupDropOff.Name = "rad_RmDupDropOff";
            this.rad_RmDupDropOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RmDupDropOff.TabIndex = 0;
            this.rad_RmDupDropOff.TabStop = true;
            this.rad_RmDupDropOff.Text = "Off";
            this.rad_RmDupDropOff.UseVisualStyleBackColor = true;
            this.rad_RmDupDropOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandGold
            // 
            this.grp_RandGold.Controls.Add(this.rad_RandGoldRand);
            this.grp_RandGold.Controls.Add(this.rad_RandGoldOn);
            this.grp_RandGold.Controls.Add(this.rad_RandGoldOff);
            this.grp_RandGold.Location = new System.Drawing.Point(259, 6);
            this.grp_RandGold.Name = "grp_RandGold";
            this.grp_RandGold.Size = new System.Drawing.Size(244, 63);
            this.grp_RandGold.TabIndex = 108;
            this.grp_RandGold.TabStop = false;
            this.grp_RandGold.Text = "Randomize Gold";
            this.adjustments.SetToolTip(this.grp_RandGold, "Randomizes gold granted by monsters by + or - 25%");
            // 
            // rad_RandGoldRand
            // 
            this.rad_RandGoldRand.AutoSize = true;
            this.rad_RandGoldRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RandGoldRand.Name = "rad_RandGoldRand";
            this.rad_RandGoldRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandGoldRand.TabIndex = 2;
            this.rad_RandGoldRand.Text = "Random";
            this.rad_RandGoldRand.UseVisualStyleBackColor = true;
            this.rad_RandGoldRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandGoldOn
            // 
            this.rad_RandGoldOn.AutoSize = true;
            this.rad_RandGoldOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RandGoldOn.Name = "rad_RandGoldOn";
            this.rad_RandGoldOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandGoldOn.TabIndex = 1;
            this.rad_RandGoldOn.Text = "On";
            this.rad_RandGoldOn.UseVisualStyleBackColor = true;
            this.rad_RandGoldOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandGoldOff
            // 
            this.rad_RandGoldOff.AutoSize = true;
            this.rad_RandGoldOff.Checked = true;
            this.rad_RandGoldOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RandGoldOff.Name = "rad_RandGoldOff";
            this.rad_RandGoldOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandGoldOff.TabIndex = 0;
            this.rad_RandGoldOff.TabStop = true;
            this.rad_RandGoldOff.Text = "Off";
            this.rad_RandGoldOff.UseVisualStyleBackColor = true;
            this.rad_RandGoldOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandDrop
            // 
            this.grp_RandDrop.Controls.Add(this.rad_RandDropRand);
            this.grp_RandDrop.Controls.Add(this.rad_RandDropOn);
            this.grp_RandDrop.Controls.Add(this.rad_RandDropOff);
            this.grp_RandDrop.Location = new System.Drawing.Point(6, 75);
            this.grp_RandDrop.Name = "grp_RandDrop";
            this.grp_RandDrop.Size = new System.Drawing.Size(244, 63);
            this.grp_RandDrop.TabIndex = 108;
            this.grp_RandDrop.TabStop = false;
            this.grp_RandDrop.Text = "Randomize Drops";
            this.adjustments.SetToolTip(this.grp_RandDrop, "Randomizes drops from monsters");
            // 
            // rad_RandDropRand
            // 
            this.rad_RandDropRand.AutoSize = true;
            this.rad_RandDropRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RandDropRand.Name = "rad_RandDropRand";
            this.rad_RandDropRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandDropRand.TabIndex = 2;
            this.rad_RandDropRand.Text = "Random";
            this.rad_RandDropRand.UseVisualStyleBackColor = true;
            this.rad_RandDropRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandDropOn
            // 
            this.rad_RandDropOn.AutoSize = true;
            this.rad_RandDropOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RandDropOn.Name = "rad_RandDropOn";
            this.rad_RandDropOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandDropOn.TabIndex = 1;
            this.rad_RandDropOn.Text = "On";
            this.rad_RandDropOn.UseVisualStyleBackColor = true;
            this.rad_RandDropOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandDropOff
            // 
            this.rad_RandDropOff.AutoSize = true;
            this.rad_RandDropOff.Checked = true;
            this.rad_RandDropOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RandDropOff.Name = "rad_RandDropOff";
            this.rad_RandDropOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandDropOff.TabIndex = 0;
            this.rad_RandDropOff.TabStop = true;
            this.rad_RandDropOff.Text = "Off";
            this.rad_RandDropOff.UseVisualStyleBackColor = true;
            this.rad_RandDropOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandExp
            // 
            this.grp_RandExp.Controls.Add(this.rad_RandExpRand);
            this.grp_RandExp.Controls.Add(this.rad_RandExpOn);
            this.grp_RandExp.Controls.Add(this.rad_RandExpOff);
            this.grp_RandExp.Location = new System.Drawing.Point(6, 6);
            this.grp_RandExp.Name = "grp_RandExp";
            this.grp_RandExp.Size = new System.Drawing.Size(244, 63);
            this.grp_RandExp.TabIndex = 107;
            this.grp_RandExp.TabStop = false;
            this.grp_RandExp.Text = "Randomize Experience";
            this.adjustments.SetToolTip(this.grp_RandExp, "Randomizes experience granted by monsters by + or - 25%");
            // 
            // rad_RandExpRand
            // 
            this.rad_RandExpRand.AutoSize = true;
            this.rad_RandExpRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RandExpRand.Name = "rad_RandExpRand";
            this.rad_RandExpRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RandExpRand.TabIndex = 2;
            this.rad_RandExpRand.Text = "Random";
            this.rad_RandExpRand.UseVisualStyleBackColor = true;
            this.rad_RandExpRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandExpOn
            // 
            this.rad_RandExpOn.AutoSize = true;
            this.rad_RandExpOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RandExpOn.Name = "rad_RandExpOn";
            this.rad_RandExpOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RandExpOn.TabIndex = 1;
            this.rad_RandExpOn.Text = "On";
            this.rad_RandExpOn.UseVisualStyleBackColor = true;
            this.rad_RandExpOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandExpOff
            // 
            this.rad_RandExpOff.AutoSize = true;
            this.rad_RandExpOff.Checked = true;
            this.rad_RandExpOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RandExpOff.Name = "rad_RandExpOff";
            this.rad_RandExpOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RandExpOff.TabIndex = 0;
            this.rad_RandExpOff.TabStop = true;
            this.rad_RandExpOff.Text = "Off";
            this.rad_RandExpOff.UseVisualStyleBackColor = true;
            this.rad_RandExpOff.CheckedChanged += new System.EventHandler(this.determineFlags);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1017, 506);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Treasures & Equipment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chk_AddRemakeEq
            // 
            this.chk_AddRemakeEq.AutoSize = true;
            this.chk_AddRemakeEq.Location = new System.Drawing.Point(300, 195);
            this.chk_AddRemakeEq.Name = "chk_AddRemakeEq";
            this.chk_AddRemakeEq.Size = new System.Drawing.Size(209, 24);
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
            this.chk_RmRedundKey.Location = new System.Drawing.Point(10, 75);
            this.chk_RmRedundKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RmRedundKey.Name = "chk_RmRedundKey";
            this.chk_RmRedundKey.Size = new System.Drawing.Size(216, 24);
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
            this.chk_AdjustEqpPrices.Location = new System.Drawing.Point(300, 75);
            this.chk_AdjustEqpPrices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_AdjustEqpPrices.Name = "chk_AdjustEqpPrices";
            this.chk_AdjustEqpPrices.Size = new System.Drawing.Size(322, 24);
            this.chk_AdjustEqpPrices.TabIndex = 118;
            this.chk_AdjustEqpPrices.Text = "Adjust equipment prices based on power";
            this.adjustments.SetToolTip(this.chk_AdjustEqpPrices, "Adjusts equipment prices based on power of equipment.");
            this.chk_AdjustEqpPrices.UseVisualStyleBackColor = true;
            this.chk_AdjustEqpPrices.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_GreenSilverOrb
            // 
            this.chk_GreenSilverOrb.AutoSize = true;
            this.chk_GreenSilverOrb.Location = new System.Drawing.Point(10, 225);
            this.chk_GreenSilverOrb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_GreenSilverOrb.Name = "chk_GreenSilverOrb";
            this.chk_GreenSilverOrb.Size = new System.Drawing.Size(190, 24);
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
            this.chk_UseVanEquipValues.Location = new System.Drawing.Point(300, 105);
            this.chk_UseVanEquipValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_UseVanEquipValues.Name = "chk_UseVanEquipValues";
            this.chk_UseVanEquipValues.Size = new System.Drawing.Size(301, 24);
            this.chk_UseVanEquipValues.TabIndex = 119;
            this.chk_UseVanEquipValues.Text = "Use vanilla values for equipment stats";
            this.adjustments.SetToolTip(this.chk_UseVanEquipValues, "Randomizes equipment stats based on Vanilla game values");
            this.chk_UseVanEquipValues.UseVisualStyleBackColor = true;
            this.chk_UseVanEquipValues.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RmFighterPenalty
            // 
            this.chk_RmFighterPenalty.AutoSize = true;
            this.chk_RmFighterPenalty.Location = new System.Drawing.Point(300, 165);
            this.chk_RmFighterPenalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RmFighterPenalty.Name = "chk_RmFighterPenalty";
            this.chk_RmFighterPenalty.Size = new System.Drawing.Size(268, 24);
            this.chk_RmFighterPenalty.TabIndex = 121;
            this.chk_RmFighterPenalty.Text = "Remove Fighter Weapon Penalty";
            this.adjustments.SetToolTip(this.chk_RmFighterPenalty, "Removes attack power penalty from some equipment the Fighter can equip.");
            this.chk_RmFighterPenalty.UseVisualStyleBackColor = true;
            this.chk_RmFighterPenalty.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // lbl_TreasurePool
            // 
            this.lbl_TreasurePool.AutoSize = true;
            this.lbl_TreasurePool.Location = new System.Drawing.Point(54, 165);
            this.lbl_TreasurePool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TreasurePool.Name = "lbl_TreasurePool";
            this.lbl_TreasurePool.Size = new System.Drawing.Size(158, 20);
            this.lbl_TreasurePool.TabIndex = 113;
            this.lbl_TreasurePool.Text = "Add to Treasure Pool";
            // 
            // chk_RemoveStartEqRestrictions
            // 
            this.chk_RemoveStartEqRestrictions.AutoSize = true;
            this.chk_RemoveStartEqRestrictions.Location = new System.Drawing.Point(300, 135);
            this.chk_RemoveStartEqRestrictions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RemoveStartEqRestrictions.Name = "chk_RemoveStartEqRestrictions";
            this.chk_RemoveStartEqRestrictions.Size = new System.Drawing.Size(323, 24);
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
            this.chk_GoldenClaw.Location = new System.Drawing.Point(10, 195);
            this.chk_GoldenClaw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_GoldenClaw.Name = "chk_GoldenClaw";
            this.chk_GoldenClaw.Size = new System.Drawing.Size(125, 24);
            this.chk_GoldenClaw.TabIndex = 114;
            this.chk_GoldenClaw.Text = "Golden Claw";
            this.adjustments.SetToolTip(this.chk_GoldenClaw, "Adds the Golden Claw to 1 random treasure chest");
            this.chk_GoldenClaw.UseVisualStyleBackColor = true;
            this.chk_GoldenClaw.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandEquip
            // 
            this.chkRandEquip.AutoSize = true;
            this.chkRandEquip.Location = new System.Drawing.Point(300, 45);
            this.chkRandEquip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRandEquip.Name = "chkRandEquip";
            this.chkRandEquip.Size = new System.Drawing.Size(242, 24);
            this.chkRandEquip.TabIndex = 117;
            this.chkRandEquip.Text = "Randomize equipment power";
            this.adjustments.SetToolTip(this.chkRandEquip, "Randomizes weapon and armor power.");
            this.chkRandEquip.UseVisualStyleBackColor = true;
            this.chkRandEquip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandWhoCanEquip
            // 
            this.chkRandWhoCanEquip.AutoSize = true;
            this.chkRandWhoCanEquip.Location = new System.Drawing.Point(300, 15);
            this.chkRandWhoCanEquip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRandWhoCanEquip.Name = "chkRandWhoCanEquip";
            this.chkRandWhoCanEquip.Size = new System.Drawing.Size(222, 24);
            this.chkRandWhoCanEquip.TabIndex = 116;
            this.chkRandWhoCanEquip.Text = "Randomize who can equip";
            this.adjustments.SetToolTip(this.chkRandWhoCanEquip, "Randomizes which classes can equip equipment.");
            this.chkRandWhoCanEquip.UseVisualStyleBackColor = true;
            this.chkRandWhoCanEquip.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandItemEffects
            // 
            this.chkRandItemEffects.AutoSize = true;
            this.chkRandItemEffects.Location = new System.Drawing.Point(10, 15);
            this.chkRandItemEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRandItemEffects.Name = "chkRandItemEffects";
            this.chkRandItemEffects.Size = new System.Drawing.Size(203, 24);
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
            this.chkRandTreasures.Location = new System.Drawing.Point(10, 45);
            this.chkRandTreasures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRandTreasures.Name = "chkRandTreasures";
            this.chkRandTreasures.Size = new System.Drawing.Size(187, 24);
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
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1017, 506);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Item & Weapon Shops & Inns";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chk_sellUnsellItems
            // 
            this.chk_sellUnsellItems.AutoSize = true;
            this.chk_sellUnsellItems.Location = new System.Drawing.Point(10, 135);
            this.chk_sellUnsellItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_sellUnsellItems.Name = "chk_sellUnsellItems";
            this.chk_sellUnsellItems.Size = new System.Drawing.Size(183, 24);
            this.chk_sellUnsellItems.TabIndex = 133;
            this.chk_sellUnsellItems.Text = "Sell Unsellable Items";
            this.adjustments.SetToolTip(this.chk_sellUnsellItems, "Sell unsellable items at item shops. Important key items cannot be sold.");
            this.chk_sellUnsellItems.UseVisualStyleBackColor = true;
            this.chk_sellUnsellItems.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_LeafoftheWorldTree
            // 
            this.chk_LeafoftheWorldTree.AutoSize = true;
            this.chk_LeafoftheWorldTree.Location = new System.Drawing.Point(472, 45);
            this.chk_LeafoftheWorldTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_LeafoftheWorldTree.Name = "chk_LeafoftheWorldTree";
            this.chk_LeafoftheWorldTree.Size = new System.Drawing.Size(193, 24);
            this.chk_LeafoftheWorldTree.TabIndex = 142;
            this.chk_LeafoftheWorldTree.Text = "Leaf of the World Tree";
            this.chk_LeafoftheWorldTree.UseVisualStyleBackColor = true;
            this.chk_LeafoftheWorldTree.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomizeWeaponShops
            // 
            this.chk_RandomizeWeaponShops.AutoSize = true;
            this.chk_RandomizeWeaponShops.Location = new System.Drawing.Point(10, 105);
            this.chk_RandomizeWeaponShops.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandomizeWeaponShops.Name = "chk_RandomizeWeaponShops";
            this.chk_RandomizeWeaponShops.Size = new System.Drawing.Size(230, 24);
            this.chk_RandomizeWeaponShops.TabIndex = 132;
            this.chk_RandomizeWeaponShops.Text = "Randomize Weapon Shops";
            this.chk_RandomizeWeaponShops.UseVisualStyleBackColor = true;
            this.chk_RandomizeWeaponShops.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_LampofDarkness
            // 
            this.chk_LampofDarkness.AutoSize = true;
            this.chk_LampofDarkness.Location = new System.Drawing.Point(472, 165);
            this.chk_LampofDarkness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_LampofDarkness.Name = "chk_LampofDarkness";
            this.chk_LampofDarkness.Size = new System.Drawing.Size(165, 24);
            this.chk_LampofDarkness.TabIndex = 146;
            this.chk_LampofDarkness.Text = "Lamp of Darkness";
            this.chk_LampofDarkness.UseVisualStyleBackColor = true;
            this.chk_LampofDarkness.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_WizardsRing
            // 
            this.chk_WizardsRing.AutoSize = true;
            this.chk_WizardsRing.Location = new System.Drawing.Point(472, 135);
            this.chk_WizardsRing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_WizardsRing.Name = "chk_WizardsRing";
            this.chk_WizardsRing.Size = new System.Drawing.Size(132, 24);
            this.chk_WizardsRing.TabIndex = 145;
            this.chk_WizardsRing.Text = "Wizard\'s Ring";
            this.chk_WizardsRing.UseVisualStyleBackColor = true;
            this.chk_WizardsRing.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_MeteoriteArmband
            // 
            this.chk_MeteoriteArmband.AutoSize = true;
            this.chk_MeteoriteArmband.Location = new System.Drawing.Point(472, 105);
            this.chk_MeteoriteArmband.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_MeteoriteArmband.Name = "chk_MeteoriteArmband";
            this.chk_MeteoriteArmband.Size = new System.Drawing.Size(171, 24);
            this.chk_MeteoriteArmband.TabIndex = 144;
            this.chk_MeteoriteArmband.Text = "Meteorite Armband";
            this.chk_MeteoriteArmband.UseVisualStyleBackColor = true;
            this.chk_MeteoriteArmband.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_ShoesofHappiness
            // 
            this.chk_ShoesofHappiness.AutoSize = true;
            this.chk_ShoesofHappiness.Location = new System.Drawing.Point(472, 75);
            this.chk_ShoesofHappiness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_ShoesofHappiness.Name = "chk_ShoesofHappiness";
            this.chk_ShoesofHappiness.Size = new System.Drawing.Size(179, 24);
            this.chk_ShoesofHappiness.TabIndex = 143;
            this.chk_ShoesofHappiness.Text = "Shoes of Happiness";
            this.chk_ShoesofHappiness.UseVisualStyleBackColor = true;
            this.chk_ShoesofHappiness.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // lbl_ItemShops
            // 
            this.lbl_ItemShops.AutoSize = true;
            this.lbl_ItemShops.Location = new System.Drawing.Point(402, 15);
            this.lbl_ItemShops.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ItemShops.Name = "lbl_ItemShops";
            this.lbl_ItemShops.Size = new System.Drawing.Size(142, 20);
            this.lbl_ItemShops.TabIndex = 135;
            this.lbl_ItemShops.Text = "Add to Item Shops";
            // 
            // chk_SilverHarp
            // 
            this.chk_SilverHarp.AutoSize = true;
            this.chk_SilverHarp.Location = new System.Drawing.Point(308, 195);
            this.chk_SilverHarp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_SilverHarp.Name = "chk_SilverHarp";
            this.chk_SilverHarp.Size = new System.Drawing.Size(112, 24);
            this.chk_SilverHarp.TabIndex = 141;
            this.chk_SilverHarp.Text = "Silver Harp";
            this.chk_SilverHarp.UseVisualStyleBackColor = true;
            this.chk_SilverHarp.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_EchoingFlute
            // 
            this.chk_EchoingFlute.AutoSize = true;
            this.chk_EchoingFlute.Location = new System.Drawing.Point(308, 165);
            this.chk_EchoingFlute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_EchoingFlute.Name = "chk_EchoingFlute";
            this.chk_EchoingFlute.Size = new System.Drawing.Size(133, 24);
            this.chk_EchoingFlute.TabIndex = 140;
            this.chk_EchoingFlute.Text = "Echoing Flute";
            this.chk_EchoingFlute.UseVisualStyleBackColor = true;
            this.chk_EchoingFlute.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RingofLife
            // 
            this.chk_RingofLife.AutoSize = true;
            this.chk_RingofLife.Location = new System.Drawing.Point(308, 135);
            this.chk_RingofLife.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RingofLife.Name = "chk_RingofLife";
            this.chk_RingofLife.Size = new System.Drawing.Size(116, 24);
            this.chk_RingofLife.TabIndex = 139;
            this.chk_RingofLife.Text = "Ring of Life";
            this.chk_RingofLife.UseVisualStyleBackColor = true;
            this.chk_RingofLife.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_BookofSatori
            // 
            this.chk_BookofSatori.AutoSize = true;
            this.chk_BookofSatori.Location = new System.Drawing.Point(308, 105);
            this.chk_BookofSatori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_BookofSatori.Name = "chk_BookofSatori";
            this.chk_BookofSatori.Size = new System.Drawing.Size(136, 24);
            this.chk_BookofSatori.TabIndex = 138;
            this.chk_BookofSatori.Text = "Book of Satori";
            this.chk_BookofSatori.UseVisualStyleBackColor = true;
            this.chk_BookofSatori.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_Seeds
            // 
            this.chk_Seeds.AutoSize = true;
            this.chk_Seeds.Location = new System.Drawing.Point(308, 75);
            this.chk_Seeds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_Seeds.Name = "chk_Seeds";
            this.chk_Seeds.Size = new System.Drawing.Size(81, 24);
            this.chk_Seeds.TabIndex = 137;
            this.chk_Seeds.Text = "Seeds";
            this.chk_Seeds.UseVisualStyleBackColor = true;
            this.chk_Seeds.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_StoneofLife
            // 
            this.chk_StoneofLife.AutoSize = true;
            this.chk_StoneofLife.Location = new System.Drawing.Point(308, 45);
            this.chk_StoneofLife.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_StoneofLife.Name = "chk_StoneofLife";
            this.chk_StoneofLife.Size = new System.Drawing.Size(126, 24);
            this.chk_StoneofLife.TabIndex = 136;
            this.chk_StoneofLife.Text = "Stone of Life";
            this.chk_StoneofLife.UseVisualStyleBackColor = true;
            this.chk_StoneofLife.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandItemStores
            // 
            this.chkRandItemStores.AutoSize = true;
            this.chkRandItemStores.Location = new System.Drawing.Point(10, 75);
            this.chkRandItemStores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRandItemStores.Name = "chkRandItemStores";
            this.chkRandItemStores.Size = new System.Drawing.Size(202, 24);
            this.chkRandItemStores.TabIndex = 131;
            this.chkRandItemStores.Text = "Randomize Item Shops";
            this.chkRandItemStores.UseVisualStyleBackColor = true;
            this.chkRandItemStores.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_Caturday
            // 
            this.chk_Caturday.AutoSize = true;
            this.chk_Caturday.Location = new System.Drawing.Point(10, 165);
            this.chk_Caturday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_Caturday.Name = "chk_Caturday";
            this.chk_Caturday.Size = new System.Drawing.Size(99, 24);
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
            this.chk_PoisonMothPowder.Location = new System.Drawing.Point(472, 195);
            this.chk_PoisonMothPowder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_PoisonMothPowder.Name = "chk_PoisonMothPowder";
            this.chk_PoisonMothPowder.Size = new System.Drawing.Size(180, 24);
            this.chk_PoisonMothPowder.TabIndex = 147;
            this.chk_PoisonMothPowder.Text = "Poison Moth Powder";
            this.chk_PoisonMothPowder.UseVisualStyleBackColor = true;
            this.chk_PoisonMothPowder.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomizeInnPrices
            // 
            this.chk_RandomizeInnPrices.AutoSize = true;
            this.chk_RandomizeInnPrices.Location = new System.Drawing.Point(10, 45);
            this.chk_RandomizeInnPrices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandomizeInnPrices.Name = "chk_RandomizeInnPrices";
            this.chk_RandomizeInnPrices.Size = new System.Drawing.Size(190, 24);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1017, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Characters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chk_nonMagicMP
            // 
            this.chk_nonMagicMP.AutoSize = true;
            this.chk_nonMagicMP.Location = new System.Drawing.Point(542, 180);
            this.chk_nonMagicMP.Name = "chk_nonMagicMP";
            this.chk_nonMagicMP.Size = new System.Drawing.Size(214, 24);
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
            this.grpMonsterStat.Location = new System.Drawing.Point(220, 165);
            this.grpMonsterStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMonsterStat.Name = "grpMonsterStat";
            this.grpMonsterStat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMonsterStat.Size = new System.Drawing.Size(304, 43);
            this.grpMonsterStat.TabIndex = 27;
            this.grpMonsterStat.TabStop = false;
            // 
            // optStatSilly
            // 
            this.optStatSilly.AutoSize = true;
            this.optStatSilly.Checked = true;
            this.optStatSilly.Location = new System.Drawing.Point(8, 12);
            this.optStatSilly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optStatSilly.Name = "optStatSilly";
            this.optStatSilly.Size = new System.Drawing.Size(61, 24);
            this.optStatSilly.TabIndex = 174;
            this.optStatSilly.TabStop = true;
            this.optStatSilly.Text = "Silly";
            this.optStatSilly.UseVisualStyleBackColor = true;
            this.optStatSilly.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optStatHeavy
            // 
            this.optStatHeavy.AutoSize = true;
            this.optStatHeavy.Location = new System.Drawing.Point(195, 12);
            this.optStatHeavy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optStatHeavy.Name = "optStatHeavy";
            this.optStatHeavy.Size = new System.Drawing.Size(103, 24);
            this.optStatHeavy.TabIndex = 176;
            this.optStatHeavy.Text = "Ludicrous";
            this.optStatHeavy.UseVisualStyleBackColor = true;
            this.optStatHeavy.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optStatMedium
            // 
            this.optStatMedium.AutoSize = true;
            this.optStatMedium.Location = new System.Drawing.Point(80, 12);
            this.optStatMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optStatMedium.Name = "optStatMedium";
            this.optStatMedium.Size = new System.Drawing.Size(107, 24);
            this.optStatMedium.TabIndex = 175;
            this.optStatMedium.Text = "Ridiculous";
            this.optStatMedium.UseVisualStyleBackColor = true;
            this.optStatMedium.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_ChangeDefaultParty
            // 
            this.chk_ChangeDefaultParty.AutoSize = true;
            this.chk_ChangeDefaultParty.Location = new System.Drawing.Point(10, 15);
            this.chk_ChangeDefaultParty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_ChangeDefaultParty.Name = "chk_ChangeDefaultParty";
            this.chk_ChangeDefaultParty.Size = new System.Drawing.Size(257, 24);
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
            this.chkFourJobFiesta.Location = new System.Drawing.Point(460, 215);
            this.chkFourJobFiesta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFourJobFiesta.Name = "chkFourJobFiesta";
            this.chkFourJobFiesta.Size = new System.Drawing.Size(237, 24);
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
            this.chkRandStatGains.Location = new System.Drawing.Point(10, 180);
            this.chkRandStatGains.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRandStatGains.Name = "chkRandStatGains";
            this.chkRandStatGains.Size = new System.Drawing.Size(189, 24);
            this.chkRandStatGains.TabIndex = 173;
            this.chkRandStatGains.Text = "Randomize stat gains";
            this.adjustments.SetToolTip(this.chkRandStatGains, "Randomizes stats gained by classes at level up.");
            this.chkRandStatGains.UseVisualStyleBackColor = true;
            this.chkRandStatGains.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandSpellStrength
            // 
            this.chkRandSpellStrength.AutoSize = true;
            this.chkRandSpellStrength.Location = new System.Drawing.Point(230, 215);
            this.chkRandSpellStrength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRandSpellStrength.Name = "chkRandSpellStrength";
            this.chkRandSpellStrength.Size = new System.Drawing.Size(223, 24);
            this.chkRandSpellStrength.TabIndex = 179;
            this.chkRandSpellStrength.Text = "Randomize spell strengths";
            this.adjustments.SetToolTip(this.chkRandSpellStrength, "Randomizes the strength of spells.");
            this.chkRandSpellStrength.UseVisualStyleBackColor = true;
            this.chkRandSpellStrength.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chkRandSpellLearning
            // 
            this.chkRandSpellLearning.AutoSize = true;
            this.chkRandSpellLearning.Location = new System.Drawing.Point(10, 215);
            this.chkRandSpellLearning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRandSpellLearning.Name = "chkRandSpellLearning";
            this.chkRandSpellLearning.Size = new System.Drawing.Size(212, 24);
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
            this.chk_RandHero.Location = new System.Drawing.Point(808, 135);
            this.chk_RandHero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandHero.Name = "chk_RandHero";
            this.chk_RandHero.Size = new System.Drawing.Size(70, 24);
            this.chk_RandHero.TabIndex = 171;
            this.chk_RandHero.Text = "Hero";
            this.chk_RandHero.UseVisualStyleBackColor = true;
            this.chk_RandHero.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSage
            // 
            this.chk_RandSage.AutoSize = true;
            this.chk_RandSage.Location = new System.Drawing.Point(808, 105);
            this.chk_RandSage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandSage.Name = "chk_RandSage";
            this.chk_RandSage.Size = new System.Drawing.Size(73, 24);
            this.chk_RandSage.TabIndex = 170;
            this.chk_RandSage.Text = "Sage";
            this.chk_RandSage.UseVisualStyleBackColor = true;
            this.chk_RandSage.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandGoofOff
            // 
            this.chk_RandGoofOff.AutoSize = true;
            this.chk_RandGoofOff.Location = new System.Drawing.Point(808, 75);
            this.chk_RandGoofOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandGoofOff.Name = "chk_RandGoofOff";
            this.chk_RandGoofOff.Size = new System.Drawing.Size(98, 24);
            this.chk_RandGoofOff.TabIndex = 169;
            this.chk_RandGoofOff.Text = "Goof-Off";
            this.chk_RandGoofOff.UseVisualStyleBackColor = true;
            this.chk_RandGoofOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandMerchant
            // 
            this.chk_RandMerchant.AutoSize = true;
            this.chk_RandMerchant.Location = new System.Drawing.Point(808, 45);
            this.chk_RandMerchant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandMerchant.Name = "chk_RandMerchant";
            this.chk_RandMerchant.Size = new System.Drawing.Size(102, 24);
            this.chk_RandMerchant.TabIndex = 168;
            this.chk_RandMerchant.Text = "Merchant";
            this.chk_RandMerchant.UseVisualStyleBackColor = true;
            this.chk_RandMerchant.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandFighter
            // 
            this.chk_RandFighter.AutoSize = true;
            this.chk_RandFighter.Location = new System.Drawing.Point(698, 135);
            this.chk_RandFighter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandFighter.Name = "chk_RandFighter";
            this.chk_RandFighter.Size = new System.Drawing.Size(85, 24);
            this.chk_RandFighter.TabIndex = 167;
            this.chk_RandFighter.Text = "Fighter";
            this.chk_RandFighter.UseVisualStyleBackColor = true;
            this.chk_RandFighter.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandWizard
            // 
            this.chk_RandWizard.Location = new System.Drawing.Point(698, 105);
            this.chk_RandWizard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandWizard.Name = "chk_RandWizard";
            this.chk_RandWizard.Size = new System.Drawing.Size(102, 26);
            this.chk_RandWizard.TabIndex = 166;
            this.chk_RandWizard.Text = "Wizard";
            this.chk_RandWizard.UseVisualStyleBackColor = true;
            this.chk_RandWizard.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandPilgrim
            // 
            this.chk_RandPilgrim.AutoSize = true;
            this.chk_RandPilgrim.Location = new System.Drawing.Point(698, 75);
            this.chk_RandPilgrim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandPilgrim.Name = "chk_RandPilgrim";
            this.chk_RandPilgrim.Size = new System.Drawing.Size(81, 24);
            this.chk_RandPilgrim.TabIndex = 165;
            this.chk_RandPilgrim.Text = "Pilgrim";
            this.chk_RandPilgrim.UseVisualStyleBackColor = true;
            this.chk_RandPilgrim.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandSoldier
            // 
            this.chk_RandSoldier.AutoSize = true;
            this.chk_RandSoldier.Location = new System.Drawing.Point(698, 45);
            this.chk_RandSoldier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandSoldier.Name = "chk_RandSoldier";
            this.chk_RandSoldier.Size = new System.Drawing.Size(84, 24);
            this.chk_RandSoldier.TabIndex = 164;
            this.chk_RandSoldier.Text = "Soldier";
            this.chk_RandSoldier.UseVisualStyleBackColor = true;
            this.chk_RandSoldier.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomGender
            // 
            this.chk_RandomGender.AutoSize = true;
            this.chk_RandomGender.Location = new System.Drawing.Point(234, 45);
            this.chk_RandomGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandomGender.Name = "chk_RandomGender";
            this.chk_RandomGender.Size = new System.Drawing.Size(174, 24);
            this.chk_RandomGender.TabIndex = 152;
            this.chk_RandomGender.Text = "Randomize Gender";
            this.adjustments.SetToolTip(this.chk_RandomGender, "Randomizes gender of party members.");
            this.chk_RandomGender.UseVisualStyleBackColor = true;
            this.chk_RandomGender.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomClass
            // 
            this.chk_RandomClass.AutoSize = true;
            this.chk_RandomClass.Location = new System.Drawing.Point(468, 45);
            this.chk_RandomClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandomClass.Name = "chk_RandomClass";
            this.chk_RandomClass.Size = new System.Drawing.Size(159, 24);
            this.chk_RandomClass.TabIndex = 153;
            this.chk_RandomClass.Text = "Randomize Class";
            this.adjustments.SetToolTip(this.chk_RandomClass, "Randomizes the class of party members.");
            this.chk_RandomClass.UseVisualStyleBackColor = true;
            this.chk_RandomClass.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // chk_RandomName
            // 
            this.chk_RandomName.AutoSize = true;
            this.chk_RandomName.Location = new System.Drawing.Point(10, 45);
            this.chk_RandomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandomName.Name = "chk_RandomName";
            this.chk_RandomName.Size = new System.Drawing.Size(170, 24);
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
            this.cboGender3.Location = new System.Drawing.Point(234, 135);
            this.cboGender3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGender3.Name = "cboGender3";
            this.cboGender3.Size = new System.Drawing.Size(223, 28);
            this.cboGender3.TabIndex = 160;
            // 
            // cboGender2
            // 
            this.cboGender2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender2.FormattingEnabled = true;
            this.cboGender2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender2.Location = new System.Drawing.Point(234, 105);
            this.cboGender2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGender2.Name = "cboGender2";
            this.cboGender2.Size = new System.Drawing.Size(223, 28);
            this.cboGender2.TabIndex = 159;
            // 
            // cboGender1
            // 
            this.cboGender1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender1.FormattingEnabled = true;
            this.cboGender1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender1.Location = new System.Drawing.Point(234, 75);
            this.cboGender1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGender1.Name = "cboGender1";
            this.cboGender1.Size = new System.Drawing.Size(223, 28);
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
            this.cboClass3.Location = new System.Drawing.Point(468, 135);
            this.cboClass3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboClass3.Name = "cboClass3";
            this.cboClass3.Size = new System.Drawing.Size(205, 28);
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
            this.cboClass2.Location = new System.Drawing.Point(468, 105);
            this.cboClass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboClass2.Name = "cboClass2";
            this.cboClass2.Size = new System.Drawing.Size(205, 28);
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
            this.cboClass1.Location = new System.Drawing.Point(468, 75);
            this.cboClass1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboClass1.Name = "cboClass1";
            this.cboClass1.Size = new System.Drawing.Size(205, 28);
            this.cboClass1.TabIndex = 161;
            this.cboClass1.SelectedIndexChanged += new System.EventHandler(this.cboClass1_SelectedIndexChanged);
            // 
            // txtCharName2
            // 
            this.txtCharName2.Location = new System.Drawing.Point(10, 105);
            this.txtCharName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCharName2.MaxLength = 8;
            this.txtCharName2.Name = "txtCharName2";
            this.txtCharName2.Size = new System.Drawing.Size(212, 26);
            this.txtCharName2.TabIndex = 155;
            // 
            // txtCharName3
            // 
            this.txtCharName3.Location = new System.Drawing.Point(10, 135);
            this.txtCharName3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCharName3.MaxLength = 8;
            this.txtCharName3.Name = "txtCharName3";
            this.txtCharName3.Size = new System.Drawing.Size(212, 26);
            this.txtCharName3.TabIndex = 156;
            // 
            // txtCharName1
            // 
            this.txtCharName1.Location = new System.Drawing.Point(10, 75);
            this.txtCharName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCharName1.MaxLength = 8;
            this.txtCharName1.Name = "txtCharName1";
            this.txtCharName1.Size = new System.Drawing.Size(212, 26);
            this.txtCharName1.TabIndex = 154;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.grp_FixHeroSpell);
            this.tabPage5.Controls.Add(this.grp_RmParryBug);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Size = new System.Drawing.Size(1017, 506);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fixes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // grp_FixHeroSpell
            // 
            this.grp_FixHeroSpell.Controls.Add(this.rad_FixHeroSpellRand);
            this.grp_FixHeroSpell.Controls.Add(this.rad_FixHeroSpellOn);
            this.grp_FixHeroSpell.Controls.Add(this.rad_FixHeroSpellOff);
            this.grp_FixHeroSpell.Location = new System.Drawing.Point(259, 6);
            this.grp_FixHeroSpell.Name = "grp_FixHeroSpell";
            this.grp_FixHeroSpell.Size = new System.Drawing.Size(244, 63);
            this.grp_FixHeroSpell.TabIndex = 193;
            this.grp_FixHeroSpell.TabStop = false;
            this.grp_FixHeroSpell.Text = "Fix Hero Spell Glitch";
            this.adjustments.SetToolTip(this.grp_FixHeroSpell, "Fixes Hero spell overflow glitch when creating too many party members");
            // 
            // rad_FixHeroSpellRand
            // 
            this.rad_FixHeroSpellRand.AutoSize = true;
            this.rad_FixHeroSpellRand.Location = new System.Drawing.Point(129, 25);
            this.rad_FixHeroSpellRand.Name = "rad_FixHeroSpellRand";
            this.rad_FixHeroSpellRand.Size = new System.Drawing.Size(95, 24);
            this.rad_FixHeroSpellRand.TabIndex = 2;
            this.rad_FixHeroSpellRand.Text = "Random";
            this.rad_FixHeroSpellRand.UseVisualStyleBackColor = true;
            this.rad_FixHeroSpellRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_FixHeroSpellOn
            // 
            this.rad_FixHeroSpellOn.AutoSize = true;
            this.rad_FixHeroSpellOn.Location = new System.Drawing.Point(68, 25);
            this.rad_FixHeroSpellOn.Name = "rad_FixHeroSpellOn";
            this.rad_FixHeroSpellOn.Size = new System.Drawing.Size(55, 24);
            this.rad_FixHeroSpellOn.TabIndex = 1;
            this.rad_FixHeroSpellOn.Text = "On";
            this.rad_FixHeroSpellOn.UseVisualStyleBackColor = true;
            this.rad_FixHeroSpellOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_FixHeroSpellOff
            // 
            this.rad_FixHeroSpellOff.AutoSize = true;
            this.rad_FixHeroSpellOff.Checked = true;
            this.rad_FixHeroSpellOff.Location = new System.Drawing.Point(6, 25);
            this.rad_FixHeroSpellOff.Name = "rad_FixHeroSpellOff";
            this.rad_FixHeroSpellOff.Size = new System.Drawing.Size(56, 24);
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
            this.grp_RmParryBug.Location = new System.Drawing.Point(6, 6);
            this.grp_RmParryBug.Name = "grp_RmParryBug";
            this.grp_RmParryBug.Size = new System.Drawing.Size(244, 63);
            this.grp_RmParryBug.TabIndex = 192;
            this.grp_RmParryBug.TabStop = false;
            this.grp_RmParryBug.Text = "Remove Parry/Fight Bug";
            this.adjustments.SetToolTip(this.grp_RmParryBug, "Removes stacking of Parry with Fight command");
            // 
            // rad_RmParryBugRand
            // 
            this.rad_RmParryBugRand.AutoSize = true;
            this.rad_RmParryBugRand.Location = new System.Drawing.Point(129, 25);
            this.rad_RmParryBugRand.Name = "rad_RmParryBugRand";
            this.rad_RmParryBugRand.Size = new System.Drawing.Size(95, 24);
            this.rad_RmParryBugRand.TabIndex = 2;
            this.rad_RmParryBugRand.Text = "Random";
            this.rad_RmParryBugRand.UseVisualStyleBackColor = true;
            this.rad_RmParryBugRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmParryBugOn
            // 
            this.rad_RmParryBugOn.AutoSize = true;
            this.rad_RmParryBugOn.Location = new System.Drawing.Point(68, 25);
            this.rad_RmParryBugOn.Name = "rad_RmParryBugOn";
            this.rad_RmParryBugOn.Size = new System.Drawing.Size(55, 24);
            this.rad_RmParryBugOn.TabIndex = 1;
            this.rad_RmParryBugOn.Text = "On";
            this.rad_RmParryBugOn.UseVisualStyleBackColor = true;
            this.rad_RmParryBugOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmParryBugOff
            // 
            this.rad_RmParryBugOff.AutoSize = true;
            this.rad_RmParryBugOff.Checked = true;
            this.rad_RmParryBugOff.Location = new System.Drawing.Point(6, 25);
            this.rad_RmParryBugOff.Name = "rad_RmParryBugOff";
            this.rad_RmParryBugOff.Size = new System.Drawing.Size(56, 24);
            this.rad_RmParryBugOff.TabIndex = 0;
            this.rad_RmParryBugOff.TabStop = true;
            this.rad_RmParryBugOff.Text = "Off";
            this.rad_RmParryBugOff.UseVisualStyleBackColor = true;
            this.rad_RmParryBugOff.CheckedChanged += new System.EventHandler(this.determineFlags);
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
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Size = new System.Drawing.Size(1017, 506);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Cosmetic";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(716, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(215, 20);
            this.label17.TabIndex = 230;
            this.label17.Text = "Sprite Change - Flag Change";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(480, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 20);
            this.label16.TabIndex = 220;
            this.label16.Text = "Sprite Change";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(249, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 20);
            this.label15.TabIndex = 210;
            this.label15.Text = "Text Adjust - Flag Change";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 201;
            this.label13.Text = "Text Adjust";
            // 
            // chk_levelUpText
            // 
            this.chk_levelUpText.AutoSize = true;
            this.chk_levelUpText.Location = new System.Drawing.Point(249, 45);
            this.chk_levelUpText.Name = "chk_levelUpText";
            this.chk_levelUpText.Size = new System.Drawing.Size(191, 24);
            this.chk_levelUpText.TabIndex = 211;
            this.chk_levelUpText.Text = "Change Level Up Text";
            this.chk_levelUpText.UseVisualStyleBackColor = true;
            // 
            // chk_FemaleHero
            // 
            this.chk_FemaleHero.AutoSize = true;
            this.chk_FemaleHero.Location = new System.Drawing.Point(480, 45);
            this.chk_FemaleHero.Name = "chk_FemaleHero";
            this.chk_FemaleHero.Size = new System.Drawing.Size(181, 24);
            this.chk_FemaleHero.TabIndex = 221;
            this.chk_FemaleHero.Text = "Female Hero Sprites";
            this.adjustments.SetToolTip(this.chk_FemaleHero, "Selects female sprites for the Hero Sprite. (Does not affect gameplay. Choose Fem" +
        "ale as sex at start to add equipment benefits.)");
            this.chk_FemaleHero.UseVisualStyleBackColor = true;
            // 
            // chk_RandNPCSprites
            // 
            this.chk_RandNPCSprites.AutoSize = true;
            this.chk_RandNPCSprites.Location = new System.Drawing.Point(480, 135);
            this.chk_RandNPCSprites.Name = "chk_RandNPCSprites";
            this.chk_RandNPCSprites.Size = new System.Drawing.Size(206, 24);
            this.chk_RandNPCSprites.TabIndex = 224;
            this.chk_RandNPCSprites.Text = "Randomize NPC Sprites";
            this.chk_RandNPCSprites.UseVisualStyleBackColor = true;
            // 
            // chk_FFigherSprite
            // 
            this.chk_FFigherSprite.AutoSize = true;
            this.chk_FFigherSprite.Location = new System.Drawing.Point(480, 105);
            this.chk_FFigherSprite.Name = "chk_FFigherSprite";
            this.chk_FFigherSprite.Size = new System.Drawing.Size(212, 24);
            this.chk_FFigherSprite.TabIndex = 223;
            this.chk_FFigherSprite.Text = "Female Fighter Sprite Fix";
            this.chk_FFigherSprite.UseVisualStyleBackColor = true;
            // 
            // chk_EveryoneCat
            // 
            this.chk_EveryoneCat.AutoSize = true;
            this.chk_EveryoneCat.Location = new System.Drawing.Point(480, 198);
            this.chk_EveryoneCat.Name = "chk_EveryoneCat";
            this.chk_EveryoneCat.Size = new System.Drawing.Size(155, 24);
            this.chk_EveryoneCat.TabIndex = 226;
            this.chk_EveryoneCat.Text = "Everyone is a cat";
            this.chk_EveryoneCat.UseVisualStyleBackColor = true;
            this.chk_EveryoneCat.Visible = false;
            // 
            // chk_changeCats
            // 
            this.chk_changeCats.AutoSize = true;
            this.chk_changeCats.Location = new System.Drawing.Point(480, 168);
            this.chk_changeCats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_changeCats.Name = "chk_changeCats";
            this.chk_changeCats.Size = new System.Drawing.Size(242, 24);
            this.chk_changeCats.TabIndex = 225;
            this.chk_changeCats.Text = "Change cats to other animals";
            this.adjustments.SetToolTip(this.chk_changeCats, "Changes cat sprites to other animals from other Dragon Warrior games.");
            this.chk_changeCats.UseVisualStyleBackColor = true;
            // 
            // chk_GhostToCasket
            // 
            this.chk_GhostToCasket.AutoSize = true;
            this.chk_GhostToCasket.Location = new System.Drawing.Point(716, 75);
            this.chk_GhostToCasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_GhostToCasket.Name = "chk_GhostToCasket";
            this.chk_GhostToCasket.Size = new System.Drawing.Size(227, 24);
            this.chk_GhostToCasket.TabIndex = 232;
            this.chk_GhostToCasket.Text = "Change Ghosts to Caskets";
            this.adjustments.SetToolTip(this.chk_GhostToCasket, "This will change dead party members from ghosts into caskets (palls) and adjusts " +
        "relevant text.");
            this.chk_GhostToCasket.UseVisualStyleBackColor = true;
            // 
            // chk_RandSpriteColor
            // 
            this.chk_RandSpriteColor.AutoSize = true;
            this.chk_RandSpriteColor.Location = new System.Drawing.Point(480, 75);
            this.chk_RandSpriteColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_RandSpriteColor.Name = "chk_RandSpriteColor";
            this.chk_RandSpriteColor.Size = new System.Drawing.Size(211, 24);
            this.chk_RandSpriteColor.TabIndex = 222;
            this.chk_RandSpriteColor.Text = "Randomize Sprite Colors";
            this.adjustments.SetToolTip(this.chk_RandSpriteColor, "Randomizes the colors of overworld sprites. There may be some interesting combina" +
        "tions.");
            this.chk_RandSpriteColor.UseVisualStyleBackColor = true;
            // 
            // chk_ChangeHeroAge
            // 
            this.chk_ChangeHeroAge.AutoSize = true;
            this.chk_ChangeHeroAge.Location = new System.Drawing.Point(716, 45);
            this.chk_ChangeHeroAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_ChangeHeroAge.Name = "chk_ChangeHeroAge";
            this.chk_ChangeHeroAge.Size = new System.Drawing.Size(174, 24);
            this.chk_ChangeHeroAge.TabIndex = 231;
            this.chk_ChangeHeroAge.Text = "Change Hero\'s Age";
            this.adjustments.SetToolTip(this.chk_ChangeHeroAge, "Changes the hero\'s age in opening to a random number and potentially the sprite b" +
        "ased on age.");
            this.chk_ChangeHeroAge.UseVisualStyleBackColor = true;
            // 
            // chk_LowerCaseMenus
            // 
            this.chk_LowerCaseMenus.AutoSize = true;
            this.chk_LowerCaseMenus.Location = new System.Drawing.Point(10, 45);
            this.chk_LowerCaseMenus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_LowerCaseMenus.Name = "chk_LowerCaseMenus";
            this.chk_LowerCaseMenus.Size = new System.Drawing.Size(194, 24);
            this.chk_LowerCaseMenus.TabIndex = 202;
            this.chk_LowerCaseMenus.Text = "Standard Case Menus";
            this.adjustments.SetToolTip(this.chk_LowerCaseMenus, "Changes casing of all caps menu items to standard caps and lower case.");
            this.chk_LowerCaseMenus.UseVisualStyleBackColor = true;
            // 
            // chk_FixSlimeSnail
            // 
            this.chk_FixSlimeSnail.AutoSize = true;
            this.chk_FixSlimeSnail.Location = new System.Drawing.Point(10, 75);
            this.chk_FixSlimeSnail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_FixSlimeSnail.Name = "chk_FixSlimeSnail";
            this.chk_FixSlimeSnail.Size = new System.Drawing.Size(137, 24);
            this.chk_FixSlimeSnail.TabIndex = 203;
            this.chk_FixSlimeSnail.Text = "Fix Slime Snail";
            this.adjustments.SetToolTip(this.chk_FixSlimeSnail, "Fixes Slime Snaii name to Slime Snail");
            this.chk_FixSlimeSnail.UseVisualStyleBackColor = true;
            this.chk_FixSlimeSnail.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Flags";
            // 
            // txtFlags
            // 
            this.txtFlags.Location = new System.Drawing.Point(176, 285);
            this.txtFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.Size = new System.Drawing.Size(656, 26);
            this.txtFlags.TabIndex = 31;
            this.txtFlags.Leave += new System.EventHandler(this.determineChecks);
            // 
            // chk_GenCompareFile
            // 
            this.chk_GenCompareFile.AutoSize = true;
            this.chk_GenCompareFile.Location = new System.Drawing.Point(326, 904);
            this.chk_GenCompareFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_GenCompareFile.Name = "chk_GenCompareFile";
            this.chk_GenCompareFile.Size = new System.Drawing.Size(201, 24);
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
            this.chk_GenIslandsMonstersZones.Location = new System.Drawing.Point(553, 904);
            this.chk_GenIslandsMonstersZones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_GenIslandsMonstersZones.Name = "chk_GenIslandsMonstersZones";
            this.chk_GenIslandsMonstersZones.Size = new System.Drawing.Size(344, 24);
            this.chk_GenIslandsMonstersZones.TabIndex = 231;
            this.chk_GenIslandsMonstersZones.Text = "Generate islands, monsters, and zones files";
            this.adjustments.SetToolTip(this.chk_GenIslandsMonstersZones, "Randomizes the healing effect of the Sage\'s Stone");
            this.chk_GenIslandsMonstersZones.UseVisualStyleBackColor = true;
            // 
            // btnCopyChecksum
            // 
            this.btnCopyChecksum.Location = new System.Drawing.Point(790, 155);
            this.btnCopyChecksum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCopyChecksum.Name = "btnCopyChecksum";
            this.btnCopyChecksum.Size = new System.Drawing.Size(184, 35);
            this.btnCopyChecksum.TabIndex = 15;
            this.btnCopyChecksum.Text = "Copy New Checksum";
            this.btnCopyChecksum.UseVisualStyleBackColor = true;
            this.btnCopyChecksum.Click += new System.EventHandler(this.btnCopyChecksum_Click);
            // 
            // lblNewChecksum
            // 
            this.lblNewChecksum.AutoSize = true;
            this.lblNewChecksum.Location = new System.Drawing.Point(176, 155);
            this.lblNewChecksum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewChecksum.Name = "lblNewChecksum";
            this.lblNewChecksum.Size = new System.Drawing.Size(369, 20);
            this.lblNewChecksum.TabIndex = 14;
            this.lblNewChecksum.Text = "????????????????????????????????????????";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 155);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "New Checksum";
            // 
            // grpFlags
            // 
            this.grpFlags.Controls.Add(this.optSotWFlags);
            this.grpFlags.Controls.Add(this.opt_JustForFun);
            this.grpFlags.Controls.Add(this.optTradSotWFlags);
            this.grpFlags.Controls.Add(this.optManualFlags);
            this.grpFlags.Location = new System.Drawing.Point(174, 222);
            this.grpFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFlags.Size = new System.Drawing.Size(608, 49);
            this.grpFlags.TabIndex = 20;
            this.grpFlags.TabStop = false;
            // 
            // optSotWFlags
            // 
            this.optSotWFlags.AutoSize = true;
            this.optSotWFlags.Location = new System.Drawing.Point(146, 15);
            this.optSotWFlags.Name = "optSotWFlags";
            this.optSotWFlags.Size = new System.Drawing.Size(117, 24);
            this.optSotWFlags.TabIndex = 22;
            this.optSotWFlags.TabStop = true;
            this.optSotWFlags.Text = "SotW Flags";
            this.optSotWFlags.UseVisualStyleBackColor = true;
            this.optSotWFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // opt_JustForFun
            // 
            this.opt_JustForFun.AutoSize = true;
            this.opt_JustForFun.Location = new System.Drawing.Point(471, 15);
            this.opt_JustForFun.Name = "opt_JustForFun";
            this.opt_JustForFun.Size = new System.Drawing.Size(124, 24);
            this.opt_JustForFun.TabIndex = 24;
            this.opt_JustForFun.TabStop = true;
            this.opt_JustForFun.Text = "Just For Fun";
            this.opt_JustForFun.UseVisualStyleBackColor = true;
            this.opt_JustForFun.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optTradSotWFlags
            // 
            this.optTradSotWFlags.AutoSize = true;
            this.optTradSotWFlags.Location = new System.Drawing.Point(270, 15);
            this.optTradSotWFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optTradSotWFlags.Name = "optTradSotWFlags";
            this.optTradSotWFlags.Size = new System.Drawing.Size(194, 24);
            this.optTradSotWFlags.TabIndex = 23;
            this.optTradSotWFlags.Text = "Traditional SotW Flags";
            this.optTradSotWFlags.UseVisualStyleBackColor = true;
            this.optTradSotWFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // optManualFlags
            // 
            this.optManualFlags.AutoSize = true;
            this.optManualFlags.Checked = true;
            this.optManualFlags.Location = new System.Drawing.Point(10, 15);
            this.optManualFlags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optManualFlags.Name = "optManualFlags";
            this.optManualFlags.Size = new System.Drawing.Size(129, 24);
            this.optManualFlags.TabIndex = 21;
            this.optManualFlags.TabStop = true;
            this.optManualFlags.Text = "Manual Flags";
            this.optManualFlags.UseVisualStyleBackColor = true;
            this.optManualFlags.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 189);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Hash";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(176, 189);
            this.lblHash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(369, 20);
            this.lblHash.TabIndex = 17;
            this.lblHash.Text = "????????????????????????????????????????";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(176, 320);
            this.txtSeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(656, 26);
            this.txtSeed.TabIndex = 33;
            // 
            // btn_CopyHash
            // 
            this.btn_CopyHash.Location = new System.Drawing.Point(790, 189);
            this.btn_CopyHash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CopyHash.Name = "btn_CopyHash";
            this.btn_CopyHash.Size = new System.Drawing.Size(184, 35);
            this.btn_CopyHash.TabIndex = 18;
            this.btn_CopyHash.Text = "Copy Hash";
            this.btn_CopyHash.UseVisualStyleBackColor = true;
            this.btn_CopyHash.Click += new System.EventHandler(this.btn_CopyHash_Click);
            // 
            // btn_chksumHash
            // 
            this.btn_chksumHash.Location = new System.Drawing.Point(790, 120);
            this.btn_chksumHash.Name = "btn_chksumHash";
            this.btn_chksumHash.Size = new System.Drawing.Size(184, 35);
            this.btn_chksumHash.TabIndex = 12;
            this.btn_chksumHash.Text = "Copy Checksum/Hash";
            this.btn_chksumHash.UseVisualStyleBackColor = true;
            this.btn_chksumHash.Click += new System.EventHandler(this.btn_chksumHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 940);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grp_EncRate.ResumeLayout(false);
            this.grp_EncRate.PerformLayout();
            this.grp_GoldGain.ResumeLayout(false);
            this.grp_GoldGain.PerformLayout();
            this.grp_ExpGain.ResumeLayout(false);
            this.grp_ExpGain.PerformLayout();
            this.grp_Big.ResumeLayout(false);
            this.grp_Big.PerformLayout();
            this.grp_SoHRoLEff.ResumeLayout(false);
            this.grp_SoHRoLEff.PerformLayout();
            this.grp_HUAStone.ResumeLayout(false);
            this.grp_HUAStone.PerformLayout();
            this.grp_RandSageStone.ResumeLayout(false);
            this.grp_RandSageStone.PerformLayout();
            this.grp_InvisNPC.ResumeLayout(false);
            this.grp_InvisNPC.PerformLayout();
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
            this.grp_Continents.ResumeLayout(false);
            this.grp_RandTown.ResumeLayout(false);
            this.grp_RandTown.PerformLayout();
            this.grp_RandCaves.ResumeLayout(false);
            this.grp_RandCaves.PerformLayout();
            this.grp_RandShrine.ResumeLayout(false);
            this.grp_RandShrine.PerformLayout();
            this.grp_RmMountains.ResumeLayout(false);
            this.grp_LancelCave.ResumeLayout(false);
            this.grp_LancelCave.PerformLayout();
            this.grp_CaveOfNecro.ResumeLayout(false);
            this.grp_CaveOfNecro.PerformLayout();
            this.grp_BaramosCast.ResumeLayout(false);
            this.grp_BaramosCast.PerformLayout();
            this.grp_DrgQnCast.ResumeLayout(false);
            this.grp_DrgQnCast.PerformLayout();
            this.grp_NoNewTown.ResumeLayout(false);
            this.grp_NoNewTown.PerformLayout();
            this.grp_Charlock.ResumeLayout(false);
            this.grp_Charlock.PerformLayout();
            this.grp_DisAlefGlitch.ResumeLayout(false);
            this.grp_DisAlefGlitch.PerformLayout();
            this.grp_RandMonstZone.ResumeLayout(false);
            this.grp_RandMonstZone.PerformLayout();
            this.grp_SmallMap.ResumeLayout(false);
            this.grp_SmallMap.PerformLayout();
            this.grp_RandMap.ResumeLayout(false);
            this.grp_RandMap.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grp_RmMetalRun.ResumeLayout(false);
            this.grp_RmMetalRun.PerformLayout();
            this.grp_RandEnePat.ResumeLayout(false);
            this.grp_RandEnePat.PerformLayout();
            this.grp_RmDupDrop.ResumeLayout(false);
            this.grp_RmDupDrop.PerformLayout();
            this.grp_RandGold.ResumeLayout(false);
            this.grp_RandGold.PerformLayout();
            this.grp_RandDrop.ResumeLayout(false);
            this.grp_RandDrop.PerformLayout();
            this.grp_RandExp.ResumeLayout(false);
            this.grp_RandExp.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpMonsterStat.ResumeLayout(false);
            this.grpMonsterStat.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.grp_FixHeroSpell.ResumeLayout(false);
            this.grp_FixHeroSpell.PerformLayout();
            this.grp_RmParryBug.ResumeLayout(false);
            this.grp_RmParryBug.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkRandStatGains;
        private System.Windows.Forms.CheckBox chkRandTreasures;
        private System.Windows.Forms.CheckBox chkRandSpellStrength;
        private System.Windows.Forms.CheckBox chkRandSpellLearning;
        private System.Windows.Forms.CheckBox chkRandEquip;
        private System.Windows.Forms.CheckBox chkRandItemStores;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtCharName2;
        private System.Windows.Forms.TextBox txtCharName3;
        private System.Windows.Forms.TextBox txtCharName1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.CheckBox chkRandWhoCanEquip;
        private System.Windows.Forms.CheckBox chkRandItemEffects;
        private System.Windows.Forms.CheckBox chkFourJobFiesta;
        private System.Windows.Forms.ToolTip adjustments;
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
        private System.Windows.Forms.GroupBox grpFlags;
        private System.Windows.Forms.RadioButton optTradSotWFlags;
        private System.Windows.Forms.RadioButton optManualFlags;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.CheckBox chk_GreenSilverOrb;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.CheckBox chk_AdjustEqpPrices;
        private System.Windows.Forms.CheckBox chk_changeCats;
        private System.Windows.Forms.CheckBox chk_sellUnsellItems;
        private System.Windows.Forms.CheckBox chk_RmRedundKey;
        private System.Windows.Forms.Button btn_CopyHash;
        private System.Windows.Forms.CheckBox chk_AddRemakeEq;
        private System.Windows.Forms.RadioButton opt_JustForFun;
        private System.Windows.Forms.GroupBox grpMonsterStat;
        private System.Windows.Forms.RadioButton optStatSilly;
        private System.Windows.Forms.RadioButton optStatHeavy;
        private System.Windows.Forms.RadioButton optStatMedium;
        private System.Windows.Forms.Button btn_chksumHash;
        private System.Windows.Forms.CheckBox chk_EveryoneCat;
        private System.Windows.Forms.CheckBox chk_FFigherSprite;
        private System.Windows.Forms.CheckBox chk_RandNPCSprites;
        private System.Windows.Forms.CheckBox chk_FemaleHero;
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
        private System.Windows.Forms.GroupBox grp_InvisNPC;
        private System.Windows.Forms.RadioButton rad_InvisNPCRand;
        private System.Windows.Forms.RadioButton rad_InvisNPCOn;
        private System.Windows.Forms.RadioButton rad_InvisNPCOff;
        private System.Windows.Forms.GroupBox grp_RandSageStone;
        private System.Windows.Forms.RadioButton rad_RandSageStoneRand;
        private System.Windows.Forms.RadioButton rad_RandSageStoneOn;
        private System.Windows.Forms.RadioButton rad_RandSageStoneOff;
        private System.Windows.Forms.GroupBox grp_HUAStone;
        private System.Windows.Forms.RadioButton rad_HUAStoneRand;
        private System.Windows.Forms.RadioButton rad_HUAStoneOn;
        private System.Windows.Forms.RadioButton rad_HUAStoneOff;
        private System.Windows.Forms.GroupBox grp_SoHRoLEff;
        private System.Windows.Forms.RadioButton rad_SoHRoLEffRand;
        private System.Windows.Forms.RadioButton rad_SoHRoLEffOn;
        private System.Windows.Forms.RadioButton rad_SoHRoLEffOff;
        private System.Windows.Forms.GroupBox grp_Big;
        private System.Windows.Forms.RadioButton rad_BigRand;
        private System.Windows.Forms.RadioButton rad_BigOn;
        private System.Windows.Forms.RadioButton rad_BigOff;
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
        private System.Windows.Forms.GroupBox grp_RandMap;
        private System.Windows.Forms.RadioButton rad_RandMapsRand;
        private System.Windows.Forms.RadioButton rad_RandMapsOn;
        private System.Windows.Forms.RadioButton rad_RandMapsOff;
        private System.Windows.Forms.GroupBox grp_SmallMap;
        private System.Windows.Forms.RadioButton rad_SmallMapRand;
        private System.Windows.Forms.RadioButton rad_SmallMapOn;
        private System.Windows.Forms.RadioButton rad_SmallMapOff;
        private System.Windows.Forms.GroupBox grp_DisAlefGlitch;
        private System.Windows.Forms.RadioButton rad_DisAlefGlitchRand;
        private System.Windows.Forms.RadioButton rad_DisAlefGlitchOn;
        private System.Windows.Forms.RadioButton rad_DisAlefGlitchOff;
        private System.Windows.Forms.GroupBox grp_DrgQnCast;
        private System.Windows.Forms.RadioButton rad_DrgQnCastRand;
        private System.Windows.Forms.RadioButton rad_DrgQnCastOn;
        private System.Windows.Forms.RadioButton rad_DrgQnCastOff;
        private System.Windows.Forms.GroupBox grp_BaramosCast;
        private System.Windows.Forms.RadioButton rad_BaramosCastRand;
        private System.Windows.Forms.RadioButton rad_BaramosCastOn;
        private System.Windows.Forms.RadioButton rad_BaramosCastOff;
        private System.Windows.Forms.GroupBox grp_CaveOfNecro;
        private System.Windows.Forms.RadioButton rad_CaveOfNecroRand;
        private System.Windows.Forms.RadioButton rad_CaveOfNecroOn;
        private System.Windows.Forms.RadioButton rad_CaveOfNecroOff;
        private System.Windows.Forms.GroupBox grp_LancelCave;
        private System.Windows.Forms.RadioButton rad_LancelCaveRand;
        private System.Windows.Forms.RadioButton rad_LancelCaveOn;
        private System.Windows.Forms.RadioButton rad_LancelCaveOff;
        private System.Windows.Forms.GroupBox grp_RandShrine;
        private System.Windows.Forms.RadioButton rad_RandShrinesRand;
        private System.Windows.Forms.RadioButton rad_RandShrinesOn;
        private System.Windows.Forms.RadioButton rad_RandShrinesOff;
        private System.Windows.Forms.GroupBox grp_RandCaves;
        private System.Windows.Forms.RadioButton rad_RandCavesRand;
        private System.Windows.Forms.RadioButton rad_RandCavesOn;
        private System.Windows.Forms.RadioButton rad_RandCavesOff;
        private System.Windows.Forms.GroupBox grp_RandTown;
        private System.Windows.Forms.RadioButton rad_RandTownsRand;
        private System.Windows.Forms.RadioButton rad_RandTownsOn;
        private System.Windows.Forms.RadioButton rad_RandTownsOff;
        private System.Windows.Forms.GroupBox grp_RandMonstZone;
        private System.Windows.Forms.RadioButton rad_RandMonstZoneRand;
        private System.Windows.Forms.RadioButton rad_RandMonstZoneOn;
        private System.Windows.Forms.RadioButton rad_RandMonstZoneOff;
        private System.Windows.Forms.GroupBox grp_NoNewTown;
        private System.Windows.Forms.RadioButton rad_NoNewTownRand;
        private System.Windows.Forms.RadioButton rad_NoNewTownOn;
        private System.Windows.Forms.RadioButton rad_NoNewTownOff;
        private System.Windows.Forms.GroupBox grp_Charlock;
        private System.Windows.Forms.RadioButton rad_CharlockRand;
        private System.Windows.Forms.RadioButton rad_CharlockOn;
        private System.Windows.Forms.RadioButton rad_CharlockOff;
        private System.Windows.Forms.GroupBox grp_RmMountains;
        private System.Windows.Forms.GroupBox grp_Continents;
        private System.Windows.Forms.GroupBox grp_RandExp;
        private System.Windows.Forms.RadioButton rad_RandExpRand;
        private System.Windows.Forms.RadioButton rad_RandExpOn;
        private System.Windows.Forms.RadioButton rad_RandExpOff;
        private System.Windows.Forms.GroupBox grp_RmMetalRun;
        private System.Windows.Forms.RadioButton rad_RmMetalRunRand;
        private System.Windows.Forms.RadioButton rad_RmMetalRunOn;
        private System.Windows.Forms.RadioButton rad_RmMetalRunOff;
        private System.Windows.Forms.GroupBox grp_RandEnePat;
        private System.Windows.Forms.RadioButton rad_RandEnePatRand;
        private System.Windows.Forms.RadioButton rad_RandEnePatOn;
        private System.Windows.Forms.RadioButton rad_RandEnePatOff;
        private System.Windows.Forms.GroupBox grp_RmDupDrop;
        private System.Windows.Forms.RadioButton rad_RmDupDropRand;
        private System.Windows.Forms.RadioButton rad_RmDupDropOn;
        private System.Windows.Forms.RadioButton rad_RmDupDropOff;
        private System.Windows.Forms.GroupBox grp_RandGold;
        private System.Windows.Forms.RadioButton rad_RandGoldRand;
        private System.Windows.Forms.RadioButton rad_RandGoldOn;
        private System.Windows.Forms.RadioButton rad_RandGoldOff;
        private System.Windows.Forms.GroupBox grp_RandDrop;
        private System.Windows.Forms.RadioButton rad_RandDropRand;
        private System.Windows.Forms.RadioButton rad_RandDropOn;
        private System.Windows.Forms.RadioButton rad_RandDropOff;
        private System.Windows.Forms.GroupBox grp_FixHeroSpell;
        private System.Windows.Forms.RadioButton rad_FixHeroSpellRand;
        private System.Windows.Forms.RadioButton rad_FixHeroSpellOn;
        private System.Windows.Forms.RadioButton rad_FixHeroSpellOff;
        private System.Windows.Forms.GroupBox grp_RmParryBug;
        private System.Windows.Forms.RadioButton rad_RmParryBugRand;
        private System.Windows.Forms.RadioButton rad_RmParryBugOn;
        private System.Windows.Forms.RadioButton rad_RmParryBugOff;
    }
}

