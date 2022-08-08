using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MainMenu : Menu
    {
        // задаємо наше меню
        public MainMenu()
        {
            name = "MENU";
            
            addChild(new MenuItem() { name = "Fish", descr = "grilled fish with vegetables", cost = 10.6 });
            addChild(new MenuItem() { name = "French fries", descr = "potato sticks boiled in oil", cost = 7.5 });
            addChild(new MenuItem() { name = "Salad", descr = "tomato, cucumber, salad leaves, paprik, sause, salt, pepper", cost = 8 });
        }
    }
}
