using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Basics
{
    abstract class TimeDifference
    {
        public static string StringChallenge(string str)
        {

            string[] timeRange = str.Split('-');

            string startTime = timeRange[0].Trim();
            string endTime = timeRange[1].Trim();

            DateTime date1 = DateTime.Parse(startTime);
            DateTime date2 = DateTime.Parse(endTime);

            TimeSpan diff = date2 - date1;
            int min = (int)diff.TotalMinutes;

            if (date1 < date2)
            {
                min += 12 * 60;
            }

            if (min < 0)
            {
                min = 1440 + min;
            }

            return min.ToString();

        }

    }

}
