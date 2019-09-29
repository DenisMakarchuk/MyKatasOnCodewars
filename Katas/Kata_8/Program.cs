using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));

            Console.Read();
        }

        public static string ToJadenCase(string phrase)
        {
            return string.Join(" ", phrase.Split(' ').Select((x) => char.ToUpper(x[0]) + x.Remove(0, 1)));
        }
    }
}
