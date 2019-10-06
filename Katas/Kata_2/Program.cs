using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogram("Dermatoglyphics"));
            Console.WriteLine(IsIsogram("moose"));
            Console.WriteLine(IsIsogram("aba"));

            Console.Read();
        }

        public static bool IsIsogram(string str)
        {
            if (str.Equals(string.Empty))
            {
                return true;
            }

            str = str.ToUpper();

            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {

                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
