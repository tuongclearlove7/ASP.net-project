using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GiaiPhuongTrinhB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ////////////////////////////////////// Phuong trình bậc 2 ax^2 + bx + c=0
            double a = 0, b = 0, c = 0, x1, x2;//khai báo 3 biến hệ số và 2 biến kết quả
            /////////////////////////////////////////////////////////// Cách 1 dùng  TRY----PARSE
            while (true)
            {
                Console.WriteLine("Nhập 3 hệ số a,b,c");
                string soA = Console.ReadLine(); string soB = Console.ReadLine(); string soC = Console.ReadLine();
                if (double.TryParse(soA, out a) == true)    // tương đương: if (double.TryParse(soA, out  a) == true)
                {
                    if (double.TryParse(soB, out b))
                    {
                        if (double.TryParse(soC, out c))
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("Nhập sai, vui lòng nhập lại bằng số");
            }
         Console.WriteLine("số vừa nhập là a = {0},b = {1}, c = {2}", a, b, c);

            ////////////////////////TRY----CATCH  dùng do_while
          /*  bool kiemtra = true;
            ///////////////////////////////    KIỂM TRA dữ liệu                            
            do
            {
                try
                {
                    Console.Write("Nhap a: ");//nhap a
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nNhap b: ");//nhap b
                    b = double.Parse(Console.ReadLine());
                    Console.Write("\nNhap c: ");//nhap c
                    c = Convert.ToInt32(Console.ReadLine());
                    //kiemtra = true;
                }
                catch (Exception) { Console.WriteLine("bạn phải nhập số"); kiemtra = false; };
            }
            while (kiemtra == false);*/

            ///////////////////////  GOTTO

            /* NhapLai:
             try
             {
                 Console.Write("Nhap a=");
                 a = double.Parse(Console.ReadLine());
                 Console.Write("Nhap b=");
                 b = double.Parse(Console.ReadLine());
                 Console.Write("Nhap c=");
                 c = double.Parse(Console.ReadLine());
             }
             catch
             {
                 goto NhapLai;
             }
             */

            ////////////////////////TRY----CATCH  dùng While
            /* while (true)
             {
                 try
                 {
                     Console.Write("Nhap a: ");//nhap a
                     a = Convert.ToInt32(Console.ReadLine());
                     Console.Write("\nNhap b: ");//nhap b
                     b = double.Parse(Console.ReadLine());
                     Console.Write("\nNhap c: ");//nhap c
                     c = Convert.ToInt32(Console.ReadLine());
                     break;
                 }
                 catch (Exception) { Console.WriteLine("bạn phải nhập số");
             }
             }*/

                //////////////////  CÁCH 3
             /*int ok; string t="";
              do
              {
              ok = 1;
              Console.WriteLine("nhap so a:"); t= Console.ReadLine();
              if(!double.TryParse(t, out a)) {Console.WriteLine(" so a khong phai la so!"); ok=0; continue;}
              Console.WriteLine("nhap so b:"); t= Console.ReadLine();
              if(!double.TryParse(t, out b)) {Console.WriteLine(" so b khong phai la so!"); ok=0; continue;}
              Console.WriteLine("nhap so c:"); t= Console.ReadLine();
              if(!double.TryParse(t, out c)) {Console.WriteLine(" so c khong phai la so!"); ok=0; continue;}
              } while(ok==0);
              Console.WriteLine("\n XONG");*/
               

            //Phuong trình bậc 2 ax^2 + bx+c=0    // nếu a và c trái dấu thì luôn có 2 nghiệm phân biệt
            double delta = Math.Pow(b, 2) - 4 * a * c;//khai báo biến delta 
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine(" Phương trình vô ngiệm");
                }
                else
                    Console.WriteLine(" Có 1 nghiệm x = {0}", -c / b);

            }
            else if (delta == 0)//nếu delta = 0 thì phuong trình có nghiệm kép
            {
                Console.Write("\nPhuong trinh co nghiem kep.\n");
                x1 = -b / (2.0 * a);
                Console.Write("\nNghiem duy nhat cua phuong trinh la x1 = x2 = {0} \n", x1);
            }
            else if (delta > 0)//nếu delta > 0 thì phuong trình có 2 nghiệm phân biệt
            {
                Console.Write("\n Phương trình có 2 nghiệm phân biệt \n");
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.Write("\nNghiem thu nhat: x1 = {0}\n", x1);
                Console.Write("\nNghiem thu nhat: x2 = {0}\n", x2);
            }
            else //ngược lại nếu delta < 0 thì phuong trình vô nghiệm
                Console.Write("Phương trình vô nghiệm \n");
            Console.WriteLine("\n ----------------------Kết thúc chương trình-----------------");
            Console.ReadLine();
            /*
            using System;
					
           public class Program
           {
           public static void Main()
           {
           Console.WriteLine("Hello World");
           float a, b,c;
           */
        }
    }
}
