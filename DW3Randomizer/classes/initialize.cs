using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer
{
    public class initialize
    {
        public void setrandomization(ref Random r1, ref Random randomFlagIncrement, ref Random randomCosmeticIncrement, string txtSeed, int buildnumber, bool genCompareFile)
        {
            r1 = new Random((int)long.Parse(txtSeed));
            randomFlagIncrement = new Random(int.Parse(txtSeed));
            randomCosmeticIncrement = new Random(int.Parse(txtSeed));

            for (int lnI = 0; lnI < buildnumber; lnI++)
            {
                r1.Next();
                randomCosmeticIncrement.Next();
                randomFlagIncrement.Next();
            }


            // Randomize how many steps up rni is increased if GenCompareFile is checked
            if (genCompareFile)
            {
                int increment = r1.Next() % buildnumber + 1;
                for (int lnI = 0; lnI < increment; lnI++)
                {
                    r1.Next();
                    randomCosmeticIncrement.Next();
                    randomFlagIncrement.Next();
                }
            }

        }

        public void maplocsfunct(ref int[,] maplocs)
        {
            for (int lnI = 0; lnI < 256; lnI++)
                for (int lnJ = 0; lnJ < 256; lnJ++)
                    maplocs[lnI, lnJ] = 0;
        }

    }
}
