using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien
{
    public class DanhSachNhanVien
    {
        Dictionary<string, NHANVIEN> list = new Dictionary<string, NHANVIEN>();

        public Dictionary<string, NHANVIEN> List
        {
            get { return list; }
            set { list = value; }
        }
        

        public DanhSachNhanVien()
        {
        }

        public DanhSachNhanVien(Dictionary<string, NHANVIEN> list)
        {
            this.list = list;
        }

        public void Nhap()
        {

            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát, B cho nhân viên biên chế, H cho nhân viên hợp đồng");
                string option = Console.ReadLine().ToUpper();
                if (option == "0") break;
                if (option == "B")
                {
                    NHANVIEN nv = new NhanVienBienChe();
                    try
                    { nv.Nhap(); List.Add(nv.MaNV, nv); }
                    catch { Console.WriteLine("-------------có thể bị trùng mã, nhập lại---------------------"); }
                }
                if (option == "H")
                {
                    NHANVIEN nv = new NhanVienHopDong();
                    try
                    { nv.Nhap(); List.Add(nv.MaNV, nv); }
                    catch { Console.WriteLine("-------------có thể bị trùng mã, nhập lại---------------------"); }
                }
            }
        }

        public void TongQuyLuong()
        {
            float sum1 = 0;
            float sum2 = 0;
            foreach (var item in List.Values)
            {
                if (item is NhanVienBienChe)
                {
                    float thuclinh = ((NhanVienBienChe)item).ThucLinh();
                    sum1 += thuclinh;
                }
                if (item is NhanVienHopDong)
                {
                    float thuclinh = ((NhanVienHopDong)item).ThucLinh();
                    sum2 += thuclinh;
                }
            }
            Console.WriteLine("Tổng quỹ Nhân viên Biên Chế " + sum1);
            Console.WriteLine("Tổng quỹ Nhân viên hợp đồng " + sum2);
        }

        public void Xuat()
        {
            foreach (var item in List.Values)
            {
                item.Xuat();
            }
        }

        public void Tim()
        {
            string manv;
            Console.WriteLine("------Mời nhập mã NV Cần tìm :"); manv =Console.ReadLine();
            bool temp = false;
            if (List.ContainsKey(manv) == true)
            {
                Console.WriteLine("------------Nhan Vien Can Tim la----------- : ");
                List[manv].Xuat();
                temp = true;
            }
            if (temp == false)
            {
                Console.WriteLine("----------Không có nhân viên này trong danh sách----------");
            }
        }
        //public void Sua()               // cách 1
        //{
        //    Console.WriteLine("--------------------------------------");
        //    Console.Write("Nhập mã bệnh nhân bạn cần sửa: ");
        //    string ma = Console.ReadLine();
        //    bool flag = false;
        //    foreach (BenhNhan x in Danhsach.Values)
        //    {
        //        if (x.MaBN == ma)
        //        {
        //            Console.WriteLine("Bạn muốn sửa ?");
        //            Console.WriteLine("1. Mã bệnh nhân");
        //            Console.WriteLine("2. Họ và tên");
        //            Console.WriteLine("3. Só ngày nhập viện");
        //            Console.WriteLine("4. Mã bảo hiểm");
        //            Console.WriteLine("0. Thoat");
        //            int key = Convert.ToInt32(Console.ReadLine());
        //            switch (key)
        //            {
        //                case 0:
        //                    return;
        //                case 1:
        //                    Console.WriteLine("Nhập mã bệnh nhân mới: ");
        //                    ma = Console.ReadLine();
        //                    while (check(ma) == true)
        //                    {
        //                        if (x.MaBN == ma)
        //                        {
        //                            break;
        //                        }
        //                        Console.WriteLine("Bạn không được nhập trùng mã bệnh nhân");
        //                        Console.WriteLine("Nhập mã bệnh nhân mới: ");
        //                        ma = Console.ReadLine();
        //                    }
        //                    x.MaBN = ma;
        //                    Console.WriteLine("Cập nhật thành công");
        //                    break;
        //                case 2:
        //                    Console.WriteLine("Nhập họ và tên bệnh nhân mới: ");
        //                    ma = Console.ReadLine();
        //                    x.HoTen = ma;
        //                    Console.WriteLine("Cập nhật thành công");
        //                    break;
        //                case 3:
        //                    Console.WriteLine("Nhập số ngày nhập viện mới: ");
        //                    int day = int.Parse(Console.ReadLine());
        //                    x.SoNgayNamVien = day;
        //                    Console.WriteLine("Cập nhật thành công");
        //                    break;
        //                case 4:
        //                    Console.WriteLine("Nhập mã bảo hiểm mới: ");
        //                    ma = Console.ReadLine();
        //                    if (x is BenhNhanBHXH)
        //                    {
        //                        ((BenhNhanBHXH)x).MaBHXH = ma;
        //                    }
        //                    else
        //                    {
        //                        ((BenhNhanBHYT)x).MaBHYT = ma;
        //                    }
        //                    Console.WriteLine("Cập nhật thành công");
        //                    break;
        //            }
        //            flag = true;
        //            break;
        //        }
        //    }
        //    if (flag == false)
        //    {
        //        Console.WriteLine("Không tìm thấy bệnh nhân cần sửa");
        //    }
        //    Console.WriteLine("--------------------------------------");
        //}

        public void Sua()     // Cách 2
        {
            string manv;
            Console.WriteLine("Mời nhập mã NV Cần Sửa"); manv = Console.ReadLine();
            bool temp = false;
            if (List.ContainsKey(manv) == true)
            {
                List[manv].Xuat();
                Console.WriteLine("-----------------------Mời bạn sửa thông tin của NV trên-----------------------");

                if (List[manv] is NhanVienBienChe)
                {
                    while (true)
                    {
                        NHANVIEN nv = new NhanVienBienChe();
                        nv.Nhap();
                        if (!List.ContainsKey(nv.MaNV))
                        {
                            List[manv] = nv;
                            temp = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("mã nhân viên bị trùng mời nhập lại");
                        }
                    }

                }
                else if (List[manv] is NhanVienHopDong)
                {
                    while (true)
                    {
                        NHANVIEN nv = new NhanVienHopDong();
                        nv.Nhap();
                        if (!List.ContainsKey(nv.MaNV))
                        {
                            List[manv] = nv;
                            temp = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("mã nhân viên bị trùng mời nhập lại");
                        }
                    }

                }
            }
            if (temp == false)
            {
                Console.WriteLine("----------Không có nhân viên này trong danh sách--------------");
            }
            else
            {
                Console.WriteLine("------------Nhân viên sau khi sửa là---------");

                List[manv].Xuat();
            }
        }

        public void Xoa()
        {
            string manv;
            Console.WriteLine("------Mời nhập mã NV Cần xóa----- :"); manv = Console.ReadLine();
            bool temp = false;
            if (List.ContainsKey(manv))
            {
                Console.WriteLine("------Đã xóa nhân viên có mã :" + manv + "ra khỏi danh sách---------");
                List.Remove(manv);
                temp = true;
            }
            if (temp == false)
            {
                Console.WriteLine("-------Không tim thấy nhân viên cần xóa----------");
            }
            else
            {
                this.Xuat();
            }
        }
        // Sửa cách 2
        /*
          public void Sua ()
        {
            
            RE10:
                Console.Write("Nhập mã nhân viên cần sửa: ");
                string ms = Console.ReadLine();
            int tim = 0;
            foreach (NhanVien item in NhanVien.Values)
                {
                
                if (item.MaNV == ms)
                {
                    tim = 1;
                    Boolean check1 = true;
                    while (check1)
                    {
                        Console.WriteLine("*******Bạn muốn sửa thông tin gì?******");
                        Console.WriteLine("0.Để thoát sửa\n1.Sửa mã NV\n2.Sửa tên nhân viên\n3.Sửa năm sinh\n4.Sửa giới tính nhân viên\n5.Sửa số CMND\n6.Sửa mức lương\n7.Sửa hệ số lương\n8.Sửa lương căn bản");

                        string options = Console.ReadLine();
                        switch (options)
                        {
                            case "0": check1 = false; break; 

                            case "1":
                            RE:
                                Console.Write("Nhập mã nhân viên mới: ");
                                string m1 = Console.ReadLine();
                                if (NhanVien.ContainsKey(m1))
                                {
                                    Console.WriteLine("************Mã nhân viên này đã tồn tại trong danh sách!Mời bạn nhập lại!************");
                                    goto RE;
                                }
                                else
                                {
                                    if (m1 != null && m1.Length > 0)
                                    {
                                        item.MaNV = m1;
                                        Console.WriteLine("Cập nhật thông tin thành công");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bạn phải nhập thông tin để cập nhật!");
                                        goto RE;
                                    }
                                }
                                

                                break;
                            case "2":
                            RE1:
                                Console.Write("Nhập tên nhân viên mới: ");
                                string m2 = Console.ReadLine();
                                if (m2 != null && m2.Length > 0)
                                {
                                    item.HoTen = m2;
                                    Console.WriteLine("Cập nhật thông tin thành công");
                                }
                                else
                                {
                                    Console.WriteLine("Bạn phải nhập thông tin để cập nhật!");
                                    goto RE1;
                                }

                                break;
                            case "3":
                            RE2:
                                Console.Write("Nhập năm sinh nhân viên mới: ");
                                string m3 = Console.ReadLine();
                                if (m3 != null && m3.Length > 0)
                                {
                                    item.NamSinh = m3;
                                    Console.WriteLine("Cập nhật thông tin thành công");
                                }
                                else
                                {
                                    Console.WriteLine("Bạn phải nhập thông tin để cập nhật!");
                                    goto RE2;
                                }

                                break;
                            case "4":
                            RE3:
                                Console.Write("Nhập giới tính nhân viên mới: ");
                                string m4 = Console.ReadLine();
                                if (m4 != null && m4.Length > 0)
                                {
                                    item.GioiTinh = m4;
                                    Console.WriteLine("Cập nhật thông tin thành công");
                                }
                                else
                                {
                                    Console.WriteLine("Bạn phải nhập thông tin để cập nhật!");
                                    goto RE3;
                                }

                                break;
                            case "5":
                            RE4:
                                Console.Write("Nhập số CMND nhân viên mới: ");
                                string m5 = Console.ReadLine();
                                if (m5 != null && m5.Length > 0)
                                {
                                    item.HoTen = m5;
                                    Console.WriteLine("Cập nhật thông tin thành công");
                                }
                                else
                                {
                                    Console.WriteLine("Bạn phải nhập thông tin để cập nhật!");
                                    goto RE4;
                                }

                                break;
                            case "6":

                                if (item is NVHD)
                                {
                                RE5:
                                    Console.Write("Nhập mức lương nhân viên mới: ");
                                    double m6 = 0;
                                    try
                                    {
                                        m6 = double.Parse(Console.ReadLine());

                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Bạn phải nhập thông tin để cập nhật!");
                                        goto RE5;
                                    }


                                        ((NVHD)item).MucLuong = m6;
                                    Console.WriteLine("Cập nhật thông tin thành công");

                                }
                                else Console.WriteLine("Đây không phải là nhân viên hợp đồng");
                                break;
                            case "7":

                                if (item is NVBC)
                                {
                                RE6:
                                    Console.Write("Nhập hệ số lương nhân viên mới: ");
                                    double m7 = 0;
                                    try
                                    {
                                        m7 = double.Parse(Console.ReadLine());
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Bạn phải nhập thông tin để cập nhật!");
                                        goto RE6;
                                    }


                                        ((NVBC)item).HeSoLuong = m7;
                                    Console.WriteLine("Cập nhật thông tin thành công");

                                }
                                else Console.WriteLine("Đây không phải là nhân viên chế");
                                break;
                            case "8":

                                if (item is NVBC)
                                {
                                RE7:
                                    Console.Write("Nhập lương cơ bản nhân viên mới: ");
                                    double m8 = 0;
                                    try
                                    {
                                        m8 = double.Parse(Console.ReadLine());
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Bạn phải nhập thông tin để cập nhật!");
                                        goto RE7;
                                    }


                                        ((NVBC)item).LuongCB = m8;
                                    Console.WriteLine("Cập nhật thông tin thành công");

                                }
                                else Console.WriteLine("Đây không phải là nhân viên biên chế");
                                break;

                        }
                    }
                }
                else tim = 0;

                
            }
            if (tim == 0)
            {
                Console.WriteLine("***************Nhân viên này không tồn tại!*********************");
                Console.WriteLine("Nhấn Enter để thoát hoặc nhập OK để nhập lại mã nhân viên");
                string mn = Console.ReadLine().ToUpper();
                if (mn == "OK")
                {
                    goto RE10;
                }
                
                    
            }
         */
    }
}
