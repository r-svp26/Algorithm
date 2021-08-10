using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MagicNumber
    {
		/// <summary>
		/// guess the number
		/// </summary>
		/// <param name="n"></param>
        public static void GuessNumber(int n)
        {
			int low = 0, high = 100;
			while (low <= high)
			{
				int mid = (low + high) / 2;
				if (n == mid)
				{
					Console.WriteLine("Magic Number is:" + mid);
					break;
				}
				else if (n < mid)
				{
					high = mid - 1;
				}
				else
				{
					low = mid + 1;
				}
			}
		}
    }
}
