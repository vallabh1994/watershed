using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOM;
using System.Data.Entity.Validation;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace DAL
{
   public class VillageDataDal
    {
        private static String constr { get; set; }
        static VillageDataDal(){
           constr= @"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=watershed";
            }


        public static MySqlConnection GetMySqlCon()
        {
            MySqlConnection con = new MySqlConnection(constr);
            return con;
        }
        public static MySqlCommand GetMySqlCommand(MySqlConnection con)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            return cmd;
        }

        public static List<BOM.watershed_state> getAllStates()
        {
            watershedEntities db = new watershedEntities();
            List<watershed_state> list = new List<watershed_state>();
            try
            {
                foreach(watershed_state st in db.watershed_state)
                {
                    list.Add(st);
                }
                return list;
            }catch(DbEntityValidationException ex)
            {
                return null;
            }
            
        }

        public static List<BOM.watershed_city> getAllCitites(int sid)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_city where u.sid == sid select u).ToList();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }

        }

        public static List<BOM.watershed_taluka> getAllTalukas(int cid)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_taluka where u.cid == cid select u).ToList();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }

        }

        public static List<BOM.watershed_village> getAllVillages(int tid)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_village where u.tid == tid select u).ToList();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }

        }


        public static List<BOM.watershed_village_data> getVillageData(int vid)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_village_data where u.village_id == vid select u).ToList();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }

        }

        public static BOM.watershed_village_data getVillageData(int vid,DateTime cycle)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_village_data where u.village_id == vid && u.cycle_year.Year==cycle.Year  select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }

        }

        public static BOM.watershed_village_data getVillageDataById(int? vid)
        {
            watershedEntities db = new watershedEntities();

            try
            {
                return (from u in db.watershed_village_data where u.vd_id == vid select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }

        }


        public static watershed_taluka getTalukaById(int tid)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_taluka where u.tid == tid select u).SingleOrDefault();
            }
            catch(DbEntityValidationException ex)
            {
                return null;
            }
        }

        public static watershed_taluka getTaluka(watershed_taluka tal)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_taluka where u.Name == tal.Name && u.cid==tal.cid select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }


        public static watershed_city getCityById(int cid)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_city where u.cid == cid select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }

        public static watershed_city getCity(watershed_city city)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_city where u.cname == city.cname && u.sid==city.sid select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }

        public static watershed_village getVillage(watershed_village vil)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_village where u.Name == vil.Name && u.tid==vil.tid select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }

        public static watershed_village getVillageById(int vil)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_village where u.vid == vil select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }

        public static BOM.watershed_state getStatesByName(String name)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_state where u.sname.Equals(name) select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }

        }


        public static bool AddVillage(watershed_village vil)
        {
            watershedEntities db = new watershedEntities();
            if (null == getVillage(vil))
            {
                try
                {
                    db.watershed_village.Add(vil);
                    db.SaveChanges();
                    
                }catch(DbEntityValidationException ex)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool AddState(watershed_state state)
        {
            watershedEntities db = new watershedEntities();
            if (null==getStatesByName(state.sname))
            {
                try
                {
                    db.watershed_state.Add(state);
                    db.SaveChanges();
                }catch(DbEntityValidationException ex)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool AddCity(watershed_city city)
        {
            watershedEntities db = new watershedEntities();
            if (null == getCity(city))
            {
                try
                {
                    db.watershed_city.Add(city);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool AddTaluka(watershed_taluka city)
        {
            watershedEntities db = new watershedEntities();
            if (null == getTaluka(city))
            {
                try
                {
                    db.watershed_taluka.Add(city);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static watershed_city_data GetCityData(watershed_city_data city)
        {
            watershedEntities db = new watershedEntities();
            try
            {
                return (from u in db.watershed_city_data where u.watershed_city.cid==city.watershed_city.cid && u.cycle_year.Equals(city.cycle_year) select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }

        public static watershed_taluka_data GetTalukaData(watershed_taluka_data city)
        {
    
            watershedEntities db = new watershedEntities();
            try
            {
              
                return (from u in db.watershed_taluka_data where u.tal_id == city.tal_id && u.cycle_year.Equals(city.cycle_year) select u).SingleOrDefault();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }

        public static bool AddVillageData(watershed_village_data city)
        {
            int i = 0;
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            watershedEntities db = new watershedEntities();
            if (null == getVillageData(city.village_id,city.cycle_year))
            {
                try
                {
                     con = GetMySqlCon();
                     cmd=  GetMySqlCommand(con);
                    con.Open();
                    cmd.CommandText = "insert into watershed_village_data (village_id,population,waterreq,rainfall,wateravail,water_sarcacity,cycle_year,livestock,num_families) values(?village_id,?population,?waterreq,?rainfall,?wateravail,?water_sarcacity,?cycle_year,?livestock,?num_families)";
                    cmd.Parameters.Add(new MySqlParameter("village_id",city.village_id));
                    cmd.Parameters.Add(new MySqlParameter("population", city.population));
                    cmd.Parameters.Add(new MySqlParameter("waterreq", city.waterreq));
                    cmd.Parameters.Add(new MySqlParameter("rainfall", city.rainfall));
                    cmd.Parameters.Add(new MySqlParameter("wateravail", city.wateravail));
                    cmd.Parameters.Add(new MySqlParameter("water_sarcacity", city.water_sarcacity));
                    cmd.Parameters.Add(new MySqlParameter("cycle_year", city.cycle_year));
                    cmd.Parameters.Add(new MySqlParameter("livestock", city.livestock));
                    cmd.Parameters.Add(new MySqlParameter("num_families", city.num_families));
                   i= cmd.ExecuteNonQuery();
                }
                catch (DbEntityValidationException ex)
                {
                    return false;
                }
                finally
                {
                    if (null != con)
                        con.Close();
                }
              
            }
            if (i > 0)
                return true;

            return false;
        }

        public static List<watershed_policy> GetPolicyYear(watershed_village_data city)
        {
            watershedEntities db = new watershedEntities();
            String year = Convert.ToString(city.cycle_year.Year);
            try
            {

                return (from u in db.watershed_policy where u.vd_id == city.vd_id && u.year.Equals(year) select u).ToList();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }
        public static List<watershed_policy> GetPolicyList(watershed_village_data city)
        {
            watershedEntities db = new watershedEntities();
      
            try
            {

                return (from u in db.watershed_policy where u.vd_id == city.vd_id select u).ToList();
            }
            catch (DbEntityValidationException ex)
            {
                return null;
            }
        }


    }
}
