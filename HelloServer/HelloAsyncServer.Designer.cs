namespace HelloServer
{
    partial class HelloAsyncServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRow1 = new System.Windows.Forms.TextBox();
            this.txtRow2 = new System.Windows.Forms.TextBox();
            this.txtRow3 = new System.Windows.Forms.TextBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRow4 = new System.Windows.Forms.TextBox();
            this.txtRow5 = new System.Windows.Forms.TextBox();
            this.txtRow6 = new System.Windows.Forms.TextBox();
            this.txtRow7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(180, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "온도계1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(45, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "온도계2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(45, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "온도계3";
            // 
            // txtRow1
            // 
            this.txtRow1.Location = new System.Drawing.Point(153, 152);
            this.txtRow1.Name = "txtRow1";
            this.txtRow1.Size = new System.Drawing.Size(355, 28);
            this.txtRow1.TabIndex = 4;
            // 
            // txtRow2
            // 
            this.txtRow2.Location = new System.Drawing.Point(153, 208);
            this.txtRow2.Name = "txtRow2";
            this.txtRow2.Size = new System.Drawing.Size(355, 28);
            this.txtRow2.TabIndex = 5;
            // 
            // txtRow3
            // 
            this.txtRow3.Location = new System.Drawing.Point(153, 264);
            this.txtRow3.Name = "txtRow3";
            this.txtRow3.Size = new System.Drawing.Size(355, 28);
            this.txtRow3.TabIndex = 6;
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 18;
            this.listLog.Location = new System.Drawing.Point(12, 610);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(554, 274);
            this.listLog.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "LOG";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 34);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "서버시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(128, 96);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 34);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "서버종료";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblStatus.Location = new System.Drawing.Point(254, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 34);
            this.lblStatus.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(45, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "온도계4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(45, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "온도계5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(45, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "온도계6";
            // 
            // txtRow4
            // 
            this.txtRow4.Location = new System.Drawing.Point(153, 317);
            this.txtRow4.Name = "txtRow4";
            this.txtRow4.Size = new System.Drawing.Size(355, 28);
            this.txtRow4.TabIndex = 15;
            // 
            // txtRow5
            // 
            this.txtRow5.Location = new System.Drawing.Point(153, 372);
            this.txtRow5.Name = "txtRow5";
            this.txtRow5.Size = new System.Drawing.Size(355, 28);
            this.txtRow5.TabIndex = 16;
            // 
            // txtRow6
            // 
            this.txtRow6.Location = new System.Drawing.Point(153, 427);
            this.txtRow6.Name = "txtRow6";
            this.txtRow6.Size = new System.Drawing.Size(355, 28);
            this.txtRow6.TabIndex = 17;
            // 
            // txtRow7
            // 
            this.txtRow7.Location = new System.Drawing.Point(153, 482);
            this.txtRow7.Name = "txtRow7";
            this.txtRow7.Size = new System.Drawing.Size(355, 28);
            this.txtRow7.TabIndex = 19;
            this.txtRow7.TextChanged += new System.EventHandler(this.txtRow7_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(45, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "저장신호";
            // 
            // HelloAsyncServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 896);
            this.Controls.Add(this.txtRow7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRow6);
            this.Controls.Add(this.txtRow5);
            this.Controls.Add(this.txtRow4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.txtRow3);
            this.Controls.Add(this.txtRow2);
            this.Controls.Add(this.txtRow1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HelloAsyncServer";
            this.Text = "HELLOServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRow1;
        private System.Windows.Forms.TextBox txtRow2;
        private System.Windows.Forms.TextBox txtRow3;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRow4;
        private System.Windows.Forms.TextBox txtRow5;
        private System.Windows.Forms.TextBox txtRow6;
        private System.Windows.Forms.TextBox txtRow7;
        private System.Windows.Forms.Label label9;
    }
}

