
using Tyuiu.Programmation.Sprint2.Task1.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        System.Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        System.Console.WriteLine("║   Programme de Comparaison Logique et Arithmétique        ║");
        System.Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        System.Console.WriteLine();

        // Valeurs de test
        int a = 455;
        int b = 335;
        int c = 14;
        int d = 17;

        System.Console.WriteLine($"Valeurs d'entrée:");
        System.Console.WriteLine($"  a = {a}");
        System.Console.WriteLine($"  b = {b}");
        System.Console.WriteLine($"  c = {c}");
        System.Console.WriteLine($"  d = {d}");
        System.Console.WriteLine();

        // Création de l'instance de DataService
        DataService ds = new DataService();

        // Calcul de la séquence logique
        bool[] resultat = ds.GetLogicOperations(a, b, c, d);
        bool[] attendu = ds.GetExpectedSequence();

        System.Console.WriteLine("Résultat obtenu:");
        System.Console.WriteLine($"  {ds.FormatSequence(resultat)}");
        System.Console.WriteLine();

        System.Console.WriteLine("Résultat attendu:");
        System.Console.WriteLine($"  {ds.FormatSequence(attendu)}");
        System.Console.WriteLine();

        // Vérification
        bool valide = VerifierSequence(resultat, attendu);

        if (valide)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("✓ Succès! La séquence logique est correcte.");
            System.Console.ResetColor();
        }
        else
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("✗ Erreur! La séquence logique ne correspond pas.");
            System.Console.ResetColor();
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Détail des opérations:");
        System.Console.WriteLine();

        AfficherDetailsOperations(a, b, c, d);
    }

    private static bool VerifierSequence(bool[] resultat, bool[] attendu)
    {
        if (resultat.Length != attendu.Length)
            return false;

        for (int i = 0; i < resultat.Length; i++)
        {
            if (resultat[i] != attendu[i])
                return false;
        }

        return true;
    }

    private static void AfficherDetailsOperations(int a, int b, int c, int d)
    {
        // 1. Vrai: (a > b) && (c < d)
        System.Console.WriteLine($"1. (a > b) && (c < d)");
        System.Console.WriteLine($"   ({a} > {b}) && ({c} < {d})");
        System.Console.WriteLine($"   {(a > b)} && {(c < d)} → {(a > b) && (c < d)} (Vrai)");
        System.Console.WriteLine();

        // 2. Faux: (a == b) || (c == d)
        System.Console.WriteLine($"2. (a == b) || (c == d)");
        System.Console.WriteLine($"   ({a} == {b}) || ({c} == {d})");
        System.Console.WriteLine($"   {(a == b)} || {(c == d)} → {(a == b) || (c == d)} (Faux)");
        System.Console.WriteLine();

        // 3. Faux: (a + b) > 800 && (c - d) != -3
        System.Console.WriteLine($"3. (a + b) > 800 && (c - d) != -3");
        System.Console.WriteLine($"   ({a} + {b}) > 800 && ({c} - {d}) != -3");
        System.Console.WriteLine($"   {(a + b)} > 800 && {(c - d)} != -3 → {((a + b) > 800)} && {((c - d) != -3)} = {((a + b) > 800 && (c - d) != -3)} (Faux)");
        System.Console.WriteLine();

        // 4. Faux: (a < b) && (d > c)
        System.Console.WriteLine($"4. (a < b) && (d > c)");
        System.Console.WriteLine($"   ({a} < {b}) && ({d} > {c})");
        System.Console.WriteLine($"   {(a < b)} && {(d > c)} → {(a < b) && (d > c)} (Faux)");
        System.Console.WriteLine();

        // 5. Vrai: (a - b) >= 120 && (c + d) == 31
        System.Console.WriteLine($"5. (a - b) >= 120 && (c + d) == 31");
        System.Console.WriteLine($"   ({a} - {b}) >= 120 && ({c} + {d}) == 31");
        System.Console.WriteLine($"   {(a - b)} >= 120 && {(c + d)} == 31 → {((a - b) >= 120)} && {((c + d) == 31)} = {((a - b) >= 120 && (c + d) == 31)} (Vrai)");
        System.Console.WriteLine();

        // 6. Faux: (a * b) < 150000 || (d - c) <= 2
        System.Console.WriteLine($"6. (a * b) < 150000 || (d - c) <= 2");
        System.Console.WriteLine($"   ({a} * {b}) < 150000 || ({d} - {c}) <= 2");
        System.Console.WriteLine($"   {(a * b)} < 150000 || {(d - c)} <= 2 → {((a * b) < 150000)} || {((d - c) <= 2)} = {((a * b) < 150000 || (d - c) <= 2)} (Faux)");
    }
}
    