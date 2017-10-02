namespace GetAge
{
    using System;

    public class GetAge
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Geburtsdatum");
            Console.WriteLine("---------------");
            Console.Write("Jahr: ");
            int inputYear = int.Parse(Console.ReadLine());
            Console.Write("Monat: ");
            int inputMonth = int.Parse(Console.ReadLine());
            Console.Write("Tag: ");
            int inputDay = int.Parse(Console.ReadLine());

            var age = CalculateAge(inputYear, inputMonth, inputDay);
            Console.WriteLine($"Man ist {age} Jahre alt.");
        }

        public static int CalculateAge(int year, int month, int day)
        {
            var timeNow = DateTime.Now;
            var currentYear = timeNow.Year;
            var currentMonth = timeNow.Month;
            var currentDay = timeNow.Day;

            var age = currentYear - year;

            if (currentMonth < month || (currentMonth < month && currentDay < day))
            {
                age--;
            }

            return age;
        }
    }
}
