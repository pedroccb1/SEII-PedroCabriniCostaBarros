using System.Net;
using System.Net.Sockets;
using System.Text;

namespace YoutubeServer
{
    internal class Program
    {
        static Socket sck;
        static Socket acc;
        static int port = 9000;
        static IPAddress ip;
        static Thread rec;

        static string GetIp()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();
        }

        static void recV()
        {

        }

        static void Main(string[] args)
        {
            rec = new Thread(recV);
            Console.WriteLine("Your Local Ip is: " + GetIp());
            Console.WriteLine("Please Enter Your Host Port");
            string inputPort = Console.ReadLine();

            try
            {
                port = Convert.ToInt32(inputPort);
            }
            catch
            {
                port = 9000;
            }

            ip = IPAddress.Parse(GetIp());
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(ip, port));
            sck.Listen(0);
            acc = sck.Accept();

            while (true)
            {
                byte[] sdata = Encoding.ASCII.GetBytes(Console.ReadLine());
                acc.Send(sdata, 0, sdata.Length, 0);
            }
        }
    }
}
