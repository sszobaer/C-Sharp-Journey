using System;
using System.Security.Cryptography.X509Certificates;
namespace MethodReturns
{
    class Program
    {
        //Return values
        static int func(int a)
        {
            return 5+a;
        }

        //Another process to return
        static int sum(int x, int y) =>x+y;

        //Named Argument 
        static void NamedArgument(string name1 , string name2 , string name3  , string name4 )
        {
            Console.WriteLine("The intilligent person is: "+name2);
        }
        static void Main(string[]args)
        {
            Console.WriteLine(func(3));
            Console.WriteLine(sum(2,4));
            NamedArgument(name1: "Zobaer",name2: "Sara", name3: "Sohana", name4: "Fahad");
        }
    }
}
