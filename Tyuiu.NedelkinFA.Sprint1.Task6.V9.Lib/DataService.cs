using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NedelkinFA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            string[] words = value.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (var word in words)
            {
                if (word.Length > 0)
                {
                    char lastChar = word[word.Length - 1];
                    string newWord = lastChar + word.Substring(0, word.Length - 1); 
                    result += newWord + " "; 
                }
            }

            return result.Trim();
        }
    }
}
