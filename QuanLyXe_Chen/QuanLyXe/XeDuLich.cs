using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class XeDuLich : Xe
    {
        int soChoNgoi;

        public int SoChoNgoi
        {
            get { return soChoNgoi; }
            set { soChoNgoi = value; }
        }
        public XeDuLich() : base()
        { }
        public XeDuLich(string BienSo, string TenXe, int TrongTai, DateTime NgayDangKiem, int TieuChuanBang, int SoChoNgoi)
            : base(BienSo, TenXe, TrongTai, NgayDangKiem, TieuChuanBang)
        {
            this.SoChoNgoi = SoChoNgoi;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhập thông tin xe Du Lịch");
            base.Nhap();
            Console.WriteLine("Nhập số chỗ ngồi");
            this.SoChoNgoi = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("Thông tin Xe Du Lịch");
            base.Xuat();
            Console.WriteLine("Số chỗ ngồi là: {0}", this.SoChoNgoi);
        }
    }
}
