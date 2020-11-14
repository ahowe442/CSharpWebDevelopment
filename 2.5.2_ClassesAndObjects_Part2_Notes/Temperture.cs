using System;
namespace Temperture
{
    public class Temperture
    {
        private double fahrenheit;
        public static double AbsoluteZeroFahrenheit { get; } = -459.76;
        // a good use case for a constant would be the following.
        public const double Absolute_Zero_Fahrenheit = -459.67;
        

        public double Fahrenheit
        {
            get
            {
                return fahrenheit; 
            }
            set
            {
                if (value < AbsoluteZeroFahrenheit)
                {
                    throw new ArgumentOutOfRangeException("Value is below absolute zero bruh! ");
                }

                fahrenheit = value; 
            }
        }
    }
}
