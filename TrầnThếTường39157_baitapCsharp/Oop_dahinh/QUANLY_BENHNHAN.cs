using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_dahinh
{
    class QUANLY_BENHNHAN
    {
        Dictionary<string, BENHNHAN> DSBN;
        internal Dictionary<string, BENHNHAN> DSBN1
        {
            get { return DSBN; }
            set { DSBN = value; }
        }
        public QUANLY_BENHNHAN()
        {
            DSBN = new Dictionary<string, BENHNHAN>();
        }
        public void Nhap()
        {
            BENHNHAN BN;
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                string Option;
                Console.WriteLine("nhập 0 để đến thoát nhập, nhập B cho bệnh nhân bhxh, H cho bệnh nhân bhyt ");
                Option = Console.ReadLine().ToUpper();
                if (Option == "0")
                {
                    break;
                }
                if (Option == "B")
                {
                    BN = new BENHNHAN_BHXH();
                    BN.Nhap();
                    DSBN1.Add(BN.Mabn, BN);
                }
                if (Option == "H")
                {
                    BN = new BENHNHAN_BHYT();
                    BN.Nhap();
                    DSBN1.Add(BN.Mabn, BN);
                }
            }
        }
        public void Xuat()
        {
            if (DSBN1.Count == 0) Console.WriteLine("Danh sách rỗng");
            else
                foreach (BENHNHAN item in DSBN1.Values)
                {
                    item.Xuat();
                    Console.WriteLine("Tien vien phi la : {0}" ,item.tinhvienphi());
                }
                   
        }
        public double tongVienphi()
        {
            double tongVienPhi = 0;
          
            foreach (BENHNHAN item in DSBN1.Values)
            {
                if (item is BENHNHAN_BHXH bHXH)
                {
                    if (bHXH.SoNgayNamVien < 30)                    
                        tongVienPhi += tongVienPhi + item.tinhvienphi() * 0.85;
                    else                 
                        tongVienPhi += tongVienPhi + item.tinhvienphi() * 0.8;
                }
                else
                {
                    if (((BENHNHAN_BHYT)item).SoNgayNamVien < 30)
                        tongVienPhi += tongVienPhi + item.tinhvienphi() * 0.8;
                    else
                        tongVienPhi += item.tinhvienphi() * 0.7;
                }
            }
                
            return tongVienPhi;
        }
        public void Tim()
        {
            Console.WriteLine("----------------------Nhập vào mã bệnh nhân cần tìm:------------------- ");
            string maTim = Console.ReadLine();
            BENHNHAN BN = null;
            int p = 0;
            foreach (BENHNHAN item in DSBN1.Values)
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
                Console.WriteLine("Tien vien phi la : {0}", BN.tinhvienphi());
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
            foreach (BENHNHAN item in DSBN1.Values)
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
                Console.WriteLine("***************************Có nhân viên cần xóa******************");
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
                foreach (BENHNHAN item in DSBN1.Values)
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
                    foreach (BENHNHAN item in DSBN1.Values)
                    {
                        item.Xuat();
                        Console.WriteLine("Tien vien phi la : {0}", item.tinhvienphi());
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
