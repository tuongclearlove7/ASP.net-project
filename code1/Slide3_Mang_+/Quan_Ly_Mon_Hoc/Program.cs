/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Mon_Hoc
{
    class Program
    {
        ////////////////////  Cách 1
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Dictionary<int, string> danhsach = new Dictionary<int, string>();
            Dictionary<string, string> danhsach = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("----------------Nhập 0 để thoát -----------------Nhập 1 để nhập");
                string K;
                K = Console.ReadLine();
                if (K == "1")
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Nhập mã môn học: ");
                            //int Mamon; Mamon = int.Parse(Console.ReadLine());
                            string maMon; maMon = Console.ReadLine();
                            Console.WriteLine("Nhập tên môn học: ");
                            string tenMonHoc; tenMonHoc = Console.ReadLine();
                            danhsach.Add(maMon, tenMonHoc);
                            break;
                        }
                        catch (Exception)
                        { Console.WriteLine("Mã môn học bị trùng"); }
                    }
                }
                if (K == "0") break;
            }
            Console.WriteLine("-----------Xuất danh sách--------------");
            foreach (KeyValuePair<string, string> item in danhsach)
                //foreach (string item in danhsach.Keys)
                Console.WriteLine(item);

            ///// Dùng hàm for  ////////////////////////////////////////////////////////////////////////////////////
            //for (int i = 0; i < danhsach.Count; i++)
            //   Console.WriteLine("Key: {0} và Value: {1}", danhsach.Keys.ElementAt(i), danhsach.Values.ElementAt(i));
            //if (danhsach.ContainsValue("Thương Mại Điện Tử"))  // Phải dùng Console.OutputEncoding = Encoding.Unicode;
            //    Console.WriteLine("Đã tồn tại môn KT TMDT");
            //else
            //{
            //    Console.WriteLine("Chưa có môn kỹ thuật thương mại điện tử, danh sách sau khi chèn");
            //    danhsach.Add("IS385", "Kỹ Thuật TMDT");
            //}
            int tim = 0;
            foreach (KeyValuePair<string, string> item in danhsach)
            {
                if (item.Value == "TMDT")
                {
                    Console.WriteLine("Đã có môn TMDT này trong dah sách");
                    tim = 1;
                    break;
                }
            }
            if (tim == 0) 
            {
                danhsach.Add("IS385", "TMDT");
                Console.WriteLine("-----------Xuất danh sách sau khi them--------------");
                foreach (KeyValuePair<string, string> item in danhsach)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Có {0} môn học trong danh sách", danhsach.Count());

            //////////////////////////////////////////////////////// cách 1

            Console.WriteLine("-------------------------------------Nhập vị trí cần chèn: ---------------------");
            int vitri = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------Nhập mã môn học cần chèn: ---------------------");
            string maMonChen; maMonChen = Console.ReadLine();
            Console.WriteLine("------------------------Nhập tên môn học cần chèn: --------------------------------");
            string tenMonChen; tenMonChen = Console.ReadLine();


            List<KeyValuePair<string, string>> listT = danhsach.ToList();                  // Chuyển từ Dictionary qua List
            listT.Insert(vitri, new KeyValuePair<string, string>(maMonChen, tenMonChen));
            danhsach = listT.ToDictionary(x => x.Key, x => x.Value);                         // Chuyển từ List qua Dictionary
            Console.WriteLine("-----------Xuất danh sách sau khi chen------");
            foreach (KeyValuePair<string, string> item in danhsach)  // có thể thay danhsach = dic
            //foreach (KeyValuePair<string, string> item in listT)
            {
                //console.Write(item.Value);
                Console.WriteLine(item);
            }


            Console.WriteLine("****************Danh sách có {0} môn học********************", danhsach.Count);
            Console.WriteLine("-----------------Nhập mã môn cần xóa------------");
            string maMonXoa = Console.ReadLine();
            //foreach (KeyValuePair<string, string> item in listT)
            foreach (KeyValuePair<string, string> item in danhsach)
            {
                // if (item.Key == 002)  // kiểu int
                if (item.Key == maMonXoa)
                {

                    danhsach.Remove(item.Key);
                    break;        //// ở phiên bản mới thì ko cần break vì hàm foreach vẫn chạy khi danhsach bị thay đổi
                }
            }
            Console.WriteLine("***********************Xuất danh sách sau khi xóa mã môn {0}", maMonXoa);

            //// foreach (KeyValuePair<int, string> item in dic)
            foreach (KeyValuePair<string, string> item in danhsach)   // có thể thay danhsach = dic
            //foreach (KeyValuePair<string, string> item in listT)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Chương trình kết thúc");
            Console.ReadLine();
        }
    }
}*/

// Câu 2.1 (chèn vào vị trí n) //////////////////////////////////////////////////   Cách 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Mon_Hoc
{
    class Program
    {
        ////////////////////  Cách 1
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Dictionary<string, string> danhsach = new Dictionary<string, string>();
       
            danhsach.Add("CS403", "Công nghệ phần mềm");
            danhsach.Add("CS420", "Hệ phân tán");
            danhsach.Add("SE445", "Tích hợp hệ thống");
            Console.WriteLine("-------------------------------------Nhập vị trí cần chèn: ---------------------");
            int n = int.Parse(Console.ReadLine());
            if (n == danhsach.Count) danhsach.Add("IS385", "Kỹ thuật TMDT"); //n = 3
            else if (n >= 0 && n < danhsach.Count)
            {
                Dictionary<string, string> danhsachNEW = new Dictionary<string, string>();
                foreach (var item in danhsach)
                {
                    if (n == 0)
                    {
                        danhsachNEW.Add("IS385", "Kỹ thuật TMDT");
                        //n -= 1;  // sai
                    }
                    danhsachNEW.Add(item.Key, item.Value);
                    n = n - 1;
                }
                danhsach = danhsachNEW;
            }
            if (n > danhsach.Count) Console.WriteLine("Vị trí vượt quá giới hạn của danh dách");
            else
            {
                Console.WriteLine("Danh sách sau khi chèn");
                foreach (KeyValuePair<string, string> item in danhsach)
                {
                    //console.Write(item.Value);
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}

// Cách của SV, add vào List rồi chèn rồi chuyển lại thành Dictionary
/*
  using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_11072023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"DS321","Machine Learning 1" },
                {"DS371","Machine Learning 2" },
                {"CS403", "Cong Nghe Phan Mem"}
            };

            //List<Dictionary<string, string>> list = new List<Dictionary<string, string>>() ;
            //list.Add(new Dictionary<string, string>(dic));

            List<List<string>> list = new List<List<string>>();
            foreach (var i in dic)
            {
                List<string> item = new List<string> { i.Key, i.Value };
                list.Add(item);
            }

            foreach (var item in list)
            {
                Console.WriteLine(string.Join(": ", item));
            }

            Console.WriteLine(list.Count);

            string maMon;
            while (true)
            {
                Console.WriteLine("Nhập mã môn: ");
                maMon = Console.ReadLine();
                if (dic.ContainsKey(maMon))
                {
                    Console.WriteLine("Mã môn trùng, nhập lại:");
                }
                else break;
            }

            Console.WriteLine("Nhập tên môn ");
            string tenMon = Console.ReadLine();
            Console.WriteLine("Nhap vị trí: ");
            int n = int.Parse(Console.ReadLine());

            List<string> addItem = new List<string> { maMon, tenMon };

            if (n < 0) 
            { 
                n = 0; 
            }
            if (n > list.Count) 
            { 
                n = list.Count; 
            }

            list.Insert(n, addItem);
            dic.Clear();

            foreach (List<string> item in list)
            {
                string key = item[0];
                string value = item[1];
                dic.Add(key, value);
            }

            Console.WriteLine("Danh sách sau khi chèn: ");

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}

 */





/*// Câu 2.1 (chèn vào vị trí n) //////////////////////////////////////////////////   Cách 2.1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Mon_Hoc
{
class Program
{
////////////////////  Cách 1
static void Main(string[] args)
{
    Console.OutputEncoding = Encoding.Unicode;
    Console.InputEncoding = Encoding.Unicode;
    Dictionary<string, string> danhsach = new Dictionary<string, string>();
    //danhsach.Add("IS401", "Hệ quản trị cơ sở dữ liệu");
    //danhsach.Add("CR250", "Nền tảng hệ thống máy tính");
    //danhsach.Add("CS414", "Lập Trình Winforms");
    //danhsach.Add("CR424", "Lập trình Android");
    danhsach.Add("CS403", "Công nghệ phần mềm");
    danhsach.Add("CS420", "Hệ phân tán");
    danhsach.Add("SE445", "Tích hợp hệ thống");
    Console.WriteLine("-------------------------------------Nhập vị trí cần chèn: ---------------------");
    int n = int.Parse(Console.ReadLine());    // n = 3
    int k = n;    // k = 3
    if (n >= 0 && n <= danhsach.Count)
    {
        Dictionary<string, string> danhsachNEW = new Dictionary<string, string>();
        foreach (var item in danhsach)
        {
            if (n == 0)
            {
                danhsachNEW.Add("IS385", "Kỹ thuật TMDT"); //.Add("IS385", "Kỹ thuật thương mại điện tử");
                //n -= 1;  // sai
            }
            danhsachNEW.Add(item.Key, item.Value);
            n = n - 1;
        }
        if (k == danhsach.Count)
            danhsachNEW.Add("IS385", "Kỹ thuật TMDT");
        danhsach = danhsachNEW;
    }
    Console.WriteLine("Danh sách sau khi chèn");
    foreach (KeyValuePair<string, string> item in danhsach)
    {
        //console.Write(item.Value);
        Console.WriteLine(item);
    }
    Console.ReadLine();
}*/
       /* static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Dictionary<string, string> danhsach = new Dictionary<string, string>();

            danhsach.Add("CR250", "Nền tảng hệ thống máy tính");
            danhsach.Add("CR424", "Lập trình Android");
            danhsach.Add("IS401", "Hệ quản trị cơ sở dữ liệu");
            danhsach.Add("CS403", "Công nghệ phần mềm");
            danhsach.Add("SE445", "Tích hợp hệ thống");
            danhsach.Add("CS414", "Lập Trình Winforms");
            danhsach.Add("CS420", "Hệ phân tán");
            foreach (KeyValuePair<string, string> item in danhsach)
            {
                Console.WriteLine(item);
            }
            string maMon = "TMDT";
            string tenMon = "Thương Mại DT";
            Dictionary<string, string> monhoc2 = new Dictionary<string, string>();
            Console.WriteLine("Nhập vị trí cần chèn: ");
            int vitri = int.Parse(Console.ReadLine());
            int i = 0;
            foreach (KeyValuePair<string, string> item in danhsach)
            {
                if (i == vitri)
                {
                    monhoc2.Add(maMon, tenMon);
                }
                monhoc2.Add(item.Key, item.Value);
                i++;
            }
            if (vitri == danhsach.Count)
                monhoc2.Add(maMon, tenMon);
            danhsach = monhoc2;
            Console.WriteLine("Danh sách sau khi chèn vào vị trí {0}", vitri);
            foreach (KeyValuePair<string, string> item in danhsach)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}*/
       

        ////////////////////////////////////////////////////////////////////  Cách 4


//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dictionary_b1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.Unicode;
//            Console.InputEncoding = Encoding.Unicode;
//            Dictionary<string, string> d = new Dictionary<string, string>();
//            while (true)
//            {
//                Console.WriteLine("Nhập 0 để thoát---Nhập 1 để nhập môn");
//                string input;
//                input = Console.ReadLine();
//                if (input == "1")
//                {
//                    do
//                    {
//                        try
//                        {
//                            Console.WriteLine("Nhập mã môn");
//                            string ma_mon = Console.ReadLine();
//                            Console.WriteLine("Nhập tên môn:");
//                            string ten_mon = Console.ReadLine();
//                            KeyValuePair<string, string> k = new KeyValuePair<string, string>(ma_mon, ten_mon);
//                            d.Add(k.Key, k.Value);
//                            break;
//                        }
//                        catch (Exception ex)
//                        {
//                            Console.WriteLine("Nhập lại");
//                        }

//                    } while (true);
//                }
//                if (input == "0")
//                    break;
//            }

//            foreach (KeyValuePair<string, string> item in d)
//            {
//                Console.WriteLine("Mã môn {0} , Tên Môn {1}", item.Key, item.Value);
//            }
//            Console.WriteLine("***-----------***");

//            if (d.ContainsValue("KTTMDT"))
//            {
//                Console.WriteLine("Đã có môn KTTMDT");
//                foreach (KeyValuePair<string, string> item in d)
//                {
//                    Console.WriteLine("Mã môn {0} , Tên Môn {1}", item.Key, item.Value);
//                }
//                Console.WriteLine("***-----------***");
//            }
//            else
//            {
//                //Console.WriteLine("Đã chèn KTTMDT");
//                //d.Add("IS311", "KTTMDT");

//                int n;
//                do
//                {
//                    Console.WriteLine("Nhập vào vị trí n cần chèn");
//                    n = int.Parse(Console.ReadLine());
//                    if (n >= 0 && n <= d.Count)
//                    {
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Nhập n trong khoảng cho phép");
//                    }
//                } while (true);

//                Dictionary<string, string> d1 = new Dictionary<string, string>();
//                if (n == 0)    // n la vi tri chen vao
//                {
//                    d1.Add("IS311", "KTTMDT");
//                    foreach (KeyValuePair<string, string> k in d)
//                    {
//                        d1.Add(k.Key, k.Value);
//                    }
//                }
//                else if (n == d.Count)
//                {
//                    foreach (KeyValuePair<string, string> k in d)
//                    {
//                        d1.Add(k.Key, k.Value);
//                    }
//                    d1.Add("IS311", "KTTMDT");
//                }
//                else
//                {
//                    for (int i = 0; i < n; i++)
//                    {
//                        KeyValuePair<string, string> k = d.ElementAt(i);
//                        d1.Add(k.Key, k.Value);
//                    }
//                    d1.Add("IS311", "KTTMDT");
//                    for (int i = n; i < d.Count; i++)
//                    {
//                        KeyValuePair<string, string> k = d.ElementAt(i);
//                        d1.Add(k.Key, k.Value);
//                    }
//                }
//                d = d1;
//                foreach (KeyValuePair<string, string> k in d)
//                {
//                    Console.WriteLine("Mã môn {0} , Tên Môn {1}", k.Key, k.Value);
//                }
//                Console.WriteLine("***-----------***");
//            }

//            Console.WriteLine("có tất cả {0} môn học", d.Count);

//            if (d.ContainsKey("CS464"))
//            {
//                d.Remove("CS464");
//                Console.WriteLine("Đã xóa CS464");
//                Console.WriteLine("***-----------***");
//            }
//            else
//            {
//                Console.WriteLine("Không có mã môn CS464");
//            }

//            foreach (KeyValuePair<string, string> k in d)
//            {
//                Console.WriteLine("Mã môn {0} , Tên Môn {1}", k.Key, k.Value);
//            }
//            Console.WriteLine("***-----------***");
//            Console.ReadLine();
//        }
//    }
//}   



         ////////////////////////////////////////////////////////////////////////////////////////////   Cách 5 
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Mon_Hoc
{
    class Program
    {
        ////////////////////  Cách 1
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Dictionary<string, string> monhoc = new Dictionary<string, string>();

            monhoc.Add("CR250", "Nền tảng hệ thống máy tính");
            monhoc.Add("CR424", "Lập trình Android");
            monhoc.Add("IS401", "Hệ quản trị cơ sở dữ liệu");
            monhoc.Add("CS403", "Công nghệ phần mềm");
            monhoc.Add("SE445", "Tích hợp hệ thống");
            monhoc.Add("CS414", "Lập Trình Winforms");
            monhoc.Add("CS420", "Hệ phân tán");
            foreach (var item in monhoc)
            {
                Console.WriteLine(item.Key + "---" + item.Value);
            }
            Console.WriteLine();
            if (monhoc.ContainsKey("CR424"))
                monhoc.Remove("CR424");
            Console.WriteLine("-----------Danh sách sau khi xóa môn CR424-----------------------------");
            foreach (var item in monhoc)
            {
                Console.WriteLine(item.Key + "---" + item.Value);
            }

            Console.WriteLine("\nNhập vị trí cần chèn n = "); int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> monhoc2 = new Dictionary<string, string>();
            if (!monhoc.ContainsKey("IS384") && !monhoc.ContainsValue("Kỷ thuật thương mại điện tử"))
            {
                int i = 0;
                foreach (var item in monhoc)
                {
                    if (n == 0)   // n là vị trí
                    {
                        monhoc2.Add("IS384", "Kỷ thuật thương mại điện tử");
                        monhoc2.Add(item.Key, item.Value);   // thêm theo vòng lặp foreach vì lúc này chèn vào IS384, nếu như ko có dòng này thì 
                        n--;                                     // sẽ không xuất ra môn CR250
                    }
                    else
                    {
                        i++;
                        monhoc2.Add(item.Key, item.Value);
                        if (i == n)
                        {
                            monhoc2.Add("IS384", "Kỷ thuật thương mại điện tử");
                        }
                    }
                }
                monhoc.Clear();
                monhoc = monhoc2;
            }
            else Console.WriteLine("Tồn tại môn kỹ thuật thương mại điện tử");
            Console.WriteLine();
            foreach (var item in monhoc)
            {
                Console.WriteLine(item.Key + "---" + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("CÓ {0} môn học !", monhoc.Count);
            Console.WriteLine();
            if (monhoc.ContainsKey("CS403"))
            {
                monhoc.Remove("CS403");
                foreach (var item in monhoc)
                {
                    Console.WriteLine(item.Key + "---" + item.Value);
                }
            }
            else Console.WriteLine("Không tồn tại môn CS403");
            Console.ReadLine();
        }
    }
}*/




        ////////////////////////////////////////////////////////////////////////////////////////////   Cách 4 của sinh viên, nhưng nếu xóa thì
        // sau khi chèn thì thứ tự danh sách sẽ đảo ngược

        /*      static void Main(string[] args)
              {
                  Console.OutputEncoding = Encoding.Unicode;
                  Console.InputEncoding = Encoding.Unicode;
                  Dictionary<string, string> monhoc = new Dictionary<string, string>();
                  while (true)
                  {
                      Console.WriteLine("nhập mã môn học");
                      string mamon = Console.ReadLine();
                      Console.WriteLine("nhập  tên môn học");
                      string tenmonhoc = Console.ReadLine();
                      monhoc.Add(mamon, tenmonhoc);
                      Console.WriteLine("bấm 1 để dừng , bấm số bất kỳ để tiếp tục nhâp");
                      int so = int.Parse(Console.ReadLine());

                      if (so == 1)
                          break;
                  };

                  //dem co bao  nhieu mon
                  Console.WriteLine("so mon hoc {0}", monhoc.Count);

                  Console.WriteLine();
                  //in

                  for (int i = 0; i < monhoc.Count; i++)
                  {
                      Console.Write("[{0},{1}]", monhoc.Keys.ElementAt(i), monhoc.Values.ElementAt(i));
                      Console.WriteLine();
                  }
            
                   //foreach (KeyValuePair<string, string> item in monhoc)
                   //{
                   //    Console.WriteLine(item);
                   //}
           
                  int checkxoa = 0;
                  // xoa mon cs414
                  foreach (KeyValuePair<string, string> item in monhoc)
                  {
                      if (item.Key == "cs414")
                      {
                          monhoc.Remove("cs414");
                          checkxoa = 1;
                          break;
                      }
                  }
                  //xoa
                  Console.WriteLine("\n");
                  if (checkxoa == 0)
                  {
                      Console.WriteLine("không có môn cs414 để xóa, danh sách vẫn giữ nguyên /n ----- Xuất danh sách vẫn giữ nguyên");
                      foreach (KeyValuePair<string, string> item in monhoc)
                      {
                          Console.WriteLine(item);
                      }
                  }
                  else
                  {
                    //  Dictionary<string, string> temp1 = new Dictionary<string, string>();
                      Console.WriteLine("----------------------------Xuất danh sách sau khi xóa môn cs414");
                      //for (int i = 0; i < monhoc.Count; i++)
                      //{
                      //  //  temp1.Add(monhoc.Keys.ElementAt(i), monhoc.Values.ElementAt(i));
                      //    Console.Write("[{0},{1}]", monhoc.Keys.ElementAt(i), monhoc.Values.ElementAt(i));
                      //    Console.WriteLine();
                      //}            
                      foreach (KeyValuePair<string, string> item in monhoc)
                      {
                          Console.WriteLine(item);
                      }
                      Console.WriteLine("----------------Xuất theo KEY");
                      foreach (KeyValuePair<string, string> item in monhoc)
                      {
                          Console.WriteLine(item.Key);
                      }
                      Console.WriteLine("-------------------Xuất theo VALUE");
                      foreach (KeyValuePair<string, string> item in monhoc)
                      {
                          Console.WriteLine(item.Value);
                      }

                    //  monhoc.Clear();
                    //  for (int i = 0; i < temp1.Count; i++)
                     // {

                       //   monhoc.Add(temp1.Keys.ElementAt(i), temp1.Values.ElementAt(i));
                    //  }
                  }

                  //chen vao vi tri 
                  Console.WriteLine("nhap vi tri can chen");
                  int x = int.Parse(Console.ReadLine());

                  Dictionary<string, string> temp = new Dictionary<string, string>();
                  if (!monhoc.ContainsValue("ky thuat thuong mai dien tu"))
                  {

                      for (int i = x; i < monhoc.Count; i++)
                      {
                          temp.Add(monhoc.Keys.ElementAt(i), monhoc.Values.ElementAt(i));
                      }

                      for (int i = monhoc.Count - 1; i >= x; i--)
                      {
                          monhoc.Remove(monhoc.Keys.ElementAt(i));

                      }

                      monhoc.Add("tmdt", "ky thuat thuong mai dien tu");
                      for (int i = 0; i < temp.Count; i++)
                      {
                          monhoc.Add(temp.Keys.ElementAt(i), temp.Values.ElementAt(i));
                      }
                      Console.WriteLine();
                      Console.WriteLine("sau khi chen ");
                      foreach(KeyValuePair<string, string> item in monhoc)
                      {
                          Console.WriteLine(item);
                      }
                      //for (int i = 0; i < monhoc.Count; i++)
                      //{
                      //    Console.Write("[{0},{1}]", monhoc.Keys.ElementAt(i), monhoc.Values.ElementAt(i));
                      //    Console.WriteLine();
                      //}
                  }
                  Console.ReadLine();
              } */


