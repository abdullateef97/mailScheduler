using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using MailSc.Models;

namespace MailSc
{
    public class MailHelper
    {
        public  void sendMail(Email emailObject)
        {
            MailMessage mailMessage = new MailMessage("birthdaymessage@wemaTransport", emailObject.EmailAddress);
            StringBuilder builder = new StringBuilder();
            builder.Append("<h3> Dear " + emailObject.Name + " </h3>");
            builder.Append("<br/>");
            builder.Append("<h1>We bring you the latest wit regards to wematransport</h1>");


            mailMessage.IsBodyHtml = true;
            mailMessage.Body = builder.ToString();
            mailMessage.Subject = "Latest News";
            
            SmtpClient smtpClient = new SmtpClient
            {
                Credentials = new NetworkCredential
                {
                    UserName = "adeniranyusufabdullateef@gmail.com",
                    Password = "abdlatol97"
                },
                EnableSsl = true
            };

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}