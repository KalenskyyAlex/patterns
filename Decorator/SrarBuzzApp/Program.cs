﻿using System;

namespace SrarBuzzApp
{
    // Decoretor pattern розширює можливості вже існуюючих компонентів за допомогою композиції з іншими компонентами
    // 
    // Переваги:
    // - Дозволяє досягнути досить специфічних властивостей об'єкта, комбінуючи різні готові класи
    // 
    // Проблеми:
    // - Багато класів
    //
    // ЛЕГЕНДА
    // Треба створити додаток для кавової компанії Starbuzz. Є певна кількість напоїв, та топіки до них. Необхідно 
    // розраховувати ціну для кожного напою, зважаючи на топіки.
    // 
    // Проблема:
    // Трохи простої арифметики:
    // Маємо, наприклад 4 види напоїв та 4 види топіків. Створюючи класи по типу Coffee, 
    // CoffeeWithMilk, CoffeeWithChoco і т.д., маємо 4*5 = 20 варіантів класів. Це тільки початок - для 10 напоїв матимемо
    // 50 класів. Врахуємо, що можна додавати кілька топіків до напоїв, і матимемо 10*5*5*5*5 = 1250 класів! Якщо врахувати,
    // що клієнт, наприклад, може захотіти подвійне молоко, кількість специфічних класів стає такою, що НЕМОЖЛИВО ОБЧИСЛИТИ,
    // і прямує до НЕСКІНЧЕННОСТІ. Отож додавання нових напоїв та топіків перетворюється на виробниче пекло, як і редагування,
    // наприклад, старих цін. Що ж робити?
    //
    // Для подібних задач існує патерн декораторів.
    // Суть полягає в тому, що ми ніби "огортаємо" старий об'єкт в новий, додаючи йому нові характеристики
    // Наприклад: Кава -> Молоко(Кава) ... -> Молоко(Молоко(Шоколад(Цукор(Цукор(Кава))))). Кожен об'єкт модифікує ціну попереднього,
    // а головне ми отримуємо нескінченну кількість комбінацій готового напою.

    // Тестовий модуль
    class Program
    {
        static void Main(string[] args)
        {
            Beverage first = new DarkRoast(); // обираємо напій

            Console.WriteLine(first.getDescription()); 
            Console.WriteLine(first.cost());

            first = new Mocha(first); // додаємо шоколад 2 рази

            Console.WriteLine(first.getDescription()); 
            Console.WriteLine(first.cost()); 

            first = new Mocha(first);

            Console.WriteLine(first.getDescription()); 
            Console.WriteLine(first.cost()); 

            first = new Milk(first); // додаємо молоко

            Console.WriteLine(first.getDescription()); // готово!
            Console.WriteLine(first.cost()); // ціна з урахуванням всіх добавок
        }
    }
}
