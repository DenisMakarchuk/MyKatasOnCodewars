using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_6_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("1 Sdad afa asdd df edfes"));

            Console.Read();
        }

        public static int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }
    }
}
