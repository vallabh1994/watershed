using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
   public class VillageBOL
    {
        public static List<BOM.watershed_village> GetAllVillage(int tid)
        {
            return DAL.VillageDataDal.getAllVillages(tid);
        }
        public static List<BOM.watershed_state> GetAllState()
        {
            return DAL.VillageDataDal.getAllStates();
        }
        public static List<BOM.watershed_city> GetAllCity(int sid)
        {
            return DAL.VillageDataDal.getAllCitites(sid);
        }
        public static List<BOM.watershed_taluka> GetAllTaluka(int cid)
        {
            return DAL.VillageDataDal.getAllTalukas(cid);
        }
        public static bool AddPolicy(BOM.watershed_policy policy)
        {
           return DAL.VillageDataDal.AddPolicy(policy);
        }
    }
}
