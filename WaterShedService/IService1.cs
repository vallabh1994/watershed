using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WaterShedService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        BOM.User doLogin(BOM.User user);

        [OperationContract]
        Boolean doRegister(BOM.User user);

        [OperationContract]
        String ForgetPassword(BOM.User users);

        [OperationContract]
        bool ChangePassword(BOM.User user, String pass);

        [OperationContract]
        BOM.watershed_crop doGetCrop(BOM.watershed_crop crop);

        [OperationContract]
        List<BOM.watershed_crop> doGetCropList();

        [OperationContract]
        bool doRemoveCrop(BOM.watershed_crop crop);

        [OperationContract]
        bool doAddCrop(BOM.watershed_crop crop);

      
        [OperationContract]
        List<BOM.watershed_state> GetAllStates();

        [OperationContract]
        bool AddPolicy(BOM.watershed_policy policy);
    }



}
