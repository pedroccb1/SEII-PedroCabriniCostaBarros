using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client
{
    enum Commands
    {
        String = 0,
        Image
    }
    class Client
    {
        public delegate void OnConnectEventHandler(Client sender, bool coonected);
        public event OnConnectEventHandler OnConnect;

        public delegate void OnSendEventHandler(Client sender, int sent);
        public event OnSendEventHandler OnSend;

        public delegate void OnDisconnectEventHandler(Client sender);
        public event OnDisconnectEventHandler OnDisconnect;

        Socket socket;

        public bool Connected
        {
            get
            {
                if (socket != null)
                {
                    return socket.Connected;
                }

                return false;
            }
        }

        public Client()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect(string ipAdress, int port)
        {
            if (socket == null)
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.BeginConnect(ipAdress, port, connectCallback, null);
        }

        void connectCallback(IAsyncResult ar)
        {
            try
            {
                socket.EndConnect(ar);

                if (OnConnect != null)
                {
                    OnConnect(this, Connected);
                }
            }
            catch 
            { 
            }
        }

        public void Send(byte[] data, int index, int length)
        {
            socket.BeginSend(BitConverter.GetBytes(length), 0, 4, SocketFlags.None, sendCallback, null);
            socket.BeginSend(data, index, length, SocketFlags.None, sendCallback, null);
        }

        void sendCallback(IAsyncResult ar)
        {
            try
            {
                int sent = socket.EndSend(ar);

                if (OnSend != null)
                {
                    OnSend(this, sent);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("SEND ERROR\n{0}", ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                if (socket.Connected)
                {
                    socket.Close();
                    socket = null;
                    if (OnDisconnect != null)
                    {
                        OnDisconnect(this);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
