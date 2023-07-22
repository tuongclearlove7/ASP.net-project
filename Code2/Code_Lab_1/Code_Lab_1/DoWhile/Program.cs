using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap canh a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c=");
            int c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                    Console.Write("Day la tam giac vuong");
                else if (a == b && b == c)
                    Console.Write("Day la tam giac deu");
                else if (a == b || a == c || b == c)
                    Console.Write("Day la tam giac can");
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                    Console.Write("Day la tam giac tu");
                else
                    Console.Write("Day la tam giac nhon");
            }
            else Console.Write("Ba canh a, b, c khong phai la ba canh cua mot tam giac");
            Console.ReadLine();
        }
    }
}
