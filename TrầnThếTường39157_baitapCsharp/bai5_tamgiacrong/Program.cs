using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_tamgiacrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào chiều cao tam giác: ");
            int chieucao = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < chieucao; i++)
            {
                for (int j = chieucao - i; j > 1; j--) 
                    Console.Write(" ");

                for (int j = 0; j <= i; j++)
                    if (j == 0 || j == i || i == chieucao - 1) 
                        Console.Write("* ");
                    else 
                        Console.Write("  ");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
