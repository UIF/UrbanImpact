using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrbanImpact.Data;

namespace UrbanImpact.Web.Controllers
{
    public class OptionsController : Controller
    {
        //
        // GET: /Options/
        [Authorize]
        public ActionResult Index()
        {
            using (var dm = new OptionsDataManager())
            {
                var listOfOptions = dm.Get();
                return View(listOfOptions);
            }
        }

    }
}
