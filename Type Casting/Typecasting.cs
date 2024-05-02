// See https://aka.ms/new-console-template for more information
using System;
namespace TC
{
    class Typecasting
    {
        static void Main(string[]args)
        {
            //Typecasting

            //Implicit Casting
            int DayPerMonth = 30;
            double MyRule = DayPerMonth;
            Console.WriteLine(DayPerMonth);
            Console.WriteLine(MyRule);

            int a = 9;
            double b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);


            //Explicit Casting
            //Manual Typecasting
            //It's used for convert double to integer
            double cgpa = 3.78;
            int myCgpa = (int) cgpa;
            Console.WriteLine(cgpa);
            Console.WriteLine(myCgpa);

            double oopMarks = 93.5;
            //Note: This method returns flooring number
            int FlooringMarks = (int) oopMarks;
            Console.WriteLine("You got actually at OOP: "+oopMarks+" marks");
            Console.WriteLine("after flooring OOP's mark: "+FlooringMarks);

            
            //Type Conversion Method
            int x = 3;
            double ooadMarks = 89.5;
            string z = "Zobaer Ahmed";
            bool xy = true;

            Console.WriteLine(Convert.ToDouble(x));
            //Note: This method returns silling number
            Console.WriteLine("You got actually at OOAD: "+ooadMarks);
            Console.WriteLine("After silling OOAD's mark is: "+Convert.ToInt32(ooadMarks));
            Console.WriteLine(Convert.ToString(xy));
            
        }
    }
}
