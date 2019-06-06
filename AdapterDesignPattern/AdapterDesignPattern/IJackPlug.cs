using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public interface IJackPlug
    {
        bool LeftChannelSend();
        bool RightChannelSend();

        bool LeftChannelReceive();
        bool RightChannelReceive();
    }
}