using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Polymorphism
{
    internal class DynamicPolymorphismVirtual
    {
        protected int width;
        protected int height;
        public DynamicPolymorphismVirtual(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        // fungsi virtual adalah fungsi yang di wariskan kepada anak untuk tujuan mengaitkan method induk ke anak
        // dan dapat dipanggil dari instansi objek induk dan anak. contoh berikut
        // instance object : DynamicPolymorphismVirtual dpv = new RectangleVirtual(12, 11);
        public virtual int area()
        {
            Console.WriteLine("Shape Area");
            return 0;
        }
    }


}
