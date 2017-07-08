using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenieClock.Screen;

namespace GenieClock.Test
{
    [TestClass]
    public class TestGenerateScreen
    {
        IScreenGenerator _generator;

        [TestInitialize]
        public void Initialize()
        {
            _generator = new ScreenGenerator();
        }

        [TestMethod]
        [TestCategory("Test Screen Generator")]
        public void Returns15x11Array()
        {
            var actual = _generator.Generate(null);
            Assert.AreEqual(165, actual.Length);

            var d0 = actual.GetUpperBound(0);
            Assert.AreEqual(10, d0);

            var d1 = actual.GetUpperBound(1);
            Assert.AreEqual(14, d1);
        }

        [TestMethod]
        [TestCategory("Test Screen Generator")]
        public void EmptyListReturnsEmptyScreen()
        {
            ClockFacePoint[] points = new ClockFacePoint[0];

            var actual = _generator.Generate(points);
            for(var row = 0; row < 11; row++)
            {
                for (var col = 0; col < 15; col++)
                {
                    Assert.AreEqual(' ', actual[row, col]);
                }
            }
        }

        [TestMethod]
        [TestCategory("Test Screen Generator")]
        public void CanGenerateABasicScreen()
        {
            var actual = _generator.Generate(null);
            for (var row = 0; row < 11; row++)
            {
                for (var col = 0; col < 15; col++)
                {
                    Assert.AreEqual(' ', actual[row, col]);
                }
            }
        }

        [TestMethod]
        [TestCategory("Test Screen Generator")]
        public void CanPlaceAtCorrectPlaceDigitOnTheScreen()
        {
            ClockFacePoint[] points = new ClockFacePoint[1];
            points[0].x = 5;
            points[0].y = 10;
            points[0].character = 'h';

            var actual = _generator.Generate(points);
            for (var row = 0; row < 11; row++)
            {
                for (var col = 0; col < 15; col++)
                {
                    if(row == 10 && col == 5)
                    {
                        Assert.AreEqual('h', actual[row, col]);
                    }
                    else
                    {
                        Assert.AreEqual(' ', actual[row, col]);
                    }
                }
            }
            
        }




    }
}
