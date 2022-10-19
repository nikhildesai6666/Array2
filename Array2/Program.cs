using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 56, 12, 89, 22 };
            int[] arr2 = new int[3];
            int[] arr3 = new int[5];
            Console.WriteLine("original array");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            // COPY

            Array.Copy(arr, 0, arr2, 0, 2);
            Array.Copy(arr, arr3, 5);

            //SORT

            Array.Sort(arr);

            //REVERSE

Array.Reverse(arr);

            //CLEAR
            Array.Clear(arr3, 3, 2);
            Console.WriteLine("sorted array");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("reverse array");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("print arr 2");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("print arr 3");
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }


        }
    }
}
