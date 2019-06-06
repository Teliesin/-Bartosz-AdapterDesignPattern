using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class HdmiPlugAdapter : IUsbPlug
    {
        private IHdmiPlug HdmiPlug { get; set; }

        public HdmiPlugAdapter(IHdmiPlug hdmiPlug)
        {
            HdmiPlug = hdmiPlug;
        }

        public bool Receive()
        {
            HdmiPlug.Connect();
            int result = HdmiPlug.Get();
            return result == 1;
        }

        public bool Send()
        {
            HdmiPlug.Connect();
            int result = HdmiPlug.Send();
            return result == 1;
        }
    }
}
