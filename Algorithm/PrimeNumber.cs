using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimeNumber
    {
        const int LIMIT = 1000;
        /// <summary>
        /// print prime number in range
        /// </summary>
        public static void PrintPrime()
        {
            bool temp;
            for (int i = 2; i <= LIMIT; i++)
            {
                temp = false;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        temp = true;
                        break;
                    }
                }
                if (temp == false)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
