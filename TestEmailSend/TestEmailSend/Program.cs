using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace TestEmailSend
{
    class Program
    {
        static string smtpAddress = "smtp.mail.yahoo.com";
        static int portNumber = 587;
        static bool enableSSL = true;

        static string emailFrom = "email@yahoo.com";
        static string password = "abcdefg";
        static string emailTo = "alexkozlov11g11@gmail.com";
        static string subject = "Hello";
        static string body = "Hello, I'm just writing this to say Hi!";


        static void Main(string[] args)
        {
            using (var mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                // Can set to false, if you are sending pure text.

                //mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
                //mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }

    }
}
