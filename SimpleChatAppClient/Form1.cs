using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace SimpleChatAppClient
{
    public partial class frmClient : Form
    {
        int port = 8888;
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        TcpClient client = new TcpClient();       
        string clientName = "";
                 

        public frmClient()
        {
            InitializeComponent();
        }

        private void btnMessageSend_Click(object sender, EventArgs e)
        {
            txtMessageDisplay.Text = txtMessageDisplay.Text + txtMessageSend.Text + Environment.NewLine;
        }


        static void ReceiveData(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream networkStream = tcpClient.GetStream();
            byte[] receivedByteData = new byte[1024];
            int receivedDataSize;

            while ((receivedDataSize = networkStream.Read(receivedByteData, 0, receivedByteData.Length)) > 0)
            {
                Console.Write(Encoding.ASCII.GetString(receivedByteData, 0, receivedDataSize));
            }

        }



        public static void ConnectingClient(TcpClient client, IPAddress ip, int port)
        {
            string[] connectingInfo = new string[4];
            connectingInfo[0] = "Connecting to the server";
            connectingInfo[1] = "Connecting to the server.";
            connectingInfo[2] = "Connecting to the server..";
            connectingInfo[3] = "Connecting to the server...";
            Random rnd = new Random();
            int waitingTime = rnd.Next(1, 3) * connectingInfo.Length + 1;

            for (int i = 1; i < waitingTime; ++i)       // mock network lag 
            {
                if (i <= connectingInfo.Length) Console.Write("\r{0}    ", connectingInfo[i - 1]);
                if (i > connectingInfo.Length && i <= connectingInfo.Length * 2) Console.Write("\r{0}    ", connectingInfo[i - connectingInfo.Length - 1]);
                else if (i > connectingInfo.Length * 2) Console.Write("\r{0}    ", connectingInfo[i - connectingInfo.Length * 2 - 1]);
                Thread.Sleep(500);
            }


            try
            {
                client.Connect(ip, port);
                Console.WriteLine("\rConected to the server: {0} , port {1}     ", ip, port);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No response from server...");
                Console.WriteLine(ex.ToString());
            }


        }

        private void btnServerConnect_Click(object sender, EventArgs e)
        {
            ConnectingClient(client, ip, port);
            NetworkStream networkStream = client.GetStream();

            Thread thread = new Thread(new ParameterizedThreadStart(ReceiveData));
            thread.Start(client);


            string messageToSend;
            while (!string.IsNullOrEmpty((messageToSend = Console.ReadLine())))
            {
                byte[] buffer = Encoding.ASCII.GetBytes(clientName + ": " + messageToSend);
                networkStream.Write(buffer, 0, buffer.Length);
            }

            client.Client.Shutdown(SocketShutdown.Send);
            networkStream.Close();
            client.Close();
            Console.WriteLine("Disconnecting from server...");
            Console.ReadKey();


        }
    }
}
