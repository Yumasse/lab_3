using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Computer
    {
        public string IPAddress { get; set; }
        public int Power { get; set; }
        public string TypeOS { get; set; }

        public Computer(string iPAddress, int power, string typeOS)
        {
            IPAddress = iPAddress;
            Power = power;
            TypeOS = typeOS;
        }
    }
}


