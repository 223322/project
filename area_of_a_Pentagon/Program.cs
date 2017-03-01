using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_a_Pentagon
{
    class Program
    {
        static int LongSides(int x1, int x2, int y1, int y2)
        {
            int tempX = x2 - x1, tempY = y2 - y1;
            int sides = (int)Math.Sqrt(Math.Pow(tempX, 2) + Math.Pow(tempY, 2));
            return sides;
        }
        static int AreaOfTriangle(int firstSides, int secondSides, int thirdSides)
        {
            int polyPerimeter = (firstSides + secondSides + thirdSides) / 2;
            int areaOfTriangle = (int)Math.Sqrt(polyPerimeter * (polyPerimeter - firstSides) * (polyPerimeter - secondSides) * (polyPerimeter - thirdSides));
            return areaOfTriangle;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first coordinate of the point 'a' ");
            int ax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point 'a' ");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first coordinate of the point 'b' ");
            int bx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point 'b' ");
            int by = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first coordinate of the point 'c' ");
            int cx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point 'c' ");
            int cy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first coordinate of the point 'd' ");
            int dx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point 'd' ");
            int dy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first coordinate of the point 'e' ");
            int ex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point 'e' ");
            int ey = Convert.ToInt32(Console.ReadLine());
            int ab = LongSides(ax, ay, bx, by);
            int be = LongSides(bx, by, ex, ey);
            int ea = LongSides(ex, ey, ax, ay);
            int bc = LongSides(bx, by, cx, cy);
            int ce = LongSides(cx, cy, ex, ey);
            int cd = LongSides(cx, cy, dx, dy);
            int de = LongSides(dx, dy, ex, ey);
            int firstAreaOfTriangle = AreaOfTriangle(ab, be, ea);
            int secondAreaOfTriangle = AreaOfTriangle(bc, be, ce);
            int thirdAreaOfTriangle = AreaOfTriangle(cd, be, de);
            int areaOfPentagon = firstAreaOfTriangle + secondAreaOfTriangle + thirdAreaOfTriangle;
            Console.WriteLine(areaOfPentagon);
        }
    }
}
