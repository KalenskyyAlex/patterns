using System;
using System.Collections.Generic;
using System.Linq;
// використаємо також State Pattern:
//  - для зручності, адже в нас є два стани - старт/стоп
//  - бо ми просто можемо ;)

namespace Mixer
{
    // інтерфейс стану
    interface IModelState
    {
        void on();
        void off();

        void setBPM(int BPM);
        int getBPM();
    }


    // ми не можемо нічого редагувати в стані стоп, а удари за хвилину дорівнюють 0
    class StopState : IModelState
    {
        public Model model;

        public StopState(Model model)
        {
            this.model = model;
        }

        public void on() 
        {
            model.state = Model.START;
        }

        public void off() { }

        public void setBPM(int BPM) { }

        public int getBPM() { return 0; }
    }


    // в цьому стані ми можемо редагувати все
    class StartState : IModelState
    {
        public Model model;

        public StartState(Model model)
        {
            this.model = model;
        }

        public void on() { }

        public void off()
        {
            model.state = Model.STOP;
        }

        public void setBPM(int BPM)
        {
            model.BPM = BPM;
            model.beatTimer.Change(0, 60000 / model.getBPM() - 500);
        }

        public int getBPM()
        {
            return model.BPM;
        }
    }
}
