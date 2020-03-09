using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPlantilla.Controllers
{
    public class EliminarController : Controller
    {
        //
        // GET: /Eliminar/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult delete(int idVideo)
        {
            return View();
        }

    }
}
