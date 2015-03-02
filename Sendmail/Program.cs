using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Sendmail
{
    class Program
    {
        static void Main(string[] args)
        {

            SmtpClient Smtp_Server = new SmtpClient();
            MailMessage e_mail = new MailMessage();
            Smtp_Server.UseDefaultCredentials = false;
            Smtp_Server.Credentials = new System.Net.NetworkCredential("Talendkpa@gmail.com", "KeolisTalend");
            Smtp_Server.Port = 587;
            Smtp_Server.EnableSsl = true;
            Smtp_Server.Host = "smtp.gmail.com";

            e_mail = new MailMessage();
            e_mail.From = new MailAddress("patrice.maldi@keolis.com");
            e_mail.To.Add("patrice.maldi@keolis.com");
            e_mail.Subject = "Test";
            e_mail.Body = "Job ok";
            Smtp_Server.Send(e_mail);
            Console.ReadKey();
        }
    }
}
