using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapSoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập số từ 100 -> 999");
            while (true){
                try{
                    do {
                        n = int.Parse(Console.ReadLine());
                        if (n <= 99 || n >999){
                            Console.WriteLine("ban phai nhap 99 < n < 1000!!!");
                            Console.Write("Vui long nhap so: ");
                        }
                    } while (n <= 99 || n >= 1000);
                    break;
                }
                catch (Exception){
                    Console.WriteLine("Nhap sai, hay nhap so!!!");
                }
            }
            int d = n / 100; // Lấy số đầu
            int c = n % 10;  // Lấy số cuối
            Console.WriteLine("Tổng của số đầu và cuối là {0}", d + c);
            //Console.WriteLine("Tổng của số đầu và cuối là: " + (d + c));
            Console.WriteLine("Tích của số đầu và cuối là: {0}", d * c);
            Console.WriteLine("------------------------------------------------------Kết thúc chương trình-----");
            Console.ReadLine();  // Dừng màn hình để xem kết quả
        }
    }
}
