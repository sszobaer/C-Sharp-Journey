/*Write a method called Greet that takes two parameters: 
a string name and an optional string greeting with a default value of "Hello". 
The method should print the greeting followed by the name.
 Demonstrate the method with both one and two arguments in the Main method.*/
using System;
namespace OptionalParameter
{
    class Program
    {
        static void Greet(string name, string greeting = "Hello")
        {
            Console.WriteLine($"{greeting} {name}");
        }
        static void Main(string[]args)
        {
            Greet("Zobaer");
            Greet("Efaz", "Hi");
        }
    }
}