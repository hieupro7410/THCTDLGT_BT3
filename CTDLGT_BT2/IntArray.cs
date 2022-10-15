using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BT2
{
    public class IntArray
    {
        private int[] arr;
        public int[] A { get => arr; set => arr = value; }
        public int this[int i] { get => arr[i]; set => arr[i] = value; }
        public int Size { get => arr.Length; }

        //Default
        public IntArray()
        {
            arr = new int[0];
        }

        //Parameter 1
        public IntArray(int k)
        {
            arr = new int[k];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 200);
            }
        }
        //Parameter 2
        public IntArray(int[] a)
        {
            int n = a.Length;
            arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = a[i];
        }
        //Copy
        public IntArray(IntArray obj)
        {
            int n = obj.arr.Length;
            arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = obj[i];
        }

        //Kiem tra mang
        public bool KiemTraKT(int n)
        {
            if (n > 0 & n < 1000000)
                return true;
            return false;
        }

        //Nhap mang
        public void NhapMang()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Phan tu tai vi tri {0} = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        //Xuat mang
        public void XuatMang()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        //Linear Search
        public int LinearSearch(int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        //Minh hoa Linear Search
        public void MHLinearSearch(int x)
        {
            int SS = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0} so voi {1}", x, arr[i]);
                SS++;
                Console.Write("Doan can tim tiep theo: ");
                Console.WriteLine(i + " -> " + (arr.Length - 1));
                if (arr[i] == x)
                {
                    break;
                }
            }
            Console.WriteLine(">>So phep so sanh: {0}", SS);
        }

        //Tim kiem bang phuong phap nhi phan
        public int BinarySearch(int x)
        {
            int left = 0;
            int right = arr.Length;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] < x)
                    left = mid + 1;
                if (arr[mid] > x)
                    right = right - 1;
            }
            return -1;
        }

        //Tang ngau nhien
        public int[] PhatSinhNgauNhienTang(int k)
        {
            arr = new int[k];
            Random r = new Random();
            arr[0] = r.Next(1, 200);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i + 1] = arr[i] + r.Next(1, 200);
            }
            return arr;
        }

        //Minh hoa Binary Search
        public void MHBinarySearch(int x)
        {
            int L = 0;
            int R = arr.Length;
            int SS = 0;
            while (L <= R)
            {
                int mid = (L + R) / 2;
                Console.WriteLine("{0} so voi {1}", x, arr[mid]);
                if (arr[mid] == x)
                    break;
                if (arr[mid] < x)
                {
                    L = mid + 1;
                    Console.Write("Doan can tim tiep theo: ");
                    Console.WriteLine(L + " -> " + (R - 1));
                }
                if (arr[mid] > x)
                {
                    R = R - 1;
                    Console.Write("Doan can tim tiep theo: ");
                    Console.WriteLine(L + " -> " + (R - 1));
                }
                SS++;
            }
            Console.WriteLine(">>So phep so sanh: {0} ", SS);
        }

        //Hoan vi
        public void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }

        //Interchange Sort
        public void InterchangeSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] > arr[j])
                    {
                        HoanVi(ref arr[i], ref arr[j]);
                    }
        }

        //Minh họa Interchange Sort
        public void MHInterchangeSort()
        {
            int HV = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] > arr[j])
                    {
                        Console.WriteLine("{0} doi cho voi {1}", arr[i], arr[j]);
                        HV++;
                        HoanVi(ref arr[i], ref arr[j]);
                    }
            Console.WriteLine(">>So phep hoan vi: {0} ", HV);
        }


        //Bubble Sort
        public void BubbleSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        HoanVi(ref arr[j], ref arr[j + 1]);
                    }
        }

        //Minh hoa Bubble Sort
        public void MHBubbleSort()
        {
            int HV = 0;
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        Console.WriteLine("{0} doi cho voi {1}", arr[j], arr[j + 1]);
                        HV++;
                        HoanVi(ref arr[j], ref arr[j + 1]);
                    }
            Console.WriteLine(">>So phep hoan vi: {0} ", HV);
        }

        //Selection Sort
        public void SelectionSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;
                HoanVi(ref arr[i], ref arr[min]);
            }
        }

        //Minh hoa Selection Sort
        public void MHSelectionSort()
        {
            int HV = 0;
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;
                Console.WriteLine("{0} doi cho voi {1}", arr[i], arr[min]);
                HV++;
                HoanVi(ref arr[i], ref arr[min]);
            }
            Console.WriteLine(">>So phep hoan vi: {0} ", HV);
        }

        //Insertion Sort
        public void InsertionSort()
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        //Quick Sort
        public void QuickSort(int left, int right)
        {
            int i = left;
            int j = right;
            int x = arr[(i + j) / 2];
            while (i < j)
            {
                while (arr[i] < x)
                    i++;
                while (arr[j] > x)
                    j--;
                if (i <= j)
                {
                    HoanVi(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }
            if (left < j)
                QuickSort(left, j);
            if (i < right)
                QuickSort(i, right);
        }

        //Minh hoa Quick Sort
        public void MHQuickSort(int left, int right)
        {
            int HV = 0;
            int i = left;
            int j = right;
            int x = arr[(i + j)] / 2;
            while (i < j)
            {
                while (arr[i] < x)
                    i++;
                while (arr[j] > x)
                    j--;
                if (i <= j)
                {
                    Console.WriteLine("{0} doi cho voi {1}", arr[i], arr[j]);
                    HV++;
                    HoanVi(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }
            if (left < j)
                QuickSort(left, j);
            if (i < right)
                QuickSort(i, right);
            Console.WriteLine(">>So phep hoan vi: {0} ", HV);
        }
    }
}
