namespace PizzaStore
{
    //Базовий клас піци - нічого цікавого
    abstract class Pizza
    {
        private double price;
        public double getPrice()
        {
            return price;
        }

        public void setPrice(double new_price)
        {
            price = new_price;
        }

        public abstract string getDesription();
    }

    // Кілька тестових піц
    class CheesyPizza : Pizza { 
        public CheesyPizza()
        {
            setPrice(8.5);
        }

        public override string getDesription()
        {
            return "Cheesy pizza - pizza with 4 kinds of Cheese";
        }
    }

    class Margarita : Pizza
    {
        public Margarita()
        {
            setPrice(9.3);
        }

        public override string getDesription()
        {
            return "Margarita - pizza with tomatoes and mozarella";
        }
    }

    class Diablo : Pizza
    {
        public Diablo()
        {
            setPrice(11);
        }

        public override string getDesription()
        {
            return "Diablo - realy HOT Pizza";
        }
    }

    class SpecialPizza : Pizza
    {
        public SpecialPizza()
        {
            setPrice(9.99);
        }

        public override string getDesription()
        {
            return "\"Special\" - pizza with a secret...";
        }
    }

}
