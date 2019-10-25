using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_18_Optima
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
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
