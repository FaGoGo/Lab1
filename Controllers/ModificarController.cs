using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPlantilla.Controllers
{
    public class ModificarController : Controller
    {
        //
        // GET: /Modificar/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult edit(int idVideo,
                                    string titulo,
                                    int repro,
                                    string url)
        {
            return View();
        }

    }
}
