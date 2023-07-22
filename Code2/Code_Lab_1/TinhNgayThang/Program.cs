using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhNgayThang
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            int month;
            Console.Write("Nhập vào 1 tháng trong nam: ");
            // month = Convert.ToInt32(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("\n Thang {0} có 31 ngày", month);
                    // Console.ReadLine();
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("\n Thang {0} có 30 ngày", month);
                    //   Console.ReadLine();
                    break;

                case 2:
                    Console.Write("\n Nhap nam: ");
                    int year = int.Parse(Console.ReadLine());
                    if (year % 100 != 0 && year % 4 == 0 || year % 400 == 0)
                    {
                        Console.Write("\nNam {0} là nam nhuan");
                        Console.Write("\nThang {0} có 29 ngày", month);
                    }
                    else
                        Console.Write("\nThang {0} co 28 ngay", month);
                    break;
                default:
                    Console.Write("Default case");
                    //  Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
