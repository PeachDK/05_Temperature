using System;

namespace _05_Temperature
{
    public interface ITemperature
    {

        double Convert(double temp);

    }

    static public class TemperatureFactory
    {

        static public ITemperature Get(Unit v)
        {
            switch (v)
            {
                case Unit.Celcius:
                    return new Celcius();
                case Unit.Fahrenheit:
                    return new Fahrenheit();
            }

            return new Celcius();
        }

    }

    public class Celcius : ITemperature
    {
        public double Convert(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }

    public class Fahrenheit : ITemperature
    {
        public double Convert(double temp)
        {
            return (temp * 9 / 5) + 32;
        }
    }
}