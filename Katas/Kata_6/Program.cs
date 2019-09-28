using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_6
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
            int num = s.Length, tempNum = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {

                if (char.IsDigit(s[i]) || char.IsLetter(s[i]))
                {
                    tempNum++;
                }
                else
                {
                    if (tempNum < num && tempNum != 0)
                    {
                        num = tempNum;
                    }
                    tempNum = 0;
                }
            }

            if (tempNum < num)
            {
                num = tempNum;
            }

            return num;
        }
    }
}
