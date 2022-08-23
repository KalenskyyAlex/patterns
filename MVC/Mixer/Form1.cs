using System;
using System.Windows.Forms;
using System.Threading;

// VMC патерн - це один з складених патернів, тобто який є комбінацією простіших. MVC означає Model View
// Controller і чудово описує принцип його роботи. Цей патерн використовується для систем, які мають користувача
// який взаємодіє з інтерфейсом (View), вводить дані (Controller), звертаючись до ядра програми, яке займається
// всіми необхідними операціями (Model).
// 
// Поїхали!



// Тут наш View -  він відповідає за все, що бачить і робить користувач
// View реалізує патерн стратегій, щоб мати можливість змінювати Control, який в свою
// чергу вже зв'язується з Model. Це робиться для того, щоб Model i View не було тісно зв'язані, з можливістю 
// заміни тієї чи іншої частини
// 
// також View реалізовує логіку спосетрігача, і отримує сповіщення про зміни від Model
//
// а, ну і ще він реалізовує Composite патерн, як і всі інші UI елементи, але за нас це вже зробили
// WinForms :)
namespace Mixer
{
    public partial class View : Form, IBeatObserver, IBPMObserver
    {
        IController controller;

        public View(IController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        // зменшуємо у/хв на 1
        public void DecrementBPM(object o, EventArgs e)
        {
            controller.DecrementBPM();
        }

        // збільшуємо у/хв на 1
        public void IncrementBPM(object o, EventArgs e)
        {
            controller.IncrementBPM();
        }

        public void setBPM(object o, EventArgs e)
        {
            int BPM = 0;
            if(int.TryParse(EnterBPM.Text, out BPM)) // невеличка перевірка на правильний ввід
            {
                controller.setBPM(BPM);
            }
            EnterBPM.Text = "";
        }

        public void on(object o, EventArgs e)
        {
            start.Enabled = false;
            stop.Enabled = true;
            controller.on();
        }

        public void off(object o, EventArgs e)
        {
            start.Enabled = true;
            stop.Enabled = false;
            controller.off();
        }


        // змінюємо напис про у/хв
        public void update(int BPM)
        {
            BPMDisplay.Text = $"current BPM: {BPM}";
        }


        // робимо *туц* *туц* *туц* *туц* *туц*
        public void update()
        {
            BeatDisplay.BeginInvoke((MethodInvoker)delegate () { BeatDisplay.Value = 100; });
            Thread.Sleep(500);
            BeatDisplay.BeginInvoke((MethodInvoker)delegate () { BeatDisplay.Value = 0; });
        }
    }
}
