/**************************************************
 *              Simple server - Client
 * This project is made in process of learning about threads and socket implementation.
 * Here are the steps I have taken in the process of creating this app.
 * 
 * Taking into account server was already created, 
 * steps I took in this file:
 * 1) Creation and form objects renaming
 * 2) Decision on which button gets enabled and disabled and setting initial values
 * 3) Name and server txt information collecting 
 * 4) ClientConnector created and connect to the server enabled
 * 5) Sending message implementation and testing
 * 6) ReceiveData and PrintReceivedData in thread safe way
 * 7) Removing unused code
 * 8) Toggle Connect/Disconnect button
 * 9) ClientConnector class adapted to create/remove clients and threads
 *    for newly instantiated clients
 * 
 * ***********************************************
 * 
 * 
 *      
 * 
 * ***********************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SimpleChatFormClient
{

    public partial class frmClient : Form
    {
        volatile bool connectedThreadSafe = false;
        int port;
        IPAddress ip;
        string clientName;
        ClientConnector clientConnector = new ClientConnector();        

        public frmClient()
        {            
            InitializeComponent();
            btnMessageSend.Enabled = false;
            btnServerConnect.Enabled = false;
            txtClientName.Text = "Alice";
            txtServerIP.Text = "127.0.0.1";
            txtServerPort.Text = "8888";       
        }

        private void txtMessageDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnClientName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientName.Text) || !string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                btnClientName.Enabled = false;
                txtClientName.Enabled = false;               
                clientName = txtClientName.Text;
                btnServerConnect.Enabled = true;
                btnServerConnect.Focus();
                txtMessageDisplay.AppendText(">>Chat name set to: " + txtClientName.Text + Environment.NewLine);                

            }
            else btnServerConnect.Enabled = false;            
        }


        private void btnServerConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                string connection;                
                if (!clientConnector.Connected) // if not connected - Connect
                {
                    connectedThreadSafe = !clientConnector.Connected;   // !false = true
                    clientConnector.Client = new TcpClient();
                    try
                    {
                        if (!string.IsNullOrEmpty(txtServerIP.Text) && !string.IsNullOrEmpty(txtServerPort.Text))
                        {
                            IPAddress.TryParse(txtServerIP.Text, out ip);
                            int.TryParse(txtServerPort.Text, out port);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogClientForm.Error(ex);
                    }
                    connection = clientConnector.ConnectDiconnect(ip, port, clientName);
                    clientConnector.ReceiveDataThread = new Thread(new ParameterizedThreadStart(ReceiveData));
                    clientConnector.ReceiveDataThread.Start(clientConnector.Client);
                    txtMessageSend.Focus();
                    btnMessageSend.Enabled = true;
                    txtServerIP.Enabled = false;
                    txtServerPort.Enabled = false;
                    btnClientName.Enabled = false;
                    btnServerConnect.Text = "Disconnect";
                }
                else
                {
                    connectedThreadSafe = !clientConnector.Connected;
                    connection = clientConnector.ConnectDiconnect();
                    btnMessageSend.Enabled = false;
                    txtServerIP.Enabled = true;
                    txtServerPort.Enabled = true;
                    txtClientName.Enabled = true;
                    btnClientName.Enabled = true;
                    btnServerConnect.Text = "Connect";
                }
                txtMessageDisplay.AppendText(">>" + connection.ToString() + Environment.NewLine);                
            }
            catch (Exception ex)
            {
                LogClientForm.Error(ex);
            }
            
        }



        private void btnMessageSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientConnector.Connected)
                {
                    if (!string.IsNullOrEmpty(txtMessageSend.Text) || !string.IsNullOrWhiteSpace(txtMessageSend.Text))
                    {
                        NetworkStream networkStream = clientConnector.Client.GetStream();
                        byte[] buffer = Encoding.ASCII.GetBytes(clientConnector.GetName() + ": " + txtMessageSend.Text);
                        networkStream.Write(buffer, 0, buffer.Length);
                        txtMessageSend.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                LogClientForm.Error(ex);
            }                       
        }


        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientConnector.ConnectDiconnect();
        }

        private void txtMessageSend_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMessageSend.PerformClick();
                // Remove the unpleasent sound
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        delegate void StringArgReturningVoidDelegate(string text);



        public void ReceiveData(object client)
        {
            try
            {                
                TcpClient tcpClient = (TcpClient)client;
                NetworkStream networkStream = tcpClient.GetStream();  
                byte[] receivedByteData = new byte[1024];
                int receivedDataSize;
                while ((receivedDataSize = networkStream.Read(receivedByteData, 0, receivedByteData.Length)) > 0 && connectedThreadSafe)
                {
                    try
                    {
                        PrintReceivedData(Encoding.ASCII.GetString(receivedByteData, 0, receivedDataSize));
                        LogClientForm.Message(Encoding.ASCII.GetString(receivedByteData, 0, receivedDataSize));
                    }
                    catch (Exception ex)
                    {
                        LogClientForm.Error(ex);
                    }
                }
                networkStream.Flush();
                networkStream.Close();                
            }
            catch (Exception ex)
            {
                LogClientForm.Error(ex);
            }

        }

 
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
                txtMessageDisplay.AppendText( text);
            }
        }

    }
}
