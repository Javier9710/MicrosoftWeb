using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ejercicioWeb2._0.Models;

namespace ejercicioWeb2._0.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Enter(String user, String password)
         {
            try
            {
                using (ejercicioWebEntities1 db = new ejercicioWebEntities1())
                {
                    var lst = from d in db.user
                              where d.email == user && d.password == password && d.idState == 1
                              select d;
                    if (lst.Count()>0)
                    {
                        user oUser = lst.First();
                        Session["User"] = oUser;
                        return Content("1");

                    }
                    else
                    {
                        return Content("Usuario Invalido");
                    }

                }
                 

            }
            catch (Exception ex)
            {
                return Content("Ocurrio Algun Error " + ex.Message);

            }

        }

    }

}