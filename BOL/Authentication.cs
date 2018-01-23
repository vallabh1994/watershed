using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Authentication
    {
        public static Boolean Register(BOM.User user)
        {
            return DAL.AuthenticationDal.RegisterDal(user);
        }
        public static BOM.User Login(BOM.User user)
        {
            return DAL.AuthenticationDal.LoginDal(user);
        }
    }
}
