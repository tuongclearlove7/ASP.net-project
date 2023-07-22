using System;
namespace QuanLyNhanVien 
{
    public class NhanVienHopDong : NHANVIEN
    {
        public float MucLuong;
        //public NhanVienHopDong()
        //{
        //}

        //public NhanVienHopDong(float mucLuong,string hoTen, DateTime namSinh, int gioiTinh, long soCMND, string maNV) : base(hoTen, namSinh, gioiTinh, soCMND, maNV)
        //{
        //    this.MucLuong = mucLuong;

        //}

        //public float MucLuong { get => mucLuong; set => mucLuong = value; }

        public override void Nhap()
        {
            Console.WriteLine("-------------------------------------Nhập thông tin nhân viên hợp đồng-------------------------");
            base.Nhap();
            Console.WriteLine("Mời Nhập mức lương: "); this.MucLuong = float.Parse(Console.ReadLine());
        }

        public float PhuCap()
        {
            return this.MucLuong / 10;
        }

        public override float ThucLinh()
        {
            return this.MucLuong + this.PhuCap();
        }

        public override void Xuat()
        {
            Console.WriteLine("-------------------------------------Xuất thông tin nhân viên hợp đồng-------------------------");
            base.Xuat();
            Console.WriteLine("Mức lương: " + this.MucLuong);
            Console.WriteLine("Phụ cấp = " + this.PhuCap());
            Console.WriteLine("Thực Lĩnh = " + this.ThucLinh());
        }
    }
}
