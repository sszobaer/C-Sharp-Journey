/*Write a recursive method called Factorial that takes an integer n 
and returns its factorial. 
Use this method in the Main method to compute and print the factorial of a given number.*/
using System;
namespace Recursion
{
    class Program
    {
        static int Factorial(int n)
        {
            if(n<=1)
            {
                return 1;
            }
            return n*Factorial(n-1);
        }
        static void Main(string[]args)
        {
           Console.WriteLine($"The factorial of this given number is: {Factorial(4)}");
        }
    }
}