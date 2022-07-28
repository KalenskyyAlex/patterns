namespace WeatherApp
{
    // Інтерфейс IObserver дозволяє отримувати інформацюю від будь-якого Subject через метод
    // update(), що викликається з потрібного Subject
    public interface IObserver
    {
        void update(float temp, float hum, float pres);
    }
}
