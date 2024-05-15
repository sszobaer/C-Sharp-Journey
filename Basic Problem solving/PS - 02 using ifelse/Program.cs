/*Write a program to check whether input alphabet is vowel or not using if-else and switch 
statement.
Input: a output: a is vowel. 
Input: b output: b is consonant. */
using System;
using System.Transactions;
namespace VowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter: ");
            char letter = Convert.ToChar(Console.ReadLine().ToLower());
            if('a'==letter || 'e'==letter || 'i'==letter || 'o'==letter || 'u'==letter)
            {
                Console.WriteLine(letter+" is vowel.");
            }
            else
            {
                Console.WriteLine(letter+" is consonant.");
            }
        }
    }
}