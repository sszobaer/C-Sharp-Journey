// See https://aka.ms/new-console-template for more information
using System;
namespace Variables
{
    class Variable
    {
        static void Main(string[]args)
        {
        //Integer
            int a = 40;
            int b =70;
            int sum = a+b;
            Console.WriteLine("The Sum of "+a+" & "+b+" is "+sum);

        //Double    
            double cgpa =3.78;
            Console.WriteLine("My CGPA is "+cgpa);

        //String
            string fName = "Zobaer";
            string lName = "Ahmed";
             Console.WriteLine("My name is "+fName+" "+lName);

        //Boolean
            bool statement = true;
    	    Console.WriteLine(statement);

        //Constants
            const int c = 4;
            //c=80; It's return error
            Console.WriteLine("Constant Variable "+c);

        //Multiple Variable
            int x=2, y=6, z=4;
            Console.WriteLine(x+y+z);    
            Console.WriteLine("Anything "+x+y+z);

        //Identifier

        /*All C# variables must be identified with unique names.
        These unique names are called identifiers.
        Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).
        Note: It is recommended to use descriptive names in order to create understandable and maintainable code*/

        int DayPerWeek = 7;
        Console.WriteLine(DayPerWeek);
        }
    }
}
