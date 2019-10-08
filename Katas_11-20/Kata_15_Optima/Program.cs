using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_15_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in UniqueInOrder(""))
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T previous = default(T);

            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
        }
    }
}
