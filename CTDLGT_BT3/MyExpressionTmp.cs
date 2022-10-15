using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CTDLGT_BT3
{
    public class MyExpressionTmp
    {
        private string[] token;
        private List<string> postfix = new List<string>();
        private MyStack opStack;
        public string[] Token { get => token; set => token = value; }
        public List<string> Postfix { get => postfix; set => postfix = value; }
        internal MyStack OpStack { get => opStack; set => opStack = value; }
        public MyExpressionTmp()
        {
            postfix = new List<string>();
            opStack = new MyStack();
            token = new string[0];
        }

        public MyExpressionTmp(String[] obj)
        {
            Token = new String[obj.Length];
            opStack = new MyStack(Token.Length);
            for (int i = 0; i < obj.Length; i++)
            {
                Token[i] = obj[i];
            }
        }

        public bool IsOperator(string token)
        {
            return Regex.Match(token, @"+|-||/|%").Success;
        }
        public bool IsOperand(string token)
        {
            return Regex.Match(token, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }
        public int Precedence(string s)
        {
            if (s == "+" || s == "-")
            {
                return 1;
            }
            else if (s == "*" || s == "/" || s == "%")
            {
                return 2;
            }
            else return -1;
        }

        public void ToPostfix()
        {
            for (int i = 0; i < Token.Length; i++)
            {
                if (IsOperand(Token[i])) Postfix.Add(Token[i]);
                else if (Token[i] == "(") opStack.Push(Token[i]);
                else if (Token[i] == ")")
                {
                    while (opStack.Peek() != "(" && opStack.Count > 0) Postfix.Add(opStack.Pop());
                    opStack.Pop();
                }
                else
                {
                    while (opStack.Count > 0 && Precedence(Token[i]) <= Precedence(opStack.Peek())) Postfix.Add(opStack.Pop());
                    opStack.Push(Token[i]);
                }
            }

            while (opStack.Count > 0) Postfix.Add(opStack.Pop());
        }

        public double Value()
        {
            opStack = new MyStack(Postfix.Count);
            for (int i = 0; i < Postfix.Count; i++)
            {
                if (IsOperand(Postfix[i])) opStack.Push(Postfix[i]);
                else
                {
                    int b = int.Parse(opStack.Pop());
                    int a = int.Parse(opStack.Pop());
                    if (Postfix[i] == "+")
                    {
                        int temp = a + b;
                        opStack.Push(temp.ToString());
                    }
                    else if (Postfix[i] == "-")
                    {
                        int temp = a - b;
                        opStack.Push(temp.ToString());
                    }
                    else if (Postfix[i] == "/")
                    {
                        int temp = a / b;
                        opStack.Push(temp.ToString());
                    }
                    else if (Postfix[i] == "*")
                    {
                        int temp = a * b;
                        opStack.Push(temp.ToString());
                    }
                    else if (Postfix[i] == "%")
                    {
                        int temp = a % b;
                        opStack.Push(temp.ToString());
                    }
                }
            }
            return Double.Parse(opStack.Pop());
        }
    }
}
