using System.Text;
using CountryDefinerLib;

namespace PhoneDefinerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SameCountryAllKnown()
        {
            string testingString = "+375(29)123 45 67; 375 29 123 45 67; 375(29)123-45-67; +375-29-123-45-67";
            StringBuilder expected = new StringBuilder("�������� +375(29)123 45 67\n�������� 375 29 123 45 67\n�������� 375(29)123-45-67\n�������� +375-29-123-45-67\n");
            Definer definer = new Definer(testingString);
            Assert.AreEqual(expected.ToString(), definer.defineCoutries().ToString());
        }
        [TestMethod]
        public void DifferentCountriesKnown()
        {
            string testingString = "+375(29)123 45 67; 355 29 123 45 67; 244(29)123-45-67; +374-29-123-45-67";
            StringBuilder expected = new StringBuilder("�������� +375(29)123 45 67\n������� 355 29 123 45 67\n������ 244(29)123-45-67\n������� +374-29-123-45-67\n");
            Definer definer = new Definer(testingString);
            Assert.AreEqual(expected.ToString(), definer.defineCoutries().ToString());
        }
        [TestMethod]
        public void DifferentCountriesUnknownOrDmaged()
        {
            string testingString = "+123 45 67; 1364332; 1401(29)123-45-67; +378-29-123-45-67; 18hg7234";
            StringBuilder expected = new StringBuilder("");
            Definer definer = new Definer(testingString);
            Assert.AreEqual(expected.ToString(), definer.defineCoutries().ToString());
        }
    }
}