using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    public class CenturiesToMinutes
    {
        public static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());

            int years = 100 * centuries;
            int days = (int)(years * 365.2422); // it is not 365, because that's a tropic year
            int hours = 24 * days;
            int minutes = 60 * hours;

            // it is so printed from the lecture
            // Console.WriteLine($"Centuries = {centuries}\nYears = {years}\nDays = {days}\nHours = {hours}\nMinutes = {minutes}");

            // so is more readable
            Console.WriteLine($"Centuries = {centuries}\n" +
                              $"Years = {years}\n" +
                              $"Days = {days}\n" +
                              $"Hours = {hours}\n" +
                              $"Minutes = {minutes}");
        }
    }
}