using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaterShed;
using BOM;
using BOL;
using System.Text;
using System.Net.Mail;

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
            User users = BOL.Authentication.Login(user) as User;
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
                this.Session.Add("user",us);
                if (us.role.Equals("admin"))
                {
                    //this.Response.Redirect("/Home/Index");
                  return  this.RedirectToAction("AddDetail", "WaterShed");
                }
                if(us.role.Equals("StateAgent"))
                {
                    return this.RedirectToAction("AddVillageDetail", "WaterShed");
                }
                if(us.role.Equals("user"))
                {
                    return this.RedirectToAction("SelectCrop", "Account");
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
        [HttpGet]
        public ActionResult SelectCrop()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SelectCrop(watershed_policy crop)
        {
            WaterShed.WaterShedservice.Service1Client sc = new WaterShed.WaterShedservice.Service1Client();
           if(sc.AddPolicy(crop))
            {
                ViewData.Add("SelectCrop", "success");
            }
            else
            {
                ViewData.Add("SelectCrop", "fail");
            }
            return View();
        }
        [HttpGet]
        public ActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgetPassword(User user)
        {
           // User users = DAL.AuthenticationDal.checkEmail(user);

            WaterShed.WaterShedservice.Service1Client client = new WaterShed.WaterShedservice.Service1Client();
            
                String mail = client.ForgetPassword(user);
                this.ViewData.Add("mail", mail);
            
            
           
            return View();
        }

        public ActionResult CropCart()
        {
            User us = Session["user"] as User;
            List<watershed_policy> list= DAL.VillageDataDal.GetPolicyListByUid(us.uid);
           
            foreach (watershed_policy pol in list)
            {
                pol.watershed_village_data = DAL.VillageDataDal.getVillageDataById(pol.vd_id);
                pol.watershed_village_data.watershed_village = DAL.VillageDataDal.getVillageById(pol.watershed_village_data.village_id);
                pol.watershed_crop = DAL.CropDal.GetCrop(pol.watershed_crop);
            }
            return View(list);
        }
        [HttpGet]
        public ActionResult UpdatePassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdatePassword(BOM.User users)
        {
            String smsg = "fail";
        
            BOM.User u= DAL.AuthenticationDal.checkEmail(users);
            String epass = BOL.Encrypted.GetEncrypted(users.password);
            if (u.password.Equals(epass))
            {
                String newpass = this.Request.Form["npassword"].ToString();
                if (BOL.Authentication.ChangePassword(u,newpass))
                    smsg = "success";
            }
            this.ViewData.Add("updatepass",smsg);
            return View();
        }

    }
}