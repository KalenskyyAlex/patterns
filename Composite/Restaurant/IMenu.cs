using System;
using System.Collections.Generic;
using System.Text;

// Цей інтерфейс - скоріше правило хорошого тону для нашого конкретного випадку. Адже класу Waiter не обов'язково знати,
// що робить клас DrinksMenu чи MainMenu - йому лише треба доступ до списку страв/напоїв, який, як ми вже вирішили,
// найкраще передвати через ітератор
namespace Restaurant
{
    // переробимо інтерфейс в абстрактний клас, щоб реалізувати print() і getChild() для кожного меню
    abstract class Menu : TreeElement
    {
        public string name;

        public override void print()
        {
            if(getChildsCount() != 0)
            {
                Console.WriteLine($"{name}:");
                for(int i = 0; i < getChildsCount(); i++)
                {
                    getChild(i).print();
                }
            }
        }
    }
}
