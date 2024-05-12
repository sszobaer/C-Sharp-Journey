using System;
namespace SortArray
{
    class Program
    {
        static void Main(string[]args)
        {
            //Sort an array
            int[] numbers = new int[5] {5, 6, 1, 3, 2};
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //sort an string
            string[] cars={"BMW", "Audi", "Toyata", "Honda"};
            Array.Sort(cars);
            foreach(string item in cars)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
