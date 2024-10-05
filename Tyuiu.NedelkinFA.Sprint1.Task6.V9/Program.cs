using Tyuiu.NedelkinFA.Sprint1.Task6.V9.Lib;

using System;

namespace WordTransformer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string result = string.Join(" ", Array.ConvertAll(Console.ReadLine().Split(' '),
                word => word.Length > 0 ? word[^1] + word[..^1] : ""));

            Console.WriteLine("Результат:");
            Console.WriteLine(result.Trim());
        }
    }
}