using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT = WOD_2ed;

namespace WOD_2ed_Tests
{
    [TestClass]
    public class Willpower_Should
    {
        [DataTestMethod]
        [DataRow(11, 10)]
        [DataRow(12, 10)]
        [DataRow(50, 10)]
        [DataRow(99999, 10)]
        public void WillpowerShould_Return10_WhenStatsAddAbove10(int intAboveTen, int expected)
        {
            //Arrange
            var stats = new SUT.BaseStats();

            //Act
            stats.Willpower = intAboveTen;

            //Assert
            Assert.AreEqual(expected, stats.Willpower);
        }
    }
}
