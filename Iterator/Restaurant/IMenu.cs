using System;
using System.Collections.Generic;
using System.Text;

// Цей інтерфейс - скоріше правило хорошого тону для нашого конкретного випадку. Адже класу Waiter не обов'язково знати,
// що робить клас DrinksMenu чи MainMenu - йому лише треба доступ до списку страв/напоїв, який, як ми вже вирішили,
// найкраще передвати через ітератор
namespace Restaurant
{
    interface IMenu
    {
        IIterator createIterator(); 
    }
}
