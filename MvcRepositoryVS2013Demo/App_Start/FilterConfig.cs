using System.Web;
using System.Web.Mvc;

namespace MvcRepositoryVS2013Demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
