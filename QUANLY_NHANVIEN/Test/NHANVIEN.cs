using System;
using System.Text;

namespace QuanLyNhanVien
{
    public abstract class NHANVIEN
    {
        public string HoTen;
        public DateTime NamSinh;
        public int GioiTinh;
        public long SoCMND;
        public string MaNV;
        public NHANVIEN()
        {
        }

        public NHANVIEN(string HoTen, DateTime NamSinh, int GioiTinh, long SoCMND, string MaNV)
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.GioiTinh = GioiTinh;
            this.SoCMND = SoCMND;
            this.MaNV = MaNV;
        }

        //public string HoTen { get => hoTen; set => hoTen = value; }
        //public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        //public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        //public long SoCMND { get => soCMND; set => soCMND = value; }
        //public string MaNV { get => maNV; set => maNV = value; }

        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số CMND: "); this.SoCMND = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mã số nhan viên: "); this.MaNV = Console.ReadLine();
            Console.WriteLine("Nhập họ tên: "); this.HoTen = Console.ReadLine();
            while (true)
                try
                {
                    Console.WriteLine("Nhập giới tính |0| là 'Nữ' |1| là 'Nam': "); this.GioiTinh = int.Parse(Console.ReadLine());
                    if (this.GioiTinh == 1 || this.GioiTinh == 0) break;
                }
                catch (FormatException)
                { Console.WriteLine("Nhập sai định dạng, nhập lại "); }
            while (true)
                try
                {
                    Console.WriteLine("Nhập ngày sinh: "); this.NamSinh = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                { Console.WriteLine("Nhập sai định dạng, nhập lại "); }
        }
        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Số CMND: " + this.SoCMND);
            Console.WriteLine("Mã nhân viên : " + this.MaNV);
            Console.WriteLine("Họ tên: " + this.HoTen);
            if (this.GioiTinh == 1)
            {
                Console.WriteLine("Giới tính : Nam");
            }
            else if (this.GioiTinh == 0)
            {
                Console.WriteLine("Giới tính : Nữ");
            }
            Console.WriteLine("Ngày sinh: " + this.NamSinh);
        }
        public abstract float ThucLinh();
    }
}

