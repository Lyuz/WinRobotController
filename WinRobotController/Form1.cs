using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRobotController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void counterButton_Click(object sender, EventArgs e)
        {
            sendMessage("Counter");
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            sendMessage("forward");
        }

        private void clockwiseButton_Click(object sender, EventArgs e)
        {
            sendMessage("clockwise");
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            sendMessage("left");
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            sendMessage("right");
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            sendMessage("up");
        }

        private void backwardsButton_Click(object sender, EventArgs e)
        {
            sendMessage("backward");
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            sendMessage("down");
        }
        //This function opens a connection to port 12000 and sends a message
        //after the complition of the message the port will close
        private void sendMessage(string msg)
        {
            const int PORT_NO = 12000;
            const string SERVER_IP = "10.0.1.2";

            //---data to send to the server---
            try
            {


                //---create a TCPClient object at the IP and port no.---
                TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
                NetworkStream nwStream = client.GetStream();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(msg);

                //---send the text---
                Console.WriteLine("Sending : " + msg);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);

                //---read back the text---
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
                Console.ReadLine();
                client.Close();
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
