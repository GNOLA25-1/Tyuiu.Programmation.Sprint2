
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Programmation.Sprint2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        private const int X_MIN = 2;
        private const int X_MAX = 12;
        private const int Y_MIN = 2;
        private const int Y_MAX = 12;

        // ✅ Cette méthode correspond exactement à ton interface
        public bool CheckDotInShadedArea(int x, int y)
        {
            return x >= X_MIN && x <= X_MAX && y >= Y_MIN && y <= Y_MAX;
        }

        public bool AreCoordinatesValid(int x, int y)
        {
            return x >= 1 && x <= 15 && y >= 1 && y <= 15;
        }

        public string GetShadedAreaDescription()
        {
            return $"Zone ombrée : rectangle défini entre ({X_MIN},{Y_MIN}) et ({X_MAX},{Y_MAX}).";
        }

        public (int xMin, int xMax, int yMin, int yMax) GetShadedAreaBounds()
        {
            return (X_MIN, X_MAX, Y_MIN, Y_MAX);
        }
    }
}