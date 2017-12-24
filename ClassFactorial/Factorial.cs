using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFactorial
{
    public class Factorial
    {
        public int count(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
                result = result * i;
            if (result <= Int32.MaxValue)
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}
