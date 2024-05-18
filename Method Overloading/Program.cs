using System;
namespace MethodOverloading
{
    class Program
    {
        //When there is same name but different primitive datatype
        static int sum(int a, int b)=> a+b;
        static double sum(double a, double b)=> a+b;
        static void Main(string[]args)
        {
            Console.WriteLine($"Int: {sum(2,3)}");
            Console.WriteLine($"Double: {sum(2.5, 5.6)}");
        }
    }
}