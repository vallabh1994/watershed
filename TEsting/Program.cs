using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.Serialization.Json;


namespace TEsting
{
    class Program
    {

       static void insertcitytostate()
        {
            String constr = @"server=127.0.0.1;user id=root;database=watershed;sslmode=Prefered;allowuservariables=True;persistsecurityinfo=True";
            MySqlConnection con = new MySqlConnection(constr);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            var txt = System.IO.File.ReadAllText(@"C:\Users\vallabh\Desktop\iacsd\proj\WaterShed\WaterShed\TEsting\json1.json");
            var on = System.IO.File.ReadAllText(txt);
         
            //  JsonCon
            Console.WriteLine(on);

        }

        static void Main(string[] args)
        {
            WaterShedService.Service1Client sc = new WaterShedService.Service1Client();
            // Console.WriteLine(sc.doLogin(new BOM.User {email="vallabh.7@gmail.com",password="123" }));
               Console.WriteLine(sc.doRegister(new BOM.User {ConfirmPassword="123",email="akshay@mytechsite.in",Name="akshay",password="123",pincode="431005",role="user",uid=0}));
            //insertcitytostate();

        //  BOM.User user=  sc.doLogin(new BOM.User {email="vallabh.7@gmail.com",password="123" });
          //  Console.WriteLine(user);
            Console.ReadLine();
        }
    }
}
