using System;
namespace QuanLyNhanVien
{
    public class NhanVienBienChe : NHANVIEN
    {
        public int HeSoLuong;
        public float LuongCoBan;
        public NhanVienBienChe()
        {
        }

        //public int HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        //public float LuongCoBan { get => luongCoBan; set => luongCoBan = value; }


        public NhanVienBienChe(string HoTen, DateTime NamSinh, int GioiTinh, long SoCMND, string MaNV, int HeSoLuong, float LuongCoBan)
            : base(HoTen, NamSinh, GioiTinh, SoCMND, MaNV)
        {
            this.HeSoLuong = HeSoLuong;
            this.LuongCoBan = LuongCoBan;
        }

        public override void Nhap()
        {
            Console.WriteLine("-------------------------------------Nhập thông tin nhân viên biên chế-------------------------");
            base.Nhap();
            Console.WriteLine("Mời nhập hệ số lương: "); this.HeSoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lương cơ bản: "); this.LuongCoBan = float.Parse(Console.ReadLine());
        }

        public float PhuCap()
        {
            return this.LuongCoBan / 10;
        }

        public override float ThucLinh()
        {
            return this.HeSoLuong * this.LuongCoBan + this.PhuCap();
        }


        public override void Xuat()
        {
            Console.WriteLine("-------------------------------------Xuất thông tin nhân viên biên chế-------------------------");
            base.Xuat();
            Console.WriteLine("Hệ số lương: " + this.HeSoLuong);
            Console.WriteLine("Lương cơ bản: " + this.LuongCoBan);
            Console.WriteLine("Phụ cấp = " + this.PhuCap());
            Console.WriteLine("Thực Lĩnh = " + this.ThucLinh());
        }

       }
}
