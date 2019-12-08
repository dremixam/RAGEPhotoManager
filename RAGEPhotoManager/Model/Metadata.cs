using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    public abstract class Metadata
    {
        public Vector3 loc;
        public String nm;
        public String sid;
        public Int64 crewid;
        public String mid;
        public String mode;
        public bool meme;
        public bool mug;
        public Int64 uid;
        public MyDateTime time;
        public Int64 creat;
        public bool slf;
        public bool drctr;
        public bool rsedtr;

        public abstract String[] Properties();
    }

    public class MyDateTime
    {
        public int hour;
        public int minute;
        public int second;
        public int day;
        public int month;
        public int year;

        public override String ToString()
        {
            return year.ToString("0000") + (month + 1).ToString("00") + day.ToString("00") + "-" + hour.ToString("00") + minute.ToString("00") + second.ToString("00");
        }

        public DateTime GetDateTime()
        {
            return new DateTime(year, month, day, hour, minute, second);
        }
    }

    public class Vector3
    {
        public double x;
        public double y;
        public double z;

        public override string ToString()
        {
            return x + ", " + y + ", " + z;
        }
    }

    public class Meta
    {
        public Int64[] anml;
        public Int64[] horse;
        public Int64[] weap;
        public Int64[] plyr;
    }


}
