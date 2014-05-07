using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchApiWebRole.Controllers
{
    public class ImportController : Controller
    {
        //
        // GET: /Import/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Stations()
        {
            Services.ImportService service = new Services.ImportService();
            service.ImportStations();
            return View();
        }

        public ActionResult Traffic()
        {
            Services.ImportService service = new Services.ImportService();
            service.ImportTraffic();
            return View();
        }

        public ActionResult Estates()
        {
            Services.ImportService service = new Services.ImportService();
            service.ImportEstates();
            return View();
        }

    }
}
