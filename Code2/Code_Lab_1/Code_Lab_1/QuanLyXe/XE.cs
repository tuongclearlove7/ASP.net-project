using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace QuanLyXe
{
    class XE 
    {
        string bienSo;

        public string BienSo
        {
            get { return bienSo; }
            set { bienSo = value; }
        }

        string tenXe;

        public string TenXe
        {
            get { return tenXe; }
            set { tenXe = value; }
        }

        DateTime ngayDangKiem;

        public DateTime NgayDangKiem
        {
            get { return ngayDangKiem; }
            set { ngayDangKiem = value; }
        }

        public void Nhap()
        {
            Console.Write("Nhap vao bien so xe: ");
            BienSo = Console.ReadLine();
            Console.Write("Nhap vao ten xe: ");
            TenXe = Console.ReadLine();
            Console.Write("Nhap vao ngay dang kiem xe: ");
            NgayDangKiem = DateTime.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine("_____________________________ Thông tin xe có biển số {0}________________________", BienSo);
            Console.WriteLine("Bien so xe la: " + BienSo);
            Console.WriteLine("Ten cua xe la: " + TenXe);
            //Console.WriteLine("Ngay dang kiem xe la: " + ngaydangkiem);    // nhập ngày 1/1/1 thì định dạng sẽ là 01/01/2001 12:00:00 AM
            Console.WriteLine("Ngay dang kiem xe la: {0}", NgayDangKiem.ToString("dd/MM/yyyy"));    // ko có 12:00:00 AM
            //Console.WriteLine("Ngày đăng kiểm xe là: {0: dd/MM/yyyy}", Ngaydangkiem);
            //Console.WriteLine(String.Format("Ngày đăng kiểm xe là: {0: dd/MM/yyyy}", Ngaydangkiem));
        }
        
    }
}
