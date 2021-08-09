using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class ArrayPermutation
    {
        
        static int fact = 1;
        /// <summary>
        /// iterative method
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int IterativeFactorial(int number)
        {
            for (int i=1; i<=number; i++)
            {
                fact *= i;
            }
            return fact;
        }
        /// <summary>
        /// recursive method
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int RecursiveFactorial(int number)
        { 
            if (number == 0 || number == 1)
                return 1;
            return number * RecursiveFactorial(number - 1);
        }
    }
}
