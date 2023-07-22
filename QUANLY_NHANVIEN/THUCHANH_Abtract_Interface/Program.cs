using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH_Abtract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DANHSACHNHANVIEN DSNV = new DANHSACHNHANVIEN();
            int luaChon;
            do
            {
                Console.WriteLine("Nhập 1 để Nhập, 2 để Xuất, 3 để Tìm, 4 để Xóa, 5 để Sửa, 0 để Thoát");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 0: break;
                    case 1: DSNV.Nhap(); break;
                    case 2: DSNV.Xuat(); break;
                    case 3: DSNV.Tim(); break;
                    case 4: DSNV.Xoa(); break;
                    case 5: DSNV.Sua(); break;
                    default: Console.WriteLine("Chỉ nhập từ 0 đến 5"); break;
                }
            } while (luaChon != 0);
    
            Console.WriteLine("---------Tổng quỹ lương là: {0}   ----------------------",DSNV.TongQuyLuong());
            Console.WriteLine("*******Chương trình kết thúc******");
            Console.ReadLine();
        }
    }
}
