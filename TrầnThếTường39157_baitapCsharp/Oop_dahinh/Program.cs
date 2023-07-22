using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{


    interface manhinh
    {
         void card_manhinh();
         void bocmanhinh();
    }

    interface banphim
    {
        void keycap_banphim();
    }

    interface day
    {
        void daycuachuot();
    }

    interface chuot : day
    {
        void chuotPC();
        void chuotLap();
    }

    interface Iphucap
    {
        double phucap();
    }


    abstract class NHANVIEN
    {
        string ten;
        string namsinh;
        string gioitinh;
        string cmnd;
        string manv;

        protected NHANVIEN()
        {
        }

        protected NHANVIEN(string ten, string namsinh, string gioitinh, string cmnd, string manv)
        {
            this.ten = ten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.Manv = manv;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public string Ten { get => ten; set => ten = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        abstract public double thuclinh();

        public override string ToString()
        {
            return base.ToString();
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap vao ma nhan vien : ");
            Manv = Console.ReadLine();
            Console.Write("Nhap vao Ten : ");
            Ten = Console.ReadLine();
            Console.Write("Nhap vao cmnd : ");
            Cmnd = Console.ReadLine();
            Console.Write("Nhap gioi tinh : ");
            Gioitinh = Console.ReadLine();
            Console.Write("Nhap nam sinh : ");
            Namsinh = Console.ReadLine();

        }
        public virtual void Xuat()
        {
            Console.WriteLine("_____________________________ Thông tin nhan vien {0}________________________", Ten);
            Console.WriteLine("ma nhan vien la : " + Manv);
            Console.WriteLine("Ten nhan vien la : " + Ten);
            Console.WriteLine("so chung minh nhan dan la : {0}", Cmnd);
            Console.WriteLine("gioi tinh la : {0}", Gioitinh);
            Console.WriteLine("Nam sinh la : {0}", Namsinh);

        }

    }

    interface Itienan
    {

        double tinhTienAn();
    }


    abstract class BENHNHAN
    {
        string ten;
        string mabn;

        protected BENHNHAN()
        {
        }

        protected BENHNHAN(string ten, string mabn)
        {
            this.ten = ten;
            this.mabn = mabn;
           
        }

        public string Mabn { get => mabn; set => mabn = value; }
        public string Ten { get => ten; set => ten = value; }

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
            Console.Write("Nhap vao ma benh nhan : ");
            Mabn = Console.ReadLine();
            Console.Write("Nhap vao Ten : ");
            Ten = Console.ReadLine();
           

        }
        public virtual void Xuat()
        {
            Console.WriteLine("_____________________________ Thông tin Benh nhan {0}________________________", Ten);
            Console.WriteLine("ma nhan vien la : " + Mabn);
            Console.WriteLine("Ten nhan vien la : " + Ten);
            

        }

        abstract public double tinhvienphi();




    }



    class laptop : manhinh, banphim, chuot
     {

        public void daycuachuot()
        {
            Console.WriteLine("day chuot");
        }

        public void chuotPC()
        {
            Console.WriteLine("chuot pc");
        }

        public void chuotLap()
        {
            Console.WriteLine("chuot lap top");
        }

        public void bocmanhinh()
        {
            Console.WriteLine("boc man hinh");
        }
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
        public abstract void hamtruutuong2();
        // Regular method
        public float sleep()
        {
            Console.WriteLine("ham trong lop truu tuong");
            return 0;
        }
    }

    class con_cua_truu_tuong : loptruutuong
    {
        public override void hamtruutuong()
        {

            Console.WriteLine("ham lop truu tuong");
        }

        public override void hamtruutuong2()
        {

            Console.WriteLine("ham lop truu tuong 2");
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            dsbenhnhan DSBN = new dsbenhnhan();
            int luaChon;
            do
            {
                Console.WriteLine("Nhập 1 để Nhập, 2 để Xuất, 3 để Tìm, 4 để Xóa, 5 để Sửa, 0 để Thoát");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 0: break;
                    case 1: DSBN.Nhap(); break;
                    case 2: DSBN.Xuat(); break;
                    case 3: DSBN.Tim(); break;
                    case 4: DSBN.Xoa(); break;
                    case 5: DSBN.Sua(); break;
                    default: Console.WriteLine("Chỉ nhập từ 0 đến 5"); break;
                }
            } while (luaChon != 0);

            Console.WriteLine("---------Tổng viện phí là: {0}   ----------------------", DSBN.TongTienVienphi());
            Console.WriteLine("*******Chương trình kết thúc******");
            Console.ReadLine();
        }


        //static void Main(string[] args)
        //{
        //    DANHSACH_NHANVIEN DSNV = new DANHSACH_NHANVIEN();
        //    DSNV.LuaChon();
        //    Console.WriteLine("Chương trình kết thúc");
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{

        //    loptruutuong truutuong = new con_cua_truu_tuong();
        //    truutuong.sleep();
        //    con_cua_truu_tuong con = new con_cua_truu_tuong();
        //    con.hamtruutuong();
        //    con.sleep();

        //    laptop lap = new laptop();
        //    lap.laptop_MSI();
        //    lap.card_manhinh();
        //    lap.keycap_banphim();
        //    lap.chuotLap();
        //    lap.chuotPC();
        //    lap.daycuachuot();

        //    baseClass obj;
        //    obj = new baseClass();
        //    obj.show();
        //    obj = new derived();
        //    obj.show();

        //    domain website = new domain();
        //    website.showdata();

        //    Console.ReadLine();


        //}
    }
}
