using System.Net;
using System.Net.Sockets;

namespace Multi_Con_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect("127.0.0.1", 8);
            s.Close();
            s.Dispose();
        }
    }
}
