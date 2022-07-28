using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    interface ICommand
    {
        void execute(); // все, що нам треба від команди - щоб вона вміла виконуватися, от і все
    }

    // перемикаємось на заданий канал. Канал виставляється перманентно в конструкторі, але це не проблема, адже ми 
    // будь-коли можемо створити нову команду
    class SwitchChannelTo : ICommand
    {
        private int channelNumber;
        public SwitchChannelTo(int channel_number)
        {
            channelNumber = channel_number;
        }

        public void execute()
        {
            Console.WriteLine($"Swithed to {channelNumber}th channel");
        }
    }

    // Встановити звук
    class SetVolumeTo : ICommand
    {
        private int volume;
        public SetVolumeTo(int volume)
        {
            this.volume = volume;
        }

        public void execute()
        {
            Console.WriteLine($"Set volume to {volume}");
        }
    }

    // Увімкнути запис
    class RecordingStart : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Recording in progress...");
        }
    }

    // Зупинити запис
    class RecordingStop : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Recording stoped and saved");
        }
    }

    // Дефолтна, нічого не виконуюча команда
    class EmptyCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("No commands assigned");
        }
    }
}
