using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrbanImpact.Data;
using UrbanImpact.Web.Models;

namespace UrbanImpact.Web.Controllers
{
    public class OptionsController : Controller
    {
        public List<BreadCrumb> BaseBreadCrumbs { 
            get {
                var urlHelper = new UrlHelper(this.ControllerContext.RequestContext);
                var breadCrumbs = new List<BreadCrumb>();
                breadCrumbs.Add(new BreadCrumb() { Text = "Home", Link = UIFExtensions.OldSiteHomeLink(), OrderId = 0 });
                breadCrumbs.Add(new BreadCrumb() { Text = "Systems", Link = "#", OrderId = 1 });
                breadCrumbs.Add(new BreadCrumb() { Text = "Options", Link = urlHelper.Action("Index") , OrderId = 2 });
                return breadCrumbs;
            } 
        }

        //
        // GET: /Options/
        [Authorize]
        public ActionResult Index()
        {
            ViewData["breadcrumbs"] = BaseBreadCrumbs;
            using (var dm = new OptionsDataManager())
            {
                var listOfOptions = dm.Get();
                return View(listOfOptions);
            }
        }

        [Authorize]
        public ActionResult Edit(int id = 0)
        {
            var breadCrumbs = BaseBreadCrumbs;
            using (var dm = new OptionsDataManager())
            {
                var optionModel = dm.Get();
                
                breadCrumbs.Add(new BreadCrumb() { Text = "Student, Name", OrderId = 3 });
                ViewData["breadcrumbs"] = breadCrumbs;
                return View();
            }
        }

    }
}
