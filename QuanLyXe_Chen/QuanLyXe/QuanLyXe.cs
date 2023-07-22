using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class QuanLyXe
    {
        Dictionary<string, Xe> danhsach;
        internal Dictionary<string, Xe> Danhsach{
            get { return danhsach; }
            set { danhsach = value; }
        }
        public QuanLyXe()
        {
            Danhsach = new Dictionary<string,Xe>();
        }
        public void LuaChon(){
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while(true){
                Console.WriteLine("-------****************Nhập 0 để thoát, 1 để thêm xe" 
                    + ", 2 để chèn vị trí, 3 để xuất danh sách xe, 4 để tìm xe theo yêu cầu *****************-------");
                string luaChon = Console.ReadLine();
                if(luaChon == "0")
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
        public void Nhap(){
            Console.OutputEncoding = Encoding.Unicode;         Console.InputEncoding = Encoding.Unicode;
            while(true) {
                Console.WriteLine("Nhập C để nhập xe chở hàng, D để nhập xe du lịch, Exit để thoát khỏi yêu cầu nhập");
                string option = Console.ReadLine().ToUpper();
                if (option == "EXIT") break;
                if (option == "C"){
                    Xe xe = new XeChoHang();
                    while(true){
                        try {
                            xe.Nhap();
                            Danhsach.Add(xe.BienSo, xe);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng");
                        }
                    }
                }
                if(option == "D")
                {
                    Xe xe = new XeDuLich();
                    while(true)
                    {
                        try
                        {
                            xe.Nhap();
                            Danhsach.Add(xe.BienSo, xe);
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
            Console.WriteLine("Xuất danh sách xe");
            foreach (Xe item in Danhsach.Values)
            {
                item.Xuat();
            }
        }

        public Xe Tim(){
            Console.WriteLine("Nhập biển số xe cần tìm");
            string bienSoTim = Console.ReadLine();
            int tim = 0;
            Xe X = null;
            foreach (Xe item in Danhsach.Values){
                if (item.BienSo == bienSoTim){
                    tim = 1;
                    X = item;
                    Console.WriteLine("Có xe cần tìm biển số là {0}", bienSoTim);
                    X.Xuat();
                    break;
                }
            }
            if(tim == 0)
                Console.WriteLine("Không Có xe cần tìm biển số là {0}", bienSoTim);
            return X;
        }

        public void Chen()
        {            
            Console.WriteLine("Nhập vị trí cần chèn: "); int n = int.Parse(Console.ReadLine());
            //Dictionary<string, Xe> danhsachNEW = new Dictionary<string, Xe>();                      // Khai báo danh sách mới (rỗng)    
            //if (n == danhsach.Count)
            //    Nhap(); // hoặc nhập đúng 1 xe như bên dưới
            //else if (n >= 0 && n < danhsach.Count)
            //{
            //    foreach (var item in danhsach)
            //    {
            //        if (n == 0)
            //        {
            //            Console.OutputEncoding = Encoding.Unicode; Console.InputEncoding = Encoding.Unicode;
            //            while (true)
            //            {
            //                Console.WriteLine("Nhập C để nhập xe chở hàng, D để nhập xe du lịch, exit để thoát");
            //                string option = Console.ReadLine().ToUpper();
            //                if (option == "EXIT") break;
            //                else if (option == "C")
            //                {
            //                    Xe xe = new XeChoHang();
            //                    xe.Nhap();
            //                    danhsachNEW.Add(xe.BienSo, xe);
            //                }
            //                else if (option == "D")
            //                {
            //                    Xe xe = new XeDuLich();
            //                    xe.Nhap();
            //                    danhsachNEW.Add(xe.BienSo, xe);
            //                }
            //            }
            //        }
            //        danhsachNEW.Add(item.Key, item.Value);
            //        n = n - 1;
            //    }
            //    danhsach = danhsachNEW;
            //}
            //Console.WriteLine("Danh sách sau khi chèn");
            //foreach (KeyValuePair<string, Xe> item in danhsach)
            //{
            //    Console.WriteLine(item);
            //}
            List<KeyValuePair<string, Xe>> listT = Danhsach.ToList();     // Chuyển từ Dictionary qua List          
            if (n > Danhsach.Count) Console.WriteLine("Vị trí nhập nằm ngoài danh sách");
            else
            {
                while (true)
                {
                    Console.WriteLine("Nhập C để nhập xe chở hàng, D để nhập xe du lịch, exit để thoát");
                    string option = Console.ReadLine().ToUpper();
                    if (option == "EXIT") break;
                    if (option == "C")
                    {
                        Xe xe = new XeChoHang();
                        xe.Nhap();
                        listT.Insert(n, new KeyValuePair<string, Xe>(xe.BienSo, xe));
                    }
                    if (option == "D")
                    {
                        Xe xe = new XeDuLich();
                        xe.Nhap();
                        listT.Insert(n, new KeyValuePair<string, Xe>(xe.BienSo, xe));
                    }
                    Console.WriteLine("Bạn có muốn chèn tiếp ko, nếu không có thì nhập vị trí n = -1, ngược lại nhập vị trí n cần nhập");
                    n = int.Parse(Console.ReadLine());
                    if (n == -1) break;
                }
                danhsach = listT.ToDictionary(x => x.Key, x => x.Value);                         // Chuyển từ List qua Dictionary
                Console.WriteLine("Danh sách sau khi chèn vào vị trí số {0}: -----------------------", n);
                foreach (KeyValuePair<string, Xe> item in danhsach)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
