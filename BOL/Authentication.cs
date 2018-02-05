using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (null == users)
                return "fail";
               
                String newpass = BOL.RandomNum();
                String encrypted = Encrypted.GetEncrypted(newpass);
                if(DAL.AuthenticationDal.UpdatePassword(users,encrypted))
                {
                 String res= BOL.SendMail(users.email, "password for watershed", "password is " + newpass);
                    return res;
                }
                return "fail";
        }
    }

}
