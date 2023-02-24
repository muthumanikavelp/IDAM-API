using IEM_EmployeeRoleMapping_Model;
using IEM_EmployeeRoleMapping_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IEM_EmployeeRoleMapping_API.Controllers
{
    public class EmployeeRoleController : ApiController
    {
        string Result;
        String result = String.Empty;
        EmployeeRole_Service ObjService = new EmployeeRole_Service();//service object
        EmployeeRole_Model objmodel = new EmployeeRole_Model(); //model object

        //Employee Mapped with role

        [HttpPost]
        public string EmployeeMappedRole(EmployeeRole_Model objmodel)
        {
            Result = ObjService.RoleEmployeeSubmit(objmodel);

            if (Result == "sub")
            {
                result = "Record Inserted Successfully";
            }
            else if (Result == "rev")
            {
                result = "Role is Removed";
            }
            else if (Result == "duplicate")
            {
                result = " Duplicate Record";
            }
            else
            {
                result = Result;
            }
            return result;
        }
    }
}
