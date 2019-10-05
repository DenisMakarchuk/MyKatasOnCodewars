using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsTriangle(5,7,9));

            Console.Read();
        }

        public static bool IsTriangle(int a, int b, int c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a && a > 0 && b > 0 && c > 0)
            {
                return true;
            }

            return false;
        }
    }
}
