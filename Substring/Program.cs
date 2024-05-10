using System;
namespace strings
{
    class Program
    {
        static void Main(string[]args)
        {
            /*Substring is a useful method is Substring(), which extracts the characters from a string, 
            starting from the specified character position/index, and returns a new string. 
            This method is often used together with IndexOf() to get the specific character position:*/
            string fullName = "Sara Islam";
            int CharacterPosition = fullName.IndexOf("I");
            string lastName = fullName.Substring(CharacterPosition);
            Console.WriteLine("Last name is: "+lastName);

            //Special Characters
            Console.WriteLine("I am Pursuing \"CSE\" from \"AIUB\".\n It\'s a dream of my life to get job at google.");


        }
    }
}
