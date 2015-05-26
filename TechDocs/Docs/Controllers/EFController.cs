using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Docs.Controllers
{
    public class EFController : Controller
    {
        // GET: EF
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RelationShips()
        {
            return View();
        }
    }
}