﻿using System;

// Патерн команд дозволяє відокремити виконання дій в окремі об'єкти(команди). Це дозволяє створювати черги команд
// замінювати команди, створювати команди за замовчуванням і т.д.
//
// Переваги: 
// - ані той хто команди дає(Client), ані той хто ними маніпулює(Invoker), ані той, хто їх виконує(Receiver) не знають
// про реалізацію команди всередині. Це створює слабкий зв'язок між цими об'єктами
//
// ЛЕГЕНДА.
// Всі ми бачили пульт. Цього разу нам самим треба його запрограмувати. Але: ми маємо можливість самим змінювати кнопки
// під різні задачі. Наприклад, я хочу, щоб кнопка 1 тепер перемикалась на мій улюблений канал, а кнопка 2 вмикала звук
// рівно на відмітці 35, бо це гарне число. Якби ми вставили реалізацію кожної кнопки напряму в пульт, то при грі зі 
// змінами нам би було дуже непросто. Адже треба змінювати код кожен раз, як задача кнопки змінюється. Але звичайний
// користувач пульта не вміє їх перепрограмовувати. Тому нам в нагоді стане патерн команд.


// Тестовий модуль
namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemote remote = new SimpleRemote();

            Console.WriteLine("Test 1");
            // переконаємося, що всі кнопки зараз пусті
            for(int i = 0; i < 5; i++) 
            {
                remote.pressButton(i);
            }

            Console.WriteLine("\n\nTest 2");
            // Призначимо деякі команди для кнопок
            remote.setCommand(0, new SwitchChannelTo(9));
            remote.setCommand(1, new SwitchChannelTo(1));
            remote.setCommand(2, new SetVolumeTo(35));
            remote.setCommand(3, new RecordingStart());
            remote.setCommand(4, new RecordingStop());

            for (int i = 0; i < 5; i++)
            {
                remote.pressButton(i);
            }


            Console.WriteLine("\n\nTest 3");
            // Припустимо, що 9й канал мені більше не до вподоби, бо там не показують моє улюблене шоу
            // Натомість, краще поставлю команду зміни звуку на 0
            remote.setCommand(0, new SetVolumeTo(0));
            remote.pressButton(0);

            // Готово! Ми можемо легко змінювати налаштування кнопок, додавати нові функції, і не перейматися, що для
            // цього нам треба буде змінити весь код.
        }
    }
}
