using System;
namespace PrivateAccMod
{
    class University
    {
        public int total_department;
        public string University_Name;
        public double total_Cost;

        public University(int total_dept, string uni_name, double cost)
        {
            total_department = total_dept;
            University_Name = uni_name;
            total_Cost = cost;
        }

        class Output
        {
            static void Main(string[]args)
            {
                University myOutput = new University(10, "AIUB", 1400000);
                Console.WriteLine($"Total University of this University: {myOutput.total_department}");
                Console.WriteLine($"The name of this university: {myOutput.University_Name}");
                Console.WriteLine($"Total cost: {myOutput.total_Cost}");
            }
        }
    }
}