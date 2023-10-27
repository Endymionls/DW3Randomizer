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
    }
}
