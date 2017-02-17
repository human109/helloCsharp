namespace HelloFile
{
    partial class HelloFile
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
            this.txtRow1 = new System.Windows.Forms.TextBox();
            this.txtRow2 = new System.Windows.Forms.TextBox();
            this.txtRow3 = new System.Windows.Forms.TextBox();
            this.txtRow4 = new System.Windows.Forms.TextBox();
            this.txtRow5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRow1
            // 
            this.txtRow1.Location = new System.Drawing.Point(135, 82);
            this.txtRow1.Name = "txtRow1";
            this.txtRow1.Size = new System.Drawing.Size(223, 28);
            this.txtRow1.TabIndex = 0;
            // 
            // txtRow2
            // 
            this.txtRow2.Location = new System.Drawing.Point(135, 138);
            this.txtRow2.Name = "txtRow2";
            this.txtRow2.Size = new System.Drawing.Size(223, 28);
            this.txtRow2.TabIndex = 1;
            // 
            // txtRow3
            // 
            this.txtRow3.Location = new System.Drawing.Point(135, 194);
            this.txtRow3.Name = "txtRow3";
            this.txtRow3.Size = new System.Drawing.Size(223, 28);
            this.txtRow3.TabIndex = 2;
            // 
            // txtRow4
            // 
            this.txtRow4.Location = new System.Drawing.Point(135, 250);
            this.txtRow4.Name = "txtRow4";
            this.txtRow4.Size = new System.Drawing.Size(223, 28);
            this.txtRow4.TabIndex = 3;
            // 
            // txtRow5
            // 
            this.txtRow5.Location = new System.Drawing.Point(135, 306);
            this.txtRow5.Name = "txtRow5";
            this.txtRow5.Size = new System.Drawing.Size(223, 28);
            this.txtRow5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "한글";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "숫자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "영어";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "이름1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "이름2";
            // 
            // btnProc
            // 
            this.btnProc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProc.Location = new System.Drawing.Point(54, 12);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(146, 44);
            this.btnProc.TabIndex = 10;
            this.btnProc.Text = "처리";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(216, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 44);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 374);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRow5);
            this.Controls.Add(this.txtRow4);
            this.Controls.Add(this.txtRow3);
            this.Controls.Add(this.txtRow2);
            this.Controls.Add(this.txtRow1);
            this.Name = "Form1";
            this.Text = "문자열처리(파일)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRow1;
        private System.Windows.Forms.TextBox txtRow2;
        private System.Windows.Forms.TextBox txtRow3;
        private System.Windows.Forms.TextBox txtRow4;
        private System.Windows.Forms.TextBox txtRow5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnClear;
    }
}

