using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    interface manhinh
    {
        void card_manhinh(); 
    }

    interface banphim
    {
        void keycap_banphim(); 
    }

  
    class laptop : manhinh, banphim
    {
        public void card_manhinh()
        {
            Console.WriteLine("Card ASUS TUF Gaming GeForce GTX 1660");
        }
        public void keycap_banphim()
        {
            Console.WriteLine("Keycap artisan Bara");
        }

        public void laptop_MSI()
        {
            Console.WriteLine("Laptop MSI Gamming");
        }
    }

    class baseClass
    {

        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }


    class derived : baseClass
    {

        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }


    public class web
    {

        string name = "Mydtu";

        public virtual void showdata()
        {
            Console.WriteLine("Website name : " + name);
        }
    }


    class domain : web
    {

        string domain_name = "mydtu.duytan.edu.vn";

        public override void showdata()
        {
            base.showdata();
            Console.WriteLine("Domain name : " + domain_name);
        }
    }

    abstract class loptruutuong
    {

        public abstract void hamtruutuong();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("ham trong lop truu tuong");
        }
    }

    class con_cua_truu_tuong : loptruutuong
    {
        public override void hamtruutuong()
        {

            Console.WriteLine("ham lop truu tuong");
        }
    }


    class Vehicle
    {
        public string brand = "Ford";  
        public void honk()           
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  
    {
        public string modelName = "Mustang";  
    }


    

 

    class XE
    {
        private string bienso;
        private string tenxe;
        private string trongtai;
        private string ngaydangkiem;
        private string tieuchuanbang;

        public string Bienso { get => bienso; set => bienso = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public string Trongtai { get => trongtai; set => trongtai = value; }
        public string Ngaydangkiem { get => ngaydangkiem; set => ngaydangkiem = value; }
        public string Tieuchuanbang { get => tieuchuanbang; set => tieuchuanbang = value; }

        public XE(string bienso, string tenxe, string trongtai, string ngaydangkiem, string tieuchuanbang)
        {
            this.Bienso = bienso;
            this.Tenxe = tenxe;
            this.trongtai = trongtai;
            this.ngaydangkiem = ngaydangkiem;
            this.Tieuchuanbang = tieuchuanbang;
        }

        public XE()
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap vao bien so xe: ");
            Bienso = Console.ReadLine();
            Console.Write("Nhap vao ten xe: ");
            Tenxe = Console.ReadLine();
            Console.Write("Nhap vao ngay dang kiem xe: ");
            Ngaydangkiem = Console.ReadLine();
            Console.Write("Nhap Trong tai xe: ");
            Trongtai = Console.ReadLine();
            Console.Write("Nhap tieu chuan xe: ");
            Tieuchuanbang = Console.ReadLine();

        }
        public virtual void Xuat()
        {
            Console.WriteLine("_____________________________ Thông tin xe có biển số {0}________________________", Bienso);
            Console.WriteLine("Bien so xe la: " + Bienso);
            Console.WriteLine("Ten cua xe la: " + Tenxe);   
            Console.WriteLine("Ngay dang kiem xe la: {0}", Ngaydangkiem);
            Console.WriteLine("Trong tai xe : {0}", Trongtai);
            Console.WriteLine("Tieu chuan bang cua xe : {0}", Tieuchuanbang);

        }
    }

    class XE_DULICH : XE
    {
        private string sochongoi;

        public string Sochongoi { get => sochongoi; set => sochongoi = value; }

        public XE_DULICH()
        {
            
        }

        public XE_DULICH(string bienso, string tenxe, string trongtai, string ngaydangkiem, string tieuchuanbang, string sochongoi) 
        : base(bienso, tenxe, trongtai, ngaydangkiem, tieuchuanbang)
        {
            Sochongoi = sochongoi;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so cho ngoi xe du lich : ");
            Sochongoi = Console.ReadLine();
         

        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So cho ngoi cua xe : " + Sochongoi);
            

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class XE_CHOHANG : XE
    {
        private string sotan;

        public string Sotan { get => sotan; set => sotan = value; }

        public XE_CHOHANG()
        {
        }

        public XE_CHOHANG(string bienso, string tenxe, string trongtai, string ngaydangkiem, string tieuchuanbang, string sotan) 
        : base(bienso, tenxe, trongtai, ngaydangkiem, tieuchuanbang)
        {

            Sotan = sotan;
        }



        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so tan xe cho hang : ");
            Sotan = Console.ReadLine();


        }
        public override void Xuat()
        {

            base.Xuat();
            Console.WriteLine("So tan cua xe : " + Sotan);


        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    //class DanhSachXe
    //{
    //    Dictionary<string, XE_DULICH> Dic = new Dictionary<string, XE_DULICH>();
    //    public void Nhap()
    //    {
    //        XE_DULICH xe;
    //        while (true)
    //        {
    //            Console.WriteLine("Nhập 0 để vào menu ----- Nhập 1 để nhập xe mới");
    //            int x = int.Parse(Console.ReadLine());
    //            if (x == 0) break;
    //            if (x == 1)
    //            {
    //                xe = new XE_DULICH();
    //                xe.Nhap();
    //                Dic.Add(xe.Bienso, xe);
    //            }
    //        }

    //    }
    //    public void Xuat()
    //    {
    //        if (Dic.Count == 0) Console.WriteLine("--------Danh sách null---------------");
    //        if (Dic.Count > 0)
    //        {
    //            Console.WriteLine("********Xuất danh sách xe **************");
    //            foreach (XE_DULICH item in Dic.Values)
    //            {
    //                item.Xuat();
    //            }
    //        }
    //    }
    //    public void Tim()
    //    {
    //        Console.WriteLine("*****************  Nhập biển số cần tìm ****************");
    //        string bienSoTim = Console.ReadLine();
    //        int tim = 0;
    //        foreach (XE_DULICH item in Dic.Values)    //foreach(kieuphantu ten in danhsach) 
    //            if (item.Bienso == bienSoTim)
    //            {
    //                tim = 1;
    //                Console.WriteLine("*************** Có xe cần tìm  *****************");
    //                Console.WriteLine("*************** Xe sau khi tìm  *************");
    //                item.Xuat();
    //                break;
    //            }
    //            else
    //                tim = 0;
    //        if (tim == 0)
    //            Console.WriteLine("*************** Không có xe cần tìm  *****************");
    //    }
    //    public void Xoa()
    //    {
    //        Console.WriteLine("-----------------Nhập biển số xe cần xóa------------");
    //        string bienSoXoa = Console.ReadLine();
    //        if (Dic.ContainsKey(bienSoXoa))
    //        {
    //            Console.WriteLine("---------------Có biển số cần xóa-----------------");
    //            Dic.Remove(bienSoXoa);
    //        }
    //        else Console.WriteLine("------Không có biển số cần xóa---------");
    //    }
    //    public void Dem()
    //    {
    //        Console.WriteLine("Số lượng xe trong danh sách là: {0}", Dic.Count());
    //    }
    //}


    class QuanLyXe
    {
        Dictionary<string, XE> danhsach;
        internal Dictionary<string, XE> Danhsach
        {
            get { return danhsach; }
            set { danhsach = value; }
        }
        public QuanLyXe()
        {
            Danhsach = new Dictionary<string, XE>();
        }
        public void LuaChon()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("-------****************Nhập 0 để thoát, 1 để thêm xe"
                    + ", 2 để chèn vị trí, 3 để xuất danh sách xe, 4 để tìm xe theo yêu cầu *****************-------");
                string luaChon = Console.ReadLine();
                if (luaChon == "0")
                    break;
                if (luaChon == "1")
                    Nhap();
                else if (luaChon == "2")
                    Chen();
                else if (luaChon == "3")
                    Xuat();
                else if (luaChon == "4") Tim();
            }
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode; Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("Nhập C để nhập xe chở hàng, D để nhập xe du lịch, Exit để thoát khỏi yêu cầu nhập");
                string option = Console.ReadLine().ToUpper();
                if (option == "EXIT") break;
                if (option == "C")
                {
                    XE xe = new XE_CHOHANG();
                    while (true)
                    {
                        try
                        {
                            xe.Nhap();
                            Danhsach.Add(xe.Bienso, xe);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng");
                        }
                    }
                }
                if (option == "D")
                {
                    XE xe = new XE_DULICH();
                    while (true)
                    {
                        try
                        {
                            xe.Nhap();
                            Danhsach.Add(xe.Bienso, xe);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nhập bị trùng mã hoặc sai định dạng ngày tháng");
                        }
                    }
                }
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Xuất danh sách xe");
            foreach (XE item in Danhsach.Values)
            {
                item.Xuat();
            }
        }

        public XE Tim()
        {
            Console.WriteLine("Nhập biển số xe cần tìm");
            string bienSoTim = Console.ReadLine();
            int tim = 0;
            XE X = null;
            foreach (XE item in Danhsach.Values)
            {
                if (item.Bienso == bienSoTim)
                {
                    tim = 1;
                    X = item;
                    Console.WriteLine("Có xe cần tìm biển số là {0}", bienSoTim);
                    X.Xuat();
                    break;
                }
            }
            if (tim == 0)
                Console.WriteLine("Không Có xe cần tìm biển số là {0}", bienSoTim);
            return X;
        }

        public void Chen()
        {
            Console.WriteLine("Nhập vị trí cần chèn: "); int n = int.Parse(Console.ReadLine());
           
            List<KeyValuePair<string, XE>> listT = Danhsach.ToList();     // Chuyển từ Dictionary qua List          
            if (n > Danhsach.Count) Console.WriteLine("Vị trí nhập nằm ngoài danh sách");
            else
            {
                while (true)
                {
                    Console.WriteLine("Nhập C để nhập xe chở hàng, D để nhập xe du lịch, exit để thoát");
                    string option = Console.ReadLine().ToUpper();
                    if (option == "EXIT") break;
                    if (option == "C")
                    {
                        XE xe = new XE_CHOHANG();
                        xe.Nhap();
                        listT.Insert(n, new KeyValuePair<string, XE>(xe.Bienso, xe));
                    }
                    if (option == "D")
                    {
                        XE xe = new XE_DULICH();
                        xe.Nhap();
                        listT.Insert(n, new KeyValuePair<string, XE>(xe.Bienso, xe));
                    }
                    Console.WriteLine("Bạn có muốn chèn tiếp ko, nếu không có thì nhập vị trí n = -1, ngược lại nhập vị trí n cần nhập");
                    n = int.Parse(Console.ReadLine());
                    if (n == -1) break;
                }
                danhsach = listT.ToDictionary(x => x.Key, x => x.Value);                         // Chuyển từ List qua Dictionary
                Console.WriteLine("Danh sách sau khi chèn vào vị trí số {0}: -----------------------", n);
                foreach (KeyValuePair<string, XE> item in danhsach)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }




    class Program
    {

        private string conga;


        public string Conga {
            get => conga;
            set => conga = value;
        }



        static void run_main()
        {
            const int dosau = 200;
            int dosoi = 100;
            int nhietdo = 20;

            Program animal = new Program();
            Console.WriteLine(animal.conga = "Chicken!!!");
            Console.WriteLine(dosoi = nhietdo);
            Console.WriteLine("{0}", dosau);
            Console.ReadLine();


            Car myCar = new Car();
            con_cua_truu_tuong con = new con_cua_truu_tuong();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            con.hamtruutuong();
            con.sleep();

            laptop lap = new laptop();
            lap.laptop_MSI();
            lap.card_manhinh();
            lap.keycap_banphim();

            baseClass obj;
            obj = new baseClass();
            obj.show();
            obj = new derived();
            obj.show();

            domain website = new domain();
            website.showdata();

            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            QuanLyXe QLX = new QuanLyXe();
            QLX.LuaChon();
            Console.WriteLine("Chương trình kết thúc");
            Console.ReadLine();
        }
    }
}
