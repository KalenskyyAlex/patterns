using System;

// Клас Monitor абсолютно нічого не підозрює - він звертається до GumBallMachine - принаймні він так думає
// І це прекрасно. Уявіть, що Monitor - це ваш клас, який ви пишете. Вам би точно не хотілося вручну 
// з'єднуватися з сервером кожного разу
// Проксі патерн робить всю цю роботу невидимою для кінцевого користувача (Monitor)

// Отож, що собі думає Monitor:

// |----------------|   (дружній зв'язок, )   |---------|
// | GumBallMachine |<--(ніби Монітор знає)-->| Monitor | 
// |----------------|   (нашу машину      )   |---------|

// Насправді ж

//   |----------------|      ( серверно )     |--------------|
//   |  ServerHelper  |<-----( мережева )---->| ClientHelper |
//   |----------------|      ( магія    )     |--------------|
//            ↑                                      ↑
//            |                                      |
// (якийсь чувак попросив)             (цей Монітор знову шось хоче )
//      (ок, тримай)                    (*посилає запит до сервера*)
//            |                                      |
//            ↓                                      ↓ 
//   |----------------|   (GumBallMachine   )   |---------|
//   | GumBallMachine | x-(взагалі не знає, )-x | Monitor | <- щасливий Монітор
//   |----------------|   (хто такий Monitor)   |---------|

namespace Monitor
{
    class Monitor
    {
        public IGumBallMachine.IGumBallMachine machine;
        public Monitor(IGumBallMachine.IGumBallMachine machine)
        {
            this.machine = machine;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(machine.getInventory());
            Console.WriteLine(machine.getLocation());
            Console.WriteLine(machine.getState());
        }
    }
}
