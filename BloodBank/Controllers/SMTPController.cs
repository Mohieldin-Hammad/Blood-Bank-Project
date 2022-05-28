using System;
using System.Net.Mail;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;


namespace BloodBank.Controllers
{
    class SMTPController
    {
        private string EmailBody = "hello, mohee your code is successfully worked";
        private string subject = "Trying to write the code";
        private string mailTitle = "Done";
        //-------------
        //enter your email and password
        private string senderEmail = "email";
        private string senderEmailPassword = "password";
        //-------------
        public string SendEmailTo(string receiverEmail)
        {
            // Email and Content
            MailMessage mailMessage = new MailMessage(new MailAddress(senderEmail, mailTitle), new MailAddress(receiverEmail));
            mailMessage.Subject = subject;
            mailMessage.Body = EmailBody;
            //mailMessage.IsBodyHtml = true;


            // server
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 465;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;


            // credentials
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
            credentials.UserName = senderEmail;
            credentials.Password = senderEmailPassword;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = credentials;

            try
            {
                smtp.Send(mailMessage);
                return "Succeed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

    }


    class SMTPWithMailKit
    {
        //-------------
        //enter your email and password
        private string senderEmail = "email";
        private string senderEmailPassword = "password";
        //-------------
        public string SendEmailTo(string email)
        {
            MimeMessage message = new MimeMessage();
            
            message.From.Add(new MailboxAddress("Tester", "bloodbank354@gmail.com"));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "Trying to write the code";
            message.Body = new TextPart("plain")
            {
                Text = "hello, mohee your code is successfully worked"
            };

            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();
            string checkMessage = "";
            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(senderEmail, senderEmailPassword);
                client.Send(message);
                checkMessage = "Succeed";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
            return checkMessage;
        }
    }
}
