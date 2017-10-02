namespace CalculateTriangleArea
{
    using System;

    public class CalculateTriangleArea
    {
        public static void Main(string[] args)
        {
            double triangleBottomPart = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            var calculation = GetTriangleArea(triangleBottomPart, triangleHeight);
            Console.WriteLine($"{calculation}");
        }
        
        public static double GetTriangleArea(double bottomPart, double height)
        {
            double calculation = bottomPart * height / 2;
            return calculation;
        } 
    }
}
