using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Text_Client
{
    public partial class Form1 : Form
    {
        Socket sck;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sck.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8));
            }
            catch
            {
                MessageBox.Show("Unable to connect");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.Default.GetBytes(richTextBox1.Text);

            sck.Send(BitConverter.GetBytes(data.Length), 0, 4, 0);
            sck.Send(data);
        }
    }
}
