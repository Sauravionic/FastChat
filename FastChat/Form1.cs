using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace FastChat
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            
            foreach(IPAddress ip in localIP)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPTextBox.Text = ip.ToString();
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            //set up scoket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get user IP

            ServerIPTextBox.Text = GetLocalIP();
            ClientIPTextBox.Text = GetLocalIP();
        }


        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            //bind the socket
            epLocal = new IPEndPoint(IPAddress.Parse(ServerIPTextBox.Text), Convert.ToInt32(ServerPortTextBox.Text));
            sck.Bind(epLocal);

            //Connecting to remote ip
            epRemote = new IPEndPoint(IPAddress.Parse(ClientIPTextBox.Text), Convert.ToInt32(ClientPortTextBox.Text));
            sck.Connect(epRemote);

            //Listening the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            MessageBox.Show("Connected");
            ChatScreenTextBox.Items.Add("\n" + "Connected");
            ConnectBtn.Enabled = false;
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //Converting byte[] to string
                ASCIIEncoding aEnconding = new ASCIIEncoding();
                string receivedMessage = aEnconding.GetString(receivedData);

                //Adding this message into ListBox

                ChatScreenTextBox.Items.Add("\n" + "Friend: " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }


        private void SendBtn_Click(object sender, EventArgs e)
        {


            //Convert string message to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(MessageTextBox.Text);

            //Sending the Encoded Message
            sck.Send(sendingMessage);

            //adding to the listboxs
            ChatScreenTextBox.Items.Add("\n" + "Me: " + MessageTextBox.Text);
            MessageTextBox.Text = "";
        }





        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList) {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }







        /*
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Any, Convert.ToInt32(ServerPortTextBox.Text));
                listener.Start();
                client = listener.AcceptTcpClient();
                //Socket socket = listener.AcceptSocket();
                //System.Diagnostics.Trace.WriteLine(IPAddress.Any);
                //NetworkStream ns = new NetworkStream(socket);
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(ClientIPTextBox.Text), Convert.ToInt32(ClientPortTextBox.Text));

            try
            {
                ChatScreenTextBox.AppendText("Connect To Server" + "\n");
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.ChatScreenTextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreenTextBox.AppendText("You: " + receive + "\n");
                    }));
                    receive = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if(client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreenTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreenTextBox.AppendText("Me: " + TextToSend + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending Failed");
            }

            backgroundWorker2.CancelAsync();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(MessageTextBox.Text))
            {
                TextToSend = MessageTextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessageTextBox.Text = "";
        }
        */
    }
}
