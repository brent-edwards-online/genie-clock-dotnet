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
            for( var row = 0; row < 11; row++)
            {
                for (var col = 0; col < 15; col++)
                {
                    result[row, col] = ' ';
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
