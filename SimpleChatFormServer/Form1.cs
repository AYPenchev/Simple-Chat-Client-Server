/**************************************************
 *              Simple Form Server
 *  
 **************************************************
 * 1) Server Stop to be implemented               
 * 2) Visual presentation of connected clients
 * 3) Show client name in presentation textbox
***************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SimpleChatFormServer
{
    
    public partial class FrmServer : Form
    {
        volatile bool started = false;
        int port;
        public volatile string messageArrived;
        static readonly Dictionary<int, TcpClient> clientTable = new Dictionary<int, TcpClient>();
        int clientCount = 1;        
        TcpListener ServerSocket;
        

        public FrmServer()
        {
            InitializeComponent();
            txtServerIP.Text = "127.0.0.1";
            txtServerPort.Text = "8888";
            port = Convert.ToInt32(txtServerPort.Text);
        }

        private void btnServerStart_Click(object sender, EventArgs e)
        {
            started = !started;
            if (started)
            {
                txtMessageDisplay.Clear();
                ServerSocket = new TcpListener(IPAddress.Any, port);                
                Thread serverListenThread = new Thread(ListenForClients);
                serverListenThread.Start(ServerSocket);                           
                ToggleStartButton();
            }
            else
            {   
                foreach (var item in clientTable)
                {
                    item.Value.GetStream().Close();
                }
                clientTable.Clear();    // remove all connections                
                clientCount = 1;
                LogServerForm.Message("Server Stopped...");
                PrintReceivedData("Server Stopped...");
                ServerSocket.Stop();
                ToggleStartButton();
            }
        }

        private void txtServerIP_TextChanged(object sender, EventArgs e)
        {
            SocketInfoDependChangeStartButton();
        }

        

        private void txtServerPort_TextChanged(object sender, EventArgs e)
        {
            SocketInfoDependChangeStartButton();
        }


        public void ListenForClients(object serverSocket)
        {
            TcpListener tcpListener = (TcpListener)serverSocket;                        
            tcpListener.Start();
            PrintReceivedData("Server started Listening...");
            while (started)
            {
                try
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    clientTable.Add(clientCount, client);
                    Thread clientListShow = new Thread(AddClientToList);
                    clientListShow.Start(clientCount);
                    LogServerForm.Message($"Client - ClientID_{clientCount} connected!");
                    PrintReceivedData($"Client - ClientID_{clientCount} connected!");                    
                    Thread clientThread = new Thread(HandleClients);
                    clientThread.Start(clientCount);
                    clientCount++;
                }
                catch (Exception ex)
                {
                    LogServerForm.Error(ex);
                }

            }               
        }



        public void HandleClients(object obj)
        {
            try
            {
                int clientID = (int)obj;
                TcpClient client;
                client = clientTable[clientID];

                while (started)
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        byte[] buffer = new byte[1024];
                        int bufferNoOfBytes = stream.Read(buffer, 0, buffer.Length);
                        if (bufferNoOfBytes == 0) break;
                        string data = Encoding.ASCII.GetString(buffer, 0, bufferNoOfBytes);
                        Broadcast(data);
                        LogServerForm.Message(data);
                        PrintReceivedData(data);                        
                    }
                    catch (Exception ex)
                    {
                        LogServerForm.Error(ex);
                    }
                }
                LogServerForm.Message($"Client - ClientID_{clientID} disconnected!");
                PrintReceivedData($"Client - Client ID_{clientID} disconnected!");                
                clientTable.Remove(clientID);
                ClientAppendToList(clientID.ToString());
                client.GetStream().Close();
                client.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                LogServerForm.Error(ex);
            }
        }


        public static void Broadcast(string data)
        {
            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(data + Environment.NewLine);
                foreach (TcpClient client in clientTable.Values)
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                LogServerForm.Error(ex);
            }

        }

        delegate void StringArgReturningVoidDelegate(string text);

        private void PrintReceivedData(string text)
            {
                // InvokeRequired required compares the thread ID of the  
                // calling thread to the thread ID of the creating thread.  
                // If these threads are different, it returns true.  
                if (txtMessageDisplay.InvokeRequired)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(PrintReceivedData);
                    Invoke(d, new object[] { text });
                }
                else
                {
                    txtMessageDisplay.AppendText(text + Environment.NewLine);
                }
            }

        private void AddClientToList(object obj)
        {
            ClientAppendToList("Client ID: " + obj.ToString());
        }

        private void ClientAppendToList(string text)
        {
            if (txtClientList.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(ClientAppendToList);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtClientList.Clear();
                foreach (var item in clientTable.Keys)
                {                    
                    txtClientList.AppendText("Client ID_" + item.ToString() + Environment.NewLine);
                }                
            }
        }

        private void SocketInfoDependChangeStartButton()
        {
            if (!string.IsNullOrEmpty(txtServerIP.Text) || !string.IsNullOrEmpty(txtServerPort.Text))
            {
                btnServerStart.Enabled = true;
            }
            else
            {
                btnServerStart.Enabled = false;
            }
        }

        private void ToggleStartButton()
        {                 
            txtServerIP.Enabled = !txtServerIP.Enabled;
            txtServerPort.Enabled = !txtServerPort.Enabled;
            if (started)
            {
                btnServerStart.Text = "Stop";
            }
            else
            {
                btnServerStart.Text = "Start";
            }
        }
    }
}
