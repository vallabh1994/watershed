using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOM;
using System.Data.Entity.Validation;

namespace DAL
{
    public class AuthenticationDal
    {
        public static User LoginDal(User user)
        {
            watershedEntities db = new watershedEntities();
            
            var st = (from u in db.Users1 where (u.email==user.email && u.password==user.password) select u).SingleOrDefault();
            return st;
        }

        public static User checkEmail(User user)
        {
            watershedEntities db = new watershedEntities();
            var st = (from u in db.Users1 where u.email == user.email select u).SingleOrDefault();
            return st;
        }

        public static Boolean RegisterDal(User user)
        {
            watershedEntities db = new watershedEntities();
            if (null==checkEmail(user))
            {
                try {
                    db.Users1.Add(user);
                    db.SaveChanges();
                }catch(DbEntityValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
            return false;
        }

    }
}
