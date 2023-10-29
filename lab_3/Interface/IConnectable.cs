using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Interface
{
    internal interface IConnectable
    {
        void TransferData(string receiveraddress, string data);
        void Connect(Computer device);
        void Disconnect(Computer device);
        
    }
}
