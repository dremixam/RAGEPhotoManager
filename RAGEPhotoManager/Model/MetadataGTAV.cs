using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    class MetadataGTAV : Metadata
    {
        public String area;
        public String rds;
        public int scr;

        public override String[] Display()
        {
            List<String> r = new List<string>();
            r.Add("Localisation : ");


            r.Add(area);

            r.Add("(" + loc + ")");

            r.Add("Rds : " + rds);

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

            return r.ToArray();
        }
    }
}
