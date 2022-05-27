using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.TryCatch
{
    internal class Temperature
    {
        int temperature = 0;

        public void showTemp()
        {
            if (temperature == 0)
            {
                throw new TempIsZeroException("Temperatur is Zero");
            } else
            {
                Console.WriteLine("Temperature is {0}", temperature);
            }
        }
    }
}
