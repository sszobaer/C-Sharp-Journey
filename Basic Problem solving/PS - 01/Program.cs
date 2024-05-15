/*Write a program to find the largest and smallest among three entered numbers by the user and 
also display whether the identified largest/smallest number is even or odd. (Using conditional 
statement)
Example: 
Input: 7, 9, 2
Output: 
largest: 9, it is odd
smallest 2, it is even*/
using System;
using System.Transactions;
namespace findLargestSmallesAndOddEvenNub
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter 3 different numbers: ");
            string[] Numbers = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(Numbers[0]);
            int y = Convert.ToInt32(Numbers[1]);
            int z = Convert.ToInt32(Numbers[2]);
        //Find Largest Number
            if(x>y && x>z)
            {
                Console.Write("Largest: "+x);
                Console.Write((x%2 == 0) ? ", It is even" : ", It is odd");
            }
            else if(y>x && y>z)
            {
                Console.Write("Largest: "+y);
                Console.Write((y%2 == 0) ? ", It is even" : ", It is odd");
            }
            else if(z>x && z>y)
            {
                Console.Write("Largest: "+z);
                Console.Write((z%2 == 0) ? ", It is even" : ", It is odd");
            }

        //Find Smallest Number  
            if(x<y && x<z)
            {
                Console.Write("\nSmallest: "+y);
                Console.Write((x%2 == 0)? ", It is even" : ", It is odd");
            }  
            else if(y<x && y<z)
            {
                Console.Write("\nSmallest: "+y);
                Console.Write((y%2 == 0)? ", It is even" : ", It is odd");
            }
            else if(z<x && z<y)
            {
                Console.Write("\nSmallest: "+z);
                Console.Write((z%2 == 0)? ", It is even" : ", It is odd");
            }
            
        }
    }
}