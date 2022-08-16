using IGumBallMachine;
using System.Net.Sockets;
using System.Net;
using System.IO;


// А ост тут починається щось серйозне
// Це - перша складовва нашого проксі. Це ClientHelper. І з назви можна здогадатися, що він бере на себе
// всю брудну роботу і ховає її від клієнта (Monitor)
//
// Особливості такого класу
//      - вдає, ніби він справжній об'єкт, який шукає клієнт (дивись визначення проксі патерну)
//      - насправді таким не є, а лише контролює доступ до справжнього об'єкта

namespace Monitor
{
    class ClientHelper : IGumBallMachine.IGumBallMachine
    {
        public string getState()
        {
            return SendRequest("getState");
        }

        public string getLocation()
        {
            return SendRequest("getLocation");
        }

        public int getInventory()
        {
            return System.Convert.ToInt32(SendRequest("getInventory"));
        }

        public string SendRequest(string request)
        {
            // трохи мережевого страшного коду
            string ip = GetLocalIPAddress();

            string state = null;

            try
            {
                // тут ми з'єднуємося з локальним сервером, бо на щастя
                // наші два проекти, як приклад, знаходяться на одному комп'ютері
                TcpClient client = new TcpClient(ip, 1302);

                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());

                // тут ми обираємо, який метод "на тому боці" буде викликаний
                sw.WriteLine(request);
                sw.Flush();

                // приймаємо відповідь від сервера
                state = sr.ReadLine();

                client.Close();
            }
            catch { }

            return state;
        }


        // отримуємо ip-адресу нашого ж комп'ютера
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "0.0.0.0";
        }
    }
}
