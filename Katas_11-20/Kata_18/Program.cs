using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_18
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Count("aabb"))
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            int counter;

            for (int i = 0; i < str.Length; i++)
            {
                if (!dictionary.ContainsKey(str[i]))
                {
                    counter = 1;

                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i].Equals(str[j]))
                        {
                            counter++;
                        }
                    }

                    dictionary.Add(str[i], counter);
                }
            }

            return dictionary;
        }
    }
}
