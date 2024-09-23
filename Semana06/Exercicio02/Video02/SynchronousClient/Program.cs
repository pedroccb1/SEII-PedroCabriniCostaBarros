using System.Data.SqlTypes;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SynchronousClient
{
    class Program
    {
        public class SyncSocketClient
        {
            public static void StartClient()
            {
                byte[] bytes = new byte[1024];
                try
                {
                    var hostName = Dns.GetHostName();
                    IPHostEntry ipHost = Dns.GetHostEntry(hostName);
                    Console.WriteLine($"Host: {hostName}");
                    IPAddress ip = ipHost.AddressList[0];
                    IPEndPoint remoteEP = new IPEndPoint(ip, 43665);

                    Socket sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        sender.Connect(remoteEP);
                        Console.WriteLine("Socket connected!");
                        sender.RemoteEndPoint.ToString();
                        byte[] msg = Encoding.UTF8.GetBytes("This is just a test <EOF>");
                        int byteSent = sender.Send(msg);
                        int byteRec = sender.Receive(bytes);
                        Console.WriteLine($"Echoed test {Encoding.UTF8.GetString(bytes, 0, byteRec)}");

                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();
                    }
                    catch (ArgumentNullException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    catch (SocketException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to cont...");
            Console.ReadLine();
            SyncSocketClient.StartClient();
            Console.ReadLine();
        }
    }
}