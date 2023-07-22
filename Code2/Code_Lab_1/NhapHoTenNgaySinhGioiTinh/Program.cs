using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NhapHoTenNgaySinhGioiTinh
{
    class Program
    {
        static void Main(string[] args)
        {             
                Console.OutputEncoding = Encoding.UTF8; //hiển thị Tiếng Việt
                //Console.OutputEncoding = Encoding.Unicode;
                //Console.InputEncoding = Encoding.Unicode;
                Console.WriteLine("Nhập họ tên"); 
                string hoTen = Console.ReadLine();               
                DateTime ngaySinh;
                Console.WriteLine("Nhập ngày sinh"); 
            do
            {
                try
                {
                    ngaySinh = DateTime.Parse(Console.ReadLine()); break;
                }
                catch(Exception)
                {
                    Console.WriteLine("Nhập sai định dạng, nhập lại");
                }
            }
            while(true);
            string gioiTinh;
            Console.WriteLine("Nhập giới tính NAM hoặc NU");
            bool namnu = true;
            do
            {       
                gioiTinh = Console.ReadLine();
                if (gioiTinh.ToUpper() == "NAM" || gioiTinh.ToUpper() == "NU")
                    namnu = true;
                else
                {
                    Console.WriteLine("Nhập lại nam (NAM) hoặc nu (NU)");
                    namnu = false;
                }
            }
            while (namnu == false);
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            Console.Write("Họ tên là: " + hoTen);
            if (ngaySinh.Day == DateTime.Today.Day && ngaySinh.Month == DateTime.Today.Month)  //Today hoac Now
                Console.WriteLine("\nChúc mừng sinh nhật lần thứ {0}", tuoi);
            if (gioiTinh == "nam")
                Console.WriteLine("\nNăm về hưu của nam là: {0}", ngaySinh.Year + 60);
                //Console.WriteLine("\nNăm về hưu của nam là: " + (ngaysinh.Year + 60));
            if(gioiTinh == "nu")
                Console.WriteLine("\nNăm về hưu của nữ là: {0}", ngaySinh.Year + 55);
            Console.WriteLine("\nKết thúc chương trình");
            Console.ReadLine();
           

                //string GioiTinh;          
                //Console.Write("Nhap ho ten: ");
                //string Hoten = Console.ReadLine();
               
                //DateTime Ngaysinh = DateTime.Today;
                //bool kiemtra = false; bool NamNu = false;
                //do
                //{
                //    Console.WriteLine("Nhap ngay sinh");
                //    try
                //    {
                //        Ngaysinh = DateTime.Parse(Console.ReadLine());
                //        kiemtra = true; 
                //    }
                //    catch (Exception)
                //    {
                //        Console.WriteLine("Nhap sai và nhập lại");
                //    }
                 

                //} while (kiemtra == false);

                //Console.WriteLine("Nhap Gioi tinh");
                //GioiTinh = Console.ReadLine(); 
                //do
                //{
                //   //try
                //   // {
                //   //    // Console.WriteLine("Nhap Gioi tinh");
                //   //    // GioiTinh = Console.ReadLine();   
                //    if (GioiTinh.ToUpper() == "NAM" || GioiTinh.ToUpper() == "NU")
                //        NamNu = true;
                //    else
                //    {
                //        Console.WriteLine("Nhap sai");
                //        Console.WriteLine("Nhap lại Gioi tinh");
                //        GioiTinh = Console.ReadLine();
                //    }
                //   // }
                //   // catch (Exception)
                //   // { 
                //   //    // Console.WriteLine("Nhap sai, nhập lại nhé"); 
                //   // }
                //} while (NamNu == false);

                //if (GioiTinh.ToUpper() == "NAM")                            //up len thanh chu Hoa het
                // Console.WriteLine("Năm về hươu la {0}", Ngaysinh.Year + 60);  // Mặc định là năm 2000 
                //else if (GioiTinh.ToUpper() == "NU")
                //    Console.WriteLine("Năm về hươu la {0}", Ngaysinh.Year + 55);
                //if (Ngaysinh.Day == DateTime.Today.Day && Ngaysinh.Month == DateTime.Today.Month)
                //    Console.WriteLine(" Chuc mung sinh nhat " + Hoten);
            //Console.WriteLine("\nKết thúc chương trình");
                //Console.ReadLine();         
        }
    }
}
