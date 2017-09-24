using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    public class Elevator
    {
        public static void Main(string[] args)
        {
            // We are trying type conversion in this program

            int elevatorPersons = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            var route = (int)Math.Ceiling((double)elevatorPersons / elevatorCapacity);

            Console.WriteLine(route);
        }
    }
}