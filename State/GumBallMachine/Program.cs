﻿using System;

// Перед тим як ви захочете розібратися в цьому, краще почитайте, що таке машина станів - мені допомогло

// ЛЕГЕНДА
// Маємо жуйковий автомат, який має всього 4 стани:
// 1. Слот з монеткою пустий (тоді можна лише вставити монетку)
// 2. Слот з монеткую повний (тоді можна повернути монетку або забрати жуйку)
// 3. Жуйку видано (повертається до 1 або 4 стану)
// 4. Жуйок немає
// Перед нами так звана машина станів, доволі проста. Але проста поки. А що, як ми захочемо додати більше станів, то потонемо в нескінченних умовах перевірки станів
// Отож як зробити машину станів більш гнучкою і розширюваною? На допомогу патерн станів
//
// Якщо формально, то:
//
//      Патерн станів інкапсулює кожен стан машини. Машина лише делегує, який метод викликати, а стан вже вирішує реаліазацію,
//      і переходи до інших станів
//
// Ой, вийшло якось неформально, але суть ви второпали =)

// Тестовий модуль
namespace GumBallMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            GumBallMachine machine = new GumBallMachine(15, "Las Vegas");

            machine.insert();
            machine.turn_crank();

            machine.insert();
            machine.eject();
            machine.turn_crank();

            machine.eject();


            for (int i = 0; i < 8; i++)
            {
                machine.insert();
                machine.turn_crank();
            }

            machine.insert();
            machine.turn_crank();
            machine.eject();

            // дивись Proxy Pattern i ServerHelper.cs
            ServerHelper serverHelper = new ServerHelper(machine);
            serverHelper.Start();
        }
    }
}
