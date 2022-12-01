
namespace SMTPEMail
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_to = new System.Windows.Forms.TextBox();
            this.txtBox_From = new System.Windows.Forms.TextBox();
            this.txtBox_Subject = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_Mail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "받는 사람";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "회신 주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "제목";
            // 
            // txtBox_to
            // 
            this.txtBox_to.Location = new System.Drawing.Point(73, 10);
            this.txtBox_to.Name = "txtBox_to";
            this.txtBox_to.Size = new System.Drawing.Size(291, 21);
            this.txtBox_to.TabIndex = 1;
            // 
            // txtBox_From
            // 
            this.txtBox_From.Location = new System.Drawing.Point(73, 39);
            this.txtBox_From.Name = "txtBox_From";
            this.txtBox_From.Size = new System.Drawing.Size(291, 21);
            this.txtBox_From.TabIndex = 2;
            // 
            // txtBox_Subject
            // 
            this.txtBox_Subject.Location = new System.Drawing.Point(73, 68);
            this.txtBox_Subject.Name = "txtBox_Subject";
            this.txtBox_Subject.Size = new System.Drawing.Size(291, 21);
            this.txtBox_Subject.TabIndex = 5;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(371, 3);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 86);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "이메일 전송";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(452, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 86);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_Mail);
            this.groupBox1.Location = new System.Drawing.Point(13, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 345);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이메일 내용";
            // 
            // txtBox_Mail
            // 
            this.txtBox_Mail.Location = new System.Drawing.Point(6, 20);
            this.txtBox_Mail.Multiline = true;
            this.txtBox_Mail.Name = "txtBox_Mail";
            this.txtBox_Mail.Size = new System.Drawing.Size(502, 319);
            this.txtBox_Mail.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txtBox_Subject);
            this.Controls.Add(this.txtBox_From);
            this.Controls.Add(this.txtBox_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "EMail(SMTP)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_to;
        private System.Windows.Forms.TextBox txtBox_From;
        private System.Windows.Forms.TextBox txtBox_Subject;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_Mail;
    }
}

