using System;

// Бачимо, що OldDisplay реалізовує інтерфейс IOldDisplay. Очевидно, колись це було корисно, але тепер нам треба
// застосовувати новий. Це може статися з багатьох причин:
// - замовник може надати свої інтерфейси
// - старий інтерфейс більше не справляється з задачами
// - тощо
// Замість того, щоб переписувати клас OldDisplay ми використаємо його методи в Adapter, який вже сам буде реалізовувати
// новий інтерйфейс. Наш старий клас не змінюється => менше можливих помилок.
namespace Adapter
{
    // цей інтерфейс показує час, сповіщення та заряд окремо
    interface IOldDisplay
    {
        void DisplayTime();
        void DisplayCharge();
        void DisplayNotifications();
        void DisplayAll();
    }

    // клас, що його задовольняє
    class OldDisplay : IOldDisplay
    {
        public void DisplayTime()
        {
            Console.Write($"{DateTime.Now}");
        }

        private byte charge = 68;
        public void DisplayCharge()
        {
            Console.Write($"{charge}%");
        }

        public void DisplayNotifications()
        {
            Console.Write($"no messages");
        }

        public void DisplayAll()
        {
            DisplayTime();
            Console.WriteLine();
            DisplayCharge();
            Console.WriteLine();
            DisplayNotifications();
            Console.WriteLine();
        }
    }
}
