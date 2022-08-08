using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Waiter
    {
        IMenu main;
        IMenu drinksmenu;

        public Waiter(IMenu main, IMenu drinksmenu)
        {
            this.main = main;
            this.drinksmenu = drinksmenu;
        }

        public void printFullMenu()
        {
            Console.WriteLine("Dishes");
            IIterator iter1 = main.createIterator();
            print(iter1);
            Console.WriteLine("Drinks");
            IIterator iter2 = drinksmenu.createIterator();
            print(iter2);

            // якби не ітератор, ми не могли б узагальнити перелік в метод print(), адже реалізація для списків буває різною
            // натомість, додаючи все нові розділи до нашого меню ми б мусили писати нові і нові цикли, повторюючи код
        }

        private void print(IIterator iter)
        {
            while (iter.hasNext())
            {
                MenuItem item = (MenuItem)iter.getNext();
                Console.WriteLine(item.name + " - " + item.descr + " - " + item.cost.ToString());
            }
        }
    }
}
