using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_GUI
{
    public partial class Form1 : Form
    {
        Socket sock;
        public Form1()
        {
            InitializeComponent();
            sock = socket();
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            sock.Close();
        }

        Socket socket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sock.Connect(new IPEndPoint(IPAddress.Parse(textBox1.Text),3));
                new Thread(() =>
                    {
                        read();
                    }).Start();
            }
            catch
            {
                MessageBox.Show("CONNECTION FAILED!");
            }

        }

        void read()
        {
            while (true) 
            { 
                try
                {
                    byte[] buffer = new byte[255];
                    int rec = sock.Receive(buffer, 0, buffer.Length, 0);
                    if (rec <= 0) 
                    {
                        throw new SocketException();
                    }
                    Array.Resize(ref buffer, rec);

                    Invoke((MethodInvoker)delegate
                    {
                        listBox1.Items.Add(Encoding.Default.GetString(buffer));
                    });
                }
                catch
                {
                    MessageBox.Show("DISCONNECTION!");
                    sock.Close();
                    break;
                }
            }
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.Default.GetBytes(textBox2.Text);
            sock.Send(data, 0, data.Length, 0);

        }

        
    }
}
