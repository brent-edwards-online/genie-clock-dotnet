using GenieClock.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenieClock.Application
{
    public interface IGenieClock
    {
        void RunApplication(ITimeParser parser, IScreenGenerator generator, IFaceDigitGenerator faceGenerator); 
    }
}
