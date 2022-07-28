// Тут всі напої та топіки
namespace SrarBuzzApp
{
    abstract class Beverage
    {
        public abstract string getDescription();
        public abstract double cost();
    }

    // Патерн декоратора вимагає існування загального класу Декораторів, який наслідує Beverage. 
    // 
    // Він мусить наслідувати Beverage, адже це дозволяє нам "обгортати" об'єкт безліч разів:
    // 
    // 1. Ми можемо "обгорнути" напій, адже він класу Beverage, оскільки поле всередині класу-декоратора має тип Beverage
    // 2. На виході отримуємо новий об'єкт Beverage, адже декоратор теж наслідує Beverage, тому ми можемо повторювати п.1
    // безліч разів
    abstract class CondimentDecorator : Beverage 
    {
        private Beverage beverage; // Декоратор це "обгортка", яка містить всередині об'єкт Beverage і інформацію про нього

        public Beverage getBeverage()
        {
            return beverage;
        }

        public void setBeverage(Beverage b)
        {
            beverage = b;
        }
    }

    // далі 4 напої зі специфічною ціною і описом
    class HouseBlend : Beverage
    {
        private string description = "Nice House Blend";
        public override string getDescription()
        {
            return description;
        }
        public override double cost()
        {
            return 1;
        }
    }

    class DarkRoast : Beverage
    {
        private string description = "Cool Dark Roast";

        public override string getDescription()
        {
            return description;
        }

        public override double cost()
        {
            return 1.1;
        }
    }
    
    class Espresso: Beverage
    {
        private string description = "Awesome Espresso";
        public override string getDescription()
        {
            return description;
        }
        public override double cost()
        {
            return 1.5;
        }
    }

    class Decaf: Beverage
    {
        private string description = "Just Decaf";
        public override string getDescription()
        {
            return description;
        }
        public override double cost()
        {
            return 0.9;
        }
    }

    // далі 4 декоратори зі специфічною ціною
    class Milk : CondimentDecorator
    {
        public Milk(Beverage b)
        {
            setBeverage(b);
        }

        // Декоратор може модифікувати ціну і назву, адже він містить всередині об'єкт Beverage, тобто містить ВСЮ інформацію про 
        // нього

        // тут і далі декоратор модифікує назву, додаючи себе
        public override string getDescription()
        {
            return getBeverage().getDescription() + ", Milk";
        }

        // тут і далі декоратор модифікує ціну, додаючи свою вартість
        public override double cost()
        {
            return getBeverage().cost() + 0.1;
        }
    }

    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage b)
        {
            setBeverage(b);
        }

        public override string getDescription()
        {
            return getBeverage().getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return getBeverage().cost() + 0.5;
        }
    }

    class Soy : CondimentDecorator
    {
        public Soy(Beverage b)
        {
            setBeverage(b);
        }

        public override string getDescription()
        {
            return getBeverage().getDescription() + ", Soy";
        }

        public override double cost()
        {
            return getBeverage().cost() + 0.05;
        }
    }

    class Whip : CondimentDecorator
    {
        public Whip(Beverage b)
        {
            setBeverage(b);
        }

        public override string getDescription()
        {
            return getBeverage().getDescription() + ", Whip";
        }
        public override double cost()
        {
            return getBeverage().cost() + 0.2;
        }
    }
}
