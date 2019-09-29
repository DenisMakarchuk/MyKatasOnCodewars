using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_7_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExpandedForm(12));
            Console.WriteLine(ExpandedForm(42));
            Console.WriteLine(ExpandedForm(703040));

            Console.Read();
        }

        public static string ExpandedForm(long num)
        {
            var str = num.ToString();

            return String.Join(" + ", str
                .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                .Where(x => x > 0));
        }
    }
}
