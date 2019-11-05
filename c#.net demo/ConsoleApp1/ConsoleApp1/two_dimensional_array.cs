using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class two_dimensional_array
    {
        static void Main(string[] args)
        {
            int columnsize, rowsize;
            Console.WriteLine("Enter the no of row of each row u need");
            rowsize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of column of each row u need");
            columnsize = int.Parse(Console.ReadLine());
            int[,] stumarks = new int[rowsize, columnsize];
            Console.WriteLine("Enter the {0} values", (rowsize * columnsize));
            for (int i = 0; i <= rowsize; i++)
            {
                for (int j = 0; j < columnsize; j++)

                {
                    stumarks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("enter 2");
            for (int i = 0; i < rowsize; i++)
            {
                for (int j = 0; j < columnsize; j++)
                {
                    Console.WriteLine(stumarks[i,j]);
                    Console.Write("\n");
                }
            }
        }
    }
}
