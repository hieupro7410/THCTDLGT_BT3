using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BT5
{
    class MyBinaryTree
    {
        private IntTNode root;
        public IntTNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public MyBinaryTree()
        {
            Root = null;
        }
        public int Count
        {
            get
            {
                if (root == null)
                    return 0;
                return root.NumNote();
            }
        }
        public int Height
        {
            get
            {
                if (root == null)
                    return 0;
                return root.Height();
            }
        }
        public bool Insert(int x)

        {
            if (Root == null)
            {
                Root = new IntTNode(x);
                return true;
            }
            return Root.InsertNode(x);
        }
        public void Input()
        {
            do
            {
                int x;
                Console.Write("Nhap vao gia tri (trung ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (Insert(x) == true)
                    Console.WriteLine("Da them gia tri vao cay");
                else
                {
                    Console.WriteLine("Ket thuc!\n");
                    return;
                }
            } while (true);
        }
        public void PreOrder()
        {
            if (Root == null)
                return;
            Root.NLR();
            Console.WriteLine();
        }
        public void InOrder()
        {
            if (Root == null)
                return;
            Root.LNR();
            Console.WriteLine();
        }
        public void PostOrder()
        {
            if (Root == null)
                return;
            Root.LRN();
            Console.WriteLine();
        }
        public void NumNote()
        {
            if (Root == null)
                return;
            Console.WriteLine(Root.NumNote());
        }

        public IntTNode FindX(int x)
        {
            if (root == null)
                return null;
            return root.FindX(x);
        }
        public IntTNode FindMax()
        {
            if (root == null)
                return null;
            return root.RightMost();
        }
        public IntTNode FindMin()
        {
            if (root == null)
                return null;
            return root.LeftMost();
        }
        public bool RemoveX(int x)
        {
            if (root == null)
                return false;
            if (root.Data == x)
            {
                IntTNode t = new IntTNode(0);
                t.Left = root;
                bool kq = root.Remove(x, t);
                root = t.Left;
                return kq;
            }
            return root.Remove(x, null);
        }
    }
}
