/*Create a method called Swap that takes two integers by reference and swaps their values. 
Demonstrate the use of this method in the Main method by swapping 
and printing the values of two integers.*/
using System;
namespace PassByRef
{
    class Program
    {
        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a=b;
            b=temp;
        }
        static void Main(string[]args)
        {
            int a = 4, b =6;
            Swap(ref a, ref b);
            Console.WriteLine($"The swapping value is: {a},{b}");
        }
    }
}