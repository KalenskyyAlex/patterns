using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    class SimpleRemote
    {
        private ICommand[] commands;
        
        public SimpleRemote()
        {
            commands = new ICommand[5];// нехай на нашому пульті буде всього 5 кнопок

            for(int i = 0; i < 5; i++)
            {
                commands[i] = new EmptyCommand();// всі кнопки "пусті" за замовчуванням
            }
        }

        // ми можемо змінювати команди для кнопок
        public void setCommand(int slot, ICommand command)
        {
            commands[slot] = command;
        }

        // тицяємо на кнопку номер 'slot'
        public void pressButton(int slot)
        {
            Console.WriteLine($"Button {slot + 1} was pressed.");
            commands[slot].execute();
        }
    }
}
