using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
   public class Crop
    {
        public static bool AddCrop(BOM.watershed_crop crop)
        {
           bool status= DAL.CropDal.AddCrop(crop);
            return status;
        }

        public static BOM.watershed_crop GetCrop(BOM.watershed_crop crop)
        {
            return DAL.CropDal.GetCrop(crop);
        }

        public static List<BOM.watershed_crop> GetCropList()
        {
            return DAL.CropDal.GetListCrop();
        }

        public static bool RemoveCrop(BOM.watershed_crop crop)
        {
            return DAL.CropDal.RemoveCrop(crop);
        }

    }
}
