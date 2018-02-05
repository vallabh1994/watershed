using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
namespace BOL
{
   public static class BOL
    {
        public static String RandomNum()
        {
            Random r = new Random();
            String rInt = r.Next(0, 1000).ToString(); //for ints
            return rInt;
        }

        public static String SendMail(String to,String sub,String msg)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.yandex.ru";
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("komal@abctnc.com", "komal@123");
                MailMessage mm = new MailMessage("vallabh@abctnc.com", to, sub, msg);
                mm.BodyEncoding = UTF8Encoding.UTF8;
                client.Send(mm);
                return "success";
            }catch(Exception e)
            {
                return "fail";
            }
   
            
        }
    }
}
