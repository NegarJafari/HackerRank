using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class ConvertTime
    {
        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         * It should return a new string representing the input time in 24 hour format.

        timeConversion has the following parameter(s):

        string input: a time in 12 hour format
        Returns string: the time in 24 hour format
        */

        public static string timeConversion(string input)
        {
            var result = string.Empty;
            var dateType = input.Substring(input.Length - 2);
            var date = input.Substring(0, input.Length - 2);
            var hour = date.Substring(0, 2);
            var is12 = hour == "12";
            var withoutHour = date.Substring(2, 6);

            switch (dateType)
            {
                case "PM":
                    if (!is12)
                    {
                        var h = Convert.ToInt32(hour) + 12;
                        hour = h.ToString();
                    }
                    result = hour + withoutHour;
                    break;
                case "AM":
                    hour = is12 ? "00" : hour;
                    result = hour + withoutHour;
                    break;
            }
            return result;
        }

    }
}
