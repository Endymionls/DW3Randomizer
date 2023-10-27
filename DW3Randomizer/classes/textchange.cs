using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer
{
    public class textchange
    {
        public void changeEnd(ref byte[] romData)
        {
            textchange textchange = new textchange();

            convertStrToHex("0Thus, ", 0x29536, false, ref romData);
            romData[0x2953d] = 0xf0; // Hero 8 Char
            convertStrToHex(" became known", 0x2953e, true, ref romData);
            convertStrToHex(" as Erdrick in some stories and", 0x2954c, true, ref romData);
            convertStrToHex(" Loto in others.", 0x2956c, true, ref romData);
            convertStrToHex("  ", 0x2957d, true, ref romData);
            convertStrToHex("  ", 0x29580, true, ref romData);
            convertStrToHex("0After a while, our hero and", 0x29583, true, ref romData);
            convertStrToHex(" the rest of the party went", 0x295a0, true, ref romData);
            convertStrToHex(" their separate ways.", 0x295bc, true, ref romData);
            convertStrToHex("  ", 0x295d2, true, ref romData);
            convertStrToHex("0The hero^s sword, armor, and", 0x295d5, true, ref romData);
            convertStrToHex(" amulet were left behind for", 0x295f3, true, ref romData);
            convertStrToHex(" future generations bearing", 0x29610, true, ref romData);
            convertStrToHex(" the name Erdrick.", 0x2962c, true, ref romData);
            convertStrToHex("  ", 0x2963f, true, ref romData);
            convertStrToHex("0Unfortunately, records of", 0x29642, true, ref romData);
            convertStrToHex(" Erdrick^s party were lost", 0x2965d, true, ref romData);
            convertStrToHex(" with time.", 0x29678, true, ref romData);
            convertStrToHex("  ", 0x29684, true, ref romData);
            convertStrToHex(" Dragon Warrior III Randomizer", 0x29687, true, ref romData);
            convertStrToHex("  ", 0x296a6, true, ref romData);
            convertStrToHex("0Originally Developed By:", 0x296a9, true, ref romData);
            convertStrToHex("0 gameboyf9", 0x296c3, true, ref romData);
            convertStrToHex("  ", 0x296cf, true, ref romData);
            convertStrToHex("0Currently Developed By:", 0x296d2, true, ref romData);
            convertStrToHex("0 endymionls", 0x296eb, true, ref romData);
            convertStrToHex("  ", 0x296f8, true, ref romData);
            convertStrToHex("0                      ", 0x296fb, true, ref romData);
            convertStrToHex("            ", 0x29713, true, ref romData);
            convertStrToHex("Thank you for playing!     ", 0x1f777, false, ref romData);
        }

        public int convertChartoInt(char character)
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

        public string convertIntToChar(int number)
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

        public void convertStrToHex(string textToConvert, int startaddress, bool needBreak, ref byte[] romData)
        {
            int offset = 0;
            char[] characterArray = textToConvert.ToCharArray();
            foreach (char c in textToConvert)
            {
                switch (c)
                {
                    case ' ':
                        romData[startaddress + offset] = 0x00;
                        break;
                    case '0':
                        romData[startaddress + offset] = 0x01;
                        break;
                    case '1':
                        romData[startaddress + offset] = 0x02;
                        break;
                    case '2':
                        romData[startaddress + offset] = 0x03;
                        break;
                    case '3':
                        romData[startaddress + offset] = 0x04;
                        break;
                    case '4':
                        romData[startaddress + offset] = 0x05;
                        break;
                    case '5':
                        romData[startaddress + offset] = 0x06;
                        break;
                    case '6':
                        romData[startaddress + offset] = 0x07;
                        break;
                    case '7':
                        romData[startaddress + offset] = 0x08;
                        break;
                    case '8':
                        romData[startaddress + offset] = 0x09;
                        break;
                    case '9':
                        romData[startaddress + offset] = 0x0a;
                        break;
                    case 'a':
                        romData[startaddress + offset] = 0x0b;
                        break;
                    case 'b':
                        romData[startaddress + offset] = 0x0c;
                        break;
                    case 'c':
                        romData[startaddress + offset] = 0x0d;
                        break;
                    case 'd':
                        romData[startaddress + offset] = 0x0e;
                        break;
                    case 'e':
                        romData[startaddress + offset] = 0x0f;
                        break;
                    case 'f':
                        romData[startaddress + offset] = 0x10;
                        break;
                    case 'g':
                        romData[startaddress + offset] = 0x11;
                        break;
                    case 'h':
                        romData[startaddress + offset] = 0x12;
                        break;
                    case 'i':
                        romData[startaddress + offset] = 0x13;
                        break;
                    case 'j':
                        romData[startaddress + offset] = 0x14;
                        break;
                    case 'k':
                        romData[startaddress + offset] = 0x15;
                        break;
                    case 'l':
                        romData[startaddress + offset] = 0x16;
                        break;
                    case 'm':
                        romData[startaddress + offset] = 0x17;
                        break;
                    case 'n':
                        romData[startaddress + offset] = 0x18;
                        break;
                    case 'o':
                        romData[startaddress + offset] = 0x19;
                        break;
                    case 'p':
                        romData[startaddress + offset] = 0x1a;
                        break;
                    case 'q':
                        romData[startaddress + offset] = 0x1b;
                        break;
                    case 'r':
                        romData[startaddress + offset] = 0x1c;
                        break;
                    case 's':
                        romData[startaddress + offset] = 0x1d;
                        break;
                    case 't':
                        romData[startaddress + offset] = 0x1e;
                        break;
                    case 'u':
                        romData[startaddress + offset] = 0x1f;
                        break;
                    case 'v':
                        romData[startaddress + offset] = 0x20;
                        break;
                    case 'w':
                        romData[startaddress + offset] = 0x21;
                        break;
                    case 'x':
                        romData[startaddress + offset] = 0x22;
                        break;
                    case 'y':
                        romData[startaddress + offset] = 0x23;
                        break;
                    case 'z':
                        romData[startaddress + offset] = 0x24;
                        break;
                    case 'A':
                        romData[startaddress + offset] = 0x25;
                        break;
                    case 'B':
                        romData[startaddress + offset] = 0x26;
                        break;
                    case 'C':
                        romData[startaddress + offset] = 0x27;
                        break;
                    case 'D':
                        romData[startaddress + offset] = 0x28;
                        break;
                    case 'E':
                        romData[startaddress + offset] = 0x29;
                        break;
                    case 'F':
                        romData[startaddress + offset] = 0x2a;
                        break;
                    case 'G':
                        romData[startaddress + offset] = 0x2b;
                        break;
                    case 'H':
                        romData[startaddress + offset] = 0x2c;
                        break;
                    case 'I':
                        romData[startaddress + offset] = 0x2d;
                        break;
                    case 'J':
                        romData[startaddress + offset] = 0x2e;
                        break;
                    case 'K':
                        romData[startaddress + offset] = 0x2f;
                        break;
                    case 'L':
                        romData[startaddress + offset] = 0x30;
                        break;
                    case 'M':
                        romData[startaddress + offset] = 0x31;
                        break;
                    case 'N':
                        romData[startaddress + offset] = 0x32;
                        break;
                    case 'O':
                        romData[startaddress + offset] = 0x33;
                        break;
                    case 'P':
                        romData[startaddress + offset] = 0x34;
                        break;
                    case 'Q':
                        romData[startaddress + offset] = 0x35;
                        break;
                    case 'R':
                        romData[startaddress + offset] = 0x36;
                        break;
                    case 'S':
                        romData[startaddress + offset] = 0x37;
                        break;
                    case 'T':
                        romData[startaddress + offset] = 0x38;
                        break;
                    case 'U':
                        romData[startaddress + offset] = 0x39;
                        break;
                    case 'V':
                        romData[startaddress + offset] = 0x3a;
                        break;
                    case 'W':
                        romData[startaddress + offset] = 0x3b;
                        break;
                    case 'X':
                        romData[startaddress + offset] = 0x3c;
                        break;
                    case 'Y':
                        romData[startaddress + offset] = 0x3d;
                        break;
                    case 'Z':
                        romData[startaddress + offset] = 0x3e;
                        break;
                    case '$':
                        romData[startaddress + offset] = 0x50;
                        break;
                    case '}':
                        romData[startaddress + offset] = 0x60;
                        break;
                    case '"':
                        romData[startaddress + offset] = 0x65;
                        break;
                    case '^':
                        romData[startaddress + offset] = 0x68;
                        break;
                    case '.':
                        romData[startaddress + offset] = 0x6c;
                        break;
                    case ',':
                        romData[startaddress + offset] = 0x6a;
                        break;
                    case '(':
                        romData[startaddress + offset] = 0x6d;
                        break;
                    case ')':
                        romData[startaddress + offset] = 0x6e;
                        break;
                    case '?':
                        romData[startaddress + offset] = 0x6f;
                        break;
                    case '!':
                        romData[startaddress + offset] = 0x70;
                        break;
                    case ';':
                        romData[startaddress + offset] = 0x71;
                        break;
                    case ':':
                        romData[startaddress + offset] = 0x75;
                        break;
                    case '{':
                        romData[startaddress + offset] = 0xc0;
                        break;
                    case '@':
                        romData[startaddress + offset] = 0xee;
                        break;
                    case '<':
                        romData[startaddress + offset] = 0xf4;
                        break;
                    case '[':
                        romData[startaddress + offset] = 0xf5;
                        break;
                    case ']':
                        romData[startaddress + offset] = 0xf8;
                        break;
                    case '&':
                        romData[startaddress + offset] = 0xff;
                        break;
                }
                offset += 1;
            }
            if (needBreak)
                romData[startaddress + offset] = 0xff;
        }

        public void levelUpText(ref byte[] romData)
        {
            textchange textchange = new textchange();
            convertStrToHex("[^s}Maximum}HP}raises}]}point{!}", 0x413dd, false, ref romData); // Acorns of life Raise HP
            convertStrToHex("[^s}STR}raises ] point{.}}", 0x412de, false, ref romData);
            convertStrToHex("[^s}AGI}raises ] point{.}", 0x412f9, false, ref romData);
            convertStrToHex("[^s}VIT}raises ] point{.}}", 0x41313, false, ref romData);
            convertStrToHex("[^s}LUC}raises ] point{.@", 0x4132e, false, ref romData);
            convertStrToHex("[^s}INT}raises}]}point{.}}}}", 0x41347, false, ref romData);
            convertStrToHex("[^s}Maximum}HP}raises}]}point{.}", 0x415b6, false, ref romData); // Max HP Level Up
            convertStrToHex("[^s}Maximum}MP}raises}]}point{.}", 0x415d7, false, ref romData); // Max MP Level Up
            convertStrToHex("[^s}Maximum}MP}raises}]}point{.}", 0x4163c, false, ref romData); // Max MP

         }
        
        public void lowerCaseMenus(ref byte[] romData)
        // changes caps menus to lower case
        {
            textchange textchange = new textchange();

            convertStrToHex("Another World", 0x38942, false, ref romData);
            convertStrToHex("Non Equipped", 0x38a71, false, ref romData);
            convertStrToHex("Sex", 0x39139, false, ref romData);
            convertStrToHex("Level", 0x39140, false, ref romData);
            convertStrToHex("Attack", 0x3925c, false, ref romData);
            convertStrToHex("Power", 0x39264, false, ref romData);
            convertStrToHex("Defense", 0x3926e, false, ref romData);
            convertStrToHex("Power", 0x39277, false, ref romData);
            convertStrToHex("Talk", 0x3940c, false, ref romData);
            convertStrToHex("Spell", 0x39411, false, ref romData);
            convertStrToHex("Status", 0x39417, false, ref romData);
            convertStrToHex("Item", 0x3941e, false, ref romData);
            convertStrToHex("Search", 0x39423, false, ref romData);
            convertStrToHex("Equip", 0x3942a, false, ref romData);
            convertStrToHex("Use", 0x3943b, false, ref romData);
            convertStrToHex("Transfer", 0x3943f, false, ref romData);
            convertStrToHex("Discard", 0x39448, false, ref romData);
            convertStrToHex("Buy", 0x3945b, false, ref romData);
            convertStrToHex("Sell", 0x3945f, false, ref romData);
            convertStrToHex("Detoxicate", 0x3946f, false, ref romData);
            convertStrToHex("Uncurse", 0x3947a, false, ref romData);
            convertStrToHex("Revive", 0x39482, false, ref romData);
            convertStrToHex("Fight", 0x39494, false, ref romData);
            convertStrToHex("Spell", 0x3949a, false, ref romData);
            convertStrToHex("Run", 0x394a0, false, ref romData);
            convertStrToHex("Item", 0x394a4, false, ref romData);
            convertStrToHex("Fight", 0x394b4, false, ref romData);
            convertStrToHex("Spell", 0x394ba, false, ref romData);
            convertStrToHex("Parry", 0x394c0, false, ref romData);
            convertStrToHex("Item", 0x394c6, false, ref romData);
            convertStrToHex("Fight", 0x394d6, false, ref romData);
            convertStrToHex("Run", 0x394dc, false, ref romData);
            convertStrToHex("Parry", 0x394e0, false, ref romData);
            convertStrToHex("Item", 0x394e6, false, ref romData);
            convertStrToHex("Fight", 0x394f6, false, ref romData);
            convertStrToHex("Parry", 0x394fc, false, ref romData);
            convertStrToHex("Item", 0x39502, false, ref romData);
            convertStrToHex("Yes", 0x39516, false, ref romData);
            convertStrToHex("No", 0x3951a, false, ref romData);
            convertStrToHex("Info", 0x39528, false, ref romData);
            convertStrToHex("Condition", 0x3952d, false, ref romData);
            convertStrToHex("Formation", 0x39537, false, ref romData);
            convertStrToHex("Gold", 0x39565, false, ref romData);
            convertStrToHex("Item", 0x3956a, false, ref romData);
            convertStrToHex("Use", 0x3957a, false, ref romData);
            convertStrToHex("Equip", 0x3957e, false, ref romData);
            convertStrToHex("Back", 0x39793, false, ref romData);
            convertStrToHex("End", 0x39798, false, ref romData);
            convertStrToHex("Male", 0x397bc, false, ref romData);
            convertStrToHex("Female", 0x397c1, false, ref romData);
            convertStrToHex("Add Member", 0x39838, false, ref romData);
            convertStrToHex("Leave Member", 0x39843, false, ref romData);
            convertStrToHex("See List", 0x39850, false, ref romData);
            convertStrToHex("Use", 0x398cf, false, ref romData);
            convertStrToHex("Transfer", 0x398d3, false, ref romData);
            convertStrToHex("Discard", 0x398dc, false, ref romData);
            convertStrToHex("Appraise", 0x398e4, false, ref romData);
            convertStrToHex("Adventure Log 1", 0x39939, false, ref romData);
            convertStrToHex("Adventure Log 2", 0x39954, false, ref romData);
            convertStrToHex("Adventure Log 1", 0x3996f, false, ref romData);
            convertStrToHex("Adventure Log 2", 0x3997f, false, ref romData);
            convertStrToHex("Adventure Log 3", 0x3999a, false, ref romData);
            convertStrToHex("Adventure Log 1", 0x399b6, false, ref romData);
            convertStrToHex("Adventure Log 3", 0x399c5, false, ref romData);
            convertStrToHex("Adventure Log 2", 0x399e0, false, ref romData);
            convertStrToHex("Adventure Log 3", 0x399f0, false, ref romData);
            convertStrToHex("Adventure Log 1", 0x39a0b, false, ref romData);
            convertStrToHex("Adventure Log 2", 0x39a1b, false, ref romData);
            convertStrToHex("Adventure Log 3", 0x39a2b, false, ref romData);
            convertStrToHex("Input Your Name", 0x39a9a, false, ref romData);
            convertStrToHex("Level", 0x39abb, false, ref romData);
            convertStrToHex("Adventure Log 1", 0x39af3, false, ref romData);
            convertStrToHex("Adventure Log 2", 0x39b11, false, ref romData);
            convertStrToHex("Adventure Log 1", 0x39b2f, false, ref romData);
            convertStrToHex("Adventure Log 2", 0x39b42, false, ref romData);
            convertStrToHex("Adventure Log 3", 0x39b60, false, ref romData);
            convertStrToHex("Adventure Log 1", 0x39b7e, false, ref romData);
            convertStrToHex("Adventure Log 3", 0x39b91, false, ref romData);
            convertStrToHex("Adventure Log 2", 0x39baf, false, ref romData);
            convertStrToHex("Adventure Log 3", 0x39bc2, false, ref romData);
            convertStrToHex("Adventure Log 1", 0x39be0, false, ref romData);
            convertStrToHex("Adventure Log 2", 0x39bf3, false, ref romData);
            convertStrToHex("Adventure Log 3", 0x39c06, false, ref romData);
            convertStrToHex("Continue a Quest", 0x39c24, false, ref romData);
            convertStrToHex("Begin a New Quest", 0x39c35, false, ref romData);
            convertStrToHex("Copy a Quest", 0x39c47, false, ref romData);
            convertStrToHex("Erase a Quest", 0x39c54, false, ref romData);
            convertStrToHex("Change Message Speed", 0x39c62, false, ref romData);
            convertStrToHex("Continue a Quest", 0x39c82, false, ref romData);
            convertStrToHex("Erase a Quest", 0x39c93, false, ref romData);
            convertStrToHex("Change Message Speed", 0x39ca1, false, ref romData);
            convertStrToHex("Begin a New Quest", 0x39cc1, false, ref romData);
            convertStrToHex("Command", 0x39d3b, false, ref romData);
            convertStrToHex("Status", 0x39d43, false, ref romData);
            convertStrToHex("Item", 0x39d4a, false, ref romData);
            convertStrToHex("Whom", 0x39d4f, false, ref romData);
            convertStrToHex("Spell", 0x39d54, false, ref romData);
            convertStrToHex("Equip", 0x39d5a, false, ref romData);
            convertStrToHex("Weapon", 0x39d60, false, ref romData);
            convertStrToHex("Armor", 0x39d67, false, ref romData);
            convertStrToHex("Shield", 0x39d6d, false, ref romData);
            convertStrToHex("Helmet", 0x39d74, false, ref romData);
            convertStrToHex("Class", 0x39d7b, false, ref romData);
            convertStrToHex("Sex", 0x39d81, false, ref romData);
            convertStrToHex("Name", 0x39d85, false, ref romData);
            convertStrToHex("Fight", 0x39d8d, false, ref romData);
            convertStrToHex("To", 0x39d93, false, ref romData);
            convertStrToHex("and", 0x3a541, false, ref romData);
            convertStrToHex("Spell", 0x3a552, false, ref romData);
            convertStrToHex("Item", 0x3a561, false, ref romData);
            convertStrToHex("Equip", 0x3a571, false, ref romData);
            convertStrToHex("ndition", 0x3a5d2, false, ref romData);
            convertStrToHex("rmation", 0x3a5dd, false, ref romData);
        }

        public void weapArmPower(ref byte[] romData, out bool dispEqPower, bool addRemakeEquip)
        {
            textchange textchange = new textchange();

            int curseOffset1 = 0;
            int curseOffset2 = 0;

            //remove 8 characters to account for the :'s. Removal of water blaster to account for Curse *'s in equipment possibility
            textchange.convertStrToHex(" Herb", 0xafb8, false, ref romData);
            textchange.convertStrToHex(" Seed", 0xb007, false, ref romData);

            dispEqPower = true;
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
                    textchange.convertStrToHex("CypStk", 0xad11, true, ref romData);
                }
                else if (lnI == 1)
                {
                    textchange.convertStrToHex("Club", 0xad18, true, ref romData);
                }
                else if (lnI == 2)
                {
                    textchange.convertStrToHex("CprSwd", 0xad1d, true, ref romData);
                }
                else if (lnI == 3)
                {
                    textchange.convertStrToHex("MgcKn", 0xad24, true, ref romData);
                }
                else if (lnI == 4)
                {
                    textchange.convertStrToHex("IrSpr", 0xad2a, true, ref romData);
                }
                else if (lnI == 5)
                {
                    if (addRemakeEquip == false)
                        textchange.convertStrToHex("BtlAxe", 0xad30, true, ref romData);
                }
                else if (lnI == 6)
                {
                    textchange.convertStrToHex("BrdSw", 0xad37, true, ref romData);
                }
                else if (lnI == 7)
                {
                    textchange.convertStrToHex("WzWnd", 0xad3d, true, ref romData);
                }
                else if (lnI == 8)
                {
                    textchange.convertStrToHex("PsnNdl", 0xad43, true, ref romData);
                }
                else if (lnI == 9)
                {
                    textchange.convertStrToHex("IrnCl", 0xad4a, true, ref romData);
                }
                else if (lnI == 10)
                {
                    if (addRemakeEquip == false)
                        textchange.convertStrToHex("ThnWh", 0xad50, true, ref romData);
                }
                else if (lnI == 11)
                {
                    if (addRemakeEquip == false)
                        textchange.convertStrToHex("GntShr", 0xad56, true, ref romData);
                }
                else if (lnI == 12)
                {
                    textchange.convertStrToHex("ChSkl", 0xad5d, true, ref romData);
                }
                else if (lnI == 13)
                {
                    textchange.convertStrToHex("ThorSw", 0xad63, true, ref romData);
                }
                else if (lnI == 14)
                {
                    textchange.convertStrToHex("SnwSwd", 0xad6a, true, ref romData);
                }
                else if (lnI == 15)
                {
                    textchange.convertStrToHex("DmnAx", 0xad71, true, ref romData);
                }
                else if (lnI == 16)
                {
                    textchange.convertStrToHex("RainStf", 0xad77, true, ref romData);
                }
                else if (lnI == 17)
                {
                    textchange.convertStrToHex("GaiaSwd", 0xad7f, true, ref romData);
                }
                else if (lnI == 18)
                {
                    textchange.convertStrToHex("RfltStf", 0xad87, true, ref romData);
                }
                else if (lnI == 19)
                {
                    textchange.convertStrToHex("DstnSwd", 0xad8f, true, ref romData);
                }
                else if (lnI == 20)
                {
                    textchange.convertStrToHex("MEdgeSwd", 0xad97, true, ref romData);
                }
                else if (lnI == 21)
                {
                    textchange.convertStrToHex("FrcStf", 0xada0, true, ref romData);
                }
                else if (lnI == 22)
                {
                    textchange.convertStrToHex("IlsnSwd", 0xada7, true, ref romData);
                }
                else if (lnI == 23)
                {
                    textchange.convertStrToHex("ZmbSlshr", 0xadaf, true, ref romData);
                }
                else if (lnI == 24)
                {
                    textchange.convertStrToHex("FcnSwd", 0xadb8, true, ref romData);
                }
                else if (lnI == 25)
                {
                    if (addRemakeEquip == false)
                        textchange.convertStrToHex("SldgHmr", 0xadbf, true, ref romData);
                }
                else if (lnI == 26)
                {
                    textchange.convertStrToHex("ThndSwd", 0xadc7, true, ref romData);
                }
                else if (lnI == 27)
                {
                    textchange.convertStrToHex("ThndStf", 0xadcf, true, ref romData);
                }
                else if (lnI == 28)
                {
                    textchange.convertStrToHex("KingSwd", 0xadd7, true, ref romData);
                }
                else if (lnI == 29)
                {
                    textchange.convertStrToHex("OrochiSwd", 0xaddf, true, ref romData);
                }
                else if (lnI == 30)
                {
                    textchange.convertStrToHex("DrgnKlr", 0xade9, true, ref romData);
                }
                else if (lnI == 31)
                {
                    textchange.convertStrToHex("JdgmtStf", 0xadf1, true, ref romData);
                }
                else if (lnI == 32)
                {
                    textchange.convertStrToHex("Clothes", 0xadfa, true, ref romData);
                }
                else if (lnI == 33)
                {
                    textchange.convertStrToHex("TrngSt", 0xae02, true, ref romData);
                }
                else if (lnI == 34)
                {
                    textchange.convertStrToHex("LthrAr", 0xae09, true, ref romData);
                }
                else if (lnI == 35)
                {
                    textchange.convertStrToHex("FlshCl", 0xae10, true, ref romData);
                }
                else if (lnI == 36)
                {
                    textchange.convertStrToHex("HalfPlAr", 0xae17, true, ref romData);
                }
                else if (lnI == 37)
                {
                    textchange.convertStrToHex("FullPlAr", 0xae20, true, ref romData);
                }
                else if (lnI == 38)
                {
                    textchange.convertStrToHex("MagicAr", 0xae29, true, ref romData);
                }
                else if (lnI == 39)
                {
                    textchange.convertStrToHex("EvCloak", 0xae31, true, ref romData);
                }
                else if (lnI == 40)
                {
                    textchange.convertStrToHex("RadiantAr", 0xae39, true, ref romData);
                }
                else if (lnI == 41)
                {
                    textchange.convertStrToHex("IronAp", 0xae43, true, ref romData);
                }
                else if (lnI == 42)
                {
                    textchange.convertStrToHex("AnimalSuit", 0xae4a, true, ref romData);
                }
                else if (lnI == 43)
                {
                    textchange.convertStrToHex("FightSuit", 0xae55, true, ref romData);
                }
                else if (lnI == 44)
                {
                    textchange.convertStrToHex("ScrdRb", 0xae5f, true, ref romData);
                }
                else if (lnI == 45)
                {
                    textchange.convertStrToHex("HadesAr", 0xae66, true, ref romData);
                }
                else if (lnI == 46)
                {
                    textchange.convertStrToHex("WtrFlyCl", 0xae6e, true, ref romData);
                }
                else if (lnI == 47)
                {
                    textchange.convertStrToHex("ChMail", 0xae77, true, ref romData);
                }
                else if (lnI == 48)
                {
                    textchange.convertStrToHex("WayfrCl", 0xae7e, true, ref romData);
                }
                else if (lnI == 49)
                {
                    textchange.convertStrToHex("RevealSwmst", 0xae86, true, ref romData);
                }
                else if (lnI == 50)
                {
                    textchange.convertStrToHex("MgBikini", 0xae92, true, ref romData);
                }
                else if (lnI == 51)
                {
                    textchange.convertStrToHex("ShellAr", 0xae9b, true, ref romData);
                }
                else if (lnI == 52)
                {
                    if (addRemakeEquip == false)
                        textchange.convertStrToHex("TerrafmAr", 0xaea3, true, ref romData);
                }
                else if (lnI == 53)
                {
                    textchange.convertStrToHex("DrgMail", 0xaead, true, ref romData);
                }
                else if (lnI == 54)
                {
                    textchange.convertStrToHex("SwedgeAr", 0xaeb5, true, ref romData);
                }
                else if (lnI == 55)
                {
                    textchange.convertStrToHex("AngelRb", 0xaebe, true, ref romData);
                }
                else if (lnI == 56)
                {
                    textchange.convertStrToHex("LthrShld", 0xaec6, true, ref romData);
                }
                else if (lnI == 57)
                {
                    if (addRemakeEquip == false)
                        textchange.convertStrToHex("IrnShld", 0xaecf, true, ref romData);
                }
                else if (lnI == 58)
                {
                    textchange.convertStrToHex("StrShld", 0xaed7, true, ref romData);
                }
                else if (lnI == 59)
                {
                    textchange.convertStrToHex("HeroShld", 0xaedf, true, ref romData);
                }
                else if (lnI == 60)
                {
                    textchange.convertStrToHex("SrwShld", 0xaee8, true, ref romData);
                }
                else if (lnI == 61)
                {
                    textchange.convertStrToHex("BrzShld", 0xaef0, true, ref romData);
                }
                else if (lnI == 62)
                {
                    textchange.convertStrToHex("SlvShld", 0xaef8, true, ref romData);
                }
                else if (lnI == 63)
                {
                    textchange.convertStrToHex("Gold Crown", 0xaf00, true, ref romData);
                }
                else if (lnI == 64)
                {
                    textchange.convertStrToHex("IrHmt", 0xaf0b, true, ref romData);
                }
                else if (lnI == 65)
                {
                    textchange.convertStrToHex("MystHt", 0xaf11, true, ref romData);
                }
                else if (lnI == 66)
                {
                    textchange.convertStrToHex("UnlyHmt", 0xaf18, true, ref romData);
                }
                else if (lnI == 67)
                {
                    textchange.convertStrToHex("Turbn", 0xaf20, true, ref romData);
                }
                else if (lnI == 68)
                {
                    textchange.convertStrToHex("NohMask", 0xaf26, true, ref romData);
                }
                else if (lnI == 69)
                {
                    textchange.convertStrToHex("LthHmt", 0xaf2e, true, ref romData);
                }
                else if (lnI == 70)
                {
                    if (addRemakeEquip == false)
                        textchange.convertStrToHex("IrMsk", 0xaf35, true, ref romData);
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
            textchange.convertStrToHex("Amulet&Life&Happiness&Claw&Armband&Satori&&Ring&Pepper&Stone&Ra&Drought&Darkness&Change&Life&&Ball&Key&Key&Key&Ruby&Powder&Scroll&&Seed&Seed&&Seed&Seed&Life&Herb&Herb&Water&Wyvern&World$Tree&&Love&Herb&", 0xb2a5 + curseOffset2, true, ref romData);

            for (int lnI = 0; lnI < (9 - curseOffset2); lnI++)
                romData[0xb371 + lnI] = 0x00;
        }
        /*
                private void remCurse(int offset)
                {
                    byte value = romData[0x11be + offset];
                    bool checkCurse = (value & 0x08) == 0x08;

                    if (checkCurse)
                    {
                        romData[0x11be + offset] = (byte)(value - 8);
                    }
                }
        */


    }
}
