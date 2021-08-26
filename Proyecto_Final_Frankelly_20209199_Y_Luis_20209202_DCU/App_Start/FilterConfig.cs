using System.Web;
using System.Web.Mvc;

namespace Proyecto_Final_Frankelly_20209199_Y_Luis_20209202_DCU
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
