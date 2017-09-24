using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    public class ConvertSpeedUnits
    {
        public static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalTimeInSeconds = (hours * 60 + minutes) * 60 + seconds; // transfer the whole time in seconds

            float speedMetersPerSec = distanceInMeters / totalTimeInSeconds; // we divide distance in meter on total time in seconds
            Console.WriteLine(speedMetersPerSec);

            float distanceInKM = distanceInMeters / 1000; // 1 km = 1000m
            float totalTimeInHours = totalTimeInSeconds / 3600.0f;
            float speedKmPerHours = distanceInKM / totalTimeInHours;
            Console.WriteLine(speedKmPerHours);

            float distanceInMiles = distanceInMeters / 1609;
            float speedInMilesPerHour = distanceInMiles / totalTimeInHours;
            Console.WriteLine(speedInMilesPerHour);
        }
    }
}
