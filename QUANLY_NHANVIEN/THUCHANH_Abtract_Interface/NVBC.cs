using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH_Abtract_Interface
{
    class NVBC:NHANVIEN,IPhuCap
    {
        float hesoluong;

        public float Hesoluong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }
        float luongcoban;

        public float Luongcoban
        {
            get { return luongcoban; }
            set { luongcoban = value; }
        }
        public override void Nhap()
        {
            Console.WriteLine("--------------------------Nhập thông tin nhân viên BC-----------------------");
            base.Nhap();
            Console.Write("Nhập hệ số lương: "); Hesoluong = float.Parse(Console.ReadLine());
            Console.Write("Nhập lương cơ bản: "); Luongcoban = float.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("*******-----------Xuất thông tin nhân viên Biên Chế******************--------------------------------");
            base.Xuat();
            Console.WriteLine("hệ số lương là: {0}", Hesoluong );
            Console.WriteLine("lương cơ bản là: {0}", Luongcoban);
        }
        public double PhuCap()   // thừa kế interface
        {
            return Luongcoban / 10;
        }
        public override double ThucLinh()   // thừa kế từ abstrast
        {
            return Hesoluong * Luongcoban + PhuCap();
        }
    }
}
