using System;

namespace WeatherApp_CSharpBuiltInObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay curCondDisplay = new CurrentConditionsDisplay();
            curCondDisplay.Subscribe(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            forecastDisplay.Subscribe(weatherData);

            weatherData.setMeasurments();
            weatherData.setMeasurments();

            forecastDisplay.Unsubscribe();

            weatherData.setMeasurments();
            forecastDisplay.Subscribe(weatherData);
            weatherData.setMeasurments();

        }
    }
}
