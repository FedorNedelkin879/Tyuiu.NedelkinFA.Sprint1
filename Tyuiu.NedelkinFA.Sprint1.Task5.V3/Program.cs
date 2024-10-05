using System;

namespace ThirdDigitFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int k = Convert.ToInt32(Console.ReadLine());
            int h = GetThirdDigitFromEnd(k);
            if (h != -1) Console.WriteLine($" {h}.");
        }

        static int GetThirdDigitFromEnd(int number) => number < 100 ? -1 : (number / 100) % 10;
    }
}