using System;

namespace CTDLGT_BT2
{
    class Program
    {
        //Test phuong phap tim kiem tuan tu
        static void TestLinearSearch(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Cac phan tu:");
            objTam.XuatMang();
            Console.Write("\n>>Gia tri can tim x = ");
            int x = int.Parse(Console.ReadLine());
            int kq = objTam.LinearSearch(x);
            objTam.MHLinearSearch(x);
            if (kq == -1)
                Console.WriteLine("->Khong ton tai {0}!", x);
            else
                Console.WriteLine("->Co {0} tai vi tri {1}", x, kq);

        }

        //Test phương pháp tìm nhị phân
        static void TestBinarySearch(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            objTam.PhatSinhNgauNhienTang(10);
            Console.WriteLine("\n>>Cac phan tu:");
            objTam.XuatMang();
            Console.Write("\n>>Gia tri can tim x = ");
            int x = int.Parse(Console.ReadLine());
            int kq = objTam.BinarySearch(x);
            objTam.MHBinarySearch(x);
            if (kq == -1)
                Console.WriteLine("-> Khong ton tai {0}!", x);
            else
                Console.WriteLine("-> Co {0} tai vi tri {1}", x, kq);
        }

        //Test Interchange Sort
        static void TestInterchangeSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.XuatMang();
            objTam.MHInterchangeSort();
            objTam.InterchangeSort();
            Console.WriteLine("\n>>Interchange Sort:");
            objTam.XuatMang();

        }

        //Test Bubble Sort
        static void TestBubbleSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.XuatMang();
            objTam.MHBubbleSort();
            objTam.BubbleSort();
            Console.WriteLine("\n>>Bubble Sort:");
            objTam.XuatMang();
        }

        //Test Selection Sort
        static void TestSelectionSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.XuatMang();
            obj.MHSelectionSort();
            objTam.SelectionSort();
            Console.WriteLine("\n>>Selection Sort:");
            objTam.XuatMang();
        }

        //Test Insertion Sort
        static void TestInsertionSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.XuatMang();
            objTam.InsertionSort();
            Console.WriteLine("\n>>Insertion Sort:");
            objTam.XuatMang();
        }

        //Test Quick Sort
        static void TestQuickSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.XuatMang();
            //objTam.MHQuickSort(0, 10);
            objTam.QuickSort(0, 10);
            Console.WriteLine("\n>>Quick Sort:");
            objTam.XuatMang();
        }

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            Console.ReadKey();
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Bai tap 2:");
            Console.WriteLine("1- Test Linear Search");
            Console.WriteLine("2- Test Binary Search");
            Console.WriteLine("3- Test Interchange Sort");
            Console.WriteLine("4- Test Bubble Sort");
            Console.WriteLine("5- Test Selection Sort");
            Console.WriteLine("6- Test Insertion Sort");
            Console.WriteLine("7- Test Quick Sort");
            Console.WriteLine("8- Thoat Chuong trinh");
            Console.Write("Ban chon:");
            
            switch (Console.ReadLine())
            {
                case "1":
                    IntArray obj1 = new IntArray(10);
                    TestLinearSearch(obj1);
                    Console.ReadKey();
                    return true;
                case "2":
                    IntArray obj2 = new IntArray(10);
                    TestBinarySearch(obj2);
                    Console.ReadKey();
                    return true;
                case "3":
                    IntArray obj3 = new IntArray(10);
                    TestInterchangeSort(obj3);
                    Console.ReadKey();
                    return true;
                case "4":
                    IntArray obj4 = new IntArray(10);
                    TestBubbleSort(obj4);
                    Console.ReadKey();
                    return true;
                case "5":
                    IntArray obj5 = new IntArray(10);
                    TestSelectionSort(obj5);
                    Console.ReadKey();
                    return true;
                case "6":
                    IntArray obj6 = new IntArray(10);
                    TestInsertionSort(obj6);
                    Console.ReadKey();
                    return true;
                case "7":
                    IntArray obj7 = new IntArray(10);
                    TestQuickSort(obj7);
                    Console.ReadKey();
                    return true;
                case "8":
                    return false;
                default:
                    return true;
            }

        }
    }
}
