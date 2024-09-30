using System.Net.Sockets;
using System.Text;

namespace Multi_Con_C
{
    public partial class Form1 : Form
    {
        Socket sck;
        public Form1()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sck.Connect("127.0.0.1", 8);
            MessageBox.Show("Connected");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = sck.Send(Encoding.Default.GetBytes(textBox1.Text));

            if (s > 0)
            {
                MessageBox.Show("Data Sent");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sck.Close();
            sck.Dispose();
            Close();
        }
    }
}
