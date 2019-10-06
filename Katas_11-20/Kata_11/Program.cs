using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("Test"));

            Console.Read();
        }

        public static string Rot13(string message)
        {
            char[] tempStr = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {

                    tempStr[i] = Convert.ToChar(message[i] + 13);

                    if ((char.IsUpper(message[i]) && char.IsUpper(tempStr[i])) || (char.IsLower(message[i]) && char.IsLower(tempStr[i])))
                    {
                        continue;
                    }
                    else if (char.IsUpper(message[i]))
                    {
                        tempStr[i] = Convert.ToChar(tempStr[i] - 'Z' + 'A' - 1);
                    }
                    else if(char.IsLower(message[i]))
                    {
                        tempStr[i] = Convert.ToChar(tempStr[i] - 'z' + 'a' - 1);
                    }
                    
                    continue;
                }

                tempStr[i] = message[i];
            }

            return string.Join("", tempStr);
        }
    }
}
