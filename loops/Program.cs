using System;
using System.Globalization;
namespace loops
{
    class Program
    {
        static void Main(string[]args)
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }   

            for(int j=10; j>=1; j--)
            {
                Console.WriteLine(j);
            }

            //foreach loop 
            //foreach only used on loops
            int[] numbers = {1, 2, 3 ,4, 5, 6, 7, 8, 9, 10};
            foreach (int i in numbers)
            {
               Console.Write(i); 
            }
        }
    }
}

