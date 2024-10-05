using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NedelkinFA.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double lol = 1 + Math.Sin(Math.Sqrt(x * x + 1));
            double kek = Math.Cos(12 * y - 4);

            return Math.Round(lol / kek, 3);
        }
    }
}
