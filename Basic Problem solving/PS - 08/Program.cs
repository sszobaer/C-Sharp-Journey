/*Write a program to find factorial of given number.
Input: 5 Output: 120*/
using System;
namespace factorial
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter a value to find factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            if(number<0)
            {
                Console.WriteLine("Negative number has no factorial");
                return;
            }
            for(int i=1; i<=number; i++)
            {
                
                factorial*=i;
                
            }
            Console.Write($"The factorial of {number} is {factorial}");
            
        }
    }
}
