using System;

// 3 базових класи Display
namespace WeatherApp
{
    class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private ISubject subject;
        public CurrentConditionsDisplay(ISubject s)
        {
            subject = s;
            subject.addObserver(this);
        }

        private float temp;
        private float hum;
        private float pres;

        public void update(float temp, float hum, float pres)
        {
            this.temp = temp;
            this.hum = hum;
            this.pres = pres;

            display();
        }

        public void display()
        {
            Console.WriteLine($"Current t: {temp} *C\n" +
                $"Current humidity: {hum*100}%,\n" +
                $"Current pressure: {pres} mm\n");
        }
    }

    class StatisticsDisplay : IObserver, IDisplay
    {
        private ISubject subject;
        public StatisticsDisplay(ISubject s)
        {
            subject = s;
            subject.addObserver(this);
        }

        private float av_temp;
        private float av_hum;
        private float av_pres;

        public void update(float temp, float hum, float pres)
        {
            av_temp = (temp + av_temp) / 2;
            av_hum = (hum + av_hum) / 2;
            av_pres = (pres + av_pres) / 2;

            display();
        }

        public void display()
        {
            Console.WriteLine($"Average t: {av_temp} *C\n" +
                $"Average humidity: {av_hum * 100}%,\n" +
                $"Average pressure: {av_pres} mm\n");
        }
    }

    class ForecastDisplay : IObserver, IDisplay
    {
        private ISubject subject;
        public ForecastDisplay(ISubject s)
        {
            subject = s;
            subject.addObserver(this);
        }

        private float temp;
        private float hum;

        public void update(float temp, float hum, float pres)
        {
            this.temp = temp;
            this.hum = hum;

            display();
        }

        public void display()
        {
            if (temp < 20 && hum > 0.8f)
            {
                Console.WriteLine("Possible rain\n");
            }
            else
            {
                Console.WriteLine("Sky is clear\n");
            }
        }
    }
}
