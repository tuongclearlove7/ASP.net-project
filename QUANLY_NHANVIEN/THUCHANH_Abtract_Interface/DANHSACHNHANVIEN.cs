using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THUCHANH_Abtract_Interface
{
    class DANHSACHNHANVIEN
    {
        Dictionary<string, NHANVIEN> DSNV;
        internal Dictionary<string, NHANVIEN> DSNV1
        {
            get { return DSNV; }
            set { DSNV = value; }
        }
        public DANHSACHNHANVIEN()
        {
            DSNV = new Dictionary<string, NHANVIEN>();
        }
        public void Nhap()
        {
            NHANVIEN NV;
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                string Option;
                Console.WriteLine("nhập 0 để đến thoát nhập, nhập B cho nhân viên biên chế, H cho nhân viên hợp đồng ");
                Option = Console.ReadLine().ToUpper();
                if (Option == "0")
                {
                    break;
                }
                if (Option == "B")
                {
                    NV = new NVBC();
                    NV.Nhap();
                    DSNV1.Add(NV.Manhanvien, NV);
                }
                if (Option == "H")
                {
                    NV = new NVHD();
                    NV.Nhap();
                    DSNV1.Add(NV.Manhanvien, NV);
                }
            }
        }
        public void Xuat()
        {
            if (DSNV1.Count == 0) Console.WriteLine("Danh sách rỗng");
            else
                foreach (NHANVIEN item in DSNV1.Values)
                    item.Xuat();
        }
        public double TongQuyLuong()
        {
            double tongquyluong = 0;
            //foreach (NHANVIEN item in DSNV1.Values)
            //{
            //    if (item is NVBC)
            //        tongquyluong = tongquyluong + ((NVBC)item).ThucLinh();
            //    else if (item is NVHD)
            //        tongquyluong = tongquyluong + ((NVHD)item).ThucLinh();
            //}
            foreach (NHANVIEN item in DSNV1.Values)   // Vì lớp NHANVIEN có abstract ở ThucLinh() và 2 lớp con có 
                tongquyluong = tongquyluong + item.ThucLinh();  // override ThucLinh() nên ở đây không cần dùng Downcasting
            return tongquyluong;
        }
        public void Tim()
        {
            Console.WriteLine("----------------------Nhập vào mã nhân viên cần tìm:------------------- ");
            string maTim = Console.ReadLine();
            NHANVIEN NV = null;
            int p = 0;
            foreach (NHANVIEN item in DSNV1.Values)
            {
                if (item.Manhanvien == maTim)
                {
                    p = 1; NV = item; break;
                }
                else
                    p = 0;
            }
            if (p == 1)
            {
                Console.WriteLine("----------------Có nhân viên cần tìm---------------------");
                NV.Xuat();
                //return NV; 
            }
            else
            {
                Console.WriteLine("---------------------Không có nhân viên cần tìm--------------------");
                //return null; 
            }
        }
        public void Xoa()
        {
            Console.WriteLine("******************Nhập vào mã nhân viên cần xóa************ ");
            string maXoa = Console.ReadLine();
            int p = 0;
            foreach (NHANVIEN item in DSNV1.Values)
            {
                if (item.Manhanvien == maXoa)
                {
                    p = 1; DSNV.Remove(maXoa); break;
                }
                else
                    p = 0;
            }
            if (p == 1)
            {
                Console.WriteLine("***************************Có nhân viên cần xóa******************");
                Console.WriteLine("*************** Danh sách nhân viên sau khi xóa *************");
                Xuat();
            }
            else
            { Console.WriteLine("*****************Không có nhân viên cần xóa**************************"); }

        }
        public void Sua()
        {
            int p = 0;
            while (true)
            {
                Console.WriteLine("-------Nhập vào mã nhân viên cần Cập nhật--------------");
                string maSua = Console.ReadLine().ToUpper();
                foreach (NHANVIEN item in DSNV1.Values)
                {
                    if (item.Manhanvien.ToUpper() == maSua)
                    {
                        p = 1;                // Nếu ko có p = 1 thì p luôn là 0 và sẽ xuất ra dòng cảnh báo Console.WriteLine("Bạn phải ....."); 
                        //   item.Nhap();        ///Nếu chỉ dùng mỗi hàm Nhap() thì khi nhập có thể trùng mã nhưng khi xuất vẫn hiện lên 2 mã giống
                        //nhau vì lúc này chưa sử dụng hàm Add của danh sách 
                        while (true)
                        {
                            try
                            {
                                DSNV1.Remove(maSua);
                                // nếu thay maSua là item.Manhanvien thì nếu như khi nhập item.Manhanvien trùng mã thì try catch 
                                //sẽ quay lại và tiếp theo là xóa 1 bản ghi nữa (vì lúc này item.Manhanvien là nhan viên tiếp 
                                //theo trong danh sách) là thành xóa 2 bản ghi => sai. Còn nếu như để maSua thì sau khi xóa 
                                // bệnh nhân có mã maSua thì sẽ ko còn bệnh nhân có mã maSua để xóa nữa  
                                item.Nhap();
                                if (item.Manhanvien != maSua) Console.WriteLine("_________*_________Bạn đã đổi lại mã {0} sang mã mới là: {1}", maSua, item.Manhanvien);
                                DSNV1.Add(item.Manhanvien, item);
                                //vd: ta có 2 nhân viên với 2 mã là 001 và 002 và ta nhập mã maSua = 002 để vào nhân viên có mã 002 để sửa
                                //Nếu ta dùng maSua thay cho item.Manhanvien thì lúc này nếu như ở hàm Nhap() ta nhập mã đã có trước đó là 001,
                                //  ví dụ ở hàm Nhap(), ta nhập mã nhân viên = 001 thì danhsach (lúc này sẽ có 2 nhân viên với 2 mã đều là 001 ) 
                                //vẫn nhận vì hàm thêm danhsach.Add(maSua, item) nhìn nhận maSua là mã mới đã nhập ở hàm Main và quan trọng
                                //là maSua = 002 khác với mã nhân viên = 001                               
                                // Vì vậy ở đây bắt buộc phải dùng item.Manhanvien (chứ ko được dùng maSua) vì nếu ở hàm Nhap() ta nhập bị trùng thì sẽ đc nhập lại
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("----------------Nhập trùng mã đã có, nhập lại");
                            }
                        }
                        break;  // thoát chương trình, vì lúc này danh sách đã được sửa, nên nếu tiếp tục chạy thì hàm foreach sẽ báo lỗi, phiên bản mới thì ko cần phải break ở dòng này
                    }
                    else p = 0;
                }
                if (p == 1)
                {
                    Console.WriteLine("-------------------Danh sách sau khi sửa bản ghi có mã là {0}---------------------", maSua);
                    foreach (NHANVIEN item in DSNV1.Values)
                        item.Xuat();
                    break;
                }
                else if (p == 0)
                {
                    Console.WriteLine("--------------Bạn phải nhập mã đã có thì mới sửa được bản ghi, nếu muốn thoát thì nhấn 3 phím 000");
                    if (maSua == "000") break;
                }
            }
        }

        //////// CÁCH 2
        /* public void Sua()
          {
              Console.WriteLine("-------Nhập vào mã nhân viên cần Cập nhật--------------");
              string maSua = Console.ReadLine().ToUpper();
              string maMoi = "";
              int timSua = 0; int sua;
              foreach (NHANVIEN item in DSNV1.Values)
                  if (item.Manhanvien == maSua)
                  {
                      timSua = 1;
                      do {
                          Console.WriteLine("Bạn muốn sửa thông tin gì ở nhân viên có mã {0} ? \n0: Thoát \n 1: Sửa Mã NV \n 2: Sửa Tên \n 3:Sửa ngày sinh .........", maSua);
                          sua = int.Parse(Console.ReadLine());
                          switch (sua){
                              case 1:
                                      while(true)
                                      {
                                          Console.WriteLine("Nhập mã muốn sửa: "); maMoi = Console.ReadLine();
                                          if(DSNV1.ContainsKey(maMoi))
                                          {
                                              if (item.Manhanvien == maMoi) { Console.WriteLine("Bạn không muốn sửa mã"); break; }
                                              else Console.WriteLine("Bạn đã nhập trùng mã đã có"); 
                                          }
                                          else
                                          {
                                              item.Manhanvien = maMoi;
                                              DSNV1.Remove(maSua);
                                              DSNV1.Add(maMoi, item);
                                              Console.WriteLine("Đã sửa xong mã");
                                              break;
                                              //return;
                                          }
                                      }                                
                                  break;
                              case 2:
                                  Console.WriteLine("Nhập tên nhân viên muốn sửa"); string tenMoi = Console.ReadLine();
                                  item.Hoten = tenMoi; 
                                  break;
                              case 3:
                                  Console.WriteLine("Nhập ngày sinh nhân viên muốn sửa"); DateTime namSinhMoi = DateTime.Parse(Console.ReadLine());
                                  item.Namsinh = namSinhMoi; 
                                  break;
                              default: Console.WriteLine("Chỉ được nhập số từ 0 đến 3 để sửa"); break;
                          }
                      } while (sua != 0);
                      if (timSua == 1) break;
                  }
              if (timSua == 0) Console.WriteLine("Không có nhân viên này trong danh sách");
          }*/
         

          ///// CÁCH 3
          /*
             public void Sua()
          {
              Console.WriteLine("-------Nhập vào mã nhân viên cần Cập nhật--------------");
              string maSua = Console.ReadLine().ToUpper();
              string maMoi = maSua;
              int sua;
              if (DSNV1.ContainsKey(maSua))
              {

                  NHANVIEN nv = DSNV1[maSua];
                  DSNV1.Remove(maSua);
                  do
                  {
                      Console.WriteLine("Bạn muốn sửa thông tin gì ? \n0: Thoát \n 1: Sửa Mã NV \n 2: Sửa Tên \n 3:Sửa ngày sinh");
                      sua = int.Parse(Console.ReadLine());
                      switch (sua)
                      {
                          case 1:
                              while (true)
                              {
                                  Console.WriteLine("Nhập mã muốn sửa: "); maMoi = Console.ReadLine();
                                  nv.Manhanvien = maMoi;
                                  if (DSNV1.ContainsKey(maMoi))
                                      Console.WriteLine("Bạn đã nhập trùng mã đã có");
                                  else
                                  {
                                      Console.WriteLine("Đã sửa xong mã");
                                      break;
                                  }
                              }
                              break;
                          case 2:
                              Console.WriteLine("Nhập tên nhân viên muốn sửa"); string tenMoi = Console.ReadLine();
                              nv.Hoten = tenMoi;
                              break;
                          case 3:
                              Console.WriteLine("Nhập ngày sinh nhân viên muốn sửa"); DateTime namSinhMoi = DateTime.Parse(Console.ReadLine());
                              nv.Namsinh = namSinhMoi;
                              break;
                          default: Console.WriteLine("Chỉ được nhập số từ 0 đến 3 để sửa"); break;
                      }
                  } while (sua != 0);
                  DSNV1.Add(maMoi, nv);
              }
              else Console.WriteLine("Không có nhân viên này trong danh sách");
          } 
           */

    }
}
