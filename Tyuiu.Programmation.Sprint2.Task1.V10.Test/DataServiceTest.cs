
using Tyuiu.Programmation.Sprint2.Task1.V10.Lib;

namespace Tyuiu.Programmation.Sprint2.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // Arrange
            // Définition des valeurs de test données dans la documentation
            int a = 455;
            int b = 335;
            int c = 14;
            int d = 17;

            // Séquence logique attendue selon la méthode GetExpectedSequence()
            bool[] attendu = new bool[] { true, false, false, false, true, false };

            // Act
            DataService ds = new DataService();
            bool[] resultat = ds.GetLogicOperations(a, b, c, d);

            // Assert
            // Vérifie que le tableau a la même longueur
            Assert.AreEqual(attendu.Length, resultat.Length,
                "Le nombre d'éléments dans le tableau n'est pas correct.");

            // Vérifie chaque valeur une par une
            for (int i = 0; i < attendu.Length; i++)
            {
                Assert.AreEqual(attendu[i], resultat[i],
                    $"L'élément à l'index {i} n'est pas correct (attendu: {attendu[i]}, obtenu: {resultat[i]}).");
            }
        }

        [TestMethod]
        public void CheckExpectedSequenceMethod()
        {
            // Arrange
            DataService ds = new DataService();

            // Act
            bool[] attendu = new bool[] { true, false, false, false, true, false };
            bool[] resultat = ds.GetExpectedSequence();

            // Assert
            CollectionAssert.AreEqual(attendu, resultat,
                "La séquence retournée par GetExpectedSequence() ne correspond pas à celle attendue.");
        }

        [TestMethod]
        public void CheckFormatSequenceOutput()
        {
            // Arrange
            DataService ds = new DataService();
            bool[] testSequence = new bool[] { true, false, true };

            // Act
            string resultat = ds.FormatSequence(testSequence);

            // Assert
            Assert.AreEqual("(Vrai, Faux, Vrai)", resultat,
                "La méthode FormatSequence() ne retourne pas le bon format de texte.");
        }
    }
}
        
