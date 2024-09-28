using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // Socket listener, connecter, acc;
            // listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // connecter = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // listener.Bind(new IPEndPoint(0, 1994));
            // listener.Listen(0);

            // new Thread(() =>
            //     {
            //         acc = listener.Accept();
            //         Console.WriteLine("Connected");    
            //     }).Start();

            // connecter.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.150"), 1994));
            
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream,  ProtocolType.Tcp);

            sck.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1994));
            sck.Listen(0);

            Socket acc = sck.Accept();

            byte[] buffer = Encoding.Default.GetBytes("Hello Client!");
            acc.Send(buffer, 0, buffer.Length, 0);

            buffer = new byte[255];

            int rec = acc.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            Console.WriteLine("Received: {0}", Encoding.Default.GetString(buffer));

            sck.Close();
            acc.Close();

            Console.Read();
        }
        
    }
}