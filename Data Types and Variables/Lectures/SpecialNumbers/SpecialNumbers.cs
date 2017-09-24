using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    public class SpecialNumbers
    {
        public static void Main(string[] args)
        {
            /* 
            // My version is what I understood
            // The program should print true on place of numbers from 0 to 20, which are 5, 7 and 11

            int inputNumber = int.Parse(Console.ReadLine());

            var number = 1;
            while (number <= inputNumber)
            {
                bool check = false;
                if (number == 5 || number == 7 || number == 11)
                {
                    check = true;
                    Console.WriteLine("{0} {1}", number, check);
                }
                else
                {
                    Console.WriteLine("{0} {1}", number, check);
                }
                number++;
            }
            */

            int inputNumber = int.Parse(Console.ReadLine());

            for (int num = 1; num <= inputNumber; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                bool status = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} {1}", num, status);
            }
        }
    }
}
