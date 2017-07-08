using GenieClock.Application;
using GenieClock.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenieClock
{
    class Program
    {
        static void Main(string[] args)
        {
            ITimeParser parser= new TimeParser();
            IScreenGenerator screenGenerator = new ScreenGenerator();
            IFaceDigitGenerator faceGenerator = new FaceDigitGenerator();
            IGenieClock clock = new GenieClockApplication();

            clock.RunApplication(parser, screenGenerator, faceGenerator);
        }
    }
}
