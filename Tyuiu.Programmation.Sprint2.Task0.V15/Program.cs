using Tyuiu.Programmation.Sprint2.Task0.V15.Lib;
internal class Program
{
   
   
        static void Main(string[] args)
        {
            Console.Title = "Sprint 2 - Task 0 - V15";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" Programme : Comparaison de valeurs (x, y)");
            Console.WriteLine(" Auteur    : Votre Nom");
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();

            // Entrée des valeurs
            Console.Write("Entrez la valeur de x : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez la valeur de y : ");
            int y = Convert.ToInt32(Console.ReadLine());

            // Création de l’objet DataService
            DataService ds = new DataService();

            // Appel de la méthode GetCompareOperations
            bool[] resultat = ds.GetCompareOperations(x, y);

            // Affichage des résultats
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Résultats des comparaisons logiques :");
            Console.ResetColor();

            Console.WriteLine($"1. (x - y) != 2830        -> {resultat[0]}");
            Console.WriteLine($"2. (x + y) < 3000         -> {resultat[1]}");
            Console.WriteLine($"3. (x / y) == 11          -> {resultat[2]}");
            Console.WriteLine($"4. (x % y) >= 55          -> {resultat[3]}");
            Console.WriteLine($"5. (x * y) > 1000000      -> {resultat[4]}");
            Console.WriteLine($"6. (y - x) > -2800        -> {resultat[5]}");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exécution terminée. Appuyez sur une touche pour quitter.");
            Console.ResetColor();

            Console.ReadKey();
        }
    }


