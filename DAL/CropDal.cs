using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOM;
using  System.Data.Entity.Validation;

namespace DAL
{
    public class CropDal
    {
    
      
        public static watershed_crop GetCrop(BOM.watershed_crop crop)
        {
            watershedEntities db = new watershedEntities();
            var st = (from u in db.watershed_crop where (u.cname == crop.cname && u.type == crop.type) select u).SingleOrDefault();
            return st;
        }
        public static bool AddCrop(BOM.watershed_crop crop)
        {
            watershedEntities db = new watershedEntities();

                if (null == GetCrop(crop))
                {
                try
                {
                    db.watershed_crop.Add(crop);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {

                    return false;
                }
            }
            return true;
        }

        public static List<watershed_crop> GetListCrop()
        {
            watershedEntities db = new watershedEntities();
            var list=db.watershed_crop.ToList();
            
            return list;
        }

        public static bool RemoveCrop(BOM.watershed_crop cr)
        {
            watershedEntities db = new watershedEntities();
            try {
                BOM.watershed_crop crop = db.watershed_crop.Remove(cr);
                db.SaveChanges();
                if (null == crop)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }catch(DbEntityValidationException ex)
            {
                return false;
            }

        }


    }
}
