using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimeNumber
    {
        static readonly ArrayList palindromeList = new ArrayList();
        const int LIMIT = 1000;
        /// <summary>
        /// print prime number in range
        /// </summary>
        public static void PrintPrime()
        {
            bool temp;
            for (int i = 11; i <= LIMIT; i++)
            {
                temp = false;
                for (int j = 11; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        temp = true;
                        break;
                    }
                }
                if (temp == false)
                    PrimePalindrome(i);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// add prime-palindrom in list.
        /// </summary>
        /// <param name="num"></param>
        public static void PrimePalindrome(int num)
        {
            if (PalindromePrime.IsPalindrome(num) == true)
            {
                palindromeList.Add(num);
            }
        }
        /// <summary>
        /// display palindrom-prime number
        /// </summary>
        public static void PrintPalindrome()
        {
            Console.WriteLine("Palindrome-Prime in Range");
            foreach (int prime in palindromeList)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
        }
    }
}
