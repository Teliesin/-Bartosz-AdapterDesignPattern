using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class JackPlugAdapter : IUsbPlug
    {
        private IJackPlug JackPlug { get; set; }

        public JackPlugAdapter(IJackPlug jackPlug)
        {
            JackPlug = jackPlug;
        }

        public bool Receive()
        {
            bool leftResult = JackPlug.LeftChannelReceive();
            bool rightResult = JackPlug.RightChannelReceive();

            return leftResult && rightResult;
        }

        public bool Send()
        {
            bool leftResult = JackPlug.LeftChannelSend();
            bool rightResult = JackPlug.RightChannelSend();

            return leftResult && rightResult;
        }
    }
}
