using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_tinhtong
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sum = 0;
            Console.Write("Nhập giá trị n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++) sum = sum + i;
            Console.WriteLine("Tổng của dãy số từ 1 đến " + n + " là: " + sum);
            Console.ReadLine();
        }   
    }
}
