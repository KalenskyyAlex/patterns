using System;
using static System.Math;
using System.Collections.Generic;

namespace WeatherApp
{
    
    public class WeatherData : ISubject // клас роздає оновлення іншим
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        
        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }

        // За легендою викликається автоматично, коли датчики метеостанції виявляють зміни
        private void measurmentsChanged()
        {
            temperature = getTemperature();
            humidity = getHumidity();
            pressure = getPressure();

            notifyObservers(); //сповіщаємо про це всі Display


            // Альтернативний "дуже поганий код"

            // forecastDisplay.update(...)
            // statisticsDisplay.update(...)
            // currentDisplay.update(...)
            // 
            // Проблема:
            // В майбутньому до WeatherData може звертатися скільки завгодно різних Display,
            // які нам доведеться вручну оновлювати
            // Більше того, якщо Display буде напиасний стороннім розробником, ми взагалі ніяк не
            // зможемо це контролювати
        }

        // Цей метод "магічно" отримує необхідні показники, з ніби-то метеостанції
        public void setMeasurments()
        {
            temperature = new Random().Next(10, 31);
            humidity = (float)Round(new Random().NextDouble(), 2);
            pressure = new Random().Next(550, 850);

            measurmentsChanged();
        }

        //Реалізація інтерфейсу ISubject
        public void addObserver(IObserver o)
        {
            observers.Add(o); // Додаємо Observer до тих хто буде "отримувати сповіщення"
        }
        
        public void removeObserver(IObserver o)
        {
            observers.Remove(o); // Тепер Obderver більше не буде "отримувати сповіщення"
        }

        //всі Obderver зі списку отимують сповіщення з новою інформацією
        public void notifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.update(temperature, humidity, pressure);
            }
        }
    }
}
