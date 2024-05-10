using System;
using System.Runtime.CompilerServices;
namespace myApp
{
    class CsStrings
    {
        static void Main(string[]args)
        {
        //Print a basic string
            string Myname = "Zobaer Ahmed";
            string FirstName = "S. S.";
            Console.WriteLine("My name is "+Myname);
            Console.WriteLine($"But my full name is {FirstName} {Myname}");
        //To show the lenght of string
            string letters = "ABCDEFGHIJKLMNOPQRSTWUVXYZ";
            Console.WriteLine("The lenght of this string is: "+ letters.Length);
        //To Upper Case & Lower Case
            Console.WriteLine("My name after convert to upper case: "+Myname.ToUpper());
            Console.WriteLine("My name after convert to lower case: "+Myname.ToLower());

        //String Concatenation

            string UniName1 = "American International";
            string UniName2 = " University-Bangladesh";
            string University_Name= string.Concat(UniName1, UniName2);
            Console.WriteLine(University_Name);

        //Number Concatenation
            int a = 10;
            int b = 20;
        /*No needed these lines:
        string num1 = Convert.ToString(a);
        string num2 = Convert.ToString(b);
        string num = string.Concat(num1, num2);*/
            string NumConcatenation = string.Concat(a,b);
            Console.WriteLine(NumConcatenation);
        //Another proccess
            String A = "10";
            string B = "20";
            Console.WriteLine("The concated number: "+(A+B));
        //String Interpolation
            string Fname = "Jubayda";
            string Lname = "Islam";
            string FullName = $"full name is: {Fname} {Lname}";
            Console.WriteLine(FullName);

        //Tasks: Add "S. S." in myName at first using more elegent concatenation system
            //Answer is in line 10

        //Access String
        /*Here we decribe that how can we access a character or letter from a full string.
        For this we need the idea of array. Array is a list. Like that 0,1,2,3,4,5,...We
        access them using this array */
        string searchEngine = "GOOGLE"; 
        Console.WriteLine(searchEngine[0]);
        Console.WriteLine(searchEngine[4]);

        }
    }
}
