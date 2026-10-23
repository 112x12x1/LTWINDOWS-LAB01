using System;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + i.ToString() + " :");
                mang[i] = int.Parse(Console.ReadLine());
            }

            int tong = 0;
            int max = mang[0];
            int min = mang[0];

            for (int i = 0; i < n; i++)
            {
                tong += mang[i];
                
                if (mang[i] > max)
                {
                    max = mang[i];
                }
                
                if (mang[i] < min)
                {
                    min = mang[i];
                }
            }

            Console.WriteLine("Tong cua mang la: " + tong.ToString());
            Console.WriteLine("So lon nhat trong mang la: " + max.ToString());
            Console.WriteLine("So nho nhat trong mang la: " + min.ToString());
        }
    }
}