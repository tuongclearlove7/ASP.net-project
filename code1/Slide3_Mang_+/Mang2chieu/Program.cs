using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] MangA = new int[3, 2] { { 5, 2 }, { 3, 9 }, { 2, 6 } }; //co the bo qua khai bao kich thuoc mang, cung~ co the bo qua toan tu new
            for (int i = 0; i < MangA.GetLength(0); i++)
            {
                for (int j = 0; j < MangA.GetLength(1); j++)
                {
                    Console.Write(MangA[i, j] + " ");
                    // Console.Write(" ");
                }
                Console.WriteLine();
            }
            // Tìm giá trị lớn nhất của mảng
            int Max = 0;
            for (int i = 0; i < MangA.GetLength(0); i++)
            {
                for (int j = 0; j < MangA.GetLength(1); j++)
                {
                    if (Max < MangA[i, j])
                        Max = MangA[i, j];
                }
            }
            Console.WriteLine("Giá trị lớn nhất là {0}", Max);

            // Tìm giá trị nhỏ nhất của mảng
            int Min = MangA[0, 0];
            for (int i = 0; i < MangA.GetLength(0); i++)
            {
                for (int j = 0; j < MangA.GetLength(1); j++)
                {
                    if (Min > MangA[i, j])
                        Min = MangA[i, j];
                }
            }
            Console.WriteLine("Giá trị nhỏ nhất của mảng là {0}", Min);

            // Tổng các phần tử trong mảng 2 chiều 
            int Tong2c = 0;
            for (int i = 0; i < MangA.GetLength(0); i++)
                for (int j = 0; j < MangA.GetLength(1); j++)
                {
                    Tong2c = Tong2c + MangA[i, j];
                }
            Console.WriteLine("Tổng các phân tử trong mảng là {0}", Tong2c);

            // Sắp xếp tăng theo từng hàng
            for (int i = 0; i < MangA.GetLength(0); i++)
                for (int j = 0; j < MangA.GetLength(1) - 1; j++)
                    for (int k = j + 1; k < MangA.GetLength(1); k++)
                        if (MangA[i, j] > MangA[i, k])
                        {
                            int Tam = MangA[i, j];
                            MangA[i, j] = MangA[i, k];
                            MangA[i, k] = Tam;
                        }
            Console.WriteLine("Mảng sau khi sắp xếp theo từng hàng");
            for (int i = 0; i < MangA.GetLength(0); i++)
            {
                for (int j = 0; j < MangA.GetLength(1); j++)
                {
                    Console.Write(MangA[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Sắp xếp theo thứ tự tăng dần từ trái qua phải và từ trên xuống dưới
            int d = MangA.GetLength(0);
            int c = MangA.GetLength(1);
            for (int i = 0; i < c * d - 1; i++)
                for (int j = i + 1; j < c * d; j++)
                {
                    if (MangA[i / c, i % c] > MangA[j / c, j % c])
                    {
                        int Tam = MangA[i / c, i % c];
                        MangA[i / c, i % c] = MangA[j / c, j % c];
                        MangA[j / c, j % c] = Tam;
                    }
                }
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần từ trái qua phải, trên xuống dưới");
            for (int i = 0; i < MangA.GetLength(0); i++)
            {
                for (int j = 0; j < MangA.GetLength(1); j++)
                {
                    Console.Write(MangA[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Sắp xếp theo thứ tự giảm dần từ trái qua phải, từ trên xuống dưới

            for (int i = 0; i < c * d - 1; i++)
                for (int j = i + 1; j < c * d; j++)
                {
                    if (MangA[i / c, i % c] < MangA[j / c, j % c])
                    {
                        int Tam = MangA[i / c, i % c];
                        MangA[i / c, i % c] = MangA[j / c, j % c];
                        MangA[j / c, j % c] = Tam;
                    }
                }
            Console.WriteLine("Mảng sau khi sắp xếp giảm dần từ trái qua phải, trên xuống dưới là");
            for (int i = 0; i < MangA.GetLength(0); i++)
            {
                for (int j = 0; j < MangA.GetLength(1); j++)
                {
                    Console.Write(MangA[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Tìm phần tử có trong mảng tại vị trí [h][c]
            int hang, cot;
            Console.WriteLine("Nhập vị trí hàng và cột cần tìm ");
            hang = int.Parse(Console.ReadLine());
            cot = int.Parse(Console.ReadLine());
            int tim = 0;
            for (int i = 0; i < MangA.GetLength(0); i++)
                for (int j = 0; j < MangA.GetLength(1); j++)
                {
                    if (i == hang && j == cot)
                    {
                        Console.WriteLine("Giá trị cần tìm là {0}", MangA[i, j]);
                        tim = 1;
                    }
                }
            if (tim == 0) Console.WriteLine("Giá trị cần tìm không có");

            // Tìm vị trí của giá trị đã có trong mảng
              int x;
              Console.WriteLine("Nhập giá trị cần tìm");
              x = int.Parse(Console.ReadLine());
              for (int i = 0; i < MangA.GetLength(0); i++)
                  for (int j = 0; j < MangA.GetLength(1); j++)
                      if (MangA[i, j] == x)
                          Console.WriteLine("Vị trí của phần tử {0} là [{1},{2}]", x, i, j);

            // Xuất các phần tử trên đường chéo chính
               Console.WriteLine("Mảng mới");
                 int[,] MangB = new int[3,3] {{4,5,1}, {8, 9 , 7}, {9,6,10}};
                 for (int i = 0; i < MangB.GetLength(0); i++)
                   {
                    for (int j = 0; j < MangB.GetLength(1); j++)
                      {
                        Console.Write(MangB[i, j] + " ");
                      }
                        Console.WriteLine();
                   }
                  Console.WriteLine("Các phần tử trên đường chéo chính của mảng là");
                for (int i = 0; i < MangB.GetLength(0); i++)
                   for (int j = i; j <= i; j++)
                      {
                         Console.Write(MangB[i, j] + " ");
                      }  

            Console.ReadLine();
        }
    }
}
