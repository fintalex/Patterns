using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverWeather
{
    public class WeatherData : Subject
    {
        // объявление переменных экземпляра
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<Observer>();
        }
        public void measurementsChanged()
        {
            notifyObservers();
            //float temp = getTemperature();
            //float humidity = getHumidity();
            //float pressure = getPressure();

            //currentConditionsDisplay.update(temp, humidity, pressure);
            //statisticsDisplay.update(temp, humidity, pressure);
            //forecastDisplay.update(temp, humidity, pressure);

        }
        // другие методы

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }

        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.update(temperature, humidity, pressure);
            }
        }
        public void setMeasurements(float temp, float humi, float pres)
        {
            this.temperature = temp;
            this.humidity = humi;
            this.pressure = pres;
            measurementsChanged();
        }
        
    }
}
