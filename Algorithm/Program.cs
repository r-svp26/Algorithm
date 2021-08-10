using System;
using System.IO;

namespace Algorithm
{
    class Program
    {
        /// <summary>
        /// invoke all the classes from here!
        /// </summary>
        static void InvokeClass()
        {
            string filepath = @"V:\BridgeLabz\Algorithm\Algorithm\BinarySearch.txt";
            string text = File.ReadAllText(filepath);
            string[] textArray = text.Split(" ");
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1: ArrayPermutation");
                Console.WriteLine("2: BinarySearchWord");
                Console.WriteLine("3. Insertion Sort");
                Console.WriteLine("4. Bubble Sort");
                Console.WriteLine("5. Merge Sort");
                Console.WriteLine("6. AnagramDetection");
                Console.WriteLine("0: Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int factIterative = ArrayPermutation.IterativeFactorial(5);
                        Console.WriteLine("Factorial of a number by iteration method:" + factIterative);
                        int factRecursive = ArrayPermutation.RecursiveFactorial(5);
                        Console.WriteLine("Factorial of a number by recursive method:" + factRecursive);
                        break;
                    case 2:
                        BinarySearchWord<string> search = new BinarySearchWord<string>(textArray);
                        Console.WriteLine("Enter the word to search");
                        string searchElement = Console.ReadLine();
                        int found = search.BinarySearch(textArray, searchElement);
                        if (found == -1)
                        {
                            Console.WriteLine("Sorry! Word is not present.");
                        }
                        else
                        {
                            Console.WriteLine("{0} is present in the file", searchElement);
                        }
                        break;
                    case 3:
                        InsertionSort<string> insertionSort = new InsertionSort<string>();
                        insertionSort.Insertion_Sort(textArray);
                        insertionSort.Display(textArray);
                        break;
                    case 4:
                        int[] arr = { 10, 20, 5, 60, 70 };
                        BubbleSort<int> bubbleSort = new BubbleSort<int>();
                        bubbleSort.Bubble_Sort(arr);
                        bubbleSort.Display(arr);
                        break;
                    case 5:
                        int start = 0;
                        int end = textArray.Length;
                        MergeSort<string> mergeSort = new MergeSort<string>();
                        mergeSort.Merge_Sort(textArray, start, end-1);
                        mergeSort.Display(textArray);
                        break;
                    case 6:
                        Console.WriteLine("Enter the First String");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Enter the Second String");
                        string str2 = Console.ReadLine();
                        bool rs = AnagramDetection.IsAnagram(str1,str2);
                        if (rs == true)
                            Console.WriteLine("Strings are Anagram");
                        else
                            Console.WriteLine("String are not Anagram");
                        break;
                    case 0:
                        Console.WriteLine("Have a nice day!");
                        CONTINUE = false;
                        break;
                    default:
                        Console.WriteLine("Please, Select valid option!");
                        break;
                }
            }
        }
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.InvokeClass();
        }
    }
}
