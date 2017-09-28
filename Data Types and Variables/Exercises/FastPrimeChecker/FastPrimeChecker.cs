using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    public class FastPrimeChecker
    {
        public static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= endNumber; currentNumber++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(currentNumber); i++)
                {
                    if (currentNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }
        }
    }
}
