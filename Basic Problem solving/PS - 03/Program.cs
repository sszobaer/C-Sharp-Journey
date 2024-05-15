/*Write a program to check whether the entered year is leap year or not (a year is leap if it is 
divisible by 4 and divisible by 100 or 400.)
Input: 2002 Output: leap year*/
using System;
namespace leapYear
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year/4 == 0) && ((year/100 == 0) || (year/400 == 0)))
            {
                Console.WriteLine(year+" is leap year");
            }
            else
            {
                Console.WriteLine(year+" is not leap year");
            }
        }
    }
}
