using System;
namespace array
{
    class Program
    {
        static void Main(string[]args)
        {
            //Array is a list of elements. It's mostly used on DSA
           //To run all of the value from this array
            int[] MyNum = {1, 2, 3, 4 ,5};
            Console.Write("Basic array: ");
            foreach (int item in MyNum)
            {
              Console.Write(item);  
            }

            //Another way
            string[] names = {"Zobaer", "Efaz", "Abid","Nayeem"};
            Console.Write("\nPrint array with for loop: ");
            for(int i=0; i<=3; i++)
            {
                Console.Write(names[i]);
            }
            //Find Length
            Console.Write("\nthe length of this array is: "+names.Length);

            double[] xyz_Company = {12.6, 32.5, 34.7, 34.7};
            Console.Write("\nPrint dounle value's array: ");
            foreach(double i in xyz_Company)
            {
                Console.Write(i);
            }
            //Change/Add value
            xyz_Company[0]=11.5;
            Console.Write("\nAdd element with xyz_comapny array: "+ xyz_Company[0]);

            //Declair then value add
            int[] arr;
            arr = new int[] {1,2,3,4,5};
            foreach(int i in arr)
            Console.WriteLine(i);

            //Now we can see how to set size on an array
            int[] array = new int[10]{11,12,13,14,15,16,17,18,19,10};//This array's size is 10 index 0-9
            Console.Write("\nPrint an array before set the size of array: ");
            foreach (int item in array)
            {
                Console.Write(item);
            }
            

        }
    }
}
