using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_17
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
            if (n == 0) 
            {
                return new int[0];
            }

            int[] beggars = new int[n];
            int counter = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (counter<n)
                {
                    beggars[counter] += values[i];
                    counter++;
                }
                else
                {
                    beggars[0] += values[i];
                    counter = 1;
                }
            }

            return beggars;
        }
    }
}
