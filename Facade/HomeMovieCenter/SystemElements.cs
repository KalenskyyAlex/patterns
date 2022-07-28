using System;

// Компоненти нашого домашнього кінотратру
namespace HomeMovieCenter
{
    class DVD
    {
        public void on()
        {
            Console.WriteLine("DVD is on");
        }

        public void off()
        {
            Console.WriteLine("DVD is off");
        }

        public void play(string movie)
        {
            Console.WriteLine($"Now {movie} is playing...");
        }

        public void stop()
        {
            Console.WriteLine("Nothing is playing");
        }
    }

    class AudioSystem
    {
        public void on()
        {
            Console.WriteLine("Audio is on");
        }

        public void off()
        {
            Console.WriteLine("Audio is off");
        }

        public void setVolume(int volume)
        {
            Console.WriteLine($"Set volume to {volume}");
        }
    }

    class TV
    {
        public void on()
        {
            Console.WriteLine("TV is on");
        }

        public void off()
        {
            Console.WriteLine("TV is off");
        }
    }

    class Lights
    {
        public void on()
        {
            Console.WriteLine("Lights are on");
        }

        public void off()
        {
            Console.WriteLine("Lights are off");
        }

        public void dim(int value)
        {
            Console.WriteLine($"Brightness set to {value}%");
        }
    }
}
