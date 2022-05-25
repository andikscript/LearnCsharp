using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Polymorphism
{
    public class RectangleDynamic: DynamicPolymorphism
    {
        private int width;
        private int height;
        public RectangleDynamic(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        // fungsi override adalah fungsi yang pewarisan dari kelas induk abstrak
        // dan wajib di tulis ulang di anak
        public override int area()
        {
            Console.WriteLine("Rectangle Class Area");
            return width * height;
        }

        public int perimeter()
        {
            return (width + height) * 2;
        }
    }
}
