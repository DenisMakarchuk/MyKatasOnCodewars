using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(3,2));

            Console.Read();
        }

        public static int GetSum(int a, int b)
        {
            int sum, counter;

            if (b > a)
            {
                counter = sum = a;
            }
            else
            {
                counter = sum = b;
            }

            for (int i = 0; i < Math.Abs(a - b); i++)
            {
                counter++;
                sum += counter;
            }

            return sum;
        }
    }
}
