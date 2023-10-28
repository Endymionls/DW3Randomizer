using System;



using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Drawing;
using System.Reflection;
using System.Deployment.Internal;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.LinkLabel;
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using DW3Randomizer.classes;

namespace DW3Randomizer
{
    public partial class Form1 : Form
    {

        readonly string versionNumber = "2.5.4.1";
        readonly string revisionDate = "10/28/2023";
        readonly int buildnumber = 276; // build starting 8/18/23
        readonly string SotWFlags = "A-QLINNDAKMBG-NB-NNABA-EMDB-NNNMNNNB-A-E-N";
        readonly string TradSotWFlags = "A-QLINNDAKMAG-JB-NAABA-BMAB-NNNMNNNB-A-B-D";
        readonly string jffFlags = "A-QLINNNBNNEG-NN-NNNNB-NNNE-NNNMNNNB-E-E-N";
        readonly string randomFlags = "A-JJD!!!!!!IH-!!-!!!!C-!!!H-!!!!!!!C-E-I-!";
        readonly string quickVanila = "A-NOGNAAAAAAD-AA-AAAAA-AAAA-AAAAAAAA-A-E-A";
        readonly bool debugmode = false;
        Random r1;
        Random randomFlagIncrement;
        Random randomCosmeticIncrement;

        bool loading = true;
        byte[] romData;
        byte[] romData2;
        readonly byte[] monsterOrder = { 0x00, 0x01, 0x68, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e,
                                0x0f, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e,
                                0x1f, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x8a, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d,
                                0x2e, 0x2f, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d,
                                0x3e, 0x3f, 0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d,
                                0x4e, 0x4f, 0x50, 0x51, 0x52, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a, 0x5b, 0x5c, 0x5d, 0x5e,
                                0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x66, 0x67, 0x53, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e, 0x6f,
                                0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e, 0x7f,
                                0x80, 0x88, 0x89, 0x65, 0x84, 0x81, 0x82, 0x83 }; // 129 normal monsters, 7 bosses.  Skip Zoma, "frozen" Zoma, Ortega
        int[,] map = new int[256, 256];
        int[,] map2 = new int[139, 158];
        int[,] maplocs = new int[256, 256];
        int[,] island = new int[256, 256];
        int[,] island2 = new int[139, 158];
        int[,] zone = new int[16, 16];
        int[] maxIsland = new int[4];
        List<int> islands = new List<int>();
        int[] heroComSpell, pilgrimComSpell, wizardComSpell, heroComLvl, pilgrimComLvl, wizardComLvl, heroBatSpell, pilgrimBatSpell, wizardBatSpell, heroBatLvl, pilgrimBatLvl, wizardBatLvl;
        bool noLamia = false;
        bool dispEqPower = false;
        bool randMap = false;
        bool smallMap = false;
        bool disAlefgardGlitch = false;
        bool addRemakeEquip = false;
        bool adjustEquipmentPrice = false;
        bool randColor = false;
        bool fHero = false;
        bool randClass = false;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Dragon Warrior III Randomizer ~ " + versionNumber + " ~ " + revisionDate + " (" + buildnumber + ")";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath);
            //            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
                runChecksum();
            }
        }

        private void runChecksum()
        {
            try
            {
                using (var md5 = SHA1.Create())
                {
                    using (var stream = File.OpenRead(txtFileName.Text))
                    {
                        lblSHAChecksum.Text = BitConverter.ToString(md5.ComputeHash(stream)).ToLower().Replace("-", "");
                    }
                }
            }
            catch
            {
                lblSHAChecksum.Text = "????????????????????????????????????????";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();
            string shortVersion = versionNumber.Replace(".", "");

            try
            {
                using (TextReader reader = File.OpenText("lastFile" + shortVersion + ".txt"))
                {
                    txtFileName.Text = reader.ReadLine();
                    txtFlags.Text = reader.ReadLine();
                    determineChecks(null, null);
                    if (reader.ReadLine() == "True") rad_ChName1Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChName1Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChName1Rand.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChName2Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChName2Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChName2Rand.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChName3Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChName3Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChName3Rand.Checked = true;
                    txt_ChName1.Text = reader.ReadLine();
                    txt_ChName2.Text = reader.ReadLine();
                    txt_ChName3.Text = reader.ReadLine();
                    if (reader.ReadLine() == "True") rad_Gender1Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_Gender1Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_Gender1Rand.Checked = true;
                    if (reader.ReadLine() == "True") rad_Gender2Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_Gender2Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_Gender2Rand.Checked = true;
                    if (reader.ReadLine() == "True") rad_Gender3Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_Gender3Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_Gender3Rand.Checked = true;
                    cbo_Gender1.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cbo_Gender2.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cbo_Gender3.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    if (reader.ReadLine() == "True")
                        chk_RandSoldier.Checked = true;
                    else
                        chk_RandSoldier.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_RandPilgrim.Checked = true;
                    else
                        chk_RandPilgrim.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_RandWizard.Checked = true;
                    else
                        chk_RandWizard.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_RandFighter.Checked = true;
                    else
                        chk_RandFighter.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_RandMerchant.Checked = true;
                    else
                        chk_RandMerchant.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_RandGoofOff.Checked = true;
                    else
                        chk_RandGoofOff.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_RandSage.Checked = true;
                    else
                        chk_RandSage.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_RandHero.Checked = true;
                    else
                        chk_RandHero.Checked = false;
                    if (reader.ReadLine() == "True") rad_Class1Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_Class1Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_Class1Rand.Checked = true;
                    if (reader.ReadLine() == "True") rad_Class2Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_Class2Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_Class2Rand.Checked = true;
                    if (reader.ReadLine() == "True") rad_Class3Off.Checked = true;
                    if (reader.ReadLine() == "True") rad_Class3Manual.Checked = true;
                    if (reader.ReadLine() == "True") rad_Class3Rand.Checked = true;
                    cbo_Class1.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cbo_Class2.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cbo_Class3.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    if (reader.ReadLine() == "True") rad_StdCaseOff.Checked = true;
                    if (reader.ReadLine() == "True") rad_StdCaseOn.Checked = true;
                    if (reader.ReadLine() == "True") rad_StdCaseRand.Checked = true;
                    if (reader.ReadLine() == "True") rad_SlimeSnailOff.Checked = true;
                    if (reader.ReadLine() == "True") rad_SlimeSnailOn.Checked = true;
                    if (reader.ReadLine() == "True") rad_SlimeSnailRand.Checked = true;
                    if (reader.ReadLine() == "True") rad_RandSpriteColOff.Checked = true;
                    if (reader.ReadLine() == "True") rad_RandSpriteColOn.Checked = true;
                    if (reader.ReadLine() == "True") rad_RandSpriteColRand.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChCatsOff.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChCatsOn.Checked = true;
                    if (reader.ReadLine() == "True") rad_ChCatsRand.Checked = true;
                    if (reader.ReadLine() == "True") rad_FFightSpriteOff.Checked = true;
                    if (reader.ReadLine() == "True") rad_FFightSpriteOn.Checked = true;
                    if (reader.ReadLine() == "True") rad_FFightSpriteRand.Checked = true;
                    if (reader.ReadLine() == "True") rad_RandNPCOff.Checked = true;
                    if (reader.ReadLine() == "True") rad_RandNPCOn.Checked = true;
                    if (reader.ReadLine() == "True") rad_RandNPCRand.Checked = true;
                    if (reader.ReadLine() == "True") rad_FHeroOff.Checked = true;
                    if (reader.ReadLine() == "True") rad_FHeroOn.Checked = true;
                    if (reader.ReadLine() == "True") rad_FHeroRand.Checked = true;
                    runChecksum();
                }
            }
            catch
            {
                // ignore error
                txt_ChName1.Text = "Glennard";
                txt_ChName2.Text = "Elucidus";
                txt_ChName3.Text = "Hiram";
                cbo_Class1.SelectedIndex = 0;
                cbo_Class2.SelectedIndex = 1;
                cbo_Class3.SelectedIndex = 2;
                cbo_Gender1.SelectedIndex = 0;
                cbo_Gender2.SelectedIndex = 0;
                cbo_Gender3.SelectedIndex = 0;
            }
            btnNewSeed_Click(null, null);
            loading = false;
            determineFlags(null, null);
        }

        private void btnNewSeed_Click(object sender, EventArgs e)
        {
            txtSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            bugFixes bugFixes = new bugFixes();
            flagscalc flagscalc = new flagscalc();
            initialize initialize = new initialize(); 
            itemsAndequipment itemsAndequipment = new itemsAndequipment();
            maps maps = new maps();
            monsters monsters = new monsters();
            optimizations optimizations = new optimizations();
            partyAndJobChange partyAndJobChange = new partyAndJobChange();
            partyStatChange partyStatChange = new partyStatChange();
            randomizeFunctions randomizeFunctions = new randomizeFunctions();
            randomizerTools randomizerTools = new randomizerTools();
            romtools romtools = new romtools();
            spritechange spritechange = new spritechange();
            textchange textchange = new textchange();

            initialize.setrandomization(ref r1, ref randomFlagIncrement, ref randomCosmeticIncrement, txtSeed.Text, buildnumber, chk_GenCompareFile.Checked);
            initialize.maplocsfunct(ref maplocs);

            if (lblSHAChecksum.Text != lblReqChecksum.Text)
            {
                if (MessageBox.Show("The checksum of the ROM does not match the required checksum.  Patch anyway?", "Checksum mismatch", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            if (!randomizerTools.loadRom(ref romData, ref romData2, txtFileName.Text, txtCompare.Text))
                return;
            if (txtSeed.Text == "output")
            {
                string IntensityDesc = lblIntensityDesc.Text;
                randomizerTools.textOutput(ref romData, ref romData2, ref IntensityDesc, txtFileName.Text, txtCompare.Text);
                lblIntensityDesc.Text = IntensityDesc;
                return;
            }
            else if (txtSeed.Text == "textGet")
            {
                randomizerTools.textGet(ref romData, txtFileName.Text);
                return;
            }
            else
            {
                try
                {
                    Random testSeed = new Random(int.Parse(txtSeed.Text));
                }
                catch
                {
                    MessageBox.Show("Invalid seed.  It must be a number from 0 to 2147483648.");
                    return;
                }
                int evalRandTemp = 0; // this will evaluate if Rand is selected on specific options
                int evalRandTemp2 = 0;
                int evalCosmeticTemp = 0;

                evalRandTemp = r1.Next() % 2;
                if (rad_RmManipOn.Checked || (rad_RmManipRand.Checked && evalRandTemp == 1))
                    randomizeFunctions.dw4RNG(ref romData);
                boostXP(); // Both boosts Exp and Evaluates Random Exp
                boostGP(); // Both boosts Gold and Evaluates Random Gold
                adjustEncounters();
                evalRandTemp = r1.Next() % 2;
                if (rad_AdjEqPriceOn.Checked ||(rad_AdjEqPriceRand.Checked && evalRandTemp == 1)) adjustEquipmentPrice = true;
                evalRandTemp = r1.Next() % 2;
                if ((rad_RandSageStoneRand.Checked && evalRandTemp == 1) || rad_RandSageStoneOn.Checked) 
                    randomizeFunctions.randsagestone(ref romData, ref r1, rad_HUAStoneOn.Checked, rad_HUAStoneRand.Checked );
                evalRandTemp = r1.Next() % 2;
                if (rad_SoHRoLEffOn.Checked ||(rad_SoHRoLEffRand.Checked && evalRandTemp == 1)) 
                    randomizeFunctions.randshoes(ref romData, ref r1, rad_BigOn.Checked, rad_BigRand.Checked);
                evalRandTemp = r1.Next() % 2;
                if (rad_codOn.Checked || (rad_codRand.Checked && evalRandTemp == 1)) 
                    optimizations.cod(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_FixHeroSpellOn.Checked || (rad_FixHeroSpellRand.Checked && evalRandTemp == 1)) 
                    bugFixes.fixHeroSpell(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_SpeedTextOn.Checked || (rad_SpeedTextRand.Checked && evalRandTemp == 1)) 
                    optimizations.speedText(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_IncBattSpeedOn.Checked || (rad_IncBattSpeedRand.Checked && evalRandTemp == 1))
                    optimizations.battleSpeed(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_FourJobFiestaOn.Checked || (rad_FourJobFiestaRand.Checked && evalRandTemp == 1)) 
                    partyAndJobChange.fourJobFiesta(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_LamiaOn.Checked || (rad_LamiaRand.Checked && evalRandTemp == 1))
                    optimizations.noOrbs(ref romData, out noLamia);
                evalRandTemp = r1.Next() % 2;
                if (rad_SpeedUpMenuOn.Checked || (rad_SpeedUpMenuRand.Checked && evalRandTemp == 1)) 
                    optimizations.speedUpMenus(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_RmParryBugOn.Checked || (rad_RmParryBugRand.Checked && evalRandTemp == 1)) 
                    bugFixes.removeParryFight(ref romData);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (rad_StdCaseOn.Checked || (rad_StdCaseRand.Checked && evalCosmeticTemp == 1))
                    textchange.lowerCaseMenus(ref romData);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (rad_SlimeSnailOn.Checked || (rad_SlimeSnailRand.Checked && evalRandTemp == 1))
                    textchange.slimeSnail(ref romData);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (rad_Gender1Rand.Checked || rad_Gender2Rand.Checked || rad_Gender3Rand.Checked)
                {
                    int Gender1 = cbo_Gender1.SelectedIndex;
                    int Gender2 = cbo_Gender2.SelectedIndex;
                    int Gender3 = cbo_Gender3.SelectedIndex;
                    partyAndJobChange.randomizeGender(txtSeed.Text, ref Gender1, ref Gender2, ref Gender3, rad_Gender1Rand.Checked, rad_Gender2Rand.Checked, rad_Gender3Rand.Checked);
                    if (rad_Gender1Rand.Checked) cbo_Gender1.SelectedIndex = Gender1;
                    if (rad_Gender2Rand.Checked) cbo_Gender2.SelectedIndex = Gender2;
                    if (rad_Gender3Rand.Checked) cbo_Gender3.SelectedIndex = Gender3;
                }
                if (rad_Class1Rand.Checked || rad_Class2Rand.Checked || rad_Class3Rand.Checked)
                {
                    int c1 = 0;
                    int c2 = 1;
                    int c3 = 2;
                    partyAndJobChange.randomizeClass(txtSeed.Text, ref c1, ref c2, ref c3, rad_Class1Rand.Checked, rad_Class2Rand.Checked, rad_Class3Rand.Checked, ref randClass,
                        chk_RandSoldier.Checked, chk_RandPilgrim.Checked, chk_RandWizard.Checked, chk_RandFighter.Checked, chk_RandMerchant.Checked, chk_RandGoofOff.Checked,
                        chk_RandSage.Checked, chk_RandHero.Checked);
                    if (rad_Class1Rand.Checked) cbo_Class1.SelectedIndex = c1;
                    if (rad_Class2Rand.Checked) cbo_Class2.SelectedIndex = c2;
                    if (rad_Class3Rand.Checked) cbo_Class3.SelectedIndex = c3;
                }
                if (rad_ChName1Rand.Checked || rad_ChName2Rand.Checked || rad_ChName3Rand.Checked)
                {
                    string ChName1 = "";
                    string ChName2 = "";
                    string ChName3 = "";
                    partyAndJobChange.randomizeNames(txtSeed.Text, ref ChName1, ref ChName2, ref ChName3, rad_ChName1Rand.Checked, rad_ChName2Rand.Checked, rad_ChName3Rand.Checked,
                        cbo_Gender1.SelectedIndex, cbo_Gender2.SelectedIndex, cbo_Gender3.SelectedIndex);
                    if (rad_ChName1Rand.Checked) txt_ChName1.Text = ChName1;
                    if (rad_ChName2Rand.Checked) txt_ChName2.Text = ChName2;
                    if (rad_ChName3Rand.Checked) txt_ChName3.Text = ChName3;
                }
                if ((rad_Gender1Rand.Checked) || (rad_Gender2Rand.Checked) || (rad_Gender3Rand.Checked) || (rad_Gender1Manual.Checked) || (rad_Gender2Manual.Checked) || (rad_Gender3Manual.Checked) ||
                        (rad_Class1Rand.Checked) || (rad_Class2Rand.Checked) || (rad_Class3Rand.Checked) || (rad_Class1Manual.Checked) || (rad_Class2Manual.Checked) || (rad_Class3Manual.Checked) ||
                        (rad_ChName1Rand.Checked) || (rad_ChName2Rand.Checked) || (rad_ChName3Rand.Checked) || (rad_ChName1Manual.Checked) || (rad_ChName2Manual.Checked) || (rad_ChName3Manual.Checked)) 
                    partyAndJobChange.chngDftParty(ref romData, cbo_Class1.SelectedIndex, cbo_Class2.SelectedIndex, cbo_Class3.SelectedIndex, cbo_Gender1.SelectedIndex, cbo_Gender2.SelectedIndex, cbo_Gender3.SelectedIndex,
                        txt_ChName1.Text, txt_ChName2.Text, txt_ChName3.Text, versionNumber);
                evalRandTemp = r1.Next() % 2;
                if (rad_SmallMapOn.Checked || (rad_SmallMapRand.Checked && evalRandTemp == 1)) smallMap = true;
                evalRandTemp = r1.Next() % 2;
                if (rad_RandMapsOn.Checked || (rad_RandMapsRand.Checked && evalRandTemp == 1)) 
                    maps.randomizeMapv5(ref romData, ref r1, ref randMap, ref map, ref map2, ref island, ref island2, ref zone, ref maxIsland, ref islands, ref maplocs, ref disAlefgardGlitch, debugmode, versionNumber, txtFileName.Text, txtSeed.Text, 
                        txtFlags.Text, smallMap, chk_GenIslandsMonstersZones.Checked, rad_RandTownsOn.Checked, rad_RandTownsRand.Checked, rad_RandCavesOn.Checked, rad_RandCavesRand.Checked, rad_RandShrinesOn.Checked, rad_RandShrinesRand.Checked, 
                        rad_BaramosCastOn.Checked, rad_BaramosCastRand.Checked, rad_DisAlefGlitchOn.Checked, rad_DisAlefGlitchRand.Checked, rad_CharlockOn.Checked, rad_CharlockRand.Checked, rad_LancelCaveOn.Checked, rad_LancelCaveRand.Checked,
                        rad_DrgQnCastOn.Checked, rad_DrgQnCastRand.Checked, rad_CaveOfNecroOn.Checked, rad_CaveOfNecroRand.Checked, rad_NoNewTownOn.Checked, rad_NoNewTownRand.Checked);
                evalRandTemp = r1.Next() % 2;
                if (rad_RandEnePatOn.Checked || (rad_RandEnePatRand.Checked && evalRandTemp == 1)) 
                    monsters.randEnemyPatterns(ref romData, ref r1, rad_RmMetalRunOn.Checked, rad_RmMetalRunRand.Checked);
                evalRandTemp = r1.Next() % 2;
                if ((rad_RandMonstZoneRand.Checked && evalRandTemp == 1) || (rad_RandMonstZoneOn.Checked)) 
                    monsters.randMonsterZones(ref romData, ref r1, monsterOrder);
                evalRandTemp = r1.Next() % 2;
                if ((rad_SellUnsellableRand.Checked && evalRandTemp == 1) || (rad_SellUnsellableOn.Checked)) 
                    itemsAndequipment.forceItemSell(ref romData, ref r1);
                evalRandTemp = r1.Next() % 2;
                if (rad_DispEqPowerOn.Checked || (rad_DispEqPowerRand.Checked && evalRandTemp == 1))
                    dispEqPower = true;
                    evalRandTemp = r1.Next() % 2;
                if (rad_RandEqPwrOn.Checked || (rad_RandEqPwrRand.Checked && evalRandTemp == 1))
                    itemsAndequipment.randEquip(ref romData, ref r1, rad_AdjStartEqOn.Checked, rad_AdjStartEqRand.Checked, rad_VanEqValOn.Checked, rad_VanEqValRand.Checked, addRemakeEquip, adjustEquipmentPrice);
                evalRandTemp = r1.Next() % 2;
                if ((rad_AddRemakeOn.Checked || (rad_AddRemakeRand.Checked && evalRandTemp == 1)))
                    itemsAndequipment.changeRemakeEq(ref romData, out addRemakeEquip, dispEqPower, adjustEquipmentPrice, randClass); // need to call early because display weapon and armor power is called on tab 1
                evalRandTemp = r1.Next() % 2;
                if (rad_RmFightPenOn.Checked || (rad_RmFightPenRand.Checked && evalRandTemp == 1)) 
                    partyStatChange.removeFightPenalty(ref romData);
                if (dispEqPower)
                    textchange.weapArmPower(ref romData, dispEqPower, addRemakeEquip);
                evalRandTemp = r1.Next() % 2;
                if (rad_RandClassEqOn.Checked || (rad_RandClassEqRand.Checked && evalRandTemp == 1))
                    itemsAndequipment.whoCanEquip(ref romData, ref r1);
                if (rad_RandSpellLearningOn.Checked || (rad_RandSpellLearningRand.Checked && evalRandTemp == 1))
                    partyAndJobChange.randSpellLearning(ref romData, ref r1, ref heroComSpell, ref heroComLvl, ref heroBatSpell, ref heroBatLvl, ref pilgrimComSpell, ref pilgrimComLvl,
                        ref pilgrimBatSpell, ref pilgrimBatLvl, ref wizardComSpell, ref wizardComLvl, ref wizardBatSpell, ref wizardBatLvl);
                evalRandTemp = r1.Next() % 2;
                if (rad_RandSpellStrOn.Checked || (rad_RandSpellStrRand.Checked && evalRandTemp == 1)) 
                    randomizeFunctions.randSpellStrength(ref romData, ref r1);
                evalRandTemp = r1.Next() % 2;
                if (rad_RandTreasOn.Checked || (rad_RandTreasRand.Checked && evalRandTemp == 1)) 
                    randomizeFunctions.randTreasures(ref romData, ref r1, disAlefgardGlitch, rad_RmRedKeysOn.Checked, rad_RmRedKeysRand.Checked, rad_AddGoldClawOn.Checked, rad_AddGoldClawRand.Checked,
                        rad_OrbDftOn.Checked, rad_OrbDftRand.Checked, noLamia, randMap);
                bool randstores = false;
                evalRandTemp = r1.Next() % 2;
                evalRandTemp2 = r1.Next() % 2;
                if ((rad_RandItemShopRand.Checked && evalRandTemp == 1) || (rad_RandItemShopOn.Checked) || (rad_RandWeapShopRand.Checked && evalRandTemp2 == 1) || (rad_RandWeapShopOn.Checked)) randstores = true;
                if (randstores) 
                    randomizeFunctions.randStores(ref romData, ref r1, rad_AcornsOn.Checked, rad_AcornsRand.Checked, rad_StrSeedOn.Checked, rad_StrSeedRand.Checked, rad_AgiSeedOn.Checked, rad_AgiSeedRand.Checked, rad_VitSeedOn.Checked,
                        rad_VitSeedRand.Checked, rad_IntSeedOn.Checked, rad_IntSeedRand.Checked, rad_LucSeedOn.Checked, rad_LucSeedRand.Checked, rad_WorldTreeOn.Checked, rad_WorldTreeRand.Checked, rad_PoisonMothOn.Checked, 
                        rad_PoisonMothRand.Checked, rad_StoneOfLifeOn.Checked, rad_StoneOfLifeRand.Checked, rad_SatoriOn.Checked, rad_SatoriRand.Checked, rad_MetoriteArmbandOn.Checked, rad_MetoriteArmbandRand.Checked,
                        rad_WizardRingOn.Checked, rad_WizardRingRand.Checked, rad_EchoingFluteOn.Checked, rad_EchoingFluteRand.Checked, rad_SilverHarpOn.Checked, rad_SilverHarpRand.Checked, rad_RingOfLifeOn.Checked, rad_RingOfLifeRand.Checked,
                        rad_ShoesOfHappinessOn.Checked, rad_ShoesOfHappinessRand.Checked, rad_LampOfDarknessOn.Checked, rad_LampOfDarknessRand.Checked, rad_RandWeapShopOn.Checked, rad_RandWeapShopRand.Checked, rad_CaturdayOn.Checked,
                        rad_CaturdayRand.Checked, rad_RandItemShopOn.Checked, rad_RandItemShopRand.Checked, txtSeed.Text);
                evalRandTemp = r1.Next() % 2;
                if (rad_RandInnOn.Checked || (rad_RandInnRand.Checked && evalRandTemp == 1)) 
                    randomizeFunctions.randomizeInnPrices(ref romData, ref r1);
                evalRandTemp = r1.Next() % 2;
                if (rad_RandStatsSilly.Checked || rad_RandStatsRid.Checked || rad_RandStatsLud.Checked || (rad_RandStatsRand.Checked && evalRandTemp == 1)) 
                    partyStatChange.randStatGains(ref romData, ref r1, rad_RandStatsSilly.Checked, rad_RandStatsRid.Checked, rad_RandStatsLud.Checked, rad_RandStatsRand.Checked);
                evalRandTemp = r1.Next() % 2;
                if (rad_FHeroOn.Checked || (rad_FHeroRand.Checked && evalRandTemp == 1)) fHero = true;
                evalRandTemp = r1.Next() % 2;
                if (rad_RandHeroAgeOn.Checked || (rad_RandHeroAgeRand.Checked && evalRandTemp == 1)) 
                    spritechange.changeHeroAge(ref romData, ref r1, fHero);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (rad_RandSpriteColOn.Checked || (rad_RandSpriteColRand.Checked && evalRandTemp == 1))
                    spritechange.randSpriteColors(ref romData, ref randColor, txtSeed.Text);
                evalRandTemp = r1.Next() % 2;
                if (rad_StartGoldOn.Checked || (rad_StartGoldRand.Checked && evalRandTemp == 1))
                    randomizeFunctions.randStartGold(ref romData, ref r1);
                evalRandTemp = r1.Next() % 2;
                if (rad_GhostToCasketOn.Checked || (rad_GhostToCasketRand.Checked && evalRandTemp == 1))
                    spritechange.changeGhostToCasket(ref romData, txtSeed.Text, randColor);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (rad_ChCatsOn.Checked || (rad_ChCatsRand.Checked && evalCosmeticTemp == 1))
                    spritechange.changeCats(ref romData, txtSeed.Text);
                evalRandTemp = r1.Next() % 2;
                if (rad_InvisNPCOn.Checked || (rad_InvisNPCRand.Checked && evalRandTemp == 1)) 
                   spritechange.invisibleNPCs(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_InvisShipBirdOn.Checked || (rad_InvisShipBirdRand.Checked && evalRandTemp == 1)) 
                    spritechange.invisbleShips(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_DoubleAttOn.Checked ||(rad_DoubleAttRand.Checked && evalRandTemp == 1))
                    partyStatChange.doubleattack(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_PartyItemsOn.Checked || (rad_PartyItemsRand.Checked && evalRandTemp == 1))
                    itemsAndequipment.heroitems(ref romData, ref r1);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (rad_FFightSpriteOn.Checked || (rad_FFightSpriteRand.Checked && evalCosmeticTemp == 1))
                    romData = spritechange.fixFFigherSprite(ref romData);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (rad_RandNPCOn.Checked || (rad_RandNPCRand.Checked && evalCosmeticTemp == 1))
                    spritechange.randomNPCSprites(ref romData, txtSeed.Text);
                evalRandTemp = r1.Next() % 2;
                if (rad_NonMagMPOn.Checked || (rad_NonMagMPRand.Checked && evalRandTemp == 1))
                    partyStatChange.nonMagicMP(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (rad_LevelUpTxtOn.Checked || (rad_LevelUpTxtRand.Checked && (randomCosmeticIncrement.Next () % 2 == 1 )))
                    textchange.levelUpText(ref romData);

                // if (chkRandItemEffects.Checked) randItemEffects(rni);

                textchange.changeEnd(ref romData);
                string Descript = lblIntensityDesc.Text;
                string Compare = txtCompare.Text;
                string newChecksum = lblNewChecksum.Text;
                romtools.saveRom(true, ref romData, versionNumber, txtFileName.Text, txtSeed.Text, txtFlags.Text, ref Descript, ref Compare, ref newChecksum);
                lblIntensityDesc.Text = Descript;
                txtCompare.Text = Compare;
                lblNewChecksum.Text = newChecksum;
                // romtools.saveRom(false, ref romData, versionNumber);
                string IntensityDesc = "";
                randomizerTools.createGuides(ref romData, ref romData2, ref IntensityDesc, versionNumber, txtFileName.Text, txtSeed.Text, txtFlags.Text, txtCompare.Text, addRemakeEquip, chk_GenCompareFile.Checked);
                lblIntensityDesc.Text = IntensityDesc;
                Form sendform = new Form1();
                runHash();
            }
        }

        private void runHash()
        {
            int adjustmentTab = (rad_ExpGain0.Checked ? 1 : (rad_ExpGain25.Checked ? 2 : (rad_ExpGain50.Checked ? 4 : (rad_ExpGain100.Checked ? 8 : (rad_ExpGain150.Checked ? 16 :
                (rad_ExpGain200.Checked ? 32 : (rad_ExpGain300.Checked ? 64 : (rad_ExpGain400.Checked ? 128 : (rad_ExpGain500.Checked ? 256 : (rad_ExpGain750.Checked ? 512 :
                (rad_ExpGain1000.Checked ? 1024 : (rad_ExpGainRand.Checked ? 2048 : 0))))))))))) + (rad_GoldGain1.Checked ? 4096 : (rad_GoldGain50.Checked ? 8192 : (rad_GoldGain100.Checked ? 16384 :
                (rad_GoldGain150.Checked ? 32768 : (rad_GoldGain200.Checked ? 65536 : (rad_GoldGainRand.Checked ? 131072 : 0)))))));

            int adjustmentTab2 = 3 * ((rad_EncRate0.Checked ? 1 : (rad_EncRate25.Checked ? 2 : (rad_EncRate50.Checked ? 4 : (rad_EncRate75.Checked ? 8 : (rad_EncRate100.Checked ? 16 :
                (rad_EncRate150.Checked ? 32 : (rad_EncRate200.Checked ? 64 : (rad_EncRate300.Checked ? 128 : (rad_EncRate400.Checked ? 256 : (rad_EncRateRand.Checked ? 512 : 0)))))))))) +
                (rad_IncBattSpeedOn.Checked ? 1024 : (rad_IncBattSpeedRand.Checked ? 2048 : 0)) + (rad_SpeedTextOn.Checked ? 4096 : (rad_SpeedTextRand.Checked ? 8192 : 0)) +
                (rad_SpeedUpMenuOn.Checked ? 16384 : (rad_SpeedUpMenuRand.Checked ? 32768 : 0)) + (rad_RmManipOn.Checked ? 65536 : 0) + (rad_RmManipRand.Checked ? 131072 : 0) +
                (rad_codOn.Checked ? 262144 : (rad_codRand.Checked ? 524288 : 0)));

            int adjustmentTab3 = 5 * ((rad_PartyItemsOn.Checked ? 1 : (rad_PartyItemsRand.Checked ? 2 : 0)) + (rad_InvisShipBirdOn.Checked ? 4 : (rad_InvisShipBirdRand.Checked ? 8 : 0)) +
                (rad_InvisNPCOn.Checked ? 16 : (rad_InvisNPCRand.Checked ? 32 : 0)) + (rad_RandSageStoneOn.Checked ? 64 : (rad_RandSageStoneRand.Checked ? 128 : 0)) +
                (rad_HUAStoneOn.Checked ? 256 : (rad_HUAStoneRand.Checked ? 512 : 0)) + (rad_SoHRoLEffOn.Checked ? 512 : (rad_SoHRoLEffRand.Checked ? 1024 : 0)) +
                (rad_BigOn.Checked ? 2048 : (rad_BigRand.Checked ? 4096 : 0)) + (rad_LamiaOn.Checked ? 8192 : (rad_LamiaRand.Checked ? 16384 : 0)) +
                (rad_DispEqPowerOn.Checked ? 32768 : (rad_DispEqPowerRand.Checked ? 65536 : 0)) + (rad_DoubleAttOn.Checked ? 131072 : (rad_DoubleAttRand.Checked ? 262144 : 0)));

            int adjustmentTab4 = 7 * ((rad_RandSpellLearningOn.Checked ? 1 : (rad_RandSpellLearningRand.Checked ? 2 : 0)) + (rad_RandSpellStrOn.Checked ? 4 : (rad_RandSpellStrRand.Checked ? 8 : 0)) +
                (rad_NonMagMPOn.Checked ? 16 : (rad_NonMagMPRand.Checked ? 32 : 0)) + (rad_FourJobFiestaOn.Checked ? 64 : (rad_FourJobFiestaRand.Checked ? 128 : 0)) +
                (rad_RandStatsSilly.Checked ? 256 : (rad_RandStatsRid.Checked ? 512 : (rad_RandStatsLud.Checked ? 1024 : (rad_RandStatsRand.Checked ? 2048 : 0)))));

            int mapTab1 = 11 * ((rad_RandMapsOn.Checked ? 1 : (rad_RandMapsRand.Checked ? 2 : 0)) + (rad_SmallMapOn.Checked ? 4 : (rad_SmallMapRand.Checked ? 8 : 0)) +
                (rad_RandMonstZoneOn.Checked ? 16 : (rad_RandMonstZoneRand.Checked ? 32 : 0)) + (rad_RandTownsOn.Checked ? 64 : (rad_RandTownsRand.Checked ? 128 : 0)) +
                (rad_RandCavesOn.Checked ? 256 : (rad_RandCavesRand.Checked ? 512 : 0)) + (rad_RandShrinesOn.Checked ? 1024 : (rad_RandShrinesRand.Checked ? 2048 : 0)) +
                (rad_LancelCaveOn.Checked ? 4096 : (rad_LancelCaveRand.Checked ? 8192 : 0)) + (rad_CaveOfNecroOn.Checked ? 16834 : (rad_CaveOfNecroRand.Checked ? 32768 : 0)));

            int mapTab2 = 13 * ((rad_BaramosCastOn.Checked ? 1 : (rad_BaramosCastRand.Checked ? 2 : 0)) + (rad_DrgQnCastOn.Checked ? 4 : (rad_DrgQnCastRand.Checked ? 8 : 0)) +
                (rad_DisAlefGlitchOn.Checked ? 16 : (rad_DisAlefGlitchRand.Checked ? 32 : 0)) + (rad_CharlockOn.Checked ? 64 : (rad_CharlockRand.Checked ? 128 : 0)) +
                (rad_NoNewTownOn.Checked ? 256 : (rad_NoNewTownRand.Checked ? 512 : 0)));

            int monstersTab = 17 * ((rad_RandExpOn.Checked ? 1 : (rad_RandExpRand.Checked ? 2 : 0)) + (rad_RandGoldOn.Checked ? 4 : (rad_RandGoldRand.Checked ? 8 : 0)) +
                (rad_RandDropOn.Checked ? 16 : (rad_RandDropRand.Checked ? 32 : 0)) + (rad_RandEnePatOn.Checked ? 64 : (rad_RandEnePatRand.Checked ? 128 : 0)) +
                (rad_RmDupDropOn.Checked ? 256 : (rad_RmDupDropRand.Checked ? 512 : 0)) + (rad_RmMetalRunOn.Checked ? 1024 : (rad_RmMetalRunRand.Checked ? 2048 : 0)));

            int treasureEquipmentTab1 = 19 * ((rad_RandTreasOn.Checked ? 1 : (rad_RandTreasRand.Checked ? 2 : 0)) + (rad_OrbDftOn.Checked ? 4 : (rad_OrbDftRand.Checked ? 8 : 0)) +
                (rad_RmRedKeysOn.Checked ? 16 : (rad_RmRedKeysRand.Checked ? 32 : 0)) + (rad_AddGoldClawOn.Checked ? 64 : (rad_AddGoldClawRand.Checked ? 128 : 0)) +
                (rad_RandEqPwrOn.Checked ? 256 : (rad_RandEqPwrRand.Checked ? 512 : 0)) + (rad_AdjEqPriceOn.Checked ? 1024 : (rad_AdjEqPriceRand.Checked ? 2048 : 0)) +
                (rad_VanEqValOn.Checked ? 4096 : (rad_VanEqValRand.Checked ? 8192 : 0)) + (rad_AddRemakeOn.Checked ? 16384 : (rad_AddRemakeRand.Checked ? 32768 : 0)));

            int treasureEquipmentTab2 = 23 * ((rad_RandClassEqOn.Checked ? 1 : (rad_RandClassEqRand.Checked ? 2 : 0)) + (rad_RmFightPenOn.Checked ? 4 : (rad_RmFightPenRand.Checked ? 8 : 0)) +
                (rad_AdjStartEqOn.Checked ? 16 : (rad_AdjStartEqRand.Checked ? 32 : 0)) + (rad_RandItemEffOn.Checked ? 64 : (rad_RandItemEffRand.Checked ? 128 : 0)));

            int itemWeaponShopsInnsTab1 = 29 * ((rad_RandInnOn.Checked ? 1 : (rad_RandInnRand.Checked ? 2 : 0)) + (rad_RandWeapShopOn.Checked ? 4 : (rad_RandWeapShopRand.Checked ? 8 : 0)) +
                (rad_RandItemShopOn.Checked ? 16 : (rad_RandItemShopRand.Checked ? 32 : 0)) + (rad_SellUnsellableOn.Checked ? 64 : (rad_SellUnsellableRand.Checked ? 128 : 0)) +
                (rad_CaturdayOn.Checked ? 256 : (rad_CaturdayRand.Checked ? 512 : 0)) + (rad_AcornsOn.Checked ? 1024 : (rad_AcornsRand.Checked ? 2048 : 0)) +
                (rad_StrSeedOn.Checked ? 4096 : (rad_StrSeedRand.Checked ? 8192 : 0)) + (rad_AgiSeedOn.Checked ? 16384 : (rad_AgiSeedRand.Checked ? 32768 : 0)) +
                (rad_IntSeedOn.Checked ? 65536 : (rad_IntSeedRand.Checked ? 131072 : 0)));

            int itemWeaponShopsInnsTab2 = 31 * ((rad_VitSeedOn.Checked ? 1 : (rad_VitSeedRand.Checked ? 2 : 0)) + (rad_LucSeedOn.Checked ? 4 : (rad_LucSeedRand.Checked ? 8 : 0)) +
                (rad_WorldTreeOn.Checked ? 16 : (rad_WorldTreeRand.Checked ? 32 : 0)) + (rad_PoisonMothOn.Checked ? 64 : (rad_PoisonMothRand.Checked ? 128 : 0)) +
                (rad_StoneOfLifeOn.Checked ? 256 : (rad_StoneOfLifeRand.Checked ? 512 : 0)) + (rad_SatoriOn.Checked ? 1024 : (rad_SatoriRand.Checked ? 2048 : 0)) +
                (rad_MetoriteArmbandOn.Checked ? 4096 : (rad_MetoriteArmbandRand.Checked ? 8192 : 0)) + (rad_WizardRingOn.Checked ? 16384 : (rad_WizardRingRand.Checked ? 32768 : 0)) +
                (rad_EchoingFluteOn.Checked ? 65536 : (rad_EchoingFluteRand.Checked ? 131072 : 0)));

            int itemWeaponShopsInnsTab3 = 37 * ((rad_SilverHarpOn.Checked ? 1 : (rad_SilverHarpRand.Checked ? 2 : 0)) + (rad_RingOfLifeOn.Checked ? 4 : (rad_RingOfLifeRand.Checked ? 8 : 0)) +
                (rad_ShoesOfHappinessOn.Checked ? 16 : (rad_ShoesOfHappinessRand.Checked ? 32 : 0)) + (rad_LampOfDarknessOn.Checked ? 64 : (rad_LampOfDarknessRand.Checked ? 128 : 0)));

            int fixesTab = 31 * ((rad_RmParryBugOn.Checked ? 1 : (rad_RmParryBugRand.Checked ? 2 : 0)) + (rad_FixHeroSpellOn.Checked ? 4 : (rad_FixHeroSpellRand.Checked ? 8 : 0)));

            int cosmeticTab = 37 * ((rad_LevelUpTxtOn.Checked ? 1 : (rad_LevelUpTxtRand.Checked ? 2 : 0)) + (rad_RandHeroAgeOn.Checked ? 4 : (rad_RandHeroAgeRand.Checked ? 8 : 0)) +
                (rad_GhostToCasketOn.Checked ? 16 : (rad_GhostToCasketRand.Checked ? 32 : 0)));

            int values = 41 * ((int)romData[0x3d126] + (2 * (int)romData[0x123b1 + 10]) + (4 * (int)romData[0x134f9]) + (8 * (int)romData[0x2a15]) +
                (16 * (int)romData[0x2a54]) + (32 * (int)romData[0x281b + 10]) + (64 * (int)romData[0x281b + 11]) + (128 * (int)romData[0x367c1 + 10]) +
                (256 * (int)romData[0x36862]) + (512 * (int)romData[0x368e2]) + (1024 * (int)romData[0x1147 + 10]) + (2048 * (int)romData[0x279a0]) +
                (4096 * (int)romData[0x11be + 10]) + (8192 * (int)romData[0x2925a]) + (16384 * (int)romData[0x2922b]) + (32768 * (int)romData[0x292c2]) +
                (65536 * (int)romData[0x2914f]) + (131072 * (int)romData[0x32e3 + (230)]) + (262144 * (int)romData[0x32e3 + 480]) + (524288 * (int)romData[0x32e3 + 10])) +
                (1048576 * (int)romData[0x1ef20]);

            int hashNumber = adjustmentTab + adjustmentTab2 + adjustmentTab3 + adjustmentTab4 + mapTab1 + mapTab2 + monstersTab + treasureEquipmentTab1 + treasureEquipmentTab2 +
                itemWeaponShopsInnsTab1 + itemWeaponShopsInnsTab2 + itemWeaponShopsInnsTab3 + fixesTab + cosmeticTab + values;

            string hashString = hashNumber.ToString("X");
            hashString = hashString.ToLower();
            lblHash.Text = hashString;
        }

        private void boostGP()
        {
            // Allow for Randomization of gold change
            int index = 0;

            if (rad_GoldGainRand.Checked)
                index = (r1.Next() % 5);
            else if (rad_GoldGain1.Checked)
                index = 4;
            else if (rad_GoldGain50.Checked)
                index = 3;
            else if (rad_GoldGain100.Checked)
                index = 2;
            else if (rad_GoldGain150.Checked)
                index = 1;
            else if (rad_GoldGain200.Checked)
                index = 0;

            // Replace monster data
            for (int lnI = 0; lnI < 139; lnI++)
            {
                int byteValStart = 0x32e3 + (23 * lnI);

                int gp = romData[byteValStart + 4] + ((romData[byteValStart + 18] % 2) * 256);
                switch (index)
                {
                    case 0:
                        gp *= 2;
                        break;
                    case 1:
                        gp = gp * 3 / 2;
                        break;
                    case 2:
                        break;
                    case 3:
                        gp /= 2;
                        break;
                    case 4:
                        gp = 0;
                        break;
                }

                bool randGold = false;
                if (rad_RandGoldOn.Checked || ((r1.Next() % 2 == 1) && (rad_RandGoldRand.Checked)))
                    randGold = true;
                if (randGold)
                {
                    int addSub = r1.Next() % 2; // 0 means subtract, 1 means add
                    int randPerc = r1.Next() % 25 + 1; // randomization can be up to 25 % either way

                    if (addSub == 0)
                    {
                        gp = gp - (gp * randPerc / 100);
                    }
                    else
                        gp = gp + (gp * randPerc / 100);
                }


                gp = (gp > 1000 ? 1000 : gp);

                if (gp > 0)
                {
                    romData[byteValStart + 4] = (byte)(gp % 256);
                    romData[byteValStart + 18] = (byte)(romData[byteValStart + 18] - (romData[byteValStart + 18] % 4) + (gp / 256));
                }
                else
                {
                    romData[byteValStart + 4] = 0x00;
                    romData[byteValStart + 18] = 0x00;
                }


            }
        }

        private void boostXP()
        {
            int index = 0;
            if (rad_ExpGainRand.Checked)
                index = (r1.Next() % 11) + 1;
            else if (rad_ExpGain0.Checked)
                index = 11;
            else if (rad_ExpGain25.Checked)
                index = 10;
            else if (rad_ExpGain50.Checked)
                index = 9;
            else if (rad_ExpGain100.Checked)
                index = 8;
            else if (rad_ExpGain150.Checked)
                index = 7;
            else if (rad_ExpGain200.Checked)
                index = 6;
            else if (rad_ExpGain300.Checked)
                index = 5;
            else if (rad_ExpGain400.Checked)
                index = 4;
            else if (rad_ExpGain500.Checked)
                index = 3;
            else if (rad_ExpGain750.Checked)
                index = 2;
            else if (rad_ExpGain1000.Checked)
                index = 1;
 
            // Replace monster data
            for (int lnI = 0; lnI < 139; lnI++)
            {
                int byteValStart = 0x32e3 + (23 * lnI);

                int xp = romData[byteValStart + 1] + (romData[byteValStart + 2] * 256);
                switch (index)
                {
                    case 1:
                        xp *= 10;
                        break;
                    case 2:
                        xp = xp * 15 / 2;
                        break;
                    case 3:
                        xp *= 5;
                        break;
                    case 4:
                        xp *= 4;
                        break;
                    case 5:
                        xp *= 3;
                        break;
                    case 6:
                        xp *= 2;
                        break;
                    case 7:
                        xp = xp * 3 / 2;
                        break;
                    case 8:
                        break;
                    case 9:
                        xp /= 2;
                        break;
                    case 10:
                        xp /= 4;
                        break;
                    case 11:
                        xp = 0;
                        break;
                }
                bool randExp = false;
                if (rad_RandExpOn.Checked || ((r1.Next() % 2 == 1) && (rad_RandExpRand.Checked)))
                    randExp = true;
                if (randExp)
                {
                    int addSub = r1.Next() % 2; // 0 means subtract, 1 means add
                    int randPerc = r1.Next() % 25 + 1; // randomization can be up to 25 % either way

                    if (addSub == 0)
                    {
                        xp = xp - (xp * randPerc / 100);
                    }
                    else
                        xp = xp + (xp * randPerc / 100);
                }
                xp = (xp > 65500 ? 65500 : xp);

                romData[byteValStart + 1] = (byte)(xp % 256);
                romData[byteValStart + 2] = (byte)(xp / 256);
            }
        }

        private void adjustEncounters()
        {
            // Randomize Encounter Rate
            int index = 0;
            if (rad_EncRateRand.Checked)
                index = (r1.Next() % 9) + 1;
            else if (rad_EncRate0.Checked)
                index = 9;
            else if (rad_EncRate25.Checked)
                index = 8;
            else if (rad_EncRate50.Checked)
                index = 7;
            else if (rad_EncRate75.Checked)
                index = 6;
            else if (rad_EncRate100.Checked)
                index = 5;
            else if (rad_EncRate150.Checked)
                index = 4;
            else if (rad_EncRate200.Checked)
                index = 3;
            else if (rad_EncRate300.Checked)
                index = 2;
            else if (rad_EncRate400.Checked)
                index = 1;

            for (int i = 0x944; i <= 0x955; i++)
            {
                switch (index)
                {
                    case 1:
                        romData[i] *= 4;
                        break;
                    case 2:
                        romData[i] *= 3;
                        break;
                    case 3:
                        romData[i] *= 2;
                        break;
                    case 4:
                        romData[i] = (byte)(romData[i] * 3 / 2);
                        break;
                    case 5:
                        break;
                    case 6:
                        romData[i] = (byte)(romData[i] * 3 / 4);
                        break;
                    case 7:
                        romData[i] /= 2;
                        break;
                    case 8:
                        romData[i] /= 4;
                        break;
                    case 9:
                        romData[i] = 0;
                        break;
                }
            }
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            randomizerTools randomizerTools = new randomizerTools();

            if (!randomizerTools.loadRom(ref romData, ref romData2, txtFileName.Text, txtCompare.Text, true)) return;

            string IntensityDesc = lblIntensityDesc.Text;
            randomizerTools.CompareFile(ref romData, ref romData2, ref IntensityDesc, txtFileName.Text);
            lblIntensityDesc.Text = IntensityDesc;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtFileName.Text != "")
            {
                string shortVersion = versionNumber.Replace(".", "");
                using (StreamWriter writer = File.CreateText("lastFile" + shortVersion + ".txt"))
                {
                    writer.WriteLine(txtFileName.Text);
                    writer.WriteLine(txtFlags.Text);
                    writer.WriteLine(rad_ChName1Off.Checked);
                    writer.WriteLine(rad_ChName1Manual.Checked);
                    writer.WriteLine(rad_ChName1Rand.Checked);
                    writer.WriteLine(rad_ChName2Off.Checked);
                    writer.WriteLine(rad_ChName2Manual.Checked);
                    writer.WriteLine(rad_ChName2Rand.Checked);
                    writer.WriteLine(rad_ChName3Off.Checked);
                    writer.WriteLine(rad_ChName3Manual.Checked);
                    writer.WriteLine(rad_ChName3Rand.Checked);
                    writer.WriteLine(txt_ChName1.Text);
                    writer.WriteLine(txt_ChName2.Text);
                    writer.WriteLine(txt_ChName3.Text);
                    writer.WriteLine(rad_Gender1Off.Checked);
                    writer.WriteLine(rad_Gender1Manual.Checked);
                    writer.WriteLine(rad_Gender1Rand.Checked);
                    writer.WriteLine(rad_Gender2Off.Checked);
                    writer.WriteLine(rad_Gender2Manual.Checked);
                    writer.WriteLine(rad_Gender2Rand.Checked);
                    writer.WriteLine(rad_Gender3Off.Checked);
                    writer.WriteLine(rad_Gender3Manual.Checked);
                    writer.WriteLine(rad_Gender3Rand.Checked);
                    writer.WriteLine(cbo_Gender1.SelectedIndex);
                    writer.WriteLine(cbo_Gender2.SelectedIndex);
                    writer.WriteLine(cbo_Gender3.SelectedIndex);
                    writer.WriteLine(chk_RandSoldier.Checked);
                    writer.WriteLine(chk_RandPilgrim.Checked);
                    writer.WriteLine(chk_RandWizard.Checked);
                    writer.WriteLine(chk_RandFighter.Checked);
                    writer.WriteLine(chk_RandMerchant.Checked);
                    writer.WriteLine(chk_RandGoofOff.Checked);
                    writer.WriteLine(chk_RandSage.Checked);
                    writer.WriteLine(chk_RandHero.Checked);
                    writer.WriteLine(rad_Class1Off.Checked);
                    writer.WriteLine(rad_Class1Manual.Checked);
                    writer.WriteLine(rad_Class1Rand.Checked);
                    writer.WriteLine(rad_Class2Off.Checked);
                    writer.WriteLine(rad_Class2Manual.Checked);
                    writer.WriteLine(rad_Class2Rand.Checked);
                    writer.WriteLine(rad_Class3Off.Checked);
                    writer.WriteLine(rad_Class3Manual.Checked);
                    writer.WriteLine(rad_Class3Rand.Checked);
                    writer.WriteLine(cbo_Class1.SelectedIndex);
                    writer.WriteLine(cbo_Class2.SelectedIndex);
                    writer.WriteLine(cbo_Class3.SelectedIndex);
                    writer.WriteLine(rad_StdCaseOff.Checked);
                    writer.WriteLine(rad_StdCaseOn.Checked);
                    writer.WriteLine(rad_StdCaseRand.Checked);
                    writer.WriteLine(rad_SlimeSnailOff.Checked);
                    writer.WriteLine(rad_SlimeSnailOn.Checked);
                    writer.WriteLine(rad_SlimeSnailRand.Checked);
                    writer.WriteLine(rad_RandSpriteColOff.Checked);
                    writer.WriteLine(rad_RandSpriteColOn.Checked);
                    writer.WriteLine(rad_RandSpriteColRand.Checked);
                    writer.WriteLine(rad_ChCatsOff.Checked);
                    writer.WriteLine(rad_ChCatsOn.Checked);
                    writer.WriteLine(rad_ChCatsRand.Checked);
                    writer.WriteLine(rad_FFightSpriteOff.Checked);
                    writer.WriteLine(rad_FFightSpriteOn.Checked);
                    writer.WriteLine(rad_FFightSpriteRand.Checked);
                    writer.WriteLine(rad_RandNPCOff.Checked);
                    writer.WriteLine(rad_RandNPCOn.Checked);
                    writer.WriteLine(rad_RandNPCRand.Checked);
                    writer.WriteLine(rad_FHeroOff.Checked);
                    writer.WriteLine(rad_FHeroOn.Checked);
                    writer.WriteLine(rad_FHeroRand.Checked);
                }
            }
        }

        private void txtFileName_Leave(object sender, EventArgs e)
        {
            runChecksum();
        }

        private void btnCompareBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath);
            //            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCompare.Text = openFileDialog1.FileName;
            }
        }


        private void btn_CopyHash_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblHash.Text);
        }

        private void btn_chksumHash_Click(object sender, EventArgs e)
        {
            string chksumhash = lblNewChecksum.Text + " / " + lblHash.Text;
            Clipboard.SetText(chksumhash);
        }

        private void determineChecks(object sender, EventArgs e)
        {
            flagscalc flagscalc = new flagscalc();

            string flags = txtFlags.Text;
            int number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(0, 1)));
            int bank1 = 0; // Generally 0,1,2
            int bank2 = 0; // Generally 4-10, may be combined with bank 1
            int bank3 = 0; // Generally 16-42
            chk_GenCompareFile.Checked = (number % 2 == 1);

            // Adjustments
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(2, 1)));
            bank3 = number; // cboExpGains - 11 options
            switch (bank3)
            {
                case 16:
                    rad_ExpGainRand.Checked = true;
                    break;
                case 17:
                    rad_ExpGain0.Checked = true;
                    break;
                case 18: 
                    rad_ExpGain25.Checked = true;
                    break;
                case 20: 
                    rad_ExpGain50.Checked = true;
                    break;
                case 21: 
                    rad_ExpGain100.Checked = true;
                    break;
                case 22:
                    rad_ExpGain150.Checked = true;
                    break;
                case 24:
                    rad_ExpGain200.Checked = true;
                    break;
                case 25:
                    rad_ExpGain300.Checked = true;
                    break;
                case 26:
                    rad_ExpGain400.Checked = true;
                    break;
                case 32:
                    rad_ExpGain500.Checked = true;
                    break;
                case 33:
                    rad_ExpGain750.Checked = true;
                    break;
                case 34:
                    rad_ExpGain1000.Checked = true;
                    break;
            }

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(3, 1)));
            bank3 = number;
            switch(bank3)
            {
                case 16:
                    rad_EncRateRand.Checked = true;
                    break;
                case 17:
                    rad_EncRate0.Checked = true;
                    break;
                case 18:
                    rad_EncRate25.Checked = true;
                    break;
                case 20:
                    rad_EncRate50.Checked = true;
                    break;
                case 21:
                    rad_EncRate75.Checked = true;
                    break;
                case 22:
                    rad_EncRate100.Checked = true;
                    break;
                case 24:
                    rad_EncRate150.Checked = true;
                    break;
                case 25:
                    rad_EncRate200.Checked = true;
                    break;
                case 26:
                    rad_EncRate300.Checked = true;
                    break;
                case 32:
                    rad_EncRate400.Checked = true;
                    break;
            }

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(4, 1)));
            bank2 = number % 16; // cboGoldReq - 6 options
            switch (bank2)
            {
                case 4:
                    rad_GoldGainRand.Checked = true;
                    break;
                case 5:
                    rad_GoldGain1.Checked = true;
                    break;
                case 6:
                    rad_GoldGain50.Checked = true;
                    break;
                case 8:
                    rad_GoldGain100.Checked = true;
                    break;
                case 9:
                    rad_GoldGain150.Checked = true;
                    break;
                case 10:
                    rad_GoldGain200.Checked = true;
                    break;
            }

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(5, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_IncBattSpeedOff.Checked = true;
            else if (bank1 == 1) rad_IncBattSpeedOn.Checked = true;
            else if (bank1 == 2) rad_IncBattSpeedRand.Checked = true;
            if (bank2 == 0) rad_SpeedTextOff.Checked = true;
            else if (bank2 == 1) rad_SpeedTextOn.Checked = true;
            else if (bank2 == 2) rad_SpeedTextRand.Checked = true;
            if (bank3 == 0) rad_SpeedUpMenuOff.Checked = true;
            else if (bank3 == 1) rad_SpeedUpMenuOn.Checked = true;
            else if (bank3 == 2) rad_SpeedUpMenuRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(6, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RmManipOff.Checked = true;
            else if (bank1 == 1) rad_RmManipOn.Checked = true;
            else if (bank1 == 2) rad_RmManipRand.Checked = true;
            if (bank2 == 0) rad_StartGoldOff.Checked = true;
            else if (bank2 == 1) rad_StartGoldOn.Checked = true;
            else if (bank2 == 2) rad_StartGoldRand.Checked = true;
            if (bank3 == 0) rad_codOff.Checked = true;
            else if (bank3 == 1) rad_codOn.Checked = true;
            else if (bank3 == 2) rad_codRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(7, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_LamiaOff.Checked = true;
            else if (bank1 == 1) rad_LamiaOn.Checked = true;
            else if (bank1 == 2) rad_LamiaRand.Checked = true;
            if (bank2 == 0) rad_DispEqPowerOff.Checked = true;
            else if (bank2 == 1) rad_DispEqPowerOn.Checked = true;
            else if (bank2 == 2) rad_DispEqPowerRand.Checked = true;
            if (bank3 == 0) rad_DoubleAttOff.Checked = true;
            else if (bank3 == 1) rad_DoubleAttOn.Checked = true;
            else if (bank3 == 2) rad_DoubleAttRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(8,1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_PartyItemsOff.Checked = true;
            else if (bank1 == 1) rad_PartyItemsOn.Checked = true;
            else if (bank1 == 2) rad_PartyItemsRand.Checked = true;
            if (bank2 == 0) rad_InvisShipBirdOff.Checked = true;
            else if (bank2 == 1) rad_InvisShipBirdOn.Checked = true;
            else if (bank2 == 2) rad_InvisShipBirdRand.Checked = true;
            if (bank3 == 0) rad_InvisNPCOff.Checked = true;
            else if (bank3 == 1) rad_InvisNPCOn.Checked = true;
            else if (bank3 == 2) rad_InvisNPCRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(9, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RandSageStoneOff.Checked = true;
            else if (bank1 == 1) rad_RandSageStoneOn.Checked = true;
            else if (bank1 == 2) rad_RandSageStoneRand.Checked = true;
            if (bank2 == 0) rad_HUAStoneOff.Checked = true;
            else if (bank2 == 1) rad_HUAStoneOn.Checked = true;
            else if (bank2 == 2) rad_HUAStoneRand.Checked = true;
            if (bank3 == 0) rad_SoHRoLEffOff.Checked = true;
            else if (bank3 == 1) rad_SoHRoLEffOn.Checked = true;
            else if (bank3 == 2) rad_SoHRoLEffRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(10, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_BigOff.Checked = true;
            else if (bank1 == 1) rad_BigOn.Checked = true;
            else if (bank1 == 2) rad_BigRand.Checked = true;
            if (bank2 == 0) rad_RandSpellLearningOff.Checked = true;
            else if (bank2 == 1) rad_RandSpellLearningOn.Checked = true;
            else if (bank2 == 2) rad_RandSpellLearningRand.Checked = true;
            if (bank3 == 0) rad_RandSpellStrOff.Checked = true;
            else if (bank3 == 1) rad_RandSpellStrOn.Checked = true;
            else if (bank3 == 2) rad_RandSpellStrRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(11, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_NonMagMPOff.Checked = true;
            else if (bank1 == 1) rad_NonMagMPOn.Checked = true;
            else if (bank1 == 2) rad_NonMagMPRand.Checked = true;
            if (bank2 == 0) rad_FourJobFiestaOff.Checked = true;
            else if (bank2 == 1) rad_FourJobFiestaOn.Checked = true;
            else if (bank2 == 2) rad_FourJobFiestaRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(12, 1)));
            bank2 = number % 16; // cboGoldReq - 6 options
            switch (bank2)
            {
                case 4:
                    rad_RandStatsOff.Checked = true;
                    break;
                case 5:
                    rad_RandStatsSilly.Checked = true;
                    break;
                case 6:
                    rad_RandStatsRid.Checked = true;
                    break;
                case 8:
                    rad_RandStatsLud.Checked = true;
                    break;
                case 9:
                    rad_RandStatsRand.Checked = true;
                    break;
            }

            // - 13

            // Monsters
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(14, 1)));
            /*
            optStatSilly.Checked = (number % 4 == 0);
            optStatMedium.Checked = (number % 4 == 1);
            optStatHeavy.Checked = (number % 4 == 2);
            */
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RandExpOff.Checked = true;
            else if (bank1 == 1) rad_RandExpOn.Checked = true;
            else if (bank1 == 2) rad_RandExpRand.Checked = true;
            if (bank2 == 0) rad_RandGoldOff.Checked = true;
            else if (bank2 == 1) rad_RandGoldOn.Checked = true;
            else if (bank2 == 2) rad_RandGoldRand.Checked = true;
            if (bank3 == 0) rad_RandDropOff.Checked = true;
            else if (bank3 == 1) rad_RandDropOn.Checked = true;
            else if (bank3 == 2) rad_RandDropRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(15, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RandEnePatOff.Checked = true;
            else if (bank1 == 1) rad_RandEnePatOn.Checked = true;
            else if (bank1 == 2) rad_RandEnePatRand.Checked = true;
            if (bank2 == 0) rad_RmDupDropOff.Checked = true;
            else if (bank2 == 1) rad_RmDupDropOn.Checked = true;
            else if (bank2 == 2) rad_RmDupDropRand.Checked = true;
            if (bank3 == 0) rad_RmMetalRunOff.Checked = true;
            else if (bank3 == 1) rad_RmMetalRunOn.Checked = true;
            else if (bank3 == 2) rad_RmMetalRunRand.Checked = true;

            // - 16

            // Map
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(17, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RandMapsOff.Checked = true;
            else if (bank1 == 1) rad_RandMapsOn.Checked = true;
            else if (bank1 == 2) rad_RandMapsRand.Checked = true;
            if (bank2 == 0) rad_SmallMapOff.Checked = true;
            else if (bank2 == 1) rad_SmallMapOn.Checked = true;
            else if (bank2 == 2) rad_SmallMapRand.Checked = true;
            if (bank3 == 0) rad_RandMonstZoneOff.Checked = true;
            else if (bank3 == 1) rad_RandMonstZoneOn.Checked = true;
            else if (bank3 == 2) rad_RandMonstZoneRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(18, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RandTownsOff.Checked = true;
            else if (bank1 == 1) rad_RandTownsOn.Checked = true;
            else if (bank1 == 2) rad_RandTownsRand.Checked = true;
            if (bank2 == 0) rad_RandCavesOff.Checked = true;
            else if (bank2 == 1) rad_RandCavesOn.Checked = true;
            else if (bank2 == 2) rad_RandCavesRand.Checked = true;
            if (bank3 == 0) rad_RandShrinesOff.Checked = true;
            else if (bank3 == 1) rad_RandShrinesOn.Checked = true;
            else if (bank3 == 2) rad_RandShrinesRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(19, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_LancelCaveOff.Checked = true;
            else if (bank1 == 1) rad_LancelCaveOn.Checked = true;
            else if (bank1 == 2) rad_LancelCaveRand.Checked = true;
            if (bank2 == 0) rad_CaveOfNecroOff.Checked = true;
            else if (bank2 == 1) rad_CaveOfNecroOn.Checked = true;
            else if (bank2 == 2) rad_CaveOfNecroRand.Checked = true;
            if (bank3 == 0) rad_BaramosCastOff.Checked = true;
            else if (bank3 == 1) rad_BaramosCastOn.Checked = true;
            else if (bank3 == 2) rad_BaramosCastRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(20, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_DrgQnCastOff.Checked = true;
            else if (bank1 == 1) rad_DrgQnCastOn.Checked = true;
            else if (bank1 == 2) rad_DrgQnCastRand.Checked= true;
            if (bank2 == 0) rad_DisAlefGlitchOff.Checked = true;
            else if (bank2 == 1) rad_DisAlefGlitchOn.Checked = true;
            else if (bank2 == 2) rad_DisAlefGlitchRand.Checked = true;
            if (bank3 == 0) rad_CharlockOff.Checked = true;
            else if (bank3 == 1) rad_CharlockOn.Checked = true;
            else if (bank3 == 2) rad_CharlockRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(21, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_NoNewTownOff.Checked = true;
            else if (bank1 == 1) rad_NoNewTownOn.Checked = true;
            else if (bank1 == 2) rad_NoNewTownRand.Checked = true;

            // - 22

            // Treasures & Equipment
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(23, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RandTreasOff.Checked = true;
            else if (bank1 == 1) rad_RandTreasOn.Checked = true;
            else if (bank1 == 2) rad_RandTreasRand.Checked = true;
            if (bank2 == 0) rad_OrbDftOff.Checked = true;
            else if (bank2 == 1) rad_OrbDftOn.Checked = true;
            else if (bank2 == 2) rad_OrbDftRand.Checked = true;
            if (bank3 == 0) rad_RmRedKeysOff.Checked = true;
            else if (bank3 == 1) rad_RmRedKeysOn.Checked = true;
            else if (bank3 == 2) rad_RmRedKeysRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(24, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_AddGoldClawOff.Checked = true;
            else if (bank1 == 1) rad_AddGoldClawOn.Checked = true;
            else if (bank1 == 2) rad_AddGoldClawRand.Checked = true;
            if (bank2 == 0) rad_RandEqPwrOff.Checked = true;
            else if (bank2 == 1) rad_RandEqPwrOn.Checked = true;
            else if (bank2 == 2) rad_RandEqPwrRand.Checked = true;
            if (bank3 == 0) rad_AdjEqPriceOff.Checked = true;
            else if (bank3 == 1) rad_AdjEqPriceOn.Checked = true;
            else if (bank3 == 2) rad_AdjEqPriceRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(25, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_VanEqValOff.Checked = true;
            else if (bank1 == 1) rad_VanEqValOn.Checked = true;
            else if (bank1 == 2) rad_VanEqValRand.Checked = true;
            if (bank2 == 0) rad_AddRemakeOff.Checked = true;
            else if (bank2 == 1) rad_AddRemakeOn.Checked = true;
            else if (bank2 == 2) rad_AddRemakeRand.Checked = true;
            if (bank3 == 0) rad_RandClassEqOff.Checked = true;
            else if (bank3 == 1) rad_RandClassEqOn.Checked = true;
            else if (bank3 == 2) rad_RandClassEqRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(26, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RmFightPenOff.Checked = true;
            else if (bank1 == 1) rad_RmFightPenOn.Checked = true;
            else if (bank1 == 2) rad_RmFightPenRand.Checked = true;
            if (bank2 == 0) rad_AdjStartEqOff.Checked = true;
            else if (bank2 == 1) rad_AdjStartEqOn.Checked = true;
            else if (bank2 == 2) rad_AdjStartEqRand.Checked = true;
            // Random Item Effects are off for now.
            rad_RandItemEffOff.Checked = true;

            // - 27

            // Item & Weapon Shops & Inns
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(28, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RandInnOff.Checked = true;
            else if (bank1 == 1) rad_RandInnOn.Checked = true;
            else if (bank1 == 2) rad_RandInnRand.Checked = true;
            if (bank2 == 0) rad_RandWeapShopOff.Checked = true;
            else if (bank2 == 1) rad_RandWeapShopOn.Checked = true;
            else if (bank2 == 2) rad_RandWeapShopRand.Checked = true;
            if (bank3 == 0) rad_RandItemShopOff.Checked = true;
            else if (bank3 == 1) rad_RandItemShopOn.Checked = true;
            else if (bank3 == 2) rad_RandItemShopRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(29, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_SellUnsellableOff.Checked = true;
            else if (bank1 == 1) rad_SellUnsellableOn.Checked = true;
            else if (bank1 == 2) rad_SellUnsellableRand.Checked = true;
            if (bank2 == 0) rad_CaturdayOff.Checked = true;
            else if (bank2 == 1) rad_CaturdayOn.Checked = true;
            else if (bank2 == 2) rad_CaturdayRand.Checked = true;
            if (bank3 == 0) rad_AcornsOff.Checked = true;
            else if (bank3 == 1) rad_AcornsOn.Checked = true;
            else if (bank3 == 2) rad_AcornsRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(30, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_StrSeedOff.Checked = true;
            else if (bank1 == 1) rad_StrSeedOn.Checked = true;
            else if (bank1 == 2) rad_StrSeedRand.Checked = true;
            if (bank2 == 0) rad_AgiSeedOff.Checked = true;
            else if (bank2 == 1) rad_AgiSeedOn.Checked = true;
            else if (bank2 == 2) rad_AgiSeedRand.Checked = true;
            if (bank3 == 0) rad_IntSeedOff.Checked = true;
            else if (bank3 == 1) rad_IntSeedOn.Checked = true;
            else if (bank3 == 2) rad_IntSeedRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(31, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_VitSeedOff.Checked = true;
            else if (bank1 == 1) rad_VitSeedOn.Checked = true;
            else if (bank1 == 2) rad_VitSeedRand.Checked = true;
            if (bank2 == 0) rad_LucSeedOff.Checked = true;
            else if (bank2 == 1) rad_LucSeedOn.Checked = true;
            else if (bank2 == 2) rad_LucSeedRand.Checked = true;
            if (bank3 == 0) rad_WorldTreeOff.Checked = true;
            else if (bank3 == 1) rad_WorldTreeOn.Checked = true;
            else if (bank3 == 2) rad_WorldTreeRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(32, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_PoisonMothOff.Checked = true;
            else if (bank1 == 1) rad_PoisonMothOn.Checked = true;
            else if (bank1 == 2) rad_PoisonMothRand.Checked = true;
            if (bank2 == 0) rad_StoneOfLifeOff.Checked = true;
            else if (bank2 == 1) rad_StoneOfLifeOn.Checked = true;
            else if (bank2 == 2) rad_StoneOfLifeRand.Checked = true;
            if (bank3 == 0) rad_SatoriOff.Checked = true;
            else if (bank3 == 1) rad_SatoriOn.Checked = true;
            else if (bank3 == 2) rad_SatoriRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(33, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_MetoriteArmbandOff.Checked = true;
            else if (bank1 == 1) rad_MetoriteArmbandOn.Checked = true;
            else if (bank2 == 2) rad_MetoriteArmbandRand.Checked = true;
            if (bank2 == 0) rad_WizardRingOff.Checked = true;
            else if (bank2 == 1) rad_WizardRingOn.Checked = true;
            else if (bank2 == 2) rad_WizardRingRand.Checked = true;
            if (bank3 == 0) rad_EchoingFluteOff.Checked = true;
            else if (bank3 == 1) rad_EchoingFluteOn.Checked = true;
            else if (bank3 == 2) rad_EchoingFluteRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(34, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_SilverHarpOff.Checked = true;
            else if (bank1 == 1) rad_SilverHarpOn.Checked = true;
            else if (bank1 == 2) rad_SilverHarpRand.Checked = true;
            if (bank2 == 0) rad_RingOfLifeOff.Checked = true;
            else if (bank2 == 1) rad_RingOfLifeOn.Checked = true;
            else if (bank2 == 2) rad_RingOfLifeRand.Checked = true;
            if (bank3 == 0) rad_ShoesOfHappinessOff.Checked = true;
            else if (bank3 == 1) rad_ShoesOfHappinessOn.Checked = true;
            else if (bank3 == 2) rad_ShoesOfHappinessRand.Checked = true;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(35, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_LampOfDarknessOff.Checked = true;
            else if (bank1 == 1) rad_LampOfDarknessOn.Checked = true;
            else if (bank1 == 2) rad_LampOfDarknessRand.Checked = true;            
            
            // - 36

            // Characters
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(37, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) chk_RandSage.Checked = false;
            else if (bank1 == 1) chk_RandSage.Checked = true;
            if (bank2 == 0) chk_RandHero.Checked = false;
            else if (bank2 == 1) chk_RandHero.Checked = true;

            // - 38

            // Fixes
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(39, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_RmParryBugOff.Checked = true;
            else if (bank1 == 1) rad_RmParryBugOn.Checked = true;
            else if (bank1 == 2) rad_RmParryBugRand.Checked = true;
            if (bank2 == 0) rad_FixHeroSpellOff.Checked = true;
            else if (bank2 == 1) rad_FixHeroSpellOn.Checked = true;
            else if (bank2 == 2) rad_FixHeroSpellRand.Checked = true;

            // - 40

            // Cosmetic
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(41, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) rad_LevelUpTxtOff.Checked = true;
            else if (bank1 == 1) rad_LevelUpTxtOn.Checked = true;
            else if (bank2 == 2) rad_LevelUpTxtRand.Checked = true;
            if (bank2 == 0) rad_RandHeroAgeOff.Checked = true;
            else if (bank2 == 1) rad_RandHeroAgeOn.Checked = true;
            else if (bank2 == 2) rad_RandHeroAgeRand.Checked = true;
            if (bank3 == 0) rad_GhostToCasketOff.Checked = true;
            else if (bank3 == 1) rad_GhostToCasketOn.Checked = true;
            else if (bank3 == 2) rad_GhostToCasketRand.Checked = true;
        }

        private void determineFlags(object sender, EventArgs e)
        {
            if (loading) return;

            flagscalc flagscalc = new flagscalc();

            string flags = "";
            int bank1 = 0; // 0,1,2
            int bank2 = 0; // 4-10
            int bank3 = 0; // 16-42
            flags += flagscalc.convertIntToCharCapsOnlyForFlags((chk_GenCompareFile.Checked ? 1 : 0)); // 0

            flags += "-"; // 1
            // Adjustments

            if (rad_ExpGainRand.Checked) bank3 = 16;
            else if (rad_ExpGain0.Checked) bank3 = 17;
            else if (rad_ExpGain25.Checked) bank3 = 18;
            else if (rad_ExpGain50.Checked) bank3 = 20;
            else if (rad_ExpGain100.Checked) bank3 = 21;
            else if (rad_ExpGain150.Checked) bank3 = 22;
            else if (rad_ExpGain200.Checked) bank3 = 24;
            else if (rad_ExpGain300.Checked) bank3 = 25;
            else if (rad_ExpGain400.Checked) bank3 = 26;
            else if (rad_ExpGain500.Checked) bank3 = 32;
            else if (rad_ExpGain750.Checked) bank3 = 33;
            else if (rad_ExpGain1000.Checked) bank3 = 34;
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 2

            bank1 = bank2 = bank3 = 0;
            if (rad_EncRateRand.Checked) bank3 = 16;
            else if (rad_EncRate0.Checked) bank3 = 17;
            else if (rad_EncRate25.Checked) bank3 = 18;
            else if (rad_EncRate50.Checked) bank3 = 20;
            else if (rad_EncRate75.Checked) bank3 = 21;
            else if (rad_EncRate100.Checked) bank3 = 22;
            else if (rad_EncRate150.Checked) bank3 = 24;
            else if (rad_EncRate200.Checked) bank3 = 25;
            else if (rad_EncRate300.Checked) bank3 = 26;
            else if (rad_EncRate400.Checked) bank3 = 32;
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 3

            bank1 = bank2 = bank3 = 0;
            if (rad_GoldGainRand.Checked) bank2 = 4;
            else if (rad_GoldGain1.Checked) bank2 = 5;
            else if (rad_GoldGain50.Checked) bank2 = 6;
            else if (rad_GoldGain100.Checked) bank2 = 8;
            else if (rad_GoldGain150.Checked) bank2 = 9;
            else if (rad_GoldGain200.Checked) bank2 = 10;
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 4

            bank1 = bank2 = bank3 = 0;
            bank1 += ((rad_IncBattSpeedOff.Checked ? 0 : 0) + (rad_IncBattSpeedOn.Checked ? 1 : 0) + (rad_IncBattSpeedRand.Checked ? 2 : 0));
            bank2 += ((rad_SpeedTextOff.Checked ? 0 : 0) + (rad_SpeedTextOn.Checked ? 4 : 0) + (rad_SpeedTextRand.Checked ? 8 : 0));
            bank3 += ((rad_SpeedUpMenuOff.Checked ? 0 : 0) + (rad_SpeedUpMenuOn.Checked ? 16 : 0) + (rad_SpeedUpMenuRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 5

            bank1 = bank2 = bank3 = 0;
            bank1 += ((rad_RmManipOff.Checked ? 0 : 0) + (rad_RmManipOn.Checked ? 1 : 0) + (rad_RmManipRand.Checked ? 2 : 0));
            bank2 += ((rad_StartGoldOff.Checked ? 0 : 0) + (rad_StartGoldOn.Checked ? 4 : 0) + (rad_StartGoldRand.Checked ? 8 : 0));
            bank3 += ((rad_codOff.Checked ? 0 : 0) + (rad_codOn.Checked ? 16 : 0) + (rad_codRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 6

            bank1 = bank2 = bank3 = 0;
            bank1 += ((rad_LamiaOff.Checked ? 0 : 0) + (rad_LamiaOn.Checked ? 1 : 0) + (rad_LamiaRand.Checked ? 2 : 0));
            bank2 += ((rad_DispEqPowerOff.Checked ? 0 : 0) + (rad_DispEqPowerOn.Checked ? 4 : 0) + (rad_DispEqPowerRand.Checked ? 8 : 0));
            bank3 += ((rad_DoubleAttOff.Checked ? 0 : 0) + (rad_DoubleAttOn.Checked ? 16 : 0) + (rad_DoubleAttRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 7

            bank1 = bank2 = bank3 = 0;
            bank1 += ((rad_PartyItemsOff.Checked ? 0 : 0) + (rad_PartyItemsOn.Checked ? 1 : 0) + (rad_PartyItemsRand.Checked ? 2 : 0));
            bank2 += ((rad_InvisShipBirdOff.Checked ? 0 : 0) + (rad_InvisShipBirdOn.Checked ? 4 : 0) + (rad_InvisShipBirdRand.Checked ? 8 : 0));
            bank3 += ((rad_InvisNPCOff.Checked ? 0 : 0) + (rad_InvisNPCOn.Checked ? 16 : 0) + (rad_InvisNPCRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 8

            bank1 = bank2 = bank3 = 0;
            bank1 += ((rad_RandSageStoneOff.Checked ? 0 : 0) + (rad_RandSageStoneOn.Checked ? 1 : 0) + (rad_RandSageStoneRand.Checked ? 2 : 0));
            bank2 += ((rad_HUAStoneOff.Checked ? 0 : 0) + (rad_HUAStoneOn.Checked ? 4 : 0) + (rad_HUAStoneRand.Checked ? 8 : 0));
            bank3 += ((rad_SoHRoLEffOff.Checked ? 0 : 0) + (rad_SoHRoLEffOn.Checked ? 16 : 0) + (rad_SoHRoLEffRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 9

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_BigOff.Checked ? 0 : 0) + (rad_BigOn.Checked ? 1 : 0) + (rad_BigRand.Checked ? 2 : 0));
            bank2 = ((rad_RandSpellLearningOff.Checked ? 0 : 0) + (rad_RandSpellLearningOn.Checked ? 4 : 0) + (rad_RandSpellLearningRand.Checked ? 8 : 0));
            bank3 = ((rad_RandSpellStrOff.Checked ? 0 : 0) + (rad_RandSpellStrOn.Checked ? 16 : 0) + (rad_RandSpellStrRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 10

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_NonMagMPOff.Checked ? 0 : 0) + (rad_NonMagMPOn.Checked ? 1 : 0) + (rad_NonMagMPRand.Checked ? 2 : 0));
            bank2 = ((rad_FourJobFiestaOff.Checked ? 0 : 0) + (rad_FourJobFiestaOn.Checked ? 4 : 0) + (rad_FourJobFiestaRand.Checked ? 8 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 11

            bank1 = bank2 = bank3 = 0;
            if (rad_RandStatsOff.Checked) bank2 = 4;
            else if (rad_RandStatsSilly.Checked) bank2 = 5;
            else if (rad_RandStatsRid.Checked) bank2 = 6;
            else if (rad_RandStatsLud.Checked) bank2 = 8;
            else if (rad_RandStatsRand.Checked) bank2 = 9;
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 12

            flags += "-"; // 13

            // Monsters
            bank1 = bank2 = bank3 = 0;
            bank1 += ((rad_RandExpOff.Checked ? 0 : 0) + (rad_RandExpOn.Checked ? 1 : 0) + (rad_RandExpRand.Checked ? 2 : 0));
            bank2 += ((rad_RandGoldOff.Checked ? 0 : 0) + (rad_RandGoldOn.Checked ? 4 : 0) + (rad_RandGoldRand.Checked ? 8 : 0));
            bank3 += ((rad_RandDropOff.Checked ? 0 : 0) + (rad_RandDropOn.Checked ? 16 : 0) + (rad_RandDropRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 14

            bank1 = bank2 = bank3 = 0;
            bank1 += ((rad_RandEnePatOff.Checked ? 0 : 0) + (rad_RandEnePatOn.Checked ? 1 : 0) + (rad_RandEnePatRand.Checked ? 2 : 0));
            bank2 += ((rad_RmDupDropOff.Checked ? 0 : 0) + (rad_RmDupDropOn.Checked ? 4 : 0) + (rad_RmDupDropRand.Checked ? 8 : 0));
            bank3 += ((rad_RmMetalRunOff.Checked ? 0 : 0) + (rad_RmMetalRunOn.Checked ? 16 : 0) + (rad_RmMetalRunRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 15

            flags += "-"; //16

            // Map
            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_RandMapsOff.Checked ? 0 : 0) + (rad_RandMapsOn.Checked ? 1 : 0) + (rad_RandMapsRand.Checked ? 2 : 0));
            bank2 = ((rad_SmallMapOff.Checked ? 0 : 0) + (rad_SmallMapOn.Checked ? 4 : 0) + (rad_SmallMapRand.Checked ? 8 : 0));
            bank3 = ((rad_RandMonstZoneOff.Checked ? 0 : 0) + ((rad_RandMonstZoneOn.Checked ? 16 : 0) + (rad_RandMonstZoneRand.Checked ? 32 : 0)));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 17

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_RandTownsOff.Checked ? 0 : 0) + (rad_RandTownsOn.Checked ? 1 : 0) + (rad_RandTownsRand.Checked ? 2 : 0));
            bank2 = ((rad_RandCavesOff.Checked ? 0 : 0) + (rad_RandCavesOn.Checked ? 4 : 0) + (rad_RandCavesRand.Checked ? 8 : 0));
            bank3 = ((rad_RandShrinesOff.Checked ? 0 : 0) + (rad_RandShrinesOn.Checked ? 16 : 0) + (rad_RandShrinesRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 18

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_LancelCaveOff.Checked ? 0 : 0) + (rad_LancelCaveOn.Checked ? 1 : 0) + (rad_LancelCaveRand.Checked ? 2 : 0));
            bank2 = ((rad_CaveOfNecroOff.Checked ? 0 : 0) + (rad_CaveOfNecroOn.Checked ? 4 : 0) + (rad_CaveOfNecroRand.Checked ? 8 : 0));
            bank3 = ((rad_BaramosCastOff.Checked ? 0 : 0) + (rad_BaramosCastOn.Checked ? 16 : 0) + (rad_BaramosCastRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 19

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_DrgQnCastOff.Checked ? 0 : 0) + (rad_DrgQnCastOn.Checked ? 1 : 0) + (rad_DrgQnCastRand.Checked ? 2 : 0));
            bank2 = ((rad_DisAlefGlitchOff.Checked ? 0 : 0) + (rad_DisAlefGlitchOn.Checked ? 4 : 0) + (rad_DisAlefGlitchRand.Checked ? 8 : 0));
            bank3 = ((rad_CharlockOff.Checked ? 0 : 0) + (rad_CharlockOn.Checked ? 16 : 0) + (rad_CharlockRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 20

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_NoNewTownOff.Checked ? 0 : 0) + (rad_NoNewTownOn.Checked ? 1 : 0) + (rad_NoNewTownRand.Checked ? 2 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 21

            flags += "-"; //22

            // Treasures & Equipment
            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_RandTreasOff.Checked ? 0 : 0) + (rad_RandTreasOn.Checked ? 1 : 0) + (rad_RandTreasRand.Checked ? 2 : 0));
            bank2 = ((rad_OrbDftOff.Checked ? 0 : 0) + (rad_OrbDftOn.Checked ? 4 : 0) + (rad_OrbDftRand.Checked ? 8 : 0));
            bank3 = ((rad_RmRedKeysOff.Checked ? 0 : 0) + (rad_RmRedKeysOn.Checked ? 16 : 0) + (rad_RmRedKeysRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 23

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_AddGoldClawOff.Checked ? 0 : 0) + (rad_AddGoldClawOn.Checked ? 1 : 0) + (rad_AddGoldClawRand.Checked ? 2 : 0));
            bank2 = ((rad_RandEqPwrOff.Checked ? 0 : 0) + (rad_RandEqPwrOn.Checked ? 4 : 0) + (rad_RandEqPwrRand.Checked ? 8 : 0));
            bank3 = ((rad_AdjEqPriceOff.Checked ? 0 : 0) + (rad_AdjEqPriceOn.Checked ? 16 : 0) + (rad_AdjEqPriceRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 24

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_VanEqValOff.Checked ? 0 : 0) + (rad_VanEqValOn.Checked ? 1 : 0) + (rad_VanEqValRand.Checked ? 2 : 0));
            bank2 = ((rad_AddRemakeOff.Checked ? 0 : 0) + (rad_AddRemakeOn.Checked ? 4 : 0) + (rad_AddRemakeRand.Checked ? 8 : 0));
            bank3 = ((rad_RandClassEqOff.Checked ? 0 : 0) + (rad_RandClassEqOn.Checked ? 16 : 0) + (rad_RandClassEqRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); //25

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_RmFightPenOff.Checked ? 0 : 0) + (rad_RmFightPenOn.Checked ? 1 : 0) + (rad_RmFightPenRand.Checked ? 2 : 0));
            bank2 = ((rad_AdjStartEqOff.Checked ? 0 : 0) + (rad_AdjStartEqOn.Checked ? 4 : 0) + (rad_AdjStartEqRand.Checked ? 8 : 0));
            bank3 = 0; // Placeholder for Randomize Item Effects
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); //26

            flags += "-"; // 27

            // Item & Weapon Shops & Inns
            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_RandInnOff.Checked ? 0 : 0) + (rad_RandInnOn.Checked ? 1 : 0) + (rad_RandInnRand.Checked ? 2 : 0));
            bank2 = ((rad_RandWeapShopOff.Checked ? 0 : 0) + (rad_RandWeapShopOn.Checked ? 4 : 0) + (rad_RandWeapShopRand.Checked ? 8 : 0));
            bank3 = ((rad_RandItemShopOff.Checked ? 0 : 0) + (rad_RandItemShopOn.Checked ? 16 : 0) + (rad_RandItemShopRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 28

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_SellUnsellableOff.Checked ? 0 : 0) + (rad_SellUnsellableOn.Checked ? 1 : 0) + (rad_SellUnsellableRand.Checked ? 2 : 0));
            bank2 = ((rad_CaturdayOff.Checked ? 0 : 0) + (rad_CaturdayOn.Checked ? 4 : 0) + (rad_CaturdayRand.Checked ? 8 : 0));
            bank3 = ((rad_AcornsOff.Checked ? 0 : 0) + (rad_AcornsOn.Checked ? 16 : 0) + (rad_AcornsRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); //29

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_StrSeedOff.Checked ? 0 : 0) + (rad_StrSeedOn.Checked ? 1 : 0) + (rad_StrSeedRand.Checked ? 2 : 0));
            bank2 = ((rad_AgiSeedOff.Checked ? 0 : 0) + (rad_AgiSeedOn.Checked ? 4 : 0) + (rad_AgiSeedRand.Checked ? 8 : 0));
            bank3 = ((rad_IntSeedOff.Checked ? 0 : 0) + (rad_IntSeedOn.Checked ? 16 : 0) + (rad_IntSeedRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 30

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_VitSeedOff.Checked ? 0 : 0) + (rad_VitSeedOn.Checked ? 1 : 0) + (rad_VitSeedRand.Checked ? 2 : 0));
            bank2 = ((rad_LucSeedOff.Checked ? 0 : 0) + (rad_LucSeedOn.Checked ? 4 : 0) + (rad_LucSeedRand.Checked ? 8 : 0));
            bank3 = ((rad_WorldTreeOff.Checked ? 0 : 0) + (rad_WorldTreeOn.Checked ? 16 : 0) + (rad_WorldTreeRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 31

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_PoisonMothOff.Checked ? 0 : 0) + (rad_PoisonMothOn.Checked ? 1 : 0) + (rad_PoisonMothRand.Checked ? 2 : 0));
            bank2 = ((rad_StoneOfLifeOff.Checked ? 0 : 0) + (rad_StoneOfLifeOn.Checked ? 4 : 0) + (rad_StoneOfLifeRand.Checked ? 8 : 0));
            bank3 = ((rad_SatoriOff.Checked ? 0 : 0) + (rad_SatoriOn.Checked ? 16 : 0) + (rad_SatoriRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 32

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_MetoriteArmbandOff.Checked ? 0 : 0) + (rad_MetoriteArmbandOn.Checked ? 1 : 0) + (rad_MetoriteArmbandRand.Checked ? 2 : 0));
            bank2 = ((rad_WizardRingOff.Checked ? 0 : 0) + (rad_WizardRingOn.Checked ? 4 : 0) + (rad_WizardRingRand.Checked ? 8 : 0));
            bank3 = ((rad_EchoingFluteOff.Checked ? 0 : 0) + (rad_EchoingFluteOn.Checked ? 16 : 0) + (rad_EchoingFluteRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 33

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_SilverHarpOff.Checked ? 0 : 0) + (rad_SilverHarpOn.Checked ? 1 : 0) + (rad_SilverHarpRand.Checked ? 2 : 0));
            bank2 = ((rad_RingOfLifeOff.Checked ? 0 : 0) + (rad_RingOfLifeOn.Checked ? 4 : 0) + (rad_RingOfLifeRand.Checked ? 8 : 0));
            bank3 = ((rad_ShoesOfHappinessOff.Checked ? 0 : 0) + (rad_ShoesOfHappinessOn.Checked ? 16 : 0) + (rad_ShoesOfHappinessRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 34

            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_LampOfDarknessOff.Checked ? 0 : 0) + (rad_LampOfDarknessOn.Checked ? 1 : 0) + (rad_LampOfDarknessRand.Checked ? 2 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 35

            flags += "-"; // 36
            // Characters
            bank1 = bank2 = bank3 = 0;
            bank1 = ((chk_RandSage.Checked ? 1 : 0));
            bank2 = ((chk_RandHero.Checked ? 4 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 37

            flags += "-"; // 38
            // Fixes
            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_RmParryBugOff.Checked ? 0 : 0) + (rad_RmParryBugOn.Checked ? 1 : 0) + (rad_RmParryBugRand.Checked ? 2 : 0));
            bank2 = ((rad_FixHeroSpellOff.Checked ? 0 : 0) + (rad_FixHeroSpellOn.Checked ? 4 : 0) + (rad_FixHeroSpellRand.Checked ? 8 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 39

            flags += "-"; // 40
            // Cosmetic
            bank1 = bank2 = bank3 = 0;
            bank1 = ((rad_LevelUpTxtOff.Checked ? 0 : 0) + (rad_LevelUpTxtOn.Checked ? 1 : 0) + (rad_LevelUpTxtRand.Checked ? 2 : 0));
            bank2 = ((rad_RandHeroAgeOff.Checked ? 0 : 0) + (rad_RandHeroAgeOn.Checked ? 4 : 0) + (rad_RandHeroAgeRand.Checked ? 8 : 0));
            bank3 = ((rad_GhostToCasketOff.Checked ? 0 : 0) + (rad_GhostToCasketOn.Checked ? 16 : 0) + (rad_GhostToCasketRand.Checked ? 32 : 0));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 41

            txtFlags.Text = flags;
            enableDisableFields(null, null);
        }

        private void btnCopyChecksum_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblNewChecksum.Text);
        }

        private void txtFileName_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void txtFileName_DragDrop(object sender, DragEventArgs e)
        {
            var filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            txtFileName.Text = filePaths[0];
        }

        private void enableDisableFields(object sender, DragEventArgs e)
        {
            if (optSotWFlags.Checked == true)
            {
                this.txtFlags.Text = SotWFlags;
                this.txtFlags.Enabled = false;
                determineChecks(null, null);
            }
            else if (rad_FastVanilla.Checked == true)
            {
                this.txtFlags.Text = quickVanila;
                this.txtFlags.Enabled = false;
                determineChecks(null, null);
            }
            else if (optTradSotWFlags.Checked == true)
            {
                this.txtFlags.Text = TradSotWFlags;
                this.txtFlags.Enabled = false;
                determineChecks(null, null);
            }
            else if (opt_JustForFun.Checked)
            {
                this.txtFlags.Text = jffFlags;
                this.txtFlags.Enabled = false;
                determineChecks(null, null);
            }
            else if (rad_EverythingRand.Checked)
            {
                this.txtFlags.Text = randomFlags;
                this.txtFlags.Enabled = false;
                this.rad_ChName1Rand.Checked = true;
                this.rad_ChName2Rand.Checked = true;
                this.rad_ChName3Rand.Checked = true;
                this.rad_Gender1Rand.Checked = true;
                this.rad_Gender2Rand.Checked = true;
                this.rad_Gender3Rand.Checked = true;
                this.chk_RandSoldier.Checked = true;
                this.chk_RandWizard.Checked = true;
                this.chk_RandPilgrim.Checked = true;
                this.chk_RandFighter.Checked = true;
                this.chk_RandMerchant.Checked = true;
                this.chk_RandGoofOff.Checked = true;
                this.rad_Class1Rand.Checked = true;
                this.rad_Class2Rand.Checked = true;
                this.rad_Class3Rand.Checked = true;
                this.rad_StdCaseRand.Checked = true;
                this.rad_SlimeSnailRand.Checked = true;
                this.rad_FHeroRand.Checked = true;
                this.rad_RandSpriteColRand.Checked = true;
                this.rad_RandNPCRand.Checked = true;
                this.rad_ChCatsRand.Checked = true;
                this.rad_FFightSpriteRand.Checked = true;
                determineChecks(null, null);
            }
            else if (optManualFlags.Checked == true)
            {
                this.txtFlags.Enabled = true;
                determineChecks(null, null);
            }
            if (rad_RandSageStoneOn.Checked || rad_RandSageStoneRand.Checked)
                this.grp_HUAStone.Visible = true;
            else
            {
                this.grp_HUAStone.Visible = false;
                this.rad_HUAStoneOff.Checked = true;
            }
            if (rad_SoHRoLEffOn.Checked || rad_SoHRoLEffRand.Checked)
                this.grp_Big.Visible = true;
            else
            {
                this.grp_Big.Visible = false;
                this.rad_BigOff.Checked = true;
            }
            if (rad_RandMapsOn.Checked || rad_RandMapsRand.Checked)
            {
                this.grp_SmallMap.Visible = true;
                this.grp_RandMonstZone.Visible = true;
                this.grp_Continents.Visible = true;
                this.grp_RmMountains.Visible = true;
                this.grp_DisAlefGlitch.Visible = true;
                this.grp_Charlock.Visible = true;
                this.grp_NoNewTown.Visible = true;
            }
            else
            {
                this.grp_SmallMap.Visible = false;
                this.rad_RandMapsOff.Checked = true;
                this.grp_RandMonstZone.Visible = false;
                this.rad_RandMonstZoneOff.Checked = true;
                this.grp_Continents.Visible = false;
                this.rad_RandTownsOff.Checked = true;
                this.rad_RandCavesOff.Checked = true;
                this.rad_RandShrinesOff.Checked = true;
                this.grp_RmMountains.Visible = false;
                this.rad_LancelCaveOff.Checked = true;
                this.rad_CaveOfNecroOff.Checked = true;
                this.rad_BaramosCastOff.Checked = true;
                this.rad_DrgQnCastOff.Checked = true;
                this.grp_DisAlefGlitch.Visible = false;
                this.rad_DisAlefGlitchOff.Checked = true;
                this.grp_Charlock.Visible = false;
                this.rad_CharlockOff.Checked = true;
                this.grp_NoNewTown.Visible = false;
                this.rad_NoNewTownOff.Checked = true;
            }
            if (rad_RandDropOn.Checked || rad_RandDropRand.Checked)
            {
                this.grp_RmDupDrop.Visible = true;
            }
            else
            {
                this.grp_RmDupDrop.Visible = false;
                this.rad_RmDupDropOff.Checked = true;
            }
            if (this.rad_RandDropOn.Checked || rad_RandDropRand.Checked)
            {
                this.grp_RmDupDrop.Visible = true;
            }
            else
            {
                this.grp_RmDupDrop.Visible = false;
                this.rad_RmDupDropOff.Checked = true;
            }
            if (this.rad_RandTreasOn.Checked || this.rad_RandTreasRand.Checked)
            {
                this.grp_RmRedKeys.Visible = true;
                this.grp_AddGoldClaw.Visible = true;
                this.grp_OrbDft.Visible = true;
            }
            else
            {
                this.grp_RmRedKeys.Visible = false;
                this.rad_RmRedKeysOff.Checked = true;
                this.grp_AddGoldClaw.Visible = false;
                this.rad_AddGoldClawOff.Checked = true;
                this.grp_OrbDft.Visible = false;
                this.rad_OrbDftOff.Checked = true;
            }
            if (this.rad_AddRemakeOn.Checked || this.rad_AddRemakeRand.Checked)
                this.rad_RmFightPenOn.Checked = true;
            if (this.rad_RandItemShopOn.Checked || this.rad_RandItemShopRand.Checked)
                this.grp_AddToItemShop.Visible = true;
            else
            {
                this.grp_AddToItemShop.Visible = false;
                this.rad_AcornsOff.Checked = true;
                this.rad_StrSeedOff.Checked = true;
                this.rad_AgiSeedOff.Checked = true;
                this.rad_VitSeedOff.Checked = true;
                this.rad_IntSeedOff.Checked = true;
                this.rad_LucSeedOff.Checked = true;
                this.rad_WorldTreeOff.Checked = true;
                this.rad_PoisonMothOff.Checked = true;
                this.rad_StoneOfLifeOff.Checked = true;
                this.rad_SatoriOff.Checked = true;
                this.rad_MetoriteArmbandOff.Checked = true;
                this.rad_WizardRingOff.Checked = true;
                this.rad_EchoingFluteOff.Checked = true;
                this.rad_SilverHarpOff.Checked = true;
                this.rad_RingOfLifeOff.Checked = true;
                this.rad_ShoesOfHappinessOff.Checked = true;
                this.rad_LampOfDarknessOff.Checked = true;
            }
            if (rad_ChName1Manual.Checked) this.txt_ChName1.Visible = true;
            else this.txt_ChName1.Visible = false;
            if (rad_ChName2Manual.Checked) this.txt_ChName2.Visible = true;
            else this.txt_ChName2.Visible = false;
            if (rad_ChName3Manual.Checked) this.txt_ChName3.Visible = true;
            else this.txt_ChName3.Visible = false;
            if (rad_Gender1Manual.Checked) this.cbo_Gender1.Visible = true;
            else this.cbo_Gender1.Visible = false;
            if (rad_Gender2Manual.Checked) this.cbo_Gender2.Visible = true;
            else this.cbo_Gender2.Visible = false;
            if (rad_Gender3Manual.Checked) this.cbo_Gender3.Visible = true;
            else this.cbo_Gender3.Visible = false;
            if (rad_Class1Manual.Checked) this.cbo_Class1.Visible = true;
            else cbo_Class1.Visible = false;
            if (rad_Class2Manual.Checked) this.cbo_Class2.Visible = true;
            else cbo_Class2.Visible = false;
            if (rad_Class3Manual.Checked) this.cbo_Class3.Visible = true;
            else cbo_Class3.Visible = false;
        }
    }
}