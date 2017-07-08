using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenieClock.Screen;

namespace GenieClock.Test
{
    [TestClass]
    public class TestTimeParser
    {
        ITimeParser _parser;

        [TestInitialize]
        public void Initialize()
        {
            _parser = new TimeParser();
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        public void MiddayShouldReturn_12_0()
        {
            var actual = _parser.Parse("12:00");
            Assert.AreEqual(12, actual.Item1);
            Assert.AreEqual(0, actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        public void MidnightShouldReturn_0_0()
        {
            var actual = _parser.Parse("0:00");
            Assert.AreEqual(0, actual.Item1);
            Assert.AreEqual(0, actual.Item2);
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        [ExpectedException(typeof(Exception))]
        public void TwentyFourShouldThrowException()
        {
            var actual = _parser.Parse("24:00");
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        [ExpectedException(typeof(Exception))]
        public void SeparatorShouldBeColon()
        {
            var actual = _parser.Parse("12.00");
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        [ExpectedException(typeof(Exception))]
        public void SixtyMinuteShouldThrowException()
        {
            var actual = _parser.Parse("1:60");
        }

        [TestMethod]
        [TestCategory("Test Time String Parser")]
        public void ThreeFifteenShouldReturn_3_15()
        {
            var actual = _parser.Parse("3:15");
            Assert.AreEqual(3, actual.Item1);
            Assert.AreEqual(15, actual.Item2);
        }
    }
}
