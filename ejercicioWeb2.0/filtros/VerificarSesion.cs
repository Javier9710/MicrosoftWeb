using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejercicioWeb2._0.Controllers;
using ejercicioWeb2._0.Models;

namespace ejercicioWeb2._0.filtros
{
    public class VerificarSesion : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var usuario = (user)HttpContext.Current.Session["User"];
            if (usuario==null)
            {
                if (filterContext.Controller is AccessController==false) {

                    filterContext.HttpContext.Response.Redirect("~/Access/Index");

                }

            }
            else
            {
                if (filterContext.Controller is AccessController == true)
                {

                    filterContext.HttpContext.Response.Redirect("~/Home/Index");

                }

            }

            base.OnActionExecuting(filterContext);
        }

    }
}