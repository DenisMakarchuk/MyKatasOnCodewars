using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_7
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
            StringBuilder stringBuilder = new StringBuilder();
            string str = Convert.ToString(num);
            int counterOfZero = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!string.Equals(str[i],'0'))
                {
                    if (i > 0)
                    {
                        stringBuilder.Append(" + ");
                    }

                    counterOfZero = str.Length - i - 1;
                    stringBuilder.Append(str[i]);

                    while (counterOfZero > 0)
                    { 
                        stringBuilder.Append("0");
                        counterOfZero--;
                    }
                }
            }

            return str = Convert.ToString(stringBuilder);
        }
    }
}
