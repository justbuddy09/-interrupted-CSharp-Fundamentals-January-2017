using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers
{
    public class ExactSumOfRealNumbers
    {
        public static void Main(string[] args)
        {
            decimal numbers = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}