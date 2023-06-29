using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_tamgiaccan
{
    class Program
    {
        static void Main(string[] args)
        {
            int chieucao = 5;

            for (int i = 1; i <= chieucao; i++)
            {
                for (int j = i; j < chieucao; j++)
                    Console.Write(" ");
                for (int j = 1; j <= (2 * i - 1); j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
