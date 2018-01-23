using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaterShed;
using BOM;


namespace WaterBudget.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Message = "Your Register page.";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";

            return View();
        }


        [HttpPost]
        public ActionResult Register(User user)
        {
           // ViewBag.Message = "Your contact page.";
            //user.role = "admin";
            WaterShed.WaterShedservice.Service1Client auth = new WaterShed.WaterShedservice.Service1Client();
            bool status = auth.doRegister(user);
            if(status==true)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
            
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            ViewBag.Message = "Your contact page.";


            WaterShed.WaterShedservice.Service1Client auth = new WaterShed.WaterShedservice.Service1Client();
            User users = auth.doLogin(user) as User;
            if (null == users)
            {
                this.Response.Redirect("Login");

            }
            else
            {
                User us = Session["user"] as User;
                us.email = users.email;
                us.Name = users.Name;
                us.role = users.role;
                us.uid = users.uid;
                us.pincode = users.pincode;
                if (us.role.Equals("admin"))
                {
                    //this.Response.Redirect("/Home/Index");
                  return  this.RedirectToAction("AddDetail", "WaterShed");
                }
                if(us.role.Equals("user"))
                {
                    return this.RedirectToAction("ViewDetail", "WaterShed");
                }
            }

            return View();
        }

        private void RedirectToAction()
        {
            throw new NotImplementedException();
        }

     

        public ActionResult Logout()
        {
            User us = Session["user"] as User;
            if(us.uid==0)
            {
                this.Response.Redirect("Login");
                return View();
            }
          //  Session.Clear
            Session["user"] = new User { uid=0 };
            this.Response.Redirect("Login");
            return View();
        }
    }
}