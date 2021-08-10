using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BubbleSort<T> where T : IComparable
    {
        /// <summary>
        /// sort the array by bubble sort
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public T[] Bubble_Sort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                T temp;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        /// <summary>
        /// display the sorted array
        /// </summary>
        /// <param name="arr"></param>
        public void Display(T[] arr)
        { 
            foreach(T sort in arr)
                {
                    Console.Write(sort + " ");
                }
            Console.WriteLine();
        }
    }
}
