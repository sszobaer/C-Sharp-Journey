using System;
namespace Encapsulation
{
    class student
    {
        private string name;
        private string Id;
        private string cgpa;

        public string Name
        {
            get{return name;}
            set{name = value;}
        }

        public string ID
        {
            get{return Id;}
            set{Id = value;}
        }

        public string CGPA
        {
            get{return cgpa;}
            set{cgpa = value;}
        }

        public student(string x, string y, string z)
        {
            Name = x;
            ID = y;
            CGPA =z;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            student myObj = new student("Zobaer", "22-49415-3", "3.78");
           
            Console.WriteLine($"Name = {myObj.Name}\nID = {myObj.ID} \nCGPA = {myObj.CGPA}");
        }
    }
}
