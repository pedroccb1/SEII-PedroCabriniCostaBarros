using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static byte[] Buffer { get; set; }
        static Socket sck;

        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(0, 1234));
            sck.Listen(100);

            Socket accepted = sck.Accept();
            Buffer = new byte[accepted.SendBufferSize];
            int bytesRead = accepted.Receive(Buffer);
            byte[] formatted = new byte[bytesRead];
            for (int i = 0; i < bytesRead; i++)
            {
                formatted[i] = Buffer[i];
            }            
            string strData = Encoding.ASCII.GetString(formatted);
            Console.WriteLine(strData +  "\r\n");
            sck.Close();
            accepted.Close();
        }
    }
}