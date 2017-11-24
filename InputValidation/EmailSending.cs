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
        public static void SendEmail(string fromEmailAddressString, string toEmailAddressString, string emailSubject, string emailBody, string username, string password)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            try
            {
                MailAddress fromEmailAddress = new MailAddress(fromEmailAddressString);
                MailAddress toEmailAddress = new MailAddress(toEmailAddressString);
                mail.From = fromEmailAddress;
                mail.To.Add(toEmailAddress);

                SmtpServer.Send(mail);
                MessageBox.Show("The mail has been sent successfully.");

                mail.Subject = emailSubject;
                mail.Body = emailBody;

                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServer.EnableSsl = true;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Host = "smtp.gmail.com";
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Cannot send email. Address is not correct.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(fe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot send email. Connection problem.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(ex);
            }
        }
    }
}
