using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_4_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));

            Console.Read();
        }

        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToUpper().Where(char.IsLetter).Select(x => x - 'A' + 1));
        }
    }
}
