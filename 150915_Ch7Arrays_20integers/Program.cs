using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150915_Ch7Arrays_20integers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program, which creates an array of 20 elements of type integer and initializes 
            each of the elements with a value equals to the index of the element multiplied by 5. 
            Print the elements to the console.
            */

            int[] arrayInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            foreach (int arr in arrayInts)
            {
                Console.WriteLine(arr * 5);
            } 

        }
    }
}
