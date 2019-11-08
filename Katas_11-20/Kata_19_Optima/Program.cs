using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_19_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighestRank(new int[] { 3, 6, 9, 5, 9, 11, 9, 3, 4, 3, 8, 5, 9, 3, 5, 6, 8, 5, 11 }));

            Console.Read();
        }

        public static int HighestRank(int[] arr)
        {
            return arr
              .GroupBy(i => i)
              .OrderByDescending(gr => gr.Count())
              .ThenByDescending(gr => gr.Key)
              .Select(gr => gr.Key)
              .First();
        }
    }
}
