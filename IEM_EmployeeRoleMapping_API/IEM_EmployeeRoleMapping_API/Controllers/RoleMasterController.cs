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
    public class RoleMasterController : ApiController
    {
        // Role Master
        [HttpPost]
        public List<RoleMaster_Model> RoleList()
        {
            try
            {
                List<RoleMaster_Model> rolelist = new List<RoleMaster_Model>();//role model list
                RoleMaster_Model rol = new RoleMaster_Model();//role model object
                RoleMaster_Service ObjService = new RoleMaster_Service();//role Service obj
                rolelist = ObjService.RoleList().ToList();
                return rolelist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
