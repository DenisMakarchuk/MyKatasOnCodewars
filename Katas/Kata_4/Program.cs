using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));

            Console.Read();
        }

        public static string AlphabetPosition(string text)
        {
            string tempString = string.Empty;

            text = text.ToUpper();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    int num = text[i] - 'A' + 1;
                    tempString += num + " ";
                }
            }

            text = tempString.Trim(' ');

            return text;
        }
    }
}
