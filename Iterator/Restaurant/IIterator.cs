using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    // Ітератор дає нам змогу рухатися по списку, не знаючи, як він реалізований(чи це масив, чи List, стек,
    // черга, або будь-що інше). Ми можемо рухатися по списку за допомогою hetNext() за умови, що hasNext() 
    // наступний елемент існує
    interface IIterator
    {
        object getNext();
        bool hasNext();

        // іноді ітератор може містити метод remove() - вилучити останній повернений елемент зі списку,
        // але зараз він нам не потрібен
    }
}