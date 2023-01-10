using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegralLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralLib.Tests
{
    [TestClass()]
    public class RectangleintegralTests
    {
        [TestMethod()]
        public void RectangleIntegralCalculateTestNan()
        {
            double leftSide = -3.4;
            double rightSide = 4.3;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(Double.NaN, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestNumb1()
        {
            double leftSide = 38.1;
            double rightSide = 64.982;
            double expected = 87.43321257233667;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestNumber2()
        {
            double leftSide = 8.2;
            double rightSide = 11.3;
            double expected = 9.2012049223072;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestNumb3()
        {
            double leftSide = 14.9234;
            double rightSide = 15.06;
            double expected = 0.4227130950806783;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestNumb4()
        {
            double leftSide = 0.99;
            double rightSide = 1;
            double expected = 0.012203986806889803;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestNumb5()
        {
            double leftSide = 1;
            double rightSide = 100;
            double expected = 313.8410993399631;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestNumb6()
        {
            double leftSide = -15.28;
            double rightSide = 11.3;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(Double.NaN, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestNumb7()
        {
            double leftSide = 0;
            double rightSide = 1000.1;
            double expected = 3292.507594531231;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestNumb8()
        {
            double leftSide = 78.78;
            double rightSide = 87.87;
            double expected = 29.798107755382823;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestBellowZero()
        {
            double leftSide = -8.92;
            double rightSide = -1.287;
            double expected = 26.53687249401745;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateTestZero()
        {
            double leftSide = 0;
            double rightSide = 0;
            double expected = 0;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleIntegralCalculateUnexisting()
        {
            double leftSide = 12.402;
            double rightSide = 9.783;
            Rectangleintegral TestingIntegral = new Rectangleintegral(leftSide, rightSide);
            double result = TestingIntegral.RectangleIntegralCalculate();
            Assert.AreEqual(0, result);
        }
    }
}