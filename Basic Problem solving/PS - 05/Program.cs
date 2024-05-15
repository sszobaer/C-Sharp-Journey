//Create a program that converts Celsius to Fahrenheit.
using System;
using System.Runtime.InteropServices.Marshalling;
namespace CtoF
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter the temaprature: ");
            double C = Convert.ToDouble(Console.ReadLine());
            double F = (C*9 /5)+32;
            Console.WriteLine(C+" degree C to "+F+" degree F");
        }
    }
}
