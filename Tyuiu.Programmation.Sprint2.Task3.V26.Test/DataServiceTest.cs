
using Tyuiu.Programmation.Sprint2.Task3.V26.Lib;

namespace Tyuiu.Programmation.Sprint2.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        { }
              private DataService ds = new DataService();

        [TestMethod]
        public void CalculateY_WhenXEqualsZero_ReturnsCorrectValue()
        {
            // Arrange
            double x = 0;
            double expected = Math.Round(15.0 / 9.0, 3); // 1.667

            // Act
            double result = ds.Calculate(x); // <-- CORRIGÉ : Appel à Calculate(x)

            // Assert
            Assert.AreEqual(expected, result, 0.001, $"Pour X = {x}, Y devrait être {expected}, mais obtenu {result}");
        }

        [TestMethod]
        public void CalculateY_WhenXGreaterThanZero_ReturnsCorrectValue()
        {
            // Arrange
            double x = 1;
            double cosX2 = Math.Cos(x * x);
            double expected = Math.Round(x + Math.Pow((x + 1) / cosX2, x), 3);

            // Act
            double result = ds.Calculate(x); // <-- CORRIGÉ : Appel à Calculate(x)

            // Assert
            Assert.AreEqual(expected, result, 0.001, $"Pour X = {x}, Y devrait être {expected}, mais obtenu {result}");
        }

        // ... (Appliquez cette correction à toutes les autres méthodes de test) ...
    }
}
        