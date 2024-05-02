// See https://aka.ms/new-console-template for more information
using System;
namespace Composition
{
    class ComOperator
    {
        static void Main(string[]args)
        {
            int x = 7;
            int y = 8;
            Console.WriteLine("x = "+x);
            Console.WriteLine("y = "+y);
            Console.WriteLine("x>y? "+(x>y));
            Console.WriteLine("x=y? "+(x==y));
            Console.WriteLine("x<y? "+(x<y));
        }
    }
}
