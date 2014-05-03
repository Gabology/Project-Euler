using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ProjectEuler5
{
    class Program
    {
        // Smallest multiple
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        static void Main(string[] args)
        {
            Stopwatch timer = Stopwatch.StartNew();
            var numbers = Enumerable.Range(1, 20);
            int start = 1;
            int result;

            while (true)
            {
                if (numbers.All(n => start % n == 0))
                {
                    result = start;
                    break;
                }
                start++;
            }
            timer.Stop();

            Console.WriteLine(result);
            Console.WriteLine("Elapsed time: " + timer.ElapsedMilliseconds + " ms");
            Console.ReadKey();
            // This method can probably be heavily optimized but it finishes in 25 seconds so it adheres to the "1-minute rule".
        }
    }
}
