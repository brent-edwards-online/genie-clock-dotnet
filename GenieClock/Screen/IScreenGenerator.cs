using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenieClock.Screen
{
    public interface IScreenGenerator
    {
        char[,] Generate(ClockFacePoint[] points);
    }
}
