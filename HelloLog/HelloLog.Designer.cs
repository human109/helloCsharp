namespace HelloLog
{
    partial class HelloLog
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnProc = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(36, 22);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(364, 28);
            this.txtInput.TabIndex = 0;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(419, 22);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(92, 28);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "저장";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(36, 78);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(475, 508);
            this.listBox.TabIndex = 2;
            // 
            // HelloLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 595);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.txtInput);
            this.Name = "HelloLog";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HelloLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.ListBox listBox;
    }
}

