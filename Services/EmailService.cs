using System.Net.Mail;

namespace HospitalMVC.Services
{
    public class EmailService
    {
        public void Send(string to, string subject, string body)
        {
            var msg = new MailMessage("youremail@gmail.com", to, subject, body);
            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential("youremail@gmail.com", "your-app-password"),
                EnableSsl = true
            };
            smtp.Send(msg);
        }
    }
}

