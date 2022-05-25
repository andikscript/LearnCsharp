using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Polymorphism
{
    internal class StaticPolymorpishm
    {
        public void print(int a)
        {
            Console.WriteLine(a);
        }

        public void print(double b)
        {
            Console.WriteLine(b);
        }

        public void print(string s)
        {
            Console.WriteLine(s);
        }

        public string print()
        {
            return "static polymorphism";
        }
    }
}
