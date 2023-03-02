using System.Web;
using System.Web.Mvc;

namespace web_profile_MVC_VS2019
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
