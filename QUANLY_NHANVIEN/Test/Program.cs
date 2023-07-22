using System;

namespace QuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DateTime date1 = new DateTime(2010, 8, 18);
            DanhSachNhanVien nv = new DanhSachNhanVien();
            NHANVIEN nvbc1 = new NhanVienBienChe("Nguyen Thi A", date1, 1, 233343, "1",1, 10000);
            NHANVIEN nvbc2 = new NhanVienBienChe("Tran Van B", date1, 0, 233345, "2", 2, 1000);
            NHANVIEN nvbc3 = new NhanVienBienChe("Nguyen Van C", date1, 0, 543343, "3", 3, 10200);
            NHANVIEN nvbc4 = new NhanVienBienChe("Tran Van D", date1, 1, 223343, "4",4, 10500);
            nv.List.Add("1", nvbc1);
            nv.List.Add("2", nvbc2);
            nv.List.Add("3", nvbc3);
            nv.List.Add("4", nvbc4);
            string option;
            while (true)
            {
                Console.WriteLine("Nhâp '1' để xem danh sách");
                Console.WriteLine("Nhâp '2' để thêm vào danh sách");
                Console.WriteLine("Nhâp '3' để Tìm theo mã nhân viên");
                Console.WriteLine("Nhâp '4' để Xóa theo mã nhân viên");
                Console.WriteLine("Nhâp '5' để Sửa theo mã nhân viên");
                Console.WriteLine("Nhâp '0' để Thoát");
                option = Console.ReadLine();
                if (option == "1")
                {
                    nv.Xuat();

                }
                else if (option == "2")
                {
                    nv.Nhap();

                }
                else if (option == "3")
                {
                    nv.Tim();

                }
                else if (option == "4")
                {
                    nv.Xoa();

                }
                else if (option == "5")
                {
                    nv.Sua();

                }
                else if (option == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập sai định dạng,mời nhập lại");
                }
                Console.ReadKey();
            }
        }
    }
}
