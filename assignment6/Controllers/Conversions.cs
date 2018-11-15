using System;
using System.Collections.Generic;

namespace assignment6.Controllers
{
    public class Conversions
    {

        public static decimal FahrenheittoCelsius(int value)
        {
            decimal x = (value - 32) * (5m / 9m);
            return x;
        }
        public static decimal FahrenheittoKelvin(decimal value)
        {
            decimal x = (value - 32m) * (5m/9m) + 273.15m;
            return x;
        }    
        public static decimal CelsiustoFahrenheit(decimal value)
        {
            decimal x = value * (9m/5m) + 32m;
            return x;
        }

        public static decimal CelsiustoKelvin(decimal value)
        {
            decimal x = value + 273.15m;
            return x;
        }
        public static decimal KelvintoCelsius(decimal value)
        {
            decimal x = value - 273.15m;
            return x;
        }
        public static decimal KelvintoFahrenheit(decimal value)
        {
            decimal x = (value - 273.15m) * (9m/5m) + 32m;
            return x;
        }

        public static decimal FeettoMeters(decimal value)
        {
            decimal x = value / 3.281m;
            return x;
        }
        public static decimal FeettoYards(decimal value)
        {
            decimal x = value / 3m;
            return x;
        }
        public static decimal MeterstoFeet(decimal value)
        {
            decimal x = value * 3.281m;
            return x;
        }
        public static decimal MeterstoYards(decimal value)
        {
            decimal x = value * 1.094m;
            return x;
        }
        public static decimal YardstoFeet(decimal value)
        {
            decimal x = value / 3m;
            return x;
        }
        public static decimal YardstoMeters(decimal value)
        {
            decimal x = value / 1.094m;
            return x;
        }
        public static decimal OuncetoPound(decimal value)
        {
            decimal x = value / 16m;
            return x;
        }
        public static decimal OuncetoGram(decimal value)
        {
           decimal x = value * 28.35m;
           return x;
        }
        public static decimal OuncetoKG(decimal value)
        {
           decimal x = value * .02835m;
           return x;
        }
        public static decimal PoundtoOunce(decimal value)
        {
            decimal x = value * 16m;
            return x;
        }
        public static decimal PoundtoGram(decimal value)
        {
            decimal x = value * 453.592m;
            return x;
        }
        public static decimal PoundtoKG(decimal value)
        {
            decimal x = value / 2.205m;
            return x;
        }
        public static decimal GramtoOunce(decimal value)
        {
            decimal x = value / 28.35m;
            return x;
        }
        public static decimal GramtoPound(decimal value)
        {
            decimal x = value / 453.592m;
            return x;
        }
        public static decimal GramtoKG(decimal value)
        {
            decimal x = value / 1000m;
            return x;
        }
        public static decimal KGtoOunce(decimal value)
        {
            decimal x = value * 35.274m;
            return x;
        }
        public static decimal KGtoPound(decimal value)
        {
            decimal x = value * 2.205m;
            return x;
        }
        public static decimal KGtoGram(decimal value)
        {
            decimal x = value * 1000m;
            return x;
        }
    }

}