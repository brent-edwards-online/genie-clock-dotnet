using System;
using System.Text.RegularExpressions;

namespace GenieClock.Screen
{
    public class TimeParser : ITimeParser
    {
        readonly Regex REGEX = new Regex(@"^([0-9]|0[0-9]|1[0-9]|2[0-3]):([0-5][0-9])$");

        public Tuple<int, int> Parse(string time)
        {

            if (!REGEX.IsMatch(time)) throw new Exception("Invalid input string");
            var fields = time.Split(':');
            var result = new Tuple<int, int>(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]));
            return result;
        }
    }
}
