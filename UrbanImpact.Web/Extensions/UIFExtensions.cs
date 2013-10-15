using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class UIFExtensions
    {
        public static string OldSite(this HtmlHelper<dynamic> helper, string pageurl = "")
        {
            return String.Format("http://localhost/uif/performingarts/{0}?Security=Good&lastname={1}&firstname={2}&Dept={3}",pageurl, HttpContext.Current.Session["LastName"], HttpContext.Current.Session["FirstName"], HttpContext.Current.Session["Department"]);
        
        }
    }
}