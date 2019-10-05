using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_10
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

        public static List<string> Wave(string str)
        {
            List<string> myList = new List<string>();

            str = str.ToLower();
            char[] tempStr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(' '))
                {
                    continue;
                }

                tempStr = str.ToCharArray();
                tempStr[i] = char.ToUpper(tempStr[i]);

                myList.Add(string.Join("", tempStr));
            }

            return myList;
        }
    }
}
