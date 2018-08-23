using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTemperatura.Comum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTemperatura.Controllers
{
    [Route("/api/v1/temperatura")]
    public class TemperaturaController : Controller
    {
        [HttpGet(), Route("{grau}/from-celsius")]
        public ActionResult GetFromCelsius(long c)
        {
            ConvertTemp.CelsiusToFahrenheit(c);
            ConvertTemp.CelsiusToKelvin(c);

            return View();
        }

        [HttpGet(), Route("{grau}/from-fahrenheit")]
        public ActionResult GetFromFahrenheit(long f)
        {
            double celsius = ConvertTemp.FahrenheitToCelsius(f);
            ConvertTemp.CelsiusToKelvin(celsius);

            return View();
        }

        [HttpGet(), Route("{grau}/from-kelvin")]
        public ActionResult GetFromKelvin(long k)
        {
            double kelvin = ConvertTemp.KelvinToCelsius(k);
            ConvertTemp.CelsiusToFahrenheit(kelvin);
            
            return View();
        }
    }
}