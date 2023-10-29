using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3.Interface;

namespace Task_3
{
    public class Vehicle : IDriveable
    {
        public string Type { get; set; }
        public double Speed { get; set; }
        public double Size { get; set; }



        public Vehicle(string type, double speed, double size)
        {
            Type = type;
            Speed = speed;
            Size = size;
        }

        public void Go()
        {
            Console.WriteLine($"{Type} рухається зі швидкістю {Speed} км/год");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} зупинився");

        }
    }

}
