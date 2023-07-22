using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVien
    {
        private string mSSV;
        public string MSSV
        {
            get { return mSSV; }
            set { mSSV = value; }
        }      
        string hoTen;
        string diaChi;
        DateTime ngaySinh;

        public SinhVien()
        { }
        public SinhVien(String mSSV, String hoTen, String diaChi, DateTime ngaySinh)
        {
            this.MSSV = mSSV;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
        }
        public virtual void Nhap()    // Cho phép lớp con ghi đè
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập mã số sinh viên: "); this.MSSV = Console.ReadLine();
            Console.Write("Nhập họ tên: "); this.hoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: "); this.diaChi = Console.ReadLine();
            while (true)
                try
                {
                    Console.Write("Nhập ngày sinh: ");
                    this.ngaySinh = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                { Console.WriteLine("Nhập sai định dạng, nhập lại "); }
        }
        public virtual void Xuat()                       // Cho phép lớp con ghi đè
        {
            Console.WriteLine("Mã số sinh viên là: {0}", this.MSSV);
            Console.WriteLine("Họ tên sinh viên là: {0}", this.hoTen);
            Console.WriteLine("Địa chỉ sinh viên là: {0}", this.diaChi);
            //Console.WriteLine("Ngày sinh của sinh viên là: {0}", this.NgaySinh);
            //Console.WriteLine("Ngay sinh của SV là: {0}", this.NgaySinh.ToString("dd/MM/yyyy"));    // ko có 12:00:00 AM
            Console.WriteLine("Ngày sinh của SV là: {0: dd/MM/yyyy}", this.ngaySinh);
            //Console.WriteLine(string.Format("Ngày sinh của sinh viên là: {0: dd/MM/yyyy}",this.NgaySinh));
        }
    }
}
