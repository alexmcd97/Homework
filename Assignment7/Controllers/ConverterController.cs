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

        [HttpPost]
        public IActionResult DoTemperature(ConverterViewModel model)
        {
            

            switch(model.Conversion)
            {
                case "FahrenheittoCelsius": model.Final = Conversions.FahrenheittoCelsius(model.value);
                break;
                case "FahrenheittoKelvin": model.Final = Conversions.FahrenheittoKelvin(model.value);
                break;
                case "CelsiustoFahrenheit": model.Final = Conversions.CelsiustoFahrenheit(model.value);
                break;
                case "CelsiustoKelvin": model.Final = Conversions.CelsiustoKelvin(model.value);
                break;
                case "KelvintoFahrenheit": model.Final = Conversions.KelvintoFahrenheit(model.value);
                break;
                case "KelvintoCelsius": model.Final = Conversions.KelvintoCelsius(model.value);
                break;


                default: break;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult DoLength(ConverterViewModel model)
        {
            switch(model.Conversion)
            {
                case "FeettoMeters": model.Final = Conversions.FeettoMeters(model.value);
                break;
                case "FeettoYards": model.Final = Conversions.FeettoYards(model.value);
                break;
                case "MeterstoFeet": model.Final = Conversions.MeterstoFeet(model.value);
                break;
                case "MeterstoYards": model.Final = Conversions.MeterstoYards(model.value);
                break;
                case "YardstoFeet": model.Final = Conversions.YardstoFeet(model.value);
                break;
                case "YardstoMeters": model.Final = Conversions.YardstoMeters(model.value);
                break;


                default: break;
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult DoMass(ConverterViewModel model)
        {

            switch(model.Conversion)
            {
                case "OuncetoPound": model.Final = Conversions.OuncetoPound(model.value);
                break;
                case "OuncetoGram": model.Final = Conversions.OuncetoGram(model.value);
                break;
                case "OuncetoKG": model.Final = Conversions.OuncetoKG(model.value);
                break;
                case "PoundtoOunce": model.Final = Conversions.PoundtoOunce(model.value);
                break;
                case "PoundtoGram": model.Final = Conversions.PoundtoGram(model.value);
                break;
                case "PoundtoKG": model.Final = Conversions.PoundtoKG(model.value);
                break;
                case "GramtoOunce": model.Final = Conversions.GramtoOunce(model.value);
                break;
                case "GramtoPound": model.Final = Conversions.GramtoPound(model.value);
                break;
                case "GramtoKG": model.Final = Conversions.GramtoKG(model.value);
                break;
                case "KGtoOunce": model.Final = Conversions.KGtoOunce(model.value);
                break;
                case "KGtoPound": model.Final = Conversions.KGtoPound(model.value);
                break;
                case "KGtoGram": model.Final = Conversions.KGtoGram(model.value);
                break;


                default: break;
            }

            return View(model);
            
        }
    }
}