using Task_2;

namespace lab_3
{
    class Program
    {
        static void Main()
        {
            var network = new Network();
            var server = new Server("192.168.1.1", 1000, "Windows Server");
            var workstation = new Workstation("192.168.1.2", 500, "Windows 10");
            var router = new Router("192.168.1.3", 800, "RouterOS");

            network.AddComputer(server);
            network.AddComputer(workstation);
            network.AddComputer(router);

            network.Interaction();
        }
    }
}