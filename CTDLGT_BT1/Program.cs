using System;

namespace CTDLGT_BT1
{
    class Program
    {
        static void TestSinhVien()
        {
            SinhVien svA = new SinhVien();
            svA.Nhap();
            Console.Write("Thong tin svA: ");
            svA.Xuat();

            SinhVien svB = new SinhVien("18DH001", "Lam Thanh Ngoc", "CNPM", 2000, 7.6);

            SinhVien svC = new SinhVien(svB);
            svC.NhapC();
            Console.WriteLine("thong tin svC: ");
            svC.Xuat();
            Console.WriteLine("thong tin svB: ");
            svB.Xuat();
        }
        static void TestMangSinhVien()
        {
            MangSinhVien dssv = new MangSinhVien();
            dssv.Nhap();
            dssv.TonTai();
            Console.WriteLine("Danh sach sinh vien:");
            dssv.Xuat();
        }

        static void Main(string[] args)
        {
            TestSinhVien();
            TestMangSinhVien();
            Console.ReadKey();
        }
    }
}

