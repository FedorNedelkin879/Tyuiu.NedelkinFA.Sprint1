using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NedelkinFA.Sprint1.Task1.V22.Lib
{
    public class DataService : ISprint1Task1V22
    {
        public double Calculate(double x, double y)
        {
            return x / (1 - y); 
        }
    }
}
