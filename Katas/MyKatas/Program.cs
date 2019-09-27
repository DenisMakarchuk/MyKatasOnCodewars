using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetIntegersFromList(new List<object>() { 1, 2, "a", "b" }).ToList<int>().ForEach(Console.WriteLine);
            Console.WriteLine();
            GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 }).ToList<int>().ForEach(Console.WriteLine);
            Console.WriteLine();
            GetIntegersFromList(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 }).ToList<int>().ForEach(Console.WriteLine);

            Console.Read();
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> returnList = new List<int>();
            int tempInt;

            foreach (var item in listOfItems)
            {
                try
                {
                    tempInt = (int)item;
                    returnList.Add(tempInt);
                }
                catch
                {
                    continue;
                }
            }

            return returnList;
        }
    }
}
