
namespace EMailCheck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_emailchecknum = new System.Windows.Forms.TextBox();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_emailcheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_emailcheck);
            this.groupBox1.Controls.Add(this.btn_email);
            this.groupBox1.Controls.Add(this.txt_emailchecknum);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이메일 인증";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이메일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "인증번호";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(84, 20);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(147, 22);
            this.txt_email.TabIndex = 2;
            // 
            // txt_emailchecknum
            // 
            this.txt_emailchecknum.Location = new System.Drawing.Point(84, 49);
            this.txt_emailchecknum.Name = "txt_emailchecknum";
            this.txt_emailchecknum.Size = new System.Drawing.Size(147, 22);
            this.txt_emailchecknum.TabIndex = 3;
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(238, 20);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(87, 23);
            this.btn_email.TabIndex = 4;
            this.btn_email.Text = "이메일 인증";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // btn_emailcheck
            // 
            this.btn_emailcheck.Location = new System.Drawing.Point(238, 49);
            this.btn_emailcheck.Name = "btn_emailcheck";
            this.btn_emailcheck.Size = new System.Drawing.Size(87, 23);
            this.btn_emailcheck.TabIndex = 5;
            this.btn_emailcheck.Text = "인증 확인";
            this.btn_emailcheck.UseVisualStyleBackColor = true;
            this.btn_emailcheck.Click += new System.EventHandler(this.btn_emailcheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 124);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_emailcheck;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.TextBox txt_emailchecknum;
    }
}

