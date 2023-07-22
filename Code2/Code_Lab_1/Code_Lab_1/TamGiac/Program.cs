using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            int a,b,c;
            Console.WriteLine("Nhập vào 3 cạnh của tam giác");
            Console.Write("a = "); a = int.Parse(Console.ReadLine());
            Console.Write("b = "); b = int.Parse(Console.ReadLine());
            Console.Write("c = "); c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a * a == b * b + c * c || c * c == b * b + a * a || b * b == a * a + c * c)
                {
                    Console.WriteLine("\nTam giác vuông");
                }
                else
                {
                    if (a == b && c == b && c == a)
                    {
                        Console.WriteLine("\nTam giác đều");
                    }
                    else
                    {
                        if (a == b || c == b || c == a)
                        {
                            Console.WriteLine("\nTam giác cân");
                        }
                        else
                        {
                            Console.WriteLine("Tam giác thường");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Không phải là tam giác");
            }
            Console.WriteLine("Chương trình kết thúc");
            Console.ReadLine();
        }
    }
}
