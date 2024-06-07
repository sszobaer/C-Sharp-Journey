namespace MasterCourse
{
    //Interface
    //Abstraction
    interface IUniversity
    {
        void ID();
    }

    interface ICourse
    {
        void course();
    }
    
    class Student : IUniversity, ICourse
    {
        public void ID()
        {
            Console.WriteLine("22-49415-3");
        }
        public void course()
        {
            Console.WriteLine("Object Oriented Programming");
        }
    }

    
    class Program
    {
       static void Main(string[] args)
        {
            Student stu = new Student();
            stu.ID();
            stu.course();
        }
    }
}