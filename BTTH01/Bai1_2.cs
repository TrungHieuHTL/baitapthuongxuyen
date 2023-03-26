using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH01
{
    internal class Bai1_2
    {
       static void Main()
        {
            int n;
            n = System.Int32.Parse(Console.ReadLine());
            string kq1 = default;
            kq1 = (n % 2 == 0) ? "Chan" : "Le";
            Console.WriteLine("n la so " + kq1);
            string kq2 = default;
            kq2 = (n % 3 == 0) ? "Chia Het cho 3" : "Khong Chia Het cho 3";
            Console.WriteLine("n " + kq2);
        }
    }
}
