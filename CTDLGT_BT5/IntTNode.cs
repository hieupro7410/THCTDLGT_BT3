using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BT5
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
        public void NLR()
        {
            Console.Write(Data + "; ");
            if (left != null)
                left.NLR();
            if (right != null)
                right.NLR();
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
        public IntTNode FindX(int x)
        {
            if (data == x)
                return this;
            if (x < data)
            {
                if (left == null)
                    return null;
                return left.FindX(x);
            }
            else
            {
                if (right == null)
                    return null;
                return right.FindX(x);
            }
        }
        public IntTNode RightMost()
        {
            if (right == null)
                return this;
            return right.RightMost();
        }
        public IntTNode LeftMost()
        {
            if (left == null)
                return this;
            return left.LeftMost();
        }
        public int MinValue()
        {
            if (left == null)
                return data;
            return left.MinValue();
        }
        public bool Remove(int x, IntTNode p)
        {
            if (x < this.data)
            {
                if (left != null)
                    return left.Remove(x, this);
                else
                    return false;
            }
            else if (x > this.data)
            {
                if (right != null)
                    return right.Remove(x, this);
                else
                    return false;
            }
            else
            {
                if (left != null && right != null)
                {
                    this.data = right.MinValue();
                    right.Remove(this.data, this);
                }
                else if (p.left == this)
                {
                    p.left = (left != null) ? left : right;
                }
                else if (p.right == this)
                {
                    p.right = (left != null) ? left : right;
                }
                return true;
            }

        }
    }
}
