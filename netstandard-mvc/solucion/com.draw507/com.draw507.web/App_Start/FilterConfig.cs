using com.draw507.web.Filters;
using System.Web;
using System.Web.Mvc;

namespace com.draw507.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomHandleErrorAttribute());
        }
    }
}
