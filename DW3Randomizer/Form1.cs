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

namespace DW3Randomizer
{
    public partial class Form1 : Form
    {
        string versionNumber = "2.4.5d";
        string revisionDate = "7/9/2023";
        string SotWFlags = "ACHMHDMBLABJEBODPPPBADB";
        string endyFlags = "ACGMHDPBLACLJDODPPPBADB";

        bool loading = true;
        byte[] romData;
        byte[] romData2;
        byte[] monsterOrder = { 0x00, 0x01, 0x68, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e,
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
        int[,] island = new int[256, 256];
        int[,] island2 = new int[139, 158];
        int[,] zone = new int[16, 16];
        int[] maxIsland = new int[4];
        List<int> islands = new List<int>();
        int[] heroComSpell, pilgrimComSpell, wizardComSpell, heroComLvl, pilgrimComLvl, wizardComLvl, heroBatSpell, pilgrimBatSpell, wizardBatSpell, heroBatLvl, pilgrimBatLvl, wizardBatLvl;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Dragon Warrior III Randomizer ~ " + versionNumber + " ~ " + revisionDate;
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
                        lblSHAChecksum.Text = BitConverter.ToString(md5.ComputeHash(stream)).ToLower().Replace("-", ""); }
                }
            } catch
            {
                lblSHAChecksum.Text = "????????????????????????????????????????";
            }
        }

        private void runHash()
        {
            int adjustmentTab = cboExpGains.SelectedIndex + (2 * cboGoldReq.SelectedIndex) + (4 * cboEncounterRate.SelectedIndex) +
                (8 * (chkFasterBattles.Checked ? 1 : 0)) + (16 * (chkSpeedText.Checked ? 1 : 0)) + (32 * (chk_SpeedUpMenus.Checked ? 1 : 0)) +
                (64 * (chk_Cod.Checked ? 1 : 0)) + (128 * (chk_RmManip.Checked ? 1 : 0)) + (256 * (chk_WeapArmPower.Checked ? 1 : 0)) +
                (512 * (chkNoLamiaOrbs.Checked ? 1 : 0)) + (1024 * (chk_RandomStartGold.Checked ? 1 : 0) + (2048 * (chk_InvisibleNPCs.Checked ? 1 : 0))) +
                (4096 * (chk_InvisibleShips.Checked ? 1 : 0));

            int mapTab = (chkRandomizeMap.Checked ? 1 : 0) + (2 * (chkRandMonsterZones.Checked ? 1 : 0)) + (4 * (chkSmallMap.Checked ? 1 : 0)) +
                (8 * (chk_RemoveMtnDrgQueen.Checked ? 1 : 0)) + (16 * (chk_SepBarGaia.Checked ? 1 : 0)) + (32 * (chk_RemLancelMountains.Checked ? 1 : 0)) +
                (64 * (chk_RmMtnNecrogond.Checked ? 1 : 0)) + (128 * (chk_RemoveBirdRequirement.Checked ? 1 : 0)) +
                (256 * (chk_lbtoCharlock.Checked ? 1 : 0)) + (512 * (chk_RmNewTown.Checked ? 1 : 0));

            int monstersTab = (optMonsterHeavy.Checked ? 1 : optMonsterLight.Checked ? 2 : optMonsterMedium.Checked ? 4 : optMonsterSilly.Checked ? 8 : 0) +
                (16 * (chkRandomizeXP.Checked ? 1 : 0)) + (32 * (chkRandomizeGP.Checked ? 1 : 0)) + (64 * (chkRandEnemyPatterns.Checked ? 1 : 0)) +
                (128 * (chk_RemMetalMonRun.Checked ? 1 : 0) + (256 * (chk_AdjustEqpPrices.Checked ? 1 : 0)));

            int treasureEquipmentTab = (chkRandTreasures.Checked ? 1 : 0) + (2 * (chk_GoldenClaw.Checked ? 1 : 0)) + (4 * (chkRandWhoCanEquip.Checked ? 1 : 0)) +
                (8 * (chkRandEquip.Checked ? 1 : 0)) + (16 * (chk_UseVanEquipValues.Checked ? 1 : 0)) + (32 * (chk_RemoveStartEqRestrictions.Checked ? 1 : 0)) +
                (64 * (chk_RmFighterPenalty.Checked ? 1 : 0)) + (128 * (chk_GreenSilverOrb.Checked ? 1 : 0));

            int itemWeaponShopsInsTab = (chkRandItemStores.Checked ? 1 : 0) + (2 * (chk_RandomizeWeaponShops.Checked ? 1 : 0)) + (4 * (chk_Caturday.Checked ? 1 : 0)) +
                (8 * (chk_RandomizeInnPrices.Checked ? 1 : 0)) + (16 * (chk_StoneofLife.Checked ? 1 : 0)) + (32 * (chk_Seeds.Checked ? 1 : 0)) +
                (64 * (chk_BookofSatori.Checked ? 1 : 0)) + (128 * (chk_RingofLife.Checked ? 1 : 0)) + (256 * (chk_EchoingFlute.Checked ? 1 : 0)) +
                (512 * (chk_SilverHarp.Checked ? 1 : 0)) + (1024 * (chk_LeafoftheWorldTree.Checked ? 1 : 0)) + (2048 * (chk_ShoesofHappiness.Checked ? 1 : 0)) +
                (4096 * (chk_MeteoriteArmband.Checked ? 1 : 0)) + (8192 * (chk_WizardsRing.Checked ? 1 : 0)) + (16384 * (chk_LampofDarkness.Checked ? 1 : 0)) +
                (32768 * (chk_PoisonMothPowder.Checked ? 1 : 0));

            int charactersTab = (chkRandStatGains.Checked ? 1 : 0) + (2 * (chkRandSpellLearning.Checked ? 1 : 0)) + (4 * (chkRandSpellStrength.Checked ? 1 : 0)) +
                (8 * (chkFourJobFiesta.Checked ? 1 : 0));

            int fixesTab = (chkRemoveParryFight.Checked ? 1 : 0);

            int values = (int)romData[0x3d126] + (10 * (int)romData[0x123b1 + 10]) + (100 * (int)romData[0x134f9]) + (1000 * (int)romData[0x2a15]) +
                (int)romData[0x2a54] + (10 * (int)romData[0x281b + 10]) + (100 * (int)romData[0x281b + 11]) + (1000 * (int)romData[0x367c1 + 10]) +
                (int)romData[0x36862] + (10 * (int)romData[0x368e2]) + (100 * (int)romData[0x1147 + 10]) + (1000 * (int)romData[0x279a0]) +
                (int)romData[0x11be + 10] + (10 * (int)romData[0x2925a]) + (100 * (int)romData[0x2922b]) + (1000 * (int)romData[0x292c2]) +
                (int)romData[0x2914f] + (10 * (int)romData[0x32e3 + (230)]) + (100 * (int)romData[0x32e3 + 480]) + (1000 * (int)romData[0x32e3 + 10]);

            int hashNumber = adjustmentTab + (2 * mapTab) + (3 * monstersTab) + (4 * treasureEquipmentTab) + (5 * itemWeaponShopsInsTab) +
                (6 * charactersTab) + (7 * fixesTab) + values;

            string hashString = hashNumber.ToString();
            lblHash.Text = hashString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();

            try
            {
                using (TextReader reader = File.OpenText("lastFile.txt"))
                {
                    txtFileName.Text = reader.ReadLine();
                    txtFlags.Text = reader.ReadLine();
                    determineChecks(null, null);
                    if (reader.ReadLine() == "True")
                    {
                        chk_ChangeDefaultParty.Checked = true;
                    }
                    else
                    {
                        chk_ChangeDefaultParty.Checked = false;
                    }
                    if (reader.ReadLine() == "True")
                    {
                        chk_RandomName.Checked = true;
                    }
                    else
                    {
                        chk_RandomName.Checked = false;
                    }
                    if (reader.ReadLine() == "True")
                    {
                        chk_RandomGender.Checked = true;
                    }
                    else
                    {
                        chk_RandomGender.Checked = false;
                    }
                    txtCharName1.Text = reader.ReadLine();
                    txtCharName2.Text = reader.ReadLine();
                    txtCharName3.Text = reader.ReadLine();
                    cboClass1.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cboClass2.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cboClass3.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cboGender1.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cboGender2.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    cboGender3.SelectedIndex = Convert.ToInt32(reader.ReadLine());
                    if (reader.ReadLine() == "True") // Sets Lower Case Menus
                        chk_LowerCaseMenus.Checked = true;
                    else
                        chk_LowerCaseMenus.Checked = false;
                    if (reader.ReadLine() == "True") // Sets Fix Slime Snail Name
                        chk_FixSlimeSnail.Checked = true;
                    else
                        chk_FixSlimeSnail.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_ChangeHeroAge.Checked = true;
                    else
                        chk_ChangeHeroAge.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_RandSpriteColor.Checked = true;
                    else
                        chk_RandSpriteColor.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_GhostToCasket.Checked = true;
                    else
                        chk_GhostToCasket.Checked = false;
                    if (reader.ReadLine() == "True")
                        chk_changeCats.Checked = true;
                    else
                        chk_changeCats.Checked = false;
                    runChecksum();
                }
            }
            catch
            {
                // ignore error
                txtCharName1.Text = "Ragnar";
                txtCharName2.Text = "Cristo";
                txtCharName3.Text = "Mara";
                cboClass1.SelectedIndex = 0;
                cboClass2.SelectedIndex = 1;
                cboClass3.SelectedIndex = 2;
                cboGender1.SelectedIndex = 0;
                cboGender2.SelectedIndex = 0;
                cboGender3.SelectedIndex = 1;
                cboEncounterRate.SelectedIndex = 4;
                cboExpGains.SelectedIndex = 5;
                cboGoldReq.SelectedIndex = 0;
                chk_LowerCaseMenus.Checked = false;
                chk_FixSlimeSnail.Checked = false;
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
            int rni = 0; //Random Number Increment
            Random r1 = new Random(int.Parse(txtSeed.Text));

            // Randomize how many steps up rni is increased if GenCompareFile is checked
            /*
            if (chk_GenCompareFile.Checked)
            {
                for (int lnI = 0; lnI < (r1.Next() % 20) + 1; lnI++)
                {
                    rni++;
                }
            }
            */
            if (lblSHAChecksum.Text != lblReqChecksum.Text)
            {
                if (MessageBox.Show("The checksum of the ROM does not match the required checksum.  Patch anyway?", "Checksum mismatch", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            if (!loadRom())
                return;
            if (txtSeed.Text == "output")
            {
                textOutput();
                return;
            }
            else if (txtSeed.Text == "textGet")
            {
                textGet();
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

                if (chk_RmManip.Checked) dw4RNG();
                //superRandomize();
                boostGP();
                boostXP();
                adjustEncounters();
                if (chk_Cod.Checked) cod();
                if (chkSpeedText.Checked) speedText();
                if (chkFasterBattles.Checked) battleSpeed();
                if (chkFourJobFiesta.Checked) fourJobFiesta();
                if (chkNoLamiaOrbs.Checked) noOrbs();
                if (chk_SpeedUpMenus.Checked) speedUpMenus();
                if (chkRemoveParryFight.Checked) removeParryFight();
                if (chk_LowerCaseMenus.Checked) lowerCaseMenus();
                if (chk_FixSlimeSnail.Checked) slimeSnail();
                if (chk_ChangeDefaultParty.Checked)
                {
                    if (chk_RandomGender.Checked) randomizeGender();
                    if (chk_RandomName.Checked) randomizeNames();
                    if (chk_RandomClass.Checked) randomizeClass();
                    chngDftParty();
                }
                if (chkRandomizeMap.Checked) randomizeMapv5(rni);
                if (chkRandEnemyPatterns.Checked) randEnemyPatterns(rni);
                if (chkRandMonsterZones.Checked) randMonsterZones(rni);
                if (chk_sellUnsellItems.Checked) forceItemSell(rni);
                if (chkRandItemEffects.Checked) randItemEffects(rni);
                if (chkRandEquip.Checked) randEquip(rni);
                if (chk_RmFighterPenalty.Checked) removeFightPenalty();
                if (chk_WeapArmPower.Checked) weapArmPower();
                if (chkRandSpellLearning.Checked) randSpellLearning(rni);
                if (chkRandSpellStrength.Checked) randSpellStrength(rni);
                if (chkRandTreasures.Checked) randTreasures(rni);
                if (chkRandItemStores.Checked) randStores(rni);
                if (chk_RandomizeInnPrices.Checked) randomizeInnPrices(rni);
                if (chkRandStatGains.Checked) randStatGains(rni);
                if (chk_ChangeHeroAge.Checked) changeHeroAge(rni);
                if (chk_RandSpriteColor.Checked) randSpriteColors(rni);
                if (chk_RandomStartGold.Checked) randStartGold();
                if (chk_GhostToCasket.Checked) changeGhostToCasket(rni);
                if (chk_changeCats.Checked) changeCats(rni);
                if (chk_InvisibleNPCs.Checked) invisibleNPCs();
                if (chk_InvisibleShips.Checked) invisbleShips();
                changeEnd();
                saveRom(true);
                saveRom(false);
                createGuides();
                runHash();

            }
        }

        private void dw4RNG()
        {
            // Implement DW4 RNG so any currently known manipulations won't work.

            romData[0x3c351] = romData[0x7c351] = 0xAD;
            romData[0x3c352] = romData[0x7c352] = 0xd2;
            romData[0x3c353] = romData[0x7c353] = 0x06;
            romData[0x3c354] = romData[0x7c354] = 0x4c;
            romData[0x3c355] = romData[0x7c355] = 0x53;
            romData[0x3c356] = romData[0x7c356] = 0xc3;
            romData[0x3c357] = romData[0x7c357] = 0xf0;
            romData[0x3c358] = romData[0x7c358] = 0xfb;
            romData[0x3c359] = romData[0x7c359] = 0x4c;
            romData[0x3c35a] = romData[0x7c35a] = 0x0a;
            romData[0x3c35b] = romData[0x7c35b] = 0xc9;
            romData[0x3c35c] = romData[0x7c35c] = 0x20;
            romData[0x3c35d] = romData[0x7c35d] = 0x41;
            romData[0x3c35e] = romData[0x7c35e] = 0xc3;
            romData[0x3c35f] = romData[0x7c35f] = 0xca;
            romData[0x3c360] = romData[0x7c360] = 0xd0;
            romData[0x3c361] = romData[0x7c361] = 0xfa;
            romData[0x3c362] = romData[0x7c362] = 0x60;
            romData[0x3c363] = romData[0x7c363] = 0xe6;
            romData[0x3c364] = romData[0x7c364] = 0x1c;
            romData[0x3c365] = romData[0x7c365] = 0xcd;
            romData[0x3c366] = romData[0x7c366] = 0xd2;
            romData[0x3c367] = romData[0x7c367] = 0x06;
            romData[0x3c368] = romData[0x7c368] = 0x4c;
            romData[0x3c369] = romData[0x7c369] = 0x47;
            romData[0x3c36a] = romData[0x7c36a] = 0xc3;
        }

        private void noOrbs()
        {
            // Allows getting Lamia without orbs

            romData[0x3794b] = 0xea;
            romData[0x3794c] = 0xea;
        }

        private void fourJobFiesta()
        {
            // Allow hero to leave the party
            romData[0x36dcf] = 0x4c;
            romData[0x36dd0] = 0xd0;
            romData[0x36dd1] = 0xad;

            // Allow hero to change classes
            romData[0x36c4c] = 0x4c;
            romData[0x36c4d] = 0x44;
            romData[0x36c4e] = 0xac;

            // Allow all heroes to change into a sage
            romData[0x36ccd] = 0x4c;
            romData[0x36cce] = 0xd8;
            romData[0x36ccf] = 0xac;
        }

        private void speedUpMenus()
        {
            // Speed up item menu loading
            romData[0x2b0d] = 0x00;
            romData[0x2b0e] = 0xf0;
            romData[0x2b0f] = 0x01;
            romData[0x2b10] = 0x00;
        }

        private void removeParryFight()
        {
            byte[] parryFightFix1 = { 0xbd, 0x9b, 0x6a, 0x29, 0xdf, 0x9d, 0x9b, 0x6a, 0x60 };
            byte[] parryFightFix2 = { 0x20, 0x70, 0xbb };
            for (int lnI = 0; lnI < parryFightFix1.Length; lnI++)
                romData[0xbb80 + lnI] = parryFightFix1[lnI];
            for (int lnI = 0; lnI < parryFightFix2.Length; lnI++)
                romData[0xa402 + lnI] = parryFightFix2[lnI];
        }

        private void slimeSnail()
        {
            romData[0xb5f7] = 0x16; // Slime Snaii > Slime Snail
        }

        private void cod()
        {
            // All ROM hacks will revive ALL characters on a ColdAsACod.
            // There will be a temporary graphical error if you use less than four characters, but I'm going to leave it be.
            byte[] codData1 = { 0xa0, 0x00, // Make sure Y is 0 first.
                0xb9, 0x3c, 0x07,
                0xc9, 0x80,
                0x90, 0x03, // If less than 0x80, skip.
                0x20, 0xb2, 0xbf, // JSR to a bunch of unused code, which will have the "revive one character code" that I'm replacing.
                0xc8, 0xc8, // Increment Y twice (Y is used to revive the characters)
                0xc0, 0x08, // Compare Y with 08
                0xd0, 0xf0, // If not equal, go back to the JSR mentioned above
                0xa0, 0x00, // Set Y back to 0 to make sure the game doesn't think something is up
                0xea, 0xea, 0xea, 0xea, 0xea,
                0xea, 0xea, 0xea, 0xea, 0xea,
                0xea, 0xea }; // 12 NOPs, since I have nothing else to do.
            byte[] codData2 = { 0xa9, 0x80, // Load 80, the status for alive
                0x99, 0x3c, 0x07, // store to two status bytes
                0x99, 0x3d, 0x07,
                0xb9, 0x24, 0x07, // Load max HP
                0x99, 0x1c, 0x07, // save max HP
                0xb9, 0x25, 0x07, // second byte
                0x99, 0x1d, 0x07,
                0xb9, 0x34, 0x07, // Load max MP
                0x99, 0x2c, 0x07, // save max MP
                0xb9, 0x35, 0x07, // second byte
                0x99, 0x2d, 0x07,
                0x60 }; // end JSR

            for (int lnI = 0; lnI < codData1.Length; lnI++)
                romData[0x22b3 + lnI] = codData1[lnI];
            for (int lnI = 0; lnI < codData2.Length; lnI++)
                romData[0x3fc2 + lnI] = codData2[lnI];

            romData[0x3cc6a] = 0x4c; // Forces a jump out of the king scolding routine, saving at least 13 seconds / party wipe.  There are graphical errors, but I'll take it!
        }

        private void battleSpeed()
        {
            romData[0x13a65] = 0x01;
            romData[0x13a66] = 0x04;
            romData[0x13a67] = 0x08;
            romData[0x13a68] = 0x0c;
            romData[0x13a69] = 0x10;
            romData[0x13a6a] = 0x18;
            romData[0x13a6b] = 0x20;
            romData[0x852] = 2; // instead of 16 - animation of transition into battle removed, saving 14 frames / start of battle.
            romData[0x8ce] = 1; // instead of 12 - flashes to start a battle, saving 11 frames / start of battle.
            romData[0x980d] = 1; // instead of 8 - Magic spell flashing, saving 7 or 14 frames / spell casted
            romData[0x9827] = 0xea; // NEXT 3 LINES:  1 flash -> 0 flashes
            romData[0x9828] = 0xea;
            romData[0x9829] = 0xea;
            romData[0x9882] = 2; // instead of 12 - Frames of shaking when YOU are hit... saving 10 frames / hit
            romData[0x9957] = 1; // Instead of 4 enemy flashes, saving at least 6 frames / hit... probably 12 or even 24 frames / hit.
        }

        private void speedText()
        {
            romData[0x3a783] = 0x20;
            romData[0x3a784] = 0xbd;
            romData[0x3a785] = 0xbf;

            romData[0x3a9c7] = 0x90;
            romData[0x3a9c8] = 0x1d;
            romData[0x3a9c9] = 0xa6;
            romData[0x3a9ca] = 0x78;
            romData[0x3a9cb] = 0xf0;
            romData[0x3a9cc] = 0x06;

            byte[] speedText = { 0xad, 0xd0, 0x6a, 0xf0, 0x03, 0x00, 0x96, 0x2f, 0x20, 0xba, 0xc2, 0xa9, 0x02, 0x8d, 0xd6, 0x06, 0x20, 0x41, 0xc3, 0xa9, 0x00, 0x8d, 0xd6, 0x06, 0x4c, 0x5f, 0xaa };
            for (int i = 0; i < speedText.Length; i++)
                romData[0x3bfcd + i] = speedText[i];
        }

        private void changeCats(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            int index = r1.Next() % 10;

            byte[] dogSprite = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x1F, 0x1F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x1C, 0x18,
                                 0x00, 0x00, 0x00, 0x00, 0x00, 0xE0, 0xF8, 0xF8, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE0, 0x38, 0x18,
                                 0x1F, 0x3E, 0x3E, 0x3F, 0x3F, 0x1F, 0x0F, 0x17, 0x10, 0x23, 0x23, 0x21, 0x20, 0x13, 0x09, 0x19,
                                 0x38, 0x7C, 0x7C, 0xFC, 0xFC, 0xCC, 0x48, 0x30, 0xC8, 0xC4, 0xC4, 0x84, 0x24, 0xF4, 0x78, 0x30,
                                 0x00, 0x00, 0x00, 0x03, 0x07, 0x0F, 0x1F, 0x1F, 0x00, 0x00, 0x00, 0x03, 0x04, 0x0B, 0x14, 0x1A,
                                 0x00, 0x00, 0xC0, 0x20, 0xF0, 0xF8, 0xF8, 0xF8, 0x00, 0x00, 0xC0, 0xE0, 0x10, 0xC8, 0x28, 0x58,
                                 0x3F, 0x3D, 0x3C, 0x3C, 0x3E, 0x1F, 0x12, 0x0C, 0x3A, 0x33, 0x23, 0x27, 0x27, 0x13, 0x1E, 0x0C,
                                 0xFC, 0xBC, 0x3C, 0x3C, 0x78, 0xF0, 0xF0, 0x88, 0x5C, 0xCC, 0xC4, 0xE4, 0xC8, 0xD0, 0x90, 0xF8,
                                 0x00, 0x00, 0x00, 0x00, 0x00, 0x3E, 0x7F, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3E, 0x4F, 0x57,
                                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x70,
                                 0x9F, 0x1F, 0x8F, 0x7F, 0x0F, 0x07, 0x03, 0x02, 0xF7, 0xE7, 0xF0, 0x78, 0x08, 0x04, 0x02, 0x03,
                                 0xFC, 0xFA, 0xF9, 0xFD, 0xFE, 0xF8, 0xF0, 0x20, 0x8C, 0x0E, 0x0F, 0x07, 0x06, 0x88, 0x90, 0xE0,
                                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x81, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x81,
                                 0x9F, 0x0F, 0xCF, 0x5F, 0x2F, 0x0F, 0x1F, 0x3C, 0xF3, 0xF1, 0xF0, 0x78, 0x28, 0x08, 0x13, 0x24,
                                 0xFE, 0xFC, 0xFD, 0xFE, 0xFF, 0xFF, 0x0D, 0x05, 0xFF, 0x87, 0x07, 0x02, 0x01, 0xF1, 0x0F, 0x07 };

            byte[] yetiSprite = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0B, 0x07, 0x1F, 0x0F, 0x1F, 0x1F, 0x3F, 0x7F,
                                  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xD0, 0xE0, 0xF8, 0xF0, 0xF8, 0xF8, 0xFC, 0xFE,
                                  0x00, 0x00, 0x00, 0x60, 0x60, 0x00, 0x00, 0x00, 0x7F, 0xFF, 0xFF, 0xFF, 0x7F, 0x1F, 0x0F, 0x00,
                                  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE0, 0x50, 0xFF, 0xFF, 0xFE, 0xFC, 0xFC, 0xF8, 0xF0, 0x50,
                                  0x00, 0x00, 0x00, 0x02, 0x05, 0x02, 0x00, 0x06, 0x0B, 0x07, 0x1F, 0x0F, 0x1F, 0x1F, 0x3F, 0x7F,
                                  0x00, 0x00, 0x00, 0x40, 0xA0, 0x40, 0x00, 0x60, 0xD0, 0xE0, 0xF8, 0xF0, 0xF8, 0xF8, 0xFC, 0xFE,
                                  0x07, 0x63, 0x63, 0x03, 0x01, 0x00, 0x00, 0x00, 0xFF, 0xFE, 0x7E, 0x3E, 0x3F, 0x1F, 0x0F, 0x00,
                                  0xE0, 0xC0, 0xC0, 0xC6, 0x86, 0x00, 0xE0, 0x50, 0xFE, 0x7F, 0x7F, 0x7F, 0xFE, 0xF8, 0xF0, 0x50,
                                  0x00, 0x00, 0x00, 0x0C, 0x06, 0x0C, 0x00, 0x0C, 0x03, 0x07, 0x0F, 0x0F, 0x0F, 0x1F, 0x1F, 0x3F,
                                  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE8, 0xF0, 0xFC, 0xF8, 0xFC, 0xF8, 0xFC, 0xFE,
                                  0x3C, 0x38, 0x70, 0x70, 0x60, 0x00, 0x07, 0x1F, 0x3F, 0x0F, 0x1F, 0x1F, 0x7F, 0x1F, 0x0F, 0x1F,
                                  0x00, 0x00, 0x18, 0x18, 0x00, 0x00, 0x00, 0x80, 0xFF, 0xFF, 0xFF, 0xFE, 0xFC, 0xFC, 0xF8, 0x80,
                                  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE8, 0xF0, 0xFC, 0xF8, 0xFC, 0xF8, 0xFC, 0xFE,
                                  0x3C, 0x38, 0x70, 0x70, 0x60, 0x00, 0x00, 0x00, 0x3F, 0x0F, 0x1F, 0x1F, 0x7F, 0x1F, 0x0F, 0x00,
                                  0x60, 0x60, 0x00, 0x00, 0x00, 0x00, 0x38, 0xFC, 0xFF, 0xFF, 0xFF, 0xFF, 0xFE, 0xFE, 0xFC, 0xFC };

            byte[] tigerSprite = { 0x37, 0x3F, 0x3F, 0x1F, 0x3F, 0x3F, 0x3F, 0x1F, 0x37, 0x29, 0x29, 0x11, 0x2E, 0x31, 0x2E, 0x1B,
                                   0xEC, 0xFC, 0xFC, 0xF8, 0xFC, 0xFC, 0xFC, 0xF8, 0xEC, 0x94, 0x94, 0x88, 0x74, 0x8C, 0x74, 0xD8,
                                   0x7F, 0xFF, 0xFF, 0xFF, 0xFF, 0x3F, 0x1E, 0x00, 0x6F, 0x82, 0xFF, 0xA2, 0xF7, 0x23, 0x1E, 0x00,
                                   0xFF, 0xFF, 0xFF, 0xFC, 0xFC, 0xFC, 0xFC, 0xFC, 0xFF, 0x45, 0xFF, 0x44, 0xEC, 0xC4, 0x84, 0xFC,
                                   0x37, 0x3F, 0x3F, 0x1C, 0x31, 0x33, 0x3D, 0x1B, 0x37, 0x2E, 0x29, 0x17, 0x2F, 0x3F, 0x2F, 0x1F,
                                   0xEC, 0xFC, 0xFC, 0x38, 0x8C, 0xCC, 0xBC, 0xD8, 0xEC, 0x74, 0x94, 0xE8, 0xF4, 0xFC, 0xF4, 0xF8,
                                   0xFB, 0xFC, 0xFB, 0x38, 0x3C, 0x3D, 0x1E, 0x00, 0xFF, 0x97, 0xF7, 0x27, 0x33, 0x23, 0x1E, 0x00,
                                   0xDE, 0x3F, 0xDF, 0x1F, 0x3F, 0xBE, 0xFC, 0xFC, 0xF6, 0xE1, 0xEF, 0xE5, 0xC9, 0xCE, 0x84, 0xFC,
                                   0x0F, 0x7F, 0x7F, 0x03, 0x01, 0x19, 0x0F, 0x3B, 0x0F, 0x76, 0x63, 0x7C, 0x3F, 0x1F, 0x0E, 0x3C,
                                   0xD8, 0xF8, 0xF8, 0xF0, 0xF8, 0xFC, 0xFC, 0xF8, 0xD8, 0x48, 0xA8, 0x30, 0xD8, 0x94, 0x64, 0x38,
                                   0x7B, 0x67, 0x7F, 0x47, 0x4F, 0x4F, 0x3E, 0x3E, 0x7D, 0x5B, 0x71, 0x7F, 0x71, 0x7F, 0x22, 0x3E,
                                   0xF0, 0xFB, 0xFB, 0xFF, 0xFC, 0xF8, 0xC0, 0x00, 0x30, 0x2B, 0xAB, 0x3D, 0xB4, 0xB8, 0xC0, 0x00,
                                   0xD8, 0xF8, 0xF8, 0xF0, 0xF8, 0xFC, 0xFC, 0xF8, 0xD8, 0x48, 0xA8, 0x30, 0xD8, 0x94, 0x64, 0x38,
                                   0x1F, 0x27, 0x3F, 0x47, 0x4F, 0x4F, 0x3C, 0x00, 0x1C, 0x3E, 0x33, 0x7F, 0x70, 0x77, 0x3C, 0x00,
                                   0xF3, 0xFB, 0xFF, 0xFE, 0xFC, 0xF8, 0xF8, 0xF8, 0x33, 0x6B, 0xFD, 0x8A, 0x3C, 0x88, 0x98, 0xF8 };

            byte[] puppySprite = { 0x00, 0x0C, 0x1F, 0x1F, 0x1F, 0x07, 0x07, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00,
                                   0x00, 0x30, 0xF8, 0xF8, 0xF8, 0xE0, 0xE0, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00,
                                   0x0F, 0x0F, 0x07, 0x0F, 0x1F, 0x1F, 0x1B, 0x38, 0x03, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0xE0, 0xF4, 0xFC, 0xF8, 0xF8, 0xFC, 0xEC, 0x00, 0xE0, 0x14, 0x0C, 0xD8, 0x70, 0x00, 0x00, 0x00,
                                   0x00, 0x0C, 0x1F, 0x1F, 0x1F, 0x05, 0x05, 0x0F, 0x00, 0x00, 0x00, 0x04, 0x0C, 0x02, 0x02, 0x00,
                                   0x00, 0x30, 0xF8, 0xF8, 0xF8, 0xA0, 0xA0, 0xF0, 0x00, 0x00, 0x00, 0x20, 0x30, 0x40, 0x40, 0x00,
                                   0x0E, 0x2F, 0x3F, 0x1F, 0x1F, 0x1F, 0x1B, 0x38, 0x01, 0x20, 0x38, 0x17, 0x00, 0x00, 0x00, 0x00,
                                   0x70, 0xF0, 0xF0, 0xF8, 0xF8, 0xFC, 0xEC, 0x00, 0x80, 0x00, 0x10, 0xE0, 0x00, 0x00, 0x00, 0x00,
                                   0x00, 0x03, 0x03, 0x07, 0x1F, 0x17, 0x77, 0xFF, 0x00, 0x00, 0x01, 0x01, 0x00, 0x08, 0x08, 0x00,
                                   0x00, 0x00, 0x80, 0x80, 0x80, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00,
                                   0x7F, 0xFF, 0x7F, 0x07, 0x07, 0x03, 0x03, 0x01, 0x80, 0x01, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0xF8, 0xFE, 0xFF, 0xFD, 0xFC, 0x1C, 0xB8, 0xB0, 0x80, 0x02, 0x03, 0x01, 0x00, 0x00, 0x00, 0x00,
                                   0x00, 0x00, 0x80, 0x80, 0x80, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00,
                                   0x7F, 0xFF, 0x7F, 0x07, 0x0F, 0x0D, 0x1C, 0x18, 0x80, 0x01, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0xF9, 0xFF, 0xFE, 0xFC, 0xFC, 0xFE, 0x1E, 0x06, 0x81, 0x03, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00 };

            byte[] foxSprite = { 0x00, 0x00, 0x00, 0x03, 0x07, 0x07, 0x0F, 0x1F, 0x00, 0x00, 0x00, 0x02, 0x06, 0x06, 0x0F, 0x1F,
                                 0x00, 0x00, 0x00, 0x40, 0xE0, 0xE0, 0xF0, 0xF8, 0x00, 0x00, 0x00, 0x40, 0x60, 0x60, 0xF0, 0xF8,
                                 0x0F, 0x03, 0x07, 0x0F, 0x0F, 0x06, 0x03, 0x07, 0x0F, 0x03, 0x07, 0x0F, 0x0F, 0x06, 0x03, 0x01,
                                 0xF0, 0xC0, 0xF0, 0xF8, 0xF8, 0x30, 0x30, 0x00, 0xF0, 0xC0, 0xF0, 0xF8, 0xF8, 0x00, 0x00, 0x00,
                                 0x00, 0x00, 0x02, 0x06, 0x06, 0x07, 0x0D, 0x1D, 0x00, 0x00, 0x02, 0x04, 0x04, 0x07, 0x0F, 0x1F,
                                 0x00, 0x00, 0x40, 0x60, 0x60, 0xE0, 0xB0, 0xB8, 0x00, 0x00, 0x40, 0x20, 0x20, 0xE0, 0xF0, 0xF8,
                                 0x0F, 0x03, 0x07, 0x0F, 0x0F, 0x06, 0x03, 0x07, 0x0C, 0x01, 0x06, 0x0F, 0x0F, 0x06, 0x03, 0x00,
                                 0xF0, 0xC0, 0xE0, 0xF0, 0xF0, 0x30, 0x60, 0x00, 0x30, 0x80, 0x60, 0xF0, 0xF0, 0x30, 0x00, 0x00,
                                 0x00, 0x00, 0x08, 0x0C, 0x0C, 0x1E, 0xAF, 0xEF, 0x00, 0x00, 0x08, 0x04, 0x04, 0x1E, 0x3F, 0xFF,
                                 0x00, 0x00, 0x00, 0x00, 0x01, 0x03, 0x03, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03,
                                 0x7F, 0x3F, 0x07, 0x03, 0x03, 0x01, 0x00, 0x01, 0x0F, 0x07, 0x07, 0x03, 0x03, 0x01, 0x00, 0x00,
                                 0xC7, 0xF7, 0xFF, 0xFE, 0xF8, 0xB0, 0x90, 0xB0, 0xC7, 0xF7, 0xFF, 0xFE, 0xF8, 0xB0, 0x00, 0x00,
                                 0x00, 0x00, 0x00, 0x02, 0x06, 0x06, 0x06, 0x0E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x0E,
                                 0x7F, 0x1F, 0x17, 0x03, 0x03, 0x03, 0x06, 0x0C, 0x0F, 0x07, 0x07, 0x03, 0x03, 0x03, 0x00, 0x00,
                                 0x0E, 0xFE, 0xFE, 0xFC, 0xF8, 0x18, 0x04, 0x0C, 0x0E, 0xFE, 0xFE, 0xFC, 0xF8, 0x18, 0x00, 0x00 };

            byte[] dw4CatSprite = { 0x00, 0x00, 0x00, 0x02, 0x06, 0x07, 0x0F, 0x1F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
                                    0x00, 0x00, 0x00, 0x40, 0x60, 0xE0, 0xF0, 0xF8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00,
                                    0x0F, 0x07, 0x0F, 0x1F, 0x1F, 0x0C, 0x0C, 0x00, 0x03, 0x04, 0x02, 0x04, 0x00, 0x00, 0x00, 0x00,
                                    0xF0, 0xC0, 0xE0, 0xF0, 0xF0, 0x60, 0xC0, 0xE0, 0xC0, 0x00, 0xC0, 0x20, 0x00, 0x00, 0x00, 0x00,
                                    0x00, 0x00, 0x00, 0x02, 0x06, 0x07, 0x0D, 0x1D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x02, 0x0A,
                                    0x00, 0x00, 0x00, 0x40, 0x60, 0xE0, 0xB0, 0xB8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x40, 0x50,
                                    0x0E, 0x03, 0x07, 0x0F, 0x0F, 0x06, 0x03, 0x07, 0x01, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00,
                                    0x70, 0xC0, 0xE0, 0xF0, 0xF0, 0x30, 0x60, 0x00, 0x80, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00,
                                    0x00, 0x00, 0x00, 0x08, 0x0C, 0x1E, 0x0F, 0x2F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x16, 0x50,
                                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                    0x7F, 0x3F, 0x07, 0x03, 0x03, 0x03, 0x06, 0x0C, 0x0D, 0x02, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00,
                                    0x06, 0xF1, 0xF9, 0xFE, 0xF8, 0x18, 0x04, 0x0C, 0x00, 0xA0, 0xA0, 0xA0, 0x00, 0x00, 0x00, 0x00,
                                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                    0x7F, 0x3F, 0x07, 0x03, 0x03, 0x01, 0x00, 0x01, 0x0D, 0x02, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00,
                                    0xC0, 0xF6, 0xF9, 0xFE, 0xF8, 0xB0, 0x90, 0xB0, 0x40, 0x50, 0x90, 0x20, 0x00, 0x00, 0x00, 0x00 };

            byte[] lionSprite = { 0x00, 0x00, 0x00, 0x00, 0x30, 0x38, 0x10, 0x18, 0x27, 0x3F, 0x1F, 0x7F, 0x7F, 0x7F, 0x7F, 0x3F,
                                  0x00, 0x00, 0x00, 0x00, 0x0C, 0x1C, 0x08, 0x18, 0xE4, 0xFC, 0xF8, 0xFE, 0xFE, 0xFE, 0xFE, 0xFC,
                                  0x30, 0x58, 0x5A, 0x5F, 0x18, 0x1E, 0x00, 0x00, 0x7F, 0xFF, 0xFF, 0xFF, 0xFF, 0x3F, 0x1E, 0x00,
                                  0x00, 0x14, 0x50, 0xF0, 0x30, 0xF0, 0xF0, 0x00, 0xFE, 0xFE, 0xFE, 0xF8, 0xF8, 0xF8, 0xF8, 0xF8,
                                  0x00, 0x00, 0x06, 0x01, 0x2A, 0x0B, 0x05, 0x0E, 0x27, 0x3F, 0x1F, 0x6F, 0x7D, 0x3C, 0x7F, 0x5F,
                                  0x00, 0x00, 0x60, 0x80, 0x54, 0xD0, 0xA0, 0x70, 0xE4, 0xFC, 0xF8, 0xF6, 0xBE, 0x3C, 0xFE, 0xFA,
                                  0x0F, 0x66, 0x6A, 0x1C, 0x1F, 0x1E, 0x00, 0x00, 0x7F, 0xFF, 0xFD, 0x7F, 0x3F, 0x3F, 0x1E, 0x00,
                                  0xF0, 0x64, 0x54, 0x2C, 0xEC, 0xF0, 0xF0, 0x00, 0xFC, 0xFE, 0xBE, 0xFE, 0xFE, 0xFC, 0xF8, 0xF8,
                                  0x00, 0x00, 0x00, 0x0C, 0x12, 0x05, 0x2D, 0x33, 0x07, 0x0F, 0x0F, 0x0F, 0x1F, 0x1B, 0x73, 0x7C,
                                  0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x1C, 0x0C, 0xEC, 0xF9, 0xFE, 0xFD, 0xFE, 0xFC, 0xFE, 0xFE,
                                  0x7F, 0x3E, 0x20, 0x07, 0x0F, 0x0F, 0x07, 0x00, 0x78, 0x21, 0x1F, 0x0F, 0x1F, 0x1F, 0x0F, 0x0F,
                                  0x04, 0x68, 0xEC, 0x6C, 0x6C, 0x18, 0x00, 0x00, 0xFE, 0xFC, 0xFE, 0xFE, 0xFE, 0xFC, 0xBC, 0x80,
                                  0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x1C, 0x0C, 0xEC, 0xF9, 0xFE, 0xFD, 0xFE, 0xFC, 0xFE, 0xFE,
                                  0x7D, 0x3D, 0x20, 0x06, 0x0F, 0x0F, 0x00, 0x00, 0x7B, 0x23, 0x1F, 0x0F, 0x1F, 0x1F, 0x0F, 0x00,
                                  0x84, 0xE8, 0xEC, 0x1C, 0xFC, 0x3C, 0x38, 0x00, 0xFE, 0xFC, 0xFE, 0xFE, 0xFE, 0xFE, 0x7C, 0x7C };

            byte[] dinoSprite = { 0x30, 0x1B, 0x1B, 0x1D, 0x0D, 0x0E, 0x06, 0x07, 0x7B, 0x3F, 0x2F, 0x2F, 0x17, 0x17, 0x0B, 0x1B,
                                  0x00, 0x60, 0xF0, 0x70, 0x78, 0xF8, 0xF8, 0x7E, 0xE0, 0xF0, 0xF8, 0xF8, 0xFC, 0xFC, 0xFE, 0xFF,
                                  0x17, 0x3B, 0x6B, 0x7D, 0x1F, 0x0C, 0x1C, 0x00, 0x39, 0x7C, 0xFC, 0xFE, 0x7E, 0x1F, 0x3E, 0x3C,
                                  0xBE, 0xD8, 0xE8, 0xE8, 0xDC, 0xDC, 0x30, 0x3C, 0xFF, 0xFE, 0x7C, 0x7C, 0x3E, 0x3E, 0xFC, 0x7E,
                                  0x60, 0x36, 0x2F, 0x2E, 0x1E, 0x1B, 0x0F, 0x05, 0xF7, 0x7F, 0x7F, 0x7F, 0x33, 0x37, 0x7F, 0x1F,
                                  0x00, 0xC0, 0xE0, 0xE0, 0xF0, 0xB0, 0xE0, 0x40, 0xC0, 0xE0, 0xF0, 0xF0, 0x98, 0xD8, 0xF0, 0xF8,
                                  0x7B, 0x1C, 0x1F, 0x3F, 0x3F, 0x1B, 0x38, 0x00, 0xFF, 0x7F, 0x3C, 0x78, 0x78, 0x3C, 0x7F, 0x78,
                                  0xB8, 0x7C, 0xF6, 0xF6, 0xF8, 0xB8, 0x60, 0x78, 0xFC, 0xFE, 0x7F, 0x3F, 0x3E, 0x7C, 0xF8, 0xFC,
                                  0x00, 0x1E, 0x3D, 0x37, 0x3F, 0x7F, 0xB9, 0xF5, 0x1E, 0x3F, 0x67, 0x6F, 0x7F, 0xE3, 0xC7, 0xCF,
                                  0x03, 0x06, 0x06, 0x8E, 0x8E, 0x8E, 0x0E, 0x0E, 0x06, 0x0D, 0x8D, 0xDD, 0xDD, 0xDD, 0x9D, 0xDD,
                                  0xFB, 0x16, 0x0D, 0x08, 0x0B, 0x07, 0x06, 0x1E, 0x9F, 0xFB, 0x17, 0x17, 0x17, 0x0F, 0x1F, 0x3F,
                                  0xDE, 0xBE, 0xBE, 0x7C, 0xD8, 0x60, 0xE0, 0x00, 0xFD, 0xFD, 0xFD, 0xFA, 0xE4, 0xF8, 0xF0, 0xE0,
                                  0x03, 0x06, 0x06, 0x8E, 0x8E, 0x8E, 0x0E, 0x0E, 0x06, 0x0D, 0x8D, 0xDD, 0xDD, 0xDD, 0x9D, 0xDD,
                                  0xE6, 0x03, 0x0C, 0x0B, 0x0B, 0x07, 0x01, 0x0F, 0x9F, 0xFF, 0x17, 0x17, 0x17, 0x0F, 0x0F, 0x1F,
                                  0xDE, 0xFE, 0xFE, 0x7C, 0xD8, 0x80, 0x80, 0x80, 0xFD, 0xFD, 0xFD, 0xFA, 0xE4, 0xF8, 0xC0, 0xC0 };

            byte[] gbaAniSprite = { 0x00, 0x10, 0x1A, 0x04, 0x0E, 0x04, 0x08, 0x06, 0x30, 0x3B, 0x2F, 0x1F, 0x1F, 0x1F, 0x1F, 0x1F,
                                    0x00, 0x08, 0x58, 0x20, 0x70, 0x20, 0x10, 0x60, 0x0C, 0xDC, 0xF4, 0xFC, 0xF8, 0xF8, 0xF8, 0xF8, 
                                    0x1C, 0x7E, 0x28, 0x0E, 0x08, 0x0E, 0x0E, 0x06, 0x7F, 0xBF, 0xFF, 0x3F, 0x1F, 0x1F, 0x1F, 0x09, 
                                    0x38, 0x3C, 0x5C, 0x50, 0x50, 0xB0, 0x60, 0x00, 0xFC, 0xFE, 0xBA, 0xFE, 0xF8, 0xF8, 0xF0, 0xE0, 
                                    0x00, 0x20, 0x34, 0x08, 0x1C, 0x08, 0x1B, 0x0C, 0x60, 0x77, 0x5F, 0x3F, 0x3F, 0x3F, 0x3F, 0x3B,
                                    0x00, 0x10, 0xB0, 0x40, 0xE0, 0x40, 0x60, 0xC0, 0x18, 0xB8, 0xE8, 0xF0, 0xF0, 0xF0, 0xF0, 0x70, 
                                    0x27, 0x78, 0x6B, 0x1C, 0x1F, 0x1F, 0x0D, 0x00, 0x78, 0xFF, 0xB4, 0xF3, 0x30, 0x38, 0x1F, 0x0F, 
                                    0x90, 0x7C, 0x68, 0xE0, 0xE0, 0xE0, 0xE0, 0xC0, 0x7C, 0xFA, 0xBC, 0x38, 0x30, 0x70, 0xF0, 0x20, 
                                    0x00, 0x00, 0x02, 0x05, 0x0F, 0x0F, 0x1E, 0x0F, 0x00, 0x07, 0x0F, 0x1F, 0x1F, 0x3F, 0x3F, 0x33, 
                                    0x00, 0x40, 0xC0, 0x80, 0xE0, 0xC0, 0xE0, 0xC0, 0x60, 0xE0, 0xA0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 
                                    0x1C, 0x00, 0x35, 0x0D, 0x18, 0x17, 0x0E, 0x0C, 0x23, 0x3F, 0x4B, 0x73, 0x27, 0x2F, 0x1F, 0x13, 
                                    0x80, 0x68, 0x8C, 0xC4, 0xCC, 0x28, 0xC0, 0x00, 0xF8, 0xF4, 0xFE, 0xFE, 0x3E, 0xFC, 0xF8, 0xE0, 
                                    0x00, 0x40, 0xC0, 0x80, 0xE0, 0xC0, 0xE0, 0xC0, 0x60, 0xE0, 0xA0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 
                                    0x1C, 0x00, 0x35, 0x0B, 0x1B, 0x18, 0x0D, 0x00, 0x23, 0x3F, 0x4B, 0x75, 0x25, 0x27, 0x13, 0x1F, 
                                    0xF8, 0x64, 0x84, 0xAC, 0x48, 0xE8, 0xE0, 0xC0, 0xFE, 0xFA, 0xFE, 0xFE, 0xFC, 0xFC, 0xF8, 0x20 };

            // index == 0 uses default sprite

            if (index == 1)
            {
                for (int lni = 0; lni < dogSprite.Length; lni++)
                    romData[0x23060 + lni] = dogSprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x3b; // W
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x19; // o
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x19; // o
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x10; // f
            }

            else if (index == 2)
            {
                for (int lni = 0; lni < yetiSprite.Length; lni++)
                    romData[0x23060 + lni] = yetiSprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x36; // R
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x19; // o
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x0b; // a
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x1c; // r
            }
            else if (index == 3)
            {
                for (int lni = 0; lni < tigerSprite.Length; lni++)
                    romData[0x23060 + lni] = tigerSprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x2b; // G
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x1c; // r
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x1c; // r
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x1c; // r
            }
            else if (index == 4)
            {
                for (int lni = 0; lni < puppySprite.Length; lni++)
                    romData[0x23060 + lni] = puppySprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x3b; // W
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x19; // o
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x19; // o
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x10; // f
            }
            else if (index == 5)
            {
                for (int lni = 0; lni < foxSprite.Length; lni++)
                    romData[0x23060 + lni] = foxSprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x27; // C
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x12; // h
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x0b; // a
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x1e; // t
            }
            else if (index == 6)
            {
                for (int lni = 0; lni < dw4CatSprite.Length; lni++)
                    romData[0x23060 + lni] = dw4CatSprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x34; // P
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x1c; // r
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x1c; // r
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x1c; // r
            }
            else if (index == 7)
            {
                for (int lni = 0; lni < lionSprite.Length; lni++)
                    romData[0x23060 + lni] = lionSprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x36; // R
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x19; // o
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x0b; // a
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x1c; // r
            }
            else if (index == 8)
            {
                for (int lni = 0; lni < dinoSprite.Length; lni++)
                    romData[0x23060 + lni] = dinoSprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x36; // R
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x19; // o
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x0b; // a
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x1c; // r
            }
            else if (index == 9)
            {
                for (int lni = 0; lni < gbaAniSprite.Length; lni++)
                    romData[0x23060 + lni] = gbaAniSprite[lni];
                romData[0x46a58] = romData[0x514cb] = romData[0x52dd7] = romData[0x52e1f] = romData[0x55e59] = 0x36; // R
                romData[0x46a59] = romData[0x514cc] = romData[0x52dd8] = romData[0x52e20] = romData[0x55e5a] = 0x19; // o
                romData[0x46a5a] = romData[0x514cd] = romData[0x52dd9] = romData[0x52e21] = romData[0x55e5b] = 0x0b; // a
                romData[0x46a5b] = romData[0x514ce] = romData[0x52dda] = romData[0x52e22] = romData[0x55e5c] = 0x1c; // r
            }
        }


        private void invisibleNPCs()
        {
            for (int lni = 0; lni < 32; lni++)
                romData[0x1fff0 + lni] = 0x00;
            for (int lni = 0; lni < (16 * 16 * 5); lni++)
                romData[0x21880 + lni] = 0x00;
            for (int lni = 0; lni < (16 * 16 * 3) + (7 * 16); lni++)
                romData[0x21de0 + lni] = 0x00;
            for (int lni = 0; lni < (16 * 16 * 9) + (1 * 16); lni++)
                romData[0x22290 + lni] = 0x00;
            for (int lni = 0; lni < (16 * 16 * 9) + (9 * 16); lni++)
                romData[0x22c60 + lni] = 0x00;
            for (int lni = 0; lni < (16 * 16 * 4) + (16 * 1); lni++)
                romData[0x23610 + lni] = 0x00;
            for (int lni = 0; lni < (16 * 16) + (14 * 16); lni++)
                romData[0x23af0 + lni] = 0x00;
        }

        private void invisbleShips()
        {
            for (int lni = 0; lni < (16 * 16) * 20; lni++)
                romData[0x22150 + lni] = 0x00;
            for (int lni = 0; lni < 32; lni++)
                romData[0x235f0 + lni] = 0x00;
            for (int lni = 0; lni < (16 * 16) * 13; lni++)
                romData[0x23a20 + lni] = 0x00;
        }

        private void chngDftParty()
        {
            // Force the same three names to be selected in the opening Lucia's Eatery
            romData[0x1e9f8] = 0x29;
            romData[0x1e9f9] = 0x00;


            // Rename the starting characters.
            for (int lnI = 0; lnI < 3; lnI++)
            {
                byte value;
                byte gender;

                value = (byte)(lnI == 0 ? cboClass1.SelectedIndex : lnI == 1 ? cboClass2.SelectedIndex : cboClass3.SelectedIndex);

                byte intValue = (byte)(value == 0 ? 4 : value == 1 ? 2 : value == 2 ? 1 : value == 3 ? 6 : value == 4 ? 5 : value == 5 ? 7 : value == 6 ? 3 : 0);

                gender = (byte)(lnI == 0 ? cboGender1.SelectedIndex : lnI == 1 ? cboGender2.SelectedIndex : cboGender3.SelectedIndex);

                romData[0x1ed4f + lnI] = (byte)(intValue + (gender == 0 ? 0 : 8));
            }

            for (int lnI = 0; lnI < 3; lnI++)
            {
                string name = (lnI == 0 ? txtCharName1.Text : lnI == 1 ? txtCharName2.Text : txtCharName3.Text);
                for (int lnJ = 0; lnJ < 8; lnJ++)
                {
                    romData[0x1ed52 + (8 * lnI * 4) + lnJ] = romData[0x1ed52 + (8 * lnI * 4) + 8 + lnJ] = romData[0x1ed52 + (8 * lnI * 4) + 16 + lnJ] = romData[0x1ed52 + (8 * lnI * 4) + 24 + lnJ] = 0;
                    try
                    {
                        char character = Convert.ToChar(name.Substring(lnJ, 1));
                        if (character >= 0x30 && character <= 0x39)
                            romData[0x1ed52 + (8 * lnI * 4) + lnJ] = (byte)(character - 47);
                        if (character >= 0x41 && character <= 0x5a)
                            romData[0x1ed52 + (8 * lnI * 4) + lnJ] = (byte)(character - 28);
                        if (character >= 0x61 && character <= 0x7a)
                            romData[0x1ed52 + (8 * lnI * 4) + lnJ] = (byte)(character - 86);
                    }
                    catch
                    {
                        romData[0x1ed52 + (8 * lnI * 4) + lnJ] = 0; // no more characters to process - make the rest of the characters blank
                    }
                }

                // Remove the golden claw 100/256 encounter rate - Can't because the king won't check if you have the black pepper.
                //romData[0x185c] = 0x4c;
                //romData[0x185d] = 0x5b;
                //romData[0x185e] = 0x98;
                saveRom(false);
            }

        }

        private void textGet()
        {
            List<string> txtStrings = new List<string>();
            string tempWord = "";
            for (int lnI = 0; lnI < 1913; lnI++)
            {
                int starter = 0x1b2da;
                if (romData[starter + lnI] == 255)
                {
                    txtStrings.Add(tempWord);
                    tempWord = "";
                }
                else if (romData[starter + lnI] >= 0 && romData[starter + lnI] <= 9)
                {
                    tempWord += (char)(romData[starter + lnI] + 39);
                }
                else if (romData[starter + lnI] >= 10 && romData[starter + lnI] <= 35)
                {
                    tempWord += (char)(romData[starter + lnI] + 87);
                }
                else if (romData[starter + lnI] >= 36 && romData[starter + lnI] <= 61)
                {
                    tempWord += (char)(romData[starter + lnI] + 29);
                }
            }
            using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "DW3Strings.txt")))
            {
                int lnJ = 1;
                foreach (string word in txtStrings)
                {
                    writer.WriteLine(lnJ.ToString("X3") + "-" + word);
                    lnJ++;
                }
            }
        }

        private bool loadRom(bool extra = false)
        {
            try
            {
                romData = File.ReadAllBytes(txtFileName.Text);
                if (extra)
                    romData2 = File.ReadAllBytes(txtCompare.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Empty file name(s) or unable to open files.  Please verify the files exist.");
                return false;
            }
            return true;
        }

        private void saveRom(bool calcChecksum)
        {
            string shortVersion = versionNumber.Replace(".", "");
            string finalFile = Path.Combine(Path.GetDirectoryName(txtFileName.Text), "DW3R_" + txtSeed.Text + "_" + txtFlags.Text + "_" + shortVersion + ".nes");
            File.WriteAllBytes(finalFile, romData);
            lblIntensityDesc.Text = "ROM hacking complete!  (" + finalFile + ")";
            txtCompare.Text = finalFile;

            if (calcChecksum)
            {
                try
                {
                    using (var md5 = SHA1.Create())
                    {
                        using (var stream = File.OpenRead(finalFile))
                        {
                            lblNewChecksum.Text = BitConverter.ToString(md5.ComputeHash(stream)).ToLower().Replace("-", "");
                        }
                    }
                }
                catch
                {
                    lblNewChecksum.Text = "????????????????????????????????????????";
                }
            }

        }

        private bool randomizeMapv5(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            for (int lnI = 0; lnI < 256; lnI++)
                for (int lnJ = 0; lnJ < 256; lnJ++)
                {
                    if (chkSmallMap.Checked && (lnI >= 128 || lnJ >= 128))
                    {
                        map[lnI, lnJ] = 0x06;
                        island[lnI, lnJ] = 200;
                    }
                    else
                    {
                        map[lnI, lnJ] = 0x00;
                        island[lnI, lnJ] = -1;
                    }
                }

            for (int lnI = 0; lnI < 139; lnI++)
                for (int lnJ = 0; lnJ < 158; lnJ++)
                {
                    map2[lnI, lnJ] = 0x00;
                    island2[lnI, lnJ] = -1;
                }

            for (int lnI = 0; lnI < 132; lnI++)
                for (int lnJ = 0; lnJ < 156; lnJ++)
                    map2[lnI, lnJ] = 0x00;


            int smallIslandSize = (r1.Next() % 24000) + 21000; // (lnI == 0 ? 1500 : lnI == 1 ? 2500 : lnI == 2 ? 1500 : lnI == 3 ? 1500 : lnI == 4 ? 5000 : 5000);
            int bigIslandSize = (r1.Next() % 12000) + 33000; // (lnI == 0 ? 1500 : lnI == 1 ? 2500 : lnI == 2 ? 1500 : lnI == 3 ? 1500 : lnI == 4 ? 5000 : 5000);
            int islandSize2 = (chkSmallMap.Checked ? (r1.Next() % 1000) + 2800 : (r1.Next() % 3000) + 11000); // For Tantegel

            smallIslandSize /= (chkSmallMap.Checked ? 4 : 1);
            bigIslandSize /= (chkSmallMap.Checked ? 4 : 1);

            // Set up three special zones.  Zone 1000 = 20 squares and has Thief key stuff.  Zone 2000 = 40 squares and has Magic Key stuff.
            // Zone 3000 = 1 square and has Baramos stuff and end of Necrogund stuff.  It will be surrounded by one tile of mountains.
            // This takes up 94 / 256 of the total squares available.

            bool zonesCreated = false;
            List<int> noradLink = new List<int>();

            while (!zonesCreated)
            {
                zone = new int[16, 16];
                if (createZone(1000, 25, false, r1) && createZone(2000, 50, false, r1))
                    zonesCreated = true;
            }

            markZoneSides();
            generateZoneMap(1000, bigIslandSize * 25 / 256, r1); // Aliahan Castle is here.
            generateZoneMap(2000, bigIslandSize * 50 / 256, r1); // Romaly Castle is here.
            generateZoneMap(0, smallIslandSize * 170 / 256, r1); // Norud Cave East is here.
            generateZoneMap(-1000, islandSize2, r1); // About 31% of the regular map

            smoothMap();
            smoothMap2();

            createBridges(r1);
            resetIslands();

            // We should mark islands and inaccessible land...
            int lakeNumber = 256;

            int maxPlots = 0;
            int maxLake = 0;
            int lastValidIsland = -1;

            for (int lnI = 0; lnI < 256; lnI++)
                for (int lnJ = 0; lnJ < 256; lnJ++)
                {
                    if (island[lnI, lnJ] == -1)
                    {
                        int plots = lakePlot(lakeNumber, lnI, lnJ);
                        if (plots > maxPlots)
                        {
                            maxPlots = plots;
                            maxLake = lakeNumber;
                        }
                        lakeNumber++;
                    } else
                    {
                        lastValidIsland = island[lnI, lnJ];
                    }
                }

            lakeNumber = 4256;
            maxPlots = 0;
            int maxLake2 = 0;
            lastValidIsland = -1;

            for (int lnI = 0; lnI < 139; lnI++)
                for (int lnJ = 0; lnJ < 158; lnJ++)
                {
                    if (island2[lnI, lnJ] == -1)
                    {
                        int plots = lakePlot2(lakeNumber, lnI, lnJ);
                        if (plots > maxPlots)
                        {
                            maxPlots = plots;
                            maxLake2 = lakeNumber;
                        }
                        lakeNumber++;
                    }
                    else
                    {
                        lastValidIsland = island[lnI, lnJ];
                    }
                }

            if (chk_GenIslandsMonstersZones.Checked == true)
            {
                string shortVersion = versionNumber.Replace(".", "");
                using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "island_" + txtSeed.Text + "_" + txtFlags.Text + "_" + shortVersion + ".txt")))
                {
                    for (int lnY = 0; lnY < 139; lnY++)
                    {
                        string output = "";
                        for (int lnX = 0; lnX < 158; lnX++)
                            output += island2[lnY, lnX].ToString().PadLeft(5);
                        writer.WriteLine(output);
                    }
                }
            }

            // Establish Aliahan location
            bool midenOK = false;
            int[] midenX = new int[7];
            int[] midenY = new int[7];
            while (!midenOK)
            {
                midenX[1] = 6 + (r1.Next() % (chkSmallMap.Checked ? 116 : 244));
                midenY[1] = 6 + (r1.Next() % (chkSmallMap.Checked ? 116 : 244));
                if (validPlot(midenY[1], midenX[1], 2, 4, new int[] { maxIsland[1] }))
                    midenOK = true;
            }

            // Shrine South Of Romaly
            midenOK = false;
            while (!midenOK)
            {
                midenX[2] = 6 + (r1.Next() % (chkSmallMap.Checked ? 116 : 244));
                midenY[2] = 6 + (r1.Next() % (chkSmallMap.Checked ? 116 : 244));
                if (validPlot(midenY[2], midenX[2], 1, 1, new int[] { maxIsland[2] }))
                    midenOK = true;
            }

            // Norud Cave
            midenOK = false;
            while (!midenOK)
            {
                midenX[0] = 6 + (r1.Next() % (chkSmallMap.Checked ? 116 : 244));
                midenY[0] = 6 + (r1.Next() % (chkSmallMap.Checked ? 116 : 244));
                if (validPlot(midenY[0], midenX[0], 1, 1, new int[] { maxIsland[0] }))
                    midenOK = true;
            }

            // Tantegel
            midenOK = false;
            while (!midenOK)
            {
                midenX[6] = r1.Next() % 132;
                midenY[6] = r1.Next() % 132;
                if (validPlot(midenY[6], midenX[6], 2, 4, new int[] { 60000 }))
                    midenOK = true;
            }

            int charlockX = -255;
            int charlockY = -255;

            // Relocate opening Tantegel scene to 1, 1
            romData[0x3ceb4] = 0x01;
            romData[0x3cebf] = 0x01;
            romData[0x1b3eb] = 0x01;
            romData[0x1b3ec] = 0x01;

            // Don't include Romaly, Aliahan, or Portuga islands in future location hunting.
            islands.Remove(maxIsland[1]);
            islands.Remove(maxIsland[2]);
            islands.Remove(maxIsland[3]);

/*
            using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "island.txt")))
            {
                for (int lnY = 0; lnY < 256; lnY++)
                {
                    string output = "";
                    for (int lnX = 0; lnX < 256; lnX++)
                        output += island[lnY, lnX].ToString().PadLeft(5) + " ";
                    writer.WriteLine(output);
                }
            }
*/
            string[] locTypes = { "C", "C", "C", "?", "S", "X", "T", "T", "?", "T", "X", "T", "T", "X", "T", "?", // Aliahan, Romaly, Eginbear, Baramos, Drought Shrine, XXXXXX, Samanao Town, Brecconary, Charlock, Reeve, Portuga, Noaniels, Assaram, XXXXXX, Baharata, Lancel
                                  // (16) Cantlin, Rimuldar, Hauksness, Luzami, Kanave, Tedanki, Moor, Jipang, Pirate's Den, Soo, Kol, Shrine before Enticement, Shrine S. of Portuga, Sword Of Gaia Shrine, Desert Shrine, Shrine south of Isis
                                  "T", "T", "T", "V", "V", "V", "V", "V", "V", "V", "V", "S", "S", "?", "S", "S",
                                  // (32) Silver Orb Shrine, Olivia Promenade, Olivia Canal Shrine, Dragon Queen Castle, Jipang Shrine, Liamland, Samanao Shrine, Shrine North of Soo, Garinham, Staff of rain shrine, Rainbow Drop Shrine, Portuga Shrine East, West, Promontory Cave, Ruby Cave, Norud Cave West
                                  "?", "S", "S", "?", "S", "S", "S", "S", "S", "S", "S", "?", "?", "E", "E", "E",
                                  // (48) Norud Cave East, Necrogund F5, Necrogund F1, Dhama, Kidnapper's Cave, Jipang Cave, Lancel Cave, Samanao Cave, Erdrick's Cave, Mountain Cave B1, Swamp Cave, Pyramid, Najimi Tower, Garuna Tower, Tower Of Arp, Champange Tower, Tower of Kol
                                  "E", "?", "?", "C", "E", "E", "?", "E", "E", "E", "E", "P", "W", "W", "W", "W", "W",
                                  // (65) Grass tile S of Reeve, Isis, Enticement Cave entrance, Shrine south of Romaly, Pirate Ship, Greenland house, New Town
                                  "?", "?", "?", "?", "?", "?", "?", "X", "?", "X", "?", "?", "?", "?", "?", "?" };

            int[] locIslands = { 1, 2, 9, 9, 9, -100, 9, 6, -2, 1, 3, 2, 2, -100, 0, 4,
                                 6, 6, 6, 9, 2, 9, 9, 9, 9, 9, 6, 1, 9, 9, -100, 4,
                                 10, 9, 9, 9, 9, 9, 9, 9, 6, 6, 6, 2, 3, 1, 2, 2,
                                 0, 9, 10, 9, 0, 9, 9, 9, 6, 6, 6, 2, 1, 0, 9, 2, 6,
                                 1, 2, 1, 2, 9, 9, 9, -100, 2, -100, 9, 2, 1, 1, 6, 9, 4 };

            int[] landLocs = { 0, 1, 9, 10, 11, 12, 14, 20, 27, 30, 43, 44, 45, 46, 47, 48, 58, 59, 60, 61, 63, 65, 66, 67 };

            int[] returnLocs = { 0, 1, 2, 6, 7, 9, 10, 11, 12, 14,
                                 15, 16, 17, 18, 20, 23, 25, 26, 51, 65 };

            int[] returnPoints = { 0, 2, 12, -1, -1, -1, 13, 15, -1, 1, 7, 4, 5, -1, 8, 10,
                                 17, 19, 16, -1, 3, -1, -1, 11, -1, 14, 18, -1, -1, -1, -1, -1,
                                 -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                                 -1, -1, -1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                                 -1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

            for (int lnI = 0; lnI < locTypes.Length; lnI++)
            {
                //if (locIslands[lnI] < 0) continue;
                int x = 300;
                int y = 300;
//                int drgqnx = 0;
//                int drgqny = 0;

                if (lnI == 0) { x = midenX[1]; y = midenY[1]; }
                else if (lnI == 48) { x = midenX[0]; y = midenY[0]; } // Norud Cave East
                else if (lnI == 77) { x = midenX[2]; y = midenY[2]; } // Shrine South Of Romaly
                else if (lnI == 7) { x = midenX[6]; y = midenY[6]; } // Brecconary/Tantegel
                else if (locIslands[lnI] == -1 || locIslands[lnI] == -2)
                {
                    // Subtract 3 for room
                    x = 4 + r1.Next() % (chkSmallMap.Checked ? 80 - 4 - 4 : 132 - 4 - 4);
                    y = 4 + r1.Next() % (chkSmallMap.Checked ? 80 - 4 - 4 : 132 - 4 - 4);
                } else if (locIslands[lnI] == -100)
                {
                    continue;
                } else
                {
                    // Subtract 6 for room
                    x = 6 + r1.Next() % (chkSmallMap.Checked ? 128 - 6 - 6 : 256 - 6 - 6);
                    y = 6 + r1.Next() % (chkSmallMap.Checked ? 128 - 6 - 6 : 256 - 6 - 6);
                }

                if (locIslands[lnI] == 6)
                {
                    if (Math.Abs(y - charlockY) < 5 || Math.Abs(x - charlockX) < 5)
                    {
                        lnI--;
                        continue;
                    }
                }

                // TODO:  Ship return points, human return points, bird return points
                // If branches on locTypes, possibly a case.
                switch (locTypes[lnI])
                {
                    case "C":
                        if (validPlot(y, x, 2, 4, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                                if (locIslands[lnI] == 6)
                                {
                                    map2[y + 0, x + 1] = 0xe8;
                                    map2[y + 0, x + 2] = 0xe9;
                                    map2[y + 1, x + 1] = 0xec;
                                    map2[y + 1, x + 2] = 0xed;
                                }
                                else
                                {
                                    map[y + 0, x + 1] = 0xe8;
                                    map[y + 0, x + 2] = 0xe9;
                                    map[y + 1, x + 1] = 0xec;
                                    map[y + 1, x + 2] = 0xed;
                                }

                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)(x + 1);
                                romData[byteToUse + 1] = (byte)(y + 1);

                                if (lnI == 0) // Aliahan Castle
                                {
                                    romData[0x18535] = (byte)(x + 1);
                                    romData[0x18536] = (byte)(y + 1);
                                }

                                if (returnPoints[lnI] != -1)
                                {
                                    int byteToUseReturn = 0x1b61c + (4 * returnPoints[lnI]);
                                    romData[byteToUseReturn] = (byte)(x + 1);
                                    if (locIslands[lnI] == 6)
                                    {
                                        if (map2[y + 2, x] == 0x00 || map2[y + 2, x] == 0x06)
                                            romData[byteToUseReturn + 1] = (byte)(y + 2);
                                        else
                                            romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    }
                                    else
                                    {
                                        if (map[y + 2, x] == 0x00 || map[y + 2, x] == 0x06)
                                            romData[byteToUseReturn + 1] = (byte)(y + 2);
                                        else
                                            romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    }
                                    if (locIslands[lnI] != 6)
                                        shipPlacement(byteToUseReturn + 2, y + 1, x + 1, maxLake);
                                    else
                                        shipPlacement2(byteToUseReturn + 2, y + 1, x + 1, maxLake2);
                                }
                            
                        }
                        else
                            lnI--;

                        break;
                    case "T": // Town
                        if (validPlot(y, x, 1, 4, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                            {
                                map2[y + 0, x + 1] = 0xea;
                                map2[y + 0, x + 2] = 0xeb;
                            }
                            else
                            {
                                map[y + 0, x + 1] = 0xea;
                                map[y + 0, x + 2] = 0xeb;
                            }

                            int byteToUse = 0x1b252 + (5 * lnI);
                            romData[byteToUse] = (byte)(x + 1);
                            romData[byteToUse + 1] = (byte)(y);

                            if (returnPoints[lnI] != -1)
                            {
                                int byteToUseReturn = 0x1b61c + (4 * returnPoints[lnI]);
                                romData[byteToUseReturn] = (byte)(x + 1);
                                if (locIslands[lnI] == 6)
                                {
                                    if (map2[y + 2, x] == 0x00 || map2[y + 2, x] == 0x06)
                                        romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    else
                                        romData[byteToUseReturn + 1] = (byte)(y + 0);
                                }
                                else
                                {
                                    if (map[y + 2, x] == 0x00 || map[y + 2, x] == 0x06)
                                        romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    else
                                        romData[byteToUseReturn + 1] = (byte)(y + 0);
                                }
                                if (locIslands[lnI] != 6)
                                    shipPlacement(byteToUseReturn + 2, y, x + 1, maxLake);
                                else
                                    shipPlacement2(byteToUseReturn + 2, y, x + 1, maxLake2);

                                if (lnI == 10) // Portuga - set originating ship location to the return point & set x coordinate of return point to east side of portuga
                                {
                                    //                                    romData[byteToUseReturn] = (byte)(x - 2);
                                    romData[0x3d126] = romData[0x7d126] = romData[byteToUseReturn + 2];
                                    romData[0x3d12a] = romData[0x7d12a] = romData[byteToUseReturn + 3];
                                }
                            }

                        }
                        else
                            lnI--;

                        break;
                    case "S": // Shrine
                        if (validPlot(y, x, 1, 1, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                                map2[y + 0, x + 0] = 0xf5;
                            else
                                map[y + 0, x + 0] = 0xf5;

                            int byteToUse = 0x1b252 + (5 * lnI);
                            romData[byteToUse] = (byte)x;
                            romData[byteToUse + 1] = (byte)y;

                            if (lnI == 28)
                            {
                                romData[0x1851a] = (byte)x;
                                romData[0x1851b] = (byte)y;
                            }
                            else if (lnI == 31)
                            {
                                romData[0x184ff] = (byte)x;
                                romData[0x18500] = (byte)y;
                            }
                            else if (lnI == 33)
                            {
                                romData[0x18505] = romData[0x18508] = (byte)x;
                                romData[0x18506] = romData[0x18509] = (byte)y;
                            }
                            else if (lnI == 36)
                            {
                                romData[0x184f6] = (byte)x;
                                romData[0x184f7] = (byte)y;
                            }
                            else if (lnI == 37)
                            {
                                romData[0x3255d] = (byte)x;
                                romData[0x32561] = (byte)(y - 1);
                            }
                            else if (lnI == 38)
                            {
                                romData[0x184f9] = romData[0x1850e] = (byte)x;
                                romData[0x184fa] = romData[0x1850f] = (byte)y;
                            }
                            else if (lnI == 39)
                            {
                                romData[0x184fc] = romData[0x18502] = romData[0x18517] = (byte)x;
                                romData[0x184fd] = romData[0x18503] = romData[0x18518] = (byte)y;
                            }
                        }
                        else
                            lnI--;

                        break;
                    case "V": // Village
                        if (validPlot(y, x, 1, 3, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                                map2[y + 0, x + 1] = 0xf1;
                            else
                                map[y + 0, x + 1] = 0xf1;

                            int byteToUse = 0x1b252 + (5 * lnI);
                            romData[byteToUse] = (byte)(x + 1);
                            romData[byteToUse + 1] = (byte)y;

                            if (returnPoints[lnI] != -1)
                            {
                                int byteToUseReturn = 0x1b61c + (4 * returnPoints[lnI]);
                                romData[byteToUseReturn] = (byte)(x + 1);
                                if (locIslands[lnI] == 6)
                                {
                                    if (map2[y + 2, x] == 0x00 || map2[y + 2, x] == 0x06)
                                        romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    else
                                        romData[byteToUseReturn + 1] = (byte)(y + 0);
                                }
                                else
                                {
                                    if (map[y + 2, x] == 0x00 || map[y + 2, x] == 0x06)
                                        romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    else
                                        romData[byteToUseReturn + 1] = (byte)(y + 0);
                                }
                                if (locIslands[lnI] != 6)
                                    shipPlacement(byteToUseReturn + 2, y, x + 1, maxLake);
                                else
                                    shipPlacement2(byteToUseReturn + 2, y, x + 1, maxLake2);
                            }

                            if (lnI == 23)
                            {
                                romData[0x311c4] = (byte)(x + 1);
                                romData[0x311c8] = (byte)y;
                            }
                        }
                        else
                            lnI--;

                        break;
                    case "P": // Pyramid
                        if (validPlot(y, x, 3, 1, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            map[y + 2, x] = 0xf3;

                            int byteToUse = 0x1b252 + (5 * lnI);
                            romData[byteToUse] = (byte)(x);
                            romData[byteToUse + 1] = (byte)(y + 2);
                        }
                        else
                            lnI--;

                        break;
                    case "E": // Cave
                        if (validPlot(y, x, 1, 1, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                                map2[y + 0, x + 0] = 0xef;
                            else
                                map[y + 0, x + 0] = 0xef;

                            int byteToUse = 0x1b252 + (5 * lnI);
                            romData[byteToUse] = (byte)(x);
                            romData[byteToUse + 1] = (byte)(y);

                            if (lnI == 45)
                            {
                                romData[0x18533] = (byte)(x);
                                romData[0x18534] = (byte)(y);
                            }
                            else if (lnI == 47)
                            {
                                romData[0x1852b] = (byte)(x);
                                romData[0x1852c] = (byte)(y);
                            }
                            else if (lnI == 48)
                            {
                                romData[0x1852d] = (byte)(x);
                                romData[0x1852e] = (byte)(y);
                            }
                            else if (lnI == 49)
                            {
                                romData[0x1853d] = (byte)(x);
                                romData[0x1853e] = (byte)(y);
                            } else if (lnI == 56)
                            {
                                romData[0x30edb] = (byte)(x);
                                romData[0x30edf] = (byte)(y);
                            }
                        }
                        else
                            lnI--;

                        break;
                    case "W": // Tower
                        if (validPlot(y, x, 3, 3, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                            {
                                map2[y + 0, x + 0] = 0xf2;
                                map2[y + 1, x + 0] = 0xee;
                            }
                            else
                            {
                                map[y + 0, x + 0] = 0xf2;
                                map[y + 1, x + 0] = 0xee;
                            }

                            int byteToUse = 0x1b252 + (5 * lnI);
                            romData[byteToUse] = (byte)(x);
                            romData[byteToUse + 1] = (byte)(y + 1);

                            if (lnI == 60) // Najimi Tower
                            {
                                romData[0x18537] = (byte)(x);
                                romData[0x18538] = (byte)(y + 1);

                                // Direct LDA of Tower fall point
                                romData[0x3d401] = (byte)(x);
                                romData[0x3d405] = (byte)(y + 1);

                                romData[0x7d401] = (byte)(x);
                                romData[0x7d405] = (byte)(y + 1);
                            }
                            else if (lnI == 61) // Garuna Tower
                            {
                                romData[0x1851d] = romData[0x18520] = romData[0x18526] = romData[0x18529] = (byte)x;
                                romData[0x1851e] = romData[0x18521] = romData[0x18527] = romData[0x1852a] = (byte)(y + 1);
                            }
                        }
                        else
                            lnI--;

                        break;
                    case "?":
                        if (lnI == 3) // Baramos Castle
                        {
                            bool baramosLegal = true;
                            for (int lnJ = x - 4; lnJ < x + 4; lnJ++)
                                for (int lnK = y - 4; lnK < y + 4; lnK++)
                                {
                                    if (map[lnK, lnJ] > 0x07)
                                        baramosLegal = false;
                                    if (lnK == midenY[0] && lnJ == midenX[0])
                                        baramosLegal = false;
                                    if (lnK == midenY[1] && lnJ == midenX[1])
                                        baramosLegal = false;
                                    if (lnK == midenY[2] && lnJ == midenX[2])
                                        baramosLegal = false;
                                }

                            if (baramosLegal)
                            {
                                if (chk_SepBarGaia.Checked == true)
                                {
                                    // draw mountains
                                    for (int lnJ = -3; lnJ < 3; lnJ++)
                                        for (int lnK = -3; lnK < 3; lnK++)
                                            island[y + lnJ, x + lnK] = 4001;
                                    if (chk_RemoveBirdRequirement.Checked == true)
                                    {
                                        for (int lnJ = -3; lnJ < 1; lnJ++)
                                        {
                                            map[y - 3, x + lnJ] = 0x05;
                                            map[y + 2, x + lnJ] = 0x05;
                                        }
                                        map[y - 2, x - 3] = 0x05;
                                        map[y - 1, x - 3] = 0x05;
                                        map[y, x - 3] = 0x05;
                                        map[y + 1, x - 3] = 0x05;
                                        map[y - 3, x + 1] = 0x05;
                                        map[y - 3, x + 2] = 0x05;
                                        map[y + 1, x + 1] = 0x05;
                                        map[y - 2, x + 2] = 0x05;
                                        map[y - 1, x + 2] = 0x05;
                                        map[y, x + 2] = 0x05;
                                    }
                                    else
                                    {
                                        for (int lnJ = -3; lnJ < 1; lnJ++)
                                        {
                                            map[y - 3, x + lnJ] = 0x06;
                                            map[y + 2, x + lnJ] = 0x06;
                                        }
                                        map[y - 2, x - 3] = 0x06;
                                        map[y - 1, x - 3] = 0x06;
                                        map[y, x - 3] = 0x06;
                                        map[y + 1, x - 3] = 0x06;
                                        map[y - 3, x + 1] = 0x06;
                                        map[y - 3, x + 2] = 0x06;
                                        map[y + 1, x + 1] = 0x06;
                                        map[y - 2, x + 2] = 0x06;
                                        map[y - 1, x + 2] = 0x06;
                                        map[y, x + 2] = 0x06;
                                    }
                                    // draw swamp
                                    for (int lnj = -2; lnj < 1; lnj++)
                                    {
                                        map[y - 2, x + lnj] = 0x02;
                                        map[y + lnj, x + 1] = 0x02;
                                        map[y + 1, x + lnj] = 0x02;
                                    }
                                    map[y - 1, x - 2] = 0x02;
                                    map[y - 1, x - 1] = 0x02;
                                    map[y + 1, x + 2] = 0x02;
                                    map[y + 2, x + 1] = 0x02;
                                    // draw castle
                                    map[y - 1, x - 1] = 0xe8;
                                    map[y - 1, x + 0] = 0xe9;
                                    map[y + 0, x - 1] = 0xec;
                                    map[y + 0, x + 0] = 0xed;
                                    // Let's also get the Pit Of Giaga!
                                    map[y + 2, x + 2] = 0xf4;
                                    romData[0x1b3f1] = (byte)(x + 2);
                                    romData[0x1b3f2] = (byte)(y + 2);

                                    int byteToUse = 0x1b252 + (5 * 3);
                                    romData[byteToUse] = (byte)(x - 1);
                                    romData[byteToUse + 1] = (byte)y;

                                }
                                else
                                {
                                    for (int lnJ = -3; lnJ < 3; lnJ++)
                                        for (int lnK = -3; lnK < 3; lnK++)
                                            island[y + lnJ, x + lnK] = 4001;

                                    if (chk_RemoveBirdRequirement.Checked == true)
                                    {
                                        for (int lnJ = -3; lnJ < 3; lnJ++)
                                        {
                                            map[y + lnJ, x - 3] = 0x05;
                                            map[y + lnJ, x + 2] = 0x05;
                                            map[y - 3, x + lnJ] = 0x05;
                                            map[y + 2, x + lnJ] = 0x05;
                                        }
                                    }
                                    else
                                    {
                                        for (int lnJ = -3; lnJ < 3; lnJ++)
                                        {
                                            map[y + lnJ, x - 3] = 0x06;
                                            map[y + lnJ, x + 2] = 0x06;
                                            map[y - 3, x + lnJ] = 0x06;
                                            map[y + 2, x + lnJ] = 0x06;
                                        }
                                    }
                                    for (int lnJ = -2; lnJ < 2; lnJ++)
                                    {
                                        map[y + lnJ, x - 2] = 0x02;
                                        map[y + lnJ, x + 1] = 0x02;
                                        map[y - 2, x + lnJ] = 0x02;
                                        map[y + 1, x + lnJ] = 0x02;
                                    }

                                    map[y - 1, x - 1] = 0xe8;
                                    map[y - 1, x + 0] = 0xe9;
                                    map[y + 0, x - 1] = 0xec;
                                    map[y + 0, x + 0] = 0xed;

                                    // Let's also get the Pit Of Giaga!
                                    map[y + 1, x + 1] = 0xf4;
                                    romData[0x1b3f1] = (byte)(x + 1);
                                    romData[0x1b3f2] = (byte)(y + 1);

                                    int byteToUse = 0x1b252 + (5 * 3);
                                    romData[byteToUse] = (byte)(x - 1);
                                    romData[byteToUse + 1] = (byte)y;
                                }
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 8) // Charlock Castle
                        {
                            bool baramosLegal = true;
                            if (x < 10 || y < 10 || x > 150 || y > 130)
                                baramosLegal = false;

                            if (baramosLegal)
                            {
                                for (int lnJ = x - 5; lnJ < x + 5; lnJ++)
                                    for (int lnK = y - 5; lnK < y + 5; lnK++)
                                    {
                                        if (map2[lnK, lnJ] > 0x07)
                                            baramosLegal = false;
                                    }
                            }

                            if (baramosLegal)
                            {
                                charlockX = x;
                                charlockY = y;

                                for (int lnJ = -5; lnJ < 5; lnJ++)
                                    for (int lnK = -5; lnK < 5; lnK++)
                                        map2[y + lnJ, x + lnK] = 0x02;
                                for (int lnJ = -4; lnJ < 4; lnJ++)
                                    for (int lnK = -4; lnK < 4; lnK++)
                                        if (chk_lbtoCharlock.Checked == true)
                                        {
                                            map2[y + lnJ, x + lnK] = 0x05;
                                        }
                                        else
                                        {
                                            map2[y + lnJ, x + lnK] = 0x06;
                                        }

                                for (int lnJ = -3; lnJ < 3; lnJ++)
                                    for (int lnK = -3; lnK < 3; lnK++)
                                        if (chk_lbtoCharlock.Checked == true)
                                        {
                                            map2[y + lnJ, x + lnK] = 0x02;
                                        }
                                        else
                                        {
                                            map2[y + lnJ, x + lnK] = 0x00;
                                        }


                                for (int lnJ = -2; lnJ < 2; lnJ++)
                                    for (int lnK = -2; lnK < 2; lnK++)
                                        map2[y + lnJ, x + lnK] = 0x07;

                                map2[y - 1, x - 1] = 0xe8;
                                map2[y - 1, x] = 0xe9;
                                map2[y, x - 1] = 0xec;
                                map2[y, x] = 0xed;
                                map2[y, x + 3] = 0x01;
                                int lnL = x + 4;
                                while (map2[y, lnL] == 0x00 && lnL < 132)
                                {
                                    map2[y, lnL] = 0x01;
                                    lnL++;
                                }

                                // Rainbow Drop
                                romData[0x1bfc6] = (byte)(x + 3);
                                romData[0x1bfcc] = (byte)y;
                                romData[0x3f023] = (byte)(x + 1);
                                romData[0x3f027] = (byte)(x + 4);
                                romData[0x3f019] = (byte)y;

                                int byteToUse = 0x1b252 + (5 * 8);
                                romData[byteToUse] = (byte)(x - 1);
                                romData[byteToUse + 1] = (byte)y;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 15) // Lancel / Lancel Cave
                        {
                            bool baramosLegal = true;
                            for (int lnJ = x - 2; lnJ <= x + 3; lnJ++)
                                //							for (int lnJ = x - 2; lnJ <= x + 2; lnJ++)
                                for (int lnK = y - 1; lnK <= y + 1; lnK++)
                                {
                                    if (map[lnK, lnJ] > 0x07)
                                        baramosLegal = false;
                                }

                            if (baramosLegal)
                            {
                                for (int lnJ = -2; lnJ < 3; lnJ++)
                                //                                for (int lnJ = -2; lnJ < 2; lnJ++)

                                {
                                    if (chk_RemLancelMountains.Checked == true)
                                    {
                                        map[y - 1, x + lnJ] = 0x02;
                                        map[y + 1, x + lnJ] = 0x02;
                                    }
                                    else
                                    {
                                        map[y - 1, x + lnJ] = 0x06;
                                        map[y + 1, x + lnJ] = 0x06;
                                    }
                                    island[y - 1, x + lnJ] = 6000;
                                    island[y, x + lnJ] = 6000;
                                    island[y + 1, x + lnJ] = 6000;
                                }

                                if (chk_RemLancelMountains.Checked == true)
                                    map[y, x - 2] = 0x01;
                                else
                                    map[y, x - 2] = 0x06;
                                map[y, x - 1] = 0xef;
                                map[y, x] = 0x02;
                                map[y, x + 1] = 0xea;
                                map[y, x + 2] = 0xeb;
                                map[y - 1, x + 1] = 0x02;
                                map[y - 1, x + 2] = 0x02;
                                map[y + 1, x + 1] = 0x02;
                                map[y + 1, x + 2] = 0x02;
                                map[y, x + 3] = 0x02;
                                map[y - 1, x + 3] = 0x02;
                                map[y + 1, x + 3] = 0x02;

                                romData[0x1b360] = (byte)(x - 1);
                                romData[0x1b361] = (byte)y;

                                romData[0x1b29d] = (byte)(x + 1);
                                romData[0x1b29e] = (byte)y;

                                romData[0x3d16f] = (byte)x;

                                romData[0x32736] = (byte)(x + 1);
                                romData[0x3273a] = (byte)y;

                                // Return point
                                int byteToUseReturn = 0x1b61c + (4 * 10);
                                romData[byteToUseReturn] = (byte)(x + 2);
                                romData[byteToUseReturn + 1] = (byte)(y + 1);
                                shipPlacement(byteToUseReturn + 2, y + 1, x + 2, maxLake);
                            }
                            else
                                lnI--;
                        }
                        //else if (lnI == 32) // Silver Orb Shrine; skip, addressing that in Necrogund.
                        else if (lnI == 29) // Olivia Canal Shrine
                        {
                            bool baramosLegal = true;
                            for (int lnJ = x - 4; lnJ < x + 4; lnJ++)
                                for (int lnK = y - 1; lnK < y + 1; lnK++)
                                {
                                    if (map[lnK, lnJ] != 0x00 || island[lnK, lnJ] != maxLake)
                                        baramosLegal = false;
                                }

                            if (baramosLegal)
                            {
                                // Create line of mountains
                                for (int lnJ = -3; lnJ < 1; lnJ++)
                                {
                                    map[y + 1, x + lnJ] = 0x06;
                                    map[y - 1, x + lnJ] = 0x06;
                                }
                                // Make the rest water
                                for (int lnJ = 1; lnJ < 4; lnJ++)
                                {
                                    map[y + 1, x + lnJ] = 0x00;
                                    map[y - 1, x + lnJ] = 0x00;
                                }
                                map[y, x - 4] = 0x06;
                                map[y, x - 3] = 0xf5; // Shrine Placement
                                map[y, x + 3] = 0xf7; // Shoal Placement

                                romData[0x1b2e3] = (byte)(x - 3);
                                romData[0x1b2e4] = (byte)y;
                                // Olivia bad news spot
                                romData[0x3313e] = (byte)(x - 2);
                                romData[0x33144] = (byte)y;
                            }
                            else
                                lnI--;
                        }
                        /*                        else if (lnI == 35)
                                                {
                                                    if (validPlot(y, x, 2, 4, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? maxLake2 : maxLake, locIslands[lnI] == 6))
                                                    {
                                                        bool baramosLegal = true;
                                                        for (int lnJ = x - 4; lnJ < x + 4; lnJ++)
                                                            for (int lnK = x - 4; lnK < x + 4; lnK++)
                                                            {
                                                                if (map[lnK, lnJ] > 0x07)
                                                                    baramosLegal = false;
                                                                if (lnK == midenY[0] && lnJ == midenX[0])
                                                                    baramosLegal = false;
                                                                if (lnK == midenY[1] && lnJ == midenX[1])
                                                                    baramosLegal = false;
                                                                if (lnK == midenY[2] && lnJ == midenX[2])
                                                                    baramosLegal = false;
                                                            }
                                                        if (baramosLegal)
                                                        {
                                                            int byteToUse = 0x1b252 + (5 * lnI);
                                                            romData[byteToUse] = (byte)(x);
                                                            romData[byteToUse + 1] = (byte)(y);

                                                            // Draw Mountains
                                                            map[y - 3, x - 1] = 0x06;
                                                            map[y - 3, x] = 0x06;
                                                            map[y - 2, x - 2] = 0x06;
                                                            map[y - 2, x + 1] = 0x06;
                                                            map[y - 1, x - 3] = 0x06;
                                                            map[y - 1, x + 2] = 0x06;
                                                            map[y, x - 3] = 0x06;
                                                            map[y, x + 2] = 0x06;
                                                            map[y + 1, x - 2] = 0x06;
                                                            map[y + 1, x + 1] = 0x06;
                                                            map[y + 2, x - 1] = 0x06;
                                                            map[y + 2, x] = 0x06;
                                                            // Draw Grass
                                                            map[y - 2, x - 1] = 0x02;
                                                            map[y - 2, x] = 0x02;
                                                            map[y - 1, x - 2] = 0x02;
                                                            map[y - 1, x + 1] = 0x02;
                                                            map[y, x - 2] = 0x02;
                                                            map[y, x + 1] = 0x02;
                                                            map[y + 1, x - 1] = 0x02;
                                                            map[y + 1, x] = 0x02;
                                                            // Draw Castle
                                                            map[y - 1, x - 1] = 0xe8;
                                                            map[y - 1, x] = 0xe9;
                                                            map[y, x - 1] = 0xec;
                                                            map[y, x] = 0xed;
                                                        }
                                                        else
                                                            lnI--;
                                                    }
                                                }
                        */
                        else if (lnI == 35) // Dragon Queen Castle
                        {
                            if (validPlot(y, x, 6, 6, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                            locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                if(chk_RemoveMtnDrgQueen.Checked)
                                    map[y, x + 2] = map[y, x + 3] = map[y + 1, x + 1] = map[y + 1, x + 4] = map[y + 2, x] = map[y + 2, x + 5] = map[y + 3, x] = map[y + 3, x + 5] = map[y + 4, x + 1] = map[y + 4, x + 4] = map[y + 5, x + 2] = map[y + 5, x + 3] = 0x05;
                                else
                                    map[y, x + 2] = map[y, x + 3] = map[y + 1, x + 1] = map[y + 1, x + 4] = map[y + 2, x] = map[y + 2, x + 5] = map[y + 3, x] = map[y + 3, x + 5] = map[y + 4, x + 1] = map[y + 4, x + 4] = map[y + 5, x + 2] = map[y + 5, x + 3] = 0x06;
                                map[y + 1, x + 2] = map[y + 1, x + 3] = map[y + 2, x + 1] = map[y + 2, x + 4] = map[y + 3, x + 1] = map[y + 3, x + 4] = map[y + 4, x + 2] = map[y + 4, x + 3] = 0x02;
                                map[y + 2, x + 2] = 0xe8;
                                map[y + 2, x + 3] = 0xe9;
                                map[y + 3, x + 2] = 0xec;
                                map[y + 3, x + 3] = 0xed;

                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)(x + 2);
                                romData[byteToUse + 1] = (byte)(y + 3);
                            }
                            else
                                lnI--;

                        }
                        else if (lnI == 43)
                        {
                            if (validPlot(y, x, 1, 1, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                                locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                bool baramosLegal = true;
                                int x2 = 8 + r1.Next() % (chkSmallMap.Checked ? 128 - 8 - 4 : 256 - 8 - 8);

                                if (chkSmallMap.Checked)
                                {
                                    for (int lnJ = x2 - 6; lnJ < x2 + 2; lnJ++)
                                        for (int lnK = y - 2; lnK < y + 3; lnK++)
                                        {
                                            if (map[lnK, lnJ] != 0x00 || island[lnK, lnJ] != maxLake)
                                                baramosLegal = false;
                                        }

                                    if (baramosLegal)
                                    {
                                        map[y + 0, x + 0] = 0xf5;

                                        // Map Portuga Shrine East to the ROM
                                        int byteToUse = 0x1b252 + (5 * lnI);
                                        romData[byteToUse] = (byte)x;
                                        romData[byteToUse + 1] = (byte)y;
                                        map[y - 2, x2 + 1] = 0x00;
                                        map[y - 2, x2] = 0x00;
                                        map[y - 2, x2 - 1] = 0x00;
                                        map[y - 2, x2 - 2] = 0x00;
                                        map[y - 2, x2 - 3] = 0x00;
                                        map[y - 2, x2 - 4] = 0x00;
                                        map[y - 2, x2 - 5] = 0x00;
                                        map[y - 2, x2 - 6] = 0x00;
                                        map[y - 2, x2 + 1] = 0x00;
                                        map[y - 1, x2] = 0x00;
                                        map[y - 1, x2 - 1] = 0x05;
                                        map[y - 1, x2 - 2] = 0x05;
                                        map[y - 1, x2 - 3] = 0x05;
                                        map[y - 1, x2 - 4] = 0x05;
                                        map[y - 1, x2 - 5] = 0x05;
                                        map[y - 1, x2 - 6] = 0x00;
                                        map[y, x2 + 1] = 0x00;
                                        map[y, x2 - 1] = 0x05;
                                        map[y, x2 - 2] = 0xeb;
                                        map[y, x2 - 3] = 0xea;
                                        map[y, x2 - 4] = 0x00;
                                        map[y, x2 - 5] = 0x05;
                                        map[y, x2 - 6] = 0x00;
                                        map[y + 1, x2 + 1] = 0x00;
                                        map[y + 1, x2] = 0x00;
                                        map[y + 1, x2 - 1] = 0x05;
                                        map[y + 1, x2 - 2] = 0x05;
                                        map[y + 1, x2 - 3] = 0x05;
                                        map[y + 1, x2 - 4] = 0x00;
                                        map[y + 1, x2 - 5] = 0x05;
                                        map[y + 1, x2 - 6] = 0x00;
                                        map[y + 2, x2 + 1] = 0x00;
                                        map[y + 2, x2] = 0x00;
                                        map[y + 2, x2 - 1] = 0x00;
                                        map[y + 2, x2 - 2] = 0x00;
                                        map[y + 2, x2 - 3] = 0x00;
                                        map[y + 2, x2 - 4] = 0x00;
                                        map[y + 2, x2 - 5] = 0x00;
                                        map[y + 2, x2 - 6] = 0x00;



                                        // Map Portuga Castle to the ROM
                                        byteToUse = 0x1b252 + (5 * 10);
                                        romData[byteToUse] = (byte)(x2 - 3);
                                        romData[byteToUse + 1] = (byte)y;

                                        map[y + 0, x2 + 0] = 0xf5;
                                        // Map Portuga Shrine West to the ROM
                                        byteToUse = 0x1b252 + (5 * 44);
                                        romData[byteToUse] = (byte)x2;
                                        romData[byteToUse + 1] = (byte)y;

                                        int byteToUseReturn = 0x1b61c + (4 * returnPoints[10]);
                                        romData[byteToUseReturn] = (byte)(x2 - 1);
                                        romData[byteToUseReturn + 1] = (byte)y;
                                        shipPlacement(byteToUseReturn + 2, y, x2 - 4, maxLake);

                                        romData[0x3d126] = romData[0x7d126] = romData[byteToUseReturn + 2];
                                        romData[0x3d12a] = romData[0x7d12a] = romData[byteToUseReturn + 3];

                                        romData[0x1850b] = romData[0x3d18b] = romData[0x7d18b] = (byte)x;
                                        romData[0x1850c] = romData[0x3d181] = romData[0x7d181] = (byte)y;

                                        romData[0x3d192] = romData[0x7d192] = (byte)x2;
                                    }
                                    else
                                        lnI--;
                                }
                                else
                                {
                                    for (int lnJ = x2 - 5; lnJ < x2 + 5; lnJ++)
                                        for (int lnK = y - 3; lnK < y + 3; lnK++)
                                        {
                                            if (map[lnK, lnJ] != 0x00 || island[lnK, lnJ] != maxLake)
                                                baramosLegal = false;
                                        }

                                    if (baramosLegal)
                                    {
                                        map[y + 0, x + 0] = 0xf5;

                                        // Map Portuga Shrine East to the ROM
                                        int byteToUse = 0x1b252 + (5 * lnI);
                                        romData[byteToUse] = (byte)x;
                                        romData[byteToUse + 1] = (byte)y;

                                        for (int lnJ = -4; lnJ < 4; lnJ++)
                                        {
                                            if (lnJ == -4 || lnJ == -3 || lnJ == -1 || lnJ == 1 || lnJ == 3)
                                            {
                                                map[y - 2, x2 + lnJ] = map[y - 1, x2 + lnJ] = map[y, x2 + lnJ] = map[y + 1, x2 + lnJ] = map[y + 2, x2 + lnJ] = 0x05;
                                            }
                                            else if (lnJ == -2 || lnJ == 2)
                                            {
                                                map[y - 2, x2 + lnJ] = map[y - 1, x2 + lnJ] = map[y, x2 + lnJ] = map[y + 1, x2 + lnJ] = 0x06;
                                                map[y + 2, x2 + lnJ] = 0x05;
                                            }
                                            else if (lnJ == 0)
                                            {
                                                map[y - 1, x2 + lnJ] = map[y, x2 + lnJ] = map[y + 1, x2 + lnJ] = map[y + 2, x2 + lnJ] = 0x06;
                                                map[y - 2, x2 + lnJ] = 0x05;
                                            }
                                            island[y - 2, x2 + lnJ] = island[y - 1, x2 + lnJ] = island[y, x2 + lnJ] = island[y + 1, x2 + lnJ] = island[y + 2, x2 + lnJ] = 3000;
                                        }

                                        map[y - 2, x2 - 4] = 0xea;
                                        map[y - 2, x2 - 3] = 0xeb;

                                        // Map Portuga Castle to the ROM
                                        byteToUse = 0x1b252 + (5 * 10);
                                        romData[byteToUse] = (byte)(x2 - 4);
                                        romData[byteToUse + 1] = (byte)(y - 2);

                                        map[y + 0, x2 + 3] = 0xf5;
                                        // Map Portuga Shrine West to the ROM
                                        byteToUse = 0x1b252 + (5 * 44);
                                        romData[byteToUse] = (byte)(x2 + 3);
                                        romData[byteToUse + 1] = (byte)y;

                                        int byteToUseReturn = 0x1b61c + (4 * returnPoints[10]);
                                        romData[byteToUseReturn] = (byte)(x2 - 4);
                                        romData[byteToUseReturn + 1] = (byte)(y - 1);
                                        shipPlacement(byteToUseReturn + 2, y - 1, x2 - 4, maxLake);

                                        romData[0x3d126] = romData[0x7d126] = romData[byteToUseReturn + 2];
                                        romData[0x3d12a] = romData[0x7d12a] = romData[byteToUseReturn + 3];

                                        romData[0x1850b] = romData[0x3d18b] = romData[0x7d18b] = (byte)x;
                                        romData[0x1850c] = romData[0x3d181] = romData[0x7d181] = (byte)y;

                                        romData[0x3d192] = romData[0x7d192] = (byte)(x2 + 3);
                                    }
                                    else
                                        lnI--;
                                }

                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 10 || lnI == 44)
                            continue;
                        else if (lnI == 49) // Necrogund F1
                        {
                            bool baramosLegal = true;
                            for (int lnJ = x - 5; lnJ <= x + 4; lnJ++)
                                for (int lnK = y - 3; lnK <= y + 2; lnK++)
                                {
                                    if (map[lnK, lnJ] > 0x07)
                                        baramosLegal = false;
                                }

                            if (baramosLegal)
                            {
                                for (int lnJ = x - 5; lnJ <= x + 4; lnJ++)
                                    for (int lnK = y - 3; lnK <= y + 2; lnK++)
                                    {
                                        island[lnK, lnJ] = 5001;
                                    }

                                for (int lnJ = y - 3; lnJ <= y + 2; lnJ++)
                                {
                                    if (chk_RmMtnNecrogond.Checked == true)
                                    {
                                        map[lnJ, x - 5] = 0x05;
                                        map[lnJ, x + 2] = 0x05;
                                        map[lnJ, x + 4] = 0x05;
                                    }
                                    else
                                    {
                                        map[lnJ, x - 5] = 0x06;
                                        map[lnJ, x + 2] = 0x06;
                                        map[lnJ, x + 4] = 0x06;
                                    }
                                }
                                for (int lnJ = x - 5; lnJ <= x + 4; lnJ++)
                                {
                                    if (chk_RmMtnNecrogond.Checked == true)
                                        map[y + 2, lnJ] = 0x05;
                                    else
                                        map[y + 2, lnJ] = 0x06;
                                }
                                for (int lnJ = x - 5; lnJ <= x + 4; lnJ++)
                                    map[y - 3, lnJ] = 0x05;

                                // Silver Orb Shrine/Necrogund F5
                                map[y - 2, x + 3] = 0x06;
                                map[y - 1, x + 3] = 0xf5;
                                map[y + 0, x + 3] = 0x05;
                                map[y + 1, x + 3] = 0xef;

                                // The rest
                                map[y - 2, x - 4] = 0x05;
                                map[y - 2, x - 3] = 0x05;
                                map[y - 2, x - 2] = 0x05;
                                map[y - 2, x - 1] = 0x06;
                                map[y - 2, x + 0] = 0x05;
                                map[y - 2, x + 1] = 0x06;

                                map[y - 1, x - 4] = 0x05;
                                map[y - 1, x - 3] = 0x05;
                                map[y - 1, x - 2] = 0x00;
                                map[y - 1, x - 1] = 0x05;
                                map[y - 1, x + 0] = 0xf0;
                                map[y - 1, x + 1] = 0x05;

                                map[y - 0, x - 4] = 0x05;
                                map[y - 0, x - 3] = 0x00;
                                map[y - 0, x - 2] = 0x00;
                                map[y - 0, x - 1] = 0x05;
                                map[y - 0, x + 0] = 0x05;
                                map[y - 0, x + 1] = 0x05;

                                map[y + 1, x - 4] = 0x00;
                                map[y + 1, x - 3] = 0x00;
                                map[y + 1, x - 2] = 0x05;
                                map[y + 1, x - 1] = 0x05;
                                map[y + 1, x + 0] = 0x05;
                                map[y + 1, x + 1] = 0xef;

                                // Volcano stuff
                                // First, Sword of Gaia
                                romData[0x2e7f] = romData[0x32a93] = (byte)x;
                                romData[0x2e85] = romData[0x32a99] = (byte)(y - 2);
                                // Second, mapping stuff
                                romData[0x3f09b] = (byte)(x - 4);
                                romData[0x3f09f] = (byte)(x - 1);
                                romData[0x3f0a5] = (byte)(y - 1);
                                romData[0x3f0a9] = (byte)(y + 3);
                                // Map link to cave now though!
                                // Beginning
                                romData[0x18531] = romData[0x1b34c] = (byte)(x + 1);
                                romData[0x18532] = romData[0x1b34d] = (byte)(y + 1);
                                // End
                                romData[0x1852f] = romData[0x1b347] = (byte)(x + 3);
                                romData[0x18530] = romData[0x1b348] = (byte)(y + 1);
                                // Shrine
                                romData[0x1b2f2] = (byte)(x + 3);
                                romData[0x1b2f3] = (byte)(y - 1);
                            }
                            else
                                lnI--;
                        }
                        //else if (lnI == 50) // Necrogrund F5/Silver Orb Shrine - skip, see above
                        else if (lnI == 65) // Grass tile south of Reeve
                        {
                            if (validPlot(y, x, 3, 3, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                                locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                map[y + 0, x + 0] = map[y + 0, x + 1] = map[y + 0, x + 2] = map[y + 1, x + 0] = map[y + 1, x + 2] = map[y + 2, x + 0] = map[y + 2, x + 1] = map[y + 2, x + 2] = 0x04;
                                map[y + 1, x + 1] = 0x03;

                                romData[0x1b3df] = (byte)(x + 1);
                                romData[0x1b3e0] = (byte)(y + 1);

                                romData[0x184f3] = romData[0x18539] = (byte)(x + 1);
                                romData[0x184f4] = romData[0x1853a] = (byte)(y + 1);
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 66) // Isis
                        {
                            if (validPlot(y, x, 4, 5, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                                locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                map[y + 0, x + 1] = map[y + 0, x + 2] = map[y + 1, x + 0] = map[y + 1, x + 3] = map[y + 2, x + 0] = map[y + 2, x + 1] = map[y + 2, x + 4] = map[y + 3, x + 1] = map[y + 3, x + 2] = map[y + 3, x + 3] = 0x04;
                                map[y + 1, x + 1] = map[y + 1, x + 2] = map[y + 2, x + 2] = map[y + 2, x + 3] = 0x00;

                                romData[0x1b39d] = (byte)(x + 1);
                                romData[0x1b39e] = (byte)(y + 3);

                                romData[0x1b3bb] = (byte)(x + 1);
                                romData[0x1b3bc] = (byte)(y + 2);

                                romData[0x1b3b5] = (byte)(x + 0);
                                romData[0x1b3b6] = (byte)(y + 1);

                                romData[0x1b3af] = (byte)(x + 1);
                                romData[0x1b3b0] = (byte)(y + 0);

                                romData[0x1b3a9] = (byte)(x + 2);
                                romData[0x1b3aa] = (byte)(y + 0);

                                romData[0x1b3c1] = (byte)(x + 3);
                                romData[0x1b3c2] = (byte)(y + 2);

                                romData[0x1b3a3] = (byte)(x + 3);
                                romData[0x1b3a4] = (byte)(y + 3);

                                if (returnPoints[lnI] != -1)
                                {
                                    int byteToUseReturn = 0x1b61c + (4 * returnPoints[lnI]);
                                    romData[byteToUseReturn] = (byte)(x + 0);
                                    romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    shipPlacement(byteToUseReturn + 2, y + 1, x, maxLake);

                                }
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 67) // Enticement Cave
                        {
                            if (chkSmallMap.Checked)
                            {
                                if (validPlot(y - 1, x - 1, 3, 3, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                                    locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                                {
                                    for (int lnX = -1; lnX < 2; lnX++)
                                        for (int lnY = -1; lnY < 2; lnY++)
                                            map[y + lnY, x + lnX] = 0x04;

                                    map[y, x] = 0x00;

                                    romData[0x1b3e5] = (byte)(x);
                                    romData[0x1b3e6] = (byte)(y + 1);

                                    romData[0x18514] = romData[0x1853b] = (byte)(x);
                                    romData[0x18515] = romData[0x1853c] = (byte)(y + 1);
                                }
                                else
                                    lnI--;
                            }
                            else
                            {
                                //								if (y == 199 && x == 157) y = y; // Why redeclare?
                                if (validPlot(y - 2, x - 2, 5, 5, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                                    locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                                {
                                    for (int lnX = -2; lnX < 3; lnX++)
                                        for (int lnY = -2; lnY < 3; lnY++)
                                            map[y + lnY, x + lnX] = 0x05;

                                    for (int lnX = -1; lnX < 2; lnX++)
                                        for (int lnY = -1; lnY < 2; lnY++)
                                            map[y + lnY, x + lnX] = 0x04;

                                    map[y, x] = 0x00;
                                    map[y + 2, x] = 0x04;

                                    romData[0x1b3e5] = (byte)(x);
                                    romData[0x1b3e6] = (byte)(y + 1);

                                    romData[0x18514] = romData[0x1853b] = (byte)(x);
                                    romData[0x18515] = romData[0x1853c] = (byte)(y + 1);
                                }
                                else
                                    lnI--;
                            }
                        }
                        else if (lnI == 68) // Shrine South of Romaly
                        {
                            if (validPlot(y, x, 1, 1, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                                locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                romData[0x1b3d9] = (byte)(x);
                                romData[0x1b3da] = (byte)(y);

                                romData[0x18523] = (byte)(x);
                                romData[0x18524] = (byte)(y);
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 69) // Pirate Ship
                        {
                            bool baramosLegal = true;
                            if (map[y, x] != 0x00 || island[y, x] != maxLake)
                                baramosLegal = false;

                            if (baramosLegal)
                            {
                                romData[0x378ba] = romData[0x3b630] = (byte)x;
                                romData[0x378be] = romData[0x3b634] = (byte)y;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 70) // Greenland house
                        {
                            if (validPlot(y, x, 3, 3, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                                locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                map[y + 0, x + 0] = map[y + 0, x + 1] = map[y + 0, x + 2] = map[y + 1, x + 0] = map[y + 1, x + 2] = map[y + 2, x + 0] = map[y + 2, x + 1] = map[y + 2, x + 2] = 0x01;
                                map[y + 1, x + 1] = 0x02;

                                romData[0x1b3d3] = (byte)(x + 1);
                                romData[0x1b3d4] = (byte)(y + 1);
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 71) // New Town
                        {
                            if (chk_RmNewTown.Checked == false)
                            {
                                if (validPlot(y, x, 3, 3, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && reachable(y, x, !landLocs.Contains(lnI),
                                    locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                                {
                                    map[y + 0, x + 0] = map[y + 0, x + 1] = map[y + 0, x + 2] = map[y + 1, x + 0] = map[y + 1, x + 2] = map[y + 2, x + 0] = map[y + 2, x + 1] = map[y + 2, x + 2] = 0x04;
                                    map[y + 1, x + 1] = 0x02;

                                    romData[0x1b397] = (byte)(x + 1);
                                    romData[0x1b398] = (byte)(y + 1);
                                }
                                else
                                    lnI--;
                            }
                        }
                        break;
                    case "X":
                        continue;
                }
/*                int drgqnx3 = drgqnx + 3;
                int drgqny5 = drgqny + 5;
                // Draw landscape around Dragon Queen Castle
                // Draw Mountains
                map[drgqny, drgqnx + 2] = 0x06;
                map[drgqny, drgqnx + 3] = 0x06;
                map[drgqny + 1, drgqnx] = 0x06;
                map[drgqny + 1, drgqnx + 4] = 0x06;
                map[drgqny + 2, drgqnx] = 0x06;
                map[drgqny + 2, drgqnx + 5] = 0x06;
                map[drgqny + 3, drgqnx] = 0x06;
                map[drgqny + 3, drgqnx + 5] = 0x06;
               // Draw Grass
                map[drgqny + 1, drgqnx + 2] = 0x02;
                map[drgqny + 1, drgqnx + 3] = 0x02;
                map[drgqny + 2, drgqnx + 1] = 0x02;
                map[drgqny + 2, drgqnx + 4] = 0x02;
                map[drgqny + 3, drgqnx + 1] = 0x02;
                map[drgqny + 3, drgqnx + 4] = 0x02;
                // Draw More Mountains
                for (int lnM = 1; lnM <= 4; lnM++)
                   map[drgqny + 4, drgqnx + lnM] = 0x01;
*/

            }

            List<int> part1 = new List<int>() { 4, 5, 6, 7 };
            List<int> part2 = new List<int>() { 8, 9, 10, 12, 13, 14 };
            List<int> part3 = new List<int>() { 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 26, 27, 28, 29, 30, 31, 32, 33, 35, 36, 37, 39, 41, 42, 43, 44, 45, 46, 47, 48, 49 };
            List<int> tantegel = new List<int>() { 50, 51, 52, 54, 55, 57, 58, 60, 61, 63 };

            int[,] monsterZones = new int[16, 16];
            for (int lnI = 0; lnI < 16; lnI++)
                for (int lnJ = 0; lnJ < 16; lnJ++)
                    monsterZones[lnI, lnJ] = 0xff;

            int midenMZX = midenX[1] / 16;
            int midenMZY = midenY[1] / 16;

            for (int mzX = 0; mzX < 16; mzX++)
                for (int mzY = 0; mzY < 16; mzY++)
                {
                    //					if (mzX == 10) mzX = mzX; // Why redeclare?
                    if (zone[mzY, mzX] / 1000 == 1)
                    {
                        if (Math.Abs(midenMZX - mzX) == 0 && Math.Abs(midenMZY - mzY) == 0)
                            monsterZones[mzY, mzX] = 4;
                        else
                            monsterZones[mzY, mzX] = part1[r1.Next() % part1.Count];
                    }
                    else if (zone[mzY, mzX] / 1000 == 2)
                        monsterZones[mzY, mzX] = part2[r1.Next() % part2.Count];
                    else
                        monsterZones[mzY, mzX] = part3[r1.Next() % part3.Count];

                    monsterZones[mzY, mzX] += 64 * (r1.Next() % 4);
                }

            bool badMap = true;
            bool compressed = false;
            while (badMap)
            {
                // Now let's enter all of this into the ROM...
                int lnPointer = 0x821a;

                for (int lnI = 0; lnI <= 256; lnI++) // <---- There is a final pointer for lnI = 256, probably indicating the conclusion of the map.
                {
                    romData[0x14028 + (lnI * 2)] = (byte)(lnPointer % 256);
                    romData[0x14029 + (lnI * 2)] = (byte)(lnPointer / 256);

                    int lnJ = 0;
                    while (lnI < 256 && lnJ < 256)
                    {
                        if (map[lnI, lnJ] >= 0 && map[lnI, lnJ] <= 7)
                        {
                            int tileNumber = 0;
                            int numberToMatch = map[lnI, lnJ];
                            while (lnJ < 256 && tileNumber < (numberToMatch == 7 ? 8 : 32) && map[lnI, lnJ] == numberToMatch)
                            {
                                tileNumber++;
                                lnJ++;
                            }
                            romData[lnPointer + 0xc010] = (byte)((0x20 * numberToMatch) + (tileNumber - 1));
                            lnPointer++;
                        }
                        else
                        {
                            romData[lnPointer + 0xc010] = (byte)map[lnI, lnJ];
                            lnPointer++;
                            lnJ++;
                        }
                    }
                }
                if (compressed) badMap = false;

                //lnPointer = lnPointer;
                if (lnPointer > 0x9a94)
                {
                    MessageBox.Show("WARNING:  The map might have taken too much ROM space... (" + (lnPointer - 0x9a94).ToString() + " over)");
                    compressed = true;
                    // Might have to compress further to remove one byte stuff
                    // Must compress the map by getting rid of further 1 byte lakes
                }
                else
                    badMap = false;
            }

            badMap = true;
            compressed = false;
            while (badMap)
            {
                // Now let's enter all of this into the ROM... (Alefgard)
                int lnPointer = 0x9bab;

                for (int lnI = 0; lnI <= 139; lnI++) // <---- There is a final pointer for lnI = 256, probably indicating the conclusion of the map.
                {
                    romData[0x15aa5 + (lnI * 2)] = (byte)(lnPointer % 256);
                    romData[0x15aa6 + (lnI * 2)] = (byte)(lnPointer / 256);

                    int lnJ = 0;
                    while (lnI < 139 && lnJ < 158)
                    {
                        if (map2[lnI, lnJ] >= 0 && map2[lnI, lnJ] <= 7)
                        {
                            int tileNumber = 0;
                            int numberToMatch = map2[lnI, lnJ];
                            while (lnJ < 158 && tileNumber < (numberToMatch == 7 ? 8 : 32) && map2[lnI, lnJ] == numberToMatch)
                            {
                                tileNumber++;
                                lnJ++;
                            }
                            romData[lnPointer + 0xc010] = (byte)((0x20 * numberToMatch) + (tileNumber - 1));
                            lnPointer++;
                        }
                        else
                        {
                            romData[lnPointer + 0xc010] = (byte)map2[lnI, lnJ];
                            lnPointer++;
                            lnJ++;
                        }
                    }
                }
                if (compressed) badMap = false;

                //lnPointer = lnPointer;
                if (lnPointer > 0xa3ee)
                {
                    MessageBox.Show("WARNING:  The map might have taken too much ROM space... (" + (lnPointer - 0xa3ee).ToString() + " over)");
                    compressed = true;
                    // Might have to compress further to remove one byte stuff
                    // Must compress the map by getting rid of further 1 byte lakes
                }
                else
                    badMap = false;
            }

            // Ensure monster zones are 8x8
            if (chkSmallMap.Checked)
            {
                romData[0x2d8] = 0x85;
                romData[0x2d9] = 0x4a;
                romData[0x2da] = 0xa5;
                romData[0x2db] = 0x2b;
                romData[0x2dc] = 0x29;
                romData[0x2dd] = 0xf0;
                romData[0x2de] = 0x0a;
            }

            // Enter monster zones
            for (int lnI = 0; lnI < 16; lnI++)
                for (int lnJ = 0; lnJ < 16; lnJ++)
                {
                    if (monsterZones[lnI, lnJ] == 0xff)
                        monsterZones[lnI, lnJ] = (r1.Next() % 60) + ((r1.Next() % 4) * 64);
                    romData[0x956 + (lnI * 16) + lnJ] = (byte)monsterZones[lnI, lnJ];
                }

            if (chk_GenIslandsMonstersZones.Checked == true)
            {
                string shortVersion = versionNumber.Replace(".", "");
                using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "zones_" + txtSeed.Text + "_" + txtFlags.Text + "_" + shortVersion + ".txt")))
                {
                    for (int lnY = 0; lnY < 16; lnY++)
                    {
                        string output = "";
                        for (int lnX = 0; lnX < 16; lnX++)
                            output += zone[lnY, lnX].ToString().PadLeft(5) + " ";
                        writer.WriteLine(output);
                    }
                }
            }

            if (chk_GenIslandsMonstersZones.Checked == true)
            {
                string shortVersion = versionNumber.Replace(".", "");
                using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "monsters_" + txtSeed.Text + "_" + txtFlags.Text + "_" + shortVersion + ".txt")))
                {
                    for (int lnY = 0; lnY < 16; lnY++)
                    {
                        string output = "";
                        for (int lnX = 0; lnX < 16; lnX++)
                            output += monsterZones[lnY, lnX].ToString("X2") + " ";
                        writer.WriteLine(output);
                    }
                }
            }

            return true;
        }

        private void randomizeNames()
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            string[] maleNames = { "Bran", "Glynn", "Talint", "Numor", "Lars", "Orfeo", "Artho", "Esgar", "Ragnar", "Cristo", "Brey", 
                "Brindar", "Adan", "Glennard", "Theron", "Elucidus", "Harley", "Mathias", "Sartris", "Petrus", "Hiram", "Viron",
                "Taloon", "Pankraz", "Parry", "Carver", "Nevan", "Terry", "Amos", "Kiefer", "Gabo", "Melvin", "Angelo", "Yangus", "Erik", 
                "Sylvando", "Arus", "Luceus", "Lazarel", "Dai", "Alvin", "Ashlay", "Dougie", "Erdwin", "Cobi", "Kendrick", "Hans", "Kiryl",
                "Hendrik", "Laurel", "Hybris", "Jasper", "Joker", "Nalasia", "Charmles", "Kameha", "Laguas", "Odisu", "Psaro", "Trode",
                "Vearn"};
            string[] femaleNames = { "Gwaelin", "Varia", "Elani", "Ollisa", "Roz", "Kailin", "Peta", "Illith", "Gwen", 
                "Alena", "Nara", "Mara", "Bianca", "Debora", "Madchen", "Nera", "Maria", "Patty", "Milly", "Ashlynn", "Maribel", 
                "Aira", "Jessica", "Jade", "Veronica", "Serena", "Lunafrea", "Aurora", "Teresa", "Tara", "Stella", "Aishe", "Aimi", "Ameria",
                "Anlucia", "Beryl", "Lin", "Erinn", "Estella", "Merle", "Mina", "Gemma", "Orifiela", "Serena", "Tania", "Anemone", "Lisette",
                "Minnie", "Medea", "Vistalia"};

            int maleNameCount = maleNames.Length;
            int femaleNameCount = femaleNames.Length;

            int mindex1 = r1.Next() % maleNameCount;
            int mindex2 = r1.Next() % maleNameCount;
            int mindex3 = r1.Next() % maleNameCount;

            int findex1 = r1.Next() % femaleNameCount;
            int findex2 = r1.Next() % femaleNameCount;
            int findex3 = r1.Next() % femaleNameCount;

            // Reroll male index if any of the values are the same (don't want characters with the same name)
            while(mindex1 == mindex2 || mindex1 == mindex3 || mindex2 == mindex3)
            {
                mindex1 = r1.Next() % maleNameCount;
                mindex2 = r1.Next() % maleNameCount;
                mindex3 = r1.Next() % maleNameCount;
            }

            // Reroll female index if any of the values are the same (don't want characters with the same name)
            while (findex1 == findex2 || findex1 == findex3 || findex2 == findex3)
            {
                findex1 = r1.Next() % femaleNameCount;
                findex2 = r1.Next() % femaleNameCount;
                findex3 = r1.Next() % femaleNameCount;
            }

            if (cboGender1.SelectedIndex == 0)
            {
                txtCharName1.Text = maleNames[mindex1];
            }
            else
            {
                txtCharName1.Text = femaleNames[findex1];
            }

            if (cboGender2.SelectedIndex == 0)
            {
                txtCharName2.Text = maleNames[mindex2];
            }
            else
            {
                txtCharName2.Text = femaleNames[findex2];
            }

            if (cboGender3.SelectedIndex == 0)
            {
                txtCharName3.Text = maleNames[mindex3];
            }
            else
            {
                txtCharName3.Text = femaleNames[findex3];
            }
        }

        private void randomizeGender()
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            if (r1.Next() % 2 == 0)
            {
                cboGender1.SelectedIndex = 0;
            }
            else
            {
                cboGender1.SelectedIndex = 1;
            }

            if (r1.Next() % 2 == 0)
            {
                cboGender2.SelectedIndex = 0;
            }
            else
            {
                cboGender2.SelectedIndex = 1;
            }

            if (r1.Next() % 2 == 0)
            {
                cboGender3.SelectedIndex = 0;
            }
            else
            {
                cboGender3.SelectedIndex = 1;
            }
        }

        private bool randomizeClass()
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            int[] availableClasses = new int[8];
            int stringIndex = 0;
            int selectIndex = 0;

            if (chk_RandSoldier.Checked == true)
            {
                availableClasses[stringIndex] = 0;
                stringIndex += 1;
            }

            if (chk_RandPilgrim.Checked == true)
            {
                availableClasses[stringIndex] = 1;
                stringIndex += 1;
            }

            if (chk_RandWizard.Checked == true)
            {
                availableClasses[stringIndex] = 2;
                stringIndex += 1;
            }

            if (chk_RandFighter.Checked == true)
            {
                availableClasses[stringIndex] = 3;
                stringIndex += 1;
            }

            if (chk_RandMerchant.Checked == true)
            {
                availableClasses[stringIndex] = 4;
                stringIndex += 1;
            }

            if (chk_RandGoofOff.Checked == true)
            {
                availableClasses[stringIndex] = 5;
                stringIndex += 1;
            }

            if (chk_RandSage.Checked == true)
            {
                availableClasses[stringIndex] = 6;
                stringIndex += 1;
            }

            if (chk_RandHero.Checked == true)
            {
                availableClasses[stringIndex] = 7;
                stringIndex += 1;
            }

            if (stringIndex == 0)
            {
                MessageBox.Show("No classes selected. Please select at least 1 class");
                return false;
            }
            //            stringIndex -= 1;
            selectIndex = r1.Next() % stringIndex;
            cboClass1.SelectedIndex = availableClasses[selectIndex];
            selectIndex = r1.Next() % stringIndex;
            cboClass2.SelectedIndex = availableClasses[selectIndex];
            selectIndex = r1.Next() % stringIndex;
            cboClass3.SelectedIndex = availableClasses[selectIndex];
            return true;
        }

        private void randEnemyPatterns(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            byte[] monsterSize = { 8, 4, 4, 4, 4, 4, 7, 4, 4, 8, 4, 4, 4, 2, 4, 4,
                4, 4, 5, 5, 2, 4, 4, 5, 4, 4, 4, 4, 4, 4, 3, 2,
                4, 4, 4, 2, 4, 5, 4, 4, 4, 4, 4, 8, 4, 4, 4, 3,
                2, 8, 4, 3, 4, 4, 2, 3, 4, 7, 3, 4, 2, 4, 4, 7,
                8, 3, 3, 4, 3, 2, 3, 4, 4, 4, 4, 4, 4, 3, 3, 4,
                2, 4, 3, 4, 3, 2, 2, 4, 3, 2, 2, 3, 2, 5, 1, 4,
                3, 3, 2, 3, 4, 1, 3, 3, 8, 7, 4, 2, 7, 4, 3, 2,
                3, 3, 3, 3, 3, 3, 3, 4, 4, 2, 1, 2, 4, 2, 3, 3,
                3, 1, 1, 3, 1, 1, 1, 2, 3, 3, 4 };

            // Totally randomize monsters (13805-13cd2)
            for (int lnI = 0; lnI < 0x8a; lnI++)
            {
                if (lnI == 0x85 || lnI == 0x86)
                    continue; // Do not adjust either Zoma.

                //0 - Monster Level (probably used for running away)
                //1 - EXP
                //2 - EXP * 256
                //3 - Agility
                //4 - GP
                //5 - Attack
                //6 - Defense
                //7 - HP
                //8 - MP
                //9 - Item dropped
                //10 = Action 1
                //11 = Action 2(first half related to "AI-Lv)
                //12 = Action 3
                //13 = Action 4(first half related to "Pattern")
                //14 = Action 5(related to # atks, first bit)
                //15 = Action 6(also related to # atks, first bit)
                //16 = Action 7[1] = related to regen
                //17 = Action 8[1] = also related to regen 
                //18 - Bits 0-1 - GPx256, Bits 2-3 - Infernos resist, Bits 4-5 - Ice resist, Bits 6-7 - Fire resist
                //19 - Bits 0-1 - Attackx256, 2-3 - Sacrifice resist, 4-5 - Beat resist, 6-7 - Lightning resist
                //20 - Bits 0-1 - Defx256, 2-3 - Defense resist, 4-5 - Stopspell resist, 6-7 - Sleep resist
                //21 - Bits 0-1 - HPx256, 2-3 - Chaos resist, 4-5 - RobMagic resist, 6-7 - Surround resist
                //22 - Bits 0-3 - Drop chance (1/1, 8, 16, 32, 64, 128, 256, and 2048), 4-5 - Expel resist, 6-7 - Limbo/Slow resist
                byte[] enemyStats = { romData[0x32e3 + (lnI * 23) + 0], romData[0x32e3 + (lnI * 23) + 1], romData[0x32e3 + (lnI * 23) + 2], romData[0x32e3 + (lnI * 23) + 3], romData[0x32e3 + (lnI * 23) + 4],
                    romData[0x32e3 + (lnI * 23) + 5], romData[0x32e3 + (lnI * 23) + 6], romData[0x32e3 + (lnI * 23) + 7], romData[0x32e3 + (lnI * 23) + 8], romData[0x32e3 + (lnI * 23) + 9],
                    romData[0x32e3 + (lnI * 23) + 10], romData[0x32e3 + (lnI * 23) + 11], romData[0x32e3 + (lnI * 23) + 12], romData[0x32e3 + (lnI * 23) + 13], romData[0x32e3 + (lnI * 23) + 14],
                    romData[0x32e3 + (lnI * 23) + 15], romData[0x32e3 + (lnI * 23) + 16], romData[0x32e3 + (lnI * 23) + 17], romData[0x32e3 + (lnI * 23) + 18], romData[0x32e3 + (lnI * 23) + 19],
                    romData[0x32e3 + (lnI * 23) + 20], romData[0x32e3 + (lnI * 23) + 21], romData[0x32e3 + (lnI * 23) + 22] };

                int byteValStart = 0x32e3 + (23 * lnI);

                for (int lnJ = 3; lnJ <= 7; lnJ++)
                {
                    int totalAtk = enemyStats[lnJ] + ((enemyStats[lnJ + 14] % 4) * 256);
                    if (lnJ == 3) totalAtk = enemyStats[lnJ];
                    if (lnJ == 7 && lnI == 0x87) totalAtk = 5; // We want Ortega to die quickly by giving him 5 HP.
                    if (lnJ == 5 && lnI == 0x87) totalAtk = 2000; // ... or win the battle quickly by giving him hoards of strength!  (he still winds up "dead" I think)

                    // Potentially add quadruple the possible gold for each monster.  Average 2 1/2 times...
                    if (lnJ == 4 && totalAtk > 0)
                        totalAtk += (r1.Next() % (totalAtk * 3));
                    else
                    {
                        int atkRandom = (r1.Next() % 3);
                        int atkDiv2 = (totalAtk / 2) + 1;
                        if (atkRandom == 1)
                            totalAtk += (r1.Next() % atkDiv2);
                        else if (atkRandom == 2)
                            totalAtk -= (r1.Next() % atkDiv2);
                    }

                    totalAtk = (totalAtk < 1 ? 1 : totalAtk);
                    totalAtk = (totalAtk > 1020 ? 1020 : totalAtk);
                    if (lnJ == 3)
                        totalAtk = (totalAtk > 255 ? 255 : totalAtk);
                    enemyStats[lnJ] = (byte)(totalAtk % 256);
                    if (lnJ > 3)
                        enemyStats[lnJ + 14] = (byte)(enemyStats[lnJ + 14] - (enemyStats[lnJ + 14] % 4) + (totalAtk / 256));
                }
                if (enemyStats[8] <= 16 && r1.Next() % 2 == 1) enemyStats[8] = (byte)(r1.Next() % 32);
                //enemyStats[8] = 255; // Always make sure the monster has MP

                // Needs to be a "legal treasure..."
                byte[] legalMonsterTreasures = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f,
                                    0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e, 0x1f,
                                    0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f,
                                    0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f,
                                    0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x48, 0x49, 0x4b, 0x4c, 0x4e,
                                    0x55, 0x56, 0x5e, 0x5f,
                                    0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6c, 0x6d,
                                    0x73, 0x74,
                                    0x65, 0x66, 0x67, 0x68, 0x6c, 0x73, 0x74, 0x65, 0x66, 0x67, 0x68, 0x6c, 0x73, 0x74,
                                    0x65, 0x66, 0x67, 0x68, 0x6c, 0x73, 0x74, 0x65, 0x66, 0x67, 0x68, 0x6c, 0x73, 0x74 };
                enemyStats[9] = (legalMonsterTreasures[r1.Next() % legalMonsterTreasures.Length]);

                byte[] res1 = { 0, 0, 0, 0, 0, 1, 2, 3 };
                byte[] res2 = { 0, 0, 0, 0, 1, 1, 2, 3 };
                byte[] res3 = { 0, 0, 0, 1, 1, 2, 2, 3 };
                byte[] res4 = { 0, 0, 1, 1, 2, 2, 3, 3 };
                byte[] res5 = { 0, 1, 1, 2, 2, 3, 3, 3 };
                byte[] res6 = { 0, 1, 2, 2, 3, 3, 3, 3 };
                byte[] res7 = { 0, 1, 2, 3, 3, 3, 3, 3 };
                byte[] finalRes = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int lnJ = 0; lnJ < finalRes.Length; lnJ++)
                {
                    if (lnI < 25)
                        finalRes[lnJ] = (res1[r1.Next() % 8]);
                    else if (lnI < 50)
                        finalRes[lnJ] = (res2[r1.Next() % 8]);
                    else if (lnI < 70)
                        finalRes[lnJ] = (res3[r1.Next() % 8]);
                    else if (lnI < 90)
                        finalRes[lnJ] = (res4[r1.Next() % 8]);
                    else if (lnI < 105)
                        finalRes[lnJ] = (res5[r1.Next() % 8]);
                    else if (lnI < 115)
                        finalRes[lnJ] = (res6[r1.Next() % 8]);
                    else
                        finalRes[lnJ] = (res7[r1.Next() % 8]);
                }

                enemyStats[18] = (byte)(enemyStats[18] % 4 + (finalRes[0] * 4) + (finalRes[1] * 16) + (finalRes[2] * 64));
                enemyStats[19] = (byte)(enemyStats[19] % 4 + (finalRes[3] * 4) + (finalRes[4] * 16) + (finalRes[5] * 64));
                enemyStats[20] = (byte)(enemyStats[20] % 4 + (finalRes[6] * 4) + (finalRes[7] * 16) + (finalRes[8] * 64));
                enemyStats[21] = (byte)(enemyStats[21] % 4 + (finalRes[9] * 4) + (finalRes[10] * 16) + (finalRes[11] * 64));
                // First part:  item drop chance.  Make sure it's at best 1/8.
                if (lnI == 0x36 || lnI == 0x62) // EXCEPT Man-eater Chests and Mimics
                    enemyStats[22] = (byte)(0 + (finalRes[12] * 16) + (finalRes[13] * 64));
                else
                    enemyStats[22] = (byte)(((r1.Next() % 7) + 1) + (finalRes[12] * 16) + (finalRes[13] * 64));

                byte[] enemyPatterns = { 2, 2, 2, 2, 2, 2, 2, 2 };

                // Types of patterns... 0:  Attack only, 1:  "Goofy attack", 2:  Totally random, 3:  Annoying, 4:  Quite annyoing, 5:  Hell monster
                byte[] pattern1 = { 45, 65, 100, 100, 100 };
                byte[] pattern2 = { 35, 60, 90, 100, 100 };
                byte[] pattern3 = { 25, 50, 80, 90, 100 };
                byte[] pattern4 = { 15, 45, 75, 85, 100 };
                byte[] pattern5 = { 10, 40, 70, 85, 100 };
                byte[] pattern6 = { 5, 30, 70, 80, 100 };
                byte[] pattern7 = { 0, 20, 60, 80, 100 };
                byte[] pattern8 = { 0, 10, 50, 60, 100 };
                byte[] pattern9 = { 0, 0, 15, 30, 100 };

                int enemyPattern = r1.Next() % 100;

                if (lnI < 15 || lnI == 0x87 || lnI == 0x68) // Ortega, so he dies quickly, and red slime, because that monster is WAY out of order
                    enemyPattern = (enemyPattern < pattern1[0] ? 0 : enemyPattern < pattern1[1] ? 1 : enemyPattern < pattern1[2] ? 2 : enemyPattern < pattern1[3] ? 3 : 4);
                else if (lnI < 30)
                    enemyPattern = (enemyPattern < pattern2[0] ? 0 : enemyPattern < pattern2[1] ? 1 : enemyPattern < pattern2[2] ? 2 : enemyPattern < pattern2[3] ? 3 : 4);
                else if (lnI < 45 || lnI == 0x88 || lnI == 0x8a) // Kandar 1 and Kandar Henchman
                    enemyPattern = (enemyPattern < pattern3[0] ? 0 : enemyPattern < pattern3[1] ? 1 : enemyPattern < pattern3[2] ? 2 : enemyPattern < pattern3[3] ? 3 : 4);
                else if (lnI < 60)
                    enemyPattern = (enemyPattern < pattern4[0] ? 0 : enemyPattern < pattern4[1] ? 1 : enemyPattern < pattern4[2] ? 2 : enemyPattern < pattern4[3] ? 3 : 4);
                else if (lnI < 75 || lnI == 0x89) // Kandar 2
                    enemyPattern = (enemyPattern < pattern5[0] ? 0 : enemyPattern < pattern5[1] ? 1 : enemyPattern < pattern5[2] ? 2 : enemyPattern < pattern5[3] ? 3 : 4);
                else if (lnI < 90)
                    enemyPattern = (enemyPattern < pattern6[0] ? 0 : enemyPattern < pattern6[1] ? 1 : enemyPattern < pattern6[2] ? 2 : enemyPattern < pattern6[3] ? 3 : 4);
                else if (lnI < 105)
                    enemyPattern = (enemyPattern < pattern7[0] ? 0 : enemyPattern < pattern7[1] ? 1 : enemyPattern < pattern7[2] ? 2 : enemyPattern < pattern7[3] ? 3 : 4);
                else if (lnI < 120)
                    enemyPattern = (enemyPattern < pattern8[0] ? 0 : enemyPattern < pattern8[1] ? 1 : enemyPattern < pattern8[2] ? 2 : enemyPattern < pattern8[3] ? 3 : 4);
                else
                    enemyPattern = (enemyPattern < pattern9[0] ? 0 : enemyPattern < pattern9[1] ? 1 : enemyPattern < pattern9[2] ? 2 : enemyPattern < pattern9[3] ? 3 : 4);

                switch (enemyPattern)
                {
                    case 0: // leave everything alone; it's a basic attack monster.
                        break;
                    case 1: // Give the monster a little goofyness to their attack...
                        for (int lnJ = 0; lnJ < 8; lnJ++)
                        {
                            // 50% chance of setting a different attack.
                            byte[] attackPattern = { 2, 2, 2, 2, 2, 0, 1, 3, 4, 5, 6, 8 };
                            byte random = (attackPattern[r1.Next() % attackPattern.Length]);
                            if (random != 2)
                                enemyPatterns[lnJ] = random;
                        }
                        break;
                    case 2:
                        for (int lnJ = 0; lnJ < 8; lnJ++)
                        {
                            // 75% chance of setting a different attack.
                            byte random = (byte)(r1.Next() % 80);
                            if (random != 2 && random < 64 && random != 0x2b)
                                enemyPatterns[lnJ] = random;
                        }
                        break;
                    case 3:
                        for (int lnJ = 0; lnJ < 8; lnJ++)
                        {
                            // Normal, heroic, poison, faint, heal, healmore (both self and others), sleep, stopspell, weak flames, 
                            // poison and sweet breaths, call for help, double attacks, and strange jigs.
                            byte[] attackPattern = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 3, 4, 5, 6, 8, 9, 10, 13, 16, 17, 19, 22, 23, 28, 34, 35, 36, 38, 39, 41, 45, 49, 54, 59 };
                            byte random = (attackPattern[r1.Next() % attackPattern.Length]);
                            if (random != 2 && random < 64)
                                enemyPatterns[lnJ] = random;
                        }
                        break;
                    case 4:
                        for (int lnJ = 0; lnJ < 8; lnJ++)
                        {
                            byte[] attackPattern = { 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 6, 6, 8, 11, 12, 14, 15, 18, 20, 21, 24, 25, 26, 27, 29, 30, 31, 32, 33, 34, 40, 40, 42, 44, 47, 48, 51, 53, 56, 58, 60 };
                            byte random = (attackPattern[r1.Next() % attackPattern.Length]);
                            if (random != 2 && random < 64)
                                enemyPatterns[lnJ] = random;
                        }
                        break;
                }

                if (lnI == 0x31 || lnI == 0x6c) // Metal slime, Metal Babble
                {
                    if (chk_RemMetalMonRun.Checked == false)
                    {
                        enemyPatterns[0] = 7; // run away
                        enemyPatterns[1] = 7; // run away
                        enemyPatterns[2] = 7; // run away
                        enemyPatterns[3] = 7; // run away
                        if (lnI == 0x41)
                        {
                            enemyPatterns[4] = 7; // run away
                            enemyPatterns[5] = 7; // run away
                        }
                    }
                }

                // Both bits set = 2 attacks guaranteed.  2nd bit set = up to 3 attacks.  1st bit set = up to 2 attacks.
                int badChance = (3 * lnI > 300 ? 300 : 3 * lnI);
                if (r1.Next() % 1000 < badChance / 4)
                    enemyPatterns[5] += 128;
                else if (r1.Next() % 1000 < badChance / 3)
                {
                    enemyPatterns[4] += 128;
                    enemyPatterns[5] += 128;
                }
                else if (r1.Next() % 1000 < badChance)
                    enemyPatterns[4] += 128;

                // Repeat for regeneration.  Both bits = 100 HP / round, 2nd bit = 50 HP / round, 3rd bit = 25 HP / round
                if (r1.Next() % 1000 < badChance / 3)
                {
                    enemyPatterns[6] += 128;
                    enemyPatterns[7] += 128;
                }
                else if (r1.Next() % 1000 < badChance / 2)
                    enemyPatterns[7] += 128;
                else if (r1.Next() % 1000 < badChance)
                    enemyPatterns[6] += 128;

                for (int lnJ = 0; lnJ < 8; lnJ++)
                    enemyStats[10 + lnJ] = (enemyPatterns[lnJ]);

                for (int lnJ = 0; lnJ < 23; lnJ++)
                    romData[byteValStart + lnJ] = enemyStats[lnJ];
            }
        }

        private void randMonsterZones(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }
            // Aliahan 1, 2, 3, Promontory Cave, Tower of Najimi B, 1, 2, Aliahan 4, Enticement Cave 1, 2, Romaly, Kanave, Champange Tower, Noaniels, Dream Cave, Assaram, Isis 1, 2, Pyramid 1, 2, 3
            List<int> gentleZones = new List<int>() { 4, 5, 6, 65, 66, 67, 68, 7, 69, 70, 8, 9, 71, 72, 10, 74, 75, 12, 13, 14, 76, 77, 80 };
            List<int> violentZone1 = new List<int>() { 78, 48, 79, 81 }; // Cave of Necrogund
            List<int> violentZone2 = new List<int>() { 82, 39, 11 }; // Baramos Castle
            List<int> violentZone3 = new List<int>() { 64, 50, 51, 52, 54, 55, 57, 58, 60, 61, 63, 59, 62, 40, 53, 56 };  // Tantegel overworld, caves, and towers
            List<int> violentZone4 = new List<int>() { 25, 34, 38, 63 }; // Zoma's Castle
                                                                         // Totally randomize monster zones
            for (int lnI = 0; lnI < 95; lnI++)
            {
                int byteToUse = 0xaeb + (lnI * 15);
                bool nonViolent = false;
                for (int lnJ = 1; lnJ < 13; lnJ++)
                {
                    if (gentleZones.IndexOf(lnI) != -1)
                        romData[byteToUse + lnJ] = monsterOrder[r1.Next() % ((gentleZones.IndexOf(lnI) * 2) + 8)];
                    else if (violentZone1.Contains(lnI))
                        romData[byteToUse + lnJ] = monsterOrder[(r1.Next() % 92) + 40];
                    else if (violentZone2.Contains(lnI))
                        romData[byteToUse + lnJ] = monsterOrder[(r1.Next() % 72) + 60];
                    else if (violentZone3.Contains(lnI))
                        romData[byteToUse + lnJ] = monsterOrder[(r1.Next() % 56) + 80];
                    else if (violentZone4.Contains(lnI))
                        romData[byteToUse + lnJ] = monsterOrder[(r1.Next() % 37) + 99];
                    else
                    {
                        romData[byteToUse + lnJ] = monsterOrder[r1.Next() % 131];
                        nonViolent = true;
                    }
                }
                if (nonViolent && r1.Next() % 3 == 1)
                {
                    romData[byteToUse + 13] = (byte)(r1.Next() % 20);
                    romData[byteToUse + 14] = (byte)(r1.Next() % 20);
                }
            }

            // Randomize the 19 special battles
            for (int lnI = 0; lnI < 20; lnI++)
            {
                int byteToUse = 0x107a + (6 * lnI);
                for (int lnJ = 0; lnJ < 4; lnJ++)
                {
                    if (r1.Next() % 2 == 1 || lnJ == 3)
                        romData[byteToUse + lnJ] = monsterOrder[r1.Next() % 129];
                }
            }

            // Not sure we can really randomize boss fights... (ff separates boss fights - 0x8ee-0x918 AND 0x919-0x944)
            // But I can change the Mummy Men treasure fights to Shadow fights!
            romData[0x909] = 0x18; // was 0x20 - Mummy Men
                                   // We could randomize the Granite Titan and Boss Troll fights too...
                                   // Maybe remove two of the Kandar Henchmen in the first fight and place two "bonus monsters" in other fights...

        }

        private void randItemEffects(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            //Randomize which items equate to which effects
            //Select 21 items randomly from a set defined as follows:
            int[] legalEffectItems = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f,
                                       0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e, 0x1f,
                                       0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f,
                                       0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f,
                                       0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46 };

            List<int> keyEffectItems = new List<int> { 0x10, 0x11 };

            //Wipe out the use byte by totally resetting the price.
            for (int lnI = 0; lnI < legalEffectItems.Length; lnI++)
            {
                int oldVal = romData[0x11be + legalEffectItems[lnI]];
                romData[0x11be + legalEffectItems[lnI]] = (byte)(oldVal % 32);
                romData[0x11be + legalEffectItems[lnI]] = (byte)(oldVal % 32 >= 16 ? 0x10 : 0x00);
                romData[0x11be + legalEffectItems[lnI]] += (byte)(oldVal % 16 >= 8 ? 0x08 : 0x00);
            }
            int oldVal1 = romData[0x11be + 0x4a];
            romData[0x11be + 0x4a] = (byte)(oldVal1 % 32);
            int oldVal2 = romData[0x11be + 0x5b];
            romData[0x11be + 0x5b] = (byte)(oldVal2 % 32);

            int[] legalItemSpells = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f,
                                      0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e, 0x1f,
                                      0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e,
                                      0x30, 0x31, 0x32, 0x34,
                                      0x38, 0x39, 0x3a }; // restore MP, everyone sneezes, self numb - 54 spells total

            List<int> enemyGroupSpells = new List<int> { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x09, 0x0a, 0x0b, 0x0d, 0x0e, 0x0f,
                                                         0x10, 0x12, 0x13, 0x15, 0x16, 0x17, 0x18, 0x22, 0x24, 0x25, 0x27, 0x2b, 0x2c }; // 25
            List<int> enemyAllSpells = new List<int> { 0x06, 0x07, 0x08, 0x0c, 0x11, 0x14, 0x39 }; // 7
            List<int> allySelfSpells = new List<int> { 0x1a, 0x1b, 0x1c, 0x23, 0x29, 0x2d, 0x30, 0x32, 0x34, 0x38, 0x3a }; // 11
            List<int> allySelectSpells = new List<int> { 0x20, 0x21, 0x28 }; // 3
            List<int> allyAllSpells = new List<int> { 0x19, 0x1d, 0x1e, 0x1f, 0x26, 0x2a, 0x2e, 0x31 }; // 8

            for (int lnI = 0; lnI < 21; lnI++)
            {
                int effectItem = legalEffectItems[r1.Next() % legalEffectItems.Length];
                if (romData[0x11be + effectItem] >= 0x80) // If it's already been selected...
                {
                    lnI--;
                }
                else
                {
                    romData[0x11be + effectItem] += 0x80;
                }
            }

            int iSpell = -1;
            for (int lnI = 0; lnI < legalEffectItems.Length; lnI++)
            {
                // Otherwise, randomize the spell it will be using.
                if (romData[0x11be + legalEffectItems[lnI]] < 0x80)
                    continue;

                int effectSpell = legalItemSpells[r1.Next() % legalItemSpells.Length];
                if (effectSpell == 0x38 && keyEffectItems.Contains(effectSpell)) // Can't let a key item potentially crumble!  Redo that randomization.
                {
                    lnI--;
                    continue;
                }

                iSpell++;
                // Now determine what spell it is... that will determine whether to "attack" yourself, a group of monsters, a selected ally, or all monsters/allies.
                if (enemyGroupSpells.Contains(effectSpell))
                    romData[0x11be + legalEffectItems[lnI]] += 0x60;
                else if (enemyAllSpells.Contains(effectSpell))
                    romData[0x11be + legalEffectItems[lnI]] += 0x20;
                else if (allySelfSpells.Contains(effectSpell)) // 50/50 chance of targetting for self or an ally.
                    romData[0x11be + legalEffectItems[lnI]] += (byte)(r1.Next() % 2 == 1 ? 0x00 : 0x40);
                else if (allySelectSpells.Contains(effectSpell))
                    romData[0x11be + legalEffectItems[lnI]] += 0x40;
                else if (allyAllSpells.Contains(effectSpell))
                    romData[0x11be + legalEffectItems[lnI]] += 0x00;

                romData[0x13280 + iSpell] = (byte)effectSpell;
            }

        }

        private void randEquip(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            // Totally randomize weapons, armor, shields, helmets (13efb-13f1d, 1a00e-1a08b for pricing)

            // Used if chk_UseVanEquipValues
            int[] attackPower = { 2, 7, 12 };
            int[] attackPower2 = { 14, 28, 40, 34, 15, 10, 30, 18, 48, 24, 100, 80, 90, 16, 48, 33, 110, 100, 55, 50, 65, 5, 55, 85, 30, 120, 63, 77, 35, 55 };
            int[] armorDefPower = { 4, 8, 12 };
            int[] armorDefPower2 = { 10, 28, 25, 32, 40, 20, 75, 22, 8, 23, 30, 65, 40, 20, 2, 40, 16, 50, 45, 55, 35 };
            int[] shieldDefPower = { 4, 12, 40, 50, 35, 7, 30 };
            int[] helmetDefPower = { 6, 16, 10, 35, 8, 45, 2, 25 };

            List<int> attackPowerList = new List<int>(attackPower);
            List<int> attackPowerList2 = new List<int>(attackPower2);
            List<int> armorDefPowerList = new List<int>(armorDefPower);
            List<int> armorDefPowerList2 = new List<int>(armorDefPower2);
            List<int> shieldDefPowerList = new List<int>(shieldDefPower);
            List<int> helmetDefPowerList = new List<int>(helmetDefPower);

            if (chk_RemoveStartEqRestrictions.Checked == true)
            {
                for (int lnI = 0; lnI < attackPower2.Length; lnI++)
                    attackPowerList.Add(attackPower2[lnI]);
                for (int lnI = 0; lnI < armorDefPower2.Length; lnI++)
                    armorDefPowerList.Add(armorDefPower2[lnI]);
            }


            for (int lnI = 0; lnI <= 70; lnI++)
            {
                byte power = 0;

                if (chk_RemoveStartEqRestrictions.Checked == true)
                {
                    if (chk_UseVanEquipValues.Checked == true)
                    {
                        int index = 0;

                        if (lnI < 32)
                        {
                            index = r1.Next() % attackPowerList.Count;
                            power = (byte)(attackPowerList[index]);
                            attackPowerList.RemoveAt(index);
                        }
                        else if (lnI < 56)
                        {
                            index = r1.Next() % armorDefPowerList.Count;
                            power = (byte)(armorDefPowerList[index]);
                            armorDefPowerList.RemoveAt(index);
                        }
                        else if (lnI < 63)
                        {
                            index = r1.Next() % shieldDefPowerList.Count;
                            power = (byte)(shieldDefPowerList[index]);
                            shieldDefPowerList.RemoveAt(index);
                        }
                        else
                        {
                            index = r1.Next() % helmetDefPowerList.Count;
                            power = (byte)(helmetDefPowerList[index]);
                            helmetDefPowerList.RemoveAt(index);
                        }
                    }
                    else
                    {
                        if (lnI < 32)
                            power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 243252); // max 130
                        else if (lnI < 56)
                            power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 395284); // max 80
                        else if (lnI < 63)
                            power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 574959); // max 55
                        else
                            power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 903507); // max 35

                    }
                }
                else
                {
                    if (chk_UseVanEquipValues.Checked == true) // Randomize the values of starting equipment separately from all equipment
                    {
                        int index = 0;

                        if (lnI == 0 || lnI == 1 || lnI == 2)
                        {
                            index = r1.Next() % attackPowerList.Count;
                            power = (byte)(attackPowerList[index]);
                            attackPowerList.RemoveAt(index);
                        }
                        else if (lnI == 32 || lnI == 34 || lnI == 48)
                        {
                            index = r1.Next() % armorDefPowerList.Count;
                            power = (byte)(armorDefPowerList[index]);
                            armorDefPowerList.RemoveAt(index);
                        }
                        else if (lnI < 32)
                        {
                            index = r1.Next() % attackPowerList2.Count;
                            power = (byte)(attackPowerList2[index]);
                            attackPowerList2.RemoveAt(index);
                        }
                        else if (lnI < 56)
                        {
                            index = r1.Next() % armorDefPowerList2.Count;
                            power = (byte)(armorDefPowerList2[index]);
                            armorDefPowerList2.RemoveAt(index);
                        }
                        else if (lnI < 63)
                        {
                            index = r1.Next() % shieldDefPowerList.Count;
                            power = (byte)(shieldDefPowerList[index]);
                            shieldDefPowerList.RemoveAt(index);
                        }
                        else
                        {
                            index = r1.Next() % helmetDefPowerList.Count;
                            power = (byte)(helmetDefPowerList[index]);
                            helmetDefPowerList.RemoveAt(index);
                        }
                    }
                    else
                    {
                        if (lnI == 0 || lnI == 1 || lnI == 2 || lnI == 32 || lnI == 34 || lnI == 48)
                            power = (byte)(r1.Next() % 12);
                        else if (lnI < 32)
                            power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 243252); // max 130
                        else if (lnI < 56)
                            power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 395284); // max 80
                        else if (lnI < 63)
                            power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 574959); // max 55
                        else
                            power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 903507); // max 35
                    }
                }
                if (power <= 1)
                {
                    power += 2; // To avoid 0 power and 0 sale price for 1 power weapons and armor
                }
                romData[0x279a0 + lnI] = power;

                if (chk_AdjustEqpPrices.Checked == true)
                {

                    // You want a max price of about 20000, shields 18300, helmets 15000 - Will be slightly higher if using standard powers
                    double price = Math.Round((lnI < 32 ? Math.Pow(power, 2.04) : lnI < 56 ? Math.Pow(power, 2.26) : lnI < 63 ? Math.Pow(power, 2.45) : Math.Pow(power, 2.7)), 0);
                    // TO DO:  Round to the nearest 10 (after 100GP), 50(after 1000 GP), or 100 (after 2500 GP)
                    price = (float)Math.Round(price, 0);

                    //// Remove any price adjustment first.
                    romData[0x11be + lnI] -= (byte)(romData[0x11be + lnI] % 4);
                    if (price >= 10000)
                    {
                        romData[0x11be + lnI] += 3; // Now multiply by 1000
                        price /= 1000;
                    }
                    else if (price >= 1000)
                    {
                        romData[0x11be + lnI] += 2; // Now multiply by 100
                        price /= 100;
                    }
                    else if (price >= 100)
                    {
                        romData[0x11be + lnI] += 1; // Now multiply by 10
                        price /= 10;
                    }
                    else
                    {
                        romData[0x11be + lnI] += 0;
                    }


                    // Must keep special effects if romData is >= 128
                    if (lnI < 80)
                    {
                        if (romData[0x123b + lnI] >= 128)
                            romData[0x123b + lnI] = (byte)(128 + price);
                        else
                            romData[0x123b + lnI] = (byte)(price);
                    }
                }
                if (lnI < 80)
                {
                    if (lnI <= 2)
                    {
                        if ((romData[0x123b + lnI] % 16) >= 8)
                            romData[0x123b + lnI] -= (byte)((romData[0x123b + lnI] % 8) + 1);
                    }
                }
            }
        }

        private void whoCanEquip(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            for (int lnI = 0; lnI <= 70; lnI++)
            {
                // Maintain equipment requirements for the starting equipment
                if (!(lnI == 0x00 || lnI == 0x01 || lnI == 0x02 || lnI == 0x20 || lnI == 0x22 || lnI == 0x30))
                    romData[0x1147 + lnI] = (byte)(r1.Next() % 255 + 1);

                // EXCEPT those that are "FF", update the "who can use the item" to the people who are allowed to equip the item
                if (romData[0x1196 + lnI] != 255 && romData[0x1196 + lnI] != 0 && lnI < 32)
                    romData[0x1196 + lnI] = romData[0x1147 + lnI];
            }
        }

        private void weapArmPower()
        {
            int curseOffset1 = 0;
            int curseOffset2 = 0;

            for (int lnI = 0; lnI < 71; lnI++)
            {
                byte value = romData[0x11be + lnI];
                bool checkCurse = (value & 0x08) == 0x08;

                int iatp = (int)romData[0x279a0 + lnI];
                int iatph = iatp / 100;
                iatp = iatp % 100;
                int iatpt = iatp / 10;
                int iatpo = iatp % 10;

                byte batph = 0x01;
                byte batpt = 0x02;
                byte batpo = 0x03;

                if (iatph == 0)
                    batph = 0x3F;
                else if (iatph > 0)
                    batph = 0x02;
                else if (iatph == 2)
                    batph = 0x03;
                else if (iatph == 3)
                    batph = 0x04;
                else if (iatph == 4)
                    batph = 0x05;
                else if (iatph == 5)
                    batph = 0x06;
                else if (iatph == 6)
                    batph = 0x07;
                else if (iatph == 7)
                    batph = 0x08;
                else if (iatph == 8)
                    batph = 0x09;
                else if (iatph == 9)
                    batph = 0x0a;

                if (iatpt == 0)
                {
                    if (iatph == 0)
                        batpt = 0x3f;
                    else
                        batpt = 0x01;
                }
                else if (iatpt == 1)
                    batpt = 0x02;
                else if (iatpt == 2)
                    batpt = 0x03;
                else if (iatpt == 3)
                    batpt = 0x04;
                else if (iatpt == 4)
                    batpt = 0x05;
                else if (iatpt == 5)
                    batpt = 0x06;
                else if (iatpt == 6)
                    batpt = 0x07;
                else if (iatpt == 7)
                    batpt = 0x08;
                else if (iatpt == 8)
                    batpt = 0x09;
                else if (iatpt == 9)
                    batpt = 0x0a;

                if (iatpo == 0)
                    batpo = 0x01;
                else if (iatpo == 1)
                    batpo = 0x02;
                else if (iatpo == 2)
                    batpo = 0x03;
                else if (iatpo == 3)
                    batpo = 0x04;
                else if (iatpo == 4)
                    batpo = 0x05;
                else if (iatpo == 5)
                    batpo = 0x06;
                else if (iatpo == 6)
                    batpo = 0x07;
                else if (iatpo == 7)
                    batpo = 0x08;
                else if (iatpo == 8)
                    batpo = 0x09;
                else if (iatpo == 9)
                    batpo = 0x0a;


                if (lnI == 0)
                {
                    // Line 1
                    romData[0xad11] = 0x27; // C
                    romData[0xad12] = 0x23; // y
                    romData[0xad13] = 0x1a; // p
                    romData[0xad14] = 0x37; // S
                    romData[0xad15] = 0x1e; // t
                    romData[0xad16] = 0x15; // k
                    romData[0xad17] = 0xff; // Break
                }
                else if (lnI == 1)
                {
                    // Line 1
                    romData[0xad18] = 0x27; // C
                    romData[0xad19] = 0x16; // l
                    romData[0xad1a] = 0x1f; // u
                    romData[0xad1b] = 0x0c; // b
                    romData[0xad1c] = 0xff; // Break
                }
                else if (lnI == 2)
                {
                    // Line 1
                    romData[0xad1d] = 0x27; // C
                    romData[0xad1e] = 0x1a; // p
                    romData[0xad1f] = 0x1c; // r
                    romData[0xad20] = 0x37; // S
                    romData[0xad21] = 0x21; // w
                    romData[0xad22] = 0x0e; // d
                    romData[0xad23] = 0xff; // Break
                }
                else if (lnI == 3)
                {
                    // Line 1
                    romData[0xad24] = 0x31; // M
                    romData[0xad25] = 0x11; // g
                    romData[0xad26] = 0x0d; // c
                    romData[0xad27] = 0x2f; // K
                    romData[0xad28] = 0x18; // n
                    romData[0xad29] = 0x10; // f
                    romData[0xad2a] = 0xff; // Break
                }
                else if (lnI == 4)
                {
                    // Line 1
                    romData[0xad2b] = 0x2d; // I
                    romData[0xad2c] = 0x1c; // r
                    romData[0xad2d] = 0x37; // S
                    romData[0xad2e] = 0x1a; // p
                    romData[0xad2f] = 0x1c; // r
                    romData[0xad30] = 0xff; // Break
                }
                else if (lnI == 5)
                {
                    // Line 1
                    romData[0xad31] = 0x26; // B
                    romData[0xad32] = 0x1e; // t
                    romData[0xad33] = 0x16; // l
                    romData[0xad34] = 0x25; // A
                    romData[0xad35] = 0x22; // x
                    romData[0xad36] = 0xff; // Break
                }
                else if (lnI == 6)
                {
                    // Line 1
                    romData[0xad37] = 0x26; // B
                    romData[0xad38] = 0x1c; // r
                    romData[0xad39] = 0x0e; // d
                    romData[0xad3a] = 0x37; // S
                    romData[0xad3b] = 0x21; // w
                    romData[0xad3c] = 0xff; // Break
                }
                else if (lnI == 7)
                {
                    // Line 1
                    romData[0xad3d] = 0x3b; // W
                    romData[0xad3e] = 0x24; // z
                    romData[0xad3f] = 0x3b; // W
                    romData[0xad40] = 0x18; // n
                    romData[0xad41] = 0x0e; // d
                    romData[0xad42] = 0xff; // Break
                }
                else if (lnI == 8)
                {
                    // Line 1
                    romData[0xad43] = 0x34; // P
                    romData[0xad44] = 0x1d; // s
                    romData[0xad45] = 0x18; // n
                    romData[0xad46] = 0x32; // N
                    romData[0xad47] = 0x0e; // d
                    romData[0xad48] = 0x16; // l
                    romData[0xad49] = 0xff; // Break
                }
                else if (lnI == 9)
                {
                    // Line 1
                    romData[0xad4a] = 0x2d; // I
                    romData[0xad4b] = 0x1c; // r
                    romData[0xad4c] = 0x18; // n
                    romData[0xad4d] = 0x27; // C
                    romData[0xad4e] = 0x16; // l
                    romData[0xad4f] = 0xff; // Break
                }
                else if (lnI == 10)
                {
                    // Line 1
                    romData[0xad50] = 0x38; // T
                    romData[0xad51] = 0x12; // h
                    romData[0xad52] = 0x18; // n
                    romData[0xad53] = 0x3b; // W
                    romData[0xad54] = 0x12; // h
                    romData[0xad55] = 0xff; // Break
                }
                else if (lnI == 11)
                {
                    // Line 1
                    romData[0xad56] = 0x2b; // G
                    romData[0xad57] = 0x18; // n
                    romData[0xad58] = 0x1e; // t
                    romData[0xad59] = 0x37; // S
                    romData[0xad5a] = 0x12; // h
                    romData[0xad5b] = 0x1c; // r
                    romData[0xad5c] = 0xff; // Break
                }
                else if (lnI == 12)
                {
                    // Line 1
                    romData[0xad5d] = 0x27; // C
                    romData[0xad5e] = 0x12; // h
                    romData[0xad5f] = 0x37; // S
                    romData[0xad60] = 0x15; // k
                    romData[0xad61] = 0x16; // l
                    romData[0xad62] = 0xff; // Break
                }
                else if (lnI == 13)
                {
                    // Line 1
                    romData[0xad63] = 0x38; // T
                    romData[0xad64] = 0x12; // h
                    romData[0xad65] = 0x19; // o
                    romData[0xad66] = 0x1c; // r
                    romData[0xad67] = 0x37; // S
                    romData[0xad68] = 0x21; // w
                    romData[0xad69] = 0xff; // Break
                }
                else if (lnI == 14)
                {
                    // Line 1
                    romData[0xad6a] = 0x37; // S
                    romData[0xad6b] = 0x18; // n
                    romData[0xad6c] = 0x21; // w
                    romData[0xad6d] = 0x37; // S
                    romData[0xad6e] = 0x21; // w
                    romData[0xad6f] = 0x0e; // d
                    romData[0xad70] = 0xff; // Break
                }
                else if (lnI == 15)
                {
                    // Line 1
                    romData[0xad71] = 0x28; // D
                    romData[0xad72] = 0x17; // m
                    romData[0xad73] = 0x18; // n
                    romData[0xad74] = 0x25; // A
                    romData[0xad75] = 0x22; // x
                    romData[0xad76] = 0xff; // Break
                }
                else if (lnI == 16)
                {
                    // Line 1
                    romData[0xad77] = 0x36; // R
                    romData[0xad78] = 0x0b; // a
                    romData[0xad79] = 0x13; // i
                    romData[0xad7a] = 0x18; // n
                    romData[0xad7b] = 0x37; // S
                    romData[0xad7c] = 0x1e; // t
                    romData[0xad7d] = 0x10; // f
                    romData[0xad7e] = 0xff; // Break
                }
                else if (lnI == 17)
                {
                    // Line 1
                    romData[0xad7f] = 0x2b; // G
                    romData[0xad80] = 0x0b; // a
                    romData[0xad81] = 0x13; // i
                    romData[0xad82] = 0x0b; // a
                    romData[0xad83] = 0x37; // S
                    romData[0xad84] = 0x21; // w
                    romData[0xad85] = 0x0e; // d
                    romData[0xad86] = 0xff; // Break
                }
                else if (lnI == 18)
                {
                    // Line 1
                    romData[0xad87] = 0x36; // R
                    romData[0xad88] = 0x10; // f
                    romData[0xad89] = 0x16; // l
                    romData[0xad8a] = 0x1e; // t
                    romData[0xad8b] = 0x37; // S
                    romData[0xad8c] = 0x1e; // t
                    romData[0xad8d] = 0x10; // f
                    romData[0xad8e] = 0xff; // Break
                }
                else if (lnI == 19)
                {
                    // Line 1
                    romData[0xad8f] = 0x28; // D
                    romData[0xad90] = 0x1d; // s
                    romData[0xad91] = 0x1e; // t
                    romData[0xad92] = 0x18; // n
                    romData[0xad93] = 0x37; // S
                    romData[0xad94] = 0x21; // w
                    romData[0xad95] = 0x0e; // d
                    romData[0xad96] = 0xff; // Break
                }
                else if (lnI == 20)
                {
                    // Line 1
                    romData[0xad97] = 0x31; // M
                    romData[0xad98] = 0x29; // E
                    romData[0xad99] = 0x0e; // d
                    romData[0xad9a] = 0x11; // g
                    romData[0xad9b] = 0x0f; // e
                    romData[0xad9c] = 0x37; // S
                    romData[0xad9d] = 0x21; // w
                    romData[0xad9e] = 0x0e; // d
                    romData[0xad9f] = 0xff; // Break
                }
                else if (lnI == 21)
                {
                    // Line 1
                    romData[0xada0] = 0x2a; // F
                    romData[0xada1] = 0x1c; // r
                    romData[0xada2] = 0x0d; // c
                    romData[0xada3] = 0x37; // S
                    romData[0xada4] = 0x1e; // t
                    romData[0xada5] = 0x10; // f
                    romData[0xada6] = 0xff; // Break
                }
                else if (lnI == 22)
                {
                    // Line 1
                    romData[0xada7] = 0x2d; // I
                    romData[0xada8] = 0x16; // l
                    romData[0xada9] = 0x1d; // s
                    romData[0xadaa] = 0x18; // n
                    romData[0xadab] = 0x37; // S
                    romData[0xadac] = 0x21; // w
                    romData[0xadad] = 0x0e; // d
                    romData[0xadae] = 0xff; // Break
                }
                else if (lnI == 23)
                {
                    // Line 1
                    romData[0xadaf] = 0x3e; // Z
                    romData[0xadb0] = 0x17; // m
                    romData[0xadb1] = 0x0c; // b
                    romData[0xadb2] = 0x37; // S
                    romData[0xadb3] = 0x16; // l
                    romData[0xadb4] = 0x1d; // s
                    romData[0xadb5] = 0x12; // h
                    romData[0xadb6] = 0x1c; // r
                    romData[0xadb7] = 0xff; // Break
                }
                else if (lnI == 24)
                {
                    // Line 1
                    romData[0xadb8] = 0x2a; // F
                    romData[0xadb9] = 0x0d; // c
                    romData[0xadba] = 0x18; // n
                    romData[0xadbb] = 0x37; // S
                    romData[0xadbc] = 0x21; // w
                    romData[0xadbd] = 0x0e; // d
                    romData[0xadbe] = 0xff; // Break
                }
                else if (lnI == 25)
                {
                    // Line 1
                    romData[0xadbf] = 0x37; // S
                    romData[0xadc0] = 0x16; // l
                    romData[0xadc1] = 0x0e; // d
                    romData[0xadc2] = 0x11; // g
                    romData[0xadc3] = 0x2c; // H
                    romData[0xadc4] = 0x17; // m
                    romData[0xadc5] = 0x1c; // r
                    romData[0xadc6] = 0xff; // Break
                }
                else if (lnI == 26)
                {
                    // Line 1
                    romData[0xadc7] = 0x38; // T
                    romData[0xadc8] = 0x12; // h
                    romData[0xadc9] = 0x18; // n
                    romData[0xadca] = 0x0e; // d
                    romData[0xadcb] = 0x37; // S
                    romData[0xadcc] = 0x21; // w
                    romData[0xadcd] = 0x0e; // d
                    romData[0xadce] = 0xff; // Break
                }
                else if (lnI == 27)
                {
                    // Line 1
                    romData[0xadcf] = 0x38; // T
                    romData[0xadd0] = 0x12; // h
                    romData[0xadd1] = 0x18; // n
                    romData[0xadd2] = 0x0e; // d
                    romData[0xadd3] = 0x37; // S
                    romData[0xadd4] = 0x1e; // t
                    romData[0xadd5] = 0x10; // f
                    romData[0xadd6] = 0xff; // Break
                }
                else if (lnI == 28)
                {
                    // Line 1
                    romData[0xadd7] = 0x2f; // K
                    romData[0xadd8] = 0x13; // i
                    romData[0xadd9] = 0x18; // n
                    romData[0xadda] = 0x11; // g
                    romData[0xaddb] = 0x37; // S
                    romData[0xaddc] = 0x21; // w
                    romData[0xaddd] = 0x0e; // d
                    romData[0xadde] = 0xff; // Break
                }
                else if (lnI == 29)
                {
                    // Line 1
                    romData[0xaddf] = 0x33; // O
                    romData[0xade0] = 0x1c; // r
                    romData[0xade1] = 0x19; // o
                    romData[0xade2] = 0x0d; // c
                    romData[0xade3] = 0x12; // h
                    romData[0xade4] = 0x13; // i
                    romData[0xade5] = 0x37; // S
                    romData[0xade6] = 0x21; // w
                    romData[0xade7] = 0x0e; // d
                    romData[0xade8] = 0xff; // Break
                }
                else if (lnI == 30)
                {
                    // Line 1
                    romData[0xade9] = 0x28; // D
                    romData[0xadea] = 0x1c; // r
                    romData[0xadeb] = 0x11; // g
                    romData[0xadec] = 0x18; // n
                    romData[0xaded] = 0x2f; // K
                    romData[0xadee] = 0x16; // l
                    romData[0xadef] = 0x1c; // r
                    romData[0xadf0] = 0xff; // Break
                }
                else if (lnI == 31)
                {
                    // Line 1
                    romData[0xadf1] = 0x2e; // J
                    romData[0xadf2] = 0x0e; // d
                    romData[0xadf3] = 0x11; // g
                    romData[0xadf4] = 0x17; // m
                    romData[0xadf5] = 0x1e; // t
                    romData[0xadf6] = 0x37; // S
                    romData[0xadf7] = 0x1e; // t
                    romData[0xadf8] = 0x10; // f
                    romData[0xadf9] = 0xff; // Break
                }
                else if (lnI == 32)
                {
                    // Line 1
                    romData[0xadfa] = 0x27; // C
                    romData[0xadfb] = 0x16; // l
                    romData[0xadfc] = 0x19; // o
                    romData[0xadfd] = 0x1e; // t
                    romData[0xadfe] = 0x12; // h
                    romData[0xadff] = 0x0f; // e
                    romData[0xae00] = 0x1d; // s
                    romData[0xae01] = 0xff; // Break
                }
                else if (lnI == 33)
                {
                    // Line 1
                    romData[0xae02] = 0x38; // T
                    romData[0xae03] = 0x1c; // r
                    romData[0xae04] = 0x18; // n
                    romData[0xae05] = 0x11; // g
                    romData[0xae06] = 0x37; // S
                    romData[0xae07] = 0x1e; // t
                    romData[0xae08] = 0xff; // Break
                }
                else if (lnI == 34)
                {
                    // Line 1
                    romData[0xae09] = 0x30; // L
                    romData[0xae0a] = 0x1e; // t
                    romData[0xae0b] = 0x12; // h
                    romData[0xae0c] = 0x1c; // r
                    romData[0xae0d] = 0x25; // A
                    romData[0xae0e] = 0x1c; // r
                    romData[0xae0f] = 0xff; // Break
                }
                else if (lnI == 35)
                {
                    // Line 1
                    romData[0xae10] = 0x2a; // F
                    romData[0xae11] = 0x16; // l
                    romData[0xae12] = 0x1d; // s
                    romData[0xae13] = 0x12; // h
                    romData[0xae14] = 0x27; // C
                    romData[0xae15] = 0x16; // l
                    romData[0xae16] = 0xff; // Break
                }
                else if (lnI == 36)
                {
                    // Line 1
                    romData[0xae17] = 0x2c; // H
                    romData[0xae18] = 0x0b; // a
                    romData[0xae19] = 0x16; // l
                    romData[0xae1a] = 0x10; // f
                    romData[0xae1b] = 0x34; // P
                    romData[0xae1c] = 0x16; // l
                    romData[0xae1d] = 0x25; // A
                    romData[0xae1e] = 0x1c; // r
                    romData[0xae1f] = 0xff; // Break
                }
                else if (lnI == 37)
                {
                    // Line 1
                    romData[0xae20] = 0x2a; // F
                    romData[0xae21] = 0x1f; // u
                    romData[0xae22] = 0x16; // l
                    romData[0xae23] = 0x16; // l
                    romData[0xae24] = 0x34; // P
                    romData[0xae25] = 0x16; // l
                    romData[0xae26] = 0x25; // A
                    romData[0xae27] = 0x1c; // r
                    romData[0xae28] = 0xff; // Break
                }
                else if (lnI == 38)
                {
                    // Line 1
                    romData[0xae29] = 0x31; // M
                    romData[0xae2a] = 0x0b; // a
                    romData[0xae2b] = 0x11; // g
                    romData[0xae2c] = 0x13; // i
                    romData[0xae2d] = 0x0d; // c
                    romData[0xae2e] = 0x25; // A
                    romData[0xae2f] = 0x1c; // r
                    romData[0xae30] = 0xff; // Break
                }
                else if (lnI == 39)
                {
                    // Line 1
                    romData[0xae31] = 0x29; // E
                    romData[0xae32] = 0x20; // v
                    romData[0xae33] = 0x27; // C
                    romData[0xae34] = 0x16; // l
                    romData[0xae35] = 0x19; // o
                    romData[0xae36] = 0x0b; // a
                    romData[0xae37] = 0x15; // k
                    romData[0xae38] = 0xff; // Break
                }
                else if (lnI == 40)
                {
                    // Line 1
                    romData[0xae39] = 0x36; // R
                    romData[0xae3a] = 0x0b; // a
                    romData[0xae3b] = 0x0e; // d
                    romData[0xae3c] = 0x13; // i
                    romData[0xae3d] = 0x0b; // a
                    romData[0xae3e] = 0x18; // n
                    romData[0xae3f] = 0x1e; // t
                    romData[0xae40] = 0x25; // A
                    romData[0xae41] = 0x1c; // r
                    romData[0xae42] = 0xff; // Break
                }
                else if (lnI == 41)
                {
                    // Line 1
                    romData[0xae43] = 0x2d; // I
                    romData[0xae44] = 0x1c; // r
                    romData[0xae45] = 0x19; // o
                    romData[0xae46] = 0x18; // n
                    romData[0xae47] = 0x25; // A
                    romData[0xae48] = 0x1a; // p
                    romData[0xae49] = 0xff; // Break
                }
                else if (lnI == 42)
                {
                    // Line 1
                    romData[0xae4a] = 0x25; // A
                    romData[0xae4b] = 0x18; // n
                    romData[0xae4c] = 0x13; // i
                    romData[0xae4d] = 0x17; // m
                    romData[0xae4e] = 0x0b; // a
                    romData[0xae4f] = 0x16; // l
                    romData[0xae50] = 0x37; // S
                    romData[0xae51] = 0x1f; // u
                    romData[0xae52] = 0x13; // i
                    romData[0xae53] = 0x1e; // t
                    romData[0xae54] = 0xff; // Break
                }
                else if (lnI == 43)
                {
                    // Line 1
                    romData[0xae55] = 0x2a; // F
                    romData[0xae56] = 0x13; // i
                    romData[0xae57] = 0x11; // g
                    romData[0xae58] = 0x12; // h
                    romData[0xae59] = 0x1e; // t
                    romData[0xae5a] = 0x37; // S
                    romData[0xae5b] = 0x1f; // u
                    romData[0xae5c] = 0x13; // i
                    romData[0xae5d] = 0x1e; // t
                    romData[0xae5e] = 0xff; // Break
                }
                else if (lnI == 44)
                {
                    // Line 1
                    romData[0xae5f] = 0x37; // S
                    romData[0xae60] = 0x0d; // c
                    romData[0xae61] = 0x1c; // r
                    romData[0xae62] = 0x0e; // d
                    romData[0xae63] = 0x36; // R
                    romData[0xae64] = 0x0c; // b
                    romData[0xae65] = 0xff; // Break
                }
                else if (lnI == 45)
                {
                    // Line 1
                    romData[0xae66] = 0x2c; // H
                    romData[0xae67] = 0x0b; // a
                    romData[0xae68] = 0x0e; // d
                    romData[0xae69] = 0x0f; // e
                    romData[0xae6a] = 0x1d; // s
                    romData[0xae6b] = 0x25; // A
                    romData[0xae6c] = 0x1c; // r
                    romData[0xae6d] = 0xff; // Break
                }
                else if (lnI == 46)
                {
                    // Line 1
                    romData[0xae6e] = 0x3b; // W
                    romData[0xae6f] = 0x1e; // t
                    romData[0xae70] = 0x1c; // r
                    romData[0xae71] = 0x2a; // F
                    romData[0xae72] = 0x16; // l
                    romData[0xae73] = 0x23; // y
                    romData[0xae74] = 0x27; // C
                    romData[0xae75] = 0x16; // l
                    romData[0xae76] = 0xff; // Break
                }
                else if (lnI == 47)
                {
                    // Line 1
                    romData[0xae77] = 0x27; // C
                    romData[0xae78] = 0x12; // h
                    romData[0xae79] = 0x31; // M
                    romData[0xae7a] = 0x0b; // a
                    romData[0xae7b] = 0x13; // i
                    romData[0xae7c] = 0x16; // l
                    romData[0xae7d] = 0xff; // Break
                }
                else if (lnI == 48)
                {
                    // Line 1
                    romData[0xae7e] = 0x3b; // W
                    romData[0xae7f] = 0x0b; // a
                    romData[0xae80] = 0x23; // y
                    romData[0xae81] = 0x10; // f
                    romData[0xae82] = 0x1c; // r
                    romData[0xae83] = 0x27; // C
                    romData[0xae84] = 0x16; // l
                    romData[0xae85] = 0xff; // Break
                }
                else if (lnI == 49)
                {
                    // Line 1
                    romData[0xae86] = 0x36; // R
                    romData[0xae87] = 0x0f; // e
                    romData[0xae88] = 0x20; // v
                    romData[0xae89] = 0x0f; // e
                    romData[0xae8a] = 0x0b; // a
                    romData[0xae8b] = 0x16; // l
                    romData[0xae8c] = 0x37; // S
                    romData[0xae8d] = 0x21; // w
                    romData[0xae8e] = 0x17; // m
                    romData[0xae8f] = 0x1d; // s
                    romData[0xae90] = 0x1e; // t
                    romData[0xae91] = 0xff; // Break
                }
                else if (lnI == 50)
                {
                    // Line 1
                    romData[0xae92] = 0x31; // M
                    romData[0xae93] = 0x11; // g
                    romData[0xae94] = 0x26; // B
                    romData[0xae95] = 0x13; // i
                    romData[0xae96] = 0x15; // k
                    romData[0xae97] = 0x13; // i
                    romData[0xae98] = 0x18; // n
                    romData[0xae99] = 0x13; // i
                    romData[0xae9a] = 0xff; // Break
                }
                else if (lnI == 51)
                {
                    // Line 1
                    romData[0xae9b] = 0x37; // S
                    romData[0xae9c] = 0x12; // h
                    romData[0xae9d] = 0x0f; // e
                    romData[0xae9e] = 0x16; // l
                    romData[0xae9f] = 0x16; // l
                    romData[0xaea0] = 0x25; // A
                    romData[0xaea1] = 0x1c; // r
                    romData[0xaea2] = 0xff; // Break
                }
                else if (lnI == 52)
                {
                    // Line 1
                    romData[0xaea3] = 0x38; // T
                    romData[0xaea4] = 0x0f; // e
                    romData[0xaea5] = 0x1c; // r
                    romData[0xaea6] = 0x1c; // r
                    romData[0xaea7] = 0x0b; // a
                    romData[0xaea8] = 0x10; // f
                    romData[0xaea9] = 0x17; // m
                    romData[0xaeaa] = 0x25; // A
                    romData[0xaeab] = 0x1c; // r
                    romData[0xaeac] = 0xff; // Break
                }
                else if (lnI == 53)
                {
                    // Line 1
                    romData[0xaead] = 0x28; // D
                    romData[0xaeae] = 0x1c; // r
                    romData[0xaeaf] = 0x11; // g
                    romData[0xaeb0] = 0x31; // M
                    romData[0xaeb1] = 0x0b; // a
                    romData[0xaeb2] = 0x13; // i
                    romData[0xaeb3] = 0x16; // l
                    romData[0xaeb4] = 0xff; // Break
                }
                else if (lnI == 54)
                {
                    // Line 1
                    romData[0xaeb5] = 0x37; // S
                    romData[0xaeb6] = 0x21; // w
                    romData[0xaeb7] = 0x0f; // e
                    romData[0xaeb8] = 0x0e; // d
                    romData[0xaeb9] = 0x11; // g
                    romData[0xaeba] = 0x0f; // e
                    romData[0xaebb] = 0x25; // A
                    romData[0xaebc] = 0x1c; // r
                    romData[0xaebd] = 0xff; // Break
                }
                else if (lnI == 55)
                {
                    // Line 1
                    romData[0xaebe] = 0x25; // A
                    romData[0xaebf] = 0x18; // n
                    romData[0xaec0] = 0x11; // g
                    romData[0xaec1] = 0x0f; // e
                    romData[0xaec2] = 0x16; // l
                    romData[0xaec3] = 0x36; // R
                    romData[0xaec4] = 0x0c; // b
                    romData[0xaec5] = 0xff; // Break
                }
                else if (lnI == 56)
                {
                    // Line 1
                    romData[0xaec6] = 0x30; // L
                    romData[0xaec7] = 0x1e; // t
                    romData[0xaec8] = 0x12; // h
                    romData[0xaec9] = 0x1c; // r
                    romData[0xaeca] = 0x37; // S
                    romData[0xaecb] = 0x12; // h
                    romData[0xaecc] = 0x16; // l
                    romData[0xaecd] = 0x0e; // d
                    romData[0xaece] = 0xff; // Break
                }
                else if (lnI == 57)
                {
                    // Line 1
                    romData[0xaecf] = 0x2d; // I
                    romData[0xaed0] = 0x1c; // r
                    romData[0xaed1] = 0x18; // n
                    romData[0xaed2] = 0x37; // S
                    romData[0xaed3] = 0x12; // h
                    romData[0xaed4] = 0x16; // l
                    romData[0xaed5] = 0x0e; // d
                    romData[0xaed6] = 0xff; // Break
                }
                else if (lnI == 58)
                {
                    // Line 1
                    romData[0xaed7] = 0x37; // S
                    romData[0xaed8] = 0x1e; // t
                    romData[0xaed9] = 0x1c; // r
                    romData[0xaeda] = 0x37; // S
                    romData[0xaedb] = 0x12; // h
                    romData[0xaedc] = 0x16; // l
                    romData[0xaedd] = 0x0e; // d
                    romData[0xaede] = 0xff; // Break
                }
                else if (lnI == 59)
                {
                    // Line 1
                    romData[0xaedf] = 0x2c; // H
                    romData[0xaee0] = 0x0f; // e
                    romData[0xaee1] = 0x1c; // r
                    romData[0xaee2] = 0x19; // o
                    romData[0xaee3] = 0x37; // S
                    romData[0xaee4] = 0x12; // h
                    romData[0xaee5] = 0x16; // l
                    romData[0xaee6] = 0x0e; // d
                    romData[0xaee7] = 0xff; // Break
                }
                else if (lnI == 60)
                {
                    // Line 1
                    romData[0xaee8] = 0x37; // S
                    romData[0xaee9] = 0x1c; // r
                    romData[0xaeea] = 0x21; // w
                    romData[0xaeeb] = 0x37; // S
                    romData[0xaeec] = 0x12; // h
                    romData[0xaeed] = 0x16; // l
                    romData[0xaeee] = 0x0e; // d
                    romData[0xaeef] = 0xff; // Break
                }
                else if (lnI == 61)
                {
                    // Line 1
                    romData[0xaef0] = 0x26; // B
                    romData[0xaef1] = 0x1c; // r
                    romData[0xaef2] = 0x24; // z
                    romData[0xaef3] = 0x37; // S
                    romData[0xaef4] = 0x12; // h
                    romData[0xaef5] = 0x16; // l
                    romData[0xaef6] = 0x0e; // d
                    romData[0xaef7] = 0xff; // Break
                }
                else if (lnI == 62)
                {
                    // Line 1
                    romData[0xaef8] = 0x37; // S
                    romData[0xaef9] = 0x16; // l
                    romData[0xaefa] = 0x20; // v
                    romData[0xaefb] = 0x37; // S
                    romData[0xaefc] = 0x12; // h
                    romData[0xaefd] = 0x16; // l
                    romData[0xaefe] = 0x0e; // d
                    romData[0xaeff] = 0xff; // Break
                }
                else if (lnI == 63)
                {
                    // Line 1
                    romData[0xaf00] = 0x2b; // G
                    romData[0xaf01] = 0x19; // o
                    romData[0xaf02] = 0x16; // l
                    romData[0xaf03] = 0x0e; // d
                    romData[0xaf04] = 0x3f; // Space
                    romData[0xaf05] = 0x27; // C
                    romData[0xaf06] = 0x1c; // r
                    romData[0xaf07] = 0x19; // o
                    romData[0xaf08] = 0x21; // w
                    romData[0xaf09] = 0x18; // n
                    romData[0xaf0a] = 0xff; // Break
                }
                else if (lnI == 64)
                {
                    // Line 1
                    romData[0xaf0b] = 0x2d; // I
                    romData[0xaf0c] = 0x2c; // H
                    romData[0xaf0d] = 0x17; // m
                    romData[0xaf0e] = 0x1e; // t
                    romData[0xaf0f] = 0xff; // Break

                    // Line 2
                    romData[0xb275] = 0x00;
                    romData[0xb276] = 0x00;
                    romData[0xb277] = 0x00;
                    romData[0xb278] = 0x00;
                    romData[0xb279] = 0x00;
                    romData[0xb27a] = 0x00;
                }
                else if (lnI == 65)
                {
                    // Line 1
                    romData[0xaf10] = 0x31; // M
                    romData[0xaf11] = 0x23; // y
                    romData[0xaf12] = 0x1d; // s
                    romData[0xaf13] = 0x23; // y
                    romData[0xaf14] = 0x2c; // H
                    romData[0xaf15] = 0x1e; // t
                    romData[0xaf16] = 0xff; // Break
                }
                else if (lnI == 66)
                {
                    // Line 1
                    romData[0xaf17] = 0x39; // U
                    romData[0xaf18] = 0x18; // n
                    romData[0xaf19] = 0x16; // l
                    romData[0xaf1a] = 0x15; // k
                    romData[0xaf1b] = 0x2c; // H
                    romData[0xaf1c] = 0x16; // l
                    romData[0xaf1d] = 0x17; // m
                    romData[0xaf1e] = 0x1e; // t
                    romData[0xaf1f] = 0xff; // Break
                }
                else if (lnI == 67)
                {
                    // Line 1
                    romData[0xaf20] = 0x38; // T
                    romData[0xaf21] = 0x1c; // r
                    romData[0xaf22] = 0x0c; // b
                    romData[0xaf23] = 0x18; // n
                    romData[0xaf24] = 0xff; // Break
                }
                else if (lnI == 68)
                {
                    // Line 1
                    romData[0xaf25] = 0x32; // N
                    romData[0xaf26] = 0x19; // o
                    romData[0xaf27] = 0x12; // h
                    romData[0xaf28] = 0x31; // M
                    romData[0xaf29] = 0x1d; // s
                    romData[0xaf2a] = 0x15; // k
                    romData[0xaf2b] = 0xff; // Break
                }
                else if (lnI == 69)
                {
                    // Line 1
                    romData[0xaf2c] = 0x30; // L
                    romData[0xaf2d] = 0x1e; // t
                    romData[0xaf2e] = 0x12; // h
                    romData[0xaf2f] = 0x2c; // H
                    romData[0xaf30] = 0x16; // l
                    romData[0xaf31] = 0x17; // m
                    romData[0xaf32] = 0x1e; // t
                    romData[0xaf33] = 0xff; // Break
                }
                else if (lnI == 70)
                {
                    // Line 1
                    romData[0xaf34] = 0x2d; // I
                    romData[0xaf35] = 0x1c; // r
                    romData[0xaf36] = 0x18; // n
                    romData[0xaf37] = 0x31; // M
                    romData[0xaf38] = 0x1d; // s
                    romData[0xaf39] = 0x15; // k
                    romData[0xaf3a] = 0xff; // Break
                }
                if (lnI < 32)
                {
                    romData[0xb0e0 + lnI * 6 + curseOffset1] = 0x25; // A
                    romData[0xb0e0 + lnI * 6 + 1 + curseOffset1] = 0x75; // :
                    romData[0xb0e0 + lnI * 6 + 2 + curseOffset1] = batph; // Hundreds
                    romData[0xb0e0 + lnI * 6 + 3 + curseOffset1] = batpt; // Tens
                    romData[0xb0e0 + lnI * 6 + 4 + curseOffset1] = batpo; // Ones
                    if (checkCurse)
                    {
                        romData[0xb0e0 + lnI * 6 + 5 + curseOffset1] = 0x5a; // *
                        romData[0xb0e0 + lnI * 6 + 6 + curseOffset1] = 0xff; // Break
                        curseOffset1 += 1;
                    }
                    else
                        romData[0xb0e0 + lnI * 6 + 5 + curseOffset1] = 0xff; // Break
                }
                else if (lnI < 64)
                {
                    romData[0xb0e0 + lnI * 6 + curseOffset1] = 0x28; // D
                    romData[0xb0e0 + lnI * 6 + 1 + curseOffset1] = 0x75; // :
                    romData[0xb0e0 + lnI * 6 + 2 + curseOffset1] = batph; // Hundreds
                    romData[0xb0e0 + lnI * 6 + 3 + curseOffset1] = batpt; // Tens
                    romData[0xb0e0 + lnI * 6 + 4 + curseOffset1] = batpo; // Ones
                    if (checkCurse)
                    {
                        romData[0xb0e0 + lnI * 6 + 5 + curseOffset1] = 0x5a; // *
                        romData[0xb0e0 + lnI * 6 + 6 + curseOffset1] = 0xff; // Break
                        curseOffset1 += 1;
                    }
                    else
                        romData[0xb0e0 + lnI * 6 + 5 + curseOffset1] = 0xff; // Break
                }
                else
                {
                    romData[0xb27b + (lnI - 64) * 6 + curseOffset2] = 0x28; // D
                    romData[0xb27b + (lnI - 64) * 6 + 1 + curseOffset2] = 0x75; // :
                    romData[0xb27b + (lnI - 64) * 6 + 2 + curseOffset2] = batph; // Hundreds
                    romData[0xb27b + (lnI - 64) * 6 + 3 + curseOffset2] = batpt; // Tens
                    romData[0xb27b + (lnI - 64) * 6 + 4 + curseOffset2] = batpo; // Ones
                    if (checkCurse)
                    {
                        romData[0xb27b + (lnI - 64) * 6 + 5 + curseOffset2] = 0x5a; // *
                        romData[0xb27b + (lnI - 64) * 6 + 6 + curseOffset2] = 0xff; // Break
                        curseOffset2 += 1;
                    }
                    else
                        romData[0xb27b + (lnI - 64) * 6 + 5 + curseOffset2] = 0xff; // Break
                }
            }


        }

        private void removeFightPenalty()
        {
            romData[0x1507] = romData[0x1508] = romData[0x1509] = romData[0x150a] = 0xea;
        }

        private void randSpellLearning(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }
            
            // Totally randomize spell learning
            // First, clear out all of the magic bytes...
            for (int lnI = 0; lnI < 252; lnI++)
                romData[0x29d6 + lnI] = 0x3f;

            // There are 64 fight spells overall, and 24 command spells overall.  Make sure that each fight spell is in the final list, then scramble after that.  Make sure there are no more than three copies of a spell, 
            // make sure there are no duplicates in blocks 0-15, 16-39, and 40-63.  Any command spells that duplicate the fight spells should be placed in their respective blocks.
            int[] finalFight = new int[64];
            int[] finalCommand = new int[24];
            for (int i = 0; i < finalFight.Length; i++) finalFight[i] = -1;
            for (int i = 0; i < finalCommand.Length; i++) finalCommand[i] = -1;

            int[] fightSpells = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 48, 49, 50, 51, 52, 53 }; // 52 (12-20-20)
            int[] commandSpells = { 26, 27, 28, 30, 31, 32, 33, 38, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61 }; // 18 (6-6-6)
            for (int lnI = 0; lnI < fightSpells.Length * 20; lnI++)
                swapArray(fightSpells, (r1.Next() % fightSpells.Length), (r1.Next() % fightSpells.Length));
            for (int lnI = 0; lnI < commandSpells.Length * 20; lnI++)
                swapArray(commandSpells, (r1.Next() % commandSpells.Length), (r1.Next() % commandSpells.Length));

            int[] heroFight2 = new int[16];
            int[] pilgrimFight2 = new int[24];
            int[] wizardFight2 = new int[24];

            for (int lnI = 0; lnI < 52; lnI++)
            {
                if (lnI < 12) heroFight2[lnI] = fightSpells[lnI];
                else if (lnI < 32) pilgrimFight2[lnI - 12] = fightSpells[lnI];
                else wizardFight2[lnI - 32] = fightSpells[lnI];
            }

            for (int lnI = 12; lnI < 16; lnI++)
            {
                heroFight2[lnI] = fightSpells[r1.Next() % fightSpells.Length];
                for (int lnJ = 0; lnJ < lnI; lnJ++)
                    if (heroFight2[lnJ] == heroFight2[lnI])
                    {
                        lnI--;
                        break;
                    }
            }
            for (int lnI = 20; lnI < 24; lnI++)
            {
                pilgrimFight2[lnI] = fightSpells[r1.Next() % fightSpells.Length];
                for (int lnJ = 0; lnJ < lnI; lnJ++)
                    if (pilgrimFight2[lnJ] == pilgrimFight2[lnI])
                    {
                        lnI--;
                        break;
                    }
            }
            for (int lnI = 20; lnI < 24; lnI++)
            {
                wizardFight2[lnI] = fightSpells[r1.Next() % fightSpells.Length];
                for (int lnJ = 0; lnJ < lnI; lnJ++)
                    if (wizardFight2[lnJ] == wizardFight2[lnI])
                    {
                        lnI--;
                        break;
                    }
            }

            int[] heroCommand2 = new int[8];
            int[] pilgrimCommand2 = new int[8];
            int[] wizardCommand2 = new int[8];

            for (int lnI = 0; lnI < 18; lnI++)
            {
                if (lnI < 6) heroCommand2[lnI] = commandSpells[lnI];
                else if (lnI < 12) pilgrimCommand2[lnI - 6] = commandSpells[lnI];
                else wizardCommand2[lnI - 12] = commandSpells[lnI];
            }

            for (int lnI = 6; lnI < 8; lnI++)
            {
                heroCommand2[lnI] = commandSpells[r1.Next() % commandSpells.Length];
                for (int lnJ = 0; lnJ < lnI; lnJ++)
                    if (heroCommand2[lnJ] == heroCommand2[lnI])
                    {
                        lnI--;
                        break;
                    }
            }
            for (int lnI = 6; lnI < 8; lnI++)
            {
                pilgrimCommand2[lnI] = commandSpells[r1.Next() % commandSpells.Length];
                for (int lnJ = 0; lnJ < lnI; lnJ++)
                    if (pilgrimCommand2[lnJ] == pilgrimCommand2[lnI])
                    {
                        lnI--;
                        break;
                    }
            }
            for (int lnI = 6; lnI < 8; lnI++)
            {
                wizardCommand2[lnI] = commandSpells[r1.Next() % commandSpells.Length];
                for (int lnJ = 0; lnJ < lnI; lnJ++)
                    if (wizardCommand2[lnJ] == wizardCommand2[lnI])
                    {
                        lnI--;
                        break;
                    }
            }

            int[] heroFightLevels = inverted_power_curve(1, 35, 24, 1, r1);
            int[] pilgrimFightLevels = inverted_power_curve(1, 35, 24, 1, r1);
            int[] wizardFightLevels = inverted_power_curve(1, 35, 24, 1, r1);
            int[] heroCommandLevels = inverted_power_curve(1, 35, 8, 1, r1);
            int[] pilgrimCommandLevels = inverted_power_curve(1, 35, 8, 1, r1);
            int[] wizardCommandLevels = inverted_power_curve(1, 35, 8, 1, r1);

            for (int lnI = 0; lnI < 8; lnI++)
            {
                romData[0x29d6 + heroCommand2[lnI]] = (byte)heroCommandLevels[lnI]; // (byte)(r1.Next() % 35 + 1);
                romData[0x2a15 + pilgrimCommand2[lnI]] = (byte)pilgrimCommandLevels[lnI]; // (r1.Next() % 35 + 1);
                romData[0x2a54 + wizardCommand2[lnI]] = (byte)wizardCommandLevels[lnI]; // (r1.Next() % 35 + 1);
                romData[0x2a93 + pilgrimCommand2[lnI]] = romData[0x2a15 + pilgrimCommand2[lnI]];
                romData[0x2a93 + wizardCommand2[lnI]] = romData[0x2a54 + wizardCommand2[lnI]];
                romData[0x22e7 + 24 + lnI] = (byte)heroCommand2[lnI];
                romData[0x22e7 + 32 + 24 + lnI] = (byte)pilgrimCommand2[lnI];
                romData[0x22e7 + 64 + 24 + lnI] = (byte)wizardCommand2[lnI];
            }

            romData[0x29d6 + 63 + romData[0x22e7 + 32 + 24]] = 1;
            romData[0x29d6 + 126 + romData[0x22e7 + 64 + 24]] = 1;

            for (int lnI = 0; lnI < 24; lnI++)
            {
                if (lnI < 16)
                    romData[0x29d6 + heroFight2[lnI]] = (byte)heroFightLevels[lnI]; // (byte)(r1.Next() % 35 + 1);
                romData[0x2a15 + pilgrimFight2[lnI]] = (byte)pilgrimFightLevels[lnI]; // (byte)(r1.Next() % 35 + 1);
                romData[0x2a54 + wizardFight2[lnI]] = (byte)wizardFightLevels[lnI]; // (byte)(r1.Next() % 35 + 1);
                romData[0x2a93 + pilgrimFight2[lnI]] = romData[0x2a15 + pilgrimFight2[lnI]];
                romData[0x2a93 + wizardFight2[lnI]] = romData[0x2a54 + wizardFight2[lnI]];
                if (lnI < 16)
                    romData[0x22e7 + lnI] = (byte)heroFight2[lnI];
                romData[0x22e7 + 32 + lnI] = (byte)pilgrimFight2[lnI];
                romData[0x22e7 + 64 + lnI] = (byte)wizardFight2[lnI];
            }
            romData[0x29d6 + romData[0x22e7]] = 2;

            // Must "complete the sentence" or really bad things happen...
            romData[0x29d6 + 62] = 0xff;
            romData[0x29d6 + 125] = 0xff;
            romData[0x29d6 + 188] = 0xff;
            romData[0x29d6 + 251] = 0xff;

            // Copy arrays to be written out later
            heroComSpell = heroCommand2;
            heroComLvl = heroCommandLevels;
            heroBatSpell = heroFight2;
            heroBatLvl = heroFightLevels;
            pilgrimComSpell = pilgrimCommand2;
            pilgrimComLvl = pilgrimCommandLevels;
            pilgrimBatSpell = pilgrimFight2;
            pilgrimBatLvl = pilgrimFightLevels;
            wizardComSpell = wizardCommand2;
            wizardComLvl = wizardCommandLevels;
            wizardBatSpell = wizardFight2;
            wizardBatLvl = wizardFightLevels;

        }

        private void randSpellStrength(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }
            
            // Totally randomize spell strengths - first, attack spells
            for (int lnI = 0; lnI < 17; lnI++)
            {
                int byteToUse = 0x134b1 + (lnI * 2);
                romData[byteToUse] = (byte)((r1.Next() % 200) + 2);
                if (lnI == 0x0d || lnI == 0x0e || lnI == 0x0f)
                    romData[byteToUse + 1] = (byte)(r1.Next() % romData[byteToUse]);
                else
                    romData[byteToUse + 1] = (byte)(r1.Next() % (romData[byteToUse] / 2));
            }

            // And then healing spells
            for (int lnI = 0; lnI < 6; lnI++)
            {
                if (lnI == 2 || lnI == 5) continue; // Healall/Healusall
                int byteToUse = 0x134f9 + (lnI * 2);
                romData[byteToUse] = (byte)((r1.Next() % 200) + 2);
                romData[byteToUse + 1] = (byte)(r1.Next() % (romData[byteToUse] / 2));
            }

        }

        private void randTreasures(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            // If the yellow orb is at a searchable spot, it won't be found unless you change this byte from 0x79 to 0x80+.  SUPER WEIRD!
            romData[0x31828] = 0xff;

            bool legal = false;

            // Totally randomize treasures... but make sure key items exist before they are needed!
            // Keep the Rainbow drop where it is
            int[] treasureAddrZ0 = { 0x375AA }; // Reeve 0ld Man - Magic Ball - 1 - 0
            int[] treasureAddrZ1 = { 0x29237, 0x29238, 0x29239, // Promontory Cave
                0x2927b, 0x292c4, 0x292c5, 0x292c6, 0x37df1 }; // Najimi Tower - Thief's Key, Magic Ball - 8 - 8
            int[] treasureAddrZ2 = { 0x2927c, 0x2927d }; // Najimi Tower behind Thief's Key - Magic Ball - 2 - 10
            int[] treasureAddrZ3 = { 0x2927e, 0x2927f, // Enticement cave
                0x29234, 0x29235, // Kanave
                0x2923a, 0x2923b, 0x29280, 0x29281, 0x29282, 0x29283, 0x29284, 0x29285, 0x29286, 0x29287, // Dream cave/Wake Up Powder
                0x29252, 0x292d2, 0x292e6, // champange tower
                0x2925c, // isis meteorite band
                0x29249, 0x2924a, 0x2924b, 0x2924c, 0x2924d, 0x2924e, 0x2924f, 0x292b4, 0x292b5, 0x292b6 }; // Pyramid -> Magic key - 28 - 38
            int[] treasureAddrZ4 = { 0x292c3, 0x317f4, // Pyramid continued
                0x29255, 0x29256, 0x29257, 0x29258, 0x29259, 0x2925a, // Aliahan continued
                0x31b9c, 0x2925d, 0x2925e, 0x2925f, 0x29260, 0x29261, 0x29262, 0x29263, 0x29264, // Isis continued
                0x29269, 0x2926a, 0x2926b }; // Portuga -> Royal Scroll - 20 - 58
            int[] treasureAddrZ5 = { 0x2923c, 0x2923d, // Dwarf's Cave
                0x29251, 0x292c7, 0x292c8, 0x292c9, 0x292ca, // Garuna Tower
                0x2923e, 0x2923f, 0x29240, 0x29241, 0x29242, 0x29243, 0x2928b, 0x2928c, 0x2928d, 0x2928e}; // Kidnapper's Cave -> Black Pepper - 17 - 75
            int[] treasureAddrZ6 = { 0x31b94, 0x29270, // Tedan (except Green Orb)
                0x292e4, 0x292e7, // Jipang
                0x29271, 0x29272, 0x29273, // Pirate Cove
                0x292cb, 0x292cc, 0x292cd, 0x292ce, 0x292cf, 0x292d0, 0x292d1}; // Arp Tower - Final Key - 14 - 89
            int[] treasureAddrZ7 = { 0x29291, 0x29292, 0x29293, 0x29294, 0x29295, 0x29296, 0x29297, 0x29298, 0x29299, 0x2929a, 0x2929b, // Samanao Cave
                0x2929c, 0x2929d, 0x2929e, 0x2929f, 0x292a0, 0x292a1, 0x292a2, 0x292a3, 0x292a4, 0x292a5, 0x292a6, 0x292a7, // Samanao Cave
                0x29244, 0x29245, 0x29246, 0x29247, 0x29248, 0x2928f, 0x29290 }; // Lancel Cave - Mirror Of Ra - 30 - 119
            int[] treasureAddrZ8 = { 0x292e5 }; // Staff Of Change - Samanao Castle - 1 - 120
            int[] treasureAddrZ9 = { 0x29275, 0x29276, 0x29277, 0x29278, 0x29279, 0x2927a }; // Sword Of Gaia - Ghost ship - 6 - 126
            int[] treasureAddrZ10 = { 0x29288, 0x29289, 0x2928a }; // All orbs - Cave Of Necrogund - 3 - 129
            int[] treasureAddrZ11 = { 0x2925b, // Eginbear
                0x31b8c, // Soo 
                0x2922b, // Final Key Shrine - Additional Potential Orb Locations 
                0x377fe  // Baharata Black Pepper - 4 - 133
                };
            int[] treasureAddrZ12 = { 0x37828, // Green orb location in Tedanki (Only should have Green Orb or other non-key item treasure)
                0x37907 }; // Silver orb location - 2 - 135
            int[] treasureAddrZ13 = { 0x377d5 }; // Water Blaster NPC  - 2 Not orb due to duplication - 1 - 136
            int[] treasureAddrZ14 = { 0x37929 }; // Dragon Queen - Add to Sphere of Light Locations - 1 - 137
            int[] treasureAddrZ15 = { 0x29265, 0x29266, 0x29267, 0x29268, // Tantegel Castle
                0x292a8, 0x292a9, 0x292aa, 0x292ab, 0x292ac, // Erdrick's Cave
                0x29274, // Garin's home
                0x292df, 0x292e0, 0x292e1, 0x292e2, 0x292e3, // Rocky Mountain Cave
                0x31b90, // Hauksness
                0x31b88, // Kol
                0x29253, 0x29254, 0x292d5, 0x292d6, 0x292d7, 0x292d8, 0x292d9, 0x292da, 0x292db, 0x292dc, 0x292dd, 0x292de, // Kol Tower
                0x29233,// Rimuldar
                0x37d9d }; // Staff of Rain NPC - Staff Of Rain, Stones Of Sunlight, Sacred Amulet - 30 - 167
            int[] treasureAddrZ16 = { 0x292ad, 0x292ae, 0x292af, 0x292b0, 0x292b1, 0x292b2, 0x292b3 }; // Zoma's Castle - Sphere of Light - 7 - 174
            int[] treasureAddrZ17 = { 0x29228, 0x29229, 0x2922a, // Baramos's Castle
                0x292b7, 0x292b8, 0x292b9, 0x292ba, 0x292bb, 0x292bc, 0x292bd, 0x292be, 0x292bf, 0x292c0, 0x292c1, 0x292c2, // Pyramid Mummy Men Chests
                0x31b9f, // World Tree
                0x31b97, // Luzami
                0x2926c, 0x2926d, 0x31b80, // New Town  0x378A9
                0x37786, 0x37cb9, 0x37828, 0x37a25}; // NPCs - Dead zone - 32 , 0x37d5a

            // NOTICE:  Using 0x3b785, supposedly the wake-up powder NPC, warps you to weird places after jumping off the rope in the tower of Garuna...

            List<int> allTreasureList = new List<int>();
            
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ0);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ1);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ2);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ3);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ4);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ5);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ6);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ7);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ8);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ9);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ10);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ11);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ12);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ13);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ14);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ15);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ16);
            allTreasureList = addTreasure(allTreasureList, treasureAddrZ17);

            int[] allTreasure = allTreasureList.ToArray();

            List<byte> treasureList = new List<byte>();
            List<byte> legalTreasuresList = new List<byte>();
            byte[] legalTreasures = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f,
                                          0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e, 0x1f,
                                          0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f,
                                          0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f,
                                          0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x48, 0x49, 0x4b, 0x4c, 0x4e,
                                          0x55, 0x56, 0x5e, 0x5f };
            byte[] legalTreasures2 = {0x60, 0x62, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6c, 0x6d,
                                          0x73, 0x74,
                                          0x88, 0x90, 0x98, 0xa0, 0xa8, 0xb0, 0xb8, 0xc0, 0xc8, 0xd0, 0xd8, 0xe0, 0xe8, 0xf0, 0xf8,
                                          0xfd, 0xfe, 0xff, 0xfd, 0xfe, 0xff, 0xfd, 0xfe, 0xff, 0xfd, 0xfe, 0xff, 0xfd, 0xfe, 0xff };

            // Populate legalTreasuresList so we can add additional items if selected (First half)
            for (int lnI = 0; lnI < legalTreasures.Length; lnI++)
            {
                legalTreasuresList.Add(legalTreasures[lnI]);
            }
            // Populate legalTreasuresList so we can add additional items if selected (Second half)
            for (int lnI = 0; lnI < legalTreasures2.Length; lnI++)
            {
                legalTreasuresList.Add(legalTreasures2[lnI]);
            }

            for (int lnI = 0; lnI < allTreasureList.Count; lnI++)
            {
                legal = false;
                while (!legal)
                {
                    byte treasure = (byte)(r1.Next() % legalTreasuresList.Count); // the last two items we can't get...
                    treasure = legalTreasuresList[treasure];
                    // Disallow earning gold for searchable items... this is because 0x80 = 0x00 in this scenario, so anything over 0x80 is useless.  
                    // (in fact, 0xfd = 0x7d, the Stick Slime, a null item.)
                    if (allTreasure[lnI] > 0x29400 && treasure >= 0x80)
                        continue;

                    //byte[] keyItems = { 0x59, 0x5a, 0x54, 0x11, 0x78, 0x79, 0x7a, 0x7b, 0x10, 0x75 };
                    //byte[] minKeyTreasure = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 134, 134 };
                    //byte[] keyTreasure = { 37, 116, 124, 130, 133, 133, 133, 133, 165, 165 };

                    // We need to make sure key items doesn't exceed a certain point in the story.

                    // Verify that only one location exists for key items -- Moved this down to the Key Items
                    if (!(treasureList.Contains(treasure) && (treasure == 0x53 || treasure == 0x71)))
                    {
                        legal = true;
                        treasureList.Add(treasure);
                        romData[allTreasure[lnI]] = treasure;
                    }
                }
            }
            if (chk_SepBarGaia.Checked == true) // Put Wing Of Wyvern in 3 chests in Baramos' Castle
            {
                romData[0x2922a] = 0x68;
                romData[0x29229] = 0x68;
                romData[0x29228] = 0x68;
            }

            // Verify that key items are available in either a store or a treasure chest in the right zone.
            byte[] keyItems = { 0x5a, 0x59, 0x58, 0x57, 0x52, 0x5d, 0x4f, 0x51, 0x54,
                                    0x6b, 0x6f, 0x5c, 0x11, 0x77, 0x78, 0x79, 0x7a, 0x7b,
                                    0x7c, 0x10, 0x75, 0x72, 0x4a, 0x50, 0x70, 0x53, 0x71, 0x5b };
            byte[] minKeyTreasure = { 1, 1, 1, 0, 1, 1, 1, 1, 1,
                                          1, 1, 1, 1, 1, 1, 1, 1, 1,
                                          1, 138, 138, 137, 1, 1, 138, 1, 1, 1 };
            byte[] maxKeyTreasure = { 89, 38, 8, 10, 38, 58, 75, 119, 120,
                                       120, 133, 133, 126, 133, 133, 133, 133, 133,
                                       133, 167, 167, 177, 174, 174, 167, 174, 174, 133 }; // used if chkRandomizeMaps is true
            byte[] maxKeyTreasure2 = { 89, 38, 8, 10, 38, 58, 75, 119, 120,
                                       120, 134, 133, 126, 133, 133, 133, 133, 133,
                                       134, 166, 166, 173, 173, 173, 166, 173, 173, 134 }; // used if chkRandomizeMaps is false


            int echoingFluteMarker = 0;
            int magicKeyMarker = 50;
            int finalKeyMarker = 50;

            for (int lnJ = 0; lnJ < keyItems.Length; lnJ++)
            {
                int treasureLocation = 0;
                int index = 0;
                if (chkNoLamiaOrbs.Checked)
                {
                    if (keyItems[lnJ] >= 0x77 && keyItems[lnJ] <= 0x7c)
                    {
                        continue;
                    }
                }
                if (chkRandomizeMap.Checked == true)
                    if (chk_GreenSilverOrb.Checked == true && lnJ == 13) // Silver Orb
                    {
                        treasureLocation = allTreasure[minKeyTreasure[lnJ] + (r1.Next() % ((maxKeyTreasure[lnJ] + 2) - minKeyTreasure[lnJ]))];
                        if (treasureLocation == 134)
                        {
                            lnJ--;
                            continue;
                        }
                    }
                    else if (chk_GreenSilverOrb.Checked == true && lnJ == 18) // Green Orb
                    {
                        treasureLocation = allTreasure[minKeyTreasure[lnJ] + (r1.Next() % ((maxKeyTreasure[lnJ] + 2) - minKeyTreasure[lnJ]))];
                        if (treasureLocation == 135)
                        {
                            lnJ--;
                            continue;
                        }
                    }
                    else
                    {
                        if (chk_RmRedundKey.Checked == true)
                        {
                            if (lnJ == 1 && finalKeyMarker <= 38)
                                continue;
                            else if (lnJ == 2 && finalKeyMarker <= 8)
                                continue;
                            else if (lnJ == 2 && magicKeyMarker <= 8)
                                continue;
                            else
                            {
                                index = minKeyTreasure[lnJ] + (r1.Next() % (maxKeyTreasure[lnJ] - minKeyTreasure[lnJ]));
                                treasureLocation = allTreasure[index];
                                if (lnJ == 0)
                                    finalKeyMarker = index;
                                else if (lnJ == 1)
                                    magicKeyMarker = index;
                            }
                        }
                        else
                        {
                            index = minKeyTreasure[lnJ] + (r1.Next() % (maxKeyTreasure[lnJ] - minKeyTreasure[lnJ]));
                            treasureLocation = allTreasure[index];
                        }
                    }
                else
                {
                    if (chk_RmRedundKey.Checked == true)
                    {
                        if (lnJ == 1 && finalKeyMarker <= 38)
                            continue;
                        else if (lnJ == 2)
                        {
                            if (finalKeyMarker <= 8)
                                continue;
                            else if (magicKeyMarker <= 8)
                                continue;
                        }
                        else
                        {
                            index = minKeyTreasure[lnJ] + (r1.Next() % (maxKeyTreasure2[lnJ] - minKeyTreasure[lnJ]));
                            treasureLocation = allTreasure[index];
                            if (lnJ == 0)
                                finalKeyMarker = index;
                            else if (lnJ == 1)
                                magicKeyMarker = index;
                        }
                    }
                    else
                    {
                        index = minKeyTreasure[lnJ] + (r1.Next() % (maxKeyTreasure2[lnJ] - minKeyTreasure[lnJ]));
                        treasureLocation = allTreasure[index];
                    }
                    index = minKeyTreasure[lnJ] + (r1.Next() % (maxKeyTreasure2[lnJ] - minKeyTreasure[lnJ]));
                    treasureLocation = allTreasure[index];
                }

                if (chkRandomizeMap.Checked == true && lnJ == 4)
                {
                    continue; // Does not add Vase of Draught to treasure pool when map is randomized
                }
                if (chk_GoldenClaw.Checked == false && lnJ == 22)
                {
                    continue; // Does not add Golden Claw if not checked
                }
                if (keyItems.Contains(romData[treasureLocation]))
                {
                    lnJ--;
                    if (lnJ == 0)
                        finalKeyMarker = 50;
                    else if (lnJ == 1)
                        magicKeyMarker = 50;
                    continue;
                }
                romData[treasureLocation] = keyItems[lnJ];

                // Echoing Flute business.  01 = Silver, 02 = Red, 04 = Yellow, 08 = Purple, 10 = Blue, 20 = Green
                if (keyItems[lnJ] >= 0x77 && keyItems[lnJ] <= 0x7c)
                {
                    byte[] echoLocations;
                    byte orbNumber = (byte)(Math.Pow(2, Math.Abs(0x77 - keyItems[lnJ])));

                    if (new int[] { 0x29255, 0x29256, 0x29257, 0x29258, 0x29259, 0x2925a }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x00, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47 }; // Aliahan
                    else if (new int[] { 0x29237, 0x29238, 0x29239 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x2d }; // Promontory Cave
                    else if (new int[] { 0x2927b, 0x292c4, 0x292c5, 0x292c6, 0x2927c, 0x2927d, 0x37df1 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x3c, 0x9f, 0xed, 0xd6, 0xd7, 0xd8 }; // Najimi Tower
                    else if (new int[] { 0x2927e, 0x2927f }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x98, 0xa0, 0xa1, 0xa2 }; // Enticement cave
                    else if (new int[] { 0x29234, 0x29235 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x14, 0x83 }; // Kanave
                    else if (new int[] { 0x2923a, 0x2923b, 0x29280, 0x29281, 0x29282, 0x29283, 0x29284, 0x29285, 0x29286, 0x29287 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x2e, 0xa3, 0xa4, 0xa5 }; // Dream cave
                    else if (new int[] { 0x29252, 0x292d2, 0x292e6 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x3f, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xee }; // Tower of Champagne
                    else if (new int[] { 0x2925c, 0x31b9c, 0x2925d, 0x2925e, 0x2925f, 0x29260, 0x29261, 0x29262, 0x29263, 0x29264 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x29, 0x96, 0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x87}; // Isis
                    else if (new int[] { 0x29269, 0x2926a, 0x2926b }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x0a, 0x6f, 0x70, 0x71 }; // Portoga
                    else if (new int[] { 0x29249, 0x2924a, 0x2924b, 0x2924c, 0x2924d, 0x2924e, 0x2924f, 0x292b4, 0x292b5, 0x292b6, 0x292c3, 0x317f4 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x3b, 0xcf, 0xd0, 0xd1, 0xd2, 0xd3, 0xd4, 0xd5 }; // Pyramid
                    else if (new int[] { 0x2923c, 0x2923d }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x2f, 0x30 }; // Dwarf's Cave
                    else if (new int[] { 0x29251, 0x292c7, 0x292c8, 0x292c9, 0x292ca }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x3d, 0xdb, 0xdc, 0xdd, 0xde }; // Garuna Tower
                    else if (new int[] { 0x377d5 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x0e, 0x7d }; // Baharata Black Pepper
                    else if (new int[] { 0x2923e, 0x2923f, 0x29240, 0x29241, 0x29242, 0x29243, 0x2928b, 0x2928c, 0x2928d, 0x2928e }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x34, 0xb2 }; // Kidnapper's Cave
                    else if (new int[] { 0x31b8c }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x19 }; // Soo
                    else if (new int[] { 0x2925b }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x02, 0x4e, 0x4f }; // Eginbear
                    else if (new int[] { 0x2922b }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x04 }; // Final Key Shrine
                    else if (new int[] { 0x31b94, 0x29270 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x15, 0x85, 0x86 }; // Tedanki
                    else if (new int[] { 0x377fe }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x16, 0x89 }; // Muor Water Blaster NPC
                    else if (new int[] { 0x292e4, 0x292e7 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x17, 0x35, 0x8a, 0xbb }; // Cave of Jipang/Jipang
                    else if (new int[] { 0x29272, 0x29271, 0x29273 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x18, 0x8b, 0x8c }; // Pirates Cove
                    else if (new int[] { 0x292d1, 0x292d0, 0x292cf, 0x292cd, 0x292ce, 0x292cc, 0x292cb }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x3e, 0xe4, 0xe5, 0xe6, 0xe7 }; // Arp Tower
                    else if (new int[] { 0x29299, 0x2929c, 0x2929b, 0x2929d, 0x2929a, 0x29298, 0x29293, 0x29294, 0x29295, 0x29291, 0x29292, 0x29296, 0x29297, 0x292a3, 0x292a4, 0x292a2, 0x2929f, 0x2929e, 0x292a0, 0x292a5, 0x292a6, 0x292a1, 0x292a7, 0x29296 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x37, 0xbe, 0xbf }; // Samano Cave
                    else if (new int[] { 0x29246, 0x29248, 0x29247, 0x29245, 0x29244, 0x29290, 0x2928f }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x36, 0xbc, 0xbd }; // Lancel Cave
                    else if (new int[] { 0x292e5 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x06, 0x5d, 0x5e, 0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x99 }; // Samano Castle
                    else if (new int[] { 0x29275, 0x29276, 0x29277, 0x29278, 0x29279, 0x2927a }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x9c, 0x9d }; // Ghost Ship
                    else if (new int[] { 0x29288, 0x29289, 0x2928a }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x31, 0x32, 0xa8, 0xa9, 0xaa }; // Cave Of Necrogund
                    else if (new int[] { 0x37929 }.Contains(treasureLocation))
                        echoLocations = new byte[] { 0x23 }; // Dragon Queen
                    else
                        echoLocations = new byte[] { };

                    for (int i = 0; i < echoLocations.Length; i++)
                    {
                        romData[0x33c51 + echoingFluteMarker] = orbNumber;
                        echoingFluteMarker++;

                        romData[0x33c51 + echoingFluteMarker] = echoLocations[i];
                        echoingFluteMarker++;
                    }
                    romData[0x33c51 + echoingFluteMarker] = 0x00;
                }
            }

            // Echoing Flute business...
            byte[] echoingFlute = { 0xA5, 0x2F, 0xD0, 0x0E, 0x00, 0x1E, 0x2F, 0x00, 0x44, 0x17, 0x00, 0x0D, 0x77, 0x20, 0x33, 0xCB,
                    0x38, 0x60, 0xA2, 0x00, 0xBD, 0x41, 0xBC, 0xF0, 0xEB, 0xE8, 0xBC, 0x41, 0xBC, 0xE8, 0x2D, 0xCE,
                    0x60, 0xD0, 0xF1, 0xC4, 0x8B, 0xD0, 0xED, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA,
                    0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0xEA, 0x4C, 0x59, 0xA2 }; // 0xC9, 0x04, 0xD0, 0x0B, 0xAD, 0xCD, 0x60, 0xC8, 0xD0, 0xE0, 

            for (int i = 0; i < echoingFlute.Length; i++)
            {
                romData[0x32228 + i] = echoingFlute[i];
            }

        }

        private void randStores(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            // Totally randomize stores (19 weapon stores, 24 item stores, 248 items total)  No store can have more than 12 items.
            // I would just create random values for 248 items, then determine weapon and item stores out of that!
            byte[] legalStoreWeapons = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f,
                                      0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e, 0x1f,
                                      0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f,
                                      0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f,
                                      0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46
                };
            byte[] legalStoreItems = { 0x56,
                                      0x65, 0x66, 0x67, 0x68, 0x6c,
                                      0x74
                };
            // Create legalStoreItemsList to add new items
            List<byte> legalStoreItemsList = new List<byte>();
            // Populate legalStoreItemsList base items
            for (int lnI = 0; lnI < legalStoreItems.Length; lnI++)
            {
                legalStoreItemsList.Add(legalStoreItems[lnI]);
            }

            // Add Stone of Life to Item Shop Items
            if (chk_StoneofLife.Checked == true && chk_StoneofLife.Enabled == true)
            {
                legalStoreItemsList.Add(0x55);
            }
            // Add Seeds to Item Shop Items
            if (chk_Seeds.Checked == true && chk_Seeds.Enabled)
            {
                legalStoreItemsList.Add(0x5f);
                legalStoreItemsList.Add(0x60);
                legalStoreItemsList.Add(0x61);
                legalStoreItemsList.Add(0x62);
                legalStoreItemsList.Add(0x63);
                legalStoreItemsList.Add(0x64);
            }
            // Add Book of Satori to Item Shop Items
            if (chk_BookofSatori.Checked == true && chk_BookofSatori.Enabled == true)
            {
                legalStoreItemsList.Add(0x4c);
            }
            // Add Ring of Life to Item Shop Items
            if (chk_RingofLife.Checked == true && chk_RingofLife.Enabled == true)
            {
                legalStoreItemsList.Add(0x48);
            }
            // Add Echoing Flute to Item Shop Items
            if (chk_EchoingFlute.Checked == true && chk_EchoingFlute.Enabled == true)
            {
                legalStoreItemsList.Add(0x6f);
            }
            // Add Silver Harp to Item Shop Items
            if (chk_SilverHarp.Checked == true && chk_SilverHarp.Enabled == true)
            {
                legalStoreItemsList.Add(0x71);
            }
            // Add Shoes of Happiness to Item Shop Items
            if (chk_ShoesofHappiness.Checked == true && chk_ShoesofHappiness.Enabled == true)
            {
                legalStoreItemsList.Add(0x49);
            }
            // Add Meterorite Armband to Item Shop Items
            if (chk_MeteoriteArmband.Checked == true && chk_MeteoriteArmband.Enabled == true)
            {
                legalStoreItemsList.Add(0x4b);
            }
            if (chk_WizardsRing.Checked == true && chk_WizardsRing.Enabled == true)
            {
                legalStoreItemsList.Add(0x4e);
            }
            if (chk_LampofDarkness.Checked == true && chk_LampofDarkness.Enabled == true)
            {
                legalStoreItemsList.Add(0x53);
            }
            if (chk_LeafoftheWorldTree.Checked == true && chk_LeafoftheWorldTree.Enabled == true)
            {
                legalStoreItemsList.Add(0x69);
            }
            if (chk_PoisonMothPowder.Checked == true && chk_PoisonMothPowder.Enabled == true)
            {
                legalStoreItemsList.Add(0x73);
            }
            

            int[] weaponStores = { 0x36838, 0x3683f, 0x36846, 0x3684d, 0x36854, 0x3685b, 0x36862, 0x36869, 0x3686e, 0x36874, 0x3687a, 0x36880, 0x36887, 0x3688d, 0x36893, 0x3689a, 0x368a1, 0x368a7, 0x368ae }; // 42
            int[] itemStores = { 0x368b4, 0x368b7, 0x368be, 0x368c4, 0x368ca, 0x368d0, 0x368d6, 0x368db, 0x368e0, 0x368e2, 0x368e6, 0x368ec, 0x368f2, 0x368f4, 0x368fa, 0x368ff, 0x36905, 0x36908, 0x3690e, 0x36914, 0x3691a, 0x36920, 0x36927, 0x3692b }; // 22

            if (chk_RandomizeWeaponShops.Checked == true)
            {
                for (int lnI = 0; lnI < weaponStores.Length; lnI++)
                {
                    List<int> store = new List<int> { };
                    bool lastItem = false;
                    int byteToUse = weaponStores[lnI];
                    int lnJ = 0;
                    do
                    {
                        if (romData[byteToUse + lnJ] >= 128)
                            lastItem = true;
                        romData[byteToUse + lnJ] = legalStoreWeapons[r1.Next() % legalStoreWeapons.Length];
                        bool failure = false;
                        for (int lnK = 0; lnK < lnJ; lnK++)
                            if (romData[byteToUse + lnJ] == romData[byteToUse + lnK])
                                failure = true;
                        if (lastItem)
                            romData[byteToUse + lnJ] += 128;
                        if (failure)
                        {
                            lastItem = false;
                            continue;
                        }
                        lnJ++;
                    } while (!lastItem);
                }
                if (chk_Caturday.Checked == true)
                {
                    Random caturday = new Random(int.Parse(txtSeed.Text));

                    int[] catWeaponStores = { 0x36838, 0x3683f, 0x36846, 0x3684d, 0x36854, 0x3685b, 0x36869, 0x3686e, 0x36874, 0x36880, 0x36887, 0x3688d, 0x36893, 0x3689a, 0x368a1, 0x368a7, 0x368ae };
                    int selectStore = caturday.Next() % catWeaponStores.Length;
                    romData[catWeaponStores[selectStore]] = 0x2a;
                }
            }
            if (chkRandItemStores.Checked == true)
            {
                for (int lnI = 0; lnI < itemStores.Length; lnI++)
                {
                    List<int> store = new List<int> { };
                    bool lastItem = false;
                    int byteToUse = itemStores[lnI];
                    int lnJ = 0;
                    do
                    {
                        if (romData[byteToUse + lnJ] >= 128)
                            lastItem = true;
                        romData[byteToUse + lnJ] = legalStoreItemsList[r1.Next() % legalStoreItemsList.Count];
                        bool failure = false;
                        for (int lnK = 0; lnK < lnJ; lnK++)
                            if (romData[byteToUse + lnJ] == romData[byteToUse + lnK])
                                failure = true;
                        if (lastItem)
                            romData[byteToUse + lnJ] += 128;
                        if (failure)
                        {
                            lastItem = false;
                            continue;
                        }
                        lnJ++;
                    } while (!lastItem);
                }
            }

        }

        private void changeGhostToCasket(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));
            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            // Changes ghost sprite to casket
            byte[] caskettop1_green = { 0x00, 0x00, 0x00, 0x07, 0x0f, 0x1f, 0x3f, 0x7f, 0x00, 0x00, 0x07, 0x0f, 0x18, 0x30, 0x63, 0xc3,
                                        0x00, 0x00, 0x00, 0x80, 0xf0, 0xfe, 0xfe, 0xfe, 0x00, 0x00, 0x80, 0xf0, 0x7e, 0x0f, 0x03, 0x03};
            byte[] caskettop2_green = { 0x3f, 0x5f, 0x2f, 0x17, 0x08, 0x07, 0x00, 0x00, 0xe0, 0xf0, 0x78, 0x3f, 0x1f, 0x0f, 0x07, 0x00,
                                        0xfe, 0xfe, 0xf0, 0x8e, 0x70, 0x80, 0x00, 0x00, 0x03, 0x0f, 0x7f, 0xff, 0xfe, 0xf0, 0x80, 0x00};// 0x21d80
            byte[] casketbottom1_green = { 0x00, 0x01, 0x03, 0x07, 0x0f, 0x1f, 0x1f, 0x1f, 0x01, 0x03, 0x06, 0x0c, 0x18, 0x31, 0x31, 0x30,
                                           0x00, 0x80, 0xc0, 0xe0, 0xf0, 0xf8, 0xf8, 0xf8, 0x80, 0xc0, 0x60, 0x30, 0x18, 0x8c, 0x8c, 0x0c,
                                           0x2f, 0x2f, 0x0f, 0x17, 0x17, 0x10, 0x07, 0x00, 0x38, 0x38, 0x18, 0x1c, 0x1f, 0x1f, 0x0f, 0x07,
                                           0xf4, 0xf4, 0xf0, 0xe8, 0xe8, 0x08, 0xe0, 0x00, 0x1c, 0x1c, 0x18, 0x38, 0xf8, 0xf8, 0xf0, 0xe0};
            byte[] casketbottom2_green = { 0x00, 0x07, 0x10, 0x17, 0x17, 0x0f, 0x2f, 0x2f, 0x07, 0x0f, 0x1f, 0x1f, 0x1c, 0x18, 0x38, 0x38,
                                           0x00, 0xe0, 0x08, 0xe8, 0xe8, 0xf0, 0xf4, 0xf4, 0xe0, 0xf0, 0xf8, 0xf8, 0x38, 0x18, 0x1c, 0x1c,
                                           0x1f, 0x1f, 0x1f, 0x0f, 0x07, 0x03, 0x01, 0x00, 0x30, 0x31, 0x31, 0x18, 0x0c, 0x06, 0x03, 0x01,
                                           0xf8, 0xf8, 0xf8, 0xf0, 0xe0, 0xc0, 0x80, 0x00, 0x0c, 0x8c, 0x8c, 0x18, 0x30, 0x60, 0xc0, 0x80};
            byte[] caskettop1_white = { 0x00, 0x00, 0x07, 0x08, 0x17, 0x2f, 0x5c, 0xbc, 0x00, 0x00, 0x00, 0x07, 0x0f, 0x1f, 0x3f, 0x7f,
                                        0x00, 0x00, 0x80, 0x70, 0x8e, 0xf1, 0xfd, 0xfd, 0x00, 0x00, 0x00, 0x80, 0xf0, 0xfe, 0xfe, 0xfe};
            byte[] caskettop2_white = { 0xdf, 0xaf, 0x57, 0x28, 0x17, 0x08, 0x07, 0x00, 0x3f, 0x5f, 0x2f, 0x17, 0x08, 0x07, 0x00, 0x00,
                                        0xfd, 0xf1, 0x8f, 0x71, 0x8e, 0x70, 0x80, 0x00, 0xfe, 0xfe, 0xf0, 0x8e, 0x70, 0x80, 0x00, 0x00};
            byte[] casketbottom1_white = { 0x01, 0x02, 0x05, 0x0b, 0x17, 0x2e, 0x2e, 0x2f, 0x00, 0x01, 0x03, 0x07, 0x0f, 0x1f, 0x1f, 0x1f,
                                           0x80, 0x40, 0xa0, 0xd0, 0xe8, 0x74, 0x74, 0xf4, 0x00, 0x80, 0xc0, 0xe0, 0xf0, 0xf8, 0xf8, 0xf8,
                                           0x17, 0x17, 0x17, 0x0b, 0x08, 0x0f, 0x08, 0x07, 0x2f, 0x2f, 0x0f, 0x17, 0x17, 0x10, 0x07, 0x00,
                                           0xe8, 0xe8, 0xe8, 0xd0, 0x10, 0xf0, 0x10, 0xe0, 0xf4, 0xf4, 0xf0, 0xe8, 0xe8, 0x08, 0xe0, 0x00};
            byte[] casketbottom2_white = { 0x07, 0x08, 0x0f, 0x08, 0x0b, 0x17, 0x17, 0x17, 0x00, 0x07, 0x10, 0x17, 0x17, 0x0f, 0x2f, 0x2f,
                                           0xe0, 0x10, 0xf0, 0x10, 0xd0, 0xe8, 0xe8, 0xe8, 0x00, 0xe0, 0x08, 0xe8, 0xe8, 0xf0, 0xf4, 0xf4,
                                           0x2f, 0x2e, 0x2e, 0x17, 0x0b, 0x05, 0x02, 0x01, 0x1f, 0x1f, 0x1f, 0x0f, 0x07, 0x03, 0x01, 0x00,
                                           0xf4, 0x74, 0x74, 0xe8, 0xd0, 0xa0, 0x40, 0x80, 0xf8, 0xf8, 0xf8, 0xf0, 0xe0, 0xc0, 0x80, 0x00};
            byte[] caskettop1_blue = { 0x00, 0x00, 0x07, 0x0f, 0x18, 0x30, 0x63, 0xc3, 0x00, 0x00, 0x07, 0x08, 0x17, 0x2f, 0x5c, 0xbc,
                                       0x00, 0x00, 0x80, 0xf0, 0x7e, 0x0f, 0x03, 0x03, 0x00, 0x00, 0x80, 0x70, 0x8e, 0xf1, 0xfd, 0xfd};
            byte[] caskettop2_blue = { 0xe0, 0xf0, 0x78, 0x3f, 0x1f, 0x0f, 0x07, 0x00, 0xdf, 0xaf, 0x57, 0x28, 0x17, 0x08, 0x07, 0x00,
                                       0x03, 0x0f, 0x7f, 0xff, 0xfe, 0xf0, 0x80, 0x00, 0xfd, 0xf1, 0x8f, 0x71, 0x8e, 0x70, 0x80, 0x00};
            byte[] casketbottom1_blue = { 0x01, 0x03, 0x06, 0x0c, 0x18, 0x31, 0x31, 0x30, 0x01, 0x02, 0x05, 0x0b, 0x17, 0x2e, 0x2e, 0x2f,
                                          0x80, 0xc0, 0x60, 0x30, 0x18, 0x8c, 0x8c, 0x0c, 0x80, 0x40, 0xa0, 0xd0, 0xe8, 0x74, 0x74, 0xf4,
                                          0x38, 0x38, 0x18, 0x1c, 0x1f, 0x1f, 0x0f, 0x07, 0x17, 0x17, 0x17, 0x0b, 0x08, 0x0f, 0x08, 0x07,
                                          0x1c, 0x1c, 0x18, 0x38, 0xf8, 0xf8, 0xf0, 0xe0, 0xe8, 0xe8, 0xe8, 0xd0, 0x10, 0xf0, 0x10, 0xe0};
            byte[] casketbottom2_blue = { 0x07, 0x0f, 0x1f, 0x1f, 0x1c, 0x18, 0x38, 0x38, 0x07, 0x08, 0x0f, 0x08, 0x0b, 0x17, 0x17, 0x17,
                                          0xe0, 0xf0, 0xf8, 0xf8, 0x38, 0x18, 0x1c, 0x1c, 0xe0, 0x10, 0xf0, 0x10, 0xd0, 0xe8, 0xe8, 0xe8,
                                          0x30, 0x31, 0x31, 0x18, 0x0c, 0x06, 0x03, 0x01, 0x2f, 0x2e, 0x2e, 0x17, 0x0b, 0x05, 0x02, 0x01,
                                          0x0c, 0x8c, 0x8c, 0x18, 0x30, 0x60, 0xc0, 0x80, 0xf4, 0x74, 0x74, 0xe8, 0xd0, 0xa0, 0x40, 0x80};

            List<byte> caskettop1 = new List<byte>();
            List<byte> caskettop2 = new List<byte>();
            List<byte> casketbottom1 = new List<byte>();
            List<byte> casketbottom2 = new List<byte>();

            int colorpick = 0;

            if (chk_RandSpriteColor.Checked == true)
                colorpick = r1.Next() % 3;

            if (colorpick == 0)
            {
                for(int lni = 0; lni < caskettop1_green.Length; lni++)
                    caskettop1.Add(caskettop1_green[lni]);
                for(int lni = 0; lni < caskettop2_green.Length; lni++)
                    caskettop2.Add(caskettop2_green[lni]);
                for (int lni = 0; lni < casketbottom1_green.Length; lni++)
                    casketbottom1.Add(casketbottom1_green[lni]);
                for (int lni = 0; lni < casketbottom2_green.Length; lni++)
                    casketbottom2.Add(casketbottom2_green[lni]);
            }
            else if (colorpick == 1)
            {
                for (int lni = 0; lni < caskettop1_white.Length; lni++)
                    caskettop1.Add(caskettop1_white[lni]);
                for (int lni = 0; lni < caskettop2_white.Length; lni++)
                    caskettop2.Add(caskettop2_white[lni]);
                for (int lni = 0; lni < casketbottom1_white.Length; lni++)
                    casketbottom1.Add(casketbottom1_white[lni]);
                for (int lni = 0; lni < casketbottom2_white.Length; lni++)
                    casketbottom2.Add(casketbottom2_white[lni]);
            }
            else
            {
                for (int lni = 0; lni < caskettop1_blue.Length; lni++)
                    caskettop1.Add(caskettop1_blue[lni]);
                for (int lni = 0; lni < caskettop2_blue.Length; lni++)
                    caskettop2.Add(caskettop2_blue[lni]);
                for (int lni = 0; lni < casketbottom1_blue.Length; lni++)
                    casketbottom1.Add(casketbottom1_blue[lni]);
                for (int lni = 0; lni < casketbottom2_blue.Length; lni++)
                    casketbottom2.Add(casketbottom2_blue[lni]);
            }

            for (int lni = 0; lni < caskettop1.Count; lni++)
                romData[0x21d80 + lni] = caskettop1[lni];
            for (int lni = 0; lni < caskettop2.Count; lni++)
                romData[0x21da0 + lni] = romData[0x21dc0 + lni] = caskettop2[lni];
            for (int lni = 0; lni < casketbottom1.Count; lni++)
                romData[0x22c20 + lni] = casketbottom1[lni];
            for (int lni = 0; lni < casketbottom2.Count; lni++)
                romData[0x22ba0 + lni] = romData[0x22be0 + lni] = casketbottom2[lni];

            // changes references from ghost to pall (synonym for casket).
            romData[0x424f1] = romData[0x42573] = romData[0x425fb] = romData[0x4260c] = romData[0x42629] = romData[0x42647] = romData[0x42650] = romData[0x42681] = romData[0x4268a] = romData[0x4269b] = romData[0x4272b] = romData[0x42746] = romData[0x42901] = romData[0x4290a] = romData[0x450b6] = romData[0x450c6] = romData[0x452c9] = romData[0x452da] = 0x1a; // p
            romData[0x424f2] = romData[0x424f6] = romData[0x42504] = romData[0x42506] = romData[0x42574] = romData[0x4260d] = romData[0x4262a] = romData[0x42648] = romData[0x4264c] = romData[0x42665] = romData[0x42682] = romData[0x42686] = romData[0x4269c] = romData[0x4272c] = romData[0x42730] = romData[0x42747] = romData[0x42902] = romData[0x42906] = romData[0x4290c] = romData[0x450c7] = romData[0x452db] = 0x0b; // a
            romData[0x424f3] = romData[0x424f4] = romData[0x42575] = romData[0x42576] = romData[0x4260e] = romData[0x4260f] = romData[0x4262b] = romData[0x4262c] = romData[0x42649] = romData[0x4264a] = romData[0x42662] = romData[0x42683] = romData[0x42684] = romData[0x4269d] = romData[0x4269e] = romData[0x4272d] = romData[0x4272e] = romData[0x42748] = romData[0x42749] = romData[0x42903] = romData[0x42904] = romData[0x4290b] = romData[0x450c8] = romData[0x450c9] = romData[0x452dc] = romData[0x452dd] = 0x16; // l
            romData[0x424f5] = romData[0x424f9] = romData[0x42500] = romData[0x42503] = romData[0x42509] = romData[0x42563] = romData[0x42567] = romData[0x42569] = romData[0x4256e] = romData[0x42572] = romData[0x425ff] = romData[0x42602] = romData[0x42607] = romData[0x4260b] = romData[0x4262e] = romData[0x4264b] = romData[0x4264f] = romData[0x42654] = romData[0x42657] = romData[0x4265a] = romData[0x4265e] = romData[0x42663] = romData[0x42668] = romData[0x42685] = romData[0x42689] = romData[0x4268e] = romData[0x42691] = romData[0x42696] = romData[0x4269a] = romData[0x426a0] = romData[0x4272f] = romData[0x42733] = romData[0x4273b] = romData[0x4273e] = romData[0x42741] = romData[0x42745] = romData[0x4274b] = romData[0x4274c] = romData[0x42905] = romData[0x42909] = romData[0x42910] = romData[0x42914] = romData[0x42916] = romData[0x42919] = romData[0x4291d] = romData[0x450b9] = romData[0x450bc] = romData[0x450c1] = romData[0x450c5] = romData[0x450cb] = romData[0x452cc] = romData[0x452cf] = romData[0x452d4] = romData[0x452d9] = 0x60; // space
            romData[0x424f7] = romData[0x4256b] = romData[0x42604] = romData[0x4264d] = romData[0x42659] = romData[0x42687] = romData[0x42693] = romData[0x42731] = romData[0x42739] = romData[0x42907] = romData[0x42918] = romData[0x450be] = romData[0x452d1] = 0x18; // n
            romData[0x424f8] = romData[0x4264e] = romData[0x42688] = romData[0x42732] = romData[0x42908] = 0x0e; // d
            romData[0x424fa] = romData[0x42502] = romData[0x42561] = romData[0x42564] = romData[0x4256c] = romData[0x425fd] = romData[0x42601] = romData[0x42605] = romData[0x42652] = romData[0x42656] = romData[0x4268c] = romData[0x42690] = romData[0x42694] = romData[0x42736] = romData[0x4273d] = romData[0x4273f] = romData[0x42911] = romData[0x4291b] = romData[0x450b8] = romData[0x450bb] = romData[0x450bf] = romData[0x452cb] = romData[0x452ce] = romData[0x452d2] = romData[0x452d5] = 0x1e; // t
            romData[0x424fb] = romData[0x42565] = romData[0x42912] = romData[0x452d6] = 0x12; // h
            romData[0x424fc] = romData[0x42734] = romData[0x42738] = 0x1c; // r
            romData[0x424fd] = romData[0x4256d] = romData[0x42606] = romData[0x42660] = romData[0x42661] = romData[0x42695] = romData[0x42740] = romData[0x450c0] = romData[0x452d3] = 0x19; // o
            romData[0x424fe] = romData[0x42505] = 0x21; // w
            romData[0x424ff] = romData[0x42562] = romData[0x42571] = romData[0x425fe] = romData[0x4260a] = romData[0x42653] = romData[0x4265d] = romData[0x4268d] = romData[0x42699] = romData[0x4273a] = romData[0x42744] = romData[0x4290f] = romData[0x450c4] = romData[0x452d8] = 0x1d; // s
            romData[0x42501] = romData[0x4256a] = romData[0x42600] = romData[0x42603] = romData[0x42655] = romData[0x42658] = romData[0x4268f] = romData[0x42692] = romData[0x4273c] = romData[0x42917] = romData[0x4291a] = romData[0x450ba] = romData[0x450bd] = romData[0x452cd] = romData[0x452d0] = romData[0x452d7] = 0x13; // i
            romData[0x42507] = 0x23; // y
            romData[0x42508] = romData[0x42576] = romData[0x42610] = romData[0x4262d] = romData[0x42667] = romData[0x4269f] = romData[0x4274a] = romData[0x4291c] = romData[0x450ca] = 0x6c; // .
            romData[0x42560] = romData[0x425fc] = romData[0x42651] = romData[0x4268b] = romData[0x42737] = romData[0x450b7] = romData[0x452ca] = 0x1f; // u
            romData[0x4256f] = romData[0x42608] = romData[0x4265b] = romData[0x42697] = romData[0x42742] = romData[0x450c2] = 0xf5; // character name
            romData[0x42570] = romData[0x42609] = romData[0x4265c] = romData[0x42698] = romData[0x42743] = romData[0x450c3] = 0x68; // '
            romData[0x4265f] = 0x38; // T
            romData[0x42664] = 0x26; // B
            romData[0x42666] = 0x11; // g
            romData[0x42566]= romData[0x42735] = romData[0x4290e] = romData[0x42913] = 0x0f; // e
            romData[0x4290d] = 0x0d; // c
            romData[0x42915] = 0xf4; // item name

               
        }

        private void randomizeInnPrices(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            for (int lnI = 0; lnI < 26; lnI++)
            {
                int innPrice = (r1.Next() % 20) + 1;
                romData[0x367c1 + lnI] -= (byte)(romData[0x367c1 + lnI] % 32);
                romData[0x367c1 + lnI] += (byte)innPrice;
            }

        }

        private void randStatGains(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            //// Randomize starting stats.
            // Give each hero from 22HP (min for Wizard) to about 36 HP.  (Hero)  Just so everybody has a chance!
            romData[0x1eed7] = (byte)((r1.Next() % 13) + 5 + 9);
            // Remove the baseline for HP...
            romData[0x24f4] = 0xea;
            romData[0x24f5] = 0x4c;
            romData[0x24f6] = 0xfa;
            romData[0x24f7] = 0xa4;
            // ... and MP...
            romData[0x2555] = 0xea;
            romData[0x2556] = 0x4c;
            romData[0x2557] = 0x5b;
            romData[0x2558] = 0xa5;
            // ... and the rest!  But we also need to prevent someone gaining 200 points in a stat...
            romData[0x247c] = 0xa9;
            romData[0x247d] = 0x00;
            romData[0x247e] = 0x8d;
            romData[0x247f] = 0x05;
            romData[0x2480] = 0x00;
            romData[0x2481] = 0x4c;
            romData[0x2482] = 0x7d;
            romData[0x2483] = 0xa4;

            // TRY TWO
            // Max array:  [7, 5]
            // ORDER:  Hero, Wizard, Pilgrim, Sage, Soldier, Merchant, Fighter, Goof-off
            int[,] heroL41Gains = new int[,] {
                               { 134, 77, 166, 121, 69 },
                               { 33, 125, 106, 143, 108 },
                               { 55, 79, 110, 120, 107 },
                               { 80, 90, 127, 79, 97 },
                               { 149, 37, 191, 32, 33 },
                               { 96, 75, 122, 54, 60 },
                               { 188, 191, 143, 145, 43 },
                               { 36, 47, 84, 210, 52 }
                               };

            //heroL41Gains[8, 0] = 0;
            // Randomize the four multipliers from 8 to 32.  Each multiplier has six bytes.
            for (int lnI = 0; lnI < 2; lnI++)
                for (int lnJ = 0; lnJ < 5; lnJ++)
                {
                    int byteToUse2 = 0x281b + (lnI * 5) + lnJ;
                    romData[byteToUse2] = (byte)(((r1.Next() % 4) + 1) * 8);
                }

            // Randomize the levels to the next multiplier from 0 to 24.(First 4 bytes)  Always make the 5th byte "99" (63 hex).
            // Calculate the base gain based on the four multipliers.  Try to get as close to the target gain for each stat as possible.
            // Char byteToUse - 0x4a15b, 0x4a17f, 0x4a1a3, 0x4a1c7, 0x4a1eb, 0x4a20f, 0x4a22d, 0x4a24b
            int byteToUse = 0x290e;
            // 40 bytes for strength, 40 bytes for agility, 40 bytes for vitality, 40 bytes for luck, 40 bytes for intelligence, in that order.  NOT in character order, statistic order!
            for (int lnJ = 0; lnJ < 5; lnJ++)
            {
                for (int lnI = 0; lnI < 8; lnI++)
                {
                    if (optMonsterSilly.Checked || optMonsterMedium.Checked)
                    {
                        int randomDir = (r1.Next() % 3);
                        int difference = heroL41Gains[lnI, lnJ] / (optMonsterSilly.Checked ? 4 : 2);
                        if (randomDir == 0)
                            heroL41Gains[lnI, lnJ] -= (r1.Next() % difference);
                        if (randomDir == 1)
                            heroL41Gains[lnI, lnJ] += (r1.Next() % difference);
                    }
                    if (optMonsterHeavy.Checked)
                    {
                        if (lnJ == 2)
                            heroL41Gains[lnI, lnJ] = (r1.Next() % (lnI == 0 || lnI >= 4 ? 140 : 170)) + (lnI == 0 || lnI >= 4 ? 110 : 80);
                        else if (lnJ == 0)
                            heroL41Gains[lnI, lnJ] = (r1.Next() % (lnI == 0 || lnI >= 4 ? 180 : 220)) + (lnI == 0 || lnI >= 4 ? 70 : 30);
                        else
                            heroL41Gains[lnI, lnJ] = (r1.Next() % (lnJ == 4 && lnI <= 3 ? 180 : 210) + (lnJ == 4 && lnI <= 3 ? 70 : 40));
                    }

                    int[] levels = { 0, 0, 0, 0, 99 };
                    for (int lnK = 0; lnK < 4; lnK++)
                        levels[lnK] = (byte)(r1.Next() % 50);
                    Array.Sort(levels);
                    //for (int lnK = 0; lnK < 4; lnK++)
                    //{
                    //    if ((lnK == 0 && baseStat % 2 == 1) || (lnK == 1 && baseStat % 4 >= 2) || (lnK == 2 && baseStat % 8 >= 4) || (lnK == 3 && baseStat % 16 >= 8))
                    //        romData[byteToUse + lnK] = (byte)(128 + levels[lnK]);
                    //    else
                    //        romData[byteToUse + lnK] = (byte)(levels[lnK]);
                    //}

                    //if (baseStat >= 16)
                    //    romData[byteToUse + 4] = 99 + 128;
                    //else
                    //    romData[byteToUse + 4] = 99;

                    // Averages:  8-16 = .6/level, 24-32 = 1.6/level, 40-48 = 2.6/level, 56-64 = 3.6/level, 72-80 = 4.6/level, 88-96 = 5.6/level, 104-112 = 6.6/level
                    // Maximize base stat at 12 (5.6/level at 8 multiplier)
                    // Now to figure out the multiplier to use (+ 0) and the base multiplier (+ 5)
                    double[] diffs = { 0.0, 0.0, 0.0, 0.0 };
                    int[] baseMult = { 0, 0, 0, 0 };
                    for (int lnK = 0; lnK < 2; lnK++)
                    {
                        for (baseMult[lnK] = 1; baseMult[lnK] <= 12; baseMult[lnK]++)
                        {
                            int byteToUse2 = 0x281b + (lnK * 5); // multipliers
                            double stat = 0.0;
                            int multLevel = 0;

                            for (int lnL = 2; lnL <= 40; lnL++)
                            {
                                int multLevelToUse = (levels[multLevel]);
                                if (lnL > multLevelToUse)
                                    multLevel++;
                                stat += Math.Floor((((double)baseMult[lnK] * romData[byteToUse2 + multLevel]) - 8) / 16) + 0.85;
                            }
                            //baseMult[lnK] = (int)Math.Round(heroL41Gains[lnI, lnJ] / stat);
                            diffs[lnK] = Math.Abs(stat - heroL41Gains[lnI, lnJ]);
                            if (stat > heroL41Gains[lnI, lnJ]) break;
                        }
                    }

                    double lowDiff = 9999;
                    int lowMult = 0;
                    int ultiBaseMult = 0;
                    for (int lnK = 0; lnK < 2; lnK++)
                    {
                        if (diffs[lnK] < lowDiff)
                        {
                            lowDiff = diffs[lnK];
                            lowMult = lnK;
                            ultiBaseMult = baseMult[lnK];
                        }
                    }

                    romData[byteToUse] = (byte)((lowMult == 0 ? 0 : 128) + levels[0]);
                    romData[byteToUse + 1] = (byte)((ultiBaseMult >= 8 ? 128 : 0) + (levels[1] - levels[0]));
                    romData[byteToUse + 2] = (byte)((ultiBaseMult % 8 >= 4 ? 128 : 0) + (levels[2] - levels[1]));
                    romData[byteToUse + 3] = (byte)((ultiBaseMult % 4 >= 2 ? 128 : 0) + (levels[3] - levels[2]));
                    romData[byteToUse + 4] = (byte)((ultiBaseMult % 2 >= 1 ? 128 : 0) + 127);

                    //romData[byteToUse] += (byte)(32 * lowMult);
                    //romData[byteToUse + 5] = (byte)ultiBaseMult;

                    byteToUse += 5;
                }

            }
        }
        
        private void markZoneSides()
        {
            for (int x = 0; x < 16; x++)
                for (int y = 0; y < 16; y++)
                {
                    // 1 = north, 2 = east, 4 = south, 8 = west
                    if (y == 0) zone[y, x] += 1;
                    else if (zone[y - 1, x] / 1000 != zone[y, x] / 1000) zone[y, x] += 1;

                    if (x == 15) zone[y, x] += 2;
                    else if (zone[y, x + 1] / 1000 != zone[y, x] / 1000) zone[y, x] += 2;

                    if (y == 15) zone[y, x] += 4;
                    else if (zone[y + 1, x] / 1000 != zone[y, x] / 1000) zone[y, x] += 4;

                    if (x == 0) zone[y, x] += 8;
                    else if (zone[y, x - 1] / 1000 != zone[y, x] / 1000) zone[y, x] += 8;
                }
        }

        private void generateZoneMap(int zoneToUse, int islandSize, Random r1)
        {
            int xMax = (zoneToUse != -1000 ? (chkSmallMap.Checked ? 128 : 256) : (chkSmallMap.Checked ? 80 : 136)) - 7;
            int yMax = (zoneToUse != -1000 ? (chkSmallMap.Checked ? 128 : 256) : (chkSmallMap.Checked ? 80 : 132)) - 7;
			int yMin = 6;
			int xMin = 6;

            int[] terrainTypes = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7 };

            for (int lnI = 0; lnI < 100; lnI++)
            {
                int swapper1 = r1.Next() % terrainTypes.Length;
                int swapper2 = r1.Next() % terrainTypes.Length;
                int temp = terrainTypes[swapper1];
                terrainTypes[swapper1] = terrainTypes[swapper2];
                terrainTypes[swapper2] = temp;
            }

            int lnMarker = -1;
            int totalLand = 0;

            while (totalLand < islandSize)
            {
                lnMarker++;
                lnMarker = (lnMarker >= terrainTypes.Length ? 0 : lnMarker);
                int sizeToUse = (r1.Next() % 400) + 150;
                //if (terrainTypes[lnMarker] == 5) sizeToUse /= 2;

                List<int> points = new List<int> { (r1.Next() % (xMax - xMin)) + xMin, (r1.Next() % (yMax - yMin)) + yMin };
                if (validPoint(points[0], points[1], zoneToUse))
                {
                    while (sizeToUse > 0)
                    {
                        List<int> newPoints = new List<int>();
                        for (int lnI = 0; lnI < points.Count; lnI += 2)
                        {
                            int lnX = points[lnI];
                            int lnY = points[lnI + 1];

//                            if (lnX == 127 && lnY == 56) lnX = lnX; // Why redeclare?

                            int direction = (r1.Next() % 16);
                            if (zoneToUse != -1000)
							{
								map[lnY, lnX] = terrainTypes[lnMarker];
								island[lnY, lnX] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
							}
							else
							{
								map2[lnY, lnX] = terrainTypes[lnMarker];
								island2[lnY, lnX] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
							}

							// 1 = North, 2 = east, 4 = south, 8 = west
							if (direction % 8 >= 4 && lnY <= yMax)
                            {
                                if (validPoint(lnX, lnY + 1, zoneToUse))
                                {
                                    if (zoneToUse == -1000)
                                    {
                                        if (map2[lnY + 1, lnX] == 0)
                                            totalLand++;
                                        map2[lnY + 1, lnX] = terrainTypes[lnMarker];
										island2[lnY + 1, lnX] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
									}
									else
                                    {
                                        if (map[lnY + 1, lnX] == 0)
                                            totalLand++;
                                        map[lnY + 1, lnX] = terrainTypes[lnMarker];
                                        island[lnY + 1, lnX] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
									}

                                    newPoints.Add(lnX);
                                    newPoints.Add(lnY + 1);
                                }
                            }
                            if (direction % 2 >= 1 && lnY >= yMin)
                            {
                                if (validPoint(lnX, lnY - 1, zoneToUse))
                                {
                                    if (zoneToUse == -1000)
                                    {
                                        if (map2[lnY - 1, lnX] == 0)
                                            totalLand++;
                                        map2[lnY - 1, lnX] = terrainTypes[lnMarker];
										island2[lnY - 1, lnX] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
									}
									else
                                    {
                                        if (map[lnY - 1, lnX] == 0)
                                            totalLand++;
                                        map[lnY - 1, lnX] = terrainTypes[lnMarker];
                                        island[lnY - 1, lnX] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
									}
                                    newPoints.Add(lnX);
                                    newPoints.Add(lnY - 1);
                                }
                            }
                            if (direction % 4 >= 2 && lnX <= xMax)
                            {
                                if (validPoint(lnX + 1, lnY, zoneToUse))
                                {
                                    if (zoneToUse == -1000)
                                    {
                                        if (map2[lnY, lnX + 1] == 0)
                                            totalLand++;
                                        map2[lnY, lnX + 1] = terrainTypes[lnMarker];
										island2[lnY, lnX + 1] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
									}
									else
                                    {
                                        if (map[lnY, lnX + 1] == 0)
                                            totalLand++;
                                        map[lnY, lnX + 1] = terrainTypes[lnMarker];
                                        island[lnY, lnX + 1] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
									}
                                    newPoints.Add(lnX + 1);
                                    newPoints.Add(lnY);
                                }
                            }
                            if (direction % 16 >= 8 && lnX >= xMin)
                            {
                                if (validPoint(lnX - 1, lnY, zoneToUse))
                                {
                                    if (zoneToUse == -1000)
                                    {
                                        if (map2[lnY, lnX - 1] == 0)
                                            totalLand++;
                                        map2[lnY, lnX - 1] = terrainTypes[lnMarker];
										island2[lnY, lnX - 1] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
									}
									else
                                    {
                                        if (map[lnY, lnX - 1] == 0)
                                            totalLand++;
                                        map[lnY, lnX - 1] = terrainTypes[lnMarker];
										island[lnY, lnX - 1] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
									}
                                    newPoints.Add(lnX - 1);
                                    newPoints.Add(lnY);
                                }
                            }

                            int takeaway = 1 + (direction > 8 ? 1 : 0) + (direction % 8 > 4 ? 1 : 0) + (direction % 4 > 2 ? 1 : 0) + (direction % 2 > 1 ? 1 : 0);
                            sizeToUse--;
                        }
                        if (sizeToUse <= 0) break;
                        if (newPoints.Count != 0)
                            points = newPoints;
                    }
                }
            }

            // Fill in water...
            List<int> land = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            if (zoneToUse != -1000)
            {
                for (int lnY = 0; lnY < 256; lnY++)
                    for (int lnX = 0; lnX < 256; lnX++)
                    {
                        if (island[lnY, lnX] == zoneToUse && island[lnY, lnX + 1] == zoneToUse && island[lnY, lnX + 2] == zoneToUse && island[lnY, lnX + 3] == zoneToUse)
                        {
                            if (map[lnY, lnX] == map[lnY, lnX + 2] && map[lnY, lnX] != map[lnY, lnX + 1])
                            {
                                map[lnY, lnX + 1] = map[lnY, lnX];
                                island[lnY, lnX + 1] = island[lnY, lnX];
                            }
                            if (lnX < 254 && land.Contains(map[lnY, lnX]) && !land.Contains(map[lnY, lnX + 1]) && !land.Contains(map[lnY, lnX + 2]) && land.Contains(map[lnY, lnX + 3]))
                            {
                                map[lnY, lnX + 1] = map[lnY, lnX];
                                map[lnY, lnX + 2] = map[lnY, lnX + 3];
                                island[lnY, lnX + 1] = island[lnY, lnX];
                                island[lnY, lnX + 2] = island[lnY, lnX + 3];
                            }
                        }
                    }

                markIslands(zoneToUse);
            }
            else
            {
                for (int lnY = 0; lnY < 136; lnY++)
                    for (int lnX = 0; lnX < 156; lnX++)
                    {
                        if (map2[lnY, lnX] == map2[lnY, lnX + 2] && map2[lnY, lnX] != map2[lnY, lnX + 1])
						{
							map2[lnY, lnX + 1] = map2[lnY, lnX];
							island2[lnY, lnX + 1] = island2[lnY, lnX];
						}
                        if (lnX < 149 && land.Contains(map2[lnY, lnX]) && !land.Contains(map2[lnY, lnX + 1]) && !land.Contains(map2[lnY, lnX + 2]) && land.Contains(map2[lnY, lnX + 3]))
                        {
                            map2[lnY, lnX + 1] = map2[lnY, lnX];
                            map2[lnY, lnX + 2] = map2[lnY, lnX + 3];
							island2[lnY, lnX + 1] = island2[lnY, lnX];
							island2[lnY, lnX + 2] = island2[lnY, lnX + 3];
                        }
                    }
            }
        }

        private void smoothMap()
        {
            // Remove one byte lands
            for (int lnX = 0; lnX < 254; lnX++)
                for (int lnY = 0; lnY < 256; lnY++)
                {
                    if (map[lnY, lnX] != map[lnY, lnX + 1] && map[lnY, lnX + 1] != map[lnY, lnX + 2] && island[lnY, lnX] == island[lnY, lnX + 2])
                    {
                        map[lnY, lnX + 1] = map[lnY, lnX];
                        island[lnY, lnX + 1] = island[lnY, lnX];
                    }
                }

            int smoothRequirement = 10;
            bool badMap = true;

            while (badMap)
            {
                // Let's PRETEND to enter this into the ROM...
                int lnPointer = 0x821a;

                for (int lnI = 0; lnI <= 256; lnI++) // <---- There is a final pointer for lnI = 256, probably indicating the conclusion of the map.
                {
                    int lnJ = 0;
                    while (lnI < 256 && lnJ < 256)
                    {
                        if (map[lnI, lnJ] >= 0 && map[lnI, lnJ] <= 7)
                        {
                            int tileNumber = 0;
                            int numberToMatch = map[lnI, lnJ];
                            while (lnJ < 256 && tileNumber < (numberToMatch == 7 ? 8 : 32) && map[lnI, lnJ] == numberToMatch)
                            {
                                tileNumber++;
                                lnJ++;
                            }
                            lnPointer++;
                        }
                        else
                        {
                            lnPointer++;
                            lnJ++;
                        }
                    }
                }
                //lnPointer = lnPointer;
                if (lnPointer <= 0x9a94 - 320)
                    badMap = false;
                else // Time to remove small areas of stuff to hopefully compress the map further.
                {
                    //MessageBox.Show("Map too big; " + (lnPointer - (0x9a94 - 256)).ToString() + " bytes too big");

                    int lastTile = 0x00;
                    int lastIsland = island[0, 0];
                    for (int lnY = 0; lnY < 255; lnY++)
                        for (int lnX = 0; lnX < 255; lnX++)
                        {
                            smoothPlot(lnX, lnY, smoothRequirement, lastTile, lastIsland);
                            lastTile = map[lnY, lnX];
                            lastIsland = island[lnY, lnX];
                        }

                    smoothRequirement += 10;
                }
            }
        }

		private void smoothMap2()
		{
			// Remove one byte lands
			for (int lnX = 0; lnX < 156; lnX++)
				for (int lnY = 0; lnY < 139; lnY++)
				{
					if (map2[lnY, lnX] != map2[lnY, lnX + 1] && map2[lnY, lnX + 1] != map2[lnY, lnX + 2] && island2[lnY, lnX] == island2[lnY, lnX + 2])
					{
						map2[lnY, lnX + 1] = map2[lnY, lnX];
						island2[lnY, lnX + 1] = island2[lnY, lnX];
					}
				}

			int smoothRequirement = 10;
			bool badMap = true;

			while (badMap)
			{
				// Let's PRETEND to enter this into the ROM...
				int lnPointer = 0x9bab;

				for (int lnI = 0; lnI <= 138; lnI++) // <---- There is a final pointer for lnI = 256, probably indicating the conclusion of the map2.
				{
					int lnJ = 0;
					while (lnI < 139 && lnJ < 158)
					{
						if (map2[lnI, lnJ] >= 0 && map2[lnI, lnJ] <= 7)
						{
							int tileNumber = 0;
							int numberToMatch = map2[lnI, lnJ];
							while (lnJ < 158 && tileNumber < (numberToMatch == 7 ? 8 : 32) && map2[lnI, lnJ] == numberToMatch)
							{
								tileNumber++;
								lnJ++;
							}
							lnPointer++;
						}
						else
						{
							lnPointer++;
							lnJ++;
						}
					}
				}
				//lnPointer = lnPointer;
				if (lnPointer <= 0xa3ee - 80)
					badMap = false;
				else // Time to remove small areas of stuff to hopefully compress the map further.
				{
					//MessageBox.Show("Map too big; " + (lnPointer - (0x9a94 - 256)).ToString() + " bytes too big");

					int lastTile = 0x00;
					int lastIsland = island2[0, 0];
					for (int lnY = 0; lnY < 139; lnY++)
						for (int lnX = 0; lnX < 158; lnX++)
						{
							smoothPlot2(lnX, lnY, smoothRequirement, lastTile, lastIsland);
							lastTile = map2[lnY, lnX];
							lastIsland = island2[lnY, lnX];
						}

					smoothRequirement += 10;
				}
			}

		}

		private void smoothPlot(int initX, int initY, int minimum, int fillTile, int fillIsland)
        {
            //if (y == 30 && x == 137)
            //    y = y;

            int x = initX;
            int y = initY;

            bool[,] plotted = new bool[256, 256];
            int landTile = map[y, x];

            bool first = true;
            List<int> toPlot = new List<int>();
            int plots = 0;
            int toFill = 0;
            while (toFill < 2)
            {
                while (first || toPlot.Count != 0)
                {
                    if (!first)
                    {
                        y = toPlot[0];
                        toPlot.RemoveAt(0);
                        x = toPlot[0];
                        toPlot.RemoveAt(0);
                    }
                    else
                        first = false;

                    if (toFill == 1)
                    {
                        map[y, x] = fillTile;
                        island[y, x] = fillIsland;
                    }

                    for (int dir = 0; dir < 5; dir++)
                    {
                        int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                        dirX = (dirX == 256 ? 0 : dirX == -1 ? 255 : dirX);
                        int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                        dirY = (dirY == 256 ? 0 : dirY == -1 ? 255 : dirY);

                        if (map[dirY, dirX] == landTile && !plotted[dirY, dirX])
                        {
                            plots++;
                            plotted[dirY, dirX] = true;

                            if (plots > minimum)
                                return;

                            if (dir != 0)
                            {
                                toPlot.Add(dirY);
                                toPlot.Add(dirX);
                            }
                        }
                    }
                }

                toFill++;
                x = initX;
                y = initY;
                first = true;
            }
        }

		private void smoothPlot2(int initX, int initY, int minimum, int fillTile, int fillIsland)
		{
			//if (y == 30 && x == 137)
			//    y = y;

			int x = initX;
			int y = initY;

			bool[,] plotted = new bool[139, 158];
			int landTile = map2[y, x];

			bool first = true;
			List<int> toPlot = new List<int>();
			int plots = 0;
			int toFill = 0;
			while (toFill < 2)
			{
				while (first || toPlot.Count != 0)
				{
					if (!first)
					{
						y = toPlot[0];
						toPlot.RemoveAt(0);
						x = toPlot[0];
						toPlot.RemoveAt(0);
					}
					else
						first = false;

					if (toFill == 1)
					{
						map2[y, x] = fillTile;
						island2[y, x] = fillIsland;
					}

					for (int dir = 0; dir < 5; dir++)
					{
						int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
						dirX = (dirX == 158 ? 0 : dirX == -1 ? 157 : dirX);
						int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
						dirY = (dirY == 139 ? 0 : dirY == -1 ? 138 : dirY);

						if (map2[dirY, dirX] == landTile && !plotted[dirY, dirX])
						{
							plots++;
							plotted[dirY, dirX] = true;

							if (plots > minimum)
								return;

							if (dir != 0)
							{
								toPlot.Add(dirY);
								toPlot.Add(dirX);
							}
						}
					}
				}

				toFill++;
				x = initX;
				y = initY;
				first = true;
			}
		}

		private bool validPoint(int x, int y, int zoneToUse)
        {
            if (zoneToUse == -1000) return true;
            int zoneSize = (chkSmallMap.Checked ? 8 : 16);
            // Establish zone
            int zoneX = x / zoneSize;
            int zoneY = y / zoneSize;
            int zoneSides = zone[zoneY, zoneX] % 1000;
            //if (zone[zoneY, zoneX] % 1000 != 0) return false;
            if (zone[zoneY, zoneX] / 1000 != zoneToUse / 1000) return false;
            // 1 = north, 2 = east, 4 = south, 8 = west
            if (y % zoneSize == 0 && zoneSides % 2 == 1) return false;
            if (x % zoneSize == zoneSize - 1 && zoneSides % 4 >= 2) return false;
            if (y % zoneSize == zoneSize - 1 && zoneSides % 8 >= 4) return false;
            if (x % zoneSize == 0 && zoneSides % 16 >= 8) return false;

            return true;
        }

        private void markIslands(int zoneToUse)
        {
			if (zoneToUse != -1000)
			{
				// We should mark islands and inaccessible land...
				int landNumber = zoneToUse + 1;
				int maxLand = -2;

				int maxLandPlots = 0;
				int lastIsland = 0;
				for (int lnI = 0; lnI < 256; lnI++)
					for (int lnJ = 0; lnJ < 256; lnJ++)
					{
						if (island[lnI, lnJ] == zoneToUse && map[lnI, lnJ] != 0x06)
						{
							int plots = landPlot(landNumber, lnI, lnJ, zoneToUse);
							if (plots > maxLandPlots)
							{
								maxLandPlots = plots;
								maxLand = landNumber;
							}
							islands.Add(landNumber);
							landNumber++;

							lastIsland = island[lnI, lnJ];
						}
					}

				maxIsland[zoneToUse / 1000] = maxLand;
			} else
			{
				// We should mark islands and inaccessible land...
				int landNumber = 1;

				for (int lnI = 0; lnI < 139; lnI++)
					for (int lnJ = 0; lnJ < 158; lnJ++)
					{
						if (island2[lnI, lnJ] == 0 && map2[lnI, lnJ] != 0x06)
						{
							int plots = landPlot(landNumber, lnI, lnJ, zoneToUse);
							landNumber++;
						}
					}
			}
		}

        private void resetIslands()
        {
            for (int y = 0; y < 256; y++)
                for (int x = 0; x < 256; x++)
                {
                    if (island[y, x] != 200 && island[y, x] != -1)
                    {
                        island[y, x] /= 1000;
                        island[y, x] *= 1000;
                    }
                }

            islands.Clear();

            markIslands(1000);
            markIslands(2000);
            markIslands(0);
            markIslands(-1000);
        }

        private void createBridges(Random r1)
        {
            List<BridgeList> bridgePossible = new List<BridgeList>();
            List<islandLinks> islandPossible = new List<islandLinks>();
            // Create bridges for points two spaces or less from two distinctly numbered islands.  Extend islands if there is interference.
            // 0x00 = Water (was 0x04 in DW2)
            // 0x06 = Mountain (was 0x05 in DW2)
            for (int y = 1; y < 252; y++)
                for (int x = 1; x < 252; x++)
                {
                    if (y == 63 && x == 8) map[y, x] = map[y, x];
                    if (map[y, x] == 0x06 || map[y, x] == 0x00) continue;

                    for (int lnI = 2; lnI <= 4; lnI++)
                    {
                        if (island[y, x] != island[y + lnI, x] && island[y, x] / 1000 == island[y + lnI, x] / 1000 && map[y + lnI, x] != 0x00 && map[y + lnI, x] != 0x06)
                        {
                            bool fail = false;
                            for (int lnJ = 1; lnJ < lnI; lnJ++)
                            {
                                if (map[y + lnJ, x] == 0x00)
                                {
                                    map[y + lnJ, x - 1] = 0x00; map[y + lnJ, x + 1] = 0x00;
                                    island[y + lnJ, x - 1] = 0x00; island[y + lnJ, x + 1] = 0x00;
                                }
                                else
                                {
                                    fail = true;
                                }
                            }
                            if (!fail)
                            {
                                bridgePossible.Add(new BridgeList(x, y, true, lnI, island[y, x], island[y + lnI, x]));
                                if (islandPossible.Where(c => c.island1 == island[y, x] && c.island2 == island[y + lnI, x]).Count() == 0)
                                    islandPossible.Add(new islandLinks(island[y, x], island[y + lnI, x]));
                            }
                        }

                        if (island[y, x] != island[y, x + lnI] && island[y, x] / 1000 == island[y, x + lnI] / 1000 && map[y, x + lnI] != 0x00 && map[y, x + lnI] != 0x06)
                        {
                            bool fail = false;
                            for (int lnJ = 1; lnJ < lnI; lnJ++)
                            {
                                if (map[y, x + lnJ] == 0x00)
                                {
                                    map[y - 1, x + lnJ] = 0x00; map[y + 1, x + lnJ] = 0x00;
                                    island[y - 1, x + lnJ] = 200; island[y + 1, x + lnJ] = 200;
                                }
                                else
                                {
                                    fail = true;
                                }
                            }
                            if (!fail)
                            {
                                bridgePossible.Add(new BridgeList(x, y, false, lnI, island[y, x], island[y, x + lnI]));
                                if (islandPossible.Where(c => c.island1 == island[y, x] && c.island2 == island[y, x + lnI]).Count() == 0)
                                    islandPossible.Add(new islandLinks(island[y, x], island[y, x + lnI]));
                            }
                        }
                    }
                }

            foreach (islandLinks islandLink in islandPossible)
            {
                List<BridgeList> test = bridgePossible.Where(c => c.island1 == islandLink.island1 && c.island2 == islandLink.island2).ToList();
                // Choose one bridge out of the possibilities
                BridgeList bridgeToBuild = test[r1.Next() % test.Count];
                for (int lnI = 1; lnI <= bridgeToBuild.distance - 1; lnI++)
                {
                    if (bridgeToBuild.south)
                    {
                        map[bridgeToBuild.y + lnI, bridgeToBuild.x] = (lnI == bridgeToBuild.distance - 1 ? 0xff : map[bridgeToBuild.y, bridgeToBuild.x]);
                        island[bridgeToBuild.y + lnI, bridgeToBuild.x] = bridgeToBuild.island1;

                        if (map[bridgeToBuild.y + lnI + 1, bridgeToBuild.x] == 0x00 && lnI == bridgeToBuild.distance - 1)
                        {
                            bridgeToBuild.distance++;
                            map[bridgeToBuild.y + lnI + 1, bridgeToBuild.x - 1] = 0x00; map[bridgeToBuild.y + lnI + 1, bridgeToBuild.x + 1] = 0x00;
                            island[bridgeToBuild.y + lnI + 1, bridgeToBuild.x - 1] = 0x00; island[bridgeToBuild.y + lnI + 1, bridgeToBuild.x + 1] = 0x00;
                        }
                    }
                    else
                    {
                        map[bridgeToBuild.y, bridgeToBuild.x + lnI] = (lnI == bridgeToBuild.distance - 1 ? 0xfb : map[bridgeToBuild.y, bridgeToBuild.x]);
                        island[bridgeToBuild.y, bridgeToBuild.x + lnI] = bridgeToBuild.island1;

                        if (map[bridgeToBuild.y, bridgeToBuild.x + lnI + 1] == 0x00 && lnI == bridgeToBuild.distance - 1)
                        {
                            bridgeToBuild.distance++;
                            map[bridgeToBuild.y - 1, bridgeToBuild.x + lnI + 1] = 0x00; map[bridgeToBuild.y + 1, bridgeToBuild.x + lnI + 1] = 0x00;
                            island[bridgeToBuild.y - 1, bridgeToBuild.x + lnI + 1] = 200; island[bridgeToBuild.y + 1, bridgeToBuild.x + lnI + 1] = 200;
                        }
                    }
                }
            }
        }

        private class islandLinks
        {
            public int island1;
            public int island2;

            public islandLinks(int pI1, int pI2)
            {
                island1 = pI1; island2 = pI2;
            }
        }

        private class BridgeList
        {
            public int x;
            public int y;
            public bool south;
            public int distance;
            public int island1;
            public int island2;

            public BridgeList(int pX, int pY, bool pS, int pDist, int pI1, int pI2)
            {
                x = pX; y = pY; south = pS; distance = pDist; island1 = pI1; island2 = pI2;
            }
        }

        private bool createZone(int zoneNumber, int size, bool rectangle, Random r1)
        {
            int tries = 1000;
            bool firstZone = true;

			if (!rectangle)
            {
                while (size > 0 && tries > 0)
                {
                    int x = r1.Next() % 16;
                    int y = r1.Next() % 16;
                    int minX = x, maxX = x, minY = y, maxY = y;
                    if (!firstZone && zone[x, y] != zoneNumber)
                    {
                        continue;
                    }
                    if (firstZone)
                    {
                        firstZone = false;
                        zone[x, y] = zoneNumber;
                    }

                    tries--;
                    int direction = r1.Next() % 16;
                    int totalDirections = 0;
                    if (direction % 16 >= 8) totalDirections++;
                    if (direction % 8 >= 4) totalDirections++;
                    if (direction % 4 >= 2) totalDirections++;
                    if (direction % 2 >= 1) totalDirections++;
                    if (totalDirections > size) continue;

                    // 1 = north, 2 = east, 4 = south, 8 = west
                    if (direction % 16 >= 8 && x != 0 && zone[x - 1, y] == 0 && (minX <= (x - 1) || maxX - minX <= 11))
                    {
                        zone[x - 1, y] = zoneNumber;
                        minX = (x - 1 < minX ? x - 1 : minX);
                        size--;
                        tries = 100;
                    }
                    if (direction % 8 >= 4 && y != 15 && zone[x, y + 1] == 0 && (maxY >= (y + 1) || maxY - minY <= 11))
                    {
                        zone[x, y + 1] = zoneNumber;
                        maxY = (y + 1 > maxY ? y + 1 : maxY);
                        size--;
                        tries = 100;
                    }
                    if (direction % 4 >= 2 && x != 15 && zone[x + 1, y] == 0 && (minX >= (x + 1) || maxX - minX <= 11))
                    {
                        zone[x + 1, y] = zoneNumber;
                        maxX = (x + 1 > maxX ? x + 1 : maxX);
                        size--;
                        tries = 100;
                    }
                    if (direction % 2 >= 1 && y != 0 && zone[x, y - 1] == 0 && (minY <= (y - 1) || maxY - minY <= 11))
                    {
                        zone[x, y - 1] = zoneNumber;
                        minY = (y - 1 < minY ? y - 1 : minY);
                        size--;
                        tries = 100;
                    }
                }
                return (size <= 0);
            }
            else
            {
                int minMeasurement = (int)Math.Ceiling((double)size / 12);
                int maxMeasurement = (int)Math.Ceiling((double)size / minMeasurement);

                int length = ((r1.Next() % (maxMeasurement - minMeasurement)) + minMeasurement);
                int width = size / length;

                int x = (r1.Next() % (16 - length));
                int y = (r1.Next() % (16 - width));

                for (int i = x; i < x + length; i++)
                    for (int j = y; j < y + width; j++)
                        zone[i, j] = zoneNumber;

				return true;
            }
        }

        private bool reachable(int startY, int startX, bool water, int finishX, int finishY, int maxLake, bool alefgard)
        {
            int x = startX;
            int y = startY;

            List<int> validPlots = new List<int> { 1, 2, 3, 4, 5, 7, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xed, 0xef, 0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xfb, 0xff };
            if (water) validPlots.Add(0);

            bool first = true;
            List<int> toPlot = new List<int>();

			if (alefgard)
			{
				bool[,] plotted = new bool[139, 158];

				while (first || toPlot.Count != 0)
				{
					if (!first)
					{
						y = toPlot[0];
						toPlot.RemoveAt(0);
						x = toPlot[0];
						toPlot.RemoveAt(0);
					}
					else
					{
						first = false;
					}

					for (int dir = 0; dir < 5; dir++)
					{
						int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
						dirX = (dirX == 158 ? 0 : dirX == -1 ? 157 : dirX);
						int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
						dirY = (dirY == 139 ? 0 : dirY == -1 ? 138 : dirY);

						if (validPlots.Contains(map2[dirY, dirX]) && (map2[dirY, dirX] != 0 || island2[dirY, dirX] == maxLake))
						{
							if (dir != 0 && plotted[dirY, dirX] == false)
							{
								if (finishX == dirX && finishY == dirY)
									return true;
								toPlot.Add(dirY);
								toPlot.Add(dirX);
								plotted[dirY, dirX] = true;
							}
						}
					}
				}

				return false;
			}
			else
			{
				bool[,] plotted = new bool[256, 256];

				while (first || toPlot.Count != 0)
				{
					if (!first)
					{
						y = toPlot[0];
						toPlot.RemoveAt(0);
						x = toPlot[0];
						toPlot.RemoveAt(0);
					}
					else
					{
						first = false;
					}

					for (int dir = 0; dir < 5; dir++)
					{
						int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
						dirX = (dirX == 256 ? 0 : dirX == -1 ? 255 : dirX);
						int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
						dirY = (dirY == 256 ? 0 : dirY == -1 ? 255 : dirY);

						if (validPlots.Contains(map[dirY, dirX]) && (map[dirY, dirX] != 0 || island[dirY, dirX] == maxLake))
						{
							if (dir != 0 && plotted[dirY, dirX] == false)
							{
								if (finishX == dirX && finishY == dirY)
									return true;
								toPlot.Add(dirY);
								toPlot.Add(dirX);
								plotted[dirY, dirX] = true;
							}
						}
					}
				}

				return false;
			}
		}

        private int landPlot(int landNumber, int y, int x, int zoneToUse = 0)
        {
            bool first = true;
            List<int> toPlot = new List<int>();
            int plots = 1;
            while (first || toPlot.Count != 0)
            {
                if (!first)
                {
                    y = toPlot[0];
                    toPlot.RemoveAt(0);
                    x = toPlot[0];
                    toPlot.RemoveAt(0);
                }
                else
                {
                    first = false;
                }

				for (int dir = 0; dir < 5; dir++)
				{
					if (zoneToUse != -1000)
					{
						int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
						dirX = (dirX == 256 ? 0 : dirX == -1 ? 255 : dirX);
						int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
						dirY = (dirY == 256 ? 0 : dirY == -1 ? 255 : dirY);

						if (island[dirY, dirX] == zoneToUse)
						{
							plots++;
							island[dirY, dirX] = landNumber;

							if (dir != 0)
							{
								toPlot.Add(dirY);
								toPlot.Add(dirX);
							}
						}
					} else
					{
						int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
						dirX = (dirX == 158 ? 0 : dirX == -1 ? 157 : dirX);
						int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
						dirY = (dirY == 138 ? 0 : dirY == -1 ? 137 : dirY);

						if (island2[dirY, dirX] == 0)
						{
							plots++;
							island2[dirY, dirX] = landNumber;

							if (dir != 0)
							{
								toPlot.Add(dirY);
								toPlot.Add(dirX);
							}
						}
					}
				}
            }

            return plots;
        }

        private bool validPlot(int y, int x, int height, int width, int[] legalIsland)
        {
			if (legalIsland[0] == 60000)
			{
				for (int lnI = 0; lnI < height; lnI++)
					for (int lnJ = 0; lnJ < width; lnJ++)
					{
						if (y + lnI >= 137 || x + lnJ >= 156) return false;

						int legalY = y + lnI;
						int legalX = x + lnJ;

						if (map2[legalY, legalX] == 0x00 || map2[legalY, legalX] == 0x06 || map2[legalY, legalX] >= 0xe8 || map[legalY, legalX] >= 0xe8) // LAST CONDITION:  Castles, towns, villages, etc - Need to not match BOTH maps!
							return false;
					}
			}
			else
			{
				for (int lnI = 0; lnI < height; lnI++)
					for (int lnJ = 0; lnJ < width; lnJ++)
					{
						if (y + lnI >= (chkSmallMap.Checked ? 128 : 256) || x + lnJ >= (chkSmallMap.Checked ? 128 : 256)) return false;

						int legalY = (y + lnI >= 256 ? y - 256 + lnI : y + lnI);
						int legalX = (x + lnJ >= 256 ? x - 256 + lnJ : x + lnJ);

						bool ok = false;
						for (int lnK = 0; lnK < legalIsland.Length; lnK++)
							if (island[legalY, legalX] == legalIsland[lnK])
								ok = true;
						if (!ok) return false;
						if (legalY < 139 && legalX < 158)
						{
							if (map[legalY, legalX] == 0x00 || map[legalY, legalX] == 0x06 || map[legalY, legalX] >= 0xe8 || map2[legalY, legalX] >= 0xe8) // LAST CONDITION:  Castles, towns, villages, etc - Need to not match BOTH maps!
								return false;
						}
						else
						{
							if (map[legalY, legalX] == 0x00 || map[legalY, legalX] == 0x06 || map[legalY, legalX] >= 0xe8) // LAST CONDITION:  Castles, towns, villages, etc
								return false;
						}
					}
			}
			return true;
        }

        private int lakePlot(int lakeNumber, int y, int x, bool fill = false, int islandNumber = -1)
        {
            bool first = true;
            List<int> toPlot = new List<int>();
            int plots = 1;
            //if (islandNumber >= 0) plots = 1;
            while (first || toPlot.Count != 0)
            {
                if (!first)
                {
                    y = toPlot[0];
                    toPlot.RemoveAt(0);
                    x = toPlot[0];
                    toPlot.RemoveAt(0);
                }
                else
                {
                    if (fill)
                        map[y, x] = (islandNumber == 0 ? 0x02 : islandNumber == 1 ? 0x03 : islandNumber == 2 ? 0x04 : islandNumber == 3 ? 0x01 : 0x05);
                    first = false;
                }

                for (int dir = 0; dir < 5; dir++)
                {
                    int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                    dirX = (dirX == 256 ? 0 : dirX == -1 ? 255 : dirX);
                    int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                    dirY = (dirY == 256 ? 0 : dirY == -1 ? 255 : dirY);

                    if (island[dirY, dirX] == -1 || (island[dirY, dirX] == lakeNumber && fill))
                    {
                        plots++;
                        island[dirY, dirX] = (fill ? islandNumber : lakeNumber);
                        if (fill)
                            map[dirY, dirX] = (islandNumber == 0 ? 0x02 : islandNumber == 1 ? 0x03 : islandNumber == 2 ? 0x04 : islandNumber == 3 ? 0x01 : 0x05);

                        if (dir != 0)
                        {
                            toPlot.Add(dirY);
                            toPlot.Add(dirX);
                        }
                        //plots += lakePlot(lakeNumber, y, x, fill);
                    }
                }
            }

            return plots;
        }

		private int lakePlot2(int lakeNumber, int y, int x, bool fill = false, int islandNumber = -1)
		{
			bool first = true;
			List<int> toPlot = new List<int>();
			int plots = 1;
			//if (islandNumber >= 0) plots = 1;
			while (first || toPlot.Count != 0)
			{
				if (!first)
				{
					y = toPlot[0];
					toPlot.RemoveAt(0);
					x = toPlot[0];
					toPlot.RemoveAt(0);
				}
				else
				{
					if (fill)
						map2[y, x] = (islandNumber == 0 ? 0x02 : islandNumber == 1 ? 0x03 : islandNumber == 2 ? 0x04 : islandNumber == 3 ? 0x01 : 0x05);
					first = false;
				}

				for (int dir = 0; dir < 5; dir++)
				{
					int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
					dirX = (dirX == 158 ? 0 : dirX == -1 ? 157 : dirX);
					int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
					dirY = (dirY == 139 ? 0 : dirY == -1 ? 138 : dirY);

					if (island2[dirY, dirX] == -1 || (island2[dirY, dirX] == lakeNumber && fill))
					{
						plots++;
						island2[dirY, dirX] = (fill ? islandNumber : lakeNumber);
						if (fill)
							map2[dirY, dirX] = (islandNumber == 0 ? 0x02 : islandNumber == 1 ? 0x03 : islandNumber == 2 ? 0x04 : islandNumber == 3 ? 0x01 : 0x05);

						if (dir != 0)
						{
							toPlot.Add(dirY);
							toPlot.Add(dirX);
						}
						//plots += lakePlot(lakeNumber, y, x, fill);
					}
				}
			}

			return plots;
		}

		private void shipPlacement(int byteToUse, int top, int left, int maxLake = 0)
        {
            int minDirection = -99;
            int minDistance = 999;
            int finalX = 0;
            int finalY = 0;
            int distance = 0;
            int lnJ = top;
            int lnK = left;
            for (int lnI = 0; lnI < 4; lnI++)
            {
                lnJ = top;
                lnK = left;
                if (lnI == 0)
                {
                    while (island[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnJ = (lnJ == 0 ? 255 : lnJ - 1);
                    }
                }
                else if (lnI == 1)
                {
                    while (island[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnJ = (lnJ == 255 ? 0 : lnJ + 1);
                    }
                }
                else if (lnI == 2)
                {
                    while (island[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnK = (lnK == 255 ? 0 : lnK + 1);
                    }
                }
                else
                {
                    while (island[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnK = (lnK == 0 ? 255 : lnK - 1);
                    }
                }
                if (distance < minDistance)
                {
                    minDistance = distance;
                    minDirection = lnI;
                    finalX = lnK;
                    finalY = lnJ;
                }
                distance = 0;
            }
            romData[byteToUse] = (byte)(finalX);
            romData[byteToUse + 1] = (byte)(finalY);
            if (minDirection == 0)
            {
                lnJ = (finalY == 255 ? 0 : finalY + 1);
                while (map[lnJ, finalX] == 0x06)
                {
                    map[lnJ, finalX] = 0x05;
                    lnJ = (lnJ == 255 ? 0 : lnJ + 1);
                }
            }
            else if (minDirection == 1)
            {
                lnJ = (finalY == 0 ? 255 : finalY - 1);
                while (map[lnJ, finalX] == 0x06)
                {
                    map[lnJ, finalX] = 0x05;
                    lnJ = (lnJ == 0 ? 255 : lnJ - 1);
                }
            }
            else if (minDirection == 2)
            {
                lnK = (finalX == 0 ? 255 : finalX - 1);
                while (map[finalY, lnK] == 0x06)
                {
                    map[finalY, lnK] = 0x05;
                    lnK = (lnK == 0 ? 255 : lnK - 1);
                }
            }
            else
            {
                lnK = (finalX == 255 ? 0 : finalX + 1);
                while (map[finalY, lnK] == 0x06)
                {
                    map[finalY, lnK] = 0x05;
                    lnK = (lnK == 255 ? 0 : lnK + 1);
                }
            }
        }

		private void shipPlacement2(int byteToUse, int top, int left, int maxLake = 0)
		{
			int minDirection = -99;
			int minDistance = 999;
			int finalX = 0;
			int finalY = 0;
			int distance = 0;
			int lnJ = top;
			int lnK = left;
			for (int lnI = 0; lnI < 4; lnI++)
			{
				lnJ = top;
				lnK = left;
				if (lnI == 0)
				{
					while (island2[lnJ, lnK] != maxLake && distance < 200)
					{
						distance++;
						lnJ = (lnJ == 0 ? 138 : lnJ - 1);
					}
				}
				else if (lnI == 1)
				{
					while (island2[lnJ, lnK] != maxLake && distance < 200)
					{
						distance++;
						lnJ = (lnJ == 138 ? 0 : lnJ + 1);
					}
				}
				else if (lnI == 2)
				{
					while (island2[lnJ, lnK] != maxLake && distance < 200)
					{
						distance++;
						lnK = (lnK == 157 ? 0 : lnK + 1);
					}
				}
				else
				{
					while (island2[lnJ, lnK] != maxLake && distance < 200)
					{
						distance++;
						lnK = (lnK == 0 ? 157 : lnK - 1);
					}
				}
				if (distance < minDistance)
				{
					minDistance = distance;
					minDirection = lnI;
					finalX = lnK;
					finalY = lnJ;
				}
				distance = 0;
			}
			romData[byteToUse] = (byte)(finalX);
			romData[byteToUse + 1] = (byte)(finalY);
			if (minDirection == 0)
			{
				lnJ = (finalY == 255 ? 0 : finalY + 1);
				while (map2[lnJ, finalX] == 0x06)
				{
					map2[lnJ, finalX] = 0x05;
					lnJ = (lnJ == 255 ? 0 : lnJ + 1);
				}
			}
			else if (minDirection == 1)
			{
				lnJ = (finalY == 0 ? 255 : finalY - 1);
				while (map2[lnJ, finalX] == 0x06)
				{
					map2[lnJ, finalX] = 0x05;
					lnJ = (lnJ == 0 ? 255 : lnJ - 1);
				}
			}
			else if (minDirection == 2)
			{
				lnK = (finalX == 0 ? 255 : finalX - 1);
				while (map2[finalY, lnK] == 0x06)
				{
					map2[finalY, lnK] = 0x05;
					lnK = (lnK == 0 ? 255 : lnK - 1);
				}
			}
			else
			{
				lnK = (finalX == 255 ? 0 : finalX + 1);
				while (map2[finalY, lnK] == 0x06)
				{
					map2[finalY, lnK] = 0x05;
					lnK = (lnK == 255 ? 0 : lnK + 1);
				}
			}
		}

		private void boostGP()
        {
            // Replace monster data
            for (int lnI = 0; lnI < 139; lnI++)
            {
                int byteValStart = 0x32e3 + (23 * lnI);

                int gp = romData[byteValStart + 4] + ((romData[byteValStart + 18] % 2) * 256);
                switch (cboGoldReq.SelectedIndex)
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
                }
                gp = (gp > 1000 ? 1000 : gp);

                romData[byteValStart + 4] = (byte)(gp % 256);
                romData[byteValStart + 18] = (byte)(romData[byteValStart + 18] - (romData[byteValStart + 18] % 4) + (gp / 256));
            }
        }

        private void boostXP()
        {
            // Replace monster data
            for (int lnI = 0; lnI < 139; lnI++)
            {
                int byteValStart = 0x32e3 + (23 * lnI);

                int xp = romData[byteValStart + 1] + (romData[byteValStart + 2] * 256);
                switch (cboExpGains.SelectedIndex)
                {
                    case 0:
                        xp *= 5;
                        break;
                    case 1:
                        xp *= 4;
                        break;
                    case 2:
                        xp *= 3;
                        break;
                    case 3:
                        xp *= 2;
                        break;
                    case 4:
                        xp = xp * 3 / 2;
                        break;
                    case 5:
                        break;
                    case 6:
                        xp /= 2;
                        break;
                    case 7:
                        xp /= 4;
                        break;
                }
                xp = (xp > 65500 ? 65500 : xp);

                romData[byteValStart + 1] = (byte)(xp % 256);
                romData[byteValStart + 2] = (byte)(xp / 256);
            }
        }

        private void adjustEncounters()
        {
            for (int i = 0x944; i <= 0x955; i++)
            {
                switch (cboEncounterRate.SelectedIndex)
                {
                    case 0:
                        romData[i] *= 4;
                        break;
                    case 1:
                        romData[i] *= 3;
                        break;
                    case 2:
                        romData[i] *= 2;
                        break;
                    case 3:
                        romData[i] = (byte)(romData[i] * 3 / 2);
                        break;
                    case 4:
                        break;
                    case 5:
                        romData[i] = (byte)(romData[i] * 3 / 4);
                        break;
                    case 6:
                        romData[i] /= 2;
                        break;
                    case 7:
                        romData[i] /= 4;
                        break;
                }
            }
        }

        private void lowerCaseMenus()
        // changes caps menus to lower case
        {
            //Another World
            romData[0x38943] = 0x18;
            romData[0x38944] = 0x19;
            romData[0x38945] = 0x1e;
            romData[0x38946] = 0x12;
            romData[0x38947] = 0x0f;
            romData[0x38948] = 0x1c;
            romData[0x3894b] = 0x19;
            romData[0x3894c] = 0x1c;
            romData[0x3894d] = 0x16;
            romData[0x3894e] = 0x0e;

            //Non Equipped
            romData[0x38a72] = 0x19;
            romData[0x38a73] = 0x18;
            romData[0x38a76] = 0x1b;
            romData[0x38a77] = 0x1f;
            romData[0x38a78] = 0x13;
            romData[0x38a79] = 0x1a;
            romData[0x38a7a] = 0x1a;
            romData[0x38a7b] = 0x0f;
            romData[0x38a7c] = 0x0e;

            //Sex
            romData[0x3913a] = 0x0f;
            romData[0x3913b] = 0x22;

            //Level
            romData[0x39141] = 0x0f;
            romData[0x39142] = 0x20;
            romData[0x39143] = 0x0f;
            romData[0x39144] = 0x16;

            //Attack Power
            romData[0x3925d] = 0x1e;
            romData[0x3925e] = 0x1e;
            romData[0x3925f] = 0x0b;
            romData[0x39260] = 0x0d;
            romData[0x39261] = 0x15;
            romData[0x39265] = 0x19;
            romData[0x39266] = 0x21;
            romData[0x39267] = 0x0f;
            romData[0x39268] = 0x1c;

            //Defense Power
            romData[0x3926f] = 0x0f;
            romData[0x39270] = 0x10;
            romData[0x39271] = 0x0f;
            romData[0x39272] = 0x18;
            romData[0x39273] = 0x1d;
            romData[0x39274] = 0x0f;
            romData[0x39278] = 0x19;
            romData[0x39279] = 0x21;
            romData[0x3927a] = 0x0f;
            romData[0x3927b] = 0x1c;

            //Talk
            romData[0x3940d] = 0x0b;
            romData[0x3940e] = 0x16;
            romData[0x3940f] = 0x15;

            //Spell
            romData[0x39412] = 0x1a;
            romData[0x39413] = 0x0f;
            romData[0x39414] = 0x16;
            romData[0x39415] = 0x16;

            //Status
            romData[0x39418] = 0x1e;
            romData[0x39419] = 0x0b;
            romData[0x3941a] = 0x1e;
            romData[0x3941b] = 0x1f;
            romData[0x3941c] = 0x1d;

            //Item
            romData[0x3941f] = 0x1e;
            romData[0x39420] = 0x0f;
            romData[0x39421] = 0x17;

            //Search
            romData[0x39424] = 0x0f;
            romData[0x39425] = 0x0b;
            romData[0x39426] = 0x1c;
            romData[0x39427] = 0x0d;
            romData[0x39428] = 0x12;

            //Equip
            romData[0x3942b] = 0x1b;
            romData[0x3942c] = 0x1f;
            romData[0x3942d] = 0x13;
            romData[0x3942e] = 0x1a;

            //Use
            romData[0x3943c] = 0x1d;
            romData[0x3943d] = 0x0f;

            //Transfer
            romData[0x39440] = 0x1c;
            romData[0x39441] = 0x0b;
            romData[0x39442] = 0x18;
            romData[0x39443] = 0x1d;
            romData[0x39444] = 0x10;
            romData[0x39445] = 0x0f;
            romData[0x39446] = 0x1c;

            //Discard
            romData[0x39449] = 0x13;
            romData[0x3944a] = 0x1d;
            romData[0x3944b] = 0x0d;
            romData[0x3944c] = 0x0b;
            romData[0x3944d] = 0x1c;
            romData[0x3944e] = 0x0e;

            //Buy
            romData[0x3945c] = 0x1f;
            romData[0x3945d] = 0x23;

            //Sell
            romData[0x39460] = 0x0f;
            romData[0x39461] = 0x16;
            romData[0x39462] = 0x16;

            //Detoxicate
            romData[0x39470] = 0x0f;
            romData[0x39471] = 0x1e;
            romData[0x39472] = 0x19;
            romData[0x39473] = 0x22;
            romData[0x39474] = 0x13;
            romData[0x39475] = 0x0d;
            romData[0x39476] = 0x0b;
            romData[0x39477] = 0x1e;
            romData[0x39478] = 0x0f;

            //Uncurse
            romData[0x3947b] = 0x18;
            romData[0x3947c] = 0x0d;
            romData[0x3947d] = 0x1f;
            romData[0x3947e] = 0x1c;
            romData[0x3947f] = 0x1d;
            romData[0x39480] = 0x0f;

            //Revive
            romData[0x39483] = 0x0f;
            romData[0x39484] = 0x20;
            romData[0x39485] = 0x13;
            romData[0x39486] = 0x20;
            romData[0x39487] = 0x0f;

            //Fight
            romData[0x39495] = 0x13;
            romData[0x39496] = 0x11;
            romData[0x39497] = 0x12;
            romData[0x39498] = 0x1e;

            //Spell
            romData[0x3949b] = 0x1a;
            romData[0x3949c] = 0x0f;
            romData[0x3949d] = 0x16;
            romData[0x3949e] = 0x16;

            //Run
            romData[0x394a1] = 0x1f;
            romData[0x394a2] = 0x18;

            //Item
            romData[0x394a5] = 0x1e;
            romData[0x394a6] = 0x0f;
            romData[0x394a7] = 0x17;

            //Fight
            romData[0x394b5] = 0x13;
            romData[0x394b6] = 0x11;
            romData[0x394b7] = 0x12;
            romData[0x394b8] = 0x1e;

            //Spell
            romData[0x394bb] = 0x1a;
            romData[0x394bc] = 0x0f;
            romData[0x394bd] = 0x16;
            romData[0x394be] = 0x16;

            //Parry
            romData[0x394c1] = 0x0b;
            romData[0x394c2] = 0x1c;
            romData[0x394c3] = 0x1c;
            romData[0x394c4] = 0x23;

            //Item
            romData[0x394c7] = 0x1e;
            romData[0x394c8] = 0x0f;
            romData[0x394c9] = 0x17;

            //Fight
            romData[0x394d7] = 0x13;
            romData[0x394d8] = 0x11;
            romData[0x394d9] = 0x12;
            romData[0x394da] = 0x1e;

            //Run
            romData[0x394dd] = 0x1f;
            romData[0x394de] = 0x18;

            //Parry
            romData[0x394e1] = 0x0b;
            romData[0x394e2] = 0x1c;
            romData[0x394e3] = 0x1c;
            romData[0x394e4] = 0x23;

            //Item
            romData[0x394e7] = 0x1e;
            romData[0x394e8] = 0x0f;
            romData[0x394e9] = 0x17;

            //Fight
            romData[0x394f7] = 0x13;
            romData[0x394f8] = 0x11;
            romData[0x394f9] = 0x12;
            romData[0x394fa] = 0x1e;

            //Parry
            romData[0x394fd] = 0x0b;
            romData[0x394fe] = 0x1c;
            romData[0x394ff] = 0x1c;
            romData[0x39500] = 0x23;

            //Item
            romData[0x39503] = 0x1e;
            romData[0x39504] = 0x0f;
            romData[0x39505] = 0x17;

            //Yes
            romData[0x39517] = 0x0f;
            romData[0x39518] = 0x1d;

            //No
            romData[0x3951b] = 0x19;

            //Info > Details
            romData[0x39528] = 0x28;
            romData[0x39529] = 0x0f;
            romData[0x3952a] = 0x1e;
            romData[0x3952b] = 0x0b;
            romData[0x3952c] = 0x13;
            romData[0x3952d] = 0x16;
            romData[0x3952e] = 0x1d;
            romData[0x3952f] = 0xff;

            //Condition > HP-MP
            romData[0x39530] = 0x2c;
            romData[0x39531] = 0x34;
            romData[0x39532] = 0x6b;
            romData[0x39533] = 0x31;
            romData[0x39534] = 0x34;
            romData[0x39535] = 0x00;

            //Formation
            romData[0x39538] = 0x19;
            romData[0x39539] = 0x1c;
            romData[0x3953a] = 0x17;
            romData[0x3953b] = 0x0b;
            romData[0x3953c] = 0x1e;
            romData[0x3953d] = 0x13;
            romData[0x3953e] = 0x19;
            romData[0x3953f] = 0x18;

            //Gold
            romData[0x39566] = 0x19;
            romData[0x39567] = 0x16;
            romData[0x39568] = 0x0e;

            //Item
            romData[0x3956b] = 0x1e;
            romData[0x3956c] = 0x0f;
            romData[0x3956d] = 0x17;

            //Use
            romData[0x3957b] = 0x1d;
            romData[0x3957c] = 0x0f;

            //Equip
            romData[0x3957f] = 0x1b;
            romData[0x39580] = 0x1f;
            romData[0x39581] = 0x13;
            romData[0x39582] = 0x1a;

            //Back End
            romData[0x39794] = 0x0b;
            romData[0x39795] = 0x0d;
            romData[0x39796] = 0x15;
            romData[0x39799] = 0x18;
            romData[0x3979a] = 0x0e;

            //Male
            romData[0x397bd] = 0x0b;
            romData[0x397be] = 0x16;
            romData[0x397bf] = 0x0f;

            //Female
            romData[0x397c2] = 0x0f;
            romData[0x397c3] = 0x17;
            romData[0x397c4] = 0x0b;
            romData[0x397c5] = 0x16;
            romData[0x397c6] = 0x0f;

            //Add Member
            romData[0x39839] = 0x0e;
            romData[0x3983a] = 0x0e;
            romData[0x3983d] = 0x0f;
            romData[0x3983e] = 0x17;
            romData[0x3983f] = 0x0c;
            romData[0x39840] = 0x0f;
            romData[0x39841] = 0x1c;

            //Leave Member
            romData[0x39844] = 0x0f;
            romData[0x39845] = 0x0b;
            romData[0x39846] = 0x20;
            romData[0x39847] = 0x0f;
            romData[0x3984a] = 0x0f;
            romData[0x3984b] = 0x17;
            romData[0x3984c] = 0x0c;
            romData[0x3984d] = 0x0f;
            romData[0x3984e] = 0x1c;

            //See List
            romData[0x39851] = 0x0f;
            romData[0x39852] = 0x0f;
            romData[0x39855] = 0x13;
            romData[0x39856] = 0x1d;
            romData[0x39857] = 0x1e;

            //Use
            romData[0x398d0] = 0x1d;
            romData[0x398d1] = 0x0f;

            //Transfer
            romData[0x398d4] = 0x1c;
            romData[0x398d5] = 0x0b;
            romData[0x398d6] = 0x18;
            romData[0x398d7] = 0x1d;
            romData[0x398d8] = 0x10;
            romData[0x398d9] = 0x0f;
            romData[0x398da] = 0x1c;

            //Discard
            romData[0x398dd] = 0x13;
            romData[0x398de] = 0x1d;
            romData[0x398df] = 0x0d;
            romData[0x398e0] = 0x0b;
            romData[0x398e1] = 0x1c;
            romData[0x398e2] = 0x0e;

            //Appraise
            romData[0x398e5] = 0x1a;
            romData[0x398e6] = 0x1a;
            romData[0x398e7] = 0x1c;
            romData[0x398e8] = 0x0b;
            romData[0x398e9] = 0x13;
            romData[0x398ea] = 0x1d;
            romData[0x398eb] = 0x0f;

            //Adventure Log 1
            romData[0x3993a] = 0x0e;
            romData[0x3993b] = 0x20;
            romData[0x3993c] = 0x0f;
            romData[0x3993d] = 0x18;
            romData[0x3993e] = 0x1e;
            romData[0x3993f] = 0x1f;
            romData[0x39940] = 0x1c;
            romData[0x39941] = 0x0f;
            romData[0x39944] = 0x19;
            romData[0x39945] = 0x11;

            //Adventure Log 2
            romData[0x39955] = 0x0e;
            romData[0x39956] = 0x20;
            romData[0x39957] = 0x0f;
            romData[0x39958] = 0x18;
            romData[0x39959] = 0x1e;
            romData[0x3995a] = 0x1f;
            romData[0x3995b] = 0x1c;
            romData[0x3995c] = 0x0f;
            romData[0x3995f] = 0x19;
            romData[0x39960] = 0x11;

            //Adventure Log 1
            romData[0x39970] = 0x0e;
            romData[0x39971] = 0x20;
            romData[0x39972] = 0x0f;
            romData[0x39973] = 0x18;
            romData[0x39974] = 0x1e;
            romData[0x39975] = 0x1f;
            romData[0x39976] = 0x1c;
            romData[0x39977] = 0x0f;
            romData[0x3997a] = 0x19;
            romData[0x3997b] = 0x11;

            //Adventure Log 2
            romData[0x39980] = 0x0e;
            romData[0x39981] = 0x20;
            romData[0x39982] = 0x0f;
            romData[0x39983] = 0x18;
            romData[0x39984] = 0x1e;
            romData[0x39985] = 0x1f;
            romData[0x39986] = 0x1c;
            romData[0x39987] = 0x0f;
            romData[0x3998a] = 0x19;
            romData[0x3998b] = 0x11;

            //Adventure Log 3
            romData[0x3999b] = 0x0e;
            romData[0x3999c] = 0x20;
            romData[0x3999d] = 0x0f;
            romData[0x3999e] = 0x18;
            romData[0x3999f] = 0x1e;
            romData[0x399a0] = 0x1f;
            romData[0x399a1] = 0x1c;
            romData[0x399a2] = 0x0f;
            romData[0x399a5] = 0x19;
            romData[0x399a6] = 0x11;

            //Adventure Log 1
            romData[0x399b6] = 0x0e;
            romData[0x399b7] = 0x20;
            romData[0x399b8] = 0x0f;
            romData[0x399b9] = 0x18;
            romData[0x399ba] = 0x1e;
            romData[0x399bb] = 0x1f;
            romData[0x399bc] = 0x1c;
            romData[0x399bd] = 0x0f;
            romData[0x399c0] = 0x19;
            romData[0x399c1] = 0x11;

            //Adventure Log 3
            romData[0x399c6] = 0x0e;
            romData[0x399c7] = 0x20;
            romData[0x399c8] = 0x0f;
            romData[0x399c9] = 0x18;
            romData[0x399ca] = 0x1e;
            romData[0x399cb] = 0x1f;
            romData[0x399cc] = 0x1c;
            romData[0x399cd] = 0x0f;
            romData[0x399d0] = 0x19;
            romData[0x399d1] = 0x11;

            //Adventure Log 2
            romData[0x399e1] = 0x0e;
            romData[0x399e2] = 0x20;
            romData[0x399e2] = 0x0f;
            romData[0x399e4] = 0x18;
            romData[0x399e5] = 0x1e;
            romData[0x399e6] = 0x1f;
            romData[0x399e7] = 0x1c;
            romData[0x399e8] = 0x0f;
            romData[0x399eb] = 0x19;
            romData[0x399ec] = 0x11;

            //Adventure Log 3
            romData[0x399f1] = 0x0e;
            romData[0x399f2] = 0x20;
            romData[0x399f2] = 0x0f;
            romData[0x399f4] = 0x18;
            romData[0x399f5] = 0x1e;
            romData[0x399f6] = 0x1f;
            romData[0x399f7] = 0x1c;
            romData[0x399f8] = 0x0f;
            romData[0x399fb] = 0x19;
            romData[0x399fc] = 0x11;

            //Adventure Log 1
            romData[0x39a0c] = 0x0e;
            romData[0x39a0d] = 0x20;
            romData[0x39a0e] = 0x0f;
            romData[0x39a0f] = 0x18;
            romData[0x39a10] = 0x1e;
            romData[0x39a11] = 0x1f;
            romData[0x39a12] = 0x1c;
            romData[0x39a13] = 0x0f;
            romData[0x39a16] = 0x19;
            romData[0x39a17] = 0x11;

            //Adventure Log 2
            romData[0x39a1c] = 0x0e;
            romData[0x39a1d] = 0x20;
            romData[0x39a1e] = 0x0f;
            romData[0x39a1f] = 0x18;
            romData[0x39a20] = 0x1e;
            romData[0x39a21] = 0x1f;
            romData[0x39a22] = 0x1c;
            romData[0x39a23] = 0x0f;
            romData[0x39a26] = 0x19;
            romData[0x39a27] = 0x11;

            //Adventure Log 3
            romData[0x39a2c] = 0x0e;
            romData[0x39a2d] = 0x20;
            romData[0x39a2e] = 0x0f;
            romData[0x39a2f] = 0x18;
            romData[0x39a30] = 0x1e;
            romData[0x39a31] = 0x1f;
            romData[0x39a32] = 0x1c;
            romData[0x39a33] = 0x0f;
            romData[0x39a36] = 0x19;
            romData[0x39a37] = 0x11;

            //Input Your Name
            romData[0x39a9b] = 0x18;
            romData[0x39a9c] = 0x1a;
            romData[0x39a9d] = 0x1f;
            romData[0x39a9e] = 0x1e;
            romData[0x39aa1] = 0x19;
            romData[0x39aa2] = 0x1f;
            romData[0x39aa3] = 0x1c;
            romData[0x39aa6] = 0x0b;
            romData[0x39aa7] = 0x17;
            romData[0x39aa8] = 0x0f;

            //Level
            romData[0x39abc] = 0x0f;
            romData[0x39abd] = 0x20;
            romData[0x39abe] = 0x0f;
            romData[0x39abf] = 0x16;

            //Adventure Log 1
            romData[0x39af4] = 0x0e;
            romData[0x39af5] = 0x20;
            romData[0x39af6] = 0x0f;
            romData[0x39af7] = 0x18;
            romData[0x39af8] = 0x1e;
            romData[0x39af9] = 0x1f;
            romData[0x39afa] = 0x1c;
            romData[0x39afb] = 0x0f;
            romData[0x39afe] = 0x19;
            romData[0x39aff] = 0x11;

            //Adventure Log 2
            romData[0x39b12] = 0x0e;
            romData[0x39b13] = 0x20;
            romData[0x39b14] = 0x0f;
            romData[0x39b15] = 0x18;
            romData[0x39b16] = 0x1e;
            romData[0x39b17] = 0x1f;
            romData[0x39b18] = 0x1c;
            romData[0x39b19] = 0x0f;
            romData[0x39b1c] = 0x19;
            romData[0x39b1d] = 0x11;

            //Adventure Log 1
            romData[0x39b30] = 0x0e;
            romData[0x39b31] = 0x20;
            romData[0x39b32] = 0x0f;
            romData[0x39b33] = 0x18;
            romData[0x39b34] = 0x1e;
            romData[0x39b35] = 0x1f;
            romData[0x39b36] = 0x1c;
            romData[0x39b37] = 0x0f;
            romData[0x39b3a] = 0x19;
            romData[0x39b3b] = 0x11;

            //Adventure Log 2
            romData[0x39b43] = 0x0e;
            romData[0x39b44] = 0x20;
            romData[0x39b45] = 0x0f;
            romData[0x39b46] = 0x18;
            romData[0x39b47] = 0x1e;
            romData[0x39b48] = 0x1f;
            romData[0x39b49] = 0x1c;
            romData[0x39b4a] = 0x0f;
            romData[0x39b4d] = 0x19;
            romData[0x39b4e] = 0x11;

            //Adventure Log 3
            romData[0x39b61] = 0x0e;
            romData[0x39b62] = 0x20;
            romData[0x39b63] = 0x0f;
            romData[0x39b64] = 0x18;
            romData[0x39b65] = 0x1e;
            romData[0x39b66] = 0x1f;
            romData[0x39b67] = 0x1c;
            romData[0x39b68] = 0x0f;
            romData[0x39b6b] = 0x19;
            romData[0x39b6c] = 0x11;

            //Adventure Log 1
            romData[0x39b7f] = 0x0e;
            romData[0x39b80] = 0x20;
            romData[0x39b81] = 0x0f;
            romData[0x39b82] = 0x18;
            romData[0x39b83] = 0x1e;
            romData[0x39b84] = 0x1f;
            romData[0x39b85] = 0x1c;
            romData[0x39b86] = 0x0f;
            romData[0x39b89] = 0x19;
            romData[0x39b8a] = 0x11;

            //Adventure Log 3
            romData[0x39b92] = 0x0e;
            romData[0x39b93] = 0x20;
            romData[0x39b94] = 0x0f;
            romData[0x39b95] = 0x18;
            romData[0x39b96] = 0x1e;
            romData[0x39b97] = 0x1f;
            romData[0x39b98] = 0x1c;
            romData[0x39b99] = 0x0f;
            romData[0x39b9c] = 0x19;
            romData[0x39b9d] = 0x11;

            //Adventure Log 2
            romData[0x39bb0] = 0x0e;
            romData[0x39bb1] = 0x20;
            romData[0x39bb2] = 0x0f;
            romData[0x39bb3] = 0x18;
            romData[0x39bb4] = 0x1e;
            romData[0x39bb5] = 0x1f;
            romData[0x39bb6] = 0x1c;
            romData[0x39bb7] = 0x0f;
            romData[0x39bba] = 0x19;
            romData[0x39bbb] = 0x11;

            //Adventure Log 3
            romData[0x39bc3] = 0x0e;
            romData[0x39bc4] = 0x20;
            romData[0x39bc5] = 0x0f;
            romData[0x39bc6] = 0x18;
            romData[0x39bc7] = 0x1e;
            romData[0x39bc8] = 0x1f;
            romData[0x39bc9] = 0x1c;
            romData[0x39bca] = 0x0f;
            romData[0x39bcd] = 0x19;
            romData[0x39bce] = 0x11;

            //Adventure Log 1
            romData[0x39be1] = 0x0e;
            romData[0x39be2] = 0x20;
            romData[0x39be3] = 0x0f;
            romData[0x39be4] = 0x18;
            romData[0x39be5] = 0x1e;
            romData[0x39be6] = 0x1f;
            romData[0x39be7] = 0x1c;
            romData[0x39be8] = 0x0f;
            romData[0x39beb] = 0x19;
            romData[0x39bec] = 0x11;

            //Adventure Log 2
            romData[0x39bf4] = 0x0e;
            romData[0x39bf5] = 0x20;
            romData[0x39bf6] = 0x0f;
            romData[0x39bf7] = 0x18;
            romData[0x39bf8] = 0x1e;
            romData[0x39bf9] = 0x1f;
            romData[0x39bfa] = 0x1c;
            romData[0x39bfb] = 0x0f;
            romData[0x39bfe] = 0x19;
            romData[0x39bff] = 0x11;

            //Adventure Log 3
            romData[0x39c07] = 0x0e;
            romData[0x39c08] = 0x20;
            romData[0x39c09] = 0x0f;
            romData[0x39c0a] = 0x18;
            romData[0x39c0b] = 0x1e;
            romData[0x39c0c] = 0x1f;
            romData[0x39c0d] = 0x1c;
            romData[0x39c0e] = 0x0f;
            romData[0x39c0f] = 0x19;
            romData[0x39c10] = 0x11;

            //Continue a quest
            romData[0x39c25] = 0x19;
            romData[0x39c26] = 0x18;
            romData[0x39c27] = 0x1e;
            romData[0x39c28] = 0x13;
            romData[0x39c29] = 0x18;
            romData[0x39c2a] = 0x1f;
            romData[0x39c2b] = 0x0f;
            romData[0x39c2d] = 0x0b;
            romData[0x39c30] = 0x1f;
            romData[0x39c31] = 0x0f;
            romData[0x39c32] = 0x1d;
            romData[0x39c33] = 0x1e;

            //Begin a new quest
            romData[0x39c36] = 0x0f;
            romData[0x39c37] = 0x11;
            romData[0x39c38] = 0x13;
            romData[0x39c39] = 0x18;
            romData[0x39c3b] = 0x0b;
            romData[0x39c3e] = 0x0f;
            romData[0x39c3f] = 0x21;
            romData[0x39c42] = 0x1f;
            romData[0x39c43] = 0x0f;
            romData[0x39c44] = 0x1d;
            romData[0x39c45] = 0x1e;

            //Copy a quest
            romData[0x39c48] = 0x19;
            romData[0x39c49] = 0x1a;
            romData[0x39c4a] = 0x23;
            romData[0x39c4c] = 0x0b;
            romData[0x39c4f] = 0x1f;
            romData[0x39c50] = 0x0f;
            romData[0x39c51] = 0x1d;
            romData[0x39c52] = 0x1e;

            //Erase a quest
            romData[0x39c55] = 0x1c;
            romData[0x39c56] = 0x0b;
            romData[0x39c57] = 0x1d;
            romData[0x39c58] = 0x0f;
            romData[0x39c5a] = 0x0b;
            romData[0x39c5d] = 0x1f;
            romData[0x39c5e] = 0x0f;
            romData[0x39c5f] = 0x1d;
            romData[0x39c60] = 0x1e;

            //Change Message Speed
            romData[0x39c63] = 0x12;
            romData[0x39c64] = 0x0b;
            romData[0x39c65] = 0x18;
            romData[0x39c66] = 0x11;
            romData[0x39c67] = 0x0f;
            romData[0x39c6a] = 0x0f;
            romData[0x39c6b] = 0x1d;
            romData[0x39c6c] = 0x1d;
            romData[0x39c6d] = 0x0b;
            romData[0x39c6e] = 0x11;
            romData[0x39c6f] = 0x0f;
            romData[0x39c72] = 0x1a;
            romData[0x39c73] = 0x0f;
            romData[0x39c74] = 0x0f;
            romData[0x39c75] = 0x0e;

            //Continue a Quest
            romData[0x39c83] = 0x19;
            romData[0x39c84] = 0x18;
            romData[0x39c85] = 0x1e;
            romData[0x39c86] = 0x13;
            romData[0x39c87] = 0x18;
            romData[0x39c88] = 0x1f;
            romData[0x39c89] = 0x0f;
            romData[0x39c8b] = 0x0b;
            romData[0x39c8e] = 0x1f;
            romData[0x39c8f] = 0x0f;
            romData[0x39c90] = 0x1d;
            romData[0x39c91] = 0x1e;

            //Erase a Quest
            romData[0x39c94] = 0x1c;
            romData[0x39c95] = 0x0b;
            romData[0x39c96] = 0x1d;
            romData[0x39c97] = 0x0f;
            romData[0x39c99] = 0x0b;
            romData[0x39c9c] = 0x1f;
            romData[0x39c9d] = 0x0f;
            romData[0x39c9e] = 0x1d;
            romData[0x39c9f] = 0x1e;

            //Change Message Speed
            romData[0x39ca2] = 0x12;
            romData[0x39ca3] = 0x0b;
            romData[0x39ca4] = 0x18;
            romData[0x39ca5] = 0x11;
            romData[0x39ca6] = 0x0f;
            romData[0x39ca9] = 0x0f;
            romData[0x39caa] = 0x1d;
            romData[0x39cab] = 0x1d;
            romData[0x39cac] = 0x0b;
            romData[0x39cad] = 0x11;
            romData[0x39cae] = 0x0f;
            romData[0x39cb1] = 0x1a;
            romData[0x39cb2] = 0x0f;
            romData[0x39cb3] = 0x0f;
            romData[0x39cb4] = 0x0e;

            //Begin a New Quest
            romData[0x39cc2] = 0x0f;
            romData[0x39cc3] = 0x11;
            romData[0x39cc4] = 0x13;
            romData[0x39cc5] = 0x18;
            romData[0x39cc7] = 0x0b;
            romData[0x39cca] = 0x0f;
            romData[0x39ccb] = 0x21;
            romData[0x39cce] = 0x1f;
            romData[0x39ccf] = 0x0f;
            romData[0x39cd0] = 0x1d;
            romData[0x39cd1] = 0x1e;

            //Command
            romData[0x39d3c] = 0x19;
            romData[0x39d3d] = 0x17;
            romData[0x39d3e] = 0x17;
            romData[0x39d3f] = 0x0b;
            romData[0x39d40] = 0x18;
            romData[0x39d41] = 0x0e;

            //Status
            romData[0x39d44] = 0x1e;
            romData[0x39d45] = 0x0b;
            romData[0x39d46] = 0x1e;
            romData[0x39d47] = 0x1f;
            romData[0x39d48] = 0x1d;

            //Item
            romData[0x39d4b] = 0x1e;
            romData[0x39d4c] = 0x0f;
            romData[0x39d4d] = 0x17;

            //Whom
            romData[0x39d50] = 0x12;
            romData[0x39d51] = 0x19;
            romData[0x39d52] = 0x17;

            //Spell
            romData[0x39d55] = 0x1a;
            romData[0x39d56] = 0x0f;
            romData[0x39d57] = 0x16;
            romData[0x39d58] = 0x16;

            //Equip
            romData[0x39d5b] = 0x1b;
            romData[0x39d5c] = 0x1f;
            romData[0x39d5d] = 0x13;
            romData[0x39d5e] = 0x1a;

            //Weapon
            romData[0x39d61] = 0x0f;
            romData[0x39d62] = 0x0b;
            romData[0x39d63] = 0x1a;
            romData[0x39d64] = 0x19;
            romData[0x39d65] = 0x18;

            //Armor
            romData[0x39d68] = 0x1c;
            romData[0x39d69] = 0x17;
            romData[0x39d6a] = 0x19;
            romData[0x39d6b] = 0x1c;

            //Shield
            romData[0x39d6e] = 0x12;
            romData[0x39d6f] = 0x13;
            romData[0x39d70] = 0x0f;
            romData[0x39d71] = 0x16;
            romData[0x39d72] = 0x0e;

            //Helmet
            romData[0x39d75] = 0x0f;
            romData[0x39d76] = 0x16;
            romData[0x39d77] = 0x17;
            romData[0x39d78] = 0x0f;
            romData[0x39d79] = 0x1e;

            //Class
            romData[0x39d7c] = 0x16;
            romData[0x39d7d] = 0x0b;
            romData[0x39d7e] = 0x1d;
            romData[0x39d7f] = 0x1d;

            //Sex
            romData[0x39d82] = 0x0f;
            romData[0x39d83] = 0x22;

            //Name
            romData[0x39d86] = 0x0b;
            romData[0x39d87] = 0x17;
            romData[0x39d88] = 0x0f;

            //Fight
            romData[0x39d8e] = 0x13;
            romData[0x39d8f] = 0x11;
            romData[0x39d90] = 0x12;
            romData[0x39d91] = 0x1e;

            //To
            romData[0x39d94] = 0x19;

            //and
            romData[0x3a541] = 0x0b;
            romData[0x3a542] = 0x18;
            romData[0x3a543] = 0x0e;

            //Spell
            romData[0x3a553] = 0x1a;
            romData[0x3a554] = 0x0f;
            romData[0x3a555] = 0x16;
            romData[0x3a556] = 0x16;

            //Item
            romData[0x3a562] = 0x1e;
            romData[0x3a563] = 0x0f;
            romData[0x3a564] = 0x17;

            //Equip
            romData[0x3a572] = 0x1b;
            romData[0x3a573] = 0x1f;
            romData[0x3a574] = 0x13;
            romData[0x3a575] = 0x1a;

            //NDITION > -MP
            romData[0x3a5d2] = 0x6b;
            romData[0x3a5d3] = 0x31;
            romData[0x3a5d4] = 0x34;
            romData[0x3a5d5] = 0x3f;
            romData[0x3a5d6] = 0x3f;
            romData[0x3a5d7] = 0x3f;
            romData[0x3a5d8] = 0x3f;

            //rmation
            romData[0x3a5dd] = 0x1c;
            romData[0x3a5de] = 0x17;
            romData[0x3a5df] = 0x0b;
            romData[0x3a5e0] = 0x1e;
            romData[0x3a5e1] = 0x13;
            romData[0x3a5e2] = 0x19;
            romData[0x3a5e3] = 0x18;

        }

        private void randSpriteColors(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            int selection = 0;
            byte heroSkin = 0x36;
            byte heroWhite = 0x30;
            byte heroBlue = 0x11;
            byte soldierSkin = 0x36;
            byte soldierRed = 0x15;
            byte soldierPurple = 0x03;
            byte wizardSkin = 0x36;
            byte wizardWhite = 0x30;
            byte wizardGreen = 0x1b;
            byte fighterSkin = 0x36;
            byte fighterGreen = 0x1a;
            byte fighterBrown = 0x06;

            selection = r1.Next() % 3;
            switch(selection)
            {
                case 0:
                    heroSkin = 0x36;
                    break;
                case 1:
                    heroSkin = 0x37;
                    break;
                case 2:
                    heroSkin = 0x17;
                    break;
            }
            selection = r1.Next() % 6;
            switch(selection)
            {
                case 0:
                    heroWhite = 0x30;
                    break;
                case 1:
                    heroWhite = 0x31;
                    break;
                case 2:
                    heroWhite = 0x3a;
                    break;
                case 3:
                    heroWhite = 0x3b;
                    break;
                case 4:
                    heroWhite = 0x32;
                    break;
                case 5:
                    heroWhite = 0x33;
                    break;
            }

            selection = r1.Next() % 7;
            switch(selection)
            {
                case 0:
                    heroBlue = 0x11;
                    break;
                case 1:
                    heroBlue = 0x02;
                    break;
                case 2:
                    heroBlue = 0x04;
                    break;
                case 3:
                    heroBlue = 0x07;
                    break;
                case 4:
                    heroBlue = 0x09;
                    break;
                case 5:
                    heroBlue = 0x0b;
                    break;
                case 6:
                    heroBlue = 0x0c;
                    break;
            }
            selection = r1.Next() % 3;
            switch (selection)
            {
                case 0:
                    soldierSkin = 0x36;
                    break;
                case 1:
                    soldierSkin = 0x37;
                    break;
                case 2:
                    soldierSkin = 0x17;
                    break;
            }
            selection = r1.Next() % 6;
            switch(selection)
            {
                case 0:
                    soldierRed = 0x15;
                    break;
                case 1:
                    soldierRed = 0x07;
                    break;
                case 2:
                    soldierRed = 0x02;
                    break;
                case 3:
                    soldierRed = 0x09;
                    break;
                case 4:
                    soldierRed = 0x04;
                    break;
                case 5:
                    soldierRed = 0x0c;
                    break;
            }

            selection = r1.Next() % 7;
            switch(selection)
            {
                case 0:
                    soldierPurple = 0x03;
                    break;
                case 1:
                    soldierPurple = 0x08;
                    break;
                case 2:
                    soldierPurple = 0x11;
                    break;
                case 3:
                    soldierPurple = 0x1c;
                    break;
                case 4:
                    soldierPurple = 0x24;
                    break;
                case 5:
                    soldierPurple = 0x10;
                    break;
                case 6:
                    soldierPurple = 0x39;
                    break;
            }
            selection = r1.Next() % 3;
            switch (selection)
            {
                case 0:
                    wizardSkin = 0x36;
                    break;
                case 1:
                    wizardSkin = 0x37;
                    break;
                case 2:
                    wizardSkin = 0x17;
                    break;
            }
            selection = r1.Next() % 6;
            switch(selection)
            {
                case 0:
                    wizardWhite = 0x30;
                    break;
                case 1:
                    wizardWhite = 0x3b;
                    break;
                case 2:
                    wizardWhite = 0x10;
                    break;
                case 3:
                    wizardWhite = 0x07;
                    break;
                case 4:
                    wizardWhite = 0x3a;
                    break;
                case 5:
                    wizardWhite = 0x3c;
                    break;
            }

            selection = r1.Next() % 7;
            switch(selection)
            {
                case 0:
                    wizardGreen = 0x1b;
                    break;
                case 1:
                    wizardGreen = 0x11;
                    break;
                case 2:
                    wizardGreen = 0x15;
                    break;
                case 3:
                    wizardGreen = 0x06;
                    break;
                case 4:
                    wizardGreen = 0x0c;
                    break;
                case 5:
                    wizardGreen = 0x04;
                    break;
                case 6:
                    wizardGreen = 0x2d;
                    break;
            }
            selection = r1.Next() % 3;
            switch (selection)
            {
                case 0:
                    fighterSkin = 0x36;
                    break;
                case 1:
                    fighterSkin = 0x37;
                    break;
                case 2:
                    fighterSkin = 0x17;
                    break;
            }
            selection = r1.Next() % 7;
            switch(selection)
            {
                case 0:
                    fighterGreen = 0x1a;
                    break;
                case 1:
                    fighterGreen = 0x0c;
                    break;
                case 2:
                    fighterGreen = 0x11;
                    break;
                case 3:
                    fighterGreen = 0x0c;
                    break;
                case 4:
                    fighterGreen = 0x06;
                    break;
                case 5:
                    fighterGreen = 0x0b;
                    break;
                case 6:
                    fighterGreen = 0x03;
                    break;
            }

            selection = r1.Next() % 6;
            switch(selection)
            {
                case 0:
                    fighterBrown = 0x06;
                    break;
                case 1:
                    fighterBrown = 0x00;
                    break;
                case 2:
                    fighterBrown = 0x1c;
                    break;
                case 3:
                    fighterBrown = 0x39;
                    break;
                case 4:
                    fighterBrown = 0x21;
                    break;
                case 5:
                    fighterBrown = 0x26;
                    break;
            }

            romData[0x3ba44] = heroSkin;
            romData[0x3ba45] = heroWhite;
            romData[0x3ba46] = heroBlue;
            romData[0x3ba47] = soldierSkin;
            romData[0x3ba48] = soldierRed;
            romData[0x3ba49] = soldierPurple;
            romData[0x3ba4a] = wizardSkin;
            romData[0x3ba4b] = wizardWhite;
            romData[0x3ba4c] = wizardGreen;
            romData[0x3ba4d] = fighterSkin;
            romData[0x3ba4e] = fighterGreen;
            romData[0x3ba4f] = fighterBrown;
        }

        private void createGuides()
        {
            //            if (chkRandEquip.Checked || chkRandItemEffects.Checked || chkRandWhoCanEquip.Checked)
            //            {
                string shortVersion2 = versionNumber.Replace(".", "");
                string finalFile = Path.Combine(Path.GetDirectoryName(txtFileName.Text), "DW3R_" + txtSeed.Text + "_" + txtFlags.Text + "_" + shortVersion2 + "_guide.txt");

                // Totally randomize who can equip (1a3ce-1a3f0).  At least one person can equip something...
                using (StreamWriter writer = File.CreateText(finalFile))
                {
                    string[] weaponText = { "Cypress stick", "Club", "Copper sword", "Magic Knife", "Iron Spear", "Battle Axe", "Broad Sword", "Wizard's Wand",
                        "Poison Needle", "Iron Claw", "Thorn Whip", "Giant Shears", "Chain Sickle", "Thor's Sword", "Snowblast Sword", "Demon Axe",
                        "Staff of Rain", "Sword of Gaia", "Staff of Reflection", "Sword of Destruction", "Multi - Edge Sword", "Staff of Force", "Sword of Illusion", "Zombie Slasher",
                        "Falcon Sword", "Sledge Hammer", "Thunder Sword", "Staff of Thunder", "Sword of Kings", "Orochi Sword", "Dragon Killer", "Staff of Judgement",
                        "Clothes", "Training Suit", "Leather Armor", "Flashy Clothes", "Half Plate Armor", "Full Plate Armor", "Magic Armor", "Cloak of Evasion",
                        "Armor of Radiance", "Iron Apron", "Animal Suit", "Fighting Suit", "Sacred Robe", "Armor of Hades", "Water Flying Cloth", "Chain Mail",
                        "Wayfarers Clothes", "Revealing Swimsuit", "Magic Bikini", "Shell Armor", "Armor of Terrafirma", "Dragon Mail", "Swordedge Armor", "Angel's Robe",
                        "Leather Shield", "Iron Shield", "Shield of Strength", "Shield of Heroes", "Shield of Sorrow", "Bronze Shield", "Silver Shield", "Golden Crown",
                        "Iron Helmet", "Mysterious Hat", "Unlucky Helmet", "Turban", "Noh Mask", "Leather Helmet", "Iron Mask", "Golden Claw" };

                    for (int lnI = 0; lnI <= 70; lnI++)
                    {
                        if (lnI < 71)
                        {
                            string equipOut = "";
                            equipOut += (romData[0x1147 + lnI] % 2 >= 1 ? "Hr  " : "--  ");
                            equipOut += (romData[0x1147 + lnI] % 32 >= 16 ? "Sr  " : "--  ");
                            equipOut += (romData[0x1147 + lnI] % 8 >= 4 ? "Pr  " : "--  ");
                            equipOut += (romData[0x1147 + lnI] % 4 >= 2 ? "Wi  " : "--  ");
                            equipOut += (romData[0x1147 + lnI] % 16 >= 8 ? "Sg  " : "--  ");
                            equipOut += (romData[0x1147 + lnI] % 128 >= 64 ? "Fi  " : "--  ");
                            equipOut += (romData[0x1147 + lnI] % 64 >= 32 ? "Mr  " : "--  ");
                            equipOut += (romData[0x1147 + lnI] >= 128 ? "Gf  " : "--  ");
                            equipOut += (romData[0x11be + lnI] >= 128 ? "**  " : "    ");
                            equipOut += (romData[0x279a0 + lnI]);
                            writer.WriteLine(weaponText[lnI].PadRight(24) + equipOut);
                        }
                        else
                        {
                            string equipOut = "";
                            equipOut += (romData[0x1147 + lnI + 3] % 2 >= 1 ? "Hr  " : "--  ");
                            equipOut += (romData[0x1147 + lnI + 3] % 32 >= 16 ? "Sr  " : "--  ");
                            equipOut += (romData[0x1147 + lnI + 3] % 8 >= 4 ? "Pr  " : "--  ");
                            equipOut += (romData[0x1147 + lnI + 3] % 4 >= 2 ? "Wi  " : "--  ");
                            equipOut += (romData[0x1147 + lnI + 3] % 16 >= 8 ? "Sg  " : "--  ");
                            equipOut += (romData[0x1147 + lnI + 3] % 128 >= 64 ? "Fi  " : "--  ");
                            equipOut += (romData[0x1147 + lnI + 3] % 64 >= 32 ? "Mr  " : "--  ");
                            equipOut += (romData[0x1147 + lnI + 3] >= 128 ? "Gf  " : "--  ");
                            equipOut += (romData[0x11be + lnI + 3] >= 128 ? "**  " : "    ");
                            equipOut += (romData[0x279a0 + lnI + 3]);
                            writer.WriteLine(weaponText[lnI].PadRight(24) + equipOut);

                        }

                    }

                    /*
                                        for (int lnI = 0; lnI < 22; lnI++)
                                        {
                                            romData[0xb29e + lnI] = romData[0xb29e + lnI + 1];
                                        }
                                        // Gold Claw
                                        romData[0xb2b4] = 0x27;
                                        romData[0xb2b5] = 0x16;
                                        romData[0xb2b6] = 0x0b;
                                        romData[0xb2b7] = 0x22;
                                        romData[0xb2b8] = 0x00;
                    */
//                }

                // Change Equipment Names to Attack
                // Copper Sword ad1e-ad23 / b0b7-b0bb
                // Breakup ATP
            }
            if (chk_GenCompareFile.Checked == true)
            {
                string shortVersion = versionNumber.Replace(".", "");
                if (!loadRom(true)) return;
                using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "DW3Compare_" + txtSeed.Text + "_" + txtFlags.Text + "_" + shortVersion + ".txt")))
                {
                    for (int lnI = 0; lnI < 0x8a; lnI++)
                        compareComposeString("monsters" + lnI.ToString("X2"), writer, (0x32e3 + (23 * lnI)), 23);

                    compareComposeString("itemPrice1", writer, 0x11be, 128);
                    compareComposeString("itemPrice2", writer, 0x123b, 128);
                    compareComposeString("weaponEffects", writer, 0x13280, 40);

                    compareComposeString("treasures-Promontory", writer, 0x29237, 3);
                    compareComposeString("treasures-NajimiBasement", writer, 0x2927B, 3);
                    compareComposeString("treasures-Najimi", writer, 0x292C4, 3);
                    compareComposeString("treasures-Thief'sKey", writer, 0x37DF1, 1);
                    compareComposeString("treasures-MagicBall", writer, 0x375AA, 1);
                    compareComposeString("treasures-Invitation", writer, 0x2927E, 2);
                    compareComposeString("treasures-Kanave", writer, 0x29234, 2);
                    compareComposeString("treasures-Champange1", writer, 0x29252, 1);
                    compareComposeString("treasures-Champange2", writer, 0x292D2, 1);
                    compareComposeString("treasures-Champange3", writer, 0x292E6, 1);
                    compareComposeString("treasures-Isis", writer, 0x2925C, 9);
                    compareComposeString("treasures-IsisWizards", writer, 0x31B9C, 1);
                    compareComposeString("treasures-GoldenClaw", writer, 0x317F4, 1);
                    compareComposeString("treasures-Pyramid1st", writer, 0x29249, 7);
                    compareComposeString("treasures-Pyramid3rd4th5th", writer, 0x292B4, 15);
                    compareComposeString("treasures-DreamCave1", writer, 0x2923A, 2);
                    compareComposeString("treasures-DreamCave2", writer, 0x29280, 8);
                    compareComposeString("treasures-WakeUpNPC", writer, 0x37786, 1);
                    compareComposeString("treasures-Aliahan", writer, 0x29255, 6);
                    compareComposeString("treasures-Portuga", writer, 0x29269, 3);
                    compareComposeString("treasures-RoyalScroll", writer, 0x37CB9, 1);
                    compareComposeString("treasures-Dwarf", writer, 0x2923C, 2);
                    compareComposeString("treasures-Kidnappers1", writer, 0x2923E, 6);
                    compareComposeString("treasures-Kidnappers2", writer, 0x2928B, 4);
                    compareComposeString("treasures-BlackPepperNPC", writer, 0x377D5, 1);
                    compareComposeString("treasures-Tedan1", writer, 0x31B94, 1);
                    compareComposeString("treasures-Tedan2", writer, 0x29270, 1);
                    compareComposeString("treasures-TedanGreenOrb", writer, 0x37828, 1);
                    compareComposeString("treasures-Garuna1", writer, 0x29251, 1);
                    compareComposeString("treasures-Garuna2", writer, 0x292C7, 4);
                    compareComposeString("treasures-NohMask", writer, 0x292E4, 1);
                    compareComposeString("treasures-PurpleOrb", writer, 0x292E7, 1);
                    compareComposeString("treasures-WaterBlaster", writer, 0x377FE, 1);
                    compareComposeString("treasures-PirateCove", writer, 0x29271, 3);
                    compareComposeString("treasures-Eginbear", writer, 0x2925B, 1);
                    compareComposeString("treasures-FinalKey", writer, 0x2922B, 1);
                    compareComposeString("treasures-ArpTower", writer, 0x292CB, 7);
                    compareComposeString("treasures-Soo", writer, 0x31B8C, 1);
                    compareComposeString("treasures-SamanaoCave", writer, 0x29291, 23);
                    compareComposeString("treasures-SamanaoCastle", writer, 0x292E5, 1);
                    compareComposeString("treasures-LancelCave1", writer, 0x29244, 5);
                    compareComposeString("treasures-LancelCave2", writer, 0x2928F, 2);
                    compareComposeString("treasures-Luzami", writer, 0x31B97, 1);
                    compareComposeString("treasures-NewTown1", writer, 0x2926C, 2);
                    compareComposeString("treasures-NewTownYellowOrb", writer, 0x31B80, 1);
                    compareComposeString("treasures-Sailor'sThighNPC", writer, 0x378A9, 1);
                    compareComposeString("treasures-GhostShip", writer, 0x29275, 6);
                    compareComposeString("treasures-SwordOfGaia", writer, 0x31B84, 1);
                    compareComposeString("treasures-Negrogund", writer, 0x29288, 3);
                    compareComposeString("treasures-SilverOrb", writer, 0x37907, 1);
                    compareComposeString("treasures-LeafOfWorld", writer, 0x31B9F, 1);
                    compareComposeString("treasures-SphereOfLight", writer, 0x37929, 1);
                    compareComposeString("treasures-Baramos", writer, 0x29228, 3);
                    compareComposeString("treasures-SwordOfIllusion", writer, 0x37a25, 1);
                    compareComposeString("treasures-Tantegel", writer, 0x29265, 4);
                    compareComposeString("treasures-Erdrick's", writer, 0x292A8, 5);
                    compareComposeString("treasures-SilverHarp", writer, 0x29274, 1);
                    compareComposeString("treasures-MountainCave", writer, 0x292DF, 5);
                    compareComposeString("treasures-Oricon", writer, 0x31B90, 1);
                    compareComposeString("treasures-FairyFlute", writer, 0x31B88, 1);
                    compareComposeString("treasures-KolTower1", writer, 0x29253, 2);
                    compareComposeString("treasures-KolTower2", writer, 0x292D5, 10);
                    compareComposeString("treasures-SacredAmulet", writer, 0x37D5A, 1);
                    compareComposeString("treasures-StaffOfRain", writer, 0x37D9D, 1);
                    compareComposeString("treasures-RainbowDrop", writer, 0x37D80, 1);
                    compareComposeString("treasures-Rimuldar", writer, 0x29233, 1);
                    compareComposeString("treasures-ZomaCastle", writer, 0x292AD, 7);

                    compareComposeString("stores", writer, 0x36838, 248, 1, "g128");

                    for (int lnI = 0; lnI < 95; lnI++)
                        compareComposeString("monsterZones" + lnI.ToString("X2"), writer, (0xaeb + (15 * lnI)), 15);
                    for (int lnI = 0; lnI < 20; lnI++)
                        compareComposeString("monsterSpecial" + lnI.ToString("X2"), writer, (0x107a + (6 * lnI)), 6);
                    //for (int lnI = 0; lnI < 13; lnI++)
                    //    compareComposeString("monsterBoss" + lnI.ToString("X2"), writer, (0x10356 + (4 * lnI)), 4);
                    //compareComposeString("statStart", writer, 0x13dd1, 12);
                    compareComposeString("statMult", writer, 0x281b, 10);
                    compareComposeString("statUpsStrength", writer, 0x290e + 0, 40);
                    compareComposeString("statUpsAgility", writer, 0x290e + 40, 40);
                    compareComposeString("statUpsVitality", writer, 0x290e + 80, 40);
                    compareComposeString("statUpsLuck", writer, 0x290e + 120, 40);
                    compareComposeString("statUpsIntelligence", writer, 0x290e + 160, 40);

                    compareComposeString("spellLearningHero", writer, 0x29d6, 63);
                    compareComposeString("spellsLearnedHero", writer, 0x22E7, 32);
                    compareComposeString("spellLearningPilgrim", writer, 0x2A15, 63);
                    compareComposeString("spellsLearnedPilgrim", writer, 0x2307, 32);
                    compareComposeString("spellLearningWizard", writer, 0x2A54, 63);
                    compareComposeString("spellsLearnedWizard", writer, 0x2327, 32);
                    compareComposeString("spellLearningSage", writer, 0x2A93, 63);
                    //for (int lnI = 0; lnI < 28; lnI++)
                    //    compareComposeString("spellStats" + (lnI).ToString(), writer, 0x127d5 + (5 * lnI), 5);
                    //compareComposeString("spellCmd", writer, 0x13528, 28);
                    //compareComposeString("spellFieldHeal", writer, 0x18be0, 16, 8);
                    //compareComposeString("spellFieldMedical", writer, 0x19602, 1);

                    //compareComposeString("start1", writer, 0x3c79f, 8);
                    //compareComposeString("start2", writer, 0x3c79f + 8, 8);
                    //compareComposeString("start3", writer, 0x3c79f + 16, 8);
                    //compareComposeString("weapons", writer, 0x13efb, 16);
                    //compareComposeString("weaponcost (2.3)", writer, 0x1a00e, 32);
                    //compareComposeString("armor", writer, 0x13efb + 16, 11);
                    //compareComposeString("armorcost (2.4)", writer, 0x1a00e + 32, 22);
                    //compareComposeString("shields", writer, 0x13efb + 27, 5);
                    //compareComposeString("shieldcost (2.8)", writer, 0x1a00e + 54, 10);
                    //compareComposeString("helmets", writer, 0x13efb + 32, 3);
                    //compareComposeString("helmetcost (3.0)", writer, 0x1a00e + 64, 6);

                }
                lblIntensityDesc.Text = "Comparison complete!  (DW3Compare.txt)";
            }

        }

        private void forceItemSell(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            int[] forcedItemSell = { 0x16, 0x1c, 0x28, 0x32, 0x34, 0x36, 0x3b, 0x3f, 0x42, 0x48, 0x4b, 0x4c, 0x50, 0x51, 0x52, 0x53, 0x55, 0x58, 0x59, 0x5b, 0x5c, 0x5d, 0x5e, 0x69, 0x6b, 0x6e, 0x6f, 0x70, 0x71 };
            for (int lnI = 0; lnI < forcedItemSell.Length; lnI++)
                if (romData[0x11be + forcedItemSell[lnI]] % 32 >= 16) // Not allowed to be sold
                    romData[0x11be + forcedItemSell[lnI]] -= 16; // Now allowed to be sold!

            int[] itemstoAdjust = { 0x16, 0x1c, 0x28, 0x32, 0x34, 0x36, 0x3b, 0x3f, 0x42, 0x48, 0x4b, 0x4c, 0x50, 0x52, 0x53, 0x58, 0x59, 0x5a, 0x69, 0x6f, 0x70, 0x71, // forced items to sell AND...
               0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x57, 0x75, 0x55, 0x4e, 0x4f, 0x49, 0x5b, 0x5c, 0x5d, 0x6b, 0x6e, 0x51 }; // Some other items I want sold (see above)

            int[] itemPriceAdjust = { 5000, 35000, 15000, 10000, 8000, 12000, 10000, 800, 10, 5000, 5000, 8000, 20000, 1000, 1000, 500, 2000, 5000, 5000, 500, 2000, 500,
                5000, 3000, 2000, 2500, 2500, 5000, 800, 10000, 3000, 2000, 10000, 5000, 1000, 500, 500, 500, 500, 500 };

            int price = 0;

            for (int lnI = 0; lnI < itemstoAdjust.Length; lnI++)
            {
                // Remove any price adjustment first.
                romData[0x11be + itemstoAdjust[lnI]] -= (byte)(romData[0x11be + itemstoAdjust[lnI]] % 4);
                if (itemstoAdjust[lnI] == 0x5b)
                {
                    price = 1000 * ((r1.Next() % 10) + 1);
                }
                else
                {
                    price = itemPriceAdjust[lnI];
                }
                //                int priceToUse = (romData[0x123b + itemstoAdjust[lnI]] >= 128 ? romData[0x123b + itemstoAdjust[lnI]] - 128 : romData[0x123b + itemstoAdjust[lnI]]);
                if (price >= 10000)
                {
                    romData[0x11be + itemstoAdjust[lnI]] += 3; // Now multiply by 1000
                    romData[0x123b + itemstoAdjust[lnI]] = (byte)(romData[0x123b + itemstoAdjust[lnI]] >= 128 ? (price / 1000) + 128 : price / 1000);
                }
                else if (price >= 1000)
                {
                    romData[0x11be + itemstoAdjust[lnI]] += 2; // Now multiply by 100
                    romData[0x123b + itemstoAdjust[lnI]] = (byte)(romData[0x123b + itemstoAdjust[lnI]] >= 128 ? (price / 100) + 128 : price / 100);
                }
                else if (price >= 100)
                {
                    romData[0x11be + itemstoAdjust[lnI]] += 1; // Now multiply by 10
                    romData[0x123b + itemstoAdjust[lnI]] = (byte)(romData[0x123b + itemstoAdjust[lnI]] >= 128 ? (price / 10) + 128 : price / 10);
                }
                else
                {
                    romData[0x123b + itemstoAdjust[lnI]] = (byte)(romData[0x123b + itemstoAdjust[lnI]] >= 128 ? price + 128 : price);
                }
            }
            // Change Dream Ruby Text to give hint to sell
            byte[] dreamRubyText = { 0x37, 0x0F, 0x16, 0x16, 0x13, 0x18, 0x11, 0x60, 0x1E, 0x12, 0x13, 0x1D, 0x60, 0x1C, 0x1F, 0x0C, 0x23,
                                     0x60, 0x21, 0x13, 0x16, 0x16, 0x60, 0x0C, 0x1C, 0x13, 0x18, 0x11, 0x60, 0x1D, 0x19, 0x17, 0x0F, 0x19,
                                     0x18, 0x0F, 0x60, 0x10, 0x19, 0x1C, 0x1E, 0x1F, 0x18, 0x0F };

            for (int lni = 0; lni < dreamRubyText.Length; lni++)
                romData[0x42bc7 + lni] = dreamRubyText[lni];
        }
         
        private void changeHeroAge(int rni)
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            for (int lnI = 0; lnI < rni; lnI++)
            {
                r1.Next();
            }

            byte[] boyHeroSprite = { 0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x07, 0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x03,
                                     0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xc0,
                                     0x03, 0x02, 0x01, 0x0f, 0x07, 0x07, 0x07, 0x00, 0x00, 0x07, 0x0f, 0x06, 0x07, 0x07, 0x07, 0x0f,
                                     0xc0, 0x40, 0x98, 0xf8, 0xe0, 0xe0, 0x00, 0x00, 0x00, 0xf0, 0xe0, 0x60, 0xe0, 0xe0, 0x70, 0x00,
                                     0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x07, 0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x03,
                                     0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xc0,
                                     0x03, 0x02, 0x19, 0x1f, 0x07, 0x07, 0x00, 0x00, 0x00, 0x0f, 0x07, 0x06, 0x07, 0x07, 0x0e, 0x00,
                                     0xc0, 0x40, 0x80, 0xf0, 0xe0, 0xe0, 0xe0, 0x00, 0x00, 0xe0, 0xf0, 0x60, 0xe0, 0xe0, 0xe0, 0xf0,
                                     0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x07, 0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x02, 0x02,
                                     0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0x40, 0x40,
                                     0x03, 0x02, 0x02, 0x07, 0x0f, 0x07, 0x07, 0x00, 0x00, 0x07, 0x0f, 0x0d, 0x07, 0x07, 0x07, 0x0f,
                                     0xc0, 0x40, 0x58, 0xf8, 0xe0, 0xe0, 0x00, 0x00, 0x00, 0xf0, 0xe0, 0xa0, 0xe0, 0xe0, 0x70, 0x00,
                                     0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x07, 0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x02, 0x02,
                                     0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0x40, 0x40,
                                     0x03, 0x02, 0x1a, 0x1f, 0x07, 0x07, 0x00, 0x00, 0x00, 0x0f, 0x07, 0x05, 0x07, 0x07, 0x0e, 0x00,
                                     0xc0, 0x40, 0x40, 0xe0, 0xf0, 0xe0, 0xe0, 0x00, 0x00, 0xe0, 0xf0, 0xb0, 0xe0, 0xe0, 0xe0, 0xf0,
                                     0x00, 0x00, 0x07, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f, 0x00, 0x00, 0x07, 0x0f, 0x0f, 0x0f, 0x0e, 0x08,
                                     0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0x40, 0x40,
                                     0x07, 0x03, 0x04, 0x0e, 0x0f, 0x0f, 0x07, 0x00, 0x04, 0x07, 0x0f, 0x07, 0x0f, 0x0f, 0x0f, 0x07,
                                     0xc0, 0x80, 0x40, 0xe0, 0xe0, 0xc0, 0x00, 0x00, 0x00, 0xc0, 0xe0, 0x00, 0x20, 0xe0, 0x40, 0x00,
                                     0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x07, 0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x02, 0x02,
                                     0x00, 0x00, 0xe0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0x00, 0x00, 0xe0, 0xf0, 0xf0, 0xf0, 0x70, 0x10,
                                     0x03, 0x01, 0x02, 0x07, 0x07, 0x03, 0x00, 0x00, 0x00, 0x03, 0x07, 0x00, 0x04, 0x07, 0x02, 0x00,
                                     0xe0, 0xc0, 0x20, 0x70, 0xf0, 0xf0, 0xe0, 0x00, 0x20, 0xe0, 0xf0, 0xe0, 0xf0, 0xf0, 0xf0, 0xe0,
                                     0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0x00, 0x00, 0xc0, 0xe0, 0xe0, 0xe0, 0x40, 0x40,
                                     0x07, 0x03, 0x04, 0x0c, 0x0f, 0x07, 0x01, 0x00, 0x04, 0x07, 0x0f, 0x07, 0x0c, 0x0c, 0x05, 0x01,
                                     0xc0, 0x80, 0x40, 0x20, 0xe0, 0xc0, 0xc0, 0x00, 0x00, 0xc0, 0xe0, 0xc0, 0xe0, 0xc0, 0xc0, 0xe0,
                                     0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x07, 0x00, 0x00, 0x03, 0x07, 0x07, 0x07, 0x02, 0x02,
                                     0x03, 0x01, 0x02, 0x04, 0x07, 0x03, 0x03, 0x00, 0x00, 0x03, 0x07, 0x03, 0x07, 0x03, 0x03, 0x07,
                                     0xe0, 0xc0, 0x20, 0x30, 0xf0, 0xe0, 0x80, 0x00, 0x20, 0xe0, 0xf0, 0xe0, 0x30, 0x30, 0xa0, 0x80};

            byte[] bardHeroSprite = { 0x06, 0x0F, 0x0F, 0x0F, 0x18, 0x1F, 0x1F, 0x0C, 0x06, 0x0F, 0x0F, 0x0F, 0x1F, 0x1F, 0x13, 0x03,
                                      0xC0, 0xE0, 0xE0, 0xE0, 0x30, 0xF0, 0xF2, 0xE6, 0xC0, 0xE0, 0xE0, 0xE0, 0xF0, 0xF0, 0xF0, 0x89,
                                      0x0E, 0x16, 0x1E, 0x3F, 0x3F, 0x7F, 0x3F, 0x00, 0x1B, 0x1B, 0x1B, 0x39, 0x3C, 0x7F, 0x7F, 0x3F,
                                      0x7E, 0xFC, 0xF8, 0xD8, 0xE4, 0xF8, 0x0E, 0xF0, 0x90, 0xB0, 0xB8, 0x38, 0x7C, 0xFC, 0xFF, 0xFE,
                                      0x06, 0x0F, 0x0F, 0x0F, 0x18, 0x1F, 0x1F, 0x0C, 0x06, 0x0F, 0x0F, 0x0F, 0x1F, 0x1F, 0x13, 0x03,
                                      0xC0, 0xE0, 0xE0, 0xE0, 0x30, 0xF0, 0xF0, 0xE2, 0xC0, 0xE0, 0xE0, 0xE0, 0xF0, 0xF0, 0xF0, 0x80,
                                      0x0E, 0x16, 0x1E, 0x3F, 0x3F, 0x7F, 0x30, 0x0F, 0x1B, 0x1B, 0x1B, 0x39, 0x3C, 0x7F, 0x7F, 0x3F,
                                      0x76, 0xFE, 0xFC, 0xD8, 0xE4, 0xF8, 0xFE, 0x00, 0x99, 0xB0, 0xB8, 0x38, 0x7C, 0xFC, 0xFF, 0xFE,
                                      0x06, 0x0F, 0x0F, 0x0F, 0x18, 0x1F, 0x5F, 0x20, 0x06, 0x0F, 0x0F, 0x0F, 0x1F, 0x1A, 0x12, 0xDF,
                                      0xC0, 0xE0, 0xE0, 0xE0, 0x10, 0xF0, 0xF0, 0xE0, 0xC0, 0xE0, 0xE0, 0x60, 0xF0, 0x50, 0x50, 0x20,
                                      0x7F, 0x37, 0x17, 0x20, 0x2F, 0x5E, 0x4E, 0x00, 0x04, 0x0C, 0x1E, 0x3F, 0x3F, 0x7E, 0xE0, 0x40,
                                      0xA0, 0xD0, 0xD8, 0x18, 0xEC, 0xEC, 0xE6, 0xF0, 0xF0, 0x30, 0x78, 0xF8, 0xFC, 0xFC, 0x0E, 0xF6,
                                      0x06, 0x0F, 0x0F, 0x0F, 0x18, 0x1F, 0x1F, 0x4F, 0x06, 0x0F, 0x0F, 0x0F, 0x1F, 0x1A, 0x12, 0x0C,
                                      0xC0, 0xE0, 0xE0, 0xE0, 0x10, 0xF0, 0xF0, 0xE0, 0xC0, 0xE0, 0xE0, 0x60, 0xF0, 0x50, 0x50, 0x20,
                                      0x20, 0x7F, 0x3F, 0x20, 0x2F, 0x5E, 0x4E, 0x1E, 0xDF, 0x04, 0x0C, 0x3F, 0x3F, 0x7E, 0xE0, 0x5E,
                                      0xA0, 0xD0, 0xD8, 0x98, 0xEC, 0xEC, 0xE6, 0x00, 0xF0, 0xB0, 0x38, 0x78, 0xFC, 0xFC, 0x0E, 0x06,
                                      0x06, 0x0F, 0x0F, 0x1F, 0x10, 0x1F, 0x3F, 0x3F, 0x06, 0x0F, 0x0F, 0x1F, 0x1F, 0x1C, 0x08, 0x0E,
                                      0xC0, 0xE0, 0xE0, 0xF0, 0x10, 0xE0, 0xE8, 0xCC, 0xC0, 0xE0, 0xE0, 0xD0, 0xF0, 0x40, 0x40, 0x10, 
                                      0x16, 0x19, 0x1F, 0x1E, 0x34, 0x79, 0xF3, 0x03, 0x07, 0x0F, 0x2F, 0x2F, 0x2F, 0x7F, 0xFC, 0xFB,
                                      0x58, 0x78, 0x70, 0x00, 0xE0, 0xF0, 0xC0, 0xE0, 0xC0, 0x80, 0xC0, 0xE0, 0xE0, 0xF0, 0x00, 0xE0,
                                      0x03, 0x07, 0x07, 0x0F, 0x08, 0x07, 0x17, 0x33, 0x03, 0x07, 0x07, 0x0B, 0x0F, 0x02, 0x02, 0x08,
                                      0x60, 0xF0, 0xF0, 0xF8, 0x08, 0xF8, 0xFC, 0xFC, 0x60, 0xF0, 0xF0, 0xF8, 0xF8, 0x38, 0x10, 0x70, 
                                      0x0E, 0x0E, 0x06, 0x00, 0x07, 0x0F, 0x0F, 0x1F, 0x03, 0x01, 0x03, 0x07, 0x07, 0x0F, 0x00, 0x1F, 
                                      0x68, 0x98, 0xE8, 0x78, 0x78, 0x3C, 0x9E, 0x00, 0xF0, 0xF0, 0xF0, 0xF0, 0xF4, 0xFC, 0xFE, 0x3F,
                                      0xC0, 0xE0, 0xE0, 0xF0, 0x10, 0xE0, 0xE0, 0xC8, 0xC0, 0xE0, 0xE0, 0xD0, 0xF0, 0x40, 0x40, 0x00,
                                      0x16, 0x19, 0x1F, 0x1E, 0x32, 0x3C, 0x79, 0x00, 0x07, 0x0F, 0x0F, 0x2F, 0x2F, 0x3F, 0x7F, 0xFC, 
                                      0x4C, 0x7C, 0x78, 0x00, 0xE0, 0xF0, 0xF0, 0xF8, 0xD0, 0x80, 0xC0, 0xE0, 0xE0, 0xF0, 0x00, 0xF8, 
                                      0x03, 0x07, 0x07, 0x0F, 0x08, 0x07, 0x07, 0x13, 0x03, 0x07, 0x07, 0x0B, 0x0F, 0x02, 0x02, 0x00,
                                      0x36, 0x0E, 0x0E, 0x00, 0x07, 0x0F, 0x03, 0x07, 0x0B, 0x01, 0x03, 0x07, 0x07, 0x0F, 0x00, 0x07,
                                      0x68, 0x98, 0xE8, 0x78, 0x3C, 0x9E, 0xCF, 0xC0, 0xF0, 0xF0, 0xF0, 0xF4, 0xF4, 0xFE, 0x3F, 0xDF};

            byte[] warriorHeroSprite = { 0x03, 0x07, 0x2F, 0x1F, 0x0F, 0x1F, 0x0F, 0xC7, 0x03, 0x07, 0x2F, 0x1F, 0x0F, 0x1F, 0x0F, 0x07, 
                                         0xC0, 0xE2, 0xF2, 0xF2, 0xF2, 0xF2, 0xE2, 0xE2, 0xC0, 0xE0, 0xF0, 0xF0, 0xF0, 0xF0, 0xE0, 0xD8, 
                                         0xE3, 0x61, 0xA3, 0x6F, 0xF2, 0xE2, 0x92, 0x00, 0xDC, 0xDF, 0x5F, 0xCF, 0xDF, 0xBF, 0x1F, 0x00, 
                                         0xC2, 0x86, 0xC7, 0xF7, 0x48, 0x24, 0x70, 0xF8, 0x3C, 0xFA, 0xF8, 0xF4, 0xF8, 0xFC, 0x80, 0x00, 
                                         0x03, 0x07, 0x2F, 0x1F, 0x0F, 0x1F, 0x7F, 0xE7, 0x03, 0x07, 0x2F, 0x1F, 0x0F, 0x1F, 0x0F, 0x7B, 
                                         0xC0, 0xE0, 0xF1, 0xF1, 0xF1, 0xF1, 0xE1, 0xC1, 0xC0, 0xE0, 0xF0, 0xF0, 0xF0, 0xF0, 0xE0, 0xF0, 
                                         0xC3, 0xE1, 0xE3, 0xFF, 0xF2, 0x64, 0x2E, 0x1F, 0x7C, 0x1F, 0x1F, 0x6F, 0x3F, 0x3F, 0x01, 0x00, 
                                         0xC1, 0x85, 0xC7, 0xF7, 0x4B, 0x44, 0x48, 0x00, 0x3C, 0xF8, 0xF9, 0xF0, 0xFA, 0xFC, 0xF8, 0x00, 
                                         0x03, 0x07, 0x8F, 0x8F, 0x8F, 0x8F, 0x87, 0x87, 0x03, 0x07, 0x0D, 0x0D, 0x0C, 0x0A, 0x02, 0x04, 
                                         0xC0, 0xE0, 0xF4, 0xF8, 0xF0, 0xF8, 0xF3, 0xE7, 0xC0, 0xE0, 0xF4, 0xF8, 0xF0, 0x58, 0x50, 0x3B, 
                                         0x83, 0xE1, 0xE3, 0xEF, 0xD2, 0x22, 0x12, 0x00, 0x3F, 0x5F, 0xFF, 0x2E, 0x5F, 0x3F, 0x1F, 0x00, 
                                         0xC6, 0x85, 0xC6, 0xF7, 0x4B, 0x25, 0x70, 0xF8, 0xFB, 0xFA, 0xFB, 0x73, 0xF9, 0xFC, 0x80, 0x00, 
                                         0x03, 0x47, 0x4F, 0x4F, 0x4F, 0x4F, 0x47, 0x47, 0x03, 0x07, 0x0D, 0x0D, 0x0C, 0x0A, 0x02, 0x1C, 
                                         0xC0, 0xE0, 0xF4, 0xF8, 0xF0, 0xF8, 0xF0, 0xEE, 0xC0, 0xE0, 0xF4, 0xF8, 0xF0, 0x58, 0x50, 0x20, 
                                         0x63, 0x71, 0x73, 0x6F, 0x12, 0x24, 0x0E, 0x1F, 0x3F, 0x7F, 0x1F, 0x2E, 0x1F, 0x3F, 0x01, 0x00, 
                                         0xDF, 0x9B, 0xD5, 0xFB, 0x5F, 0x4E, 0x4C, 0x00, 0xEE, 0xEE, 0xEA, 0x6E, 0xEE, 0xF4, 0xF8, 0x00, 
                                         0x03, 0x2F, 0x1F, 0x1F, 0x2F, 0x1F, 0x0F, 0x0F, 0x03, 0x2F, 0x1F, 0x1F, 0x2F, 0x1E, 0x08, 0x07, 
                                         0xC0, 0xE0, 0xF4, 0xF4, 0xF4, 0xF4, 0xE4, 0xC4, 0xC0, 0xE0, 0xF0, 0xB0, 0xB0, 0x50, 0x40, 0x00, 
                                         0x00, 0x01, 0x13, 0x0F, 0x02, 0x04, 0x0F, 0x07, 0x0F, 0x1F, 0x1E, 0x0F, 0x1F, 0x3F, 0x10, 0x00, 
                                         0x04, 0xC4, 0xEE, 0xFE, 0x7C, 0x48, 0x70, 0x80, 0xC0, 0x60, 0x2E, 0x02, 0xC4, 0xF8, 0xF0, 0x00, 
                                         0x03, 0x07, 0x4F, 0x4F, 0x4F, 0x4F, 0x47, 0x43, 0x03, 0x07, 0x0F, 0x0D, 0x0D, 0x0A, 0x02, 0x00, 
                                         0xC0, 0xF4, 0xF8, 0xF8, 0xF4, 0xF8, 0xF0, 0xE0, 0xC0, 0xF4, 0xF8, 0xF8, 0xF4, 0x78, 0x10, 0x20, 
                                         0x47, 0x49, 0xFD, 0xF7, 0x61, 0x02, 0x0F, 0x07, 0x06, 0x06, 0xE6, 0x82, 0x47, 0x0F, 0x00, 0x00, 
                                         0xB0, 0x50, 0xB0, 0xF0, 0xE0, 0x64, 0x38, 0x80, 0xE8, 0xA8, 0xE0, 0xE0, 0x50, 0xBC, 0xF8, 0x00, 
                                         0xC0, 0xE0, 0xF0, 0xF0, 0xF0, 0xF0, 0xE0, 0xC0, 0xC0, 0xE0, 0x70, 0x30, 0x30, 0x50, 0x40, 0x00, 
                                         0x0F, 0x1F, 0x1F, 0x0F, 0x04, 0x24, 0x1C, 0x01, 0x1A, 0x13, 0x10, 0x09, 0x1F, 0x3F, 0x1F, 0x00, 
                                         0x60, 0x00, 0xA0, 0xE0, 0x80, 0x40, 0xF0, 0xE0, 0xE0, 0xE0, 0xE0, 0xC0, 0xE0, 0xF0, 0x00, 0x00, 
                                         0x03, 0x27, 0x2F, 0x2F, 0x2F, 0x2F, 0x27, 0x27, 0x03, 0x07, 0x0F, 0x0D, 0x0D, 0x0A, 0x02, 0x00, 
                                         0x2F, 0x7D, 0x7A, 0x3D, 0x0F, 0x17, 0x0E, 0x01, 0x07, 0x77, 0x45, 0x27, 0x07, 0x1A, 0x0D, 0x00, 
                                         0x80, 0xE0, 0xE8, 0xF0, 0xC0, 0x20, 0xF0, 0xE0, 0x70, 0x18, 0x18, 0x70, 0x78, 0xFC, 0x08, 0x00 };

            byte[] oldHeroSprite = { 0x00, 0x03, 0x07, 0xE7, 0xA3, 0x20, 0x44, 0x5F, 0x00, 0x00, 0x00, 0x00, 0x04, 0x0F, 0x0B, 0x1C,
                                     0x00, 0xC0, 0xE0, 0xE0, 0xC0, 0x00, 0x20, 0xF8, 0x00, 0x00, 0x00, 0x00, 0x20, 0xF0, 0xD0, 0x38,
                                     0x7F, 0xBF, 0xDF, 0x43, 0x5C, 0x7F, 0x60, 0x1F, 0x3F, 0x7F, 0x7F, 0x1F, 0x1F, 0x3F, 0x3F, 0x61,
                                     0xFC, 0xFC, 0xFE, 0xC4, 0x38, 0xFC, 0xFC, 0x00, 0xFC, 0xFE, 0xFA, 0xFC, 0xC0, 0xCC, 0xFC, 0xFE,
                                     0x00, 0x03, 0x07, 0x07, 0xE3, 0xA0, 0x24, 0x5F, 0x00, 0x00, 0x00, 0x00, 0x04, 0x0F, 0x0B, 0x1C, 
                                     0x00, 0xC0, 0xE0, 0xE0, 0xC0, 0x00, 0x20, 0xF8, 0x00, 0x00, 0x00, 0x00, 0x20, 0xF0, 0xD0, 0x38,
                                     0x7F, 0x7F, 0xBF, 0xCF, 0x50, 0x5F, 0x3F, 0x00, 0x3F, 0x3F, 0x7F, 0x7F, 0x1F, 0x1F, 0x3F, 0x7F,
                                     0xFC, 0xF8, 0xC6, 0x3C, 0xF8, 0xFC, 0x04, 0xF8, 0xFC, 0xFE, 0xFE, 0xC4, 0xC8, 0xFC, 0xFC, 0x86,
                                     0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x02, 0x19, 0x00, 0x00, 0x00, 0x00, 0x02, 0x0A, 0x0D, 0x1E,
                                     0x00, 0xC0, 0xE0, 0xE7, 0xE5, 0xE4, 0x42, 0x9A, 0x00, 0x00, 0x00, 0x00, 0x40, 0x50, 0xB0, 0x78,
                                     0x38, 0x3C, 0x5F, 0x23, 0x1D, 0x3D, 0x20, 0x1F, 0x3F, 0x7F, 0x7F, 0x1E, 0x1F, 0x3F, 0x3F, 0x61, 
                                     0x1E, 0x3E, 0xF6, 0xCE, 0xBA, 0xBA, 0xBE, 0x02, 0xFC, 0xF8, 0xF8, 0x7C, 0xF8, 0xF8, 0xFC, 0xFC,
                                     0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0x02, 0x19, 0x00, 0x00, 0x00, 0x00, 0x02, 0x0A, 0x0D, 0x1E, 
                                     0x00, 0xC0, 0xE0, 0xE0, 0xE7, 0xE5, 0x44, 0x9A, 0x00, 0x00, 0x00, 0x00, 0x40, 0x50, 0xB0, 0x78, 
                                     0x38, 0x3C, 0x5F, 0x23, 0x1D, 0x1D, 0x3D, 0x00, 0x3F, 0x7F, 0x7F, 0x1E, 0x1F, 0x1F, 0x3F, 0x7F, 
                                     0x1E, 0x3E, 0xF6, 0xCE, 0xBA, 0xBE, 0x04, 0xF8, 0xF8, 0xFC, 0xF8, 0x78, 0xF8, 0xFC, 0xFC, 0x86, 
                                     0x00, 0x07, 0x0F, 0x0F, 0x0D, 0x00, 0x02, 0x1F, 0x00, 0x00, 0x00, 0x00, 0x02, 0x0F, 0x0D, 0x17, 
                                     0x00, 0xC0, 0xE0, 0xE0, 0xE0, 0xE0, 0x43, 0x22, 0x00, 0x00, 0x00, 0x00, 0x40, 0x40, 0xA0, 0xD0, 
                                     0x3F, 0x21, 0x1E, 0x3F, 0x7F, 0x7F, 0x70, 0x0F, 0x3F, 0x3F, 0x7F, 0x23, 0x67, 0x7F, 0x7F, 0xF0, 
                                     0x02, 0x94, 0x64, 0xE8, 0xE8, 0xE0, 0x60, 0x98, 0xF0, 0xF8, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 
                                     0x00, 0x03, 0x07, 0x07, 0x07, 0x07, 0xC2, 0x44, 0x00, 0x00, 0x00, 0x00, 0x02, 0x02, 0x05, 0x0B, 
                                     0x00, 0xE0, 0xF0, 0xF0, 0xB0, 0x00, 0x40, 0xF8, 0x00, 0x00, 0x00, 0x00, 0x40, 0xF0, 0xB0, 0xE8, 
                                     0x40, 0x29, 0x3F, 0x1F, 0x1F, 0x0F, 0x08, 0x0F, 0x0F, 0x0F, 0x07, 0x07, 0x0F, 0x07, 0x07, 0x18, 
                                     0xFC, 0xFC, 0xF0, 0x0C, 0xFE, 0xFE, 0x0E, 0xF0, 0xFC, 0xFE, 0xFC, 0xFC, 0xFE, 0xFE, 0xFE, 0x0F, 
                                     0x00, 0xC0, 0xE0, 0xE6, 0xE4, 0xE4, 0x42, 0x22, 0x00, 0x00, 0x00, 0x00, 0x40, 0x40, 0xA0, 0xD0, 
                                     0x3F, 0x3F, 0x18, 0x27, 0x7F, 0x7F, 0x7E, 0x01, 0x3F, 0x7F, 0x3F, 0x3F, 0x63, 0x67, 0x7F, 0xFE, 
                                     0x04, 0x94, 0xEC, 0x14, 0xE4, 0xE4, 0x04, 0xF4, 0xF0, 0xF8, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0x18, 
                                     0x00, 0x03, 0x07, 0x67, 0x27, 0x27, 0x42, 0x44, 0x00, 0x00, 0x00, 0x00, 0x02, 0x02, 0x05, 0x0B, 
                                     0x40, 0x79, 0x7F, 0x5C, 0x4F, 0x47, 0x46, 0x49, 0x0F, 0x1F, 0x0F, 0x1F, 0x0F, 0x0F, 0x0F, 0x1F, 
                                     0xFC, 0xFC, 0xF0, 0x0C, 0xFE, 0xFE, 0x7E, 0x80, 0xFC, 0xFE, 0xFC, 0xFC, 0xFE, 0xFE, 0xFE, 0x7F };
/*
            for (int lni=0; lni < 16; lni++)
            {
                // code for moving sprite parts to hero sprite

                romData[0x20010 + lni] = romData[0x22d10 + lni]; // left head back 1
                romData[0x20020 + lni] = romData[0x22d20 + lni]; // right head back 1
                romData[0x20030 + lni] = romData[0x22d30 + lni]; // left body back 1
                romData[0x20040 + lni] = romData[0x22d40 + lni]; // right body back 1
                romData[0x20050 + lni] = romData[0x22d50 + lni]; // left head back 2
                romData[0x20060 + lni] = romData[0x22d60 + lni]; // right head back 2
                romData[0x20070 + lni] = romData[0x22d70 + lni]; // left body back 2
                romData[0x20080 + lni] = romData[0x22d80 + lni]; // right body back 2

                romData[0x20090 + lni] = romData[0x22940 + lni]; // left head front 1
                romData[0x200a0 + lni] = romData[0x22950 + lni]; // right head front 1
                romData[0x200b0 + lni] = romData[0x22960 + lni]; // left body front 1
                romData[0x200c0 + lni] = romData[0x22970 + lni]; // right body front 1
                romData[0x200d0 + lni] = romData[0x22980 + lni]; // left head front 2
                romData[0x200e0 + lni] = romData[0x22990 + lni]; // right head front 2
                romData[0x200f0 + lni] = romData[0x229a0 + lni]; // left body front 2
                romData[0x20100 + lni] = romData[0x229b0 + lni]; // right body front 2

                romData[0x20110 + lni] = romData[0x229d0 + lni]; // facing right head left
                romData[0x20120 + lni] = romData[0x22a40 + lni]; // facing right head right 1
                romData[0x20130 + lni] = romData[0x22a50 + lni]; // facing right body left 1
                romData[0x20140 + lni] = romData[0x22a60 + lni]; // facing right body right 1
                romData[0x20190 + lni] = romData[0x22a80 + lni]; // facing right head left 2
                romData[0x201a0 + lni] = romData[0x22a90 + lni]; // facing right body left 2
                romData[0x201b0 + lni] = romData[0x22aa0 + lni]; // facing right body right 2

                romData[0x20150 + lni] = romData[0x229c0 + lni]; // facing left head left 1
                romData[0x20160 + lni] = romData[0x22a10 + lni]; // facing left head right
                romData[0x20170 + lni] = romData[0x229e0 + lni]; // facing left body left 1
                romData[0x20180 + lni] = romData[0x229f0 + lni]; // facing left body right 1
                romData[0x201c0 + lni] = romData[0x22a00 + lni]; // facing left head left 2
                romData[0x201d0 + lni] = romData[0x22a20 + lni]; // facing left body left 2
                romData[0x201e0 + lni] = romData[0x22a30 + lni]; // facing left body right 2
            }
*/

            int age = (r1.Next() % 99) + 1;
            int tens = age / 10;
            int ones = age % 10;
            int offset = 0;

            if (age < 12)
            {
                for (int lni = 0; lni < boyHeroSprite.Length; lni++)
                    romData[0x20010 + lni] = boyHeroSprite[lni];
            }
            else if (age > 22 && age < 46)
            {
                for (int lni = 0; lni < warriorHeroSprite.Length; lni++)
                    romData[0x20010 + lni] = warriorHeroSprite[lni];
            }
            else if (age > 45 && age < 66)
            {
                for (int lni = 0; lni < bardHeroSprite.Length; lni++)
                    romData[0x20010 + lni] = bardHeroSprite[lni];
            }
            else if (age > 65)
            {
                for (int lni = 0; lni < oldHeroSprite.Length; lni++)
                    romData[0x20010 + lni] = oldHeroSprite[lni];
            }

            byte tensHex = 0x00;
            byte onesHex = 0x00;

            for (int lnI = 0; lnI < 10; lnI++)
            {
                if (tens == lnI)
                {
                    switch (tens)
                    {
                        case 0:
                            tensHex = 0x01;
                            break;
                        case 1:
                            tensHex = 0x02;
                            break;
                        case 2:
                            tensHex = 0x03;
                            break;
                        case 3:
                            tensHex = 0x04;
                            break;
                        case 4:
                            tensHex = 0x05;
                            break;
                        case 5:
                            tensHex = 0x06;
                            break;
                        case 6:
                            tensHex = 0x07;
                            break;
                        case 7:
                            tensHex = 0x08;
                            break;
                        case 8:
                            tensHex = 0x09;
                            break;
                        case 9:
                            tensHex = 0x0a;
                            break;
                    }
                }
                if (ones == lnI)
                {
                    switch (ones)
                    {
                        case 0:
                            onesHex = 0x01;
                            break;
                        case 1:
                            onesHex = 0x02;
                            break;
                        case 2:
                            onesHex = 0x03;
                            break;
                        case 3:
                            onesHex = 0x04;
                            break;
                        case 4:
                            onesHex = 0x05;
                            break;
                        case 5:
                            onesHex = 0x06;
                            break;
                        case 6:
                            onesHex = 0x07;
                            break;
                        case 7:
                            onesHex = 0x08;
                            break;
                        case 8:
                            onesHex = 0x09;
                            break;
                        case 9:
                            onesHex = 0x0a;
                            break;
                    }

                }
            }
            if (tens == 0) offset = 1;
            romData[0x43876] = tensHex;
            romData[0x43877-offset] = onesHex;
            if (tens == 1)
            {
                romData[0x43878 - offset] = 0x1e;
                romData[0x43879 - offset] = 0x12;
            }
            else
            {
                if (ones == 0 || ones > 3)
                {
                    romData[0x43878 - offset] = 0x1e;
                    romData[0x43879 - offset] = 0x12;
                }
                else if (ones == 1)
                {
                    romData[0x43878 - offset] = 0x1d;
                    romData[0x43879 - offset] = 0x1e;
                }
                else if (ones == 2)
                {
                    romData[0x43878 - offset] = 0x18;
                    romData[0x43879 - offset] = 0x0e;
                }
                else // ones == 3
                {
                    romData[0x43878 - offset] = 0x1c;
                    romData[0x43879 - offset] = 0x0e;
                }
            }
            romData[0x4387a - offset] = romData[0x4387f];
            romData[0x4387b - offset] = romData[0x43880];
            romData[0x4387c - offset] = romData[0x43881];
            romData[0x4387d - offset] = romData[0x43882];
            romData[0x4387e - offset] = romData[0x43883];
            romData[0x4387f - offset] = romData[0x43884];
            romData[0x43880 - offset] = romData[0x43885];
            romData[0x43881 - offset] = romData[0x43886];
            romData[0x43882 - offset] = romData[0x43887];
            romData[0x43883 - offset] = romData[0x43888];
            romData[0x43884 - offset] = 0x00;
            romData[0x43885 - offset] = 0x00;
            romData[0x43886 - offset] = 0x00;
            romData[0x43887 - offset] = 0x00;
            romData[0x43888 - offset] = 0x00;
            if (offset == 1)
            {
                romData[0x43888] = 0x00;
            }
        }

        private void randStartGold()
        {
            Random r1 = new Random(int.Parse(txtSeed.Text));

            // randomize starting gold
            romData[0x2914f] = (byte)(r1.Next() % 256);

        }

        private void superRandomize()
        {
        }

        private int[] inverted_power_curve(int min, int max, int arraySize, double powToUse, Random r1)
        {
            int range = max - min;
            double p_range = Math.Pow(range, 1 / powToUse);
            int[] points = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                double section = (double)r1.Next() / int.MaxValue;
                points[i] = (int)Math.Round(max - Math.Pow(section * p_range, powToUse));
            }
            Array.Sort(points);
            return points;
        }

        private List<int> addTreasure(List<int> currentList, int[] treasureData)
        {
            for (int lnI = 0; lnI < treasureData.Length; lnI++)
                currentList.Add(treasureData[lnI]);
            return currentList;
        }

        private void shuffle(int[] treasureData, Random r1, bool keyItemAvoidance = false)
        {
            // Do not exceed these zones defined for the key items, or you're going to be stuck!
            int[] keyZoneMax = { 13, 13, 23, 40, 45, 53 }; // Cloak of wind, Mirror Of Ra, Golden Key, Jailor's Key, Moon Fragment, Eye Of Malroth
            List<byte> keyItems = new List<byte> { 0x2b, 0x2e, 0x37, 0x39, 0x26, 0x28 }; // When we reach insane randomness, we'll want to know what the key items are so we place them in the appropriate zones...

            // Shuffle each zone 15 times the length of the array for randomness.
            for (int lnI = 0; lnI < 15 * treasureData.Length; lnI++)
            {
                int swap1 = r1.Next() % treasureData.Length;
                int swap2 = r1.Next() % treasureData.Length;

                // Don't shuffle if key items would be swapped into inaccessible areas.
                if (keyItemAvoidance) {
                    int position1 = keyItems.IndexOf(romData[treasureData[swap1]]);
                    int position2 = keyItems.IndexOf(romData[treasureData[swap2]]);
                    if (position1 > -1 && swap2 > keyZoneMax[position1])
                        continue;
                    if (position2 > -1 && swap1 > keyZoneMax[position2])
                        continue;
                }

                swap(treasureData[swap1], treasureData[swap2]);
            }
        }

        private void swap(int firstAddress, int secondAddress)
        {
            byte holdAddress = romData[secondAddress];
            romData[secondAddress] = romData[firstAddress];
            romData[firstAddress] = holdAddress;
        }

        private int[] swapArray(int[] array, int first, int second)
        {
            int holdAddress = array[second];
            array[second] = array[first];
            array[first] = holdAddress;
            return array;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (!loadRom(true)) return;
            using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "DW3Compare.txt")))
            {
               for (int lnI = 0; lnI < 0x8a; lnI++)
                    compareComposeString("monsters" + lnI.ToString("X2"), writer, (0x32e3 + (23 * lnI)), 23);

                compareComposeString("itemPrice1", writer, 0x11be, 128);
                compareComposeString("itemPrice2", writer, 0x123b, 128);
                compareComposeString("weaponEffects", writer, 0x13280, 40);

                compareComposeString("treasures-Promontory", writer, 0x29237, 3);
                compareComposeString("treasures-NajimiBasement", writer, 0x2927B, 3);
                compareComposeString("treasures-Najimi", writer, 0x292C4, 3);
                compareComposeString("treasures-Thief'sKey", writer, 0x37DF1, 1);
                compareComposeString("treasures-MagicBall", writer, 0x375AA, 1);
                compareComposeString("treasures-Invitation", writer, 0x2927E, 2);
                compareComposeString("treasures-Kanave", writer, 0x29234, 2);
                compareComposeString("treasures-Champange1", writer, 0x29252, 1);
                compareComposeString("treasures-Champange2", writer, 0x292D2, 1);
                compareComposeString("treasures-Champange3", writer, 0x292E6, 1);
                compareComposeString("treasures-Isis", writer, 0x2925C, 9);
                compareComposeString("treasures-IsisWizards", writer, 0x31B9C, 1);
                compareComposeString("treasures-GoldenClaw", writer, 0x317F4, 1);
                compareComposeString("treasures-Pyramid1st", writer, 0x29249, 7);
                compareComposeString("treasures-Pyramid3rd4th5th", writer, 0x292B4, 15);
                compareComposeString("treasures-DreamCave1", writer, 0x2923A, 2);
                compareComposeString("treasures-DreamCave2", writer, 0x29280, 8);
                compareComposeString("treasures-WakeUpNPC", writer, 0x37786, 1);
                compareComposeString("treasures-Aliahan", writer, 0x29255, 5);
                compareComposeString("treasures-Portuga", writer, 0x29269, 3);
                compareComposeString("treasures-RoyalScroll", writer, 0x37CB9, 1);
                compareComposeString("treasures-Dwarf", writer, 0x2923C, 2);
                compareComposeString("treasures-Kidnappers1", writer, 0x2923E, 6);
                compareComposeString("treasures-Kidnappers2", writer, 0x2928B, 4);
                compareComposeString("treasures-BlackPepperNPC", writer, 0x377D5, 1);
                compareComposeString("treasures-Tedan1", writer, 0x31B94, 1);
                compareComposeString("treasures-Tedan2", writer, 0x29270, 1);
                compareComposeString("treasures-TedanGreenOrb", writer, 0x37828, 1);
                compareComposeString("treasures-Garuna1", writer, 0x29251, 1);
                compareComposeString("treasures-Garuna2", writer, 0x292C7, 4);
                compareComposeString("treasures-NohMask", writer, 0x292E4, 1);
                compareComposeString("treasures-PurpleOrb", writer, 0x292E7, 1);
                compareComposeString("treasures-WaterBlaster", writer, 0x377FE, 1);
                compareComposeString("treasures-PirateCove", writer, 0x29271, 3);
                compareComposeString("treasures-Eginbear", writer, 0x2925B, 1);
                compareComposeString("treasures-FinalKey", writer, 0x2922B, 1);
                compareComposeString("treasures-ArpTower", writer, 0x292CB, 7);
                compareComposeString("treasures-Soo", writer, 0x31B8C, 1);
                compareComposeString("treasures-SamanaoCave", writer, 0x29291, 23);
                compareComposeString("treasures-SamanaoCastle", writer, 0x292E5, 1);
                compareComposeString("treasures-LancelCave1", writer, 0x29244, 5);
                compareComposeString("treasures-LancelCave2", writer, 0x2928F, 2);
                compareComposeString("treasures-Luzami", writer, 0x31B97, 1);
                compareComposeString("treasures-NewTown1", writer, 0x2926C, 2);
                compareComposeString("treasures-NewTownYellowOrb", writer, 0x31B80, 1);
                compareComposeString("treasures-Sailor'sThighNPC", writer, 0x378A9, 1);
                compareComposeString("treasures-GhostShip", writer, 0x29275, 6);
                compareComposeString("treasures-SwordOfGaia", writer, 0x31B84, 1);
                compareComposeString("treasures-Negrogund", writer, 0x29288, 3);
                compareComposeString("treasures-SilverOrb", writer, 0x37907, 1);
                compareComposeString("treasures-LeafOfWorld", writer, 0x31B9F, 1);
                compareComposeString("treasures-SphereOfLight", writer, 0x37929, 1);
                compareComposeString("treasures-Baramos", writer, 0x29228, 3);
                compareComposeString("treasures-SwordOfIllusion", writer, 0x37a25, 1);
                compareComposeString("treasures-Tantegel", writer, 0x29265, 4);
                compareComposeString("treasures-Erdrick's", writer, 0x292A8, 5);
                compareComposeString("treasures-SilverHarp", writer, 0x29274, 1);
                compareComposeString("treasures-MountainCave", writer, 0x292DF, 5);
                compareComposeString("treasures-Oricon", writer, 0x31B90, 1);
                compareComposeString("treasures-FairyFlute", writer, 0x31B88, 1);
                compareComposeString("treasures-KolTower1", writer, 0x29253, 2);
                compareComposeString("treasures-KolTower2", writer, 0x292D5, 10);
                compareComposeString("treasures-SacredAmulet", writer, 0x37D5A, 1);
                compareComposeString("treasures-StaffOfRain", writer, 0x37D9D, 1);
                compareComposeString("treasures-RainbowDrop", writer, 0x37D80, 1);
                compareComposeString("treasures-Rimuldar", writer, 0x29233, 1);
                compareComposeString("treasures-ZomaCastle", writer, 0x292AD, 7);

                compareComposeString("stores", writer, 0x36838, 248, 1, "g128");

                for (int lnI = 0; lnI < 95; lnI++)
                    compareComposeString("monsterZones" + lnI.ToString("X2"), writer, (0xaeb + (15 * lnI)), 15);
                for (int lnI = 0; lnI < 20; lnI++)
                    compareComposeString("monsterSpecial" + lnI.ToString("X2"), writer, (0x107a + (6 * lnI)), 6);
                //for (int lnI = 0; lnI < 13; lnI++)
                //    compareComposeString("monsterBoss" + lnI.ToString("X2"), writer, (0x10356 + (4 * lnI)), 4);
                //compareComposeString("statStart", writer, 0x13dd1, 12);
                compareComposeString("statMult", writer, 0x281b, 10);
                compareComposeString("statUpsStrength", writer, 0x290e + 0, 40);
                compareComposeString("statUpsAgility", writer, 0x290e + 40, 40);
                compareComposeString("statUpsVitality", writer, 0x290e + 80, 40);
                compareComposeString("statUpsLuck", writer, 0x290e + 120, 40);
                compareComposeString("statUpsIntelligence", writer, 0x290e + 160, 40);

                compareComposeString("spellLearningHero", writer, 0x29d6, 63);
                compareComposeString("spellsLearnedHero", writer, 0x22E7, 32);
                compareComposeString("spellLearningPilgrim", writer, 0x2A15, 63);
                compareComposeString("spellsLearnedPilgrim", writer, 0x2307, 32);
                compareComposeString("spellLearningWizard", writer, 0x2A54, 63);
                compareComposeString("spellsLearnedWizard", writer, 0x2327, 32);
                compareComposeString("spellLearningSage", writer, 0x2A93, 63);
                //for (int lnI = 0; lnI < 28; lnI++)
                //    compareComposeString("spellStats" + (lnI).ToString(), writer, 0x127d5 + (5 * lnI), 5);
                //compareComposeString("spellCmd", writer, 0x13528, 28);
                //compareComposeString("spellFieldHeal", writer, 0x18be0, 16, 8);
                //compareComposeString("spellFieldMedical", writer, 0x19602, 1);

                //compareComposeString("start1", writer, 0x3c79f, 8);
                //compareComposeString("start2", writer, 0x3c79f + 8, 8);
                //compareComposeString("start3", writer, 0x3c79f + 16, 8);
                //compareComposeString("weapons", writer, 0x13efb, 16);
                //compareComposeString("weaponcost (2.3)", writer, 0x1a00e, 32);
                //compareComposeString("armor", writer, 0x13efb + 16, 11);
                //compareComposeString("armorcost (2.4)", writer, 0x1a00e + 32, 22);
                //compareComposeString("shields", writer, 0x13efb + 27, 5);
                //compareComposeString("shieldcost (2.8)", writer, 0x1a00e + 54, 10);
                //compareComposeString("helmets", writer, 0x13efb + 32, 3);
                //compareComposeString("helmetcost (3.0)", writer, 0x1a00e + 64, 6);

            }
            lblIntensityDesc.Text = "Comparison complete!  (DW3Compare.txt)";
        }

        private void changeEnd()
        {
            romData[0x29536] = 0x01; // indent
            romData[0x29537] = 0x38; // T
            romData[0x29538] = 0x12; // h
            romData[0x29539] = 0x1f; // u
            romData[0x2953a] = 0x1d; // s
            romData[0x2953b] = 0x6a; // ,
            romData[0x2953c] = 0x00; //
            romData[0x2953d] = 0xf0; // Hero 8 Char
            romData[0x2953e] = 0x00; //
            romData[0x2953f] = 0x0c; // b
            romData[0x29540] = 0x0f; // e
            romData[0x29541] = 0x0d; // c
            romData[0x29542] = 0x0b; // a
            romData[0x29543] = 0x17; // m
            romData[0x29544] = 0x0f; // e
            romData[0x29545] = 0x00; //
            romData[0x29546] = 0x15; // k
            romData[0x29547] = 0x18; // n
            romData[0x29548] = 0x19; // o
            romData[0x29549] = 0x21; // w
            romData[0x2954a] = 0x18; // n
            romData[0x2954b] = 0xff; // new line
            romData[0x2954c] = 0x00; // indent
            romData[0x2954d] = 0x0b; // a
            romData[0x2954e] = 0x1d; // s
            romData[0x2954f] = 0x00; //
            romData[0x29550] = 0x29; // E
            romData[0x29551] = 0x1c; // r
            romData[0x29552] = 0x0e; // d
            romData[0x29553] = 0x1c; // r
            romData[0x29554] = 0x13; // i
            romData[0x29555] = 0x0d; // c
            romData[0x29556] = 0x15; // k
            romData[0x29557] = 0x00; //
            romData[0x29558] = 0x13; // i
            romData[0x29559] = 0x18; // n
            romData[0x2955a] = 0x00; //
            romData[0x2955b] = 0x1d; // s
            romData[0x2955c] = 0x19; // o
            romData[0x2955d] = 0x17; // m
            romData[0x2955e] = 0x0f; // e
            romData[0x2955f] = 0x00; //
            romData[0x29560] = 0x1d; // s
            romData[0x29561] = 0x1e; // t
            romData[0x29562] = 0x19; // o
            romData[0x29563] = 0x1c; // r
            romData[0x29564] = 0x13; // i
            romData[0x29565] = 0x0f; // e
            romData[0x29566] = 0x1d; // s
            romData[0x29567] = 0x00; //
            romData[0x29568] = 0x0b; // a
            romData[0x29569] = 0x18; // n
            romData[0x2956a] = 0x0e; // d
            romData[0x2956b] = 0xff; // new line
            romData[0x2956c] = 0x00; // indent
            romData[0x2956d] = 0x30; // L
            romData[0x2956e] = 0x19; // o
            romData[0x2956f] = 0x1e; // t
            romData[0x29570] = 0x19; // o
            romData[0x29571] = 0x00; //
            romData[0x29572] = 0x13; // i
            romData[0x29573] = 0x18; // n
            romData[0x29574] = 0x00; //
            romData[0x29575] = 0x19; // o
            romData[0x29576] = 0x1e; // t
            romData[0x29577] = 0x12; // h
            romData[0x29578] = 0x0f; // e
            romData[0x29579] = 0x1c; // r
            romData[0x2957a] = 0x1d; // s
            romData[0x2957b] = 0x6c; // .
            romData[0x2957c] = 0xff; // newline
            romData[0x2957d] = 0x00; //
            romData[0x2957e] = 0x00; //
            romData[0x2957f] = 0xff; // new line
            romData[0x29580] = 0x00; // 
            romData[0x29581] = 0x00; //
            romData[0x29582] = 0xff; // new line
            romData[0x29583] = 0x01; // indent
            romData[0x29584] = 0x25; // A
            romData[0x29585] = 0x10; // f
            romData[0x29586] = 0x1e; // t
            romData[0x29587] = 0x0f; // e
            romData[0x29588] = 0x1c; // r
            romData[0x29589] = 0x00; //
            romData[0x2958a] = 0x0b; // a
            romData[0x2958b] = 0x00; // 
            romData[0x2958c] = 0x21; // w
            romData[0x2958d] = 0x12; // h
            romData[0x2958e] = 0x13; // i
            romData[0x2958f] = 0x16; // l
            romData[0x29590] = 0x0f; // e
            romData[0x29591] = 0x6a; // ,
            romData[0x29592] = 0x00; //
            romData[0x29593] = 0x19; // o
            romData[0x29594] = 0x1f; // u
            romData[0x29595] = 0x1c; // r
            romData[0x29596] = 0x00; //
            romData[0x29597] = 0x12; // h
            romData[0x29598] = 0x0f; // e
            romData[0x29599] = 0x1c; // r
            romData[0x2959a] = 0x19; // o
            romData[0x2959b] = 0x00; //
            romData[0x2959c] = 0x0b; // a
            romData[0x2959d] = 0x18; // n
            romData[0x2959e] = 0x0e; // d
            romData[0x2959f] = 0xff; // new line
            romData[0x295a0] = 0x00; // indent
            romData[0x295a1] = 0x1e; // t
            romData[0x295a2] = 0x12; // h
            romData[0x295a3] = 0x0f; // e
            romData[0x295a4] = 0x00; //
            romData[0x295a5] = 0x1c; // r
            romData[0x295a6] = 0x0f; // e
            romData[0x295a7] = 0x1d; // s
            romData[0x295a8] = 0x1e; // t
            romData[0x295a9] = 0x00; // 
            romData[0x295aa] = 0x19; // o
            romData[0x295ab] = 0x10; // f
            romData[0x295ac] = 0x00; //
            romData[0x295ad] = 0x1e; // t
            romData[0x295ae] = 0x12; // h
            romData[0x295af] = 0x0f; // e
            romData[0x295b0] = 0x00; //
            romData[0x295b1] = 0x1a; // p
            romData[0x295b2] = 0x0b; // a
            romData[0x295b3] = 0x1c; // r
            romData[0x295b4] = 0x1e; // t
            romData[0x295b5] = 0x23; // y
            romData[0x295b6] = 0x00; //
            romData[0x295b7] = 0x21; // w
            romData[0x295b8] = 0x0f; // e
            romData[0x295b9] = 0x18; // n
            romData[0x295ba] = 0x1e; // t
            romData[0x295bb] = 0xff; // new line
            romData[0x295bc] = 0x00; // indent
            romData[0x295bd] = 0x1e; // t
            romData[0x295be] = 0x12; // h
            romData[0x295bf] = 0x0f; // e
            romData[0x295c0] = 0x13; // i
            romData[0x295c1] = 0x1c; // r
            romData[0x295c2] = 0x00; //
            romData[0x295c3] = 0x1d; // s
            romData[0x295c4] = 0x0f; // e
            romData[0x295c5] = 0x1a; // p
            romData[0x295c6] = 0x0b; // a
            romData[0x295c7] = 0x1c; // r
            romData[0x295c8] = 0x0b; // a
            romData[0x295c9] = 0x1e; // t
            romData[0x295ca] = 0x0f; // e
            romData[0x295cb] = 0x00; //
            romData[0x295cc] = 0x21; // w
            romData[0x295cd] = 0x0b; // a
            romData[0x295ce] = 0x23; // y
            romData[0x295cf] = 0x1d; // s
            romData[0x295d0] = 0x6c; // .
            romData[0x295d1] = 0xff; // new line
            romData[0x295d2] = 0x00; //
            romData[0x295d3] = 0x00; //
            romData[0x295d4] = 0xff; // new line
            romData[0x295d5] = 0x01; // indent
            romData[0x295d6] = 0x38; // T
            romData[0x295d7] = 0x12; // h
            romData[0x295d8] = 0x0f; // e
            romData[0x295d9] = 0x00; //
            romData[0x295da] = 0x12; // h
            romData[0x295db] = 0x0f; // e
            romData[0x295dc] = 0x1c; // r
            romData[0x295dd] = 0x19; // o
            romData[0x295de] = 0x67; // '
            romData[0x295df] = 0x1d; // s
            romData[0x295e0] = 0x00; // 
            romData[0x295e1] = 0x1d; // s
            romData[0x295e2] = 0x21; // w
            romData[0x295e3] = 0x19; // o
            romData[0x295e4] = 0x1c; // r
            romData[0x295e5] = 0x0e; // d
            romData[0x295e6] = 0x6a; // ,
            romData[0x295e7] = 0x00; //
            romData[0x295e8] = 0x0b; // a
            romData[0x295e9] = 0x1c; // r
            romData[0x295ea] = 0x17; // m
            romData[0x295eb] = 0x19; // o
            romData[0x295ec] = 0x1c; // r
            romData[0x295ed] = 0x6a; // ,
            romData[0x295ee] = 0x00; //
            romData[0x295ef] = 0x0b; // a
            romData[0x295f0] = 0x18; // n
            romData[0x295f1] = 0x0e; // d
            romData[0x295f2] = 0xff; // new line
            romData[0x295f3] = 0x00; // paragraph
            romData[0x295f4] = 0x0b; // a
            romData[0x295f5] = 0x17; // m
            romData[0x295f6] = 0x1f; // u
            romData[0x295f7] = 0x16; // l
            romData[0x295f8] = 0x0f; // e
            romData[0x295f9] = 0x1e; // t
            romData[0x295fa] = 0x00; //
            romData[0x295fb] = 0x21; // w
            romData[0x295fc] = 0x0f; // e
            romData[0x295fd] = 0x1c; // r
            romData[0x295fe] = 0x0f; // e
            romData[0x295ff] = 0x00; //
            romData[0x29600] = 0x16; // l
            romData[0x29601] = 0x0f; // e
            romData[0x29602] = 0x10; // f
            romData[0x29603] = 0x1e; // t
            romData[0x29604] = 0x00; //
            romData[0x29605] = 0x0c; // b
            romData[0x29606] = 0x0f; // e
            romData[0x29607] = 0x12; // h
            romData[0x29608] = 0x13; // i
            romData[0x29609] = 0x18; // n
            romData[0x2960a] = 0x0e; // d
            romData[0x2960b] = 0x00; // 
            romData[0x2960c] = 0x10; // f
            romData[0x2960d] = 0x19; // o
            romData[0x2960e] = 0x1c; // r
            romData[0x2960f] = 0xff; // new line
            romData[0x29610] = 0x00; // indent
            romData[0x29611] = 0x10; // f
            romData[0x29612] = 0x1f; // u
            romData[0x29613] = 0x1e; // t
            romData[0x29614] = 0x1f; // u
            romData[0x29615] = 0x1c; // r
            romData[0x29616] = 0x0f; // e
            romData[0x29617] = 0x00; // 
            romData[0x29618] = 0x11; // g
            romData[0x29619] = 0x0f; // e
            romData[0x2961a] = 0x18; // n
            romData[0x2961b] = 0x0f; // e
            romData[0x2961c] = 0x1c; // r
            romData[0x2961d] = 0x0b; // a
            romData[0x2961e] = 0x1e; // t
            romData[0x2961f] = 0x13; // i
            romData[0x29620] = 0x19; // o
            romData[0x29621] = 0x18; // n
            romData[0x29622] = 0x1d; // s
            romData[0x29623] = 0x00; // 
            romData[0x29624] = 0x0c; // b
            romData[0x29625] = 0x0f; // e
            romData[0x29626] = 0x0b; // a
            romData[0x29627] = 0x1c; // r
            romData[0x29628] = 0x13; // i
            romData[0x29629] = 0x18; // n
            romData[0x2962a] = 0x11; // g
            romData[0x2962b] = 0xff; // new line
            romData[0x2962c] = 0x00; // indent
            romData[0x2962d] = 0x1e; // t
            romData[0x2962e] = 0x12; // h
            romData[0x2962f] = 0x0f; // e
            romData[0x29630] = 0x00; // 
            romData[0x29631] = 0x18; // n
            romData[0x29632] = 0x0b; // a
            romData[0x29633] = 0x17; // m
            romData[0x29634] = 0x0f; // e
            romData[0x29635] = 0x00; //
            romData[0x29636] = 0x19; // o
            romData[0x29637] = 0x10; // f
            romData[0x29638] = 0x00; //
            romData[0x29639] = 0x29; // E
            romData[0x2963a] = 0x1c; // r
            romData[0x2963b] = 0x0e; // d
            romData[0x2963c] = 0x1c; // r
            romData[0x2963d] = 0x13; // i
            romData[0x2963e] = 0x0d; // c
            romData[0x2963f] = 0x15; // k
            romData[0x29640] = 0x6c; // .
            romData[0x29641] = 0xff; // new line
            romData[0x29642] = 0x00; //
            romData[0x29643] = 0x00; //
            romData[0x29644] = 0xff; // new line
            romData[0x29645] = 0x01; // indent
            romData[0x29646] = 0x39; // U
            romData[0x29647] = 0x18; // n
            romData[0x29648] = 0x10; // f
            romData[0x29649] = 0x19; // o
            romData[0x2964a] = 0x1c; // r
            romData[0x2964b] = 0x1e; // t
            romData[0x2964c] = 0x1f; // u
            romData[0x2964d] = 0x18; // n
            romData[0x2964e] = 0x0b; // a
            romData[0x2964f] = 0x1e; // t
            romData[0x29650] = 0x0f; // e
            romData[0x29651] = 0x16; // l
            romData[0x29652] = 0x23; // y
            romData[0x29653] = 0x61; // ,
            romData[0x29654] = 0x00; //
            romData[0x29655] = 0x1c; // r
            romData[0x29656] = 0x0f; // e
            romData[0x29657] = 0x0d; // c
            romData[0x29658] = 0x19; // o
            romData[0x29659] = 0x1c; // r
            romData[0x2965a] = 0x0e; // d
            romData[0x2965b] = 0x1d; // s
            romData[0x2965c] = 0x00; //
            romData[0x2965d] = 0x19; // o
            romData[0x2965e] = 0x10; // f
            romData[0x2965f] = 0xff; // new line
            romData[0x29660] = 0x00; // indent
            romData[0x29661] = 0x29; // E
            romData[0x29662] = 0x1c; // r
            romData[0x29663] = 0x0e; // d
            romData[0x29664] = 0x1c; // r
            romData[0x29665] = 0x13; // i
            romData[0x29666] = 0x0d; // c
            romData[0x29667] = 0x15; // k
            romData[0x29668] = 0x67; // '
            romData[0x29669] = 0x1d; // s
            romData[0x2966a] = 0x00; //
            romData[0x2966b] = 0x1a; // p
            romData[0x2966c] = 0x0b; // a
            romData[0x2966d] = 0x1c; // r
            romData[0x2966e] = 0x1e; // t
            romData[0x2966f] = 0x23; // y
            romData[0x29670] = 0x00; //
            romData[0x29671] = 0x21; // w
            romData[0x29672] = 0x0f; // e
            romData[0x29673] = 0x1c; // r
            romData[0x29674] = 0x0f; // e
            romData[0x29675] = 0x00; //
            romData[0x29676] = 0x16; // l
            romData[0x29677] = 0x19; // o
            romData[0x29678] = 0x1d; // s
            romData[0x29679] = 0x1e; // t
            romData[0x2967a] = 0xff; // new line
            romData[0x2967b] = 0x00; // indent
            romData[0x2967c] = 0x21; // w
            romData[0x2967d] = 0x13; // i
            romData[0x2967e] = 0x1e; // t
            romData[0x2967f] = 0x12; // h
            romData[0x29680] = 0x00; //
            romData[0x29681] = 0x1e; // t
            romData[0x29682] = 0x13; // i
            romData[0x29683] = 0x17; // m
            romData[0x29684] = 0x0f; // e
            romData[0x29685] = 0x6c; // .
            romData[0x29686] = 0xff; // new line
            romData[0x29687] = 0x00; //
            romData[0x29688] = 0x00; //
            romData[0x29689] = 0xff; // new line
            romData[0x2968a] = 0x00; // indent
            romData[0x2968b] = 0x28; // D
            romData[0x2968c] = 0x1c; // r
            romData[0x2968d] = 0x0b; // a
            romData[0x2968e] = 0x11; // g
            romData[0x2968f] = 0x19; // o
            romData[0x29690] = 0x18; // n
            romData[0x29691] = 0x00; //
            romData[0x29692] = 0x3b; // W
            romData[0x29693] = 0x0b; // a
            romData[0x29694] = 0x1c; // r
            romData[0x29695] = 0x1c; // r
            romData[0x29696] = 0x13; // i
            romData[0x29697] = 0x19; // o
            romData[0x29698] = 0x1c; // r
            romData[0x29699] = 0x00; //
            romData[0x2969a] = 0x2d; // I
            romData[0x2969b] = 0x2d; // I
            romData[0x2969c] = 0x2d; // I
            romData[0x2969d] = 0x00; //
            romData[0x2969e] = 0x36; // R
            romData[0x2969f] = 0x0b; // a
            romData[0x296a0] = 0x18; // n
            romData[0x296a1] = 0x0e; // d
            romData[0x296a2] = 0x19; // o
            romData[0x296a3] = 0x17; // m
            romData[0x296a4] = 0x13; // i
            romData[0x296a5] = 0x24; // z
            romData[0x296a6] = 0x0f; // e
            romData[0x296a7] = 0x1c; // r
            romData[0x296a8] = 0xff; // New Line 
            romData[0x296a9] = 0x00; // 
            romData[0x296aa] = 0x00; //
            romData[0x296ab] = 0xff; // New Line
            romData[0x296ac] = 0x01; // Paragraph
            romData[0x296ad] = 0x33; // O
            romData[0x296ae] = 0x1c; // r
            romData[0x296af] = 0x13; // i
            romData[0x296b0] = 0x11; // g
            romData[0x296b1] = 0x13; // i
            romData[0x296b2] = 0x18; // n
            romData[0x296b3] = 0x0b; // a
            romData[0x296b4] = 0x16; // l
            romData[0x296b5] = 0x16; // l
            romData[0x296b6] = 0x23; // y
            romData[0x296b7] = 0x00; //
            romData[0x296b8] = 0x28; // D
            romData[0x296b9] = 0x0f; // e
            romData[0x296ba] = 0x20; // v
            romData[0x296bb] = 0x0f; // e
            romData[0x296bc] = 0x16; // l
            romData[0x296bd] = 0x19; // o
            romData[0x296be] = 0x1a; // p
            romData[0x296bf] = 0x0f; // e
            romData[0x296c0] = 0x0e; // d
            romData[0x296c1] = 0x00; //
            romData[0x296c2] = 0x26; // B
            romData[0x296c3] = 0x23; // y
            romData[0x296c4] = 0x75; // :
            romData[0x296c5] = 0xff; // new line
            romData[0x296c6] = 0x01; // paragraph
            romData[0x296c7] = 0x00; //
            romData[0x296c8] = 0x11; // g
            romData[0x296c9] = 0x0b; // a
            romData[0x296ca] = 0x17; // m
            romData[0x296cb] = 0x0f; // e
            romData[0x296cc] = 0x0c; // b
            romData[0x296cd] = 0x19; // o
            romData[0x296ce] = 0x23; // y
            romData[0x296cf] = 0x10; // f
            romData[0x296d0] = 0x0a; // 9
            romData[0x296d1] = 0xff; // new line
            romData[0x296d2] = 0x00; //
            romData[0x296d3] = 0x00; //
            romData[0x296d4] = 0xff; // new line
            romData[0x296d5] = 0x01; // paragraph
            romData[0x296d6] = 0x27; // C
            romData[0x296d7] = 0x1f; // u
            romData[0x296d8] = 0x1c; // r
            romData[0x296d9] = 0x1c; // r
            romData[0x296da] = 0x0f; // e
            romData[0x296db] = 0x18; // n
            romData[0x296dc] = 0x1e; // t
            romData[0x296dd] = 0x16; // l
            romData[0x296de] = 0x23; // y
            romData[0x296df] = 0x00; //
            romData[0x296e0] = 0x28; // D
            romData[0x296e1] = 0x0f; // e
            romData[0x296e2] = 0x20; // v
            romData[0x296e3] = 0x0f; // e
            romData[0x296e4] = 0x16; // l
            romData[0x296e5] = 0x19; // o
            romData[0x296e6] = 0x1a; // p
            romData[0x296e7] = 0x0f; // e
            romData[0x296e8] = 0x0e; // d
            romData[0x296e9] = 0x00; //
            romData[0x296ea] = 0x26; // B
            romData[0x296eb] = 0x23; // y
            romData[0x296ec] = 0x75; // :
            romData[0x296ed] = 0xff; // new line
            romData[0x296ee] = 0x01; // paragraph
            romData[0x296ef] = 0x00; //
            romData[0x296f0] = 0x0f; // e
            romData[0x296f1] = 0x18; // n
            romData[0x296f2] = 0x0e; // d
            romData[0x296f3] = 0x23; // y
            romData[0x296f4] = 0x17; // m
            romData[0x296f5] = 0x13; // i
            romData[0x296f6] = 0x19; // o
            romData[0x296f7] = 0x18; // n
            romData[0x296f8] = 0x16; // l
            romData[0x296f9] = 0x1d; // s
            romData[0x296fa] = 0xff; // new line
            romData[0x296fb] = 0x00; //
            romData[0x296fc] = 0x00; //
            romData[0x296fd] = 0xff; // new line
            romData[0x296fe] = 0x01; // paragraph
            romData[0x296ff] = 0x38; // T
            romData[0x29700] = 0x12; // h
            romData[0x29701] = 0x0b; // a
            romData[0x29702] = 0x18; // n
            romData[0x29703] = 0x15; // k
            romData[0x29704] = 0x00; //
            romData[0x29705] = 0x23; // y
            romData[0x29706] = 0x19; // o
            romData[0x29707] = 0x1f; // u
            romData[0x29708] = 0x00; // 
            romData[0x29709] = 0x10; // f
            romData[0x2970a] = 0x19; // o
            romData[0x2970b] = 0x1c; // r
            romData[0x2970c] = 0x00; //
            romData[0x2970d] = 0x1a; // p
            romData[0x2970e] = 0x16; // l
            romData[0x2970f] = 0x0b; // a
            romData[0x29710] = 0x23; // y
            romData[0x29711] = 0x13; // i
            romData[0x29712] = 0x18; // n
            romData[0x29713] = 0x11; // g
            romData[0x29714] = 0x70; // !
            romData[0x29715] = 0xff; // new line
            romData[0x29716] = 0x00; // 
            romData[0x29717] = 0x00; // 
            romData[0x29718] = 0x00; // 
            romData[0x29719] = 0x00; // 
            romData[0x2971a] = 0x00; // 
            romData[0x2971b] = 0x00; // 
            romData[0x2971c] = 0x00; // 
            romData[0x2971d] = 0x00; // 
            romData[0x2971e] = 0x00; // 
            romData[0x2971f] = 0x00; // 
            romData[0x1f777] = 0x00; //
            romData[0x1f778] = 0x00; //
            romData[0x1f779] = 0x38; // T
            romData[0x1f77a] = 0x12; // h
            romData[0x1f77b] = 0x0b; // a
            romData[0x1f77c] = 0x18; // n
            romData[0x1f77d] = 0x15; // k
            romData[0x1f77e] = 0x00; //
            romData[0x1f77f] = 0x23; // y
            romData[0x1f780] = 0x19; // o
            romData[0x1f781] = 0x1f; // u
            romData[0x1f782] = 0x00; // 
            romData[0x1f783] = 0x10; // f
            romData[0x1f784] = 0x19; // o
            romData[0x1f785] = 0x1c; // r
            romData[0x1f786] = 0x00; //
            romData[0x1f787] = 0x1a; // p
            romData[0x1f788] = 0x16; // l
            romData[0x1f789] = 0x0b; // a
            romData[0x1f78a] = 0x23; // y
            romData[0x1f78b] = 0x13; // i
            romData[0x1f78c] = 0x18; // n
            romData[0x1f78d] = 0x11; // g
            romData[0x1f78e] = 0x70; // !
            romData[0x1f78f] = 0x00; //
            romData[0x1f790] = 0x00; //
        }

        private StreamWriter compareComposeString(string intro, StreamWriter writer, int startAddress, int length, int skip = 1, string delimiter = "")
        {
            if (delimiter == "")
            {
                writer.WriteLine(intro);
                string final = "";
                string final2 = "";
                for (int lnI = 0; lnI < length; lnI += skip)
                {
                    final += romData[startAddress + lnI].ToString("X2") + " ";
                    if (lnI % 16 == 15)
                    {
                        writer.WriteLine(final);
                        final = "";
                    }
                }
                writer.WriteLine(final);
                if (length >= 16) writer.WriteLine();
                for (int lnI = 0; lnI < length; lnI += skip)
                {
                    final2 += romData2[startAddress + lnI].ToString("X2") + " ";
                    if (lnI % 16 == 15)
                    {
                        writer.WriteLine(final2);
                        final2 = "";
                    }
                }
                writer.WriteLine(final2);
                writer.WriteLine();
            }
            else
            {
                writer.WriteLine(intro);

                string final = "";
                for (int lnI = 0; lnI < length; lnI += skip)
                {
                    final += romData[startAddress + lnI].ToString("X2") + " ";
                    if (delimiter == "g128" && romData[startAddress + lnI] >= 128)
                    {
                        writer.WriteLine(final);
                        final = "";
                    }
                }
                writer.WriteLine(final);
                writer.WriteLine("---------------- VS -------------");
                final = "";
                for (int lnI = 0; lnI < length; lnI += skip)
                {
                    final += romData2[startAddress + lnI].ToString("X2") + " ";
                    if (delimiter == "g128" && romData2[startAddress + lnI] >= 128)
                    {
                        writer.WriteLine(final);
                        final = "";
                    }
                }
                writer.WriteLine(final);
                writer.WriteLine("");
            }
            return writer;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtFileName.Text != "")
            {
                using (StreamWriter writer = File.CreateText("lastFile.txt"))
                {
                    writer.WriteLine(txtFileName.Text);
                    writer.WriteLine(txtFlags.Text);
                    writer.WriteLine(chk_ChangeDefaultParty.Checked);
                    writer.WriteLine(chk_RandomName.Checked);
                    writer.WriteLine(chk_RandomGender.Checked);
                    writer.WriteLine(txtCharName1.Text);
                    writer.WriteLine(txtCharName2.Text);
                    writer.WriteLine(txtCharName3.Text);
                    writer.WriteLine(cboClass1.SelectedIndex);
                    writer.WriteLine(cboClass2.SelectedIndex);
                    writer.WriteLine(cboClass3.SelectedIndex);
                    writer.WriteLine(cboGender1.SelectedIndex);
                    writer.WriteLine(cboGender2.SelectedIndex);
                    writer.WriteLine(cboGender3.SelectedIndex);
                    writer.WriteLine(chk_LowerCaseMenus.Checked);
                    writer.WriteLine(chk_FixSlimeSnail.Checked);
                    writer.WriteLine(chk_ChangeHeroAge.Checked);
                    writer.WriteLine(chk_RandSpriteColor.Checked);
                    writer.WriteLine(chk_GhostToCasket.Checked);
                    writer.WriteLine(chk_changeCats.Checked);
                }
            }
        }

        private void txtFileName_Leave(object sender, EventArgs e)
        {
            runChecksum();
        }

        private void grpMonsterStat_Enter(object sender, EventArgs e)
        {

        }

        private void cboClass1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboClass2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboClass3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void textOutput()
        {
            loadRom(false);
            using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "DW3TextOutput.txt")))
            {
                for (int lnI = 0; lnI < 96; lnI++)
                    outputComposeString("monstersZones" + (lnI).ToString("X2"), writer, (0xaeb + (15 * lnI)), 15);

                for (int lnI = 0; lnI < 19; lnI++)
                    outputComposeString("monstersZoneSpecial" + (lnI + 1).ToString("X2"), writer, (0x108b + (6 * lnI)), 6);

                for (int lnI = 0; lnI < 140; lnI++)
                    outputComposeString("monsters" + (lnI).ToString("X2"), writer, (0x32e3 + (23 * lnI)), 23);

                for (int lnI = 0; lnI < 21; lnI++)
                    outputComposeString("bosses" + (lnI).ToString("X2"), writer, (0x8ee + (2 * lnI)), 2, 1, 43);
            }
            lblIntensityDesc.Text = "Text output complete!  (DW3TextOutput.txt)";
        }

        private void btn_CopyHash_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblHash.Text);
        }

        private StreamWriter outputComposeString(string intro, StreamWriter writer, int startAddress, int length, int skip = 1, int duplicate = 0)
        {
            string final = "";
            for (int lnI = 0; lnI < length; lnI += skip)
            {
                final += romData[startAddress + lnI].ToString("X2") + " ";
            }
            if (duplicate != 0)
            {
                for (int lnI = duplicate; lnI < length + duplicate; lnI += skip)
                {
                    final += romData[startAddress + lnI].ToString("X2") + " ";
                }
            }
            writer.WriteLine(intro);
            writer.WriteLine(final);
            writer.WriteLine();
            return writer;
        }

        private void determineChecks(object sender, EventArgs e)
        {
            string flags = txtFlags.Text;
            int number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(0, 1)));
            chk_GenCompareFile.Checked = (number % 2 == 1);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(1, 1)));
            cboExpGains.SelectedIndex = (number % 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(2, 1)));
            cboEncounterRate.SelectedIndex = (number % 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(3, 1)));
            cboGoldReq.SelectedIndex = (number % 4);
            chkFasterBattles.Checked = (number % 8 >= 4);
            chkSpeedText.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(4,1)));    
            chk_SpeedUpMenus.Checked = (number % 2 == 1);
            chk_Cod.Checked = (number % 4 >= 2);
            chk_WeapArmPower.Checked = (number % 8 >= 4);
            chkNoLamiaOrbs.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(5, 1)));
            chk_RmManip.Checked = (number % 2 == 1);
            chk_RandomStartGold.Checked = (number % 4 >= 2);
            chk_InvisibleNPCs.Checked = (number % 8 >= 4);
            chk_InvisibleShips.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(6, 1)));
            optMonsterLight.Checked = (number % 4 == 0);
            optMonsterSilly.Checked = (number % 4 == 1);
            optMonsterMedium.Checked = (number % 4 == 2);
            optMonsterHeavy.Checked = (number % 4 == 3);
            chkRandomizeXP.Checked = (number % 8 >= 4);
            chkRandomizeGP.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(7,1)));
            chkRandEnemyPatterns.Checked = (number % 2 == 1);
            chk_RemMetalMonRun.Checked = (number % 4 >= 2);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(8, 1)));
            chkRandomizeMap.Checked = (number % 2 == 1);
            chkSmallMap.Checked = (number % 4 >= 2);
            chk_SepBarGaia.Checked = (number % 8 >= 4);
            chkRandMonsterZones.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(9, 1)));
            chk_RemoveBirdRequirement.Checked = (number % 2 == 1);
            chk_RemLancelMountains.Checked = (number % 4 >= 2);
            chk_lbtoCharlock.Checked = (number % 8 >= 4);
            chk_RmMtnNecrogond.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(10, 1)));
            chk_RemoveMtnDrgQueen.Checked = (number % 2 == 1);
            chk_RmNewTown.Checked = (number % 4 >= 2);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(11, 1)));
            chkRandTreasures.Checked = (number % 2 == 1);
            chk_GoldenClaw.Checked = (number % 4 >= 2);;
            chkRandWhoCanEquip.Checked = (number % 8 >= 4);
            chkRandEquip.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(12, 1)));
            chk_UseVanEquipValues.Checked = (number % 2 == 1);
            chk_RemoveStartEqRestrictions.Checked = (number % 4 >= 2);
            chk_RmFighterPenalty.Checked = (number % 8 >= 4);
            chk_GreenSilverOrb.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(13, 1)));
            chk_AdjustEqpPrices.Checked = (number % 2 == 1);
            chk_RmRedundKey.Checked = (number % 4 >= 2);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(14, 1)));
            //chkRandItemEffects.Checked = (number % 2 == 1);
            chkRandItemEffects.Checked = false;
            chkRandItemStores.Checked = (number % 4 >= 2);
            chk_RandomizeWeaponShops.Checked = (number % 8 >= 4);
            chk_Caturday.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(15, 1)));
            chk_RandomizeInnPrices.Checked = (number % 2 == 1);
            chk_sellUnsellItems.Checked = (number % 4 >= 2);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(16, 1)));
            chk_StoneofLife.Checked = (number % 2 == 1);
            chk_Seeds.Checked = (number % 4 >= 2);
            chk_BookofSatori.Checked = (number % 8 >= 4);
            chk_RingofLife.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(17, 1)));
            chk_EchoingFlute.Checked = (number % 2 == 1);
            chk_SilverHarp.Checked = (number % 4 >= 2);
            chk_LeafoftheWorldTree.Checked = (number % 8 >= 4);
            chk_ShoesofHappiness.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(18, 1)));
            chk_MeteoriteArmband.Checked = (number % 2 == 1);
            chk_WizardsRing.Checked = (number % 4 >= 2);
            chk_LampofDarkness.Checked = (number % 8 >= 4);
            chk_PoisonMothPowder.Checked = (number % 16 >= 8);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(19, 1)));
            //chk_RandomName.Checked = (number % 2 == 1);
            //chk_RandomGender.Checked = (number % 2 == 1);
            //chk_RandomClass.Checked = (number % 4 >= 2);
            chkRandStatGains.Checked = (number % 2 == 1);
/*
            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(19, 1)));
            chk_RandSoldier.Checked = (number % 2 == 1);
            chk_RandPilgrim.Checked = (number % 4 >= 2);
            chk_RandWizard.Checked = (number % 8 >= 4);
            chk_RandFighter.Checked = (number % 16 >= 8);
*/
            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(20, 1)));
//            chk_RandMerchant.Checked = (number % 2 == 1);
//            chk_RandGoofOff.Checked = (number % 4 >= 2);
            chk_RandSage.Checked = (number % 2 == 1);
            chk_RandHero.Checked = (number % 4 >= 2);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(21, 1)));
            chkRandSpellLearning.Checked = (number % 2 == 1);
            chkRandSpellStrength.Checked = (number % 4 >= 2);
            chkFourJobFiesta.Checked = (number % 8 >= 4);

            number = convertChartoIntCapsOnly(Convert.ToChar(flags.Substring(22, 1)));
            chkRemoveParryFight.Checked = (number % 2 == 1);
        }

        private void determineFlags(object sender, EventArgs e)
        {
            if (loading) return;

            string flags = "";
            flags += convertIntToCharCapsOnly((chk_GenCompareFile.Checked ? 1 : 0)); // 0
            flags += convertIntToCharCapsOnly(cboExpGains.SelectedIndex); // 1
            flags += convertIntToCharCapsOnly(cboEncounterRate.SelectedIndex); // 2
            flags += convertIntToCharCapsOnly((cboGoldReq.SelectedIndex) + (chkFasterBattles.Checked ? 4 : 0) + (chkSpeedText.Checked ? 8 : 0)); // 3
            flags += convertIntToCharCapsOnly((chk_SpeedUpMenus.Checked ? 1 : 0) + (chk_Cod.Checked ? 2 : 0) + (chk_WeapArmPower.Checked ? 4 : 0) + (chkNoLamiaOrbs.Checked ? 8 : 0)); // 4
            flags += convertIntToCharCapsOnly((chk_RmManip.Checked ? 1 : 0) + (chk_RandomStartGold.Checked ? 2 : 0) + (chk_InvisibleNPCs.Checked ? 4 : 0) + (chk_InvisibleShips.Checked ? 8 : 0)); // 5
            flags += convertIntToCharCapsOnly((optMonsterLight.Checked ? 0 : optMonsterSilly.Checked ? 1 : optMonsterMedium.Checked ? 2 : 3) + (chkRandomizeXP.Checked ? 4 : 0) + (chkRandomizeGP.Checked ? 8 : 0)); // 6
            flags += convertIntToCharCapsOnly((chkRandEnemyPatterns.Checked ? 1 : 0) + (chk_RemMetalMonRun.Checked ? 2 : 0)); // 7
            flags += convertIntToCharCapsOnly((chkRandomizeMap.Checked ? 1 : 0) + (chkRandomizeMap.Checked ? (chkSmallMap.Checked ? 2 : 0) : 0) + (chkRandomizeMap.Checked ? (chkSmallMap.Checked ? (chk_SepBarGaia.Checked ? 4 : 0) : 0) : 0) + (chkRandomizeMap.Checked ? (chkRandMonsterZones.Checked ? 8 : 0) : 0)); // 8
            flags += convertIntToCharCapsOnly((chkRandomizeMap.Checked ? (chk_RemoveBirdRequirement.Checked ? 1 : 0) : 0) + (chkRandomizeMap.Checked ? (chk_RemLancelMountains.Checked ? 2 : 0) : 0) + (chkRandomizeMap.Checked ? (chk_lbtoCharlock.Checked ? 4 : 0) : 0) + (chkRandomizeMap.Checked ? (chk_RmMtnNecrogond.Checked ? 8 : 0) : 0)); // 9
            flags += convertIntToCharCapsOnly((chkRandomizeMap.Checked ? (chk_RemoveMtnDrgQueen.Checked ? 1 : 0) : 0) + (chkRandomizeMap.Checked ? (chk_RmNewTown.Checked ? 2 : 0) : 0));
            flags += convertIntToCharCapsOnly((chkRandTreasures.Checked ? 1 : 0) + (chkRandTreasures.Checked ? (chk_GoldenClaw.Checked ? 2 : 0) : 0)  + (chkRandWhoCanEquip.Checked ? 4 : 0) + (chkRandEquip.Checked ? 8 : 0)); // 10
            flags += convertIntToCharCapsOnly((chkRandEquip.Checked ? (chk_UseVanEquipValues.Checked ? 1 : 0) : 0) + (chkRandEquip.Checked ? (chk_RemoveStartEqRestrictions.Checked ? 2 : 0) : 0) + (chkRandEquip.Checked ? (chk_RmFighterPenalty.Checked ? 4 : 0) : 0) + (chkRandTreasures.Checked ? (chk_GreenSilverOrb.Checked ? 8 : 0) : 0)); // 11
            flags += convertIntToCharCapsOnly((chkRandEquip.Checked ? (chk_AdjustEqpPrices.Checked ? 1 : 0) : 0) + (chkRandTreasures.Checked ? (chk_RmRedundKey.Checked ? 2 : 0) : 0));
            flags += convertIntToCharCapsOnly((chkRandItemEffects.Checked ? 1 : 0) + (chkRandItemStores.Checked ? 2 : 0) + (chk_RandomizeWeaponShops.Checked ? 4 : 0) + (chk_Caturday.Checked ? 8 : 0)); // 12
            flags += convertIntToCharCapsOnly((chk_RandomizeInnPrices.Checked ? 1 : 0) + (chk_sellUnsellItems.Checked ? 2 : 0)); //13
            flags += convertIntToCharCapsOnly((chkRandItemStores.Checked ? (chk_StoneofLife.Checked ? 1 : 0) : 0) + (chkRandItemStores.Checked ? (chk_Seeds.Checked ? 2 : 0) : 0) + (chkRandItemStores.Checked ? (chk_BookofSatori.Checked ? 4 : 0) : 0) + (chkRandItemStores.Checked ? (chk_RingofLife.Checked ? 8 : 0) : 0)); // 14
            flags += convertIntToCharCapsOnly((chkRandItemStores.Checked ? (chk_EchoingFlute.Checked ? 1 : 0) : 0) + (chkRandItemStores.Checked ? (chk_SilverHarp.Checked ? 2 : 0) : 0) + (chkRandItemStores.Checked ? (chk_LeafoftheWorldTree.Checked ? 4 : 0) : 0) + (chkRandItemStores.Checked ? (chk_ShoesofHappiness.Checked ? 8 : 0) : 0)); // 15
            flags += convertIntToCharCapsOnly((chkRandItemStores.Checked ? (chk_MeteoriteArmband.Checked ? 1 : 0) : 0) + (chkRandItemStores.Checked ? (chk_WizardsRing.Checked ? 2 : 0) : 0) + (chkRandItemStores.Checked ? (chk_LampofDarkness.Checked ? 4 : 0) : 0) + (chkRandItemStores.Checked ? (chk_PoisonMothPowder.Checked ? 8 : 0) : 0)); // 16
            flags += convertIntToCharCapsOnly(/*(chk_ChangeDefaultParty.Checked ? (chk_RandomName.Checked ? 1 : 0) :0) + (chk_ChangeDefaultParty.Checked ? (chk_RandomGender.Checked ? 1 : 0) : 0) + (chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? 2 : 0) : 0) + */(chkRandStatGains.Checked ? 1 : 0)); // 17
 //           flags += convertIntToCharCapsOnly((chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? (chk_RandSoldier.Checked ? 1 : 0) : 0) : 0) + (chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? (chk_RandPilgrim.Checked ? 2 : 0) : 0) :0) + (chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? (chk_RandWizard.Checked ? 4 : 0) : 0) : 0) + (chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? (chk_RandFighter.Checked ? 8 : 0) : 0) : 0)); // 18
            flags += convertIntToCharCapsOnly(/*(chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? (chk_RandMerchant.Checked ? 1 : 0) : 0) : 0) + (chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? (chk_RandGoofOff.Checked ? 2 : 0) : 0) : 0) + */(chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? (chk_RandSage.Checked ? 1 : 0) : 0) : 0) + (chk_ChangeDefaultParty.Checked ? (chk_RandomClass.Checked ? (chk_RandHero.Checked ? 2 : 0) : 0) : 0)); // 19
            flags += convertIntToCharCapsOnly((chkRandSpellLearning.Checked ? 1 : 0) + (chkRandSpellStrength.Checked ? 2 : 0) + (chkFourJobFiesta.Checked ? 4 : 0)); // 20
            flags += convertIntToCharCapsOnly((chkRemoveParryFight.Checked ? 1 : 0)); // 21

            txtFlags.Text = flags;
            enableDisableFields(null,null);
        }

        private string convertIntToCharCapsOnly(int number)
        {
            return Convert.ToChar(65 + number).ToString();
        }

        private string convertIntToChar(int number)
        {
            if (number >= 0 && number <= 9)
                return number.ToString();
            if (number >= 10 && number <= 35)
                return Convert.ToChar(55 + number).ToString();
            if (number >= 36 && number <= 61)
                return Convert.ToChar(61 + number).ToString();
            if (number == 62) return "!";
            if (number == 63) return "@";
            return "";
        }

        private int convertChartoIntCapsOnly(char character)
        {
            return character - 65;
        }

        private int convertChartoInt(char character)
        {
            if (character >= Convert.ToChar("0") && character <= Convert.ToChar("9"))
                return character - 48;
            if (character >= Convert.ToChar("A") && character <= Convert.ToChar("Z"))
                return character - 55;
            if (character >= Convert.ToChar("a") && character <= Convert.ToChar("z"))
                return character - 61;
            if (character == Convert.ToChar("!")) return 62;
            if (character == Convert.ToChar("@")) return 63;
            return 0;
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
            if (optEndysFlags.Checked == true)
            {
                this.txtFlags.Text = endyFlags;
                this.txtFlags.Enabled = false;
                determineChecks(null, null);
            }
            if (optManualFlags.Checked == true)
            {
                this.txtFlags.Enabled = true;
                determineChecks(null, null);
            }
            if (chk_ChangeDefaultParty.Checked == false)
            {
                this.txtCharName1.Visible = false;
                this.txtCharName2.Visible = false;
                this.txtCharName3.Visible = false;
                this.cboClass1.Visible = false;
                this.cboClass2.Visible = false;
                this.cboClass3.Visible = false;
                this.cboGender1.Visible = false;
                this.cboGender2.Visible = false;
                this.cboGender3.Visible = false;
                this.chk_RandSoldier.Visible = false;
                this.chk_RandPilgrim.Visible = false;
                this.chk_RandWizard.Visible = false;
                this.chk_RandFighter.Visible = false;
                this.chk_RandMerchant.Visible = false;
                this.chk_RandGoofOff.Visible = false;
                this.chk_RandSage.Visible = false;
                this.chk_RandHero.Visible = false;
                this.chk_RandomName.Visible = false;
                this.chk_RandomClass.Visible = false;
                this.chk_RandomGender.Visible = false;
            }
            else
            {
                this.txtCharName1.Visible = !this.chk_RandomName.Checked;
                this.txtCharName2.Visible = !this.chk_RandomName.Checked;
                this.txtCharName3.Visible = !this.chk_RandomName.Checked;
                this.cboClass1.Visible = !this.chk_RandomClass.Checked;
                this.cboClass2.Visible = !this.chk_RandomClass.Checked;
                this.cboClass3.Visible = !this.chk_RandomClass.Checked;
                this.cboGender1.Visible = !this.chk_RandomGender.Checked;
                this.cboGender2.Visible = !this.chk_RandomGender.Checked;
                this.cboGender3.Visible = !this.chk_RandomGender.Checked;
                this.chk_RandSoldier.Visible = this.chk_RandomClass.Checked;
                this.chk_RandPilgrim.Visible = this.chk_RandomClass.Checked;
                this.chk_RandWizard.Visible = this.chk_RandomClass.Checked;
                this.chk_RandFighter.Visible = this.chk_RandomClass.Checked;
                this.chk_RandMerchant.Visible = this.chk_RandomClass.Checked;
                this.chk_RandGoofOff.Visible = this.chk_RandomClass.Checked;
                this.chk_RandSage.Visible = this.chk_RandomClass.Checked;
                this.chk_RandHero.Visible = this.chk_RandomClass.Checked;
                this.chk_RandomGender.Visible = true;
                this.chk_RandomClass.Visible = true;
                this.chk_RandomName.Visible = true;
            }
            this.lbl_ItemShops.Visible = this.chkRandItemStores.Checked;
            this.chk_BookofSatori.Visible = this.chkRandItemStores.Checked;
            this.chk_StoneofLife.Visible = this.chkRandItemStores.Checked;
            this.chk_Seeds.Visible = this.chkRandItemStores.Checked;
            this.chk_RingofLife.Visible = this.chkRandItemStores.Checked;
            this.chk_EchoingFlute.Visible = this.chkRandItemStores.Checked;
            this.chk_SilverHarp.Visible = this.chkRandItemStores.Checked;
            this.chk_ShoesofHappiness.Visible = this.chkRandItemStores.Checked;
            this.chk_MeteoriteArmband.Visible = this.chkRandItemStores.Checked;
            this.chk_WizardsRing.Visible = this.chkRandItemStores.Checked;
            this.chk_LampofDarkness.Visible = this.chkRandItemStores.Checked;
            this.chk_LeafoftheWorldTree.Visible = this.chkRandItemStores.Checked;
            this.chk_PoisonMothPowder.Visible = this.chkRandItemStores.Checked;
            this.lbl_TreasurePool.Visible = this.chkRandTreasures.Checked;
            this.chk_GoldenClaw.Visible = this.chkRandTreasures.Checked;
            this.chk_GreenSilverOrb.Visible = this.chkRandTreasures.Checked;
            this.chk_AdjustEqpPrices.Visible = this.chkRandEquip.Checked;
            this.chk_RemoveStartEqRestrictions.Visible = this.chkRandEquip.Checked;
            this.chkSmallMap.Visible = this.chkRandomizeMap.Checked;
            this.chk_SepBarGaia.Visible = this.chkRandomizeMap.Checked;
            this.chkRandMonsterZones.Visible = this.chkRandomizeMap.Checked;
            this.chk_RemoveBirdRequirement.Visible = this.chkRandomizeMap.Checked;
            this.chk_RemoveMtnDrgQueen.Visible = this.chkRandomizeMap.Checked;
            this.chk_RmNewTown.Visible = this.chkRandomizeMap.Checked;
            this.chk_RmMtnNecrogond.Visible = this.chkRandomizeMap.Checked;
            this.chk_RmFighterPenalty.Visible = this.chkRandEquip.Checked;
            this.chk_UseVanEquipValues.Visible = this.chkRandEquip.Checked;
            this.chk_RemLancelMountains.Visible = this.chkRandomizeMap.Checked;
            this.chk_lbtoCharlock.Visible = this.chkRandomizeMap.Checked;
            this.chk_RmRedundKey.Visible = this.chkRandTreasures.Checked;
        }
    }
}
