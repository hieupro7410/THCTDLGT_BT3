using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BT1
{
    class MangSinhVien
    {
        static List<SinhVien> dsSinhVien = new List<SinhVien>();
        private int n;
        public void Nhap()
        {
            Console.Write("So sinh vien ban muon nhap: ");
     nhapn: n = int.Parse(Console.ReadLine());
            while (n < 1 & n > 1000000)
            {
                Console.WriteLine("So luong khong phu hop");
                Console.Write("Nhap lai so luong: ");
                goto nhapn;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.Nhap();
                while (TonTai(sv.maSo, i) == true)
                {
                    Console.WriteLine("Ma so sv bi trung, vui long nhap lai!");
                    sv.Nhap();
                }
                dsSinhVien[i] = sv;
                dsSinhVien.Add(sv);
            }
        }
        //Kiem tra tru
        public bool TonTai(string msx, int vt)
        {
            for (int i = 0; i < vt; i++)
            {
                if (dsSinhVien[i].maSo.CompareTo(msx) == 0)
                    return true;
            }
            return false;
        }
        public void SelectionSort()
        {
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (dsSinhVien[j] < dsSinhVien[min])
                        min = j;
                HoanVi(ref arr[i], ref arr[min]);
            }
        }
        public void Xuat()
        {
            foreach (SinhVien sinhVien in dsSinhVien)
            {

                sinhVien.Xuat();
            }
        }
    }
}
