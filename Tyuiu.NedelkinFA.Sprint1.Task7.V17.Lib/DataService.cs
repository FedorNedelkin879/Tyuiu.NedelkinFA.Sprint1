using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NedelkinFA.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double numerator = 1 + Math.Sin(Math.Sqrt(x * x + 1));
            double denominator = Math.Cos(12 * y - 4);

            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменатель равен нулю. Проверьте значение y.");
            }

            return Math.Round(numerator / denominator, 3);
        }
    }
}
