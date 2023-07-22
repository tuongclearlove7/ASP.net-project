using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyXe QLX = new QuanLyXe();
            QLX.LuaChon();
            Console.WriteLine("Chương trình kết thúc");
            Console.ReadLine();
        }
    }
}
