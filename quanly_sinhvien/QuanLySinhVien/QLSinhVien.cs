using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class QLSinhVien
    {
        Dictionary<string, SinhVien> dsSinhVien; // = new Dictionary<string, SinhVien>();

        internal Dictionary<string, SinhVien> DsSinhVien
        {
            get { return dsSinhVien; }
            set { dsSinhVien = value; }
        }
        public QLSinhVien()
        {
            dsSinhVien = new Dictionary<string, SinhVien>();
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát, C cho sinh viên CNTT" +
                    " D cho sinh viên Điện Tử");
                string option = Console.ReadLine().ToUpper();
                if (option == "0") break;
                else if (option == "C")
                {                    
                    SinhVien CNTT = new SinhVienKCNTT();      // đa hình / upcasting                                                                        
                    try
                    {                                                                          //CNTT.LopCha();     // test upcasting và kế thừa
                        CNTT.Nhap(); 
                        DsSinhVien.Add(CNTT.MSSV, CNTT); 
                    }
                    catch { Console.WriteLine("-------------có thể bị trùng mã, nhập lại---------------------"); }                   
                }
                else if(option == "D" || option == "d")
                {
                    SinhVien DT = new SinhVienDienTu();        
                    try
                    {                                                                        //  DT.LopCha();     // test upcasting và kế thừa
                        DT.Nhap(); DsSinhVien.Add(DT.MSSV, DT); }
                    catch { Console.WriteLine("-------------có thể bị trùng mã, nhập lại---------------------"); }  
                }
            }
        }
        public void Xuat()
        {
            foreach (SinhVien item in DsSinhVien.Values)
                item.Xuat();

            Dem();
        }
        public void Dem()
        {
            int GioiCNTT = 0, KhaCNTT = 0, TBCNTT = 0, YeuCNTT = 0;
            int GioiDT = 0, KhaDT = 0, TBDT = 0, YeuDT = 0;
            foreach (SinhVien item in DsSinhVien.Values)
            {                                               // Vì item đang là đối tượng thuộc lớp cha (SinhVien) cho nên chúng ta phải dowcating
                if(item is SinhVienKCNTT)                  // ép từ kiểu cha xuống kiểu con thì mới gọi được phương thức của lớp con
                {
                   
                    if (((SinhVienKCNTT)item).TinhXepLoaiCNTT() == "Giỏi") // đa hình / downcasting 
                    {
                        GioiCNTT = GioiCNTT + 1;
                    }
                    else if (((SinhVienKCNTT)item).TinhXepLoaiCNTT() == "Khá")
                    {
                        KhaCNTT += 1;
                    }
                    else if (((SinhVienKCNTT)item).TinhXepLoaiCNTT() == "Trung Bình")
                    {
                        TBCNTT += 1;
                    }
                    else
                    {
                        YeuCNTT = YeuCNTT + 1;
                    }  
                    //foreach (SinhVienKCNTT SV in DsSinhVien.Values) //Ke Thua
                    // if(SV.TinhXepLoaiCNTT() == "Giỏi") 
                    // //if (((SinhVienKCNTT)item).TinhXepLoaiCNTT() == "Giỏi") // đa hình / downcasting 
                    //{
                    //    GioiCNTT = GioiCNTT + 1;
                    //}
                    // else if (SV.TinhXepLoaiCNTT() == "Khá")
                    //{
                    //    KhaCNTT += 1;
                    //}
                    // else if (SV.TinhXepLoaiCNTT() == "Trung Bình")
                    //{
                    //    TBCNTT += 1;
                    //}
                    //else
                    //{
                    //    YeuCNTT = YeuCNTT + 1;
                    //}

                }

                if (item is SinhVienDienTu)
                {
                    if (((SinhVienDienTu)item).TinhXepLoaiDT() == "Giỏi")
                    {
                        GioiDT = GioiDT + 1;
                    }
                    else if (((SinhVienDienTu)item).TinhXepLoaiDT() == "Khá")
                    {
                        KhaDT += 1;
                    }
                    else if (((SinhVienDienTu)item).TinhXepLoaiDT() == "Trung Bình")
                    {
                        TBDT = TBDT + 1;
                    }
                    else
                    {
                        YeuDT = YeuDT + 1;
                    }
                }
                   
            }
            Console.WriteLine(" ------------------------------- Xếp loại SV khoa CNTT----------------");
            Console.WriteLine("Số sinh viên Giỏi CNTT là: {0}", GioiCNTT);
            Console.WriteLine("Số sinh viên Khá CNTT là: {0}", KhaCNTT);
            Console.WriteLine("Số sinh viên Trung Bình CNTT là: {0}", TBCNTT);
            Console.WriteLine("Số sinh viên Yếu CNTT là: {0}", YeuCNTT);
            Console.WriteLine(" ------------------------------- Xếp loại SV khoa Điện----------------");
            Console.WriteLine("Số sinh viên Giỏi ĐT là: {0}", GioiDT);
            Console.WriteLine("Số sinh viên Khá ĐT là: {0}", KhaDT);
            Console.WriteLine("Số sinh viên Trung Bình ĐT là: {0}", TBDT);
            Console.WriteLine("Số sinh viên Yếu ĐT là: {0}", YeuDT);

        }
    }
}
