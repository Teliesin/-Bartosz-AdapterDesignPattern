using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IUsbPlug usbPlug = new UsbPlug();
            usbPlug.Receive();
            usbPlug.Send();

            IHdmiPlug hdmiPlug = new HdmiPlug();
            IUsbPlug hdmiPlugAdapter = new HdmiPlugAdapter(hdmiPlug);

            hdmiPlugAdapter.Receive();
            hdmiPlugAdapter.Send();

            IJackPlug jackPlug = new JackPlug();
            IUsbPlug jackPlugAdapter = new JackPlugAdapter(jackPlug);

            jackPlugAdapter.Receive();
            jackPlugAdapter.Send();
        }
    }
}
