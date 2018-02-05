using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BOM;

namespace WaterShedService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        bool IService1.AddPolicy(watershed_policy policy)
        {
            return BOL.VillageBOL.AddPolicy(policy);
        }

        bool IService1.ChangePassword(User user, string pass)
        {
            return BOL.Authentication.ChangePassword(user,pass);
        }

        bool IService1.doAddCrop(watershed_crop crop)
        {
            return BOL.Crop.AddCrop(crop);
        }

        watershed_crop IService1.doGetCrop(watershed_crop crop)
        {
            return BOL.Crop.GetCrop(crop);
        }

        List<watershed_crop> IService1.doGetCropList()
        {
            return BOL.Crop.GetCropList();
        }
      
        User IService1.doLogin(User user)
        {
            return BOL.Authentication.Login(user);
        }

        bool IService1.doRegister(User user)
        {
            return BOL.Authentication.Register(user);
        }

        bool IService1.doRemoveCrop(watershed_crop crop)
        {
            return BOL.Crop.RemoveCrop(crop);
        }

        string IService1.ForgetPassword(User users)
        {
            return BOL.Authentication.ForgetPassword(users);
        }

        List<BOM.watershed_state> IService1.GetAllStates()
        {
            return BOL.VillageBOL.GetAllState();
        }

     
    }
}
