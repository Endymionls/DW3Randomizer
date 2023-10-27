using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Randomizer.classes
{
    public class optimizations
    {
        public void cod(ref byte[] romData)
        {
            // All ROM hacks will revive ALL characters on a ColdAsACod.
            // There will be a temporary graphical error if you use less than four characters, but I'm going to leave it be.
            byte[] codData1 = { 0xa0, 0x00, // Make sure Y is 0 first.
                0xb9, 0x3c, 0x07,
                0xc9, 0x80,
                0x90, 0x03, // If less than 0x80, skip.
                0x20, 0xb2, 0xbf, // JSR to a bunch of unused code, which will have the "revive one character code" that I'm replacing.
                0xc8, 0xc8, // Increment Y twice (Y is used to revive the characters)
                0xc0, 0x08, // Compare Y with 08
                0xd0, 0xf0, // If not equal, go back to the JSR mentioned above
                0xa0, 0x00, // Set Y back to 0 to make sure the game doesn't think something is up
                0xea, 0xea, 0xea, 0xea, 0xea,
                0xea, 0xea, 0xea, 0xea, 0xea,
                0xea, 0xea }; // 12 NOPs, since I have nothing else to do.
            byte[] codData2 = { 0xa9, 0x80, // Load 80, the status for alive
                0x99, 0x3c, 0x07, // store to two status bytes
                0x99, 0x3d, 0x07,
                0xb9, 0x24, 0x07, // Load max HP
                0x99, 0x1c, 0x07, // save max HP
                0xb9, 0x25, 0x07, // second byte
                0x99, 0x1d, 0x07,
                0xb9, 0x34, 0x07, // Load max MP
                0x99, 0x2c, 0x07, // save max MP
                0xb9, 0x35, 0x07, // second byte
                0x99, 0x2d, 0x07,
                0x60 }; // end JSR

            for (int lnI = 0; lnI < codData1.Length; lnI++)
                romData[0x22b3 + lnI] = codData1[lnI];
            for (int lnI = 0; lnI < codData2.Length; lnI++)
                romData[0x3fc2 + lnI] = codData2[lnI];

            romData[0x3cc6a] = 0x4c; // Forces a jump out of the king scolding routine, saving at least 13 seconds / party wipe.  There are graphical errors, but I'll take it!
        }

        public void speedText(ref byte[] romData)
        {
            romData[0x3a783] = 0x20;
            romData[0x3a784] = 0xbd;
            romData[0x3a785] = 0xbf;

            romData[0x3a9c7] = 0x90;
            romData[0x3a9c8] = 0x1d;
            romData[0x3a9c9] = 0xa6;
            romData[0x3a9ca] = 0x78;
            romData[0x3a9cb] = 0xf0;
            romData[0x3a9cc] = 0x06;

            byte[] speedText = { 0xad, 0xd0, 0x6a, 0xf0, 0x03, 0x00, 0x96, 0x2f, 0x20, 0xba, 0xc2, 0xa9, 0x02, 0x8d, 0xd6, 0x06, 0x20, 0x41, 0xc3, 0xa9, 0x00, 0x8d, 0xd6, 0x06, 0x4c, 0x5f, 0xaa };
            for (int i = 0; i < speedText.Length; i++)
                romData[0x3bfcd + i] = speedText[i];
        }

        public void speedUpMenus(ref byte[] romData)
        {
            // Speed up item menu loading
            romData[0x2b0d] = 0x00;
            romData[0x2b0e] = 0xf0;
            romData[0x2b0f] = 0x01;
            romData[0x2b10] = 0x00;
        }
    }
}
