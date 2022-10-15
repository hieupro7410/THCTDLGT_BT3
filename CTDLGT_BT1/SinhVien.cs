using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BT1
{
    class SinhVien
    {
        //Khai báo các thuộc tính, get/set
        public string maSo { get; set; }
        public string hoTen { get; set; }
        public string chuyenNganh { get; set; }
        public int namSinh { get; set; }
        public double diemTB { get; set; }
        public string loai { get; set; }

        //Default
        public SinhVien()
        {
            maSo = " ";
            hoTen = " ";
            chuyenNganh = " ";
            namSinh = 0;
            diemTB = 0;
            loai = " ";
        }

        //Parameter
        public SinhVien(string ms, string ht, string cn, int ns, double dtb)
        {
            this.maSo = ms;
            this.hoTen = ht;
            this.chuyenNganh = cn;
            this.namSinh = ns;
            this.diemTB = dtb;
        }

        //Copy
        public SinhVien(SinhVien svC)
        {
            maSo = svC.maSo;
            chuyenNganh = svC.chuyenNganh;
            namSinh = svC.namSinh;
        }

        //Nhap thông tin cho svC
        public void NhapC()
        {

            Console.Write("Ho ten SV: ");
            hoTen = Console.ReadLine();
            Console.Write("Diem trung binh tich luy: ");
        diemTB: diemTB = double.Parse(Console.ReadLine());
            //KiemTraDiemTB(diemTB);
            while (KiemTraDiemTB(diemTB) == false)
            {
                Console.WriteLine("Diem tb khong phu hop");
                Console.Write("Nhap lai diem trung binh: ");
                goto diemTB;
            }
        }

        //Kiểm tra ràng buộc tuổi
        public bool KiemTraNamSinh(int ns)
        {
            int age = DateTime.Now.Year - ns;
            if (age >= 17 & age <= 70)
                return true;
            else return false;
        }

        //Kiểm tra ràng buộc điểm
        public bool KiemTraDiemTB(double dtb)
        {
            if (dtb >= 0 & dtb <= 10)
                return true;
            else return false;
        }

        //Nhập thông tin sinh viên
        public void Nhap()
        {
            Console.Write("Ma so SV: ");
            maSo = Console.ReadLine();
            Console.Write("Ho ten SV: ");
            hoTen = Console.ReadLine();
            Console.Write("Chuyen nganh: ");
            chuyenNganh = Console.ReadLine();
            Console.Write("Nam sinh: ");
        tuoi: namSinh = int.Parse(Console.ReadLine());
            //KiemTraNamSinh(namSinh);
            while (KiemTraNamSinh(namSinh) == false)
            {
                Console.WriteLine("Nam sinh khong phu hop");
                Console.Write("Nhap lai nam sinh: ");
                goto tuoi;
            }
            Console.Write("Diem trung binh tich luy: ");
        diemTB: diemTB = double.Parse(Console.ReadLine());
            //KiemTraDiemTB(diemTB);
            while (KiemTraDiemTB(diemTB) == false)
            {
                Console.WriteLine("Diem tb khong phu hop");
                Console.Write("Nhap lai diem trung binh: ");
                goto diemTB;
            }
        }

        //Xuất thông tin sinh viên
        public void Xuat()
        {
            Console.Write("ma so: {0}, " +
                " ho ten: {1}," +
                " chuyen nganh: {2}," +
                " nam sinh: {3}," +
                " diem tb: {4}, ", maSo, hoTen, chuyenNganh, namSinh, diemTB);
            XepLoai();
        }

        //Xếp loại
        public void XepLoai()
        {
            Console.Write("xep loai: ");
            if (diemTB < 5)
                Console.WriteLine("Kem");
            else
            {
                if (diemTB < 7)
                    Console.WriteLine("Trung binh");
                else
                {
                    if (diemTB < 8)
                        Console.WriteLine("Kha");
                    else Console.WriteLine("Gioi");
                }
            }
        }
    }
}
