/*Write a program to check whether input alphabet is vowel or not using if-else and switch 
statement.
Input: a output: a is vowel. 
Input: b output: b is consonant. */
using System;
namespace VowelOrConso
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Enter an alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            switch (alphabet)
            {
                case 'a':
                Console.WriteLine(alphabet + " is vowel");
                break;

                case 'e':
                Console.WriteLine(alphabet +" is vowel"); 
                break;

                case 'i':
                Console.WriteLine(alphabet +" is vowel");
                break;

                case 'o':
                Console.WriteLine(alphabet +" is vowel");
                break;

                case 'u':
                Console.WriteLine(alphabet + " is vowel");
                break;

                default:
                Console.WriteLine(alphabet + " is consonant");
                break;
            }

        }
    }
}
