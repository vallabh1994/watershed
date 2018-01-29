using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOM;
using Newtonsoft.Json;
namespace WaterShed.Models
{
    public class StateList
    {
        public static String GetStateList()
        {
            List<BOM.watershed_state> list = BOL.VillageBOL.GetAllState();
            var sorted = from states in list orderby states.sname select states;
            String statelist = "<option value=''>select</option>";
            foreach (watershed_state st in sorted)
            {
                statelist += "<option value=" + st.sid + ">" + st.sname + "</option>";
            }
           // statelist += "";
            return statelist;
        }

        public static String GetCityList(int sid)
        {
            List<BOM.watershed_city> list = BOL.VillageBOL.GetAllCity(sid);
            var sorted = from cities in list orderby cities.cname select cities;
            var citylist = "<option value=''>select</option>";
            foreach(watershed_city cit in sorted)
            {
                citylist += "<option value='"+cit.cid+"'>"+cit.cname+"</option>";
            }
            return citylist;
        }

        public static String GetVillageList(int sid)
        {
            List<BOM.watershed_village> list = BOL.VillageBOL.GetAllVillage(sid);
            var sorted = from cities in list orderby cities.Name select cities;
            var citylist = "<option value=''>select</option>";
            foreach (watershed_village cit in sorted)
            {
                citylist += "<option value='" + cit.vid + "'>" + cit.Name + "</option>";
            }
            return citylist;
        }

        public static String GetTalukaList(int sid)
        {
            List<BOM.watershed_taluka> list = BOL.VillageBOL.GetAllTaluka(sid);
            var sorted = from cities in list orderby cities.Name select cities;
            var citylist = "<option value=''>select</option>";
            foreach (watershed_taluka cit in sorted)
            {
                citylist += "<option value=" + cit.tid + ">" + cit.Name + "</option>";
            }
            return citylist;
        }

        public static String GetVillageDataList(int vid)
        {
            List<BOM.watershed_village_data> list = DAL.VillageDataDal.getVillageData(vid);
            var sorted = from cities in list orderby cities.watershed_village.Name select cities;
            var citylist = "<option value=''>select</option>";
            foreach (watershed_village_data cit in sorted)
            {
                citylist += "<option value='"+cit.vd_id+"'>" + cit.cycle_year.Year + "</option>";
            }
            return citylist;
        }

        public static watershed_village_data GetVillageDataList(watershed_village_data vil)
        {
           BOM.watershed_village_data list = DAL.VillageDataDal.getVillageDataById(vil.vd_id);
          
          
            return list;
        }


    }
}