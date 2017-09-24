using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    public class TriplesOfLetters
    {
        public static void Main(string[] args)
        {
            // It should print a variation of all letters before 'number'

            int number = int.Parse(Console.ReadLine());

            for (int first = 1; first <= number; first++)
            {
                for (int second = 1; second <= number; second++)
                {
                    for (int third = 1; third <= number; third++)
                    {
                        char firstLetter = (char)('a' + first - 1);
                        char secondLetter = (char)('a' + second - 1);
                        char thirdLetter = (char)('a' + third - 1);

                        Console.WriteLine("{0}{1}{2}", firstLetter, secondLetter, thirdLetter);
                    }
                }
            }
            // Console.WriteLine((char)(number + 'a' - 1));
        }
    }
}
