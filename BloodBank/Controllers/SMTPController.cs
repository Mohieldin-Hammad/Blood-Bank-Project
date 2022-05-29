using System;
using System.Net.Mail;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.IO;

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


    class SMTPWithMailKit : HtmlEmailMassage
    {
        //-------------
        //enter your email and password
        private string senderEmail = "bloodbank354@gmail.com";
        private string senderEmailPassword = "Aa@123456";
        //-------------
        public string SendEmailTo(string email, string userName, string cond)
        {
            MimeMessage message = new MimeMessage();
            
            message.From.Add(new MailboxAddress("Tester", "bloodbank354@gmail.com"));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "Trying to write the code";
            message.Body = new TextPart("htm")
            {
                Text = "hello, mohee your code is successfully worked"
            };

            string emailCode = "";
            var bodyBuilder = new BodyBuilder();
            if (cond != null && cond == "Donation")
            {
                emailCode = emailSelection(cond);
            }
            else if (cond != null && cond == "SignIn")
            {
                emailCode = emailSelection(cond);
            }
            else
            {
                return "Email Condition is not selected";
            }
            bodyBuilder.HtmlBody = emailCode;
            //bodyBuilder.TextBody = "This is some plain text";

            message.Body = bodyBuilder.ToMessageBody();

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


        private static string emailSelection(string selection)
        {
            HtmlEmailMassage email_html= new HtmlEmailMassage();
            
            if (selection == "Donation")
                return email_html.DonationMessage;
            else if (selection == "SignInd")
                return email_html.SignInMeassage;
            else
                return null;
        }
    }
}

class HtmlEmailMassage
{
    protected string donationMessage = File.ReadAllText("donation.html");
    protected string signInMeassage = File.ReadAllText("signin.html");
    public string DonationMessage
    {
        get
        {
            return donationMessage;
        }
    }

    public string SignInMeassage
    {
        get
        {
            return signInMeassage;
        }
    }

}


