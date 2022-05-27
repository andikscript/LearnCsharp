using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LearnProject.FileStreamC
{
    internal class ReadWrite
    {
        FileStream file = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

        public void write()
        {
            for(int i = 0; i < 10; i++)
            {
                file.WriteByte(Convert.ToByte(i));
            }
        }

        public void read()
        {
            file.Position = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(file.ReadByte() + " ");
            }
        }

    }
}
