using System;

namespace TempConcertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert degrees celcious to kelvin and fahranheit

            Console.WriteLine("Enter a number in degrees celsius:");
            double degrees = Convert.ToDouble(Console.ReadLine());

            double kelvin = 273.15;
              // fahrenheit = (9/5)C + 32

            Console.WriteLine("The temperature in degrees celcius is: {0}", degrees);
            Console.WriteLine("The temperature in Kelvin is: {0}", degrees+kelvin);
            Console.WriteLine("The temperature in Fahrenheit is {0}", 1.8*degrees + 32);
        }
    }
}