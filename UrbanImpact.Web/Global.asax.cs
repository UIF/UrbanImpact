using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using UrbanImpact.Web.App_Start;
using UrbanImpact.Data;

namespace UrbanImpact.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start()
        {
            if (User.Identity.IsAuthenticated)
            {
                using (AccountDataManager dm = new AccountDataManager())
                {
                    var staff = dm.GetStaff(User.Identity.Name);
                    Session["FirstName"] = staff.FirstName;
                    Session["LastName"] = staff.LastName;
                    Session["Department"] = staff.Department;
                }
            }
        }
    }
}
