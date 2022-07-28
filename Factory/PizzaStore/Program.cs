﻿namespace PizzaStore
{
    // Патерн Фабрики дає можливість інкапсулювати створення об'єкта. Наприклад нам треба створювати кожного разу досить специфічний
    // об'єкт, один з багатьох. В такому разі можемо доручити це відповідальне(без рофлів) завдання окремому об'єкту
    // 
    // Переваги:
    // - інкапсуляція створення об'єктів спрощує розробку, адже зовнішні методи не зайняті створенням об'єктів
    // - взаємозамінність фабрик (по-моєму, це перегукується з патерном Стратегій)
    //
    // ЛЕГЕНДА
    // Треба розробити додаток для великої франшизи піцерій. Можливість створювати різні піци
    // 
    // Проблема 1:
    // Створення піци може знадобитися в різних методах. Наприклад:
    // - функція cook(type), яка готує специфічну піцу
    // - фунція menu(type), яка повертає опис і ціну специфічної піци
    // Кожен з цих методів буде містити код, по типу:
    // if type1 -> pizza = new Pizza1()
    // elif type2 -> pizza = new Pizza2()
    // ...
    // elif type100 -> pizza = new Pizza100()
    // Маємо повторення коду, до того ж, очевидно, що з'являться інші методи, які треба буде створити піцу,
    // що перетворює код в т.зв. розробницьке пекло
    // 
    // Проблема 2:
    // Деякі ресторани можуть захотіти мати своє меню. Наприклад
    // - ресторан 1 хоче ввести свою фірмову піцу
    // - ресторан 2 вилучає 2 види піци через непопулярність
    // - ресторан 3 має іншу цінову політику через особливість регіону
    //
    // Це погіршить Проблему 1 БАГАТОРАЗОВО, адже тепер кожен метод муситиме враховувати, який ресторан його викликає
    //
    // В цьому випадку краще використати патерн Фабрик, і доручити створення піц професіоналам(лол)


    // тестовий модуль
    class Program
    {
        static void Main(string[] args)
        {
            //Різні ресторани задовольняють різні потреби завдяки різним PizzaFactory
            Restaurant restaurant = new Restaurant(new SimplePizzaFactory(), "Restaurant");
            restaurant.menu();

            Restaurant restaurantDonbass = new Restaurant(new DonbassPizzaFactory(), "Donbass Restaurant");
            restaurantDonbass.menu();

            Restaurant restaurantVeggie = new Restaurant(new VeggiePizzaFactory(), "Veggie Restaurant");
            restaurantVeggie.menu();

            Restaurant restaurantBig = new Restaurant(new SpecialPizzaFactory(), "Big Restaurant");
            restaurantBig.menu();
        }
    }
}
