using System;

namespace WeatherApp_CSharpBuiltInObserverPattern
{
    class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplay
    {
        private IDisposable unsubscriber;
        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            display(value);
        }

        public void display(WeatherData value)
        {
            Console.WriteLine($"Current t: {value.getTemperature()} *C\n" +
                $"Current humidity: {value.getHumidity()*100}%\n" +
                $"Current pressure: {value.getPressure()} mm.");
        }

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }

    class ForecastDisplay : IObserver<WeatherData>, IDisplay
    {
        private IDisposable unsubscriber;
        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            display(value);
        }

        public void display(WeatherData value)
        {
            if (value.getTemperature() > 15 && value.getHumidity() > 0.8f)
            {
                Console.WriteLine("Bad weather coming!\n");
            }
            else
            {
                Console.WriteLine("Good weather coming!\n");
            }
        }

        public void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
