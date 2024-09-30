using System.Net;
using System.Net.Sockets;
using System.Text;

namespace YoutubeClient
{
    internal class Program
    {
        static string name = "";
        static int port = 9000;
        static IPAddress ip;
        static Socket sck;
        static Thread rec;
        
        static void recV()
        {
            while (true)
            {
                Thread.Sleep(500);
                byte[] Buffer = new byte[255];
                int rec = sck.Receive(Buffer, 0, Buffer.Length, 0);
                Array.Resize(ref Buffer, rec);
                Console.WriteLine(Encoding.Default.GetString(Buffer));
            }
        }

        static void Main(string[] args)
        {
            rec = new Thread(recV);
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the ip of the server");
            ip = IPAddress.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The Port");
            string inputPort = Console.ReadLine();
            try
            {
                port = Convert.ToInt32(inputPort);
            }
            catch
            {
                port = 9000;
            }

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Connect(new IPEndPoint(ip, port));
            rec.Start();
            byte[] conmsg = Encoding.Default.GetBytes("<" + name + ">" + "Connected");
            sck.Send(conmsg, 0, conmsg.Length, 0);

            while (sck.Connected)
            {
                byte[] sdata = Encoding.Default.GetBytes("<"+name+">"+Console.ReadLine());
                sck.Send(sdata, 0, sdata.Length, 0);
            }


        }
    }
}
