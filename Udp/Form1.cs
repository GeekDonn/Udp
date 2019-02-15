using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Udp
{
    public partial class Form1 : Form
    {
        public delegate void myDelegate();
        public delegate void SetTextCallback(String text);
        public Form1()
        {
            InitializeComponent();
        }
        static bool exitFlag = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ip1.Text.Trim()))
            {
                MessageBox.Show("未输入ip!","error");
                return;
            }
            Send();
        }
        static UdpClient udpClient = null;
        public  void Receive(TextBox textbox)
        {
            udpClient = new UdpClient(servicePoint);
            
            //IPEndPoint senderPoint = new IPEndPoint(IPAddress.Parse("14.55.36.2"), 0);
            IPEndPoint senderPoint = new IPEndPoint(IPAddress.Any, 0);
            while (exitFlag)
            {
                try
                {
                    byte[] recvData = udpClient.Receive(ref senderPoint);
                    if (recvData.Length > 0)
                    {
                        SetText(Encoding.Default.GetString(recvData));
                        Console.WriteLine("Receive Message:{0}", Encoding.Default.GetString(recvData));
                        Console.Read();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        //IPEndPoint udpPoint = new IPEndPoint(IPAddress.Parse(ip1), 4505);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (isCmd.Checked)
                {
                    text+=Environment.NewLine+Common.RunCmd(text);
                }
                this.textBox2.Text +=  Environment.NewLine+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+Environment.NewLine+text;
            }
        }
        static IPEndPoint servicePoint = null;
        public void Send()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);  //向此网段发广播包
            int UDPListenerPort = 80;
            IPAddress broadcast = IPAddress.Parse(ip1.Text.Trim()); //此处根据IP及子网掩码改为相应的广播IP
            string ts = textBox1.Text;
            byte[] sendbuf = Encoding.Default.GetBytes(ts);
            IPEndPoint ep = new IPEndPoint(broadcast, UDPListenerPort);
            s.SendTo(sendbuf, ep);
            //UdpClient udpClient = new UdpClient(udpPoint);
            ////UdpClient udpClient = new UdpClient();
            //string sendMsg = textBox1.Text;
            //byte[] sendData = Encoding.Default.GetBytes(sendMsg);
            
            //udpClient.Send(sendData, sendData.Length, servicePoint);
            //Console.WriteLine("Send Message:{0}", sendMsg);
            //Console.Read();
        }
        Thread thread = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            //myDelegate m = new myDelegate(Receive);
            //this.BeginInvoke(m);
            String ip = Common.GetAll();
            String[] ips = ip.Split(' ').Where(t=>t.Contains(".")).ToArray();
            ip1.Items.AddRange(ips);
            button2_Click(sender,e);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitFlag = false;
            if (udpClient!=null)
            {
                udpClient.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_FormClosed(sender, null);
            exitFlag = true;
            servicePoint = new IPEndPoint(IPAddress.Parse(GetIp()), 80);
            thread = new Thread(new ThreadStart(delegate { Receive(textBox2); }));
            thread.Start();
            label1.Text = "连接成功。";
            
        }

        private String GetIp() {
            String ip = String.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    ip = _IPAddress.ToString();
                }
            }
            return ip;

        }
    }
}
