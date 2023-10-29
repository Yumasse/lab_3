using Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Ecosystem ecosystem = new Ecosystem();

            ecosystem.AddOrganism(new Animal(100, 5, 10, 6));
            ecosystem.AddOrganism(new Plant(50, 2, 3, 4));
            ecosystem.AddOrganism(new Microorganism(20, 1, 1, 5));

            Console.WriteLine($"{ecosystem.Organism.Count} inital quantity of organism");

            for (int i= 0; i< 20; i++)
            {
                ecosystem.SimulateDay();
                Console.WriteLine($"{ ecosystem.Organism.Count} organisms alive after {i+1} days");
            }

            Console.WriteLine("Simulation finished!");
        }
    }
}
