using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_MonHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Dictionary<string, string> DS = new Dictionary<string, string>();
            while(true)
            {
                int n;
                Console.WriteLine("Nhập 0 để thoát, nhập 1 để tiếp tục");
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Nhập mã môn học:");
                            string maMon = Console.ReadLine();
                            Console.WriteLine("Nhập tên môn học:");
                            string monHoc = Console.ReadLine();
                            DS.Add(maMon, monHoc);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Mã môn học bị trùng");
                        }
                    }
                }
                if (n == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Danh sách môn học: ");
            foreach (KeyValuePair<string, string> item in DS)
            {
                Console.WriteLine(item);
            }

            if (!DS.ContainsValue("KTTMDT"))
            {
                Console.WriteLine("Chưa có môn KTTMDT, hãy nhập vị trí bạn muốn chèn (0 <= k <= {0}): ", DS.Count());
                int k = int.Parse(Console.ReadLine());
                if (k == DS.Count()) DS.Add("IS385", "KTTMDT");
                if (k >= 0 && k < DS.Count())
                {
                    Dictionary<string, string> DSNew = new Dictionary<string, string>();
                    foreach (var item in DS)
                    {
                        if (k == 0)
                        {
                            DSNew.Add("IS385", "KTTMDT");
                            break;
                        }
                        else
                        {
                            DSNew.Add(item.Key, item.Value);
                            k = k - 1;
                        }
                    }
                    Dictionary<string, string> DS2 = new Dictionary<string, string>(DSNew);
                    foreach (var kvp in DS)
                    {
                        if (!DS2.ContainsKey(kvp.Key))
                        {
                            DS2.Add(kvp.Key, kvp.Value);
                        }
                    }
                    
                    DS = DS2;
                    Console.WriteLine("Danh sách môn học sau khi chèn: ");
                    foreach (KeyValuePair<string, string> item in DS)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Bạn đã nhập sai");
                }
            } else
            {
                Console.WriteLine("Đã tồn tại môn KTTMDT");
            }

            Console.WriteLine("Số lượng môn học là: {0}", DS.Count());

            foreach (KeyValuePair<string, string> item in DS)
            {
                if (item.Value == "CS464")
                {
                    DS.Remove(item.Key);
                    break;
                }
            }
            Console.WriteLine("Mảng sau khi xóa môn CS464 (nếu có): ");
            foreach (KeyValuePair<string, string> item in DS)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
