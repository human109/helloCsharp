using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelloFile
{
    public partial class HelloFile : Form
    {
        String filePath = @"D:\L2EDU\helloworld\HelloFile\strdata.txt";

        public HelloFile()
        {
            InitializeComponent();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    String line = sr.ReadToEnd();

                    txtRow1.Text = line.Substring(0, 4);
                    txtRow2.Text = line.Substring(4, 4);
                    txtRow3.Text = line.Substring(8, 4);
                    txtRow4.Text = line.Substring(12, 3);
                    txtRow5.Text = line.Substring(15, 2);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(String.Format("파일을 찾을 수 없습니다. \n위치 : {0}\n{1}", filePath, ex.StackTrace));

            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생하였습니다.\n\n" + ex.StackTrace);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    ctl.Text = null;
                }
            };
        }

    }
}
