using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{
    class dsbenhnhan
    {
        Dictionary<string, benh_nhan> DSBN;
        internal Dictionary<string, benh_nhan> DSBN1
        {
            get { return DSBN; }
            set { DSBN = value; }
        }
        public dsbenhnhan()
        {
            DSBN = new Dictionary<string, benh_nhan>();
        }
        public void Nhap()
        {
            benh_nhan BN;
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                string Option;
                Console.WriteLine("nhập 0 để đến thoát nhập, nhập B cho bệnh nhân bhxh, H cho bệnh nhân bhyt ");
                Option = Console.ReadLine().ToUpper();
                if (Option == "0") break;
                if (Option == "B")
                {
                    DateTime dt = new DateTime(2023,9,9);
                    BN = new benhnhan__bhxh("tuong", "123", dt, true, "321");
                    //BN.Nhap();
                    DSBN1.Add(BN.Mabn, BN);
                }
                if (Option == "H")
                {
                    DateTime dt = new DateTime(2023, 7, 5);
                    BN = new benhnhan__bhyt("thao", "456", dt, false, "654");
                    //BN.Nhap();
                    DSBN1.Add(BN.Mabn, BN);
                }
            }
        }
        public void Xuat()
        {

            if (DSBN1.Count == 0) Console.WriteLine("Danh sách rỗng");
            else
                foreach (benh_nhan item in DSBN1.Values)
                {
                    item.Xuat();
                    Console.WriteLine();
                    if (item is benhnhan__bhxh bhxh)
                    {
                        Console.WriteLine("Tien vien phi benh nhan bhxh {0}",bhxh.tinhHoaDonVienPhi());
                    }
                    else if (item is benhnhan__bhyt bhyt)
                    {
                        Console.WriteLine("Tien vien phi benh nhan bhyt {0}",bhyt.tinhHoaDonVienPhi());
                    }

                }

        }
        public double TongTienVienphi()
        {
            double tongTien = 0;

            foreach (benh_nhan item in DSBN1.Values)
            {
                if (item is benhnhan__bhxh bhxh)
                {
                    tongTien += bhxh.tinhHoaDonVienPhi();
                }
                else if (item is benhnhan__bhyt bhyt)
                {
                    tongTien += bhyt.tinhHoaDonVienPhi();
                }
            }

            return tongTien;
        }
        public void Tim()
        {
            Console.WriteLine("----------------------Nhập vào mã bệnh nhân cần tìm:------------------- ");
            string maTim = Console.ReadLine();
            benh_nhan BN = null;
            int p = 0;
            foreach (benh_nhan item in DSBN1.Values)
            {
                if (item.Mabn == maTim)
                {
                    p = 1; BN = item; break;
                }
                else
                    p = 0;
            }
            if (p == 1)
            {
                Console.WriteLine("----------------Có bệnh nhân cần tìm---------------------");
                BN.Xuat();
                foreach (benh_nhan item in DSBN1.Values)
                {
                    if (item is benhnhan__bhxh bhxh)
                    {
                        Console.WriteLine("Tien vien phi benh nhan bhxh {0}", bhxh.tinhHoaDonVienPhi());
                    }
                    else if (item is benhnhan__bhyt bhyt)
                    {
                        Console.WriteLine("Tien vien phi benh nhan bhyt {0}", bhyt.tinhHoaDonVienPhi());
                    }
                }
                //return NV; 
            }
            else
            {
                Console.WriteLine("---------------------Không có bệnh nhân cần tìm--------------------");
                //return null; 
            }
        }
        public void Xoa()
        {
            Console.WriteLine("******************Nhập vào mã bệnh nhân cần xóa************ ");
            string maXoa = Console.ReadLine();
            int p = 0;
            foreach (benh_nhan item in DSBN1.Values)
            {
                if (item.Mabn == maXoa)
                {
                    p = 1; DSBN.Remove(maXoa); break;
                }
                else
                    p = 0;
            }
            if (p == 1)
            {
                Console.WriteLine("***************************Có bệnh nhân cần xóa******************");
                Console.WriteLine("*************** Danh sách bệnh nhân sau khi xóa *************");
                Xuat();
            }
            else
            { Console.WriteLine("*****************Không có bệnh nhân cần xóa**************************"); }

        }
        public void Sua()
        {
            int p = 0;
            while (true)
            {
                Console.WriteLine("-------Nhập vào mã bệnh nhân cần Cập nhật--------------");
                string maSua = Console.ReadLine().ToUpper();
                foreach (benh_nhan item in DSBN1.Values)
                {
                    if (item.Mabn.ToUpper() == maSua)
                    {
                        p = 1;

                        while (true)
                        {
                            try
                            {
                                DSBN1.Remove(maSua);

                                item.Nhap();
                                if (item.Mabn != maSua) Console.WriteLine("_________*_________Bạn đã đổi lại mã {0} sang mã mới là: {1}", maSua, item.Mabn);
                                DSBN1.Add(item.Mabn, item);

                                break;
                            }
                            catch
                            {
                                Console.WriteLine("----------------Nhập trùng mã đã có, nhập lại");
                            }
                        }
                        break;
                    }
                    else p = 0;
                }
                if (p == 1)
                {
                    Console.WriteLine("-------------------Danh sách sau khi sửa bản ghi có mã là {0}---------------------", maSua);
                    foreach (benh_nhan item in DSBN1.Values)
                    {
                        item.Xuat();
                       
                        if (item is benhnhan__bhxh bhxh)
                        {
                            Console.WriteLine("Tien vien phi benh nhan bhxh {0}", bhxh.tinhHoaDonVienPhi());
                        }
                        else if (item is benhnhan__bhyt bhyt)
                        {
                            Console.WriteLine("Tien vien phi benh nhan bhyt {0}", bhyt.tinhHoaDonVienPhi());
                        }
                    }
                    break;
                }
                else if (p == 0)
                {
                    Console.WriteLine("--------------Bạn phải nhập mã đã có thì mới sửa được bản ghi, nếu muốn thoát thì nhấn 3 phím 000");
                    if (maSua == "000") break;
                }
            }
        }



    }
}
