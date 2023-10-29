using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Trafficsimulation
    {
        public void Trafficsimulat(Road road, List<Vehicle> vehicle)
        {
            Console.WriteLine($"Дорога довжиною {road.Length} метрів і {road.Lanes} смугами");

            foreach (var transport in vehicle)
            {
                Console.WriteLine($"На дорозі рухається {transport.Type}");
                transport.Go();
            }

        }
    }
}
