/*Constructor:- A constructor is a special method that is used to initialize objects. 
The advantage of a constructor, is that it is called when an object of a class is created. 
It can be used to set initial values for fields:*/
using System;
namespace Constructor
{
    class employee
    {
        //field
        public string salary ;
    /*Note that the constructor name must match the class name, 
    and it cannot have a return type (like void or int).*/

    //Constructor
        public employee()
        {
            salary = "1,00,000/-";
        }
        static void Main(string[]args)
        {
            employee Engr = new employee();
            Console.WriteLine(Engr.salary);
        }
    }
}