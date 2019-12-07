using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RAGEPhotoManager.Model
{
    public enum GameType
    {
        [Description("Grand Theft Auto V")]
        GTA5,
        [Description("Red Dead Redemption 2")]
        RDR3
    }

    public static class EnumExtensions
    {
        public static string DisplayName(this Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memberInfo = type.GetMember(en.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return en.ToString();
        }
    }
}
