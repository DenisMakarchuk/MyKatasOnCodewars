using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_3_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(binaryArrayToNumber(new int[] { 0, 0, 0, 1 }));
            Console.WriteLine(binaryArrayToNumber(new int[] { 0, 0, 1, 0 }));
            Console.WriteLine(binaryArrayToNumber(new int[] { 0, 1, 0, 1 }));
            Console.WriteLine(binaryArrayToNumber(new int[] { 1, 0, 0, 1 }));
            Console.WriteLine(binaryArrayToNumber(new int[] { 0, 1, 1, 0 }));
            Console.WriteLine(binaryArrayToNumber(new int[] { 1, 1, 1, 1 }));
            Console.WriteLine(binaryArrayToNumber(new int[] { 1, 0, 1, 1 }));

            Console.Read();
        }

        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            return Convert.ToInt32(string.Join("", BinaryArray), 2);
        }
    }
}