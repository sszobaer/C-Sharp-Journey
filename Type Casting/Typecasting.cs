// See https://aka.ms/new-console-template for more information
using System;
namespace TC
{
    class Typecasting
    {
        static void Main(string[]args)
        {
            //Typecasting
            int DayPerMonth = 30;
            double MyRule = DayPerMonth;
            Console.WriteLine(DayPerMonth);
            Console.WriteLine(MyRule);

            int a = 9;
            double b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //Manual Typecasting
            //It's used for convert double to integer
            double cgpa = 3.78;
            int myCgpa = (int) cgpa;
            Console.WriteLine(cgpa);
            Console.WriteLine(myCgpa);

            double oopMarks = 93.5;
            int FlooringMarks = (int) oopMarks;
            Console.WriteLine("You got actually: "+oopMarks+" marks");
            Console.WriteLine("The flooring mark: "+FlooringMarks);
            
            
        }
    }
}
