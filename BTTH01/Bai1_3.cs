using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH01
{
    internal class Bai1_3
    {
        static void Main()
        {
            int a, b;
            Console.Write("Nhap a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b : ");
            b = System.Int32.Parse(Console.ReadLine());
            int lc;
            while (1 == 1)
            {
                Console.Write("Nhap Lua Chon De Chay Chuong Trinh : ");
                lc = Convert.ToInt32(Console.ReadLine());
                switch (lc)
                {
                    case 1:
                        {
                            float tong = a + b;
                            Console.WriteLine($"{a} + {b} = {tong}");
                        };break;
                    case 2:
                        {
                            float hieu = a - b;
                            Console.WriteLine("{0} - {1} = {2}",a,b,hieu);
                        }; break;

                    case 3:
                        {
                            float tich = a * b;
                            Console.WriteLine("{0} * {1} = {2}", a, b, tich);
                        }; break;
                    case 4:
                        {
                            float thuong = (float)a / b;
                            Console.WriteLine($"{a} / {b} = {thuong}");
                        }; break;
                    case 5:
                        {
                            float thuong = (float)a % b;
                            Console.WriteLine($"{a} / {b} = {thuong}");
                        }; break;
                }
            }
        }
    }
}
