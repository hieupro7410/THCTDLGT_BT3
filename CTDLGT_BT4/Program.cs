using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_BT4
{
    internal class Program
    {
        static void TestInput()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();

            //TIM X
            Console.Write("nhap x: ");
            int x = int.Parse(Console.ReadLine());
            IntNode kq = list.SearchX(x);
            if (kq == null)
            {
                Console.WriteLine($"khong tim thay phan tu {x}");
            }
            else
            {
                Console.WriteLine($"Tim thay phan tu {x}");
            }

            //MIN
            Console.WriteLine($"gia tri lon nhat: {list.GetMax().Data}");

            //MAX
            Console.WriteLine($"gia tri nho nhat: {list.GetMin().Data}");

            //DS SO CHAN
            Console.WriteLine("DS so chan:");
            list.GetEvenList();

            //DS SO LE
            Console.WriteLine("DS so le:");
            list.GetOddList();

            //REMOVE AT
            Console.WriteLine("remove At");
            Console.Write("nhap vi tri can xoa: ");
            int a = int.Parse(Console.ReadLine());
            list.RemoveAt(a);
            Console.WriteLine("Danh sach sau khi remove: ");
            list.ShowList();

            //REMOVE X
            Console.WriteLine("remove X");
            Console.Write("nhap X can xoa: ");
            int b = int.Parse(Console.ReadLine());
            list.RemoveX(b);
            Console.WriteLine("Danh sach sau khi remove: ");
            list.ShowList();

            //INSERT AT
            Console.WriteLine("Insert At");
            Console.Write("Nhap gia tri can chen: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("nhap vi tri can chen: ");
            int d = int.Parse(Console.ReadLine());
            list.InsertAt(c, d);
            Console.WriteLine("Danh sach sau khi chen:");
            list.ShowList();

            //INSERT AFTER MIN
            Console.WriteLine("Insert After Min");
            Console.Write("nhap gia tri can chen: ");
            int e = int.Parse(Console.ReadLine());
            list.InsertAfterMin(a);
            Console.WriteLine("Danh sach sau khi chen:");
            list.ShowList();

            //INSERT AFTER Y
            Console.WriteLine("Insert After Y");
            Console.Write("nhap gia tri can chen: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("nhap y: ");
            int g = int.Parse(Console.ReadLine());
            list.InsertAfterY(b, c);
            Console.WriteLine("Danh sach sau khi chen:");
            list.ShowList();

            //INSERT BEFORE MAX
            Console.WriteLine("Insert X Before Max");
            Console.Write("nhap gia tri can chen: ");
            int h = int.Parse(Console.ReadLine());
            list.InsertXBeforeMax(h);
            Console.WriteLine("Danh sach sau khi chen:");
            list.ShowList();

            //INSERT BEFORE Y
            Console.WriteLine("Insert X Before Y");
            Console.Write("nhap gia tri can chen: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("nhap y: ");
            int j = int.Parse(Console.ReadLine());
            list.InsertBeforeY(i, j);
            Console.WriteLine("Danh sach sau khi chen:");
            list.ShowList();

            //SORT
            Console.WriteLine("Sort");
            list.Sort();
            Console.WriteLine("Danh sach sau khi sap xep: ");
            list.ShowList();
        }

        static void reserve()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            Console.WriteLine("DSLK dao nguoc: ");
            list.ReverseList();
            list.ShowList();
        }

        static void Main(string[] args)
        {
            TestInput();
            Console.ReadKey();
        }

    }
}
