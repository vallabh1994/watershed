using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Net.Mail;
namespace BOL
{
    public class Authentication
    {
        public static Boolean Register(BOM.User user)
        {
            user.password = Encrypted.GetEncrypted(user.password);
            user.ConfirmPassword = Encrypted.GetEncrypted(user.ConfirmPassword);
            return DAL.AuthenticationDal.RegisterDal(user);
        }
        public static BOM.User Login(BOM.User user)
        {
            user.password = Encrypted.GetEncrypted(user.password);
            //user.ConfirmPassword = Encrypted.GetEncrypted(user.ConfirmPassword);
            return DAL.AuthenticationDal.LoginDal(user);
        }


        public static String ForgetPassword(BOM.User user)
        {
            BOM.User users=DAL.AuthenticationDal.checkEmail(user);


            if (null != users)
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.yandex.ru";
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("vallabh@abctnc.com", "nokia5230");

                String newpass = BOL.RandomNum();
                String encrypted = Encrypted.GetEncrypted(newpass);
                if(DAL.AuthenticationDal.UpdatePassword(users,encrypted))
                {
                    MailMessage mm = new MailMessage("vallabh@abctnc.com", users.email, "password for watershed", "password is " + newpass);
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    client.Send(mm);
                    return "success";
                }
                return "fail";

            }
            else
            {
                return "fail";
            }
        }



    }
}
