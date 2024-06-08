namespace Enums
{
    enum level
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class Program
    {
        static void Main(string[]args)
        {
            level Num = level.Thursday;
            switch (Num)
            {
                case level.Saturday:
                Console.WriteLine("Saturday");
                break;
                case level.Sunday:
                Console.WriteLine("Sunday");
                break;
                case level.Monday:
                Console.WriteLine("Monday");
                break;
                case level.Tuesday:
                Console.WriteLine("Tuesday");
                break;
                case level.Wednesday:
                Console.WriteLine("Wednesday");
                break;
                case level.Thursday:
                Console.WriteLine("Thursday");
                break;
                case level.Friday:
                Console.WriteLine("Friday");
                break;
                
            }
        }
    }
}