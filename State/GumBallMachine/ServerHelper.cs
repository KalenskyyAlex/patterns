using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;


// Друга частина нашого проксі - необов'язкова за визначенням(за визначенням, обов'язковим класмо є ClientHelper) але
// дуже корисна в нашій ситуації
// Справа в тім, що і GumBallMachine не хоче займатися цією всією серверною роботою, тому ми її трошки розвантажимо

namespace GumBallMachine
{
    class ServerHelper
    {
        // ми тримаємо реальну GumBallMachine (нарешті!) тут
        private GumBallMachine instance;

        public ServerHelper(GumBallMachine m)
        {
            instance = m;
        }

        public void Start()
        {
            // ще трошки мережевого коду
            TcpListener listener = new TcpListener(1302);
            listener.Start();

            // весь час очікуємо на запити від Monitor
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client Found");

                StreamWriter sw = new StreamWriter(client.GetStream());
                StreamReader sr = new StreamReader(client.GetStream());

                string request = sr.ReadLine();

                // визначаємо, що нас попросив Monitor і даємо відповідну відповідь
                if(request == "getState")
                {
                    sw.WriteLine(instance.getState());
                }
                else if(request == "getInventory")
                {
                    sw.WriteLine(instance.getInventory());
                }
                else
                {
                    sw.WriteLine(instance.getLocation());
                }
                

                sw.Flush();

                // відправляємо клієнта додому щасливого і з відповіддю
                client.Close();
            }
        }
    }
}
