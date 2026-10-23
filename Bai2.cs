using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tham so a:");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Nhap tham so b:");
            double b = double.Parse(Console.ReadLine());
            
            if (a == 0) 
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.Write("Phuong trinh vo nghiem");
                }
            }
            else
            {
                double x = -b / a;
                Console.Write("Phuong trinh co nghiem x= " + x.ToString());
            }
        }
    }
}