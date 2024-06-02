using System;
namespace Abstraction
{
    /*Abstract class: is a restricted class that cannot be used to create objects 
    (to access it, it must be inherited from another class).*/
    abstract class employee
    {
        /*Abstract method: can only be used in an abstract class, and it does not have a body. 
        The body is provided by the derived class (inherited from).*/
        public abstract void secretCode();
        public void AverageSalary()
        {
            Console.WriteLine("The avg salary of a Software Engineer is: 50,000 bdt");
        } 

        public void Department()
        {
            Console.WriteLine("The department is: Software Engineering");
        }
    }

    class SoftwareEngineer : employee
    {
        public override void secretCode()
        {
            Console.WriteLine("The id of Software engineer's is: 49415");
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            SoftwareEngineer myObj = new SoftwareEngineer();
            myObj.secretCode();
            myObj.AverageSalary();
            myObj.Department();
        }
    }
}
