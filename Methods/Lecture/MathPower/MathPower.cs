namespace MathPower
{
    using System;

    public class MathPower
    {
        public static void Main(string[] args)
        {
            double inputBaseNumber = double.Parse(Console.ReadLine());
            int inputGradedNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Pow(inputBaseNumber, inputGradedNumber));
        }

        public static double Pow(double baseNumber, int gradedNumber)
        {
            double result = 1;
            for (int i = 1; i <= gradedNumber; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
