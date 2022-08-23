namespace Mixer
{
    // цей спостерігач спрацьовуватиме, коли швидкість змінена
    interface IBPMObserver
    {
        void update(int BPM);
    }

    // а цей спостерігач спрацьовуватиме, коли відбувся біт, щоб змінити шкалу
    interface IBeatObserver
    {
        void update();
    }
}
