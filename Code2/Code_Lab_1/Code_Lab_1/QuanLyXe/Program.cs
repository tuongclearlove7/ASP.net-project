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
            Dictionary<string, XE> Dic = new Dictionary<string, XE>();
            while(true)
            {
                XE xe = new XE();
                Console.WriteLine("Nhập vào 0 để thoát \n1: để nhập xe mới, \n2: xóa 1 xe theo biển số, \n3: tìm kiếm và in ra xe theo biển số, \n4: để xuất ra danh sách");
                int x = int.Parse(Console.ReadLine());
                if (x == 0) break;
                if (x == 1)
                {
                    //XE xe = new XE();
                    xe.Nhap();
                    Dic.Add(xe.BienSo, xe);
                    //Dic.Add(xe.BienSo, xe);
                }
                if (x == 2)
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
                if (x == 3)
                {
                    Console.WriteLine("*****************  Nhập biển số cần tìm ****************"); 
                    string bienSoTim = Console.ReadLine();
                    //var itemT = list.SingleOrDefault(XE => xe.Bienso == biensoTim);
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
                    if(tim == 0)
                            Console.WriteLine("*************** Không có xe cần tìm  *****************");
                }
                if (x == 4)
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
                    break;
                }
                if (x < 0 || x > 4)
                {
                    Console.WriteLine("\n------------------------  Chỉ nhập từ 0 -> 4  ---------------------------");
                }
            }
            Console.WriteLine("----------------------- Kết thúc chương trình-------------------- ");
            Console.ReadLine();
        }        
    }
}
