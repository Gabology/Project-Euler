using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler10
{
    class Program
    {
        // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        // Find the sum of all the primes below two million.
        static void Main(string[] args)
        {
            var primes = new HashSet<long>();

            //I think trial by division will do for this calc
            for (int i = 2; i < 2000000; i++)
            {
                if (TrialByDivision(i))
                {
                    primes.Add(i);
                }
            }
            Console.Write(primes.Sum());
            Console.ReadKey();
        }
        static bool TrialByDivision(long n)
        {
            return (Enumerable.Range(2, (int)Math.Sqrt(n)).Any(x => n % x == 0 && n != x)) ? false : true;
        }
    }
}
