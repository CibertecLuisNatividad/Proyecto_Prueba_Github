using System.Web;
using System.Web.Mvc;

namespace Proyecto_Prueba_Github
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
