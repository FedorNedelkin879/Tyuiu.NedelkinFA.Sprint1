using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NedelkinFA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value; // Возвращаем пустую строку, если значение пустое

            // Разделяем текст на слова
            string[] words = value.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
                return value; // Если нет слов, возвращаем исходное значение

            string lastWord = words[words.Length - 1]; // Получаем последнее слово
            char lastChar = lastWord[lastWord.Length - 1]; // Получаем последнюю букву последнего слова

            // Формируем новый текст с переносом последней буквы
            string newValue = lastChar + value.Substring(0, value.Length - lastWord.Length) + lastWord.Substring(0, lastWord.Length - 1);
            return newValue;
        }
    }
}
