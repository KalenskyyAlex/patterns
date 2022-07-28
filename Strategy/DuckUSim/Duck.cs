using System;

// Зберігає всі класи каченят
namespace DuckUSim
{
    public abstract class Duck
    {
        // В даному випадку, цей метод є однаковим для всіх каченят
        public void swim()
        {
            Console.WriteLine("*swimming*");
        }

        // Не має сенсу використовувати патерн стратегії, адже для всіх каченят цей метод унікальний
        public abstract void display();

        protected IQuackBehaviour quackBehaviour; // Інтерфейс IQuackBehaviour містить всі можливі алгоритми
        // щоб відтворити *кряк*. Це дає нам велику гнучкість у створенні каченят
        protected IFlyBehaviour flyBehaviour; // аналогічно, IFlyBehaviour містить всі можливі варіанти 
        // польоту

        //Переваги:
        //
        // - Можна змінювати способи поведінки в рантаймі
        // - Можна додавати нові способи, не змінюючи клас Duck

        public void proceedFly()
        {
            flyBehaviour.fly();
            // Consle.WriteLine("I'm flying!");
            // 
            // Проблема: не всі качечки літають
            // 
            // Можливе рішення 1: зробити цей метод абстрактним і переписувати його для кожної
            // качечки
            //
            // public abstract void proceedFly();
            //
            // Нова проблема: це вимагає постійного повторення коду, наприклад, для качечок,
            // які літають одним способом. Це робить в коді багато повторень => дуже поганий код
            //
            // Можливе рішення 2: зробити інтерфейси IFlyable i INotFlyable і навішуватти його на
            // відповідні класи.
            // 
            // Нова проблема: це мало відрізняється від попередньої проблеми, адже інтерфейси
            // вимагають реалізації всередині класу, як і абстрактні класи => дуже поганий код
            // 
            // Натомість ми використовуємо патерн стратегії, тобто виносим "проблемну" та часто змінювану частину
            // коду, в т.зв. "сімейство алгоритмів", які реалізовують один інтерфейс
        }

        public void proceedQuack()
        {
            quackBehaviour.quack();
            // Consle.WriteLine("Quack!");
            // 
            // Проблема така ж як і в proceedFly(): далеко не всі качечки крякають, а ті, що крякають,
            // роблять це по-різному
            // 
            // Нехитрими мозковими діями можна здогадатися, що тут теж варто використати патерн стратегії

        }

        // наступні два методи дозволяють оперувати поведінкою каченят під роботи програми
        public void setFlyBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void setQuackBehaviour(IQuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }


    // Далі приклади різноманітних каченят. Бачимо, як спрощується створення нових класів
    // Не використовуючи патерн стратегій, ми мусили б писати методи fly() i quack() окремо для кожного
    public class ReadheadDuck : Duck
    {
        public ReadheadDuck()
        {
            flyBehaviour = new FlyableWithWings();
            quackBehaviour = new Quackable();
        }

        public override void display()
        {
            Console.WriteLine("I'm a readhead duck!");
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new NotFlyable();
            quackBehaviour = new Squickable();
        }

        public override void display()
        {
            Console.WriteLine("I'm a rubber duck!");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new NotFlyable();
            quackBehaviour = new Muted();
        }

        public override void display()
        {
            Console.WriteLine("I'm a mallard duck!");
        }
    }

    public class CommonDuck : Duck
    {
        public CommonDuck()
        {
            flyBehaviour = new FlyableWithWings();
            quackBehaviour = new Quackable();
        }

        public override void display()
        {
            Console.WriteLine("I'm a common duck!");
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new NotFlyable();
            quackBehaviour = new Quackable();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck~~~");
        }
    }

    public class RocketDuck : Duck
    {
        public RocketDuck()
        {
            flyBehaviour = new FlyableWithRocketBelt();
            quackBehaviour = new Quackable();
        }

        public override void display()
        {
            Console.WriteLine("I'M A DUCK WITH A ROCKET BELT!");
        }
    }
}
