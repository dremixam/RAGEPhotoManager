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

        public override String[] Properties()
        {
            List<String> r = new List<string>();
            r.Add("Uid : " + uid);

            r.Add("Location : ");
            r.Add(area);
            r.Add("(" + loc + ")");

            //r.Add("Rds : " + rds);

            // Propriétés générales
            //r.Add("Nm : " + nm);
            //r.Add("Session ID : " + sid);
            //r.Add("Crewid : " + crewid);
            //r.Add("Mid : " + mid);
            //r.Add("Mode : " + mode);



            //r.Add("drctr : " + drctr); // ?

            return r.ToArray();
        }
    }
}
