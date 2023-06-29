using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_tinhgiaithua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int gt = 1;

            for (int i = 2; i <= n; i++) gt *= i;
            Console.WriteLine("Giai thừa của {0} là: {1}", n, gt);
            Console.ReadLine();
        }
    }
}
