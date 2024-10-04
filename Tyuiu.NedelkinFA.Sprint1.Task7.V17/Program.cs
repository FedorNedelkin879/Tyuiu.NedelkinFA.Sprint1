using Tyuiu.NedelkinFA.Sprint1.Task7.V17.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y:");
        double y = Convert.ToDouble(Console.ReadLine());

        double z = (1 + Math.Sin(Math.Sqrt(x * x + 1))) / Math.Cos(12 * y - 4);

        Console.WriteLine($"Результат: z = {z}");
    }
}