using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace System.Web.Mvc
{
    public static class UIFExtensions
    {
        public static string OldSite(this HtmlHelper<dynamic> helper, string pageUrl = "")
        {
            return OldSite(pageUrl);
        }

        public static string OldSite(string pageUrl)
        {
            return String.Format("{0}{1}?Security=Good&lastname={2}&firstname={3}&Dept={4}", ConfigurationManager.AppSettings["oldSiteBaseUrl"], pageUrl, HttpContext.Current.Session["LastName"], HttpContext.Current.Session["FirstName"], HttpContext.Current.Session["Department"]);
        }

        public static string OldSiteHomeLink()
        {
            return String.Format("{0}{1}?Security=Good&lastname={2}&firstname={3}&Dept={4}", ConfigurationManager.AppSettings["oldSiteBaseUrl"], "menutest.aspx", HttpContext.Current.Session["LastName"], HttpContext.Current.Session["FirstName"], HttpContext.Current.Session["Department"]);
        }
    }
}