using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Polymorphism
{
    internal class RectangleVirtual : DynamicPolymorphismVirtual
    {
        public RectangleVirtual(int width, int height) : base(width, height) { }

        public override int area()
        {
            Console.WriteLine("Rectangle Area");
            return width * height;
        }
    }
}
