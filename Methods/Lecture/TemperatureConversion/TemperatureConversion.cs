namespace TemperatureConversion
{
    using System;

    public class TemperatureConversion
    {
        public static void Main(string[] args)
        {
            // Console.Write("Temperature in Fahrenheit: ");
            double inputFahrenheit = double.Parse(Console.ReadLine());

            inputFahrenheit = GetCelsius(inputFahrenheit);
            // Console.WriteLine($"Temperature in Celsius: {inputFahrenheit:f2}");
            Console.WriteLine($"{inputFahrenheit:f2}");
        }

        public static double GetCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
