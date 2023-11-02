using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer
{
    public class itemsAndequipment
    {

        public void adjustEqPrices(ref byte[] romData, int lnI, int power)
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
            /*
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
            */
        }

        public void changeRemakeEq(ref byte[] romData, out bool addRemakeEquip, bool dispEqPower, bool adjustEquipmentPrice, bool randClass)
        {
            textchange textchange = new textchange();
            addRemakeEquip = true;
            if (dispEqPower)
            {
                textchange.convertStrToHex("HlyLnc", 0xad30, false, ref romData);
                textchange.convertStrToHex("BstCl", 0xad50, true, ref romData);
                textchange.convertStrToHex("JustAb", 0xad56, true, ref romData);
                textchange.convertStrToHex("DrgClaw", 0xadbf, true, ref romData);
                textchange.convertStrToHex("NinjaSuit", 0xaea3, true, ref romData);
                textchange.convertStrToHex("Pot Lid", 0xaecf, true, ref romData);
                textchange.convertStrToHex("BlkHd", 0xaf35, true, ref romData);
            }
            else
            {
                // First line of equipment names
                textchange.convertStrToHex("Holy&Broad&Wizard^s&Poison&Iron&Beast&Justice", 0xad30, false, ref romData);
                textchange.convertStrToHex("Dragon&Thunder&Staff$of&Sword$of&Orochi&Dragon&Staff$of&Clothes&Trainging&Leather&Flashy&Half$Plate&Full$Plate&Magic&Cloak$of&Armor$of&Water$Flying&Chain&Wayfarer^s&Revealing&Magic&Shell&Ninja&Dragon&Swordedge&Angel^s&Leather&Pot&Shield$of&Shield$of&Bronze&Silver&Golden&$$$$", 0xadca, false, ref romData);
                textchange.convertStrToHex("Unluck&Turban&Noh&Leather&Black", 0xaf1b, false, ref romData);

                // Second line of equipment names
                textchange.convertStrToHex("Lance&Sword&Wand&Needle&Claw&Claw&Abacus&Sickle&Sword&Sword&Axe&Rain&Gaia&Reflection&Destruction&Sword&Force&Illusion&Slasher&Sword&Claw", 0xb0f9, false, ref romData);
                textchange.convertStrToHex("Suit&Mail&Armor&Robe&Shield&Lid&Strength&Heroes&Sorrow&Shield&Shield&Crown&$$$$$$$$$", 0xb227, false, ref romData);
                textchange.convertStrToHex("Hood", 0xb29a, false, ref romData);
            }

            int[] prices = { 2300, 24000, 25000, 17000, 4200, 50, 1200 };
            int[] itemToChange = { 0x05, 0x0a, 0x0b, 0x19, 0x34, 0x39, 0x46 };
            int[] powers = { 35, 95, 110, 85, 58, 2, 18 };
            int[] whocanequip = { 0x0c, 0x40, 0x20, 0x40, 0x40, 0xff, 0x40 };
            int[] effect = { 0x01, 0x01, 0x01, 0x01, 0x1d, 0x01, 0x01 };

            int price = 0;

            if (adjustEquipmentPrice == false)
            {
                for (int lnI = 0; lnI < itemToChange.Length; lnI++)
                {
                    romData[0x11be + itemToChange[lnI]] -= (byte)(romData[0x11be + itemToChange[lnI]] % 4);
                    price = prices[lnI];
                    //                int priceToUse = (romData[0x123b + itemstoAdjust[lnI]] >= 128 ? romData[0x123b + itemstoAdjust[lnI]] - 128 : romData[0x123b + itemstoAdjust[lnI]]);
                    if (price >= 10000)
                    {
                        romData[0x11be + itemToChange[lnI]] += 3; // Now multiply by 1000
                        romData[0x123b + itemToChange[lnI]] = (byte)(romData[0x123b + itemToChange[lnI]] >= 128 ? (price / 1000) + 128 : price / 1000);
                    }
                    else if (price >= 1000)
                    {
                        romData[0x11be + itemToChange[lnI]] += 2; // Now multiply by 100
                        romData[0x123b + itemToChange[lnI]] = (byte)(romData[0x123b + itemToChange[lnI]] >= 128 ? (price / 100) + 128 : price / 100);
                    }
                    else if (price >= 100)
                    {
                        romData[0x11be + itemToChange[lnI]] += 1; // Now multiply by 10
                        romData[0x123b + itemToChange[lnI]] = (byte)(romData[0x123b + itemToChange[lnI]] >= 128 ? (price / 10) + 128 : price / 10);
                    }
                    else
                    {
                        romData[0x123b + itemToChange[lnI]] = (byte)(romData[0x123b + itemToChange[lnI]] >= 128 ? price + 128 : price);
                    }
                }
            }

            if (randClass)
            {
                for (int lnI = 0; lnI < itemToChange.Length; lnI++)
                {
                    romData[0x1147 + itemToChange[lnI]] = (byte)whocanequip[lnI];
                    if (romData[0x1196 + itemToChange[lnI]] != 255 && romData[0x1196 + itemToChange[lnI]] != 0 && itemToChange[lnI] < 32)
                        romData[0x1196 + itemToChange[lnI]] = (byte)whocanequip[lnI];
                }
            }
        }

        public void forceItemSell(ref byte[] romData, ref Random r1)
        {
            int[] forcedItemSell = { 0x16, 0x1c, 0x28, 0x32, 0x34, 0x36, 0x3b, 0x3f, 0x42, 0x48, 0x4b, 0x4c, 0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x58, 0x59, 0x5b, 0x5c, 0x5d, 0x5e, 0x69, 0x6b, 0x6e, 0x6f, 0x70, 0x71 };
            for (int lnI = 0; lnI < forcedItemSell.Length; lnI++)
                if (romData[0x11be + forcedItemSell[lnI]] % 32 >= 16) // Not allowed to be sold
                    romData[0x11be + forcedItemSell[lnI]] -= 16; // Now allowed to be sold!

            int[] itemstoAdjust = { 0x16, 0x1c, 0x28, 0x32, 0x34, 0x36, 0x3b, 0x3f, 0x42, 0x48, 0x49, 0x4b, 0x4c, 0x50, 0x52, 0x53, 0x58, 0x59, 0x5a, 0x69, 0x6f, 0x70, 0x71, // forced items to sell AND...
               0x5f, 0x60, 0x61, 0x62, 0x63, 0x64, 0x57, 0x75, 0x55, 0x4e, 0x4f, 0x49, 0x5b, 0x5c, 0x5d, 0x6b, 0x6e, 0x51, 0x54 }; // Some other items I want sold (see above)

            int[] itemPriceAdjust = { 5000, 35000, 15000, 10000, 8000, 12000, 10000, 800, 10, 5000, 5000, 5000, 8000, 20000, 1000, 1000, 500, 2000, 5000, 5000, 500, 2000, 500,
                5000, 3000, 2000, 2500, 2500, 5000, 800, 10000, 3000, 2000, 10000, 5000, 1000, 500, 500, 500, 500, 500, 500 };

            int price = 0;

            for (int lnI = 0; lnI < itemstoAdjust.Length; lnI++)
            {
                // Remove any price adjustment first.
                romData[0x11be + itemstoAdjust[lnI]] -= (byte)(romData[0x11be + itemstoAdjust[lnI]] % 4);
                if (itemstoAdjust[lnI] == 0x5b)
                {
                    price = 1000 * ((r1.Next() % 10) + 1);
                }
                else if (itemstoAdjust[lnI] == 0x49)
                {
                    int priceoffset = Convert.ToInt32(romData[0x330fc]);
                    price = itemPriceAdjust[lnI] + priceoffset;
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

        public void heroitems(ref byte[] romData, ref Random r1)
        {
            // Gives party of a random consumable item
            int heroitem = r1.Next() % 7;
            switch (heroitem)
            {
                case 0:
                    romData[0x1ef20] = 0x56; // Invis Herb
                    break;
                case 1:
                    romData[0x1ef20] = 0x65; // Medical Herb
                    break;
                case 2:
                    romData[0x1ef20] = 0x66; // Antidote Herb
                    break;
                case 3:
                    romData[0x1ef20] = 0x67; // Fairy Water
                    break;
                case 4:
                    romData[0x1ef20] = 0x68; // Wing of Wyvern;
                    break;
                case 5:
                    romData[0x1ef20] = 0x73; // Poison Moth Powder
                    break;
                case 6:
                    romData[0x1ef20] = 0x74; // Spiders Web
                    break;
            }
        }

        public void randEquip(ref byte[] romData, ref Random r1, int AdjStartEq, int VanEqVal, bool addRemakeEquip, bool adjustEquipmentPrice)
        {
            itemsAndequipment itemsAndequipment = new itemsAndequipment();
            // Totally randomize weapons, armor, shields, helmets (13efb-13f1d, 1a00e-1a08b for pricing)

            // Used if chk_UseVanEquipValues
            int[] attackPower = { 2, 7, 12 };
            int[] attackPower2 = { 14, 28, 40, 34, 15, 10, 30, 18, 48, 24, 100, 80, 90, 16, 48, 33, 110, 100, 55, 50, 65, 5, 55, 85, 30, 120, 63, 77, 35, 55 }; //20
            int[] armorDefPower = { 4, 8, 12 };
            int[] armorDefPower2 = { 10, 28, 25, 32, 40, 20, 75, 22, 8, 23, 30, 65, 40, 20, 2, 40, 16, 50, 45, 55, 35 }; //38
            int[] shieldDefPower = { 4, 12, 40, 50, 35, 7, 30 }; //45
            int[] helmetDefPower = { 6, 16, 10, 35, 8, 45, 2, 25 };

            List<int> attackPowerList = new List<int>(attackPower);
            List<int> attackPowerList2 = new List<int>(attackPower2);
            List<int> armorDefPowerList = new List<int>(armorDefPower);
            List<int> armorDefPowerList2 = new List<int>(armorDefPower2);
            List<int> shieldDefPowerList = new List<int>(shieldDefPower);
            List<int> helmetDefPowerList = new List<int>(helmetDefPower);

            bool removeStartEqRestrictions = false;
            bool useVanilla = false;

            if (AdjStartEq == 1 || ((r1.Next() % 2 == 1) && AdjStartEq == 2)) removeStartEqRestrictions = true;
            if (VanEqVal == 1 || ((r1.Next() % 2 == 1) && VanEqVal == 2)) useVanilla = true;

            if (addRemakeEquip)
            {
                attackPowerList2[2] = 35;
                attackPowerList2[7] = 95;
                attackPowerList2[8] = 110;
                attackPowerList2[16] = 85;
                armorDefPowerList2[17] = 58;
                shieldDefPowerList[1] = 2;
                helmetDefPowerList[7] = 18;
            }
            if (removeStartEqRestrictions)
            {
                for (int lnI = 0; lnI < attackPower2.Length; lnI++)
                    attackPowerList.Add(attackPower2[lnI]);
                for (int lnI = 0; lnI < armorDefPower2.Length; lnI++)
                    armorDefPowerList.Add(armorDefPower2[lnI]);
            }


            for (int lnI = 0; lnI <= 70; lnI++)
            {
                byte power = 0;

                if (removeStartEqRestrictions)
                {
                    if (useVanilla)
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
                            while (power < 2)
                                power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 243252); // max 130
                        else if (lnI < 56)
                            while (power < 2)
                                power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 395284); // max 80
                        else if (lnI < 63)
                            while (power < 2)
                                power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 574959); // max 55
                        else
                            while (power < 2)
                                power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 903507); // max 35
                    }
                }
                else
                {
                    if (useVanilla) // Randomize the values of starting equipment separately from all equipment
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
                            while (power < 2)
                                power = (byte)(r1.Next() % 12);
                        else if (lnI < 32)
                            while (power < 2)
                                power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 243252); // max 130
                        else if (lnI < 56)
                            while (power < 2)
                                power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 395284); // max 80
                        else if (lnI < 63)
                            while (power < 2)
                                power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 574959); // max 55
                        else
                            while (power < 2)
                                power = (byte)(Math.Pow(r1.Next() % 1000, 2.5) / 903507); // max 35
                    }
                }
                romData[0x279a0 + lnI] = power;

                if (adjustEquipmentPrice) itemsAndequipment.adjustEqPrices(ref romData, lnI, power);

                if (lnI < 80)
                {
                    if (lnI <= 2)
                    {
                        if ((romData[0x123b + lnI] % 16) >= 8)
                            romData[0x123b + lnI] -= (byte)((romData[0x123b + lnI] % 8) + 1);
                    }
                }
            }
            /*        private void randItemEffects(int rni)
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
*/
        }

        public void whoCanEquip(ref byte[] romData, ref Random r1)
        {
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

    }
}
