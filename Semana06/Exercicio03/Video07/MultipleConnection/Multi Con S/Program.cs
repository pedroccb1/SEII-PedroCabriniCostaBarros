using System;
using System.Net.Sockets;


namespace Multi_Con_S
{
    class Program
    {
        static Listener l;
        static List<Socket> sockets;
        static void Main(string[] args) 
        {
            l = new Listener(8);
            l.SocketAccepted += new Listener.SocketAcceptHandler(l_SocketAccepted);
            l.Start();
            sockets = new List<Socket>();

            Console.Read();
        }

        private static void l_SocketAccepted(Socket e)
        {
            Console.WriteLine("New Connection: {0}\n{1}\n===========", e.RemoteEndPoint, DateTime.Now);
            sockets.Add(e);
        }
    }
}
