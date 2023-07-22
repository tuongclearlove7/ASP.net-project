using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static int Nhap(char i){
            Console.WriteLine("Nhap he so {0}", i);
            int x;
            while (true){
                try{
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception){
                
    Console.WriteLine("Ban nhap sai kieu he so {0},moi nhap lai = so", i);
                }
            }
            return x;
        }
        static void Main(string[] args)
        {   Console.OutputEncoding = Encoding.UTF8;
            int a, b, c;
            Console.WriteLine("Mời bạn nhập 3 hệ số a, b,c");
            a = Nhap('a');
            b = Nhap('b'); c = Nhap('c');
            Console.WriteLine("Các hệ số vừa nhập là a = {0}, b = {1}, c = {2}", a, b, c);
            //Console.ReadLine();
            //    while (true){
            //    string soA = Console.ReadLine(); 
            //    string soB = Console.ReadLine(); string soC = Console.ReadLine();
            //    if (int.TryParse(soA, out a))
            //    {
            //        if (int.TryParse(soB, out b))
            //        {
            //            if (int.TryParse(soC, out c))
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    Console.WriteLine("Mời bạn nhập lại = chữ");
            //}
            //Console.WriteLine("Các hệ số vừa nhập là a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}
