using System.Diagnostics;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var road = new Road(500, 4, 2);
            var automobile = new Vehicle("Автомобіль", 60, 4);
            var bus = new Vehicle("Автобус", 50, 6);
            var truck = new Vehicle("Вантажівка", 40, 8);

            var vehicle = new List<Vehicle> { automobile, bus, truck };

            var simulation = new Trafficsimulation();
            simulation.Trafficsimulat(road, vehicle);
        }
    }
}