namespace HelloCalc
{
    partial class HelloCalc
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloCalc));
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDel = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(16, 100);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(72, 60);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "<-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(16, 166);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 60);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(94, 166);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 60);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(172, 166);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 60);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(16, 232);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 60);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(94, 232);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 60);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(172, 232);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 60);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(16, 298);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 60);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(94, 298);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 60);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(172, 298);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 60);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(254, 100);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(72, 60);
            this.btnDiv.TabIndex = 12;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(254, 166);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(72, 60);
            this.btnMul.TabIndex = 13;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(254, 232);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(72, 60);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(254, 298);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(72, 60);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(254, 366);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(72, 60);
            this.btnResult.TabIndex = 16;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(16, 364);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(150, 60);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(172, 364);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(72, 60);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 60);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(94, 100);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(72, 60);
            this.btnCE.TabIndex = 20;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblResult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(13, 21);
            this.lblResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblResult.MinimumSize = new System.Drawing.Size(310, 50);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(310, 50);
            this.lblResult.TabIndex = 21;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 438);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
    }
}

