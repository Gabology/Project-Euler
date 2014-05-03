using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler4
{
    class Program
    {
        // A palindromic number reads the same both ways. 
        // The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.
        static void Main(string[] args)
        {
            //  
            var palindromes = new List<int>();
            
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if (IsPalindrome(i * j))
                    {
                        palindromes.Add(i * j);
                    }
                }
            }

            // For some reason the list is not sorted correctly, but when sorted it works.
            palindromes.Sort();
            Console.WriteLine(palindromes.Last());
            Console.ReadKey();
        }

        static bool IsPalindrome(int number) 
        {
            char[] numberChar = number.ToString().ToCharArray();
            char[] inversion = numberChar.Reverse().ToArray();

            return (numberChar.SequenceEqual(inversion)) ? true : false;
        }
    }
}
