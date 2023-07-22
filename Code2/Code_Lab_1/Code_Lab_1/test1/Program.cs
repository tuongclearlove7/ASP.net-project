using System;
using System.Text;

namespace TinhNgayCuaCacThang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tháng : ");
            string thang = Console.ReadLine();
            int th = int.Parse(thang);
            int SoNgay = 0;
            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: SoNgay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: SoNgay = 30; break;

                    case 2:
                        Console.Write("Năm nào : ");
                        string nam = Console.ReadLine();
                        int nm = int.Parse(nam);
                        if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))
                            SoNgay = 29;
                        else
                            SoNgay = 28;
                        break;
                }

                Console.Write("=> Tháng " + th + " có " + SoNgay + " ngày\n");
            }
            else
                Console.Write("=> Không tồn tại tháng\n");
            Console.WriteLine("\n---------Kết thúc----------");
            Console.ReadLine();
        }
    }
}
