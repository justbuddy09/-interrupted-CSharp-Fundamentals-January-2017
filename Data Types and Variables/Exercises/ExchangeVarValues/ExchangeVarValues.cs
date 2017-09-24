using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVarValues
{
    public class ExchangeVarValues
    {
        public static void Main(string[] args)
        {
            byte firstNumber = byte.Parse(Console.ReadLine());
            byte secondNumber = byte.Parse(Console.ReadLine());

            Console.WriteLine("Before:");

            var storeFirstNumber = firstNumber;
            Console.WriteLine($"a = {storeFirstNumber}");

            var storeSecondNumber = secondNumber;
            Console.WriteLine($"b = {storeSecondNumber}");

            Console.WriteLine("After:");

            firstNumber = storeSecondNumber;
            Console.WriteLine($"a = {firstNumber}");

            secondNumber = storeFirstNumber;
            Console.WriteLine($"b = {secondNumber}");
        }
    }
}
