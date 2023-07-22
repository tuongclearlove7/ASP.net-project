using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide3_Mang__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] MangA = new int[7] { 10, 8, 6, 2, 5, 7, 4 };
            //int[] MangA = new int[10];
            //int n; Console.WriteLine("Nhap so phan tu n cua mang"); 
            //n = int.Parse(Console.ReadLine());
            //for(int i=0; i<n;i++)
            //{
            //   Console.WriteLine("Nhap phan tu thu {0} cua mang A",i+1);
            //   MangA[i] = int.Parse(Console.ReadLine());
            //}

            Console.WriteLine(" in mang");
            //for (int i = 0; i < n; i++)
            for (int i = 0; i < MangA.Length; i++)
            {
                Console.Write(MangA[i] + " ");
                //  Console.Write(" ");
            }
            Console.WriteLine();
            //Console.WriteLine("\nSo phan tu cua MangA la: {0} ", n);

            // Chen phan tu vao mang
            Console.WriteLine("Nhap phan tu B can chen"); int b;
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri X can chen"); int x;
            x = int.Parse(Console.ReadLine());
            // chen phan tu vao mang Cach 1
            int[] MangB = new int[MangA.Length + 1];
            for (int i = 0; i < MangA.Length; i++)
            //for (int i = 0; i < n; i++)
            {
                if (i < x)
                    MangB[i] = MangA[i];
                else MangB[i + 1] = MangA[i];
            }
            MangB[x] = b;
            MangA = MangB;
            //for (int i = 0; i <= n; i++)
            for (int i = 0; i < MangA.Length; i++)
            {
                Console.Write(MangA[i] + " ");
            }

            //chen phan tu vao mang Cach 2
            //if (x > n) { Console.WriteLine("vị trí vượt quá giới hạn của mảng"); }
            //else
            //{
            //    for (int i = n; i > x; i--)
            //    {

            //        MangA[i] = MangA[i - 1];
            //    }
            //    MangA[x] = b;
            //    n++;
            //}
            //Console.WriteLine(" in mang");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(MangA[i] + " ");
            //}

            Console.WriteLine("\nSố phần tử của mảng A sau khi chèn là {0}", MangA.Length);
            int m = MangA.Length;// +1;
            // int m = n + 1;              
            // Xoa phan tử tại vị trí y
            Console.WriteLine("\nNhập vị trí y cần xóa"); int y; y = int.Parse(Console.ReadLine());
            if (y >= m) Console.WriteLine("vị trí vượt quá giới hạn của mảng");
            else
            {
                for (int i = y; i < m - 1; i++)
                    MangA[i] = MangA[i + 1];
                m--;
            }
            Console.WriteLine("\nSố phần tử của mảng A sau khi xóa là {0}", m);
            for (int i = 0; i < m; i++)
            {
                Console.Write(MangA[i] + " ");
            }
            // Tìm số cần tìm 
            Console.WriteLine("\n Nhập so can tim "); int r = int.Parse(Console.ReadLine());
            int pos = 0;
            for (int i = 0; i < MangA.Length; i++)
            //for (int i = 0; i < n; i++ )
            {
                if (MangA[i] == r) { Console.WriteLine("Số cần tìm ở vị trí {0}", i); pos = 1; }
            }
            if (pos == 0) Console.WriteLine("ko có số cần tìm");

            //Ham Foreach 
            /* foreach(int thanhphan in MangA)
            {
                Console.Write(thanhphan);
                Console.Write(" ");
            }*/

            /* foreach(object thanhphan in MangA)
             {
                 Console.Write(thanhphan);
                 Console.Write(" ");
             }*/
            // Xắp sếp theo thứ tự tăng dần
            for (int i = 0; i < MangA.Length; i++)
            //for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < MangA.Length; j++)
                // for (int j = i + 1; j < n; j++)
                {
                    if (MangA[i] > MangA[j])
                    {
                        int Tam = MangA[i];
                        MangA[i] = MangA[j];
                        MangA[j] = Tam;
                    }
                }
            }
            Console.WriteLine("\nMang sau khi sắp xếp tăng dần");
            //for (int i = 0; i < n; i++)
            for (int i = 0; i < MangA.Length; i++)
                Console.Write(MangA[i] + " ");
            Console.WriteLine();

            Console.WriteLine("\nMang sau khi sắp xếp giảm dần");
            //for (int i = 0; i < n; i++)
            for (int i = MangA.Length - 1; i >= 0; i--)
                Console.Write(MangA[i] + " ");
            Console.ReadLine();
        }
    }
}
