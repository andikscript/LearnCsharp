#define PI

using LearnProject.Enum;
using System;
using LearnProject.Struct;
using LearnProject.Class;
using LearnProject.Inheritance;
using LearnProject.Polymorphism;
using LearnProject.Interface;
using LearnProject.TryCatch;
using LearnProject.FileStreamC;

namespace LearnProject
{
    public enum Bool
    {
        TRUE = 10,
        FALSE = 0,
    }
    class Program
    {
        static void Main()
        {
            var filest = new ReadWrite();
            filest.write();
            filest.read();
        }
        public void printDefine()
        {
#if (!PI)
            Console.WriteLine("PI is defined");
#else
            Console.WriteLine("PI is not defined");
#endif
            Console.WriteLine("end");
        }
    }

    class Running
    {
        public void swapRef(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }
        public void swapOut(out int x, out int y)
        {
            x = 10;
            y = 11;
        }

        public (String, int, String) retrn()
        {
            return ("a", 1323, "andik");
        }

        public void addParams(params int[] a)
        {
            Console.Write("[");
            foreach (int a2 in a)
            {
                Console.Write("{0}", String.Join("\n {0}", a2));
            }
            Console.Write("]");

            Array.Sort(a);
            foreach (int a2 in a)
            {
                Console.Write("{0}", String.Join("\n {0}", a2));
            }
            Console.Write("]");
        }
    }
}