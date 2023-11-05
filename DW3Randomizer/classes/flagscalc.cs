using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer
{
    public class flagscalc
    {
        public static void determineChecksBanks(out int b1, out int b2, out int b3, int num)
        {
            b3 = num / 16;
            b2 = (num - b3 * 16) / 4;
            b1 = (num - b2 * 4) % 4;
        }

        public string convertIntToCharCapsOnlyForFlags(int number)
        {
            switch (number)
            {
                case 0: return "A";
                case 1: return "B";
                case 2: return "C";
                case 4: return "D";
                case 5: return "E";
                case 6: return "F";
                case 8: return "G";
                case 9: return "H";
                case 10: return "I";
                case 16: return "J";
                case 17: return "K";
                case 18: return "L";
                case 20: return "M";
                case 21: return "N";
                case 22: return "O";
                case 24: return "P";
                case 25: return "Q";
                case 26: return "R";
                case 32: return "S";
                case 33: return "T";
                case 34: return "U";
                case 36: return "V";
                case 37: return "W";
                case 38: return "X";
                case 40: return "Y";
                case 41: return "Z";
                case 42: return "#";
            }
            return Convert.ToChar(65 + number).ToString();
        }
        public int convertChartoIntCapsOnlyForFlags(char character)
        {
            switch (character)
            {
                case 'A': return 0;
                case 'B': return 1;
                case 'C': return 2;
                case 'D': return 4;
                case 'E': return 5;
                case 'F': return 6;
                case 'G': return 8;
                case 'H': return 9;
                case 'I': return 10;
                case 'J': return 16;
                case 'K': return 17;
                case 'L': return 18;
                case 'M': return 20;
                case 'N': return 21;
                case 'O': return 22;
                case 'P': return 24;
                case 'Q': return 25;
                case 'R': return 26;
                case 'S': return 32;
                case 'T': return 33;
                case 'U': return 34;
                case 'V': return 36;
                case 'W': return 37;
                case 'X': return 38;
                case 'Y': return 40;
                case 'Z': return 41;
                case '#': return 42;
            }
            return character;
        }


    }
}
