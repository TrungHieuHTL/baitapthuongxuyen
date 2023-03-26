using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH01
{
    internal class Bai1_9
    {
        static void Main()
        {
            int a, b;
            Console.Write("Nhap a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b : ");
            b = Convert.ToInt32(Console.ReadLine());
            float x = default;
            if(a == 0)
            {
                Console.WriteLine("Phuong Trinh Vo Nghiem");
            }else if(b == 0)
            {
                x = 0;
                Console.WriteLine($"x = {x}");
            }
            else
            {
                x = (float)-b / a;
                Console.WriteLine($"x = {x}");
            }

            
        }
    }
}
