using System;
namespace ClsMembers
{
    class employees
    {
        string name;
        string place;
        string experience;
        int salary;
        
        static void Main(string[]args)
        {
            employees SoftwareEngineer = new employees();
            SoftwareEngineer.name = "S. S. Zobaer Ahmed";
            SoftwareEngineer.experience = "null"; 
            SoftwareEngineer.place = "Intern";
            SoftwareEngineer.salary = 20000;

            employees WebTechnoxian = new employees();
            WebTechnoxian.name = "Yeasin Ahmed Tusher";
            WebTechnoxian.experience = "5 years";
            WebTechnoxian.salary = 100000;
            WebTechnoxian.place = "Senior web Engineer";
            //Output for SE
            Console.WriteLine($"The name of employee is: {SoftwareEngineer.name}");
            Console.WriteLine($"The experience of this employee is: {SoftwareEngineer.experience}");
            Console.WriteLine($"The place of this employee is: {SoftwareEngineer.place}");   
            Console.WriteLine($"The salary of this employee is: {SoftwareEngineer.salary}");

            //Output for WT
            Console.WriteLine($"The name of this employee is: {WebTechnoxian.name}");
            Console.WriteLine($"The experience of this employee is: {WebTechnoxian.experience}");
            Console.WriteLine($"The place of this employee is: {WebTechnoxian.place}");
            Console.WriteLine($"The salary of this employee is: {WebTechnoxian.salary}");                                 
        }
    
    }
}