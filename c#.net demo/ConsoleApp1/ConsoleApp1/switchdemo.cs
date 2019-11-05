using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class switchdemo
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("enter the choice between 1-4");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:Console.WriteLine("first choice");
                    break;
                case 2:
                    Console.WriteLine("second choice");
                    break;
                case 3:
                    Console.WriteLine("third choice");
                    break;
                case 4:
                    Console.WriteLine("4th choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
