using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    public class ComparingFloats
    {
        public static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double difference = Math.Abs(numberA - numberB);
            const double precision = 0.000001;

            bool AreNumbersRelativeEqual = difference < precision;

            Console.WriteLine(AreNumbersRelativeEqual);
        }
    }
}
