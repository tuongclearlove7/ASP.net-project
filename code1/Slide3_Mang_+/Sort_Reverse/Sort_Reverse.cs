using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Reverse
{
    class Sort_Reverse
    {
        int[] A = { 5, 3, 7, 9, 6 };
        string[] B = { "Xuân", "Hạ", "Thu", "Đông" };
        public void SapXep()
        {
            Array.Sort(A);
            Console.WriteLine("SORT A");
            foreach (int item in A)
                Console.Write("" + item + "   ");
            Console.WriteLine();

            Array.Sort(B);
            Console.WriteLine("\nSORT B");
            foreach (string item in B)
                Console.Write("" + item + "  ");
            Console.WriteLine();

            Console.WriteLine("\nReverse A");
            Array.Reverse(A);
            foreach (int item in A)
                Console.Write("" + item + "   ");
            Console.WriteLine();

            Console.WriteLine("\nReverse B");
            Array.Reverse(B);
            foreach (string item in B)
                Console.Write("" + item + "   ");
        }
    }
}
