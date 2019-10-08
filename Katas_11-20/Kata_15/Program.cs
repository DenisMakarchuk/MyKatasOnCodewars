using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_15
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
            List<T> enumerable = new List<T>();

            if (iterable.ToString() == string.Empty)
            {
                return iterable;
            }
            else
            {
                var prev = iterable.FirstOrDefault();

                enumerable.Add(prev);

                foreach (var item in iterable)
                {
                    if (!object.Equals(item, prev))
                    {
                        prev = item;

                        enumerable.Add(prev);
                    }
                }
            }

            return enumerable;
        }
    }
}
