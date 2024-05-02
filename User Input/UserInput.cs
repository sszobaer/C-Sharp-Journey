// See https://aka.ms/new-console-template for more information
using System;
namespace UInput
{
    class UserInput
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter your name: ");
            //User Input command
            string Username = Console.ReadLine();
            Console.WriteLine("The username is: "+Username);

            /*[N:B: The Console.ReadLine() method returns a string. 
            Therefore, you cannot get information from another data type, such as int. The following program will cause an error]*/

            Console.WriteLine("Enter your cgpa: ");
            double cgpa =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Your age is: "+cgpa);

            Console.WriteLine("Enter your semester: ");
            int semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are in "+semester+"th semester");

            Console.WriteLine("Enter your date of Birth: ");
            DateTime DoB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Your date of birth is: "+DoB);

            Console.WriteLine("Completed credit hour: ");
            int credit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have completed "+credit+" crdeits");


        }   
    }
    
}
