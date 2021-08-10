using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PalindromePrime
    {
		/// <summary>
		/// check num is palindrome or not
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static bool IsPalindrome(int n)
		{
			int rev = 0, temp = n;
			while (n != 0)
			{
				int rem = n % 10;
				rev = rev * 10 + rem;
				n /= 10;
			}
			if (rev == temp)
			{
				return true;
			}
			return false;
		}
	}
}
