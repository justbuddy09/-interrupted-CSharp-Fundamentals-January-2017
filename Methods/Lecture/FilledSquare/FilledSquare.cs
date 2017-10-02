namespace FilledSquare
{
    using System;

    public class FilledSquare
    {
        static int numberStore;

        public static void Main(string[] args)
        {
            int someNumber = int.Parse(Console.ReadLine());
            numberStore = someNumber;

            PrintTopAndBot(numberStore);
            PrintBody(numberStore, numberStore - 2);
            PrintTopAndBot(numberStore);
        }

        public static void PrintTopAndBot(int lenght)
        {
            Console.WriteLine(new string('-', lenght * 2));
        }
        public static void PrintBody(int lenght, int repeatTimes)
        {
            for (int row = 1; row <= repeatTimes; row++)
            {
                Console.Write("-");
                for (int col = 1; col < lenght; col++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
