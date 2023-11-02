using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer.classes
{
    public class monsters
    {
        public void randEnemyPatterns(ref byte[] romData, ref Random r1, int RmMetal)
        {
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
                                    0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6c,
                                    0x73, 0x74,
                                    // These increase the odds of receiving herbs and other items more than other items
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
                    bool rmMetalRunBool = false;
                    if (RmMetal == 1|| ((r1.Next() % 2 == 1) && RmMetal == 2))
                        rmMetalRunBool = true;
                    if (rmMetalRunBool)
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

        public void randMonsterZones(ref byte[] romData, ref Random r1, byte[] monsterOrder)
        {
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




    }
}
