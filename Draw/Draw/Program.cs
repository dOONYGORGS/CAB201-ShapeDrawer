using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShapeDrawer.DrawSquare(10, 10));
            Console.WriteLine(ShapeDrawer.DrawIsoscelesTriangle(15));
            Console.ReadLine();
        }
    }
}
