using System;

namespace ThirdDigitFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод положительного целого числа
            Console.WriteLine("Введите положительное целое число:");
            int k = Convert.ToInt32(Console.ReadLine());

            // Присвоение третьей от конца цифры переменной h
            int h = GetThirdDigitFromEnd(k);

            // Вывод результата
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
            // Проверка, что число имеет хотя бы три цифры
            if (number < 100)
            {
                return -1; // Возвращаем -1, если цифр меньше трех
            }

            // Извлечение третьей от конца цифры
            return (number / 100) % 10;
        }
    }
}