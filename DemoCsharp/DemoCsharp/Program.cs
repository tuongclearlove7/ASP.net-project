using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp
{
    class Program
    {


        static int tinhtong(int n)
        {
            int s = 0;

            for (int i = 1; i < n; i++)
            {
                s = s + i;

            }

            return s;
        }

        static int tinhtong_binhphuong(int n)
        {

            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        static int dequy_giaithua(int n)
        {

            if( n == 0)
            {
                return 1;
            }

            else
            {
                return n * dequy_giaithua(n - 1);
            }
        

        }

        static int tam_giac(int n)
        {
            for (int i = 1; i <= n; i++)
            {
             
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
               
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
               
                Console.Write("\n");
            }


            return 0;
        }


        static int tam_giac_rong(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = n - i; j > 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i || i == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            return 0;
        }

        

        static void Main(string[] args)
        {


            int n = 10;
            Console.WriteLine(dequy_giaithua(n));
            Console.WriteLine(tinhtong(n));
            Console.WriteLine(tinhtong_binhphuong(n));
            tam_giac(5);
            tam_giac_rong(5);


            DateTime ngaysinh1 = DateTime.ParseExact("16/01/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngaysinh2 = DateTime.ParseExact("09/09/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            nguoi ng = new nguoi("tuong", ngaysinh1, 1, "3423434");
            giangvien gv = new giangvien("thao", ngaysinh2, 0, "5646464", 112);
            sinhvien sv = new sinhvien("tuong", ngaysinh1, 1, "342424", 113);

            sv.nhap();
            gv.nhap();
            gv.xuat();  
            sv.xuat();


            Console.ReadLine();


        }
    }
}
