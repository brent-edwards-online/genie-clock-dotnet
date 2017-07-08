using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenieClock.Screen
{
    public struct ClockFacePoint
    {
        public ClockFacePoint(Byte x, Byte y, char character)
        {
            this.x = x;
            this.y = y;
            this.character = character;
        }
        public Byte x;
        public Byte y;
        public char character;
    }
}
