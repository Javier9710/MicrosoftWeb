using System.Web;
using System.Web.Mvc;

namespace ejercicioWeb2._0
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new filtros.VerificarSesion());
        }
    }
}
