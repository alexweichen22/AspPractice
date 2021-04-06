using System.Web;
using System.Web.Mvc;

namespace S05B_MVC_Auth
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
