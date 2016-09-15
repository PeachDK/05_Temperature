using System;

namespace _05_Temperature
{
    
    public enum Unit
    {
        Fahrenheit,
        Celcius
    }

    internal class Temperature
    {
        public double Fahrenheit, Celcius;
        

        public Temperature(Unit valg, double temp)
        {
            Fahrenheit = temp;
            Celcius = temp;
        }
        public Temperature()
        {

        }


        internal static double FahrenheitToCelcius(double f)
        {
            return (f - 32) * 5 / 9;

        }

        internal static double CelciusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        
      
        
    }
}