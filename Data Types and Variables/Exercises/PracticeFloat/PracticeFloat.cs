using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFloat
{
    public class PracticeFloat
    {
        public static void Main(string[] args)
        {
            decimal num1 = 3.141592653589793238M;
            double num2 = 1.60217657;
            decimal num3 = 7.8184261974584555216535342341M;

            Console.WriteLine("{0:f18}", num1);
            Console.WriteLine("{0:f8}", num2);
            Console.WriteLine("{0:f28}", num3);
        }
    }
}
