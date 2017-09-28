using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartASCII
{
    public class PrintPartASCII
    {
        public static void Main(string[] args)
        {
            // You should give a start and end value and it should prints a symbols from ASCII Table from a start to end value
            byte startNumber = byte.Parse(Console.ReadLine());
            byte endNumber = byte.Parse(Console.ReadLine());

            for (int number = startNumber; number <= endNumber; number++)
            {
                var printChar = Convert.ToChar(number);
                var printMessage = string.Format(printChar + " ");
                Console.Write(printMessage);
            }
        }
    }
}
