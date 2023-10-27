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

        public void randEquip(ref byte[] romData, ref Random r1, bool AdjStartEqOn, bool AdjStartEqRand, bool VanEqValOn, bool VanEqValRand, bool addRemakeEquip, bool adjustEquipmentPrice)
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

            if (AdjStartEqOn || ((r1.Next() % 2 == 1) && AdjStartEqRand)) removeStartEqRestrictions = true;
            if (VanEqValOn || ((r1.Next() % 2 == 1) && VanEqValRand)) useVanilla = true;

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
        }

    }
}
