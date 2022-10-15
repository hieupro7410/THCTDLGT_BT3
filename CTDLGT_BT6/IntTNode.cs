using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BT6
{
    class IntTNode
    {
        private int data;
        private IntTNode left;
        private IntTNode right;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public IntTNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public IntTNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public IntTNode(int x = 0)
        {
            data = x;
            left = null;
            right = null;
        }

        public bool InsertNode(int x)
        {
            if (data == x)
                return false;
            if (data > x)
            {
                if (left == null)
                    left = new IntTNode(x);
                else
                    return left.InsertNode(x);
            }
            else
            {
                if (right == null)
                    right = new IntTNode(x);
                else
                    return right.InsertNode(x);
            }
            return true;
        }
        public int NumNote()
        {
            int d1 = 0, d2 = 0;
            if (left != null)
                d1 = left.NumNote();
            if (right != null)
                d2 = right.NumNote();
            return 1 + d1 + d2;
        }
        public int Height()
        {
            int l = 0;
            int r = 0;
            if (left != null)
            {
                l = left.Height();
            }
            if (right != null)
            {
                r = right.Height();
            }
            return 1 + Math.Max(l, r);
        }
        public int CountLeaf()
        {
            int d1 = 0, d2 = 0;
            if (left == null && right == null)
                return 1;
            if (left != null)
                d1 = left.CountLeaf();
            if (right != null)
                d2 = right.CountLeaf();
            return d1 + d2;
        }
        public void NRL()
        {
            Console.Write(Data + "; ");
            if (right != null)
                right.NRL();
            if (left != null)
                left.NRL();
        }
        public void LNR()
        {
            if (left != null)
                left.LNR();
            Console.Write(Data + "; ");
            if (right != null)
                right.LNR();
        }
        public void LRN()
        {
            if (left != null)
                left.LRN();
            if (right != null)
                right.LRN();
            Console.Write(Data + "; ");
        }
    }
}
