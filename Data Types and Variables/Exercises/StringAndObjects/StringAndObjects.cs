using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObjects
{
    public class StringAndObjects
    {
        public static void Main(string[] args)
        {
            string firstString = Console.ReadLine().Trim(); // trim removes the distances in front of string abd behind it
            string secondString = Console.ReadLine().Trim(); // trim removes the distances in front of string abd behind it

            secondString = " " + secondString;

            string printMessage = string.Concat(firstString, secondString); // string.Concat unites the strings
            Console.WriteLine(printMessage);
        }
    }
}
