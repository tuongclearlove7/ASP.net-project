using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n co 3 chu so: ");
            n = int.Parse(Console.ReadLine());
            int dau = 0;
            int cuoi = n % 10;
            while (n != 0)
            {
                int du = n % 10;
                if (n / 10 == 0)
                {
                    dau = n;
                }
                n = n / 10;
            }
            Console.WriteLine("Tong la: " + (dau + cuoi) + "\n" + "Tich la: " + dau * cuoi);
            Console.ReadLine();
        }
    }
}
