using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW3Randomizer.classes
{
    public class partyAndJobChange
    {
        public void chngDftParty(ref byte[] romData, int Class1, int Class2, int Class3, int Gender1, int Gender2, int Gender3, string ChName1, string ChName2, string ChName3, string versionNumber)
        {
            // Force the same three names to be selected in the opening Lucia's Eatery
            romData[0x1e9f8] = 0x29;
            romData[0x1e9f9] = 0x00;


            // Rename the starting characters.
            for (int lnI = 0; lnI < 3; lnI++)
            {
                byte value;
                byte gender;

                value = (byte)(lnI == 0 ? Class1 : lnI == 1 ? Class2 : Class3);

                byte intValue = (byte)(value == 0 ? 4 : value == 1 ? 2 : value == 2 ? 1 : value == 3 ? 6 : value == 4 ? 5 : value == 5 ? 7 : value == 6 ? 3 : 0);

                gender = (byte)(lnI == 0 ? Gender1 : lnI == 1 ? Gender2 : Gender3);

                romData[0x1ed4f + lnI] = (byte)(intValue + (gender == 0 ? 0 : 8));
            }

            for (int lnI = 0; lnI < 3; lnI++)
            {
                string name = (lnI == 0 ? ChName1 : lnI == 1 ? ChName2 : ChName3);
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
//                romtools.saveRom(false, versionNumber);
            }

        }

        public void fourJobFiesta(ref byte[] romData)
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

        public bool randomizeClass(string txtSeed, ref int c1, ref int c2, ref int c3, bool Class1Rand, bool Class2Rand, bool Class3Rand, ref bool randClass, bool RandSoldier,
            bool RandPilgrim, bool RandWizard, bool RandFighter, bool RandMerchant, bool RandGoofOff, bool RandSage, bool RandHero)
        {
            Random r2 = new Random(int.Parse(txtSeed));

            randClass = true;

            int[] availableClasses = new int[8];
            int stringIndex = 0;

            if (RandSoldier == true)
            {
                availableClasses[stringIndex] = 0;
                stringIndex += 1;
            }

            if (RandPilgrim == true)
            {
                availableClasses[stringIndex] = 1;
                stringIndex += 1;
            }

            if (RandWizard == true)
            {
                availableClasses[stringIndex] = 2;
                stringIndex += 1;
            }

            if (RandFighter == true)
            {
                availableClasses[stringIndex] = 3;
                stringIndex += 1;
            }

            if (RandMerchant == true)
            {
                availableClasses[stringIndex] = 4;
                stringIndex += 1;
            }

            if (RandGoofOff == true)
            {
                availableClasses[stringIndex] = 5;
                stringIndex += 1;
            }

            if (RandSage == true)
            {
                availableClasses[stringIndex] = 6;
                stringIndex += 1;
            }

            if (RandHero == true)
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
            int crand1 = r2.Next() % stringIndex;
            int crand2 = r2.Next() % stringIndex;
            int crand3 = r2.Next() % stringIndex;
            if (Class1Rand) c1 = availableClasses[crand1];
            if (Class2Rand) c2 = availableClasses[crand2];
            if (Class3Rand) c3 = availableClasses[crand3];
            return true;
        }

        public void randomizeGender(string txtSeed, ref int Gender1, ref int Gender2, ref int Gender3, bool Gender1Rand, bool Gender2Rand, bool Gender3Rand)
        {
            Random r2 = new Random((int)long.Parse(txtSeed));
            int g1 = r2.Next() % 2;
            int g2 = r2.Next() % 2;
            int g3 = r2.Next() % 2;

            if (Gender1Rand)
            {
                if (g1 == 0)
                {
                    Gender1 = 0;
                }
                else
                {
                    Gender1 = 1;
                }
            }

            if (Gender2Rand)
            {
                if (g2 == 0)
                {
                    Gender2 = 0;
                }
                else
                {
                    Gender2 = 1;
                }
            }

            if (Gender3Rand)
            {
                if (g3 == 0)
                {
                    Gender3 = 0;
                }
                else
                {
                    Gender3 = 1;
                }
            }
        }

        public void randomizeNames(string txtSeed, ref string ChName1, ref string ChName2, ref string ChName3, bool ChName1Rand, bool ChName2Rand, bool ChName3Rand,
    int Gender1, int Gender2, int Gender3)
        {
            Random r2 = new Random(int.Parse(txtSeed));

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
                "Minnie", "Medea", "Vistalia", "Mia"};

            int maleNameCount = maleNames.Length;
            int femaleNameCount = femaleNames.Length;

            int mindex1 = r2.Next() % maleNameCount;
            int mindex2 = r2.Next() % maleNameCount;
            int mindex3 = r2.Next() % maleNameCount;

            int findex1 = r2.Next() % femaleNameCount;
            int findex2 = r2.Next() % femaleNameCount;
            int findex3 = r2.Next() % femaleNameCount;

            // Reroll male index if any of the values are the same (don't want characters with the same name)
            while (mindex1 == mindex2 || mindex1 == mindex3 || mindex2 == mindex3)
            {
                mindex1 = r2.Next() % maleNameCount;
                mindex2 = r2.Next() % maleNameCount;
                mindex3 = r2.Next() % maleNameCount;
            }

            // Reroll female index if any of the values are the same (don't want characters with the same name)
            while (findex1 == findex2 || findex1 == findex3 || findex2 == findex3)
            {
                findex1 = r2.Next() % femaleNameCount;
                findex2 = r2.Next() % femaleNameCount;
                findex3 = r2.Next() % femaleNameCount;
            }

            if (ChName1Rand)
            {
                if (Gender1 == 0)
                {
                    ChName1 = maleNames[mindex1];
                }
                else
                {
                    ChName1 = femaleNames[findex1];
                }
            }

            if (ChName2Rand)
            {
                if (Gender2 == 0)
                {
                    ChName2 = maleNames[mindex2];
                }
                else
                {
                    ChName2 = femaleNames[findex2];
                }
            }

            if (ChName3Rand)
            {
                if (Gender3 == 0)
                {
                    ChName3 = maleNames[mindex3];
                }
                else
                {
                    ChName3 = femaleNames[findex3];
                }
            }
        }

        public void randSpellLearning(ref byte[] romData, ref Random r1, ref int[] heroComSpell, ref int[] heroComLvl, ref int[] heroBatSpell, ref int[] heroBatLvl, ref int[] pilgrimComSpell, ref int[] pilgrimComLvl,
            ref int[] pilgrimBatSpell, ref int[] pilgrimBatLvl, ref int[] wizardComSpell, ref int[] wizardComLvl, ref int[] wizardBatSpell, ref int[] wizardBatLvl)
        {
            randomizerTools randomizerTools = new randomizerTools();
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
                randomizerTools.swapArray(fightSpells, (r1.Next() % fightSpells.Length), (r1.Next() % fightSpells.Length));
            for (int lnI = 0; lnI < commandSpells.Length * 20; lnI++)
                randomizerTools.swapArray(commandSpells, (r1.Next() % commandSpells.Length), (r1.Next() % commandSpells.Length));

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

            int[] heroFightLevels = randomizerTools.inverted_power_curve(1, 35, 24, 1, ref r1);
            int[] pilgrimFightLevels = randomizerTools.inverted_power_curve(1, 35, 24, 1, ref r1);
            int[] wizardFightLevels = randomizerTools.inverted_power_curve(1, 35, 24, 1, ref r1);
            int[] heroCommandLevels = randomizerTools.inverted_power_curve(1, 35, 8, 1, ref r1);
            int[] pilgrimCommandLevels = randomizerTools.inverted_power_curve(1, 35, 8, 1, ref r1);
            int[] wizardCommandLevels = randomizerTools.inverted_power_curve(1, 35, 8, 1, ref r1);

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



    }
}
