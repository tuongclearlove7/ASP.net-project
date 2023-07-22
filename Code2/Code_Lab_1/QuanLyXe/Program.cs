using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachXe danhsach = new DanhSachXe();
            int a;
            do
            {
                Console.WriteLine("1: Nhập thông tin xe");
                Console.WriteLine("2: Xuất danh sách");
                Console.WriteLine("3: Tìm");
                Console.WriteLine("4 : Xóa");
                Console.WriteLine("5 : Đếm");
                Console.WriteLine("0 : Thoát ");
                a = int.Parse(Console.ReadLine()); //a = Int32.Parse(Console.ReadLine());
                switch(a)
                {
                    case 0: break;
                    case 1: danhsach.Nhap(); break;
                    case 2: danhsach.Xuat(); break;
                    case 3: danhsach.Tim(); break;
                    case 4: danhsach.Xoa(); break;
                    case 5: danhsach.Dem(); break;
                    default: Console.WriteLine("Không có trường hợp này, nhập lại"); break;
                }
            } while (a != 0);
            Console.WriteLine("----------------------- Kết thúc chương trình-------------------- ");
            Console.ReadLine();
        }        
    }
}
