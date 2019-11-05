using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class switch_with_char
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("Enter the value from A-D");
            x = Convert.ToChar(Console.ReadLine());
            char y = Convert.ToChar(x.ToString().ToUpper());
            switch(y)
            {
                case 'A':Console.WriteLine("Apple");break;
                case 'B': Console.WriteLine("ball"); break;
                case 'C': Console.WriteLine("chips"); break;
                case 'D': Console.WriteLine("dates"); break;
                default:Console.WriteLine("invalid");break;
            }
            Console.ReadLine();
        }
    }
}
