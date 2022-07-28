using System;

// Наведено класи, які реалізують політ. Кожен клас містить один з варіантів алгоритмів, які будуть
// застосовані в створенні качечок
// 
// Але цього не достатньо
//
// Саме інтерфейс IFlyBehaviour дозволяє зробити ці класи взаємохамінюваними
namespace DuckUSim
{
    public interface IFlyBehaviour
    {
        public void fly();
    }

    public class FlyableWithWings : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }

    public class NotFlyable : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm not flying");
        }
    }

    public class FlyableWithRocketBelt : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'M FLYING WITH DA FUCKING ROCKET BELT!");
        }
    }
}
