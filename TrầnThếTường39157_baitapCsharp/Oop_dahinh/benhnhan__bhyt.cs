using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{
    class benhnhan__bhyt : benh_nhan, Ivienphi
    {


        string mabh_yt;

        public benhnhan__bhyt(string ten, string mabn, DateTime ngaynamvien, bool phongtheoyeucau, string mabh_yt) : base(ten, mabn, ngaynamvien, phongtheoyeucau)
        {

            this.mabh_yt = mabh_yt;

        }

        public benhnhan__bhyt()
        {
        }

        public string Mabh_yt { get => mabh_yt; set => mabh_yt = value; }
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

            Console.Write("Nhap vao ma benh nhan bhyt : ");
            Mabh_yt = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma nhan vien bhyt la : " + Mabh_yt);
        }


        public override string ToString()
        {
            return base.ToString();
        }


        public double tinhHoaDonVienPhi()
        {
            dongiaPhong = 150;
            if (base.Phongtheoyeucau)
            {
                return (base.tinhSongayNhapVien() * dongiaPhong) * 0.07;
            }
            return (base.tinhSongayNhapVien() * dongiaPhong) - 0.07;
        }

       

        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}
