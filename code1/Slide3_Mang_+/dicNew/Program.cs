using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Dictionary<string, string> danhsach = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát, nhập 1 để thêm thông tin SV, nhập 2 để tìm môn TMDT,  nhập 3 để xóa môn LTUD, nhập 4 đếm, nhập 6 xuất danh sách");
                string nhap = Console.ReadLine();
                if (nhap == "0") break;
                else if (nhap == "1")
                {
                    Console.WriteLine("Nhập mã môn và tên môn");
                    while (true)
                    {
                        try
                        {
                            string maMon = Console.ReadLine();
                            string tenMon = Console.ReadLine();
                            danhsach.Add(maMon, tenMon); break;
                        }
                        catch
                        {
                            Console.WriteLine("Mã bị trùng, nhập lại");
                        }
                    }

                }
                else if (nhap == "2")
                {
                    if (danhsach.ContainsValue("Thương Mại DT"))
                        Console.WriteLine("Có môn Thương Mại DT");
                    else
                    {
                        Console.WriteLine("Chưa Có môn Thương Mại DT, Danh sách sau khi thêm");
                        danhsach.Add("TMDT", "Thương Mại ĐT");
                    }
                    foreach (KeyValuePair<string, string> item in danhsach)
                        Console.WriteLine(item);
                }
                else if(nhap == "3")
                {
                    if(danhsach.ContainsKey("CS464"))
                    {
                        Console.WriteLine("Có môn cần xóa");
                        danhsach.Remove("CS464");
                    }
                }
                else if (nhap == "4")
                    Console.WriteLine("Trong danh sách có {0} môn học", danhsach.Count);
                else if (nhap == "6")    // Xuất danh sách
                    foreach (KeyValuePair<string, string> item in danhsach)
                        Console.WriteLine(item);
            }
        }
    }
}
