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
    public class EmployeeMasterController : ApiController
    {
        ErrorLog objerr = new ErrorLog();
        //Employee Master
        [HttpPost]
        public List<EmployeeMaster_Model> EmployeeList()
        {
            objerr.WriteErrorLog("method started", "");
            try
            {
                List<EmployeeMaster_Model> employeelist = new List<EmployeeMaster_Model>();//employee model list
                EmployeeMaster_Model emp = new EmployeeMaster_Model();//employee model object
                EmployeeMaster_Service ObjService = new EmployeeMaster_Service();//employee Service obj

                employeelist = ObjService.EmployeeList().ToList();

                return employeelist;
            }
            catch (Exception ex)
            {
                objerr.WriteErrorLog(ex.ToString(),"catch method");
                objerr.WriteErrorLog("method catch", ex.ToString());
                throw ex;
            }
        }
    }
}
