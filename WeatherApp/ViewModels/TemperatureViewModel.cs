using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;
using WeatherApp.Models;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        public DelegateCommand<string> GetTempCommand { get; set; }
        public TemperatureModel CurrentTemp { get; set; }

        public double CelsiusInFahrenheit(double c)
        {
            return c * (9d / 5d) + 32d;
        }
    }
}
