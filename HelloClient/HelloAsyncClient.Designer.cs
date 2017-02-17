namespace HelloClient
{
    partial class HelloAsyncClient
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datasendTimer = new System.Windows.Forms.Timer(this.components);
            this.eventSendTimer = new System.Windows.Forms.Timer(this.components);
            this.offeventTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 25);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(589, 28);
            this.txtMessage.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "전송";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // datasendTimer
            // 
            this.datasendTimer.Enabled = true;
            this.datasendTimer.Interval = 3000;
            this.datasendTimer.Tick += new System.EventHandler(this.datasendTimer_Tick);
            // 
            // eventSendTimer
            // 
            this.eventSendTimer.Enabled = true;
            this.eventSendTimer.Interval = 10000;
            this.eventSendTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // offeventTimer
            // 
            this.offeventTimer.Interval = 3000;
            this.offeventTimer.Tick += new System.EventHandler(this.offeventTimer_Tick);
            // 
            // HelloAsyncClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 113);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMessage);
            this.Name = "HelloAsyncClient";
            this.Text = "HelloClient";
            this.Load += new System.EventHandler(this.HelloAsyncClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer datasendTimer;
        private System.Windows.Forms.Timer eventSendTimer;
        private System.Windows.Forms.Timer offeventTimer;
    }
}

