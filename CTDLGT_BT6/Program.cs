using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT6
{
    class Program
    {
        static void TestInput()
        {
            MyAVLTree root = new MyAVLTree();
            root.Input();
            Console.WriteLine();
            Console.Write("Duyet cay theo thu tu NRL: ");
            root.PreOrder();
            Console.WriteLine();

            Console.Write("Duyet cay theo thu tu LNR: ");
            root.PreOrderLNR();
            Console.WriteLine();

            Console.Write("Duyet cay theo thu tu LRN: ");
            root.PreOrderLRN();
            Console.WriteLine();

            Console.Write("So luong phan tu trong cay: {0}\n", root.CountNode);

            Console.Write("Chieu cao cua cay: {0}\n", root.Height());

            Console.Write("Nhap gia tri can xoa: ");
            int x = int.Parse(Console.ReadLine());
            root.RemoveX(x);
            Console.WriteLine();
            Console.WriteLine($"Cay sau khi xoa gia tri {x}: ");
            root.PreOrderLNR();
            Console.WriteLine();

            Console.Write("So luong phan tu trong cay sau khi xoa: {0}\n", root.CountNode);

            Console.Write("Chieu cao cua cay sau khi xoa: {0}\n", root.Height());
        }
        static void Main(string[] args)
        {
            TestInput();
            Console.ReadKey();
        }
    }
}
