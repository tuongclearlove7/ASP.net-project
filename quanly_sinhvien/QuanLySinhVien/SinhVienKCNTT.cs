using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVienKCNTT : SinhVien
    {
        float diemCS414;
        float diemIS311;
        float diemCS311;     
        float diemTB;

        public SinhVienKCNTT() : base()
        { }
        public SinhVienKCNTT(String mSSV, String hoTen, String diaChi, DateTime ngaySinh,
            float diemCS414, float diemIS311, float diemCS311, float diemTB)
            : base(mSSV, hoTen, diaChi, ngaySinh)
        {
            this.diemCS414 = diemCS414;
            this.diemIS311 = diemIS311;
            this.diemCS311 = diemCS311;
            this.diemTB = diemTB;
        }
        public override void Nhap()
           {
               Console.OutputEncoding = Encoding.UTF8;
               Console.WriteLine("**************** Nhập thông tin sinh viên CNTT ******************");
               base.Nhap(); // Gọi lại phương thức nhập của lớp Sinh Viên (lớp cha)
               Console.Write("Nhập điểm CS414: "); this.diemCS414 = float.Parse(Console.ReadLine());
               Console.Write("Nhập điểm IS311: "); this.diemIS311 = float.Parse(Console.ReadLine());
               Console.Write("Nhập điểm CS311: "); this.diemCS311 = float.Parse(Console.ReadLine());
            this.diemTB = (this.diemCS414 + this.diemIS311 + this.diemCS311) / 3;
           }
        public String TinhXepLoaiCNTT()
        {
            if (diemTB >= 8)
                return "Giỏi";
            else if (diemTB >= 6.5)
                return "Khá";
            else if (diemTB >= 5)
                return "Trung Bình";
            else
                return "Yếu";
        }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-----------------------Xuất thông tin sinh viên CNTT-------------");
            base.Xuat(); // Gọi lại phương thức xuất của lớp Sinh Viên (lớp cha)
            Console.WriteLine("Điểm CS414 sinh viên là: {0}", this.diemCS414);
            Console.WriteLine("Điểm IS311 sinh viên là: {0}", this.diemIS311);
            Console.WriteLine("Điểm CS311 sinh viên là: {0}", this.diemCS311);
            Console.WriteLine("Điểm trung bình của sinh viên là: {0}", this.diemTB);
            Console.WriteLine("Xếp loại: {0}", this.TinhXepLoaiCNTT());
        }
    }
}
