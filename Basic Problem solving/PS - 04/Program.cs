// Create a program that converts meters to feet
using System;
namespace converter
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter your value in meter: ");
            double value = Convert.ToDouble(Console.ReadLine());
            double Newvalue = value*3.2808399;
            Console.WriteLine(value+" meter = "+Newvalue+" feet");
        }
    }
}
