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
            this.grp_RandItemEff = new System.Windows.Forms.GroupBox();
            this.rad_RandItemEffRand = new System.Windows.Forms.RadioButton();
            this.rad_RandItemEffOn = new System.Windows.Forms.RadioButton();
            this.rad_RandItemEffOff = new System.Windows.Forms.RadioButton();
            this.grp_AddRemake = new System.Windows.Forms.GroupBox();
            this.rad_AddRemakeRand = new System.Windows.Forms.RadioButton();
            this.rad_AddRemakeOn = new System.Windows.Forms.RadioButton();
            this.rad_AddRemakeOff = new System.Windows.Forms.RadioButton();
            this.grp_AdjStartEq = new System.Windows.Forms.GroupBox();
            this.rad_AdjStartEqRand = new System.Windows.Forms.RadioButton();
            this.rad_AdjStartEqOn = new System.Windows.Forms.RadioButton();
            this.rad_AdjStartEqOff = new System.Windows.Forms.RadioButton();
            this.grp_AddGoldClaw = new System.Windows.Forms.GroupBox();
            this.rad_AddGoldClawRand = new System.Windows.Forms.RadioButton();
            this.rad_AddGoldClawOn = new System.Windows.Forms.RadioButton();
            this.rad_AddGoldClawOff = new System.Windows.Forms.RadioButton();
            this.grp_RmFightPen = new System.Windows.Forms.GroupBox();
            this.rad_RmFightPenRand = new System.Windows.Forms.RadioButton();
            this.rad_RmFightPenOn = new System.Windows.Forms.RadioButton();
            this.rad_RmFightPenOff = new System.Windows.Forms.RadioButton();
            this.grp_VanEqVal = new System.Windows.Forms.GroupBox();
            this.rad_VanEqValRand = new System.Windows.Forms.RadioButton();
            this.rad_VanEqValOn = new System.Windows.Forms.RadioButton();
            this.rad_VanEqValOff = new System.Windows.Forms.RadioButton();
            this.grp_RandClassEq = new System.Windows.Forms.GroupBox();
            this.rad_RandClassEqRand = new System.Windows.Forms.RadioButton();
            this.rad_RandClassEqOn = new System.Windows.Forms.RadioButton();
            this.rad_RandClassEqOff = new System.Windows.Forms.RadioButton();
            this.grp_AdjEqPrice = new System.Windows.Forms.GroupBox();
            this.rad_AdjEqPriceRand = new System.Windows.Forms.RadioButton();
            this.rad_AdjEqPriceOn = new System.Windows.Forms.RadioButton();
            this.rad_AdjEqPriceOff = new System.Windows.Forms.RadioButton();
            this.grp_RmRedKeys = new System.Windows.Forms.GroupBox();
            this.rad_RmRedKeysRand = new System.Windows.Forms.RadioButton();
            this.rad_RmRedKeysOn = new System.Windows.Forms.RadioButton();
            this.rad_RmRedKeysOff = new System.Windows.Forms.RadioButton();
            this.grp_RandEqPwr = new System.Windows.Forms.GroupBox();
            this.rad_RandEqPwrRand = new System.Windows.Forms.RadioButton();
            this.rad_RandEqPwrOn = new System.Windows.Forms.RadioButton();
            this.rad_RandEqPwrOff = new System.Windows.Forms.RadioButton();
            this.grp_OrbDft = new System.Windows.Forms.GroupBox();
            this.rad_OrbDftRand = new System.Windows.Forms.RadioButton();
            this.rad_OrbDftOn = new System.Windows.Forms.RadioButton();
            this.rad_OrbDftOff = new System.Windows.Forms.RadioButton();
            this.grp_RandTreas = new System.Windows.Forms.GroupBox();
            this.rad_RandTreasRand = new System.Windows.Forms.RadioButton();
            this.rad_RandTreasOn = new System.Windows.Forms.RadioButton();
            this.rad_RandTreasOff = new System.Windows.Forms.RadioButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.grp_AddToItemShop = new System.Windows.Forms.GroupBox();
            this.grp_LampOfDarkness = new System.Windows.Forms.GroupBox();
            this.rad_LampOfDarknessRand = new System.Windows.Forms.RadioButton();
            this.rad_LampOfDarknessOn = new System.Windows.Forms.RadioButton();
            this.rad_LampOfDarknessOff = new System.Windows.Forms.RadioButton();
            this.grp_ShoesOfHappiness = new System.Windows.Forms.GroupBox();
            this.rad_ShoesOfHappinessRand = new System.Windows.Forms.RadioButton();
            this.rad_ShoesOfHappinessOn = new System.Windows.Forms.RadioButton();
            this.rad_ShoesOfHappinessOff = new System.Windows.Forms.RadioButton();
            this.grp_RingOfLife = new System.Windows.Forms.GroupBox();
            this.rad_RingOfLifeRand = new System.Windows.Forms.RadioButton();
            this.rad_RingOfLifeOn = new System.Windows.Forms.RadioButton();
            this.rad_RingOfLifeOff = new System.Windows.Forms.RadioButton();
            this.grp_SilverHarp = new System.Windows.Forms.GroupBox();
            this.rad_SilverHarpRand = new System.Windows.Forms.RadioButton();
            this.rad_SilverHarpOn = new System.Windows.Forms.RadioButton();
            this.rad_SilverHarpOff = new System.Windows.Forms.RadioButton();
            this.grp_EchoingFlute = new System.Windows.Forms.GroupBox();
            this.rad_EchoingFluteRand = new System.Windows.Forms.RadioButton();
            this.rad_EchoingFluteOn = new System.Windows.Forms.RadioButton();
            this.rad_EchoingFluteOff = new System.Windows.Forms.RadioButton();
            this.grp_WizardRing = new System.Windows.Forms.GroupBox();
            this.rad_WizardRingRand = new System.Windows.Forms.RadioButton();
            this.rad_WizardRingOn = new System.Windows.Forms.RadioButton();
            this.rad_WizardRingOff = new System.Windows.Forms.RadioButton();
            this.grp_MetoriteArmband = new System.Windows.Forms.GroupBox();
            this.rad_MetoriteArmbandRand = new System.Windows.Forms.RadioButton();
            this.rad_MetoriteArmbandOn = new System.Windows.Forms.RadioButton();
            this.rad_MetoriteArmbandOff = new System.Windows.Forms.RadioButton();
            this.grp_Satori = new System.Windows.Forms.GroupBox();
            this.rad_SatoriRand = new System.Windows.Forms.RadioButton();
            this.rad_SatoriOn = new System.Windows.Forms.RadioButton();
            this.rad_SatoriOff = new System.Windows.Forms.RadioButton();
            this.grp_StoneOfLife = new System.Windows.Forms.GroupBox();
            this.rad_StoneOfLifeRand = new System.Windows.Forms.RadioButton();
            this.rad_StoneOfLifeOn = new System.Windows.Forms.RadioButton();
            this.rad_StoneOfLifeOff = new System.Windows.Forms.RadioButton();
            this.grp_PoisonMoth = new System.Windows.Forms.GroupBox();
            this.rad_PoisonMothRand = new System.Windows.Forms.RadioButton();
            this.rad_PoisonMothOn = new System.Windows.Forms.RadioButton();
            this.rad_PoisonMothOff = new System.Windows.Forms.RadioButton();
            this.grp_LucSeed = new System.Windows.Forms.GroupBox();
            this.rad_LucSeedRand = new System.Windows.Forms.RadioButton();
            this.rad_LucSeedOn = new System.Windows.Forms.RadioButton();
            this.rad_LucSeedOff = new System.Windows.Forms.RadioButton();
            this.grp_VitSeed = new System.Windows.Forms.GroupBox();
            this.rad_VitSeedRand = new System.Windows.Forms.RadioButton();
            this.rad_VitSeedOn = new System.Windows.Forms.RadioButton();
            this.rad_VitSeedOff = new System.Windows.Forms.RadioButton();
            this.grp_WorldTree = new System.Windows.Forms.GroupBox();
            this.rad_WorldTreeRand = new System.Windows.Forms.RadioButton();
            this.rad_WorldTreeOn = new System.Windows.Forms.RadioButton();
            this.rad_WorldTreeOff = new System.Windows.Forms.RadioButton();
            this.grp_IntSeed = new System.Windows.Forms.GroupBox();
            this.rad_IntSeedRand = new System.Windows.Forms.RadioButton();
            this.rad_IntSeedOn = new System.Windows.Forms.RadioButton();
            this.rad_IntSeedOff = new System.Windows.Forms.RadioButton();
            this.grp_AgiSeed = new System.Windows.Forms.GroupBox();
            this.rad_AgiSeedRand = new System.Windows.Forms.RadioButton();
            this.rad_AgiSeedOn = new System.Windows.Forms.RadioButton();
            this.rad_AgiSeedOff = new System.Windows.Forms.RadioButton();
            this.grp_StrSeed = new System.Windows.Forms.GroupBox();
            this.rad_StrSeedRand = new System.Windows.Forms.RadioButton();
            this.rad_StrSeedOn = new System.Windows.Forms.RadioButton();
            this.rad_StrSeedOff = new System.Windows.Forms.RadioButton();
            this.grp_Acorns = new System.Windows.Forms.GroupBox();
            this.rad_AcornsRand = new System.Windows.Forms.RadioButton();
            this.rad_AcornsOn = new System.Windows.Forms.RadioButton();
            this.rad_AcornsOff = new System.Windows.Forms.RadioButton();
            this.grp_Caturday = new System.Windows.Forms.GroupBox();
            this.rad_CaturdayRand = new System.Windows.Forms.RadioButton();
            this.rad_CaturdayOn = new System.Windows.Forms.RadioButton();
            this.rad_CaturdayOff = new System.Windows.Forms.RadioButton();
            this.grp_SellUnsellable = new System.Windows.Forms.GroupBox();
            this.rad_SellUnsellableRand = new System.Windows.Forms.RadioButton();
            this.rad_SellUnsellableOn = new System.Windows.Forms.RadioButton();
            this.rad_SellUnsellableOff = new System.Windows.Forms.RadioButton();
            this.grp_RandItemShop = new System.Windows.Forms.GroupBox();
            this.rad_RandItemShopRand = new System.Windows.Forms.RadioButton();
            this.rad_RandItemShopOn = new System.Windows.Forms.RadioButton();
            this.rad_RandItemShopOff = new System.Windows.Forms.RadioButton();
            this.grp_RandWeapShop = new System.Windows.Forms.GroupBox();
            this.rad_RandWeapShopRand = new System.Windows.Forms.RadioButton();
            this.rad_RandWeapShopOn = new System.Windows.Forms.RadioButton();
            this.rad_RandWeapShopOff = new System.Windows.Forms.RadioButton();
            this.grp_RandInn = new System.Windows.Forms.GroupBox();
            this.rad_RandInnRand = new System.Windows.Forms.RadioButton();
            this.rad_RandInnOn = new System.Windows.Forms.RadioButton();
            this.rad_RandInnOff = new System.Windows.Forms.RadioButton();
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
            this.grp_RandItemEff.SuspendLayout();
            this.grp_AddRemake.SuspendLayout();
            this.grp_AdjStartEq.SuspendLayout();
            this.grp_AddGoldClaw.SuspendLayout();
            this.grp_RmFightPen.SuspendLayout();
            this.grp_VanEqVal.SuspendLayout();
            this.grp_RandClassEq.SuspendLayout();
            this.grp_AdjEqPrice.SuspendLayout();
            this.grp_RmRedKeys.SuspendLayout();
            this.grp_RandEqPwr.SuspendLayout();
            this.grp_OrbDft.SuspendLayout();
            this.grp_RandTreas.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.grp_AddToItemShop.SuspendLayout();
            this.grp_LampOfDarkness.SuspendLayout();
            this.grp_ShoesOfHappiness.SuspendLayout();
            this.grp_RingOfLife.SuspendLayout();
            this.grp_SilverHarp.SuspendLayout();
            this.grp_EchoingFlute.SuspendLayout();
            this.grp_WizardRing.SuspendLayout();
            this.grp_MetoriteArmband.SuspendLayout();
            this.grp_Satori.SuspendLayout();
            this.grp_StoneOfLife.SuspendLayout();
            this.grp_PoisonMoth.SuspendLayout();
            this.grp_LucSeed.SuspendLayout();
            this.grp_VitSeed.SuspendLayout();
            this.grp_WorldTree.SuspendLayout();
            this.grp_IntSeed.SuspendLayout();
            this.grp_AgiSeed.SuspendLayout();
            this.grp_StrSeed.SuspendLayout();
            this.grp_Acorns.SuspendLayout();
            this.grp_Caturday.SuspendLayout();
            this.grp_SellUnsellable.SuspendLayout();
            this.grp_RandItemShop.SuspendLayout();
            this.grp_RandWeapShop.SuspendLayout();
            this.grp_RandInn.SuspendLayout();
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
            this.btnRandomize.Location = new System.Drawing.Point(608, 684);
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
            this.tabControl1.Size = new System.Drawing.Size(686, 448);
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
            this.tabPage1.Size = new System.Drawing.Size(678, 422);
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
            this.tchk_InvisShipBird.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_BigSoHRoL.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_SoHRoLEff.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_HUAStone.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_SagesStone.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_InvisNPC.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_FourJobFiesta.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_PartyItems.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_NoOrb.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_DoubleAttack.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_NonMPJobs.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandSpellLearn.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_DispEqPower.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_Cod.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandStartGold.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmManips.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_SpeedUpMenus.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_SpeedUpText.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_IncBatSpeed.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmNoEncounter.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_NoNewTown.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmMoatCharlock.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmMountDQC.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmMountBaramos.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmMountNecro.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmMountLancel.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandShrines.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandCaveTower.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandTowns.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandMonstZones.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_SmallMaps.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandMaps.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmMetalRun.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandEnAttPat.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RmDupItemPool.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandDrops.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandGold.Click += new System.EventHandler(this.determineFlags);
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
            this.tchk_RandExp.Click += new System.EventHandler(this.determineFlags);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grp_RandItemEff);
            this.tabPage4.Controls.Add(this.grp_AddRemake);
            this.tabPage4.Controls.Add(this.grp_AdjStartEq);
            this.tabPage4.Controls.Add(this.grp_AddGoldClaw);
            this.tabPage4.Controls.Add(this.grp_RmFightPen);
            this.tabPage4.Controls.Add(this.grp_VanEqVal);
            this.tabPage4.Controls.Add(this.grp_RandClassEq);
            this.tabPage4.Controls.Add(this.grp_AdjEqPrice);
            this.tabPage4.Controls.Add(this.grp_RmRedKeys);
            this.tabPage4.Controls.Add(this.grp_RandEqPwr);
            this.tabPage4.Controls.Add(this.grp_OrbDft);
            this.tabPage4.Controls.Add(this.grp_RandTreas);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(678, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Treasures & Equipment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grp_RandItemEff
            // 
            this.grp_RandItemEff.Controls.Add(this.rad_RandItemEffRand);
            this.grp_RandItemEff.Controls.Add(this.rad_RandItemEffOn);
            this.grp_RandItemEff.Controls.Add(this.rad_RandItemEffOff);
            this.grp_RandItemEff.Location = new System.Drawing.Point(510, 94);
            this.grp_RandItemEff.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RandItemEff.Name = "grp_RandItemEff";
            this.grp_RandItemEff.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RandItemEff.Size = new System.Drawing.Size(163, 41);
            this.grp_RandItemEff.TabIndex = 141;
            this.grp_RandItemEff.TabStop = false;
            this.grp_RandItemEff.Text = "Randomize Item Effects";
            this.adjustments.SetToolTip(this.grp_RandItemEff, "Randomizes the effect of items.");
            this.grp_RandItemEff.Visible = false;
            // 
            // rad_RandItemEffRand
            // 
            this.rad_RandItemEffRand.AutoSize = true;
            this.rad_RandItemEffRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RandItemEffRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandItemEffRand.Name = "rad_RandItemEffRand";
            this.rad_RandItemEffRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandItemEffRand.TabIndex = 2;
            this.rad_RandItemEffRand.Text = "Random";
            this.rad_RandItemEffRand.UseVisualStyleBackColor = true;
            this.rad_RandItemEffRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandItemEffOn
            // 
            this.rad_RandItemEffOn.AutoSize = true;
            this.rad_RandItemEffOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RandItemEffOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandItemEffOn.Name = "rad_RandItemEffOn";
            this.rad_RandItemEffOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandItemEffOn.TabIndex = 1;
            this.rad_RandItemEffOn.Text = "On";
            this.rad_RandItemEffOn.UseVisualStyleBackColor = true;
            this.rad_RandItemEffOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandItemEffOff
            // 
            this.rad_RandItemEffOff.AutoSize = true;
            this.rad_RandItemEffOff.Checked = true;
            this.rad_RandItemEffOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandItemEffOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandItemEffOff.Name = "rad_RandItemEffOff";
            this.rad_RandItemEffOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandItemEffOff.TabIndex = 0;
            this.rad_RandItemEffOff.TabStop = true;
            this.rad_RandItemEffOff.Text = "Off";
            this.rad_RandItemEffOff.UseVisualStyleBackColor = true;
            this.rad_RandItemEffOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_AddRemake
            // 
            this.grp_AddRemake.Controls.Add(this.rad_AddRemakeRand);
            this.grp_AddRemake.Controls.Add(this.rad_AddRemakeOn);
            this.grp_AddRemake.Controls.Add(this.rad_AddRemakeOff);
            this.grp_AddRemake.Location = new System.Drawing.Point(510, 49);
            this.grp_AddRemake.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AddRemake.Name = "grp_AddRemake";
            this.grp_AddRemake.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AddRemake.Size = new System.Drawing.Size(163, 41);
            this.grp_AddRemake.TabIndex = 137;
            this.grp_AddRemake.TabStop = false;
            this.grp_AddRemake.Text = "Add Remake Equipment";
            this.adjustments.SetToolTip(this.grp_AddRemake, "Add equipment from remakes for Pilgrim, Merchant, and Fighter.");
            // 
            // rad_AddRemakeRand
            // 
            this.rad_AddRemakeRand.AutoSize = true;
            this.rad_AddRemakeRand.Location = new System.Drawing.Point(92, 19);
            this.rad_AddRemakeRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AddRemakeRand.Name = "rad_AddRemakeRand";
            this.rad_AddRemakeRand.Size = new System.Drawing.Size(65, 17);
            this.rad_AddRemakeRand.TabIndex = 2;
            this.rad_AddRemakeRand.Text = "Random";
            this.rad_AddRemakeRand.UseVisualStyleBackColor = true;
            this.rad_AddRemakeRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AddRemakeOn
            // 
            this.rad_AddRemakeOn.AutoSize = true;
            this.rad_AddRemakeOn.Location = new System.Drawing.Point(49, 19);
            this.rad_AddRemakeOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AddRemakeOn.Name = "rad_AddRemakeOn";
            this.rad_AddRemakeOn.Size = new System.Drawing.Size(39, 17);
            this.rad_AddRemakeOn.TabIndex = 1;
            this.rad_AddRemakeOn.Text = "On";
            this.rad_AddRemakeOn.UseVisualStyleBackColor = true;
            this.rad_AddRemakeOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AddRemakeOff
            // 
            this.rad_AddRemakeOff.AutoSize = true;
            this.rad_AddRemakeOff.Checked = true;
            this.rad_AddRemakeOff.Location = new System.Drawing.Point(6, 19);
            this.rad_AddRemakeOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AddRemakeOff.Name = "rad_AddRemakeOff";
            this.rad_AddRemakeOff.Size = new System.Drawing.Size(39, 17);
            this.rad_AddRemakeOff.TabIndex = 0;
            this.rad_AddRemakeOff.TabStop = true;
            this.rad_AddRemakeOff.Text = "Off";
            this.rad_AddRemakeOff.UseVisualStyleBackColor = true;
            this.rad_AddRemakeOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_AdjStartEq
            // 
            this.grp_AdjStartEq.Controls.Add(this.rad_AdjStartEqRand);
            this.grp_AdjStartEq.Controls.Add(this.rad_AdjStartEqOn);
            this.grp_AdjStartEq.Controls.Add(this.rad_AdjStartEqOff);
            this.grp_AdjStartEq.Location = new System.Drawing.Point(341, 94);
            this.grp_AdjStartEq.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AdjStartEq.Name = "grp_AdjStartEq";
            this.grp_AdjStartEq.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AdjStartEq.Size = new System.Drawing.Size(163, 41);
            this.grp_AdjStartEq.TabIndex = 140;
            this.grp_AdjStartEq.TabStop = false;
            this.grp_AdjStartEq.Text = "Adjust Start Equipment";
            this.adjustments.SetToolTip(this.grp_AdjStartEq, "Starting equipment is not limited in power when randomized.");
            // 
            // rad_AdjStartEqRand
            // 
            this.rad_AdjStartEqRand.AutoSize = true;
            this.rad_AdjStartEqRand.Location = new System.Drawing.Point(92, 19);
            this.rad_AdjStartEqRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AdjStartEqRand.Name = "rad_AdjStartEqRand";
            this.rad_AdjStartEqRand.Size = new System.Drawing.Size(65, 17);
            this.rad_AdjStartEqRand.TabIndex = 2;
            this.rad_AdjStartEqRand.Text = "Random";
            this.rad_AdjStartEqRand.UseVisualStyleBackColor = true;
            this.rad_AdjStartEqRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AdjStartEqOn
            // 
            this.rad_AdjStartEqOn.AutoSize = true;
            this.rad_AdjStartEqOn.Location = new System.Drawing.Point(49, 19);
            this.rad_AdjStartEqOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AdjStartEqOn.Name = "rad_AdjStartEqOn";
            this.rad_AdjStartEqOn.Size = new System.Drawing.Size(39, 17);
            this.rad_AdjStartEqOn.TabIndex = 1;
            this.rad_AdjStartEqOn.Text = "On";
            this.rad_AdjStartEqOn.UseVisualStyleBackColor = true;
            this.rad_AdjStartEqOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AdjStartEqOff
            // 
            this.rad_AdjStartEqOff.AutoSize = true;
            this.rad_AdjStartEqOff.Checked = true;
            this.rad_AdjStartEqOff.Location = new System.Drawing.Point(6, 19);
            this.rad_AdjStartEqOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AdjStartEqOff.Name = "rad_AdjStartEqOff";
            this.rad_AdjStartEqOff.Size = new System.Drawing.Size(39, 17);
            this.rad_AdjStartEqOff.TabIndex = 0;
            this.rad_AdjStartEqOff.TabStop = true;
            this.rad_AdjStartEqOff.Text = "Off";
            this.rad_AdjStartEqOff.UseVisualStyleBackColor = true;
            this.rad_AdjStartEqOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_AddGoldClaw
            // 
            this.grp_AddGoldClaw.Controls.Add(this.rad_AddGoldClawRand);
            this.grp_AddGoldClaw.Controls.Add(this.rad_AddGoldClawOn);
            this.grp_AddGoldClaw.Controls.Add(this.rad_AddGoldClawOff);
            this.grp_AddGoldClaw.Location = new System.Drawing.Point(510, 4);
            this.grp_AddGoldClaw.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AddGoldClaw.Name = "grp_AddGoldClaw";
            this.grp_AddGoldClaw.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AddGoldClaw.Size = new System.Drawing.Size(163, 41);
            this.grp_AddGoldClaw.TabIndex = 133;
            this.grp_AddGoldClaw.TabStop = false;
            this.grp_AddGoldClaw.Text = "Add Golden Claw to Pool";
            this.adjustments.SetToolTip(this.grp_AddGoldClaw, "Add the Golden Claw to the Treasure Pool (1 will be put in a random chest).");
            // 
            // rad_AddGoldClawRand
            // 
            this.rad_AddGoldClawRand.AutoSize = true;
            this.rad_AddGoldClawRand.Location = new System.Drawing.Point(92, 19);
            this.rad_AddGoldClawRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AddGoldClawRand.Name = "rad_AddGoldClawRand";
            this.rad_AddGoldClawRand.Size = new System.Drawing.Size(65, 17);
            this.rad_AddGoldClawRand.TabIndex = 2;
            this.rad_AddGoldClawRand.Text = "Random";
            this.rad_AddGoldClawRand.UseVisualStyleBackColor = true;
            this.rad_AddGoldClawRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AddGoldClawOn
            // 
            this.rad_AddGoldClawOn.AutoSize = true;
            this.rad_AddGoldClawOn.Location = new System.Drawing.Point(49, 19);
            this.rad_AddGoldClawOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AddGoldClawOn.Name = "rad_AddGoldClawOn";
            this.rad_AddGoldClawOn.Size = new System.Drawing.Size(39, 17);
            this.rad_AddGoldClawOn.TabIndex = 1;
            this.rad_AddGoldClawOn.Text = "On";
            this.rad_AddGoldClawOn.UseVisualStyleBackColor = true;
            this.rad_AddGoldClawOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AddGoldClawOff
            // 
            this.rad_AddGoldClawOff.AutoSize = true;
            this.rad_AddGoldClawOff.Checked = true;
            this.rad_AddGoldClawOff.Location = new System.Drawing.Point(6, 19);
            this.rad_AddGoldClawOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AddGoldClawOff.Name = "rad_AddGoldClawOff";
            this.rad_AddGoldClawOff.Size = new System.Drawing.Size(39, 17);
            this.rad_AddGoldClawOff.TabIndex = 0;
            this.rad_AddGoldClawOff.TabStop = true;
            this.rad_AddGoldClawOff.Text = "Off";
            this.rad_AddGoldClawOff.UseVisualStyleBackColor = true;
            this.rad_AddGoldClawOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RmFightPen
            // 
            this.grp_RmFightPen.Controls.Add(this.rad_RmFightPenRand);
            this.grp_RmFightPen.Controls.Add(this.rad_RmFightPenOn);
            this.grp_RmFightPen.Controls.Add(this.rad_RmFightPenOff);
            this.grp_RmFightPen.Location = new System.Drawing.Point(173, 94);
            this.grp_RmFightPen.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RmFightPen.Name = "grp_RmFightPen";
            this.grp_RmFightPen.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RmFightPen.Size = new System.Drawing.Size(163, 41);
            this.grp_RmFightPen.TabIndex = 139;
            this.grp_RmFightPen.TabStop = false;
            this.grp_RmFightPen.Text = "Remove Fighter Penalty";
            this.adjustments.SetToolTip(this.grp_RmFightPen, "Removes the penalty some equipment has for fighters.");
            // 
            // rad_RmFightPenRand
            // 
            this.rad_RmFightPenRand.AutoSize = true;
            this.rad_RmFightPenRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RmFightPenRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmFightPenRand.Name = "rad_RmFightPenRand";
            this.rad_RmFightPenRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RmFightPenRand.TabIndex = 2;
            this.rad_RmFightPenRand.Text = "Random";
            this.rad_RmFightPenRand.UseVisualStyleBackColor = true;
            this.rad_RmFightPenRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmFightPenOn
            // 
            this.rad_RmFightPenOn.AutoSize = true;
            this.rad_RmFightPenOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RmFightPenOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmFightPenOn.Name = "rad_RmFightPenOn";
            this.rad_RmFightPenOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RmFightPenOn.TabIndex = 1;
            this.rad_RmFightPenOn.Text = "On";
            this.rad_RmFightPenOn.UseVisualStyleBackColor = true;
            this.rad_RmFightPenOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmFightPenOff
            // 
            this.rad_RmFightPenOff.AutoSize = true;
            this.rad_RmFightPenOff.Checked = true;
            this.rad_RmFightPenOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RmFightPenOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmFightPenOff.Name = "rad_RmFightPenOff";
            this.rad_RmFightPenOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RmFightPenOff.TabIndex = 0;
            this.rad_RmFightPenOff.TabStop = true;
            this.rad_RmFightPenOff.Text = "Off";
            this.rad_RmFightPenOff.UseVisualStyleBackColor = true;
            this.rad_RmFightPenOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_VanEqVal
            // 
            this.grp_VanEqVal.Controls.Add(this.rad_VanEqValRand);
            this.grp_VanEqVal.Controls.Add(this.rad_VanEqValOn);
            this.grp_VanEqVal.Controls.Add(this.rad_VanEqValOff);
            this.grp_VanEqVal.Location = new System.Drawing.Point(341, 49);
            this.grp_VanEqVal.Margin = new System.Windows.Forms.Padding(2);
            this.grp_VanEqVal.Name = "grp_VanEqVal";
            this.grp_VanEqVal.Padding = new System.Windows.Forms.Padding(2);
            this.grp_VanEqVal.Size = new System.Drawing.Size(163, 41);
            this.grp_VanEqVal.TabIndex = 136;
            this.grp_VanEqVal.TabStop = false;
            this.grp_VanEqVal.Text = "Vanilla Equipment Values";
            this.adjustments.SetToolTip(this.grp_VanEqVal, "Uses values of actual equipment instead of a random number when randomizing power" +
        ".");
            // 
            // rad_VanEqValRand
            // 
            this.rad_VanEqValRand.AutoSize = true;
            this.rad_VanEqValRand.Location = new System.Drawing.Point(92, 19);
            this.rad_VanEqValRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_VanEqValRand.Name = "rad_VanEqValRand";
            this.rad_VanEqValRand.Size = new System.Drawing.Size(65, 17);
            this.rad_VanEqValRand.TabIndex = 2;
            this.rad_VanEqValRand.Text = "Random";
            this.rad_VanEqValRand.UseVisualStyleBackColor = true;
            this.rad_VanEqValRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_VanEqValOn
            // 
            this.rad_VanEqValOn.AutoSize = true;
            this.rad_VanEqValOn.Location = new System.Drawing.Point(49, 19);
            this.rad_VanEqValOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_VanEqValOn.Name = "rad_VanEqValOn";
            this.rad_VanEqValOn.Size = new System.Drawing.Size(39, 17);
            this.rad_VanEqValOn.TabIndex = 1;
            this.rad_VanEqValOn.Text = "On";
            this.rad_VanEqValOn.UseVisualStyleBackColor = true;
            this.rad_VanEqValOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_VanEqValOff
            // 
            this.rad_VanEqValOff.AutoSize = true;
            this.rad_VanEqValOff.Checked = true;
            this.rad_VanEqValOff.Location = new System.Drawing.Point(6, 19);
            this.rad_VanEqValOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_VanEqValOff.Name = "rad_VanEqValOff";
            this.rad_VanEqValOff.Size = new System.Drawing.Size(39, 17);
            this.rad_VanEqValOff.TabIndex = 0;
            this.rad_VanEqValOff.TabStop = true;
            this.rad_VanEqValOff.Text = "Off";
            this.rad_VanEqValOff.UseVisualStyleBackColor = true;
            this.rad_VanEqValOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandClassEq
            // 
            this.grp_RandClassEq.Controls.Add(this.rad_RandClassEqRand);
            this.grp_RandClassEq.Controls.Add(this.rad_RandClassEqOn);
            this.grp_RandClassEq.Controls.Add(this.rad_RandClassEqOff);
            this.grp_RandClassEq.Location = new System.Drawing.Point(4, 94);
            this.grp_RandClassEq.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RandClassEq.Name = "grp_RandClassEq";
            this.grp_RandClassEq.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RandClassEq.Size = new System.Drawing.Size(163, 41);
            this.grp_RandClassEq.TabIndex = 138;
            this.grp_RandClassEq.TabStop = false;
            this.grp_RandClassEq.Text = "Randomize Equipping Class";
            // 
            // rad_RandClassEqRand
            // 
            this.rad_RandClassEqRand.AutoSize = true;
            this.rad_RandClassEqRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RandClassEqRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandClassEqRand.Name = "rad_RandClassEqRand";
            this.rad_RandClassEqRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandClassEqRand.TabIndex = 2;
            this.rad_RandClassEqRand.Text = "Random";
            this.rad_RandClassEqRand.UseVisualStyleBackColor = true;
            this.rad_RandClassEqRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandClassEqOn
            // 
            this.rad_RandClassEqOn.AutoSize = true;
            this.rad_RandClassEqOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RandClassEqOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandClassEqOn.Name = "rad_RandClassEqOn";
            this.rad_RandClassEqOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandClassEqOn.TabIndex = 1;
            this.rad_RandClassEqOn.Text = "On";
            this.rad_RandClassEqOn.UseVisualStyleBackColor = true;
            this.rad_RandClassEqOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandClassEqOff
            // 
            this.rad_RandClassEqOff.AutoSize = true;
            this.rad_RandClassEqOff.Checked = true;
            this.rad_RandClassEqOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandClassEqOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandClassEqOff.Name = "rad_RandClassEqOff";
            this.rad_RandClassEqOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandClassEqOff.TabIndex = 0;
            this.rad_RandClassEqOff.TabStop = true;
            this.rad_RandClassEqOff.Text = "Off";
            this.rad_RandClassEqOff.UseVisualStyleBackColor = true;
            this.rad_RandClassEqOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_AdjEqPrice
            // 
            this.grp_AdjEqPrice.Controls.Add(this.rad_AdjEqPriceRand);
            this.grp_AdjEqPrice.Controls.Add(this.rad_AdjEqPriceOn);
            this.grp_AdjEqPrice.Controls.Add(this.rad_AdjEqPriceOff);
            this.grp_AdjEqPrice.Location = new System.Drawing.Point(173, 49);
            this.grp_AdjEqPrice.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AdjEqPrice.Name = "grp_AdjEqPrice";
            this.grp_AdjEqPrice.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AdjEqPrice.Size = new System.Drawing.Size(163, 41);
            this.grp_AdjEqPrice.TabIndex = 135;
            this.grp_AdjEqPrice.TabStop = false;
            this.grp_AdjEqPrice.Text = "Adjust Equipment Prices";
            this.adjustments.SetToolTip(this.grp_AdjEqPrice, "Adjusts equipment prices based on power.");
            // 
            // rad_AdjEqPriceRand
            // 
            this.rad_AdjEqPriceRand.AutoSize = true;
            this.rad_AdjEqPriceRand.Location = new System.Drawing.Point(92, 19);
            this.rad_AdjEqPriceRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AdjEqPriceRand.Name = "rad_AdjEqPriceRand";
            this.rad_AdjEqPriceRand.Size = new System.Drawing.Size(65, 17);
            this.rad_AdjEqPriceRand.TabIndex = 2;
            this.rad_AdjEqPriceRand.Text = "Random";
            this.rad_AdjEqPriceRand.UseVisualStyleBackColor = true;
            this.rad_AdjEqPriceRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AdjEqPriceOn
            // 
            this.rad_AdjEqPriceOn.AutoSize = true;
            this.rad_AdjEqPriceOn.Location = new System.Drawing.Point(49, 19);
            this.rad_AdjEqPriceOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AdjEqPriceOn.Name = "rad_AdjEqPriceOn";
            this.rad_AdjEqPriceOn.Size = new System.Drawing.Size(39, 17);
            this.rad_AdjEqPriceOn.TabIndex = 1;
            this.rad_AdjEqPriceOn.Text = "On";
            this.rad_AdjEqPriceOn.UseVisualStyleBackColor = true;
            this.rad_AdjEqPriceOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AdjEqPriceOff
            // 
            this.rad_AdjEqPriceOff.AutoSize = true;
            this.rad_AdjEqPriceOff.Checked = true;
            this.rad_AdjEqPriceOff.Location = new System.Drawing.Point(6, 19);
            this.rad_AdjEqPriceOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AdjEqPriceOff.Name = "rad_AdjEqPriceOff";
            this.rad_AdjEqPriceOff.Size = new System.Drawing.Size(39, 17);
            this.rad_AdjEqPriceOff.TabIndex = 0;
            this.rad_AdjEqPriceOff.TabStop = true;
            this.rad_AdjEqPriceOff.Text = "Off";
            this.rad_AdjEqPriceOff.UseVisualStyleBackColor = true;
            this.rad_AdjEqPriceOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RmRedKeys
            // 
            this.grp_RmRedKeys.Controls.Add(this.rad_RmRedKeysRand);
            this.grp_RmRedKeys.Controls.Add(this.rad_RmRedKeysOn);
            this.grp_RmRedKeys.Controls.Add(this.rad_RmRedKeysOff);
            this.grp_RmRedKeys.Location = new System.Drawing.Point(341, 4);
            this.grp_RmRedKeys.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RmRedKeys.Name = "grp_RmRedKeys";
            this.grp_RmRedKeys.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RmRedKeys.Size = new System.Drawing.Size(163, 41);
            this.grp_RmRedKeys.TabIndex = 132;
            this.grp_RmRedKeys.TabStop = false;
            this.grp_RmRedKeys.Text = "Remove Redundant Keys";
            this.adjustments.SetToolTip(this.grp_RmRedKeys, "Removes lower tier keys from areas if a higher tier one is found there.");
            // 
            // rad_RmRedKeysRand
            // 
            this.rad_RmRedKeysRand.AutoSize = true;
            this.rad_RmRedKeysRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RmRedKeysRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmRedKeysRand.Name = "rad_RmRedKeysRand";
            this.rad_RmRedKeysRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RmRedKeysRand.TabIndex = 2;
            this.rad_RmRedKeysRand.Text = "Random";
            this.rad_RmRedKeysRand.UseVisualStyleBackColor = true;
            this.rad_RmRedKeysRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmRedKeysOn
            // 
            this.rad_RmRedKeysOn.AutoSize = true;
            this.rad_RmRedKeysOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RmRedKeysOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmRedKeysOn.Name = "rad_RmRedKeysOn";
            this.rad_RmRedKeysOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RmRedKeysOn.TabIndex = 1;
            this.rad_RmRedKeysOn.Text = "On";
            this.rad_RmRedKeysOn.UseVisualStyleBackColor = true;
            this.rad_RmRedKeysOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RmRedKeysOff
            // 
            this.rad_RmRedKeysOff.AutoSize = true;
            this.rad_RmRedKeysOff.Checked = true;
            this.rad_RmRedKeysOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RmRedKeysOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RmRedKeysOff.Name = "rad_RmRedKeysOff";
            this.rad_RmRedKeysOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RmRedKeysOff.TabIndex = 0;
            this.rad_RmRedKeysOff.TabStop = true;
            this.rad_RmRedKeysOff.Text = "Off";
            this.rad_RmRedKeysOff.UseVisualStyleBackColor = true;
            this.rad_RmRedKeysOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandEqPwr
            // 
            this.grp_RandEqPwr.Controls.Add(this.rad_RandEqPwrRand);
            this.grp_RandEqPwr.Controls.Add(this.rad_RandEqPwrOn);
            this.grp_RandEqPwr.Controls.Add(this.rad_RandEqPwrOff);
            this.grp_RandEqPwr.Location = new System.Drawing.Point(4, 49);
            this.grp_RandEqPwr.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RandEqPwr.Name = "grp_RandEqPwr";
            this.grp_RandEqPwr.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RandEqPwr.Size = new System.Drawing.Size(163, 41);
            this.grp_RandEqPwr.TabIndex = 134;
            this.grp_RandEqPwr.TabStop = false;
            this.grp_RandEqPwr.Text = "Randomize Equipment Power";
            this.adjustments.SetToolTip(this.grp_RandEqPwr, "Randomizes the power of weapons, armor, helmets, and shields.");
            // 
            // rad_RandEqPwrRand
            // 
            this.rad_RandEqPwrRand.AutoSize = true;
            this.rad_RandEqPwrRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RandEqPwrRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandEqPwrRand.Name = "rad_RandEqPwrRand";
            this.rad_RandEqPwrRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandEqPwrRand.TabIndex = 2;
            this.rad_RandEqPwrRand.Text = "Random";
            this.rad_RandEqPwrRand.UseVisualStyleBackColor = true;
            this.rad_RandEqPwrRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandEqPwrOn
            // 
            this.rad_RandEqPwrOn.AutoSize = true;
            this.rad_RandEqPwrOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RandEqPwrOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandEqPwrOn.Name = "rad_RandEqPwrOn";
            this.rad_RandEqPwrOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandEqPwrOn.TabIndex = 1;
            this.rad_RandEqPwrOn.Text = "On";
            this.rad_RandEqPwrOn.UseVisualStyleBackColor = true;
            this.rad_RandEqPwrOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandEqPwrOff
            // 
            this.rad_RandEqPwrOff.AutoSize = true;
            this.rad_RandEqPwrOff.Checked = true;
            this.rad_RandEqPwrOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandEqPwrOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandEqPwrOff.Name = "rad_RandEqPwrOff";
            this.rad_RandEqPwrOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandEqPwrOff.TabIndex = 0;
            this.rad_RandEqPwrOff.TabStop = true;
            this.rad_RandEqPwrOff.Text = "Off";
            this.rad_RandEqPwrOff.UseVisualStyleBackColor = true;
            this.rad_RandEqPwrOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_OrbDft
            // 
            this.grp_OrbDft.Controls.Add(this.rad_OrbDftRand);
            this.grp_OrbDft.Controls.Add(this.rad_OrbDftOn);
            this.grp_OrbDft.Controls.Add(this.rad_OrbDftOff);
            this.grp_OrbDft.Location = new System.Drawing.Point(173, 4);
            this.grp_OrbDft.Margin = new System.Windows.Forms.Padding(2);
            this.grp_OrbDft.Name = "grp_OrbDft";
            this.grp_OrbDft.Padding = new System.Windows.Forms.Padding(2);
            this.grp_OrbDft.Size = new System.Drawing.Size(163, 41);
            this.grp_OrbDft.TabIndex = 131;
            this.grp_OrbDft.TabStop = false;
            this.grp_OrbDft.Text = "Green and Silver Orb Default";
            this.adjustments.SetToolTip(this.grp_OrbDft, "Allows Green and Silver Orbs to be found in their default locations.");
            // 
            // rad_OrbDftRand
            // 
            this.rad_OrbDftRand.AutoSize = true;
            this.rad_OrbDftRand.Location = new System.Drawing.Point(92, 19);
            this.rad_OrbDftRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_OrbDftRand.Name = "rad_OrbDftRand";
            this.rad_OrbDftRand.Size = new System.Drawing.Size(65, 17);
            this.rad_OrbDftRand.TabIndex = 2;
            this.rad_OrbDftRand.Text = "Random";
            this.rad_OrbDftRand.UseVisualStyleBackColor = true;
            this.rad_OrbDftRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_OrbDftOn
            // 
            this.rad_OrbDftOn.AutoSize = true;
            this.rad_OrbDftOn.Location = new System.Drawing.Point(49, 19);
            this.rad_OrbDftOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_OrbDftOn.Name = "rad_OrbDftOn";
            this.rad_OrbDftOn.Size = new System.Drawing.Size(39, 17);
            this.rad_OrbDftOn.TabIndex = 1;
            this.rad_OrbDftOn.Text = "On";
            this.rad_OrbDftOn.UseVisualStyleBackColor = true;
            this.rad_OrbDftOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_OrbDftOff
            // 
            this.rad_OrbDftOff.AutoSize = true;
            this.rad_OrbDftOff.Checked = true;
            this.rad_OrbDftOff.Location = new System.Drawing.Point(6, 19);
            this.rad_OrbDftOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_OrbDftOff.Name = "rad_OrbDftOff";
            this.rad_OrbDftOff.Size = new System.Drawing.Size(39, 17);
            this.rad_OrbDftOff.TabIndex = 0;
            this.rad_OrbDftOff.TabStop = true;
            this.rad_OrbDftOff.Text = "Off";
            this.rad_OrbDftOff.UseVisualStyleBackColor = true;
            this.rad_OrbDftOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandTreas
            // 
            this.grp_RandTreas.Controls.Add(this.rad_RandTreasRand);
            this.grp_RandTreas.Controls.Add(this.rad_RandTreasOn);
            this.grp_RandTreas.Controls.Add(this.rad_RandTreasOff);
            this.grp_RandTreas.Location = new System.Drawing.Point(4, 4);
            this.grp_RandTreas.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RandTreas.Name = "grp_RandTreas";
            this.grp_RandTreas.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RandTreas.Size = new System.Drawing.Size(163, 41);
            this.grp_RandTreas.TabIndex = 130;
            this.grp_RandTreas.TabStop = false;
            this.grp_RandTreas.Text = "Randomize Treasures";
            this.adjustments.SetToolTip(this.grp_RandTreas, "Randomizes treasures found in chests and on the ground.");
            // 
            // rad_RandTreasRand
            // 
            this.rad_RandTreasRand.AutoSize = true;
            this.rad_RandTreasRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RandTreasRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandTreasRand.Name = "rad_RandTreasRand";
            this.rad_RandTreasRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandTreasRand.TabIndex = 2;
            this.rad_RandTreasRand.Text = "Random";
            this.rad_RandTreasRand.UseVisualStyleBackColor = true;
            this.rad_RandTreasRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandTreasOn
            // 
            this.rad_RandTreasOn.AutoSize = true;
            this.rad_RandTreasOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RandTreasOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandTreasOn.Name = "rad_RandTreasOn";
            this.rad_RandTreasOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandTreasOn.TabIndex = 1;
            this.rad_RandTreasOn.Text = "On";
            this.rad_RandTreasOn.UseVisualStyleBackColor = true;
            this.rad_RandTreasOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandTreasOff
            // 
            this.rad_RandTreasOff.AutoSize = true;
            this.rad_RandTreasOff.Checked = true;
            this.rad_RandTreasOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandTreasOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandTreasOff.Name = "rad_RandTreasOff";
            this.rad_RandTreasOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandTreasOff.TabIndex = 0;
            this.rad_RandTreasOff.TabStop = true;
            this.rad_RandTreasOff.Text = "Off";
            this.rad_RandTreasOff.UseVisualStyleBackColor = true;
            this.rad_RandTreasOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.grp_AddToItemShop);
            this.tabPage6.Controls.Add(this.grp_Caturday);
            this.tabPage6.Controls.Add(this.grp_SellUnsellable);
            this.tabPage6.Controls.Add(this.grp_RandItemShop);
            this.tabPage6.Controls.Add(this.grp_RandWeapShop);
            this.tabPage6.Controls.Add(this.grp_RandInn);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(678, 422);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Item & Weapon Shops & Inns";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // grp_AddToItemShop
            // 
            this.grp_AddToItemShop.Controls.Add(this.grp_LampOfDarkness);
            this.grp_AddToItemShop.Controls.Add(this.grp_ShoesOfHappiness);
            this.grp_AddToItemShop.Controls.Add(this.grp_RingOfLife);
            this.grp_AddToItemShop.Controls.Add(this.grp_SilverHarp);
            this.grp_AddToItemShop.Controls.Add(this.grp_EchoingFlute);
            this.grp_AddToItemShop.Controls.Add(this.grp_WizardRing);
            this.grp_AddToItemShop.Controls.Add(this.grp_MetoriteArmband);
            this.grp_AddToItemShop.Controls.Add(this.grp_Satori);
            this.grp_AddToItemShop.Controls.Add(this.grp_StoneOfLife);
            this.grp_AddToItemShop.Controls.Add(this.grp_PoisonMoth);
            this.grp_AddToItemShop.Controls.Add(this.grp_LucSeed);
            this.grp_AddToItemShop.Controls.Add(this.grp_VitSeed);
            this.grp_AddToItemShop.Controls.Add(this.grp_WorldTree);
            this.grp_AddToItemShop.Controls.Add(this.grp_IntSeed);
            this.grp_AddToItemShop.Controls.Add(this.grp_AgiSeed);
            this.grp_AddToItemShop.Controls.Add(this.grp_StrSeed);
            this.grp_AddToItemShop.Controls.Add(this.grp_Acorns);
            this.grp_AddToItemShop.Location = new System.Drawing.Point(3, 94);
            this.grp_AddToItemShop.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AddToItemShop.Name = "grp_AddToItemShop";
            this.grp_AddToItemShop.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AddToItemShop.Size = new System.Drawing.Size(670, 240);
            this.grp_AddToItemShop.TabIndex = 165;
            this.grp_AddToItemShop.TabStop = false;
            this.grp_AddToItemShop.Text = "Add to Item Shops Pool";
            this.adjustments.SetToolTip(this.grp_AddToItemShop, "Add specific items to Item Shop pool.");
            // 
            // grp_LampOfDarkness
            // 
            this.grp_LampOfDarkness.Controls.Add(this.rad_LampOfDarknessRand);
            this.grp_LampOfDarkness.Controls.Add(this.rad_LampOfDarknessOn);
            this.grp_LampOfDarkness.Controls.Add(this.rad_LampOfDarknessOff);
            this.grp_LampOfDarkness.Location = new System.Drawing.Point(4, 196);
            this.grp_LampOfDarkness.Margin = new System.Windows.Forms.Padding(2);
            this.grp_LampOfDarkness.Name = "grp_LampOfDarkness";
            this.grp_LampOfDarkness.Padding = new System.Windows.Forms.Padding(2);
            this.grp_LampOfDarkness.Size = new System.Drawing.Size(163, 41);
            this.grp_LampOfDarkness.TabIndex = 181;
            this.grp_LampOfDarkness.TabStop = false;
            this.grp_LampOfDarkness.Text = "Lamp of Darkness";
            // 
            // rad_LampOfDarknessRand
            // 
            this.rad_LampOfDarknessRand.AutoSize = true;
            this.rad_LampOfDarknessRand.Location = new System.Drawing.Point(92, 19);
            this.rad_LampOfDarknessRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_LampOfDarknessRand.Name = "rad_LampOfDarknessRand";
            this.rad_LampOfDarknessRand.Size = new System.Drawing.Size(65, 17);
            this.rad_LampOfDarknessRand.TabIndex = 2;
            this.rad_LampOfDarknessRand.Text = "Random";
            this.rad_LampOfDarknessRand.UseVisualStyleBackColor = true;
            this.rad_LampOfDarknessRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LampOfDarknessOn
            // 
            this.rad_LampOfDarknessOn.AutoSize = true;
            this.rad_LampOfDarknessOn.Location = new System.Drawing.Point(49, 19);
            this.rad_LampOfDarknessOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_LampOfDarknessOn.Name = "rad_LampOfDarknessOn";
            this.rad_LampOfDarknessOn.Size = new System.Drawing.Size(39, 17);
            this.rad_LampOfDarknessOn.TabIndex = 1;
            this.rad_LampOfDarknessOn.Text = "On";
            this.rad_LampOfDarknessOn.UseVisualStyleBackColor = true;
            this.rad_LampOfDarknessOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LampOfDarknessOff
            // 
            this.rad_LampOfDarknessOff.AutoSize = true;
            this.rad_LampOfDarknessOff.Checked = true;
            this.rad_LampOfDarknessOff.Location = new System.Drawing.Point(6, 19);
            this.rad_LampOfDarknessOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_LampOfDarknessOff.Name = "rad_LampOfDarknessOff";
            this.rad_LampOfDarknessOff.Size = new System.Drawing.Size(39, 17);
            this.rad_LampOfDarknessOff.TabIndex = 0;
            this.rad_LampOfDarknessOff.TabStop = true;
            this.rad_LampOfDarknessOff.Text = "Off";
            this.rad_LampOfDarknessOff.UseVisualStyleBackColor = true;
            this.rad_LampOfDarknessOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_ShoesOfHappiness
            // 
            this.grp_ShoesOfHappiness.Controls.Add(this.rad_ShoesOfHappinessRand);
            this.grp_ShoesOfHappiness.Controls.Add(this.rad_ShoesOfHappinessOn);
            this.grp_ShoesOfHappiness.Controls.Add(this.rad_ShoesOfHappinessOff);
            this.grp_ShoesOfHappiness.Location = new System.Drawing.Point(503, 151);
            this.grp_ShoesOfHappiness.Margin = new System.Windows.Forms.Padding(2);
            this.grp_ShoesOfHappiness.Name = "grp_ShoesOfHappiness";
            this.grp_ShoesOfHappiness.Padding = new System.Windows.Forms.Padding(2);
            this.grp_ShoesOfHappiness.Size = new System.Drawing.Size(163, 41);
            this.grp_ShoesOfHappiness.TabIndex = 180;
            this.grp_ShoesOfHappiness.TabStop = false;
            this.grp_ShoesOfHappiness.Text = "Shoes of Happiness";
            // 
            // rad_ShoesOfHappinessRand
            // 
            this.rad_ShoesOfHappinessRand.AutoSize = true;
            this.rad_ShoesOfHappinessRand.Location = new System.Drawing.Point(92, 19);
            this.rad_ShoesOfHappinessRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ShoesOfHappinessRand.Name = "rad_ShoesOfHappinessRand";
            this.rad_ShoesOfHappinessRand.Size = new System.Drawing.Size(65, 17);
            this.rad_ShoesOfHappinessRand.TabIndex = 2;
            this.rad_ShoesOfHappinessRand.Text = "Random";
            this.rad_ShoesOfHappinessRand.UseVisualStyleBackColor = true;
            this.rad_ShoesOfHappinessRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ShoesOfHappinessOn
            // 
            this.rad_ShoesOfHappinessOn.AutoSize = true;
            this.rad_ShoesOfHappinessOn.Location = new System.Drawing.Point(49, 19);
            this.rad_ShoesOfHappinessOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ShoesOfHappinessOn.Name = "rad_ShoesOfHappinessOn";
            this.rad_ShoesOfHappinessOn.Size = new System.Drawing.Size(39, 17);
            this.rad_ShoesOfHappinessOn.TabIndex = 1;
            this.rad_ShoesOfHappinessOn.Text = "On";
            this.rad_ShoesOfHappinessOn.UseVisualStyleBackColor = true;
            this.rad_ShoesOfHappinessOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_ShoesOfHappinessOff
            // 
            this.rad_ShoesOfHappinessOff.AutoSize = true;
            this.rad_ShoesOfHappinessOff.Checked = true;
            this.rad_ShoesOfHappinessOff.Location = new System.Drawing.Point(6, 19);
            this.rad_ShoesOfHappinessOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_ShoesOfHappinessOff.Name = "rad_ShoesOfHappinessOff";
            this.rad_ShoesOfHappinessOff.Size = new System.Drawing.Size(39, 17);
            this.rad_ShoesOfHappinessOff.TabIndex = 0;
            this.rad_ShoesOfHappinessOff.TabStop = true;
            this.rad_ShoesOfHappinessOff.Text = "Off";
            this.rad_ShoesOfHappinessOff.UseVisualStyleBackColor = true;
            this.rad_ShoesOfHappinessOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RingOfLife
            // 
            this.grp_RingOfLife.Controls.Add(this.rad_RingOfLifeRand);
            this.grp_RingOfLife.Controls.Add(this.rad_RingOfLifeOn);
            this.grp_RingOfLife.Controls.Add(this.rad_RingOfLifeOff);
            this.grp_RingOfLife.Location = new System.Drawing.Point(337, 151);
            this.grp_RingOfLife.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RingOfLife.Name = "grp_RingOfLife";
            this.grp_RingOfLife.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RingOfLife.Size = new System.Drawing.Size(163, 41);
            this.grp_RingOfLife.TabIndex = 179;
            this.grp_RingOfLife.TabStop = false;
            this.grp_RingOfLife.Text = "Ring of Life";
            // 
            // rad_RingOfLifeRand
            // 
            this.rad_RingOfLifeRand.AutoSize = true;
            this.rad_RingOfLifeRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RingOfLifeRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RingOfLifeRand.Name = "rad_RingOfLifeRand";
            this.rad_RingOfLifeRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RingOfLifeRand.TabIndex = 2;
            this.rad_RingOfLifeRand.Text = "Random";
            this.rad_RingOfLifeRand.UseVisualStyleBackColor = true;
            this.rad_RingOfLifeRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RingOfLifeOn
            // 
            this.rad_RingOfLifeOn.AutoSize = true;
            this.rad_RingOfLifeOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RingOfLifeOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RingOfLifeOn.Name = "rad_RingOfLifeOn";
            this.rad_RingOfLifeOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RingOfLifeOn.TabIndex = 1;
            this.rad_RingOfLifeOn.Text = "On";
            this.rad_RingOfLifeOn.UseVisualStyleBackColor = true;
            this.rad_RingOfLifeOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RingOfLifeOff
            // 
            this.rad_RingOfLifeOff.AutoSize = true;
            this.rad_RingOfLifeOff.Checked = true;
            this.rad_RingOfLifeOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RingOfLifeOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RingOfLifeOff.Name = "rad_RingOfLifeOff";
            this.rad_RingOfLifeOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RingOfLifeOff.TabIndex = 0;
            this.rad_RingOfLifeOff.TabStop = true;
            this.rad_RingOfLifeOff.Text = "Off";
            this.rad_RingOfLifeOff.UseVisualStyleBackColor = true;
            this.rad_RingOfLifeOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_SilverHarp
            // 
            this.grp_SilverHarp.Controls.Add(this.rad_SilverHarpRand);
            this.grp_SilverHarp.Controls.Add(this.rad_SilverHarpOn);
            this.grp_SilverHarp.Controls.Add(this.rad_SilverHarpOff);
            this.grp_SilverHarp.Location = new System.Drawing.Point(170, 151);
            this.grp_SilverHarp.Margin = new System.Windows.Forms.Padding(2);
            this.grp_SilverHarp.Name = "grp_SilverHarp";
            this.grp_SilverHarp.Padding = new System.Windows.Forms.Padding(2);
            this.grp_SilverHarp.Size = new System.Drawing.Size(163, 41);
            this.grp_SilverHarp.TabIndex = 178;
            this.grp_SilverHarp.TabStop = false;
            this.grp_SilverHarp.Text = "Silver Harp";
            // 
            // rad_SilverHarpRand
            // 
            this.rad_SilverHarpRand.AutoSize = true;
            this.rad_SilverHarpRand.Location = new System.Drawing.Point(93, 19);
            this.rad_SilverHarpRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SilverHarpRand.Name = "rad_SilverHarpRand";
            this.rad_SilverHarpRand.Size = new System.Drawing.Size(65, 17);
            this.rad_SilverHarpRand.TabIndex = 2;
            this.rad_SilverHarpRand.Text = "Random";
            this.rad_SilverHarpRand.UseVisualStyleBackColor = true;
            this.rad_SilverHarpRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SilverHarpOn
            // 
            this.rad_SilverHarpOn.AutoSize = true;
            this.rad_SilverHarpOn.Location = new System.Drawing.Point(50, 19);
            this.rad_SilverHarpOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SilverHarpOn.Name = "rad_SilverHarpOn";
            this.rad_SilverHarpOn.Size = new System.Drawing.Size(39, 17);
            this.rad_SilverHarpOn.TabIndex = 1;
            this.rad_SilverHarpOn.Text = "On";
            this.rad_SilverHarpOn.UseVisualStyleBackColor = true;
            this.rad_SilverHarpOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SilverHarpOff
            // 
            this.rad_SilverHarpOff.AutoSize = true;
            this.rad_SilverHarpOff.Checked = true;
            this.rad_SilverHarpOff.Location = new System.Drawing.Point(6, 19);
            this.rad_SilverHarpOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SilverHarpOff.Name = "rad_SilverHarpOff";
            this.rad_SilverHarpOff.Size = new System.Drawing.Size(39, 17);
            this.rad_SilverHarpOff.TabIndex = 0;
            this.rad_SilverHarpOff.TabStop = true;
            this.rad_SilverHarpOff.Text = "Off";
            this.rad_SilverHarpOff.UseVisualStyleBackColor = true;
            this.rad_SilverHarpOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_EchoingFlute
            // 
            this.grp_EchoingFlute.Controls.Add(this.rad_EchoingFluteRand);
            this.grp_EchoingFlute.Controls.Add(this.rad_EchoingFluteOn);
            this.grp_EchoingFlute.Controls.Add(this.rad_EchoingFluteOff);
            this.grp_EchoingFlute.Location = new System.Drawing.Point(4, 151);
            this.grp_EchoingFlute.Margin = new System.Windows.Forms.Padding(2);
            this.grp_EchoingFlute.Name = "grp_EchoingFlute";
            this.grp_EchoingFlute.Padding = new System.Windows.Forms.Padding(2);
            this.grp_EchoingFlute.Size = new System.Drawing.Size(163, 41);
            this.grp_EchoingFlute.TabIndex = 177;
            this.grp_EchoingFlute.TabStop = false;
            this.grp_EchoingFlute.Text = "Echoing Flute";
            // 
            // rad_EchoingFluteRand
            // 
            this.rad_EchoingFluteRand.AutoSize = true;
            this.rad_EchoingFluteRand.Location = new System.Drawing.Point(92, 19);
            this.rad_EchoingFluteRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EchoingFluteRand.Name = "rad_EchoingFluteRand";
            this.rad_EchoingFluteRand.Size = new System.Drawing.Size(65, 17);
            this.rad_EchoingFluteRand.TabIndex = 2;
            this.rad_EchoingFluteRand.Text = "Random";
            this.rad_EchoingFluteRand.UseVisualStyleBackColor = true;
            this.rad_EchoingFluteRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EchoingFluteOn
            // 
            this.rad_EchoingFluteOn.AutoSize = true;
            this.rad_EchoingFluteOn.Location = new System.Drawing.Point(49, 19);
            this.rad_EchoingFluteOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EchoingFluteOn.Name = "rad_EchoingFluteOn";
            this.rad_EchoingFluteOn.Size = new System.Drawing.Size(39, 17);
            this.rad_EchoingFluteOn.TabIndex = 1;
            this.rad_EchoingFluteOn.Text = "On";
            this.rad_EchoingFluteOn.UseVisualStyleBackColor = true;
            this.rad_EchoingFluteOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_EchoingFluteOff
            // 
            this.rad_EchoingFluteOff.AutoSize = true;
            this.rad_EchoingFluteOff.Checked = true;
            this.rad_EchoingFluteOff.Location = new System.Drawing.Point(6, 19);
            this.rad_EchoingFluteOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_EchoingFluteOff.Name = "rad_EchoingFluteOff";
            this.rad_EchoingFluteOff.Size = new System.Drawing.Size(39, 17);
            this.rad_EchoingFluteOff.TabIndex = 0;
            this.rad_EchoingFluteOff.TabStop = true;
            this.rad_EchoingFluteOff.Text = "Off";
            this.rad_EchoingFluteOff.UseVisualStyleBackColor = true;
            this.rad_EchoingFluteOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_WizardRing
            // 
            this.grp_WizardRing.Controls.Add(this.rad_WizardRingRand);
            this.grp_WizardRing.Controls.Add(this.rad_WizardRingOn);
            this.grp_WizardRing.Controls.Add(this.rad_WizardRingOff);
            this.grp_WizardRing.Location = new System.Drawing.Point(503, 106);
            this.grp_WizardRing.Margin = new System.Windows.Forms.Padding(2);
            this.grp_WizardRing.Name = "grp_WizardRing";
            this.grp_WizardRing.Padding = new System.Windows.Forms.Padding(2);
            this.grp_WizardRing.Size = new System.Drawing.Size(163, 41);
            this.grp_WizardRing.TabIndex = 176;
            this.grp_WizardRing.TabStop = false;
            this.grp_WizardRing.Text = "Wizard\'s Ring";
            // 
            // rad_WizardRingRand
            // 
            this.rad_WizardRingRand.AutoSize = true;
            this.rad_WizardRingRand.Location = new System.Drawing.Point(92, 19);
            this.rad_WizardRingRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_WizardRingRand.Name = "rad_WizardRingRand";
            this.rad_WizardRingRand.Size = new System.Drawing.Size(65, 17);
            this.rad_WizardRingRand.TabIndex = 2;
            this.rad_WizardRingRand.Text = "Random";
            this.rad_WizardRingRand.UseVisualStyleBackColor = true;
            this.rad_WizardRingRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_WizardRingOn
            // 
            this.rad_WizardRingOn.AutoSize = true;
            this.rad_WizardRingOn.Location = new System.Drawing.Point(49, 19);
            this.rad_WizardRingOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_WizardRingOn.Name = "rad_WizardRingOn";
            this.rad_WizardRingOn.Size = new System.Drawing.Size(39, 17);
            this.rad_WizardRingOn.TabIndex = 1;
            this.rad_WizardRingOn.Text = "On";
            this.rad_WizardRingOn.UseVisualStyleBackColor = true;
            this.rad_WizardRingOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_WizardRingOff
            // 
            this.rad_WizardRingOff.AutoSize = true;
            this.rad_WizardRingOff.Checked = true;
            this.rad_WizardRingOff.Location = new System.Drawing.Point(6, 19);
            this.rad_WizardRingOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_WizardRingOff.Name = "rad_WizardRingOff";
            this.rad_WizardRingOff.Size = new System.Drawing.Size(39, 17);
            this.rad_WizardRingOff.TabIndex = 0;
            this.rad_WizardRingOff.TabStop = true;
            this.rad_WizardRingOff.Text = "Off";
            this.rad_WizardRingOff.UseVisualStyleBackColor = true;
            this.rad_WizardRingOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_MetoriteArmband
            // 
            this.grp_MetoriteArmband.Controls.Add(this.rad_MetoriteArmbandRand);
            this.grp_MetoriteArmband.Controls.Add(this.rad_MetoriteArmbandOn);
            this.grp_MetoriteArmband.Controls.Add(this.rad_MetoriteArmbandOff);
            this.grp_MetoriteArmband.Location = new System.Drawing.Point(337, 106);
            this.grp_MetoriteArmband.Margin = new System.Windows.Forms.Padding(2);
            this.grp_MetoriteArmband.Name = "grp_MetoriteArmband";
            this.grp_MetoriteArmband.Padding = new System.Windows.Forms.Padding(2);
            this.grp_MetoriteArmband.Size = new System.Drawing.Size(163, 41);
            this.grp_MetoriteArmband.TabIndex = 175;
            this.grp_MetoriteArmband.TabStop = false;
            this.grp_MetoriteArmband.Text = "Meteorite Armband";
            // 
            // rad_MetoriteArmbandRand
            // 
            this.rad_MetoriteArmbandRand.AutoSize = true;
            this.rad_MetoriteArmbandRand.Location = new System.Drawing.Point(92, 19);
            this.rad_MetoriteArmbandRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_MetoriteArmbandRand.Name = "rad_MetoriteArmbandRand";
            this.rad_MetoriteArmbandRand.Size = new System.Drawing.Size(65, 17);
            this.rad_MetoriteArmbandRand.TabIndex = 2;
            this.rad_MetoriteArmbandRand.Text = "Random";
            this.rad_MetoriteArmbandRand.UseVisualStyleBackColor = true;
            this.rad_MetoriteArmbandRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_MetoriteArmbandOn
            // 
            this.rad_MetoriteArmbandOn.AutoSize = true;
            this.rad_MetoriteArmbandOn.Location = new System.Drawing.Point(49, 19);
            this.rad_MetoriteArmbandOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_MetoriteArmbandOn.Name = "rad_MetoriteArmbandOn";
            this.rad_MetoriteArmbandOn.Size = new System.Drawing.Size(39, 17);
            this.rad_MetoriteArmbandOn.TabIndex = 1;
            this.rad_MetoriteArmbandOn.Text = "On";
            this.rad_MetoriteArmbandOn.UseVisualStyleBackColor = true;
            this.rad_MetoriteArmbandOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_MetoriteArmbandOff
            // 
            this.rad_MetoriteArmbandOff.AutoSize = true;
            this.rad_MetoriteArmbandOff.Checked = true;
            this.rad_MetoriteArmbandOff.Location = new System.Drawing.Point(6, 19);
            this.rad_MetoriteArmbandOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_MetoriteArmbandOff.Name = "rad_MetoriteArmbandOff";
            this.rad_MetoriteArmbandOff.Size = new System.Drawing.Size(39, 17);
            this.rad_MetoriteArmbandOff.TabIndex = 0;
            this.rad_MetoriteArmbandOff.TabStop = true;
            this.rad_MetoriteArmbandOff.Text = "Off";
            this.rad_MetoriteArmbandOff.UseVisualStyleBackColor = true;
            this.rad_MetoriteArmbandOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_Satori
            // 
            this.grp_Satori.Controls.Add(this.rad_SatoriRand);
            this.grp_Satori.Controls.Add(this.rad_SatoriOn);
            this.grp_Satori.Controls.Add(this.rad_SatoriOff);
            this.grp_Satori.Location = new System.Drawing.Point(171, 106);
            this.grp_Satori.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Satori.Name = "grp_Satori";
            this.grp_Satori.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Satori.Size = new System.Drawing.Size(163, 41);
            this.grp_Satori.TabIndex = 174;
            this.grp_Satori.TabStop = false;
            this.grp_Satori.Text = "Book of Satori";
            // 
            // rad_SatoriRand
            // 
            this.rad_SatoriRand.AutoSize = true;
            this.rad_SatoriRand.Location = new System.Drawing.Point(92, 19);
            this.rad_SatoriRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SatoriRand.Name = "rad_SatoriRand";
            this.rad_SatoriRand.Size = new System.Drawing.Size(65, 17);
            this.rad_SatoriRand.TabIndex = 2;
            this.rad_SatoriRand.Text = "Random";
            this.rad_SatoriRand.UseVisualStyleBackColor = true;
            this.rad_SatoriRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SatoriOn
            // 
            this.rad_SatoriOn.AutoSize = true;
            this.rad_SatoriOn.Location = new System.Drawing.Point(49, 19);
            this.rad_SatoriOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SatoriOn.Name = "rad_SatoriOn";
            this.rad_SatoriOn.Size = new System.Drawing.Size(39, 17);
            this.rad_SatoriOn.TabIndex = 1;
            this.rad_SatoriOn.Text = "On";
            this.rad_SatoriOn.UseVisualStyleBackColor = true;
            this.rad_SatoriOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SatoriOff
            // 
            this.rad_SatoriOff.AutoSize = true;
            this.rad_SatoriOff.Checked = true;
            this.rad_SatoriOff.Location = new System.Drawing.Point(6, 19);
            this.rad_SatoriOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SatoriOff.Name = "rad_SatoriOff";
            this.rad_SatoriOff.Size = new System.Drawing.Size(39, 17);
            this.rad_SatoriOff.TabIndex = 0;
            this.rad_SatoriOff.TabStop = true;
            this.rad_SatoriOff.Text = "Off";
            this.rad_SatoriOff.UseVisualStyleBackColor = true;
            this.rad_SatoriOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_StoneOfLife
            // 
            this.grp_StoneOfLife.Controls.Add(this.rad_StoneOfLifeRand);
            this.grp_StoneOfLife.Controls.Add(this.rad_StoneOfLifeOn);
            this.grp_StoneOfLife.Controls.Add(this.rad_StoneOfLifeOff);
            this.grp_StoneOfLife.Location = new System.Drawing.Point(4, 106);
            this.grp_StoneOfLife.Margin = new System.Windows.Forms.Padding(2);
            this.grp_StoneOfLife.Name = "grp_StoneOfLife";
            this.grp_StoneOfLife.Padding = new System.Windows.Forms.Padding(2);
            this.grp_StoneOfLife.Size = new System.Drawing.Size(163, 41);
            this.grp_StoneOfLife.TabIndex = 173;
            this.grp_StoneOfLife.TabStop = false;
            this.grp_StoneOfLife.Text = "Stone of Life";
            // 
            // rad_StoneOfLifeRand
            // 
            this.rad_StoneOfLifeRand.AutoSize = true;
            this.rad_StoneOfLifeRand.Location = new System.Drawing.Point(92, 19);
            this.rad_StoneOfLifeRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_StoneOfLifeRand.Name = "rad_StoneOfLifeRand";
            this.rad_StoneOfLifeRand.Size = new System.Drawing.Size(65, 17);
            this.rad_StoneOfLifeRand.TabIndex = 2;
            this.rad_StoneOfLifeRand.Text = "Random";
            this.rad_StoneOfLifeRand.UseVisualStyleBackColor = true;
            this.rad_StoneOfLifeRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_StoneOfLifeOn
            // 
            this.rad_StoneOfLifeOn.AutoSize = true;
            this.rad_StoneOfLifeOn.Location = new System.Drawing.Point(49, 19);
            this.rad_StoneOfLifeOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_StoneOfLifeOn.Name = "rad_StoneOfLifeOn";
            this.rad_StoneOfLifeOn.Size = new System.Drawing.Size(39, 17);
            this.rad_StoneOfLifeOn.TabIndex = 1;
            this.rad_StoneOfLifeOn.Text = "On";
            this.rad_StoneOfLifeOn.UseVisualStyleBackColor = true;
            this.rad_StoneOfLifeOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_StoneOfLifeOff
            // 
            this.rad_StoneOfLifeOff.AutoSize = true;
            this.rad_StoneOfLifeOff.Checked = true;
            this.rad_StoneOfLifeOff.Location = new System.Drawing.Point(6, 19);
            this.rad_StoneOfLifeOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_StoneOfLifeOff.Name = "rad_StoneOfLifeOff";
            this.rad_StoneOfLifeOff.Size = new System.Drawing.Size(39, 17);
            this.rad_StoneOfLifeOff.TabIndex = 0;
            this.rad_StoneOfLifeOff.TabStop = true;
            this.rad_StoneOfLifeOff.Text = "Off";
            this.rad_StoneOfLifeOff.UseVisualStyleBackColor = true;
            this.rad_StoneOfLifeOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_PoisonMoth
            // 
            this.grp_PoisonMoth.Controls.Add(this.rad_PoisonMothRand);
            this.grp_PoisonMoth.Controls.Add(this.rad_PoisonMothOn);
            this.grp_PoisonMoth.Controls.Add(this.rad_PoisonMothOff);
            this.grp_PoisonMoth.Location = new System.Drawing.Point(503, 61);
            this.grp_PoisonMoth.Margin = new System.Windows.Forms.Padding(2);
            this.grp_PoisonMoth.Name = "grp_PoisonMoth";
            this.grp_PoisonMoth.Padding = new System.Windows.Forms.Padding(2);
            this.grp_PoisonMoth.Size = new System.Drawing.Size(163, 41);
            this.grp_PoisonMoth.TabIndex = 172;
            this.grp_PoisonMoth.TabStop = false;
            this.grp_PoisonMoth.Text = "Poison Moth Powder";
            // 
            // rad_PoisonMothRand
            // 
            this.rad_PoisonMothRand.AutoSize = true;
            this.rad_PoisonMothRand.Location = new System.Drawing.Point(92, 19);
            this.rad_PoisonMothRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_PoisonMothRand.Name = "rad_PoisonMothRand";
            this.rad_PoisonMothRand.Size = new System.Drawing.Size(65, 17);
            this.rad_PoisonMothRand.TabIndex = 2;
            this.rad_PoisonMothRand.Text = "Random";
            this.rad_PoisonMothRand.UseVisualStyleBackColor = true;
            this.rad_PoisonMothRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_PoisonMothOn
            // 
            this.rad_PoisonMothOn.AutoSize = true;
            this.rad_PoisonMothOn.Location = new System.Drawing.Point(49, 19);
            this.rad_PoisonMothOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_PoisonMothOn.Name = "rad_PoisonMothOn";
            this.rad_PoisonMothOn.Size = new System.Drawing.Size(39, 17);
            this.rad_PoisonMothOn.TabIndex = 1;
            this.rad_PoisonMothOn.Text = "On";
            this.rad_PoisonMothOn.UseVisualStyleBackColor = true;
            this.rad_PoisonMothOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_PoisonMothOff
            // 
            this.rad_PoisonMothOff.AutoSize = true;
            this.rad_PoisonMothOff.Checked = true;
            this.rad_PoisonMothOff.Location = new System.Drawing.Point(6, 19);
            this.rad_PoisonMothOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_PoisonMothOff.Name = "rad_PoisonMothOff";
            this.rad_PoisonMothOff.Size = new System.Drawing.Size(39, 17);
            this.rad_PoisonMothOff.TabIndex = 0;
            this.rad_PoisonMothOff.TabStop = true;
            this.rad_PoisonMothOff.Text = "Off";
            this.rad_PoisonMothOff.UseVisualStyleBackColor = true;
            this.rad_PoisonMothOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_LucSeed
            // 
            this.grp_LucSeed.Controls.Add(this.rad_LucSeedRand);
            this.grp_LucSeed.Controls.Add(this.rad_LucSeedOn);
            this.grp_LucSeed.Controls.Add(this.rad_LucSeedOff);
            this.grp_LucSeed.Location = new System.Drawing.Point(171, 61);
            this.grp_LucSeed.Margin = new System.Windows.Forms.Padding(2);
            this.grp_LucSeed.Name = "grp_LucSeed";
            this.grp_LucSeed.Padding = new System.Windows.Forms.Padding(2);
            this.grp_LucSeed.Size = new System.Drawing.Size(163, 41);
            this.grp_LucSeed.TabIndex = 170;
            this.grp_LucSeed.TabStop = false;
            this.grp_LucSeed.Text = "Luck Seed";
            // 
            // rad_LucSeedRand
            // 
            this.rad_LucSeedRand.AutoSize = true;
            this.rad_LucSeedRand.Location = new System.Drawing.Point(92, 19);
            this.rad_LucSeedRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_LucSeedRand.Name = "rad_LucSeedRand";
            this.rad_LucSeedRand.Size = new System.Drawing.Size(65, 17);
            this.rad_LucSeedRand.TabIndex = 2;
            this.rad_LucSeedRand.Text = "Random";
            this.rad_LucSeedRand.UseVisualStyleBackColor = true;
            this.rad_LucSeedRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LucSeedOn
            // 
            this.rad_LucSeedOn.AutoSize = true;
            this.rad_LucSeedOn.Location = new System.Drawing.Point(49, 19);
            this.rad_LucSeedOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_LucSeedOn.Name = "rad_LucSeedOn";
            this.rad_LucSeedOn.Size = new System.Drawing.Size(39, 17);
            this.rad_LucSeedOn.TabIndex = 1;
            this.rad_LucSeedOn.Text = "On";
            this.rad_LucSeedOn.UseVisualStyleBackColor = true;
            this.rad_LucSeedOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_LucSeedOff
            // 
            this.rad_LucSeedOff.AutoSize = true;
            this.rad_LucSeedOff.Checked = true;
            this.rad_LucSeedOff.Location = new System.Drawing.Point(6, 19);
            this.rad_LucSeedOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_LucSeedOff.Name = "rad_LucSeedOff";
            this.rad_LucSeedOff.Size = new System.Drawing.Size(39, 17);
            this.rad_LucSeedOff.TabIndex = 0;
            this.rad_LucSeedOff.TabStop = true;
            this.rad_LucSeedOff.Text = "Off";
            this.rad_LucSeedOff.UseVisualStyleBackColor = true;
            this.rad_LucSeedOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_VitSeed
            // 
            this.grp_VitSeed.Controls.Add(this.rad_VitSeedRand);
            this.grp_VitSeed.Controls.Add(this.rad_VitSeedOn);
            this.grp_VitSeed.Controls.Add(this.rad_VitSeedOff);
            this.grp_VitSeed.Location = new System.Drawing.Point(4, 61);
            this.grp_VitSeed.Margin = new System.Windows.Forms.Padding(2);
            this.grp_VitSeed.Name = "grp_VitSeed";
            this.grp_VitSeed.Padding = new System.Windows.Forms.Padding(2);
            this.grp_VitSeed.Size = new System.Drawing.Size(163, 41);
            this.grp_VitSeed.TabIndex = 169;
            this.grp_VitSeed.TabStop = false;
            this.grp_VitSeed.Text = "Vitality Seed";
            // 
            // rad_VitSeedRand
            // 
            this.rad_VitSeedRand.AutoSize = true;
            this.rad_VitSeedRand.Location = new System.Drawing.Point(92, 19);
            this.rad_VitSeedRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_VitSeedRand.Name = "rad_VitSeedRand";
            this.rad_VitSeedRand.Size = new System.Drawing.Size(65, 17);
            this.rad_VitSeedRand.TabIndex = 2;
            this.rad_VitSeedRand.Text = "Random";
            this.rad_VitSeedRand.UseVisualStyleBackColor = true;
            this.rad_VitSeedRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_VitSeedOn
            // 
            this.rad_VitSeedOn.AutoSize = true;
            this.rad_VitSeedOn.Location = new System.Drawing.Point(49, 19);
            this.rad_VitSeedOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_VitSeedOn.Name = "rad_VitSeedOn";
            this.rad_VitSeedOn.Size = new System.Drawing.Size(39, 17);
            this.rad_VitSeedOn.TabIndex = 1;
            this.rad_VitSeedOn.Text = "On";
            this.rad_VitSeedOn.UseVisualStyleBackColor = true;
            this.rad_VitSeedOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_VitSeedOff
            // 
            this.rad_VitSeedOff.AutoSize = true;
            this.rad_VitSeedOff.Checked = true;
            this.rad_VitSeedOff.Location = new System.Drawing.Point(6, 19);
            this.rad_VitSeedOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_VitSeedOff.Name = "rad_VitSeedOff";
            this.rad_VitSeedOff.Size = new System.Drawing.Size(39, 17);
            this.rad_VitSeedOff.TabIndex = 0;
            this.rad_VitSeedOff.TabStop = true;
            this.rad_VitSeedOff.Text = "Off";
            this.rad_VitSeedOff.UseVisualStyleBackColor = true;
            this.rad_VitSeedOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_WorldTree
            // 
            this.grp_WorldTree.Controls.Add(this.rad_WorldTreeRand);
            this.grp_WorldTree.Controls.Add(this.rad_WorldTreeOn);
            this.grp_WorldTree.Controls.Add(this.rad_WorldTreeOff);
            this.grp_WorldTree.Location = new System.Drawing.Point(337, 61);
            this.grp_WorldTree.Margin = new System.Windows.Forms.Padding(2);
            this.grp_WorldTree.Name = "grp_WorldTree";
            this.grp_WorldTree.Padding = new System.Windows.Forms.Padding(2);
            this.grp_WorldTree.Size = new System.Drawing.Size(163, 41);
            this.grp_WorldTree.TabIndex = 171;
            this.grp_WorldTree.TabStop = false;
            this.grp_WorldTree.Text = "Leaf of World Tree";
            // 
            // rad_WorldTreeRand
            // 
            this.rad_WorldTreeRand.AutoSize = true;
            this.rad_WorldTreeRand.Location = new System.Drawing.Point(92, 19);
            this.rad_WorldTreeRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_WorldTreeRand.Name = "rad_WorldTreeRand";
            this.rad_WorldTreeRand.Size = new System.Drawing.Size(65, 17);
            this.rad_WorldTreeRand.TabIndex = 2;
            this.rad_WorldTreeRand.Text = "Random";
            this.rad_WorldTreeRand.UseVisualStyleBackColor = true;
            this.rad_WorldTreeRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_WorldTreeOn
            // 
            this.rad_WorldTreeOn.AutoSize = true;
            this.rad_WorldTreeOn.Location = new System.Drawing.Point(49, 19);
            this.rad_WorldTreeOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_WorldTreeOn.Name = "rad_WorldTreeOn";
            this.rad_WorldTreeOn.Size = new System.Drawing.Size(39, 17);
            this.rad_WorldTreeOn.TabIndex = 1;
            this.rad_WorldTreeOn.Text = "On";
            this.rad_WorldTreeOn.UseVisualStyleBackColor = true;
            this.rad_WorldTreeOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_WorldTreeOff
            // 
            this.rad_WorldTreeOff.AutoSize = true;
            this.rad_WorldTreeOff.Checked = true;
            this.rad_WorldTreeOff.Location = new System.Drawing.Point(6, 19);
            this.rad_WorldTreeOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_WorldTreeOff.Name = "rad_WorldTreeOff";
            this.rad_WorldTreeOff.Size = new System.Drawing.Size(39, 17);
            this.rad_WorldTreeOff.TabIndex = 0;
            this.rad_WorldTreeOff.TabStop = true;
            this.rad_WorldTreeOff.Text = "Off";
            this.rad_WorldTreeOff.UseVisualStyleBackColor = true;
            this.rad_WorldTreeOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_IntSeed
            // 
            this.grp_IntSeed.Controls.Add(this.rad_IntSeedRand);
            this.grp_IntSeed.Controls.Add(this.rad_IntSeedOn);
            this.grp_IntSeed.Controls.Add(this.rad_IntSeedOff);
            this.grp_IntSeed.Location = new System.Drawing.Point(503, 16);
            this.grp_IntSeed.Margin = new System.Windows.Forms.Padding(2);
            this.grp_IntSeed.Name = "grp_IntSeed";
            this.grp_IntSeed.Padding = new System.Windows.Forms.Padding(2);
            this.grp_IntSeed.Size = new System.Drawing.Size(163, 41);
            this.grp_IntSeed.TabIndex = 168;
            this.grp_IntSeed.TabStop = false;
            this.grp_IntSeed.Text = "Intelligence Seed";
            // 
            // rad_IntSeedRand
            // 
            this.rad_IntSeedRand.AutoSize = true;
            this.rad_IntSeedRand.Location = new System.Drawing.Point(92, 19);
            this.rad_IntSeedRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_IntSeedRand.Name = "rad_IntSeedRand";
            this.rad_IntSeedRand.Size = new System.Drawing.Size(65, 17);
            this.rad_IntSeedRand.TabIndex = 2;
            this.rad_IntSeedRand.Text = "Random";
            this.rad_IntSeedRand.UseVisualStyleBackColor = true;
            this.rad_IntSeedRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_IntSeedOn
            // 
            this.rad_IntSeedOn.AutoSize = true;
            this.rad_IntSeedOn.Location = new System.Drawing.Point(49, 19);
            this.rad_IntSeedOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_IntSeedOn.Name = "rad_IntSeedOn";
            this.rad_IntSeedOn.Size = new System.Drawing.Size(39, 17);
            this.rad_IntSeedOn.TabIndex = 1;
            this.rad_IntSeedOn.Text = "On";
            this.rad_IntSeedOn.UseVisualStyleBackColor = true;
            this.rad_IntSeedOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_IntSeedOff
            // 
            this.rad_IntSeedOff.AutoSize = true;
            this.rad_IntSeedOff.Checked = true;
            this.rad_IntSeedOff.Location = new System.Drawing.Point(6, 19);
            this.rad_IntSeedOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_IntSeedOff.Name = "rad_IntSeedOff";
            this.rad_IntSeedOff.Size = new System.Drawing.Size(39, 17);
            this.rad_IntSeedOff.TabIndex = 0;
            this.rad_IntSeedOff.TabStop = true;
            this.rad_IntSeedOff.Text = "Off";
            this.rad_IntSeedOff.UseVisualStyleBackColor = true;
            this.rad_IntSeedOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_AgiSeed
            // 
            this.grp_AgiSeed.Controls.Add(this.rad_AgiSeedRand);
            this.grp_AgiSeed.Controls.Add(this.rad_AgiSeedOn);
            this.grp_AgiSeed.Controls.Add(this.rad_AgiSeedOff);
            this.grp_AgiSeed.Location = new System.Drawing.Point(337, 16);
            this.grp_AgiSeed.Margin = new System.Windows.Forms.Padding(2);
            this.grp_AgiSeed.Name = "grp_AgiSeed";
            this.grp_AgiSeed.Padding = new System.Windows.Forms.Padding(2);
            this.grp_AgiSeed.Size = new System.Drawing.Size(163, 41);
            this.grp_AgiSeed.TabIndex = 167;
            this.grp_AgiSeed.TabStop = false;
            this.grp_AgiSeed.Text = "Agility Seed";
            // 
            // rad_AgiSeedRand
            // 
            this.rad_AgiSeedRand.AutoSize = true;
            this.rad_AgiSeedRand.Location = new System.Drawing.Point(92, 19);
            this.rad_AgiSeedRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AgiSeedRand.Name = "rad_AgiSeedRand";
            this.rad_AgiSeedRand.Size = new System.Drawing.Size(65, 17);
            this.rad_AgiSeedRand.TabIndex = 2;
            this.rad_AgiSeedRand.Text = "Random";
            this.rad_AgiSeedRand.UseVisualStyleBackColor = true;
            this.rad_AgiSeedRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AgiSeedOn
            // 
            this.rad_AgiSeedOn.AutoSize = true;
            this.rad_AgiSeedOn.Location = new System.Drawing.Point(49, 19);
            this.rad_AgiSeedOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AgiSeedOn.Name = "rad_AgiSeedOn";
            this.rad_AgiSeedOn.Size = new System.Drawing.Size(39, 17);
            this.rad_AgiSeedOn.TabIndex = 1;
            this.rad_AgiSeedOn.Text = "On";
            this.rad_AgiSeedOn.UseVisualStyleBackColor = true;
            this.rad_AgiSeedOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AgiSeedOff
            // 
            this.rad_AgiSeedOff.AutoSize = true;
            this.rad_AgiSeedOff.Checked = true;
            this.rad_AgiSeedOff.Location = new System.Drawing.Point(6, 19);
            this.rad_AgiSeedOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AgiSeedOff.Name = "rad_AgiSeedOff";
            this.rad_AgiSeedOff.Size = new System.Drawing.Size(39, 17);
            this.rad_AgiSeedOff.TabIndex = 0;
            this.rad_AgiSeedOff.TabStop = true;
            this.rad_AgiSeedOff.Text = "Off";
            this.rad_AgiSeedOff.UseVisualStyleBackColor = true;
            this.rad_AgiSeedOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_StrSeed
            // 
            this.grp_StrSeed.Controls.Add(this.rad_StrSeedRand);
            this.grp_StrSeed.Controls.Add(this.rad_StrSeedOn);
            this.grp_StrSeed.Controls.Add(this.rad_StrSeedOff);
            this.grp_StrSeed.Location = new System.Drawing.Point(171, 16);
            this.grp_StrSeed.Margin = new System.Windows.Forms.Padding(2);
            this.grp_StrSeed.Name = "grp_StrSeed";
            this.grp_StrSeed.Padding = new System.Windows.Forms.Padding(2);
            this.grp_StrSeed.Size = new System.Drawing.Size(163, 41);
            this.grp_StrSeed.TabIndex = 166;
            this.grp_StrSeed.TabStop = false;
            this.grp_StrSeed.Text = "Strength Seed";
            // 
            // rad_StrSeedRand
            // 
            this.rad_StrSeedRand.AutoSize = true;
            this.rad_StrSeedRand.Location = new System.Drawing.Point(92, 19);
            this.rad_StrSeedRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_StrSeedRand.Name = "rad_StrSeedRand";
            this.rad_StrSeedRand.Size = new System.Drawing.Size(65, 17);
            this.rad_StrSeedRand.TabIndex = 2;
            this.rad_StrSeedRand.Text = "Random";
            this.rad_StrSeedRand.UseVisualStyleBackColor = true;
            this.rad_StrSeedRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_StrSeedOn
            // 
            this.rad_StrSeedOn.AutoSize = true;
            this.rad_StrSeedOn.Location = new System.Drawing.Point(49, 19);
            this.rad_StrSeedOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_StrSeedOn.Name = "rad_StrSeedOn";
            this.rad_StrSeedOn.Size = new System.Drawing.Size(39, 17);
            this.rad_StrSeedOn.TabIndex = 1;
            this.rad_StrSeedOn.Text = "On";
            this.rad_StrSeedOn.UseVisualStyleBackColor = true;
            this.rad_StrSeedOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_StrSeedOff
            // 
            this.rad_StrSeedOff.AutoSize = true;
            this.rad_StrSeedOff.Checked = true;
            this.rad_StrSeedOff.Location = new System.Drawing.Point(6, 19);
            this.rad_StrSeedOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_StrSeedOff.Name = "rad_StrSeedOff";
            this.rad_StrSeedOff.Size = new System.Drawing.Size(39, 17);
            this.rad_StrSeedOff.TabIndex = 0;
            this.rad_StrSeedOff.TabStop = true;
            this.rad_StrSeedOff.Text = "Off";
            this.rad_StrSeedOff.UseVisualStyleBackColor = true;
            this.rad_StrSeedOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_Acorns
            // 
            this.grp_Acorns.Controls.Add(this.rad_AcornsRand);
            this.grp_Acorns.Controls.Add(this.rad_AcornsOn);
            this.grp_Acorns.Controls.Add(this.rad_AcornsOff);
            this.grp_Acorns.Location = new System.Drawing.Point(4, 16);
            this.grp_Acorns.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Acorns.Name = "grp_Acorns";
            this.grp_Acorns.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Acorns.Size = new System.Drawing.Size(163, 41);
            this.grp_Acorns.TabIndex = 165;
            this.grp_Acorns.TabStop = false;
            this.grp_Acorns.Text = "Acorns of Life";
            // 
            // rad_AcornsRand
            // 
            this.rad_AcornsRand.AutoSize = true;
            this.rad_AcornsRand.Location = new System.Drawing.Point(92, 19);
            this.rad_AcornsRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AcornsRand.Name = "rad_AcornsRand";
            this.rad_AcornsRand.Size = new System.Drawing.Size(65, 17);
            this.rad_AcornsRand.TabIndex = 2;
            this.rad_AcornsRand.Text = "Random";
            this.rad_AcornsRand.UseVisualStyleBackColor = true;
            this.rad_AcornsRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AcornsOn
            // 
            this.rad_AcornsOn.AutoSize = true;
            this.rad_AcornsOn.Location = new System.Drawing.Point(49, 19);
            this.rad_AcornsOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AcornsOn.Name = "rad_AcornsOn";
            this.rad_AcornsOn.Size = new System.Drawing.Size(39, 17);
            this.rad_AcornsOn.TabIndex = 1;
            this.rad_AcornsOn.Text = "On";
            this.rad_AcornsOn.UseVisualStyleBackColor = true;
            this.rad_AcornsOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_AcornsOff
            // 
            this.rad_AcornsOff.AutoSize = true;
            this.rad_AcornsOff.Checked = true;
            this.rad_AcornsOff.Location = new System.Drawing.Point(6, 19);
            this.rad_AcornsOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_AcornsOff.Name = "rad_AcornsOff";
            this.rad_AcornsOff.Size = new System.Drawing.Size(39, 17);
            this.rad_AcornsOff.TabIndex = 0;
            this.rad_AcornsOff.TabStop = true;
            this.rad_AcornsOff.Text = "Off";
            this.rad_AcornsOff.UseVisualStyleBackColor = true;
            this.rad_AcornsOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_Caturday
            // 
            this.grp_Caturday.Controls.Add(this.rad_CaturdayRand);
            this.grp_Caturday.Controls.Add(this.rad_CaturdayOn);
            this.grp_Caturday.Controls.Add(this.rad_CaturdayOff);
            this.grp_Caturday.Location = new System.Drawing.Point(510, 49);
            this.grp_Caturday.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Caturday.Name = "grp_Caturday";
            this.grp_Caturday.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Caturday.Size = new System.Drawing.Size(163, 41);
            this.grp_Caturday.TabIndex = 164;
            this.grp_Caturday.TabStop = false;
            this.grp_Caturday.Text = "Caturday";
            this.adjustments.SetToolTip(this.grp_Caturday, "Ensures that the Animal Suit will be found in at least 1 Weapon Shp.");
            // 
            // rad_CaturdayRand
            // 
            this.rad_CaturdayRand.AutoSize = true;
            this.rad_CaturdayRand.Location = new System.Drawing.Point(92, 19);
            this.rad_CaturdayRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_CaturdayRand.Name = "rad_CaturdayRand";
            this.rad_CaturdayRand.Size = new System.Drawing.Size(65, 17);
            this.rad_CaturdayRand.TabIndex = 2;
            this.rad_CaturdayRand.Text = "Random";
            this.rad_CaturdayRand.UseVisualStyleBackColor = true;
            this.rad_CaturdayRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_CaturdayOn
            // 
            this.rad_CaturdayOn.AutoSize = true;
            this.rad_CaturdayOn.Location = new System.Drawing.Point(49, 19);
            this.rad_CaturdayOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_CaturdayOn.Name = "rad_CaturdayOn";
            this.rad_CaturdayOn.Size = new System.Drawing.Size(39, 17);
            this.rad_CaturdayOn.TabIndex = 1;
            this.rad_CaturdayOn.Text = "On";
            this.rad_CaturdayOn.UseVisualStyleBackColor = true;
            this.rad_CaturdayOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_CaturdayOff
            // 
            this.rad_CaturdayOff.AutoSize = true;
            this.rad_CaturdayOff.Checked = true;
            this.rad_CaturdayOff.Location = new System.Drawing.Point(6, 19);
            this.rad_CaturdayOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_CaturdayOff.Name = "rad_CaturdayOff";
            this.rad_CaturdayOff.Size = new System.Drawing.Size(39, 17);
            this.rad_CaturdayOff.TabIndex = 0;
            this.rad_CaturdayOff.TabStop = true;
            this.rad_CaturdayOff.Text = "Off";
            this.rad_CaturdayOff.UseVisualStyleBackColor = true;
            this.rad_CaturdayOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_SellUnsellable
            // 
            this.grp_SellUnsellable.Controls.Add(this.rad_SellUnsellableRand);
            this.grp_SellUnsellable.Controls.Add(this.rad_SellUnsellableOn);
            this.grp_SellUnsellable.Controls.Add(this.rad_SellUnsellableOff);
            this.grp_SellUnsellable.Location = new System.Drawing.Point(341, 49);
            this.grp_SellUnsellable.Margin = new System.Windows.Forms.Padding(2);
            this.grp_SellUnsellable.Name = "grp_SellUnsellable";
            this.grp_SellUnsellable.Padding = new System.Windows.Forms.Padding(2);
            this.grp_SellUnsellable.Size = new System.Drawing.Size(163, 41);
            this.grp_SellUnsellable.TabIndex = 163;
            this.grp_SellUnsellable.TabStop = false;
            this.grp_SellUnsellable.Text = "Sell Unsellable Items";
            this.adjustments.SetToolTip(this.grp_SellUnsellable, "Sell many key items. Be sure to use them before selling.");
            // 
            // rad_SellUnsellableRand
            // 
            this.rad_SellUnsellableRand.AutoSize = true;
            this.rad_SellUnsellableRand.Location = new System.Drawing.Point(92, 19);
            this.rad_SellUnsellableRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SellUnsellableRand.Name = "rad_SellUnsellableRand";
            this.rad_SellUnsellableRand.Size = new System.Drawing.Size(65, 17);
            this.rad_SellUnsellableRand.TabIndex = 2;
            this.rad_SellUnsellableRand.Text = "Random";
            this.rad_SellUnsellableRand.UseVisualStyleBackColor = true;
            this.rad_SellUnsellableRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SellUnsellableOn
            // 
            this.rad_SellUnsellableOn.AutoSize = true;
            this.rad_SellUnsellableOn.Location = new System.Drawing.Point(49, 19);
            this.rad_SellUnsellableOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SellUnsellableOn.Name = "rad_SellUnsellableOn";
            this.rad_SellUnsellableOn.Size = new System.Drawing.Size(39, 17);
            this.rad_SellUnsellableOn.TabIndex = 1;
            this.rad_SellUnsellableOn.Text = "On";
            this.rad_SellUnsellableOn.UseVisualStyleBackColor = true;
            this.rad_SellUnsellableOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_SellUnsellableOff
            // 
            this.rad_SellUnsellableOff.AutoSize = true;
            this.rad_SellUnsellableOff.Checked = true;
            this.rad_SellUnsellableOff.Location = new System.Drawing.Point(6, 19);
            this.rad_SellUnsellableOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_SellUnsellableOff.Name = "rad_SellUnsellableOff";
            this.rad_SellUnsellableOff.Size = new System.Drawing.Size(39, 17);
            this.rad_SellUnsellableOff.TabIndex = 0;
            this.rad_SellUnsellableOff.TabStop = true;
            this.rad_SellUnsellableOff.Text = "Off";
            this.rad_SellUnsellableOff.UseVisualStyleBackColor = true;
            this.rad_SellUnsellableOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandItemShop
            // 
            this.grp_RandItemShop.Controls.Add(this.rad_RandItemShopRand);
            this.grp_RandItemShop.Controls.Add(this.rad_RandItemShopOn);
            this.grp_RandItemShop.Controls.Add(this.rad_RandItemShopOff);
            this.grp_RandItemShop.Location = new System.Drawing.Point(173, 49);
            this.grp_RandItemShop.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RandItemShop.Name = "grp_RandItemShop";
            this.grp_RandItemShop.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RandItemShop.Size = new System.Drawing.Size(163, 41);
            this.grp_RandItemShop.TabIndex = 162;
            this.grp_RandItemShop.TabStop = false;
            this.grp_RandItemShop.Text = "Randomize Item Shops";
            this.adjustments.SetToolTip(this.grp_RandItemShop, "Randomizes items found in Item Shops.");
            // 
            // rad_RandItemShopRand
            // 
            this.rad_RandItemShopRand.AutoSize = true;
            this.rad_RandItemShopRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RandItemShopRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandItemShopRand.Name = "rad_RandItemShopRand";
            this.rad_RandItemShopRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandItemShopRand.TabIndex = 2;
            this.rad_RandItemShopRand.Text = "Random";
            this.rad_RandItemShopRand.UseVisualStyleBackColor = true;
            this.rad_RandItemShopRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandItemShopOn
            // 
            this.rad_RandItemShopOn.AutoSize = true;
            this.rad_RandItemShopOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RandItemShopOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandItemShopOn.Name = "rad_RandItemShopOn";
            this.rad_RandItemShopOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandItemShopOn.TabIndex = 1;
            this.rad_RandItemShopOn.Text = "On";
            this.rad_RandItemShopOn.UseVisualStyleBackColor = true;
            this.rad_RandItemShopOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandItemShopOff
            // 
            this.rad_RandItemShopOff.AutoSize = true;
            this.rad_RandItemShopOff.Checked = true;
            this.rad_RandItemShopOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandItemShopOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandItemShopOff.Name = "rad_RandItemShopOff";
            this.rad_RandItemShopOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandItemShopOff.TabIndex = 0;
            this.rad_RandItemShopOff.TabStop = true;
            this.rad_RandItemShopOff.Text = "Off";
            this.rad_RandItemShopOff.UseVisualStyleBackColor = true;
            this.rad_RandItemShopOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandWeapShop
            // 
            this.grp_RandWeapShop.Controls.Add(this.rad_RandWeapShopRand);
            this.grp_RandWeapShop.Controls.Add(this.rad_RandWeapShopOn);
            this.grp_RandWeapShop.Controls.Add(this.rad_RandWeapShopOff);
            this.grp_RandWeapShop.Location = new System.Drawing.Point(4, 49);
            this.grp_RandWeapShop.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RandWeapShop.Name = "grp_RandWeapShop";
            this.grp_RandWeapShop.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RandWeapShop.Size = new System.Drawing.Size(163, 41);
            this.grp_RandWeapShop.TabIndex = 161;
            this.grp_RandWeapShop.TabStop = false;
            this.grp_RandWeapShop.Text = "Randomize Weapon Shops";
            this.adjustments.SetToolTip(this.grp_RandWeapShop, "Randomizes weapons and armor found in Weapon Shops.");
            // 
            // rad_RandWeapShopRand
            // 
            this.rad_RandWeapShopRand.AutoSize = true;
            this.rad_RandWeapShopRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RandWeapShopRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandWeapShopRand.Name = "rad_RandWeapShopRand";
            this.rad_RandWeapShopRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandWeapShopRand.TabIndex = 2;
            this.rad_RandWeapShopRand.Text = "Random";
            this.rad_RandWeapShopRand.UseVisualStyleBackColor = true;
            this.rad_RandWeapShopRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandWeapShopOn
            // 
            this.rad_RandWeapShopOn.AutoSize = true;
            this.rad_RandWeapShopOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RandWeapShopOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandWeapShopOn.Name = "rad_RandWeapShopOn";
            this.rad_RandWeapShopOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandWeapShopOn.TabIndex = 1;
            this.rad_RandWeapShopOn.Text = "On";
            this.rad_RandWeapShopOn.UseVisualStyleBackColor = true;
            this.rad_RandWeapShopOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandWeapShopOff
            // 
            this.rad_RandWeapShopOff.AutoSize = true;
            this.rad_RandWeapShopOff.Checked = true;
            this.rad_RandWeapShopOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandWeapShopOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandWeapShopOff.Name = "rad_RandWeapShopOff";
            this.rad_RandWeapShopOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandWeapShopOff.TabIndex = 0;
            this.rad_RandWeapShopOff.TabStop = true;
            this.rad_RandWeapShopOff.Text = "Off";
            this.rad_RandWeapShopOff.UseVisualStyleBackColor = true;
            this.rad_RandWeapShopOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // grp_RandInn
            // 
            this.grp_RandInn.Controls.Add(this.rad_RandInnRand);
            this.grp_RandInn.Controls.Add(this.rad_RandInnOn);
            this.grp_RandInn.Controls.Add(this.rad_RandInnOff);
            this.grp_RandInn.Location = new System.Drawing.Point(4, 4);
            this.grp_RandInn.Margin = new System.Windows.Forms.Padding(2);
            this.grp_RandInn.Name = "grp_RandInn";
            this.grp_RandInn.Padding = new System.Windows.Forms.Padding(2);
            this.grp_RandInn.Size = new System.Drawing.Size(163, 41);
            this.grp_RandInn.TabIndex = 160;
            this.grp_RandInn.TabStop = false;
            this.grp_RandInn.Text = "Randomize Inn Prices";
            this.adjustments.SetToolTip(this.grp_RandInn, "Randomizes inn prices.");
            // 
            // rad_RandInnRand
            // 
            this.rad_RandInnRand.AutoSize = true;
            this.rad_RandInnRand.Location = new System.Drawing.Point(92, 19);
            this.rad_RandInnRand.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandInnRand.Name = "rad_RandInnRand";
            this.rad_RandInnRand.Size = new System.Drawing.Size(65, 17);
            this.rad_RandInnRand.TabIndex = 2;
            this.rad_RandInnRand.Text = "Random";
            this.rad_RandInnRand.UseVisualStyleBackColor = true;
            this.rad_RandInnRand.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandInnOn
            // 
            this.rad_RandInnOn.AutoSize = true;
            this.rad_RandInnOn.Location = new System.Drawing.Point(49, 19);
            this.rad_RandInnOn.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandInnOn.Name = "rad_RandInnOn";
            this.rad_RandInnOn.Size = new System.Drawing.Size(39, 17);
            this.rad_RandInnOn.TabIndex = 1;
            this.rad_RandInnOn.Text = "On";
            this.rad_RandInnOn.UseVisualStyleBackColor = true;
            this.rad_RandInnOn.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // rad_RandInnOff
            // 
            this.rad_RandInnOff.AutoSize = true;
            this.rad_RandInnOff.Checked = true;
            this.rad_RandInnOff.Location = new System.Drawing.Point(6, 19);
            this.rad_RandInnOff.Margin = new System.Windows.Forms.Padding(2);
            this.rad_RandInnOff.Name = "rad_RandInnOff";
            this.rad_RandInnOff.Size = new System.Drawing.Size(39, 17);
            this.rad_RandInnOff.TabIndex = 0;
            this.rad_RandInnOff.TabStop = true;
            this.rad_RandInnOff.Text = "Off";
            this.rad_RandInnOff.UseVisualStyleBackColor = true;
            this.rad_RandInnOff.CheckedChanged += new System.EventHandler(this.determineFlags);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grp_Class);
            this.tabPage3.Controls.Add(this.grp_Gender);
            this.tabPage3.Controls.Add(this.grp_ChName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(678, 422);
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
            this.chk_GenCompareFile.Location = new System.Drawing.Point(220, 688);
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
            this.chk_GenIslandsMonstersZones.Location = new System.Drawing.Point(372, 688);
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
            this.ClientSize = new System.Drawing.Size(698, 717);
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
            this.grp_RandItemEff.ResumeLayout(false);
            this.grp_RandItemEff.PerformLayout();
            this.grp_AddRemake.ResumeLayout(false);
            this.grp_AddRemake.PerformLayout();
            this.grp_AdjStartEq.ResumeLayout(false);
            this.grp_AdjStartEq.PerformLayout();
            this.grp_AddGoldClaw.ResumeLayout(false);
            this.grp_AddGoldClaw.PerformLayout();
            this.grp_RmFightPen.ResumeLayout(false);
            this.grp_RmFightPen.PerformLayout();
            this.grp_VanEqVal.ResumeLayout(false);
            this.grp_VanEqVal.PerformLayout();
            this.grp_RandClassEq.ResumeLayout(false);
            this.grp_RandClassEq.PerformLayout();
            this.grp_AdjEqPrice.ResumeLayout(false);
            this.grp_AdjEqPrice.PerformLayout();
            this.grp_RmRedKeys.ResumeLayout(false);
            this.grp_RmRedKeys.PerformLayout();
            this.grp_RandEqPwr.ResumeLayout(false);
            this.grp_RandEqPwr.PerformLayout();
            this.grp_OrbDft.ResumeLayout(false);
            this.grp_OrbDft.PerformLayout();
            this.grp_RandTreas.ResumeLayout(false);
            this.grp_RandTreas.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.grp_AddToItemShop.ResumeLayout(false);
            this.grp_LampOfDarkness.ResumeLayout(false);
            this.grp_LampOfDarkness.PerformLayout();
            this.grp_ShoesOfHappiness.ResumeLayout(false);
            this.grp_ShoesOfHappiness.PerformLayout();
            this.grp_RingOfLife.ResumeLayout(false);
            this.grp_RingOfLife.PerformLayout();
            this.grp_SilverHarp.ResumeLayout(false);
            this.grp_SilverHarp.PerformLayout();
            this.grp_EchoingFlute.ResumeLayout(false);
            this.grp_EchoingFlute.PerformLayout();
            this.grp_WizardRing.ResumeLayout(false);
            this.grp_WizardRing.PerformLayout();
            this.grp_MetoriteArmband.ResumeLayout(false);
            this.grp_MetoriteArmband.PerformLayout();
            this.grp_Satori.ResumeLayout(false);
            this.grp_Satori.PerformLayout();
            this.grp_StoneOfLife.ResumeLayout(false);
            this.grp_StoneOfLife.PerformLayout();
            this.grp_PoisonMoth.ResumeLayout(false);
            this.grp_PoisonMoth.PerformLayout();
            this.grp_LucSeed.ResumeLayout(false);
            this.grp_LucSeed.PerformLayout();
            this.grp_VitSeed.ResumeLayout(false);
            this.grp_VitSeed.PerformLayout();
            this.grp_WorldTree.ResumeLayout(false);
            this.grp_WorldTree.PerformLayout();
            this.grp_IntSeed.ResumeLayout(false);
            this.grp_IntSeed.PerformLayout();
            this.grp_AgiSeed.ResumeLayout(false);
            this.grp_AgiSeed.PerformLayout();
            this.grp_StrSeed.ResumeLayout(false);
            this.grp_StrSeed.PerformLayout();
            this.grp_Acorns.ResumeLayout(false);
            this.grp_Acorns.PerformLayout();
            this.grp_Caturday.ResumeLayout(false);
            this.grp_Caturday.PerformLayout();
            this.grp_SellUnsellable.ResumeLayout(false);
            this.grp_SellUnsellable.PerformLayout();
            this.grp_RandItemShop.ResumeLayout(false);
            this.grp_RandItemShop.PerformLayout();
            this.grp_RandWeapShop.ResumeLayout(false);
            this.grp_RandWeapShop.PerformLayout();
            this.grp_RandInn.ResumeLayout(false);
            this.grp_RandInn.PerformLayout();
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
        private System.Windows.Forms.GroupBox grp_AddGoldClaw;
        private System.Windows.Forms.RadioButton rad_AddGoldClawRand;
        private System.Windows.Forms.RadioButton rad_AddGoldClawOn;
        private System.Windows.Forms.RadioButton rad_AddGoldClawOff;
        private System.Windows.Forms.GroupBox grp_RmRedKeys;
        private System.Windows.Forms.RadioButton rad_RmRedKeysRand;
        private System.Windows.Forms.RadioButton rad_RmRedKeysOn;
        private System.Windows.Forms.RadioButton rad_RmRedKeysOff;
        private System.Windows.Forms.GroupBox grp_OrbDft;
        private System.Windows.Forms.RadioButton rad_OrbDftRand;
        private System.Windows.Forms.RadioButton rad_OrbDftOn;
        private System.Windows.Forms.RadioButton rad_OrbDftOff;
        private System.Windows.Forms.GroupBox grp_RandTreas;
        private System.Windows.Forms.RadioButton rad_RandTreasOn;
        private System.Windows.Forms.RadioButton rad_RandTreasOff;
        private System.Windows.Forms.GroupBox grp_AddRemake;
        private System.Windows.Forms.RadioButton rad_AddRemakeRand;
        private System.Windows.Forms.RadioButton rad_AddRemakeOn;
        private System.Windows.Forms.RadioButton rad_AddRemakeOff;
        private System.Windows.Forms.GroupBox grp_VanEqVal;
        private System.Windows.Forms.RadioButton rad_VanEqValRand;
        private System.Windows.Forms.RadioButton rad_VanEqValOn;
        private System.Windows.Forms.RadioButton rad_VanEqValOff;
        private System.Windows.Forms.GroupBox grp_AdjEqPrice;
        private System.Windows.Forms.RadioButton rad_AdjEqPriceRand;
        private System.Windows.Forms.RadioButton rad_AdjEqPriceOn;
        private System.Windows.Forms.RadioButton rad_AdjEqPriceOff;
        private System.Windows.Forms.GroupBox grp_RandEqPwr;
        private System.Windows.Forms.RadioButton rad_RandEqPwrRand;
        private System.Windows.Forms.RadioButton rad_RandEqPwrOn;
        private System.Windows.Forms.RadioButton rad_RandEqPwrOff;
        private System.Windows.Forms.GroupBox grp_RandItemEff;
        private System.Windows.Forms.RadioButton rad_RandItemEffRand;
        private System.Windows.Forms.RadioButton rad_RandItemEffOn;
        private System.Windows.Forms.RadioButton rad_RandItemEffOff;
        private System.Windows.Forms.GroupBox grp_AdjStartEq;
        private System.Windows.Forms.RadioButton rad_AdjStartEqRand;
        private System.Windows.Forms.RadioButton rad_AdjStartEqOn;
        private System.Windows.Forms.RadioButton rad_AdjStartEqOff;
        private System.Windows.Forms.GroupBox grp_RmFightPen;
        private System.Windows.Forms.RadioButton rad_RmFightPenRand;
        private System.Windows.Forms.RadioButton rad_RmFightPenOn;
        private System.Windows.Forms.RadioButton rad_RmFightPenOff;
        private System.Windows.Forms.GroupBox grp_RandClassEq;
        private System.Windows.Forms.RadioButton rad_RandClassEqRand;
        private System.Windows.Forms.RadioButton rad_RandClassEqOn;
        private System.Windows.Forms.RadioButton rad_RandClassEqOff;
        private System.Windows.Forms.RadioButton rad_RandTreasRand;
        private System.Windows.Forms.GroupBox grp_Caturday;
        private System.Windows.Forms.RadioButton rad_CaturdayRand;
        private System.Windows.Forms.RadioButton rad_CaturdayOn;
        private System.Windows.Forms.RadioButton rad_CaturdayOff;
        private System.Windows.Forms.GroupBox grp_SellUnsellable;
        private System.Windows.Forms.RadioButton rad_SellUnsellableRand;
        private System.Windows.Forms.RadioButton rad_SellUnsellableOn;
        private System.Windows.Forms.RadioButton rad_SellUnsellableOff;
        private System.Windows.Forms.GroupBox grp_RandItemShop;
        private System.Windows.Forms.RadioButton rad_RandItemShopRand;
        private System.Windows.Forms.RadioButton rad_RandItemShopOn;
        private System.Windows.Forms.RadioButton rad_RandItemShopOff;
        private System.Windows.Forms.GroupBox grp_RandWeapShop;
        private System.Windows.Forms.RadioButton rad_RandWeapShopRand;
        private System.Windows.Forms.RadioButton rad_RandWeapShopOn;
        private System.Windows.Forms.RadioButton rad_RandWeapShopOff;
        private System.Windows.Forms.GroupBox grp_RandInn;
        private System.Windows.Forms.RadioButton rad_RandInnRand;
        private System.Windows.Forms.RadioButton rad_RandInnOn;
        private System.Windows.Forms.RadioButton rad_RandInnOff;
        private System.Windows.Forms.GroupBox grp_Acorns;
        private System.Windows.Forms.RadioButton rad_AcornsRand;
        private System.Windows.Forms.RadioButton rad_AcornsOn;
        private System.Windows.Forms.RadioButton rad_AcornsOff;
        private System.Windows.Forms.GroupBox grp_AddToItemShop;
        private System.Windows.Forms.GroupBox grp_IntSeed;
        private System.Windows.Forms.RadioButton rad_IntSeedRand;
        private System.Windows.Forms.RadioButton rad_IntSeedOn;
        private System.Windows.Forms.RadioButton rad_IntSeedOff;
        private System.Windows.Forms.GroupBox grp_AgiSeed;
        private System.Windows.Forms.RadioButton rad_AgiSeedRand;
        private System.Windows.Forms.RadioButton rad_AgiSeedOn;
        private System.Windows.Forms.RadioButton rad_AgiSeedOff;
        private System.Windows.Forms.GroupBox grp_StrSeed;
        private System.Windows.Forms.RadioButton rad_StrSeedRand;
        private System.Windows.Forms.RadioButton rad_StrSeedOn;
        private System.Windows.Forms.RadioButton rad_StrSeedOff;
        private System.Windows.Forms.GroupBox grp_PoisonMoth;
        private System.Windows.Forms.RadioButton rad_PoisonMothRand;
        private System.Windows.Forms.RadioButton rad_PoisonMothOn;
        private System.Windows.Forms.RadioButton rad_PoisonMothOff;
        private System.Windows.Forms.GroupBox grp_LucSeed;
        private System.Windows.Forms.RadioButton rad_LucSeedRand;
        private System.Windows.Forms.RadioButton rad_LucSeedOn;
        private System.Windows.Forms.RadioButton rad_LucSeedOff;
        private System.Windows.Forms.GroupBox grp_VitSeed;
        private System.Windows.Forms.RadioButton rad_VitSeedRand;
        private System.Windows.Forms.RadioButton rad_VitSeedOn;
        private System.Windows.Forms.RadioButton rad_VitSeedOff;
        private System.Windows.Forms.GroupBox grp_WorldTree;
        private System.Windows.Forms.RadioButton rad_WorldTreeRand;
        private System.Windows.Forms.RadioButton rad_WorldTreeOn;
        private System.Windows.Forms.RadioButton rad_WorldTreeOff;
        private System.Windows.Forms.GroupBox grp_RingOfLife;
        private System.Windows.Forms.RadioButton rad_RingOfLifeRand;
        private System.Windows.Forms.RadioButton rad_RingOfLifeOn;
        private System.Windows.Forms.RadioButton rad_RingOfLifeOff;
        private System.Windows.Forms.GroupBox grp_SilverHarp;
        private System.Windows.Forms.RadioButton rad_SilverHarpRand;
        private System.Windows.Forms.RadioButton rad_SilverHarpOn;
        private System.Windows.Forms.RadioButton rad_SilverHarpOff;
        private System.Windows.Forms.GroupBox grp_EchoingFlute;
        private System.Windows.Forms.RadioButton rad_EchoingFluteRand;
        private System.Windows.Forms.RadioButton rad_EchoingFluteOn;
        private System.Windows.Forms.RadioButton rad_EchoingFluteOff;
        private System.Windows.Forms.GroupBox grp_WizardRing;
        private System.Windows.Forms.RadioButton rad_WizardRingRand;
        private System.Windows.Forms.RadioButton rad_WizardRingOn;
        private System.Windows.Forms.RadioButton rad_WizardRingOff;
        private System.Windows.Forms.GroupBox grp_MetoriteArmband;
        private System.Windows.Forms.RadioButton rad_MetoriteArmbandRand;
        private System.Windows.Forms.RadioButton rad_MetoriteArmbandOn;
        private System.Windows.Forms.RadioButton rad_MetoriteArmbandOff;
        private System.Windows.Forms.GroupBox grp_Satori;
        private System.Windows.Forms.RadioButton rad_SatoriRand;
        private System.Windows.Forms.RadioButton rad_SatoriOn;
        private System.Windows.Forms.RadioButton rad_SatoriOff;
        private System.Windows.Forms.GroupBox grp_StoneOfLife;
        private System.Windows.Forms.RadioButton rad_StoneOfLifeRand;
        private System.Windows.Forms.RadioButton rad_StoneOfLifeOn;
        private System.Windows.Forms.RadioButton rad_StoneOfLifeOff;
        private System.Windows.Forms.GroupBox grp_LampOfDarkness;
        private System.Windows.Forms.RadioButton rad_LampOfDarknessRand;
        private System.Windows.Forms.RadioButton rad_LampOfDarknessOn;
        private System.Windows.Forms.RadioButton rad_LampOfDarknessOff;
        private System.Windows.Forms.GroupBox grp_ShoesOfHappiness;
        private System.Windows.Forms.RadioButton rad_ShoesOfHappinessRand;
        private System.Windows.Forms.RadioButton rad_ShoesOfHappinessOn;
        private System.Windows.Forms.RadioButton rad_ShoesOfHappinessOff;
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
    }
}

