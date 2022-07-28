namespace PizzaStore
{
    // Будь яка PizzaFactory мусить мати метод для створення піци(і все)
    interface IPizzaFactory
    {
        public Pizza createPizza(PizzaTypes type);
    }

    // Ця PizzaFactory буде викликатися за замовчуванням, наприклад
    class SimplePizzaFactory : IPizzaFactory
    {
        public Pizza createPizza(PizzaTypes type)
        {
            if (type == PizzaTypes.Cheesy)
            {
                return new CheesyPizza();
            }
            else if (type == PizzaTypes.Diablo)
            {
                return new Diablo();
            }
            else if (type == PizzaTypes.Margarita)
            {
                return new Margarita();
            }
            else return null;
        }
    }

    // пам'єтаєте "ресторан може захотіти ввести іншу цінову політику"?
    // Ця PizzaFactory прив'язана до специфічних ресторанів і дає доступну піцу для дітей Бомбасу
    class DonbassPizzaFactory : IPizzaFactory
    {
        public Pizza createPizza(PizzaTypes type)
        {
            if (type == PizzaTypes.Cheesy)
            {
                Pizza p = new CheesyPizza();
                p.setPrice(100);
                return p;
            }
            else if (type == PizzaTypes.Diablo)
            {
                Pizza p = new Diablo();
                p.setPrice(100);
                return p;
            }
            else if (type == PizzaTypes.Margarita)
            {
                Pizza p = new Margarita();
                p.setPrice(100);
                return p;
            }
            else return null;
        }
    }

    // пам'ятаєте "ресторан вилучає вид піци через непопулярність"
    // ця PizzaFactory може працювати у вегетеріанських ресторанах - в ній немає піци Diablo з м'ясом
    class VeggiePizzaFactory : IPizzaFactory
    {
        public Pizza createPizza(PizzaTypes type)
        {
            if (type == PizzaTypes.Cheesy)
            {
                return new CheesyPizza();
            }
            else if (type == PizzaTypes.Margarita)
            {
                return new Margarita();
            }
            else return null;
        }
    }

    // ця PizzaFactory підходить для ресторанів, які пропонують фірмову піцу
    class SpecialPizzaFactory : IPizzaFactory
    {
        public Pizza createPizza(PizzaTypes type)
        {
            if (type == PizzaTypes.Cheesy)
            {
                return new CheesyPizza();
            }
            else if (type == PizzaTypes.Diablo)
            {
                return new Diablo();
            }
            else if (type == PizzaTypes.Margarita)
            {
                return new Margarita();
            }
            else if (type == PizzaTypes.Special)
            {
                return new SpecialPizza();
            }
            else return null;
        }
    }
}
