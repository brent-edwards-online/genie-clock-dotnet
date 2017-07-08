using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenieClock.Screen
{
    public class ScreenGenerator : IScreenGenerator
    {
        public char[,] Generate(ClockFacePoint[] points)
        {
            var result = new char[11,15];
            for( var idx = 0; idx < 11; idx++)
            {
                for (var jdx = 0; jdx < 15; jdx++)
                {
                    result[idx, jdx] = ' ';
                }
            }

            if (points != null)
            {
                foreach (var point in points)
                {
                    result[point.y, point.x] = point.character;
                }
            }
            return result;
        }
    }
}
