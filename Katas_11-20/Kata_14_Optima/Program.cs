using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_14_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BreakCamelCase("camelCasing"));

            Console.Read();
        }

        public static string BreakCamelCase(string str)
        {
            return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        }
    }
}
