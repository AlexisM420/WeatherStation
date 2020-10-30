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
        private async void CanGetTemp(Object o)
        {
            CurrentTemp = await TemperatureService.GetTempAsync();
        }
        public DelegateCommand<string> GetTempCommand {
            get
            {
                if (TemperatureService == null)
                    throw new NullReferenceException();
                return new DelegateCommand<string>(CanGetTemp);
            }
            private set { } 
        }
        public TemperatureModel CurrentTemp { get; set; }

        public TemperatureViewModel()
        {
            GetTempCommand = new DelegateCommand<string>(GetTempData);
        }

        private async void GetTempData(string obj)
        {
            CurrentTemp = await TemperatureService.GetTempAsync();
        }

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
            if (TemperatureService == null) 
                return false;
            return true;
        }
    }
}
