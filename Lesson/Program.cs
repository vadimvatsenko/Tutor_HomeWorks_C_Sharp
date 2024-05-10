using System;
using System.Diagnostics.Metrics;
using System.Threading.Channels;


namespace Lesson 
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            
            string str = "sdgsdg                    gergeergerg    \n\n\n\n\n wfegfeeg                  ergerg \n\n      erg                  erge    \n\n\n      erge       ergegregre    \n ge    ergerg";
            
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        counter++;
                        if (str[i] != ' ' && str[i] != '\n')
                        {
                            if (!result.ContainsKey(str[i]))
                            {

                                result.Add(str[i], counter);
                            }
                            else
                            {
                                result[str[i]] = counter;
                            }
                        }                        
                    }                    
                }
            }

            //var sortKey = result.OrderBy(x => x.Key);
            var sortResult = result.OrderByDescending(x => x.Value).ThenBy(p => p.Key);

            /*foreach (var v in result)
            {
                Console.WriteLine($"{v.Key.ToString().ToUpper()}: {v.Value}");
            }
            Console.WriteLine();*/
            foreach (var v in sortResult)
            {
                Console.WriteLine($"{v.Key.ToString().ToUpper()}: {v.Value}");
            }




        }
    }
}    
