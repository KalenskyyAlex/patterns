using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// ЛЕГЕНДА
// Ми хочемо зробити програму, яка буте створювати біт з можливістю виставляти частоту. Все настільки просто, але 
// реалізація обіцяє бути цікавою
//
// VMC патерн - це один з складених патернів, тобто який є комбінацією простіших. MVC означає Model View
// Controller і чудово описує принцип його роботи. Цей патерн використовується для систем, які мають користувача
// який взаємодіє з інтерфейсом (View), вводить дані (Controller), звертаючись до ядра програми, яке займається
// всіми необхідними операціями (Model).
// 
// Поїхали!

namespace Mixer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            // Об'єднуємо все до купи
            IModel model = new Model();
            IController controller = new Controller(model);
            View view = new View(controller);


            // Тепер наш View буде оновлюватися, коли Model змінюється
            model.addObserver((IBeatObserver)view);
            model.addObserver((IBPMObserver)view);
            
            Application.Run(view);
        }
    }
}
