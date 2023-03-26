using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH01
{
    internal class Bai1_1
    {
        static void Main(string[] args)
        {
            /*Viết chương trình in ra nội dung của 1 chuỗi kí tự
             * nào đó nhập từ bàn phím
             */
            Console.Title = "Nhap Xuat Chuoi";
            string msg;
            Console.Write("Nhap Chuoi : ");
            msg = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
