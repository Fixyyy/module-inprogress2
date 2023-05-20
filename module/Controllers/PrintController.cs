using inprogress.dnn.module.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inprogress.dnn.module.Controllers
{
    public class PrintController : Controller
    {
        // GET: Print
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                // Fájl feltöltése és adatok kezelése

                // Példa: Fájlnév mentése a modellbe
                var model = new PrintModel();
                model.FileName = file.FileName;

                // Átirányítás a részletek nézetre
                return RedirectToAction("Details", model);
            }

            // Visszatérés az Index nézetre, ha nem történt fájl feltöltés
            return View("Index");
        }

        public ActionResult Details(PrintModel model)
        {
            // Adatok kezelése és kalkuláció

            return View(model);
        }
    }
}