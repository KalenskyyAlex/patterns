using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MainMenu : IMenu
    {
        Stack<string> dishes; // наш клас побудований на Stack<string>

        // задаємо наше меню
        public MainMenu()
        {
            dishes = new Stack<string>();
            dishes.Push("Chicken Nuggets - 5$");
            dishes.Push("Frites - 4$");
            dishes.Push("Salat - 3.5$");
        }

        // ще дуже багато методів, побудованих на тому, що disches це Stack<string> - ми не хочемо їх переписувати
        
        public IIterator createIterator()
        {
            return new MainIterator(dishes);
        }
    }

    // стврюємо простий ітератор для MainMenu 
    class MainIterator : IIterator
    {
        private Stack<string> dishes;

        public MainIterator(Stack<string> dishes)
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
            string res = dishes.Pop();
            return res;
        }
    }
}
