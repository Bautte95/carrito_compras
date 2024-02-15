using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidad;
using Negocio;

namespace administrador.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListadoUsuarios()
        {
            List<Usuario> oLista = new CN_Usuarios().Listar();
            return Json(new { data = oLista}, JsonRequestBehavior.AllowGet);
        }
    }
}