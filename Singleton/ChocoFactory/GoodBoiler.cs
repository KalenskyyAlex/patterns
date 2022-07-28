using System;

// Забезпечує існування лише одного GoodBoiler в програмі
namespace ChocoFactory
{
    class GoodBoiler
    {
        // стан контейнера з шоколадом
        private bool isEmpty;
        private bool isCold;

        private GoodBoiler()
        {
            isEmpty = true;
            isCold = true;
        }

        // гріємо
        public void Boil()
        {
            if (!isEmpty && isCold)
            {
                isCold = false;
                Console.WriteLine("Boiling...");
            }
            else
            {
                Console.WriteLine("Can't boil this container!");
            }
        }

        // наповнюємо
        public void Fill()
        {
            if (isEmpty)
            {
                Console.WriteLine("Filling with chocolate...");
                isEmpty = false;
            }
            else
            {
                Console.WriteLine("Can't fill full container!");
            }
        }

        // звільнюємо контейнер
        public void Drain()
        {
            isEmpty = true;
            isCold = true;
            Console.WriteLine("Draining container...");
        }

        // Доки цей клас нічим не відрізняється від BadBoiler, хіба що Ви дуже уважний і помітили, що конструктор 
        // GoodBoiler тепер приватний. "О, тепер ми точно не зможемо створити більше 1ї копії GoodBoiler. Ба більше,
        // тепер ми ВЗАГАЛІ НЕ МОЖЕМО СТВОРИТИ ЖОДЕН!" Це правда, приватний конструктор може лише використовуватися 
        // всередині класу - толку від нього мало. Але ми можемо зробити один трюк:

        private  static GoodBoiler instance;
        public static GoodBoiler getInstance()
        {
            if (instance == null)
            {
                instance = new GoodBoiler();
            }
            return instance;
        }

        // Тепер ми можемо створити GoodBoiler через приватний конструктор. А getInstance() потурбується, щоб ми ніколи
        // не робили цього двічі. Так як метод статичний, ми можемо звертатися до нього завжди.
    }
}
