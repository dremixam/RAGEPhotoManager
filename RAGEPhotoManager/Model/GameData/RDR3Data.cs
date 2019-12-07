using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model.GameData
{
    enum RDR3Hashes : uint
    {
        COS = 0x00238FE9,
        LEMOYNE = 0x00a55d60,
        _043B32FD = 0x043B32FD,
        BAY = 0x07d52030,
        _0A2398F3 = 0x0A2398F3,
        _0CE0BBF5 = 0x0CE0BBF5,
        PAI = 0x0d023334,
        CSP = 0x0def9525,
        _0EA03525 = 0x0EA03525,
        _0EF443A7 = 0x0EF443A7,
        _0FA26137 = 0x0FA26137,
        _11F25506 = 0x11F25506,
        APP = 0x126c3411,

        VAL = 0xd9a7ec35,
        RHO = 0xffd9846d
    }

    static class RDR3Data
    {
        private static Dictionary<RDR3Hashes, String> _Names;
        static RDR3Data()
        {
            _Names = new Dictionary<RDR3Hashes, string>();
            _Names.Add(RDR3Hashes.COS, "Compsons Stead");
            _Names.Add(RDR3Hashes.LEMOYNE, "Lemoyne");
            _Names.Add(RDR3Hashes._043B32FD, "Northern Cardinal");
            _Names.Add(RDR3Hashes.BAY, "Bayou Nwa");
            _Names.Add(RDR3Hashes._0A2398F3, "Hill Haven Ranch");
            _Names.Add(RDR3Hashes._0CE0BBF5, "Longnose Gar");
            _Names.Add(RDR3Hashes.PAI, "Painted Sky");
            _Names.Add(RDR3Hashes.CSP, "Cotorra Springs");
            _Names.Add(RDR3Hashes._0EA03525, "Ewing Basin");
            _Names.Add(RDR3Hashes._0EF443A7, "Poodle");
            _Names.Add(RDR3Hashes._0FA26137, "Thoroughbred");
            _Names.Add(RDR3Hashes._11F25506, "Mattlock Pond");
            _Names.Add(RDR3Hashes.APP, "Appleseed Timber Co.");

            _Names.Add(RDR3Hashes.VAL, "Valentine");
            _Names.Add(RDR3Hashes.RHO, "Rhodes");
        }

        public static String GetName(long hash)
        {
            String value;
            if (_Names.TryGetValue((RDR3Hashes)hash, out value))
            {
                return value;
            }
            else
            {
                return hash.ToString("X");
            }
        }
    }
}
