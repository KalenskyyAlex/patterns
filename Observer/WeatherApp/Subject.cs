namespace WeatherApp
{
    // Інтерфейс, який забезпечує можливість "підписуватися" та "відписуватися "будь-якому IObserver
    // для отримування інформації.
    interface ISubject
    {
        void addObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers(); // викликається, коли необхідні для IObserver дані оновлюються
    }
}
