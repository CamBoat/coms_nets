using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace App_Coms_Nets
{
    public class Com_Nets
    {
        public SerialPort com;
        public List<IPEndPoint> nets;

        public Com_Nets(SerialPort com, List<IPEndPoint> aims)
        {
            this.nets = aims; 
            this.com = com;
        }
    }
}
