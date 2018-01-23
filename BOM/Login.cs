using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM
{
    public class Login
    {
        
        public static void doRegister()
        {
            watershedEntities db = new watershedEntities();
            // Console.WriteLine(db.Users1.Add(new User {Name="vallabh",ConfirmPassword="123",email="vallabh.7@gmail.com",password="123",pincode="431005",role="admin" }));

          //var st=  (from u in db.Users1 where u.email == "vallabdh.7@gmail.com" select u).SingleOrDefault();
           // Console.WriteLine(st);
            // db.SaveChanges();sd
        }


    }
}
