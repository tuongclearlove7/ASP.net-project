using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{
    class benhnhan__bhxh : benh_nhan, Ivienphi
    {


        string mabh_xh;

        public benhnhan__bhxh(string ten, string mabn, DateTime ngaynamvien, bool phongtheoyeucau, string mabh_xh) : base(ten, mabn, ngaynamvien, phongtheoyeucau)
        {

            this.mabh_xh = mabh_xh;

        }

        public benhnhan__bhxh(string v)
        {
        }

        public string Mabh_xh { get => mabh_xh; set => mabh_xh = value; }
        public double dongiaPhong { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Nhap vao ma benh nhan bhxh : ");
            Mabh_xh = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma nhan vien bhxh la : " + Mabh_xh);
        }


        public override string ToString()
        {
            return base.ToString();
        }


        public double tinhHoaDonVienPhi()
        {
            dongiaPhong = 150;
            if (base.Phongtheoyeucau == true)
            {
                return (base.tinhSongayNhapVien() * dongiaPhong * 2);
            }
            return base.tinhSongayNhapVien() * dongiaPhong;
        }



        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}
