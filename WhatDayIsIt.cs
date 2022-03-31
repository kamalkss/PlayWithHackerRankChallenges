using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class WhatDayIsIt
    {
        public static string Run(string birthday_date)
        {
            string future_dates = "";
            //
            // Write your code below; return type and arguments should be according to the problem\'s requirements
            //
            //Birth is on dd-mm format
            string[] date = birthday_date.Split('-');
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            //Check the day of weeks for next 50 years

            for (int i = 0; i < 50; i++)
            {
                try
                {
                    DateTime dt = new DateTime(DateTime.Now.Year - 6 + i, month, day);
                    switch (dt.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            future_dates += "Sun-" + dt.Year + " ";
                            break;
                        case DayOfWeek.Friday:
                            future_dates += "Fri-" + dt.Year + " ";
                            break;
                        case DayOfWeek.Saturday:
                            future_dates += "Sat-" + dt.Year + " ";
                            break;
                    }
                }
                catch{continue;}
                
            }

            future_dates = future_dates.Remove(future_dates.Length - 1, 1);
            return future_dates;
        }
    }
}
