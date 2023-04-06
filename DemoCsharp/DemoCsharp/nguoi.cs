using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    class nguoi
    {

        string hoten;
        int gioitinh;
        DateTime ngaysinh;
        string dienthoai;

        public nguoi(string hoten, DateTime ngaysinh, int gioitinh, string dienthoai)
        {
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.dienthoai = dienthoai;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }

        public nguoi() : base()
        {

        }

        ~nguoi()
        {

        }

        public int tinhtuoi()
        {

            int tuoi = DateTime.Now.Year - Ngaysinh.Year;

            return tuoi;

        }

        public virtual void nhap()
        {

            Console.WriteLine("nhap ten : ");
            Hoten = Console.ReadLine();

            Console.WriteLine("nhap gioi tinh : ");
            Gioitinh = int.Parse(Console.ReadLine());

            Console.WriteLine("nhap ngay sinh : ");
            Ngaysinh = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("nhap dien thoai : ");
            Dienthoai = Console.ReadLine();

        }

        public virtual void xuat()
        {


            Console.WriteLine("ten : " + Hoten);
            Console.WriteLine("gioi tinh : " + ((Gioitinh == 0) ? "nu" : "nam"));
            Console.WriteLine("Ngay sinh : " + Ngaysinh);
            Console.WriteLine("dien thoai : " + Dienthoai);

         
        }

       

    }
}
