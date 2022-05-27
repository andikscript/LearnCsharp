using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.TryCatch
{
    internal class ExceptionDevide
    {
        int result;

        public ExceptionDevide()
        {
            result = 0;
        }

        public void division(int a, int b)
        {
            try
            {
                result = a / b;
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception Caught devide by zero");
            } finally
            {
                Console.WriteLine("Result : {0}", result);
            }
        }
    }
}
