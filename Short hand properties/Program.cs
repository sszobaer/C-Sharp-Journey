using System;
using System.Reflection.Metadata.Ecma335;
namespace ShortHandProperties
{
    class student
    {
        public string Name
        {get; set;}
        public string ID 
        {get; set;}
        public string CGPA
        {get; set;}

        public student(string n, string id, string cg)
        {
            Name = n;
            ID = id;
            CGPA = cg;
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            student myObj = new student("S. S. Zobaer Ahmed", "22-49415-3", "3.78");
            Console.WriteLine($"Name = {myObj.Name} \nID = {myObj.ID} \nCGPA = {myObj.CGPA}");
        }
    }
}