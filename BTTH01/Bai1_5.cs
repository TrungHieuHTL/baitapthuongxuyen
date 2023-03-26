using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH01
{
    internal class Bai1_5
    {
        static void Main()
        {
            int a, b, c, d;
            Console.Write("Nhap a : ");
            a = System.Int32.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            b = System.Int32.Parse(Console.ReadLine());
            Console.Write("Nhap c : ");
            c = System.Int32.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            d = System.Int32.Parse(Console.ReadLine());
            int min;

            if (a < b && a < c && a < d)
            {
                min = a;
            }
            else if (b < a && b < c && b < d)
            {
                min = b;
            }
            else if(c<a && c<b && c < d)
            {
                min=c;
            }
            else if(d<a && d<b && d < c)
            {
                min = d;
            }
            else
            {
                min = default;
            }
            Console.WriteLine($"Min = {min}");
        }
    }
}
