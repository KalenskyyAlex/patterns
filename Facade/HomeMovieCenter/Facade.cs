using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMovieCenter
{
    class Facade
    {
        // Facade містить доступ до всіх елементів групи
        Lights lights;
        DVD dvd;
        AudioSystem audioSystem;
        TV tv;

        public Facade( Lights l, DVD d, AudioSystem a, TV t)
        {
            lights = l;
            dvd = d;
            audioSystem = a;
            tv = t;
        }

        // вся інструкція в одному методі
        public void prepareForWatching(string movie)
        {
            lights.on();
            lights.dim(10);
            tv.on();
            dvd.on();
            audioSystem.on();
            audioSystem.setVolume(30);
            dvd.play("Pacific Rim");
        }

        // ще одна інструкція в одному методі
        public void stopWatching()
        {
            dvd.stop();
            audioSystem.off();
            dvd.off();
            tv.off();
            lights.off();
        }
    }
}
