using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace App_Coms_Nets
{
    class Coms
    {
        public int count = 0;
        public List<String> names=new List<string>();
        public List<SerialPort> listComs = new List<SerialPort>();

        public Coms() 
        {
            string[] namesTemp = SerialPort.GetPortNames();
            foreach (string name in namesTemp)
            {
                SerialPort com = new SerialPort(name, 9600, Parity.None, 8, StopBits.One);
                try
                {
                    com.Open();
                }
                catch (Exception ex)
                {
                    continue;
                }
                listComs.Add(com);
            }

            for (int i = 0; i < listComs.Count; i++)
            {
                names.Add(listComs[i].PortName);
            }
            this.count = listComs.Count;
        }
    }
}
