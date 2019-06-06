using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class JackPlug : IJackPlug
    {
        public bool LeftChannelReceive()
        {
            return true;
        }

        public bool LeftChannelSend()
        {
            return true;
        }

        public bool RightChannelReceive()
        {
            return true;
        }

        public bool RightChannelSend()
        {
            return true;
        }
    }
}