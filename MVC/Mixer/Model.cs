using System.Collections.Generic;
using System.Threading;


// Отож Model - це ядро нашої системи.
// Воно реалізує Observer Pattern, щоб сповіщувати View про зміни
namespace Mixer
{
    class Model : IModel
    {
        public static IModelState START;
        public static IModelState STOP;

        public IModelState state;

        public List<IBeatObserver> BeatObservers;
        public List<IBPMObserver> BPMObservers;

        public int BPM { get; set; }

        public Timer beatTimer;

        public Model()
        {
            BPMObservers = new List<IBPMObserver>();
            BeatObservers = new List<IBeatObserver>();
            beatTimer = new Timer(new TimerCallback(notify));

            STOP = new StopState(this);
            START = new StartState(this);

            state = STOP; // за замовчуванням мікшер зупинений
            BPM = 0;
        }

        // власне, функціонал нашої Model, але ми даємо виконати його об'єкту-стану

        public void on()
        {
            state.on();
        }

        public void off()
        {
            state.off();
        }

        public void setBPM(int BPM)
        {
            state.setBPM(BPM);
            notifyBPMObservers();
        }

        public int getBPM()
        {
            return state.getBPM();
        }

        private void notify(object o)
        {
            notifyBeatObservers();
        }

        // нічого особливого, далі логіка з Observer Pattern - ви її вже точно бачили

        public void addObserver(IBPMObserver BPMObserver)
        {
            if(!BPMObservers.Contains(BPMObserver) && BPMObserver != null)
            {
                BPMObservers.Add(BPMObserver);
            }
        }

        public void removeObserver(IBPMObserver BPMObserver)
        {
            BPMObservers.Remove(BPMObserver);
        }

        public void notifyBPMObservers()
        {
            foreach(IBPMObserver BPMObserver in BPMObservers)
            {
                BPMObserver.update(getBPM());
            }
        }


        public void addObserver(IBeatObserver beatObserver)
        {
            if (!BeatObservers.Contains(beatObserver) && beatObserver != null)
            {
                BeatObservers.Add(beatObserver);
            }
        }

        public void removeObserver(IBeatObserver beatObserver)
        {
            BeatObservers.Remove(beatObserver);
        }

        public void notifyBeatObservers()
        {
            foreach (IBeatObserver beatObserver in BeatObservers)
            {
                beatObserver.update();
            }
        }
    }
}
