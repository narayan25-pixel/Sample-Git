using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class looping_demo
    {
        static void Main(string[] args)
        {
            for (int i=0;i<14;i++)
            {
                if (i == 10)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
