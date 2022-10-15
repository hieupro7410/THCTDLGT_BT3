using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_BT3
{
    class MyStack
    {
        private int stkMax;
        private int stkTop;
        private string[] stkArray;

        //Các properties get/ set
        public int StkMax { get; set; }
        public int StkTop { get; set; }
        public string[] StkArray
        {
            get { return stkArray; }
            set { stkArray = value; }
        }
        public int Count { get => stkTop + 1; }
        public String this[int index]
        {
            get { return stkArray[index]; }
            set { stkArray[index] = value; }
        }

        //Constructors
        public MyStack() { }

        public MyStack(int maxItem = 0)
        {
            StkMax = maxItem;
            stkArray = new string[StkMax];
            stkTop = -1;
        }
        public MyStack(MyStack s)
        {
            //Định nghĩa copy constructor
            stkArray = new String[s.stkArray.Length];
            for (int i = 0; i < stkArray.Length; i++)
                stkArray[i] = s.stkArray[i];
        }

        //Các phương thức
        public bool IsEmpty()
        {
            if (StkTop == -1)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (StkTop == StkMax - 1)
                return true;
            return false;
        }

        public String Pop()
        {
            if (IsEmpty()) return null;
            else
            {
                String data = stkArray[stkTop];
                stkTop--;
                return data;
            }
        }

        public bool Push(string newitem)
        {
            if (IsFull())
                return false;
            StkTop++;
            StkArray[StkTop] = newitem;
            return true;
        }

        public String Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return stkArray[StkTop];
        }

        public void Clear()
        {
            stkTop = -1;
        }

        public void Contains(string x)
        {
            for (int i = 0; i <= stkArray.Length; i++)
            {
                if (stkArray[i] == x)
                    Console.WriteLine("Chua x");
            }
            Console.WriteLine("Khong chua x");
        }

        public void Input()
        {
            List<String> token = new List<String>();
            System.Console.WriteLine("Nhap lan luot cac ky tu: ");
            System.Console.WriteLine("Nhan \".\" de dung nhap!");
            string s; stkMax = 0;
            do
            {
                stkMax++;
                s = Console.ReadLine();
                token.Add(s);
                StkTop++;
            }
            while (s != "d");

            stkArray = new String[stkMax];

            for (int i = 0; i <= stkMax; i++)
            {
                stkArray[i] = token[i];
            }
        }

        public void GetStack()
        {
            String token = "";

            if (StkTop < 0) token = "Stack rong";
            else
            {
                for (int i = stkTop; i >= 0; i--)
                {
                    token += stkArray[i];
                }
            }

            System.Console.WriteLine(token);
        }
    }
}
