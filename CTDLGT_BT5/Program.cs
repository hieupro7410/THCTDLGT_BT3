using System;

namespace CTDLGT_BT5
{
    class Program
    {
        static MyBinaryTree root = new MyBinaryTree();
        static void TestInput()
        {
            root.Input();
            Console.Write("Duyet cay theo thu tu NLR: ");
            root.PreOrder();

            Console.Write("Duyet cay theo thu tu LNR: ");
            root.InOrder();

            Console.Write("Duyet cay theo thu tu LRN: ");
            root.PostOrder();
            Console.WriteLine();
        }
        static void TestCount()
        {
            Console.WriteLine("So luong phan tu trong cay: {0}\n", root.Count);
        }
        static void TestHeight()
        {
            Console.WriteLine("Chieu cao cua cay: {0}\n", root.Height);
        }
        static void TestCountLeaf()
        {
            Console.WriteLine("So luong node la trong cay: {0}\n", root.Root.CountLeaf());
        }
        static void TestFindX()
        {
            MyBinaryTree root = new MyBinaryTree();
            Console.Write("Tim node co gia tri: x = ");
            int x = int.Parse(Console.ReadLine());
            if (root.FindX(x) == null)
                Console.WriteLine("Khong tim thay gia tri x = {0}", x);
            else
                Console.WriteLine("Tim thay gia tri x = {0} tai node = {1}", x, root.FindX(x).Data);
                
        }
        static void TestFindMaxMin()
        {
            Console.WriteLine("Gia tri lon nhat la: {0}\nGia tri nho nhat la: {1}\n", root.FindMax().Data, root.FindMin().Data);
        }
        static void TestRemove()
        {
            Console.Write("Nhap gia tri can xoa: ");
            int x = int.Parse(Console.ReadLine());
            if (root.RemoveX(x))
            {
                Console.WriteLine("Da xoa phan tu!");
                Console.Write("Sau khi xoa: ");
                root.PreOrder();
            }
            else
            {
                Console.WriteLine("Khong tim thay gia tri!");
            }
        }
        static void Main(string[] args)
        {
            TestInput();
            TestCount();
            TestHeight();
            TestCountLeaf();
            TestFindX();
            TestFindMaxMin();
            TestRemove();
            Console.ReadKey();
        }
    }
}

