using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TEN = { "Lan", "Thu", "Hoa", "Xuan" };
            foreach (string tenbien in TEN)
                Console.Write("{0} ", tenbien);
            Console.ReadLine();

        }
    }
}
