using System;
using System.Net;
using System.Net.Mail;
namespace EmailSmtp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var credentials = new NetworkCredential("leejongcheol2018@gmail.com", "GMail비밀번호");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("leejongcheol2018@gmail.com"),
                    Subject = "C# 프로그램에서 보내는 메일 입니다.",
                    Body = "반갑습니다. Hello C#, C#을 통해 구글 SMTP를 이용한 메일발송 프로그램 입니다."
                };
                mail.To.Add(new MailAddress("aplusplusking@naver.com"));
                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                // Send it...
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in sending email: " + ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Email sccessfully sent");
            Console.ReadKey();
        }
    }
}