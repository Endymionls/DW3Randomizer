using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer.classes
{
    public class bugFixes
    {
        public void fixHeroSpell(ref byte[] romData)
        {
            romData[0x1ef72] = 0x07;
        }
        public void removeParryFight(ref byte[] romData)
        {
            byte[] parryFightFix1 = { 0xbd, 0x9b, 0x6a, 0x29, 0xdf, 0x9d, 0x9b, 0x6a, 0x60 };
            byte[] parryFightFix2 = { 0x20, 0x70, 0xbb };
            for (int lnI = 0; lnI < parryFightFix1.Length; lnI++)
                romData[0xbb80 + lnI] = parryFightFix1[lnI];
            for (int lnI = 0; lnI < parryFightFix2.Length; lnI++)
                romData[0xa402 + lnI] = parryFightFix2[lnI];
        }

    }
}
