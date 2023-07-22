using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{
    class DANHSACH_NHANVIEN
    {
        Dictionary<string, NHANVIEN> danhsach;
        internal Dictionary<string, NHANVIEN> Danhsach
        {
            get { return danhsach; }
            set { danhsach = value; }
        }
        
        public DANHSACH_NHANVIEN()
        {
            Danhsach = new Dictionary<string, NHANVIEN>();
        }
        public void LuaChon()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("-------****************Nhập 0 để thoát, 1 để thêm nhan vien"
                    + ", 2 để chèn vị trí, 3 để xuất danh sách nhan vien, 4 để tìm xe theo yêu cầu *****************-------");
                string luaChon = Console.ReadLine();
                if (luaChon == "0")
                    break;
                if (luaChon == "1")
                    Nhap();
                else if (luaChon == "2")
                    Chen();
                else if (luaChon == "3")
                    Xuat();
                else if (luaChon == "4") Tim();
            }
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode; Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("Nhập C để nhập nhan vien hop dong, D để nhập nhan vien bien che, Exit để thoát khỏi yêu cầu nhập");
                string option = Console.ReadLine().ToUpper();
                if (option == "EXIT") break;
                if (option == "C")
                {
                    NHANVIEN nv = new NHANVIEN_HOPDONG();
                    while (true)
                    {
                        try
                        {
                            nv.Nhap();
                            Danhsach.Add(nv.Manv, nv);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng");
                        }
                    }
                }
                if (option == "D")
                {
                    NHANVIEN nv = new NHANVIEN_BIENCHE();
                    while (true)
                    {
                        try
                        {
                            nv.Nhap();
                            Danhsach.Add(nv.Manv, nv);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng");
                        }
                    }
                }
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Xuất danh sách nhan vien");
            foreach (NHANVIEN item in Danhsach.Values)
            {
                item.Xuat();
                Console.WriteLine("luong thuc linh la : {0}",item.thuclinh());
            }

           
        }

        public NHANVIEN Tim()
        {
            Console.WriteLine("Nhập ma nhan vien cần tìm");
            string manvTim = Console.ReadLine();
            int tim = 0;
            NHANVIEN NV = null;
            foreach (NHANVIEN item in Danhsach.Values)
            {
                if (item.Manv == manvTim)
                {
                    tim = 1;
                    NV = item;
                    Console.WriteLine("Có ma nhan vien vua tim là {0}", manvTim);
                    NV.Xuat();
                    Console.WriteLine("luong thuc linh la : {0}", item.thuclinh());
                    break;
                }
            }
            if (tim == 0)
                Console.WriteLine("Không Có ma nhan vien {0}", manvTim);
            return NV;
        }

        public void Chen()
        {
            Console.WriteLine("Nhập vị trí cần chèn: "); int n = int.Parse(Console.ReadLine());

            List<KeyValuePair<string, NHANVIEN>> listT = Danhsach.ToList();     // Chuyển từ Dictionary qua List          
            if (n > Danhsach.Count) Console.WriteLine("Vị trí nhập nằm ngoài danh sách");
            else
            {
                while (true)
                {
                    Console.WriteLine("Nhập C để nhập nhan vien hop dong, D để nhập nhan vien bien che, Exit để thoát khỏi yêu cầu nhập");
                    string option = Console.ReadLine().ToUpper();
                    if (option == "EXIT") break;
                    if (option == "C")
                    {
                        NHANVIEN nv = new NHANVIEN_HOPDONG();
                        nv.Nhap();
                        listT.Insert(n, new KeyValuePair<string, NHANVIEN>(nv.Manv, nv));
                    }
                    if (option == "D")
                    {
                        NHANVIEN nv = new NHANVIEN_BIENCHE();
                        nv.Nhap();
                        listT.Insert(n, new KeyValuePair<string, NHANVIEN>(nv.Manv, nv));
                    }
                    Console.WriteLine("Bạn có muốn chèn tiếp ko, nếu không có thì nhập vị trí n = -1, ngược lại nhập vị trí n cần nhập");
                    n = int.Parse(Console.ReadLine());
                    if (n == -1) break;
                }
                danhsach = listT.ToDictionary(x => x.Key, x => x.Value);// Chuyển từ List qua Dictionary
                Console.WriteLine("Danh sách sau khi chèn vào vị trí số {0}: -----------------------", n);
                foreach (KeyValuePair<string, NHANVIEN> item in danhsach)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
