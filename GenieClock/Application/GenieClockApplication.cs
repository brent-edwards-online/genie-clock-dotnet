using GenieClock.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenieClock.Application
{
    public class GenieClockApplication : IGenieClock
    {
        public void RunApplication(ITimeParser parser, IScreenGenerator generator, IFaceDigitGenerator faceGenerator)
        {
            Console.WriteLine("GenieClock By Brent Edwards");
            Console.WriteLine("Enter x to exit");
            bool keepGoing = true;
            while(keepGoing == true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enter a time in 24 hour format hh:mm");
                Console.Write("> ");
                var enteredTime = Console.ReadLine();
                Console.WriteLine("\n");

                if (enteredTime == "x")
                {
                    keepGoing = false;
                }
                else
                {
                    try
                    {
                        Tuple<int, int> timeValues = null;
                        try
                        {
                            timeValues = parser.Parse(enteredTime);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid Input. Please use hh:mm");
                        }

                        if(timeValues != null)
                        {
                            var points = faceGenerator.Generate(timeValues.Item1, timeValues.Item2);
                            var screen = generator.Generate(points);
                            var dimx = screen.GetLongLength(0);
                            var dimy = screen.GetLongLength(1);
                            for (var x = 0; x < dimx; x++)
                            {
                                for (var y = 0; y < dimy; y++)
                                {
                                    Console.Write(screen[x, y]);
                                }
                                Console.WriteLine("");
                            }
                        }
                        
                    }
                    catch
                    {
                        Console.WriteLine("Error Processing Clock");
                    }
                }
            }
        }
    }
}
