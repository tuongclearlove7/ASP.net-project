using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class Xe
    {
        string bienSo;
        public string BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }
        string tenXe;
        int trongTai;
        DateTime ngayDangKiem;
        int tieuChuanBang;
        public Xe(){ }
        public Xe(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang) {
            this.BienSo = bienSo;
            this.tenXe = tenXe;
            this.trongTai = trongTai;
            this.ngayDangKiem = ngayDangKiem;
            this.tieuChuanBang = tieuChuanBang;
        }
        public virtual void Nhap(){
            Console.WriteLine("Nhập biển số Xe: "); this.BienSo = Console.ReadLine();
            Console.WriteLine("Nhập Tên Xe: "); this.tenXe = Console.ReadLine();
            Console.WriteLine("Nhập Trọng tải: "); this.trongTai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Ngày Đăng Kiểm: "); this.ngayDangKiem = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập tiêu chuẩn bằng: "); this.TieuChuanBang = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Biển số xe là: {0}", this.BienSo);
            Console.WriteLine("Tên xe là: {0}", this.tenXe);
            //Console.WriteLine("Trọng tải xe là: {0}", this.TrongTai);
            Console.WriteLine("Ngày đăng kiểm là: {0}", this.ngayDangKiem);
            //Console.WriteLine("Tiêu chuẩn bằng là: {0}", this.TieuChuanBang);
        }
    }
}
