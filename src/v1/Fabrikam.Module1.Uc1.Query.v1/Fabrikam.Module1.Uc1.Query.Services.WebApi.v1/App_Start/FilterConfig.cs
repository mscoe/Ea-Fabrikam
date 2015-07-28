using System.Web;
using System.Web.Mvc;

namespace Fabrikam.Module1.Uc1.Query.Services.WebApi.v1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
