
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Programmation.Sprint2.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] resultat = new bool[6];

            // Opération 1: Vrai
            // (a > b) && (c < d) = (455 > 335) && (14 < 17) = Vrai && Vrai = Vrai
            resultat[0] = (a > b) && (c < d);

            // Opération 2: Faux
            // (a == b) || (c == d) = (455 == 335) || (14 == 17) = Faux || Faux = Faux
            resultat[1] = (a == b) || (c == d);

            // Opération 3: Faux
            // (a + b) > 800 && (c - d) != -3 = (790) > 800 && (-3) != -3 = Faux && Faux = Faux
            resultat[2] = (a + b) > 800 && (c - d) != -3;

            // Opération 4: Faux
            // !(a < b) || (d <= c) = !(455 < 335) || (17 <= 14) = !Faux || Faux = Vrai || Faux = Vrai
            // Mais on veut Faux, donc: (a < b) && (d > c)
            // (455 < 335) && (17 > 14) = Faux && Vrai = Faux
            resultat[3] = (a < b) && (d > c);

            // Opération 5: Vrai
            // (a - b) >= 120 && (c + d) == 31 = (120) >= 120 && (31) == 31 = Vrai && Vrai = Vrai
            resultat[4] = (a - b) >= 120 && (c + d) == 31;

            // Opération 6: Faux
            // (a * b) < 150000 || (d - c) <= 2 = (152425) < 150000 || (3) <= 2 = Faux || Faux = Faux
            resultat[5] = (a * b) < 150000 || (d - c) <= 2;

            return resultat;
        }

        /// <summary>
        /// Retourne la séquence logique attendue pour validation.
        /// </summary>
        /// <returns>Tableau booléen attendu: (Vrai, Faux, Faux, Faux, Vrai, Faux)</returns>
        public bool[] GetExpectedSequence()
        {
            return new bool[] { true, false, false, false, true, false };
        }

        /// <summary>
        /// Convertit un tableau de booléens en chaîne lisible.
        /// </summary>
        /// <param name="sequence">Tableau de booléens</param>
        /// <returns>Chaîne formatée</returns>
        public string FormatSequence(bool[] sequence)
        {
            var elements = sequence.Select(b => b ? "Vrai" : "Faux");
            return "(" + string.Join(", ", elements) + ")";
        }
    }
}
        
