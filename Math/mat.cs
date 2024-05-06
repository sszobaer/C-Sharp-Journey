// See https://aka.ms/new-console-template for more information
using System;
namespace Application
{
    class mat
    {
        static void Main(string[] args)
        {
        //For abstract any value
            Console.WriteLine(Math.Abs(-4.7));
        //For round any value
            Console.WriteLine(Math.Round(9.99));
        //For find highest & lowest value
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));
        //For find square root
            Console.WriteLine(Math.Sqrt(16));
        //For find logarithomic value
            Console.WriteLine(Math.Log(2));
        //For find Sin cos value
            int degrees = 0;
            double radians = degrees * Math.PI / 180;
            Console.WriteLine(Math.Sin(radians)); 
            Console.WriteLine(Math.Cos(radians));
        }
    }
}
