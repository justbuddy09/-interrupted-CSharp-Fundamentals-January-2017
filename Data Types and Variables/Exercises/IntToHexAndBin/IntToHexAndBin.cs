using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToHexAndBin
{
    public class IntToHexAndBin
    {
        public static void Main(string[] args)
        {
            // Insert a decimal number
            int someNumber = int.Parse(Console.ReadLine());

            // Convert a decimal number to hexadecimal and binary number and print it
            var convertedToHEX = Convert.ToString(someNumber, 16).ToUpper();
            var convertedToBin = Convert.ToString(someNumber, 2);

            Console.WriteLine(convertedToHEX);
            Console.WriteLine(convertedToBin);
        }
    }
}
