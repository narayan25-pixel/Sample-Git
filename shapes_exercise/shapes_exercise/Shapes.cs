using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_exercise
{
   
    class Shapes
    {
        int r, l, w, area_rect, area_circle, area_square, a;
        public Shapes(int r,int l,int w,int a)
        {
            area_rect = l * w;
            area_circle = 22/7*r * r;
            area_square = a * a;
            Console.WriteLine("area of rectange is={0}\n area of circle is={1}\n area of square is={2}" ,area_rect,area_circle,area_square);
            
        }
    }
}
