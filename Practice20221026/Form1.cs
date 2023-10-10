using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;


/*
 * programmed by Jianzhou Li
 * This program is used to transfer data from every serial to all network aims.
 * The  baund rates of the serials are all setted to 9600 B/s defaultly.
*/

namespace App_Coms_Nets
{
    public partial class Form1 : Form
    {
        Coms coms;
        List<IPEndPoint> nets;

        StringBuilder[] arrStr = new StringBuilder[5];
        int iArrStr = 0;
        StringBuilder strTemp;

        public void show(String portName, byte[] data, int length)
        {
            arrStr[iArrStr] = new StringBuilder(portName.Substring(3) + ":" + ASCIIEncoding.ASCII.GetString(data, 0, length) + Environment.NewLine);
            iArrStr++;
            if (iArrStr == 5)
                iArrStr = 0;

            strTemp = new StringBuilder(120);
            for (int i = iArrStr; i < iArrStr + 5; i++)
                strTemp.Append(arrStr[i % 5]);
            tbx_S_N.Text = strTemp.ToString();
        }

        public void transfer(Object aCom_Nets)
        {
            Com_Nets com_Nets = (Com_Nets)aCom_Nets;
            SerialPort com = com_Nets.com;
            List<IPEndPoint> aims = com_Nets.nets;
         
            UdpClient udpClient = new UdpClient(0);

            byte[] data = new byte[255];
            int iData = 0;
            byte tempByte = 0;

            while (true)
            {
                iData = 0;
                while (true)
                {
                    tempByte = (byte)com.ReadByte();
                    data[iData] = tempByte;
                    iData++;
                    
                    //13:change line
                    if (tempByte == 13|iData==254)
                        break;
                }

                foreach (IPEndPoint aim in aims)
                {
                    udpClient.Send(data, iData, aim);
                    show(com.PortName,data,iData);
                }
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            btnServer.Text = "ip_port for each net node" + Environment.NewLine + "click this to save,then restart the APP";
        }

        public void initComs()
        {
            coms = new Coms();
            foreach (String name in coms.names)
                txtComs.Text += name+";";
        }

        public void initNets()
        {
            nets = new List<IPEndPoint>();
            txtServers.Text = "";
            string[] arr_ip_port = File.ReadAllLines("ip_port.txt");
            foreach(string ip_port in arr_ip_port)
            {
                if (ip_port == "")
                    break;

                txtServers.Text += ip_port + Environment.NewLine;
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ip_port.Split('_')[0]),Convert.ToInt32(ip_port.Split('_')[1]));
                nets.Add(ipEndPoint);  
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStartWork.Focus();
            initComs();
            initNets();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            string[] arr_ip_port = txtServers.Lines;
            File.WriteAllLines("ip_port.txt", arr_ip_port);
        }

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < coms.count; i++)
            {
                Thread thread = new Thread(transfer);
                thread.IsBackground = true;
                Com_Nets aCom_Nets = new Com_Nets(coms.listComs[i], nets);
                thread.Start(aCom_Nets);
            }
            pictureBox1.Image =Properties.Resources.pumb1;
            btnStartWork.Text = "RUNNING";
            btnStartWork.ForeColor = Color.Red;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (SerialPort com in coms.listComs)
            {
                com.Close();
            } 
        } 
    }
}
