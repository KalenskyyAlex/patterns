using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    // створимо абстрактний клас, від якого будуть наслідуватися як наші меню, так і кінцеві елементи(страви)
    // абстрактний клас, а не інтерфейс, адже частину реалізації ми лишаємо за ним.
    abstract class TreeElement
    {
        List<TreeElement> childs = new List<TreeElement>(); // збергіаємо вкладені мені та страви
        
        public TreeElement getChild(int index)
        {
            return childs[index];
        }

        public int getChildsCount()
        {
            return childs.Count;
        }

        public void addChild(TreeElement child)
        {
            childs.Add(child);
        }

        // кожен елемент дерева сам вирішує, як йому виконувати це завдання.
        // Якщо це меню - то воно просить надрукувати страви, а страви друкують самі себе
        public abstract void print();
    }
}
