using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    public class TheaThePhotographer
    {
        public static void Main(string[] args)
        {
            int photos = int.Parse(Console.ReadLine()); // taken pictures
            int filterTimePhoto = int.Parse(Console.ReadLine()); // time to filter each photo
            byte percentageForFilter = byte.Parse(Console.ReadLine()); // photos that will be filtered (in %)
            int uploadSecondsPhoto = int.Parse(Console.ReadLine()); // time for every picture to be uploaded 

            // changed from int to long
            long goodPhotos = (long)Math.Ceiling((((double)photos / 100) * percentageForFilter));

            // added long
            long filterSeconds = (long)photos * filterTimePhoto;
            long uploadTimePhotos = goodPhotos * uploadSecondsPhoto;

            long totalSeconds = filterSeconds + uploadTimePhotos;

            // var totalTime = new TimeSpan(0, 0, totalSeconds); // how to use long here?
            // replaced the row above with the row below
            TimeSpan totalTime = TimeSpan.FromSeconds(totalSeconds);

            Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}