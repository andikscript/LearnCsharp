using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.TryCatch
{
    // kelas yang digunakan untuk membuat custom Exception
    internal class TempIsZeroException: Exception
    {
        public TempIsZeroException(string message) : base(message) { }
    }
}
