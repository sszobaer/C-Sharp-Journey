using System;
namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[]args)
        {
            //If else real time use to find voting age in Bangladesh
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else
            {
                Console.WriteLine("You are not eligible for voting");
            }

            //The uses of else if
            Console.Write("Enter two numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if(a<b)
            {
                Console.WriteLine("\'b\' is greater than \'a\'");
            }
            else if(a==b)
            {
                Console.WriteLine("\'a\' and \'b\' is equal");
            }
            else
            {
                Console.WriteLine("\'a\' is greater than \'b\'");
            }
        }    
    }
}