using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLDrevoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_text = System.IO.File.ReadAllText(@"big.txt");
            //string[] input_check = System.IO.File.ReadAllLines(@"check.txt");
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            long elapsedMs;

            /// 
            // the : 123
            // red : 456
            // ...
            // count: 1456
            // time:  4134

            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine("time:  " + elapsedMs);
        }
    }
}
