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

        public override String[] Properties()
        {
            List<String> r = new List<string>();

            r.Add("Location : ");
            r.Add(GameData.RDR3Data.GetName(districtname) + ", "
                + GameData.RDR3Data.GetName(regionname) + ", "
                + GameData.RDR3Data.GetName(statename));
            r.Add("(" + loc + ")");

            // Propriétés générales
            //r.Add("Nm : " + nm);
            //r.Add("Session ID : " + sid);
            //r.Add("Crewid : " + crewid);
            //r.Add("Mid : " + mid);


            //r.Add("drctr : " + drctr);

            // Propriétés spécifiques a RDR3
            //r.Add("width : " + width);
            //r.Add("height : " + height);
            //r.Add("size : " + size);



            return r.ToArray();
        }
    }
}
