using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryArrayToNumber(new int[] { 0, 0, 0, 1 }));
            Console.WriteLine(BinaryArrayToNumber(new int[] { 0, 0, 1, 0 }));
            Console.WriteLine(BinaryArrayToNumber(new int[] { 0, 1, 0, 1 }));
            Console.WriteLine(BinaryArrayToNumber(new int[] { 1, 0, 0, 1 }));
            Console.WriteLine(BinaryArrayToNumber(new int[] { 0, 1, 1, 0 }));
            Console.WriteLine(BinaryArrayToNumber(new int[] { 1, 1, 1, 1 }));
            Console.WriteLine(BinaryArrayToNumber(new int[] { 1, 0, 1, 1 }));

            Console.Read();
        }

        public static int BinaryArrayToNumber(int[] binaryArray)
        {
            int degree = 0;
            int num = 0;

            for (int i = binaryArray.Length - 1; i >= 0; i--)
            {
                if (binaryArray[i] != 0)
                {
                    num += (int)Math.Pow(2, degree);
                }

                degree++;
            }

            return num;
        }
    }
}