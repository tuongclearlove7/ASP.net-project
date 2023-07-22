using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVienDienTu : SinhVien
    {
        float diemEE200, diemEE201, diemEE205;
        float diemTB;
        public SinhVienDienTu()
            : base()
        { }
        public SinhVienDienTu(String Mssv, String Hoten, String Diachi, DateTime Ngaysinh,
               float DiemEE200, float DiemEE201, float DiemEE205, float DiemTB)
            : base(Mssv, Hoten, Diachi, Ngaysinh)
        {
            this.diemEE200 = DiemEE200;
            this.diemEE201 = DiemEE201;
            this.diemEE205 = DiemEE205;
            this.diemTB = DiemTB;
        }
        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*************** Nhập thông tin sinh viên Điện Tử ***************");
            base.Nhap(); // Gọi lại phương thức nhập của lớp Sinh Viên (lớp cha)
            Console.Write("Nhập Diem EE200: "); this.diemEE200 = float.Parse(Console.ReadLine());
            Console.Write("Nhập Diem EE201: "); this.diemEE201 = float.Parse(Console.ReadLine());
            Console.Write("Nhập Diem EE205: "); this.diemEE205 = float.Parse(Console.ReadLine());
            diemTB = (diemEE200 + diemEE201 + diemEE205) / 3;
        }
        public String TinhXepLoaiDT()
        {
            if (diemTB >= 8)
                return "Giỏi";
            else if (diemTB >= 6.5)
                return "Khá";
            else if (diemTB >= 5)
                return "Trung Bình";
            else
                return "yếu";
        }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-------------------------------------Xuất thông tin sinh viên Điện tử-------------------------");
            base.Xuat();
            Console.WriteLine("Điểm EE200 sinh viên là: {0}", this.diemEE200);
            Console.WriteLine("Điểm EE201 sinh viên là: {0}", this.diemEE201);
            Console.WriteLine("Điểm EE205 sinh viên là: {0}", this.diemEE205);
            Console.WriteLine("Điểm trung bình của sinh viên là: {0}", this.diemTB);
            Console.WriteLine("Xếp loại: {0}", this.TinhXepLoaiDT());
        }
    }
}
