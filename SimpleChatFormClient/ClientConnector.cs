namespace SimpleChatFormClient
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    public class ClientConnector
    {
        public bool Connected { get; set; } = false;       

        public TcpClient Client { get; set; }

        public Thread ReceiveDataThread { get; set; }

        IPAddress ip;
        int port;

        string name;

        public string GetName() { return this.name; }


        public string ConnectDiconnect(IPAddress ip, int port, string name)
        {
            try
            {
                if (!this.Connected)
                {
                    this.ip = ip;
                    this.port = port;
                    if (name != null || name != "") this.name = name;
                    this.Connected = true;
                    Client.Connect(ip, port);
                    return "Conected to the server: " + ip + " , port: " + port;
                }
                else
                {
                    this.Connected = false;
                    //this.ReceiveDataThread.Abort();
                    this.Client.Client.Shutdown(SocketShutdown.Both);
                    this.Client.Close();
                    return "Disonnected from the server...";
                }
            }
            catch (Exception ex)
            {
                LogClientForm.Error(ex);
                return "Something went wrong: " + ex.ToString();
            }
        }


        public string ConnectDiconnect()
        {
            try
            {
                this.Connected = false;
                this.Client.Client.Shutdown(SocketShutdown.Both);
                this.Client.Close();

                return "Disonnected from the server...";
            }
            catch (Exception ex)
            {
                LogClientForm.Error(ex);
                return "Something went wrong: " + ex.ToString();
            }
        }

    }
}
