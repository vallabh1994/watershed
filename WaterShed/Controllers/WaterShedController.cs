using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WaterShed;
using BOM;
namespace WaterBudget.Controllers
{
    public class WaterShedController : Controller
    {
        // GET: WaterShed
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddDetail()
        {
            return View();
        }
        public ActionResult ViewDetail()
        {
            int tal = 0;
            watershedEntities db = new watershedEntities();
            if(null!=this.TempData["tal"] )
            {
                tal = (int)this.TempData["tal"];
            }
            List<watershed_village_data> list=db.watershed_village_data.ToList();
            List<watershed_village_data> list1 = new List<watershed_village_data>();
            if (tal!=0)
            {
                foreach (watershed_village_data wt in list)
                {
                    if(null!=wt.watershed_village)
                    if(wt.watershed_village.tid==tal)
                    {
                            list1.Add(wt);
                    }
                }
            }
            if (list1.Count > 0)
                list = list1;

                return View(list);
        }
        public ActionResult ViewPolicy()
        {
            return View();
        }

        public ActionResult PolicyView()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddVillageDetail()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddState()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCity()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddVillage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddTaluka()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddVillageDetail(watershed_village_data data)
        {
           
            watershed_village_data village= WaterShed.Models.WaterModel.VillageData(data);

            if (DAL.VillageDataDal.AddVillageData(village) == true)
            {
                ViewData.Add("AddVillageData", "success");
            }
            else
            {
                ViewData.Add("AddVillageData", "fail");
            }

            return View();
        }
        [HttpPost]
        public ActionResult AddState(watershed_state data)
        {
            if (DAL.VillageDataDal.AddState(data) == true)
            {
                ViewData.Add("AddState", "success");
            }
            else
            {
                ViewData.Add("AddState", "fail");
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddCity(watershed_city data)
        {
           if( DAL.VillageDataDal.AddCity(data)==true)
            {
                ViewData.Add("AddCity","success");
            }else
            {
                ViewData.Add("AddCity", "fail");
            }

            return View();
        }

        [HttpPost]
        public ActionResult AddVillage(watershed_village data)
        {
            if (DAL.VillageDataDal.AddVillage(data) == true)
            {
                ViewData.Add("AddVillage", "success");
            }
            else
            {
                ViewData.Add("AddVillage", "fail");
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddTaluka(watershed_taluka data)
        {
            if (DAL.VillageDataDal.AddTaluka(data) == true)
            {
                ViewData.Add("AddTaluka", "success");
            }
            else
            {
                ViewData.Add("AddTaluka", "fail");
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddCrop(BOM.watershed_crop crop)
        {
            WaterShed.WaterShedservice.Service1Client service = new WaterShed.WaterShedservice.Service1Client();
            bool status=service.doAddCrop(crop);
            String msg = "";
            if (status)
            {
              msg= "add";
            }
            else
            {
               msg= "not";
            }
            TempData.Add("msg",msg);
            return View();
        }

        public ActionResult VillageDetails(int? Id)
        {

            BOM.watershed_village_data d = DAL.VillageDataDal.getVillageDataById(Id);
            List<BOM.watershed_policy> policy = DAL.VillageDataDal.GetPolicyYear(d);
            ViewData.Add("policy", policy);
            List<watershed_crop> list = DAL.CropDal.GetListCrop();
            
            if (null != policy && null!=list)
            {
                foreach(watershed_policy pol in policy)
                foreach(watershed_crop crop in list)
                {
                    if (pol.crop_id == crop.crop_id)
                        pol.watershed_crop = crop;
                    
                }
            }
          
            return View(d);
        }
   
        [HttpPost]
        public ActionResult FilterVillage()
        {
        
           int tal= Convert.ToInt32(this.Request.Form["taluka"].ToString());
            TempData.Add("tal", tal);
            return RedirectToAction("ViewDetail");
        }


    }
}