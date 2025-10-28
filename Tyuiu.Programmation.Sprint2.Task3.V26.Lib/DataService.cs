
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Programmation.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double y = 0;

            // Cas 1: X > 0
            if (x > 0)
            {
                // Y = X + ((X+1)/cos(X²))^X
                double cosX2 = Math.Cos(x * x);

                // Vérifier que cos(X²) != 0 pour éviter une division par zéro
                if (Math.Abs(cosX2) < 0.0001)
                {
                    // Si cos(X²) est très proche de 0, retourner une valeur d'erreur ou une valeur par défaut
                    return double.NaN;
                }

                double fraction = (x + 1) / cosX2;
                double power = Math.Pow(fraction, x);
                y = x + power;
            }
            // Cas 2: X = 0
            else if (x == 0)
            {
                // Y = (15 + X) / (3² - sin(X²))
                // Y = (15 + 0) / (9 - sin(0))
                // Y = 15 / 9 = 1.667
                double numerator = 15 + x;
                double sinX2 = Math.Sin(x * x);
                double denominator = 9 - sinX2; // 3² = 9

                // Vérifier que le dénominateur != 0
                if (Math.Abs(denominator) < 0.0001)
                {
                    return double.NaN;
                }

                y = numerator / denominator;
            }
            // Cas 3: -30 < X < 0
            else if (x > -30 && x < 0)
            {
                // Y = (sin(X³)/(X+5))^X
                double sinX3 = Math.Sin(x * x * x);
                double denominator = x + 5;

                // Vérifier que le dénominateur != 0
                if (Math.Abs(denominator) < 0.0001)
                {
                    return double.NaN;
                }

                double fraction = sinX3 / denominator;

                // Vérifier que la fraction est positive pour pouvoir la lever à la puissance X (qui est négative)
                if (fraction <= 0)
                {
                    return double.NaN;
                }

                y = Math.Pow(fraction, x);
            }
            // Cas 4: X < -30
            else if (x < -30)
            {
                // Y = X + 7X - (1/X)
                // Y = 8X - (1/X)

                // Vérifier que X != 0 (ce qui est garanti ici car X < -30)
                if (Math.Abs(x) < 0.0001)
                {
                    return double.NaN;
                }

                y = x + (7 * x) - (1 / x);
            }

            // Arrondir le résultat à trois décimales
            y = Math.Round(y, 3);

            return y;
        }

        /// <summary>
        /// Retourne une description de la fonction Y(X).
        /// </summary>
        /// <returns>Description de la fonction</returns>
        public string GetFunctionDescription()
        {
            return @"Fonction Y(X):
- Si X > 0 : Y = X + ((X+1)/cos(X²))^X
- Si X = 0 : Y = (15 + X) / (3² - sin(X²))
- Si -30 < X < 0 : Y = (sin(X³)/(X+5))^X
- Si X < -30 : Y = X + 7X - (1/X)

Résultat arrondi à trois décimales.";
        }
    }
}
