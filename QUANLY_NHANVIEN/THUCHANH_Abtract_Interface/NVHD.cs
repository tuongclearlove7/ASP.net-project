using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH_Abtract_Interface
{
    class NVHD:NHANVIEN,IPhuCap
    {
        double mucluong;

        public double Mucluong
        {
            get { return mucluong; }
            set { mucluong = value; }
        }
        public override void Nhap()
        {
            Console.WriteLine("--------------------------Nhập thông tin nhân viên Hợp Đồng -----------------------");
            base.Nhap();
            Console.Write("Nhập mức lương: "); Mucluong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("*********************----Xuất thông tin nhân viên Hợp Đồng-------*************************");
            base.Xuat();
            Console.WriteLine("Mức lương là: {0}", Mucluong);  
        }
        public double PhuCap()  // thừa kế interface
        {
            return Mucluong / 10;
        }
        public override double ThucLinh() // thừa kế từ abstrast
        {
            return Mucluong + PhuCap();
        }
    }
}
