using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Waiter
    {
        TreeElement mainMenu;

        public Waiter(TreeElement menu)
        {
            mainMenu = menu;
        }


        // що не так зі старим методом? (дивися коментований код)
        // В тому, що Waiter все ще занадто переймається тим, як відобразити певний блок меню
        // Щоразу, як додаватимуться нові блоки меню, ми муситимемо змінювати цей метод (і це -
        // як ви здогадалися -  не добре). Ваші ідеї?
        //
        //  - Можна зробити список списків і ітерувати його
        //      
        //      List<IMenu> menus
        //      
        //      printFullMenu() {
        //          foreach (IMenu menu in menus)
        //          {
        //              то й же код, що був
        //          }
        //      }
        //
        // Чудове рішення, доки ми не стикнемося зі ще однією проблемою:
        // Як щодо вкладених списків? Наприклад DesertMenu буде містити як страви (торт, млинці, 
        // мафіни і т.д., так і кладку IceCream, що теж буде окремим меню? Тепер ітерування такого 
        // списку, це просто пекло, якщо використовували метод вище. Прочитавши це, можна повертатися
        // до Program.cs
        public void printFullMenu()
        {
            // Console.WriteLine("Dishes");
            // IIterator iter1 = main.createIterator();
            // print(iter1);
            // Console.WriteLine("Drinks");
            // IIterator iter2 = drinksmenu.createIterator();
            // print(iter2);

            mainMenu.print();
        }
    }
}
