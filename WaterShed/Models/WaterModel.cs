using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BOM;
namespace WaterShed.Models
{
    public class WaterModel
    {
        public static BOM.watershed_village_data VillageData(watershed_village_data data)
        {
            double catchment = data.wateravail;
            double evaporation = data.water_sarcacity;
            data.watershed_village=DAL.VillageDataDal.getVillageById(data.village_id);
            double hectre = data.watershed_village.Area* 100;
            double m2 = hectre * 100;

            //water available
            data.wateravail = (m2 * ((data.rainfall * 1000)-(evaporation*1000)));//in litres

            data.waterreq = GetWaterBudget(data).total;

            data.water_sarcacity = data.wateravail - data.waterreq;

            return data;
        }
        public static WaterShed.Models.WaterBugest GetWaterBudget(watershed_village_data data)
        {
            //1 gallon 3.785 liter 
            //50 bath per gallon
            int population = data.population;
            WaterBugest refs= new WaterBugest { Bath=(population*0.14*50* 3.78541),Toilet=(population * 0.14 * 1.6 * 3.78541),clothwashing=(population * 0.14 * 40 * 3.78541),dishwashing=(population * 0.14 * 8.5 * 3.78541),livestock=((double)data.livestock*50) };
            refs.total = (refs.Bath + refs.clothwashing + refs.dishwashing + refs.Toilet+refs.livestock) * 365;//for year
            return refs;
        }

    }
}