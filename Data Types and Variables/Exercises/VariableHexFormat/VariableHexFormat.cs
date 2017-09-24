using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableHexFormat
{
    public class VariableHexFormat
    {
        public static void Main(string[] args)
        {
            // Convert a hexadecimal to a number
            var value = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(value);
        }
    }
}
