using System;

namespace CTDLGT_BT3
{
    class Program
    {
        static void TestMyStack()
        {
            MyStack stack = new MyStack();
            stack.Input();
            stack.GetStack();
            Console.Write("Nhap x: ");
            string x = Console.ReadLine();
            stack.Contains(x);
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Peek());
            stack.GetStack();
            System.Console.WriteLine(stack.Push("i"));
            stack.GetStack();
        }
        static void TestMyExpressionTmp()
        {
            string[] token = { "(", "(", "10", "+", "4", ")", "*", "2", "+", "(", "20", "/", "5", "-", "3", ")", ")", "%", "3" };
            MyExpressionTmp myExp = new MyExpressionTmp(token);
            myExp.ToPostfix();
            double kq = myExp.Value();
            System.Console.WriteLine(kq);
        }
        static void Main(string[] args)
        {
            //TestMyStack();
            TestMyExpressionTmp();
            Console.ReadKey();
        }
    }
}
