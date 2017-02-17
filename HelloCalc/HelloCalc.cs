using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCalc
{
    public partial class HelloCalc : Form
    {

        List<Decimal> listNumber;
        
        // PLUS : 1, MINUS : 2, MULTIPLY : 3, DIVIDE : 4
        List<int> listOperator;

        public HelloCalc()
        {
            InitializeComponent();

            btn1.Click += btnNumber_Click;
            btn2.Click += btnNumber_Click;
            btn3.Click += btnNumber_Click;
            btn4.Click += btnNumber_Click;
            btn5.Click += btnNumber_Click;
            btn6.Click += btnNumber_Click;
            btn7.Click += btnNumber_Click;
            btn8.Click += btnNumber_Click;
            btn9.Click += btnNumber_Click;
            btn0.Click += btnNumber_Click;
            btnDot.Click += btnNumber_Click;

            listNumber = new List<Decimal>();
            listOperator = new List<int>();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btnNumber = sender as Button;

            if (btnNumber.Text == "." && lblResult.Text.Contains("."))
            {

            }
            else
            {
                if (lblResult.Text == "0" && btnNumber.Text == ".")
                {
                   lblResult.Text += btnNumber.Text;
                }
                else if (lblResult.Text == "0")
                {
                    lblResult.Text = btnNumber.Text;
                }
                else
                {
                    lblResult.Text += btnNumber.Text;
                }
            }
        }
      
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            memClear();
            lblResult.Text = "0";
        }
        /// <summary>
        /// 입력창 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {

            if (!lblResult.Text.Equals(""))
            {
                String text = lblResult.Text;

                lblResult.Text = text.Substring(0, text.Length - 1);
            }
        }
        /// <summary>
        /// 현재 값과 연산자 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!lblResult.Text.Equals(""))
            {
                listNumber.Add(Decimal.Parse(lblResult.Text));
                listOperator.Add(1);
                lblResult.Text = "0";
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!lblResult.Text.Equals(""))
            {
                listNumber.Add(Decimal.Parse(lblResult.Text));
                listOperator.Add(2);
                lblResult.Text = "0";
            }
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!lblResult.Text.Equals(""))
            {
                listNumber.Add(Decimal.Parse(lblResult.Text));
                listOperator.Add(3);
                lblResult.Text = "0";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!lblResult.Text.Equals(""))
            {
                if (Decimal.Parse(lblResult.Text) == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.");
                }
                else
                {
                    listNumber.Add(Decimal.Parse(lblResult.Text));
                    listOperator.Add(4);
                    lblResult.Text = "0";
                }
            }
        }

        /// <summary>
        /// 값을 모두 연산해서 결과 값 출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult_Click(object sender, EventArgs e)
        {
            if (!lblResult.Text.Equals(""))
            {
                listNumber.Add(Decimal.Parse(lblResult.Text));

                Decimal result = listNumber[0];

                for (int i = 1; i < listNumber.Count; i++)
                {
                    switch (listOperator[i-1])
                    {
                        case 1: // PLUS
                            result += listNumber[i];
                            break;
                        case 2: // MINUS
                            result -= listNumber[i];
                            break;
                        case 3: // MULTIPLY
                            result *= listNumber[i];
                            break;
                        case 4: // DIVIDE
                            result /= listNumber[i];
                            break;
                        default:
                            break;
                    }
                }

                if (NumLength(Convert.ToDouble(result)) >= 2)
                {
                    lblResult.Text = result.ToString();
                }
                else
                {
                    lblResult.Text = result.ToString();
                }
                memClear();


            }
        }

        private void memClear()
        {
            listNumber.Clear();
            listOperator.Clear();
        }

        private int NumLength(double number)
        {
            if (number == 0L)
            {
                return 1;
            }
            return ((int)Math.Log10(number > 0L ? number : -number)) + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblResult;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                lblResult.Text += e.KeyChar.ToString();
                e.Handled = true;
                      
            }
            if (e.KeyChar == 13)
            {
                btnResult.PerformClick();
                e.Handled = true;
            }
            if (e.KeyChar == 43)
            {
                btnPlus.PerformClick();
                e.Handled = true;
            }
            if (e.KeyChar == 45)
            {
                btnPlus.PerformClick();
                e.Handled = true;
            }
        }
    }
}
