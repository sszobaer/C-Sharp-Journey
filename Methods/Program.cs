using System;
using System.Data;
using System.Diagnostics;
namespace Methods
{
    class Program
    {
        //Parameters & Arguments
        static void MyMethod()
        {
            Console.WriteLine("It's me Zobaer");
        }
        static void summation(int a, int b, int c)
        {
            int sum = a+b+c;
            Console.WriteLine($"a+b+c = {sum}");
        }
        static void substruction(int a, int b)
        {
            int sub = a-b;
            Console.WriteLine($"a-b = {sub}");
        }

        static void Multiplication(int a, int b, int c)
        {
            int mul = a*b*c;
            Console.WriteLine($"a * b * c = {mul}");
        }
        static void division(int a, int b)
        {
            double div = a/b; 
            Console.WriteLine($"a/b = {div}");
        }

        //Default parameter
        static void DreamCountries(string Country = "France")
        {
            Console.WriteLine($"My dream country is: {Country}");
        }
        static void Main(string[]args)
        {
            MyMethod();
            summation(2,3,5);
            substruction(6,4);
            Multiplication(2,3,5);
            division(10,5);
            //Default parameter
            DreamCountries();
            DreamCountries( "Italy");
            DreamCountries("Canada");
            
        }
    }
}
