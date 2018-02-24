using System.Web;
using System.Web.Mvc;
using MyMVCApp.CustomActionFilters;

namespace MyMVCApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LoggingFilter());
        }
    }
}
