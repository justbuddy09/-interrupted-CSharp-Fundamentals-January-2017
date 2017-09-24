using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    public class RefactorSpecialNumbers
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int digitNumber = 0;
            int counter = 0;
            bool numberStatus = false;

            for (int number = 1; number <= inputNumber; number++)
            {
                counter = number;
                while (number > 0)
                {
                    digitNumber += number % 10;
                    number = number / 10;
                }

                numberStatus = (digitNumber == 5) || (digitNumber == 7) || (digitNumber == 11);

                Console.WriteLine($"{counter} -> {numberStatus}");

                digitNumber = 0;
                number = counter;
            }
        }
    }
}
