using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler9
{
    class Program
    {
        // Special Pythagorean triplet
        // A Pythagorean triplet is A set of three natural numbers, A < B < C, for which,
        //  A^2 + B^2 = C^2
        // For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        // There exists exactly one Pythagorean triplet for which A + B + C = 1000.
        // Find the product abc.
        static void Main(string[] args)
        {
            // Okay my intial thought is, 
            // first of all we need to write A method to identify if A set of numbers is equal to A Pythagorean triplet
            // The formula SHOULD BE something like sqrt(A^2 + B^2) == natural number ? return TRUE : return FALSE.
            // Now my other thought is.. Because ultimately we're looking for an expression that will generate A + B + C = 1000,
            // We know that A^2 + B^2 < 1000 and by extension A^2 + B^2 = 500
            int seed = 0;
            while (true) // loop until we find A pythagorean triplet where the sum of A^2 + B^2 + C^2 = 1000
            {
                for (int i = seed + 1; i < 100; i++)
                {
                    var triplet = new PythagoreanTriplet(i, seed);
                    int sum = triplet.A + triplet.B + triplet.C;

                    if (sum == 1000)
                    {
                        Console.WriteLine("a = " + triplet.A + "\nb = " + triplet.B + "\nc = " + triplet.C);
                        Console.WriteLine("The product of {0} * {1} * {2} is equal to: {3}",
                            triplet.A, triplet.B, triplet.C, triplet.A * triplet.B * triplet.C);
                        Console.ReadKey();
                    }
                }
                seed++;
            }
        }
    }
}
