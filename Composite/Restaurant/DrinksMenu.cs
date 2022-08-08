using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class DrinksMenu : Menu
    {
        List<MenuItem> drinks; // наш клас побудований на List<string> на відміну від MainMenu

        // задаємо наше меню
        public DrinksMenu()
        {
            name = "Drinks";
            drinks = new List<MenuItem>();

            addChild(new MenuItem() { name = "Tea", descr = "hot!", cost = 2 });
            addChild(new MenuItem() { name = "Juice", descr = "orange or apple juice", cost = 3.1 });
            addChild(new MenuItem() { name = "Coffee", descr = "late/cappuccino/espresso/classic", cost = 2.5 });
        }
    }
}
