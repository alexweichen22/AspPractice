using System.Web;
using System.Web.Mvc;

namespace Z03_MVC_Conversion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
