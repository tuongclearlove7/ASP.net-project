using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ky_tu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string k;
            Console.Write("nhập chuỗi cần chuyển k: ");
            k = Console.ReadLine();
            k = k.ToUpper();
            char s = (char)k[0];
            Console.WriteLine("\nChuỗi sau khi chuyển là k = {0}", k);
            Console.WriteLine("Ký tự đầu của chuỗi: {0}", s);
            if (k.Length > 1)
            Console.WriteLine("Ký tự kế cuối của chuỗi: {0}", (char)k[k.Length - 2]);
            Console.ReadLine();
        }
    }
}
