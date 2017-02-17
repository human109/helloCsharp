using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloLog
{
    public partial class HelloLog : Form
    {

        String filePath = @"D:\L2EDU\helloworld\HelloLog\log.txt";
        public HelloLog()
        {
            InitializeComponent();
        }

        #region 처리버튼 클릭
        private void btnProc_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtInput.Text))
            {
                // LISTBOX에 Index 0에 입력
                listBox.Items.Insert(0, String.Format("{0} {1} : {2}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString(), txtInput.Text));

                try
                {
                    using (StreamWriter w = File.AppendText(filePath))
                    {
                        Log(txtInput.Text, w);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(String.Format("파일을 찾을 수 없습니다. \n{0}\n{1}" ,filePath, ex.StackTrace));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류가 발생했습니다. \n\n" + ex.StackTrace);

                }

                txtInput.Text = null;
                txtInput.Focus();
            }
        }
        #endregion


        #region 파일에 LOG
        /// <summary>
        /// 문자열과  WriteStream을 받아서 LOG
        /// </summary>
        private void Log(String str, TextWriter w)
        {
            w.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.Write(" : ");
            w.Write("{0}\n", str);
        }
        #endregion


        /// <summary>
        /// 폼 로드시 기존에 있는 로그파일 listbox에 뿌려주기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloLog_Load(object sender, EventArgs e)
        {

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Peek() > -1)
                {
                    listBox.Items.Insert(0, sr.ReadLine());
                }
            }


        }

    }
}
