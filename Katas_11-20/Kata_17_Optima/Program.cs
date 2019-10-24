using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_17_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Beggars(new int[] { 1, 2, 3, 4, 5 }, 0))
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        public static int[] Beggars(int[] values, int n)
        {
            int[] beggars = new int[n];

            if (n == 0)
            {
                return beggars;
            }

            for (int i = 0; i < values.Length; i++)
            {
                beggars[i % n] += values[i];
            }

            return beggars;
        }
    }
}
