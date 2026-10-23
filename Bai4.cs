using System;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CAU 1: NHAP HO, TEN LOT, TEN -> XUAT HO TEN DAY DU ===");
            Console.Write("Nhap ho: ");
            string ho1 = Console.ReadLine() ?? "";
            
            Console.Write("Nhap ten lot: ");
            string tenlot1 = Console.ReadLine() ?? "";
            
            Console.Write("Nhap ten: ");
            string ten1 = Console.ReadLine() ?? "";
            
            Console.WriteLine("Ho va ten day du: {0} {1} {2}", ho1, tenlot1, ten1);
            Console.WriteLine();

            Console.WriteLine("=== CAU 2: NHAP HO TEN DAY DU -> TACH TUNG PHAN ===");
            Console.Write("Nhap ho ten: ");
            string fullname2 = Console.ReadLine() ?? "";
            
            string[] parts2 = fullname2.Split(new string[] { " " }, StringSplitOptions.None);
            
            if (parts2.Length >= 3)
            {
                Console.WriteLine("Ho: {0}, ten lot: {1}, ten: {2}", parts2[0], parts2[1], parts2[parts2.Length - 1]);
            }
            else if (parts2.Length == 2)
            {
                Console.WriteLine("Ho: {0}, ten lot: , ten: {1}", parts2[0], parts2[1]);
            }
            else if (parts2.Length == 1 && !string.IsNullOrWhiteSpace(parts2[0]))
            {
                Console.WriteLine("Ho: , ten lot: , ten: {0}", parts2[0]);
            }
            else
            {
                Console.WriteLine("Du lieu nhap vao khong hop le!");
            }
            Console.WriteLine();

            Console.WriteLine("=== CAU 3: CHUAN HOA HO TEN ===");
            Console.Write("Nhap ho ten (khong can theo chuan): ");
            string fullname3 = Console.ReadLine() ?? "";
            
            string[] parts3 = fullname3.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            
            if (parts3.Length == 0)
            {
                Console.WriteLine("Loi: Chuoi nhap vao khong hop le!");
            }
            else
            {
                for (int i = 0; i < parts3.Length; i++)
                {
                    if (parts3[i].Length > 0)
                    {
                        parts3[i] = parts3[i].Substring(0, 1).ToUpper() + parts3[i].Substring(1).ToLower();
                    }
                }
                
                string result3 = string.Join(" ", parts3);
                Console.WriteLine("Ten theo dung chuan la: " + result3);
            }
        }
    }
}