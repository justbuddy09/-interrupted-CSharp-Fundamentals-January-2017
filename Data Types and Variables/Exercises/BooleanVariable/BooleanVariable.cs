using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    public class BooleanVariable
    {
        public static void Main(string[] args)
        {
            bool checkBool = Convert.ToBoolean(Console.ReadLine());

            if (checkBool)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
