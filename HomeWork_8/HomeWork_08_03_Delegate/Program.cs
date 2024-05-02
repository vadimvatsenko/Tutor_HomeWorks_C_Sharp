using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Создайте делегат, который принимает 2 строки. Делегат должен возвращать строку. Создайте соответствующий метод. Пример на вход подается
	/*“Hello it is me”.
	“it”
	Результат: Ваша фраза содержит слово “it”. Если не содержит то написать соответствующее сообщение */

namespace HomeWork_08_03_Delegate
{
    delegate string ReturnTheWord(string sentence, string word);
    internal class Program
    {
        static void Main(string[] args)
        {
            ReturnTheWord find = FindWord;
            Console.WriteLine(find?.Invoke("Hello it is me", "is"));
        }

        static string FindWord(string sentence, string word) 
        {
            string[] words = sentence.Split(' ');

            foreach (string w  in words)
            {
                if (w == word)
                {
                    return w;
                }
            }
            return "No word";
        }
    }
}
