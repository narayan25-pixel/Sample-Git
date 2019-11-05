using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class array_demo
    {
        static void Main(string[] args)
        {
            int arraysize;
            Console.WriteLine("enter the size of array");
            arraysize = int.Parse(Console.ReadLine());

            int[] myarray = new int[arraysize];
            Console.WriteLine("enter {0} integer values", arraysize);
            for (int i = 0; i < arraysize; i++)
            {
                myarray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("array elements are");
            foreach (var item in myarray)
                Console.WriteLine(item);


            Console.ReadLine();
        }
    }
}
