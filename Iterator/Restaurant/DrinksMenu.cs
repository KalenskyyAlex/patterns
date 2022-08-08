using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class DrinksMenu : IMenu
    {
        List<MenuItem> drinks; // наш клас побудований на List<string> на відміну від MainMenu

        // задаємо наше меню
        public DrinksMenu()
        {
            drinks = new List<MenuItem>();

            drinks.Add(new MenuItem() { name = "Tea", descr = "hot!", cost = 2 });
            drinks.Add(new MenuItem() { name = "Juice", descr = "orange or apple juice", cost = 3.1 });
            drinks.Add(new MenuItem() { name = "Coffee", descr = "late/cappuccino/espresso/classic", cost = 2.5 });
        }

        // ще дуже багато методів, побудованих на тому, що drinks це List<string> - ми не хочемо їх переписувати

        public IIterator createIterator()
        {
            return new DrinksIterator(drinks);
        }
    }

    // стврюємо простий ітератор для DrinksMenu 
    class DrinksIterator : IIterator
    {
        private List<MenuItem> drinks;
        private int position = 0;
        public DrinksIterator(List<MenuItem> drinks)
        {
            this.drinks = drinks;
        }

        public bool hasNext()
        {
            if (position < drinks.Count)
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
            MenuItem res = drinks[position];
            position++;
            return res;
        }
    }
}
