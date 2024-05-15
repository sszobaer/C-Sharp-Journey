/* Write a program to build a basic calculator like we use. User can give input as many times as they 
want. They can do addition, Subtraction, Multiplication, Division, Remainder, They Could find 
square, Square root, Round up any number, find the value of log, also they could find the solution 
of xy (x=2, y=2, xy = 4)*/
using System;
using System.Transactions;
using System.Xml.Serialization;
namespace BasicCalculator
{
    class Program
    {
        static void Main(string[]args)
        {
            bool KeepRunning = true;
            while(KeepRunning)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Remainder");
                Console.WriteLine("6. Power (xy)");
                Console.WriteLine("7. Square");
                Console.WriteLine("8. Square Root");
                Console.WriteLine("9. Round");
                Console.WriteLine("10. Logarithm (base 10)");
                
                Console.WriteLine("11. Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                double value1 = 0, value2 = 0, result = 0;

                if(choice >=1 && choice<=5 )
                {
                    Console.Write("Enter your first value: ");
                    value1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your second value: ");
                    value2 = Convert.ToInt32(Console.ReadLine());
                }
                else if(choice == 6)
                {
                    Console.Write("Enter the value that you want to need power:  ");
                    value1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the power: ");
                    value2 = Convert.ToInt32(Console.ReadLine()); 
                }
                else if(choice>=7 && choice<=10)
                {
                    Console.Write("Enter your number: ");
                    value1 = Convert.ToInt32(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                    result = value1+value2;
                    Console.WriteLine($"The sum of {value1} and {value2} is : {result}");
                    break;

                    case 2:
                    result = value1-value2;
                    Console.WriteLine($"The substruction of {value1} and {value2} is : {result}");
                    break;

                    case 3:
                    result = value1+value2;
                    Console.WriteLine($"The multiplication of {value1} and {value2} is : {result}");
                    break;

                    case 4:
                    if(value2 == 0)
                    {
                        Console.WriteLine("Cannot divided by zero");
                    }
                    else
                    {
                    result = value1/value2;
                    Console.WriteLine($"The division of {value1} and {value2} is : {result}");
                    }
                    break;

                    case 5:
                    result = value1%value2;
                    Console.WriteLine($"The remainder of {value1} and {value2} is : {result}");
                    break;

                    case 6:
                    Console.WriteLine($"The {value2} of {value1} is : {Math.Pow(value1, value2)}");
                    break;

                    case 7:
                    Console.WriteLine($"The square of {value1} is {value1*value1} {result}");
                    break;

                    case 8:
                    if(value1 <= 0)
                    {
                        Console.WriteLine("The negative value has no square root");
                    }
                    else
                    {
                        Console.WriteLine($"The square root of {value1} is {Math.Sqrt(value1)}");
                    }
                    break;

                    case 9: 
                    Console.WriteLine($"The round of {value1} is {Math.Round(value1)}");
                    break;

                    case 10:
                    Console.WriteLine($"The logarithm of {value1} is {Math.Log10(value1)}");
                    break;

                    case 11:
                    KeepRunning = false;
                    Console.WriteLine("Exiting from the program...");
                    break;

                    default:
                    Console.WriteLine("Invalid value or operator");
                    break;
                    
                }
            }
        }
    }
}