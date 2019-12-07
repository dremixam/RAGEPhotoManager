using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    static class Tool
    {
        public static DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }
    }
}
