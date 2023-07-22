using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class DanhSachXe
    {
        Dictionary<string, XE> Dic = new Dictionary<string, XE>();
        public void Nhap()
        {
            XE xe; 
            while(true)
            {
                 Console.WriteLine("Nhập 0 để vào menu ----- Nhập 1 để nhập xe mới");
                 int x = int.Parse(Console.ReadLine());
                 if (x == 0) break;
                 if (x == 1)
                 {
                  xe = new XE();
                  xe.Nhap();
                  Dic.Add(xe.BienSo, xe);
                 }
            }
           
        }
        public void Xuat()
        {
                if (Dic.Count == 0) Console.WriteLine("--------Danh sách null---------------");
                if (Dic.Count > 0)
                {
                    Console.WriteLine("********Xuất danh sách xe **************");
                    foreach (XE item in Dic.Values)
                    {
                        item.Xuat(); 
                    }
                }
        }
        public void Tim()
        {
                Console.WriteLine("*****************  Nhập biển số cần tìm ****************");
                string bienSoTim = Console.ReadLine();
                int tim = 0;
                foreach (XE item in Dic.Values)    //foreach(kieuphantu ten in danhsach) 
                    if (item.BienSo == bienSoTim)
                    {
                        tim = 1;
                        Console.WriteLine("*************** Có xe cần tìm  *****************");
                        Console.WriteLine("*************** Xe sau khi tìm  *************");
                        item.Xuat();
                        break;
                    }
                    else
                        tim = 0;
                if (tim == 0)
                    Console.WriteLine("*************** Không có xe cần tìm  *****************");
        }
        public void Xoa()
        {
                Console.WriteLine("-----------------Nhập biển số xe cần xóa------------");
                string bienSoXoa = Console.ReadLine();
                if (Dic.ContainsKey(bienSoXoa))
                {
                    Console.WriteLine("---------------Có biển số cần xóa-----------------");
                    Dic.Remove(bienSoXoa);
                }
                else Console.WriteLine("------Không có biển số cần xóa---------");
        }
        public void Dem()
        {
            Console.WriteLine("Số lượng xe trong danh sách là: {0}", Dic.Count());
        }
    }
}
