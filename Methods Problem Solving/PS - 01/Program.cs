/*Write a method called AddNumbers that takes two integers as parameters 
and returns their sum. 
Then, write a Main method that calls AddNumbers and prints the result.*/
using System;
namespace Method01
{
    class Program
    {
        static int AddNumbers(int a, int b)=>a+b;
        static void Main(string[]args)
        {
            Console.WriteLine($"The sum is: {AddNumbers(200,300)}");
        }
    }
}