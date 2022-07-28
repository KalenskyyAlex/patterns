using System;

// Цей клас не захищений від існування кількох копій BadBoiler
namespace ChocoFactory
{
    class BadBoiler
    {
        // стан контейнера з шоколадом
        private bool isEmpty;
        private bool isCold;

        public BadBoiler()
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
    }
}
