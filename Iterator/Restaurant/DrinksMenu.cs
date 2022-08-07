using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class DrinksMenu : IMenu
    {
        List<string> drinks; // наш клас побудований на List<string> на відміну від MainMenu

        // задаємо наше меню
        public DrinksMenu()
        {
            drinks = new List<string>();

            drinks.Add("Tea - 2$");
            drinks.Add("Juice - 2.4$");
            drinks.Add("Coffe - 3$");
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
        private List<string> drinks;
        private int position = 0;
        public DrinksIterator(List<string> drinks)
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
            string res = drinks[position];
            position++;
            return res;
        }
    }
}
