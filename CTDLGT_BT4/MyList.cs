using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT4
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;
        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }
        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }
        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }
        public void Input()
        {
            int len = 0;
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);
                len++;
            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        //Show đảo ngược
        public void ReverseList()
        {
            IntNode p = first, prev = null, next = null;
            while (p != null)
            {
                next = p.Next;
                p.Next = prev;
                prev = p;
                p = next;
            }
            first = prev;
        }
        public IntNode SearchX(int x)
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data == x)
                {
                    return p;
                }
                p = p.Next;
            }
            return null;
        }
        public IntNode GetMax()
        {
            IntNode max = first;
            IntNode p = first.Next;
            while (p != null)
            {
                if (p.Data > max.Data)
                {
                    max = p;
                }
                p = p.Next;
            }
            return max;
        }
        public IntNode GetMin()
        {
            IntNode min = first;
            IntNode p = first.Next;
            while (p != null)
            {
                if (p.Data < min.Data && p.Data != 0)
                {
                    min = p;
                }
                p = p.Next;
            }
            return min;
        }
        public void GetEvenList()
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data % 2 == 0 && p.Data != 0)
                {
                    Console.Write($"{p.Data} -> ");
                }
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        //Tim node chan cuoi cung
        //public IntNode GetLastEven1()
        //{
        //    IntNode LastEven = first;
        //    for (IntNode p = first; p != null; p = p.Next)
        //    {
        //        if (p.Data % 2 == 0 && p.Data != 0)
        //            LastEven = p->key;
        //        p = p.Next;
        //    }
        //    return LastEven;
        //}
        public IntNode GetLastEven(int n)
        {
            int len = 0;
            IntNode p = last;
            while (p != null)
            {
                p = p.Next;
                len++;
            }
            for (int i = 1; i < len - n + 1; i++)
                p = p.Next;
            return p;
        }
        public void GetOddList()
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data % 2 != 0 && p.Data != 0)
                {
                    Console.Write($"{p.Data} -> ");
                }
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        public IntNode PrevNode(IntNode p)
        {
            if (p == first)
                return null;
            IntNode pTruoc = first;
            while (pTruoc.Next != p)
            {
                pTruoc = pTruoc.Next;
            }
            return pTruoc;
        }
        public bool RemoveFirst()
        {
            if (IsEmpty())
                return false;

            IntNode pDel = first;
            first = first.Next;
            pDel = null;

            if (first == null)
                last = null;
            return true;
        }
        public bool RemoveLast()
        {
            if (IsEmpty())
                return false;

            if (first == last)
                return RemoveFirst();

            IntNode pTruoc = PrevNode(last);
            last = null;
            last = pTruoc;
            return true;
        }
        public bool RemoveNode(IntNode p)
        {
            if (IsEmpty())
                return false;
            if (p == first)
                return RemoveFirst();
            if (p == last)
                return RemoveLast();
            IntNode pTruoc = PrevNode(p);
            pTruoc.Next = p.Next;
            p = null;
            return true;
        }
        public IntNode GetNode(int i)
        {
            int vt = 0;
            IntNode p = first;
            while (vt<i && p!=null)
            {
                vt++;
                p = p.Next;
            }
            if (vt == i)
                return p;
            return null;
        }
        public bool RemoveAt(int i)
        {
            IntNode P = GetNode(i);
            if (P == null)
                return false;
            return RemoveNode(P);
        }
        public void RemoveX(int x)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Danh sach rong");
            }
            IntNode temp = first;
            IntNode before = null;
            while (temp != null)
            {
                if (temp.Data == x)
                {
                    before.Next = temp.Next;
                }
                before = temp;
                temp = temp.Next;
            }
        }
        public void InsertAfterP(IntNode p, IntNode newNode)
        {
            if (p == last)
                AddLast(newNode);
            else
            {
                IntNode pSau = p.Next;
                newNode.Next = pSau;
                p.Next = newNode;
            }
        }
        public void HoanVi(IntNode a, IntNode b)
        {
            int tam = a.Data;
            a.Data = b.Data;
            b.Data = tam;
        }
        public void InsertBeforeP(IntNode p, IntNode newNode)
        {
            InsertAfterP(p, newNode);
            HoanVi(p, newNode);
        }
        public void InsertAt(int x, int i)
        {
            IntNode newNode = new IntNode(x);

            IntNode temp = first;
            IntNode before = null;
            int pos = 0;

            while (temp != null)
            {
                if (i == pos)
                {
                    before.Next = newNode;
                    newNode.Next = temp;
                    break;
                }
                before = temp;
                temp = temp.Next;
                pos++;
            }
        }
        public void InsertAfterMin(int x)
        {
            IntNode newNode = new IntNode(x);
            IntNode min = GetMin();
            InsertAfterP(min, newNode);
        }
        public void InsertAfterY(int x, int y)
        {
            IntNode newNode = new IntNode(x);
            if (SearchX(y) == null)
            {
                AddFirst(newNode);
            }
            IntNode pY = SearchX(y);
            if (pY != null) InsertAfterP(pY, newNode);
            else AddFirst(pY);
        }
        public void InsertXBeforeMax(int x)
        {
            IntNode newNode = new IntNode(x);
            IntNode max = GetMax();
            InsertBeforeP(max, newNode);
        }
        public void InsertBeforeY(int x, int y)
        {
            IntNode newNode = new IntNode(x);
            if (SearchX(y) == null)
            {
                AddFirst(newNode);
            }
            IntNode pY = SearchX(y);
            if (pY != null) InsertBeforeP(pY, newNode);
            else AddFirst(pY);
        }
        public void Sort()
        {
            IntNode p = first;
            IntNode pnext = null;
            int tam = 0;

            while (p != null)
            {
                pnext = p.Next;
                while (pnext != null)
                {
                    if (p.Data > pnext.Data)
                    {
                        tam = p.Data;
                        p.Data = pnext.Data;
                        pnext.Data = tam;
                    }
                    pnext = pnext.Next;
                }
                p = p.Next;
            }
        }
    }
}

