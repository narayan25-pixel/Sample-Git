using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Jagged_Array
    {
        static void Main(string[] args)
        {

            int[][] jaggedarr = new int[4][];
            jaggedarr[0] = new int[] { 23, 56 };
            jaggedarr[1] = new int[] { 34, 67, 67, 7, 8 };
            jaggedarr[2] = new int[] { 4, 67 };
            jaggedarr[3] = new int[] { 23, 56, 34, 56, 78 };
            for (int i = 0; i < jaggedarr.Length; i++)
            {
                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    Console.Write(jaggedarr[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
