using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17_VongLapFor
{
    internal class Program
    {
        static void SapXep(int[] a,int n,int left,int right)
        {
            int l = left;
            int r = right;
            int m = (l + r) / 2;
            do
            {
                while (a[l] < a[m])
                {
                    l++;
                }
                while (a[r] > a[m])
                {
                    r--;
                }
                if(l <= r)
                {
                    int tg = a[l];
                    a[l] = a[r];
                    a[r] = tg;
                    l++;
                    r--;
                }
            } while (l <= r);
            if(left < r)
            {
                SapXep(a, n, left, r);
            }
            if(l < right)
            {
                SapXep(a, n, l, right);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n : ");
            n = System.Int32.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++){
                Console.Write($"Nhap a[{i}] : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("==== Xuat Mang ====");
            for (int i = 0; i < n; i++) {
  
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(a[i]);
            }
            //sap xep
            SapXep(a, n,0,n-1);
            Console.WriteLine("==== Sau Khi Sap Xep ====");
            for (int i = 0; i < n; i++)
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(a[i]);
            }
        }
    }
}
