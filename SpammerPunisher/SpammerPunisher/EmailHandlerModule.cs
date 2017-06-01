using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Evolution;

namespace EmailHandlerModule
{
    class EmailHandlerModule
    {
        public static void EmailHandler()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            //Save the credentials in a remote encrypted file.
            client.Credentials = new System.Net.NetworkCredential("yodeler999@gmail.com", "password!!");

            MailMessage mm = new MailMessage("yodeler999@gmail.com", "newsletter@offeronmail.com", "You need to stop Spamming me!!", "I am tired of your emails. Stop spamming!");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
            
        }
    }
}
