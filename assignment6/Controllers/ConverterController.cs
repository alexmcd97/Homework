using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using assignment6.Models;

namespace assignment6.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Temperature(string Conversion, int value)
        {
            decimal x;

            switch(Conversion)
            {
                case "FahrenheittoCelsius": x = Conversions.FahrenheittoCelsius(value);
                break;
                case "FahrenheittoKelvin": x = Conversions.FahrenheittoKelvin(value);
                break;
                case "CelsiustoFahrenheit": x = Conversions.CelsiustoFahrenheit(value);
                break;
                case "CelsiustoKelvin": x = Conversions.CelsiustoKelvin(value);
                break;
                case "KelvintoFahrenheit": x = Conversions.KelvintoFahrenheit(value);
                break;
                case "KelvintoCelsius": x = Conversions.KelvintoCelsius(value);
                break;


                default: return "Invalid Input";
            }
            return $"{Conversion} of {value} is {x}";
        }

        public string Length(string Conversion, int value)
        {
            decimal x;

            switch(Conversion)
            {
                case "FeettoMeters": x = Conversions.FeettoMeters(value);
                break;
                case "FeettoYards": x = Conversions.FeettoYards(value);
                break;
                case "MeterstoFeet": x = Conversions.MeterstoFeet(value);
                break;
                case "MeterstoYards": x = Conversions.MeterstoYards(value);
                break;
                case "YardstoFeet": x = Conversions.YardstoFeet(value);
                break;
                case "YardstoMeters": x = Conversions.YardstoMeters(value);
                break;


                default: return "Invalid Input";
            }
            return $"{Conversion} of {value} is {x}";
        }

        public string Mass(string Conversion, int value)
        {
            decimal x;

            switch(Conversion)
            {
                case "OuncetoPound": x = Conversions.OuncetoPound(value);
                break;
                case "OuncetoGram": x = Conversions.OuncetoGram(value);
                break;
                case "OuncetoKG": x = Conversions.OuncetoKG(value);
                break;
                case "PoundtoOunce": x = Conversions.PoundtoOunce(value);
                break;
                case "PoundtoGram": x = Conversions.PoundtoGram(value);
                break;
                case "PoundtoKG": x = Conversions.PoundtoKG(value);
                break;
                case "GramtoOunce": x = Conversions.GramtoOunce(value);
                break;
                case "GramtoPound": x = Conversions.GramtoPound(value);
                break;
                case "GramtoKG": x = Conversions.GramtoKG(value);
                break;
                case "KGtoOunce": x = Conversions.KGtoOunce(value);
                break;
                case "KGtoPound": x = Conversions.KGtoPound(value);
                break;
                case "KGtoGram": x = Conversions.KGtoGram(value);
                break;


                default: return "Invalid Input";
            }

            return $"{Conversion} of {value} is {x}";
            
        }
    }
}