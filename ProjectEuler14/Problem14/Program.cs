using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem14
{
    class Program
    {
        // Problem 14
        // Longest Collatz sequence
        // The following iterative sequence is defined for the set of positive integers:
        // n → n/2 (n is even)
        // n → 3n + 1 (n is odd)
        // Using the rule above and starting with 13, we generate the following sequence:
        // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        // It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
        // Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
        // Which starting number, under one million, produces the longest chain?
        // NOTE: Once the chain starts the terms are allowed to go above one million.
        static void Main(string[] args)
        {
            var longestChain = new { Number = 0, Steps = 0 };
            var timer = Stopwatch.StartNew();

            for (int i = 1; i < 1000001; i++)
            {
                int steps = GetCollatzSteps(i); 

                if (steps > longestChain.Steps)
                {
                    longestChain = new { Number = i, Steps = steps };
                }
            }

            Console.WriteLine("The longest was number {0} with {1} steps", longestChain.Number, longestChain.Steps);
            Console.Write("Completed in {0} ms", timer.ElapsedMilliseconds);
            Console.ReadKey();
        }

        static int GetCollatzSteps(long n)
        {
            int sequenceSteps = 0;
            return GetCollatzSteps(n, ref sequenceSteps);//sequenceSteps;
        }

        static int GetCollatzSteps(long n, ref int sequenceSteps)
        {
            n = (n % 2 == 0) ? n / 2 : 3 * n + 1;
            sequenceSteps++;

            if (n != 1)
            {
                GetCollatzSteps(n, ref sequenceSteps);
            }

            return sequenceSteps;
        }
    }
}
