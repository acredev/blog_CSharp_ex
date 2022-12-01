﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EMailCheck
{
    public partial class Form1 : Form
    {
        public static Random randomNum = new Random(); // 전역변수
        public static int checkNum = randomNum.Next(10000000, 99999999);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            string SystemMailId = "이메일 아이디";
            string SystemMailPwd = "이메일 비밀번호";

            MailMessage mail = new MailMessage();
            mail.To.Add(txt_email.Text);
            mail.From = new MailAddress(SystemMailId);
            mail.Subject = "회원가입 본인인증 이메일";
            mail.Body = checkNum.ToString();

            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            mail.SubjectEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.UTF8;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Timeout = 10000;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential(SystemMailId, SystemMailPwd);

            try
            {
                smtp.Send(mail);
                smtp.Dispose();

                MessageBox.Show("인증번호 전송완료", "전송 완료");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_emailcheck_Click(object sender, EventArgs e)
        {
            if(txt_emailchecknum.Text == checkNum.ToString())
            {
                MessageBox.Show("이메일 인증이 완료되었습니다.", "인증 성공");
            }
            else
            {
                MessageBox.Show("인증 번호가 다릅니다.", "인증 실패");
            }
        }
    }
}
