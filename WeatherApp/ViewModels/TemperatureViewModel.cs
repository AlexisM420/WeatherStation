using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        /// 
        public ITemperatureService TemperatureService;
        public DelegateCommand<string> GetTempCommand {
            get { return null; }
            set {  } 
        }
        public TemperatureModel CurrentTemp { get; set; }

        public void SetTemperatureService(ITemperatureService itmps)
        {
            TemperatureService = itmps;
        }

        public static double CelsiusInFahrenheit(double c)
        {
            return c * (9d / 5d) + 32d;
        }

        public static double FahrenheitInCelsius(double f)
        {
            return (f - 32d) * 5d / 9d;
        }

        public bool CanGetTemp()
        {
            if (TemperatureService == null) return false;
            return true;
        }
    }
}
