using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_11_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("Test"));

            Console.Read();
        }

        public static string Rot13(string message)
        {
            return String.Join("", message.Select(x => char.IsLetter(x) ? (x >= 65 && x <= 77) 
            || (x >= 97 && x <= 109) ? (char)(x + 13) : (char)(x - 13) : x));
        }
    }
}
