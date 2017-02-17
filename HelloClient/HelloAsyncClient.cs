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
using System.Threading;

namespace HelloClient
{
    public partial class HelloAsyncClient : Form
    {

        TcpClient client;
        Int32 port = 12345;
        IPAddress server = IPAddress.Parse("127.0.0.1");
        private Socket m_ClientSocket;
        int id = 0;

        public HelloAsyncClient()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            send(txtMessage.Text);

            txtMessage.Text = "";
            txtMessage.Focus();
        }

        private void send(String msg)
        {
            SocketAsyncEventArgs args = new SocketAsyncEventArgs();
            byte[] szData = Encoding.Unicode.GetBytes(msg);
            args.SetBuffer(szData, 0, szData.Length);
            m_ClientSocket.SendAsync(args);

        }

        private void HelloAsyncClient_Load(object sender, EventArgs e)
        {
            m_ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipep = new IPEndPoint(server, port);

            SocketAsyncEventArgs args = new SocketAsyncEventArgs();
            args.RemoteEndPoint = ipep;

            m_ClientSocket.ConnectAsync(args);
        }


        #region 데이터 전송 타이머
        private void datasendTimer_Tick(object sender, EventArgs e)
        {
            // 전문 생성
            // 전문ID
            string msg = "TR01";
            // 전문순번
            msg += (id+1).ToString().PadLeft(2,'0');
            // 랜덤한 온도값 생성
            Random rnd = new Random();
            int temp = rnd.Next(1000, 1300);
            msg += temp.ToString().PadLeft(4, '0');
            
            // 메시지 전송
            Console.WriteLine(msg);
            send(msg);

            // 전문 순번 증가(6이되면 다시 처음부터)
            if (++id == 6) id = 0;

        }

        /// <summary>
        /// ON 이벤트 전송 타이머
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string msg = "TR021";
            send(msg);
            eventSendTimer.Enabled = false;
            offeventTimer.Enabled = true;

        }
        
        #endregion

        private void offeventTimer_Tick(object sender, EventArgs e)
        {
            string msg = "TR020";
            send(msg);
            eventSendTimer.Enabled = true;
            offeventTimer.Enabled = false;
        }
    }
}
