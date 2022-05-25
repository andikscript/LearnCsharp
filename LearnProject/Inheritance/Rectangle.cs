using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnProject.Interface;

namespace LearnProject.Inheritance
{
    internal class Rectangle : Shape, PaintCost
    {
        // base artinya seperti super di java dan di inheritance ke construktor terlebih dahulu jika
        // ingin memakainya, jika parameter constructor induk kosong maka dikosongkan cukup dengan menulis base()
        // jika ada parameternya maka diisi sesuai nama constructor kelas induknya. misal base(width, height)
        public Rectangle(int width, int height) : base() 
        {
            base.width = width;
            base.height = height;
        }
        public int getArea()
        {
            return width * height;
        }

        public int getCost(int area)
        {
            return area * 100;
        }
    }
}
