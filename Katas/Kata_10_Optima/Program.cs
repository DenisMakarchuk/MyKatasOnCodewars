using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_10_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Wave("two words");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        public static List<string> Wave(string str) =>  
            str.Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
            .Where(x => x != str)
            .ToList();
    }
}