using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTemperatura.Comum
{
    public class ConvertTemp
    {
        public static double CelsiusToKelvin(double c)
        {
            return c + 273;
        }

        public static double KelvinToCelsius(double k)
        {
            return k - 273;
        }

        public static double CelsiusToFahrenheit(double c)
        {
            return c * 1.8 + 32;
        }

        public static double FahrenheitToCelsius(double f)
        {
            return (5.0 / 9.0) * (f - 32);
        }
    }
}
