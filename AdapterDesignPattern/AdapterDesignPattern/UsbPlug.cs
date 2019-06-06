using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class UsbPlug : IUsbPlug
    {
        public bool Receive()
        {
            return true;
        }

        public bool Send()
        {
            return true;
        }
    }
}
