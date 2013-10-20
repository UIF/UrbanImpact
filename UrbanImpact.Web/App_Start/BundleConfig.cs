﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace UrbanImpact.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap/bootstrap.css",
                "~/Content/bootstrap-theme.min.css", 
                "~/Content/bootstrap-responsive.min.css",
                "~/Content/css/uif.css"));
        }
    }
}