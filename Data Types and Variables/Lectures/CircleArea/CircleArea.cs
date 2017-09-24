using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    public class CircleArea
    {
        public static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            var radiusArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("{0:f12}", radiusArea);
        }
    }
}
