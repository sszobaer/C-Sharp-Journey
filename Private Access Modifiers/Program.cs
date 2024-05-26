using System;
namespace AccessMod
{
    class UniCourse
    {
        private string department;
        private int semester;
        private UniCourse(string dept, int sem)
        {
            department = dept;
            semester = sem;
        }
        static void Main()
        {
            UniCourse myInfo = new UniCourse("EEE", 6);
            Console.WriteLine(myInfo.department);
        }
       /* this class is not accessable because the parents class's fields are private 
       class Program
        {
            static void Main()
            {
                UniCourse myInfo = new UniCourse("CSE", 6);
                Console.WriteLine(myInfo.semester);
            }
        }*/

    }
}
