using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Class1
    {
        public static bool StarsChecker(int num)
        {
            if (num < 1 || num > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
