using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_16
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
            return string.Join("", word.ToUpper().Select((val) => 
                                   word.ToUpper().IndexOf(val) == word.ToUpper().LastIndexOf(val) ? '(' : ')'));
        }
    }
}
