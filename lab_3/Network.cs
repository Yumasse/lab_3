using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Interface;

namespace Task_2
{
    internal class Network
    {
        internal List<Computer> computers = new List<Computer>();

        public void AddComputer(Computer comp)
        {
            computers.Add(comp);
        }

        public void Interaction()
        {
            foreach (var comp1 in computers)
            {
                foreach (var comp2 in computers)
                {
                    if (comp1 != comp2)
                    {
                        if (comp1 is IConnectable)
                        {
                            (comp1 as IConnectable).Connect(comp2);
                            (comp1 as IConnectable).TransferData(comp2.IPAddress, "Дані для передачі");
                            (comp1 as IConnectable).Disconnect(comp2);
                        }
                        
                    }
                }
            }
        }
    }
}
