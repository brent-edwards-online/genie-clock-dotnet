using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenieClock.Screen;

namespace GenieClock.Test
{
    [TestClass]
    public class TestFaceDigitGenerator
    {
        IFaceDigitGenerator _generator;

        [TestInitialize]
        public void Initialize()
        {
            _generator = new FaceDigitGenerator();
        }

        [TestMethod]
        [TestCategory("Test Face Digit Generator")]
        public void ZeroZeroGeneratesXAtZero()
        {
            var actual = _generator.Generate(0, 0);
            Assert.AreEqual(12, actual.Length);
            Assert.AreEqual('x', actual[0].character);
            Assert.AreEqual('o', actual[1].character);
            Assert.AreEqual('o', actual[2].character);
            Assert.AreEqual('o', actual[3].character);
            Assert.AreEqual('o', actual[4].character);
            Assert.AreEqual('o', actual[5].character);
            Assert.AreEqual('o', actual[6].character);
            Assert.AreEqual('o', actual[7].character);
            Assert.AreEqual('o', actual[8].character);
            Assert.AreEqual('o', actual[9].character);
            Assert.AreEqual('o', actual[10].character);
            Assert.AreEqual('o', actual[11].character);
        }

        [TestMethod]
        [TestCategory("Test Face Digit Generator")]
        public void ThirteenThirtyTwoGeneratesHAt1andMAt6()
        {
            var actual = _generator.Generate(13, 32);
            Assert.AreEqual(12, actual.Length);
            Assert.AreEqual('o', actual[0].character);
            Assert.AreEqual('h', actual[1].character);
            Assert.AreEqual('o', actual[2].character);
            Assert.AreEqual('o', actual[3].character);
            Assert.AreEqual('o', actual[4].character);
            Assert.AreEqual('o', actual[5].character);
            Assert.AreEqual('m', actual[6].character);
            Assert.AreEqual('o', actual[7].character);
            Assert.AreEqual('o', actual[8].character);
            Assert.AreEqual('o', actual[9].character);
            Assert.AreEqual('o', actual[10].character);
            Assert.AreEqual('o', actual[11].character);
        }

        [TestMethod]
        [TestCategory("Test Face Digit Generator")]
        public void HourGreaterThan23ReturnsAValidHour()
        {
            var actual = _generator.Generate(25, 15);
            Assert.AreEqual(12, actual.Length);
            Assert.AreEqual('o', actual[0].character);
            Assert.AreEqual('h', actual[1].character);
            Assert.AreEqual('o', actual[2].character);
            Assert.AreEqual('m', actual[3].character);
            Assert.AreEqual('o', actual[4].character);
            Assert.AreEqual('o', actual[5].character);
            Assert.AreEqual('o', actual[6].character);
            Assert.AreEqual('o', actual[7].character);
            Assert.AreEqual('o', actual[8].character);
            Assert.AreEqual('o', actual[9].character);
            Assert.AreEqual('o', actual[10].character);
            Assert.AreEqual('o', actual[11].character);
        }

        [TestMethod]
        [TestCategory("Test Face Digit Generator")]
        public void MinuteValueGreaterThan59ReturnsAValidMinute()
        {
            var actual = _generator.Generate(6, 71);
            Assert.AreEqual(12, actual.Length);
            Assert.AreEqual('o', actual[0].character);
            Assert.AreEqual('o', actual[1].character);
            Assert.AreEqual('m', actual[2].character);
            Assert.AreEqual('o', actual[3].character);
            Assert.AreEqual('o', actual[4].character);
            Assert.AreEqual('o', actual[5].character);
            Assert.AreEqual('h', actual[6].character);
            Assert.AreEqual('o', actual[7].character);
            Assert.AreEqual('o', actual[8].character);
            Assert.AreEqual('o', actual[9].character);
            Assert.AreEqual('o', actual[10].character);
            Assert.AreEqual('o', actual[11].character);
        }
    }
}
