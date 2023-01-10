using customArrsLib;
namespace singleArrsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getLengthTest()
        {
            int trueLength = 9;
            double[] testArr = { -12.452, 38, 0, 7.402, 22, 0, 208, -101, 2.04 };
            SingleArr testMass = new SingleArr(testArr);
            Assert.AreEqual(trueLength, testMass.getLength());
        }

        [TestMethod]
        public void getAnElementTest()
        {
            double trueElement = 22;
            int trueIndex = 4;
            double[] testArr = { -12.452, 38, 0, 7.402, 22, 0, 208, -101, 2.04 };
            SingleArr testMass = new SingleArr(testArr);
            Assert.AreEqual(trueElement, testMass.getAnEllement(4));
        }

        [TestMethod]
        public void negativeTestAll()
        {
            int trueAmount = 2;
            double[] testArr = { -12.452, 38, 0, 7.402, 22, 0, 208, -101, 2.04 };
            SingleArr testMass = new SingleArr(testArr);
            Assert.AreEqual(trueAmount, testMass.getAmountOfNegative());
        }

        [TestMethod]
        public void negativeTestInd()
        {
            int trueInd = 2;
            int trueAmount = 3;
            double[] testArr = { -12.452, 38, 0, 7.402, -22, 0, 208, -101, -2.04 };
            SingleArr testMass = new SingleArr(testArr);
            Assert.AreEqual(trueAmount, testMass.getAmountOfNegative(trueInd));
        }

        [TestMethod]
        public void negativeTestAbove()
        {
            int trueAmount = 2;
            double trueAbove = -100;
            double[] testArr = { -12.452, 38, 0, -7.402, 22, 0, 208, -101, 2.04 };
            SingleArr testMass = new SingleArr(testArr);
            Assert.AreEqual(trueAmount, testMass.getAmountOfNegative(trueAbove));
        }

        [TestMethod]
        public void convertTest()
        {
            int trueAmount = 8;
            int[] trueConvertedArr = { 1, 1, 1, 1, 1, 1, 1, 1 };
            Assert.IsTrue(Enumerable.SequenceEqual(trueConvertedArr, SingleArr.convertToArr(trueAmount)));
        }

        [TestMethod]
        public void multiplicationTest()
        {
            double[] arr1 = { 1, 2.4, 5.8, 11.0 };
            double[] arr2 = { 1, 2.4, 5.8, 11.0, 4.2, 8.099 };
            double[] trueArr = {1, 5.76, 33.64, 121, 4.2, 8.099};
            Assert.IsTrue(Enumerable.SequenceEqual(trueArr, SingleArr.multiplication(arr1, arr2)));
        }
    }
}