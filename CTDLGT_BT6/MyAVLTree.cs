using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT6
{
    class MyAVLTree
    {
        private IntTNode root;

        private int count = 0;
        public IntTNode Root
        {
            get { return root; }
            set { root = value; }
        }

        public MyAVLTree()
        {
            Root = null;
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int Height()
        {
            if (root != null)
                return root.Height();
            else
                return 0;
        }

        public int CountNode
        {
            get
            {
                if (root == null)
                    return 0;
                return root.NumNote();
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
            Root.NRL();
            Console.WriteLine();
        }
        public void PreOrderLNR()
        {
            if (Root == null)
                return;
            Root.LNR();
            Console.WriteLine();
        }
        public void PreOrderLRN()
        {
            if (Root == null)
                return;
            Root.LRN();
            Console.WriteLine();
        }

        private IntTNode RecursiveInsert(IntTNode current, IntTNode n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.Data < current.Data)
            {
                current.Left = RecursiveInsert(current.Left, n);
                current = GetBalance(current);
            }
            else if (n.Data > current.Data)
            {
                current.Right = RecursiveInsert(current.Right, n);
                current = GetBalance(current);
            }
            return current;
        }

        private IntTNode GetBalance(IntTNode current)
        {
            int b_factor = GetBalanceFactor(current);
            if (b_factor > 1)
            {
                if (GetBalanceFactor(current.Left) > 0)
                {
                    current = RotateLeftLeft(current);
                }
                else
                {
                    current = RotateLeftRight(current);
                }
            }
            else if (b_factor < -1)
            {
                if (GetBalanceFactor(current.Right) > 0)
                {
                    current = RotateRightLeft(current);
                }
                else
                {
                    current = RotateRightRight(current);
                }
            }
            return current;
        }

        private int max(int l, int r)
        {
            return l > r ? l : r;
        }

        private int getHeight(IntTNode current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.Left);
                int r = getHeight(current.Right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }

        private int GetBalanceFactor(IntTNode current)
        {
            int l = getHeight(current.Left);
            int r = getHeight(current.Right);
            int b_factor = l - r;
            return b_factor;
        }

        private IntTNode RotateRightRight(IntTNode parent)
        {
            IntTNode pivot = parent.Right;
            parent.Right = pivot.Left;
            pivot.Left = parent;
            return pivot;
        }

        private IntTNode RotateLeftLeft(IntTNode parent)
        {
            IntTNode pivot = parent.Left;
            parent.Left = pivot.Right;
            pivot.Right = parent;
            return pivot;
        }

        private IntTNode RotateLeftRight(IntTNode parent)
        {
            IntTNode pivot = parent.Left;
            parent.Left = RotateRightRight(pivot);
            return RotateLeftLeft(parent);
        }

        private IntTNode RotateRightLeft(IntTNode parent)
        {
            IntTNode pivot = parent.Right;
            parent.Right = RotateLeftLeft(pivot);
            return RotateRightRight(parent);
        }

        public void RemoveX(int target)
        {
            root = RemoveX(root, target);
            count--;
        }

        private IntTNode RemoveX(IntTNode current, int target)
        {
            IntTNode parent;
            if (current == null)
            { return null; }
            else
            {
                if (target < current.Data)
                {
                    current.Left = RemoveX(current.Left, target);
                    if (GetBalanceFactor(current) == -2)
                    {
                        if (GetBalanceFactor(current.Right) <= 0)
                        {
                            current = RotateRightRight(current);
                        }
                        else
                        {
                            current = RotateRightLeft(current);
                        }
                    }
                }
                else if (target > current.Data)
                {
                    current.Right = RemoveX(current.Right, target);
                    if (GetBalanceFactor(current) == 2)
                    {
                        if (GetBalanceFactor(current.Left) >= 0)
                        {
                            current = RotateLeftLeft(current);
                        }
                        else
                        {
                            current = RotateLeftRight(current);
                        }
                    }
                }
                else
                {
                    if (current.Right != null)
                    {
                        parent = current.Right;
                        while (parent.Left != null)
                        {
                            parent = parent.Left;
                        }
                        current.Data = parent.Data;
                        current.Right = RemoveX(current.Right, parent.Data);
                        if (GetBalanceFactor(current) == 2)
                        {
                            if (GetBalanceFactor(current.Left) >= 0)
                            {
                                current = RotateLeftLeft(current);
                            }
                            else { current = RotateLeftRight(current); }
                        }
                    }
                    else
                    {
                        return current.Left;
                    }
                }
            }
            return current;
        }
    }
}
