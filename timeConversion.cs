using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges
{
    public class timeConversion
    {
        public static string timeConversions(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "00:00:00";
            }
            int hour = Convert.ToInt32(s.Substring(0, 2));
            if (hour > 12)
            {
                return "00:00:00";
            }
            if (s.Contains("AM"))
            {

                int indexofAM = s.IndexOf("AM");
                if (hour == 12)
                {
                    return "00" + s.Substring(2, indexofAM-2);
                }
                return s.Substring(0, indexofAM);
            }
            else if (s.Contains("PM"))
            {
                int indexofAM = s.IndexOf("PM");

                if (hour == 12)
                {
                    return s.Substring(2, indexofAM);
                }
                else
                {
                    return (hour + 12).ToString() + s.Substring(2, indexofAM - 2);
                }
            }
            return s;
        }
    }
}