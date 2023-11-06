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

        readonly string versionNumber = "2.5.4.3";
        readonly string revisionDate = "11/5/2023";
        readonly int buildnumber = 281; // build starting 8/18/23
        readonly string SotWFlags = "A-QLINNDAKMBG-NB-NNABA-EMDB-NNNNNNNB-A-E-N";
        readonly string TradSotWFlags = "A-QLINNDAKMAG-JB-NAABA-BMAB-NNNMNNNB-A-B-D";
        readonly string jffFlags = "A-QLINNNBNNEG-NN-NNNNB-NNNE-NNNMNNNB-E-E-N";
        readonly string randomFlags = "A-JJD######IH-##-####C-###H-#######C-E-I-#";
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

                    string line = reader.ReadLine();
                    switch (line)
                    {
                        case "Checked":
                            tchk_StdCaseMenus.CheckState = CheckState.Checked;
                            break;
                        case "Unchecked":
                            tchk_StdCaseMenus.CheckState = CheckState.Unchecked;
                            break;
                        case "Indeterminate":
                            tchk_StdCaseMenus.CheckState = CheckState.Indeterminate;
                            break;
                    }
                    line = reader.ReadLine();
                    switch (line)
                    {
                        case "Checked":
                            tchk_FixSlimeSnail.CheckState = CheckState.Checked;
                            break;
                        case "Unchecked":
                            tchk_FixSlimeSnail.CheckState = CheckState.Unchecked;
                            break;
                        case "Indeterminate":
                            tchk_FixSlimeSnail.CheckState = CheckState.Indeterminate;
                            break;
                    }
                    line = reader.ReadLine();
                    switch (line)
                    {
                        case "Checked":
                            tchk_RandSpriteColor.CheckState = CheckState.Checked;
                            break;
                        case "Unchecked":
                            tchk_RandSpriteColor.CheckState = CheckState.Unchecked;
                            break;
                        case "Indeterminate":
                            tchk_RandSpriteColor.CheckState = CheckState.Indeterminate;
                            break;
                    }
                    line = reader.ReadLine();
                    switch (line)
                    {
                        case "Checked":
                            tchk_ChangeCats.CheckState = CheckState.Checked;
                            break;
                        case "Unchecked":
                            tchk_ChangeCats.CheckState = CheckState.Unchecked;
                            break;
                        case "Indeterminate":
                            tchk_ChangeCats.CheckState = CheckState.Indeterminate;
                            break;
                    }
                    line = reader.ReadLine();
                    switch (line)
                    {
                        case "Checked":
                            tchk_FixFFighterSprite.CheckState = CheckState.Checked;
                            break;
                        case "Unchecked":
                            tchk_FixFFighterSprite.CheckState = CheckState.Unchecked;
                            break;
                        case "Indeterminate":
                            tchk_FixFFighterSprite.CheckState = CheckState.Indeterminate;
                            break;
                    }
                    line = reader.ReadLine();
                    switch (line)
                    {
                        case "Checked":
                            tchk_RandNPCSprites.CheckState = CheckState.Checked;
                            break;
                        case "Unchecked":
                            tchk_RandNPCSprites.CheckState = CheckState.Unchecked;
                            break;
                        case "Indeterminate":
                            tchk_RandNPCSprites.CheckState = CheckState.Indeterminate;
                            break;
                    }
                    line = reader.ReadLine();
                    switch (line)
                    {
                        case "Checked":
                            tchk_FemaleHero.CheckState = CheckState.Checked;
                            break;
                        case "Unchecked":
                            tchk_FemaleHero.CheckState = CheckState.Unchecked;
                            break;
                        case "Indeterminate":
                            tchk_FemaleHero.CheckState = CheckState.Indeterminate;
                            break;
                    }
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
                if (randomizerTools.GetCheckboxValue(tchk_RmManips) == 1 || (randomizerTools.GetCheckboxValue(tchk_RmManips) == 2 && evalRandTemp == 1))
                    randomizeFunctions.dw4RNG(ref romData);
                boostXP(); // Both boosts Exp and Evaluates Random Exp
                boostGP(); // Both boosts Gold and Evaluates Random Gold
                adjustEncounters();
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_AdjEqPrices) == 1 || (randomizerTools.GetCheckboxValue(tchk_AdjEqPrices) == 2 && evalRandTemp == 1)) 
                    adjustEquipmentPrice = true;
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_SagesStone) == 1 || (randomizerTools.GetCheckboxValue(tchk_SagesStone) == 2 && evalRandTemp == 1))
                    randomizeFunctions.randsagestone(ref romData, ref r1, randomizerTools.GetCheckboxValue(tchk_HUAStone));
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_SoHRoLEff) == 1 || (randomizerTools.GetCheckboxValue(tchk_SoHRoLEff) == 2 && evalRandTemp == 1)) 
                    randomizeFunctions.randshoes(ref romData, ref r1, randomizerTools.GetCheckboxValue(tchk_BigSoHRoL));
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_Cod) == 1 || (randomizerTools.GetCheckboxValue(tchk_Cod) == 2 && evalRandTemp == 1)) 
                    optimizations.cod(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RmHeroSpellGlitch) == 1 || (randomizerTools.GetCheckboxValue(tchk_RmHeroSpellGlitch) == 2 && evalRandTemp == 1)) 
                    bugFixes.fixHeroSpell(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_SpeedUpText) == 1 || (randomizerTools.GetCheckboxValue(tchk_SpeedUpText) == 2 && evalRandTemp == 1)) 
                    optimizations.speedText(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_IncBatSpeed) == 1 || (randomizerTools.GetCheckboxValue(tchk_IncBatSpeed) == 2 && evalRandTemp == 1))
                    optimizations.battleSpeed(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_FourJobFiesta) == 1 || (randomizerTools.GetCheckboxValue(tchk_FourJobFiesta) == 2 && evalRandTemp == 1)) 
                    partyAndJobChange.fourJobFiesta(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_NoOrb) == 1 || (randomizerTools.GetCheckboxValue (tchk_NoOrb) == 2 && evalRandTemp == 1))
                    optimizations.noOrbs(ref romData, out noLamia);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_SpeedUpMenus) == 1 || (randomizerTools.GetCheckboxValue(tchk_SpeedUpMenus) == 2 && evalRandTemp == 1)) 
                    optimizations.speedUpMenus(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RmParryBug) == 1 || (randomizerTools.GetCheckboxValue(tchk_RmParryBug) == 2 && evalRandTemp == 1)) 
                    bugFixes.removeParryFight(ref romData);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_StdCaseMenus) == 1 || (randomizerTools.GetCheckboxValue(tchk_StdCaseMenus) == 2 && evalCosmeticTemp == 1))
                    textchange.lowerCaseMenus(ref romData);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_FixSlimeSnail) == 1|| (randomizerTools.GetCheckboxValue(tchk_FixSlimeSnail) == 2 && evalRandTemp == 1))
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
                if (randomizerTools.GetCheckboxValue(tchk_SmallMaps) == 1|| (randomizerTools.GetCheckboxValue(tchk_SmallMaps) == 2 && evalRandTemp == 1)) 
                    smallMap = true;
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandMaps) == 1|| (randomizerTools.GetCheckboxValue(tchk_RandMaps) == 2 && evalRandTemp == 1)) 
                    maps.randomizeMapv5(ref romData, ref r1, ref randMap, ref map, ref map2, ref island, ref island2, ref zone, ref maxIsland, ref islands, ref maplocs, ref disAlefgardGlitch, debugmode, versionNumber, txtFileName.Text, txtSeed.Text, 
                        txtFlags.Text, smallMap, chk_GenIslandsMonstersZones.Checked, randomizerTools.GetCheckboxValue(tchk_RandTowns), randomizerTools.GetCheckboxValue(tchk_RandCaveTower), randomizerTools.GetCheckboxValue(tchk_RandShrines),
                        randomizerTools.GetCheckboxValue(tchk_RmMountBaramos), randomizerTools.GetCheckboxValue(tchk_RmNoEncounter), randomizerTools.GetCheckboxValue(tchk_RmMoatCharlock), randomizerTools.GetCheckboxValue(tchk_RmMountLancel),
                        randomizerTools.GetCheckboxValue(tchk_RmMountDQC), randomizerTools.GetCheckboxValue(tchk_RmMountNecro), randomizerTools.GetCheckboxValue(tchk_NoNewTown));
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandEnAttPat) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandEnAttPat) == 2 && evalRandTemp == 1)) 
                    monsters.randEnemyPatterns(ref romData, ref r1, randomizerTools.GetCheckboxValue(tchk_RmMetalRun));
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandMonstZones) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandMonstZones) == 2 && evalRandTemp == 1))
                    monsters.randMonsterZones(ref romData, ref r1, monsterOrder);
                evalRandTemp = r1.Next() % 2;
                if ((randomizerTools.GetCheckboxValue(tchk_SellKeyItems) == 2 && evalRandTemp == 1) || randomizerTools.GetCheckboxValue(tchk_SellKeyItems) == 1 )
                    itemsAndequipment.forceItemSell(ref romData, ref r1);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_DispEqPower) == 1 || (randomizerTools.GetCheckboxValue(tchk_DispEqPower) == 2 && evalRandTemp == 1))
                    dispEqPower = true;
                    evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandEqPower) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandEqPower) == 2 && evalRandTemp == 1))
                    itemsAndequipment.randEquip(ref romData, ref r1, randomizerTools.GetCheckboxValue(tchk_RemStartCap), randomizerTools.GetCheckboxValue(tchk_VanEqVals), addRemakeEquip, adjustEquipmentPrice);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_AddRemakeEq) == 1|| (randomizerTools.GetCheckboxValue(tchk_AddRemakeEq) == 2 && evalRandTemp == 1))
                    itemsAndequipment.changeRemakeEq(ref romData, out addRemakeEquip, dispEqPower, adjustEquipmentPrice, randClass); // need to call early because display weapon and armor power is called on tab 1
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RmFigherPen) == 1 || (randomizerTools.GetCheckboxValue(tchk_RmFigherPen) == 2 && evalRandTemp == 1)) 
                    partyStatChange.removeFightPenalty(ref romData);
                if (dispEqPower)
                    textchange.weapArmPower(ref romData, dispEqPower, addRemakeEquip);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandEqClass) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandEqClass) == 2 && evalRandTemp == 1))
                    itemsAndequipment.whoCanEquip(ref romData, ref r1);
                if (randomizerTools.GetCheckboxValue(tchk_RandSpellLearn) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandSpellLearn) == 2 && evalRandTemp == 1))
                    partyAndJobChange.randSpellLearning(ref romData, ref r1, ref heroComSpell, ref heroComLvl, ref heroBatSpell, ref heroBatLvl, ref pilgrimComSpell, ref pilgrimComLvl,
                        ref pilgrimBatSpell, ref pilgrimBatLvl, ref wizardComSpell, ref wizardComLvl, ref wizardBatSpell, ref wizardBatLvl);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandSpellStr) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandSpellStr) == 2 && evalRandTemp == 1)) 
                    randomizeFunctions.randSpellStrength(ref romData, ref r1);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandTreasures) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandTreasures) == 2 && evalRandTemp == 1)) 
                    randomizeFunctions.randTreasures(ref romData, ref r1, disAlefgardGlitch, randomizerTools.GetCheckboxValue(tchk_RmRedKey), randomizerTools.GetCheckboxValue(tchk_AddGoldClaw),
                        randomizerTools.GetCheckboxValue(tchk_GreenSilvOrb), noLamia, randMap);
                bool randstores = false;
                evalRandTemp = r1.Next() % 2;
                evalRandTemp2 = r1.Next() % 2;
                if ((randomizerTools.GetCheckboxValue(tchk_RandItemShop) == 2 && evalRandTemp == 1) || randomizerTools.GetCheckboxValue(tchk_RandItemShop) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandWeapShop) == 2 && evalRandTemp2 == 1) || randomizerTools.GetCheckboxValue(tchk_RandWeapShop) == 1) 
                        randstores = true;
                if (randstores) 
                    randomizeFunctions.randStores(ref romData, ref r1, randomizerTools.GetCheckboxValue(tchk_AcornsOfLife), randomizerTools.GetCheckboxValue(tchk_StrSeed), 
                        randomizerTools.GetCheckboxValue(tchk_AgiSeed), randomizerTools.GetCheckboxValue(tchk_VitSeed), randomizerTools.GetCheckboxValue(tchk_IntSeed), 
                        randomizerTools.GetCheckboxValue(tchk_LuckSeed), randomizerTools.GetCheckboxValue(tchk_LeafOfTheWorldTree), randomizerTools.GetCheckboxValue(tchk_PoisonMothPowder),
                        randomizerTools.GetCheckboxValue(tchk_StoneOfLife), randomizerTools.GetCheckboxValue(tchk_BookOfSatori), randomizerTools.GetCheckboxValue(tchk_MeteoriteArmband),
                        randomizerTools.GetCheckboxValue(tchk_WizardsRing), randomizerTools.GetCheckboxValue(tchk_EchoingFlute), randomizerTools.GetCheckboxValue(tchk_SilverHarp),
                        randomizerTools.GetCheckboxValue(tchk_RingOfLife), randomizerTools.GetCheckboxValue(tchk_ShoesOfHappiness), randomizerTools.GetCheckboxValue(tchk_LampOfDarkness),
                        randomizerTools.GetCheckboxValue(tchk_RandWeapShop), randomizerTools.GetCheckboxValue(tchk_AnimalSuit), randomizerTools.GetCheckboxValue(tchk_RandItemShop), txtSeed.Text);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandInnPrice) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandInnPrice) == 2 && evalRandTemp == 1)) 
                    randomizeFunctions.randomizeInnPrices(ref romData, ref r1);
                evalRandTemp = r1.Next() % 2;
                if (rad_RandStatsSilly.Checked || rad_RandStatsRid.Checked || rad_RandStatsLud.Checked || (rad_RandStatsRand.Checked && evalRandTemp == 1)) 
                    partyStatChange.randStatGains(ref romData, ref r1, rad_RandStatsSilly.Checked, rad_RandStatsRid.Checked, rad_RandStatsLud.Checked, rad_RandStatsRand.Checked);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_FemaleHero) == 1 || (randomizerTools.GetCheckboxValue(tchk_FemaleHero) == 2 && evalRandTemp == 1)) fHero = true;
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandHeroAge) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandHeroAge) == 2 && evalRandTemp == 1)) 
                    spritechange.changeHeroAge(ref romData, ref r1, fHero);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandSpriteColor) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandSpriteColor) == 2 && evalRandTemp == 1))
                    spritechange.randSpriteColors(ref romData, ref randColor, txtSeed.Text);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandStartGold) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandStartGold) == 2 && evalRandTemp == 1))
                    randomizeFunctions.randStartGold(ref romData, ref r1);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_GhostsToCaskets) == 1 || (randomizerTools.GetCheckboxValue(tchk_GhostsToCaskets) == 2 && evalRandTemp == 1))
                    spritechange.changeGhostToCasket(ref romData, txtSeed.Text, randColor);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_ChangeCats) == 1 || (randomizerTools.GetCheckboxValue(tchk_ChangeCats) == 2 && evalCosmeticTemp == 1))
                    spritechange.changeCats(ref romData, txtSeed.Text);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_InvisNPC) == 1 || (randomizerTools.GetCheckboxValue(tchk_InvisNPC) == 2 && evalRandTemp == 1)) 
                   spritechange.invisibleNPCs(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_InvisShipBird) == 1 || (randomizerTools.GetCheckboxValue(tchk_InvisShipBird) == 2 && evalRandTemp == 1)) 
                    spritechange.invisbleShips(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_DoubleAttack) == 1 ||(randomizerTools.GetCheckboxValue(tchk_DoubleAttack) == 2 && evalRandTemp == 1))
                    partyStatChange.doubleattack(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_PartyItems) == 1 || (randomizerTools.GetCheckboxValue(tchk_PartyItems) == 2 && evalRandTemp == 1))
                    itemsAndequipment.heroitems(ref romData, ref r1);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_FixFFighterSprite) == 1 || (randomizerTools.GetCheckboxValue(tchk_FixFFighterSprite) == 2 && evalCosmeticTemp == 1))
                    romData = spritechange.fixFFigherSprite(ref romData);
                evalCosmeticTemp = randomCosmeticIncrement.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_RandNPCSprites) == 1 || (randomizerTools.GetCheckboxValue(tchk_RandNPCSprites) == 2 && evalCosmeticTemp == 1))
                    spritechange.randomNPCSprites(ref romData, txtSeed.Text);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_NonMPJobs) == 1 || (randomizerTools.GetCheckboxValue(tchk_NonMPJobs) == 2 && evalRandTemp == 1))
                    partyStatChange.nonMagicMP(ref romData);
                evalRandTemp = r1.Next() % 2;
                if (randomizerTools.GetCheckboxValue(tchk_ChLevelUpText) == 1 || (randomizerTools.GetCheckboxValue(tchk_ChLevelUpText) == 2 && (randomCosmeticIncrement.Next () % 2 == 1 )))
                    textchange.levelUpText(ref romData);

                // if (chkRandItemEffects.Checked) randItemEffects(rni);

                textchange.changeEnd(ref romData);
                string Descript = lblIntensityDesc.Text;
                string Compare = txtCompare.Text;
                string newChecksum = lblNewChecksum.Text;
                
                romtools.saveRom(true, ref romData, versionNumber, txtFileName.Text, txtSeed.Text, txtFlags.Text, ref Descript, ref Compare, ref newChecksum);
                lblIntensityDesc.Text = Descript;
                txtCompare.Text = Compare;
                lbl_statChecksum.Text = "New Hash:";
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
            randomizerTools randomizerTools = new randomizerTools();
            long adjustmentTab = (rad_ExpGain0.Checked ? 1 : (rad_ExpGain25.Checked ? 2 : (rad_ExpGain50.Checked ? 4 : (rad_ExpGain100.Checked ? 8 : (rad_ExpGain150.Checked ? 16 :
                (rad_ExpGain200.Checked ? 32 : (rad_ExpGain300.Checked ? 64 : (rad_ExpGain400.Checked ? 128 : (rad_ExpGain500.Checked ? 256 : (rad_ExpGain750.Checked ? 512 :
                (rad_ExpGain1000.Checked ? 1024 : (rad_ExpGainRand.Checked ? 2048 : 0))))))))))) + (rad_GoldGain1.Checked ? 4096 : (rad_GoldGain50.Checked ? 8192 : (rad_GoldGain100.Checked ? 16384 :
                (rad_GoldGain150.Checked ? 32768 : (rad_GoldGain200.Checked ? 65536 : (rad_GoldGainRand.Checked ? 131072 : 0)))))));

            long adjustmentTab2 = 3 *
                ((rad_EncRate0.Checked ? 1 : (rad_EncRate25.Checked ? 2 : (rad_EncRate50.Checked ? 4 : (rad_EncRate75.Checked ? 8 : (rad_EncRate100.Checked ? 16 :
                (rad_EncRate150.Checked ? 32 : (rad_EncRate200.Checked ? 64 : (rad_EncRate300.Checked ? 128 : (rad_EncRate400.Checked ? 256 : (rad_EncRateRand.Checked ? 512 : 0)))))))))) +
                (rad_RandStatsSilly.Checked ? 1024 : (rad_RandStatsRid.Checked ? 2048 : (rad_RandStatsLud.Checked ? 4096 : (rad_RandStatsRand.Checked ? 8192 : 0)))) +
                (randomizerTools.GetCheckboxValue(tchk_SpeedUpMenus) == 0 ? 16384 : randomizerTools.GetCheckboxValue(tchk_SpeedUpMenus) == 1 ? 32768 : 65536));

            long adjustmentTab3 = 5 *
                ((randomizerTools.GetCheckboxValue(tchk_RmManips) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_RmManips) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_Cod) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_Cod) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_DispEqPower) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_DispEqPower) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_RandSpellLearn) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_RandSpellLearn) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_RandSpellStr) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_RandSpellStr) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_NonMPJobs) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_NonMPJobs) == 1 ? 65536 : 131072));

            long adjustmentTab4 = 7 *
                ((randomizerTools.GetCheckboxValue(tchk_DoubleAttack) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_DoubleAttack) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_NoOrb) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_NoOrb) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_PartyItems) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_PartyItems) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_FourJobFiesta) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_FourJobFiesta) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_IncBatSpeed) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_IncBatSpeed) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_SpeedUpText) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_SpeedUpText) == 1 ? 65536 : 131072));

            long adjustmentTab5 = 11 *
                ((randomizerTools.GetCheckboxValue(tchk_InvisNPC) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_InvisNPC) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_SagesStone) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_SagesStone) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_HUAStone) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_HUAStone) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_SoHRoLEff) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_SoHRoLEff) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_BigSoHRoL) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_BigSoHRoL) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_InvisShipBird) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_InvisShipBird) == 1 ? 65536 : 131072));

            long mapTab1 = 11 * (
                (randomizerTools.GetCheckboxValue(tchk_RandMaps) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_RandMaps) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_SmallMaps) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_SmallMaps) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_RandMonstZones) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_RandMonstZones) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_RandTowns) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_RandTowns) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_RandCaveTower) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_RandCaveTower) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_RandShrines) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_RandShrines) == 1 ? 65536 : 131072));


            long mapTab2 = 17 * (
                (randomizerTools.GetCheckboxValue(tchk_RmMountLancel) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_RmMountLancel) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_RmMountNecro) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_RmMountNecro) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_RmMountBaramos) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_RmMountBaramos) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_RmMountDQC) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_RmMountDQC) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_RmMoatCharlock) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_RmMoatCharlock) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_NoNewTown) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_NoNewTown) == 1 ? 65536 : 131072) +
                (randomizerTools.GetCheckboxValue(tchk_RmNoEncounter) == 0 ? 262144 : randomizerTools.GetCheckboxValue(tchk_RmNoEncounter) == 1 ? 524288 : 1048576)
                );

            long monstersTab = 19 * (
                (randomizerTools.GetCheckboxValue(tchk_RandExp) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_RandExp) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_RandGold) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_RandGold) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_RandDrops) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_RandDrops) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_RmDupItemPool) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_RmDupItemPool) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_RandEnAttPat) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_RandEnAttPat) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_RmMetalRun) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_RmMetalRun) == 1 ? 65536 : 131072));

            long treasureEquipmentTab1 = 23 * (
                (randomizerTools.GetCheckboxValue(tchk_AddRemakeEq) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_AddRemakeEq) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_RandEqPower) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_RandEqPower) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_VanEqVals) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_VanEqVals) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_RemStartCap) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_RemStartCap) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_RmFigherPen) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_RmFigherPen) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_RandEqClass) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_RandEqClass) == 1 ? 65536 : 131072));

            long treasureEquipmentTab2 = 29 * (
                (randomizerTools.GetCheckboxValue(tchk_AdjEqPrices) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_AdjEqPrices) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_RandTreasures) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_RandTreasures) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_AddGoldClaw) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_AddGoldClaw) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_GreenSilvOrb) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_GreenSilvOrb) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_RmRedKey) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_RmRedKey) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_RandItemEff) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_RandItemEff) == 1 ? 65536 : 131072));

            long itemWeaponShopsInnsTab1 = 31 * (
                (randomizerTools.GetCheckboxValue(tchk_RandItemShop) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_RandItemShop) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_RandWeapShop) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_RandWeapShop) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_RandInnPrice) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_RandInnPrice) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_SellKeyItems) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_SellKeyItems) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_AcornsOfLife) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_AcornsOfLife) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_StrSeed) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_StrSeed) == 1 ? 65536 : 131072));

            long itemWeaponShopsInnsTab2 = 37 * (
                (randomizerTools.GetCheckboxValue(tchk_AgiSeed) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_AgiSeed) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_IntSeed) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_IntSeed) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_VitSeed) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_VitSeed) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_LuckSeed) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_LuckSeed) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_EchoingFlute) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_EchoingFlute) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_SilverHarp) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_SilverHarp) == 1 ? 65536 : 131072));

            long itemWeaponShopsInnsTab3 = 43 * (
                (randomizerTools.GetCheckboxValue(tchk_LampOfDarkness) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_LampOfDarkness) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_MeteoriteArmband) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_MeteoriteArmband) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_RingOfLife) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_RingOfLife) == 1 ? 128 : 256) +
                (randomizerTools.GetCheckboxValue(tchk_ShoesOfHappiness) == 0 ? 512 : randomizerTools.GetCheckboxValue(tchk_ShoesOfHappiness) == 1 ? 1024 : 2048) +
                (randomizerTools.GetCheckboxValue(tchk_LeafOfTheWorldTree) == 0 ? 4096 : randomizerTools.GetCheckboxValue(tchk_LeafOfTheWorldTree) == 1 ? 8192 : 16384) +
                (randomizerTools.GetCheckboxValue(tchk_PoisonMothPowder) == 0 ? 32768 : randomizerTools.GetCheckboxValue(tchk_PoisonMothPowder) == 1 ? 66536 : 131072));

            long itemWeaponShopsInnTab4 = 47 * (
                (randomizerTools.GetCheckboxValue(tchk_StoneOfLife) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_StoneOfLife) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_BookOfSatori) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_BookOfSatori) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_WizardsRing) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_WizardsRing) == 1 ? 128 : 256));

            long fixesTab = 51 * (
                (randomizerTools.GetCheckboxValue(tchk_RmParryBug) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_RmParryBug) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_RmHeroSpellGlitch) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_RmHeroSpellGlitch) == 1 ? 16 : 32));

            long cosmeticTab = 53 * (
                (randomizerTools.GetCheckboxValue(tchk_RandHeroAge) == 0 ? 1 : randomizerTools.GetCheckboxValue(tchk_RandHeroAge) == 1 ? 2 : 4) +
                (randomizerTools.GetCheckboxValue(tchk_ChLevelUpText) == 0 ? 8 : randomizerTools.GetCheckboxValue(tchk_ChLevelUpText) == 1 ? 16 : 32) +
                (randomizerTools.GetCheckboxValue(tchk_GhostsToCaskets) == 0 ? 64 : randomizerTools.GetCheckboxValue(tchk_GhostsToCaskets) == 1 ? 128 : 256));

            long values = 57 * (romData[0x2914f] + (2 * romData[0x134b1]) + (4 * romData[0x330fc]) + (8 * romData[0x279a0 + 3]) + (16 * romData[0x32e3]) + (32 * romData[0x32e3 + (10 * 23) + 9]) +
                (64 * romData[0x2922b]) + (128 * romData[0x279c0]) + (256 * romData[0x290e])); 

            // Starting Gold + First Spell Strength + Shoes Effect Strength + 3rd Weapon Strength + Monster level 1 + Monster 10 Item Dropped +
            // Final Key Shrine Item

            long hashNumber = adjustmentTab + adjustmentTab2 + adjustmentTab3 + adjustmentTab4 + adjustmentTab5 + mapTab1 + mapTab2 + monstersTab + treasureEquipmentTab1 + 
                treasureEquipmentTab2 + itemWeaponShopsInnsTab1 + itemWeaponShopsInnsTab2 + itemWeaponShopsInnsTab3 + fixesTab + cosmeticTab + values;

            string hashString = hashNumber.ToString("X");
            hashString = hashString.ToLower();
            lblHash.Text = hashString;
        }

        private void boostGP()
        {
            randomizerTools randomizerTools = new randomizerTools();
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
                if (randomizerTools.GetCheckboxValue(tchk_RandGold) == 1 || ((r1.Next() % 2 == 1) && randomizerTools.GetCheckboxValue(tchk_RandGold) == 2))
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
            randomizerTools randomizerTools = new randomizerTools();

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
                if (randomizerTools.GetCheckboxValue(tchk_RandExp) == 1 || ((r1.Next() % 2 == 1) && randomizerTools.GetCheckboxValue(tchk_RandExp) == 2))
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

        private void btn_SaveSettings_Click(object sender, EventArgs e)
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

                    writer.WriteLine(tchk_StdCaseMenus.CheckState);
                    writer.WriteLine(tchk_FixSlimeSnail.CheckState);
                    writer.WriteLine(tchk_RandSpriteColor.CheckState);

                    writer.WriteLine(tchk_ChangeCats.CheckState);
                    writer.WriteLine(tchk_FixFFighterSprite.CheckState);
                    writer.WriteLine(tchk_RandNPCSprites.CheckState);
                    writer.WriteLine(tchk_FemaleHero.CheckState);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
 
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
            if (bank1 == 0) tchk_IncBatSpeed.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_IncBatSpeed.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_IncBatSpeed.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_SpeedUpText.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_SpeedUpText.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_SpeedUpText.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_SpeedUpMenus.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_SpeedUpMenus.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_SpeedUpMenus.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(6, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RmManips.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RmManips.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RmManips.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RandStartGold.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RandStartGold.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RandStartGold.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_Cod.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_Cod.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_Cod.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(7, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_NoOrb.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_NoOrb.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_NoOrb.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_DispEqPower.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_DispEqPower.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_DispEqPower.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_DoubleAttack.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_DoubleAttack.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_DoubleAttack.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(8, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_PartyItems.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_PartyItems.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_PartyItems.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_InvisShipBird.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_InvisShipBird.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_InvisShipBird.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_InvisNPC.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_InvisNPC.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_InvisNPC.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(9, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_SagesStone.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_SagesStone.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_SagesStone.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_HUAStone.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_HUAStone.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_HUAStone.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_SoHRoLEff.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_SoHRoLEff.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_SoHRoLEff.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(10, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_BigSoHRoL.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_BigSoHRoL.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_BigSoHRoL.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RandSpellLearn.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RandSpellLearn.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RandSpellLearn.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RandSpellStr.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RandSpellStr.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RandSpellStr.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(11, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_NonMPJobs.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_NonMPJobs.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_NonMPJobs.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_FourJobFiesta.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_FourJobFiesta.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_FourJobFiesta.CheckState = CheckState.Indeterminate;

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
            if (bank1 == 0) tchk_RandExp.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RandExp.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RandExp.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RandGold.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RandGold.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RandGold.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RandDrops.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RandDrops.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RandDrops.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(15, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RandEnAttPat.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RandEnAttPat.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RandEnAttPat.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RmDupItemPool.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RmDupItemPool.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RmDupItemPool.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RmMetalRun.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RmMetalRun.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RmMetalRun.CheckState = CheckState.Indeterminate;

            // - 16

            // Map
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(17, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RandMaps.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RandMaps.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RandMaps.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_SmallMaps.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_SmallMaps.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_SmallMaps.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RandMonstZones.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RandMonstZones.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RandMonstZones.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(18, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RandTowns.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RandTowns.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RandTowns.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RandCaveTower.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RandCaveTower.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RandCaveTower.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RandShrines.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RandShrines.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RandShrines.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(19, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RmMountLancel.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RmMountLancel.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RmMountLancel.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RmMountNecro.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RmMountNecro.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RmMountNecro.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RmMountBaramos.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RmMountBaramos.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RmMountBaramos.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(20, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RmMountDQC.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RmMountDQC.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RmMountDQC.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RmNoEncounter.CheckState = CheckState.Unchecked;   
            else if (bank2 == 1) tchk_RmNoEncounter.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RmNoEncounter.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RmMoatCharlock.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RmMoatCharlock.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RmMoatCharlock.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(21, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_NoNewTown.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_NoNewTown.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_NoNewTown.CheckState = CheckState.Indeterminate;

            // - 22

            // Treasures & Equipment
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(23, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RandTreasures.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RandTreasures.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RandTreasures.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_GreenSilvOrb.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_GreenSilvOrb.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_GreenSilvOrb.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RmRedKey.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RmRedKey.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RmRedKey.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(24, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_AddGoldClaw.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_AddGoldClaw.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_AddGoldClaw.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RandEqPower.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RandEqPower.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RandEqPower.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_AdjEqPrices.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_AdjEqPrices.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_AdjEqPrices.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(25, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_VanEqVals.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_VanEqVals.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_VanEqVals.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_AddRemakeEq.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_AddRemakeEq.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_AddRemakeEq.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RandEqClass.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RandEqClass.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RandEqClass.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(26, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RmFigherPen.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RmFigherPen.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RmFigherPen.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RemStartCap.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RemStartCap.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RemStartCap.CheckState = CheckState.Indeterminate;
            // Random Item Effects are off for now.
            tchk_RandItemEff.CheckState = CheckState.Unchecked;

            // - 27

            // Item & Weapon Shops & Inns
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(28, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_RandInnPrice.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RandInnPrice.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RandInnPrice.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RandWeapShop.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RandWeapShop.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RandWeapShop.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_RandItemShop.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_RandItemShop.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_RandItemShop.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(29, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_SellKeyItems.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_SellKeyItems.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_SellKeyItems.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_AnimalSuit.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_AnimalSuit.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_AnimalSuit.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_AcornsOfLife.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_AcornsOfLife.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_AcornsOfLife.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(30, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_StrSeed.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_StrSeed.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_StrSeed.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_AgiSeed.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_AgiSeed.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_AgiSeed.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_IntSeed.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_IntSeed.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_IntSeed.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(31, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_VitSeed.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_VitSeed.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_VitSeed.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_LuckSeed.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_LuckSeed.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_LuckSeed.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_LeafOfTheWorldTree.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_LeafOfTheWorldTree.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_LeafOfTheWorldTree.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(32, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_PoisonMothPowder.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_PoisonMothPowder.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_PoisonMothPowder.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_StoneOfLife.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_StoneOfLife.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_StoneOfLife.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_BookOfSatori.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_BookOfSatori.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_BookOfSatori.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(33, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_MeteoriteArmband.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_MeteoriteArmband.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_MeteoriteArmband.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_WizardsRing.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_WizardsRing.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_WizardsRing.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_EchoingFlute.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_EchoingFlute.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_EchoingFlute.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(34, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_SilverHarp.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_SilverHarp.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_SilverHarp.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RingOfLife.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RingOfLife.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RingOfLife.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_ShoesOfHappiness.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_ShoesOfHappiness.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_ShoesOfHappiness.CheckState = CheckState.Indeterminate;

            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(35, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_LampOfDarkness.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_LampOfDarkness.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_LampOfDarkness.CheckState = CheckState.Indeterminate;
            
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
            if (bank1 == 0) tchk_RmParryBug.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_RmParryBug.CheckState = CheckState.Checked;
            else if (bank1 == 2) tchk_RmParryBug.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RmHeroSpellGlitch.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RmHeroSpellGlitch.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RmHeroSpellGlitch.CheckState = CheckState.Indeterminate;

            // - 40

            // Cosmetic
            number = flagscalc.convertChartoIntCapsOnlyForFlags(Convert.ToChar(flags.Substring(41, 1)));
            flagscalc.determineChecksBanks(out bank1, out bank2, out bank3, number);
            if (bank1 == 0) tchk_ChLevelUpText.CheckState = CheckState.Unchecked;
            else if (bank1 == 1) tchk_ChLevelUpText.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_ChLevelUpText.CheckState = CheckState.Indeterminate;
            if (bank2 == 0) tchk_RandHeroAge.CheckState = CheckState.Unchecked;
            else if (bank2 == 1) tchk_RandHeroAge.CheckState = CheckState.Checked;
            else if (bank2 == 2) tchk_RandHeroAge.CheckState = CheckState.Indeterminate;
            if (bank3 == 0) tchk_GhostsToCaskets.CheckState = CheckState.Unchecked;
            else if (bank3 == 1) tchk_GhostsToCaskets.CheckState = CheckState.Checked;
            else if (bank3 == 2) tchk_GhostsToCaskets.CheckState = CheckState.Indeterminate;
        }

        private void determineFlags(object sender, EventArgs e)
        {
            if (loading) return;

            flagscalc flagscalc = new flagscalc();
            randomizerTools randomizerTools = new randomizerTools();

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
            bank1 = randomizerTools.GetCheckboxValue(tchk_IncBatSpeed);
            bank2 = 4 * (randomizerTools.GetCheckboxValue(tchk_SpeedUpText));
            bank3 = 16 * (randomizerTools.GetCheckboxValue(tchk_SpeedUpMenus));
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 5

            bank1 = bank2 = bank3 = 0;
            bank1 += randomizerTools.GetCheckboxValue(tchk_RmManips);
            bank2 += 4 * randomizerTools.GetCheckboxValue(tchk_RandStartGold);
            bank3 += 16 * randomizerTools.GetCheckboxValue(tchk_Cod);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 6

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_NoOrb);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_DispEqPower);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_DoubleAttack);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 7

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_PartyItems);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_InvisShipBird);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_InvisNPC);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 8

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_SagesStone);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_HUAStone);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_SoHRoLEff);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 9

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_BigSoHRoL);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RandSpellLearn);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RandSpellStr);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 10

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_NonMPJobs);
            bank2 = 4 * (randomizerTools.GetCheckboxValue(tchk_FourJobFiesta));
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
            bank1 = randomizerTools.GetCheckboxValue(tchk_RandExp);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RandGold);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RandDrops);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 14

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_RandEnAttPat);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RmDupItemPool);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RmMetalRun);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 15

            flags += "-"; //16

            // Map
            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_RandMaps);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_SmallMaps);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RandMonstZones);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 17

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_RandTowns);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RandCaveTower);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RandShrines);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 18

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_RmMountLancel);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RmMountNecro);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RmMountBaramos);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 19

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_RmMountDQC);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RmNoEncounter);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RmMoatCharlock);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 20

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_NoNewTown);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 21

            flags += "-"; //22

            // Treasures & Equipment
            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_RandTreasures);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_GreenSilvOrb);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RmRedKey);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 23

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_AddGoldClaw);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RandEqPower);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_AdjEqPrices);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 24

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_VanEqVals);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_AddRemakeEq);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RandEqClass);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); //25

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_RmFigherPen);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RemStartCap);
            bank3 = 0; // Placeholder for Randomize Item Effects
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); //26

            flags += "-"; // 27

            // Item & Weapon Shops & Inns
            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_RandInnPrice);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RandWeapShop);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_RandItemShop);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 28

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_SellKeyItems);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_AnimalSuit);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_AcornsOfLife);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); //29

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_StrSeed);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_AgiSeed);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_IntSeed);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 30

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_VitSeed);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_LuckSeed);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_LeafOfTheWorldTree);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 31

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_PoisonMothPowder);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_StoneOfLife);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_BookOfSatori);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 32

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_MeteoriteArmband);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_WizardsRing);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_EchoingFlute);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 33

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_SilverHarp);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RingOfLife);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_ShoesOfHappiness);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 34

            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_LampOfDarkness);
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
            bank1 = randomizerTools.GetCheckboxValue(tchk_RmParryBug);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RmHeroSpellGlitch);
            flags += flagscalc.convertIntToCharCapsOnlyForFlags(bank1 + bank2 + bank3); // 39

            flags += "-"; // 40
            // Cosmetic
            bank1 = bank2 = bank3 = 0;
            bank1 = randomizerTools.GetCheckboxValue(tchk_ChLevelUpText);
            bank2 = 4 * randomizerTools.GetCheckboxValue(tchk_RandHeroAge);
            bank3 = 16 * randomizerTools.GetCheckboxValue(tchk_GhostsToCaskets);
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
            randomizerTools randomizerTools = new randomizerTools();
            
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
                this.tchk_StdCaseMenus.CheckState = CheckState.Indeterminate;
                this.tchk_FixSlimeSnail.CheckState = CheckState.Indeterminate;
                this.tchk_FemaleHero.CheckState = CheckState.Indeterminate;
                this.tchk_RandSpriteColor.CheckState = CheckState.Indeterminate;
                this.tchk_RandNPCSprites.CheckState = CheckState.Indeterminate;
                this.tchk_ChangeCats.CheckState = CheckState.Indeterminate;
                this.tchk_FixFFighterSprite.CheckState = CheckState.Indeterminate;
                determineChecks(null, null);
            }
            else if (optManualFlags.Checked == true)
            {
                this.txtFlags.Enabled = true;
                determineChecks(null, null);
            }
            if (randomizerTools.GetCheckboxValue(this.tchk_SagesStone) > 0) // Checked or indeterminate
                this.tchk_HUAStone.Visible = true;
            else
            {
                this.tchk_HUAStone.Visible = false;
                this.tchk_HUAStone.CheckState = CheckState.Unchecked;
            }
            if (randomizerTools.GetCheckboxValue(this.tchk_SoHRoLEff) > 0)
                this.tchk_BigSoHRoL.Visible = true;
            else
            {
                this.tchk_BigSoHRoL.Visible = false;
                this.tchk_BigSoHRoL.CheckState = CheckState.Unchecked;
            }
            if (randomizerTools.GetCheckboxValue(this.tchk_RandMaps) > 0)
            {
                this.tchk_SmallMaps.Visible = true;
                this.tchk_RandMonstZones.Visible = true;
                this.tchk_RandCaveTower.Visible = true;
                this.tchk_RandShrines.Visible = true;
                this.tchk_RandTowns.Visible = true;
                this.tchk_RmMountDQC.Visible = true;
                this.tchk_RmNoEncounter.Visible = true;
                this.tchk_RmMoatCharlock.Visible = true;
                this.tchk_NoNewTown.Visible = true;
                this.tchk_RmMountLancel.Visible = true;
                this.tchk_RmMountNecro.Visible = true;
                this.tchk_RmMountBaramos.Visible = true;
            }
            else
            {
                this.tchk_SmallMaps.Visible = false;
                this.tchk_SmallMaps.CheckState = CheckState.Unchecked;
                this.tchk_RandMonstZones.Visible = false;
                this.tchk_RandMonstZones.CheckState = CheckState.Unchecked;
                this.tchk_RandTowns.Visible = false;
                this.tchk_RandTowns.CheckState = CheckState.Unchecked;
                this.tchk_RandCaveTower.Visible = false;
                this.tchk_RandCaveTower.CheckState = CheckState.Unchecked;
                this.tchk_RandShrines.Visible = false;
                this.tchk_RandShrines.CheckState = CheckState.Unchecked;
                this.tchk_RmMountLancel.Visible = false;
                this.tchk_RmMountLancel.CheckState = CheckState.Unchecked;
                this.tchk_RmMountNecro.Visible = false;
                this.tchk_RmMountNecro.CheckState = CheckState.Unchecked;
                this.tchk_RmMountBaramos.Visible = false;
                this.tchk_RmMountBaramos.CheckState = CheckState.Unchecked;
                this.tchk_RmMountDQC.Visible = false;
                this.tchk_RmMountDQC.CheckState = CheckState.Unchecked;
                this.tchk_RmNoEncounter.Visible = false;
                this.tchk_RmNoEncounter.CheckState = CheckState.Unchecked;
                this.tchk_RmMoatCharlock.Visible = false;
                this.tchk_RmMoatCharlock.CheckState = CheckState.Unchecked;
                this.tchk_NoNewTown.Visible = false;
                this.tchk_NoNewTown.CheckState = CheckState.Unchecked;
            }
            if (randomizerTools.GetCheckboxValue(this.tchk_RandDrops) > 0)
            {
                this.tchk_RmDupItemPool.Visible = true;
            }
            else
            {
                this.tchk_RmDupItemPool.Visible = false;
                this.tchk_RmDupItemPool.CheckState = CheckState.Unchecked;
            }
            if (randomizerTools.GetCheckboxValue(this.tchk_RandTreasures) > 0)
            {
                this.tchk_RmRedKey.Visible = true;
                this.tchk_AddGoldClaw.Visible = true;
                this.tchk_GreenSilvOrb.Visible = true;
            }
            else
            {
                this.tchk_RmRedKey.Visible = false;
                this.tchk_RmRedKey.CheckState = CheckState.Unchecked;
                this.tchk_AddGoldClaw.Visible = false;
                this.tchk_AddGoldClaw.CheckState = CheckState.Unchecked;
                this.tchk_GreenSilvOrb.Visible = false;
                this.tchk_GreenSilvOrb.CheckState = CheckState.Unchecked;
            }
            if (randomizerTools.GetCheckboxValue(this.tchk_AddRemakeEq) > 0)
                this.tchk_RmFigherPen.CheckState = CheckState.Checked;
            if (randomizerTools.GetCheckboxValue(this.tchk_RandItemShop) > 0)
                this.grp_AddToItemShop.Visible = true;
            else
            {
                this.grp_AddToItemShop.Visible = false;
                this.tchk_AcornsOfLife.CheckState = CheckState.Unchecked;
                this.tchk_StrSeed.CheckState = CheckState.Unchecked;
                this.tchk_AgiSeed.CheckState = CheckState.Unchecked;
                this.tchk_VitSeed.CheckState = CheckState.Unchecked;
                this.tchk_IntSeed.CheckState = CheckState.Unchecked;
                this.tchk_LuckSeed.CheckState = CheckState.Unchecked;
                this.tchk_LeafOfTheWorldTree.CheckState = CheckState.Unchecked;
                this.tchk_PoisonMothPowder.CheckState = CheckState.Unchecked;
                this.tchk_StoneOfLife.CheckState = CheckState.Unchecked;
                this.tchk_BookOfSatori.CheckState = CheckState.Unchecked;
                this.tchk_MeteoriteArmband.CheckState = CheckState.Unchecked;
                this.tchk_WizardsRing.CheckState = CheckState.Unchecked;
                this.tchk_EchoingFlute.CheckState = CheckState.Unchecked;
                this.tchk_SilverHarp.CheckState = CheckState.Unchecked;
                this.tchk_RingOfLife.CheckState = CheckState.Unchecked;
                this.tchk_ShoesOfHappiness.CheckState = CheckState.Unchecked;
                this.tchk_LampOfDarkness.CheckState = CheckState.Unchecked;
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