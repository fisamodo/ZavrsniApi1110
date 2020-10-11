using System.Web;
using System.Web.Mvc;

namespace ZavrsniApi1110
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
