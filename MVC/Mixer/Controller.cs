// Controller - зв'язуючий між View i Model
// він реалізує Strategy pattern в купі з View
namespace Mixer
{
    class Controller : IController
    {
        IModel model;

        public Controller(IModel model)
        {
            this.model = model;
        }

        public void DecrementBPM()
        {
            model.setBPM(model.getBPM() - 1);
        }

        public void IncrementBPM()
        {
            model.setBPM(model.getBPM() + 1);
        }

        public void setBPM(int BPM)
        {
            model.setBPM(BPM);
        }
        
        public void on()
        {
            model.on();
        }

        public void off()
        {
            model.off();
        }
    }
}
