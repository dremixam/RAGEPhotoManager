using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    class MetadataRDR3 : Metadata
    {
        public Int64 regionname;
        public Int64 districtname;
        public Int64 statename;
        public bool inphotomode;
        public int width;
        public int height;
        public int size;
        public Int64 sign;
        public Meta meta;

        public override String[] Display()
        {
            List<String> r = new List<string>();

            r.Add("Localisation : ");
            r.Add(GameData.RDR3Data.GetName(districtname) + ", "
                + GameData.RDR3Data.GetName(regionname) + ", "
                + GameData.RDR3Data.GetName(statename));
            r.Add("(" + loc + ")");

            // Propriétés générales
            r.Add("Nm : " + nm);
            r.Add("Sid : " + sid);
            r.Add("Crewid : " + crewid);
            r.Add("Mid : " + mid);
            r.Add("Mode : " + mode);
            r.Add("Meme : " + meme);
            r.Add("Mugshot : " + mug);
            r.Add("Uid : " + uid);
            r.Add("Game time : " + time.GetDateTime());
            r.Add("Real time : " + Tool.UnixTimeToDateTime(creat));
            r.Add("Selfie : " + slf);
            r.Add("drctr : " + drctr);
            r.Add("rsedtr : " + rsedtr);

            // Propriétés spécifiques a RDR3
            r.Add("Inphotomode : " + inphotomode);
            r.Add("width : " + width);
            r.Add("height : " + height);
            r.Add("size : " + size);

            if (meta.anml != null)
                foreach (Int64 anml in meta.anml)
                {
                    r.Add("Animal : " + GameData.RDR3Data.GetName(anml));
                }
            if (meta.horse != null)
                foreach (Int64 horse in meta.horse)
                {
                    r.Add("Horse : " + GameData.RDR3Data.GetName(horse));
                }
            if (meta.weap != null)
                foreach (Int64 weap in meta.weap)
                {
                    r.Add("Weapon : " + GameData.RDR3Data.GetName(weap));
                }
            if (meta.plyr != null)
                foreach (Int64 plyr in meta.plyr)
                {
                    r.Add("Player : " + GameData.RDR3Data.GetName(plyr));
                }

            return r.ToArray();
        }
    }
}
