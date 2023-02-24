using System.Web;
using System.Web.Mvc;

namespace IEM_EmployeeRoleMapping_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
