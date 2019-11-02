using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_13_Optima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Number(new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } }));

            Console.Read();
        }

        public static int Number(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Sum(Item => Item[0] - Item[1]);
        }
    }
}
