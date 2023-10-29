using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interface;

namespace Task_2
{
    public class Router : Computer, IConnectable
    {
        public Router(string IPAddress, int power, string typeOS) : base(IPAddress, power, typeOS)
        {
        }

        public void TransferData(string receiveraddress, string data)
        {
            Console.WriteLine($"Маршрутизатор ({IPAddress}) передав дані до {receiveraddress}: {data}");
        }

        public void Connect(Computer device)
        {
            Console.WriteLine($"Маршрутизатор ({IPAddress}) підключився до {device.IPAddress}");
        }

        public void Disconnect(Computer device)
        {
            Console.WriteLine($"Маршрутизатор ({IPAddress}) відключився від {device.IPAddress}");
        }
    }
}
