using System;
using System.Collections.Generic;
using static System.Math;

namespace WeatherApp_CSharpBuiltInObserverPattern
{
    class WeatherData : IObservable<WeatherData>
    {
        public WeatherData()
        {
            observers = new List<IObserver<WeatherData>>();
        }

        private List<IObserver<WeatherData>> observers;

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer)){
                observers.Add(observer);
            }
            return new UnSubscriber(observers, observer);
        }

        private class UnSubscriber : IDisposable
        {
            private List<IObserver<WeatherData>> _observers;
            private IObserver<WeatherData> _observer;

            public UnSubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }

        private float temperature;
        private float humidity;
        private float pressure;

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

        private void measurmentsChanged()
        {
            temperature = getTemperature();
            humidity = getHumidity();
            pressure = getPressure();

            notifyObservers();
        }

        private void notifyObservers()
        {
            foreach (IObserver<WeatherData> observer in observers)
            {
                observer.OnNext(this);
            }
        }

        // Цей метод "магічно" отримує необхідні показники, з ніби-то метеостанції
        public void setMeasurments()
        {
            temperature = new Random().Next(10, 31);
            humidity = (float)Round(new Random().NextDouble(), 2);
            pressure = new Random().Next(550, 850);

            measurmentsChanged();
        }
    }
}
