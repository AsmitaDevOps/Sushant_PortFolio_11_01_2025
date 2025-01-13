using System.Web;
using System.Web.Mvc;

namespace Sushant_PortFolio_11_01_2025
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
