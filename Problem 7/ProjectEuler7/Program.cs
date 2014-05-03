using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler7
{
    class Program
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?
        static void Main(string[] args)
        {
            Console.Write(GetPrimes(10001).Max());
            Console.ReadKey();
        }

        static int[] GetPrimes(int numberofPrimes)
        {
            // Since the example gave us a few free prime numbers let's start with adding those
            var primes = new List<int>() { 2, 3, 5, 7, 11, 13 };
            int n = 14; // We start 14 since we have prime numbers up to 13 added already

            do
            {
                // Check if n is divisible by any number where number < n, if not it is a prime number
                if (!Enumerable.Range(2, n).Any(x => n % x == 0 && n != x)) 
                {
                    primes.Add(n++);
                }
                n++;
            } while (primes.Count < numberofPrimes);
            
            return primes.ToArray();
        }
    }
}
