
using Tyuiu.Programmation.Sprint2.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Sprint 2 - Task 2 - Vérification de la zone ombrée";
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine(" Programme : Vérification d’un point dans une zone");
        Console.WriteLine(" Auteur    : Votre Nom");
        Console.WriteLine("------------------------------------------------------");
        Console.ResetColor();

        // Création d’un objet du service
        DataService dataService = new DataService();

        // Demande à l’utilisateur d’entrer les coordonnées
        Console.Write("Entrez la coordonnée X (1 à 15) : ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Entrez la coordonnée Y (1 à 15) : ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        // Vérification de validité
        if (!dataService.AreCoordinatesValid(x, y))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Les coordonnées sont invalides. Veuillez entrer des valeurs entre 1 et 15.");
            Console.ResetColor();
        }
        else
        {
            // Vérifie si le point est dans la zone ombrée
            bool inside = dataService.CheckDotInShadedArea(x, y);

            if (inside)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Le point ({x},{y}) est DANS la zone ombrée.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Le point ({x},{y}) est HORS de la zone ombrée.");
            }
            Console.ResetColor();

            // Affiche les informations sur la zone
            Console.WriteLine();
            Console.WriteLine(dataService.GetShadedAreaDescription());
            var (xMin, xMax, yMin, yMax) = dataService.GetShadedAreaBounds();
            Console.WriteLine($"Limites : X({xMin}-{xMax}), Y({yMin}-{yMax})");
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Appuyez sur une touche pour quitter...");
        Console.ResetColor();
        Console.ReadKey();
    }
}

