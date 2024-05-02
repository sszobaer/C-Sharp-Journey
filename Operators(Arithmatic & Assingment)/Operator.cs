// See https://aka.ms/new-console-template for more information
using System;
namespace OP
{
    class Operator
    {
        static void Main(string[]args)
        {
            //[Arithmatic Operator: +, _, *, /, %, ++, --]
            int x = 1+2;
            Console.WriteLine(x);
            Console.WriteLine(34+1);
            Console.WriteLine("++ -> "+x++);
            Console.WriteLine(1%3);

            //[Assignment op: +=, -=, *=, /=, %=, &=, |=, ^=, >>=, <<=,]
            int y = x+=4;
            Console.WriteLine("+= -> "+y);
            int z = x-=4;
            Console.WriteLine("-= ->"+z);

        }
    }
}
