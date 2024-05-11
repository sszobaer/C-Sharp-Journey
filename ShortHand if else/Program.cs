using System;
namespace ShortHand
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string output = (age>=18)?"You are eligible for voting. ": "You are Not eligible for voting";
            Console.WriteLine(output);
        }
    }
}