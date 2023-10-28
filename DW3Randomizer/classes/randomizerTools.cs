using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW3Randomizer.classes
{
    public class randomizerTools
    {
        public List<int> addTreasure(List<int> currentList, int[] treasureData)
        {
            for (int lnI = 0; lnI < treasureData.Length; lnI++)
                currentList.Add(treasureData[lnI]);
            return currentList;
        }

        public StreamWriter compareComposeString(ref byte[] romData, ref byte[] romData2, string intro, StreamWriter writer, int startAddress, int length, int skip = 1, string delimiter = "")
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

        public void CompareFile(ref byte[] romData, ref byte[] romData2, ref string IntensityDesc, string txtFileName)
        {
            using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "DW3Compare.txt")))
            {
                for (int lnI = 0; lnI < 0x8a; lnI++)
                    compareComposeString(ref romData, ref romData2, "monsters" + lnI.ToString("X2"), writer, (0x32e3 + (23 * lnI)), 23);

                compareComposeString(ref romData, ref romData2, "itemPrice1", writer, 0x11be, 128);
                compareComposeString(ref romData, ref romData2, "itemPrice2", writer, 0x123b, 128);
                compareComposeString(ref romData, ref romData2, "weaponEffects", writer, 0x13280, 40);
                compareComposeString(ref romData, ref romData2, "treasures-Promontory", writer, 0x29237, 3);
                compareComposeString(ref romData, ref romData2, "treasures-NajimiBasement", writer, 0x2927B, 3);
                compareComposeString(ref romData, ref romData2, "treasures-Najimi", writer, 0x292C4, 3);
                compareComposeString(ref romData, ref romData2, "treasures-Thief'sKey", writer, 0x37DF1, 1);
                compareComposeString(ref romData, ref romData2, "treasures-MagicBall", writer, 0x375AA, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Invitation", writer, 0x2927E, 2);
                compareComposeString(ref romData, ref romData2, "treasures-Kanave", writer, 0x29234, 2);
                compareComposeString(ref romData, ref romData2, "treasures-Champange1", writer, 0x29252, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Champange2", writer, 0x292D2, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Champange3", writer, 0x292E6, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Isis", writer, 0x2925C, 9);
                compareComposeString(ref romData, ref romData2, "treasures-IsisWizards", writer, 0x31B9C, 1);
                compareComposeString(ref romData, ref romData2, "treasures-GoldenClaw", writer, 0x317F4, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Pyramid1st", writer, 0x29249, 7);
                compareComposeString(ref romData, ref romData2, "treasures-Pyramid3rd4th5th", writer, 0x292B4, 15);
                compareComposeString(ref romData, ref romData2, "treasures-DreamCave1", writer, 0x2923A, 2);
                compareComposeString(ref romData, ref romData2, "treasures-DreamCave2", writer, 0x29280, 8);
                compareComposeString(ref romData, ref romData2, "treasures-WakeUpNPC", writer, 0x37786, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Aliahan", writer, 0x29255, 5);
                compareComposeString(ref romData, ref romData2, "treasures-Portoga", writer, 0x29269, 3);
                compareComposeString(ref romData, ref romData2, "treasures-RoyalScroll", writer, 0x37CB9, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Dwarf", writer, 0x2923C, 2);
                compareComposeString(ref romData, ref romData2, "treasures-Kidnappers1", writer, 0x2923E, 6);
                compareComposeString(ref romData, ref romData2, "treasures-Kidnappers2", writer, 0x2928B, 4);
                compareComposeString(ref romData, ref romData2, "treasures-BlackPepperNPC", writer, 0x377D5, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Tedan1", writer, 0x31B94, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Tedan2", writer, 0x29270, 1);
                compareComposeString(ref romData, ref romData2, "treasures-TedanGreenOrb", writer, 0x37828, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Garuna1", writer, 0x29251, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Garuna2", writer, 0x292C7, 4);
                compareComposeString(ref romData, ref romData2, "treasures-NohMask", writer, 0x292E4, 1);
                compareComposeString(ref romData, ref romData2, "treasures-PurpleOrb", writer, 0x292E7, 1);
                compareComposeString(ref romData, ref romData2, "treasures-WaterBlaster", writer, 0x377FE, 1);
                compareComposeString(ref romData, ref romData2, "treasures-PirateCove", writer, 0x29271, 3);
                compareComposeString(ref romData, ref romData2, "treasures-Eginbear", writer, 0x2925B, 1);
                compareComposeString(ref romData, ref romData2, "treasures-FinalKey", writer, 0x2922B, 1);
                compareComposeString(ref romData, ref romData2, "treasures-ArpTower", writer, 0x292CB, 7);
                compareComposeString(ref romData, ref romData2, "treasures-Soo", writer, 0x31B8C, 1);
                compareComposeString(ref romData, ref romData2, "treasures-SamanaoCave", writer, 0x29291, 23);
                compareComposeString(ref romData, ref romData2, "treasures-SamanaoCastle", writer, 0x292E5, 1);
                compareComposeString(ref romData, ref romData2, "treasures-LancelCave1", writer, 0x29244, 5);
                compareComposeString(ref romData, ref romData2, "treasures-LancelCave2", writer, 0x2928F, 2);
                compareComposeString(ref romData, ref romData2, "treasures-Luzami", writer, 0x31B97, 1);
                compareComposeString(ref romData, ref romData2, "treasures-NewTown1", writer, 0x2926C, 2);
                compareComposeString(ref romData, ref romData2, "treasures-NewTownYellowOrb", writer, 0x31B80, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Sailor'sThighNPC", writer, 0x378A9, 1);
                compareComposeString(ref romData, ref romData2, "treasures-GhostShip", writer, 0x29275, 6);
                compareComposeString(ref romData, ref romData2, "treasures-SwordOfGaia", writer, 0x31B84, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Negrogund", writer, 0x29288, 3);
                compareComposeString(ref romData, ref romData2, "treasures-SilverOrb", writer, 0x37907, 1);
                compareComposeString(ref romData, ref romData2, "treasures-LeafOfWorld", writer, 0x31B9F, 1);
                compareComposeString(ref romData, ref romData2, "treasures-SphereOfLight", writer, 0x37929, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Baramos", writer, 0x29228, 3);
                compareComposeString(ref romData, ref romData2, "treasures-SwordOfIllusion", writer, 0x37a25, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Tantegel", writer, 0x29265, 4);
                compareComposeString(ref romData, ref romData2, "treasures-Erdrick's", writer, 0x292A8, 5);
                compareComposeString(ref romData, ref romData2, "treasures-SilverHarp", writer, 0x29274, 1);
                compareComposeString(ref romData, ref romData2, "treasures-MountainCave", writer, 0x292DF, 5);
                compareComposeString(ref romData, ref romData2, "treasures-Oricon", writer, 0x31B90, 1);
                compareComposeString(ref romData, ref romData2, "treasures-FairyFlute", writer, 0x31B88, 1);
                compareComposeString(ref romData, ref romData2, "treasures-KolTower1", writer, 0x29253, 2);
                compareComposeString(ref romData, ref romData2, "treasures-KolTower2", writer, 0x292D5, 10);
                compareComposeString(ref romData, ref romData2, "treasures-SacredAmulet", writer, 0x37D5A, 1);
                compareComposeString(ref romData, ref romData2, "treasures-StaffOfRain", writer, 0x37D9D, 1);
                compareComposeString(ref romData, ref romData2, "treasures-RainbowDrop", writer, 0x37D80, 1);
                compareComposeString(ref romData, ref romData2, "treasures-Rimuldar", writer, 0x29233, 1);
                compareComposeString(ref romData, ref romData2, "treasures-ZomaCastle", writer, 0x292AD, 7);

                compareComposeString(ref romData, ref romData2, "stores", writer, 0x36838, 248, 1, "g128");

                for (int lnI = 0; lnI < 95; lnI++)
                    compareComposeString(ref romData, ref romData2, "monsterZones" + lnI.ToString("X2"), writer, (0xaeb + (15 * lnI)), 15);
                for (int lnI = 0; lnI < 20; lnI++)
                    compareComposeString(ref romData, ref romData2, "monsterSpecial" + lnI.ToString("X2"), writer, (0x107a + (6 * lnI)), 6);
                //for (int lnI = 0; lnI < 13; lnI++)
                //    compareComposeString("monsterBoss" + lnI.ToString("X2"), writer, (0x10356 + (4 * lnI)), 4);
                //compareComposeString("statStart", writer, 0x13dd1, 12);
                compareComposeString(ref romData, ref romData2, "statMult", writer, 0x281b, 10);
                compareComposeString(ref romData, ref romData2, "statUpsStrength", writer, 0x290e + 0, 40);
                compareComposeString(ref romData, ref romData2, "statUpsAgility", writer, 0x290e + 40, 40);
                compareComposeString(ref romData, ref romData2, "statUpsVitality", writer, 0x290e + 80, 40);
                compareComposeString(ref romData, ref romData2, "statUpsLuck", writer, 0x290e + 120, 40);
                compareComposeString(ref romData, ref romData2, "statUpsIntelligence", writer, 0x290e + 160, 40);

                compareComposeString(ref romData, ref romData2, "spellLearningHero", writer, 0x29d6, 63);
                compareComposeString(ref romData, ref romData2, "spellsLearnedHero", writer, 0x22E7, 32);
                compareComposeString(ref romData, ref romData2, "spellLearningPilgrim", writer, 0x2A15, 63);
                compareComposeString(ref romData, ref romData2, "spellsLearnedPilgrim", writer, 0x2307, 32);
                compareComposeString(ref romData, ref romData2, "spellLearningWizard", writer, 0x2A54, 63);
                compareComposeString(ref romData, ref romData2, "spellsLearnedWizard", writer, 0x2327, 32);
                compareComposeString(ref romData, ref romData2, "spellLearningSage", writer, 0x2A93, 63);
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
            IntensityDesc = "Comparison complete!  (DW3Compare.txt)";
        }

        public void createGuides(ref byte[] romData, ref byte[] romData2, ref string IntensityDesc, string versionNumber, string txtFileName, string txtSeed, string txtFlags, string txtCompare, bool addRemakeEquip, bool GenCompareFile)
        {
            //            if (chkRandEquip.Checked || chkRandItemEffects.Checked || chkRandWhoCanEquip.Checked)
            //            {
            string shortVersion2 = versionNumber.Replace(".", "");
            string finalFile = Path.Combine(Path.GetDirectoryName(txtFileName), "DW3R_" + txtSeed + "_" + txtFlags + "_" + shortVersion2 + "_guide.txt");

            // Totally randomize who can equip (1a3ce-1a3f0).  At least one person can equip something...
            using (StreamWriter writer = File.CreateText(finalFile))
            {
                string[] weaponText1 = { "Cypress stick", "Club", "Copper sword", "Magic Knife", "Iron Spear", "Battle Axe", "Broad Sword", "Wizard's Wand",
                        "Poison Needle", "Iron Claw", "Thorn Whip", "Giant Shears", "Chain Sickle", "Thor's Sword", "Snowblast Sword", "Demon Axe",
                        "Staff of Rain", "Sword of Gaia", "Staff of Reflection", "Sword of Destruction", "Multi - Edge Sword", "Staff of Force", "Sword of Illusion", "Zombie Slasher",
                        "Falcon Sword", "Sledge Hammer", "Thunder Sword", "Staff of Thunder", "Sword of Kings", "Orochi Sword", "Dragon Killer", "Staff of Judgement",
                        "Clothes", "Training Suit", "Leather Armor", "Flashy Clothes", "Half Plate Armor", "Full Plate Armor", "Magic Armor", "Cloak of Evasion",
                        "Armor of Radiance", "Iron Apron", "Animal Suit", "Fighting Suit", "Sacred Robe", "Armor of Hades", "Water Flying Cloth", "Chain Mail",
                        "Wayfarers Clothes", "Revealing Swimsuit", "Magic Bikini", "Shell Armor", "Armor of Terrafirma", "Dragon Mail", "Swordedge Armor", "Angel's Robe",
                        "Leather Shield", "Iron Shield", "Shield of Strength", "Shield of Heroes", "Shield of Sorrow", "Bronze Shield", "Silver Shield", "Golden Crown",
                        "Iron Helmet", "Mysterious Hat", "Unlucky Helmet", "Turban", "Noh Mask", "Leather Helmet", "Iron Mask", "Golden Claw" };

                string[] weaponText2 = { "Cypress stick", "Club", "Copper sword", "Magic Knife", "Iron Spear", "Holy Lance", "Broad Sword", "Wizard's Wand",
                        "Poison Needle", "Iron Claw", "Beast Claw", "Justice Abacus", "Chain Sickle", "Thor's Sword", "Snowblast Sword", "Demon Axe",
                        "Staff of Rain", "Sword of Gaia", "Staff of Reflection", "Sword of Destruction", "Multi - Edge Sword", "Staff of Force", "Sword of Illusion", "Zombie Slasher",
                        "Falcon Sword", "Dragon Claw", "Thunder Sword", "Staff of Thunder", "Sword of Kings", "Orochi Sword", "Dragon Killer", "Staff of Judgement",
                        "Clothes", "Training Suit", "Leather Armor", "Flashy Clothes", "Half Plate Armor", "Full Plate Armor", "Magic Armor", "Cloak of Evasion",
                        "Armor of Radiance", "Iron Apron", "Animal Suit", "Fighting Suit", "Sacred Robe", "Armor of Hades", "Water Flying Cloth", "Chain Mail",
                        "Wayfarers Clothes", "Revealing Swimsuit", "Magic Bikini", "Shell Armor", "Ninja Suit", "Dragon Mail", "Swordedge Armor", "Angel's Robe",
                        "Leather Shield", "Pot Lid", "Shield of Strength", "Shield of Heroes", "Shield of Sorrow", "Bronze Shield", "Silver Shield", "Golden Crown",
                        "Iron Helmet", "Mysterious Hat", "Unlucky Helmet", "Turban", "Noh Mask", "Leather Helmet", "Black Hood", "Golden Claw" };

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
                        if (addRemakeEquip)
                            writer.WriteLine(weaponText2[lnI].PadRight(24) + equipOut);
                        else
                            writer.WriteLine(weaponText1[lnI].PadRight(24) + equipOut);
                    }
                    else //writes out Golden Claw
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
                        if (addRemakeEquip)
                            writer.WriteLine(weaponText2[lnI].PadRight(24) + equipOut);
                        else
                            writer.WriteLine(weaponText1[lnI].PadRight(24) + equipOut);

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
            if (GenCompareFile == true)
            {
                string shortVersion = versionNumber.Replace(".", "");
                if (!loadRom(ref romData, ref romData2, txtFileName, txtCompare, true)) return;
                using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "DW3Compare_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                {
                    for (int lnI = 0; lnI < 0x8a; lnI++)
                        compareComposeString(ref romData, ref romData2, "monsters" + lnI.ToString("X2"), writer, (0x32e3 + (23 * lnI)), 23);

                    compareComposeString(ref romData, ref romData2, "itemPrice1", writer, 0x11be, 128);
                    compareComposeString(ref romData, ref romData2, "itemPrice2", writer, 0x123b, 128);
                    compareComposeString(ref romData, ref romData2, "weaponEffects", writer, 0x13280, 40);

                    compareComposeString(ref romData, ref romData2, "treasures-Promontory", writer, 0x29237, 3);
                    compareComposeString(ref romData, ref romData2, "treasures-NajimiBasement", writer, 0x2927B, 3);
                    compareComposeString(ref romData, ref romData2, "treasures-Najimi", writer, 0x292C4, 3);
                    compareComposeString(ref romData, ref romData2, "treasures-Thief'sKey", writer, 0x37DF1, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-MagicBall", writer, 0x375AA, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Invitation", writer, 0x2927E, 2);
                    compareComposeString(ref romData, ref romData2, "treasures-Kanave", writer, 0x29234, 2);
                    compareComposeString(ref romData, ref romData2, "treasures-Champange1", writer, 0x29252, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Champange2", writer, 0x292D2, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Champange3", writer, 0x292E6, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Isis", writer, 0x2925C, 9);
                    compareComposeString(ref romData, ref romData2, "treasures-IsisWizards", writer, 0x31B9C, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-GoldenClaw", writer, 0x317F4, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Pyramid1st", writer, 0x29249, 7);
                    compareComposeString(ref romData, ref romData2, "treasures-Pyramid3rd4th5th", writer, 0x292B4, 15);
                    compareComposeString(ref romData, ref romData2, "treasures-DreamCave1", writer, 0x2923A, 2);
                    compareComposeString(ref romData, ref romData2, "treasures-DreamCave2", writer, 0x29280, 8);
                    compareComposeString(ref romData, ref romData2, "treasures-WakeUpNPC", writer, 0x37786, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Aliahan", writer, 0x29255, 6);
                    compareComposeString(ref romData, ref romData2, "treasures-Portoga", writer, 0x29269, 3);
                    compareComposeString(ref romData, ref romData2, "treasures-RoyalScroll", writer, 0x37CB9, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Dwarf", writer, 0x2923C, 2);
                    compareComposeString(ref romData, ref romData2, "treasures-Kidnappers1", writer, 0x2923E, 6);
                    compareComposeString(ref romData, ref romData2, "treasures-Kidnappers2", writer, 0x2928B, 4);
                    compareComposeString(ref romData, ref romData2, "treasures-BlackPepperNPC", writer, 0x377D5, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Tedan1", writer, 0x31B94, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Tedan2", writer, 0x29270, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-TedanGreenOrb", writer, 0x37828, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Garuna1", writer, 0x29251, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Garuna2", writer, 0x292C7, 4);
                    compareComposeString(ref romData, ref romData2, "treasures-NohMask", writer, 0x292E4, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-PurpleOrb", writer, 0x292E7, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-WaterBlaster", writer, 0x377FE, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-PirateCove", writer, 0x29271, 3);
                    compareComposeString(ref romData, ref romData2, "treasures-Eginbear", writer, 0x2925B, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-FinalKey", writer, 0x2922B, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-ArpTower", writer, 0x292CB, 7);
                    compareComposeString(ref romData, ref romData2, "treasures-Soo", writer, 0x31B8C, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-SamanaoCave", writer, 0x29291, 23);
                    compareComposeString(ref romData, ref romData2, "treasures-SamanaoCastle", writer, 0x292E5, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-LancelCave1", writer, 0x29244, 5);
                    compareComposeString(ref romData, ref romData2, "treasures-LancelCave2", writer, 0x2928F, 2);
                    compareComposeString(ref romData, ref romData2, "treasures-Luzami", writer, 0x31B97, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-NewTown1", writer, 0x2926C, 2);
                    compareComposeString(ref romData, ref romData2, "treasures-NewTownYellowOrb", writer, 0x31B80, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Sailor'sThighNPC", writer, 0x378A9, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-GhostShip", writer, 0x29275, 6);
                    compareComposeString(ref romData, ref romData2, "treasures-SwordOfGaia", writer, 0x31B84, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Negrogund", writer, 0x29288, 3);
                    compareComposeString(ref romData, ref romData2, "treasures-SilverOrb", writer, 0x37907, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-LeafOfWorld", writer, 0x31B9F, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-SphereOfLight", writer, 0x37929, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Baramos", writer, 0x29228, 3);
                    compareComposeString(ref romData, ref romData2, "treasures-SwordOfIllusion", writer, 0x37a25, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Tantegel", writer, 0x29265, 4);
                    compareComposeString(ref romData, ref romData2, "treasures-Erdrick's", writer, 0x292A8, 5);
                    compareComposeString(ref romData, ref romData2, "treasures-SilverHarp", writer, 0x29274, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-MountainCave", writer, 0x292DF, 5);
                    compareComposeString(ref romData, ref romData2, "treasures-Oricon", writer, 0x31B90, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-FairyFlute", writer, 0x31B88, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-KolTower1", writer, 0x29253, 2);
                    compareComposeString(ref romData, ref romData2, "treasures-KolTower2", writer, 0x292D5, 10);
                    compareComposeString(ref romData, ref romData2, "treasures-SacredAmulet", writer, 0x37D5A, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-StaffOfRain", writer, 0x37D9D, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-RainbowDrop", writer, 0x37D80, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-Rimuldar", writer, 0x29233, 1);
                    compareComposeString(ref romData, ref romData2, "treasures-ZomaCastle", writer, 0x292AD, 7);

                    compareComposeString(ref romData, ref romData2, "stores", writer, 0x36838, 248, 1, "g128");

                    for (int lnI = 0; lnI < 95; lnI++)
                        compareComposeString(ref romData, ref romData2, "monsterZones" + lnI.ToString("X2"), writer, (0xaeb + (15 * lnI)), 15);
                    for (int lnI = 0; lnI < 20; lnI++)
                        compareComposeString(ref romData, ref romData2, "monsterSpecial" + lnI.ToString("X2"), writer, (0x107a + (6 * lnI)), 6);
                    //for (int lnI = 0; lnI < 13; lnI++)
                    //    compareComposeString("monsterBoss" + lnI.ToString("X2"), writer, (0x10356 + (4 * lnI)), 4);
                    //compareComposeString("statStart", writer, 0x13dd1, 12);
                    compareComposeString(ref romData, ref romData2, "statMult", writer, 0x281b, 10);
                    compareComposeString(ref romData, ref romData2, "statUpsStrength", writer, 0x290e + 0, 40);
                    compareComposeString(ref romData, ref romData2, "statUpsAgility", writer, 0x290e + 40, 40);
                    compareComposeString(ref romData, ref romData2, "statUpsVitality", writer, 0x290e + 80, 40);
                    compareComposeString(ref romData, ref romData2, "statUpsLuck", writer, 0x290e + 120, 40);
                    compareComposeString(ref romData, ref romData2, "statUpsIntelligence", writer, 0x290e + 160, 40);

                    compareComposeString(ref romData, ref romData2, "spellLearningHero", writer, 0x29d6, 63);
                    compareComposeString(ref romData, ref romData2, "spellsLearnedHero", writer, 0x22E7, 32);
                    compareComposeString(ref romData, ref romData2, "spellLearningPilgrim", writer, 0x2A15, 63);
                    compareComposeString(ref romData, ref romData2, "spellsLearnedPilgrim", writer, 0x2307, 32);
                    compareComposeString(ref romData, ref romData2, "spellLearningWizard", writer, 0x2A54, 63);
                    compareComposeString(ref romData, ref romData2, "spellsLearnedWizard", writer, 0x2327, 32);
                    compareComposeString(ref romData, ref romData2, "spellLearningSage", writer, 0x2A93, 63);
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
                IntensityDesc = "Comparison complete!  (DW3Compare.txt)";
            }

        }

        public int[] inverted_power_curve(int min, int max, int arraySize, double powToUse, ref Random r1)
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

        public bool loadRom(ref byte[] romData, ref byte[] romData2, string txtFileName, string txtCompare, bool extra = false)
        {
            try
            {
                romData = File.ReadAllBytes(txtFileName);
                if (extra)
                    romData2 = File.ReadAllBytes(txtCompare);
            }
            catch (Exception)
            {
                MessageBox.Show("Empty file name(s) or unable to open files.  Please verify the files exist." + txtFileName);
                return false;
            }
            return true;
        }

        private StreamWriter outputComposeString(ref byte[] romData, string intro, StreamWriter writer, int startAddress, int length, int skip = 1, int duplicate = 0)
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

        private void swap(ref byte[] romData, int firstAddress, int secondAddress)
        {
            byte holdAddress = romData[secondAddress];
            romData[secondAddress] = romData[firstAddress];
            romData[firstAddress] = holdAddress;
        }

        public int[] swapArray(int[] array, int first, int second)
        {
            int holdAddress = array[second];
            array[second] = array[first];
            array[first] = holdAddress;
            return array;
        }

        public void textGet(ref byte[] romData, string txtFileName)
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
            using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "DW3Strings.txt")))
            {
                int lnJ = 1;
                foreach (string word in txtStrings)
                {
                    writer.WriteLine(lnJ.ToString("X3") + "-" + word);
                    lnJ++;
                }
            }
        }

        public void textOutput(ref byte[] romData, ref byte[] romData2, ref string IntensityDesc, string txtFileName, string txtCompare)
        {
            randomizerTools randomizerTools = new randomizerTools();

            randomizerTools.loadRom(ref romData, ref romData2, txtFileName, txtCompare, false);
            using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "DW3TextOutput.txt")))
            {
                for (int lnI = 0; lnI < 96; lnI++)
                    outputComposeString(ref romData, "monstersZones" + (lnI).ToString("X2"), writer, (0xaeb + (15 * lnI)), 15);

                for (int lnI = 0; lnI < 19; lnI++)
                    outputComposeString(ref romData, "monstersZoneSpecial" + (lnI + 1).ToString("X2"), writer, (0x108b + (6 * lnI)), 6);

                for (int lnI = 0; lnI < 140; lnI++)
                    outputComposeString(ref romData, "monsters" + (lnI).ToString("X2"), writer, (0x32e3 + (23 * lnI)), 23);

                for (int lnI = 0; lnI < 21; lnI++)
                    outputComposeString(ref romData, "bosses" + (lnI).ToString("X2"), writer, (0x8ee + (2 * lnI)), 2, 1, 43);
            }
            IntensityDesc = "Text output complete!  (DW3TextOutput.txt)";
        }



    }
}
