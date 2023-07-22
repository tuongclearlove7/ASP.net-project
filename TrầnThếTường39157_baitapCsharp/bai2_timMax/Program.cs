using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_timMax
{
    class Program
    {

        static void nhapso(int n)
        {
            bool isValidInput = false;
            do
            {

                Console.Write("");
                isValidInput = int.TryParse(Console.ReadLine(), out n);

               
                if (!isValidInput)
                {
                    Console.WriteLine("Bạn đã nhập giá trị không hợp lệ. Vui lòng nhập lại.\n");
                }
            } while (!isValidInput);
        }

         static void Main(string[] args)
        {

            int a, b, c, d, e;
            bool isValidInput = false;

            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Nhập 5 số a, b, c, d, e:");

                Console.Write("a = ");
                isValidInput = int.TryParse(Console.ReadLine(), out a);

                Console.Write("b = ");
                isValidInput &= int.TryParse(Console.ReadLine(), out b);

                Console.Write("c = ");
                isValidInput &= int.TryParse(Console.ReadLine(), out c);

                Console.Write("d = ");
                isValidInput &= int.TryParse(Console.ReadLine(), out d);

                Console.Write("e = ");
                isValidInput &= int.TryParse(Console.ReadLine(), out e);

                if (!isValidInput)
                {
                    Console.WriteLine("Bạn đã nhập giá trị không hợp lệ. Vui lòng nhập lại.\n");
                }
            } while (!isValidInput);

            int maxNumber = Math.Max(Math.Max(Math.Max(Math.Max(a, b), c), d), e);

            Console.WriteLine("Số lớn nhất là: " + maxNumber);
        }
    }
}
