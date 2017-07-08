using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenieClock.Screen
{
    public class FaceDigitGenerator : IFaceDigitGenerator
    {
        public ClockFacePoint[] Generate(int hour, int minute)
        {
            var result = new ClockFacePoint[12];
            result[0] = new ClockFacePoint(7, 0, 'o');
            result[1] = new ClockFacePoint(10, 1, 'o');
            result[2] = new ClockFacePoint(13, 3, 'o');
            result[3] = new ClockFacePoint(14, 5, 'o');
            result[4] = new ClockFacePoint(13, 7, 'o');
            result[5] = new ClockFacePoint(10, 9, 'o');
            result[6] = new ClockFacePoint(7, 10, 'o');
            result[7] = new ClockFacePoint(4, 9, 'o');
            result[8] = new ClockFacePoint(1, 7, 'o');
            result[9] = new ClockFacePoint(0, 5, 'o');
            result[10] = new ClockFacePoint(1, 3, 'o');
            result[11] = new ClockFacePoint(4, 1, 'o');

            var hourPosition = hour % 12;
            var minutePosition = ((minute - (minute % 5))/ 5) % 12;
            if(minutePosition == hourPosition)
            {
                result[hourPosition].character = 'x';
            }
            else
            {
                result[hourPosition].character = 'h';
                result[minutePosition].character = 'm';
            }


            return result;
        }
    }
}
