
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Programmation.Sprint2.Task0.V15.Lib
{
    public class DataService:ISprint2Task0V15
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] resultat = new bool[6];

            // Séquence attendue: (Faux, Faux, Vrai, Vrai, Faux, Faux)

            // 1. Faux: (x - y) != 2830  (3105 - 275 = 2830. 2830 != 2830 est Faux)
            resultat[0] = (x - y) != 2830;

            // 2. Faux: (x + y) < 3000   (3105 + 275 = 3380. 3380 < 3000 est Faux)
            resultat[1] = (x + y) < 3000;

            // 3. Vrai: (x / y) == 11    (3105 / 275 = 11 en division entière. 11 == 11 est Vrai)
            resultat[2] = (x / y) == 11;

            // 4. Vrai: (x % y) >= 55    (3105 % 275 = 80. 80 >= 55 est Vrai)
            resultat[3] = (x % y) >= 55;

            // 5. Faux: (x * y) > 1000000 (3105 * 275 = 853875. 853875 > 1000000 est Faux)
            resultat[4] = (x * y) > 1000000;

            // 6. Faux: (y - x) > -2800   (275 - 3105 = -2830. -2830 > -2800 est Faux)
            resultat[5] = (y - x) > -2800;

            return resultat;
        }
    }
}
        
