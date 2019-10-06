using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_5_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BouncingBall(3, 0.66, 1.5));
            Console.WriteLine(BouncingBall(3, 1, 1.5));

            Console.Read();
        }

        public static int BouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h) return -1;

            int result = -1;

            do
            {
                result += 2;
                h *= bounce;
            }
            while (h > window);

            return result;
        }
    }
}
