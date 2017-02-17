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
using System.IO;


namespace HelloServer
{
    public partial class HelloAsyncServer : Form
    {
        // 서버 소켓
        Socket m_ServerSocket;
        // 다중클라이언트이므로 리스트로 클라이언트 소켓 생성
        List<Socket> m_clientSocket = new List<Socket>();
        // 포트설정
        Int16 port = 12345;
        // 로컬 IP설정
        IPAddress localaddr = IPAddress.Parse("127.0.0.1");
        // 로그파일 설정
        static String filePath = @"D:\L2EDU\helloworld\HelloLog\log.txt";
        // 소켓으로 받아올 데이터 변수
        byte[] szData;

        public HelloAsyncServer()
        {
            // 컴포넌트 초기화
            InitializeComponent();
           
            lblStatus.Text = "서버중지";
            lblStatus.ForeColor = Color.Red;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #region 서버 동작 메소드
        /// <summary>
        /// 서버 시작 메소드
        /// </summary>
        private void serverStart()
        {
            // 서버 소켓 생성(주소지정체계 : IPv4, 소켓의 유형 : 스트림, 프로토콜 : TCP)
            m_ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 로컬의 연결지점 생성(로컬Address, PORT)
            IPEndPoint ipep = new IPEndPoint(localaddr, port);
            
            // 바인드
            m_ServerSocket.Bind(ipep);
            // 20개의 연결에대한 Listen을 시작
            m_ServerSocket.Listen(20);

            // 비동기 이벤트 생성
            SocketAsyncEventArgs args = new SocketAsyncEventArgs();
            // 비동기 작업이 완료되는 이벤트 핸들러 콜백
            args.Completed += new EventHandler<SocketAsyncEventArgs>(Accept_Completed);
            // 들어오는 연결에 대해 허용 하는 비동기 작업
            m_ServerSocket.AcceptAsync(args);
        }

        /// <summary>
        /// 서버 종료 메소드(작성중)
        /// </summary>
        private void serverStop()
        {

        }
        #endregion


        #region 연결허용 콜백
        /// <summary>
        /// 연결 허용에 대한 이벤트 콜백 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Accept_Completed(object sender, SocketAsyncEventArgs e)
        {
            // 연결된 클라이언트 소켓 생성
            Socket clientSocket = e.AcceptSocket;
            // 리스트에 클라이언트 소켓 추가
            m_clientSocket.Add(clientSocket);

            if (m_clientSocket != null)
            {
                // 비동기 이벤트 생성
                SocketAsyncEventArgs args = new SocketAsyncEventArgs();
                // 비동기 소켓 메서드와 함께 사용하기 위한 버퍼 생성
                szData = new Byte[1024];
                args.SetBuffer(szData, 0, 1024);
                // 비동기 소켓 작업에 사용된 객체 설정
                args.UserToken = m_clientSocket;
                // 비동기 완료 이벤트 콜백 설정
                args.Completed += new EventHandler<SocketAsyncEventArgs>(Receive_Completed);
                // 연결된 소켓으로 부터 데이터를 받을 요청을 시작하는 이벤트
                clientSocket.ReceiveAsync(args);
            }

            e.AcceptSocket = null;
            m_ServerSocket.AcceptAsync(e);
        }
        /// <summary>
        /// 데이터 수신 완료 콜백
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Receive_Completed(object sender, SocketAsyncEventArgs e)
        {
            // 클라이언트 소켓 선언
            Socket clientSocket = sender as Socket;

            // 데이터전송이 완료되었는지 여부 체크
            if (clientSocket.Connected && e.BytesTransferred > 0)
            {
                szData = e.Buffer;
                string sData = Encoding.Unicode.GetString(szData);
                
                // 메시지 처리
                Console.WriteLine(sData);
                msgProc(sData);

                for (int i = 0; i < szData.Length; i++)
                {
                    szData[i] = 0;
                }

                e.SetBuffer(szData, 0, 1024);
                clientSocket.ReceiveAsync(e);
            }
            else
            {
                clientSocket.Disconnect(false);
                clientSocket.Dispose();
                m_clientSocket.Remove(clientSocket);
            }
        }

       
        #endregion

        #region 메시지 처리 메소드
        /// <summary>
        /// 메시지 처리 메소드
        /// </summary>
        /// <param name="sData"></param>
        
        private void msgProc(string sData)
        {
            // 전문ID 추출
            String msgID = sData.Substring(0, 4);
            
            // 전문 ID 확인
            if (msgID.Equals("TR01"))
            {
                // 순번 추출
                String msgIDX = sData.Substring(4, 2);
                // 온도값 추출
                String msgData = sData.Substring(6, 4);

                // 순번 별 화면에 출력
                switch (msgIDX){
                    case "01":
                        setMsg(txtRow1, msgData);
                        break;
                    case "02":
                        setMsg(txtRow2, msgData);
                        break;
                    case "03":
                        setMsg(txtRow3, msgData);
                        break;
                    case "04":
                        setMsg(txtRow4, msgData);
                        break;
                    case "05":
                        setMsg(txtRow5, msgData);
                        break;
                    case "06":
                        setMsg(txtRow6, msgData);
                        break;
                    default:
                        break;
                }
            }
            else if (msgID.Equals("TR02"))
            {
                // 이벤트 추출
                String msgEvent = sData.Substring(4, 1);
                // 이벤트 텍스트박스에 저장
                setMsg(txtRow7, msgEvent);
            }
            else
            {
            }

           
        }

        /// <summary>
        /// 폼 텍스트박스에 출력하는 메소드
        /// 
        /// </summary>
        /// <param name="o">텍스트박스 객체</param>
        /// <param name="str">문자열</param>
        private delegate void SetMsgCallBack(Object o, string str);
        private void setMsg(Object o, string str)
        {
            TextBox txtBox = o as TextBox;
            
            // Invoke 필요여부 확인
            if (txtBox.InvokeRequired)
            {
                // 콜백함수 생성
                SetMsgCallBack d = new SetMsgCallBack(setMsg);
                // Invoke 실행
                this.Invoke(d, new object[] { txtBox, str });
            }
            else
            {
                // 실제 데이터 입력
                txtBox.Text = str;
            }

        }

            #region 로깅 메소드
            /// <summary>
            /// 메시지를 파일에 로깅 메소드
            /// </summary>
            /// <param name="sData"></param>
            private void setLog(string sData)
            {
                try
                {
                    using (StreamWriter w = File.AppendText(filePath))
                    {
                        Log(sData, w);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(String.Format("파일을 찾을 수 없습니다. \n{0}\n{1}", filePath, ex.StackTrace));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류가 발생했습니다. \n\n" + ex.StackTrace);

                }
            }
            private void Log(String str, TextWriter w)
            {
                w.Write("{0}\n", str);
            }
            #endregion

            #region 데이터 출력 메소드
            /// <summary>
            /// listbox에 로그하는 메소드
            /// </summary>
            /// <param name="text"></param>
            private delegate void SetTextCallBack(string sData);
            private void setText(string sData)
            {
                if (listLog.InvokeRequired)
                {
                    SetTextCallBack d = new SetTextCallBack(setText);
                    this.Invoke(d, new object[] { sData });
                }
                else
                {
                    listLog.Items.Insert(0, String.Format("{0}",  sData));
                }
            }
            #endregion

        #endregion

        #region 버튼 클릭 이벤트

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 서버시작함수 호출
            serverStart();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                m_ServerSocket.Shutdown(SocketShutdown.Both);
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            m_ServerSocket.Close();
        }
        #endregion

        #region 서버 동작여부 체크
        /// <summary>
        /// 서버 동작 여부 체크 타이머
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_ServerSocket != null)
            {
                lblStatus.Text = "서버 동작 중..";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "서버 종료";
                lblStatus.ForeColor = Color.Red;

            }
        }
        #endregion

        #region 저장신호 처리
        private void txtRow7_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            string txt = txtBox.Text;

            if (txt.Equals("1"))
            {
                List<string> sdata = new List<string>();

                int i = 0;
                foreach (Control ctl in this.Controls)
                {
                    if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                    {
                        if(ctl.Name != "txtRow7")
                            sdata.Add(ctl.Text);
                    }
                };
                DateTime today = DateTime.Now;
                setText(String.Format("[{0:G}] - {1}", today, String.Join(",", sdata.ToArray().Reverse()) ));
                setLog(String.Format("[{0:G}] - {1}", today, String.Join(",", sdata.ToArray().Reverse()) ));
            }

        }
        #endregion


    }
}
