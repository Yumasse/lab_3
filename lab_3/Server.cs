using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interface;

namespace Task_2
{
    public class Server : Computer, IConnectable
    {
        public Server(string iPAddress, int power, string typeOS)  : base(iPAddress, power, typeOS)
        {

        }

        public void TransferData(string receiveraddress, string data)
        {
            Console.WriteLine($"Сервер ({IPAddress}) передав дані до {receiveraddress}: {data}");
        }

        public void Connect(Computer device)
        {
            Console.WriteLine($"Сервер ({IPAddress}) підключився до {device.IPAddress}");
        }

        public void Disconnect(Computer device)
        {
            Console.WriteLine($"Сервер ({IPAddress}) відключився від {device.IPAddress}");
        }
    }
}
