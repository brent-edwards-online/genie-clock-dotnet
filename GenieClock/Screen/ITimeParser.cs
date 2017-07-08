using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenieClock.Screen
{
    public interface ITimeParser
    {
        Tuple<int, int> Parse(string time);
    }
}
