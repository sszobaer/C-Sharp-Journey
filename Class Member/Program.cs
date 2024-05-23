using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
namespace Name
{
    class Lecturer
    {
        string name;
        string department;
        string courses;
        string experiences;
         double salary;
         //Inside a class method must be public 
        public void increments()
        {
            Console.WriteLine("Salary will increment after 1 yeras");
        }
        
        static void Main(string[]args)
        {
            Lecturer MyObj = new Lecturer();
            MyObj.name = "Jubayer Ahmed";
            MyObj.department = "Computer Science";
            MyObj.experiences = "2 yeras";
            MyObj.salary = 80000;

            Console.WriteLine($"The name of lecturer: {MyObj.name}");
            Console.WriteLine($"His department is: {MyObj.department}");
            Console.WriteLine($"His experience is: {MyObj.experiences}");
            Console.WriteLine($"His Salary is: {MyObj.salary}");
            MyObj.increments();

        }
    }
}