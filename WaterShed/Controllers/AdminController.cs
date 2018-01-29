using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOM;
using WaterShed;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using WaterShed.Models;
namespace WaterShed.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult AddState()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddState(watershed_state state)
        {

            //WaterShed.WaterShedservice.Service1Client service = new WaterShed.WaterShedservice.Service1Client();
            String statelist = StateList.GetStateList();
            try
            {
                return Json(new
                {
                    msg = "success ", list=statelist
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult GetCityList(watershed_city city)
        {
     
            //WaterShed.WaterShedservice.Service1Client service = new WaterShed.WaterShedservice.Service1Client();
            String citylist = StateList.GetCityList(city.sid);
            try
            {
                return Json(new
                {
                    msg = "success ",
                    list = citylist
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult GetTalukaList(watershed_city city)
        {

            //WaterShed.WaterShedservice.Service1Client service = new WaterShed.WaterShedservice.Service1Client();
            String citylist = StateList.GetTalukaList(city.cid);
            try
            {
                return Json(new
                {
                    msg = "success ",
                    list = citylist
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult GetVillageList(watershed_taluka city)
        {

            //WaterShed.WaterShedservice.Service1Client service = new WaterShed.WaterShedservice.Service1Client();
            String citylist = StateList.GetVillageList(city.tid);
            try
            {
                return Json(new
                {
                    msg = "success ",
                    list = citylist
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult GetVillageDataList(watershed_village_data vil)
        {
            String citylist = StateList.GetVillageDataList(vil.village_id);
            try
            {
                return Json(new
                {
                    msg = "success ",
                    list = citylist
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult GetVillageData(watershed_village_data vil)
        {
           
            watershed_village_data citylist = StateList.GetVillageDataList(vil);
            citylist.watershed_village = DAL.VillageDataDal.getVillageById(citylist.village_id);
          
            this.Session.Add("villagedata",citylist);
            try
            {
                return Json(new
                {
                    msg = "success ",
                    wateravail = citylist.wateravail,
                    water_sarcacity=citylist.water_sarcacity,
                    cycle_year= citylist.cycle_year.Year.ToString(),
                    Area= citylist.watershed_village.Area
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult GetCropList(watershed_village_data vil)
        {
            List<watershed_crop> clist=DAL.CropDal.GetListCrop();
            // watershed_village_data data = this.Session["villagedata"] as watershed_village_data;
            watershed_village_data data = DAL.VillageDataDal.getVillageDataById(vil.vd_id);
            this.Session.Add("villagedata", data);
            String str = "<option value=''></option>";
            foreach(watershed_crop cr in clist)
            {
                double waterreq = (cr.waterreq * data.watershed_village.Area*  1000);
                if(waterreq<data.waterreq)
                {
                    str += "<option value='"+cr.crop_id+"'>"+cr.cname+waterreq+"</option>";
                }

            }
            try
            {
                return Json(new
                {
                    msg = "success ",
                    list = str
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        public ActionResult GetCropListArea(watershed_policy vil)
        {
            List<watershed_crop> clist = DAL.CropDal.GetListCrop();
            watershed_village_data data = this.Session["villagedata"] as watershed_village_data;
            String str = "<option value=''>select</option>";
            double area = vil.cultivated_area;
            if (area < data.watershed_village.Area)
            {


                foreach (watershed_crop cr in clist)
                {
                    double waterreq = (cr.waterreq * area * 1000);
                    if (waterreq < data.waterreq)
                    {
                        str += "<option value='" + cr.crop_id + "'>" + cr.cname + waterreq + "</option>";
                    }

                }
            }
            try
            {
                return Json(new
                {
                    msg = "success ",
                    list = str
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}