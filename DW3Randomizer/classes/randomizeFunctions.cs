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

        public void randsagestone(ref byte[] romData, ref Random r1, bool HUAStoneOn, bool HUAStoneRand)
        {
            int HUAStone = r1.Next() % 2;
            int HUAStoneChance = r1.Next() % 12;
            if (HUAStoneOn || (HUAStoneRand && HUAStone == 1))
                romData[0x13293] = 0x1f;
            else if (HUAStoneChance == 10)
                romData[0x13293] = 0x1f;
        }

        public void randshoes(ref byte[] romData, ref Random r1, bool BigOn, bool BigRand)
        {
            int BigEffect = r1.Next() % 2;
            if (BigOn || (BigRand && BigEffect == 1)) // Shoes will give 11-255 exp per step
                romData[0x330fc] = (byte)((r1.Next() % 245) + 11);
            else // Shoes will give 0-10 exp per step
                romData[0x330fc] = (byte)((r1.Next() % 10) + 1);

        }

    }
}
