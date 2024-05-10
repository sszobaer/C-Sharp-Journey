using System;
namespace booleans
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int votingAge = 18;
            Console.WriteLine(age>=votingAge); 
        }
    }
}