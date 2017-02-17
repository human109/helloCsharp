namespace helloStr
{
    partial class HelloStr
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
            this.btnProc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRow1 = new System.Windows.Forms.TextBox();
            this.txtRow2 = new System.Windows.Forms.TextBox();
            this.txtRow3 = new System.Windows.Forms.TextBox();
            this.txtRow4 = new System.Windows.Forms.TextBox();
            this.txtRow5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRow6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(76, 12);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(104, 37);
            this.btnProc.TabIndex = 0;
            this.btnProc.Text = "처리";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "한글";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "영어";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "숫자";
            // 
            // txtRow1
            // 
            this.txtRow1.Location = new System.Drawing.Point(90, 70);
            this.txtRow1.Name = "txtRow1";
            this.txtRow1.Size = new System.Drawing.Size(152, 28);
            this.txtRow1.TabIndex = 4;
            // 
            // txtRow2
            // 
            this.txtRow2.Location = new System.Drawing.Point(90, 119);
            this.txtRow2.Name = "txtRow2";
            this.txtRow2.Size = new System.Drawing.Size(152, 28);
            this.txtRow2.TabIndex = 5;
            // 
            // txtRow3
            // 
            this.txtRow3.Location = new System.Drawing.Point(90, 168);
            this.txtRow3.Name = "txtRow3";
            this.txtRow3.Size = new System.Drawing.Size(152, 28);
            this.txtRow3.TabIndex = 6;
            // 
            // txtRow4
            // 
            this.txtRow4.Location = new System.Drawing.Point(90, 213);
            this.txtRow4.Name = "txtRow4";
            this.txtRow4.Size = new System.Drawing.Size(152, 28);
            this.txtRow4.TabIndex = 7;
            // 
            // txtRow5
            // 
            this.txtRow5.Location = new System.Drawing.Point(90, 260);
            this.txtRow5.Name = "txtRow5";
            this.txtRow5.Size = new System.Drawing.Size(152, 28);
            this.txtRow5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "이름1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "이름2";
            // 
            // txtRow6
            // 
            this.txtRow6.Location = new System.Drawing.Point(90, 312);
            this.txtRow6.Name = "txtRow6";
            this.txtRow6.Size = new System.Drawing.Size(152, 28);
            this.txtRow6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "계산값";
            // 
            // HelloStr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 388);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRow6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRow5);
            this.Controls.Add(this.txtRow4);
            this.Controls.Add(this.txtRow3);
            this.Controls.Add(this.txtRow2);
            this.Controls.Add(this.txtRow1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProc);
            this.Name = "HelloStr";
            this.Text = "문자열처리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRow1;
        private System.Windows.Forms.TextBox txtRow2;
        private System.Windows.Forms.TextBox txtRow3;
        private System.Windows.Forms.TextBox txtRow4;
        private System.Windows.Forms.TextBox txtRow5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRow6;
        private System.Windows.Forms.Label label6;
    }
}

