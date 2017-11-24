using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputValidation
{
    class EmailSending
    {
        public static void SendEmail(string fromEmailAddress, string toEmailAddress, string emailSubject, string emailBody, string username, string password)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(fromEmailAddress);
            mail.To.Add(toEmailAddress);
            mail.Subject = emailSubject;
            mail.Body = emailBody;

            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.UseDefaultCredentials = true;
            SmtpServer.Host = "smtp.gmail.com";
            try
            {
                SmtpServer.Send(mail);
                MessageBox.Show("The mail has been sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
