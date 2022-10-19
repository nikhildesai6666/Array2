using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class jaggadarray
    {
        static void Main(string[] args)
        {

            int[][] jarray = new int[3][];

            jarray[0] = new int[] { 10, 20, 30, 40, 50 };
            jarray[1] = new int[] { 11, 22, 33 };
            jarray[2] = new int[] { 100, 200 };

            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write(" " + jarray[i][j]);
                }
                Console.WriteLine();
            }
        }


    }
}
