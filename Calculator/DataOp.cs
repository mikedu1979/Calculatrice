using System;
using System.Collections.Generic;

namespace Calculator
{
    class DataOp : FrmMain
    {
        static Stack<double> m = new Stack<double>();
        static Stack<char> s = new Stack<char>();
        public static void Read()
        {
            for (int i = 0; i < inputStr.Count; i++)
            {
                if (!IsOperator(inputStr[i]))
                {
                    string s = null;
                    while (i < inputStr.Count && !IsOperator(inputStr[i]))
                    {
                        s += inputStr[i];
                        i++;
                    }
                    i--;
                    double mm = Convert.ToDouble(s);
                    m.Push(mm);
                }
                else if (IsOper(inputStr[i]))   //+ - * / 
                {
                    if (s.Count.Equals(0) || s.Peek().Equals('('))
                    {
                        s.Push(inputStr[i]);
                    }
                    else if (OperatorPrecedence(inputStr[i]) > OperatorPrecedence(s.Peek()))
                    {
                        s.Push(inputStr[i]);
                    }
                    else
                    {
                        double n1, n2;
                        char s1;
                        n2 = m.Pop();
                        n1 = m.Pop();
                        s1 = s.Pop();
                        double sum = Operat(n1, n2, s1);
                        m.Push(sum);
                        s.Push(inputStr[i]);
                    }
                }
                else
                {
                    if (inputStr[i].Equals('('))
                    {
                        s.Push(inputStr[i]);
                    }
                    else if (inputStr[i].Equals(')'))
                    {
                        while (!s.Peek().Equals('('))
                        {
                            double n1, n2;
                            char s1;
                            n2 = m.Pop();
                            n1 = m.Pop();
                            s1 = s.Pop();
                            double sum = Operat(n1, n2, s1);
                            m.Push(sum);
                        }
                        s.Pop();

                    }
                }
            }
        }
        public static double PopStack()
        {
            Stack<double> tepM = new Stack<double>();
            Stack<char> tepS = new Stack<char>();
            while (s.Count != 0)
            {
                char temp;
                temp = s.Pop();
                tepS.Push(temp);
            }

            while (m.Count != 0)
            {
                double temp;
                temp = m.Pop();
                tepM.Push(temp);
            }

            double sum = 0;
            while (tepS.Count != 0)
            {
                double n1, n2;
                char s1;
                n2 = tepM.Pop();
                n1 = tepM.Pop();
                s1 = tepS.Pop();
                sum = Operat(n2, n1, s1);
                tepM.Push(sum);
            }
            return sum;
        }
        public static bool IsOperator(char c)
        {
            if (c.Equals('+') || c.Equals('-') || c.Equals('*') || c.Equals('/') || c.Equals('(') || c.Equals(')'))
                return true;
            return false;
        }
        public static bool IsOper(char c)
        {
            if (c.Equals('+') || c.Equals('-') || c.Equals('*') || c.Equals('/'))
                return true;
            return false;
        }
        public static int OperatorPrecedence(char a)
        {
            int i = 0;
            switch (a)
            {
                case '+': i = 3; break;
                case '-': i = 3; break;
                case '*': i = 4; break;
                case '/': i = 4; break;
            }
            return i;
        }
        public static double Operat(double n1, double n2, char s1)
        {
            double sum = 0;
            switch (s1)
            {
                case '+': sum = n1 + n2; break;
                case '-': sum = n1 - n2; break;
                case '*': sum = n1 * n2; break;
                case '/': sum = n1 / n2; break;
            }
            return sum;
        }
        public static string DataMain()
        {
            Read();
            return PopStack().ToString();
        }
    }
}