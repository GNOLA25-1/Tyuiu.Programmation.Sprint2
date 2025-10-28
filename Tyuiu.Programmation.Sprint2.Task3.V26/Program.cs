
using Tyuiu.Programmation.Sprint2.Task3.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        System.Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        System.Console.WriteLine("║   Programme de Calcul de Fonction Y(X)                     ║");
        System.Console.WriteLine("║   Résultat arrondi à trois décimales                       ║");
        System.Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        System.Console.WriteLine();

        // Afficher la description de la fonction
        System.Console.WriteLine(ds.GetFunctionDescription());
        System.Console.WriteLine();

        // Demander la valeur de X à l'utilisateur
        System.Console.WriteLine("Entrez la valeur de X :");

        // Vérifier que l'entrée est un nombre valide
        if (!double.TryParse(System.Console.ReadLine(), out double x))
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Erreur : Veuillez entrer un nombre valide.");
            System.Console.ResetColor();
            System.Console.WriteLine("Appuyez sur une touche pour fermer...");
            System.Console.ReadKey();
            return;
        }

        System.Console.WriteLine();
        System.Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        System.Console.WriteLine("║ RÉSULTAT                                                   ║");
        System.Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        System.Console.WriteLine();

        // Calculer Y
        // Calculer Y
        double y = ds.Calculate(x); // <-- CORRECTION : Utiliser le nom de méthode correct


        // Afficher le résultat
        if (double.IsNaN(y))
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Erreur : La fonction n'est pas définie pour X = {x}");
            System.Console.WriteLine("(Cela peut être dû à une division par zéro ou à une opération mathématique invalide)");
            System.Console.ResetColor();
        }
        else
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"X = {x}");
            System.Console.WriteLine($"Y = {y}");
            System.Console.ResetColor();
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Appuyez sur une touche pour fermer...");
        System.Console.ReadKey();
    }
}
    