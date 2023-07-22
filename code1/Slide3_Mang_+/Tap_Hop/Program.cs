using System;
using System.Collections;               // Dùng cho ArrayList, Queue
using System.Collections.Generic;         // Dùng cho List[T],  Queue[T]
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap_Hop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // 
            Console.WriteLine("Vi du minh hoa ArrayList và List<T> trong C#");

           /* ArrayList al = new ArrayList();
            Console.WriteLine("\n------------------Thêm mot vai phan tu vao ArrayList:----");
            al.Add(45); al.Add(78); al.Add("ba mươi ba"); al.Add(56); al.Add(15); al.Add(20);
            al.Add(12); al.Add(7); al.Add(9); al.Add(78);
            //al.Add(12); al.Add(7); al.Add(9);
            Console.WriteLine("-------- Xuất---------");
            foreach (var i in al)      // var hoặc object
            {
                Console.Write(i + "\t");  // 1
            }
            al.Remove(45); al.Remove(15);
            Console.WriteLine("\nTổng số lượng có trong danh sách là: {0}", al.Count);  //2
            Console.WriteLine("Dung lượng hiện tại của danh sách là: {0}", al.Capacity);  // 3
            Console.ReadLine();*/

            //List<int> L = new List<int>();
            //Console.WriteLine("\n-------------- Thêm một vài phần tử vào List<T>:------");
            //L.Add(45); L.Add(78); L.Add(33); L.Add(56); L.Add(15);
            //Console.WriteLine("Xuất List");
            //foreach (int i in L)
            //    Console.Write(i + "\t");   //1
            //Console.ReadLine();

            //L.Insert(2, 1000);
            //L.RemoveAt(1);
            //Console.WriteLine();       
            //Console.WriteLine("\n-------------Hien thi cac phan tu trong ArrayList sau khi chèn và xóa: -----------------------------");
            //foreach (var i in L)
            //{
            //    Console.Write(i + "\t");    //2
            //}
            //Console.WriteLine();
            //Console.WriteLine("\nSo phan tu trong ArrayList: {0}", L.Count);  //3
            //Console.WriteLine("Dung luong cua ArrayList: {0} ", L.Capacity);  //4
            //Console.ReadLine();
            //Console.WriteLine();
            //al.Sort();
            //Console.WriteLine("\nSap xep va hien thi ArrayList sau khi đã sort: ");
            //foreach (int i in al)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine();
            //Console.ReadLine();


            ///  Queue dùng using System.Collections; 
            //Console.WriteLine("\n---------------Hàng đợi ");
            //Queue hangdoi1 = new Queue();
            //hangdoi1.Enqueue(1);
            //hangdoi1.Enqueue(2);
            //hangdoi1.Enqueue("Hello");
            //hangdoi1.Enqueue(8);
            //foreach (var item in hangdoi1)
            //    Console.Write(item + "\t");  // 1
            //Console.WriteLine();
            //Console.ReadLine();

            //bool kiemtra1 = hangdoi1.Contains(2);
            //hangdoi1.Dequeue();
            //Console.WriteLine(kiemtra1);      //2
            //foreach (var item in hangdoi1)
            //    Console.Write(item + "\t");   //3
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine("\n---------------------Hàng đợi <T>--- Queue<T>----------------");        // Dùng using System.Collections.Generic;
            //Queue<int> hangdoi2 = new Queue<int>();
            //hangdoi2.Enqueue(4);
            //hangdoi2.Enqueue(7);
            //hangdoi2.Enqueue(9);
            //bool kiemtra2 = hangdoi2.Contains(6);
            //Console.WriteLine(kiemtra2);
            //foreach (var item in hangdoi2)
            //    Console.Write(item + "\t ");
            //hangdoi2.Dequeue();
            //Console.WriteLine();
            //Console.WriteLine("\n-----Sau khi xóa----------");
            //foreach (int item in hangdoi2)
            //    Console.Write(item + "\t ");
            //hangdoi2.Enqueue(10);
            //Console.WriteLine("\n-----Sau khi thêm lại----------");
            //foreach (int item in hangdoi2)
            //    Console.Write(item + "\t ");
            //Console.ReadLine();

            // Ngăn xếp Stack
            //Console.WriteLine("\n***************Ngăn xếp Stack*****************");
           /* Stack nganxep = new Stack();
            nganxep.Push("Có");
            nganxep.Push(1);
            nganxep.Push("Nơi");
            Console.WriteLine(nganxep.Contains("Nơi"));  //1
            foreach (var item in nganxep)
            {
                Console.WriteLine(item + "\t");   //2
            }
            Console.ReadLine();
            //nganxep.Pop();
            //Console.WriteLine();
            //Console.WriteLine("\n-----Sau khi xóa----------");
            //foreach (var item in nganxep)
            //    Console.WriteLine(item + "\t");               // 3
            //nganxep.Push("Tốt");
            //Console.WriteLine("\n-----Sau khi thêm lại----------");
            //foreach (var item in nganxep)
            //    Console.WriteLine(item + "\t");               //4
            Console.ReadLine(); */

            // Dictionary
            Dictionary<int, string> thuvien = new Dictionary<int, string>();
            thuvien.Add(1, "Công Nghệ Phần Mềm");
            thuvien.Add(2, "Tin Ứng Dụng");
            thuvien.Add(3, "Lập trình .Net");
            Console.WriteLine(thuvien.ContainsKey(4));    //1
            Console.WriteLine(thuvien.ContainsValue("Tin Ứng Dụg"));    //2
            thuvien.Remove(3);
            //foreach (KeyValuePair<int, string> item in thuvien)
            //foreach (var item in thuvien)
            //foreach (int item in thuvien.Keys)
            foreach (string item in thuvien.Values)
            {
                Console.WriteLine(item);     //3
            }
            Console.ReadLine();
        }
    }
}
