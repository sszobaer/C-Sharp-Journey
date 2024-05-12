/*2D Array 
Basically It's a matrix form. like that
    0  1  2  3
0-> 1  2  3  4
1-> 2  3  4  5
2-> 3  4  5  6
3-> 4  5  6  7 */

using System;
namespace multidimesionalArray
{
    class Program
    {
        static void Main(string[]args)
        {
            int[,] mdarray = {{1,2,3,4}, {2,3,4,5}, {3,4,5,6},{4,5,6,7}};
            Console.WriteLine("Print a single element: "+mdarray[1,2]);
         //foreach loop through a 2D array  
            Console.WriteLine("Print Full array using For Each loop: ");
            foreach (int i in mdarray)
            {
                Console.Write(i+" ");
            }
         //for loop through a 2d array
            int[,] two_d_arr = {{1,2,3},{2,3,4}};
            for(int i=0; i<two_d_arr.GetLength(0); i++)
            {
                for(int j=0; i<two_d_arr.GetLength(1); j++)
                {
                    Console.WriteLine(two_d_arr[i,j]);
                }
            }

        }
    }
}
