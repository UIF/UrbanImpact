using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrbanImpact.Web.Models;
using UrbanImpact.Data;
using System.Web.Security;

namespace UrbanImpact.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return Redirect("~/Account/Login");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl = "")
        {
            using (AccountDataManager dm = new AccountDataManager())
            {
                if (ModelState.IsValid)
                {
                    var staff = dm.Login(model.UserName, model.Password);

                    Session["FirstName"] = staff.FirstName;
                    Session["LastName"] = staff.LastName;
                    Session["Department"] = staff.Department;

                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                       return Redirect(UIFExtensions.OldSite("MenuTest.aspx"));
                    }
                    return RedirectToLocal(returnUrl);
                }
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(model);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

    }
}
