using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class XeChoHang : Xe
    {
        double soTan;

        public double SoTan
        {
            get { return soTan; }
            set { soTan = value; }
        }
        public XeChoHang() : base()
        { }
        public XeChoHang(string BienSo, string TenXe, int TrongTai, DateTime NgayDangKiem, int TieuChuanBang, double SoTan)
            : base(BienSo, TenXe, TrongTai, NgayDangKiem, TieuChuanBang)
        {
            this.SoTan = SoTan;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhập thông tin xe Chở Hàng");
            base.Nhap();
            Console.WriteLine("Nhập số tấn");
            this.soTan = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("----------------------*** Thông tin Xe Chở Hàng ***---------------------");
            base.Xuat();
            Console.WriteLine("Số Tấn là: {0}", this.SoTan);
        }
    }
}
