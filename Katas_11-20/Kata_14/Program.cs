using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BreakCamelCase("camelCasing"));

            Console.Read();
        }

        public static string BreakCamelCase(string str)
        {
            string tempStr = str;

            for (int i = str.Length-1; i >= 0; i--)
            {
                if (char.IsUpper(str[i]))
                {
                    tempStr = tempStr.Insert(i, " ");
                }
            }

            return tempStr;
        }
    }
}
