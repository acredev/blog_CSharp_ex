using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text;

namespace SMTPEMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
		{
			MailMessage mail = new MailMessage();
			mail.To.Add(txtBox_to.Text);
			// txtBox_to에 입력된 이메일 받을 사람 텍스트를 불러옴
			mail.From = new MailAddress(txtBox_From.Text);
			// txtBox_From에 입력된 이메일을 회신받을 주소 텍스트를 불러옴
			mail.Subject = txtBox_Subject.Text;
			// txtBox_Subject에 입력된 이메일 제목 텍스트를 불러옴
			mail.Body = txtBox_Mail.Text + "회신 받을 주소 : " + txtBox_From.Text;
			// 이메일 전송 시에 txtBox_Mail에 입력된 텍스트와 회신 받을 주소 텍스트를 한번에 보냄

			mail.IsBodyHtml = true;
			// HTML 사용
			mail.Priority = MailPriority.High;
			// 메일 중요도 표시, 필요 없으면 없애도 됨
			mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
			// 메일 발송 실패시 알려줌

			mail.SubjectEncoding = Encoding.UTF8;
			// 메일 제목 인코딩은 UTF-8
			mail.BodyEncoding = Encoding.UTF8;
			// 메일 내용 인코딩은 UTF-8

			SmtpClient smtp = new SmtpClient();
			// SmtpClient 사용을 위한 smtp 객체 생성
			smtp.Host = "smtp.gmail.com";
			// smtp 메일 서버 주소 입력
			smtp.Port = 587;
			// smtp 메일 포트 주소 입력
			smtp.Timeout = 10000;
			smtp.UseDefaultCredentials = true;
			// 서버 기본 인증 이용
			smtp.EnableSsl = true;
			// smtp SSL 보안 설정
			smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
			// 이메일을 네트워크를 통해 SMTP 서버로 전송
			smtp.Credentials = new System.Net.NetworkCredential("구글아이디", "구글비밀번호");
			// 사용자 아이디와 비밀번호

			try
			{
				smtp.Send(mail);
				// smtp 객체를 통해 mail 발송
				mail.Dispose();

				MessageBox.Show("전송완료", "전송 완료");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				// 메일 발송 실패시 오류 메시지 출력
			}
		}

        private void btn_Exit_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}
