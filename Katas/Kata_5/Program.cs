using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BouncingBall(3,0.66,1.5));
            Console.WriteLine(BouncingBall(3,1,1.5));

            Console.Read();
        }

        public static int BouncingBall(double h, double bounce, double window)
        {
            if (bounce <= 0 || bounce >= 1 || h <= 0 || h <= window)
            {
                return -1;
            }

            int counter = 1;

            for (double i = bounce * h; i > window; counter +=2)
            {
                i *= bounce;
            }

            return counter;
        }
    }
}
