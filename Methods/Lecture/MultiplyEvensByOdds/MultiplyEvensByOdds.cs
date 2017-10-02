namespace MultiplyEvensByOdds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            var result = GetMultipleOfEvensAndOdds(inputNumber);
            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvensAndOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number)
                 * GetSumOfOddDigits(number));  
        }

        public static int GetSumOfEvenDigits(int number)
        {
            return GetSumOfDigits(number, 0);
        }

        public static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, 1);
        }

        public static int GetSumOfDigits(int number, int remainder)
        {
            var result = 0;

            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == remainder)
                {
                    result += digit;
                }
            }

            return result;
        }
    }
}
