using System.Web;
using System.Web.Mvc;

namespace System_Controle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Add Authorize user role
            filters.Add(new AuthorizeAttribute());
            //Access https only
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
