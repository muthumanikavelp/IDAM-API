using IEM_EmployeeRoleMapping_DataModel;
using IEM_EmployeeRoleMapping_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEM_EmployeeRoleMapping_Service
{
   public class EmployeeRole_Service
    {
        string Result;
        EmployeeRole_Model objmodel = new EmployeeRole_Model(); //model object
        EmployeeRole_DataModel ObjDatamodel = new EmployeeRole_DataModel(); //datamodel object

        //Employee mapped Role  service
        public string RoleEmployeeSubmit(EmployeeRole_Model objmodel)
        {
            Result = ObjDatamodel.RoleEmployeeSubmit(objmodel);
            return Result;
        }
    }
}
