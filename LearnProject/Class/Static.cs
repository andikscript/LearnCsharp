using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Class
{
    internal class Static
    {
        public static int num;

        public void addNum()
        {
            num += 1;
        }

        public static int getNum()
        {
            return num;
        }
    }
}
