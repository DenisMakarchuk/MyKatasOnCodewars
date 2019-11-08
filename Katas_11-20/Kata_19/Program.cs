using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighestRank( new int[] { 3, 6, 9, 5, 9, 11, 9, 3, 4, 3, 8, 5, 9, 3, 5, 6, 8, 5, 11 }));

            Console.Read();
        }

        public static int HighestRank(int[] arr)
        {
            int[,] tempArr = new int[arr.Length + 1, 2];
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }

                tempArr[i, 0] = arr[i];
                tempArr[i, 1] = counter;
            }

            int maxVal = tempArr[0,0];
            counter = tempArr[0, 1];

            for (int i = 1; i < arr.Length; i++)
            {
                if (counter < tempArr[i,1])
                {
                    maxVal = tempArr[i, 0];
                    counter = tempArr[i, 1];
                }
                else if (counter == tempArr[i, 1])
                {
                    if (maxVal < tempArr[i, 0])
                    {
                        maxVal = tempArr[i, 0];
                    }
                }
            }

            return maxVal;
        }
    }
}
