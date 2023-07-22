using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mang_SoNguyen
{

    public class Program
    {
       /* static int nhapso()
        {
            Console.WriteLine("Bạn hãy nhập vào 1 số");
            int x;
            while (true)
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("----------  Bạn phải nhập số  ------------");
                }
            }
            return x;
        }*/
        static bool SoNguyenTo(float x)
        {
            int dem = 0;
            for (int i = 1; i <= x; i++)
                if (x % i == 0)
                    dem++;
            // if(dem == 2) return true;
            // else return false;
            return dem == 2;  // tương đương if và else ở trên
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;        
            Console.WriteLine("Các số nguyên tố từ 1 đến {0} là: ", 100);
            for (float i = 1; i <= 100; i++)
                if (SoNguyenTo(i) == true)
                    Console.WriteLine(i + " ");

            int x = 11;
            int y = 20;
            Console.WriteLine("So nho hon la so: {0}", Math.Min(x, y));
                //int n;
                //do
                //{
                //    Console.Write("nhập số phần tử cho mảng 0 <= n <=100 \n n = ");
                //    n = int.Parse(Console.ReadLine());
                //    if (n >= 0 && n <= 100)
                //        break;
                //    else
                //        Console.WriteLine("Bạn phải nhập số trong phạm vi từ 0 -> 100");
                //}
                //while (true);

                //int[] A = new int[n];
                //for (int i = 0; i < n; i++)
                //{
                //    Console.WriteLine("Nhập phần tử thứ A[{0}]: ", i);
                //                                        //A[i] = nhapso();   // Gọi phương thức nhapso
                //    while (true)
                //    {
                //        try
                //        {
                //            A[i] = int.Parse(Console.ReadLine());
                //            break;
                //        }
                //        catch
                //        {
                //            Console.WriteLine("------------Bạn phải nhập số-----------------");
                //        }
                //    }
                //}
                //Console.WriteLine("--------Mảng sau khi nhập------------------");
                ////                                                      //int[] A = new int[] {3, 7, 9, 1}
                //foreach (int bien in A)                              //foreach(kiểu phần tử, tên biến, từ khóa, mảng/danh sách )
                //    Console.Write(bien + "  ");                       //  foreach(int, tenbien, in, A)
                ////                                                          // Console.Write(tenbien + " ")
                //Console.WriteLine("\n Các phần tử lẻ trong mảng là");
                //int dem = 0;
                //for (int i = 0; i < n; i++)
                //    if (A[i] % 2 != 0)
                //    {
                //        Console.Write(A[i] + "  ");
                //        dem++;
                //    }
                //Console.WriteLine("\nSố lượng phần tử lẻ là: {0}", dem); 


                Console.WriteLine("\n---------Xuất mảng cho trước để tìm số nguyên tố------");
            int[] A = new int[] {2, 3, 14, 5, 10, 21, 12, 13, 1, 15, 46, 48, 55, 91, 37 };
            foreach (int item in A)
                Console.Write(item + "\t");
            Console.WriteLine("\nSố 0 và 1 theo quy ước không phải là số nguyên tố");
            Console.WriteLine("Các số nguyên tố có trong mảng là: ");
            bool kiemTra = true;
            int demNT = 0; 
            for (int i = 0; i < A.Length; i++){
                if (A[i] == 0 || A[i] == 1) kiemTra = false;
                if (A[i] == 2 || A[i] == 3) kiemTra = true;
                for (int j = 2; j <= Math.Sqrt(A[i]); j++){ // kiểm tra từng giá trị trong mảng
                    if (A[i] % j == 0){
                        kiemTra = false;                                        
                        break;
                    }
                    else{
                        kiemTra = true;                       
                    }
                }
                if (kiemTra){   //tương đương với kiemtra == true              
                    Console.Write(A[i] + "  ");
                    demNT++;
                }
            }
            Console.WriteLine("\nSố lượng số nguyên tố trong mảng là: {0}", demNT);

            Console.WriteLine("Sắp xếp mảng tăng dần");
            for (int i = 0; i < A.Length; i++)
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        int tam = A[i];
                        A[i] = A[j];
                        A[j] = tam;
                    }
                }

            foreach (int item in A)
                Console.Write(item + "  ");
             
            Console.ReadLine();
            Console.WriteLine("------ Kết thúc chương trình-------");
        }
    }
}
