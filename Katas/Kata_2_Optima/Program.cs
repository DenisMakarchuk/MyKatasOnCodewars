using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_2_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogram("Dermatoglyphics"));
            Console.WriteLine(IsIsogram("moose"));
            Console.WriteLine(IsIsogram("aba"));

            Console.Read();
        }

        public static bool IsIsogram(string str)
        {
            return str.ToUpper().Distinct().Count() == str.Length;
        }
    }
}
