using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer
{
    public class partyStatChange
    {
        public void doubleattack(ref byte[] romData)
        {
            romData[0x115f8] = 0x00;
        }

        public void nonMagicMP(ref byte[] romData)
        {
            romData[0x2540] = 0x08;
        }
        
        public void randStatGains(ref byte[] romData, ref Random r1, bool RandStatsSilly, bool RandStatsRid, bool RandStatsLud, bool RandStatsRand)
        {
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

            int randomstate = 0;
            if (RandStatsSilly) randomstate = 1;
            else if (RandStatsRid) randomstate = 2;
            else if (RandStatsLud) randomstate = 3;
            else if (RandStatsRand) randomstate = (r1.Next() % 3) + 1;

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
                    if (randomstate == 1 || randomstate == 2)
                    {
                        int randomDir = (r1.Next() % 3);
                        int difference = heroL41Gains[lnI, lnJ] / (RandStatsSilly ? 4 : 2);
                        if (randomDir == 0)
                            heroL41Gains[lnI, lnJ] -= (r1.Next() % difference);
                        if (randomDir == 1)
                            heroL41Gains[lnI, lnJ] += (r1.Next() % difference);
                    }
                    if (randomstate == 3)
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

        public void removeFightPenalty(ref byte[] romData)
        {
            romData[0x1507] = romData[0x1508] = romData[0x1509] = romData[0x150a] = 0xea;
        }


    }
}
