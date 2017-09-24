using System;
// using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoS
{
    public class CenturiesToNanoS
    {
        public static void Main(string[] args)
        {
            /* 
            Enter an integer number of centuries and convert it to 
            years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds 
            */

            byte centuries = byte.Parse(Console.ReadLine());

            ushort convertedYears = (ushort)(centuries * 100);
            int convertedDays = (int)(convertedYears * 365.2422); // 365.2422 - tropic year, use it???
            int convertedHours = convertedDays * 24;
            long convertedMinutes = convertedHours * 60;
            long convertedSeconds = convertedMinutes * 60;
            ulong convertedMiliseconds = (ulong)(convertedSeconds * 1000);
            decimal convertedMicroseconds = convertedMiliseconds * 1000;
            decimal convertedNanoseconds = convertedMicroseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {convertedYears} years = {convertedDays} days = " +
                $"{convertedHours} hours = {convertedMinutes} minutes = {convertedSeconds} seconds = {convertedMiliseconds} milliseconds = " +
                $"{convertedMicroseconds} microseconds = {convertedNanoseconds} nanoseconds");
        }
    }
}