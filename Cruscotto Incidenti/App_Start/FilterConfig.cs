using System.Web;
using System.Web.Mvc;

namespace Cruscotto_Incidenti
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
