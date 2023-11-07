using DW3Randomizer.classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer
{
    public class randomizeFunctions
    {
        public void dw4RNG(ref byte[] romData)
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

        public void randomizeInnPrices(ref byte[] romData, ref Random r1)
        {
            for (int lnI = 0; lnI < 26; lnI++)
            {
                int innPrice = (r1.Next() % 20) + 1;
                romData[0x367c1 + lnI] -= (byte)(romData[0x367c1 + lnI] % 32);
                romData[0x367c1 + lnI] += (byte)innPrice;
            }

        }

        public void randsagestone(ref byte[] romData, ref Random r1, int HUAStone)
        {
            int HUAStoneRandom = r1.Next() % 2;
            int HUAStoneChance = r1.Next() % 12;
            if (HUAStone == 1 || (HUAStone == 2 && HUAStoneRandom == 1) || HUAStoneChance == 10)
                romData[0x13293] = 0x1f;
        }

        public void randshoes(ref byte[] romData, ref Random r1, int BigSoHRoL)
        {
            int BigEffect = r1.Next() % 2;
            if (BigSoHRoL == 1 || (BigSoHRoL == 2 && BigEffect == 1)) // Shoes will give 11-255 exp per step
                romData[0x330fc] = (byte)((r1.Next() % 245) + 11);
            else // Shoes will give 0-10 exp per step
                romData[0x330fc] = (byte)((r1.Next() % 10) + 1);

        }

        public void randSpellStrength(ref byte[] romData, ref Random r1)
        {
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

        public void randStartGold(ref byte[] romData, ref Random r1)
        {
            // randomize starting gold
            romData[0x2914f] = (byte)((r1.Next() % 255) + 1);
        }

        public void randStores(ref byte[] romData, ref Random r1, int Acorns, int StrSeed, int AgiSeed, int VitSeed, int IntSeed,
            int LucSeed, int WorldTree, int PoisonMoth, int StoneOfLife, int Satori, int MetoriteArmband,
            int WizardRing, int EchoingFlute, int SilverHarp, int RingOfLife, int ShoesOfHappiness,
            int LampOfDarkness, int RandWeapShop, int Caturday, int RandItemShop, string txtSeed)
        {
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

            // Add Acorns of Life
            if (Acorns == 1 || (Acorns ==2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x64);

            // Add Strength Seed
            if (StrSeed == 1 || (StrSeed == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x5f);

            // Add Agility Seed
            if (AgiSeed == 1 || (AgiSeed == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x60);

            // Add Vitality Seed
            if (VitSeed == 1 || (VitSeed == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x61);

            // Add Intelligence Seed
            if (IntSeed == 1 || (IntSeed == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x62);

            // Add Luck Seed
            if (LucSeed == 1 || (LucSeed == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x63);

            // Add Leaf of the World Tree
            if (WorldTree == 1 || (WorldTree == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x69);

            // Add Poison Moth Powder
            if (PoisonMoth == 1 || (PoisonMoth == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x73);

            // Add Stone of Life
            if (StoneOfLife == 1 || (StoneOfLife == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x55);

            // Add Book of Satori
            if (Satori == 1 || (Satori == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x4c);

            // Add Meterorite Armband to Item Shop Items
            if (MetoriteArmband == 1 || (MetoriteArmband == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x4b);

            // Add Wizards Ring
            if (WizardRing == 1 || (WizardRing == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x4e);

            // Add Echoing Flute to Item Shop Items
            if (EchoingFlute == 1 || (EchoingFlute == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x6f);

            // Add Silver Harp to Item Shop Items
            if (SilverHarp == 1 || (SilverHarp == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x71);

            // Add Ring of Life to Item Shop Items
            if (RingOfLife == 1 || (RingOfLife == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x48);

            // Add Shoes of Happiness to Item Shop Items
            if (ShoesOfHappiness == 1 || (ShoesOfHappiness == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x49);

            // Add Lamp of Darkness
            if (LampOfDarkness == 1 || (LampOfDarkness == 2 && (r1.Next() % 2 == 1))) legalStoreItemsList.Add(0x53);




            int[] weaponStores = { 0x36838, 0x3683f, 0x36846, 0x3684d, 0x36854, 0x3685b, 0x36862, 0x36869, 0x3686e, 0x36874, 0x3687a, 0x36880, 0x36887, 0x3688d, 0x36893, 0x3689a, 0x368a1, 0x368a7, 0x368ae }; // 42
            int[] itemStores = { 0x368b4, 0x368b7, 0x368be, 0x368c4, 0x368ca, 0x368d0, 0x368d6, 0x368db, 0x368e0, 0x368e2, 0x368e6, 0x368ec, 0x368f2, 0x368f4, 0x368fa, 0x368ff, 0x36905, 0x36908, 0x3690e, 0x36914, 0x3691a, 0x36920, 0x36927, 0x3692b }; // 22

            if (RandWeapShop == 1 || (RandWeapShop == 2 && (r1.Next() % 2 == 1)))
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
                if (Caturday == 1 || (Caturday == 2 && (r1.Next() % 2 == 1)))
                {
                    Random caturday = new Random(int.Parse(txtSeed));

                    int[] catWeaponStores = { 0x36838, 0x3683f, 0x36846, 0x3684d, 0x36854, 0x3685b, 0x36869, 0x3686e, 0x36874, 0x36880, 0x36887, 0x3688d, 0x36893, 0x3689a, 0x368a1, 0x368a7, 0x368ae };
                    int selectStore = caturday.Next() % catWeaponStores.Length;
                    romData[catWeaponStores[selectStore]] = 0x2a;
                }
            }
            if (RandItemShop == 1 || (RandItemShop == 2 && (r1.Next() % 2 == 1)))
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


        public void randTreasures(ref byte[] romData, ref Random r1, bool disAlefgardGlitch, int RmRedKeys, int AddGoldClaw, int OrbDft, bool noLamia, bool randMap, int NoEmpty, int NoGold,
            int NoManEater, int NoMimic)
        {
            randomizerTools randomizerTools = new randomizerTools();

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
                0x29269, 0x2926a, 0x2926b }; // Portoga -> Royal Scroll - 20 - 58
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

            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ0);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ1);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ2);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ3);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ4);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ5);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ6);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ7);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ8);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ9);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ10);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ11);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ12);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ13);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ14);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ15);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ16);
            allTreasureList = randomizerTools.addTreasure(allTreasureList, treasureAddrZ17);

            int[] allTreasure = allTreasureList.ToArray();

            List<byte> treasureList = new List<byte>();
            List<byte> legalTreasuresList = new List<byte>();
            byte[] legalEquipment = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f,
                                          0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a, 0x1b, 0x1c, 0x1d, 0x1e, 0x1f,
                                          0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f,
                                          0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f,
                                          0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x48, 0x49, 0x4b, 0x4c, 0x4e,
                                          0x55, 0x56, 0x5e, 0x5f };
            byte[] legalItems = {0x60, 0x62, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6c,
                                          0x73, 0x74 };
            byte[] goldChests = { 0x88, 0x90, 0x98, 0xa0, 0xa8, 0xb0, 0xb8, 0xc0, 0xc8, 0xd0, 0xd8, 0xe0, 0xe8, 0xf0, 0xf8 };
            
            /*
            byte[] maneaterchests = { 0xfd };
            byte[] mimicChests = { 0xfe };
            byte[] emptyChests = { 0xff };
            */

            // Populate legalTreasuresList so we can add additional items if selected (First half)
            for (int lnI = 0; lnI < legalEquipment.Length; lnI++)
            {
                legalTreasuresList.Add(legalEquipment[lnI]);
            }
            // Populate legalTreasuresList so we can add additional items if selected (Second half)
            for (int lnI = 0; lnI < legalItems.Length; lnI++)
            {
                legalTreasuresList.Add(legalItems[lnI]);
            }

            // If No Gold Chests is unchecked or Indeterminate and Random 0, add Gold Chests to the Treasure Pool
            if (NoGold == 0 || (NoGold == 2 && r1.Next() % 2 == 0))
            {
                for (int lnI = 0; lnI < goldChests.Length; lnI++)
                {
                    legalTreasuresList.Add(goldChests[lnI]);
                }
            }

            int localNoEmpty = 0;
            int localNoManEater = 0;
            int localNoMimic = 0;

            if (NoEmpty == 1 || (NoEmpty == 2 && r1.Next() % 2 == 1)) 
                localNoEmpty = 1;
            if (NoManEater == 1 || (NoManEater == 2 && r1.Next() % 2 == 1))
                localNoManEater = 1;
            if (NoMimic == 1 || (NoMimic == 2 && r1.Next() % 2 == 1))
                localNoMimic = 1;

            for (int lnI = 0; lnI < 5; lnI++)
            {
                if (localNoManEater == 0)
                    legalTreasuresList.Add(0xfd);
                if (localNoMimic == 0)
                    legalTreasuresList.Add(0xfe);
                if (localNoEmpty == 0)
                    legalTreasuresList.Add(0xff);
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
            if (disAlefgardGlitch == true) // Put Wing Of Wyvern in 3 chests in Baramos' Castle
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
            bool rmRedKey = false;
            bool addGoldClaw = false;
            bool defaultOrb = false;

            if (RmRedKeys == 1 || ((r1.Next() % 2 == 1) && RmRedKeys == 2))
                rmRedKey = true;
            if (AddGoldClaw == 1 || ((r1.Next() % 2 == 1) && AddGoldClaw == 2))
                addGoldClaw = true;
            if (OrbDft == 1 || ((r1.Next() % 2 == 1) && OrbDft == 2))
                defaultOrb = true;

            for (int lnJ = 0; lnJ < keyItems.Length; lnJ++)
            {
                int treasureLocation = 0;
                int index = 0;
                if (noLamia)
                {
                    if (keyItems[lnJ] >= 0x77 && keyItems[lnJ] <= 0x7c)
                    {
                        continue;
                    }
                }
                if (randMap)
                {
                    if (lnJ == 13 || lnJ == 18)
                    {

                    }
                    if (defaultOrb && lnJ == 13) // Silver Orb
                    {
                        treasureLocation = allTreasure[minKeyTreasure[lnJ] + (r1.Next() % ((maxKeyTreasure[lnJ] + 2) - minKeyTreasure[lnJ]))];
                        if (treasureLocation == 134)
                        {
                            lnJ--;
                            continue;
                        }
                    }
                    else if (defaultOrb && lnJ == 18) // Green Orb
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
                        if (rmRedKey)
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
                }
                else
                {
                    if (rmRedKey)
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

                if (randMap && lnJ == 4)
                {
                    continue; // Does not add Vase of Draught to treasure pool when map is randomized
                }
                if (addGoldClaw == false && lnJ == 22)
                {
                    continue; // Does not add Golden Claw if off or random off
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
                        echoLocations = new byte[] { 0x29, 0x96, 0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x87 }; // Isis
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



    }
}
