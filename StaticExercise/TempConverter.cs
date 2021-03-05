using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double fTemp)
        {
            var celTemp = ((fTemp - 32)) / 1.8;
            return celTemp;
        }

        public static double CelsiusToFarenheit(double cTemp)
        {
            var fahTemp = ((cTemp * 1.8)) + 32;
            return fahTemp;
        }
    }
}
