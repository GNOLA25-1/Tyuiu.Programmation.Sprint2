
using Tyuiu.Programmation.Sprint2.Task0.V15.Lib;

namespace Tyuiu.Programmation.Sprint2.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // Arrange
            // Les valeurs d'entrée spécifiées par l'utilisateur
            int x = 3105;
            int y = 275;

            // La séquence logique attendue : (Faux, Faux, Vrai, Vrai, Faux, Faux)
            bool[] attendu = new bool[] { false, false, true, true, false, false };

            // Act
            // Appel de la méthode de votre bibliothèque
            // Assurez-vous que la classe DataService et la méthode GetCompareOperations existent dans le projet de bibliothèque
            DataService ds = new DataService(); // Si la méthode est non-statique
            bool[] resultat = ds.GetCompareOperations(x, y);

            // Assert
            // 1. Vérifie que le nombre d'éléments est le même
            Assert.AreEqual(attendu.Length, resultat.Length, "Le nombre d'éléments dans le tableau de résultat n'est pas correct.");

            // 2. Vérifie que chaque élément correspond à la séquence attendue
            for (int i = 0; i < attendu.Length; i++)
            {
                Assert.AreEqual(attendu[i], resultat[i], $"L'élément à l'index {i} n'est pas correct.");
            }
        }
    }
}
       
