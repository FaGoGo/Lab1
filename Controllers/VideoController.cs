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
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {

            ViewData["video"] = BaseHelper.ejecutarSentencia("select * from video", CommandType.Text);


            return View();
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(int idVideo, string titulo, int repro,string url)

        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("insert into video values (@idVideo, @titulo, @repro, @url)", CommandType.Text, parametros);
            return View();
        }
        public ActionResult delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult delete(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idvideo", idVideo));

            BaseHelper.ejecutarSentencia("Delete from video where IdVideo = @idvideo", CommandType.Text, parametros);

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
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("UPDATE video SET idVideo = @idVideo, titulo = @titulo, repro = @repro, url = @url WHERE IdVideo = @idvideo", CommandType.Text, parametros);

            return View();
        }
    }
}
