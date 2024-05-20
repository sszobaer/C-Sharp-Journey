/*Create a class Calculator with overloaded methods Multiply. 
One method should accept two integers and return their product, 
and the other should accept three integers and return their product.
 Demonstrate the use of both methods in the Main method.*/
 using System;
 namespace Method02
 {
    class Calculator
    {
        static int Multiply(int a, int b)=>a*b;
        static int Multiply(int a, int b, int c)=>a*b*c;
        static void Main(string[]args)
        {
            Console.WriteLine($"The Multiplication of two numbers is: {Multiply(5,6)}");
            Console.WriteLine($"The multiplication of three numbers is: {Multiply(3,4,6)}");
        }
    }
 }