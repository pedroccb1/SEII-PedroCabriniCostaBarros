using System.Data.SqlTypes;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SynchronousServer
{
    class Program
    {
        public class SyncSeverSocket
        {
            public static string data = null;

            public static void StartListener()
            {
                byte[] bytes = new byte[1024];

                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 43665);
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(10);
                    while (true)
                    {
                        Console.WriteLine($"Waiting for a connection ...");
                        Socket handler = listener.Accept();
                        data = null;
                        while (true)
                        {
                            int byteRec = handler.Receive(bytes);
                            data += Encoding.UTF8.GetString(bytes, 0, byteRec);
                            if (data.IndexOf("<EOF>", StringComparison.Ordinal) > -1)
                                break;
                        }
                        Console.WriteLine($"Text received: {data}");
                        byte[] msg = Encoding.UTF8.GetBytes(data);
                        handler.Send(msg);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Press any key to exit program");
                Console.ReadLine();
            }
        }    
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to cont...");
            Console.ReadLine();
            SyncSeverSocket.StartListener();
            Console.ReadLine();
        }
    }
}
