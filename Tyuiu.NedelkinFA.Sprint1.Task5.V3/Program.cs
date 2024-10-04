using System;

namespace ThirdDigitFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное целое число:");
            int k = Convert.ToInt32(Console.ReadLine());

            int h = GetThirdDigitFromEnd(k);

            if (h != -1)
            {
                Console.WriteLine($"Третья от конца цифра числа {k} равна {h}.");
            }
            else
            {
                Console.WriteLine("Число содержит менее трех цифр.");
            }
        }

        static int GetThirdDigitFromEnd(int number)
        {
            if (number < 100)
            {
                return -1;
            }

            return (number / 100) % 10;
        }
    }
}