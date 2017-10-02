namespace GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main(string[] args)
        {
            var readInput = Console.ReadLine().ToLower(); // int, char, string

            if (readInput == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());

                var printGreaterValue = GetGreaterValue(firstValue, secondValue);
                Console.WriteLine(printGreaterValue);
            }
            else if (readInput == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                var printGreaterChar = GetGreaterValue(firstChar, secondChar);
                Console.WriteLine(printGreaterChar);
            }
            else if (readInput == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                var printGreaterString = GetGreaterValue(firstString, secondString);
                Console.WriteLine(printGreaterString);
            }
        }

        public static int GetGreaterValue(int firstValue, int secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
        public static char GetGreaterValue(char firstChar, char secondChar)
        {
            return (char)GetGreaterValue((int)firstChar, (int)secondChar);
        }
        public static string GetGreaterValue(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) < 0)
            {
                return secondString;
            }
            else
            {
                return firstString;
            }
        }
    }
}
