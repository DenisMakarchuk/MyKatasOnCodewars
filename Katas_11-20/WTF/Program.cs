using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Kata_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Stat("01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17"));

            Console.Read();
        }

        public static string Stat(string strg)
        {
            TimeSpan[] time = strg.Split(',',' ').Where(x => !string.Equals(x, ""))
                .Select(x => DateTime.Parse(string.Join(":", x.Split('|'))).TimeOfDay).ToArray();

            TimeSpan range = TimeSpan.FromSeconds(Math.Abs(time.Select(x => x).Min(x => x.TotalSeconds) 
                - time.Select(x => x).Max(x => x.TotalSeconds)));

            TimeSpan average = TimeSpan.FromSeconds((int)time.Average(x => x.TotalSeconds));

            TimeSpan median = time.Aggregate((x, y) => Math.Abs(x.TotalSeconds - average.TotalSeconds) 
                            < Math.Abs(y.TotalSeconds - average.TotalSeconds) ? x : y);

            return $"Range: {string.Join("|", range.ToString().Split(':'))} " +
                $"Average: {string.Join("|", average.ToString().Split(':'))} " +
                $"Median: {string.Join("|", median.ToString().Split(':'))}";
        }
    }
}
