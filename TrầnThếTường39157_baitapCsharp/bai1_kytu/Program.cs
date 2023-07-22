using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_kytu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một ký tự thường: ");
            char lowercaseChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

   
            char uppercaseChar = char.ToUpper(lowercaseChar);

            Console.WriteLine("Ký tự in hoa tương ứng là: " + uppercaseChar);
            Console.ReadLine();
        }
    }
}
