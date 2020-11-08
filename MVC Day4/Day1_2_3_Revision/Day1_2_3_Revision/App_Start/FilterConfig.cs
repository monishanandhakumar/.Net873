using System.Web;
using System.Web.Mvc;

namespace Day1_2_3_Revision
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
