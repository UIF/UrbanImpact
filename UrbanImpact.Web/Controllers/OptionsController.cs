using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrbanImpact.Web.Controllers
{
    public class OptionsController : Controller
    {
        //
        // GET: /Options/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

    }
}
