using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DW3Randomizer.classes
{
    public class romtools
    {
        public void saveRom(bool calcChecksum, ref byte[] romData, string versionNumber, string txtFileName, string txtSeed, string txtFlags, ref string lblIntensityDesc, ref string txtCompare, ref string lblNewChecksum)
        {
            string shortVersion = versionNumber.Replace(".", "");
            string finalFile = Path.Combine(Path.GetDirectoryName(txtFileName), "DW3R_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".nes");
            File.WriteAllBytes(finalFile, romData);
            lblIntensityDesc = "ROM hacking complete!  (" + finalFile + ")";
            txtCompare = finalFile;

            if (calcChecksum)
            {
                try
                {
                    using (var md5 = SHA1.Create())
                    {
                        using (var stream = File.OpenRead(finalFile))
                        {
                            lblNewChecksum = BitConverter.ToString(md5.ComputeHash(stream)).ToLower().Replace("-", "");
                        }
                    }
                }
                catch
                {
                    lblNewChecksum = "????????????????????????????????????????";
                }
            }

        }

    }
}
