using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_16_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateEncode("recede"));

            Console.Read();
        }

        public static string DuplicateEncode(string word)
        {
            return new string(word.ToUpper().Select(ch => 
                              word.ToUpper().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
        }
    }
}
