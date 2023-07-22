using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Dictionary<string, string> monhoc = new Dictionary<string, string>();
            int a;
            do
            {
                Console.WriteLine("1: Nhập thông tin môn học");
                Console.WriteLine("2: Thực hiện kiểm tra môn KTTMĐT đã tồn tại hay chưa, nếu chưa thì thêm vào");
                Console.WriteLine("3 : Xem danh sách môn ");
                Console.WriteLine("4 : Đếm xem có bao nhiêu môn học ");
                Console.WriteLine("5 : Thực hiện xóa môn CS464 nếu có ");
                Console.WriteLine("0 : Thoát ");
                Console.WriteLine("Chon : ");
                a = int.Parse(Console.ReadLine()); //a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Nhập vào mã môn học");
                        string ma = Console.ReadLine();
                        Console.WriteLine("Nhập vào tên môn học");
                        string ten = Console.ReadLine();
                        try
                        {
                            monhoc.Add(ma, ten);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Không được trùng mã, nhập lại");
                        }
                        Console.WriteLine("------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("------------------------------");
                        if (monhoc.ContainsKey("CS464"))
                        {
                            Console.WriteLine("Đã tồn tại môn kỹ thuật thương mại điện tử");
                        }
                        else
                        {
                            monhoc.Add("CS464", "kỹ thuật thương mại điện tử");
                        }

                        Console.WriteLine("Danh sách môn sau khi thêm ");
                        foreach (KeyValuePair<string, string> item in monhoc)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("------------------------------");
                        break;
                    //break;
                    case 3:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Danh sách môn");
                        foreach (KeyValuePair<string, string> item in monhoc)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("------------------------------");
                        break;

                    case 4:
                        Console.WriteLine("------------------------------");
                        int dem = monhoc.Count();
                        Console.WriteLine("Tổng số môn học hiện có : {0}", dem);
                        Console.WriteLine("------------------------------");
                        break;

                    case 5:
                        Console.WriteLine("------------------------------");
                        if (monhoc.ContainsKey("CS464"))
                        {
                            monhoc.Remove("CS464");
                            Console.WriteLine("Danh sách môn sau khi xóa");
                            foreach (KeyValuePair<string, string> item in monhoc)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Không có môn CS464");
                        }

                        Console.WriteLine("------------------------------");
                        break;
                    default: // Nếu không thỏa các trường hợp trên sẽ thực hiện lệnh sau đây
                        Console.WriteLine("k thỏa nhé");
                        break;
                }
            }
            while (a != 0);


            Console.ReadLine();
        }
    }
}
