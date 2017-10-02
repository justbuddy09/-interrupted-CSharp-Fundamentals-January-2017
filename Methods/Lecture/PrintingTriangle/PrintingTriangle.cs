namespace PrintingTriangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangleFromNumbers(n);
        }

        public static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }

        public static void PrintTriangleFromNumbers(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintColumns(row);
            }
            for (int row = number - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}
