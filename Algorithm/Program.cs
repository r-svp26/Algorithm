using System;

namespace Algorithm
{
    class Program
    {
        /// <summary>
        /// invoke all the classes from here!
        /// </summary>
        static void InvokeClass()
        {
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1: ArrayPermutation");
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
                    case 0:
                        Console.WriteLine("Thank you for using Algorithm!");
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
