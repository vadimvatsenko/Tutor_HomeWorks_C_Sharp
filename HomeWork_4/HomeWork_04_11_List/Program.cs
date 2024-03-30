using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 11. Есть список имен Алексей Женя Григорий Арсений. Удалите из списка все имена, которые начинаются на букву А

namespace HomeWork_04_11_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Алексей", "Женя", "Григорий", "Арсений"
            };

            names.RemoveAll(p => p.Contains("А"));


            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
