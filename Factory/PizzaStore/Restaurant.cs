using System;


namespace PizzaStore
{
    public enum PizzaTypes {Cheesy, Diablo, Margarita, Special}
    // Тестовий клас ресторанів, які надає меню користувачам
    class Restaurant
    {
        private IPizzaFactory factory;
        private string name;

        public Restaurant(IPizzaFactory factory, string name)
        {
            this.factory = factory;
            this.name = name;
        }

        // Виводимо меню. Оскільки меню визначає специфічна PizzaFactory, нам не треба створювати безліч класів ресторанів
        // ми вже визначили вид ресторану просто обравши відповідну фабрику
        public void menu()
        {
            Console.WriteLine(name + "'s menu:");
            foreach(PizzaTypes type in (PizzaTypes[])Enum.GetValues(typeof(PizzaTypes)))
            {
                Pizza newPizza = factory.createPizza(type);
                if(newPizza != null)
                {
                    Console.WriteLine(newPizza.getDesription() + " " + newPizza.getPrice() + "$");
                }
            }
            Console.WriteLine();
        }
    }
}
