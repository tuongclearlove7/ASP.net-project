using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_tinhtongbinhphuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sum = 0;
            Console.Write("Nhập giá trị n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++) sum += i * i;
            Console.WriteLine("Tổng của bình phương dãy số từ 1 đến " + n + " là: " + sum);
            Console.ReadLine();

        }
    }
}
