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
            for(var idx = 0; idx < 11; idx++)
            {
                for (var jdx = 0; jdx < 15; jdx++)
                {
                    Assert.AreEqual(' ', actual[idx, jdx]);
                }
            }
        }

        [TestMethod]
        [TestCategory("Test Screen Generator")]
        public void CanGenerateABasicScreen()
        {
            var actual = _generator.Generate(null);
            for (var idx = 0; idx < 11; idx++)
            {
                for (var jdx = 0; jdx < 15; jdx++)
                {
                    Assert.AreEqual(' ', actual[idx, jdx]);
                }
            }
        }




    }
}
