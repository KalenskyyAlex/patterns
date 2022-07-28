using System;


// Наведено класи, які реалізують крякання. Кожен клас містить один з варіантів алгоритмів, які будуть
// застосовані в створенні качечок
// 
// Але цього не достатньо
//
// Саме інтерфейс IQuackBehaviour дозволяє зробити ці класи взаємохамінюваними
namespace DuckUSim
{
    public interface IQuackBehaviour
    {
        public void quack();
    }

    public class Quackable : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quack-quack!");
        }
    }

    public class Squickable : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squick!");
        }
    }

    public class Muted : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("....");
        }
    }
}
