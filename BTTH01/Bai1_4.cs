using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH01
{
    internal class Bai1_4
    {
        static void Main()
        {
            int a, b;
            Console.Write("Nhap a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b : ");
            b = System.Int32.Parse(Console.ReadLine());
            if(a > b)
            {
                Console.WriteLine($"{a} > {b}");
            }else if(a < b)
            {
                Console.WriteLine($"{a} < {b}");
            }
            else
            {
                Console.WriteLine($"{a} = {b}");
            }
        }
    }
}
