using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT = WOD_2ed;

namespace WOD_2ed_Tests
{
    [TestClass]
    public class BaseStats_Tests
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

        [DataTestMethod]
        [DataRow(1, 6)]
        [DataRow(3, 8)]
        [DataRow(5, 10)]
        [DataRow(10, 15)]
        public void GetHealthShould_ReturnHealthOfStaminaPlus5_WhenCalled(int stamina, int expected)
        {
            //Arrange
            var stats = new SUT.BaseStats();

            //Act
            stats.Stamina.Value = stamina;
            stats.GetHealth();

            //Assert
            Assert.AreEqual(expected, stats.Health);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 4, 6)]
        [DataRow(5, 5, 10)]
        [DataRow(5, 6, 10)]
        [DataRow(50, 60, 10)]
        public void GetWillpowerShould_ReturnWillpowerEqualToResolvePlusComposure10Max_WhenCalled(int resolve, int composure, int expected)
        {
            //Arrange
            var stats = new SUT.BaseStats();

            //Act
            stats.Resolve.Value = resolve;
            stats.Composure.Value = composure;
            stats.GetWillPower();

            //Assert
            Assert.AreEqual(expected, stats.Willpower);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(5, 5, 10)]
        [DataRow(5, 6, 11)]
        [DataRow(50, 60, 110)]
        public void GetInitiativeModifierShould_ReturnInitiativeModifierEqualToDexterityPlusComposure_WhenCalled(int dexterity, int composure, int expected)
        {
            //Arrange
            var stats = new SUT.BaseStats();

            //Act
            stats.Dexterity.Value = dexterity;
            stats.Composure.Value = composure;
            stats.GetInitiativeModifier();

            //Assert
            Assert.AreEqual(expected, stats.InitiativeModifier);
        }

        [DataTestMethod]
        [DataRow(1, 1, 7)]
        [DataRow(2, 4, 11)]
        [DataRow(5, 5, 15)]
        [DataRow(5, 6, 16)]
        [DataRow(50, 60, 115)]
        public void GetSpeedShould_ReturnSpeedEqualToStrengthPlusDexterityPlus5_WhenCalled(int strength, int dexterity, int expected)
        {
            //Arrange
            var stats = new SUT.BaseStats();

            //Act
            stats.Strength.Value = strength;
            stats.Dexterity.Value = dexterity;
            stats.GetSpeed();

            //Assert
            Assert.AreEqual(expected, stats.Speed);
        }
    }
}
