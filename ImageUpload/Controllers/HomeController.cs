using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file != null)
            {
                ViewBag.Message = "Imagem Carregada";
            }
            else
            {
                ViewBag.Message = "Erro no Upload";
            }
            return View();
        }

    }
}