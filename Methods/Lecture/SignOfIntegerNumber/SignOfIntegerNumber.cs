namespace SignOfIntegerNumber
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumberStatus(number);
        }

        public static void PrintNumberStatus(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
