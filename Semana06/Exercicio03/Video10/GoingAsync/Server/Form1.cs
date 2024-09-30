using System.IO;
using System.Net.Sockets;

namespace Server
{
    public partial class Form1 : Form
    {
        Listener listener;
        Client client;
        public Form1()
        {
            InitializeComponent();
            btnListen.Click += new EventHandler(btnListen_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }

            if (listener != null && listener.Running)
                listener.Stop();
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }
            listener.Stop();

            lblInfo.Text = "Connected: NULL";

            lstText.Items.Clear();
            pbImage.Image = null;

        }

        private void btnListen_Click(object? sender, EventArgs e)
        {
            listener = new Listener();
            listener.Accepted += new Listener.SocketAcceptedHandler(listener_Accepted);
            listener.Start(8192);
        }

        private void listener_Accepted(Socket e)
        {
            if (client != null)
            {
                e.Close();
                return;
            }

            client = new Client(e);
            client.DataRecieved += new Client.DataRecievedEventHandler(client_DataRecieved);
            client.Disconnected += new Client.DisconnectedEventHandler(client_Disconnected);
            client.ReceiveAsync();

            Invoke((MethodInvoker)delegate
            {
                lblInfo.Text = "Connected: " + client.EndPoint.ToString();
            });
        }

        private void client_Disconnected(Client sender)
        {
            client.Close();
            client = null;

            Invoke((MethodInvoker)delegate
            {
                lblInfo.Text = "Connected: NULL";

                DialogResult res = MessageBox.Show("Client Disconnected\nClear Data?", "", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    lstText.Items.Clear();
                    pbImage.Image = null;
                }
            });
        }

        private void client_DataRecieved(Client sender, ReceiveBuffer e)
        {
            BinaryReader r = new BinaryReader(e.BufStream);

            Commands header = (Commands)r.ReadInt32();

            switch (header)
            {
                case Commands.String:
                    {
                        string s = r.ReadString();
                        Invoke((MethodInvoker)delegate
                        {
                            lstText.Items.Add(s);
                        });
                    }
                    break;
                case Commands.Image:
                    {
                        int imageBytesLen = r.ReadInt32();

                        byte[] iBytes = r.ReadBytes(imageBytesLen);

                        Invoke((MethodInvoker)delegate
                        {
                            pbImage.Image = Image.FromStream(new MemoryStream(iBytes));
                        });

                        iBytes = null;
                    }
                    break;
            }
        }
    }
}
