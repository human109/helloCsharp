using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloStr
{
    public partial class HelloStr : Form
    {
        private string str = "가나다라1234ABCD전주영이택";
        private string str2 = "21234+578";

        public HelloStr()
        {
            InitializeComponent();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            txtRow1.Text = str.Substring(0, 4); // 한글
            txtRow2.Text = str.Substring(8, 4); // 영어 
            txtRow3.Text = str.Substring(4, 4); // 숫자
            txtRow4.Text = str.Substring(12, 3); // 이름1
            txtRow5.Text = str.Substring(15, 2); // 이름2

            txtRow6.Text = calcStr(str2).ToString();
        }

        private int calcStr(String str)
        {
            
            int result = 0;
            
            String ed1 = "";
            String ed2 = "";
            int idx = str.IndexOf('+');

            ed1 = str.Substring(0, idx);
            ed2 = str.Substring(idx + 1);
            
            result = Convert.ToInt32(ed1) + Convert.ToInt32(ed2);
            
            return result;
        }
    }
}
