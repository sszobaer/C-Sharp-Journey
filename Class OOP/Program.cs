using System;
namespace Class
{
    class Fruite
    {
            string fruitsColor = "Red";
        static void Main(string[]args)
        {
            Fruite myObj1 = new Fruite();
            Console.WriteLine($"The color of apple is: {myObj1.fruitsColor}");
            Fruite myObj2 = new Fruite();
            Console.WriteLine($"The color of lichi is: {myObj2.fruitsColor}");
        }
    }
}