using System.IO;
using System.Net.Sockets;

namespace Client
{
    public partial class Form1 : Form
    {
        Client client;

        public Form1()
        {
            InitializeComponent();
            btnDisconnect.Click += new EventHandler(btnDisconnect_Click);
            btnImage.Click += new EventHandler(btnImage_Click);
            btnSendText.Click += new EventHandler(btnSendText_Click);
            btnConnect.Click += new EventHandler(btnConnect_Click);
            client = new Client();
            client.OnConnect += new Client.OnConnectEventHandler(client_OnConnect);
            client.OnSend += new Client.OnSendEventHandler(client_OnSend);
            client.OnDisconnect += new Client.OnDisconnectEventHandler(client_OnDisconnect);
        }

        private void client_OnDisconnect(Client sender)
        {
            MessageBox.Show("Disconnected");
        }

        private void client_OnSend(Client sender, int sent)
        {
            Invoke((MethodInvoker)delegate
            {
                lblDataSent.Text = string.Format("Data Sent: {0}", sent);
            });
        }

        private void client_OnConnect(Client sender, bool connected)
        {
            if (connected)
                MessageBox.Show("Connected Accepted");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                client.Connect("127.0.0.1", 8192);
            }
        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            SendText(txtBox.Text);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SendImage(o.FileName);
                }
            }
        }

        private void btnDisconnect_Click(object? sender, EventArgs e)
        {
            client.Disconnect();
        }

        void SendText(string text)
        {
            BinaryWriter bw = new BinaryWriter(new MemoryStream());
            bw.Write((int)Commands.String);
            bw.Write(text);
            bw.Close();
            byte[] data = ((MemoryStream)bw.BaseStream).ToArray();
            bw.BaseStream.Dispose();
            client.Send(data, 0, data.Length);
            data = null;
        }

        void SendImage(string path)
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            byte[] b = File.ReadAllBytes(path);
            bw.Write((int)Commands.Image);
            bw.Write((int)b.Length);
            bw.Write(b);
            bw.Close();
            b = ms.ToArray();
            ms.Dispose();

            client.Send(b, 0, b.Length);
        }
    }
}
