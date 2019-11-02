using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_12_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(3, 2));

            Console.Read();
        }

        public static int GetSum(int a, int b)
        {
            return (a + b) * (Math.Abs(a - b) + 1) / 2;
        }
    }
}
