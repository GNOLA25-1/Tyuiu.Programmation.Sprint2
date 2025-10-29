
using Tyuiu.Programmation.Sprint2.V9.Lib;
namespace Tyuiu.Programmation.Sprint2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private readonly DataService ds = new DataService();

        [TestMethod]
        public void CheckDotInShadedArea_ReturnsTrue_WhenInside()
        {
            // Arrange
            int x = 5;
            int y = 6;

            // Act
            bool result = ds.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsTrue(result, "Le point (5,6) devrait être à l'intérieur de la zone ombrée.");
        }

        [TestMethod]
        public void CheckDotInShadedArea_ReturnsFalse_WhenOutside()
        {
            // Arrange
            int x = 1;
            int y = 15;

            // Act
            bool result = ds.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsFalse(result, "Le point (1,15) devrait être à l'extérieur de la zone ombrée.");
        }

        [TestMethod]
        public void AreCoordinatesValid_ReturnsTrue_WhenInRange()
        {
            // Arrange
            int x = 10;
            int y = 12;

            // Act
            bool result = ds.AreCoordinatesValid(x, y);

            // Assert
            Assert.IsTrue(result, "Les coordonnées (10,12) devraient être valides.");
        }

        [TestMethod]
        public void AreCoordinatesValid_ReturnsFalse_WhenOutOfRange()
        {
            // Arrange
            int x = 0;
            int y = 20;

            // Act
            bool result = ds.AreCoordinatesValid(x, y);

            // Assert
            Assert.IsFalse(result, "Les coordonnées (0,20) sont hors limites et devraient être invalides.");
        }

        [TestMethod]
        public void GetShadedAreaDescription_ReturnsExpectedText()
        {
            // Act
            string description = ds.GetShadedAreaDescription();

            // Assert
            Assert.IsTrue(description.Contains("Zone ombrée"), "La description devrait contenir 'Zone ombrée'.");
            Assert.IsTrue(description.Contains("2"), "La description devrait mentionner les bornes 2 et 12.");
            Assert.IsTrue(description.Contains("12"), "La description devrait mentionner les bornes 2 et 12.");
        }

        [TestMethod]
        public void GetShadedAreaBounds_ReturnsCorrectValues()
        {
            // Act
            var bounds = ds.GetShadedAreaBounds();

            // Assert
            Assert.AreEqual(2, bounds.xMin, "La borne X minimale doit être 2.");
            Assert.AreEqual(12, bounds.xMax, "La borne X maximale doit être 12.");
            Assert.AreEqual(2, bounds.yMin, "La borne Y minimale doit être 2.");
            Assert.AreEqual(12, bounds.yMax, "La borne Y maximale doit être 12.");
        }
    }
}