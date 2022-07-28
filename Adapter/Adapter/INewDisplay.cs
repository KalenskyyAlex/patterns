using System;

namespace Adapter
{
    // натомість ми вирішили використати мінімалістичніший дісплей, який буде показувати все це в одному місці
    // вгорі (як на звичайному телефоні). Але тепер ми не можемо використати клас OldDisplay
    interface INewDisplay
    {
        void DisplayAll();
    }

    // цей клас реалізовує новий інтерфейс, використовуючи старий
    class DisplayAdapter : INewDisplay
    {
        private IOldDisplay display; // Адаптер завжди містить посилання на старий клас, адже він використовує його методи
        public DisplayAdapter(IOldDisplay d)
        {
            display = d;
        }

        // використовуючи старі методи IOldDisplay, задовольняємо потреби нового інтерефейсу
        public void DisplayAll()
        {
            display.DisplayNotifications();
            Console.Write(" | ");
            display.DisplayCharge();
            Console.Write(" | ");
            display.DisplayTime();
            Console.WriteLine();
        }
    }
}
