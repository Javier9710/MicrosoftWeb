using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejercicioWeb2._0.Models;
using ejercicioWeb2._0.Models.TablasDatos;
using ejercicioWeb2._0.Models.TablasModelo;

namespace ejercicioWeb2._0.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            List<UsuarioTablaDatos> lst = null;
            using (ejercicioWebEntities1 db = new ejercicioWebEntities1())
            {
                lst = (from d in db.user
                       where d.idState == 1
                       orderby d.email
                       select new UsuarioTablaDatos
                       {
                           Email = d.email,
                           Id = d.id,
                           Edad = d.edad


                       }).ToList();
            }
                return View(lst);
        }
        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Add (UsuarioTablasModelo model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db=new ejercicioWebEntities1())
            {
                user oUser = new user();
                oUser.idState = 1;
                oUser.email = model.Email;
                oUser.edad = model.Edad;
                oUser.password = model.Password;

                db.user.Add(oUser);
                db.SaveChanges();

            }
            return Redirect(Url.Content("~/Usuario/"));


        }

    }


}