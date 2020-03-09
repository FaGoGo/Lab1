using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class AgregarController : Controller
    {
        //
        // GET: /Agregar/

        public ActionResult Index()
        {
            return View();

        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(int idVideo,
                                    string titulo,
                                    string repro,
                                    string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("Insert Into video " +
                                         "values(@idVideo,@titulo," +
                                         "@repro, @url)",
                                        CommandType.Text,
                                        parametros);

            return RedirectToAction("Index", "Agregar");
        }

    }
}
