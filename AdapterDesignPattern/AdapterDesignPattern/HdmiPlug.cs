using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class HdmiPlug : IHdmiPlug
    {
        public void Connect()
        {
        }

        public int Get()
        {
            return 1;
        }

        public int Send()
        {
            return 1;
        }
    }
}