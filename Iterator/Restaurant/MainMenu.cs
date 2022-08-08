using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MainMenu : IMenu
    {
        Stack<MenuItem> dishes; // наш клас побудований на Stack<string>

        // задаємо наше меню
        public MainMenu()
        {
            dishes = new Stack<MenuItem>();
            dishes.Push(new MenuItem() { name = "Fish", descr = "grilled fish with vegetables", cost = 10.6 });
            dishes.Push(new MenuItem() { name = "French fries", descr = "potato sticks boiled in oil", cost = 7.5 });
            dishes.Push(new MenuItem() { name = "Salad", descr = "tomato, cucumber, salad leaves, paprik, sause, salt, pepper", cost = 8 });
        }

        public IIterator createIterator()
        {
            return new MainIterator(dishes);
        }
    }

    // стврюємо простий ітератор для MainMenu 
    class MainIterator : IIterator
    {
        private Stack<MenuItem> dishes;

        public MainIterator(Stack<MenuItem> dishes)
        {
            this.dishes = dishes;
        }

        public bool hasNext()
        {
            if (dishes.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object getNext()
        {
            MenuItem res = dishes.Pop();
            return res;
        }
    }
}
