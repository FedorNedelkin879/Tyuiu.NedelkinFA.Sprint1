using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NedelkinFA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value; // Возвращаем пустую строку, если слово пустое

            char lastChar = value[value.Length - 1]; // Получаем последнюю букву
            string newWord = lastChar + value.Substring(0, value.Length - 1); // Переносим ее в начало
            return newWord;
        }
    }
}
