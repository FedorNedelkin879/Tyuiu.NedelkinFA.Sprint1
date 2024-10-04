using Tyuiu.NedelkinFA.Sprint1.Task6.V9.Lib;

using System;

namespace WordTransformer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            // Разделяем текст на слова
            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (var word in words)
            {
                if (word.Length > 0)
                {
                    // Переносим последнюю букву в начало слова
                    char lastChar = word[word.Length - 1];
                    string newWord = lastChar + word.Substring(0, word.Length - 1);
                    result += newWord + " ";
                }
            }

            Console.WriteLine("Результат:");
            Console.WriteLine(result.Trim());
        }
    }
}