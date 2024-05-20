/*Write a method called Sum that takes a variable number of integer arguments 
using the params keyword and returns their sum. 
Use this method in the Main method to compute and print the sum of various sets of numbers.*/
using System;
namespace ParamsKeyword
{
    class Program
    {
        static int sum(params int[] number)
        {
            int total = 0;
            foreach (int num in number)
            {
                total+=num;
            }
            return total;
        }
        static void Main(string[]args)
        {
            Console.WriteLine($"The sum of 3 numbers is: {sum(2,5,6)}");
            Console.WriteLine($"The sum of 2 numbers is: {sum(4,6)}");
            Console.WriteLine($"The sum of 6 numbers is: {sum(19,13,54,78,92,100)}");
        }
    }
}