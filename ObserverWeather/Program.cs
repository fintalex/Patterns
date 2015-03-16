using ObserverWeather.VisualElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.setMeasurements(80, 65, 30);
            weatherData.setMeasurements(82, 70, 28);
            weatherData.setMeasurements(78, 90, 29);
        }
    }
}
